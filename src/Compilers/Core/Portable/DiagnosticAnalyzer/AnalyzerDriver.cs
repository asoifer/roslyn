// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class AnalyzerDriver : IDisposable
    {
        private const int
        MaxSymbolKind = 100
        ;

        private static readonly Func<DiagnosticAnalyzer, bool> s_IsCompilerAnalyzerFunc;

        private static readonly Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> s_getTopmostNodeForAnalysis;

        private readonly Func<SyntaxTree, CancellationToken, bool> _isGeneratedCode;

        private readonly ConcurrentSet<Suppression>? _programmaticSuppressions;

        private readonly ConcurrentSet<Diagnostic>? _diagnosticsProcessedForProgrammaticSuppressions;

        private readonly bool _hasDiagnosticSuppressors;

        private readonly SeverityFilter _severityFilter;

        protected ImmutableArray<DiagnosticAnalyzer> Analyzers { get; }

        protected AnalyzerManager AnalyzerManager { get; }

        private CancellationTokenRegistration? _lazyQueueRegistration;

        private AnalyzerExecutor? _lazyAnalyzerExecutor;

        protected AnalyzerExecutor AnalyzerExecutor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 3161, 3303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3197, 3241);

                    f_222_3197_3240(_lazyAnalyzerExecutor != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3259, 3288);

                    return _lazyAnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 3161, 3303);

                    int
                    f_222_3197_3240(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 3197, 3240);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 3093, 3314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 3093, 3314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CompilationData? _lazyCurrentCompilationData;

        protected CompilationData CurrentCompilationData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 3462, 3616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3498, 3548);

                    f_222_3498_3547(_lazyCurrentCompilationData != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3566, 3601);

                    return _lazyCurrentCompilationData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 3462, 3616);

                    int
                    f_222_3498_3547(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 3498, 3547);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 3389, 3627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 3389, 3627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected CachingSemanticModelProvider SemanticModelProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 3700, 3747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3703, 3747);
                    return f_222_3703_3747(f_222_3703_3725()); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 3700, 3747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 3700, 3747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 3700, 3747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected ref readonly AnalyzerActions AnalyzerActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 3815, 3842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3818, 3842);
                    return ref _lazyAnalyzerActions; DynAbs.Tracing.TraceSender.TraceExitMethod(222, 3815, 3842);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 3815, 3842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 3815, 3842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableHashSet<DiagnosticAnalyzer>? _lazyUnsuppressedAnalyzers;

        protected ImmutableHashSet<DiagnosticAnalyzer> UnsuppressedAnalyzers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 4143, 4295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 4179, 4228);

                    f_222_4179_4227(_lazyUnsuppressedAnalyzers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 4246, 4280);

                    return _lazyUnsuppressedAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 4143, 4295);

                    int
                    f_222_4179_4227(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 4179, 4227);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 4050, 4306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 4050, 4306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConcurrentDictionary<(INamespaceOrTypeSymbol, DiagnosticAnalyzer), IGroupedAnalyzerActions>? _lazyPerSymbolAnalyzerActionsCache;

        private ConcurrentDictionary<(INamespaceOrTypeSymbol, DiagnosticAnalyzer), IGroupedAnalyzerActions> PerSymbolAnalyzerActionsCache
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 5129, 5297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 5165, 5222);

                    f_222_5165_5221(_lazyPerSymbolAnalyzerActionsCache != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 5240, 5282);

                    return _lazyPerSymbolAnalyzerActionsCache;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 5129, 5297);

                    int
                    f_222_5165_5221(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 5165, 5221);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 4975, 5308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 4975, 5308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<ImmutableArray<SymbolAnalyzerAction>>)> _lazySymbolActionsByKind;

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<SemanticModelAnalyzerAction>)> _lazySemanticModelActions;

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<SyntaxTreeAnalyzerAction>)> _lazySyntaxTreeActions;

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<AdditionalFileAnalyzerAction>)> _lazyAdditionalFileActions;

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<CompilationAnalyzerAction>)> _lazyCompilationActions;

        private ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<CompilationAnalyzerAction>)> _lazyCompilationEndActions;

        private ImmutableHashSet<DiagnosticAnalyzer>? _lazyCompilationEndAnalyzers;

        private ImmutableHashSet<DiagnosticAnalyzer> CompilationEndAnalyzers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 6436, 6592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 6472, 6523);

                    f_222_6472_6522(_lazyCompilationEndAnalyzers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 6541, 6577);

                    return _lazyCompilationEndAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 6436, 6592);

                    int
                    f_222_6472_6522(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 6472, 6522);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 6343, 6603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 6343, 6603);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal const GeneratedCodeAnalysisFlags
        DefaultGeneratedCodeAnalysisFlags = GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics
        ;

        private ImmutableDictionary<DiagnosticAnalyzer, SemaphoreSlim>? _lazyAnalyzerGateMap;

        private ImmutableDictionary<DiagnosticAnalyzer, SemaphoreSlim> AnalyzerGateMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 7541, 7681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 7577, 7620);

                    f_222_7577_7619(_lazyAnalyzerGateMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 7638, 7666);

                    return _lazyAnalyzerGateMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 7541, 7681);

                    int
                    f_222_7577_7619(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 7577, 7619);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 7438, 7692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 7438, 7692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags>? _lazyGeneratedCodeAnalysisFlagsMap;

        private ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags> GeneratedCodeAnalysisFlagsMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 8097, 8265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 8133, 8190);

                    f_222_8133_8189(_lazyGeneratedCodeAnalysisFlagsMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 8208, 8250);

                    return _lazyGeneratedCodeAnalysisFlagsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 8097, 8265);

                    int
                    f_222_8133_8189(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 8133, 8189);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 7967, 8276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 7967, 8276);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private AnalyzerActions _lazyAnalyzerActions;

        private ImmutableHashSet<DiagnosticAnalyzer>? _lazyNonConfigurableAnalyzers;

        private ImmutableHashSet<DiagnosticAnalyzer> NonConfigurableAnalyzers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 8861, 9019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 8897, 8949);

                    f_222_8897_8948(_lazyNonConfigurableAnalyzers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 8967, 9004);

                    return _lazyNonConfigurableAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 8861, 9019);

                    int
                    f_222_8897_8948(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 8897, 8948);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 8767, 9030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 8767, 9030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableHashSet<DiagnosticAnalyzer>? _lazySymbolStartAnalyzers;

        private ImmutableHashSet<DiagnosticAnalyzer> SymbolStartAnalyzers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 9346, 9496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9382, 9430);

                    f_222_9382_9429(_lazySymbolStartAnalyzers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9448, 9481);

                    return _lazySymbolStartAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 9346, 9496);

                    int
                    f_222_9382_9429(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 9382, 9429);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 9256, 9507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 9256, 9507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _lazyTreatAllCodeAsNonGeneratedCode;

        private bool TreatAllCodeAsNonGeneratedCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 9839, 10016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9875, 9934);

                    f_222_9875_9933(f_222_9888_9932(_lazyTreatAllCodeAsNonGeneratedCode));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9952, 10001);

                    return f_222_9959_10000(_lazyTreatAllCodeAsNonGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 9839, 10016);

                    bool
                    f_222_9888_9932(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 9888, 9932);
                        return return_v;
                    }


                    int
                    f_222_9875_9933(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 9875, 9933);
                        return 0;
                    }


                    bool
                    f_222_9959_10000(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 9959, 10000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 9771, 10027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 9771, 10027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool? _lazyDoNotAnalyzeGeneratedCode;

        private ConcurrentDictionary<SyntaxTree, bool>? _lazyGeneratedCodeFilesMap;

        private ConcurrentDictionary<SyntaxTree, bool> GeneratedCodeFilesMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 10687, 10839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 10723, 10772);

                    f_222_10723_10771(_lazyGeneratedCodeFilesMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 10790, 10824);

                    return _lazyGeneratedCodeFilesMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 10687, 10839);

                    int
                    f_222_10723_10771(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 10723, 10771);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 10594, 10850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 10594, 10850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<SyntaxTree, ImmutableHashSet<ISymbol>>? _lazyGeneratedCodeSymbolsForTreeMap;

        private Dictionary<SyntaxTree, ImmutableHashSet<ISymbol>> GeneratedCodeSymbolsForTreeMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 11229, 11399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 11265, 11323);

                    f_222_11265_11322(_lazyGeneratedCodeSymbolsForTreeMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 11341, 11384);

                    return _lazyGeneratedCodeSymbolsForTreeMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 11229, 11399);

                    int
                    f_222_11265_11322(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 11265, 11322);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 11116, 11410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 11116, 11410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConcurrentDictionary<SyntaxTree, ImmutableHashSet<DiagnosticAnalyzer>>? _lazySuppressedAnalyzersForTreeMap;

        private ConcurrentDictionary<SyntaxTree, ImmutableHashSet<DiagnosticAnalyzer>> SuppressedAnalyzersForTreeMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 11833, 12001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 11869, 11926);

                    f_222_11869_11925(_lazySuppressedAnalyzersForTreeMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 11944, 11986);

                    return _lazySuppressedAnalyzersForTreeMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 11833, 12001);

                    int
                    f_222_11869_11925(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 11869, 11925);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 11700, 12012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 11700, 12012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConcurrentDictionary<ISymbol, bool>? _lazyIsGeneratedCodeSymbolMap;

        private ConcurrentDictionary<ISymbol, bool> IsGeneratedCodeSymbolMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 12359, 12517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 12395, 12447);

                    f_222_12395_12446(_lazyIsGeneratedCodeSymbolMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 12465, 12502);

                    return _lazyIsGeneratedCodeSymbolMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 12359, 12517);

                    int
                    f_222_12395_12446(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 12395, 12446);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 12266, 12528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 12266, 12528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConcurrentDictionary<SyntaxTree, bool>? _lazyTreesWithHiddenRegionsMap;

        private INamedTypeSymbol? _lazyGeneratedCodeAttribute;

        private Task? _lazyInitializeTask;

        private bool _initializeSucceeded;

        private Task? _lazyPrimaryTask;

        private readonly int _workerCount;

        private AsyncQueue<CompilationEvent>? _lazyCompilationEventQueue;

        public AsyncQueue<CompilationEvent> CompilationEventQueue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 14247, 14399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14283, 14332);

                    f_222_14283_14331(_lazyCompilationEventQueue != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14350, 14384);

                    return _lazyCompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 14247, 14399);

                    int
                    f_222_14283_14331(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 14283, 14331);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 14165, 14410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 14165, 14410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private DiagnosticQueue? _lazyDiagnosticQueue;

        public DiagnosticQueue DiagnosticQueue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 14683, 14823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14719, 14762);

                    f_222_14719_14761(_lazyDiagnosticQueue != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14780, 14808);

                    return _lazyDiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 14683, 14823);

                    int
                    f_222_14719_14761(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 14719, 14761);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 14620, 14834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 14620, 14834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected AnalyzerDriver(ImmutableArray<DiagnosticAnalyzer> analyzers, AnalyzerManager analyzerManager, SeverityFilter severityFilter, Func<SyntaxTrivia, bool> isComment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(222, 15423, 16491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 1607, 1623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 1827, 1852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 2068, 2116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 2377, 2402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 2763, 2778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 2864, 2914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3000, 3022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3061, 3082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3351, 3378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 3901, 3927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 4419, 4453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 6304, 6332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 7407, 7427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 7781, 7815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 8538, 8567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9088, 9113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 9533, 9568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 10223, 10253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 10314, 10340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 10921, 10956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 11502, 11536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 12069, 12098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 12820, 12850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 13022, 13049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 13264, 13283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 13453, 13481);
                this._initializeSucceeded = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 13742, 13758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 13937, 13978);
                this._workerCount = f_222_13952_13978(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14029, 14055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 14447, 14467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15618, 15684);

                f_222_15618_15683(!f_222_15632_15682(severityFilter, ReportDiagnostic.Suppress));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15698, 15763);

                f_222_15698_15762(!f_222_15712_15761(severityFilter, ReportDiagnostic.Default));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15779, 15806);

                this.Analyzers = analyzers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15820, 15859);

                this.AnalyzerManager = analyzerManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15873, 15966);

                _isGeneratedCode = (tree, ct) => GeneratedCodeUtilities.IsGeneratedCode(tree, isComment, ct);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 15980, 16013);

                _severityFilter = severityFilter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 16027, 16106);

                _hasDiagnosticSuppressors = this.Analyzers.Any(a => a is DiagnosticSuppressor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 16120, 16216);

                _programmaticSuppressions = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 16148, 16173) || ((_hasDiagnosticSuppressors && DynAbs.Tracing.TraceSender.Conditional_F2(222, 16176, 16208)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 16211, 16215))) ? f_222_16176_16208() : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 16230, 16382);

                _diagnosticsProcessedForProgrammaticSuppressions = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 16281, 16306) || ((_hasDiagnosticSuppressors && DynAbs.Tracing.TraceSender.Conditional_F2(222, 16309, 16374)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 16377, 16381))) ? f_222_16309_16374(ReferenceEqualityComparer.Instance) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 16396, 16480);

                _lazyAnalyzerGateMap = ImmutableDictionary<DiagnosticAnalyzer, SemaphoreSlim>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(222, 15423, 16491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 15423, 16491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 15423, 16491);
            }
        }

        private void Initialize(AnalyzerExecutor analyzerExecutor, DiagnosticQueue diagnosticQueue, CompilationData compilationData, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 16823, 21320);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 17045, 17087);

                    f_222_17045_17086(_lazyInitializeTask == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 17107, 17148);

                    _lazyAnalyzerExecutor = analyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 17166, 17212);

                    _lazyCurrentCompilationData = compilationData;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 17230, 17269);

                    _lazyDiagnosticQueue = diagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 17402, 20523);

                    _lazyInitializeTask = f_222_17424_20522(async () =>
                                    {
                                        (_lazyAnalyzerActions, _lazyUnsuppressedAnalyzers) = await GetAnalyzerActionsAsync(Analyzers, AnalyzerManager, analyzerExecutor, _severityFilter).ConfigureAwait(false);
                                        _lazyAnalyzerGateMap = await CreateAnalyzerGateMapAsync(UnsuppressedAnalyzers, AnalyzerManager, analyzerExecutor, _severityFilter).ConfigureAwait(false);
                                        _lazyNonConfigurableAnalyzers = ComputeNonConfigurableAnalyzers(UnsuppressedAnalyzers);
                                        _lazySymbolStartAnalyzers = ComputeSymbolStartAnalyzers(UnsuppressedAnalyzers);
                                        _lazyGeneratedCodeAnalysisFlagsMap = await CreateGeneratedCodeAnalysisFlagsMapAsync(UnsuppressedAnalyzers, AnalyzerManager, analyzerExecutor, _severityFilter).ConfigureAwait(false);
                                        _lazyTreatAllCodeAsNonGeneratedCode = ComputeShouldTreatAllCodeAsNonGeneratedCode(UnsuppressedAnalyzers, GeneratedCodeAnalysisFlagsMap);
                                        _lazyDoNotAnalyzeGeneratedCode = ComputeShouldSkipAnalysisOnGeneratedCode(UnsuppressedAnalyzers, GeneratedCodeAnalysisFlagsMap, TreatAllCodeAsNonGeneratedCode);
                                        _lazyGeneratedCodeFilesMap = TreatAllCodeAsNonGeneratedCode ? null : new ConcurrentDictionary<SyntaxTree, bool>();
                                        _lazyGeneratedCodeSymbolsForTreeMap = TreatAllCodeAsNonGeneratedCode ? null : new Dictionary<SyntaxTree, ImmutableHashSet<ISymbol>>();
                                        _lazyIsGeneratedCodeSymbolMap = TreatAllCodeAsNonGeneratedCode ? null : new ConcurrentDictionary<ISymbol, bool>();
                                        _lazyTreesWithHiddenRegionsMap = TreatAllCodeAsNonGeneratedCode ? null : new ConcurrentDictionary<SyntaxTree, bool>();
                                        _lazySuppressedAnalyzersForTreeMap = new ConcurrentDictionary<SyntaxTree, ImmutableHashSet<DiagnosticAnalyzer>>();
                                        _lazyGeneratedCodeAttribute = analyzerExecutor.Compilation?.GetTypeByMetadataName("System.CodeDom.Compiler.GeneratedCodeAttribute");

                                        _lazySymbolActionsByKind = MakeSymbolActionsByKind(in AnalyzerActions);
                                        _lazySemanticModelActions = MakeActionsByAnalyzer(AnalyzerActions.SemanticModelActions);
                                        _lazySyntaxTreeActions = MakeActionsByAnalyzer(AnalyzerActions.SyntaxTreeActions);
                                        _lazyAdditionalFileActions = MakeActionsByAnalyzer(AnalyzerActions.AdditionalFileActions);
                                        _lazyCompilationActions = MakeActionsByAnalyzer(this.AnalyzerActions.CompilationActions);
                                        _lazyCompilationEndActions = MakeActionsByAnalyzer(this.AnalyzerActions.CompilationEndActions);
                                        _lazyCompilationEndAnalyzers = MakeCompilationEndAnalyzers(_lazyCompilationEndActions);

                                        if (this.AnalyzerActions.SymbolStartActionsCount > 0)
                                        {
                                            _lazyPerSymbolAnalyzerActionsCache = new ConcurrentDictionary<(INamespaceOrTypeSymbol, DiagnosticAnalyzer), IGroupedAnalyzerActions>();
                                        }

                                    }, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 20596, 20645);

                    cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 20665, 20693);

                    _initializeSucceeded = true;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 20722, 21309);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 20762, 21294) || true) && (_lazyInitializeTask == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 20762, 21294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 20902, 20981);

                        _lazyInitializeTask = f_222_20924_20980(f_222_20942_20979(canceled: true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21069, 21145);

                        _lazyPrimaryTask = f_222_21088_21144(f_222_21106_21143(canceled: true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21240, 21275);

                        f_222_21240_21274(f_222_21240_21260(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 20762, 21294);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 20722, 21309);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 16823, 21320);

                int
                f_222_17045_17086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 17045, 17086);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_222_17424_20522(System.Func<System.Threading.Tasks.Task?>
                function, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(function, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 17424, 20522);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_20942_20979(bool
                canceled)
                {
                    var return_v = new System.Threading.CancellationToken(canceled: canceled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 20942, 20979);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_20924_20980(System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.FromCanceled(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 20924, 20980);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_21106_21143(bool
                canceled)
                {
                    var return_v = new System.Threading.CancellationToken(canceled: canceled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21106, 21143);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_21088_21144(System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.FromCanceled(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21088, 21144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_21240_21260(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 21240, 21260);
                    return return_v;
                }


                bool
                f_222_21240_21274(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param)
                {
                    var return_v = this_param.TryComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21240, 21274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 16823, 21320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 16823, 21320);
            }
        }

        internal void Initialize(
                   Compilation compilation,
                   CompilationWithAnalyzersOptions analysisOptions,
                   CompilationData compilationData,
                   bool categorizeDiagnostics,
                   CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 21332, 24513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21614, 21656);

                f_222_21614_21655(_lazyInitializeTask == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21670, 21726);

                f_222_21670_21725(f_222_21683_21716(compilation) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21742, 21810);

                var
                diagnosticQueue = f_222_21764_21809(categorizeDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21826, 21881);

                Action<Diagnostic>?
                addNotCategorizedDiagnostic = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21895, 21978);

                Action<Diagnostic, DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 21992, 22072);

                Action<Diagnostic, DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 22086, 22705) || true) && (categorizeDiagnostics)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 22086, 22705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 22145, 22299);

                    addCategorizedLocalDiagnostic = f_222_22177_22298(diagnosticQueue.EnqueueLocal, compilation, f_222_22238_22261(analysisOptions), _severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 22317, 22477);

                    addCategorizedNonLocalDiagnostic = f_222_22352_22476(diagnosticQueue.EnqueueNonLocal, compilation, f_222_22416_22439(analysisOptions), _severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 22086, 22705);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 22086, 22705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 22543, 22690);

                    addNotCategorizedDiagnostic = f_222_22573_22689(diagnosticQueue.Enqueue, compilation, f_222_22629_22652(analysisOptions), _severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 22086, 22705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 22794, 23715);

                Action<Exception, DiagnosticAnalyzer, Diagnostic>
                newOnAnalyzerException = (ex, analyzer, diagnostic) =>
                            {
                                var filteredDiagnostic = GetFilteredDiagnostic(diagnostic, compilation, analysisOptions.Options, _severityFilter, cancellationToken);
                                if (filteredDiagnostic != null)
                                {
                                    if (analysisOptions.OnAnalyzerException != null)
                                    {
                                        analysisOptions.OnAnalyzerException(ex, analyzer, filteredDiagnostic);
                                    }
                                    else if (categorizeDiagnostics)
                                    {
                                        addCategorizedNonLocalDiagnostic!(filteredDiagnostic, analyzer);
                                    }
                                    else
                                    {
                                        addNotCategorizedDiagnostic!(filteredDiagnostic);
                                    }
                                }
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 23731, 24404);

                var
                analyzerExecutor = f_222_23754_24403(compilation, f_222_23809_23832(analysisOptions) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?>(222, 23809, 23857) ?? AnalyzerOptions.Empty), addNotCategorizedDiagnostic, newOnAnalyzerException, f_222_23912_23951(analysisOptions), IsCompilerAnalyzer, f_222_23990_24005(), ShouldSkipAnalysisOnGeneratedCode, ShouldSuppressGeneratedCodeDiagnostic, IsGeneratedOrHiddenCodeLocation, IsAnalyzerSuppressedForTree, GetAnalyzerGate, getSemanticModel: GetOrCreateSemanticModel, f_222_24238_24278(analysisOptions), addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, s => _programmaticSuppressions!.Add(s), cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 24420, 24502);

                f_222_24420_24501(this, analyzerExecutor, diagnosticQueue, compilationData, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 21332, 24513);

                int
                f_222_21614_21655(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21614, 21655);
                    return 0;
                }


                Microsoft.CodeAnalysis.SemanticModelProvider?
                f_222_21683_21716(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 21683, 21716);
                    return return_v;
                }


                int
                f_222_21670_21725(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21670, 21725);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_21764_21809(bool
                categorized)
                {
                    var return_v = DiagnosticQueue.Create(categorized);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 21764, 21809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_222_22238_22261(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 22238, 22261);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                f_222_22177_22298(System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                addLocalDiagnosticCore, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetDiagnosticSink(addLocalDiagnosticCore, compilation, analyzerOptions, severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 22177, 22298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_222_22416_22439(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 22416, 22439);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_22352_22476(System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                addDiagnosticCore, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetDiagnosticSink(addDiagnosticCore, compilation, analyzerOptions, severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 22352, 22476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_222_22629_22652(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 22629, 22652);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic>
                f_222_22573_22689(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnosticCore, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetDiagnosticSink(addDiagnosticCore, compilation, analyzerOptions, severityFilter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 22573, 22689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_222_23809_23832(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 23809, 23832);
                    return return_v;
                }


                System.Func<System.Exception, bool>?
                f_222_23912_23951(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.AnalyzerExceptionFilter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 23912, 23951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_23990_24005()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 23990, 24005);
                    return return_v;
                }


                bool
                f_222_24238_24278(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.LogAnalyzerExecutionTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 24238, 24278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_23754_24403(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                analyzerOptions, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnostic, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                isCompilerAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                shouldSkipAnalysisOnGeneratedCode, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Text.TextSpan, bool>
                isGeneratedCodeLocation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?, bool>
                isAnalyzerSuppressedForTree, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, object?>
                getAnalyzerGate, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                getSemanticModel, bool
                logExecutionTime, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostics.Suppression>?
                addSuppression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = AnalyzerExecutor.Create(compilation, analyzerOptions, addNonCategorizedDiagnostic, onAnalyzerException, analyzerExceptionFilter, isCompilerAnalyzer, analyzerManager, shouldSkipAnalysisOnGeneratedCode, shouldSuppressGeneratedCodeDiagnostic, isGeneratedCodeLocation, isAnalyzerSuppressedForTree, getAnalyzerGate, getSemanticModel: getSemanticModel, logExecutionTime, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, addSuppression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 23754, 24403);
                    return return_v;
                }


                int
                f_222_24420_24501(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                diagnosticQueue, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                compilationData, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Initialize(analyzerExecutor, diagnosticQueue, compilationData, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 24420, 24501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 21332, 24513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 21332, 24513);
            }
        }

        private SemaphoreSlim? GetAnalyzerGate(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 24525, 24897);
                System.Threading.SemaphoreSlim gate = default(System.Threading.SemaphoreSlim);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 24617, 24821) || true) && (f_222_24621_24672(f_222_24621_24636(), analyzer, out gate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 24617, 24821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 24794, 24806);

                    return gate;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 24617, 24821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 24874, 24886);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 24525, 24897);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>
                f_222_24621_24636()
                {
                    var return_v = AnalyzerGateMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 24621, 24636);
                    return return_v;
                }


                bool
                f_222_24621_24672(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out System.Threading.SemaphoreSlim
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 24621, 24672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 24525, 24897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 24525, 24897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableHashSet<DiagnosticAnalyzer> ComputeNonConfigurableAnalyzers(ImmutableHashSet<DiagnosticAnalyzer> unsuppressedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 24909, 25683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25070, 25137);

                var
                builder = f_222_25084_25136()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25151, 25620);
                    foreach (var analyzer in f_222_25176_25197_I(unsuppressedAnalyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 25151, 25620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25231, 25327);

                        var
                        descriptors = f_222_25249_25326(f_222_25249_25264(), analyzer, f_222_25309_25325())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25345, 25605);
                            foreach (var descriptor in f_222_25372_25383_I(descriptors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 25345, 25605);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25425, 25586) || true) && (f_222_25429_25459(descriptor))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 25425, 25586);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25509, 25531);

                                    f_222_25509_25530(builder, analyzer);
                                    DynAbs.Tracing.TraceSender.TraceBreak(222, 25557, 25563);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 25425, 25586);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 25345, 25605);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 261);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 261);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 25151, 25620);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25636, 25672);

                return f_222_25643_25671(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 24909, 25683);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                f_222_25084_25136()
                {
                    var return_v = ImmutableHashSet.CreateBuilder<DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25084, 25136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_25249_25264()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 25249, 25264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_25309_25325()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 25309, 25325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_222_25249_25326(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedDiagnosticDescriptors(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25249, 25326);
                    return return_v;
                }


                bool
                f_222_25429_25459(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsNotConfigurable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25429, 25459);
                    return return_v;
                }


                bool
                f_222_25509_25530(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25509, 25530);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_222_25372_25383_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25372, 25383);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_25176_25197_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25176, 25197);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_25643_25671(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25643, 25671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 24909, 25683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 24909, 25683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableHashSet<DiagnosticAnalyzer> ComputeSymbolStartAnalyzers(ImmutableHashSet<DiagnosticAnalyzer> unsuppressedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 25695, 26248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25852, 25919);

                var
                builder = f_222_25866_25918()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 25933, 26185);
                    foreach (var action in f_222_25956_25995_I(this.AnalyzerActions.SymbolStartActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 25933, 26185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26029, 26170) || true) && (f_222_26033_26080(unsuppressedAnalyzers, f_222_26064_26079(action)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 26029, 26170);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26122, 26151);

                            f_222_26122_26150(builder, f_222_26134_26149(action));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 26029, 26170);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 25933, 26185);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26201, 26237);

                return f_222_26208_26236(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 25695, 26248);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                f_222_25866_25918()
                {
                    var return_v = ImmutableHashSet.CreateBuilder<DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25866, 25918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_26064_26079(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 26064, 26079);
                    return return_v;
                }


                bool
                f_222_26033_26080(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 26033, 26080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_26134_26149(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 26134, 26149);
                    return return_v;
                }


                bool
                f_222_26122_26150(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 26122, 26150);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                f_222_25956_25995_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 25956, 25995);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_26208_26236(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 26208, 26236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 25695, 26248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 25695, 26248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ComputeShouldSkipAnalysisOnGeneratedCode(
                    ImmutableHashSet<DiagnosticAnalyzer> analyzers,
                    ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags> generatedCodeAnalysisFlagsMap,
                    bool treatAllCodeAsNonGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 26260, 26876);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26569, 26837);
                    foreach (var analyzer in f_222_26594_26603_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 26569, 26837);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26637, 26822) || true) && (!f_222_26642_26748(analyzer, generatedCodeAnalysisFlagsMap, treatAllCodeAsNonGeneratedCode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 26637, 26822);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26790, 26803);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 26637, 26822);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 26569, 26837);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 26853, 26865);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 26260, 26876);

                bool
                f_222_26642_26748(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                generatedCodeAnalysisFlagsMap, bool
                treatAllCodeAsNonGeneratedCode)
                {
                    var return_v = ShouldSkipAnalysisOnGeneratedCode(analyzer, generatedCodeAnalysisFlagsMap, treatAllCodeAsNonGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 26642, 26748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_26594_26603_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 26594, 26603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 26260, 26876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 26260, 26876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ComputeShouldTreatAllCodeAsNonGeneratedCode(ImmutableHashSet<DiagnosticAnalyzer> analyzers, ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags> generatedCodeAnalysisFlagsMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 27086, 27783);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27321, 27744);
                    foreach (var analyzer in f_222_27346_27355_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 27321, 27744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27389, 27441);

                        var
                        flags = f_222_27401_27440(generatedCodeAnalysisFlagsMap, analyzer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27459, 27523);

                        var
                        analyze = (flags & GeneratedCodeAnalysisFlags.Analyze) != 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27541, 27614);

                        var
                        report = (flags & GeneratedCodeAnalysisFlags.ReportDiagnostics) != 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27632, 27729) || true) && (!analyze || (DynAbs.Tracing.TraceSender.Expression_False(222, 27636, 27655) || !report))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 27632, 27729);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27697, 27710);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 27632, 27729);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 27321, 27744);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 424);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27760, 27772);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 27086, 27783);

                Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                f_222_27401_27440(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 27401, 27440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_27346_27355_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 27346, 27355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 27086, 27783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 27086, 27783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldSkipAnalysisOnGeneratedCode(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 27884, 27993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 27887, 27993);
                return f_222_27887_27993(analyzer, f_222_27931_27960(), f_222_27962_27992()); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 27884, 27993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 27884, 27993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 27884, 27993);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
            f_222_27931_27960()
            {
                var return_v = GeneratedCodeAnalysisFlagsMap;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 27931, 27960);
                return return_v;
            }


            bool
            f_222_27962_27992()
            {
                var return_v = TreatAllCodeAsNonGeneratedCode;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 27962, 27992);
                return return_v;
            }


            bool
            f_222_27887_27993(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
            generatedCodeAnalysisFlagsMap, bool
            treatAllCodeAsNonGeneratedCode)
            {
                var return_v = ShouldSkipAnalysisOnGeneratedCode(analyzer, generatedCodeAnalysisFlagsMap, treatAllCodeAsNonGeneratedCode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 27887, 27993);
                return return_v;
            }

        }

        private static bool ShouldSkipAnalysisOnGeneratedCode(
                    DiagnosticAnalyzer analyzer,
                    ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags> generatedCodeAnalysisFlagsMap,
                    bool treatAllCodeAsNonGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 28006, 28533);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28289, 28385) || true) && (treatAllCodeAsNonGeneratedCode)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 28289, 28385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28357, 28370);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 28289, 28385);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28401, 28452);

                var
                mode = f_222_28412_28451(generatedCodeAnalysisFlagsMap, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28466, 28522);

                return (mode & GeneratedCodeAnalysisFlags.Analyze) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 28006, 28533);

                Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                f_222_28412_28451(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 28412, 28451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 28006, 28533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 28006, 28533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldSuppressGeneratedCodeDiagnostic(Diagnostic diagnostic, DiagnosticAnalyzer analyzer, Compilation compilation, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 28545, 29174);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28734, 28830) || true) && (f_222_28738_28768())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 28734, 28830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28802, 28815);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 28734, 28830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28846, 28919);

                var
                generatedCodeAnalysisFlags = f_222_28879_28918(f_222_28879_28908(), analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 28933, 29044);

                var
                suppressInGeneratedCode = (generatedCodeAnalysisFlags & GeneratedCodeAnalysisFlags.ReportDiagnostics) == 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 29058, 29163);

                return suppressInGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(222, 29065, 29162) && f_222_29092_29162(this, f_222_29110_29129(diagnostic), compilation, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 28545, 29174);

                bool
                f_222_28738_28768()
                {
                    var return_v = TreatAllCodeAsNonGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 28738, 28768);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                f_222_28879_28908()
                {
                    var return_v = GeneratedCodeAnalysisFlagsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 28879, 28908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                f_222_28879_28918(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 28879, 28918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_222_29110_29129(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 29110, 29129);
                    return return_v;
                }


                bool
                f_222_29092_29162(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.IsInGeneratedCode(location, compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 29092, 29162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 28545, 29174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 28545, 29174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal async Task AttachQueueAndProcessAllEventsAsync(AsyncQueue<CompilationEvent> eventQueue, AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 29948, 30988);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30201, 30664) || true) && (_initializeSucceeded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 30201, 30664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30267, 30307);

                        _lazyCompilationEventQueue = eventQueue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30329, 30393);

                        _lazyQueueRegistration = default(CancellationTokenRegistration);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30417, 30580);

                        await f_222_30423_30579(f_222_30423_30557(this, analysisScope, analysisState, usingPrePopulatedEventQueue: true, cancellationToken: cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30604, 30645);

                        _lazyPrimaryTask = f_222_30623_30644(true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 30201, 30664);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 30693, 30977);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30733, 30962) || true) && (_lazyPrimaryTask == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 30733, 30962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 30867, 30943);

                        _lazyPrimaryTask = f_222_30886_30942(f_222_30904_30941(canceled: true));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 30733, 30962);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 30693, 30977);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 29948, 30988);

                System.Threading.Tasks.Task
                f_222_30423_30557(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                usingPrePopulatedEventQueue, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ExecutePrimaryAnalysisTaskAsync(analysisScope, analysisState, usingPrePopulatedEventQueue: usingPrePopulatedEventQueue, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 30423, 30557);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_30423_30579(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 30423, 30579);
                    return return_v;
                }


                System.Threading.Tasks.Task<bool>
                f_222_30623_30644(bool
                result)
                {
                    var return_v = Task.FromResult(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 30623, 30644);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_30904_30941(bool
                canceled)
                {
                    var return_v = new System.Threading.CancellationToken(canceled: canceled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 30904, 30941);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_30886_30942(System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.FromCanceled(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 30886, 30942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 29948, 30988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 29948, 30988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AttachQueueAndStartProcessingEvents(AsyncQueue<CompilationEvent> eventQueue, AnalysisScope analysisScope, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 31678, 33077);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 31895, 32623) || true) && (_initializeSucceeded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 31895, 32623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 31961, 32001);

                        _lazyCompilationEventQueue = eventQueue;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 32023, 32256);

                        _lazyQueueRegistration = cancellationToken.Register(() =>
                                            {
                                                this.CompilationEventQueue.TryComplete();
                                                this.DiagnosticQueue.TryComplete();
                                            });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 32280, 32604);

                        _lazyPrimaryTask = f_222_32299_32603(f_222_32299_32440(this, analysisScope, analysisState: null, usingPrePopulatedEventQueue: false, cancellationToken: cancellationToken), c => DiagnosticQueue.TryComplete(), cancellationToken, TaskContinuationOptions.ExecuteSynchronously, f_222_32581_32602());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 31895, 32623);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 32652, 33066);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 32692, 33051) || true) && (_lazyPrimaryTask == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 32692, 33051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 32826, 32902);

                        _lazyPrimaryTask = f_222_32845_32901(f_222_32863_32900(canceled: true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 32997, 33032);

                        f_222_32997_33031(f_222_32997_33017(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 32692, 33051);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 32652, 33066);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 31678, 33077);

                System.Threading.Tasks.Task
                f_222_32299_32440(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                usingPrePopulatedEventQueue, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ExecutePrimaryAnalysisTaskAsync(analysisScope, analysisState: analysisState, usingPrePopulatedEventQueue: usingPrePopulatedEventQueue, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 32299, 32440);
                    return return_v;
                }


                System.Threading.Tasks.TaskScheduler
                f_222_32581_32602()
                {
                    var return_v = TaskScheduler.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 32581, 32602);
                    return return_v;
                }


                System.Threading.Tasks.Task<bool>
                f_222_32299_32603(System.Threading.Tasks.Task
                this_param, System.Func<System.Threading.Tasks.Task, bool>
                continuationFunction, System.Threading.CancellationToken
                cancellationToken, System.Threading.Tasks.TaskContinuationOptions
                continuationOptions, System.Threading.Tasks.TaskScheduler
                scheduler)
                {
                    var return_v = this_param.ContinueWith<bool>(continuationFunction, cancellationToken, continuationOptions, scheduler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 32299, 32603);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_32863_32900(bool
                canceled)
                {
                    var return_v = new System.Threading.CancellationToken(canceled: canceled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 32863, 32900);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_32845_32901(System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.FromCanceled(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 32845, 32901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_32997_33017(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 32997, 33017);
                    return return_v;
                }


                bool
                f_222_32997_33031(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param)
                {
                    var return_v = this_param.TryComplete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 32997, 33031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 31678, 33077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 31678, 33077);
            }
        }

        private async Task ExecutePrimaryAnalysisTaskAsync(AnalysisScope analysisScope, AnalysisState? analysisState, bool usingPrePopulatedEventQueue, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 33089, 34225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33294, 33330);

                f_222_33294_33329(analysisScope != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33346, 33394);

                await f_222_33352_33393(f_222_33352_33371(), false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33410, 34214) || true) && (f_222_33414_33443(f_222_33414_33433()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 33410, 34214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33477, 33564);

                    f_222_33477_33563(f_222_33495_33514(), f_222_33516_33537(this), f_222_33539_33562(analysisScope));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 33410, 34214);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 33410, 34214);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33598, 34214) || true) && (f_222_33602_33633_M(!f_222_33603_33622().IsCanceled))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 33598, 34214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33667, 33754);

                        _lazyAnalyzerExecutor = f_222_33691_33753(f_222_33691_33712(this), cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 33774, 33910);

                        await f_222_33780_33909(f_222_33780_33887(this, analysisScope, analysisState, usingPrePopulatedEventQueue, cancellationToken), false);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34054, 34199) || true) && (!usingPrePopulatedEventQueue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 34054, 34199);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34128, 34180);

                            f_222_34128_34179(f_222_34128_34143());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 34054, 34199);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 33598, 34214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 33410, 34214);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 33089, 34225);

                int
                f_222_33294_33329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33294, 33329);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_222_33352_33371()
                {
                    var return_v = WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33352, 33371);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_33352_33393(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33352, 33393);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_33414_33433()
                {
                    var return_v = WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33414, 33433);
                    return return_v;
                }


                bool
                f_222_33414_33443(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.IsFaulted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33414, 33443);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_33495_33514()
                {
                    var return_v = WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33495, 33514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_33516_33537(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33516, 33537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_33539_33562(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33539, 33562);
                    return return_v;
                }


                int
                f_222_33477_33563(System.Threading.Tasks.Task
                faultedTask, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    OnDriverException(faultedTask, analyzerExecutor, analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33477, 33563);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_222_33603_33622()
                {
                    var return_v = WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33603, 33622);
                    return return_v;
                }


                bool
                f_222_33602_33633_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33602, 33633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_33691_33712(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 33691, 33712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_33691_33753(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.WithCancellationToken(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33691, 33753);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_33780_33887(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                prePopulatedEventQueue, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ProcessCompilationEventsAsync(analysisScope, analysisState, prePopulatedEventQueue, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33780, 33887);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_33780_33909(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 33780, 33909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_34128_34143()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 34128, 34143);
                    return return_v;
                }


                int
                f_222_34128_34179(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param)
                {
                    this_param.VerifyAllSymbolEndActionsExecuted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 34128, 34179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 33089, 34225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 33089, 34225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void OnDriverException(Task faultedTask, AnalyzerExecutor analyzerExecutor, ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 34237, 35138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34398, 34434);

                f_222_34398_34433(f_222_34411_34432(faultedTask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34450, 34509);

                var
                innerException = f_222_34471_34508_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_222_34471_34492(faultedTask), 222, 34471, 34508)?.InnerException)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34523, 34653) || true) && (innerException == null || (DynAbs.Tracing.TraceSender.Expression_False(222, 34527, 34597) || innerException is OperationCanceledException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 34523, 34653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34631, 34638);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 34523, 34653);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 34669, 34751);

                var
                diagnostic = f_222_34686_34750(innerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35008, 35036);

                var
                analyzer = analyzers[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35052, 35127);

                f_222_35052_35126(
                            analyzerExecutor, innerException, analyzer, diagnostic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 34237, 35138);

                bool
                f_222_34411_34432(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.IsFaulted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 34411, 34432);
                    return return_v;
                }


                int
                f_222_34398_34433(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 34398, 34433);
                    return 0;
                }


                System.AggregateException?
                f_222_34471_34492(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 34471, 34492);
                    return return_v;
                }


                System.Exception?
                f_222_34471_34508_M(System.Exception?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 34471, 34508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_222_34686_34750(System.Exception
                e)
                {
                    var return_v = AnalyzerExecutor.CreateDriverExceptionDiagnostic(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 34686, 34750);
                    return return_v;
                }


                int
                f_222_35052_35126(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Exception
                arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg2, Microsoft.CodeAnalysis.Diagnostic
                arg3)
                {
                    this_param.OnAnalyzerException(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 35052, 35126);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 34237, 35138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 34237, 35138);
            }
        }

        private void ExecuteSyntaxTreeActions(AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 35150, 37108);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35308, 35556) || true) && (f_222_35312_35346(analysisScope) && (DynAbs.Tracing.TraceSender.Expression_True(222, 35312, 35394) && f_222_35350_35394_M(!analysisScope.IsSyntacticSingleFileAnalysis)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 35308, 35556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35534, 35541);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 35308, 35556);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35572, 37097);
                    foreach (var tree in f_222_35593_35618_I(f_222_35593_35618(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 35572, 37097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35652, 35696);

                        var
                        isGeneratedCode = f_222_35674_35695(this, tree)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35714, 35758);

                        var
                        file = f_222_35725_35757(tree)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35776, 35989) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(222, 35780, 35824) && f_222_35799_35824()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 35776, 35989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35866, 35939);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 35866, 35938)?.MarkSyntaxAnalysisComplete(file, f_222_35914_35937(analysisScope)), 222, 35880, 35938);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 35961, 35970);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 35776, 35989);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36009, 36113);

                        var
                        processedAnalyzers = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 36034, 36055) || ((analysisState != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 36058, 36105)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 36108, 36112))) ? f_222_36058_36105() : null
                        ;
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36175, 36820);
                                foreach (var (analyzer, syntaxTreeActions) in f_222_36221_36243_I(_lazySyntaxTreeActions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 36175, 36820);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36293, 36424) || true) && (!f_222_36298_36330(analysisScope, analyzer))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 36293, 36424);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36388, 36397);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 36293, 36424);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36452, 36501);

                                    cancellationToken.ThrowIfCancellationRequested();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36608, 36735);

                                    f_222_36608_36734(f_222_36608_36624(), syntaxTreeActions, analyzer, file, analysisScope, analysisState, isGeneratedCode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36763, 36797);

                                    f_222_36763_36796_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 36763, 36796)?.Add(analyzer));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 36175, 36820);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 646);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 646);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 36844, 36951);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 36844, 36950)?.MarkSyntaxAnalysisCompleteForUnprocessedAnalyzers(file, analysisScope, processedAnalyzers!), 222, 36858, 36950);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 36988, 37082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37036, 37063);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 37036, 37062)?.Free(), 222, 37055, 37062);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(222, 36988, 37082);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 35572, 37097);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 1526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 1526);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 35150, 37108);

                bool
                f_222_35312_35346(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.IsSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 35312, 35346);
                    return return_v;
                }


                bool
                f_222_35350_35394_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 35350, 35394);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_222_35593_35618(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 35593, 35618);
                    return return_v;
                }


                bool
                f_222_35674_35695(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsGeneratedCode(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 35674, 35695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_222_35725_35757(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 35725, 35757);
                    return return_v;
                }


                bool
                f_222_35799_35824()
                {
                    var return_v = DoNotAnalyzeGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 35799, 35824);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                f_222_35914_35937(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 35914, 35937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_36058_36105()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 36058, 36105);
                    return return_v;
                }


                bool
                f_222_36298_36330(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 36298, 36330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_36608_36624()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 36608, 36624);
                    return return_v;
                }


                bool
                f_222_36608_36734(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>
                syntaxTreeActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                isGeneratedCode)
                {
                    var return_v = this_param.TryExecuteSyntaxTreeActions(syntaxTreeActions, analyzer, file, analysisScope, analysisState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 36608, 36734);
                    return return_v;
                }


                bool?
                f_222_36763_36796_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 36763, 36796);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>)>
                f_222_36221_36243_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 36221, 36243);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_222_35593_35618_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 35593, 35618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 35150, 37108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 35150, 37108);
            }
        }

        private void ExecuteAdditionalFileActions(AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 37120, 38831);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37282, 37549) || true) && (f_222_37286_37320(analysisScope) && (DynAbs.Tracing.TraceSender.Expression_True(222, 37286, 37368) && f_222_37324_37368_M(!analysisScope.IsSyntacticSingleFileAnalysis)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 37282, 37549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37527, 37534);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 37282, 37549);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37565, 38820);
                    foreach (var additionalFile in f_222_37596_37625_I(f_222_37596_37625(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 37565, 38820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37659, 37713);

                        var
                        file = f_222_37670_37712(additionalFile)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37733, 37837);

                        var
                        processedAnalyzers = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 37758, 37779) || ((analysisState != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 37782, 37829)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 37832, 37836))) ? f_222_37782_37829() : null
                        ;
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 37899, 38543);
                                foreach (var (analyzer, additionalFileActions) in f_222_37949_37975_I(_lazyAdditionalFileActions))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 37899, 38543);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38025, 38156) || true) && (!f_222_38030_38062(analysisScope, analyzer))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 38025, 38156);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38120, 38129);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 38025, 38156);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38184, 38233);

                                    cancellationToken.ThrowIfCancellationRequested();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38340, 38458);

                                    f_222_38340_38457(f_222_38340_38356(), additionalFileActions, analyzer, file, analysisScope, analysisState);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38486, 38520);

                                    f_222_38486_38519_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 38486, 38519)?.Add(analyzer));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 37899, 38543);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 645);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 645);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38567, 38674);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 38567, 38673)?.MarkSyntaxAnalysisCompleteForUnprocessedAnalyzers(file, analysisScope, processedAnalyzers!), 222, 38581, 38673);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 38711, 38805);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 38759, 38786);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 38759, 38785)?.Free(), 222, 38778, 38785);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(222, 38711, 38805);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 37565, 38820);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 1256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 1256);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 37120, 38831);

                bool
                f_222_37286_37320(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.IsSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 37286, 37320);
                    return return_v;
                }


                bool
                f_222_37324_37368_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 37324, 37368);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                f_222_37596_37625(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 37596, 37625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_222_37670_37712(Microsoft.CodeAnalysis.AdditionalText
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 37670, 37712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_37782_37829()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 37782, 37829);
                    return return_v;
                }


                bool
                f_222_38030_38062(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 38030, 38062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_38340_38356()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 38340, 38356);
                    return return_v;
                }


                bool
                f_222_38340_38457(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>
                additionalFileActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteAdditionalFileActions(additionalFileActions, analyzer, file, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 38340, 38457);
                    return return_v;
                }


                bool?
                f_222_38486_38519_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 38486, 38519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>)>
                f_222_37949_37975_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 37949, 37975);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                f_222_37596_37625_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 37596, 37625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 37120, 38831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 37120, 38831);
            }
        }

        public static AnalyzerDriver CreateAndAttachToCompilation(
                    Compilation compilation,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    AnalyzerOptions options,
                    AnalyzerManager analyzerManager,
                    Action<Diagnostic> addExceptionDiagnostic,
                    bool reportAnalyzer,
                    SeverityFilter severityFilter,
                    out Compilation newCompilation,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 40382, 41328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 40875, 41037);

                Action<Exception, DiagnosticAnalyzer, Diagnostic>
                onAnalyzerException =
                                (ex, analyzer, diagnostic) => addExceptionDiagnostic?.Invoke(diagnostic)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 41053, 41094);

                Func<Exception, bool>?
                nullFilter = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 41108, 41317);

                return f_222_41115_41316(compilation, analyzers, options, analyzerManager, onAnalyzerException, nullFilter, reportAnalyzer, severityFilter, out newCompilation, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 40382, 41328);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_222_41115_41316(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, bool
                reportAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, out Microsoft.CodeAnalysis.Compilation
                newCompilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = CreateAndAttachToCompilation(compilation, analyzers, options, analyzerManager, onAnalyzerException, analyzerExceptionFilter, reportAnalyzer, severityFilter, out newCompilation, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 41115, 41316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 40382, 41328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 40382, 41328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AnalyzerDriver CreateAndAttachToCompilation(
                    Compilation compilation,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    AnalyzerOptions options,
                    AnalyzerManager analyzerManager,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException,
                    Func<Exception, bool>? analyzerExceptionFilter,
                    bool reportAnalyzer,
                    SeverityFilter severityFilter,
                    out Compilation newCompilation,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 41382, 43137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 41966, 42075);

                AnalyzerDriver
                analyzerDriver = f_222_41998_42074(compilation, analyzers, analyzerManager, severityFilter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42089, 42267);

                newCompilation = f_222_42106_42266(f_222_42106_42197(compilation
                , f_222_42162_42196()), f_222_42231_42265());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42283, 42317);

                var
                categorizeDiagnostics = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42331, 42573);

                var
                analysisOptions = f_222_42353_42572(options, onAnalyzerException, analyzerExceptionFilter: analyzerExceptionFilter, concurrentAnalysis: true, logAnalyzerExecutionTime: reportAnalyzer, reportSuppressedDiagnostics: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42587, 42725);

                f_222_42587_42724(analyzerDriver, newCompilation, analysisOptions, f_222_42646_42681(newCompilation), categorizeDiagnostics, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42741, 42944);

                var
                analysisScope = f_222_42761_42943(newCompilation, options, analyzers, hasAllAnalyzers: true, concurrentAnalysis: f_222_42858_42896(f_222_42858_42880(newCompilation)), categorizeDiagnostics: categorizeDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 42958, 43090);

                f_222_42958_43089(analyzerDriver, newCompilation.EventQueue!, analysisScope, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43104, 43126);

                return analyzerDriver;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 41382, 43137);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_222_41998_42074(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = this_param.CreateAnalyzerDriver(analyzers, analyzerManager, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 41998, 42074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                f_222_42162_42196()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42162, 42196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_42106_42197(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                semanticModelProvider)
                {
                    var return_v = this_param.WithSemanticModelProvider((Microsoft.CodeAnalysis.SemanticModelProvider)semanticModelProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42106, 42197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_42231_42265()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42231, 42265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_42106_42266(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue)
                {
                    var return_v = this_param.WithEventQueue(eventQueue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42106, 42266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                f_222_42353_42572(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, bool
                concurrentAnalysis, bool
                logAnalyzerExecutionTime, bool
                reportSuppressedDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions(options, onAnalyzerException, analyzerExceptionFilter: analyzerExceptionFilter, concurrentAnalysis: concurrentAnalysis, logAnalyzerExecutionTime: logAnalyzerExecutionTime, reportSuppressedDiagnostics: reportSuppressedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42353, 42572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                f_222_42646_42681(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42646, 42681);
                    return return_v;
                }


                int
                f_222_42587_42724(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                analysisOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                compilationData, bool
                categorizeDiagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Initialize(compilation, analysisOptions, compilationData, categorizeDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42587, 42724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_42858_42880(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 42858, 42880);
                    return return_v;
                }


                bool
                f_222_42858_42896(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 42858, 42896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_222_42761_42943(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(compilation, analyzerOptions, analyzers, hasAllAnalyzers: hasAllAnalyzers, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42761, 42943);
                    return return_v;
                }


                int
                f_222_42958_43089(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.AttachQueueAndStartProcessingEvents(eventQueue, analysisScope, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 42958, 43089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 41382, 43137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 41382, 43137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetDiagnosticsAsync(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 43557, 44686);
                Microsoft.CodeAnalysis.Diagnostic? diagnostic = default(Microsoft.CodeAnalysis.Diagnostic?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43672, 43721);

                var
                allDiagnostics = f_222_43693_43720()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43735, 44070) || true) && (f_222_43739_43772(f_222_43739_43760()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 43735, 44070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43806, 43857);

                    await f_222_43812_43856(f_222_43812_43834(this), false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43877, 44055) || true) && (f_222_43881_43913(f_222_43881_43903(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 43877, 44055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 43955, 44036);

                        f_222_43955_44035(f_222_43973_43995(this), f_222_43997_44018(this), f_222_44020_44034(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 43877, 44055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 43735, 44070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44086, 44166);

                var
                suppressMessageState = f_222_44113_44165(f_222_44113_44135())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44180, 44262);

                var
                reportSuppressedDiagnostics = f_222_44214_44261(f_222_44214_44233(compilation))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44276, 44617) || true) && (f_222_44283_44329(f_222_44283_44298(), out diagnostic))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 44276, 44617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44363, 44433);

                        diagnostic = f_222_44376_44432(suppressMessageState, diagnostic);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44451, 44602) || true) && (reportSuppressedDiagnostics || (DynAbs.Tracing.TraceSender.Expression_False(222, 44455, 44510) || f_222_44486_44510_M(!diagnostic.IsSuppressed)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 44451, 44602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44552, 44583);

                            f_222_44552_44582(allDiagnostics, diagnostic);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 44451, 44602);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 44276, 44617);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 44276, 44617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 44276, 44617);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44633, 44675);

                return f_222_44640_44674(allDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 43557, 44686);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_222_43693_43720()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 43693, 43720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_43739_43760()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43739, 43760);
                    return return_v;
                }


                bool
                f_222_43739_43772(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43739, 43772);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_43812_43834(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenCompletedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43812, 43834);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_43812_43856(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 43812, 43856);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_43881_43903(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenCompletedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43881, 43903);
                    return return_v;
                }


                bool
                f_222_43881_43913(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.IsFaulted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43881, 43913);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_43973_43995(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenCompletedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43973, 43995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_43997_44018(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 43997, 44018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_44020_44034(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44020, 44034);
                    return return_v;
                }


                int
                f_222_43955_44035(System.Threading.Tasks.Task
                faultedTask, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    OnDriverException(faultedTask, analyzerExecutor, analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 43955, 44035);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                f_222_44113_44135()
                {
                    var return_v = CurrentCompilationData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44113, 44135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                f_222_44113_44165(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                this_param)
                {
                    var return_v = this_param.SuppressMessageAttributeState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44113, 44165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_44214_44233(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44214, 44233);
                    return return_v;
                }


                bool
                f_222_44214_44261(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44214, 44261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_44283_44298()
                {
                    var return_v = DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44283, 44298);
                    return return_v;
                }


                bool
                f_222_44283_44329(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param, out Microsoft.CodeAnalysis.Diagnostic?
                d)
                {
                    var return_v = this_param.TryDequeue(out d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44283, 44329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_222_44376_44432(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = this_param.ApplySourceSuppressions(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44376, 44432);
                    return return_v;
                }


                bool
                f_222_44486_44510_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44486, 44510);
                    return return_v;
                }


                int
                f_222_44552_44582(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44552, 44582);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_44640_44674(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44640, 44674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 43557, 44686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 43557, 44686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SemanticModel GetOrCreateSemanticModel(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 44775, 44838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44778, 44838);
                return f_222_44778_44838(this, tree, f_222_44809_44837(f_222_44809_44825())); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 44775, 44838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 44775, 44838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 44775, 44838);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
            f_222_44809_44825()
            {
                var return_v = AnalyzerExecutor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44809, 44825);
                return return_v;
            }


            Microsoft.CodeAnalysis.Compilation
            f_222_44809_44837(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
            this_param)
            {
                var return_v = this_param.Compilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44809, 44837);
                return return_v;
            }


            Microsoft.CodeAnalysis.SemanticModel
            f_222_44778_44838(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            tree, Microsoft.CodeAnalysis.Compilation
            compilation)
            {
                var return_v = this_param.GetOrCreateSemanticModel(tree, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44778, 44838);
                return return_v;
            }

        }

        private SemanticModel GetOrCreateSemanticModel(SyntaxTree tree, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 44953, 45013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 44956, 45013);
                return f_222_44956_45013(f_222_44956_44977(), tree, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 44953, 45013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 44953, 45013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 44953, 45013);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
            f_222_44956_44977()
            {
                var return_v = SemanticModelProvider;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 44956, 44977);
                return return_v;
            }


            Microsoft.CodeAnalysis.SemanticModel
            f_222_44956_45013(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            tree, Microsoft.CodeAnalysis.Compilation
            compilation)
            {
                var return_v = this_param.GetSemanticModel(tree, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 44956, 45013);
                return return_v;
            }

        }

        public void ApplyProgrammaticSuppressions(DiagnosticBag reportedDiagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 45026, 45542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45152, 45212);

                f_222_45152_45211(f_222_45165_45210_M(!reportedDiagnostics.IsEmptyWithoutResolution));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45226, 45312) || true) && (!_hasDiagnosticSuppressors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 45226, 45312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45290, 45297);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 45226, 45312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45328, 45430);

                var
                newDiagnostics = f_222_45349_45429(this, f_222_45383_45415(reportedDiagnostics), compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45444, 45472);

                f_222_45444_45471(reportedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45486, 45531);

                f_222_45486_45530(reportedDiagnostics, newDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 45026, 45542);

                bool
                f_222_45165_45210_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 45165, 45210);
                    return return_v;
                }


                int
                f_222_45152_45211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45152, 45211);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_45383_45415(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45383, 45415);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_45349_45429(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ApplyProgrammaticSuppressionsCore(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45349, 45429);
                    return return_v;
                }


                int
                f_222_45444_45471(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45444, 45471);
                    return 0;
                }


                int
                f_222_45486_45530(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45486, 45530);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 45026, 45542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 45026, 45542);
            }
        }

        public ImmutableArray<Diagnostic> ApplyProgrammaticSuppressions(ImmutableArray<Diagnostic> reportedDiagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 45554, 45971);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45715, 45869) || true) && (reportedDiagnostics.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(222, 45719, 45793) || !_hasDiagnosticSuppressors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 45715, 45869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45827, 45854);

                    return reportedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 45715, 45869);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 45885, 45960);

                return f_222_45892_45959(this, reportedDiagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 45554, 45971);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_45892_45959(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ApplyProgrammaticSuppressionsCore(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 45892, 45959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 45554, 45971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 45554, 45971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Diagnostic> ApplyProgrammaticSuppressionsCore(ImmutableArray<Diagnostic> reportedDiagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 45983, 53162);
                Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo programmaticSuppressionInfo = default(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 46149, 46189);

                f_222_46149_46188(_hasDiagnosticSuppressors);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 46203, 46246);

                f_222_46203_46245(f_222_46216_46244_M(!reportedDiagnostics.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 46260, 46308);

                f_222_46260_46307(_programmaticSuppressions != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 46322, 46393);

                f_222_46322_46392(_diagnosticsProcessedForProgrammaticSuppressions != null);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 46896, 47348);

                    var
                    suppressableDiagnostics = reportedDiagnostics.Where(d => !d.IsSuppressed &&
                                                                                                 !d.IsNotConfigurable() &&
                                                                                                 d.DefaultSeverity != DiagnosticSeverity.Error &&
                                                                                                 !_diagnosticsProcessedForProgrammaticSuppressions.Contains(d))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47368, 47493) || true) && (f_222_47372_47405(suppressableDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 47368, 47493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47447, 47474);

                        return reportedDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 47368, 47493);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47513, 47613);

                    f_222_47513_47612(suppressableDiagnostics, concurrent: f_222_47576_47611(f_222_47576_47595(compilation)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47631, 47756) || true) && (f_222_47635_47668(_programmaticSuppressions))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 47631, 47756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47710, 47737);

                        return reportedDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 47631, 47756);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47776, 47855);

                    var
                    builder = f_222_47790_47854(reportedDiagnostics.Length)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 47873, 48046);

                    ImmutableDictionary<Diagnostic, ProgrammaticSuppressionInfo>
                    programmaticSuppressionsByDiagnostic = f_222_47973_48045(_programmaticSuppressions)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48064, 48846);
                        foreach (var diagnostic in f_222_48091_48110_I(reportedDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 48064, 48846);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48152, 48827) || true) && (f_222_48156_48253(programmaticSuppressionsByDiagnostic, diagnostic, out programmaticSuppressionInfo))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 48152, 48827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48303, 48362);

                                f_222_48303_48361(f_222_48316_48360(suppressableDiagnostics, diagnostic));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48388, 48427);

                                f_222_48388_48426(f_222_48401_48425_M(!diagnostic.IsSuppressed));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48453, 48548);

                                var
                                suppressedDiagnostic = f_222_48480_48547(diagnostic, programmaticSuppressionInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48574, 48622);

                                f_222_48574_48621(f_222_48587_48620(suppressedDiagnostic));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48648, 48682);

                                f_222_48648_48681(builder, suppressedDiagnostic);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 48152, 48827);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 48152, 48827);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48780, 48804);

                                f_222_48780_48803(builder, diagnostic);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 48152, 48827);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 48064, 48846);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 783);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 783);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 48866, 48902);

                    return f_222_48873_48901(builder);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 48931, 49224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49130, 49209);

                    f_222_49130_49208(                // Mark the reported diagnostics as processed for programmatic suppressions to avoid duplicate callbacks to suppressors for same diagnostics.
                                    _diagnosticsProcessedForProgrammaticSuppressions, reportedDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 48931, 49224);
                }

                void executeSuppressionActions(IEnumerable<Diagnostic> reportedDiagnostics, bool concurrent)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 49240, 51769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49365, 49429);

                        var
                        suppressors = this.Analyzers.OfType<DiagnosticSuppressor>()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49447, 50815) || true) && (concurrent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 49447, 50815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49766, 49811);

                            var
                            tasks = f_222_49778_49810()
                            ;
                            try
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49885, 50278);
                                    foreach (var suppressor in f_222_49912_49923_I(suppressors))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 49885, 50278);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 49981, 50205);

                                        var
                                        task = f_222_49992_50204(() => AnalyzerExecutor.ExecuteSuppressionAction(suppressor, getSuppressableDiagnostics(suppressor)), f_222_50169_50203(f_222_50169_50185()))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50235, 50251);

                                        f_222_50235_50250(tasks, task);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 49885, 50278);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 394);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 394);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50306, 50372);

                                f_222_50306_50371(f_222_50319_50334(tasks), f_222_50336_50370(f_222_50336_50352()));
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 50417, 50509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50473, 50486);

                                f_222_50473_50485(tasks);
                                DynAbs.Tracing.TraceSender.TraceExitFinally(222, 50417, 50509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 49447, 50815);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 49447, 50815);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50591, 50796);
                                foreach (var suppressor in f_222_50618_50629_I(suppressors))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 50591, 50796);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50679, 50773);

                                    f_222_50679_50772(f_222_50679_50695(), suppressor, f_222_50733_50771(suppressor));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 50591, 50796);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 206);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 206);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 49447, 50815);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50835, 50842);

                        return;

                        ImmutableArray<Diagnostic> getSuppressableDiagnostics(DiagnosticSuppressor suppressor)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 50862, 51754);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 50989, 51098);

                                var
                                supportedSuppressions = f_222_51017_51097(f_222_51017_51032(), suppressor, f_222_51080_51096())
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51120, 51266) || true) && (supportedSuppressions.IsEmpty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 51120, 51266);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51203, 51243);

                                    return ImmutableArray<Diagnostic>.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 51120, 51266);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51290, 51343);

                                var
                                builder = f_222_51304_51342()
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51365, 51675);
                                    foreach (var diagnostic in f_222_51392_51411_I(reportedDiagnostics))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 51365, 51675);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51461, 51652) || true) && (f_222_51465_51543(ref supportedSuppressions, s => s.SuppressedDiagnosticId == diagnostic.Id))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 51461, 51652);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51601, 51625);

                                            f_222_51601_51624(builder, diagnostic);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 51461, 51652);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 51365, 51675);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 311);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 311);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51699, 51735);

                                return f_222_51706_51734(builder);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 50862, 51754);

                                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                                f_222_51017_51032()
                                {
                                    var return_v = AnalyzerManager;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 51017, 51032);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                                f_222_51080_51096()
                                {
                                    var return_v = AnalyzerExecutor;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 51080, 51096);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                                f_222_51017_51097(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                                suppressor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                                analyzerExecutor)
                                {
                                    var return_v = this_param.GetSupportedSuppressionDescriptors(suppressor, analyzerExecutor);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51017, 51097);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                                f_222_51304_51342()
                                {
                                    var return_v = ArrayBuilder<Diagnostic>.GetInstance();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51304, 51342);
                                    return return_v;
                                }


                                bool
                                f_222_51465_51543(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                                sequence, System.Func<Microsoft.CodeAnalysis.SuppressionDescriptor, bool>
                                predicate)
                                {
                                    var return_v = sequence.Contains<Microsoft.CodeAnalysis.SuppressionDescriptor>(predicate);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51465, 51543);
                                    return return_v;
                                }


                                int
                                f_222_51601_51624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                                this_param, Microsoft.CodeAnalysis.Diagnostic
                                item)
                                {
                                    this_param.Add(item);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51601, 51624);
                                    return 0;
                                }


                                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                                f_222_51392_51411_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51392, 51411);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                                f_222_51706_51734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                                this_param)
                                {
                                    var return_v = this_param.ToImmutableAndFree();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 51706, 51734);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 50862, 51754);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 50862, 51754);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 49240, 51769);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Threading.Tasks.Task>
                        f_222_49778_49810()
                        {
                            var return_v = ArrayBuilder<Task>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 49778, 49810);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_50169_50185()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 50169, 50185);
                            return return_v;
                        }


                        System.Threading.CancellationToken
                        f_222_50169_50203(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param)
                        {
                            var return_v = this_param.CancellationToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 50169, 50203);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_222_49992_50204(System.Action
                        action, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = Task.Run(action, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 49992, 50204);
                            return return_v;
                        }


                        int
                        f_222_50235_50250(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Threading.Tasks.Task>
                        this_param, System.Threading.Tasks.Task
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50235, 50250);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor>
                        f_222_49912_49923_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 49912, 49923);
                            return return_v;
                        }


                        System.Threading.Tasks.Task[]
                        f_222_50319_50334(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Threading.Tasks.Task>
                        this_param)
                        {
                            var return_v = this_param.ToArray();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50319, 50334);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_50336_50352()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 50336, 50352);
                            return return_v;
                        }


                        System.Threading.CancellationToken
                        f_222_50336_50370(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param)
                        {
                            var return_v = this_param.CancellationToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 50336, 50370);
                            return return_v;
                        }


                        int
                        f_222_50306_50371(System.Threading.Tasks.Task[]
                        tasks, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            Task.WaitAll(tasks, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50306, 50371);
                            return 0;
                        }


                        int
                        f_222_50473_50485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Threading.Tasks.Task>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50473, 50485);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_50679_50695()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 50679, 50695);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                        f_222_50733_50771(Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                        suppressor)
                        {
                            var return_v = getSuppressableDiagnostics(suppressor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50733, 50771);
                            return return_v;
                        }


                        int
                        f_222_50679_50772(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                        suppressor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                        reportedDiagnostics)
                        {
                            this_param.ExecuteSuppressionAction(suppressor, reportedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50679, 50772);
                            return 0;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor>
                        f_222_50618_50629_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 50618, 50629);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 49240, 51769);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 49240, 51769);
                    }
                }

                static ImmutableDictionary<Diagnostic, ProgrammaticSuppressionInfo> createProgrammaticSuppressionsByDiagnosticMap(ConcurrentSet<Suppression> programmaticSuppressions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 51785, 53151);
                        System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder set = default(System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 51984, 52120);

                        var
                        programmaticSuppressionsBuilder = f_222_52022_52119()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52138, 52747);
                            foreach (var programmaticSuppression in f_222_52178_52202_I(programmaticSuppressions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 52138, 52747);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52244, 52605) || true) && (!f_222_52249_52351(programmaticSuppressionsBuilder, programmaticSuppression.SuppressedDiagnostic, out set))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 52244, 52605);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52401, 52469);

                                    set = f_222_52407_52468();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52495, 52582);

                                    f_222_52495_52581(programmaticSuppressionsBuilder, programmaticSuppression.SuppressedDiagnostic, set);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 52244, 52605);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52629, 52728);

                                f_222_52629_52727(
                                                    set, (f_222_52638_52675(programmaticSuppression.Descriptor), f_222_52677_52725(programmaticSuppression.Descriptor)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 52138, 52747);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 610);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 610);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52767, 52861);

                        var
                        mapBuilder = f_222_52784_52860()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52879, 53084);
                            foreach (var (diagnostic, set2) in f_222_52913_52944_I(programmaticSuppressionsBuilder))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 52879, 53084);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 52986, 53065);

                                f_222_52986_53064(mapBuilder, diagnostic, f_222_53013_53063(f_222_53045_53062(set2)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 52879, 53084);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 206);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 206);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 53104, 53136);

                        return f_222_53111_53135(mapBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 51785, 53151);

                        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.Diagnostic, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder>
                        f_222_52022_52119()
                        {
                            var return_v = PooledDictionary<Diagnostic, ImmutableHashSet<(string, LocalizableString)>.Builder>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52022, 52119);
                            return return_v;
                        }


                        bool
                        f_222_52249_52351(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.Diagnostic, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        key, out System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52249, 52351);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder
                        f_222_52407_52468()
                        {
                            var return_v = ImmutableHashSet.CreateBuilder<(string, LocalizableString)>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52407, 52468);
                            return return_v;
                        }


                        int
                        f_222_52495_52581(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.Diagnostic, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        key, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52495, 52581);
                            return 0;
                        }


                        string
                        f_222_52638_52675(Microsoft.CodeAnalysis.SuppressionDescriptor
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 52638, 52675);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.LocalizableString
                        f_222_52677_52725(Microsoft.CodeAnalysis.SuppressionDescriptor
                        this_param)
                        {
                            var return_v = this_param.Justification;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 52677, 52725);
                            return return_v;
                        }


                        bool
                        f_222_52629_52727(System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder
                        this_param, (string Id, Microsoft.CodeAnalysis.LocalizableString Justification)
                        item)
                        {
                            var return_v = this_param.Add(((string, Microsoft.CodeAnalysis.LocalizableString))item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52629, 52727);
                            return return_v;
                        }


                        Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>
                        f_222_52178_52202_I(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52178, 52202);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>.Builder
                        f_222_52784_52860()
                        {
                            var return_v = ImmutableDictionary.CreateBuilder<Diagnostic, ProgrammaticSuppressionInfo>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52784, 52860);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>
                        f_222_53045_53062(System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53045, 53062);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        f_222_53013_53063(System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>
                        suppressions)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo(suppressions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53013, 53063);
                            return return_v;
                        }


                        int
                        f_222_52986_53064(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>.Builder
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        key, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52986, 53064);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.Diagnostic, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder>
                        f_222_52913_52944_I(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.Diagnostic, System.Collections.Immutable.ImmutableHashSet<(string, Microsoft.CodeAnalysis.LocalizableString)>.Builder>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 52913, 52944);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>
                        f_222_53111_53135(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53111, 53135);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 51785, 53151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 51785, 53151);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 45983, 53162);

                int
                f_222_46149_46188(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 46149, 46188);
                    return 0;
                }


                bool
                f_222_46216_46244_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 46216, 46244);
                    return return_v;
                }


                int
                f_222_46203_46245(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 46203, 46245);
                    return 0;
                }


                int
                f_222_46260_46307(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 46260, 46307);
                    return 0;
                }


                int
                f_222_46322_46392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 46322, 46392);
                    return 0;
                }


                bool
                f_222_47372_47405(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 47372, 47405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_47576_47595(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 47576, 47595);
                    return return_v;
                }


                bool
                f_222_47576_47611(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 47576, 47611);
                    return return_v;
                }


                int
                f_222_47513_47612(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, bool
                concurrent)
                {
                    executeSuppressionActions(reportedDiagnostics, concurrent: concurrent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 47513, 47612);
                    return 0;
                }


                bool
                f_222_47635_47668(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 47635, 47668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                f_222_47790_47854(int
                capacity)
                {
                    var return_v = ArrayBuilder<Diagnostic>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 47790, 47854);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>
                f_222_47973_48045(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>
                programmaticSuppressions)
                {
                    var return_v = createProgrammaticSuppressionsByDiagnosticMap(programmaticSuppressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 47973, 48045);
                    return return_v;
                }


                bool
                f_222_48156_48253(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                key, out Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48156, 48253);
                    return return_v;
                }


                bool
                f_222_48316_48360(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                source, Microsoft.CodeAnalysis.Diagnostic
                value)
                {
                    var return_v = source.Contains<Microsoft.CodeAnalysis.Diagnostic>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48316, 48360);
                    return return_v;
                }


                int
                f_222_48303_48361(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48303, 48361);
                    return 0;
                }


                bool
                f_222_48401_48425_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 48401, 48425);
                    return return_v;
                }


                int
                f_222_48388_48426(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48388, 48426);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_222_48480_48547(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                programmaticSuppressionInfo)
                {
                    var return_v = this_param.WithProgrammaticSuppression(programmaticSuppressionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48480, 48547);
                    return return_v;
                }


                bool
                f_222_48587_48620(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 48587, 48620);
                    return return_v;
                }


                int
                f_222_48574_48621(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48574, 48621);
                    return 0;
                }


                int
                f_222_48648_48681(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48648, 48681);
                    return 0;
                }


                int
                f_222_48780_48803(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48780, 48803);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_48091_48110_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48091, 48110);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_48873_48901(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 48873, 48901);
                    return return_v;
                }


                int
                f_222_49130_49208(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                values)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 49130, 49208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 45983, 53162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 45983, 53162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Diagnostic> DequeueLocalDiagnosticsAndApplySuppressions(DiagnosticAnalyzer analyzer, bool syntax, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 53174, 53593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 53343, 53486);

                var
                diagnostics = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 53361, 53367) || ((syntax && DynAbs.Tracing.TraceSender.Conditional_F2(222, 53370, 53425)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 53428, 53485))) ? f_222_53370_53425(f_222_53370_53385(), analyzer) : f_222_53428_53485(f_222_53428_53443(), analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 53500, 53582);

                return f_222_53507_53581(this, diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 53174, 53593);

                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_53370_53385()
                {
                    var return_v = DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 53370, 53385);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_53370_53425(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.DequeueLocalSyntaxDiagnostics(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53370, 53425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_53428_53443()
                {
                    var return_v = DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 53428, 53443);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_53428_53485(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.DequeueLocalSemanticDiagnostics(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53428, 53485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_53507_53581(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.FilterDiagnosticsSuppressedInSourceOrByAnalyzers(diagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53507, 53581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 53174, 53593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 53174, 53593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<Diagnostic> DequeueNonLocalDiagnosticsAndApplySuppressions(DiagnosticAnalyzer analyzer, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 53605, 53942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 53764, 53835);

                var
                diagnostics = f_222_53782_53834(f_222_53782_53797(), analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 53849, 53931);

                return f_222_53856_53930(this, diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 53605, 53942);

                Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                f_222_53782_53797()
                {
                    var return_v = DiagnosticQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 53782, 53797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_53782_53834(Microsoft.CodeAnalysis.Diagnostics.DiagnosticQueue
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.DequeueNonLocalDiagnostics(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53782, 53834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_53856_53930(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.FilterDiagnosticsSuppressedInSourceOrByAnalyzers(diagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 53856, 53930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 53605, 53942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 53605, 53942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Diagnostic> FilterDiagnosticsSuppressedInSourceOrByAnalyzers(ImmutableArray<Diagnostic> diagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 53954, 54345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54127, 54257);

                diagnostics = f_222_54141_54256(diagnostics, compilation, f_222_54203_54255(f_222_54203_54225()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54271, 54334);

                return f_222_54278_54333(this, diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 53954, 54345);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                f_222_54203_54225()
                {
                    var return_v = CurrentCompilationData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 54203, 54225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                f_222_54203_54255(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                this_param)
                {
                    var return_v = this_param.SuppressMessageAttributeState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 54203, 54255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_54141_54256(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                suppressMessageState)
                {
                    var return_v = FilterDiagnosticsSuppressedInSource(diagnostics, compilation, suppressMessageState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 54141, 54256);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_54278_54333(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 54278, 54333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 53954, 54345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 53954, 54345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<Diagnostic> FilterDiagnosticsSuppressedInSource(
                    ImmutableArray<Diagnostic> diagnostics,
                    Compilation compilation,
                    SuppressMessageAttributeState suppressMessageState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 54357, 55639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54616, 54707) || true) && (diagnostics.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 54616, 54707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54673, 54692);

                    return diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 54616, 54707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54723, 54805);

                var
                reportSuppressedDiagnostics = f_222_54757_54804(f_222_54757_54776(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54819, 54876);

                var
                builder = f_222_54833_54875()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54899, 54904);
                    for (var
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54890, 55583) || true) && (i < diagnostics.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 54930, 54933)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(222, 54890, 55583))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 54890, 55583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55113, 55214);

                        f_222_55113_55213(diagnostics[i], compilation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55242, 55320);

                        var
                        diagnostic = f_222_55259_55319(suppressMessageState, diagnostics[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55338, 55524) || true) && (!reportSuppressedDiagnostics && (DynAbs.Tracing.TraceSender.Expression_True(222, 55342, 55397) && f_222_55374_55397(diagnostic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 55338, 55524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55496, 55505);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 55338, 55524);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55544, 55568);

                        f_222_55544_55567(
                                        builder, diagnostic);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55599, 55628);

                return f_222_55606_55627(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 54357, 55639);

                Microsoft.CodeAnalysis.CompilationOptions
                f_222_54757_54776(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 54757, 54776);
                    return return_v;
                }


                bool
                f_222_54757_54804(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReportSuppressedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 54757, 54804);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                f_222_54833_54875()
                {
                    var return_v = ImmutableArray.CreateBuilder<Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 54833, 54875);
                    return return_v;
                }


                int
                f_222_55113_55213(Microsoft.CodeAnalysis.Diagnostic
                diagnostic, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    DiagnosticAnalysisContextHelpers.VerifyDiagnosticLocationsInCompilation(diagnostic, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 55113, 55213);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_222_55259_55319(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = this_param.ApplySourceSuppressions(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 55259, 55319);
                    return return_v;
                }


                bool
                f_222_55374_55397(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 55374, 55397);
                    return return_v;
                }


                int
                f_222_55544_55567(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 55544, 55567);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_222_55606_55627(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 55606, 55627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 54357, 55639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 54357, 55639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsInGeneratedCode(Location location, Compilation compilation, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 55651, 60911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55787, 55907) || true) && (f_222_55791_55821() || (DynAbs.Tracing.TraceSender.Expression_False(222, 55791, 55845) || f_222_55825_55845_M(!location.IsInSource)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 55787, 55907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55879, 55892);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 55787, 55907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 55923, 55965);

                f_222_55923_55964(f_222_55936_55955(location) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56041, 56179) || true) && (f_222_56045_56118(this, f_222_56077_56096(location), f_222_56098_56117(location)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 56041, 56179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56152, 56164);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 56041, 56179);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56304, 57449) || true) && (_lazyGeneratedCodeAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 56304, 57449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56377, 56502);

                    var
                    generatedCodeSymbolsInTree = f_222_56410_56501(f_222_56449_56468(location), compilation, cancellationToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56520, 57434) || true) && (f_222_56524_56556(generatedCodeSymbolsInTree) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 56520, 57434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56602, 56664);

                        var
                        model = f_222_56614_56663(compilation, f_222_56643_56662(location))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56695, 56808);
                            for (var
        node = f_222_56702_56808(f_222_56702_56748(f_222_56702_56721(location), cancellationToken), f_222_56758_56777(location), getInnermostNodeForTie: true)
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56686, 57415) || true) && (node != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56874, 56892)
        , node = f_222_56881_56892(node), DynAbs.Tracing.TraceSender.TraceExitCondition(222, 56686, 57415))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 56686, 57415);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 56942, 57021);

                                var
                                declaredSymbols = f_222_56964_57020(model, node, cancellationToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57047, 57085);

                                f_222_57047_57084(declaredSymbols != null);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57113, 57392);
                                    foreach (var symbol in f_222_57136_57151_I(declaredSymbols))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 57113, 57392);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57209, 57365) || true) && (f_222_57213_57256(generatedCodeSymbolsInTree, symbol))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 57209, 57365);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57322, 57334);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 57209, 57365);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 57113, 57392);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 280);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 280);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 730);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 730);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 56520, 57434);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 56304, 57449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57465, 57478);

                return false;

                ImmutableHashSet<ISymbol> getOrComputeGeneratedCodeSymbolsInTree(SyntaxTree tree, Compilation compilation, CancellationToken cancellationToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 57494, 60900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57670, 57723);

                        f_222_57670_57722(f_222_57683_57713() != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57741, 57791);

                        f_222_57741_57790(_lazyGeneratedCodeAttribute != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57811, 57859);

                        ImmutableHashSet<ISymbol>?
                        generatedCodeSymbols
                        = default(ImmutableHashSet<ISymbol>?);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57883, 57913);
                        lock (f_222_57883_57913())
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 57955, 58134) || true) && (f_222_57959_58033(f_222_57959_57989(), tree, out generatedCodeSymbols))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 57955, 58134);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58083, 58111);

                                return generatedCodeSymbols;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 57955, 58134);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58173, 58297);

                        generatedCodeSymbols = f_222_58196_58296(tree, compilation, _lazyGeneratedCodeAttribute, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58323, 58353);

                        lock (f_222_58323_58353())
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58395, 58451);

                            ImmutableHashSet<ISymbol>?
                            existingGeneratedCodeSymbols
                            = default(ImmutableHashSet<ISymbol>?);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58473, 58869) || true) && (!f_222_58478_58560(f_222_58478_58508(), tree, out existingGeneratedCodeSymbols))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 58473, 58869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58610, 58673);

                                f_222_58610_58672(f_222_58610_58640(), tree, generatedCodeSymbols);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 58473, 58869);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 58473, 58869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58771, 58846);

                                f_222_58771_58845(f_222_58784_58844(existingGeneratedCodeSymbols, generatedCodeSymbols));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 58473, 58869);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 58908, 58936);

                        return generatedCodeSymbols;

                        static ImmutableHashSet<ISymbol> computeGeneratedCodeSymbolsInTree(SyntaxTree tree, Compilation compilation, INamedTypeSymbol generatedCodeAttribute, CancellationToken cancellationToken)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 58956, 60885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59271, 59332);

                                var
                                walker = f_222_59284_59331(cancellationToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59354, 59400);

                                f_222_59354_59399(walker, f_222_59367_59398(tree, cancellationToken));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59422, 59572) || true) && (f_222_59426_59460_M(!walker.HasGeneratedCodeIdentifier))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 59422, 59572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59510, 59549);

                                    return ImmutableHashSet<ISymbol>.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 59422, 59572);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59596, 59643);

                                var
                                model = f_222_59608_59642(compilation, tree)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59665, 59708);

                                var
                                root = f_222_59676_59707(tree, cancellationToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59730, 59755);

                                var
                                span = f_222_59741_59754(root)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59777, 59850);

                                var
                                declarationInfoBuilder = f_222_59806_59849()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 59872, 59998);

                                f_222_59872_59997(model, span, getSymbol: true, builder: declarationInfoBuilder, cancellationToken: cancellationToken);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60022, 60088);

                                ImmutableHashSet<ISymbol>.Builder?
                                generatedSymbolsBuilder = null
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60110, 60677);
                                    foreach (var declarationInfo in f_222_60142_60164_I(declarationInfoBuilder))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 60110, 60677);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60214, 60258);

                                        var
                                        symbol = declarationInfo.DeclaredSymbol
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60284, 60654) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 60288, 60433) && f_222_60335_60433(symbol, generatedCodeAttribute)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 60284, 60654);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60491, 60561);

                                            generatedSymbolsBuilder ??= f_222_60519_60560();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60591, 60627);

                                            f_222_60591_60626(generatedSymbolsBuilder, symbol);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 60284, 60654);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 60110, 60677);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 568);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 568);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60701, 60731);

                                f_222_60701_60730(
                                                    declarationInfoBuilder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 60753, 60866);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(222, 60760, 60791) || ((generatedSymbolsBuilder != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 60794, 60831)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 60834, 60865))) ? f_222_60794_60831(generatedSymbolsBuilder) : ImmutableHashSet<ISymbol>.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 58956, 60885);

                                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.GeneratedCodeTokenWalker
                                f_222_59284_59331(System.Threading.CancellationToken
                                cancellationToken)
                                {
                                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.GeneratedCodeTokenWalker(cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59284, 59331);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.SyntaxNode
                                f_222_59367_59398(Microsoft.CodeAnalysis.SyntaxTree
                                this_param, System.Threading.CancellationToken
                                cancellationToken)
                                {
                                    var return_v = this_param.GetRoot(cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59367, 59398);
                                    return return_v;
                                }


                                int
                                f_222_59354_59399(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.GeneratedCodeTokenWalker
                                this_param, Microsoft.CodeAnalysis.SyntaxNode
                                node)
                                {
                                    this_param.Visit(node);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59354, 59399);
                                    return 0;
                                }


                                bool
                                f_222_59426_59460_M(bool
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 59426, 59460);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.SemanticModel
                                f_222_59608_59642(Microsoft.CodeAnalysis.Compilation
                                this_param, Microsoft.CodeAnalysis.SyntaxTree
                                syntaxTree)
                                {
                                    var return_v = this_param.GetSemanticModel(syntaxTree);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59608, 59642);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.SyntaxNode
                                f_222_59676_59707(Microsoft.CodeAnalysis.SyntaxTree
                                this_param, System.Threading.CancellationToken
                                cancellationToken)
                                {
                                    var return_v = this_param.GetRoot(cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59676, 59707);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Text.TextSpan
                                f_222_59741_59754(Microsoft.CodeAnalysis.SyntaxNode
                                this_param)
                                {
                                    var return_v = this_param.FullSpan;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 59741, 59754);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                                f_222_59806_59849()
                                {
                                    var return_v = ArrayBuilder<DeclarationInfo>.GetInstance();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59806, 59849);
                                    return return_v;
                                }


                                int
                                f_222_59872_59997(Microsoft.CodeAnalysis.SemanticModel
                                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                                span, bool
                                getSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                                builder, System.Threading.CancellationToken
                                cancellationToken)
                                {
                                    this_param.ComputeDeclarationsInSpan(span, getSymbol: getSymbol, builder: builder, cancellationToken: cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 59872, 59997);
                                    return 0;
                                }


                                bool
                                f_222_60335_60433(Microsoft.CodeAnalysis.ISymbol
                                symbol, Microsoft.CodeAnalysis.INamedTypeSymbol
                                generatedCodeAttribute)
                                {
                                    var return_v = GeneratedCodeUtilities.IsGeneratedSymbolWithGeneratedCodeAttribute(symbol, generatedCodeAttribute);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60335, 60433);
                                    return return_v;
                                }


                                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>.Builder
                                f_222_60519_60560()
                                {
                                    var return_v = ImmutableHashSet.CreateBuilder<ISymbol>();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60519, 60560);
                                    return return_v;
                                }


                                bool
                                f_222_60591_60626(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>.Builder
                                this_param, Microsoft.CodeAnalysis.ISymbol
                                item)
                                {
                                    var return_v = this_param.Add(item);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60591, 60626);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                                f_222_60142_60164_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60142, 60164);
                                    return return_v;
                                }


                                int
                                f_222_60701_60730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                                this_param)
                                {
                                    this_param.Free();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60701, 60730);
                                    return 0;
                                }


                                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                                f_222_60794_60831(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>.Builder
                                this_param)
                                {
                                    var return_v = this_param.ToImmutable();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 60794, 60831);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 58956, 60885);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 58956, 60885);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 57494, 60900);

                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_57683_57713()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 57683, 57713);
                            return return_v;
                        }


                        int
                        f_222_57670_57722(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57670, 57722);
                            return 0;
                        }


                        int
                        f_222_57741_57790(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57741, 57790);
                            return 0;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_57883_57913()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 57883, 57913);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_57959_57989()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 57959, 57989);
                            return return_v;
                        }


                        bool
                        f_222_57959_58033(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        key, out System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57959, 58033);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                        f_222_58196_58296(Microsoft.CodeAnalysis.SyntaxTree
                        tree, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.INamedTypeSymbol
                        generatedCodeAttribute, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = computeGeneratedCodeSymbolsInTree(tree, compilation, generatedCodeAttribute, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 58196, 58296);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_58323_58353()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 58323, 58353);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_58478_58508()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 58478, 58508);
                            return return_v;
                        }


                        bool
                        f_222_58478_58560(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        key, out System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 58478, 58560);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        f_222_58610_58640()
                        {
                            var return_v = GeneratedCodeSymbolsForTreeMap;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 58610, 58640);
                            return return_v;
                        }


                        int
                        f_222_58610_58672(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>>
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        key, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 58610, 58672);
                            return 0;
                        }


                        bool
                        f_222_58784_58844(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                        this_param, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                        other)
                        {
                            var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 58784, 58844);
                            return return_v;
                        }


                        int
                        f_222_58771_58845(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 58771, 58845);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 57494, 60900);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 57494, 60900);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 55651, 60911);

                bool
                f_222_55791_55821()
                {
                    var return_v = TreatAllCodeAsNonGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 55791, 55821);
                    return return_v;
                }


                bool
                f_222_55825_55845_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 55825, 55845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_55936_55955(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 55936, 55955);
                    return return_v;
                }


                int
                f_222_55923_55964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 55923, 55964);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_56077_56096(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56077, 56096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_222_56098_56117(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56098, 56117);
                    return return_v;
                }


                bool
                f_222_56045_56118(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.IsGeneratedOrHiddenCodeLocation(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56045, 56118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_56449_56468(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56449, 56468);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                f_222_56410_56501(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = getOrComputeGeneratedCodeSymbolsInTree(tree, compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56410, 56501);
                    return return_v;
                }


                int
                f_222_56524_56556(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56524, 56556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_56643_56662(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56643, 56662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_222_56614_56663(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56614, 56663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_56702_56721(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56702, 56721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_56702_56748(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56702, 56748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_222_56758_56777(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56758, 56777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_56702_56808(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, bool
                getInnermostNodeForTie)
                {
                    var return_v = this_param.FindNode(span, getInnermostNodeForTie: getInnermostNodeForTie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56702, 56808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_222_56881_56892(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 56881, 56892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_222_56964_57020(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbolsForNode(declaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 56964, 57020);
                    return return_v;
                }


                int
                f_222_57047_57084(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57047, 57084);
                    return 0;
                }


                bool
                f_222_57213_57256(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.ISymbol>
                this_param, Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57213, 57256);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_222_57136_57151_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 57136, 57151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 55651, 60911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 55651, 60911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsAnalyzerSuppressedForTree(DiagnosticAnalyzer analyzer, SyntaxTree tree, SyntaxTreeOptionsProvider? options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 60923, 61390);
                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer> suppressedAnalyzers = default(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61070, 61317) || true) && (!f_222_61075_61151(f_222_61075_61104(), tree, out suppressedAnalyzers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 61070, 61317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61185, 61302);

                    suppressedAnalyzers = f_222_61207_61301(f_222_61207_61236(), tree, f_222_61252_61300(this, tree, options));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 61070, 61317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61333, 61379);

                return f_222_61340_61378(suppressedAnalyzers, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 60923, 61390);

                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                f_222_61075_61104()
                {
                    var return_v = SuppressedAnalyzersForTreeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 61075, 61104);
                    return return_v;
                }


                bool
                f_222_61075_61151(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61075, 61151);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                f_222_61207_61236()
                {
                    var return_v = SuppressedAnalyzersForTreeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 61207, 61236);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_61252_61300(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                options)
                {
                    var return_v = this_param.ComputeSuppressedAnalyzersForTree(tree, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61252, 61300);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_61207_61301(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61207, 61301);
                    return return_v;
                }


                bool
                f_222_61340_61378(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61340, 61378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 60923, 61390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 60923, 61390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableHashSet<DiagnosticAnalyzer> ComputeSuppressedAnalyzersForTree(SyntaxTree tree, SyntaxTreeOptionsProvider? options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 61402, 64054);
                Microsoft.CodeAnalysis.ReportDiagnostic configuredSeverity = default(Microsoft.CodeAnalysis.ReportDiagnostic);
                Microsoft.CodeAnalysis.ReportDiagnostic diagnosticSeverity = default(Microsoft.CodeAnalysis.ReportDiagnostic);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61558, 61676) || true) && (options is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 61558, 61676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61611, 61661);

                    return ImmutableHashSet<DiagnosticAnalyzer>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 61558, 61676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61692, 61772);

                ImmutableHashSet<DiagnosticAnalyzer>.Builder?
                suppressedAnalyzersBuilder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61786, 63897);
                    foreach (var analyzer in f_222_61811_61832_I(f_222_61811_61832()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 61786, 63897);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 61866, 62131) || true) && (f_222_61870_61913(f_222_61870_61894(), analyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 61866, 62131);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62103, 62112);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 61866, 62131);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62151, 62628) || true) && ((f_222_62156_62195(f_222_62156_62176(), analyzer) || (DynAbs.Tracing.TraceSender.Expression_False(222, 62156, 62241) || f_222_62199_62241(f_222_62199_62222(), analyzer))) && (DynAbs.Tracing.TraceSender.Expression_True(222, 62155, 62311) && !f_222_62268_62311(this, analyzer)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 62151, 62628);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62600, 62609);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 62151, 62628);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62648, 62744);

                        var
                        descriptors = f_222_62666_62743(f_222_62666_62681(), analyzer, f_222_62726_62742())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62762, 62800);

                        var
                        hasUnsuppressedDiagnostic = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62818, 63624);
                            foreach (var descriptor in f_222_62845_62856_I(descriptors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 62818, 63624);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 62898, 63017);

                                _ = f_222_62902_63016(options, f_222_62938_62951(descriptor), f_222_62953_62987(f_222_62953_62969()), out configuredSeverity);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63039, 63270) || true) && (f_222_63043_63157(options, tree, f_222_63079_63092(descriptor), f_222_63094_63128(f_222_63094_63110()), out diagnosticSeverity))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 63039, 63270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63207, 63247);

                                    configuredSeverity = diagnosticSeverity;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 63039, 63270);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63294, 63605) || true) && (configuredSeverity != ReportDiagnostic.Suppress)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 63294, 63605);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63517, 63550);

                                    hasUnsuppressedDiagnostic = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(222, 63576, 63582);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 63294, 63605);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 62818, 63624);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 807);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 807);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63644, 63882) || true) && (!hasUnsuppressedDiagnostic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 63644, 63882);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63716, 63800);

                            suppressedAnalyzersBuilder ??= f_222_63747_63799();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63822, 63863);

                            f_222_63822_63862(suppressedAnalyzersBuilder, analyzer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 63644, 63882);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 61786, 63897);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 2112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 2112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 63913, 64043);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(222, 63920, 63954) || ((suppressedAnalyzersBuilder != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 63957, 63997)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 64000, 64042))) ? f_222_63957_63997(suppressedAnalyzersBuilder) : ImmutableHashSet<DiagnosticAnalyzer>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 61402, 64054);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_61811_61832()
                {
                    var return_v = UnsuppressedAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 61811, 61832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_61870_61894()
                {
                    var return_v = NonConfigurableAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 61870, 61894);
                    return return_v;
                }


                bool
                f_222_61870_61913(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61870, 61913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_62156_62176()
                {
                    var return_v = SymbolStartAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62156, 62176);
                    return return_v;
                }


                bool
                f_222_62156_62195(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62156, 62195);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_62199_62222()
                {
                    var return_v = CompilationEndAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62199, 62222);
                    return return_v;
                }


                bool
                f_222_62199_62241(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62199, 62241);
                    return return_v;
                }


                bool
                f_222_62268_62311(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.ShouldSkipAnalysisOnGeneratedCode(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62268, 62311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_62666_62681()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62666, 62681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_62726_62742()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62726, 62742);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_222_62666_62743(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedDiagnosticDescriptors(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62666, 62743);
                    return return_v;
                }


                string
                f_222_62938_62951(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62938, 62951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_62953_62969()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62953, 62969);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_62953_62987(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 62953, 62987);
                    return return_v;
                }


                bool
                f_222_62902_63016(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, string
                diagnosticId, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = this_param.TryGetGlobalDiagnosticValue(diagnosticId, cancellationToken, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62902, 63016);
                    return return_v;
                }


                string
                f_222_63079_63092(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 63079, 63092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_63094_63110()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 63094, 63110);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_63094_63128(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 63094, 63128);
                    return return_v;
                }


                bool
                f_222_63043_63157(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, string
                diagnosticId, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = this_param.TryGetDiagnosticValue(tree, diagnosticId, cancellationToken, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 63043, 63157);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_222_62845_62856_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 62845, 62856);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                f_222_63747_63799()
                {
                    var return_v = ImmutableHashSet.CreateBuilder<DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 63747, 63799);
                    return return_v;
                }


                bool
                f_222_63822_63862(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 63822, 63862);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_61811_61832_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 61811, 61832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_63957_63997(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 63957, 63997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 61402, 64054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 61402, 64054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsInitialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 64092, 64122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64095, 64122);
                    return _lazyInitializeTask != null; DynAbs.Tracing.TraceSender.TraceExitMethod(222, 64092, 64122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 64092, 64122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 64092, 64122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Task WhenInitializedTask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 64312, 64450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64348, 64390);

                    f_222_64348_64389(_lazyInitializeTask != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64408, 64435);

                    return _lazyInitializeTask;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 64312, 64450);

                    int
                    f_222_64348_64389(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 64348, 64389);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 64256, 64461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 64256, 64461);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Task WhenCompletedTask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 64663, 64795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64699, 64738);

                    f_222_64699_64737(_lazyPrimaryTask != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64756, 64780);

                    return _lazyPrimaryTask;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 64663, 64795);

                    int
                    f_222_64699_64737(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 64699, 64737);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 64609, 64806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 64609, 64806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableDictionary<DiagnosticAnalyzer, TimeSpan> AnalyzerExecutionTimes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 64900, 64942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 64903, 64942);
                    return f_222_64903_64942(f_222_64903_64919()); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 64900, 64942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 64900, 64942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 64900, 64942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TimeSpan ResetAnalyzerExecutionTime(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 65027, 65083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65030, 65083);
                return f_222_65030_65083(f_222_65030_65046(), analyzer); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 65027, 65083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 65027, 65083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 65027, 65083);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
            f_222_65030_65046()
            {
                var return_v = AnalyzerExecutor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 65030, 65046);
                return return_v;
            }


            System.TimeSpan
            f_222_65030_65083(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
            this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer)
            {
                var return_v = this_param.ResetAnalyzerExecutionTime(analyzer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65030, 65083);
                return return_v;
            }

        }

        private static ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<ImmutableArray<SymbolAnalyzerAction>>)> MakeSymbolActionsByKind(in AnalyzerActions analyzerActions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 65096, 66709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65286, 65403);

                var
                builder = f_222_65300_65402()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65417, 65507);


                // LAFHIS
                //var actionsByAnalyzers = f_222_65442_65506(analyzerActions.SymbolActions, action => action.Analyzer);
                var actionsByAnalyzers = analyzerActions.SymbolActions.GroupBy
                    <Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    (action => action.Analyzer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65442, 65506);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65521, 65611);

                var
                actionsByKindBuilder = f_222_65548_65610()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65625, 66604);
                    foreach (var analyzerAndActions in f_222_65660_65678_I(actionsByAnalyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 65625, 66604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65712, 65741);

                        f_222_65712_65740(actionsByKindBuilder);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65759, 66402);
                            foreach (var symbolAction in f_222_65788_65806_I(analyzerAndActions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 65759, 66402);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65848, 65879);

                                var
                                kinds = f_222_65860_65878(symbolAction)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65901, 66383);
                                    foreach (int kind in f_222_65922_65938_I(kinds.Distinct()))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 65901, 66383);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 65988, 66023) || true) && (kind > MaxSymbolKind)
                                        )
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 65988, 66023);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66014, 66023);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 65988, 66023);
                                        }
                                        try
                                        {
                                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66086, 66287) || true) && (kind >= f_222_66101_66127(actionsByKindBuilder))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 66086, 66287);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66185, 66260);

                                                f_222_66185_66259(actionsByKindBuilder, f_222_66210_66258());
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 66086, 66287);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 66086, 66287);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 66086, 66287);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66315, 66360);

                                        f_222_66315_66359(f_222_66315_66341(actionsByKindBuilder, kind), symbolAction);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 65901, 66383);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 483);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 483);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 65759, 66402);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 644);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 644);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66422, 66518);

                        var
                        actionsByKind = f_222_66442_66517(f_222_66442_66498(actionsByKindBuilder, a => a.ToImmutableAndFree()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66536, 66589);

                        f_222_66536_66588(builder, (f_222_66549_66571(analyzerAndActions), actionsByKind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 65625, 66604);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66620, 66648);

                f_222_66620_66647(
                            actionsByKindBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66662, 66698);

                return f_222_66669_66697(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 65096, 66709);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                f_222_65300_65402()
                {
                    var return_v = ArrayBuilder<(DiagnosticAnalyzer, ImmutableArray<ImmutableArray<SymbolAnalyzerAction>>)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65300, 65402);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                f_222_65442_65506(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                keySelector)
                {
                    var return_v = source.GroupBy<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65442, 65506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                f_222_65548_65610()
                {
                    var return_v = ArrayBuilder<ArrayBuilder<SymbolAnalyzerAction>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65548, 65610);
                    return return_v;
                }


                int
                f_222_65712_65740(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65712, 65740);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_222_65860_65878(Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Kinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 65860, 65878);
                    return return_v;
                }


                int
                f_222_66101_66127(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 66101, 66127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                f_222_66210_66258()
                {
                    var return_v = ArrayBuilder<SymbolAnalyzerAction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66210, 66258);
                    return return_v;
                }


                int
                f_222_66185_66259(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66185, 66259);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                f_222_66315_66341(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 66315, 66341);
                    return return_v;
                }


                int
                f_222_66315_66359(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66315, 66359);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_222_65922_65938_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65922, 65938);
                    return return_v;
                }


                System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                f_222_65788_65806_I(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65788, 65806);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                f_222_66442_66498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                source, System.Func<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66442, 66498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                f_222_66442_66517(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                items)
                {
                    var return_v = items.ToImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66442, 66517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_66549_66571(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 66549, 66571);
                    return return_v;
                }


                int
                f_222_66536_66588(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                this_param, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer Key, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>> actionsByKind)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66536, 66588);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                f_222_65660_65678_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 65660, 65678);
                    return return_v;
                }


                int
                f_222_66620_66647(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66620, 66647);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                f_222_66669_66697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66669, 66697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 65096, 66709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 65096, 66709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<TAnalyzerAction>)> MakeActionsByAnalyzer<TAnalyzerAction>(in ImmutableArray<TAnalyzerAction> analyzerActions)
                    where TAnalyzerAction : AnalyzerAction
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 66721, 67415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 66973, 67069);

                var
                builder = f_222_66987_67068()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67083, 67159);

                // LAFHIS
                //var actionsByAnalyzers = f_222_67108_67158(ref analyzerActions, action => action.Analyzer);
                var actionsByAnalyzers = analyzerActions.GroupBy<TAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    (action => action.Analyzer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67108, 67158);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67173, 67352);
                    foreach (var analyzerAndActions in f_222_67208_67226_I(actionsByAnalyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 67173, 67352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67260, 67337);

                        f_222_67260_67336(builder, (f_222_67273_67295(analyzerAndActions), f_222_67297_67334(analyzerAndActions)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 67173, 67352);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67368, 67404);

                return f_222_67375_67403(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 66721, 67415);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>)>
                f_222_66987_67068()
                {
                    var return_v = ArrayBuilder<(DiagnosticAnalyzer, ImmutableArray<TAnalyzerAction>)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 66987, 67068);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, TAnalyzerAction>>
                f_222_67108_67158(ref System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                source, System.Func<TAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                keySelector)
                {
                    var return_v = source.GroupBy<TAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67108, 67158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_67273_67295(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, TAnalyzerAction>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 67273, 67295);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                f_222_67297_67334(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, TAnalyzerAction>
                items)
                {
                    var return_v = items.ToImmutableArray<TAnalyzerAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67297, 67334);
                    return return_v;
                }


                int
                f_222_67260_67336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>)>
                this_param, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer Key, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67260, 67336);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, TAnalyzerAction>>
                f_222_67208_67226_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, TAnalyzerAction>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67208, 67226);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>)>
                f_222_67375_67403(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<TAnalyzerAction>)>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67375, 67403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 66721, 67415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 66721, 67415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableHashSet<DiagnosticAnalyzer> MakeCompilationEndAnalyzers(ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<CompilationAnalyzerAction>)> compilationEndActionsByAnalyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 67427, 67913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67644, 67711);

                var
                builder = f_222_67658_67710()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67725, 67857);
                    foreach (var (analyzer, _) in f_222_67755_67786_I(compilationEndActionsByAnalyzer))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 67725, 67857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67820, 67842);

                        f_222_67820_67841(builder, analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 67725, 67857);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 67873, 67902);

                return f_222_67880_67901(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 67427, 67913);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                f_222_67658_67710()
                {
                    var return_v = ImmutableHashSet.CreateBuilder<DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67658, 67710);
                    return return_v;
                }


                bool
                f_222_67820_67841(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67820, 67841);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                f_222_67755_67786_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67755, 67786);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_67880_67901(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 67880, 67901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 67427, 67913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 67427, 67913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task ProcessCompilationEventsAsync(AnalysisScope analysisScope, AnalysisState? analysisState, bool prePopulatedEventQueue, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 67925, 71280);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68159, 68208);

                    CompilationCompletedEvent?
                    completedEvent = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68228, 70787) || true) && (f_222_68232_68264(analysisScope))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 68228, 70787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68524, 68634);

                        var
                        workerCount = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 68542, 68564) || ((prePopulatedEventQueue && DynAbs.Tracing.TraceSender.Conditional_F2(222, 68567, 68618)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 68621, 68633))) ? f_222_68567_68618(f_222_68576_68603(f_222_68576_68597()), _workerCount) : _workerCount
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68658, 68726);

                        var
                        workerTasks = new Task<CompilationCompletedEvent?>[workerCount]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68757, 68762);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68748, 69181) || true) && (i < workerCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68781, 68784)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(222, 68748, 69181))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 68748, 69181);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 68984, 69158);

                                workerTasks[i] = f_222_69001_69157(async () => await ProcessCompilationEventsCoreAsync(analysisScope, analysisState, prePopulatedEventQueue, cancellationToken).ConfigureAwait(false));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 434);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 434);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69205, 69254);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69349, 69486);

                        var
                        syntaxTreeActionsTask = f_222_69377_69485(() => ExecuteSyntaxTreeActions(analysisScope, analysisState, cancellationToken), cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69585, 69730);

                        var
                        additionalFileActionsTask = f_222_69617_69729(() => ExecuteAdditionalFileActions(analysisScope, analysisState, cancellationToken), cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69837, 69955);

                        await f_222_69843_69954(f_222_69843_69932(f_222_69856_69931(f_222_69856_69897(workerTasks, syntaxTreeActionsTask), additionalFileActionsTask)), false);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69988, 69993);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 69979, 70336) || true) && (i < workerCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70012, 70015)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(222, 69979, 70336))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 69979, 70336);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70065, 70313) || true) && (f_222_70069_70090(workerTasks[i]) == TaskStatus.RanToCompletion && (DynAbs.Tracing.TraceSender.Expression_True(222, 70069, 70153) && f_222_70124_70145(workerTasks[i]) != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 70065, 70313);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70211, 70250);

                                    completedEvent = f_222_70228_70249(workerTasks[i]);
                                    DynAbs.Tracing.TraceSender.TraceBreak(222, 70280, 70286);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 70065, 70313);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 358);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 358);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 68228, 70787);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 68228, 70787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70418, 70570);

                        completedEvent = await f_222_70441_70569(f_222_70441_70547(this, analysisScope, analysisState, prePopulatedEventQueue, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70594, 70668);

                        f_222_70594_70667(this, analysisScope, analysisState, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70690, 70768);

                        f_222_70690_70767(this, analysisScope, analysisState, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 68228, 70787);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70884, 71082) || true) && (completedEvent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 70884, 71082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 70952, 71063);

                        await f_222_70958_71062(f_222_70958_71040(this, completedEvent, analysisScope, analysisState, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 70884, 71082);
                    }
                }
                catch (Exception e) when (f_222_71137_71183(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(222, 71111, 71269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 71217, 71254);

                    throw f_222_71223_71253();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(222, 71111, 71269);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 67925, 71280);

                bool
                f_222_68232_68264(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 68232, 68264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_68576_68597()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 68576, 68597);
                    return return_v;
                }


                int
                f_222_68576_68603(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 68576, 68603);
                    return return_v;
                }


                int
                f_222_68567_68618(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 68567, 68618);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                f_222_69001_69157(System.Func<System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent>?>
                function)
                {
                    var return_v = Task.Run(function);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69001, 69157);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_69377_69485(System.Action
                action, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(action, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69377, 69485);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_69617_69729(System.Action
                action, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = Task.Run(action, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69617, 69729);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                f_222_69856_69897(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>[]
                source, System.Threading.Tasks.Task
                value)
                {
                    var return_v = source.Concat<System.Threading.Tasks.Task>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69856, 69897);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                f_222_69856_69931(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                source, System.Threading.Tasks.Task
                value)
                {
                    var return_v = source.Concat<System.Threading.Tasks.Task>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69856, 69931);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_69843_69932(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                tasks)
                {
                    var return_v = Task.WhenAll(tasks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69843, 69932);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_69843_69954(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 69843, 69954);
                    return return_v;
                }


                System.Threading.Tasks.TaskStatus
                f_222_70069_70090(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                this_param)
                {
                    var return_v = this_param.Status;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 70069, 70090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?
                f_222_70124_70145(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 70124, 70145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?
                f_222_70228_70249(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 70228, 70249);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                f_222_70441_70547(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                prePopulatedEventQueue, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ProcessCompilationEventsCoreAsync(analysisScope, analysisState, prePopulatedEventQueue, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70441, 70547);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                f_222_70441_70569(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent?>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70441, 70569);
                    return return_v;
                }


                int
                f_222_70594_70667(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ExecuteSyntaxTreeActions(analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70594, 70667);
                    return 0;
                }


                int
                f_222_70690_70767(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ExecuteAdditionalFileActions(analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70690, 70767);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_222_70958_71040(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                e, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ProcessEventAsync((Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)e, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70958, 71040);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_70958_71062(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 70958, 71062);
                    return return_v;
                }


                bool
                f_222_71137_71183(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 71137, 71183);
                    return return_v;
                }


                System.Exception
                f_222_71223_71253()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 71223, 71253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 67925, 71280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 67925, 71280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<CompilationCompletedEvent?> ProcessCompilationEventsCoreAsync(AnalysisScope analysisScope, AnalysisState? analysisState, bool prePopulatedEventQueue, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 71292, 74265);
                Microsoft.CodeAnalysis.Diagnostics.CompilationEvent compilationEvent = default(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 71558, 71607);

                    CompilationCompletedEvent?
                    completedEvent = null
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 71627, 74025) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 71627, 74025);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 71680, 71729);

                            cancellationToken.ThrowIfCancellationRequested();

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 71953, 72158) || true) && ((prePopulatedEventQueue || (DynAbs.Tracing.TraceSender.Expression_False(222, 71958, 72017) || f_222_71984_72017(f_222_71984_72005()))) && (DynAbs.Tracing.TraceSender.Expression_True(222, 71957, 72079) && f_222_72047_72074(f_222_72047_72068()) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 71953, 72158);
                                DynAbs.Tracing.TraceSender.TraceBreak(222, 72129, 72135);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 71953, 72158);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 72182, 73368) || true) && (!f_222_72187_72245(f_222_72187_72208(), out compilationEvent))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 72182, 73368);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 72295, 73345) || true) && (!prePopulatedEventQueue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 72295, 73345);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 72380, 72485);

                                    var
                                    optionalEvent = await f_222_72406_72462(f_222_72406_72427(), cancellationToken).ConfigureAwait(false)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 72515, 73111) || true) && (f_222_72519_72542_M(!optionalEvent.HasValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 72515, 73111);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 72911, 73040);

                                        f_222_72911_73039(f_222_72924_72957(f_222_72924_72945()), "TryDequeueAsync should provide a value unless the AsyncQueue<T> is completed.");
                                        DynAbs.Tracing.TraceSender.TraceBreak(222, 73074, 73080);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 72515, 73111);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73143, 73182);

                                    compilationEvent = optionalEvent.Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 72295, 73345);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 72295, 73345);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73296, 73318);

                                    return completedEvent;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 72295, 73345);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 72182, 73368);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73643, 73869) || true) && (compilationEvent is CompilationCompletedEvent compilationCompletedEvent)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 73643, 73869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73768, 73811);

                                completedEvent = compilationCompletedEvent;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73837, 73846);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 73643, 73869);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 73893, 74006);

                            await f_222_73899_74005(f_222_73899_73983(this, compilationEvent, analysisScope, analysisState, cancellationToken), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 71627, 74025);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 71627, 74025);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 71627, 74025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74045, 74067);

                    return completedEvent;
                }
                catch (Exception e) when (f_222_74122_74168(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(222, 74096, 74254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74202, 74239);

                    throw f_222_74208_74238();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(222, 74096, 74254);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 71292, 74265);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_71984_72005()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 71984, 72005);
                    return return_v;
                }


                bool
                f_222_71984_72017(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 71984, 72017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_72047_72068()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72047, 72068);
                    return return_v;
                }


                int
                f_222_72047_72074(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72047, 72074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_72187_72208()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72187, 72208);
                    return return_v;
                }


                bool
                f_222_72187_72245(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, out Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                d)
                {
                    var return_v = this_param.TryDequeue(out d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 72187, 72245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_72406_72427()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72406, 72427);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Optional<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                f_222_72406_72462(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryDequeueAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 72406, 72462);
                    return return_v;
                }


                bool
                f_222_72519_72542_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72519, 72542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_222_72924_72945()
                {
                    var return_v = CompilationEventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72924, 72945);
                    return return_v;
                }


                bool
                f_222_72924_72957(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 72924, 72957);
                    return return_v;
                }


                int
                f_222_72911_73039(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 72911, 73039);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_222_73899_73983(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                e, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ProcessEventAsync(e, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 73899, 73983);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_73899_74005(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 73899, 74005);
                    return return_v;
                }


                bool
                f_222_74122_74168(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 74122, 74168);
                    return return_v;
                }


                System.Exception
                f_222_74208_74238()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 74208, 74238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 71292, 74265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 71292, 74265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task ProcessEventAsync(CompilationEvent e, AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 74277, 75279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74454, 74601);

                EventProcessedState
                eventProcessedState = await f_222_74502_74578(this, e, analysisScope, analysisState, cancellationToken).ConfigureAwait(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74617, 74671);

                ImmutableArray<DiagnosticAnalyzer>
                processedAnalyzers
                = default(ImmutableArray<DiagnosticAnalyzer>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74685, 75141);

                switch (f_222_74693_74717(eventProcessedState))
                {

                    case EventProcessedStateKind.Processed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 74685, 75141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74812, 74857);

                        processedAnalyzers = f_222_74833_74856(analysisScope);
                        DynAbs.Tracing.TraceSender.TraceBreak(222, 74879, 74885);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 74685, 75141);

                    case EventProcessedStateKind.PartiallyProcessed:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 74685, 75141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 74975, 75041);

                        processedAnalyzers = f_222_74996_75040(eventProcessedState);
                        DynAbs.Tracing.TraceSender.TraceBreak(222, 75063, 75069);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 74685, 75141);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 74685, 75141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75119, 75126);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 74685, 75141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75157, 75268);

                await f_222_75163_75267(f_222_75163_75245(this, e, processedAnalyzers, analysisState, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 74277, 75279);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState>
                f_222_74502_74578(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryProcessEventCoreAsync(compilationEvent, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 74502, 74578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedStateKind
                f_222_74693_74717(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 74693, 74717);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_74833_74856(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 74833, 74856);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_74996_75040(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
                this_param)
                {
                    var return_v = this_param.SubsetProcessedAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 74996, 75040);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_75163_75245(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                processedAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.OnEventProcessedCoreAsync(compilationEvent, processedAnalyzers, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 75163, 75245);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_75163_75267(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 75163, 75267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 74277, 75279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 74277, 75279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task OnEventProcessedCoreAsync(CompilationEvent compilationEvent, ImmutableArray<DiagnosticAnalyzer> processedAnalyzers, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 75291, 78244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75517, 75763) || true) && (analysisState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 75517, 75763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75576, 75723);

                    await f_222_75582_75722(f_222_75582_75700(analysisState, compilationEvent, processedAnalyzers, onSymbolAndMembersProcessedAsync), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75741, 75748);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 75517, 75763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75779, 76764);

                switch (compilationEvent)
                {

                    case SymbolDeclaredCompilationEvent symbolDeclaredEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 75779, 76764);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 75915, 76262) || true) && (f_222_75919_75934().SymbolStartActionsCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 75915, 76262);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76012, 76239);
                                foreach (var analyzer in f_222_76037_76055_I(processedAnalyzers))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 76012, 76239);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76113, 76212);

                                    await f_222_76119_76211(f_222_76119_76189(f_222_76152_76178(symbolDeclaredEvent), analyzer), false);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 76012, 76239);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 228);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 228);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 75915, 76262);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(222, 76286, 76292);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 75779, 76764);

                    case CompilationUnitCompletedEvent compilationUnitCompletedEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 75779, 76764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76399, 76522);

                        f_222_76399_76521(f_222_76399_76420(), f_222_76432_76477(compilationUnitCompletedEvent), f_222_76479_76520(compilationUnitCompletedEvent));
                        DynAbs.Tracing.TraceSender.TraceBreak(222, 76544, 76550);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 75779, 76764);

                    case CompilationCompletedEvent compilationCompletedEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 75779, 76764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76649, 76721);

                        f_222_76649_76720(f_222_76649_76670(), f_222_76682_76719(compilationCompletedEvent));
                        DynAbs.Tracing.TraceSender.TraceBreak(222, 76743, 76749);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 75779, 76764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76780, 76787);

                return;

                async Task onSymbolAndMembersProcessedAsync(ISymbol symbol, DiagnosticAnalyzer analyzer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 76803, 77554);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 76924, 77071) || true) && (f_222_76928_76943().SymbolStartActionsCount == 0 || (DynAbs.Tracing.TraceSender.Expression_False(222, 76928, 77003) || f_222_76976_77003(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 76924, 77071);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77045, 77052);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 76924, 77071);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77091, 77280) || true) && (symbol is INamespaceOrTypeSymbol namespaceOrType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 77091, 77280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77185, 77261);

                            f_222_77185_77260(f_222_77185_77214(), (namespaceOrType, analyzer), out _);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 77091, 77280);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77300, 77413);

                        await f_222_77306_77412(f_222_77306_77390(f_222_77345_77371(symbol), symbol, analyzer), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77431, 77539);

                        await f_222_77437_77538(f_222_77437_77516(f_222_77476_77497(symbol), symbol, analyzer), false);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 76803, 77554);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_222_76928_76943()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76928, 76943);
                            return return_v;
                        }


                        bool
                        f_222_76976_77003(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.IsImplicitlyDeclared;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76976, 77003);
                            return return_v;
                        }


                        System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                        f_222_77185_77214()
                        {
                            var return_v = PerSymbolAnalyzerActionsCache;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 77185, 77214);
                            return return_v;
                        }


                        bool
                        f_222_77185_77260(System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                        this_param, (Microsoft.CodeAnalysis.INamespaceOrTypeSymbol namespaceOrType, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                        key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                        value)
                        {
                            var return_v = this_param.TryRemove(((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer))key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77185, 77260);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.INamespaceSymbol
                        f_222_77345_77371(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 77345, 77371);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_222_77306_77390(Microsoft.CodeAnalysis.INamespaceSymbol
                        containerSymbol, Microsoft.CodeAnalysis.ISymbol
                        processedMemberSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            var return_v = processContainerOnMemberCompletedAsync((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)containerSymbol, processedMemberSymbol, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77306, 77390);
                            return return_v;
                        }


                        System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                        f_222_77306_77412(System.Threading.Tasks.Task
                        this_param, bool
                        continueOnCapturedContext)
                        {
                            var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77306, 77412);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.INamedTypeSymbol
                        f_222_77476_77497(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 77476, 77497);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_222_77437_77516(Microsoft.CodeAnalysis.INamedTypeSymbol
                        containerSymbol, Microsoft.CodeAnalysis.ISymbol
                        processedMemberSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            var return_v = processContainerOnMemberCompletedAsync((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol)containerSymbol, processedMemberSymbol, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77437, 77516);
                            return return_v;
                        }


                        System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                        f_222_77437_77538(System.Threading.Tasks.Task
                        this_param, bool
                        continueOnCapturedContext)
                        {
                            var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77437, 77538);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 76803, 77554);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 76803, 77554);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                async Task processContainerOnMemberCompletedAsync(INamespaceOrTypeSymbol containerSymbol, ISymbol processedMemberSymbol, DiagnosticAnalyzer analyzer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 77570, 78233);
                        Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent? processedContainerEvent = default(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 77752, 78218) || true) && (containerSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 77756, 78011) && f_222_77804_78011(f_222_77804_77820(), containerSymbol, processedMemberSymbol, analyzer, s_getTopmostNodeForAnalysis, analysisState, out processedContainerEvent)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 77752, 78218);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 78053, 78199);

                            await f_222_78059_78198(f_222_78059_78176(this, processedContainerEvent, f_222_78110_78141(analyzer), analysisState, cancellationToken), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 77752, 78218);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 77570, 78233);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_77804_77820()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 77804, 77820);
                            return return_v;
                        }


                        bool
                        f_222_77804_78011(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                        containingSymbol, Microsoft.CodeAnalysis.ISymbol
                        processedMemberSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                        getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                        analysisState, out Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent?
                        containingSymbolDeclaredEvent)
                        {
                            var return_v = this_param.TryExecuteSymbolEndActionsForContainer(containingSymbol, processedMemberSymbol, analyzer, getTopMostNodeForAnalysis, analysisState, out containingSymbolDeclaredEvent);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 77804, 78011);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        f_222_78110_78141(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 78110, 78141);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_222_78059_78176(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                        compilationEvent, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        processedAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                        analysisState, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = this_param.OnEventProcessedCoreAsync((Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)compilationEvent, processedAnalyzers, analysisState, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 78059, 78176);
                            return return_v;
                        }


                        System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                        f_222_78059_78198(System.Threading.Tasks.Task
                        this_param, bool
                        continueOnCapturedContext)
                        {
                            var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 78059, 78198);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 77570, 78233);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 77570, 78233);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 75291, 78244);

                System.Threading.Tasks.Task
                f_222_75582_75700(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.Tasks.Task>
                onSymbolAndMembersProcessedAsync)
                {
                    var return_v = this_param.OnCompilationEventProcessedAsync(compilationEvent, analyzers, onSymbolAndMembersProcessedAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 75582, 75700);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_75582_75722(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 75582, 75722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_75919_75934()
                {
                    var return_v = AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 75919, 75934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_222_76152_76178(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76152, 76178);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_222_76119_76189(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = onSymbolAndMembersProcessedAsync(symbol, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 76119, 76189);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_222_76119_76211(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 76119, 76211);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_76037_76055_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 76037, 76055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                f_222_76399_76420()
                {
                    var return_v = SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76399, 76420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_76432_76477(Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76432, 76477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_76479_76520(Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76479, 76520);
                    return return_v;
                }


                int
                f_222_76399_76521(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ClearCache(tree, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 76399, 76521);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                f_222_76649_76670()
                {
                    var return_v = SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76649, 76670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_76682_76719(Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 76682, 76719);
                    return return_v;
                }


                int
                f_222_76649_76720(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ClearCache(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 76649, 76720);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 75291, 78244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 75291, 78244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://developercommunity.visualstudio.com/content/problem/805524/ctrl-suggestions-are-very-slow-and-produce-gatheri.html",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<EventProcessedState> TryProcessEventCoreAsync(CompilationEvent compilationEvent, AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 78256, 79873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 78702, 78751);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 78767, 79862);

                return compilationEvent switch
                {
                    SymbolDeclaredCompilationEvent symbolEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 78830, 79016) && DynAbs.Tracing.TraceSender.Expression_True(222, 78830, 79016))
    =>
                        await f_222_78903_78994(this, symbolEvent, analysisScope, analysisState, cancellationToken).ConfigureAwait(false),

                    CompilationUnitCompletedEvent completedEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 79037, 79272) && DynAbs.Tracing.TraceSender.Expression_True(222, 79037, 79272))
    =>
    (DynAbs.Tracing.TraceSender.Conditional_F1(222, 79106, 79205) || ((f_222_79106_79205(this, completedEvent, analysisScope, analysisState, cancellationToken) && DynAbs.Tracing.TraceSender.Conditional_F2(222, 79208, 79237)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 79240, 79272))) ? EventProcessedState.Processed : EventProcessedState.NotProcessed,

                    CompilationCompletedEvent endEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 79293, 79489) && DynAbs.Tracing.TraceSender.Expression_True(222, 79293, 79489))
    =>
    (DynAbs.Tracing.TraceSender.Conditional_F1(222, 79352, 79422) || ((f_222_79352_79422(this, endEvent, analysisScope, analysisState) && DynAbs.Tracing.TraceSender.Conditional_F2(222, 79425, 79454)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 79457, 79489))) ? EventProcessedState.Processed : EventProcessedState.NotProcessed,

                    CompilationStartedEvent startedEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 79510, 79710) && DynAbs.Tracing.TraceSender.Expression_True(222, 79510, 79710))
    =>
    (DynAbs.Tracing.TraceSender.Conditional_F1(222, 79571, 79643) || ((f_222_79571_79643(this, startedEvent, analysisScope, analysisState) && DynAbs.Tracing.TraceSender.Conditional_F2(222, 79646, 79675)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 79678, 79710))) ? EventProcessedState.Processed : EventProcessedState.NotProcessed,

                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 79731, 79846) && DynAbs.Tracing.TraceSender.Expression_True(222, 79731, 79846))
    => throw f_222_79742_79846("Unexpected compilation event of type " + f_222_79814_79845(f_222_79814_79840(compilationEvent)))
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 78256, 79873);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState>
                f_222_78903_78994(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryProcessSymbolDeclaredAsync(symbolEvent, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 78903, 78994);
                    return return_v;
                }


                bool
                f_222_79106_79205(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                completedEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryProcessCompilationUnitCompleted(completedEvent, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 79106, 79205);
                    return return_v;
                }


                bool
                f_222_79352_79422(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                endEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryProcessCompilationCompleted(endEvent, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 79352, 79422);
                    return return_v;
                }


                bool
                f_222_79571_79643(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent
                startedEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryProcessCompilationStarted(startedEvent, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 79571, 79643);
                    return return_v;
                }


                System.Type
                f_222_79814_79840(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 79814, 79840);
                    return return_v;
                }


                string
                f_222_79814_79845(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 79814, 79845);
                    return return_v;
                }


                System.InvalidOperationException
                f_222_79742_79846(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 79742, 79846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 78256, 79873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 78256, 79873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://developercommunity.visualstudio.com/content/problem/805524/ctrl-suggestions-are-very-slow-and-produce-gatheri.html",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<EventProcessedState> TryProcessSymbolDeclaredAsync(SymbolDeclaredCompilationEvent symbolEvent, AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 80217, 82634);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer> subsetProcessedAnalyzers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 80734, 80785);

                var
                processedState = EventProcessedState.Processed
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 80799, 80831);

                var
                symbol = f_222_80812_80830(symbolEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 80845, 80903);

                var
                isGeneratedCodeSymbol = f_222_80873_80902(this, symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 80919, 80996);

                var
                skipSymbolAnalysis = f_222_80944_80995(symbolEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81010, 81092);

                var
                skipDeclarationAnalysis = f_222_81040_81091(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81106, 81229);

                var
                hasPerSymbolActions = f_222_81132_81147().SymbolStartActionsCount > 0 && (DynAbs.Tracing.TraceSender.Expression_True(222, 81132, 81228) && (!skipSymbolAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(222, 81180, 81227) || !skipDeclarationAnalysis)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81245, 81464);

                var
                perSymbolActions = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 81268, 81287) || ((hasPerSymbolActions && DynAbs.Tracing.TraceSender.Conditional_F2(222, 81307, 81424)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 81444, 81463))) ? await f_222_81313_81402(this, symbol, analysisScope, analysisState, cancellationToken).ConfigureAwait(false) : f_222_81444_81463()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81480, 81732) || true) && (!skipSymbolAnalysis && (DynAbs.Tracing.TraceSender.Expression_True(222, 81484, 81633) && !f_222_81525_81633(this, symbolEvent, analysisScope, analysisState, isGeneratedCodeSymbol, cancellationToken)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 81480, 81732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81667, 81717);

                    processedState = EventProcessedState.NotProcessed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 81480, 81732);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81748, 82035) || true) && (!skipDeclarationAnalysis && (DynAbs.Tracing.TraceSender.Expression_True(222, 81752, 81936) && !f_222_81798_81936(this, symbolEvent, analysisScope, analysisState, isGeneratedCodeSymbol, perSymbolActions, cancellationToken)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 81748, 82035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 81970, 82020);

                    processedState = EventProcessedState.NotProcessed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 81748, 82035);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 82051, 82585) || true) && (f_222_82055_82074(processedState) == EventProcessedStateKind.Processed && (DynAbs.Tracing.TraceSender.Expression_True(222, 82055, 82151) && hasPerSymbolActions) && (DynAbs.Tracing.TraceSender.Expression_True(222, 82055, 82310) && !f_222_82173_82310(this, f_222_82200_82232(perSymbolActions), symbolEvent, analysisScope, analysisState, out subsetProcessedAnalyzers)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 82051, 82585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 82344, 82394);

                    f_222_82344_82393(f_222_82357_82392_M(!subsetProcessedAnalyzers.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 82412, 82570);

                    processedState = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 82429, 82461) || ((subsetProcessedAnalyzers.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(222, 82464, 82496)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 82499, 82569))) ? EventProcessedState.NotProcessed : f_222_82499_82569(subsetProcessedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 82051, 82585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 82601, 82623);

                return processedState;
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 80217, 82634);

                Microsoft.CodeAnalysis.ISymbol
                f_222_80812_80830(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 80812, 80830);
                    return return_v;
                }


                bool
                f_222_80873_80902(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsGeneratedCodeSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 80873, 80902);
                    return return_v;
                }


                bool
                f_222_80944_80995(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolEvent)
                {
                    var return_v = AnalysisScope.ShouldSkipSymbolAnalysis(symbolEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 80944, 80995);
                    return return_v;
                }


                bool
                f_222_81040_81091(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = AnalysisScope.ShouldSkipDeclarationAnalysis(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 81040, 81091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_81132_81147()
                {
                    var return_v = AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 81132, 81147);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_81313_81402(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetPerSymbolAnalyzerActionsAsync(symbol, analysisScope, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 81313, 81402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_81444_81463()
                {
                    var return_v = EmptyGroupedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 81444, 81463);
                    return return_v;
                }


                bool
                f_222_81525_81633(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                isGeneratedCodeSymbol, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryExecuteSymbolActions(symbolEvent, analysisScope, analysisState, isGeneratedCodeSymbol, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 81525, 81633);
                    return return_v;
                }


                bool
                f_222_81798_81936(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                isGeneratedCodeSymbol, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                additionalPerSymbolActions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.TryExecuteDeclaringReferenceActions(symbolEvent, analysisScope, analysisState, isGeneratedCodeSymbol, additionalPerSymbolActions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 81798, 81936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedStateKind
                f_222_82055_82074(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 82055, 82074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_82200_82232(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                this_param)
                {
                    var return_v = this_param.AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 82200, 82232);
                    return return_v;
                }


                bool
                f_222_82173_82310(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                perSymbolActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                subsetProcessedAnalyzers)
                {
                    var return_v = this_param.TryExecuteSymbolEndActions(perSymbolActions, symbolEvent, analysisScope, analysisState, out subsetProcessedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 82173, 82310);
                    return return_v;
                }


                bool
                f_222_82357_82392_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 82357, 82392);
                    return return_v;
                }


                int
                f_222_82344_82393(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 82344, 82393);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
                f_222_82499_82569(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                subsetProcessedAnalyzers)
                {
                    var return_v = EventProcessedState.CreatePartiallyProcessed(subsetProcessedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 82499, 82569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 80217, 82634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 80217, 82634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExecuteSymbolActions(SymbolDeclaredCompilationEvent symbolEvent, AnalysisScope analysisScope, AnalysisState? analysisState, bool isGeneratedCodeSymbol, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 82975, 84639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83204, 83236);

                var
                symbol = f_222_83217_83235(symbolEvent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83250, 83351) || true) && (!f_222_83255_83290(analysisScope, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 83250, 83351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83324, 83336);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 83250, 83351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83367, 83471);

                var
                processedAnalyzers = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 83392, 83413) || ((analysisState != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 83416, 83463)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 83466, 83470))) ? f_222_83416_83463() : null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83521, 83540);

                    var
                    success = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83558, 84363);
                        foreach (var (analyzer, actionsByKind) in f_222_83600_83624_I(_lazySymbolActionsByKind))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 83558, 84363);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83666, 83785) || true) && (!f_222_83671_83703(analysisScope, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 83666, 83785);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83753, 83762);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 83666, 83785);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83882, 84344) || true) && ((int)f_222_83891_83902(symbol) < actionsByKind.Length)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 83882, 84344);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 83975, 84259) || true) && (!f_222_83980_84158(f_222_83980_83996(), actionsByKind[(int)f_222_84040_84051(symbol)], analyzer, symbolEvent, s_getTopmostNodeForAnalysis, analysisScope, analysisState, isGeneratedCodeSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 83975, 84259);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84216, 84232);

                                    success = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 83975, 84259);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84287, 84321);

                                f_222_84287_84320_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 84287, 84320)?.Add(analyzer));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 83882, 84344);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 83558, 84363);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 806);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84383, 84484);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 84383, 84483)?.MarkSymbolCompleteForUnprocessedAnalyzers(symbol, analysisScope, processedAnalyzers!), 222, 84397, 84483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84502, 84517);

                    return success;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 84546, 84628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84586, 84613);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 84586, 84612)?.Free(), 222, 84605, 84612);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 84546, 84628);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 82975, 84639);

                Microsoft.CodeAnalysis.ISymbol
                f_222_83217_83235(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 83217, 83235);
                    return return_v;
                }


                bool
                f_222_83255_83290(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.ShouldAnalyze(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 83255, 83290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_83416_83463()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 83416, 83463);
                    return return_v;
                }


                bool
                f_222_83671_83703(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 83671, 83703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_222_83891_83902(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 83891, 83902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_83980_83996()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 83980, 83996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_222_84040_84051(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 84040, 84051);
                    return return_v;
                }


                bool
                f_222_83980_84158(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                symbolActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                isGeneratedCodeSymbol)
                {
                    var return_v = this_param.TryExecuteSymbolActions(symbolActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analysisScope, analysisState, isGeneratedCodeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 83980, 84158);
                    return return_v;
                }


                bool?
                f_222_84287_84320_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 84287, 84320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                f_222_83600_83624_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 83600, 83624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 82975, 84639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 82975, 84639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExecuteSymbolEndActions(
                    in AnalyzerActions perSymbolActions,
                    SymbolDeclaredCompilationEvent symbolEvent,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    out ImmutableArray<DiagnosticAnalyzer> subsetProcessedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 84651, 87888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 84986, 85044);

                f_222_84986_85043(f_222_84999_85014().SymbolStartActionsCount > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85060, 85092);

                var
                symbol = f_222_85073_85091(symbolEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85106, 85163);

                var
                symbolEndActions = perSymbolActions.SymbolEndActions
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85177, 85488) || true) && (!f_222_85182_85217(analysisScope, symbol) || (DynAbs.Tracing.TraceSender.Expression_False(222, 85181, 85245) || symbolEndActions.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 85177, 85488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85279, 85357);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 85279, 85356)?.MarkSymbolEndAnalysisComplete(symbol, f_222_85332_85355(analysisScope)), 222, 85293, 85356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85375, 85443);

                    subsetProcessedAnalyzers = ImmutableArray<DiagnosticAnalyzer>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85461, 85473);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 85177, 85488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85504, 85523);

                var
                success = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85537, 85609);

                var
                completedAnalyzers = f_222_85562_85608()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85623, 85696);

                var
                processedAnalyzers = f_222_85648_85695()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85746, 86724);
                        foreach (var groupedActions in f_222_85777_85818_I(f_222_85777_85818(ref symbolEndActions, a => a.Analyzer)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 85746, 86724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85860, 85894);

                            var
                            analyzer = f_222_85875_85893(groupedActions)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 85916, 86035) || true) && (!f_222_85921_85953(analysisScope, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 85916, 86035);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86003, 86012);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 85916, 86035);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86059, 86092);

                            f_222_86059_86091(
                                                processedAnalyzers, analyzer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86116, 86191);

                            var
                            symbolEndActionsForAnalyzer = f_222_86150_86190(groupedActions)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86213, 86546) || true) && (f_222_86217_86253_M(!symbolEndActionsForAnalyzer.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(222, 86217, 86422) && !f_222_86283_86422(f_222_86283_86299(), symbolEndActionsForAnalyzer, analyzer, symbolEvent, s_getTopmostNodeForAnalysis, analysisState)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 86213, 86546);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86472, 86488);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86514, 86523);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 86213, 86546);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86570, 86650);

                            f_222_86570_86649(f_222_86570_86586(), symbol, analyzer, analysisState);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86672, 86705);

                            f_222_86672_86704(completedAnalyzers, analyzer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 85746, 86724);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 979);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 979);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86744, 87257) || true) && (f_222_86748_86772(processedAnalyzers) < analysisScope.Analyzers.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 86744, 87257);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86847, 87238);
                            foreach (var analyzer in f_222_86872_86895_I(f_222_86872_86895(analysisScope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 86847, 87238);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 86945, 87215) || true) && (!f_222_86950_86987(processedAnalyzers, analyzer))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 86945, 87215);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87045, 87125);

                                    f_222_87045_87124(f_222_87045_87061(), symbol, analyzer, analysisState);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87155, 87188);

                                    f_222_87155_87187(completedAnalyzers, analyzer);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 86945, 87215);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 86847, 87238);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 392);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 392);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 86744, 87257);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87277, 87723) || true) && (!success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 87277, 87723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87331, 87403);

                        f_222_87331_87402(f_222_87344_87368(completedAnalyzers) < analysisScope.Analyzers.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87425, 87485);

                        subsetProcessedAnalyzers = f_222_87452_87484(completedAnalyzers);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87507, 87520);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 87277, 87723);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 87277, 87723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87602, 87670);

                        subsetProcessedAnalyzers = ImmutableArray<DiagnosticAnalyzer>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87692, 87704);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 87277, 87723);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 87752, 87877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87792, 87818);

                    f_222_87792_87817(processedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 87836, 87862);

                    f_222_87836_87861(completedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 87752, 87877);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 84651, 87888);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_84999_85014()
                {
                    var return_v = AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 84999, 85014);
                    return return_v;
                }


                int
                f_222_84986_85043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 84986, 85043);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_222_85073_85091(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 85073, 85091);
                    return return_v;
                }


                bool
                f_222_85182_85217(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.ShouldAnalyze(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85182, 85217);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                f_222_85332_85355(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 85332, 85355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_85562_85608()
                {
                    var return_v = ArrayBuilder<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85562, 85608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_85648_85695()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85648, 85695);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>>
                f_222_85777_85818(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                keySelector)
                {
                    var return_v = source.GroupBy<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85777, 85818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_85875_85893(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 85875, 85893);
                    return return_v;
                }


                bool
                f_222_85921_85953(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85921, 85953);
                    return return_v;
                }


                bool
                f_222_86059_86091(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86059, 86091);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                f_222_86150_86190(System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                items)
                {
                    var return_v = items.ToImmutableArrayOrEmpty<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86150, 86190);
                    return return_v;
                }


                bool
                f_222_86217_86253_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 86217, 86253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_86283_86299()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 86283, 86299);
                    return return_v;
                }


                bool
                f_222_86283_86422(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteSymbolEndActions(symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86283, 86422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_86570_86586()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 86570, 86586);
                    return return_v;
                }


                int
                f_222_86570_86649(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86570, 86649);
                    return 0;
                }


                int
                f_222_86672_86704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86672, 86704);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>>
                f_222_85777_85818_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 85777, 85818);
                    return return_v;
                }


                int
                f_222_86748_86772(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 86748, 86772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_86872_86895(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 86872, 86895);
                    return return_v;
                }


                bool
                f_222_86950_86987(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86950, 86987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_87045_87061()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 87045, 87061);
                    return return_v;
                }


                int
                f_222_87045_87124(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87045, 87124);
                    return 0;
                }


                int
                f_222_87155_87187(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87155, 87187);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_86872_86895_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 86872, 86895);
                    return return_v;
                }


                int
                f_222_87344_87368(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 87344, 87368);
                    return return_v;
                }


                int
                f_222_87331_87402(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87331, 87402);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_87452_87484(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87452, 87484);
                    return return_v;
                }


                int
                f_222_87792_87817(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87792, 87817);
                    return 0;
                }


                int
                f_222_87836_87861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 87836, 87861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 84651, 87888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 84651, 87888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode GetTopmostNodeForAnalysis(ISymbol symbol, SyntaxReference syntaxReference, Compilation compilation, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 87900, 88284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 88087, 88156);

                var
                model = f_222_88099_88155(compilation, f_222_88128_88154(syntaxReference))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 88170, 88273);

                return f_222_88177_88272(model, symbol, f_222_88227_88271(syntaxReference, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 87900, 88284);

                Microsoft.CodeAnalysis.SyntaxTree
                f_222_88128_88154(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 88128, 88154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_222_88099_88155(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 88099, 88155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_88227_88271(Microsoft.CodeAnalysis.SyntaxReference
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSyntax(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 88227, 88271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_88177_88272(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                declaringSyntax)
                {
                    var return_v = this_param.GetTopmostNodeForDiagnosticAnalysis(symbol, declaringSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 88177, 88272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 87900, 88284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 87900, 88284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract bool TryExecuteDeclaringReferenceActions(
                    SymbolDeclaredCompilationEvent symbolEvent,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCodeSymbol,
                    IGroupedAnalyzerActions additionalPerSymbolActions,
                    CancellationToken cancellationToken);

        private bool TryProcessCompilationUnitCompleted(CompilationUnitCompletedEvent completedEvent, AnalysisScope analysisScope, AnalysisState? analysisState, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 89006, 91190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89491, 89610);

                var
                semanticModel = f_222_89511_89609(f_222_89511_89532(), f_222_89550_89580(completedEvent), f_222_89582_89608(completedEvent))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89624, 89743) || true) && (!f_222_89629_89682(analysisScope, f_222_89657_89681(semanticModel)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 89624, 89743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89716, 89728);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 89624, 89743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89759, 89823);

                var
                isGeneratedCode = f_222_89781_89822(this, f_222_89797_89821(semanticModel))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89837, 90038) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(222, 89841, 89885) && f_222_89860_89885()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 89837, 90038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 89919, 89993);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 89919, 89992)?.MarkEventComplete(completedEvent, f_222_89968_89991(analysisScope)), 222, 89933, 89992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90011, 90023);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 89837, 90038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90054, 90158);

                var
                processedAnalyzers = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 90079, 90100) || ((analysisState != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 90103, 90150)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 90153, 90157))) ? f_222_90103_90150() : null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90208, 90227);

                    var
                    success = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90245, 90907);
                        foreach (var (analyzer, semanticModelActions) in f_222_90294_90319_I(_lazySemanticModelActions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 90245, 90907);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90361, 90480) || true) && (!f_222_90366_90398(analysisScope, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 90361, 90480);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90448, 90457);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 90361, 90480);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90579, 90830) || true) && (!f_222_90584_90741(f_222_90584_90600(), semanticModelActions, analyzer, semanticModel, completedEvent, analysisScope, analysisState, isGeneratedCode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 90579, 90830);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90791, 90807);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 90579, 90830);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90854, 90888);

                            f_222_90854_90887_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 90854, 90887)?.Add(analyzer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 90245, 90907);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 663);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 663);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 90927, 91035);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 90927, 91034)?.MarkEventCompleteForUnprocessedAnalyzers(completedEvent, analysisScope, processedAnalyzers!), 222, 90941, 91034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 91053, 91068);

                    return success;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 91097, 91179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 91137, 91164);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 91137, 91163)?.Free(), 222, 91156, 91163);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 91097, 91179);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 89006, 91190);

                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                f_222_89511_89532()
                {
                    var return_v = SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89511, 89532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_89550_89580(Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89550, 89580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_89582_89608(Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89582, 89608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_222_89511_89609(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetSemanticModel(tree, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 89511, 89609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_89657_89681(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89657, 89681);
                    return return_v;
                }


                bool
                f_222_89629_89682(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.ShouldAnalyze(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 89629, 89682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_222_89797_89821(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89797, 89821);
                    return return_v;
                }


                bool
                f_222_89781_89822(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsGeneratedCode(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 89781, 89822);
                    return return_v;
                }


                bool
                f_222_89860_89885()
                {
                    var return_v = DoNotAnalyzeGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89860, 89885);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                f_222_89968_89991(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 89968, 89991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_90103_90150()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 90103, 90150);
                    return return_v;
                }


                bool
                f_222_90366_90398(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 90366, 90398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_90584_90600()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 90584, 90600);
                    return return_v;
                }


                bool
                f_222_90584_90741(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>
                semanticModelActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                compilationUnitCompletedEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, bool
                isGeneratedCode)
                {
                    var return_v = this_param.TryExecuteSemanticModelActions(semanticModelActions, analyzer, semanticModel, (Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)compilationUnitCompletedEvent, analysisScope, analysisState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 90584, 90741);
                    return return_v;
                }


                bool?
                f_222_90854_90887_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 90854, 90887);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>)>
                f_222_90294_90319_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 90294, 90319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 89006, 91190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 89006, 91190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryProcessCompilationStarted(CompilationStartedEvent startedEvent, AnalysisScope analysisScope, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 91544, 91823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 91707, 91812);

                return f_222_91714_91811(this, _lazyCompilationActions, startedEvent, analysisScope, analysisState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 91544, 91823);

                bool
                f_222_91714_91811(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                compilationActionsMap, Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteCompilationActions(compilationActionsMap, (Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)compilationEvent, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 91714, 91811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 91544, 91823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 91544, 91823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryProcessCompilationCompleted(CompilationCompletedEvent endEvent, AnalysisScope analysisScope, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 92179, 92457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 92342, 92446);

                return f_222_92349_92445(this, _lazyCompilationEndActions, endEvent, analysisScope, analysisState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 92179, 92457);

                bool
                f_222_92349_92445(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                compilationActionsMap, Microsoft.CodeAnalysis.Diagnostics.CompilationCompletedEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteCompilationActions(compilationActionsMap, (Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)compilationEvent, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 92349, 92445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 92179, 92457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 92179, 92457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExecuteCompilationActions(
                    ImmutableArray<(DiagnosticAnalyzer, ImmutableArray<CompilationAnalyzerAction>)> compilationActionsMap,
                    CompilationEvent compilationEvent,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 92803, 94265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93119, 93226);

                f_222_93119_93225(compilationEvent is CompilationStartedEvent || (DynAbs.Tracing.TraceSender.Expression_False(222, 93132, 93224) || compilationEvent is CompilationCompletedEvent));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93242, 93346);

                var
                processedAnalyzers = (DynAbs.Tracing.TraceSender.Conditional_F1(222, 93267, 93288) || ((analysisState != null && DynAbs.Tracing.TraceSender.Conditional_F2(222, 93291, 93338)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 93341, 93345))) ? f_222_93291_93338() : null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93396, 93415);

                    var
                    success = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93433, 93980);
                        foreach (var (analyzer, compilationActions) in f_222_93480_93501_I(compilationActionsMap))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 93433, 93980);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93543, 93662) || true) && (!f_222_93548_93580(analysisScope, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 93543, 93662);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93630, 93639);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 93543, 93662);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93686, 93903) || true) && (!f_222_93691_93814(f_222_93691_93707(), compilationActions, analyzer, compilationEvent, analysisScope, analysisState))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 93686, 93903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93864, 93880);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 93686, 93903);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 93927, 93961);

                            f_222_93927_93960_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 93927, 93960)?.Add(analyzer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 93433, 93980);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 548);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 94000, 94110);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 222, 94000, 94109)?.MarkEventCompleteForUnprocessedAnalyzers(compilationEvent, analysisScope, processedAnalyzers!), 222, 94014, 94109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 94128, 94143);

                    return success;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 94172, 94254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 94212, 94239);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(processedAnalyzers, 222, 94212, 94238)?.Free(), 222, 94231, 94238);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 94172, 94254);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 92803, 94265);

                int
                f_222_93119_93225(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93119, 93225);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_93291_93338()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93291, 93338);
                    return return_v;
                }


                bool
                f_222_93548_93580(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93548, 93580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_93691_93707()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 93691, 93707);
                    return return_v;
                }


                bool
                f_222_93691_93814(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>
                compilationActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteCompilationActions(compilationActions, analyzer, compilationEvent, analysisScope, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93691, 93814);
                    return return_v;
                }


                bool?
                f_222_93927_93960_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93927, 93960);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                f_222_93480_93501_I(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>)>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 93480, 93501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 92803, 94265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 92803, 94265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Action<Diagnostic> GetDiagnosticSink(Action<Diagnostic> addDiagnosticCore, Compilation compilation, AnalyzerOptions? analyzerOptions, SeverityFilter severityFilter, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 94277, 94870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 94519, 94859);

                return diagnostic =>
                            {
                                var filteredDiagnostic = GetFilteredDiagnostic(diagnostic, compilation, analyzerOptions, severityFilter, cancellationToken);
                                if (filteredDiagnostic != null)
                                {
                                    addDiagnosticCore(filteredDiagnostic);
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 94277, 94870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 94277, 94870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 94277, 94870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Action<Diagnostic, DiagnosticAnalyzer, bool> GetDiagnosticSink(Action<Diagnostic, DiagnosticAnalyzer, bool> addLocalDiagnosticCore, Compilation compilation, AnalyzerOptions? analyzerOptions, SeverityFilter severityFilter, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 94882, 95599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 95181, 95588);

                return (diagnostic, analyzer, isSyntaxDiagnostic) =>
                            {
                                var filteredDiagnostic = GetFilteredDiagnostic(diagnostic, compilation, analyzerOptions, severityFilter, cancellationToken);
                                if (filteredDiagnostic != null)
                                {
                                    addLocalDiagnosticCore(filteredDiagnostic, analyzer, isSyntaxDiagnostic);
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 94882, 95599);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 94882, 95599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 94882, 95599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Action<Diagnostic, DiagnosticAnalyzer> GetDiagnosticSink(Action<Diagnostic, DiagnosticAnalyzer> addDiagnosticCore, Compilation compilation, AnalyzerOptions? analyzerOptions, SeverityFilter severityFilter, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 95611, 96266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 95893, 96255);

                return (diagnostic, analyzer) =>
                            {
                                var filteredDiagnostic = GetFilteredDiagnostic(diagnostic, compilation, analyzerOptions, severityFilter, cancellationToken);
                                if (filteredDiagnostic != null)
                                {
                                    addDiagnosticCore(filteredDiagnostic, analyzer);
                                }
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 95611, 96266);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 95611, 96266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 95611, 96266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Diagnostic? GetFilteredDiagnostic(Diagnostic diagnostic, Compilation compilation, AnalyzerOptions? analyzerOptions, SeverityFilter severityFilter, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 96278, 97610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 96501, 96594);

                var
                filteredDiagnostic = f_222_96526_96593(f_222_96526_96545(compilation), diagnostic, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 96608, 96657);

                return f_222_96615_96656(filteredDiagnostic);

                Diagnostic? applyFurtherFiltering(Diagnostic? diagnostic)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 96673, 97599);
                        Microsoft.CodeAnalysis.ReportDiagnostic severity = default(Microsoft.CodeAnalysis.ReportDiagnostic);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 96968, 97320) || true) && (diagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 96972, 97036) && f_222_96994_97024(f_222_96994_97013(diagnostic)) is { } tree) && (DynAbs.Tracing.TraceSender.Expression_True(222, 96972, 97204) && f_222_97061_97204(analyzerOptions, tree, compilation, f_222_97132_97153(diagnostic), cancellationToken, out severity)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 96968, 97320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 97246, 97301);

                            diagnostic = f_222_97259_97300(diagnostic, severity);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 96968, 97320);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 97340, 97546) || true) && (diagnostic != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 97344, 97473) && f_222_97387_97473(severityFilter, f_222_97411_97472(f_222_97452_97471(diagnostic)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 97340, 97546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 97515, 97527);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 97340, 97546);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 97566, 97584);

                        return diagnostic;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 96673, 97599);

                        Microsoft.CodeAnalysis.Location
                        f_222_96994_97013(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 96994, 97013);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree?
                        f_222_96994_97024(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 96994, 97024);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticDescriptor
                        f_222_97132_97153(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Descriptor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 97132, 97153);
                            return return_v;
                        }


                        bool
                        f_222_97061_97204(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                        analyzerOptions, Microsoft.CodeAnalysis.SyntaxTree
                        tree, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.DiagnosticDescriptor
                        descriptor, System.Threading.CancellationToken
                        cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                        severity)
                        {
                            var return_v = analyzerOptions.TryGetSeverityFromBulkConfiguration(tree, compilation, descriptor, cancellationToken, out severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 97061, 97204);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostic?
                        f_222_97259_97300(Microsoft.CodeAnalysis.Diagnostic
                        this_param, Microsoft.CodeAnalysis.ReportDiagnostic
                        reportAction)
                        {
                            var return_v = this_param.WithReportDiagnostic(reportAction);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 97259, 97300);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_222_97452_97471(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 97452, 97471);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ReportDiagnostic
                        f_222_97411_97472(Microsoft.CodeAnalysis.DiagnosticSeverity
                        severity)
                        {
                            var return_v = DiagnosticDescriptor.MapSeverityToReport(severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 97411, 97472);
                            return return_v;
                        }


                        bool
                        f_222_97387_97473(Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                        severityFilter, Microsoft.CodeAnalysis.ReportDiagnostic
                        severity)
                        {
                            var return_v = severityFilter.Contains(severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 97387, 97473);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 96673, 97599);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 96673, 97599);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 96278, 97610);

                Microsoft.CodeAnalysis.CompilationOptions
                f_222_96526_96545(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 96526, 96545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_222_96526_96593(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterDiagnostic(diagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 96526, 96593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_222_96615_96656(Microsoft.CodeAnalysis.Diagnostic?
                diagnostic)
                {
                    var return_v = applyFurtherFiltering(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 96615, 96656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 96278, 97610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 96278, 97610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static async Task<(AnalyzerActions actions, ImmutableHashSet<DiagnosticAnalyzer> unsuppressedAnalyzers)> GetAnalyzerActionsAsync(
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    AnalyzerManager analyzerManager,
                    AnalyzerExecutor analyzerExecutor,
                    SeverityFilter severityFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 97622, 98911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 97981, 98028);

                var
                allAnalyzerActions = AnalyzerActions.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98042, 98125);

                var
                unsuppressedAnalyzersBuilder = f_222_98077_98124()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98139, 98691);
                    foreach (var analyzer in f_222_98164_98173_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 98139, 98691);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98207, 98676) || true) && (!f_222_98212_98341(analyzer, f_222_98253_98289(f_222_98253_98281(analyzerExecutor)), analyzerManager, analyzerExecutor, severityFilter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 98207, 98676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98383, 98426);

                            f_222_98383_98425(unsuppressedAnalyzersBuilder, analyzer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98450, 98568);

                            var
                            analyzerActions = await f_222_98478_98545(analyzerManager, analyzer, analyzerExecutor).ConfigureAwait(false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98590, 98657);

                            allAnalyzerActions = allAnalyzerActions.Append(in analyzerActions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 98207, 98676);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 98139, 98691);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98707, 98785);

                var
                unsuppressedAnalyzers = f_222_98735_98784(unsuppressedAnalyzersBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98799, 98835);

                f_222_98799_98834(unsuppressedAnalyzersBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 98849, 98900);

                return (allAnalyzerActions, unsuppressedAnalyzers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 97622, 98911);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_98077_98124()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98077, 98124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_98253_98281(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 98253, 98281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_98253_98289(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 98253, 98289);
                    return return_v;
                }


                bool
                f_222_98212_98341(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = IsDiagnosticAnalyzerSuppressed(analyzer, options, analyzerManager, analyzerExecutor, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98212, 98341);
                    return return_v;
                }


                bool
                f_222_98383_98425(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98383, 98425);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_222_98478_98545(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetAnalyzerActionsAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98478, 98545);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_98164_98173_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98164, 98173);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_98735_98784(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98735, 98784);
                    return return_v;
                }


                int
                f_222_98799_98834(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 98799, 98834);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 97622, 98911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 97622, 98911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasSymbolStartedActions(AnalysisScope analysisScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 98923, 100909);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99012, 99127) || true) && (this.AnalyzerActions.SymbolStartActionsCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99012, 99127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99099, 99112);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99012, 99127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99324, 100067) || true) && (analysisScope.Analyzers.Length == this.Analyzers.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99324, 100067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99545, 99557);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99324, 100067);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99324, 100067);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99591, 100067) || true) && (analysisScope.Analyzers.Length == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99591, 100067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99720, 99762);

                        var
                        analyzer = f_222_99735_99758(analysisScope)[0]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99780, 100019);
                            foreach (var action in f_222_99803_99842_I(this.AnalyzerActions.SymbolStartActions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99780, 100019);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99884, 100000) || true) && (f_222_99888_99903(action) == analyzer)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 99884, 100000);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 99965, 99977);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99884, 100000);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99780, 100019);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 240);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 240);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100039, 100052);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99591, 100067);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 99324, 100067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100206, 100281);

                var
                symbolStartAnalyzers = f_222_100233_100280()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100331, 100496);
                        foreach (var action in f_222_100354_100393_I(this.AnalyzerActions.SymbolStartActions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 100331, 100496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100435, 100477);

                            f_222_100435_100476(symbolStartAnalyzers, f_222_100460_100475(action));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 100331, 100496);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 166);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 166);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100516, 100753);
                        foreach (var analyzer in f_222_100541_100564_I(f_222_100541_100564(analysisScope)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 100516, 100753);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100606, 100734) || true) && (f_222_100610_100649(symbolStartAnalyzers, analyzer))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 100606, 100734);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100699, 100711);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 100606, 100734);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 100516, 100753);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100773, 100786);

                    return false;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(222, 100815, 100898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 100855, 100883);

                    f_222_100855_100882(symbolStartAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(222, 100815, 100898);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 98923, 100909);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_99735_99758(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 99735, 99758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_99888_99903(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 99888, 99903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                f_222_99803_99842_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 99803, 99842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_100233_100280()
                {
                    var return_v = PooledHashSet<DiagnosticAnalyzer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100233, 100280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_222_100460_100475(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 100460, 100475);
                    return return_v;
                }


                bool
                f_222_100435_100476(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100435, 100476);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                f_222_100354_100393_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100354, 100393);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_100541_100564(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 100541, 100564);
                    return return_v;
                }


                bool
                f_222_100610_100649(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100610, 100649);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_100541_100564_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100541, 100564);
                    return return_v;
                }


                int
                f_222_100855_100882(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 100855, 100882);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 98923, 100909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 98923, 100909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://developercommunity.visualstudio.com/content/problem/805524/ctrl-suggestions-are-very-slow-and-produce-gatheri.html",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<IGroupedAnalyzerActions> GetPerSymbolAnalyzerActionsAsync(
                    ISymbol symbol,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 100921, 102201);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101413, 101568) || true) && (f_222_101417_101432().SymbolStartActionsCount == 0 || (DynAbs.Tracing.TraceSender.Expression_False(222, 101417, 101492) || f_222_101465_101492(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 101413, 101568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101526, 101553);

                    return f_222_101533_101552();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 101413, 101568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101584, 101621);

                var
                allActions = f_222_101601_101620()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101635, 102156);
                    foreach (var analyzer in f_222_101660_101683_I(f_222_101660_101683(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 101635, 102156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101717, 101831) || true) && (!f_222_101722_101761(f_222_101722_101742(), analyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 101717, 101831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101803, 101812);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 101717, 101831);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 101851, 101986);

                        var
                        analyzerActions = await f_222_101879_101963(this, symbol, analyzer, analysisState, cancellationToken).ConfigureAwait(false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102004, 102141) || true) && (f_222_102008_102032_M(!analyzerActions.IsEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 102004, 102141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102074, 102122);

                            allActions = f_222_102087_102121(allActions, analyzerActions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 102004, 102141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 101635, 102156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102172, 102190);

                return allActions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 100921, 102201);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_101417_101432()
                {
                    var return_v = AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101417, 101432);
                    return return_v;
                }


                bool
                f_222_101465_101492(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101465, 101492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_101533_101552()
                {
                    var return_v = EmptyGroupedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101533, 101552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_101601_101620()
                {
                    var return_v = EmptyGroupedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101601, 101620);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_101660_101683(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101660, 101683);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_101722_101742()
                {
                    var return_v = SymbolStartAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 101722, 101742);
                    return return_v;
                }


                bool
                f_222_101722_101761(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 101722, 101761);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_101879_101963(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetPerSymbolAnalyzerActionsAsync(symbol, analyzer, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 101879, 101963);
                    return return_v;
                }


                bool
                f_222_102008_102032_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 102008, 102032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_102087_102121(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                groupedAnalyzerActions)
                {
                    var return_v = this_param.Append(groupedAnalyzerActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 102087, 102121);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_101660_101683_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 101660, 101683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 100921, 102201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 100921, 102201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://developercommunity.visualstudio.com/content/problem/805524/ctrl-suggestions-are-very-slow-and-produce-gatheri.html",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<IGroupedAnalyzerActions> GetPerSymbolAnalyzerActionsAsync(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    AnalysisState? analysisState,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 102213, 107220);
                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions actions = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102705, 102763);

                f_222_102705_102762(f_222_102718_102733().SymbolStartActionsCount > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102777, 102831);

                f_222_102777_102830(f_222_102790_102829(f_222_102790_102810(), analyzer));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102847, 102954) || true) && (f_222_102851_102878(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 102847, 102954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 102912, 102939);

                    return f_222_102919_102938();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 102847, 102954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103153, 103369) || true) && (!(symbol is INamespaceOrTypeSymbol namespaceOrType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 103153, 103369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103242, 103354);

                    return await f_222_103255_103331(this, symbol, analyzer, analysisState, cancellationToken).ConfigureAwait(false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 103153, 103369);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103385, 103540) || true) && (f_222_103389_103476(f_222_103389_103418(), (namespaceOrType, analyzer), out actions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 103385, 103540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103510, 103525);

                    return actions;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 103385, 103540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103556, 103678);

                var
                allActions = await f_222_103579_103655(this, symbol, analyzer, analysisState, cancellationToken).ConfigureAwait(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 103692, 103779);

                return f_222_103699_103778(f_222_103699_103728(), (namespaceOrType, analyzer), allActions);

                async ValueTask<IGroupedAnalyzerActions> getAllActionsAsync(AnalyzerDriver driver, ISymbol symbol, DiagnosticAnalyzer analyzer, AnalysisState? analysisState, CancellationToken cancellationToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 103795, 104823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104145, 104281);

                        var
                        inheritedActions = await f_222_104174_104258(driver, symbol, analyzer, analysisState, cancellationToken).ConfigureAwait(false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104417, 104525);

                        AnalyzerActions
                        myActions = await f_222_104451_104502(driver, symbol, analyzer).ConfigureAwait(false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104543, 104649) || true) && (myActions.IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 104543, 104649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104606, 104630);

                            return inheritedActions;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 104543, 104649);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104669, 104740);

                        var
                        allActions = inheritedActions.AnalyzerActions.Append(in myActions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 104758, 104808);

                        return f_222_104765_104807(this, analyzer, allActions);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 103795, 104823);

                        System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                        f_222_104174_104258(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        driver, Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                        analysisState, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = getInheritedActionsAsync(driver, symbol, analyzer, analysisState, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 104174, 104258);
                            return return_v;
                        }


                        System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                        f_222_104451_104502(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        driver, Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            var return_v = getSymbolActionsCoreAsync(driver, symbol, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 104451, 104502);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                        f_222_104765_104807(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        analyzerActions)
                        {
                            var return_v = this_param.CreateGroupedActions(analyzer, analyzerActions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 104765, 104807);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 103795, 104823);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 103795, 104823);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                async ValueTask<IGroupedAnalyzerActions> getInheritedActionsAsync(AnalyzerDriver driver, ISymbol symbol, DiagnosticAnalyzer analyzer, AnalysisState? analysisState, CancellationToken cancellationToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 104839, 106539);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 105072, 106477) || true) && (f_222_105076_105099(symbol) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 105072, 106477);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 105264, 105424);

                            var
                            containerActions = await f_222_105293_105401(driver, f_222_105333_105356(symbol), analyzer, analysisState, cancellationToken).ConfigureAwait(false)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 105446, 106458) || true) && (f_222_105450_105475_M(!containerActions.IsEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 105446, 106458);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 105928, 106435) || true) && (f_222_105932_105960(f_222_105932_105955(symbol)) != f_222_105964_105975(symbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 105928, 106435);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106120, 106184);

                                    var
                                    containerAnalyzerActions = f_222_106151_106183(containerActions)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106214, 106331);

                                    var
                                    actions = AnalyzerActions.Empty.Append(in containerAnalyzerActions, appendSymbolStartAndSymbolEndActions: false)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106361, 106408);

                                    return f_222_106368_106407(this, analyzer, actions);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 105928, 106435);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 105446, 106458);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 105072, 106477);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106497, 106524);

                        return f_222_106504_106523();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 104839, 106539);

                        Microsoft.CodeAnalysis.ISymbol
                        f_222_105076_105099(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105076, 105099);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_222_105333_105356(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105333, 105356);
                            return return_v;
                        }


                        System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                        f_222_105293_105401(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                        analysisState, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = this_param.GetPerSymbolAnalyzerActionsAsync(symbol, analyzer, analysisState, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 105293, 105401);
                            return return_v;
                        }


                        bool
                        f_222_105450_105475_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105450, 105475);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_222_105932_105955(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105932, 105955);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_222_105932_105960(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105932, 105960);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_222_105964_105975(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 105964, 105975);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_222_106151_106183(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                        this_param)
                        {
                            var return_v = this_param.AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 106151, 106183);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                        f_222_106368_106407(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        analyzerActions)
                        {
                            var return_v = this_param.CreateGroupedActions(analyzer, analyzerActions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 106368, 106407);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                        f_222_106504_106523()
                        {
                            var return_v = EmptyGroupedActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 106504, 106523);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 104839, 106539);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 104839, 106539);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static async ValueTask<AnalyzerActions> getSymbolActionsCoreAsync(AnalyzerDriver driver, ISymbol symbol, DiagnosticAnalyzer analyzer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 106555, 107209);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106721, 107194) || true) && (!f_222_106726_106773(f_222_106726_106754(driver), analyzer) || (DynAbs.Tracing.TraceSender.Expression_False(222, 106725, 106888) || f_222_106798_106834(driver, symbol) && (DynAbs.Tracing.TraceSender.Expression_True(222, 106798, 106888) && f_222_106838_106888(driver, analyzer))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 106721, 107194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 106930, 106959);

                            return AnalyzerActions.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 106721, 107194);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 106721, 107194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 107041, 107175);

                            return await f_222_107054_107152(f_222_107054_107076(driver), symbol, analyzer, f_222_107128_107151(driver)).ConfigureAwait(false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 106721, 107194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 106555, 107209);

                        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        f_222_106726_106754(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param)
                        {
                            var return_v = this_param.UnsuppressedAnalyzers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 106726, 106754);
                            return return_v;
                        }


                        bool
                        f_222_106726_106773(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 106726, 106773);
                            return return_v;
                        }


                        bool
                        f_222_106798_106834(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol)
                        {
                            var return_v = this_param.IsGeneratedCodeSymbol(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 106798, 106834);
                            return return_v;
                        }


                        bool
                        f_222_106838_106888(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            var return_v = this_param.ShouldSkipAnalysisOnGeneratedCode(analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 106838, 106888);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                        f_222_107054_107076(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param)
                        {
                            var return_v = this_param.AnalyzerManager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 107054, 107076);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_107128_107151(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param)
                        {
                            var return_v = this_param.AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 107128, 107151);
                            return return_v;
                        }


                        System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                        f_222_107054_107152(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                        this_param, Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        analyzerExecutor)
                        {
                            var return_v = this_param.GetPerSymbolAnalyzerActionsAsync(symbol, analyzer, analyzerExecutor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107054, 107152);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 106555, 107209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 106555, 107209);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 102213, 107220);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_222_102718_102733()
                {
                    var return_v = AnalyzerActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 102718, 102733);
                    return return_v;
                }


                int
                f_222_102705_102762(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 102705, 102762);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_102790_102810()
                {
                    var return_v = SymbolStartAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 102790, 102810);
                    return return_v;
                }


                bool
                f_222_102790_102829(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 102790, 102829);
                    return return_v;
                }


                int
                f_222_102777_102830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 102777, 102830);
                    return 0;
                }


                bool
                f_222_102851_102878(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 102851, 102878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_102919_102938()
                {
                    var return_v = EmptyGroupedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 102919, 102938);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_103255_103331(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = getAllActionsAsync(driver, symbol, analyzer, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 103255, 103331);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_103389_103418()
                {
                    var return_v = PerSymbolAnalyzerActionsCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 103389, 103418);
                    return return_v;
                }


                bool
                f_222_103389_103476(System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                this_param, (Microsoft.CodeAnalysis.INamespaceOrTypeSymbol namespaceOrType, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                value)
                {
                    var return_v = this_param.TryGetValue(((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer))key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 103389, 103476);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_103579_103655(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = getAllActionsAsync(driver, symbol, analyzer, analysisState, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 103579, 103655);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                f_222_103699_103728()
                {
                    var return_v = PerSymbolAnalyzerActionsCache;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 103699, 103728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                f_222_103699_103778(System.Collections.Concurrent.ConcurrentDictionary<(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer), Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions>
                this_param, (Microsoft.CodeAnalysis.INamespaceOrTypeSymbol namespaceOrType, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                key, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.IGroupedAnalyzerActions
                value)
                {
                    var return_v = this_param.GetOrAdd(((Microsoft.CodeAnalysis.INamespaceOrTypeSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer))key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 103699, 103778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 102213, 107220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 102213, 107220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static async Task<ImmutableDictionary<DiagnosticAnalyzer, SemaphoreSlim>> CreateAnalyzerGateMapAsync(
                    ImmutableHashSet<DiagnosticAnalyzer> analyzers,
                    AnalyzerManager analyzerManager,
                    AnalyzerExecutor analyzerExecutor,
                    SeverityFilter severityFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 107232, 108404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 107565, 107650);

                var
                builder = f_222_107579_107649()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 107664, 108348);
                    foreach (var analyzer in f_222_107689_107698_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 107664, 108348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 107732, 107877);

                        f_222_107732_107876(!f_222_107746_107875(analyzer, f_222_107787_107823(f_222_107787_107815(analyzerExecutor)), analyzerManager, analyzerExecutor, severityFilter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 107897, 108014);

                        var
                        isConcurrent = await f_222_107922_108013(f_222_107922_107991(analyzerManager, analyzer, analyzerExecutor), false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108032, 108333) || true) && (!isConcurrent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 108032, 108333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108218, 108264);

                            var
                            gate = f_222_108229_108263(initialCount: 1)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108286, 108314);

                            f_222_108286_108313(builder, analyzer, gate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 108032, 108333);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 107664, 108348);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 685);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108364, 108393);

                return f_222_108371_108392(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 107232, 108404);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>.Builder
                f_222_107579_107649()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, SemaphoreSlim>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107579, 107649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_107787_107815(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 107787, 107815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_107787_107823(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 107787, 107823);
                    return return_v;
                }


                bool
                f_222_107746_107875(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = IsDiagnosticAnalyzerSuppressed(analyzer, options, analyzerManager, analyzerExecutor, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107746, 107875);
                    return return_v;
                }


                int
                f_222_107732_107876(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107732, 107876);
                    return 0;
                }


                System.Threading.Tasks.Task<bool>
                f_222_107922_107991(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.IsConcurrentAnalyzerAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107922, 107991);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<bool>
                f_222_107922_108013(System.Threading.Tasks.Task<bool>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107922, 108013);
                    return return_v;
                }


                System.Threading.SemaphoreSlim
                f_222_108229_108263(int
                initialCount)
                {
                    var return_v = new System.Threading.SemaphoreSlim(initialCount: initialCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108229, 108263);
                    return return_v;
                }


                int
                f_222_108286_108313(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, System.Threading.SemaphoreSlim
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108286, 108313);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_107689_107698_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 107689, 107698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>
                f_222_108371_108392(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.SemaphoreSlim>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108371, 108392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 107232, 108404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 107232, 108404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static async Task<ImmutableDictionary<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags>> CreateGeneratedCodeAnalysisFlagsMapAsync(
                    ImmutableHashSet<DiagnosticAnalyzer> analyzers,
                    AnalyzerManager analyzerManager,
                    AnalyzerExecutor analyzerExecutor,
                    SeverityFilter severityFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 108416, 109400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108776, 108874);

                var
                builder = f_222_108790_108873()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108888, 109344);
                    foreach (var analyzer in f_222_108913_108922_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 108888, 109344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 108956, 109101);

                        f_222_108956_109100(!f_222_108970_109099(analyzer, f_222_109011_109047(f_222_109011_109039(analyzerExecutor)), analyzerManager, analyzerExecutor, severityFilter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109121, 109261);

                        var
                        generatedCodeAnalysisFlags = await f_222_109160_109260(f_222_109160_109238(analyzerManager, analyzer, analyzerExecutor), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109279, 109329);

                        f_222_109279_109328(builder, analyzer, generatedCodeAnalysisFlags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 108888, 109344);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109360, 109389);

                return f_222_109367_109388(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 108416, 109400);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>.Builder
                f_222_108790_108873()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, GeneratedCodeAnalysisFlags>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108790, 108873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_222_109011_109039(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 109011, 109039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_222_109011_109047(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 109011, 109047);
                    return return_v;
                }


                bool
                f_222_108970_109099(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = IsDiagnosticAnalyzerSuppressed(analyzer, options, analyzerManager, analyzerExecutor, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108970, 109099);
                    return return_v;
                }


                int
                f_222_108956_109100(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108956, 109100);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                f_222_109160_109238(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetGeneratedCodeAnalysisFlagsAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109160, 109238);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                f_222_109160_109260(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109160, 109260);
                    return return_v;
                }


                int
                f_222_109279_109328(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109279, 109328);
                    return 0;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_222_108913_108922_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 108913, 108922);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>
                f_222_109367_109388(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109367, 109388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 108416, 109400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 108416, 109400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/pull/23637",
                    AllowLocks = false)]
        private bool IsGeneratedCodeSymbol(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 109412, 110612);
                bool isGeneratedCodeSymbol = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109613, 109709) || true) && (f_222_109617_109647())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 109613, 109709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109681, 109694);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 109613, 109709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 109725, 109943);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(222, 109732, 109808) || ((f_222_109732_109808(f_222_109732_109756(), symbol, out isGeneratedCodeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(222, 109828, 109849)) || DynAbs.Tracing.TraceSender.Conditional_F3(222, 109869, 109942))) ? isGeneratedCodeSymbol : f_222_109869_109942(f_222_109869_109893(), symbol, f_222_109911_109941());

                bool computeIsGeneratedCodeSymbol()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 109959, 110601);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110027, 110246) || true) && (_lazyGeneratedCodeAttribute != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 110031, 110173) && f_222_110070_110173(symbol, _lazyGeneratedCodeAttribute)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 110027, 110246);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110215, 110227);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 110027, 110246);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110266, 110554);
                            foreach (var declaringRef in f_222_110295_110327_I(f_222_110295_110327(symbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 110266, 110554);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110369, 110535) || true) && (!f_222_110374_110449(this, f_222_110406_110429(declaringRef), f_222_110431_110448(declaringRef)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 110369, 110535);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110499, 110512);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 110369, 110535);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 110266, 110554);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 289);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 289);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110574, 110586);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 109959, 110601);

                        bool
                        f_222_110070_110173(Microsoft.CodeAnalysis.ISymbol
                        symbol, Microsoft.CodeAnalysis.INamedTypeSymbol
                        generatedCodeAttribute)
                        {
                            var return_v = GeneratedCodeUtilities.IsGeneratedSymbolWithGeneratedCodeAttribute(symbol, generatedCodeAttribute);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 110070, 110173);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                        f_222_110295_110327(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaringSyntaxReferences;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 110295, 110327);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_222_110406_110429(Microsoft.CodeAnalysis.SyntaxReference
                        this_param)
                        {
                            var return_v = this_param.SyntaxTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 110406, 110429);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_222_110431_110448(Microsoft.CodeAnalysis.SyntaxReference
                        this_param)
                        {
                            var return_v = this_param.Span;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 110431, 110448);
                            return return_v;
                        }


                        bool
                        f_222_110374_110449(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                        span)
                        {
                            var return_v = this_param.IsGeneratedOrHiddenCodeLocation(syntaxTree, span);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 110374, 110449);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                        f_222_110295_110327_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 110295, 110327);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 109959, 110601);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 109959, 110601);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 109412, 110612);

                bool
                f_222_109617_109647()
                {
                    var return_v = TreatAllCodeAsNonGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 109617, 109647);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, bool>
                f_222_109732_109756()
                {
                    var return_v = IsGeneratedCodeSymbolMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 109732, 109756);
                    return return_v;
                }


                bool
                f_222_109732_109808(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, bool>
                this_param, Microsoft.CodeAnalysis.ISymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109732, 109808);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, bool>
                f_222_109869_109893()
                {
                    var return_v = IsGeneratedCodeSymbolMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 109869, 109893);
                    return return_v;
                }


                bool
                f_222_109911_109941()
                {
                    var return_v = computeIsGeneratedCodeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109911, 109941);
                    return return_v;
                }


                bool
                f_222_109869_109942(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, bool>
                this_param, Microsoft.CodeAnalysis.ISymbol
                key, bool
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 109869, 109942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 109412, 110612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 109412, 110612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/pull/23637",
                    AllowLocks = false)]
        protected bool IsGeneratedCode(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 110624, 111807);
                bool isGenerated = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110822, 110918) || true) && (f_222_110826_110856())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 110822, 110918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110890, 110903);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 110822, 110918);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 110934, 111153) || true) && (!f_222_110939_110999(f_222_110939_110960(), tree, out isGenerated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 110934, 111153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111033, 111072);

                    isGenerated = f_222_111047_111071();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111090, 111138);

                    f_222_111090_111137(f_222_111090_111111(), tree, isGenerated);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 110934, 111153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111169, 111188);

                return isGenerated;

                bool computeIsGeneratedCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 111204, 111796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111517, 111611);

                        var
                        options = f_222_111531_111610(f_222_111531_111593(f_222_111531_111563(f_222_111531_111547())), tree)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111629, 111781);

                        return f_222_111636_111697(options) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(222, 111636, 111780) ?? f_222_111722_111780(this, tree, f_222_111745_111779(f_222_111745_111761())));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 111204, 111796);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_111531_111547()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111531, 111547);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                        f_222_111531_111563(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param)
                        {
                            var return_v = this_param.AnalyzerOptions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111531, 111563);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                        f_222_111531_111593(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                        this_param)
                        {
                            var return_v = this_param.AnalyzerConfigOptionsProvider;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111531, 111593);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                        f_222_111531_111610(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        tree)
                        {
                            var return_v = this_param.GetOptions(tree);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111531, 111610);
                            return return_v;
                        }


                        bool?
                        f_222_111636_111697(Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                        options)
                        {
                            var return_v = GeneratedCodeUtilities.GetIsGeneratedCodeFromOptions(options);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111636, 111697);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        f_222_111745_111761()
                        {
                            var return_v = AnalyzerExecutor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111745, 111761);
                            return return_v;
                        }


                        System.Threading.CancellationToken
                        f_222_111745_111779(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                        this_param)
                        {
                            var return_v = this_param.CancellationToken;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111745, 111779);
                            return return_v;
                        }


                        bool
                        f_222_111722_111780(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        arg1, System.Threading.CancellationToken
                        arg2)
                        {
                            var return_v = this_param._isGeneratedCode(arg1, arg2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111722, 111780);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 111204, 111796);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 111204, 111796);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 110624, 111807);

                bool
                f_222_110826_110856()
                {
                    var return_v = TreatAllCodeAsNonGeneratedCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 110826, 110856);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                f_222_110939_110960()
                {
                    var return_v = GeneratedCodeFilesMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 110939, 110960);
                    return return_v;
                }


                bool
                f_222_110939_110999(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 110939, 110999);
                    return return_v;
                }


                bool
                f_222_111047_111071()
                {
                    var return_v = computeIsGeneratedCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111047, 111071);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                f_222_111090_111111()
                {
                    var return_v = GeneratedCodeFilesMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111090, 111111);
                    return return_v;
                }


                bool
                f_222_111090_111137(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111090, 111137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 110624, 111807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 110624, 111807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool DoNotAnalyzeGeneratedCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 111884, 112051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111920, 111974);

                    f_222_111920_111973(f_222_111933_111972(_lazyDoNotAnalyzeGeneratedCode));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 111992, 112036);

                    return f_222_111999_112035(_lazyDoNotAnalyzeGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(222, 111884, 112051);

                    bool
                    f_222_111933_111972(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111933, 111972);
                        return return_v;
                    }


                    int
                    f_222_111920_111973(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 111920, 111973);
                        return 0;
                    }


                    bool
                    f_222_111999_112035(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 111999, 112035);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 111819, 112062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 111819, 112062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool IsGeneratedOrHiddenCodeLocation(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 112307, 112381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112310, 112381);
                return f_222_112310_112337(this, syntaxTree) || (DynAbs.Tracing.TraceSender.Expression_False(222, 112310, 112381) || f_222_112341_112381(this, syntaxTree, span)); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 112307, 112381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 112307, 112381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 112307, 112381);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_222_112310_112337(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            tree)
            {
                var return_v = this_param.IsGeneratedCode(tree);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 112310, 112337);
                return return_v;
            }


            bool
            f_222_112341_112381(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
            span)
            {
                var return_v = this_param.IsHiddenSourceLocation(syntaxTree, span);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 112341, 112381);
                return return_v;
            }

        }

        protected bool IsHiddenSourceLocation(SyntaxTree syntaxTree, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 112483, 112573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112486, 112573);
                return f_222_112486_112514(this, syntaxTree) && (DynAbs.Tracing.TraceSender.Expression_True(222, 112486, 112573) && f_222_112534_112573(syntaxTree, span.Start)); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 112483, 112573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 112483, 112573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 112483, 112573);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_222_112486_112514(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
            this_param, Microsoft.CodeAnalysis.SyntaxTree
            tree)
            {
                var return_v = this_param.HasHiddenRegions(tree);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 112486, 112514);
                return return_v;
            }


            bool
            f_222_112534_112573(Microsoft.CodeAnalysis.SyntaxTree
            tree, int
            position)
            {
                var return_v = tree.IsHiddenPosition(position);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 112534, 112573);
                return return_v;
            }

        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/pull/23637",
                    AllowLocks = false)]
        private bool HasHiddenRegions(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 112586, 113237);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112783, 112887) || true) && (_lazyTreesWithHiddenRegionsMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 112783, 112887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112859, 112872);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 112783, 112887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112903, 112925);

                bool
                hasHiddenRegions
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 112939, 113186) || true) && (!f_222_112944_113014(_lazyTreesWithHiddenRegionsMap, tree, out hasHiddenRegions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 112939, 113186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113048, 113091);

                    hasHiddenRegions = f_222_113067_113090(tree);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113109, 113171);

                    f_222_113109_113170(_lazyTreesWithHiddenRegionsMap, tree, hasHiddenRegions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 112939, 113186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113202, 113226);

                return hasHiddenRegions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 112586, 113237);

                bool
                f_222_112944_113014(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 112944, 113014);
                    return return_v;
                }


                bool
                f_222_113067_113090(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.HasHiddenRegions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 113067, 113090);
                    return return_v;
                }


                bool
                f_222_113109_113170(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.SyntaxTree, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, bool
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 113109, 113170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 112586, 113237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 112586, 113237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal async Task<AnalyzerActionCounts> GetAnalyzerActionCountsAsync(DiagnosticAnalyzer analyzer, CompilationOptions compilationOptions, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 113249, 114056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113449, 113522);

                var
                executor = f_222_113464_113521(f_222_113464_113480(), cancellationToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113536, 113727) || true) && (f_222_113540_113644(analyzer, compilationOptions, f_222_113601_113616(), executor, _severityFilter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 113536, 113727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113678, 113712);

                    return AnalyzerActionCounts.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 113536, 113727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113743, 113853);

                var
                analyzerActions = await f_222_113771_113830(f_222_113771_113786(), analyzer, executor).ConfigureAwait(false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113867, 113977) || true) && (analyzerActions.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 113867, 113977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113928, 113962);

                    return AnalyzerActionCounts.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 113867, 113977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 113993, 114045);

                return f_222_114000_114044(analyzerActions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 113249, 114056);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_113464_113480()
                {
                    var return_v = AnalyzerExecutor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 113464, 113480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_222_113464_113521(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.WithCancellationToken(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 113464, 113521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_113601_113616()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 113601, 113616);
                    return return_v;
                }


                bool
                f_222_113540_113644(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = IsDiagnosticAnalyzerSuppressed(analyzer, options, analyzerManager, analyzerExecutor, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 113540, 113644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_222_113771_113786()
                {
                    var return_v = AnalyzerManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 113771, 113786);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_222_113771_113830(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetAnalyzerActionsAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 113771, 113830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                f_222_114000_114044(Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                analyzerActions)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts(analyzerActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 114000, 114044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 113249, 114056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 113249, 114056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDiagnosticAnalyzerSuppressed(
                    DiagnosticAnalyzer analyzer,
                    CompilationOptions options,
                    AnalyzerManager analyzerManager,
                    AnalyzerExecutor analyzerExecutor,
                    SeverityFilter severityFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 114234, 114676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 114532, 114665);

                return f_222_114539_114664(analyzerManager, analyzer, options, s_IsCompilerAnalyzerFunc, analyzerExecutor, severityFilter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 114234, 114676);

                bool
                f_222_114539_114664(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                isCompilerAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = this_param.IsDiagnosticAnalyzerSuppressed(analyzer, options, isCompilerAnalyzer, analyzerExecutor, severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 114539, 114664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 114234, 114676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 114234, 114676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsCompilerAnalyzer(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 114756, 114797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 114759, 114797);
                return analyzer is CompilerDiagnosticAnalyzer; DynAbs.Tracing.TraceSender.TraceExitMethod(222, 114756, 114797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 114756, 114797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 114756, 114797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 114810, 115089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 114856, 114898);

                f_222_114856_114897_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyCompilationEventQueue, 222, 114856, 114897)?.TryComplete());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 114912, 114948);

                f_222_114912_114947_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyDiagnosticQueue, 222, 114912, 114947)?.TryComplete());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 114985, 115078) || true) && (_lazyQueueRegistration.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 114985, 115078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 115039, 115078);

                    _lazyQueueRegistration.Value.Dispose();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 114985, 115078);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 114810, 115089);

                bool?
                f_222_114856_114897_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 114856, 114897);
                    return return_v;
                }


                bool?
                f_222_114912_114947_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 114912, 114947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 114810, 115089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 114810, 115089);
            }
        }

        Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
        f_222_3703_3725()
        {
            var return_v = CurrentCompilationData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 3703, 3725);
            return return_v;
        }


        Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
        f_222_3703_3747(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
        this_param)
        {
            var return_v = this_param.SemanticModelProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 3703, 3747);
            return return_v;
        }


        int
        f_222_13952_13978()
        {
            var return_v = Environment.ProcessorCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 13952, 13978);
            return return_v;
        }


        static bool
        f_222_15632_15682(Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
        severityFilter, Microsoft.CodeAnalysis.ReportDiagnostic
        severity)
        {
            var return_v = severityFilter.Contains(severity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 15632, 15682);
            return return_v;
        }


        static int
        f_222_15618_15683(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 15618, 15683);
            return 0;
        }


        static bool
        f_222_15712_15761(Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
        severityFilter, Microsoft.CodeAnalysis.ReportDiagnostic
        severity)
        {
            var return_v = severityFilter.Contains(severity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 15712, 15761);
            return return_v;
        }


        static int
        f_222_15698_15762(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 15698, 15762);
            return 0;
        }


        static Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>
        f_222_16176_16208()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostics.Suppression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 16176, 16208);
            return return_v;
        }


        static Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostic>
        f_222_16309_16374(Roslyn.Utilities.ReferenceEqualityComparer
        equalityComparer)
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostic>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Diagnostic>)equalityComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 16309, 16374);
            return return_v;
        }


        Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
        f_222_64903_64919()
        {
            var return_v = AnalyzerExecutor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 64903, 64919);
            return return_v;
        }


        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
        f_222_64903_64942(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
        this_param)
        {
            var return_v = this_param.AnalyzerExecutionTimes;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 64903, 64942);
            return return_v;
        }

    }
    internal partial class AnalyzerDriver<TLanguageKindEnum> : AnalyzerDriver where TLanguageKindEnum : struct
    {
        private readonly Func<SyntaxNode, TLanguageKindEnum> _getKind;

        private GroupedAnalyzerActions? _lazyCoreActions;

        internal AnalyzerDriver(ImmutableArray<DiagnosticAnalyzer> analyzers, Func<SyntaxNode, TLanguageKindEnum> getKind, AnalyzerManager analyzerManager, SeverityFilter severityFilter, Func<SyntaxTrivia, bool> isComment)
        : base(f_222_116519_116528_C(analyzers), analyzerManager, severityFilter, isComment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(222, 116284, 116628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 115504, 115512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 115555, 115571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 116598, 116617);

                _getKind = getKind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(222, 116284, 116628);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 116284, 116628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 116284, 116628);
            }
        }

        private GroupedAnalyzerActions GetOrCreateCoreActions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 116640, 117383);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 116720, 116874) || true) && (_lazyCoreActions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 116720, 116874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 116782, 116859);

                    f_222_116782_116858(ref _lazyCoreActions, f_222_116832_116851(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 116720, 116874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 116890, 116914);

                return _lazyCoreActions;

                GroupedAnalyzerActions createCoreActions()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 116930, 117372);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117005, 117129) || true) && (f_222_117009_117024().IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 117005, 117129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117074, 117110);

                            return GroupedAnalyzerActions.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 117005, 117129);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117203, 117274);

                        var
                        analyzers = f_222_117219_117228().WhereAsArray(f_222_117242_117263().Contains)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117292, 117357);

                        return f_222_117299_117356(analyzers, f_222_117340_117355());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(222, 116930, 117372);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_222_117009_117024()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 117009, 117024);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        f_222_117219_117228()
                        {
                            var return_v = Analyzers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 117219, 117228);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        f_222_117242_117263()
                        {
                            var return_v = UnsuppressedAnalyzers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 117242, 117263);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_222_117340_117355()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 117340, 117355);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                        f_222_117299_117356(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        analyzerActions)
                        {
                            var return_v = GroupedAnalyzerActions.Create(analyzers, analyzerActions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 117299, 117356);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 116930, 117372);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 116930, 117372);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 116640, 117383);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                f_222_116832_116851()
                {
                    var return_v = createCoreActions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 116832, 116851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions?
                f_222_116782_116858(ref Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions?
                location1, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                value, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 116782, 116858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 116640, 117383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 116640, 117383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ComputeShouldExecuteActions(
                    in AnalyzerActions coreActions,
                    in AnalyzerActions additionalActions,
                    ISymbol symbol,
                    out bool executeSyntaxNodeActions,
                    out bool executeCodeBlockActions,
                    out bool executeOperationActions,
                    out bool executeOperationBlockActions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 117395, 119585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117787, 117820);

                executeSyntaxNodeActions = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117834, 117866);

                executeCodeBlockActions = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117880, 117912);

                executeOperationActions = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117926, 117963);

                executeOperationBlockActions = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 117979, 118064);

                var
                canHaveExecutableCodeBlock = f_222_118012_118063(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 118078, 118269);

                f_222_118078_118268(coreActions, canHaveExecutableCodeBlock, ref executeSyntaxNodeActions, ref executeCodeBlockActions, ref executeOperationActions, ref executeOperationBlockActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 118283, 118480);

                f_222_118283_118479(additionalActions, canHaveExecutableCodeBlock, ref executeSyntaxNodeActions, ref executeCodeBlockActions, ref executeOperationActions, ref executeOperationBlockActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 118494, 118501);

                return;

                static void computeShouldExecuteActions(
                                AnalyzerActions analyzerActions,
                                bool canHaveExecutableCodeBlock,
                                ref bool executeSyntaxNodeActions,
                                ref bool executeCodeBlockActions,
                                ref bool executeOperationActions,
                                ref bool executeOperationBlockActions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 118517, 119574);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 118900, 118995) || true) && (analyzerActions.IsEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 118900, 118995);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 118969, 118976);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 118900, 118995);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119015, 119086);

                        executeSyntaxNodeActions |= analyzerActions.SyntaxNodeActionsCount > 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119104, 119173);

                        executeOperationActions |= analyzerActions.OperationActionsCount > 0;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119193, 119559) || true) && (canHaveExecutableCodeBlock)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 119193, 119559);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119265, 119384);

                            executeCodeBlockActions |= analyzerActions.CodeBlockStartActionsCount > 0 || (DynAbs.Tracing.TraceSender.Expression_False(222, 119292, 119383) || analyzerActions.CodeBlockActionsCount > 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119406, 119540);

                            executeOperationBlockActions |= analyzerActions.OperationBlockStartActionsCount > 0 || (DynAbs.Tracing.TraceSender.Expression_False(222, 119438, 119539) || analyzerActions.OperationBlockActionsCount > 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 119193, 119559);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 118517, 119574);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 118517, 119574);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 118517, 119574);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 117395, 119585);

                bool
                f_222_118012_118063(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = AnalyzerExecutor.CanHaveExecutableCodeBlock(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 118012, 118063);
                    return return_v;
                }


                int
                f_222_118078_118268(Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                analyzerActions, bool
                canHaveExecutableCodeBlock, ref bool
                executeSyntaxNodeActions, ref bool
                executeCodeBlockActions, ref bool
                executeOperationActions, ref bool
                executeOperationBlockActions)
                {
                    computeShouldExecuteActions(analyzerActions, canHaveExecutableCodeBlock, ref executeSyntaxNodeActions, ref executeCodeBlockActions, ref executeOperationActions, ref executeOperationBlockActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 118078, 118268);
                    return 0;
                }


                int
                f_222_118283_118479(Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                analyzerActions, bool
                canHaveExecutableCodeBlock, ref bool
                executeSyntaxNodeActions, ref bool
                executeCodeBlockActions, ref bool
                executeOperationActions, ref bool
                executeOperationBlockActions)
                {
                    computeShouldExecuteActions(analyzerActions, canHaveExecutableCodeBlock, ref executeSyntaxNodeActions, ref executeCodeBlockActions, ref executeOperationActions, ref executeOperationBlockActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 118283, 118479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 117395, 119585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 117395, 119585);
            }
        }

        protected override IGroupedAnalyzerActions EmptyGroupedActions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 119660, 119691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119663, 119691);
                    return GroupedAnalyzerActions.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(222, 119660, 119691);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 119660, 119691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 119660, 119691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override IGroupedAnalyzerActions CreateGroupedActions(DiagnosticAnalyzer analyzer, in AnalyzerActions analyzerActions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 119844, 119903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 119847, 119903);
                return f_222_119847_119903(analyzer, analyzerActions); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 119844, 119903);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 119844, 119903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 119844, 119903);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
            f_222_119847_119903(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            analyzerActions)
            {
                var return_v = GroupedAnalyzerActions.Create(analyzer, analyzerActions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 119847, 119903);
                return return_v;
            }

        }

        /// <summary>
        /// Tries to execute syntax node, code block and operation actions for all declarations for the given symbol.
        /// </summary>
        /// <returns>
        /// True, if successfully executed the actions for the given analysis scope OR no actions were required to be executed for the given analysis scope.
        /// False, otherwise.
        /// </returns>
        protected override bool TryExecuteDeclaringReferenceActions(
            SymbolDeclaredCompilationEvent symbolEvent,
            AnalysisScope analysisScope,
            AnalysisState? analysisState,
            bool isGeneratedCodeSymbol,
            IGroupedAnalyzerActions additionalPerSymbolActions,
            CancellationToken cancellationToken)
        {
            var symbol = symbolEvent.Symbol;

            ComputeShouldExecuteActions(
                AnalyzerActions, additionalPerSymbolActions.AnalyzerActions, symbol,
                executeSyntaxNodeActions: out var executeSyntaxNodeActions,
                executeCodeBlockActions: out var executeCodeBlockActions,
                executeOperationActions: out var executeOperationActions,
                executeOperationBlockActions: out var executeOperationBlockActions);

            var success = true;
            if (executeSyntaxNodeActions || executeOperationActions || executeCodeBlockActions || executeOperationBlockActions)
            {
                var declaringReferences = symbolEvent.DeclaringSyntaxReferences;
                var coreActions = GetOrCreateCoreActions();
                for (var i = 0; i < declaringReferences.Length; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var decl = declaringReferences[i];
                    if (analysisScope.FilterFileOpt != null && analysisScope.FilterFileOpt?.SourceTree != decl.SyntaxTree)
                    {
                        continue;
                    }

                    var isInGeneratedCode = isGeneratedCodeSymbol || IsGeneratedOrHiddenCodeLocation(decl.SyntaxTree, decl.Span);
                    if (isInGeneratedCode && DoNotAnalyzeGeneratedCode)
                    {
                        analysisState?.MarkDeclarationComplete(symbol, i, analysisScope.Analyzers);
                        continue;
                    }

                    if (!TryExecuteDeclaringReferenceActions(decl, i, symbolEvent, analysisScope, analysisState, coreActions, (GroupedAnalyzerActions)additionalPerSymbolActions,
                        executeSyntaxNodeActions, executeOperationActions, executeCodeBlockActions, executeOperationBlockActions, isInGeneratedCode, cancellationToken))
                    {
                        success = false;
                    }
                }
            }
            else if (analysisState != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                analysisState.MarkDeclarationsComplete(symbol, analysisScope.Analyzers);

                var declaringReferences = symbolEvent.DeclaringSyntaxReferences;
                for (var i = 0; i < declaringReferences.Length; i++)
                {
                    var decl = declaringReferences[i];
                    ClearCachedAnalysisDataIfAnalyzed(decl, symbol, i, analysisState);
                }
            }

            return success;
        }

        private void ClearCachedAnalysisDataIfAnalyzed(SyntaxReference declaration, ISymbol symbol, int declarationIndex, AnalysisState analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 123404, 123837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 123571, 123607);

                f_222_123571_123606(analysisState != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 123623, 123745) || true) && (!f_222_123628_123689(analysisState, symbol, declarationIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 123623, 123745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 123723, 123730);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 123623, 123745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 123761, 123826);

                f_222_123761_123825(
                            CurrentCompilationData, declaration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 123404, 123837);

                int
                f_222_123571_123606(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 123571, 123606);
                    return 0;
                }


                bool
                f_222_123628_123689(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex)
                {
                    var return_v = this_param.IsDeclarationComplete(symbol, declarationIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 123628, 123689);
                    return return_v;
                }


                int
                f_222_123761_123825(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                this_param, Microsoft.CodeAnalysis.SyntaxReference
                declaration)
                {
                    this_param.ClearDeclarationAnalysisData(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 123761, 123825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 123404, 123837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 123404, 123837);
            }
        }

        private DeclarationAnalysisData ComputeDeclarationAnalysisData(
                    ISymbol symbol,
                    SyntaxReference declaration,
                    SemanticModel semanticModel,
                    AnalysisScope analysisScope,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 123849, 125243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124142, 124191);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124207, 124265);

                var
                builder = f_222_124221_124264()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124279, 124358);

                SyntaxNode
                declaringReferenceSyntax = f_222_124317_124357(declaration, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124372, 124492);

                SyntaxNode
                topmostNodeForAnalysis = f_222_124408_124491(semanticModel, symbol, declaringReferenceSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124506, 124633);

                f_222_124506_124632(semanticModel, symbol, declaringReferenceSyntax, topmostNodeForAnalysis, builder, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124647, 124727);

                ImmutableArray<DeclarationInfo>
                declarationInfos = f_222_124698_124726(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124743, 124873);

                bool
                isPartialDeclAnalysis = analysisScope.FilterSpanOpt.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(222, 124772, 124872) && !f_222_124813_124872(analysisScope, f_222_124840_124871(topmostNodeForAnalysis)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 124887, 125076);

                ImmutableArray<SyntaxNode>
                nodesToAnalyze = f_222_124931_125075(topmostNodeForAnalysis, symbol, declarationInfos, analysisScope, isPartialDeclAnalysis, semanticModel, AnalyzerExecutor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 125090, 125232);

                return f_222_125097_125231(declaringReferenceSyntax, topmostNodeForAnalysis, declarationInfos, nodesToAnalyze, isPartialDeclAnalysis);
                DynAbs.Tracing.TraceSender.TraceExitMethod(222, 123849, 125243);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                f_222_124221_124264()
                {
                    var return_v = ArrayBuilder<DeclarationInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124221, 124264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_124317_124357(Microsoft.CodeAnalysis.SyntaxReference
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSyntax(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124317, 124357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_124408_124491(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                declaringSyntax)
                {
                    var return_v = this_param.GetTopmostNodeForDiagnosticAnalysis(symbol, declaringSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124408, 124491);
                    return return_v;
                }


                int
                f_222_124506_124632(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, Microsoft.CodeAnalysis.SyntaxNode
                declaringReferenceSyntax, Microsoft.CodeAnalysis.SyntaxNode
                topmostNodeForAnalysis, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                builder, System.Threading.CancellationToken
                cancellationToken)
                {
                    ComputeDeclarationsInNode(semanticModel, declaredSymbol, declaringReferenceSyntax, topmostNodeForAnalysis, builder, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124506, 124632);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DeclarationInfo>
                f_222_124698_124726(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124698, 124726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_222_124840_124871(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 124840, 124871);
                    return return_v;
                }


                bool
                f_222_124813_124872(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan)
                {
                    var return_v = this_param.ContainsSpan(filterSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124813, 124872);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_124931_125075(Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DeclarationInfo>
                declarationsInNode, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                isPartialDeclAnalysis, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = GetSyntaxNodesToAnalyze(declaredNode, declaredSymbol, declarationsInNode, analysisScope, isPartialDeclAnalysis, semanticModel, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 124931, 125075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                f_222_125097_125231(Microsoft.CodeAnalysis.SyntaxNode
                declaringReferenceSyntax, Microsoft.CodeAnalysis.SyntaxNode
                topmostNodeForAnalysis, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DeclarationInfo>
                declarationsInNodeBuilder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                descendantNodesToAnalyze, bool
                isPartialAnalysis)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData(declaringReferenceSyntax, topmostNodeForAnalysis, declarationsInNodeBuilder, descendantNodesToAnalyze, isPartialAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 125097, 125231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 123849, 125243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 123849, 125243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ComputeDeclarationsInNode(SemanticModel semanticModel, ISymbol declaredSymbol, SyntaxNode declaringReferenceSyntax, SyntaxNode topmostNodeForAnalysis, ArrayBuilder<DeclarationInfo> builder, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 125255, 125947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 125633, 125658);

                int?
                levelsToCompute = 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 125672, 125786);

                var
                getSymbol = topmostNodeForAnalysis != declaringReferenceSyntax || (DynAbs.Tracing.TraceSender.Expression_False(222, 125688, 125785) || f_222_125742_125761(declaredSymbol) == SymbolKind.Namespace)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 125800, 125936);

                f_222_125800_125935(semanticModel, topmostNodeForAnalysis, declaredSymbol, getSymbol, builder, cancellationToken, levelsToCompute);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 125255, 125947);

                Microsoft.CodeAnalysis.SymbolKind
                f_222_125742_125761(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 125742, 125761);
                    return return_v;
                }


                int
                f_222_125800_125935(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.ISymbol
                associatedSymbol, bool
                getSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DeclarationInfo>
                builder, System.Threading.CancellationToken
                cancellationToken, int?
                levelsToCompute)
                {
                    this_param.ComputeDeclarationsInNode(node, associatedSymbol, getSymbol, builder, cancellationToken, levelsToCompute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 125800, 125935);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 125255, 125947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 125255, 125947);
            }
        }

        /// <summary>
        /// Tries to execute syntax node, code block and operation actions for the given declaration.
        /// </summary>
        /// <returns>
        /// True, if successfully executed the actions for the given analysis scope OR no actions were required to be executed for the given analysis scope.
        /// False, otherwise.
        /// </returns>
        private bool TryExecuteDeclaringReferenceActions(
            SyntaxReference decl,
            int declarationIndex,
            SymbolDeclaredCompilationEvent symbolEvent,
            AnalysisScope analysisScope,
            AnalysisState? analysisState,
            GroupedAnalyzerActions coreActions,
            GroupedAnalyzerActions additionalPerSymbolActions,
            bool shouldExecuteSyntaxNodeActions,
            bool shouldExecuteOperationActions,
            bool shouldExecuteCodeBlockActions,
            bool shouldExecuteOperationBlockActions,
            bool isInGeneratedCode,
            CancellationToken cancellationToken)
        {
            Debug.Assert(shouldExecuteSyntaxNodeActions || shouldExecuteOperationActions || shouldExecuteCodeBlockActions || shouldExecuteOperationBlockActions);
            Debug.Assert(!isInGeneratedCode || !DoNotAnalyzeGeneratedCode);

            var symbol = symbolEvent.Symbol;

            var semanticModel = symbolEvent.SemanticModelWithCachedBoundNodes ??
                SemanticModelProvider.GetSemanticModel(decl.SyntaxTree, symbolEvent.Compilation);

            var cacheAnalysisData = analysisScope.Analyzers.Length < Analyzers.Length &&
                (!analysisScope.FilterSpanOpt.HasValue || analysisScope.FilterSpanOpt.Value.Length >= decl.SyntaxTree.GetRoot(cancellationToken).Span.Length);

            var declarationAnalysisData = CurrentCompilationData.GetOrComputeDeclarationAnalysisData(
                decl,
                computeDeclarationAnalysisData: () => ComputeDeclarationAnalysisData(symbol, decl, semanticModel, analysisScope, cancellationToken),
                cacheAnalysisData: cacheAnalysisData);

            if (!analysisScope.ShouldAnalyze(declarationAnalysisData.TopmostNodeForAnalysis))
            {
                return true;
            }

            var success = true;

            // Execute stateless syntax node actions.
            executeNodeActions();

            // Execute actions in executable code: code block actions, operation actions and operation block actions.
            executeExecutableCodeActions();

            // Mark completion if we successfully executed all actions and only if we are analyzing a span containing the entire syntax node.
            if (success && analysisState != null && !declarationAnalysisData.IsPartialAnalysis)
            {
                // Ensure that we do not mark declaration complete/clear state if cancellation was requested.
                // Other thread(s) might still be executing analysis, and clearing state could lead to corrupt execution
                // or unknown exceptions.
                cancellationToken.ThrowIfCancellationRequested();

                foreach (var analyzer in analysisScope.Analyzers)
                {
                    analysisState.MarkDeclarationComplete(symbol, declarationIndex, analyzer);
                }

                if (cacheAnalysisData)
                {
                    ClearCachedAnalysisDataIfAnalyzed(decl, symbol, declarationIndex, analysisState);
                }
            }

            return success;

            void executeNodeActions()
            {
                if (shouldExecuteSyntaxNodeActions)
                {
                    var nodesToAnalyze = declarationAnalysisData.DescendantNodesToAnalyze;
                    executeNodeActionsByKind(analysisScope, nodesToAnalyze, coreActions);
                    executeNodeActionsByKind(analysisScope, nodesToAnalyze, additionalPerSymbolActions);
                }
            }

            void executeNodeActionsByKind(AnalysisScope analysisScope, ImmutableArray<SyntaxNode> nodesToAnalyze, GroupedAnalyzerActions groupedActions)
            {
                foreach (var (analyzer, groupedActionsForAnalyzer) in groupedActions.GroupedActionsByAnalyzer)
                {
                    var nodeActionsByKind = groupedActionsForAnalyzer.NodeActionsByAnalyzerAndKind;
                    if (nodeActionsByKind.IsEmpty || !analysisScope.Contains(analyzer))
                    {
                        continue;
                    }

                    if (!AnalyzerExecutor.TryExecuteSyntaxNodeActions(nodesToAnalyze, nodeActionsByKind,
                            analyzer, semanticModel, _getKind, declarationAnalysisData.TopmostNodeForAnalysis.FullSpan,
                            declarationIndex, symbol, analysisScope, analysisState, isInGeneratedCode))
                    {
                        success = false;
                    }
                }
            }

            void executeExecutableCodeActions()
            {
                if (!shouldExecuteCodeBlockActions && !shouldExecuteOperationActions && !shouldExecuteOperationBlockActions)
                {
                    return;
                }

                // Compute the executable code blocks of interest.
                var executableCodeBlocks = ImmutableArray<SyntaxNode>.Empty;
                var executableCodeBlockActionsBuilder = ArrayBuilder<ExecutableCodeBlockAnalyzerActions>.GetInstance();
                try
                {
                    foreach (var declInNode in declarationAnalysisData.DeclarationsInNode)
                    {
                        if (declInNode.DeclaredNode == declarationAnalysisData.TopmostNodeForAnalysis || declInNode.DeclaredNode == declarationAnalysisData.DeclaringReferenceSyntax)
                        {
                            executableCodeBlocks = declInNode.ExecutableCodeBlocks;
                            if (!executableCodeBlocks.IsEmpty)
                            {
                                if (shouldExecuteCodeBlockActions || shouldExecuteOperationBlockActions)
                                {
                                    addExecutableCodeBlockAnalyzerActions(coreActions, analysisScope, executableCodeBlockActionsBuilder);
                                    addExecutableCodeBlockAnalyzerActions(additionalPerSymbolActions, analysisScope, executableCodeBlockActionsBuilder);
                                }

                                // Execute operation actions.
                                if (shouldExecuteOperationActions || shouldExecuteOperationBlockActions)
                                {
                                    var operationBlocksToAnalyze = GetOperationBlocksToAnalyze(executableCodeBlocks, semanticModel, cancellationToken);
                                    var operationsToAnalyze = getOperationsToAnalyzeWithStackGuard(operationBlocksToAnalyze);

                                    if (!operationsToAnalyze.IsEmpty)
                                    {
                                        try
                                        {
                                            executeOperationsActions(operationsToAnalyze);
                                            executeOperationsBlockActions(operationBlocksToAnalyze, operationsToAnalyze, executableCodeBlockActionsBuilder);
                                        }
                                        finally
                                        {
                                            AnalyzerExecutor.OnOperationBlockActionsExecuted(operationBlocksToAnalyze);
                                        }
                                    }
                                }

                                break;
                            }
                        }
                    }

                    executeCodeBlockActions(executableCodeBlocks, executableCodeBlockActionsBuilder);
                }
                finally
                {
                    executableCodeBlockActionsBuilder.Free();
                }
            }

            ImmutableArray<IOperation> getOperationsToAnalyzeWithStackGuard(ImmutableArray<IOperation> operationBlocksToAnalyze)
            {
                try
                {
                    return GetOperationsToAnalyze(operationBlocksToAnalyze);
                }
                catch (Exception ex) when (ex is InsufficientExecutionStackException || FatalError.ReportAndCatchUnlessCanceled(ex))
                {
                    // the exception filter will short-circuit if `ex` is `InsufficientExecutionStackException` (from OperationWalker)
                    // and no non-fatal-watson will be logged as a result.
                    var diagnostic = AnalyzerExecutor.CreateDriverExceptionDiagnostic(ex);
                    var analyzer = this.Analyzers[0];

                    AnalyzerExecutor.OnAnalyzerException(ex, analyzer, diagnostic);
                    return ImmutableArray<IOperation>.Empty;
                }
            }

            void executeOperationsActions(ImmutableArray<IOperation> operationsToAnalyze)
            {
                if (shouldExecuteOperationActions)
                {
                    executeOperationsActionsByKind(analysisScope, operationsToAnalyze, coreActions);
                    executeOperationsActionsByKind(analysisScope, operationsToAnalyze, additionalPerSymbolActions);
                }
            }

            void executeOperationsActionsByKind(AnalysisScope analysisScope, ImmutableArray<IOperation> operationsToAnalyze, GroupedAnalyzerActions groupedActions)
            {
                foreach (var (analyzer, groupedActionsForAnalyzer) in groupedActions.GroupedActionsByAnalyzer)
                {
                    var operationActionsByKind = groupedActionsForAnalyzer.OperationActionsByAnalyzerAndKind;
                    if (operationActionsByKind.IsEmpty || !analysisScope.Contains(analyzer))
                    {
                        continue;
                    }

                    if (!AnalyzerExecutor.TryExecuteOperationActions(operationsToAnalyze, operationActionsByKind,
                            analyzer, semanticModel, declarationAnalysisData.TopmostNodeForAnalysis.FullSpan,
                            declarationIndex, symbol, analysisScope, analysisState, isInGeneratedCode))
                    {
                        success = false;
                    }
                }
            }

            void executeOperationsBlockActions(ImmutableArray<IOperation> operationBlocksToAnalyze, ImmutableArray<IOperation> operationsToAnalyze, IEnumerable<ExecutableCodeBlockAnalyzerActions> codeBlockActions)
            {
                if (!shouldExecuteOperationBlockActions)
                {
                    return;
                }

                foreach (var analyzerActions in codeBlockActions)
                {
                    if (analyzerActions.OperationBlockStartActions.IsEmpty &&
                        analyzerActions.OperationBlockActions.IsEmpty &&
                        analyzerActions.OperationBlockEndActions.IsEmpty)
                    {
                        continue;
                    }

                    if (!analysisScope.Contains(analyzerActions.Analyzer))
                    {
                        continue;
                    }

                    if (!AnalyzerExecutor.TryExecuteOperationBlockActions(
                        analyzerActions.OperationBlockStartActions, analyzerActions.OperationBlockActions,
                        analyzerActions.OperationBlockEndActions, analyzerActions.Analyzer, declarationAnalysisData.TopmostNodeForAnalysis, symbol,
                        operationBlocksToAnalyze, operationsToAnalyze, semanticModel, declarationIndex, analysisScope, analysisState, isInGeneratedCode))
                    {
                        success = false;
                    }
                }
            }

            void executeCodeBlockActions(ImmutableArray<SyntaxNode> executableCodeBlocks, IEnumerable<ExecutableCodeBlockAnalyzerActions> codeBlockActions)
            {
                if (executableCodeBlocks.IsEmpty || !shouldExecuteCodeBlockActions)
                {
                    return;
                }

                foreach (var analyzerActions in codeBlockActions)
                {
                    if (analyzerActions.CodeBlockStartActions.IsEmpty &&
                        analyzerActions.CodeBlockActions.IsEmpty &&
                        analyzerActions.CodeBlockEndActions.IsEmpty)
                    {
                        continue;
                    }

                    if (!analysisScope.Contains(analyzerActions.Analyzer))
                    {
                        continue;
                    }

                    if (!AnalyzerExecutor.TryExecuteCodeBlockActions(
                        analyzerActions.CodeBlockStartActions, analyzerActions.CodeBlockActions,
                        analyzerActions.CodeBlockEndActions, analyzerActions.Analyzer, declarationAnalysisData.TopmostNodeForAnalysis, symbol,
                        executableCodeBlocks, semanticModel, _getKind, declarationIndex, analysisScope, analysisState, isInGeneratedCode))
                    {
                        success = false;
                    }
                }
            }

            static void addExecutableCodeBlockAnalyzerActions(
                GroupedAnalyzerActions groupedActions,
                AnalysisScope analysisScope,
                ArrayBuilder<ExecutableCodeBlockAnalyzerActions> builder)
            {
                foreach (var (analyzer, groupedActionsForAnalyzer) in groupedActions.GroupedActionsByAnalyzer)
                {
                    if (analysisScope.Contains(analyzer) &&
                        groupedActionsForAnalyzer.TryGetExecutableCodeBlockActions(out var executableCodeBlockActions))
                    {
                        builder.Add(executableCodeBlockActions);
                    }
                }
            }
        }

        private static ImmutableArray<SyntaxNode> GetSyntaxNodesToAnalyze(
                    SyntaxNode declaredNode,
                    ISymbol declaredSymbol,
                    ImmutableArray<DeclarationInfo> declarationsInNode,
                    AnalysisScope analysisScope,
                    bool isPartialDeclAnalysis,
                    SemanticModel semanticModel,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 140451, 143808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141006, 141056);

                HashSet<SyntaxNode>?
                descendantDeclsToSkip = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141070, 141088);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141102, 142981);
                    foreach (var declInNode in f_222_141129_141147_I(declarationsInNode))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 141102, 142981);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141181, 141247);

                        analyzerExecutor.CancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141267, 142932) || true) && (declInNode.DeclaredNode != declaredNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 141267, 142932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141821, 142127) || true) && (f_222_141825_141886(declaredSymbol, declInNode.DeclaredSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 141821, 142127);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 141936, 142036) || true) && (first)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 141936, 142036);
                                    DynAbs.Tracing.TraceSender.TraceBreak(222, 142003, 142009);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 141936, 142036);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142064, 142104);

                                return ImmutableArray<SyntaxNode>.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 141821, 142127);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142277, 142329);

                            var
                            declarationNodeToSkip = declInNode.DeclaredNode
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142351, 142506);

                            var
                            declaredSymbolOfDeclInNode = declInNode.DeclaredSymbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ISymbol?>(222, 142384, 142505) ?? f_222_142413_142505(semanticModel, declInNode.DeclaredNode, f_222_142470_142504(analyzerExecutor)))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142528, 142766) || true) && (declaredSymbolOfDeclInNode != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 142528, 142766);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142616, 142743);

                                declarationNodeToSkip = f_222_142640_142742(semanticModel, declaredSymbolOfDeclInNode, declInNode.DeclaredNode);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 142528, 142766);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142790, 142842);

                            descendantDeclsToSkip ??= f_222_142816_142841();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142864, 142913);

                            f_222_142864_142912(descendantDeclsToSkip, declarationNodeToSkip);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 141267, 142932);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142952, 142966);

                        first = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 141102, 142981);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 1880);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 1880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 142997, 143114);

                Func<SyntaxNode, bool>?
                additionalFilter = f_222_143040_143113(semanticModel, declaredNode, declaredSymbol)
                ;

                bool shouldAddNode(SyntaxNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(222, 143166, 143297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143169, 143297);
                        return (descendantDeclsToSkip == null || (DynAbs.Tracing.TraceSender.Expression_False(222, 143170, 143240) || !f_222_143204_143240(descendantDeclsToSkip, node))) && (DynAbs.Tracing.TraceSender.Expression_True(222, 143169, 143297) && (additionalFilter is null || (DynAbs.Tracing.TraceSender.Expression_False(222, 143246, 143296) || f_222_143274_143296(additionalFilter, node)))); DynAbs.Tracing.TraceSender.TraceExitMethod(222, 143166, 143297);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 143166, 143297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 143166, 143297);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143312, 143369);

                var
                nodeBuilder = f_222_143330_143368()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143383, 143741);
                    foreach (var node in f_222_143404_143500_I(f_222_143404_143500(declaredNode, descendIntoChildren: shouldAddNode, descendIntoTrivia: true)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 143383, 143741);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143534, 143726) || true) && (f_222_143538_143557(node) && (DynAbs.Tracing.TraceSender.Expression_True(222, 143538, 143643) && (!isPartialDeclAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(222, 143583, 143642) || f_222_143609_143642(analysisScope, node)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 143534, 143726);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143685, 143707);

                            f_222_143685_143706(nodeBuilder, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 143534, 143726);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 143383, 143741);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143757, 143797);

                return f_222_143764_143796(nodeBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 140451, 143808);

                bool
                f_222_141825_141886(Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, Microsoft.CodeAnalysis.ISymbol?
                otherSymbol)
                {
                    var return_v = IsEquivalentSymbol(declaredSymbol, otherSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 141825, 141886);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_222_142470_142504(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 142470, 142504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_222_142413_142505(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 142413, 142505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_222_142640_142742(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                declaringSyntax)
                {
                    var return_v = this_param.GetTopmostNodeForDiagnosticAnalysis(symbol, declaringSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 142640, 142742);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_142816_142841()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 142816, 142841);
                    return return_v;
                }


                bool
                f_222_142864_142912(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 142864, 142912);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DeclarationInfo>
                f_222_141129_141147_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DeclarationInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 141129, 141147);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                f_222_143040_143113(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol)
                {
                    var return_v = this_param.GetSyntaxNodesToAnalyzeFilter(declaredNode, declaredSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143040, 143113);
                    return return_v;
                }


                bool
                f_222_143204_143240(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143204, 143240);
                    return return_v;
                }


                bool
                f_222_143274_143296(System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143274, 143296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_143330_143368()
                {
                    var return_v = ArrayBuilder<SyntaxNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143330, 143368);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_143404_143500(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                descendIntoChildren, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantNodesAndSelf(descendIntoChildren: descendIntoChildren, descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143404, 143500);
                    return return_v;
                }


                bool
                f_222_143538_143557(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = shouldAddNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143538, 143557);
                    return return_v;
                }


                bool
                f_222_143609_143642(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.ShouldAnalyze(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143609, 143642);
                    return return_v;
                }


                int
                f_222_143685_143706(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143685, 143706);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_143404_143500_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143404, 143500);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_143764_143796(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143764, 143796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 140451, 143808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 140451, 143808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEquivalentSymbol(ISymbol declaredSymbol, ISymbol? otherSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 143820, 144588);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 143929, 144028) || true) && (f_222_143933_143967(declaredSymbol, otherSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 143929, 144028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 144001, 144013);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(222, 143929, 144028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 144279, 144577);

                return otherSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(222, 144286, 144369) && f_222_144326_144345(declaredSymbol) == SymbolKind.Namespace) && (DynAbs.Tracing.TraceSender.Expression_True(222, 144286, 144430) && f_222_144390_144406(otherSymbol) == SymbolKind.Namespace) && (DynAbs.Tracing.TraceSender.Expression_True(222, 144286, 144490) && f_222_144451_144470(declaredSymbol) == f_222_144474_144490(otherSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(222, 144286, 144576) && f_222_144511_144543(declaredSymbol) == f_222_144547_144576(otherSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 143820, 144588);

                bool
                f_222_143933_143967(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.ISymbol?
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 143933, 143967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_222_144326_144345(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 144326, 144345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_222_144390_144406(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 144390, 144406);
                    return return_v;
                }


                string
                f_222_144451_144470(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 144451, 144470);
                    return return_v;
                }


                string
                f_222_144474_144490(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 144474, 144490);
                    return return_v;
                }


                string
                f_222_144511_144543(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 144511, 144543);
                    return return_v;
                }


                string
                f_222_144547_144576(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 144547, 144576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 143820, 144588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 143820, 144588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<IOperation> GetOperationBlocksToAnalyze(
                    ImmutableArray<SyntaxNode> executableBlocks,
                    SemanticModel semanticModel,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 144600, 145325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 144845, 144936);

                ArrayBuilder<IOperation>
                operationBlocksToAnalyze = f_222_144897_144935()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 144952, 145245);
                    foreach (SyntaxNode executableBlock in f_222_144991_145007_I(executableBlocks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 144952, 145245);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145041, 145230) || true) && (f_222_145045_145107(semanticModel, executableBlock, cancellationToken) is { } operation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 145041, 145230);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145166, 145211);

                            f_222_145166_145210(operationBlocksToAnalyze, operation);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 145041, 145230);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 144952, 145245);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145261, 145314);

                return f_222_145268_145313(operationBlocksToAnalyze);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 144600, 145325);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                f_222_144897_144935()
                {
                    var return_v = ArrayBuilder<IOperation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 144897, 144935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_222_145045_145107(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOperation(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 145045, 145107);
                    return return_v;
                }


                int
                f_222_145166_145210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, params Microsoft.CodeAnalysis.IOperation[]
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 145166, 145210);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                f_222_144991_145007_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 144991, 145007);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_222_145268_145313(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 145268, 145313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 144600, 145325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 144600, 145325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<IOperation> GetOperationsToAnalyze(
                    ImmutableArray<IOperation> operationBlocks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(222, 145337, 148603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145484, 145570);

                ArrayBuilder<IOperation>
                operationsToAnalyze = f_222_145531_145569()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145584, 145607);

                var
                checkParent = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145623, 148424);
                    foreach (IOperation operationBlock in f_222_145661_145676_I(operationBlocks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 145623, 148424);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 145710, 148323) || true) && (checkParent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 145710, 148323);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 146602, 148304) || true) && (f_222_146606_146627(operationBlock) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 146602, 148304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 146685, 148233);

                                switch (f_222_146693_146719(f_222_146693_146714(operationBlock)))
                                {

                                    case OperationKind.MethodBody:
                                    case OperationKind.ConstructorBody:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 146685, 148233);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 146906, 146954);

                                        f_222_146906_146953(f_222_146919_146952_M(!f_222_146920_146941(operationBlock).IsImplicit));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 146988, 147035);

                                        f_222_146988_147034(operationsToAnalyze, f_222_147012_147033(operationBlock));
                                        DynAbs.Tracing.TraceSender.TraceBreak(222, 147069, 147075);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 146685, 148233);

                                    case OperationKind.ExpressionStatement:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 146685, 148233);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147336, 147398);

                                        f_222_147336_147397(f_222_147349_147368(operationBlock) == OperationKind.Invocation);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147432, 147479);

                                        f_222_147432_147478(f_222_147445_147477(f_222_147445_147466(operationBlock)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147513, 147680);

                                        f_222_147513_147679(f_222_147526_147554(f_222_147526_147547(operationBlock)) is IConstructorBodyOperation ctorBody && (DynAbs.Tracing.TraceSender.Expression_True(222, 147526, 147678) && f_222_147633_147653(ctorBody) == f_222_147657_147678(operationBlock)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147714, 147769);

                                        f_222_147714_147768(f_222_147727_147767_M(!f_222_147728_147756(f_222_147728_147749(operationBlock)).IsImplicit));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147805, 147859);

                                        f_222_147805_147858(
                                                                        operationsToAnalyze, f_222_147829_147857(f_222_147829_147850(operationBlock)));
                                        DynAbs.Tracing.TraceSender.TraceBreak(222, 147895, 147901);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 146685, 148233);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(222, 146685, 148233);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 147975, 148166);

                                        f_222_147975_148165($"Expected operation with kind '{f_222_148019_148038(operationBlock)}' to be the root operation with null 'Parent', but instead it has a non-null Parent with kind '{f_222_148135_148161(f_222_148135_148156(operationBlock))}'");
                                        DynAbs.Tracing.TraceSender.TraceBreak(222, 148200, 148206);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 146685, 148233);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 148261, 148281);

                                checkParent = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(222, 146602, 148304);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(222, 145710, 148323);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 148343, 148409);

                        f_222_148343_148408(
                                        operationsToAnalyze, f_222_148372_148407(operationBlock));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(222, 145623, 148424);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(222, 1, 2802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(222, 1, 2802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 148440, 148530);

                f_222_148440_148529(f_222_148453_148499(f_222_148453_148493(operationsToAnalyze)) == f_222_148503_148528(operationsToAnalyze));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 148544, 148592);

                return f_222_148551_148591(operationsToAnalyze);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(222, 145337, 148603);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                f_222_145531_145569()
                {
                    var return_v = ArrayBuilder<IOperation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 145531, 145569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_222_146606_146627(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 146606, 146627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_146693_146714(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 146693, 146714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_222_146693_146719(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 146693, 146719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_146920_146941(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 146920, 146941);
                    return return_v;
                }


                bool
                f_222_146919_146952_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 146919, 146952);
                    return return_v;
                }


                int
                f_222_146906_146953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 146906, 146953);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147012_147033(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147012, 147033);
                    return return_v;
                }


                int
                f_222_146988_147034(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 146988, 147034);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_222_147349_147368(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147349, 147368);
                    return return_v;
                }


                int
                f_222_147336_147397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147336, 147397);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147445_147466(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147445, 147466);
                    return return_v;
                }


                bool
                f_222_147445_147477(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.IsImplicit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147445, 147477);
                    return return_v;
                }


                int
                f_222_147432_147478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147432, 147478);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147526_147547(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147526, 147547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_222_147526_147554(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147526, 147554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_222_147633_147653(Microsoft.CodeAnalysis.Operations.IConstructorBodyOperation
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147633, 147653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147657_147678(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147657, 147678);
                    return return_v;
                }


                int
                f_222_147513_147679(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147513, 147679);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147728_147749(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147728, 147749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147728_147756(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147728, 147756);
                    return return_v;
                }


                bool
                f_222_147727_147767_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147727, 147767);
                    return return_v;
                }


                int
                f_222_147714_147768(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147714, 147768);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147829_147850(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147829, 147850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_147829_147857(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 147829, 147857);
                    return return_v;
                }


                int
                f_222_147805_147858(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147805, 147858);
                    return 0;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_222_148019_148038(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 148019, 148038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_222_148135_148156(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 148135, 148156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_222_148135_148161(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 148135, 148161);
                    return return_v;
                }


                int
                f_222_147975_148165(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 147975, 148165);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_222_148372_148407(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.DescendantsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 148372, 148407);
                    return return_v;
                }


                int
                f_222_148343_148408(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 148343, 148408);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_222_145661_145676_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 145661, 145676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.IOperation>
                f_222_148453_148493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.IOperation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 148453, 148493);
                    return return_v;
                }


                int
                f_222_148453_148499(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 148453, 148499);
                    return return_v;
                }


                int
                f_222_148503_148528(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(222, 148503, 148528);
                    return return_v;
                }


                int
                f_222_148440_148529(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 148440, 148529);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_222_148551_148591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(222, 148551, 148591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(222, 145337, 148603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(222, 145337, 148603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        f_222_116519_116528_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(222, 116284, 116628);
            return return_v;
        }

    }
}
