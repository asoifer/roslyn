// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

using AnalyzerStateData = Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData;
using DeclarationAnalyzerStateData = Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData;
using OperationAnalyzerStateData = Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData;
using SyntaxNodeAnalyzerStateData = Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerExecutor
    {
        private const string
        DiagnosticCategory = "Compiler"
        ;

        internal const string
        AnalyzerExceptionDiagnosticId = "AD0001"
        ;

        internal const string
        AnalyzerDriverExceptionDiagnosticId = "AD0002"
        ;

        private readonly Compilation? _compilation;

        private readonly AnalyzerOptions? _analyzerOptions;

        private readonly Action<Diagnostic>? _addNonCategorizedDiagnostic;

        private readonly Action<Diagnostic, DiagnosticAnalyzer, bool>? _addCategorizedLocalDiagnostic;

        private readonly Action<Diagnostic, DiagnosticAnalyzer>? _addCategorizedNonLocalDiagnostic;

        private readonly Action<Suppression>? _addSuppression;

        private readonly Action<Exception, DiagnosticAnalyzer, Diagnostic> _onAnalyzerException;

        private readonly Func<Exception, bool>? _analyzerExceptionFilter;

        private readonly AnalyzerManager _analyzerManager;

        private readonly Func<DiagnosticAnalyzer, bool>? _isCompilerAnalyzer;

        private readonly Func<DiagnosticAnalyzer, object?>? _getAnalyzerGate;

        private readonly Func<SyntaxTree, SemanticModel>? _getSemanticModel;

        private readonly Func<DiagnosticAnalyzer, bool> _shouldSkipAnalysisOnGeneratedCode;

        private readonly Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> _shouldSuppressGeneratedCodeDiagnostic;

        private readonly Func<SyntaxTree, TextSpan, bool> _isGeneratedCodeLocation;

        private readonly Func<DiagnosticAnalyzer, SyntaxTree, SyntaxTreeOptionsProvider?, bool>? _isAnalyzerSuppressedForTree;

        private readonly ConcurrentDictionary<DiagnosticAnalyzer, StrongBox<long>>? _analyzerExecutionTimeMap;

        private readonly CompilationAnalysisValueProviderFactory _compilationAnalysisValueProviderFactory;

        private readonly CancellationToken _cancellationToken;

        private Func<IOperation, ControlFlowGraph>? _lazyGetControlFlowGraph;

        private ConcurrentDictionary<IOperation, ControlFlowGraph>? _lazyControlFlowGraphMap;

        private Func<IOperation, ControlFlowGraph> GetControlFlowGraph
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 3689, 3744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3692, 3744);
                    return _lazyGetControlFlowGraph ??= GetControlFlowGraphImpl; DynAbs.Tracing.TraceSender.TraceExitMethod(231, 3689, 3744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 3689, 3744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 3689, 3744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsAnalyzerSuppressedForTree(DiagnosticAnalyzer analyzer, SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 3757, 4043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3868, 3919);

                f_231_3868_3918(_isAnalyzerSuppressedForTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3933, 4032);

                return f_231_3940_4031(this, analyzer, tree, f_231_3985_4030(f_231_3985_4004(f_231_3985_3996())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 3757, 4043);

                int
                f_231_3868_3918(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 3868, 3918);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_3985_3996()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 3985, 3996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_231_3985_4004(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 3985, 4004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_231_3985_4030(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 3985, 4030);
                    return return_v;
                }


                bool
                f_231_3940_4031(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg1, Microsoft.CodeAnalysis.SyntaxTree
                arg2, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                arg3)
                {
                    var return_v = this_param._isAnalyzerSuppressedForTree(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 3940, 4031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 3757, 4043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 3757, 4043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzerExecutor Create(
                    Compilation compilation,
                    AnalyzerOptions analyzerOptions,
                    Action<Diagnostic>? addNonCategorizedDiagnostic,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException,
                    Func<Exception, bool>? analyzerExceptionFilter,
                    Func<DiagnosticAnalyzer, bool> isCompilerAnalyzer,
                    AnalyzerManager analyzerManager,
                    Func<DiagnosticAnalyzer, bool> shouldSkipAnalysisOnGeneratedCode,
                    Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> shouldSuppressGeneratedCodeDiagnostic,
                    Func<SyntaxTree, TextSpan, bool> isGeneratedCodeLocation,
                    Func<DiagnosticAnalyzer, SyntaxTree, SyntaxTreeOptionsProvider?, bool> isAnalyzerSuppressedForTree,
                    Func<DiagnosticAnalyzer, object?> getAnalyzerGate,
                    Func<SyntaxTree, SemanticModel> getSemanticModel,
                    bool logExecutionTime = false,
                    Action<Diagnostic, DiagnosticAnalyzer, bool>? addCategorizedLocalDiagnostic = null,
                    Action<Diagnostic, DiagnosticAnalyzer>? addCategorizedNonLocalDiagnostic = null,
                    Action<Suppression>? addSuppression = null,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 7073, 9399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 8517, 8611);

                f_231_8517_8610((addNonCategorizedDiagnostic != null) ^ (addCategorizedLocalDiagnostic != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 8625, 8725);

                f_231_8625_8724((addCategorizedLocalDiagnostic != null) == (addCategorizedNonLocalDiagnostic != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 8741, 8862);

                var
                analyzerExecutionTimeMap = (DynAbs.Tracing.TraceSender.Conditional_F1(231, 8772, 8788) || ((logExecutionTime && DynAbs.Tracing.TraceSender.Conditional_F2(231, 8791, 8854)) || DynAbs.Tracing.TraceSender.Conditional_F3(231, 8857, 8861))) ? f_231_8791_8854() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 8878, 9388);

                return f_231_8885_9387(compilation, analyzerOptions, addNonCategorizedDiagnostic, onAnalyzerException, analyzerExceptionFilter, isCompilerAnalyzer, analyzerManager, shouldSkipAnalysisOnGeneratedCode, shouldSuppressGeneratedCodeDiagnostic, isGeneratedCodeLocation, isAnalyzerSuppressedForTree, getAnalyzerGate, getSemanticModel, analyzerExecutionTimeMap, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, addSuppression, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 7073, 9399);

                int
                f_231_8517_8610(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 8517, 8610);
                    return 0;
                }


                int
                f_231_8625_8724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 8625, 8724);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>
                f_231_8791_8854()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 8791, 8854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_231_8885_9387(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                analyzerOptions, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnosticOpt, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                isCompilerAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                shouldSkipAnalysisOnGeneratedCode, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Text.TextSpan, bool>
                isGeneratedCodeLocation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?, bool>
                isAnalyzerSuppressedForTree, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, object?>
                getAnalyzerGate, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                getSemanticModel, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>?
                analyzerExecutionTimeMap, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostics.Suppression>?
                addSuppression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor(compilation, analyzerOptions, addNonCategorizedDiagnosticOpt, onAnalyzerException, analyzerExceptionFilter, isCompilerAnalyzer, analyzerManager, shouldSkipAnalysisOnGeneratedCode, shouldSuppressGeneratedCodeDiagnostic, isGeneratedCodeLocation, isAnalyzerSuppressedForTree, getAnalyzerGate, getSemanticModel, analyzerExecutionTimeMap, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, addSuppression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 8885, 9387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 7073, 9399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 7073, 9399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzerExecutor CreateForSupportedDiagnostics(
                    Action<Exception, DiagnosticAnalyzer, Diagnostic>? onAnalyzerException,
                    AnalyzerManager analyzerManager,
                    CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 10051, 11390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 10328, 10386);

                onAnalyzerException ??= (ex, analyzer, diagnostic) => { };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 10400, 11379);

                return f_231_10407_11378(compilation: null, analyzerOptions: null, addNonCategorizedDiagnosticOpt: null, isCompilerAnalyzer: null, shouldSkipAnalysisOnGeneratedCode: _ => false, shouldSuppressGeneratedCodeDiagnostic: (diagnostic, analyzer, compilation, ct) => false, isGeneratedCodeLocation: (_1, _2) => false, isAnalyzerSuppressedForTree: null, getAnalyzerGate: null, getSemanticModel: null, onAnalyzerException: onAnalyzerException, analyzerExceptionFilter: null, analyzerManager: analyzerManager, analyzerExecutionTimeMap: null, addCategorizedLocalDiagnostic: null, addCategorizedNonLocalDiagnostic: null, addSuppression: null, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 10051, 11390);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_231_10407_11378(Microsoft.CodeAnalysis.Compilation?
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnosticOpt, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                isCompilerAnalyzer, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                shouldSkipAnalysisOnGeneratedCode, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Text.TextSpan, bool>
                isGeneratedCodeLocation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?, bool>?
                isAnalyzerSuppressedForTree, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, object?>?
                getAnalyzerGate, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>?
                getSemanticModel, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>?
                analyzerExecutionTimeMap, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostics.Suppression>?
                addSuppression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor(compilation: compilation, analyzerOptions: analyzerOptions, addNonCategorizedDiagnosticOpt: addNonCategorizedDiagnosticOpt, isCompilerAnalyzer: isCompilerAnalyzer, shouldSkipAnalysisOnGeneratedCode: shouldSkipAnalysisOnGeneratedCode, shouldSuppressGeneratedCodeDiagnostic: shouldSuppressGeneratedCodeDiagnostic, isGeneratedCodeLocation: isGeneratedCodeLocation, isAnalyzerSuppressedForTree: isAnalyzerSuppressedForTree, getAnalyzerGate: getAnalyzerGate, getSemanticModel: getSemanticModel, onAnalyzerException: onAnalyzerException, analyzerExceptionFilter: analyzerExceptionFilter, analyzerManager: analyzerManager, analyzerExecutionTimeMap: analyzerExecutionTimeMap, addCategorizedLocalDiagnostic: addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic: addCategorizedNonLocalDiagnostic, addSuppression: addSuppression, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 10407, 11378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 10051, 11390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 10051, 11390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerExecutor(
                    Compilation? compilation,
                    AnalyzerOptions? analyzerOptions,
                    Action<Diagnostic>? addNonCategorizedDiagnosticOpt,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic> onAnalyzerException,
                    Func<Exception, bool>? analyzerExceptionFilter,
                    Func<DiagnosticAnalyzer, bool>? isCompilerAnalyzer,
                    AnalyzerManager analyzerManager,
                    Func<DiagnosticAnalyzer, bool> shouldSkipAnalysisOnGeneratedCode,
                    Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> shouldSuppressGeneratedCodeDiagnostic,
                    Func<SyntaxTree, TextSpan, bool> isGeneratedCodeLocation,
                    Func<DiagnosticAnalyzer, SyntaxTree, SyntaxTreeOptionsProvider?, bool>? isAnalyzerSuppressedForTree,
                    Func<DiagnosticAnalyzer, object?>? getAnalyzerGate,
                    Func<SyntaxTree, SemanticModel>? getSemanticModel,
                    ConcurrentDictionary<DiagnosticAnalyzer, StrongBox<long>>? analyzerExecutionTimeMap,
                    Action<Diagnostic, DiagnosticAnalyzer, bool>? addCategorizedLocalDiagnostic,
                    Action<Diagnostic, DiagnosticAnalyzer>? addCategorizedNonLocalDiagnostic,
                    Action<Suppression>? addSuppression,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(231, 11402, 13991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1639, 1651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1696, 1712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1760, 1788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1862, 1892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 1960, 1993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2042, 2057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2135, 2155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2206, 2230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2274, 2290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2350, 2369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2432, 2448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2509, 2526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2585, 2619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2722, 2760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2821, 2845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 2945, 2973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3225, 3250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3318, 3358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3479, 3503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 3576, 3600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 12754, 12781);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 12795, 12830);

                _analyzerOptions = analyzerOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 12844, 12906);

                _addNonCategorizedDiagnostic = addNonCategorizedDiagnosticOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 12920, 12963);

                _onAnalyzerException = onAnalyzerException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 12977, 13028);

                _analyzerExceptionFilter = analyzerExceptionFilter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13042, 13083);

                _isCompilerAnalyzer = isCompilerAnalyzer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13097, 13132);

                _analyzerManager = analyzerManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13146, 13217);

                _shouldSkipAnalysisOnGeneratedCode = shouldSkipAnalysisOnGeneratedCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13231, 13310);

                _shouldSuppressGeneratedCodeDiagnostic = shouldSuppressGeneratedCodeDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13324, 13375);

                _isGeneratedCodeLocation = isGeneratedCodeLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13389, 13448);

                _isAnalyzerSuppressedForTree = isAnalyzerSuppressedForTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13462, 13497);

                _getAnalyzerGate = getAnalyzerGate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13511, 13548);

                _getSemanticModel = getSemanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13562, 13615);

                _analyzerExecutionTimeMap = analyzerExecutionTimeMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13629, 13692);

                _addCategorizedLocalDiagnostic = addCategorizedLocalDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13706, 13775);

                _addCategorizedNonLocalDiagnostic = addCategorizedNonLocalDiagnostic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13789, 13822);

                _addSuppression = addSuppression;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13836, 13875);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 13891, 13980);

                _compilationAnalysisValueProviderFactory = f_231_13934_13979();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(231, 11402, 13991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 11402, 13991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 11402, 13991);
            }
        }

        public AnalyzerExecutor WithCancellationToken(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 14003, 14768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 14110, 14214) || true) && (cancellationToken == _cancellationToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 14110, 14214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 14187, 14199);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 14110, 14214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 14230, 14757);

                return f_231_14237_14756(_compilation, _analyzerOptions, _addNonCategorizedDiagnostic, _onAnalyzerException, _analyzerExceptionFilter, _isCompilerAnalyzer, _analyzerManager, _shouldSkipAnalysisOnGeneratedCode, _shouldSuppressGeneratedCodeDiagnostic, _isGeneratedCodeLocation, _isAnalyzerSuppressedForTree, _getAnalyzerGate, _getSemanticModel, _analyzerExecutionTimeMap, _addCategorizedLocalDiagnostic, _addCategorizedNonLocalDiagnostic, _addSuppression, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 14003, 14768);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_231_14237_14756(Microsoft.CodeAnalysis.Compilation?
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnosticOpt, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                onAnalyzerException, System.Func<System.Exception, bool>?
                analyzerExceptionFilter, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                isCompilerAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                shouldSkipAnalysisOnGeneratedCode, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.Text.TextSpan, bool>
                isGeneratedCodeLocation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?, bool>?
                isAnalyzerSuppressedForTree, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, object?>?
                getAnalyzerGate, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>?
                getSemanticModel, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>?
                analyzerExecutionTimeMap, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostics.Suppression>?
                addSuppression, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor(compilation, analyzerOptions, addNonCategorizedDiagnosticOpt, onAnalyzerException, analyzerExceptionFilter, isCompilerAnalyzer, analyzerManager, shouldSkipAnalysisOnGeneratedCode, shouldSuppressGeneratedCodeDiagnostic, isGeneratedCodeLocation, isAnalyzerSuppressedForTree, getAnalyzerGate, getSemanticModel, analyzerExecutionTimeMap, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, addSuppression, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 14237, 14756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 14003, 14768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 14003, 14768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetCompilationAndAnalyzerOptions(
                    [NotNullWhen(true)] out Compilation? compilation,
                    [NotNullWhen(true)] out AnalyzerOptions? analyzerOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 14780, 15134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 14989, 15055);

                (compilation, analyzerOptions) = (_compilation, _analyzerOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15069, 15123);

                return compilation != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 15076, 15122) && analyzerOptions != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 14780, 15134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 14780, 15134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 14780, 15134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 15203, 15327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15239, 15274);

                    f_231_15239_15273(_compilation != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15292, 15312);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(231, 15203, 15327);

                    int
                    f_231_15239_15273(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 15239, 15273);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 15146, 15338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 15146, 15338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AnalyzerOptions AnalyzerOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 15415, 15547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15451, 15490);

                    f_231_15451_15489(_analyzerOptions != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15508, 15532);

                    return _analyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(231, 15415, 15547);

                    int
                    f_231_15451_15489(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 15451, 15489);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 15350, 15558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 15350, 15558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 15615, 15636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15618, 15636);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(231, 15615, 15636);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 15615, 15636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 15615, 15636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Action<Exception, DiagnosticAnalyzer, Diagnostic> OnAnalyzerException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 15726, 15749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15729, 15749);
                    return _onAnalyzerException; DynAbs.Tracing.TraceSender.TraceExitMethod(231, 15726, 15749);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 15726, 15749);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 15726, 15749);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 15866, 16102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15902, 15950);

                    f_231_15902_15949(_analyzerExecutionTimeMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 15968, 16087);

                    return f_231_15975_16086(_analyzerExecutionTimeMap, pair => pair.Key, pair => TimeSpan.FromTicks(pair.Value.Value));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(231, 15866, 16102);

                    int
                    f_231_15902_15949(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 15902, 15949);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                    f_231_15975_16086(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>
                    source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    keySelector, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>, System.TimeSpan>
                    elementSelector)
                    {
                        var return_v = source.ToImmutableDictionary<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>(keySelector, elementSelector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 15975, 16086);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 15760, 16113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 15760, 16113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void ExecuteInitializeMethod(DiagnosticAnalyzer analyzer, HostSessionStartAnalysisScope sessionScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 16906, 17411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 17039, 17105);

                var
                context = f_231_17053_17104(analyzer, sessionScope)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 17245, 17400);

                f_231_17245_17399(this, analyzer, data => data.analyzer.Initialize(data.context), (analyzer, context));
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 16906, 17411);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerAnalysisContext
                f_231_17053_17104(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                scope)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerAnalysisContext(analyzer, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 17053, 17104);
                    return return_v;
                }


                int
                f_231_17245_17399(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerAnalysisContext context)>
                analyze, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerAnalysisContext context)
                argument)
                {
                    this_param.ExecuteAndCatchIfThrows<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerAnalysisContext context)>(analyzer, analyze, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 17245, 17399);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 16906, 17411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 16906, 17411);
            }
        }

        public void ExecuteCompilationStartActions(ImmutableArray<CompilationStartAnalyzerAction> actions, HostCompilationStartAnalysisScope compilationScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 17749, 18563);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 17924, 18552);
                    foreach (var startAction in f_231_17952_17959_I(actions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 17924, 18552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 17993, 18043);

                        _cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 18063, 18274);

                        var
                        context = f_231_18077_18273(f_231_18121_18141(startAction), compilationScope, f_231_18182_18193(), f_231_18195_18210(), _compilationAnalysisValueProviderFactory, _cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 18294, 18537);

                        f_231_18294_18536(this, f_231_18340_18360(startAction), data => data.action(data.context), (action: f_231_18448_18466(startAction), context), f_231_18499_18535(f_231_18523_18534()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 17924, 18552);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 17749, 18563);

                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_18121_18141(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18121, 18141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_18182_18193()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18182, 18193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_18195_18210()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18195, 18210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerCompilationStartAnalysisContext
                f_231_18077_18273(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                scope, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory
                compilationAnalysisValueProviderFactory, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerCompilationStartAnalysisContext(analyzer, scope, compilation, options, compilationAnalysisValueProviderFactory, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 18077, 18273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_18340_18360(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18340, 18360);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                f_231_18448_18466(Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18448, 18466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_18523_18534()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 18523, 18534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_18499_18535(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 18499, 18535);
                    return return_v;
                }


                int
                f_231_18294_18536(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCompilationStartAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCompilationStartAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCompilationStartAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 18294, 18536);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction>
                f_231_17952_17959_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 17952, 17959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 17749, 18563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 17749, 18563);
            }
        }

        public void ExecuteSymbolStartActions(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    ImmutableArray<SymbolStartAnalyzerAction> actions,
                    HostSymbolStartAnalysisScope symbolScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 18881, 19925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19134, 19241) || true) && (f_231_19138_19185(this, analyzer, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 19134, 19241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19219, 19226);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 19134, 19241);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19257, 19914);
                    foreach (var startAction in f_231_19285_19292_I(actions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 19257, 19914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19326, 19373);

                        f_231_19326_19372(f_231_19339_19359(startAction) == analyzer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19391, 19441);

                        _cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19461, 19628);

                        var
                        context = f_231_19475_19627(f_231_19514_19534(startAction), symbolScope, symbol, f_231_19578_19589(), f_231_19591_19606(), _cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 19648, 19899);

                        f_231_19648_19898(this, f_231_19694_19714(startAction), data => data.action(data.context), (action: f_231_19802_19820(startAction), context), f_231_19853_19897(f_231_19877_19888(), symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 19257, 19914);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 658);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 18881, 19925);

                bool
                f_231_19138_19185(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForSymbol(analyzer, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19138, 19185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_19339_19359(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19339, 19359);
                    return return_v;
                }


                int
                f_231_19326_19372(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19326, 19372);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_19514_19534(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19514, 19534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_19578_19589()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19578, 19589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_19591_19606()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19591, 19606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerSymbolStartAnalysisContext
                f_231_19475_19627(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                scope, Microsoft.CodeAnalysis.ISymbol
                owningSymbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerSymbolStartAnalysisContext(analyzer, scope, owningSymbol, compilation, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19475, 19627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_19694_19714(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19694, 19714);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext>
                f_231_19802_19820(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19802, 19820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_19877_19888()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 19877, 19888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_19853_19897(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19853, 19897);
                    return return_v;
                }


                int
                f_231_19648_19898(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerSymbolStartAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerSymbolStartAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerSymbolStartAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19648, 19898);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                f_231_19285_19292_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 19285, 19292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 18881, 19925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 18881, 19925);
            }
        }

        public void ExecuteSuppressionAction(DiagnosticSuppressor suppressor, ImmutableArray<Diagnostic> reportedDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 20230, 21370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20372, 20410);

                f_231_20372_20409(_addSuppression != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20424, 20464);

                f_231_20424_20463(_getSemanticModel != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20480, 20567) || true) && (reportedDiagnostics.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 20480, 20567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20545, 20552);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 20480, 20567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20583, 20633);

                _cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20649, 20747);

                var
                supportedSuppressions = f_231_20677_20746(_analyzerManager, suppressor, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20761, 20851);

                Func<SuppressionDescriptor, bool>
                isSupportedSuppression = supportedSuppressions.Contains
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20865, 20939);

                Action<SuppressionAnalysisContext>
                action = suppressor.ReportSuppressions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 20953, 21146);

                var
                context = f_231_20967_21145(f_231_20998_21009(), f_231_21011_21026(), reportedDiagnostics, _addSuppression, isSupportedSuppression, _getSemanticModel, _cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 21162, 21359);

                f_231_21162_21358(this, suppressor, data => data.action(data.context), (action, context), f_231_21321_21357(f_231_21345_21356()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 20230, 21370);

                int
                f_231_20372_20409(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 20372, 20409);
                    return 0;
                }


                int
                f_231_20424_20463(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 20424, 20463);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_231_20677_20746(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                suppressor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedSuppressionDescriptors(suppressor, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 20677, 20746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_20998_21009()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 20998, 21009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_21011_21026()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 21011, 21026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext
                f_231_20967_21145(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, System.Action<Microsoft.CodeAnalysis.Diagnostics.Suppression>
                suppressDiagnostic, System.Func<Microsoft.CodeAnalysis.SuppressionDescriptor, bool>
                isSupportedSuppressionDescriptor, System.Func<Microsoft.CodeAnalysis.SyntaxTree, Microsoft.CodeAnalysis.SemanticModel>
                getSemanticModel, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext(compilation, options, reportedDiagnostics, suppressDiagnostic, isSupportedSuppressionDescriptor, getSemanticModel, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 20967, 21145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_21345_21356()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 21345, 21356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_21321_21357(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 21321, 21357);
                    return return_v;
                }


                int
                f_231_21162_21358(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SuppressionAnalysisContext context)>((Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer)analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 21162, 21358);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 20230, 21370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 20230, 21370);
            }
        }

        public bool TryExecuteCompilationActions(
                    ImmutableArray<CompilationAnalyzerAction> compilationActions,
                    DiagnosticAnalyzer analyzer,
                    CompilationEvent compilationEvent,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 22243, 23347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 22559, 22666);

                f_231_22559_22665(compilationEvent is CompilationStartedEvent || (DynAbs.Tracing.TraceSender.Expression_False(231, 22572, 22664) || compilationEvent is CompilationCompletedEvent));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 22682, 22722);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 22774, 23131) || true) && (f_231_22778_22878(compilationEvent, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 22774, 23131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 22920, 22995);

                        f_231_22920_22994(this, compilationActions, analyzer, analyzerState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23017, 23078);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 23017, 23077)?.MarkEventComplete(compilationEvent, analyzer), 231, 23031, 23077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23100, 23112);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 22774, 23131);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23151, 23217);

                    return f_231_23158_23216(compilationEvent, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 23246, 23336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23286, 23321);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 23286, 23320)?.ResetToReadyState(), 231, 23300, 23320);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 23246, 23336);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 22243, 23347);

                int
                f_231_22559_22665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 22559, 22665);
                    return 0;
                }


                bool
                f_231_22778_22878(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                nonSymbolCompilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartProcessingEvent(nonSymbolCompilationEvent, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 22778, 22878);
                    return return_v;
                }


                int
                f_231_22920_22994(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>
                compilationActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteCompilationActionsCore(compilationActions, analyzer, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 22920, 22994);
                    return 0;
                }


                bool
                f_231_23158_23216(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsEventComplete(compilationEvent, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 23158, 23216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 22243, 23347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 22243, 23347);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteCompilationActionsCore(ImmutableArray<CompilationAnalyzerAction> compilationActions, DiagnosticAnalyzer analyzer, AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 23359, 24735);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23551, 23609);

                var
                addDiagnostic = f_231_23571_23608(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23625, 23808);

                using var
                _ = f_231_23639_23807((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23824, 24724);
                    foreach (var endAction in f_231_23850_23868_I(compilationActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 23824, 24724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23902, 23952);

                        _cancellationToken.ThrowIfCancellationRequested();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 23972, 24709) || true) && (f_231_23976_24021(analyzerState, endAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 23972, 24709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 24063, 24289);

                            var
                            context = f_231_24077_24288(f_231_24134_24145(), f_231_24147_24162(), addDiagnostic, isSupportedDiagnostic, _compilationAnalysisValueProviderFactory, _cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 24313, 24568);

                            f_231_24313_24567(this, f_231_24363_24381(endAction), data => data.action(data.context), (action: f_231_24477_24493(endAction), context), f_231_24530_24566(f_231_24554_24565()));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 24592, 24690) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 24592, 24690);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 24644, 24690);

                                f_231_24644_24689(f_231_24644_24674(analyzerState), endAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 24592, 24690);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 23972, 24709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 23824, 24724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 901);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 23359, 24735);

                System.Action<Microsoft.CodeAnalysis.Diagnostic>
                f_231_23571_23608(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddCompilationDiagnostic(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 23571, 23608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_23639_23807(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 23639, 23807);
                    return return_v;
                }


                bool
                f_231_23976_24021(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 23976, 24021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_24134_24145()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24134, 24145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_24147_24162()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24147, 24162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext
                f_231_24077_24288(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory
                compilationAnalysisValueProviderFactoryOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext(compilation, options, reportDiagnostic, isSupportedDiagnostic, compilationAnalysisValueProviderFactoryOpt, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 24077, 24288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_24363_24381(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24363, 24381);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext>
                f_231_24477_24493(Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24477, 24493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_24554_24565()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24554, 24565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_24530_24566(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 24530, 24566);
                    return return_v;
                }


                int
                f_231_24313_24567(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 24313, 24567);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_24644_24674(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 24644, 24674);
                    return return_v;
                }


                bool
                f_231_24644_24689(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 24644, 24689);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>
                f_231_23850_23868_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 23850, 23868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 23359, 24735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 23359, 24735);
            }
        }

        public bool TryExecuteSymbolActions(
                    ImmutableArray<SymbolAnalyzerAction> symbolActions,
                    DiagnosticAnalyzer analyzer,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCodeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 25849, 27079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26323, 26363);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26415, 26455);

                    var
                    symbol = f_231_26428_26454(symbolDeclaredEvent)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26473, 26872) || true) && (f_231_26477_26567(symbol, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 26473, 26872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26609, 26745);

                        f_231_26609_26744(this, symbolActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analyzerState, isGeneratedCodeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26767, 26819);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 26767, 26818)?.MarkSymbolComplete(symbol, analyzer), 231, 26781, 26818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26841, 26853);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 26473, 26872);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 26892, 26949);

                    return f_231_26899_26948(symbol, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 26978, 27068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27018, 27053);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 27018, 27052)?.ResetToReadyState(), 231, 27032, 27052);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 26978, 27068);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 25849, 27079);

                Microsoft.CodeAnalysis.ISymbol
                f_231_26428_26454(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 26428, 26454);
                    return return_v;
                }


                bool
                f_231_26477_26567(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartAnalyzingSymbol(symbol, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 26477, 26567);
                    return return_v;
                }


                int
                f_231_26609_26744(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                symbolActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, bool
                isGeneratedCodeSymbol)
                {
                    this_param.ExecuteSymbolActionsCore(symbolActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analyzerState, isGeneratedCodeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 26609, 26744);
                    return 0;
                }


                bool
                f_231_26899_26948(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsSymbolComplete(symbol, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 26899, 26948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 25849, 27079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 25849, 27079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteSymbolActionsCore(
                    ImmutableArray<SymbolAnalyzerAction> symbolActions,
                    DiagnosticAnalyzer analyzer,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalyzerStateData? analyzerState,
                    bool isGeneratedCodeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 27091, 29313);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27529, 27577);

                f_231_27529_27576(getTopMostNodeForAnalysis != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27593, 27810) || true) && (isGeneratedCodeSymbol && (DynAbs.Tracing.TraceSender.Expression_True(231, 27597, 27666) && f_231_27622_27666(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 27597, 27754) || f_231_27687_27754(this, analyzer, f_231_27727_27753(symbolDeclaredEvent))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 27593, 27810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27788, 27795);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 27593, 27810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27826, 27866);

                var
                symbol = f_231_27839_27865(symbolDeclaredEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 27880, 28009);

                var
                addDiagnostic = f_231_27900_28008(this, symbol, f_231_27925_27970(symbolDeclaredEvent), analyzer, getTopMostNodeForAnalysis)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28025, 28208);

                using var
                _ = f_231_28039_28207((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28224, 29302);
                    foreach (var symbolAction in f_231_28253_28266_I(symbolActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 28224, 29302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28300, 28333);

                        var
                        action = f_231_28313_28332(symbolAction)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28351, 28382);

                        var
                        kinds = f_231_28363_28381(symbolAction)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28402, 29287) || true) && (kinds.Contains(f_231_28421_28432(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 28402, 29287);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28475, 29268) || true) && (f_231_28479_28527(analyzerState, symbolAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 28475, 29268);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28577, 28627);

                                _cancellationToken.ThrowIfCancellationRequested();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28655, 28820);

                                var
                                context = f_231_28669_28819(symbol, f_231_28703_28714(), f_231_28716_28731(), addDiagnostic, isSupportedDiagnostic, _cancellationToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 28848, 29112);

                                f_231_28848_29111(this, f_231_28902_28923(symbolAction), data => data.action(data.context), (action, context), f_231_29066_29110(f_231_29090_29101(), symbol));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 29140, 29245) || true) && (analyzerState != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 29140, 29245);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 29196, 29245);

                                    f_231_29196_29244(f_231_29196_29226(analyzerState), symbolAction);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 29140, 29245);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 28475, 29268);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 28402, 29287);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 28224, 29302);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 1079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 1079);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 27091, 29313);

                int
                f_231_27529_27576(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 27529, 27576);
                    return 0;
                }


                bool
                f_231_27622_27666(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 27622, 27666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_231_27727_27753(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 27727, 27753);
                    return return_v;
                }


                bool
                f_231_27687_27754(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForSymbol(analyzer, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 27687, 27754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_231_27839_27865(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 27839, 27865);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_231_27925_27970(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 27925, 27970);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic>
                f_231_27900_28008(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.ISymbol
                contextSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                cachedDeclaringReferences, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis)
                {
                    var return_v = this_param.GetAddDiagnostic(contextSymbol, cachedDeclaringReferences, analyzer, getTopMostNodeForAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 27900, 28008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_28039_28207(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 28039, 28207);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                f_231_28313_28332(Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28313, 28332);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolKind>
                f_231_28363_28381(Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Kinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28363, 28381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_231_28421_28432(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28421, 28432);
                    return return_v;
                }


                bool
                f_231_28479_28527(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 28479, 28527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_28703_28714()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28703, 28714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_28716_28731()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28716, 28731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext
                f_231_28669_28819(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext(symbol, compilation, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 28669, 28819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_28902_28923(Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 28902, 28923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_29090_29101()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 29090, 29101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_29066_29110(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 29066, 29110);
                    return return_v;
                }


                int
                f_231_28848_29111(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 28848, 29111);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_29196_29226(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 29196, 29226);
                    return return_v;
                }


                bool
                f_231_29196_29244(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 29196, 29244);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                f_231_28253_28266_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 28253, 28266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 27091, 29313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 27091, 29313);
            }
        }

        public bool TryExecuteSymbolEndActionsForContainer(
                    INamespaceOrTypeSymbol containingSymbol,
                    ISymbol processedMemberSymbol,
                    DiagnosticAnalyzer analyzer,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalysisState? analysisState,
                    [NotNullWhen(returnValue: true)] out SymbolDeclaredCompilationEvent? containingSymbolDeclaredEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 30284, 31426);
                (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction> symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent symbolDeclaredEvent) containerEndActionsAndEvent = default((System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction> symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent symbolDeclaredEvent));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 30771, 30808);

                containingSymbolDeclaredEvent = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 30822, 31060) || true) && (!f_231_30827_30998(_analyzerManager, containingSymbol, processedMemberSymbol, analyzer, out containerEndActionsAndEvent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 30822, 31060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 31032, 31045);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 30822, 31060);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 31076, 31174);

                ImmutableArray<SymbolEndAnalyzerAction>
                endActions = containerEndActionsAndEvent.symbolEndActions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 31188, 31268);

                containingSymbolDeclaredEvent = containerEndActionsAndEvent.symbolDeclaredEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 31282, 31415);

                return f_231_31289_31414(this, endActions, analyzer, containingSymbolDeclaredEvent, getTopMostNodeForAnalysis, analysisState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 30284, 31426);

                bool
                f_231_30827_30998(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.ISymbol
                processedMemberSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction> symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent symbolDeclaredEvent)
                containerEndActionsAndEvent)
                {
                    var return_v = this_param.TryProcessCompletedMemberAndGetPendingSymbolEndActionsForContainer((Microsoft.CodeAnalysis.ISymbol)containingSymbol, processedMemberSymbol, analyzer, out containerEndActionsAndEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 30827, 30998);
                    return return_v;
                }


                bool
                f_231_31289_31414(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteSymbolEndActionsCore(symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 31289, 31414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 30284, 31426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 30284, 31426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryExecuteSymbolEndActions(
                    ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions,
                    DiagnosticAnalyzer analyzer,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 32330, 32988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 32730, 32977);

                return f_231_32737_32834(_analyzerManager, symbolEndActions, analyzer, symbolDeclaredEvent) && (DynAbs.Tracing.TraceSender.Expression_True(231, 32737, 32976) && f_231_32855_32976(this, symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analysisState));
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 32330, 32988);

                bool
                f_231_32737_32834(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent)
                {
                    var return_v = this_param.TryStartExecuteSymbolEndActions(symbolEndActions, analyzer, symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 32737, 32834);
                    return return_v;
                }


                bool
                f_231_32855_32976(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = this_param.TryExecuteSymbolEndActionsCore(symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 32855, 32976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 32330, 32988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 32330, 32988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryExecuteSymbolEndActionsCore(
                    ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions,
                    DiagnosticAnalyzer analyzer,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 33000, 34379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33405, 33445);

                var
                symbol = f_231_33418_33444(symbolDeclaredEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33461, 33501);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33553, 33933) || true) && (f_231_33557_33634(symbol, analyzer, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 33553, 33933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33676, 33795);

                        f_231_33676_33794(this, symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analyzerState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33817, 33880);

                        f_231_33817_33879(this, symbol, analyzer, analysisState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33902, 33914);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 33553, 33933);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 33953, 34217) || true) && (!f_231_33958_34018(symbol, analyzer, analysisState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 33953, 34217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34060, 34163);

                        f_231_34060_34162(_analyzerManager, symbol, analyzer, symbolEndActions, symbolDeclaredEvent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34185, 34198);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 33953, 34217);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34237, 34249);

                    return true;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 34278, 34368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34318, 34353);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 34318, 34352)?.ResetToReadyState(), 231, 34332, 34352);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 34278, 34368);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 33000, 34379);

                Microsoft.CodeAnalysis.ISymbol
                f_231_33418_33444(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 33418, 33444);
                    return return_v;
                }


                bool
                f_231_33557_33634(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartSymbolEndAnalysis(symbol, analyzer, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 33557, 33634);
                    return return_v;
                }


                int
                f_231_33676_33794(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteSymbolEndActionsCore(symbolEndActions, analyzer, symbolDeclaredEvent, getTopMostNodeForAnalysis, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 33676, 33794);
                    return 0;
                }


                int
                f_231_33817_33879(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 33817, 33879);
                    return 0;
                }


                bool
                f_231_33958_34018(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsSymbolEndAnalysisComplete(symbol, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 33958, 34018);
                    return return_v;
                }


                int
                f_231_34060_34162(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent)
                {
                    this_param.MarkSymbolEndAnalysisPending(symbol, analyzer, symbolEndActions, symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 34060, 34162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 33000, 34379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 33000, 34379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkSymbolEndAnalysisComplete(ISymbol symbol, DiagnosticAnalyzer analyzer, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 34391, 34685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34532, 34595);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 34532, 34594)?.MarkSymbolEndAnalysisComplete(symbol, analyzer), 231, 34546, 34594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 34609, 34674);

                f_231_34609_34673(_analyzerManager, symbol, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 34391, 34685);

                int
                f_231_34609_34673(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 34609, 34673);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 34391, 34685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 34391, 34685);
            }
        }

        private void ExecuteSymbolEndActionsCore(
                    ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions,
                    DiagnosticAnalyzer analyzer,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 34697, 36596);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35103, 35151);

                f_231_35103_35150(getTopMostNodeForAnalysis != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35165, 35248);

                f_231_35165_35247(!f_231_35179_35246(this, analyzer, f_231_35219_35245(symbolDeclaredEvent)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35264, 35304);

                var
                symbol = f_231_35277_35303(symbolDeclaredEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35318, 35447);

                var
                addDiagnostic = f_231_35338_35446(this, symbol, f_231_35363_35408(symbolDeclaredEvent), analyzer, getTopMostNodeForAnalysis)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35463, 35646);

                using var
                _ = f_231_35477_35645((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35662, 36585);
                    foreach (var symbolAction in f_231_35691_35707_I(symbolEndActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 35662, 36585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35741, 35774);

                        var
                        action = f_231_35754_35773(symbolAction)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35794, 36570) || true) && (f_231_35798_35846(analyzerState, symbolAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 35794, 36570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35888, 35938);

                            _cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 35962, 36123);

                            var
                            context = f_231_35976_36122(symbol, f_231_36010_36021(), f_231_36023_36038(), addDiagnostic, isSupportedDiagnostic, _cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 36147, 36395);

                            f_231_36147_36394(this, f_231_36197_36218(symbolAction), data => data.action(data.context), (action, context), f_231_36349_36393(f_231_36373_36384(), symbol));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 36450, 36551) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 36450, 36551);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 36502, 36551);

                                f_231_36502_36550(f_231_36502_36532(analyzerState), symbolAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 36450, 36551);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 35794, 36570);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 35662, 36585);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 924);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 34697, 36596);

                int
                f_231_35103_35150(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35103, 35150);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_231_35219_35245(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 35219, 35245);
                    return return_v;
                }


                bool
                f_231_35179_35246(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForSymbol(analyzer, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35179, 35246);
                    return return_v;
                }


                int
                f_231_35165_35247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35165, 35247);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_231_35277_35303(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 35277, 35303);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_231_35363_35408(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 35363, 35408);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic>
                f_231_35338_35446(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.ISymbol
                contextSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                cachedDeclaringReferences, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis)
                {
                    var return_v = this_param.GetAddDiagnostic(contextSymbol, cachedDeclaringReferences, analyzer, getTopMostNodeForAnalysis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35338, 35446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_35477_35645(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35477, 35645);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext>
                f_231_35754_35773(Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 35754, 35773);
                    return return_v;
                }


                bool
                f_231_35798_35846(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35798, 35846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_36010_36021()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 36010, 36021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_36023_36038()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 36023, 36038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext
                f_231_35976_36122(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext(symbol, compilation, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35976, 36122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_36197_36218(Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 36197, 36218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_36373_36384()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 36373, 36384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_36349_36393(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 36349, 36393);
                    return return_v;
                }


                int
                f_231_36147_36394(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SymbolAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 36147, 36394);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_36502_36532(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 36502, 36532);
                    return return_v;
                }


                bool
                f_231_36502_36550(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 36502, 36550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                f_231_35691_35707_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 35691, 35707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 34697, 36596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 34697, 36596);
            }
        }

        public bool TryExecuteSemanticModelActions(
                    ImmutableArray<SemanticModelAnalyzerAction> semanticModelActions,
                    DiagnosticAnalyzer analyzer,
                    SemanticModel semanticModel,
                    CompilationEvent compilationUnitCompletedEvent,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 37718, 38870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38130, 38170);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38222, 38641) || true) && (f_231_38226_38339(compilationUnitCompletedEvent, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 38222, 38641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38381, 38492);

                        f_231_38381_38491(this, semanticModelActions, analyzer, semanticModel, analyzerState, isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38514, 38588);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 38514, 38587)?.MarkEventComplete(compilationUnitCompletedEvent, analyzer), 231, 38528, 38587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38610, 38622);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 38222, 38641);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38661, 38740);

                    return f_231_38668_38739(compilationUnitCompletedEvent, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 38769, 38859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 38809, 38844);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 38809, 38843)?.ResetToReadyState(), 231, 38823, 38843);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 38769, 38859);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 37718, 38870);

                bool
                f_231_38226_38339(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                nonSymbolCompilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartProcessingEvent(nonSymbolCompilationEvent, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 38226, 38339);
                    return return_v;
                }


                int
                f_231_38381_38491(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>
                semanticModelActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteSemanticModelActionsCore(semanticModelActions, analyzer, semanticModel, analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 38381, 38491);
                    return 0;
                }


                bool
                f_231_38668_38739(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsEventComplete(compilationEvent, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 38668, 38739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 37718, 38870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 37718, 38870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteSemanticModelActionsCore(
                    ImmutableArray<SemanticModelAnalyzerAction> semanticModelActions,
                    DiagnosticAnalyzer analyzer,
                    SemanticModel semanticModel,
                    AnalyzerStateData? analyzerState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 38882, 40759);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39197, 39404) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(231, 39201, 39264) && f_231_39220_39264(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 39201, 39348) || f_231_39285_39348(this, analyzer, f_231_39323_39347(semanticModel))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 39197, 39404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39382, 39389);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 39197, 39404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39420, 39500);

                var
                diagReporter = f_231_39439_39499(this, f_231_39464_39488(semanticModel), analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39516, 39699);

                using var
                _ = f_231_39530_39698((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39715, 40712);
                    foreach (var semanticModelAction in f_231_39751_39771_I(semanticModelActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 39715, 40712);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39805, 40697) || true) && (f_231_39809_39864(analyzerState, semanticModelAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 39805, 40697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39906, 39956);

                            _cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 39980, 40161);

                            var
                            context = f_231_39994_40160(semanticModel, f_231_40042_40057(), diagReporter.AddDiagnosticAction, isSupportedDiagnostic, _cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 40238, 40515);

                            f_231_40238_40514(this, f_231_40288_40316(semanticModelAction), data => data.action(data.context), (action: f_231_40412_40438(semanticModelAction), context), f_231_40475_40513(semanticModel));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 40570, 40678) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 40570, 40678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 40622, 40678);

                                f_231_40622_40677(f_231_40622_40652(analyzerState), semanticModelAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 40570, 40678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 39805, 40697);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 39715, 40712);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 40728, 40748);

                f_231_40728_40747(
                            diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 38882, 40759);

                bool
                f_231_39220_39264(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39220, 39264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_39323_39347(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 39323, 39347);
                    return return_v;
                }


                bool
                f_231_39285_39348(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39285, 39348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_39464_39488(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 39464, 39488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_39439_39499(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSemanticDiagnostic(tree, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39439, 39499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_39530_39698(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39530, 39698);
                    return return_v;
                }


                bool
                f_231_39809_39864(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39809, 39864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_40042_40057()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 40042, 40057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext
                f_231_39994_40160(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext(semanticModel, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39994, 40160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_40288_40316(Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 40288, 40316);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext>
                f_231_40412_40438(Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 40412, 40438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_40475_40513(Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 40475, 40513);
                    return return_v;
                }


                int
                f_231_40238_40514(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 40238, 40514);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_40622_40652(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 40622, 40652);
                    return return_v;
                }


                bool
                f_231_40622_40677(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 40622, 40677);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>
                f_231_39751_39771_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SemanticModelAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 39751, 39771);
                    return return_v;
                }


                int
                f_231_40728_40747(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 40728, 40747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 38882, 40759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 38882, 40759);
            }
        }

        public bool TryExecuteSyntaxTreeActions(
                    ImmutableArray<SyntaxTreeAnalyzerAction> syntaxTreeActions,
                    DiagnosticAnalyzer analyzer,
                    SourceOrAdditionalFile file,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 41745, 42830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42087, 42125);

                f_231_42087_42124(file.SourceTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42139, 42179);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42231, 42593) || true) && (f_231_42235_42322(file, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 42231, 42593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42364, 42460);

                        f_231_42364_42459(this, syntaxTreeActions, analyzer, file, analyzerState, isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42482, 42540);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 42482, 42539)?.MarkSyntaxAnalysisComplete(file, analyzer), 231, 42496, 42539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42562, 42574);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 42231, 42593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42613, 42700);

                    return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 42620, 42699) || !f_231_42646_42699(analysisState, analysisScope));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 42729, 42819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 42769, 42804);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 42769, 42803)?.ResetToReadyState(), 231, 42783, 42803);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 42729, 42819);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 41745, 42830);

                int
                f_231_42087_42124(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 42087, 42124);
                    return 0;
                }


                bool
                f_231_42235_42322(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartSyntaxAnalysis(file, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 42235, 42322);
                    return return_v;
                }


                int
                f_231_42364_42459(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>
                syntaxTreeActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteSyntaxTreeActionsCore(syntaxTreeActions, analyzer, file, analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 42364, 42459);
                    return 0;
                }


                bool
                f_231_42646_42699(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope)
                {
                    var return_v = this_param.HasPendingSyntaxAnalysis(analysisScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 42646, 42699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 41745, 42830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 41745, 42830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteSyntaxTreeActionsCore(
                    ImmutableArray<SyntaxTreeAnalyzerAction> syntaxTreeActions,
                    DiagnosticAnalyzer analyzer,
                    SourceOrAdditionalFile file,
                    AnalyzerStateData? analyzerState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 42842, 44725);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43148, 43186);

                f_231_43148_43185(file.SourceTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43202, 43229);

                var
                tree = file.SourceTree
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43243, 43430) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(231, 43247, 43310) && f_231_43266_43310(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 43247, 43374) || f_231_43331_43374(this, analyzer, tree)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 43243, 43430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43408, 43415);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 43243, 43430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43446, 43504);

                var
                diagReporter = f_231_43465_43503(this, file, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43520, 43703);

                using var
                _ = f_231_43534_43702((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43719, 44678);
                    foreach (var syntaxTreeAction in f_231_43752_43769_I(syntaxTreeActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 43719, 44678);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43803, 44663) || true) && (f_231_43807_43859(analyzerState, syntaxTreeAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 43803, 44663);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43901, 43951);

                            _cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 43975, 44132);

                            var
                            context = f_231_43989_44131(tree, f_231_44025_44040(), diagReporter.AddDiagnosticAction, isSupportedDiagnostic, f_231_44099_44110(), _cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 44209, 44484);

                            f_231_44209_44483(this, f_231_44259_44284(syntaxTreeAction), data => data.action(data.context), (action: f_231_44380_44403(syntaxTreeAction), context), f_231_44440_44482(f_231_44464_44475(), file));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 44539, 44644) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 44539, 44644);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 44591, 44644);

                                f_231_44591_44643(f_231_44591_44621(analyzerState), syntaxTreeAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 44539, 44644);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 43803, 44663);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 43719, 44678);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 44694, 44714);

                f_231_44694_44713(
                            diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 42842, 44725);

                int
                f_231_43148_43185(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43148, 43185);
                    return 0;
                }


                bool
                f_231_43266_43310(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43266, 43310);
                    return return_v;
                }


                bool
                f_231_43331_43374(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43331, 43374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_43465_43503(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSyntaxDiagnostic(file, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43465, 43503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_43534_43702(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43534, 43702);
                    return return_v;
                }


                bool
                f_231_43807_43859(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43807, 43859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_44025_44040()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44025, 44040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_44099_44110()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44099, 44110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext
                f_231_43989_44131(Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext(tree, options, reportDiagnostic, isSupportedDiagnostic, compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43989, 44131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_44259_44284(Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44259, 44284);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext>
                f_231_44380_44403(Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44380, 44403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_44464_44475()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44464, 44475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_44440_44482(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 44440, 44482);
                    return return_v;
                }


                int
                f_231_44209_44483(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 44209, 44483);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_44591_44621(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 44591, 44621);
                    return return_v;
                }


                bool
                f_231_44591_44643(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 44591, 44643);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>
                f_231_43752_43769_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxTreeAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 43752, 43769);
                    return return_v;
                }


                int
                f_231_44694_44713(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 44694, 44713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 42842, 44725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 42842, 44725);
            }
        }

        public bool TryExecuteAdditionalFileActions(
                    ImmutableArray<AdditionalFileAnalyzerAction> additionalFileActions,
                    DiagnosticAnalyzer analyzer,
                    SourceOrAdditionalFile file,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 45566, 46623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 45885, 45927);

                f_231_45885_45926(file.AdditionalFile != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 45941, 45981);

                AnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46033, 46386) || true) && (f_231_46037_46124(file, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 46033, 46386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46166, 46253);

                        f_231_46166_46252(this, additionalFileActions, analyzer, file, analyzerState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46275, 46333);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analysisState, 231, 46275, 46332)?.MarkSyntaxAnalysisComplete(file, analyzer), 231, 46289, 46332);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46355, 46367);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 46033, 46386);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46406, 46493);

                    return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 46413, 46492) || !f_231_46439_46492(analysisState, analysisScope));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 46522, 46612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46562, 46597);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 46562, 46596)?.ResetToReadyState(), 231, 46576, 46596);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 46522, 46612);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 45566, 46623);

                int
                f_231_45885_45926(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 45885, 45926);
                    return 0;
                }


                bool
                f_231_46037_46124(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartSyntaxAnalysis(file, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 46037, 46124);
                    return return_v;
                }


                int
                f_231_46166_46252(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>
                additionalFileActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteAdditionalFileActionsCore(additionalFileActions, analyzer, file, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 46166, 46252);
                    return 0;
                }


                bool
                f_231_46439_46492(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope)
                {
                    var return_v = this_param.HasPendingSyntaxAnalysis(analysisScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 46439, 46492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 45566, 46623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 45566, 46623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteAdditionalFileActionsCore(
                    ImmutableArray<AdditionalFileAnalyzerAction> additionalFileActions,
                    DiagnosticAnalyzer analyzer,
                    SourceOrAdditionalFile file,
                    AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 46635, 48346);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46918, 46960);

                f_231_46918_46959(file.AdditionalFile != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 46974, 47015);

                var
                additionalFile = file.AdditionalFile
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47031, 47089);

                var
                diagReporter = f_231_47050_47088(this, file, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47105, 47288);

                using var
                _ = f_231_47119_47287((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47302, 48299);
                    foreach (var additionalFileAction in f_231_47339_47360_I(additionalFileActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 47302, 48299);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47394, 48284) || true) && (f_231_47398_47454(analyzerState, additionalFileAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 47394, 48284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47496, 47546);

                            _cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47570, 47741);

                            var
                            context = f_231_47584_47740(additionalFile, f_231_47634_47649(), diagReporter.AddDiagnosticAction, isSupportedDiagnostic, f_231_47708_47719(), _cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 47818, 48101);

                            f_231_47818_48100(this, f_231_47868_47897(additionalFileAction), data => data.action(data.context), (action: f_231_47993_48020(additionalFileAction), context), f_231_48057_48099(f_231_48081_48092(), file));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 48156, 48265) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 48156, 48265);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 48208, 48265);

                                f_231_48208_48264(f_231_48208_48238(analyzerState), additionalFileAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 48156, 48265);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 47394, 48284);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 47302, 48299);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 998);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 998);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 48315, 48335);

                f_231_48315_48334(
                            diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 46635, 48346);

                int
                f_231_46918_46959(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 46918, 46959);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_47050_47088(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSyntaxDiagnostic(file, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47050, 47088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_47119_47287(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47119, 47287);
                    return return_v;
                }


                bool
                f_231_47398_47454(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction(analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47398, 47454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_47634_47649()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 47634, 47649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_47708_47719()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 47708, 47719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext
                f_231_47584_47740(Microsoft.CodeAnalysis.AdditionalText
                additionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext(additionalFile, options, reportDiagnostic, isSupportedDiagnostic, compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47584, 47740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_47868_47897(Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 47868, 47897);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext>
                f_231_47993_48020(Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 47993, 48020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_48081_48092()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 48081, 48092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_48057_48099(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48057, 48099);
                    return return_v;
                }


                int
                f_231_47818_48100(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47818, 48100);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_48208_48238(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 48208, 48238);
                    return return_v;
                }


                bool
                f_231_48208_48264(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48208, 48264);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>
                f_231_47339_47360_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AdditionalFileAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 47339, 47360);
                    return return_v;
                }


                int
                f_231_48315_48334(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48315, 48334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 46635, 48346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 46635, 48346);
            }
        }

        private void ExecuteSyntaxNodeAction<TLanguageKindEnum>(
                    SyntaxNodeAnalyzerAction<TLanguageKindEnum> syntaxNodeAction,
                    SyntaxNode node,
                    ISymbol containingSymbol,
                    SemanticModel semanticModel,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    SyntaxNodeAnalyzerStateData? analyzerState)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 48358, 49775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 48834, 48907);

                f_231_48834_48906(analyzerState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 48847, 48905) || f_231_48872_48897(analyzerState) == node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 48921, 49008);

                f_231_48921_49007(!f_231_48935_49006(this, f_231_48963_48988(syntaxNodeAction), f_231_48990_49005(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 49024, 49764) || true) && (f_231_49028_49080(analyzerState, syntaxNodeAction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 49024, 49764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 49114, 49303);

                    var
                    syntaxNodeContext = f_231_49138_49302(node, containingSymbol, semanticModel, f_231_49207_49222(), addDiagnostic, isSupportedDiagnostic, _cancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 49323, 49601);

                    f_231_49323_49600(this, f_231_49369_49394(syntaxNodeAction), data => data.action(data.context), (action: f_231_49482_49505(syntaxNodeAction), context: syntaxNodeContext), f_231_49557_49599(f_231_49581_49592(), node));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 49648, 49749) || true) && (analyzerState != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 49648, 49749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 49696, 49749);

                        f_231_49696_49748(f_231_49696_49726(analyzerState), syntaxNodeAction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 49648, 49749);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 49024, 49764);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 48358, 49775);

                Microsoft.CodeAnalysis.SyntaxNode
                f_231_48872_48897(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.CurrentNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 48872, 48897);
                    return return_v;
                }


                int
                f_231_48834_48906(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48834, 48906);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_48963_48988(Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 48963, 48988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_48990_49005(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 48990, 49005);
                    return return_v;
                }


                bool
                f_231_48935_49006(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48935, 49006);
                    return return_v;
                }


                int
                f_231_48921_49007(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 48921, 49007);
                    return 0;
                }


                bool
                f_231_49028_49080(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                action)
                {
                    var return_v = ShouldExecuteAction((Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?)analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 49028, 49080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_49207_49222()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 49207, 49222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext
                f_231_49138_49302(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext(node, containingSymbol, semanticModel, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 49138, 49302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_49369_49394(Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 49369, 49394);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext>
                f_231_49482_49505(Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 49482, 49505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_49581_49592()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 49581, 49592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_49557_49599(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 49557, 49599);
                    return return_v;
                }


                int
                f_231_49323_49600(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 49323, 49600);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_49696_49726(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 49696, 49726);
                    return return_v;
                }


                bool
                f_231_49696_49748(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 49696, 49748);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 48358, 49775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 48358, 49775);
            }
        }

        private void ExecuteOperationAction(
                    OperationAnalyzerAction operationAction,
                    IOperation operation,
                    ISymbol containingSymbol,
                    SemanticModel semanticModel,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    OperationAnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 49787, 51173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 50180, 50263);

                f_231_50180_50262(analyzerState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 50193, 50261) || f_231_50218_50248(analyzerState) == operation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 50277, 50372);

                f_231_50277_50371(!f_231_50291_50370(this, f_231_50319_50343(operationAction), f_231_50345_50369(semanticModel)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 50388, 51162) || true) && (f_231_50392_50443(analyzerState, operationAction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 50388, 51162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 50477, 50702);

                    var
                    operationContext = f_231_50500_50701(operation, containingSymbol, f_231_50558_50583(semanticModel), f_231_50606_50621(), addDiagnostic, isSupportedDiagnostic, f_231_50661_50680(), _cancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 50720, 51000);

                    f_231_50720_50999(this, f_231_50766_50790(operationAction), data => data.action(data.context), (action: f_231_50878_50900(operationAction), context: operationContext), f_231_50951_50998(f_231_50975_50986(), operation));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 51047, 51147) || true) && (analyzerState != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 51047, 51147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 51095, 51147);

                        f_231_51095_51146(f_231_51095_51125(analyzerState), operationAction);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 51047, 51147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 50388, 51162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 49787, 51173);

                Microsoft.CodeAnalysis.IOperation
                f_231_50218_50248(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.CurrentOperation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50218, 50248);
                    return return_v;
                }


                int
                f_231_50180_50262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50180, 50262);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_50319_50343(Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50319, 50343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_50345_50369(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50345, 50369);
                    return return_v;
                }


                bool
                f_231_50291_50370(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50291, 50370);
                    return return_v;
                }


                int
                f_231_50277_50371(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50277, 50371);
                    return 0;
                }


                bool
                f_231_50392_50443(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                action)
                {
                    var return_v = ShouldExecuteAction((Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?)analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50392, 50443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_50558_50583(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50558, 50583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_50606_50621()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50606, 50621);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_231_50661_50680()
                {
                    var return_v = GetControlFlowGraph;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50661, 50680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext
                f_231_50500_50701(Microsoft.CodeAnalysis.IOperation
                operation, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                getControlFlowGraph, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext(operation, containingSymbol, compilation, options, reportDiagnostic, isSupportedDiagnostic, getControlFlowGraph, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50500, 50701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_50766_50790(Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50766, 50790);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext>
                f_231_50878_50900(Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50878, 50900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_50975_50986()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 50975, 50986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_50951_50998(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50951, 50998);
                    return return_v;
                }


                int
                f_231_50720_50999(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 50720, 50999);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_51095_51125(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 51095, 51125);
                    return return_v;
                }


                bool
                f_231_51095_51146(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 51095, 51146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 49787, 51173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 49787, 51173);
            }
        }

        public bool TryExecuteCodeBlockActions<TLanguageKindEnum>(
                    IEnumerable<CodeBlockStartAnalyzerAction<TLanguageKindEnum>> codeBlockStartActions,
                    IEnumerable<CodeBlockAnalyzerAction> codeBlockActions,
                    IEnumerable<CodeBlockAnalyzerAction> codeBlockEndActions,
                    DiagnosticAnalyzer analyzer,
                    SyntaxNode declaredNode,
                    ISymbol declaredSymbol,
                    ImmutableArray<SyntaxNode> executableCodeBlocks,
                    SemanticModel semanticModel,
                    Func<SyntaxNode, TLanguageKindEnum> getKind,
                    int declarationIndex,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCode)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 51646, 54160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 52445, 52496);

                DeclarationAnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 52548, 53922) || true) && (f_231_52552_52673(declaredSymbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 52548, 53922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 52715, 53869);

                        f_231_52715_53868(this, codeBlockStartActions, codeBlockActions, codeBlockEndActions, analyzer, declaredNode, declaredSymbol, executableCodeBlocks, (codeBlocks) => codeBlocks.SelectMany(
                                                    cb =>
                                                    {
                                                        var filter = semanticModel.GetSyntaxNodesToAnalyzeFilter(cb, declaredSymbol);

                                                        if (filter is object)
                                                        {
                                                            return cb.DescendantNodesAndSelf(descendIntoChildren: filter).Where(filter);
                                                        }
                                                        else
                                                        {
                                                            return cb.DescendantNodesAndSelf();
                                                        }
                                                    }), semanticModel, getKind, f_231_53813_53850_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 53813, 53850)?.CodeBlockAnalysisState), isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 53891, 53903);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 52548, 53922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 53942, 54030);

                    return f_231_53949_54029(declaredSymbol, declarationIndex, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 54059, 54149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 54099, 54134);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 54099, 54133)?.ResetToReadyState(), 231, 54113, 54133);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 54059, 54149);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 51646, 54160);

                bool
                f_231_52552_52673(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartAnalyzingDeclaration(symbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 52552, 52673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData?
                f_231_53813_53850_M(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 53813, 53850);
                    return return_v;
                }


                int
                f_231_52715_53868(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                startActions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                actions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                endActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>
                executableBlocks, System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxNode>, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>>
                getNodesToAnalyze, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.CodeBlockAnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteBlockActionsCore<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>, Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData, Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>(startActions, actions, endActions, analyzer, declaredNode, declaredSymbol, executableBlocks, getNodesToAnalyze, semanticModel, getKind, (Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData>?)analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 52715, 53868);
                    return 0;
                }


                bool
                f_231_53949_54029(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 53949, 54029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 51646, 54160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 51646, 54160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryExecuteOperationBlockActions(
                    IEnumerable<OperationBlockStartAnalyzerAction> operationBlockStartActions,
                    IEnumerable<OperationBlockAnalyzerAction> operationBlockActions,
                    IEnumerable<OperationBlockAnalyzerAction> operationBlockEndActions,
                    DiagnosticAnalyzer analyzer,
                    SyntaxNode declaredNode,
                    ISymbol declaredSymbol,
                    ImmutableArray<IOperation> operationBlocks,
                    ImmutableArray<IOperation> operations,
                    SemanticModel semanticModel,
                    int declarationIndex,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 54638, 56422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 55377, 55428);

                DeclarationAnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 55480, 56184) || true) && (f_231_55484_55605(declaredSymbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 55480, 56184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 55647, 56131);

                        f_231_55647_56130(this, operationBlockStartActions, operationBlockActions, operationBlockEndActions, analyzer, declaredNode, declaredSymbol, operationBlocks, (blocks) => operations, semanticModel, getKind: null, f_231_56070_56112_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 56070, 56112)?.OperationBlockAnalysisState), isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 56153, 56165);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 55480, 56184);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 56204, 56292);

                    return f_231_56211_56291(declaredSymbol, declarationIndex, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 56321, 56411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 56361, 56396);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 56361, 56395)?.ResetToReadyState(), 231, 56375, 56395);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 56321, 56411);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 54638, 56422);

                bool
                f_231_55484_55605(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartAnalyzingDeclaration(symbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 55484, 55605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData?
                f_231_56070_56112_M(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 56070, 56112);
                    return return_v;
                }


                int
                f_231_55647_56130(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
                startActions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                actions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                endActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                executableBlocks, System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>>
                getNodesToAnalyze, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Func<Microsoft.CodeAnalysis.SyntaxNode, int>?
                getKind, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteBlockActionsCore<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData, Microsoft.CodeAnalysis.IOperation, int>(startActions, actions, endActions, analyzer, declaredNode, declaredSymbol, executableBlocks, getNodesToAnalyze, semanticModel, getKind: getKind, (Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData>?)analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 55647, 56130);
                    return 0;
                }


                bool
                f_231_56211_56291(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 56211, 56291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 54638, 56422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 54638, 56422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteBlockActionsCore<TBlockStartAction, TBlockAction, TNodeAction, TNodeStateData, TNode, TLanguageKindEnum>(
                   IEnumerable<TBlockStartAction> startActions,
                   IEnumerable<TBlockAction> actions,
                   IEnumerable<TBlockAction> endActions,
                   DiagnosticAnalyzer analyzer,
                   SyntaxNode declaredNode,
                   ISymbol declaredSymbol,
                   ImmutableArray<TNode> executableBlocks,
                   Func<ImmutableArray<TNode>, IEnumerable<TNode>> getNodesToAnalyze,
                   SemanticModel semanticModel,
                   Func<SyntaxNode, TLanguageKindEnum>? getKind,
                   AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>? analyzerState,
                   bool isGeneratedCode)
                   where TLanguageKindEnum : struct
                   where TBlockStartAction : AnalyzerAction
                   where TBlockAction : AnalyzerAction
                   where TNodeAction : AnalyzerAction
                   where TNodeStateData : AnalyzerStateData, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 56434, 65593);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57464, 57499);

                f_231_57464_57498(declaredNode != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57513, 57550);

                f_231_57513_57549(declaredSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57564, 57621);

                f_231_57564_57620(f_231_57577_57619(declaredSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57635, 57705);

                f_231_57635_57704(f_231_57648_57666(startActions) || (DynAbs.Tracing.TraceSender.Expression_False(231, 57648, 57686) || f_231_57670_57686(endActions)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 57648, 57703) || f_231_57690_57703(actions)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57719, 57759);

                f_231_57719_57758(f_231_57732_57757_M(!executableBlocks.IsEmpty));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57775, 57981) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(231, 57779, 57842) && f_231_57798_57842(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 57779, 57925) || f_231_57863_57925(this, analyzer, f_231_57901_57924(declaredNode))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 57775, 57981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 57959, 57966);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 57775, 57981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58090, 58154);

                var
                blockEndActions = f_231_58112_58153()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58168, 58229);

                var
                blockActions = f_231_58187_58228()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58243, 58311);

                var
                executableNodeActions = f_231_58271_58310()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58325, 58432);

                var
                syntaxNodeActions = executableNodeActions as ArrayBuilder<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58446, 58532);

                var
                operationActions = executableNodeActions as ArrayBuilder<OperationAnalyzerAction>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58546, 58715);

                ImmutableArray<IOperation>
                operationBlocks = (DynAbs.Tracing.TraceSender.Conditional_F1(231, 58591, 58624) || ((executableBlocks[0] is IOperation && DynAbs.Tracing.TraceSender.Conditional_F2(231, 58627, 58679)) || DynAbs.Tracing.TraceSender.Conditional_F3(231, 58682, 58714))) ? (ImmutableArray<IOperation>)(object)executableBlocks : ImmutableArray<IOperation>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58779, 58808);

                f_231_58779_58807(
                            // Include the code block actions.
                            blockActions, actions);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 58884, 59414) || true) && (f_231_58888_58925_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 58888, 58925)?.CurrentBlockEndActions) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 58884, 59414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59039, 59121);

                    f_231_59039_59120(                // We have partially processed the code block actions.
                                    blockEndActions, f_231_59062_59119(f_231_59062_59098(analyzerState)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59139, 59229);

                    f_231_59139_59228(executableNodeActions, f_231_59170_59227(f_231_59170_59207(analyzerState)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 58884, 59414);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 58884, 59414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59364, 59399);

                    f_231_59364_59398(                // We have begun to process the code block actions.
                                    blockEndActions, endActions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 58884, 59414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59430, 59533);

                var
                diagReporter = f_231_59449_59532(this, f_231_59474_59498(semanticModel), f_231_59500_59521(declaredNode), analyzer)
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59635, 63201);
                        foreach (var startAction in f_231_59663_59675_I(startActions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 59635, 63201);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59717, 63182) || true) && (f_231_59721_59768(analyzerState, startAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 59717, 63182);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59818, 62992) || true) && (startAction is CodeBlockStartAnalyzerAction<TLanguageKindEnum> codeBlockStartAction)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 59818, 62992);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 59963, 60047);

                                    var
                                    codeBlockEndActions = blockEndActions as PooledHashSet<CodeBlockAnalyzerAction>
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 60077, 60155);

                                    var
                                    codeBlockScope = f_231_60098_60154()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 60185, 60423);

                                    var
                                    blockStartContext = f_231_60209_60422(f_231_60270_60290(startAction), codeBlockScope, declaredNode, declaredSymbol, semanticModel, f_231_60386_60401(), _cancellationToken)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 60526, 61263);

                                    f_231_60526_61262(this, f_231_60584_60604(startAction), data =>
                                                                    {
                                                                        data.action(data.context);
                                                                        data.blockEndActions?.AddAll(data.scope.CodeBlockEndActions);
                                                                        data.syntaxNodeActions?.AddRange(data.scope.SyntaxNodeActions);
                                                                    }, (action: f_231_61024_61051(codeBlockStartAction), context: blockStartContext, scope: codeBlockScope, blockEndActions: codeBlockEndActions, syntaxNodeActions), f_231_61195_61261(f_231_61219_61230(), declaredSymbol, declaredNode));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 59818, 62992);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 59818, 62992);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 61377, 62965) || true) && (startAction is OperationBlockStartAnalyzerAction operationBlockStartAction)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 61377, 62965);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 61521, 61615);

                                        var
                                        operationBlockEndActions = blockEndActions as PooledHashSet<OperationBlockAnalyzerAction>
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 61649, 61718);

                                        var
                                        operationBlockScope = f_231_61675_61717()
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 61752, 62025);

                                        var
                                        operationStartContext = f_231_61780_62024(f_231_61827_61847(startAction), operationBlockScope, operationBlocks, declaredSymbol, f_231_61940_61965(semanticModel), f_231_61967_61982(), f_231_61984_62003(), _cancellationToken)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 62136, 62934);

                                        f_231_62136_62933(this, f_231_62198_62218(startAction), data =>
                                                                            {
                                                                                data.action(data.context);
                                                                                data.blockEndActions?.AddAll(data.scope.OperationBlockEndActions);
                                                                                data.operationActions?.AddRange(data.scope.OperationActions);
                                                                            }, (action: f_231_62669_62701(operationBlockStartAction), context: operationStartContext, scope: operationBlockScope, blockEndActions: operationBlockEndActions, operationActions: operationActions), f_231_62880_62932(f_231_62904_62915(), declaredSymbol));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 61377, 62965);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 59818, 62992);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63055, 63159) || true) && (analyzerState != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 63055, 63159);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63111, 63159);

                                    f_231_63111_63158(f_231_63111_63141(analyzerState), startAction);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 63055, 63159);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 59717, 63182);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 59635, 63201);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 3567);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 3567);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 63230, 63582);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63270, 63567) || true) && (analyzerState != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 63270, 63567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63337, 63427);

                        analyzerState.CurrentBlockEndActions = f_231_63376_63426(blockEndActions);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63449, 63548);

                        analyzerState.CurrentBlockNodeActions = f_231_63489_63547(executableNodeActions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 63270, 63567);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 63230, 63582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63598, 63781);

                using var
                _ = f_231_63612_63780((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63865, 65112) || true) && (f_231_63869_63896(executableNodeActions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 63865, 65112);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 63930, 65097) || true) && (syntaxNodeActions != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 63930, 65097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64001, 64031);

                        f_231_64001_64030(getKind != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64055, 64129);

                        var
                        executableNodeActionsByKind = f_231_64089_64128(syntaxNodeActions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64151, 64239);

                        var
                        syntaxNodesToAnalyze = (IEnumerable<SyntaxNode>)f_231_64203_64238(getNodesToAnalyze, executableBlocks)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64261, 64520);

                        // LAFHIS
                        f_231_64261_64519(this, syntaxNodesToAnalyze, executableNodeActionsByKind, analyzer, declaredSymbol, 
                            semanticModel, getKind, diagReporter.AddDiagnosticAction, isSupportedDiagnostic, 
                            f_231_64444_64487_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 64444, 64487)?
                                .ExecutableNodesAnalysisState));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 63930, 65097);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 63930, 65097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64562, 65097) || true) && (operationActions != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 64562, 65097);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64632, 64705);

                            var
                            operationActionsByKind = f_231_64661_64704(operationActions)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64727, 64814);

                            var
                            operationsToAnalyze = (IEnumerable<IOperation>)f_231_64778_64813(getNodesToAnalyze, executableBlocks)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 64836, 65078);

                            // LAFHIS
                            f_231_64836_65077(this, operationsToAnalyze, operationActionsByKind, analyzer, declaredSymbol, semanticModel, diagReporter.AddDiagnosticAction, isSupportedDiagnostic,
                                f_231_65003_65046_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(
                                    analyzerState, 231, 65003, 65046)?.ExecutableNodesAnalysisState));

                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 64562, 65097);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 63930, 65097);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 63865, 65112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 65128, 65157);

                f_231_65128_65156(
                            executableNodeActions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 65173, 65351);

                f_231_65173_65350(this, blockActions, declaredNode, declaredSymbol, analyzer, semanticModel, operationBlocks, diagReporter.AddDiagnosticAction, isSupportedDiagnostic, analyzerState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 65365, 65546);

                f_231_65365_65545(this, blockEndActions, declaredNode, declaredSymbol, analyzer, semanticModel, operationBlocks, diagReporter.AddDiagnosticAction, isSupportedDiagnostic, analyzerState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 65562, 65582);

                f_231_65562_65581(
                            diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 56434, 65593);

                int
                f_231_57464_57498(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57464, 57498);
                    return 0;
                }


                int
                f_231_57513_57549(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57513, 57549);
                    return 0;
                }


                bool
                f_231_57577_57619(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = CanHaveExecutableCodeBlock(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57577, 57619);
                    return return_v;
                }


                int
                f_231_57564_57620(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57564, 57620);
                    return 0;
                }


                bool
                f_231_57648_57666(System.Collections.Generic.IEnumerable<TBlockStartAction>
                source)
                {
                    var return_v = source.Any<TBlockStartAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57648, 57666);
                    return return_v;
                }


                bool
                f_231_57670_57686(System.Collections.Generic.IEnumerable<TBlockAction>
                source)
                {
                    var return_v = source.Any<TBlockAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57670, 57686);
                    return return_v;
                }


                bool
                f_231_57690_57703(System.Collections.Generic.IEnumerable<TBlockAction>
                source)
                {
                    var return_v = source.Any<TBlockAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57690, 57703);
                    return return_v;
                }


                int
                f_231_57635_57704(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57635, 57704);
                    return 0;
                }


                bool
                f_231_57732_57757_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 57732, 57757);
                    return return_v;
                }


                int
                f_231_57719_57758(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57719, 57758);
                    return 0;
                }


                bool
                f_231_57798_57842(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57798, 57842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_57901_57924(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 57901, 57924);
                    return return_v;
                }


                bool
                f_231_57863_57925(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 57863, 57925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                f_231_58112_58153()
                {
                    var return_v = PooledHashSet<TBlockAction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 58112, 58153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                f_231_58187_58228()
                {
                    var return_v = PooledHashSet<TBlockAction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 58187, 58228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNodeAction>
                f_231_58271_58310()
                {
                    var return_v = ArrayBuilder<TNodeAction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 58271, 58310);
                    return return_v;
                }


                bool
                f_231_58779_58807(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                set, System.Collections.Generic.IEnumerable<TBlockAction>
                values)
                {
                    var return_v = set.AddAll<TBlockAction>(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 58779, 58807);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<TBlockAction>?
                f_231_58888_58925_M(System.Collections.Immutable.ImmutableHashSet<TBlockAction>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 58888, 58925);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<TBlockAction>
                f_231_59062_59098(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>
                this_param)
                {
                    var return_v = this_param.CurrentBlockEndActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 59062, 59098);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TBlockAction>
                f_231_59062_59119(System.Collections.Immutable.ImmutableHashSet<TBlockAction>
                source)
                {
                    var return_v = source.Cast<TBlockAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59062, 59119);
                    return return_v;
                }


                bool
                f_231_59039_59120(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                set, System.Collections.Generic.IEnumerable<TBlockAction>
                values)
                {
                    var return_v = set.AddAll<TBlockAction>(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59039, 59120);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_59170_59207(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>
                this_param)
                {
                    var return_v = this_param.CurrentBlockNodeActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 59170, 59207);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNodeAction>
                f_231_59170_59227(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                source)
                {
                    var return_v = source.Cast<TNodeAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59170, 59227);
                    return return_v;
                }


                int
                f_231_59139_59228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNodeAction>
                this_param, System.Collections.Generic.IEnumerable<TNodeAction>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59139, 59228);
                    return 0;
                }


                bool
                f_231_59364_59398(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                set, System.Collections.Generic.IEnumerable<TBlockAction>
                values)
                {
                    var return_v = set.AddAll<TBlockAction>(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59364, 59398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_59474_59498(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 59474, 59498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_231_59500_59521(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 59500, 59521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_59449_59532(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSemanticDiagnostic(tree, (Microsoft.CodeAnalysis.Text.TextSpan?)span, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59449, 59532);
                    return return_v;
                }


                bool
                f_231_59721_59768(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>?
                analyzerState, TBlockStartAction
                action)
                {
                    var return_v = ShouldExecuteAction((Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?)analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59721, 59768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum>
                f_231_60098_60154()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 60098, 60154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_60270_60290(TBlockStartAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 60270, 60290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_60386_60401()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 60386, 60401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum>
                f_231_60209_60422(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum>
                scope, Microsoft.CodeAnalysis.SyntaxNode
                codeBlock, Microsoft.CodeAnalysis.ISymbol
                owningSymbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum>(analyzer, scope, codeBlock, owningSymbol, semanticModel, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 60209, 60422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_60584_60604(TBlockStartAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 60584, 60604);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>>
                f_231_61024_61051(Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61024, 61051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_61219_61230()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61219, 61230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_61195_61261(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 61195, 61261);
                    return return_v;
                }


                int
                f_231_60526_61262(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum> context, Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum> scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction> blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>> syntaxNodeActions)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum> context, Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum> scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>? blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>? syntaxNodeActions)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalysisContext<TLanguageKindEnum>> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerCodeBlockStartAnalysisContext<TLanguageKindEnum> context, Microsoft.CodeAnalysis.Diagnostics.HostCodeBlockStartAnalysisScope<TLanguageKindEnum> scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>? blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>? syntaxNodeActions)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 60526, 61262);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope
                f_231_61675_61717()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 61675, 61717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_61827_61847(TBlockStartAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61827, 61847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_61940_61965(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61940, 61965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_61967_61982()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61967, 61982);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_231_61984_62003()
                {
                    var return_v = GetControlFlowGraph;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 61984, 62003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOperationBlockStartAnalysisContext
                f_231_61780_62024(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope
                scope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                operationBlocks, Microsoft.CodeAnalysis.ISymbol
                owningSymbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                getControlFlowGraph, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerOperationBlockStartAnalysisContext(analyzer, scope, operationBlocks, owningSymbol, compilation, options, getControlFlowGraph, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 61780, 62024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_62198_62218(TBlockStartAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 62198, 62218);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext>
                f_231_62669_62701(Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 62669, 62701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_62904_62915()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 62904, 62915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_62880_62932(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 62880, 62932);
                    return return_v;
                }


                int
                f_231_62136_62933(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOperationBlockStartAnalysisContext context, Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction> blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction> operationActions)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOperationBlockStartAnalysisContext context, Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>? blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>? operationActions)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOperationBlockStartAnalysisContext context, Microsoft.CodeAnalysis.Diagnostics.HostOperationBlockStartAnalysisScope scope, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>? blockEndActions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>? operationActions)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 62136, 62933);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_63111_63141(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 63111, 63141);
                    return return_v;
                }


                bool
                f_231_63111_63158(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, TBlockStartAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 63111, 63158);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TBlockStartAction>
                f_231_59663_59675_I(System.Collections.Generic.IEnumerable<TBlockStartAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 59663, 59675);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<TBlockAction>
                f_231_63376_63426(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                source)
                {
                    var return_v = source.ToImmutableHashSet<TBlockAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 63376, 63426);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_63489_63547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNodeAction>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 63489, 63547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_63612_63780(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 63612, 63780);
                    return return_v;
                }


                bool
                f_231_63869_63896(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNodeAction>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 63869, 63896);
                    return return_v;
                }


                int
                f_231_64001_64030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64001, 64030);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                f_231_64089_64128(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                nodeActions)
                {
                    var return_v = GetNodeActionsByKind((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>)nodeActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64089, 64128);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_231_64203_64238(System.Func<System.Collections.Immutable.ImmutableArray<TNode>, System.Collections.Generic.IEnumerable<TNode>>
                this_param, System.Collections.Immutable.ImmutableArray<TNode>
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64203, 64238);
                    return return_v;
                }


                TNodeStateData?
                f_231_64444_64487_M(TNodeStateData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 64444, 64487);
                    return return_v;
                }


                int
                f_231_64261_64519(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToAnalyze, System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                nodeActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, TNodeStateData?
                analyzerState)
                {
                    this_param.ExecuteSyntaxNodeActions<TLanguageKindEnum>(nodesToAnalyze, (System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>)nodeActionsByKind, analyzer, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState: analyzerState as SyntaxNodeAnalyzerStateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64261, 64519);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                f_231_64661_64704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                operationActions)
                {
                    var return_v = GetOperationActionsByKind((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>)operationActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64661, 64704);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_231_64778_64813(System.Func<System.Collections.Immutable.ImmutableArray<TNode>, System.Collections.Generic.IEnumerable<TNode>>
                this_param, System.Collections.Immutable.ImmutableArray<TNode>
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64778, 64813);
                    return return_v;
                }


                TNodeStateData?
                f_231_65003_65046_M(TNodeStateData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 65003, 65046);
                    return return_v;
                }


                int
                f_231_64836_65077(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                operationsToAnalyze, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                operationActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, TNodeStateData?
                analyzerState)
                {
                    this_param.ExecuteOperationActions(operationsToAnalyze, (System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>)operationActionsByKind, analyzer, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState: analyzerState as OperationAnalyzerStateData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 64836, 65077);
                    return 0;
                }


                int
                f_231_65128_65156(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TNodeAction>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 65128, 65156);
                    return 0;
                }


                int
                f_231_65173_65350(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                blockActions, Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                operationBlocks, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>?
                analyzerState)
                {
                    this_param.ExecuteBlockActions<TBlockAction, TNodeStateData>(blockActions, declaredNode, declaredSymbol, analyzer, semanticModel, operationBlocks, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 65173, 65350);
                    return 0;
                }


                int
                f_231_65365_65545(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                blockActions, Microsoft.CodeAnalysis.SyntaxNode
                declaredNode, Microsoft.CodeAnalysis.ISymbol
                declaredSymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                operationBlocks, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>?
                analyzerState)
                {
                    this_param.ExecuteBlockActions<TBlockAction, TNodeStateData>(blockActions, declaredNode, declaredSymbol, analyzer, semanticModel, operationBlocks, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 65365, 65545);
                    return 0;
                }


                int
                f_231_65562_65581(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 65562, 65581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 56434, 65593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 56434, 65593);
            }
        }

        private void ExecuteBlockActions<TBlockAction, TNodeStateData>(
                    PooledHashSet<TBlockAction> blockActions,
                    SyntaxNode declaredNode,
                    ISymbol declaredSymbol,
                    DiagnosticAnalyzer analyzer,
                    SemanticModel semanticModel,
                    ImmutableArray<IOperation> operationBlocks,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>? analyzerState)
                    where TBlockAction : AnalyzerAction
                    where TNodeStateData : AnalyzerStateData, new()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 65605, 68375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66276, 66354);

                f_231_66276_66353(!f_231_66290_66352(this, analyzer, f_231_66328_66351(declaredNode)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66370, 68328);
                    foreach (var blockAction in f_231_66398_66410_I(blockActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 66370, 68328);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66444, 68313) || true) && (f_231_66448_66495(analyzerState, blockAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 66444, 68313);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66537, 66598);

                            var
                            codeBlockAction = blockAction as CodeBlockAnalyzerAction
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66620, 68139) || true) && (codeBlockAction != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 66620, 68139);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66697, 66860);

                                var
                                context = f_231_66711_66859(declaredNode, declaredSymbol, semanticModel, f_231_66785_66800(), addDiagnostic, isSupportedDiagnostic, _cancellationToken)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 66888, 67210);

                                f_231_66888_67209(this, f_231_66942_66966(codeBlockAction), data => data.action(data.context), (action: f_231_67070_67092(codeBlockAction), context: context), f_231_67142_67208(f_231_67166_67177(), declaredSymbol, declaredNode));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 66620, 68139);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 66620, 68139);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 67308, 67379);

                                var
                                operationBlockAction = blockAction as OperationBlockAnalyzerAction
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 67405, 68116) || true) && (operationBlockAction != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 67405, 68116);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 67495, 67732);

                                    var
                                    context = f_231_67509_67731(operationBlocks, declaredSymbol, f_231_67576_67601(semanticModel), f_231_67636_67651(), addDiagnostic, isSupportedDiagnostic, f_231_67691_67710(), _cancellationToken)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 67764, 68089);

                                    f_231_67764_68088(this, f_231_67822_67851(operationBlockAction), data => data.action(data.context), (action: f_231_67963_67990(operationBlockAction), context), f_231_68035_68087(f_231_68059_68070(), declaredSymbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 67405, 68116);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 66620, 68139);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68194, 68294) || true) && (analyzerState != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 68194, 68294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68246, 68294);

                                f_231_68246_68293(f_231_68246_68276(analyzerState), blockAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 68194, 68294);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 66444, 68313);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 66370, 68328);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 1959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 1959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68344, 68364);

                f_231_68344_68363(
                            blockActions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 65605, 68375);

                Microsoft.CodeAnalysis.SyntaxTree
                f_231_66328_66351(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 66328, 66351);
                    return return_v;
                }


                bool
                f_231_66290_66352(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66290, 66352);
                    return return_v;
                }


                int
                f_231_66276_66353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66276, 66353);
                    return 0;
                }


                bool
                f_231_66448_66495(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>?
                analyzerState, TBlockAction
                action)
                {
                    var return_v = ShouldExecuteAction((Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?)analyzerState, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66448, 66495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_66785_66800()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 66785, 66800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext
                f_231_66711_66859(Microsoft.CodeAnalysis.SyntaxNode
                codeBlock, Microsoft.CodeAnalysis.ISymbol
                owningSymbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext(codeBlock, owningSymbol, semanticModel, options, reportDiagnostic, isSupportedDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66711, 66859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_66942_66966(Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 66942, 66966);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext>
                f_231_67070_67092(Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67070, 67092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_67166_67177()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67166, 67177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_67142_67208(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 67142, 67208);
                    return return_v;
                }


                int
                f_231_66888_67209(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66888, 67209);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_67576_67601(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67576, 67601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_231_67636_67651()
                {
                    var return_v = AnalyzerOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67636, 67651);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_231_67691_67710()
                {
                    var return_v = GetControlFlowGraph;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67691, 67710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext
                f_231_67509_67731(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                operationBlocks, Microsoft.CodeAnalysis.ISymbol
                owningSymbol, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                getControlFlowGraph, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext(operationBlocks, owningSymbol, compilation, options, reportDiagnostic, isSupportedDiagnostic, getControlFlowGraph, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 67509, 67731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                f_231_67822_67851(Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Analyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67822, 67851);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext>
                f_231_67963_67990(Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 67963, 67990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_68059_68070()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 68059, 68070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                f_231_68035_68087(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo(compilation, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68035, 68087);
                    return return_v;
                }


                int
                f_231_67764_68088(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext context)>
                analyze, (System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext context)
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo
                info)
                {
                    this_param.ExecuteAndCatchIfThrows<(System.Action<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext> action, Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalysisContext context)>(analyzer, analyze, argument, (Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 67764, 68088);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_68246_68276(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.BlockAnalyzerStateData<TBlockAction, TNodeStateData>
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 68246, 68276);
                    return return_v;
                }


                bool
                f_231_68246_68293(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, TBlockAction
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68246, 68293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                f_231_66398_66410_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 66398, 66410);
                    return return_v;
                }


                int
                f_231_68344_68363(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<TBlockAction>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68344, 68363);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 65605, 68375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 65605, 68375);
            }
        }

        internal static ImmutableDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> GetNodeActionsByKind<TLanguageKindEnum>(
                    IEnumerable<SyntaxNodeAnalyzerAction<TLanguageKindEnum>> nodeActions)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 68387, 69676);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>> actionsForKind = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68697, 68752);

                f_231_68697_68751(nodeActions != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 68710, 68750) && f_231_68733_68750(nodeActions)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68768, 68901);

                var
                nodeActionsByKind = f_231_68792_68900()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68915, 69410);
                    foreach (var nodeAction in f_231_68942_68953_I(nodeActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 68915, 69410);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 68987, 69395);
                            foreach (var kind in f_231_69008_69024_I(f_231_69008_69024(nodeAction)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 68987, 69395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69066, 69321) || true) && (!f_231_69071_69130(nodeActionsByKind, kind, out actionsForKind))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 69066, 69321);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69180, 69298);

                                    f_231_69180_69297(nodeActionsByKind, kind, actionsForKind = f_231_69225_69296());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 69066, 69321);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69345, 69376);

                                f_231_69345_69375(
                                                    actionsForKind, nodeAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 68987, 69395);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 409);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 409);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 68915, 69410);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69426, 69537);

                var
                tuples = f_231_69439_69536(nodeActionsByKind, kvp => KeyValuePairUtil.Create(kvp.Key, kvp.Value.ToImmutableAndFree()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69551, 69601);

                var
                map = f_231_69561_69600(tuples)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69615, 69640);

                f_231_69615_69639(nodeActionsByKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 69654, 69665);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 68387, 69676);

                bool
                f_231_68733_68750(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68733, 68750);
                    return return_v;
                }


                int
                f_231_68697_68751(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68697, 68751);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                f_231_68792_68900()
                {
                    var return_v = PooledDictionary<TLanguageKindEnum, ArrayBuilder<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68792, 68900);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                f_231_69008_69024(Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                this_param)
                {
                    var return_v = this_param.Kinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 69008, 69024);
                    return return_v;
                }


                bool
                f_231_69071_69130(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                this_param, TLanguageKindEnum
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69071, 69130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_231_69225_69296()
                {
                    var return_v = ArrayBuilder<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69225, 69296);
                    return return_v;
                }


                int
                f_231_69180_69297(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                this_param, TLanguageKindEnum
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69180, 69297);
                    return 0;
                }


                int
                f_231_69345_69375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69345, 69375);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                f_231_69008_69024_I(System.Collections.Immutable.ImmutableArray<TLanguageKindEnum>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69008, 69024);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_231_68942_68953_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 68942, 68953);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>>
                f_231_69439_69536(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                source, System.Func<System.Collections.Generic.KeyValuePair<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>, System.Collections.Generic.KeyValuePair<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>, System.Collections.Generic.KeyValuePair<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69439, 69536);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                f_231_69561_69600(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>>
                items)
                {
                    var return_v = ImmutableDictionary.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69561, 69600);
                    return return_v;
                }


                int
                f_231_69615_69639(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<TLanguageKindEnum, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 69615, 69639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 68387, 69676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 68387, 69676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryExecuteSyntaxNodeActions<TLanguageKindEnum>(
                   IEnumerable<SyntaxNode> nodesToAnalyze,
                   IDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> nodeActionsByKind,
                   DiagnosticAnalyzer analyzer,
                   SemanticModel model,
                   Func<SyntaxNode, TLanguageKindEnum> getKind,
                   TextSpan filterSpan,
                   int declarationIndex,
                   ISymbol declaredSymbol,
                   AnalysisScope analysisScope,
                   AnalysisState? analysisState,
                   bool isGeneratedCode)
                   where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 70150, 71516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 70805, 70856);

                DeclarationAnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 70908, 71278) || true) && (f_231_70912_71033(declaredSymbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 70908, 71278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 71075, 71225);

                        f_231_71075_71224(this, nodesToAnalyze, nodeActionsByKind, analyzer, declaredSymbol, model, getKind, filterSpan, analyzerState, isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 71247, 71259);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 70908, 71278);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 71298, 71386);

                    return f_231_71305_71385(declaredSymbol, declarationIndex, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 71415, 71505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 71455, 71490);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 71455, 71489)?.ResetToReadyState(), 231, 71469, 71489);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 71415, 71505);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 70150, 71516);

                bool
                f_231_70912_71033(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartAnalyzingDeclaration(symbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 70912, 71033);
                    return return_v;
                }


                int
                f_231_71075_71224(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToAnalyze, System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                nodeActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteSyntaxNodeActionsCore<TLanguageKindEnum>(nodesToAnalyze, nodeActionsByKind, analyzer, containingSymbol, model, getKind, filterSpan, (Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?)analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 71075, 71224);
                    return 0;
                }


                bool
                f_231_71305_71385(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 71305, 71385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 70150, 71516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 70150, 71516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteSyntaxNodeActionsCore<TLanguageKindEnum>(
                    IEnumerable<SyntaxNode> nodesToAnalyze,
                    IDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> nodeActionsByKind,
                    DiagnosticAnalyzer analyzer,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    Func<SyntaxNode, TLanguageKindEnum> getKind,
                    TextSpan filterSpan,
                    SyntaxNodeAnalyzerStateData? analyzerState,
                    bool isGeneratedCode)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 71528, 72869);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72136, 72335) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(231, 72140, 72203) && f_231_72159_72203(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 72140, 72279) || f_231_72224_72279(this, analyzer, f_231_72262_72278(model))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 72136, 72335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72313, 72320);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 72136, 72335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72351, 72435);

                var
                diagReporter = f_231_72370_72434(this, f_231_72395_72411(model), filterSpan, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72451, 72634);

                using var
                _ = f_231_72465_72633((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72648, 72824);

                f_231_72648_72823(this, nodesToAnalyze, nodeActionsByKind, analyzer, containingSymbol, model, getKind, diagReporter.AddDiagnosticAction, isSupportedDiagnostic, analyzerState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 72838, 72858);

                f_231_72838_72857(diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 71528, 72869);

                bool
                f_231_72159_72203(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72159, 72203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_72262_72278(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 72262, 72278);
                    return return_v;
                }


                bool
                f_231_72224_72279(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72224, 72279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_72395_72411(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 72395, 72411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_72370_72434(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSemanticDiagnostic(tree, (Microsoft.CodeAnalysis.Text.TextSpan?)span, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72370, 72434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_72465_72633(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72465, 72633);
                    return return_v;
                }


                int
                f_231_72648_72823(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                nodesToAnalyze, System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                nodeActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteSyntaxNodeActions<TLanguageKindEnum>(nodesToAnalyze, nodeActionsByKind, analyzer, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72648, 72823);
                    return 0;
                }


                int
                f_231_72838_72857(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 72838, 72857);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 71528, 72869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 71528, 72869);
            }
        }

        private void ExecuteSyntaxNodeActions<TLanguageKindEnum>(
                    IEnumerable<SyntaxNode> nodesToAnalyze,
                    IDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> nodeActionsByKind,
                    DiagnosticAnalyzer analyzer,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    Func<SyntaxNode, TLanguageKindEnum> getKind,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    SyntaxNodeAnalyzerStateData? analyzerState)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 72881, 74394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73522, 73560);

                f_231_73522_73559(f_231_73535_73558(nodeActionsByKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73574, 73645);

                f_231_73574_73644(!f_231_73588_73643(this, analyzer, f_231_73626_73642(model)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73661, 73717);

                var
                partiallyProcessedNode = f_231_73690_73716_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 73690, 73716)?.CurrentNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73731, 73969) || true) && (partiallyProcessedNode != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 73731, 73969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73799, 73954);

                    f_231_73799_73953(this, partiallyProcessedNode, nodeActionsByKind, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 73731, 73969);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 73985, 74383);
                    foreach (var child in f_231_74007_74021_I(nodesToAnalyze))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 73985, 74383);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 74055, 74368) || true) && (f_231_74059_74108(this, analyzerState, child, analyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 74055, 74368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 74150, 74187);

                            f_231_74150_74186(analyzerState, child);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 74211, 74349);

                            f_231_74211_74348(this, child, nodeActionsByKind, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 74055, 74368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 73985, 74383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 399);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 72881, 74394);

                bool
                f_231_73535_73558(System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                source)
                {
                    var return_v = source.Any<System.Collections.Generic.KeyValuePair<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 73535, 73558);
                    return return_v;
                }


                int
                f_231_73522_73559(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 73522, 73559);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_73626_73642(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 73626, 73642);
                    return return_v;
                }


                bool
                f_231_73588_73643(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 73588, 73643);
                    return return_v;
                }


                int
                f_231_73574_73644(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 73574, 73644);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_231_73690_73716_M(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 73690, 73716);
                    return return_v;
                }


                int
                f_231_73799_73953(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                nodeActionsByKind, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteSyntaxNodeActions<TLanguageKindEnum>(node, nodeActionsByKind, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 73799, 73953);
                    return 0;
                }


                bool
                f_231_74059_74108(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.ShouldExecuteNode(analyzerState, node, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 74059, 74108);
                    return return_v;
                }


                int
                f_231_74150_74186(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    SetCurrentNode(analyzerState, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 74150, 74186);
                    return 0;
                }


                int
                f_231_74211_74348(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                nodeActionsByKind, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                getKind, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteSyntaxNodeActions<TLanguageKindEnum>(node, nodeActionsByKind, containingSymbol, model, getKind, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 74211, 74348);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_231_74007_74021_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 74007, 74021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 72881, 74394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 72881, 74394);
            }
        }

        private void ExecuteSyntaxNodeActions<TLanguageKindEnum>(
                    SyntaxNode node,
                    IDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> nodeActionsByKind,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    Func<SyntaxNode, TLanguageKindEnum> getKind,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    SyntaxNodeAnalyzerStateData? analyzerState)
                    where TLanguageKindEnum : struct
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 74406, 75384);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>> actionsForKind = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 74982, 75317) || true) && (f_231_74986_75054(nodeActionsByKind, f_231_75016_75029(getKind, node), out actionsForKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 74982, 75317);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75088, 75302);
                        foreach (var action in f_231_75111_75125_I(actionsForKind))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 75088, 75302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75167, 75283);

                            f_231_75167_75282(this, action, node, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 75088, 75302);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 215);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 74982, 75317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75333, 75373);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 75333, 75372)?.ClearNodeAnalysisState(), 231, 75347, 75372);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 74406, 75384);

                TLanguageKindEnum
                f_231_75016_75029(System.Func<Microsoft.CodeAnalysis.SyntaxNode, TLanguageKindEnum>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75016, 75029);
                    return return_v;
                }


                bool
                f_231_74986_75054(System.Collections.Generic.IDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                this_param, TLanguageKindEnum
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 74986, 75054);
                    return return_v;
                }


                int
                f_231_75167_75282(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>
                syntaxNodeAction, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteSyntaxNodeAction<TLanguageKindEnum>(syntaxNodeAction, node, containingSymbol, semanticModel, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75167, 75282);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                f_231_75111_75125_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75111, 75125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 74406, 75384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 74406, 75384);
            }
        }

        internal static ImmutableDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> GetOperationActionsByKind(IEnumerable<OperationAnalyzerAction> operationActions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 75396, 76555);
                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction> actionsForKind = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75593, 75630);

                f_231_75593_75629(f_231_75606_75628(operationActions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75646, 75760);

                var
                operationActionsByKind = f_231_75675_75759()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75774, 76279);
                    foreach (var operationAction in f_231_75806_75822_I(operationActions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 75774, 76279);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75856, 76264);
                            foreach (var kind in f_231_75877_75898_I(f_231_75877_75898(operationAction)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 75856, 76264);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 75940, 76185) || true) && (!f_231_75945_76009(operationActionsByKind, kind, out actionsForKind))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 75940, 76185);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76059, 76162);

                                    f_231_76059_76161(operationActionsByKind, kind, actionsForKind = f_231_76109_76160());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 75940, 76185);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76209, 76245);

                                f_231_76209_76244(
                                                    actionsForKind, operationAction);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 75856, 76264);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 409);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 409);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 75774, 76279);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76295, 76411);

                var
                tuples = f_231_76308_76410(operationActionsByKind, kvp => KeyValuePairUtil.Create(kvp.Key, kvp.Value.ToImmutableAndFree()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76425, 76475);

                var
                map = f_231_76435_76474(tuples)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76489, 76519);

                f_231_76489_76518(operationActionsByKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 76533, 76544);

                return map;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 75396, 76555);

                bool
                f_231_75606_75628(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75606, 75628);
                    return return_v;
                }


                int
                f_231_75593_75629(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75593, 75629);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                f_231_75675_75759()
                {
                    var return_v = PooledDictionary<OperationKind, ArrayBuilder<OperationAnalyzerAction>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75675, 75759);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_231_75877_75898(Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                this_param)
                {
                    var return_v = this_param.Kinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 75877, 75898);
                    return return_v;
                }


                bool
                f_231_75945_76009(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                this_param, Microsoft.CodeAnalysis.OperationKind
                key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75945, 76009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                f_231_76109_76160()
                {
                    var return_v = ArrayBuilder<OperationAnalyzerAction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76109, 76160);
                    return return_v;
                }


                int
                f_231_76059_76161(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                this_param, Microsoft.CodeAnalysis.OperationKind
                key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76059, 76161);
                    return 0;
                }


                int
                f_231_76209_76244(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76209, 76244);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                f_231_75877_75898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.OperationKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75877, 75898);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                f_231_75806_75822_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 75806, 75822);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>>
                f_231_76308_76410(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76308, 76410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                f_231_76435_76474(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>>
                items)
                {
                    var return_v = ImmutableDictionary.CreateRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76435, 76474);
                    return return_v;
                }


                int
                f_231_76489_76518(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.OperationKind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 76489, 76518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 75396, 76555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 75396, 76555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryExecuteOperationActions(
                    IEnumerable<IOperation> operationsToAnalyze,
                    IDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> operationActionsByKind,
                    DiagnosticAnalyzer analyzer,
                    SemanticModel model,
                    TextSpan filterSpan,
                    int declarationIndex,
                    ISymbol declaredSymbol,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 77027, 78325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 77556, 77607);

                DeclarationAnalyzerStateData?
                analyzerState = null
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 77659, 78087) || true) && (f_231_77663_77784(declaredSymbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 77659, 78087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 77826, 78034);

                        // LAFHIS
                        f_231_77826_78033(this, operationsToAnalyze, operationActionsByKind, analyzer, declaredSymbol, model, 
                            filterSpan,  
                                f_231_77958_78015(f_231_77944_78015_M(
                                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 77944, 78015)?.OperationBlockAnalysisState)), isGeneratedCode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 78056, 78068);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 77659, 78087);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 78107, 78195);

                    return f_231_78114_78194(declaredSymbol, declarationIndex, analyzer, analysisState);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(231, 78224, 78314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 78264, 78299);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 78264, 78298)?.ResetToReadyState(), 231, 78278, 78298);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(231, 78224, 78314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 77027, 78325);

                bool
                f_231_77663_77784(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                analyzerState)
                {
                    var return_v = TryStartAnalyzingDeclaration(symbol, declarationIndex, analyzer, analysisScope, analysisState, out analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 77663, 77784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData
                f_231_77958_78015(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ExecutableNodesAnalysisState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 77958, 78015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData?
                f_231_77944_78015_M(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationBlockAnalyzerStateData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 77944, 78015);
                    return return_v;
                }


                int
                f_231_77826_78033(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                operationsToAnalyze, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                operationActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Text.TextSpan
                filterSpan, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState, bool
                isGeneratedCode)
                {
                    this_param.ExecuteOperationActionsCore(operationsToAnalyze, operationActionsByKind, analyzer, containingSymbol, model, filterSpan, analyzerState, isGeneratedCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 77826, 78033);
                    return 0;
                }


                bool
                f_231_78114_78194(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalysisState?
                analysisState)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, analyzer, analysisState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 78114, 78194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 77027, 78325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 77027, 78325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteOperationActionsCore(
                    IEnumerable<IOperation> operationsToAnalyze,
                    IDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> operationActionsByKind,
                    DiagnosticAnalyzer analyzer,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    TextSpan filterSpan,
                    OperationAnalyzerStateData? analyzerState,
                    bool isGeneratedCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 78337, 79539);
                System.Func<Microsoft.CodeAnalysis.Diagnostic, bool> isSupportedDiagnostic = default(System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 78806, 79005) || true) && (isGeneratedCode && (DynAbs.Tracing.TraceSender.Expression_True(231, 78810, 78873) && f_231_78829_78873(this, analyzer)) || (DynAbs.Tracing.TraceSender.Expression_False(231, 78810, 78949) || f_231_78894_78949(this, analyzer, f_231_78932_78948(model))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 78806, 79005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 78983, 78990);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 78806, 79005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 79021, 79105);

                var
                diagReporter = f_231_79040_79104(this, f_231_79065_79081(model), filterSpan, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 79121, 79304);

                using var
                _ = f_231_79135_79303((d, arg) => arg.self.IsSupportedDiagnostic(arg.analyzer, d), (self: this, analyzer), out isSupportedDiagnostic)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 79318, 79494);

                f_231_79318_79493(this, operationsToAnalyze, operationActionsByKind, analyzer, containingSymbol, model, diagReporter.AddDiagnosticAction, isSupportedDiagnostic, analyzerState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 79508, 79528);

                f_231_79508_79527(diagReporter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 78337, 79539);

                bool
                f_231_78829_78873(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 78829, 78873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_78932_78948(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 78932, 78948);
                    return return_v;
                }


                bool
                f_231_78894_78949(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 78894, 78949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_79065_79081(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 79065, 79081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_79040_79104(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAddSemanticDiagnostic(tree, (Microsoft.CodeAnalysis.Text.TextSpan?)span, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 79040, 79104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDelegates.Releaser
                f_231_79135_79303(System.Func<Microsoft.CodeAnalysis.Diagnostic, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer), bool>
                unboundFunction, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor self, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer)
                argument, out System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                boundFunction)
                {
                    var return_v = PooledDelegates.GetPooledFunction(unboundFunction, argument, out boundFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 79135, 79303);
                    return return_v;
                }


                int
                f_231_79318_79493(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                operationsToAnalyze, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                operationActionsByKind, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteOperationActions(operationsToAnalyze, operationActionsByKind, analyzer, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 79318, 79493);
                    return 0;
                }


                int
                f_231_79508_79527(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 79508, 79527);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 78337, 79539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 78337, 79539);
            }
        }

        private void ExecuteOperationActions(
                    IEnumerable<IOperation> operationsToAnalyze,
                    IDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> operationActionsByKind,
                    DiagnosticAnalyzer analyzer,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    OperationAnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 79551, 81014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80053, 80098);

                f_231_80053_80097(operationActionsByKind != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80112, 80155);

                f_231_80112_80154(f_231_80125_80153(operationActionsByKind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80169, 80240);

                f_231_80169_80239(!f_231_80183_80238(this, analyzer, f_231_80221_80237(model)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80256, 80322);

                var
                partiallyProcessedOperation = f_231_80290_80321_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 80290, 80321)?.CurrentOperation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80336, 80579) || true) && (partiallyProcessedOperation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 80336, 80579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80409, 80564);

                    f_231_80409_80563(this, partiallyProcessedOperation, operationActionsByKind, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 80336, 80579);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80595, 81003);
                    foreach (var child in f_231_80617_80636_I(operationsToAnalyze))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 80595, 81003);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80670, 80988) || true) && (f_231_80674_80728(this, analyzerState, child, analyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 80670, 80988);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80770, 80812);

                            f_231_80770_80811(analyzerState, child);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 80836, 80969);

                            f_231_80836_80968(this, child, operationActionsByKind, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 80670, 80988);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 80595, 81003);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 409);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 79551, 81014);

                int
                f_231_80053_80097(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80053, 80097);
                    return 0;
                }


                bool
                f_231_80125_80153(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                source)
                {
                    var return_v = source.Any<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80125, 80153);
                    return return_v;
                }


                int
                f_231_80112_80154(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80112, 80154);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_80221_80237(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 80221, 80237);
                    return return_v;
                }


                bool
                f_231_80183_80238(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80183, 80238);
                    return return_v;
                }


                int
                f_231_80169_80239(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80169, 80239);
                    return 0;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_231_80290_80321_M(Microsoft.CodeAnalysis.IOperation?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 80290, 80321);
                    return return_v;
                }


                int
                f_231_80409_80563(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                operationActionsByKind, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteOperationActions(operation, operationActionsByKind, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80409, 80563);
                    return 0;
                }


                bool
                f_231_80674_80728(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.IOperation
                operation, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.ShouldExecuteOperation(analyzerState, operation, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80674, 80728);
                    return return_v;
                }


                int
                f_231_80770_80811(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState, Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    SetCurrentOperation(analyzerState, operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80770, 80811);
                    return 0;
                }


                int
                f_231_80836_80968(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.IOperation
                operation, System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                operationActionsByKind, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                model, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteOperationActions(operation, operationActionsByKind, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80836, 80968);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                f_231_80617_80636_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 80617, 80636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 79551, 81014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 79551, 81014);
            }
        }

        private void ExecuteOperationActions(
                    IOperation operation,
                    IDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> operationActionsByKind,
                    ISymbol containingSymbol,
                    SemanticModel model,
                    Action<Diagnostic> addDiagnostic,
                    Func<Diagnostic, bool> isSupportedDiagnostic,
                    OperationAnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 81026, 81875);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction> actionsForKind = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 81463, 81808) || true) && (f_231_81467_81541(operationActionsByKind, f_231_81502_81516(operation), out actionsForKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 81463, 81808);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 81575, 81793);
                        foreach (var action in f_231_81598_81612_I(actionsForKind))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 81575, 81793);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 81654, 81774);

                            f_231_81654_81773(this, action, operation, containingSymbol, model, addDiagnostic, isSupportedDiagnostic, analyzerState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 81575, 81793);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 219);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 219);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 81463, 81808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 81824, 81864);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerState, 231, 81824, 81863)?.ClearNodeAnalysisState(), 231, 81838, 81863);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 81026, 81875);

                Microsoft.CodeAnalysis.OperationKind
                f_231_81502_81516(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 81502, 81516);
                    return return_v;
                }


                bool
                f_231_81467_81541(System.Collections.Generic.IDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                this_param, Microsoft.CodeAnalysis.OperationKind
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 81467, 81541);
                    return return_v;
                }


                int
                f_231_81654_81773(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction
                operationAction, Microsoft.CodeAnalysis.IOperation
                operation, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, bool>
                isSupportedDiagnostic, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData?
                analyzerState)
                {
                    this_param.ExecuteOperationAction(operationAction, operation, containingSymbol, semanticModel, addDiagnostic, isSupportedDiagnostic, analyzerState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 81654, 81773);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                f_231_81598_81612_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 81598, 81612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 81026, 81875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 81026, 81875);
            }
        }

        internal static bool CanHaveExecutableCodeBlock(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 81887, 82579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 81975, 82568);

                switch (f_231_81983_81994(symbol))
                {

                    case SymbolKind.Method:
                    case SymbolKind.Event:
                    case SymbolKind.Property:
                    case SymbolKind.NamedType:
                    case SymbolKind.Namespace: // We are exposing assembly/module attributes on global namespace symbol.
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 81975, 82568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82318, 82330);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 81975, 82568);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 81975, 82568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82394, 82456);

                        f_231_82394_82455(f_231_82407_82446(((IFieldSymbol)symbol)) == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82478, 82490);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 81975, 82568);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 81975, 82568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82540, 82553);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 81975, 82568);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 81887, 82579);

                Microsoft.CodeAnalysis.SymbolKind
                f_231_81983_81994(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 81983, 81994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_231_82407_82446(Microsoft.CodeAnalysis.IFieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 82407, 82446);
                    return return_v;
                }


                int
                f_231_82394_82455(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 82394, 82455);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 81887, 82579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 81887, 82579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ExecuteAndCatchIfThrows<TArg>(DiagnosticAnalyzer analyzer, Action<TArg> analyze, TArg argument, AnalysisContextInfo? info = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 82591, 84664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82759, 82791);

                SharedStopwatch
                timer = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82805, 83921) || true) && (_analyzerExecutionTimeMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 82805, 83921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 82876, 82907);

                    _ = SharedStopwatch.StartNew();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 83871, 83906);

                    timer = SharedStopwatch.StartNew();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 82805, 83921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 83937, 83983);

                var
                gate = f_231_83948_83982_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_getAnalyzerGate, 231, 83948, 83982)?.Invoke(analyzer))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 83997, 84331) || true) && (gate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 83997, 84331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84053, 84057);
                    lock (gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84099, 84165);

                        f_231_84099_84164(this, analyzer, analyze, argument, info);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 83997, 84331);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 83997, 84331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84250, 84316);

                    f_231_84250_84315(this, analyzer, analyze, argument, info);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 83997, 84331);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84347, 84653) || true) && (_analyzerExecutionTimeMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 84347, 84653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84418, 84452);

                    var
                    elapsed = timer.Elapsed.Ticks
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84470, 84573);

                    StrongBox<long>
                    totalTicks = f_231_84499_84572(_analyzerExecutionTimeMap, analyzer, _ => new StrongBox<long>(0))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 84591, 84638);

                    f_231_84591_84637(ref totalTicks.Value, elapsed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 84347, 84653);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 82591, 84664);

                object?
                f_231_83948_83982_I(object?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 83948, 83982);
                    return return_v;
                }


                int
                f_231_84099_84164(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<TArg>
                analyze, TArg?
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?
                info)
                {
                    this_param.ExecuteAndCatchIfThrows_NoLock<TArg>(analyzer, analyze, argument, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 84099, 84164);
                    return 0;
                }


                int
                f_231_84250_84315(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<TArg>
                analyze, TArg?
                argument, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?
                info)
                {
                    this_param.ExecuteAndCatchIfThrows_NoLock<TArg>(analyzer, analyze, argument, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 84250, 84315);
                    return 0;
                }


                System.Runtime.CompilerServices.StrongBox<long>
                f_231_84499_84572(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 84499, 84572);
                    return return_v;
                }


                long
                f_231_84591_84637(ref long
                location1, long
                value)
                {
                    var return_v = Interlocked.Add(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 84591, 84637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 82591, 84664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 82591, 84664);
            }
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/23582",
                    AllowCaptures = false)]
        private void ExecuteAndCatchIfThrows_NoLock<TArg>(DiagnosticAnalyzer analyzer, Action<TArg> analyze, TArg argument, AnalysisContextInfo? info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 84676, 85621);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85010, 85060);

                    _cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85078, 85096);

                    f_231_85078_85095(analyze, argument);
                }
                catch (Exception e) when (f_231_85151_85169(this, e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(231, 85125, 85610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85258, 85328);

                    var
                    diagnostic = f_231_85275_85327(analyzer, e, info)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85390, 85436);

                        f_231_85390_85435(this, e, analyzer, diagnostic);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(231, 85473, 85595);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(231, 85473, 85595);
                        // Ignore exceptions from exception handlers.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(231, 85125, 85610);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 84676, 85621);

                int
                f_231_85078_85095(System.Action<TArg>
                this_param, TArg?
                obj)
                {
                    this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 85078, 85095);
                    return 0;
                }


                bool
                f_231_85151_85169(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Exception
                ex)
                {
                    var return_v = this_param.ExceptionFilter(ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 85151, 85169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_231_85275_85327(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Exception
                e, Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?
                info)
                {
                    var return_v = CreateAnalyzerExceptionDiagnostic(analyzer, e, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 85275, 85327);
                    return return_v;
                }


                int
                f_231_85390_85435(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Exception
                arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg2, Microsoft.CodeAnalysis.Diagnostic
                arg3)
                {
                    this_param._onAnalyzerException(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 85390, 85435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 84676, 85621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 84676, 85621);
            }
        }

        internal bool ExceptionFilter(Exception ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 85633, 86180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85820, 86004) || true) && (((DynAbs.Tracing.TraceSender.Conditional_F1(231, 85825, 85859) || (((ex is OperationCanceledException) && DynAbs.Tracing.TraceSender.Conditional_F2(231, 85862, 85912)) || DynAbs.Tracing.TraceSender.Conditional_F3(231, 85915, 85919))) ? f_231_85862_85912(((OperationCanceledException)ex)) : null) == _cancellationToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 85820, 86004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 85976, 85989);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 85820, 86004);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86020, 86141) || true) && (_analyzerExceptionFilter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 86020, 86141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86090, 86126);

                    return f_231_86097_86125(this, ex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 86020, 86141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86157, 86169);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 85633, 86180);

                System.Threading.CancellationToken
                f_231_85862_85912(System.OperationCanceledException
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 85862, 85912);
                    return return_v;
                }


                bool
                f_231_86097_86125(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, System.Exception
                arg)
                {
                    var return_v = this_param._analyzerExceptionFilter(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86097, 86125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 85633, 86180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 85633, 86180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic CreateAnalyzerExceptionDiagnostic(DiagnosticAnalyzer analyzer, Exception e, AnalysisContextInfo? info = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 86192, 87197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86353, 86392);

                var
                analyzerName = f_231_86372_86391(analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86406, 86464);

                var
                title = f_231_86418_86463()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86478, 86543);

                var
                messageFormat = f_231_86498_86542()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86557, 86694);

                var
                contextInformation = f_231_86582_86693(f_231_86582_86686(f_231_86594_86613(), f_231_86615_86651(info, e), f_231_86653_86685(analyzer)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86708, 86809);

                var
                messageArguments = new[] { analyzerName, f_231_86753_86775(f_231_86753_86764(e)), f_231_86777_86786(e), contextInformation }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86823, 86964);

                var
                description = f_231_86841_86963(f_231_86855_86910(), analyzerName, f_231_86926_86962(info, e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 86978, 87102);

                var
                descriptor = f_231_86995_87101(AnalyzerExceptionDiagnosticId, title, description, messageFormat)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 87116, 87186);

                return f_231_87123_87185(descriptor, f_231_87153_87166(), messageArguments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 86192, 87197);

                string
                f_231_86372_86391(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86372, 86391);
                    return return_v;
                }


                string
                f_231_86418_86463()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 86418, 86463);
                    return return_v;
                }


                string
                f_231_86498_86542()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerThrows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 86498, 86542);
                    return return_v;
                }


                string
                f_231_86594_86613()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 86594, 86613);
                    return return_v;
                }


                string
                f_231_86615_86651(Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?
                info, System.Exception
                e)
                {
                    var return_v = CreateDiagnosticDescription(info, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86615, 86651);
                    return return_v;
                }


                string
                f_231_86653_86685(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = CreateDisablingMessage(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86653, 86685);
                    return return_v;
                }


                string
                f_231_86582_86686(string
                separator, params string?[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86582, 86686);
                    return return_v;
                }


                string
                f_231_86582_86693(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86582, 86693);
                    return return_v;
                }


                System.Type
                f_231_86753_86764(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86753, 86764);
                    return return_v;
                }


                string
                f_231_86753_86775(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86753, 86775);
                    return return_v;
                }


                string
                f_231_86777_86786(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 86777, 86786);
                    return return_v;
                }


                string
                f_231_86855_86910()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerThrowsDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 86855, 86910);
                    return return_v;
                }


                string
                f_231_86926_86962(Microsoft.CodeAnalysis.Diagnostics.AnalysisContextInfo?
                info, System.Exception
                e)
                {
                    var return_v = CreateDiagnosticDescription(info, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86926, 86962);
                    return return_v;
                }


                string
                f_231_86841_86963(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86841, 86963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_231_86995_87101(string
                id, string
                title, string
                description, string
                messageFormat)
                {
                    var return_v = GetAnalyzerExceptionDiagnosticDescriptor(id, title, description, messageFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 86995, 87101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_231_87153_87166()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 87153, 87166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_231_87123_87185(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params string[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, (object?[])messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87123, 87185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 86192, 87197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 86192, 87197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CreateDiagnosticDescription(AnalysisContextInfo? info, Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 87209, 87855);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 87323, 87427) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 87323, 87427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 87373, 87412);

                    return f_231_87380_87411(e);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 87323, 87427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 87651, 87844);

                return f_231_87658_87843(f_231_87670_87689(), f_231_87708_87809(f_231_87722_87760(), (DynAbs.Tracing.TraceSender.Conditional_F1(231, 87762, 87775) || ((info.HasValue && DynAbs.Tracing.TraceSender.Conditional_F2(231, 87778, 87801)) || DynAbs.Tracing.TraceSender.Conditional_F3(231, 87804, 87808))) ? info.Value.GetContext() : null), f_231_87811_87842(e));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 87209, 87855);

                string
                f_231_87380_87411(System.Exception
                exception)
                {
                    var return_v = exception.CreateDiagnosticDescription();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87380, 87411);
                    return return_v;
                }


                string
                f_231_87670_87689()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 87670, 87689);
                    return return_v;
                }


                string
                f_231_87722_87760()
                {
                    var return_v = CodeAnalysisResources.ExceptionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 87722, 87760);
                    return return_v;
                }


                string
                f_231_87708_87809(string
                format, string?
                arg0)
                {
                    var return_v = string.Format(format, (object?)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87708, 87809);
                    return return_v;
                }


                string
                f_231_87811_87842(System.Exception
                exception)
                {
                    var return_v = exception.CreateDiagnosticDescription();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87811, 87842);
                    return return_v;
                }


                string
                f_231_87658_87843(string
                separator, params string?[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87658, 87843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 87209, 87855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 87209, 87855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string CreateDisablingMessage(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 87867, 88674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 87965, 88065);

                var
                diagnosticIds = f_231_87985_88064(ImmutableSortedSet<string>.Empty, f_231_88031_88063())
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88115, 88281);
                        foreach (var diagnostic in f_231_88142_88171_I(f_231_88142_88171(analyzer)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 88115, 88281);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88213, 88262);

                            diagnosticIds = f_231_88229_88261(diagnosticIds, f_231_88247_88260(diagnostic));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 88115, 88281);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 167);
                    }
                }
                catch (Exception e) when (f_231_88336_88364(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(231, 88310, 88435);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(231, 88310, 88435);
                    // Intentionally empty
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88451, 88535) || true) && (f_231_88455_88476(diagnosticIds))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 88451, 88535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88510, 88520);

                    return "";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 88451, 88535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88551, 88663);

                return f_231_88558_88662(f_231_88572_88627(), f_231_88629_88661(", ", diagnosticIds));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 87867, 88674);

                System.StringComparer
                f_231_88031_88063()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88031, 88063);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableSortedSet<string>
                f_231_87985_88064(System.Collections.Immutable.ImmutableSortedSet<string>
                this_param, System.StringComparer
                comparer)
                {
                    var return_v = this_param.WithComparer((System.Collections.Generic.IComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 87985, 88064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_231_88142_88171(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.SupportedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88142, 88171);
                    return return_v;
                }


                string
                f_231_88247_88260(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88247, 88260);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableSortedSet<string>
                f_231_88229_88261(System.Collections.Immutable.ImmutableSortedSet<string>
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88229, 88261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_231_88142_88171_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88142, 88171);
                    return return_v;
                }


                bool
                f_231_88336_88364(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndCatch(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88336, 88364);
                    return return_v;
                }


                bool
                f_231_88455_88476(System.Collections.Immutable.ImmutableSortedSet<string>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88455, 88476);
                    return return_v;
                }


                string
                f_231_88572_88627()
                {
                    var return_v = CodeAnalysisResources.DisableAnalyzerDiagnosticsMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88572, 88627);
                    return return_v;
                }


                string
                f_231_88629_88661(string
                separator, System.Collections.Immutable.ImmutableSortedSet<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88629, 88661);
                    return return_v;
                }


                string
                f_231_88558_88662(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88558, 88662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 87867, 88674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 87867, 88674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Diagnostic CreateDriverExceptionDiagnostic(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 88686, 89369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88782, 88838);

                var
                title = f_231_88794_88837()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88852, 88915);

                var
                messageFormat = f_231_88872_88914()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 88929, 88996);

                var
                messageArguments = new[] { f_231_88960_88982(f_231_88960_88971(e)), f_231_88984_88993(e) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 89010, 89130);

                var
                description = f_231_89028_89129(f_231_89042_89095(), f_231_89097_89128(e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 89144, 89274);

                var
                descriptor = f_231_89161_89273(AnalyzerDriverExceptionDiagnosticId, title, description, messageFormat)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 89288, 89358);

                return f_231_89295_89357(descriptor, f_231_89325_89338(), messageArguments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 88686, 89369);

                string
                f_231_88794_88837()
                {
                    var return_v = CodeAnalysisResources.AnalyzerDriverFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88794, 88837);
                    return return_v;
                }


                string
                f_231_88872_88914()
                {
                    var return_v = CodeAnalysisResources.AnalyzerDriverThrows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88872, 88914);
                    return return_v;
                }


                System.Type
                f_231_88960_88971(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88960, 88971);
                    return return_v;
                }


                string
                f_231_88960_88982(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 88960, 88982);
                    return return_v;
                }


                string
                f_231_88984_88993(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 88984, 88993);
                    return return_v;
                }


                string
                f_231_89042_89095()
                {
                    var return_v = CodeAnalysisResources.AnalyzerDriverThrowsDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 89042, 89095);
                    return return_v;
                }


                string
                f_231_89097_89128(System.Exception
                exception)
                {
                    var return_v = exception.CreateDiagnosticDescription();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 89097, 89128);
                    return return_v;
                }


                string
                f_231_89028_89129(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 89028, 89129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_231_89161_89273(string
                id, string
                title, string
                description, string
                messageFormat)
                {
                    var return_v = GetAnalyzerExceptionDiagnosticDescriptor(id, title, description, messageFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 89161, 89273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_231_89325_89338()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 89325, 89338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_231_89295_89357(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params string[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, (object?[])messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 89295, 89357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 88686, 89369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 88686, 89369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticDescriptor GetAnalyzerExceptionDiagnosticDescriptor(string? id = null, string? title = null, string? description = null, string? messageFormat = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 89381, 90635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 89971, 90008);

                id ??= AnalyzerExceptionDiagnosticId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90022, 90078);

                title ??= f_231_90032_90077();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90092, 90155);

                messageFormat ??= f_231_90110_90154();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90169, 90231);

                description ??= f_231_90185_90230();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90247, 90624);

                return f_231_90254_90623(id, title, messageFormat, description: description, category: DiagnosticCategory, defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, customTags: WellKnownDiagnosticTags.AnalyzerException);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 89381, 90635);

                string
                f_231_90032_90077()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90032, 90077);
                    return return_v;
                }


                string
                f_231_90110_90154()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerThrows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90110, 90154);
                    return return_v;
                }


                string
                f_231_90185_90230()
                {
                    var return_v = CodeAnalysisResources.CompilerAnalyzerFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90185, 90230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_231_90254_90623(string
                id, string
                title, string
                messageFormat, string
                description, string
                category, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, params string[]
                customTags)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, description: description, category: category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 90254, 90623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 89381, 90635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 89381, 90635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAnalyzerExceptionDiagnostic(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 90647, 91190);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90745, 91150) || true) && (f_231_90749_90762(diagnostic) == AnalyzerExceptionDiagnosticId || (DynAbs.Tracing.TraceSender.Expression_False(231, 90749, 90851) || f_231_90799_90812(diagnostic) == AnalyzerDriverExceptionDiagnosticId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 90745, 91150);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90885, 91135);
                        foreach (var tag in f_231_90905_90937_I(f_231_90905_90937(f_231_90905_90926(diagnostic))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 90885, 91135);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 90979, 91116) || true) && (tag == WellKnownDiagnosticTags.AnalyzerException)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 90979, 91116);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 91081, 91093);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(231, 90979, 91116);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 90885, 91135);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 251);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 90745, 91150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 91166, 91179);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 90647, 91190);

                string
                f_231_90749_90762(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90749, 90762);
                    return return_v;
                }


                string
                f_231_90799_90812(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90799, 90812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_231_90905_90926(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90905, 90926);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_231_90905_90937(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 90905, 90937);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_231_90905_90937_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 90905, 90937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 90647, 91190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 90647, 91190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool AreEquivalentAnalyzerExceptionDiagnostics(Diagnostic exceptionDiagnostic, Diagnostic other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 91202, 92403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92008, 92073);

                f_231_92008_92072(f_231_92021_92071(exceptionDiagnostic));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92089, 92192) || true) && (!f_231_92094_92130(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 92089, 92192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92164, 92177);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 92089, 92192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92208, 92392);

                return f_231_92215_92237(exceptionDiagnostic) == f_231_92241_92249(other) && (DynAbs.Tracing.TraceSender.Expression_True(231, 92215, 92316) && f_231_92270_92298(exceptionDiagnostic) == f_231_92302_92316(other)) && (DynAbs.Tracing.TraceSender.Expression_True(231, 92215, 92391) && f_231_92337_92369(exceptionDiagnostic) == f_231_92373_92391(other));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 91202, 92403);

                bool
                f_231_92021_92071(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = IsAnalyzerExceptionDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92021, 92071);
                    return return_v;
                }


                int
                f_231_92008_92072(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92008, 92072);
                    return 0;
                }


                bool
                f_231_92094_92130(Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = IsAnalyzerExceptionDiagnostic(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92094, 92130);
                    return return_v;
                }


                string
                f_231_92215_92237(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 92215, 92237);
                    return return_v;
                }


                string
                f_231_92241_92249(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 92241, 92249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_231_92270_92298(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 92270, 92298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_231_92302_92316(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 92302, 92316);
                    return return_v;
                }


                string
                f_231_92337_92369(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.GetMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92337, 92369);
                    return return_v;
                }


                string
                f_231_92373_92391(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.GetMessage();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92373, 92391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 91202, 92403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 91202, 92403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSupportedDiagnostic(DiagnosticAnalyzer analyzer, Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 92415, 92843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92526, 92568);

                f_231_92526_92567(_isCompilerAnalyzer != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92584, 92721) || true) && (diagnostic is DiagnosticWithInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 92584, 92721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92694, 92706);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 92584, 92721);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 92737, 92832);

                return f_231_92744_92831(_analyzerManager, analyzer, diagnostic, _isCompilerAnalyzer, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 92415, 92843);

                int
                f_231_92526_92567(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92526, 92567);
                    return 0;
                }


                bool
                f_231_92744_92831(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                isCompilerAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.IsSupportedDiagnostic(analyzer, diagnostic, isCompilerAnalyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 92744, 92831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 92415, 92843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 92415, 92843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Action<Diagnostic> GetAddDiagnostic(ISymbol contextSymbol, ImmutableArray<SyntaxReference> cachedDeclaringReferences, DiagnosticAnalyzer analyzer, Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 92855, 93438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 93136, 93427);

                return f_231_93143_93426(contextSymbol, cachedDeclaringReferences, f_231_93202_93213(), analyzer, _addNonCategorizedDiagnostic, _addCategorizedLocalDiagnostic, _addCategorizedNonLocalDiagnostic, getTopMostNodeForAnalysis, _shouldSuppressGeneratedCodeDiagnostic, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 92855, 93438);

                Microsoft.CodeAnalysis.Compilation
                f_231_93202_93213()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 93202, 93213);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.Diagnostic>
                f_231_93143_93426(Microsoft.CodeAnalysis.ISymbol
                contextSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                cachedDeclaringReferences, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, Microsoft.CodeAnalysis.SyntaxNode>
                getTopMostNodeForAnalysis, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = GetAddDiagnostic(contextSymbol, cachedDeclaringReferences, compilation, analyzer, addNonCategorizedDiagnostic, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, getTopMostNodeForAnalysis, shouldSuppressGeneratedCodeDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 93143, 93426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 92855, 93438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 92855, 93438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Action<Diagnostic> GetAddDiagnostic(
                    ISymbol contextSymbol,
                    ImmutableArray<SyntaxReference> cachedDeclaringReferences,
                    Compilation compilation,
                    DiagnosticAnalyzer analyzer,
                    Action<Diagnostic>? addNonCategorizedDiagnostic,
                    Action<Diagnostic, DiagnosticAnalyzer, bool>? addCategorizedLocalDiagnostic,
                    Action<Diagnostic, DiagnosticAnalyzer>? addCategorizedNonLocalDiagnostic,
                    Func<ISymbol, SyntaxReference, Compilation, CancellationToken, SyntaxNode> getTopMostNodeForAnalysis,
                    Func<Diagnostic, DiagnosticAnalyzer, Compilation, CancellationToken, bool> shouldSuppressGeneratedCodeDiagnostic,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 93450, 95741);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 94245, 95730);

                return diagnostic =>
                            {
                                if (shouldSuppressGeneratedCodeDiagnostic(diagnostic, analyzer, compilation, cancellationToken))
                                {
                                    return;
                                }

                                if (addCategorizedLocalDiagnostic == null)
                                {
                                    Debug.Assert(addNonCategorizedDiagnostic != null);
                                    addNonCategorizedDiagnostic(diagnostic);
                                    return;
                                }

                                Debug.Assert(addNonCategorizedDiagnostic == null);
                                Debug.Assert(addCategorizedNonLocalDiagnostic != null);

                                if (diagnostic.Location.IsInSource)
                                {
                                    foreach (var syntaxRef in cachedDeclaringReferences)
                                    {
                                        if (syntaxRef.SyntaxTree == diagnostic.Location.SourceTree)
                                        {
                                            var syntax = getTopMostNodeForAnalysis(contextSymbol, syntaxRef, compilation, cancellationToken);
                                            if (diagnostic.Location.SourceSpan.IntersectsWith(syntax.FullSpan))
                                            {
                                                addCategorizedLocalDiagnostic(diagnostic, analyzer, false);
                                                return;
                                            }
                                        }
                                    }
                                }

                                addCategorizedNonLocalDiagnostic(diagnostic, analyzer);
                            };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 93450, 95741);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 93450, 95741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 93450, 95741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Action<Diagnostic> GetAddCompilationDiagnostic(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 95753, 96451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 95861, 96440);

                return diagnostic =>
                            {
                                if (_shouldSuppressGeneratedCodeDiagnostic(diagnostic, analyzer, Compilation, _cancellationToken))
                                {
                                    return;
                                }

                                if (_addCategorizedNonLocalDiagnostic == null)
                                {
                                    Debug.Assert(_addNonCategorizedDiagnostic != null);
                                    _addNonCategorizedDiagnostic(diagnostic);
                                    return;
                                }

                                _addCategorizedNonLocalDiagnostic(diagnostic, analyzer);
                            };
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 95753, 96451);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 95753, 96451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 95753, 96451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerDiagnosticReporter GetAddSemanticDiagnostic(SyntaxTree tree, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 96463, 96937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 96593, 96926);

                return f_231_96600_96925(f_231_96639_96671(tree), span: null, f_231_96685_96696(), analyzer, isSyntaxDiagnostic: false, _addNonCategorizedDiagnostic, _addCategorizedLocalDiagnostic, _addCategorizedNonLocalDiagnostic, _shouldSuppressGeneratedCodeDiagnostic, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 96463, 96937);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_231_96639_96671(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 96639, 96671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_96685_96696()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 96685, 96696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_96600_96925(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                contextFile, Microsoft.CodeAnalysis.Text.TextSpan?
                span, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                isSyntaxDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = AnalyzerDiagnosticReporter.GetInstance(contextFile, span: span, compilation, analyzer, isSyntaxDiagnostic: isSyntaxDiagnostic, addNonCategorizedDiagnostic, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, shouldSuppressGeneratedCodeDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 96600, 96925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 96463, 96937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 96463, 96937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerDiagnosticReporter GetAddSemanticDiagnostic(SyntaxTree tree, TextSpan? span, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 96949, 97433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 97095, 97422);

                return f_231_97102_97421(f_231_97141_97173(tree), span, f_231_97181_97192(), analyzer, isSyntaxDiagnostic: false, _addNonCategorizedDiagnostic, _addCategorizedLocalDiagnostic, _addCategorizedNonLocalDiagnostic, _shouldSuppressGeneratedCodeDiagnostic, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 96949, 97433);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_231_97141_97173(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 97141, 97173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_231_97181_97192()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 97181, 97192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_97102_97421(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                contextFile, Microsoft.CodeAnalysis.Text.TextSpan?
                span, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                isSyntaxDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = AnalyzerDiagnosticReporter.GetInstance(contextFile, span, compilation, analyzer, isSyntaxDiagnostic: isSyntaxDiagnostic, addNonCategorizedDiagnostic, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, shouldSuppressGeneratedCodeDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 97102, 97421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 96949, 97433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 96949, 97433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerDiagnosticReporter GetAddSyntaxDiagnostic(SourceOrAdditionalFile file, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 97445, 97900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 97585, 97889);

                return f_231_97592_97888(file, span: null, f_231_97649_97660(), analyzer, isSyntaxDiagnostic: true, _addNonCategorizedDiagnostic, _addCategorizedLocalDiagnostic, _addCategorizedNonLocalDiagnostic, _shouldSuppressGeneratedCodeDiagnostic, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 97445, 97900);

                Microsoft.CodeAnalysis.Compilation
                f_231_97649_97660()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 97649, 97660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor.AnalyzerDiagnosticReporter
                f_231_97592_97888(Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                contextFile, Microsoft.CodeAnalysis.Text.TextSpan?
                span, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                isSyntaxDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic>?
                addNonCategorizedDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>?
                addCategorizedLocalDiagnostic, System.Action<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>?
                addCategorizedNonLocalDiagnostic, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Compilation, System.Threading.CancellationToken, bool>
                shouldSuppressGeneratedCodeDiagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = AnalyzerDiagnosticReporter.GetInstance(contextFile, span: span, compilation, analyzer, isSyntaxDiagnostic: isSyntaxDiagnostic, addNonCategorizedDiagnostic, addCategorizedLocalDiagnostic, addCategorizedNonLocalDiagnostic, shouldSuppressGeneratedCodeDiagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 97592, 97888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 97445, 97900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 97445, 97900);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ShouldExecuteAction(AnalyzerStateData? analyzerState, AnalyzerAction action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 97912, 98125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98033, 98114);

                return analyzerState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 98040, 98113) || !f_231_98066_98113(f_231_98066_98096(analyzerState), action));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 97912, 98125);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                f_231_98066_98096(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 98066, 98096);
                    return return_v;
                }


                bool
                f_231_98066_98113(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerAction
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 98066, 98113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 97912, 98125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 97912, 98125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldExecuteNode(SyntaxNodeAnalyzerStateData? analyzerState, SyntaxNode node, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 98137, 98790);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98344, 98478) || true) && (analyzerState != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 98348, 98416) && f_231_98373_98416(f_231_98373_98401(analyzerState), node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 98344, 98478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98450, 98463);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 98344, 98478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98568, 98751) || true) && (f_231_98572_98616(this, analyzer) && (DynAbs.Tracing.TraceSender.Expression_True(231, 98572, 98689) && f_231_98637_98689(this, f_231_98662_98677(node), f_231_98679_98688(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 98568, 98751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98723, 98736);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 98568, 98751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 98767, 98779);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 98137, 98790);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                f_231_98373_98401(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.SyntaxNodeAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 98373, 98401);
                    return return_v;
                }


                bool
                f_231_98373_98416(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 98373, 98416);
                    return return_v;
                }


                bool
                f_231_98572_98616(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 98572, 98616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_98662_98677(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 98662, 98677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_231_98679_98688(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 98679, 98688);
                    return return_v;
                }


                bool
                f_231_98637_98689(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                arg1, Microsoft.CodeAnalysis.Text.TextSpan
                arg2)
                {
                    var return_v = this_param._isGeneratedCodeLocation(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 98637, 98689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 98137, 98790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 98137, 98790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldExecuteOperation(OperationAnalyzerStateData? analyzerState, IOperation operation, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 98802, 99543);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99023, 99167) || true) && (analyzerState != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 99027, 99105) && f_231_99052_99105(f_231_99052_99085(analyzerState), operation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 99023, 99167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99139, 99152);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 99023, 99167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99269, 99504) || true) && (f_231_99273_99289(operation) != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 99273, 99345) && f_231_99301_99345(this, analyzer)) && (DynAbs.Tracing.TraceSender.Expression_True(231, 99273, 99442) && f_231_99366_99442(this, f_231_99391_99418(f_231_99391_99407(operation)), f_231_99420_99441(f_231_99420_99436(operation)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 99269, 99504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99476, 99489);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 99269, 99504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99520, 99532);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 98802, 99543);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                f_231_99052_99085(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.OperationAnalyzerStateData
                this_param)
                {
                    var return_v = this_param.ProcessedOperations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99052, 99085);
                    return return_v;
                }


                bool
                f_231_99052_99105(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.IOperation>
                this_param, Microsoft.CodeAnalysis.IOperation
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 99052, 99105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_231_99273_99289(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99273, 99289);
                    return return_v;
                }


                bool
                f_231_99301_99345(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param._shouldSkipAnalysisOnGeneratedCode(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 99301, 99345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_231_99391_99407(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99391, 99407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_99391_99418(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99391, 99418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_231_99420_99436(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99420, 99436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_231_99420_99441(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 99420, 99441);
                    return return_v;
                }


                bool
                f_231_99366_99442(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                arg1, Microsoft.CodeAnalysis.Text.TextSpan
                arg2)
                {
                    var return_v = this_param._isGeneratedCodeLocation(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 99366, 99442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 98802, 99543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 98802, 99543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SetCurrentNode(SyntaxNodeAnalyzerStateData? analyzerState, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 99555, 99838);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99675, 99827) || true) && (analyzerState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 99675, 99827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99734, 99761);

                    f_231_99734_99760(node != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99779, 99812);

                    analyzerState.CurrentNode = node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 99675, 99827);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 99555, 99838);

                int
                f_231_99734_99760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 99734, 99760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 99555, 99838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 99555, 99838);
            }
        }

        private static void SetCurrentOperation(OperationAnalyzerStateData? analyzerState, IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 99850, 100157);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 99979, 100146) || true) && (analyzerState != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 99979, 100146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100038, 100070);

                    f_231_100038_100069(operation != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100088, 100131);

                    analyzerState.CurrentOperation = operation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 99979, 100146);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 99850, 100157);

                int
                f_231_100038_100069(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 100038, 100069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 99850, 100157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 99850, 100157);
            }
        }

        private static bool TryStartProcessingEvent(
                    CompilationEvent nonSymbolCompilationEvent,
                    DiagnosticAnalyzer analyzer,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    out AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 100169, 100800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100473, 100551);

                f_231_100473_100550(nonSymbolCompilationEvent is not SymbolDeclaredCompilationEvent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100565, 100612);

                f_231_100565_100611(f_231_100578_100610(analysisScope, analyzer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100628, 100649);

                analyzerState = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 100663, 100789);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 100670, 100788) || f_231_100695_100788(analysisState, nonSymbolCompilationEvent, analyzer, out analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 100169, 100800);

                int
                f_231_100473_100550(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 100473, 100550);
                    return 0;
                }


                bool
                f_231_100578_100610(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 100578, 100610);
                    return return_v;
                }


                int
                f_231_100565_100611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 100565, 100611);
                    return 0;
                }


                bool
                f_231_100695_100788(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartProcessingEvent(compilationEvent, analyzer, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 100695, 100788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 100169, 100800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 100169, 100800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryStartSyntaxAnalysis(SourceOrAdditionalFile file,
                    DiagnosticAnalyzer analyzer,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    out AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 100812, 101299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101086, 101133);

                f_231_101086_101132(f_231_101099_101131(analysisScope, analyzer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101149, 101170);

                analyzerState = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101184, 101288);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 101191, 101287) || f_231_101216_101287(analysisState, file, analyzer, out analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 100812, 101299);

                bool
                f_231_101099_101131(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101099, 101131);
                    return return_v;
                }


                int
                f_231_101086_101132(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101086, 101132);
                    return 0;
                }


                bool
                f_231_101216_101287(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartSyntaxAnalysis(file, analyzer, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101216, 101287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 100812, 101299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 100812, 101299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryStartAnalyzingSymbol(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    out AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 101311, 101803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101587, 101634);

                f_231_101587_101633(f_231_101600_101632(analysisScope, analyzer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101650, 101671);

                analyzerState = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 101685, 101792);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 101692, 101791) || f_231_101717_101791(analysisState, symbol, analyzer, out analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 101311, 101803);

                bool
                f_231_101600_101632(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101600, 101632);
                    return return_v;
                }


                int
                f_231_101587_101633(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101587, 101633);
                    return 0;
                }


                bool
                f_231_101717_101791(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartAnalyzingSymbol(symbol, analyzer, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 101717, 101791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 101311, 101803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 101311, 101803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryStartSymbolEndAnalysis(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    AnalysisState? analysisState,
                    out AnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 101815, 102206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102051, 102072);

                analyzerState = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102086, 102195);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 102093, 102194) || f_231_102118_102194(analysisState, symbol, analyzer, out analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 101815, 102206);

                bool
                f_231_102118_102194(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartSymbolEndAnalysis(symbol, analyzer, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 102118, 102194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 101815, 102206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 101815, 102206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryStartAnalyzingDeclaration(
                    ISymbol symbol,
                    int declarationIndex,
                    DiagnosticAnalyzer analyzer,
                    AnalysisScope analysisScope,
                    AnalysisState? analysisState,
                    out DeclarationAnalyzerStateData? analyzerState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 102218, 102784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102545, 102592);

                f_231_102545_102591(f_231_102558_102590(analysisScope, analyzer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102608, 102629);

                analyzerState = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102643, 102773);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 102650, 102772) || f_231_102675_102772(analysisState, symbol, declarationIndex, analyzer, out analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 102218, 102784);

                bool
                f_231_102558_102590(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.Contains(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 102558, 102590);
                    return return_v;
                }


                int
                f_231_102545_102591(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 102545, 102591);
                    return 0;
                }


                bool
                f_231_102675_102772(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartAnalyzingDeclaration(symbol, declarationIndex, analyzer, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 102675, 102772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 102218, 102784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 102218, 102784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEventComplete(CompilationEvent compilationEvent, DiagnosticAnalyzer analyzer, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 102796, 103051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 102950, 103040);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 102957, 103039) || f_231_102982_103039(analysisState, compilationEvent, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 102796, 103051);

                bool
                f_231_102982_103039(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.IsEventComplete(compilationEvent, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 102982, 103039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 102796, 103051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 102796, 103051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSymbolComplete(ISymbol symbol, DiagnosticAnalyzer analyzer, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 103063, 103291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 103199, 103280);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 103206, 103279) || f_231_103231_103279(analysisState, symbol, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 103063, 103291);

                bool
                f_231_103231_103279(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.IsSymbolComplete(symbol, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 103231, 103279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 103063, 103291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 103063, 103291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSymbolEndAnalysisComplete(ISymbol symbol, DiagnosticAnalyzer analyzer, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 103303, 103553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 103450, 103542);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 103457, 103541) || f_231_103482_103541(analysisState, symbol, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 103303, 103553);

                bool
                f_231_103482_103541(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.IsSymbolEndAnalysisComplete(symbol, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 103482, 103541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 103303, 103553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 103303, 103553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDeclarationComplete(ISymbol symbol, int declarationIndex, DiagnosticAnalyzer analyzer, AnalysisState? analysisState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(231, 103565, 103843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 103728, 103832);

                return analysisState == null || (DynAbs.Tracing.TraceSender.Expression_False(231, 103735, 103831) || f_231_103760_103831(analysisState, symbol, declarationIndex, analyzer));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(231, 103565, 103843);

                bool
                f_231_103760_103831(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.IsDeclarationComplete(symbol, declarationIndex, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 103760, 103831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 103565, 103843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 103565, 103843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TimeSpan ResetAnalyzerExecutionTime(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 103855, 104232);
                System.Runtime.CompilerServices.StrongBox<long> executionTime = default(System.Runtime.CompilerServices.StrongBox<long>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 103953, 104001);

                f_231_103953_104000(_analyzerExecutionTimeMap != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104015, 104158) || true) && (!f_231_104020_104088(_analyzerExecutionTimeMap, analyzer, out executionTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 104015, 104158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104122, 104143);

                    return TimeSpan.Zero;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 104015, 104158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104174, 104221);

                return TimeSpan.FromTicks(executionTime.Value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 103855, 104232);

                int
                f_231_103953_104000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 103953, 104000);
                    return 0;
                }


                bool
                f_231_104020_104088(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Runtime.CompilerServices.StrongBox<long>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, out System.Runtime.CompilerServices.StrongBox<long>
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104020, 104088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 103855, 104232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 103855, 104232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ControlFlowGraph GetControlFlowGraphImpl(IOperation operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 104244, 104722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104339, 104378);

                f_231_104339_104377(f_231_104352_104368(operation) == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104394, 104601) || true) && (_lazyControlFlowGraphMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 104394, 104601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104464, 104586);

                    f_231_104464_104585(ref _lazyControlFlowGraphMap, f_231_104522_104578(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 104394, 104601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104617, 104711);

                return f_231_104624_104710(_lazyControlFlowGraphMap, operation, op => ControlFlowGraphBuilder.Create(op));
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 104244, 104722);

                Microsoft.CodeAnalysis.IOperation?
                f_231_104352_104368(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 104352, 104368);
                    return return_v;
                }


                int
                f_231_104339_104377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104339, 104377);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                f_231_104522_104578()
                {
                    var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104522, 104578);
                    return return_v;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
                f_231_104464_104585(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
                location1, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                value, System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104464, 104585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                f_231_104624_104710(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param, Microsoft.CodeAnalysis.IOperation
                key, System.Func<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104624, 104710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 104244, 104722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 104244, 104722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsAnalyzerSuppressedForSymbol(DiagnosticAnalyzer analyzer, ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 104734, 105164);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104846, 105125);
                    foreach (var location in f_231_104871_104887_I(f_231_104871_104887(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 104846, 105125);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 104921, 105110) || true) && (f_231_104925_104944(location) != null && (DynAbs.Tracing.TraceSender.Expression_True(231, 104925, 105036) && !f_231_104978_105036(this, analyzer, f_231_105016_105035(location))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 104921, 105110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105078, 105091);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 104921, 105110);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(231, 104846, 105125);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105141, 105153);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 104734, 105164);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_231_104871_104887(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 104871, 104887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_231_104925_104944(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 104925, 104944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_231_105016_105035(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 105016, 105035);
                    return return_v;
                }


                bool
                f_231_104978_105036(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.IsAnalyzerSuppressedForTree(analyzer, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104978, 105036);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_231_104871_104887_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 104871, 104887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 104734, 105164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 104734, 105164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void OnOperationBlockActionsExecuted(ImmutableArray<IOperation> operationBlocks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(231, 105176, 105982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105661, 105971) || true) && (f_231_105665_105696_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyControlFlowGraphMap, 231, 105665, 105696)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 105661, 105971);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105734, 105956);
                        foreach (var operationBlock in f_231_105765_105780_I(operationBlocks))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(231, 105734, 105956);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105822, 105867);

                            var
                            root = f_231_105833_105866(operationBlock)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(231, 105889, 105937);

                            f_231_105889_105936(_lazyControlFlowGraphMap, root, out _);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(231, 105734, 105956);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(231, 1, 223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(231, 1, 223);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(231, 105661, 105971);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(231, 105176, 105982);

                int?
                f_231_105665_105696_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(231, 105665, 105696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_231_105833_105866(Microsoft.CodeAnalysis.IOperation
                operation)
                {
                    var return_v = operation.GetRootOperation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 105833, 105866);
                    return return_v;
                }


                bool
                f_231_105889_105936(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.IOperation, Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph>
                this_param, Microsoft.CodeAnalysis.IOperation
                key, out Microsoft.CodeAnalysis.FlowAnalysis.ControlFlowGraph
                value)
                {
                    var return_v = this_param.TryRemove(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 105889, 105936);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                f_231_105765_105780_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 105765, 105780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(231, 105176, 105982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(231, 105176, 105982);
            }
        }

        static Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory
        f_231_13934_13979()
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationAnalysisValueProviderFactory();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(231, 13934, 13979);
            return return_v;
        }

    }
}
