// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public class CompilationWithAnalyzers
    {
        private readonly Compilation _compilation;

        private readonly CompilationData _compilationData;

        private readonly ImmutableArray<DiagnosticAnalyzer> _analyzers;

        private readonly CompilationWithAnalyzersOptions _analysisOptions;

        private readonly CancellationToken _cancellationToken;

        private readonly AnalyzerManager _analyzerManager;

        private readonly ObjectPool<AnalyzerDriver> _driverPool;

        private readonly AnalysisState _analysisState;

        private readonly AnalysisResultBuilder _analysisResultBuilder;

        private readonly ConcurrentSet<Diagnostic> _exceptionDiagnostics;

        private readonly object _executingTasksLock;

        private readonly Dictionary<SourceOrAdditionalFile, Tuple<Task, CancellationTokenSource>>? _executingConcurrentTreeTasksOpt;

        private Tuple<Task, CancellationTokenSource>? _executingCompilationOrNonConcurrentTreeTask;

        private int _currentToken;

        private readonly Dictionary<Task, int>? _concurrentTreeTaskTokensOpt;

        private readonly ObjectPool<AsyncQueue<CompilationEvent>> _eventQueuePool;

        private static readonly AsyncQueue<CompilationEvent> s_EmptyEventQueue;

        public Compilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 4144, 4159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 4147, 4159);
                    return _compilation; DynAbs.Tracing.TraceSender.TraceExitMethod(249, 4144, 4159);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 4144, 4159);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 4144, 4159);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<DiagnosticAnalyzer> Analyzers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 4325, 4338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 4328, 4338);
                    return _analyzers; DynAbs.Tracing.TraceSender.TraceExitMethod(249, 4325, 4338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 4325, 4338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 4325, 4338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompilationWithAnalyzersOptions AnalysisOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 4507, 4526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 4510, 4526);
                    return _analysisOptions; DynAbs.Tracing.TraceSender.TraceExitMethod(249, 4507, 4526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 4507, 4526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 4507, 4526);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 4830, 4851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 4833, 4851);
                    return _cancellationToken; DynAbs.Tracing.TraceSender.TraceExitMethod(249, 4830, 4851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 4830, 4851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 4830, 4851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompilationWithAnalyzers(Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, AnalyzerOptions? options, CancellationToken cancellationToken)
        : this(f_249_5559_5570_C(compilation), analyzers, f_249_5583_5779(options, onAnalyzerException: null, analyzerExceptionFilter: null, concurrentAnalysis: true, logAnalyzerExecutionTime: true, reportSuppressedDiagnostics: false), cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(249, 5373, 5821);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(249, 5373, 5821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 5373, 5821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 5373, 5821);
            }
        }

        public CompilationWithAnalyzers(Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, CompilationWithAnalyzersOptions analysisOptions)
        : this(f_249_6415_6426_C(compilation), analyzers, analysisOptions, cancellationToken: CancellationToken.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(249, 6243, 6520);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(249, 6243, 6520);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 6243, 6520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 6243, 6520);
            }
        }

        private CompilationWithAnalyzers(Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, CompilationWithAnalyzersOptions analysisOptions, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(249, 6532, 8290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 760, 772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 816, 832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 965, 981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 1089, 1105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 1289, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 1803, 1817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 2084, 2106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 2300, 2355);
                this._exceptionDiagnostics = f_249_2324_2355(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 2561, 2595);
                this._executingTasksLock = f_249_2583_2595(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 2697, 2729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 2786, 2830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 3276, 3293);
                this._currentToken = 0; DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 3478, 3506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 3693, 3797);
                this._eventQueuePool = f_249_3711_3797(() => new AsyncQueue<CompilationEvent>()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 6746, 6803);

                f_249_6746_6802(compilation, analyzers, analysisOptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 6819, 7122);

                compilation = f_249_6833_7121(f_249_6833_7052(f_249_6833_6972(compilation
                , f_249_6875_6971(f_249_6875_6894(compilation), f_249_6927_6970(analysisOptions))), f_249_7017_7051()), f_249_7086_7120());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7136, 7163);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7177, 7200);

                _analyzers = analyzers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7214, 7249);

                _analysisOptions = analysisOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7263, 7302);

                _cancellationToken = cancellationToken;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7318, 7371);

                _compilationData = f_249_7337_7370(_compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7385, 7493);

                _analysisState = f_249_7402_7492(analyzers, f_249_7431_7469(_compilationData), f_249_7471_7491(_compilation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7507, 7694);

                _analysisResultBuilder = f_249_7532_7693(f_249_7558_7598(analysisOptions), analyzers, f_249_7611_7652_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_249_7611_7635(_analysisOptions), 249, 7611, 7652)?.AdditionalFiles) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?>(249, 7611, 7692) ?? ImmutableArray<AdditionalText>.Empty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7708, 7758);

                _analyzerManager = f_249_7727_7757(analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7772, 7924);

                _driverPool = f_249_7786_7923(() => _compilation.CreateAnalyzerDriver(analyzers, _analyzerManager, severityFilter: SeverityFilter.None));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 7938, 8096);

                _executingConcurrentTreeTasksOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(249, 7973, 8007) || ((f_249_7973_8007(analysisOptions) && DynAbs.Tracing.TraceSender.Conditional_F2(249, 8010, 8088)) || DynAbs.Tracing.TraceSender.Conditional_F3(249, 8091, 8095))) ? f_249_8010_8088() : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8110, 8213);

                _concurrentTreeTaskTokensOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(249, 8141, 8175) || ((f_249_8141_8175(analysisOptions) && DynAbs.Tracing.TraceSender.Conditional_F2(249, 8178, 8205)) || DynAbs.Tracing.TraceSender.Conditional_F3(249, 8208, 8212))) ? f_249_8178_8205() : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8227, 8279);

                _executingCompilationOrNonConcurrentTreeTask = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(249, 6532, 8290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 6532, 8290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 6532, 8290);
            }
        }

        private static void VerifyArguments(Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, CompilationWithAnalyzersOptions analysisOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 8371, 8900);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8551, 8676) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 8551, 8676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8608, 8661);

                    throw f_249_8614_8660(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 8551, 8676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8692, 8825) || true) && (analysisOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 8692, 8825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8753, 8810);

                    throw f_249_8759_8809(nameof(analysisOptions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 8692, 8825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 8841, 8889);

                f_249_8841_8888(analyzers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 8371, 8900);

                System.ArgumentNullException
                f_249_8614_8660(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 8614, 8660);
                    return return_v;
                }


                System.ArgumentNullException
                f_249_8759_8809(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 8759, 8809);
                    return return_v;
                }


                int
                f_249_8841_8888(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    VerifyAnalyzersArgumentForStaticApis(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 8841, 8888);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 8371, 8900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 8371, 8900);
            }
        }

        private static void VerifyAnalyzersArgumentForStaticApis(ImmutableArray<DiagnosticAnalyzer> analyzers, bool allowDefaultOrEmpty = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 8912, 9829);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9073, 9355) || true) && (analyzers.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 9073, 9355);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9137, 9228) || true) && (allowDefaultOrEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 9137, 9228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9202, 9209);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 9137, 9228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9248, 9340);

                    throw f_249_9254_9339(f_249_9276_9319(), nameof(analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 9073, 9355);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9371, 9551) || true) && (analyzers.Any(a => a == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 9371, 9551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9438, 9536);

                    throw f_249_9444_9535(f_249_9466_9515(), nameof(analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 9371, 9551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9567, 9818) || true) && (analyzers.Distinct().Length != analyzers.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 9567, 9818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9706, 9803);

                    throw f_249_9712_9802(f_249_9734_9782(), nameof(analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 9567, 9818);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 8912, 9829);

                string
                f_249_9276_9319()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 9276, 9319);
                    return return_v;
                }


                System.ArgumentException
                f_249_9254_9339(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 9254, 9339);
                    return return_v;
                }


                string
                f_249_9466_9515()
                {
                    var return_v = CodeAnalysisResources.ArgumentElementCannotBeNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 9466, 9515);
                    return return_v;
                }


                System.ArgumentException
                f_249_9444_9535(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 9444, 9535);
                    return return_v;
                }


                string
                f_249_9734_9782()
                {
                    var return_v = CodeAnalysisResources.DuplicateAnalyzerInstances;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 9734, 9782);
                    return return_v;
                }


                System.ArgumentException
                f_249_9712_9802(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 9712, 9802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 8912, 9829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 8912, 9829);
            }
        }

        private void VerifyAnalyzerArgument(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 9841, 10183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9930, 9976);

                f_249_9930_9975(analyzer);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 9992, 10172) || true) && (!_analyzers.Contains(analyzer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 9992, 10172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10060, 10157);

                    throw f_249_10066_10156(f_249_10088_10137(), nameof(analyzer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 9992, 10172);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 9841, 10183);

                int
                f_249_9930_9975(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    VerifyAnalyzerArgumentForStaticApis(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 9930, 9975);
                    return 0;
                }


                string
                f_249_10088_10137()
                {
                    var return_v = CodeAnalysisResources.UnsupportedAnalyzerInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 10088, 10137);
                    return return_v;
                }


                System.ArgumentException
                f_249_10066_10156(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 10066, 10156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 9841, 10183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 9841, 10183);
            }
        }

        private static void VerifyAnalyzerArgumentForStaticApis(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 10195, 10475);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10304, 10464) || true) && (analyzer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 10304, 10464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10358, 10449);

                    throw f_249_10364_10448(f_249_10386_10429(), nameof(analyzer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 10304, 10464);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 10195, 10475);

                string
                f_249_10386_10429()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 10386, 10429);
                    return return_v;
                }


                System.ArgumentException
                f_249_10364_10448(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 10364, 10448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 10195, 10475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 10195, 10475);
            }
        }

        private void VerifyExistingAnalyzersArgument(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 10487, 11139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10602, 10650);

                f_249_10602_10649(analyzers);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10666, 10861) || true) && (analyzers.Any(a => !_analyzers.Contains(a)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 10666, 10861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10747, 10846);

                    throw f_249_10753_10845(f_249_10775_10824(), nameof(_analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 10666, 10861);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 10877, 11128) || true) && (analyzers.Distinct().Length != analyzers.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 10877, 11128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11016, 11113);

                    throw f_249_11022_11112(f_249_11044_11092(), nameof(analyzers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 10877, 11128);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 10487, 11139);

                int
                f_249_10602_10649(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    VerifyAnalyzersArgumentForStaticApis(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 10602, 10649);
                    return 0;
                }


                string
                f_249_10775_10824()
                {
                    var return_v = CodeAnalysisResources.UnsupportedAnalyzerInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 10775, 10824);
                    return return_v;
                }


                System.ArgumentException
                f_249_10753_10845(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 10753, 10845);
                    return return_v;
                }


                string
                f_249_11044_11092()
                {
                    var return_v = CodeAnalysisResources.DuplicateAnalyzerInstances;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 11044, 11092);
                    return return_v;
                }


                System.ArgumentException
                f_249_11022_11112(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11022, 11112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 10487, 11139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 10487, 11139);
            }
        }

        private void VerifyModel(SemanticModel model)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 11151, 11542);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11221, 11334) || true) && (model == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 11221, 11334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11272, 11319);

                    throw f_249_11278_11318(nameof(model));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 11221, 11334);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11350, 11531) || true) && (!f_249_11355_11404(_compilation, f_249_11387_11403(model)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 11350, 11531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11438, 11516);

                    throw f_249_11444_11515(f_249_11466_11499(), nameof(model));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 11350, 11531);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 11151, 11542);

                System.ArgumentNullException
                f_249_11278_11318(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11278, 11318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_249_11387_11403(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 11387, 11403);
                    return return_v;
                }


                bool
                f_249_11355_11404(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11355, 11404);
                    return return_v;
                }


                string
                f_249_11466_11499()
                {
                    var return_v = CodeAnalysisResources.InvalidTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 11466, 11499);
                    return return_v;
                }


                System.ArgumentException
                f_249_11444_11515(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11444, 11515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 11151, 11542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 11151, 11542);
            }
        }

        private void VerifyTree(SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 11554, 11925);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11619, 11730) || true) && (tree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 11619, 11730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11669, 11715);

                    throw f_249_11675_11714(nameof(tree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 11619, 11730);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11746, 11914) || true) && (!f_249_11751_11788(_compilation, tree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 11746, 11914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 11822, 11899);

                    throw f_249_11828_11898(f_249_11850_11883(), nameof(tree));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 11746, 11914);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 11554, 11925);

                System.ArgumentNullException
                f_249_11675_11714(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11675, 11714);
                    return return_v;
                }


                bool
                f_249_11751_11788(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11751, 11788);
                    return return_v;
                }


                string
                f_249_11850_11883()
                {
                    var return_v = CodeAnalysisResources.InvalidTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 11850, 11883);
                    return return_v;
                }


                System.ArgumentException
                f_249_11828_11898(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 11828, 11898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 11554, 11925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 11554, 11925);
            }
        }

        private void VerifyAdditionalFile(AdditionalText file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 11937, 12386);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12016, 12127) || true) && (file == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 12016, 12127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12066, 12112);

                    throw f_249_12072_12111(nameof(file));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 12016, 12127);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12143, 12375) || true) && (f_249_12147_12171(_analysisOptions) == null || (DynAbs.Tracing.TraceSender.Expression_False(249, 12147, 12239) || !f_249_12184_12208(_analysisOptions).AdditionalFiles.Contains(file)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 12143, 12375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12273, 12360);

                    throw f_249_12279_12359(f_249_12301_12344(), nameof(file));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 12143, 12375);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 11937, 12386);

                System.ArgumentNullException
                f_249_12072_12111(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 12072, 12111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_12147_12171(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 12147, 12171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_249_12184_12208(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 12184, 12208);
                    return return_v;
                }


                string
                f_249_12301_12344()
                {
                    var return_v = CodeAnalysisResources.InvalidAdditionalFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 12301, 12344);
                    return return_v;
                }


                System.ArgumentException
                f_249_12279_12359(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 12279, 12359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 11937, 12386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 11937, 12386);
            }
        }

        public Task<ImmutableArray<Diagnostic>> GetAnalyzerDiagnosticsAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 12541, 12701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12635, 12690);

                return f_249_12642_12689(this, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 12541, 12701);

                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_12642_12689(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDiagnosticsAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 12642, 12689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 12541, 12701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 12541, 12701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerDiagnosticsAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 12834, 13093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 12969, 13082);

                return await f_249_12982_13081(f_249_12982_13059(this, f_249_13030_13039(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 12834, 13093);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_13030_13039()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 13030, 13039);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_12982_13059(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDiagnosticsWithoutStateTrackingAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 12982, 13059);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_12982_13081(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 12982, 13081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 12834, 13093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 12834, 13093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerDiagnosticsAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 13515, 13879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 13696, 13739);

                f_249_13696_13738(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 13755, 13868);

                return await f_249_13768_13867(f_249_13768_13845(this, analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 13515, 13879);

                int
                f_249_13696_13738(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 13696, 13738);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_13768_13845(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDiagnosticsWithoutStateTrackingAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 13768, 13845);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_13768_13867(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 13768, 13867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 13515, 13879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 13515, 13879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<AnalysisResult> GetAnalysisResultAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 14088, 14325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 14206, 14314);

                return await f_249_14219_14313(f_249_14219_14291(this, f_249_14262_14271(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 14088, 14325);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_14262_14271()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 14262, 14271);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_14219_14291(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultWithoutStateTrackingAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 14219, 14291);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_14219_14313(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 14219, 14313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 14088, 14325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 14088, 14325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<AnalysisResult> GetAnalysisResultAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 14832, 15174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 14996, 15039);

                f_249_14996_15038(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 15055, 15163);

                return await f_249_15068_15162(f_249_15068_15140(this, analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 14832, 15174);

                int
                f_249_14996_15038(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 14996, 15038);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_15068_15140(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultWithoutStateTrackingAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 15068, 15140);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_15068_15162(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 15068, 15162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 14832, 15174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 14832, 15174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<ImmutableArray<Diagnostic>> GetAllDiagnosticsAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 15330, 15480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 15419, 15469);

                return f_249_15426_15468(this, _cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 15330, 15480);

                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_15426_15468(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAllDiagnosticsAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 15426, 15468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 15330, 15480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 15330, 15480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAllDiagnosticsAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 15636, 15980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 15766, 15904);

                var
                diagnostics = await f_249_15790_15903(f_249_15790_15881(this, f_249_15833_15842(), cancellationToken: cancellationToken), false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 15918, 15969);

                return diagnostics.AddRange(_exceptionDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 15636, 15980);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_15833_15842()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 15833, 15842);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_15790_15881(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAllDiagnosticsWithoutStateTrackingAsync(analyzers, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 15790, 15881);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_15790_15903(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 15790, 15903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 15636, 15980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 15636, 15980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("This API was found to have performance issues and hence has been deprecated. Instead, invoke the API 'GetAnalysisResultAsync' and access the property 'CompilationDiagnostics' on the returned 'AnalysisResult' to fetch the compilation diagnostics.")]
        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerCompilationDiagnosticsAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 16136, 16670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 16551, 16659);

                return await f_249_16564_16658(f_249_16564_16636(this, f_249_16607_16616(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 16136, 16670);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_16607_16616()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 16607, 16616);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_16564_16636(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerCompilationDiagnosticsCoreAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 16564, 16636);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_16564_16658(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 16564, 16658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 16136, 16670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 16136, 16670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("This API was found to have performance issues and hence has been deprecated. Instead, invoke the API 'GetAnalysisResultAsync' and access the property 'CompilationDiagnostics' on the returned 'AnalysisResult' to fetch the compilation diagnostics.")]
        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerCompilationDiagnosticsAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 17115, 17754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 17576, 17619);

                f_249_17576_17618(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 17635, 17743);

                return await f_249_17648_17742(f_249_17648_17720(this, analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 17115, 17754);

                int
                f_249_17576_17618(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 17576, 17618);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_17648_17720(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerCompilationDiagnosticsCoreAsync(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 17648, 17720);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_17648_17742(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 17648, 17742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 17115, 17754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 17115, 17754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<ImmutableArray<Diagnostic>> GetAnalyzerCompilationDiagnosticsCoreAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 17766, 19197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18018, 18185);

                await f_249_18024_18184(f_249_18024_18162(this, waitForTreeTasks: true, waitForCompilationOrNonConcurrentTask: true, cancellationToken: cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18201, 18252);

                var
                diagnostics = ImmutableArray<Diagnostic>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18266, 18325);

                var
                hasAllAnalyzers = analyzers.Length == f_249_18308_18317().Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18339, 18511);

                var
                analysisScope = f_249_18359_18510(_compilation, f_249_18391_18415(_analysisOptions), analyzers, hasAllAnalyzers, f_249_18445_18480(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18525, 18725);

                Func<ImmutableArray<CompilationEvent>>
                getPendingEvents = () =>
                                _analysisState.GetPendingEvents(analyzers, includeSourceEvents: true, includeNonSourceEvents: true, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 18820, 18968);

                await f_249_18826_18967(f_249_18826_18945(this, analysisScope, getPendingEvents, newTaskToken: 0, cancellationToken: cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 19068, 19186);

                return f_249_19075_19185(_analysisResultBuilder, analysisScope, getLocalDiagnostics: false, getNonLocalDiagnostics: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 17766, 19197);

                System.Threading.Tasks.Task
                f_249_18024_18162(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, bool
                waitForTreeTasks, bool
                waitForCompilationOrNonConcurrentTask, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.WaitForActiveAnalysisTasksAsync(waitForTreeTasks: waitForTreeTasks, waitForCompilationOrNonConcurrentTask: waitForCompilationOrNonConcurrentTask, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 18024, 18162);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_18024_18184(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 18024, 18184);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_18308_18317()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 18308, 18317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_18391_18415(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 18391, 18415);
                    return return_v;
                }


                bool
                f_249_18445_18480(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 18445, 18480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_18359_18510(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(compilation, analyzerOptions, analyzers, hasAllAnalyzers, concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 18359, 18510);
                    return return_v;
                }


                System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_18826_18945(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                getPendingEventsOpt, int
                newTaskToken, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerDiagnosticsAsync(analysisScope, getPendingEventsOpt, newTaskToken: newTaskToken, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 18826, 18945);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_18826_18967(System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 18826, 18967);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_19075_19185(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                getLocalDiagnostics, bool
                getNonLocalDiagnostics)
                {
                    var return_v = this_param.GetDiagnostics(analysisScope, getLocalDiagnostics: getLocalDiagnostics, getNonLocalDiagnostics: getNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 19075, 19185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 17766, 19197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 17766, 19197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<AnalysisResult> GetAnalysisResultWithoutStateTrackingAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 19209, 19708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 19505, 19604);

                await f_249_19511_19603(f_249_19511_19581(this, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 19620, 19697);

                return f_249_19627_19696(_analysisResultBuilder, analyzers, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 19209, 19708);

                System.Threading.Tasks.Task
                f_249_19511_19581(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerDiagnosticsWithoutStateTrackingAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 19511, 19581);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_19511_19603(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 19511, 19603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                f_249_19627_19696(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ToAnalysisResult(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 19627, 19696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 19209, 19708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 19209, 19708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<ImmutableArray<Diagnostic>> GetAnalyzerDiagnosticsWithoutStateTrackingAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 19720, 20626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 20033, 20132);

                await f_249_20039_20131(f_249_20039_20109(this, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 20219, 20278);

                var
                hasAllAnalyzers = analyzers.Length == f_249_20261_20270().Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 20292, 20484);

                var
                analysisScope = f_249_20312_20483(_compilation, f_249_20344_20368(_analysisOptions), analyzers, hasAllAnalyzers, concurrentAnalysis: f_249_20418_20453(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 20498, 20615);

                return f_249_20505_20614(_analysisResultBuilder, analysisScope, getLocalDiagnostics: true, getNonLocalDiagnostics: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 19720, 20626);

                System.Threading.Tasks.Task
                f_249_20039_20109(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerDiagnosticsWithoutStateTrackingAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 20039, 20109);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_20039_20131(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 20039, 20131);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_20261_20270()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 20261, 20270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_20344_20368(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 20344, 20368);
                    return return_v;
                }


                bool
                f_249_20418_20453(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 20418, 20453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_20312_20483(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(compilation, analyzerOptions, analyzers, hasAllAnalyzers, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 20312, 20483);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_20505_20614(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                getLocalDiagnostics, bool
                getNonLocalDiagnostics)
                {
                    var return_v = this_param.GetDiagnostics(analysisScope, getLocalDiagnostics: getLocalDiagnostics, getNonLocalDiagnostics: getNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 20505, 20614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 19720, 20626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 19720, 20626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static AnalyzerDriver CreateDriverForComputingDiagnosticsWithoutStateTracking(Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 20638, 21421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21290, 21410);

                return f_249_21297_21409(compilation, analyzers, f_249_21341_21371(analyzers), severityFilter: SeverityFilter.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 20638, 21421);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_249_21341_21371(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 21341, 21371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_249_21297_21409(Microsoft.CodeAnalysis.Compilation
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = this_param.CreateAnalyzerDriver(analyzers, analyzerManager, severityFilter: severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 21297, 21409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 20638, 21421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 20638, 21421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task ComputeAnalyzerDiagnosticsWithoutStateTrackingAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 21433, 24174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21625, 21700);

                var
                analyzers = f_249_21641_21699(_analysisResultBuilder, f_249_21684_21698(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21714, 21791) || true) && (analyzers.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 21714, 21791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21769, 21776);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 21714, 21791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21807, 21876);

                AsyncQueue<CompilationEvent>
                eventQueue = f_249_21849_21875(_eventQueuePool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 21890, 21920);

                AnalyzerDriver?
                driver = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22036, 22094);

                    var
                    compilation = f_249_22054_22093(_compilation, eventQueue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22112, 22167);

                    var
                    compilationData = f_249_22134_22166(compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22252, 22285);

                    var
                    categorizeDiagnostics = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22303, 22392);

                    driver = f_249_22312_22391(compilation, analyzers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22410, 22518);

                    f_249_22410_22517(driver, compilation, _analysisOptions, compilationData, categorizeDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22536, 22595);

                    var
                    hasAllAnalyzers = analyzers.Length == f_249_22578_22587().Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22613, 22821);

                    var
                    analysisScope = f_249_22633_22820(compilation, f_249_22664_22688(_analysisOptions), analyzers, hasAllAnalyzers, concurrentAnalysis: f_249_22738_22773(_analysisOptions), categorizeDiagnostics: categorizeDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 22839, 22941);

                    f_249_22839_22940(driver, compilation.EventQueue!, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23056, 23118);

                    var
                    compDiags = f_249_23072_23117(compilation, cancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23136, 23189);

                    await f_249_23142_23188(f_249_23142_23166(driver), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23257, 23359);

                    var
                    analyzerActionCounts = f_249_23284_23358(analyzers.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23377, 23676);
                        foreach (var analyzer in f_249_23402_23411_I(analyzers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 23377, 23676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23453, 23586);

                            var
                            actionCounts = await f_249_23478_23585(f_249_23478_23563(driver, analyzer, f_249_23524_23543(compilation), cancellationToken), false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23608, 23657);

                            f_249_23608_23656(analyzerActionCounts, analyzer, actionCounts);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 23377, 23676);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 300);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23694, 23810);

                    Func<DiagnosticAnalyzer, AnalyzerActionCounts>
                    getAnalyzerActionCounts = analyzer => analyzerActionCounts[analyzer]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 23830, 23999);

                    f_249_23830_23998(
                                    _analysisResultBuilder, analysisScope, driver, compilation, getAnalyzerActionCounts, fullAnalysisResultForAnalyzersInScope: true);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 24028, 24163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24068, 24086);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(driver, 249, 24068, 24085)?.Dispose(), 249, 24075, 24085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24104, 24148);

                    f_249_24104_24147(eventQueue, _eventQueuePool);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(249, 24028, 24163);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 21433, 24174);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_21684_21698(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 21684, 21698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_21641_21699(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetPendingAnalyzers(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 21641, 21699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_249_21849_21875(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 21849, 21875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_249_22054_22093(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue)
                {
                    var return_v = this_param.WithEventQueue(eventQueue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22054, 22093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                f_249_22134_22166(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22134, 22166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_249_22312_22391(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = CreateDriverForComputingDiagnosticsWithoutStateTracking(compilation, analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22312, 22391);
                    return return_v;
                }


                int
                f_249_22410_22517(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                analysisOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                compilationData, bool
                categorizeDiagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Initialize(compilation, analysisOptions, compilationData, categorizeDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22410, 22517);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_22578_22587()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 22578, 22587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_22664_22688(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 22664, 22688);
                    return return_v;
                }


                bool
                f_249_22738_22773(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 22738, 22773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_22633_22820(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(compilation, analyzerOptions, analyzers, hasAllAnalyzers, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22633, 22820);
                    return return_v;
                }


                int
                f_249_22839_22940(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.AttachQueueAndStartProcessingEvents(eventQueue, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 22839, 22940);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_23072_23117(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23072, 23117);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_23142_23166(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenCompletedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 23142, 23166);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_23142_23188(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23142, 23188);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_23284_23358(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23284, 23358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_249_23524_23543(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 23524, 23543);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_23478_23563(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                compilationOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerActionCountsAsync(analyzer, compilationOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23478, 23563);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_23478_23585(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23478, 23585);
                    return return_v;
                }


                int
                f_249_23608_23656(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23608, 23656);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_23402_23411_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23402, 23411);
                    return return_v;
                }


                int
                f_249_23830_23998(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                getAnalyzerActionCounts, bool
                fullAnalysisResultForAnalyzersInScope)
                {
                    this_param.ApplySuppressionsAndStoreAnalysisResult(analysisScope, driver, compilation, getAnalyzerActionCounts, fullAnalysisResultForAnalyzersInScope: fullAnalysisResultForAnalyzersInScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 23830, 23998);
                    return 0;
                }


                int
                f_249_24104_24147(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                eventQueuePool)
                {
                    FreeEventQueue(eventQueue, eventQueuePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24104, 24147);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 21433, 24174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 21433, 24174);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<ImmutableArray<Diagnostic>> GetAllDiagnosticsWithoutStateTrackingAsync(ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 24186, 26150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24383, 24452);

                AsyncQueue<CompilationEvent>
                eventQueue = f_249_24425_24451(_eventQueuePool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24466, 24496);

                AnalyzerDriver?
                driver = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24612, 24670);

                    var
                    compilation = f_249_24630_24669(_compilation, eventQueue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24688, 24743);

                    var
                    compilationData = f_249_24710_24742(compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24828, 24862);

                    var
                    categorizeDiagnostics = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24880, 24969);

                    driver = f_249_24889_24968(compilation, analyzers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 24987, 25095);

                    f_249_24987_25094(driver, compilation, _analysisOptions, compilationData, categorizeDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25113, 25172);

                    var
                    hasAllAnalyzers = analyzers.Length == f_249_25155_25164().Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25190, 25398);

                    var
                    analysisScope = f_249_25210_25397(compilation, f_249_25241_25265(_analysisOptions), analyzers, hasAllAnalyzers, concurrentAnalysis: f_249_25315_25350(_analysisOptions), categorizeDiagnostics: categorizeDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25416, 25518);

                    f_249_25416_25517(driver, compilation.EventQueue!, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25633, 25695);

                    var
                    compDiags = f_249_25649_25694(compilation, cancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25713, 25801);

                    var
                    analyzerDiags = await f_249_25739_25800(f_249_25739_25778(driver, compilation), false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25819, 25879);

                    var
                    reportedDiagnostics = compDiags.AddRange(analyzerDiags)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 25897, 25975);

                    return f_249_25904_25974(driver, reportedDiagnostics, compilation);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 26004, 26139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 26044, 26062);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(driver, 249, 26044, 26061)?.Dispose(), 249, 26051, 26061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 26080, 26124);

                    f_249_26080_26123(eventQueue, _eventQueuePool);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(249, 26004, 26139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 24186, 26150);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_249_24425_24451(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24425, 24451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_249_24630_24669(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue)
                {
                    var return_v = this_param.WithEventQueue(eventQueue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24630, 24669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                f_249_24710_24742(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24710, 24742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_249_24889_24968(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = CreateDriverForComputingDiagnosticsWithoutStateTracking(compilation, analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24889, 24968);
                    return return_v;
                }


                int
                f_249_24987_25094(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                analysisOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                compilationData, bool
                categorizeDiagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Initialize(compilation, analysisOptions, compilationData, categorizeDiagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 24987, 25094);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_25155_25164()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 25155, 25164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_25241_25265(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 25241, 25265);
                    return return_v;
                }


                bool
                f_249_25315_25350(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 25315, 25350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_25210_25397(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(compilation, analyzerOptions, analyzers, hasAllAnalyzers, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25210, 25397);
                    return return_v;
                }


                int
                f_249_25416_25517(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.AttachQueueAndStartProcessingEvents(eventQueue, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25416, 25517);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_25649_25694(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25649, 25694);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_25739_25778(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetDiagnosticsAsync(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25739, 25778);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_25739_25800(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25739, 25800);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_25904_25974(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 25904, 25974);
                    return return_v;
                }


                int
                f_249_26080_26123(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                eventQueuePool)
                {
                    FreeEventQueue(eventQueue, eventQueuePool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 26080, 26123);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 24186, 26150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 24186, 26150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerSyntaxDiagnosticsAsync(SyntaxTree tree, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 26722, 27033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 26880, 26897);

                f_249_26880_26896(this, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 26913, 27022);

                return await f_249_26926_27021(f_249_26926_26999(this, tree, f_249_26970_26979(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 26722, 27033);

                int
                f_249_26880_26896(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    this_param.VerifyTree(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 26880, 26896);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_26970_26979()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 26970, 26979);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_26926_26999(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerSyntaxDiagnosticsCoreAsync(tree, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 26926, 26999);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_26926_27021(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 26926, 27021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 26722, 27033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 26722, 27033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerSyntaxDiagnosticsAsync(SyntaxTree tree, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 27821, 28235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 28025, 28042);

                f_249_28025_28041(this, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 28056, 28099);

                f_249_28056_28098(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 28115, 28224);

                return await f_249_28128_28223(f_249_28128_28201(this, tree, analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 27821, 28235);

                int
                f_249_28025_28041(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    this_param.VerifyTree(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28025, 28041);
                    return 0;
                }


                int
                f_249_28056_28098(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28056, 28098);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_28128_28201(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerSyntaxDiagnosticsCoreAsync(tree, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28128, 28201);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_28128_28223(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28128, 28223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 27821, 28235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 27821, 28235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<AnalysisResult> GetAnalysisResultAsync(SyntaxTree tree, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 28794, 29065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 28923, 28940);

                f_249_28923_28939(this, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 28956, 29054);

                return f_249_28963_29053(this, f_249_28990_29022(tree), f_249_29024_29033(), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 28794, 29065);

                int
                f_249_28923_28939(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    this_param.VerifyTree(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28923, 28939);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_28990_29022(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28990, 29022);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_29024_29033()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 29024, 29033);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_28963_29053(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(file, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 28963, 29053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 28794, 29065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 28794, 29065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<AnalysisResult> GetAnalysisResultAsync(SyntaxTree tree, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 29840, 30214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 30015, 30032);

                f_249_30015_30031(this, tree);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 30046, 30089);

                f_249_30046_30088(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 30105, 30203);

                return f_249_30112_30202(this, f_249_30139_30171(tree), analyzers, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 29840, 30214);

                int
                f_249_30015_30031(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    this_param.VerifyTree(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 30015, 30031);
                    return 0;
                }


                int
                f_249_30046_30088(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 30046, 30088);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_30139_30171(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 30139, 30171);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_30112_30202(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(file, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 30112, 30202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 29840, 30214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 29840, 30214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<AnalysisResult> GetAnalysisResultAsync(AdditionalText file, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 30987, 31306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 31126, 31153);

                f_249_31126_31152(this, file);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 31169, 31295);

                return await f_249_31182_31294(f_249_31182_31272(this, f_249_31209_31241(file), f_249_31243_31252(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 30987, 31306);

                int
                f_249_31126_31152(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.AdditionalText
                file)
                {
                    this_param.VerifyAdditionalFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 31126, 31152);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_31209_31241(Microsoft.CodeAnalysis.AdditionalText
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 31209, 31241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_31243_31252()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 31243, 31252);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_31182_31272(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(file, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 31182, 31272);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_31182_31294(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 31182, 31294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 30987, 31306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 30987, 31306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<AnalysisResult> GetAnalysisResultAsync(AdditionalText file, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 32295, 32717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 32480, 32507);

                f_249_32480_32506(this, file);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 32521, 32564);

                f_249_32521_32563(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 32580, 32706);

                return await f_249_32593_32705(f_249_32593_32683(this, f_249_32620_32652(file), analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 32295, 32717);

                int
                f_249_32480_32506(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.AdditionalText
                file)
                {
                    this_param.VerifyAdditionalFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32480, 32506);
                    return 0;
                }


                int
                f_249_32521_32563(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32521, 32563);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_32620_32652(Microsoft.CodeAnalysis.AdditionalText
                file)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32620, 32652);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_32593_32683(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(file, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32593, 32683);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_32593_32705(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32593, 32705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 32295, 32717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 32295, 32717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<AnalysisResult> GetAnalysisResultCoreAsync(SourceOrAdditionalFile file, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 32729, 33339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 32927, 33123);

                var
                analysisScope = f_249_32947_33122(analyzers, file, filterSpan: null, isSyntacticSingleFileAnalysis: true, concurrentAnalysis: f_249_33057_33092(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 33137, 33237);

                await f_249_33143_33236(f_249_33143_33214(this, analysisScope, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 33251, 33328);

                return f_249_33258_33327(_analysisResultBuilder, analyzers, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 32729, 33339);

                bool
                f_249_33057_33092(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 33057, 33092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_32947_33122(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, bool
                isSyntacticSingleFileAnalysis, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(analyzers, filterFile, filterSpan: filterSpan, isSyntacticSingleFileAnalysis: isSyntacticSingleFileAnalysis, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 32947, 33122);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_33143_33214(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerSyntaxDiagnosticsAsync(analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33143, 33214);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_33143_33236(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33143, 33236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                f_249_33258_33327(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ToAnalysisResult(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33258, 33327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 32729, 33339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 32729, 33339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<ImmutableArray<Diagnostic>> GetAnalyzerSyntaxDiagnosticsCoreAsync(SyntaxTree tree, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 33351, 34041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 33560, 33784);

                var
                analysisScope = f_249_33580_33783(analyzers, f_249_33609_33641(tree), filterSpan: null, isSyntacticSingleFileAnalysis: true, concurrentAnalysis: f_249_33718_33753(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 33798, 33898);

                await f_249_33804_33897(f_249_33804_33875(this, analysisScope, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 33912, 34030);

                return f_249_33919_34029(_analysisResultBuilder, analysisScope, getLocalDiagnostics: true, getNonLocalDiagnostics: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 33351, 34041);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_33609_33641(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33609, 33641);
                    return return_v;
                }


                bool
                f_249_33718_33753(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 33718, 33753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_33580_33783(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, bool
                isSyntacticSingleFileAnalysis, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(analyzers, filterFile, filterSpan: filterSpan, isSyntacticSingleFileAnalysis: isSyntacticSingleFileAnalysis, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33580, 33783);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_33804_33875(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerSyntaxDiagnosticsAsync(analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33804, 33875);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_33804_33897(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33804, 33897);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_33919_34029(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                getLocalDiagnostics, bool
                getNonLocalDiagnostics)
                {
                    var return_v = this_param.GetDiagnostics(analysisScope, getLocalDiagnostics: getLocalDiagnostics, getNonLocalDiagnostics: getNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 33919, 34029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 33351, 34041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 33351, 34041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task ComputeAnalyzerSyntaxDiagnosticsAsync(AnalysisScope analysisScope, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 34053, 35136);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 34236, 34293);

                    var
                    taskToken = f_249_34252_34292(ref _currentToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 34313, 34404);

                    var
                    pendingAnalyzers = f_249_34336_34403(_analysisResultBuilder, f_249_34379_34402(analysisScope))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 34422, 34938) || true) && (pendingAnalyzers.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 34422, 34938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 34495, 34667);

                        var
                        pendingAnalysisScope = (DynAbs.Tracing.TraceSender.Conditional_F1(249, 34522, 34578) || ((pendingAnalyzers.Length < analysisScope.Analyzers.Length && DynAbs.Tracing.TraceSender.Conditional_F2(249, 34581, 34650)) || DynAbs.Tracing.TraceSender.Conditional_F3(249, 34653, 34666))) ? f_249_34581_34650(analysisScope, pendingAnalyzers, hasAllAnalyzers: false) : analysisScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 34780, 34919);

                        await f_249_34786_34918(f_249_34786_34896(this, pendingAnalysisScope, getPendingEventsOpt: null, taskToken, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 34422, 34938);
                    }
                }
                catch (Exception e) when (f_249_34993_35039(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 34967, 35125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 35073, 35110);

                    throw f_249_35079_35109();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 34967, 35125);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 34053, 35136);

                int
                f_249_34252_34292(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34252, 34292);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_34379_34402(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 34379, 34402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_34336_34403(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetPendingAnalyzers(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34336, 34403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_34581_34650(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers)
                {
                    var return_v = this_param.WithAnalyzers(analyzers, hasAllAnalyzers: hasAllAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34581, 34650);
                    return return_v;
                }


                System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_34786_34896(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>?
                getPendingEventsOpt, int
                newTaskToken, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerDiagnosticsAsync(analysisScope, getPendingEventsOpt: getPendingEventsOpt, newTaskToken, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34786, 34896);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_34786_34918(System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34786, 34918);
                    return return_v;
                }


                bool
                f_249_34993_35039(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 34993, 35039);
                    return return_v;
                }


                System.Exception
                f_249_35079_35109()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 35079, 35109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 34053, 35136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 34053, 35136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerSemanticDiagnosticsAsync(SemanticModel model, TextSpan? filterSpan, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 35808, 36164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 35994, 36013);

                f_249_35994_36012(this, model);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 36029, 36153);

                return await f_249_36042_36152(f_249_36042_36130(this, model, filterSpan, f_249_36101_36110(), cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 35808, 36164);

                int
                f_249_35994_36012(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    this_param.VerifyModel(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 35994, 36012);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_36101_36110()
                {
                    var return_v = Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 36101, 36110);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_36042_36130(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerSemanticDiagnosticsCoreAsync(model, filterSpan, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 36042, 36130);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_36042_36152(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 36042, 36152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 35808, 36164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 35808, 36164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<ImmutableArray<Diagnostic>> GetAnalyzerSemanticDiagnosticsAsync(SemanticModel model, TextSpan? filterSpan, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 37056, 37515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 37288, 37307);

                f_249_37288_37306(this, model);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 37321, 37364);

                f_249_37321_37363(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 37380, 37504);

                return await f_249_37393_37503(f_249_37393_37481(this, model, filterSpan, analyzers, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 37056, 37515);

                int
                f_249_37288_37306(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    this_param.VerifyModel(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 37288, 37306);
                    return 0;
                }


                int
                f_249_37321_37363(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 37321, 37363);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_37393_37481(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerSemanticDiagnosticsCoreAsync(model, filterSpan, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 37393, 37481);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_249_37393_37503(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 37393, 37503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 37056, 37515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 37056, 37515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<AnalysisResult> GetAnalysisResultAsync(SemanticModel model, TextSpan? filterSpan, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 38262, 38551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 38417, 38436);

                f_249_38417_38435(this, model);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 38452, 38540);

                return f_249_38459_38539(this, model, filterSpan, f_249_38505_38519(this), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 38262, 38551);

                int
                f_249_38417_38435(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    this_param.VerifyModel(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 38417, 38435);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_38505_38519(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 38505, 38519);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_38459_38539(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(model, filterSpan, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 38459, 38539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 38262, 38551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 38262, 38551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Task<AnalysisResult> GetAnalysisResultAsync(SemanticModel model, TextSpan? filterSpan, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 39518, 39905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 39719, 39738);

                f_249_39719_39737(this, model);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 39752, 39795);

                f_249_39752_39794(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 39811, 39894);

                return f_249_39818_39893(this, model, filterSpan, analyzers, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 39518, 39905);

                int
                f_249_39719_39737(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model)
                {
                    this_param.VerifyModel(model);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 39719, 39737);
                    return 0;
                }


                int
                f_249_39752_39794(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    this_param.VerifyExistingAnalyzersArgument(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 39752, 39794);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalysisResult>
                f_249_39818_39893(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalysisResultCoreAsync(model, filterSpan, analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 39818, 39893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 39518, 39905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 39518, 39905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<AnalysisResult> GetAnalysisResultCoreAsync(SemanticModel model, TextSpan? filterSpan, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 39917, 40585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 40129, 40360);

                var
                analysisScope = f_249_40149_40359(analyzers, f_249_40178_40222(f_249_40205_40221(model)), filterSpan, isSyntacticSingleFileAnalysis: false, concurrentAnalysis: f_249_40294_40329(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 40374, 40483);

                await f_249_40380_40482(f_249_40380_40460(this, model, analysisScope, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 40497, 40574);

                return f_249_40504_40573(_analysisResultBuilder, analyzers, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 39917, 40585);

                Microsoft.CodeAnalysis.SyntaxTree
                f_249_40205_40221(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 40205, 40221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_40178_40222(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40178, 40222);
                    return return_v;
                }


                bool
                f_249_40294_40329(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 40294, 40329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_40149_40359(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, bool
                isSyntacticSingleFileAnalysis, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(analyzers, filterFile, filterSpan, isSyntacticSingleFileAnalysis: isSyntacticSingleFileAnalysis, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40149, 40359);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_40380_40460(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerSemanticDiagnosticsAsync(model, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40380, 40460);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_40380_40482(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40380, 40482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisResult
                f_249_40504_40573(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ToAnalysisResult(analyzers, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40504, 40573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 39917, 40585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 39917, 40585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<ImmutableArray<Diagnostic>> GetAnalyzerSemanticDiagnosticsCoreAsync(SemanticModel model, TextSpan? filterSpan, ImmutableArray<DiagnosticAnalyzer> analyzers, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 40597, 41331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 40834, 41065);

                var
                analysisScope = f_249_40854_41064(analyzers, f_249_40883_40927(f_249_40910_40926(model)), filterSpan, isSyntacticSingleFileAnalysis: false, concurrentAnalysis: f_249_40999_41034(_analysisOptions), categorizeDiagnostics: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41079, 41188);

                await f_249_41085_41187(f_249_41085_41165(this, model, analysisScope, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41202, 41320);

                return f_249_41209_41319(_analysisResultBuilder, analysisScope, getLocalDiagnostics: true, getNonLocalDiagnostics: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 40597, 41331);

                Microsoft.CodeAnalysis.SyntaxTree
                f_249_40910_40926(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 40910, 40926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                f_249_40883_40927(Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40883, 40927);
                    return return_v;
                }


                bool
                f_249_40999_41034(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 40999, 41034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_40854_41064(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpan, bool
                isSyntacticSingleFileAnalysis, bool
                concurrentAnalysis, bool
                categorizeDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(analyzers, filterFile, filterSpan, isSyntacticSingleFileAnalysis: isSyntacticSingleFileAnalysis, concurrentAnalysis: concurrentAnalysis, categorizeDiagnostics: categorizeDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 40854, 41064);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_41085_41165(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerSemanticDiagnosticsAsync(model, analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41085, 41165);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_41085_41187(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41085, 41187);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_41209_41319(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, bool
                getLocalDiagnostics, bool
                getNonLocalDiagnostics)
                {
                    var return_v = this_param.GetDiagnostics(analysisScope, getLocalDiagnostics: getLocalDiagnostics, getNonLocalDiagnostics: getNonLocalDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41209, 41319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 40597, 41331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 40597, 41331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task ComputeAnalyzerSemanticDiagnosticsAsync(SemanticModel model, AnalysisScope analysisScope, CancellationToken cancellationToken, bool forceCompletePartialTrees = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 41343, 46435);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41588, 41645);

                    var
                    taskToken = f_249_41604_41644(ref _currentToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41665, 41756);

                    var
                    pendingAnalyzers = f_249_41688_41755(_analysisResultBuilder, f_249_41731_41754(analysisScope))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41774, 42958) || true) && (pendingAnalyzers.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 41774, 42958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 41847, 42019);

                        var
                        pendingAnalysisScope = (DynAbs.Tracing.TraceSender.Conditional_F1(249, 41874, 41930) || ((pendingAnalyzers.Length < analysisScope.Analyzers.Length && DynAbs.Tracing.TraceSender.Conditional_F2(249, 41933, 42002)) || DynAbs.Tracing.TraceSender.Conditional_F3(249, 42005, 42018))) ? f_249_41933_42002(analysisScope, pendingAnalyzers, hasAllAnalyzers: false) : analysisScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 42043, 42201);

                        Func<ImmutableArray<CompilationEvent>>
                        getPendingEvents = () => _analysisState.GetPendingEvents(analysisScope.Analyzers, model.SyntaxTree, cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 42225, 42274);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 42385, 42598);

                        (ImmutableArray<CompilationEvent> compilationEvents, bool hasSymbolStartActions) = await f_249_42474_42597(f_249_42474_42575(this, pendingAnalysisScope, getPendingEvents, taskToken, cancellationToken), false);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 42715, 42939) || true) && (hasSymbolStartActions && (DynAbs.Tracing.TraceSender.Expression_True(249, 42719, 42769) && forceCompletePartialTrees))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 42715, 42939);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 42819, 42916);

                            await f_249_42825_42915(f_249_42825_42893(compilationEvents, analysisScope), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 42715, 42939);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 41774, 42958);
                    }
                }
                catch (Exception e) when (f_249_43013_43059(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 42987, 43145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43093, 43130);

                    throw f_249_43099_43129();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 42987, 43145);
                }

                async Task processPartialSymbolLocationsAsync(ImmutableArray<CompilationEvent> compilationEvents, AnalysisScope analysisScope)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 43161, 46424);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43320, 43426) || true) && (compilationEvents.IsDefaultOrEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 43320, 43426);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43400, 43407);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 43320, 43426);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43446, 43687) || true) && (analysisScope.FilterSpanOpt.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(249, 43450, 43567) && !f_249_43491_43567(analysisScope, f_249_43518_43566(f_249_43518_43561(f_249_43518_43534(model), cancellationToken)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 43446, 43687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43661, 43668);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 43446, 43687);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43707, 43748);

                        HashSet<SyntaxTree>?
                        partialTrees = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43766, 44722);
                            foreach (var compilationEvent in f_249_43799_43816_I(compilationEvents))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 43766, 44722);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 43950, 44703) || true) && (compilationEvent is SymbolDeclaredCompilationEvent symbolDeclaredEvent && (DynAbs.Tracing.TraceSender.Expression_True(249, 43954, 44108) && f_249_44053_44084(f_249_44053_44079(symbolDeclaredEvent)) != SymbolKind.Namespace) && (DynAbs.Tracing.TraceSender.Expression_True(249, 43954, 44184) && f_249_44137_44163(symbolDeclaredEvent).Locations.Length > 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 43950, 44703);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44234, 44680);
                                        foreach (var location in f_249_44259_44295_I(f_249_44259_44295(f_249_44259_44285(symbolDeclaredEvent))))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 44234, 44680);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44353, 44653) || true) && (f_249_44357_44376(location) != null && (DynAbs.Tracing.TraceSender.Expression_True(249, 44357, 44427) && f_249_44388_44407(location) != f_249_44411_44427(model)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 44353, 44653);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44493, 44550);

                                                partialTrees = partialTrees ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>?>(249, 44508, 44549) ?? f_249_44524_44549());
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44584, 44622);

                                                f_249_44584_44621(partialTrees, f_249_44601_44620(location));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 44353, 44653);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 44234, 44680);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 447);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 447);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 43950, 44703);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 43766, 44722);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 957);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 957);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44742, 46409) || true) && (partialTrees != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 44742, 46409);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44808, 46390) || true) && (f_249_44812_44846(f_249_44812_44827()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 44808, 46390);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 44896, 45593);

                                await f_249_44902_45592(f_249_44902_45570(f_249_44915_45569(partialTrees, tree =>
                                                            Task.Run(() =>
                                                            {
                                                                var treeModel = _compilation.GetSemanticModel(tree);
                                                                analysisScope = new AnalysisScope(analysisScope.Analyzers, new SourceOrAdditionalFile(tree), filterSpan: null, isSyntacticSingleFileAnalysis: false, analysisScope.ConcurrentAnalysis, analysisScope.CategorizeDiagnostics);
                                                                return ComputeAnalyzerSemanticDiagnosticsAsync(treeModel, analysisScope, cancellationToken, forceCompletePartialTrees: false);
                                                            }, cancellationToken))), false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 44808, 46390);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 44808, 46390);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 45691, 46367);
                                    foreach (var tree in f_249_45712_45724_I(partialTrees))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 45691, 46367);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 45782, 45831);

                                        cancellationToken.ThrowIfCancellationRequested();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 45861, 45913);

                                        var
                                        treeModel = f_249_45877_45912(_compilation, tree)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 45943, 46163);

                                        analysisScope = f_249_45959_46162(f_249_45977_46000(analysisScope), f_249_46002_46034(tree), filterSpan: null, isSyntacticSingleFileAnalysis: false, f_249_46092_46124(analysisScope), f_249_46126_46161(analysisScope));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 46193, 46340);

                                        await f_249_46199_46339(f_249_46199_46317(this, treeModel, analysisScope, cancellationToken, forceCompletePartialTrees: false), false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 45691, 46367);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 677);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 677);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 44808, 46390);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 44742, 46409);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(249, 43161, 46424);

                        Microsoft.CodeAnalysis.SyntaxTree
                        f_249_43518_43534(Microsoft.CodeAnalysis.SemanticModel
                        this_param)
                        {
                            var return_v = this_param.SyntaxTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 43518, 43534);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode
                        f_249_43518_43561(Microsoft.CodeAnalysis.SyntaxTree
                        this_param, System.Threading.CancellationToken
                        cancellationToken)
                        {
                            var return_v = this_param.GetRoot(cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 43518, 43561);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Text.TextSpan
                        f_249_43518_43566(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Span;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 43518, 43566);
                            return return_v;
                        }


                        bool
                        f_249_43491_43567(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        this_param, Microsoft.CodeAnalysis.Text.TextSpan
                        filterSpan)
                        {
                            var return_v = this_param.ContainsSpan(filterSpan);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 43491, 43567);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_249_44053_44079(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44053, 44079);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_249_44053_44084(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44053, 44084);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_249_44137_44163(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44137, 44163);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ISymbol
                        f_249_44259_44285(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44259, 44285);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_249_44259_44295(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44259, 44295);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree?
                        f_249_44357_44376(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44357, 44376);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_249_44388_44407(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44388, 44407);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_249_44411_44427(Microsoft.CodeAnalysis.SemanticModel
                        this_param)
                        {
                            var return_v = this_param.SyntaxTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44411, 44427);
                            return return_v;
                        }


                        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                        f_249_44524_44549()
                        {
                            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44524, 44549);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTree
                        f_249_44601_44620(Microsoft.CodeAnalysis.Location
                        this_param)
                        {
                            var return_v = this_param.SourceTree;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44601, 44620);
                            return return_v;
                        }


                        bool
                        f_249_44584_44621(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44584, 44621);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_249_44259_44295_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44259, 44295);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        f_249_43799_43816_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 43799, 43816);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                        f_249_44812_44827()
                        {
                            var return_v = AnalysisOptions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44812, 44827);
                            return return_v;
                        }


                        bool
                        f_249_44812_44846(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                        this_param)
                        {
                            var return_v = this_param.ConcurrentAnalysis;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 44812, 44846);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                        f_249_44915_45569(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                        source, System.Func<Microsoft.CodeAnalysis.SyntaxTree, System.Threading.Tasks.Task>
                        selector)
                        {
                            var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxTree, System.Threading.Tasks.Task>(selector);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44915, 45569);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_249_44902_45570(System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>
                        tasks)
                        {
                            var return_v = Task.WhenAll(tasks);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44902, 45570);
                            return return_v;
                        }


                        System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                        f_249_44902_45592(System.Threading.Tasks.Task
                        this_param, bool
                        continueOnCapturedContext)
                        {
                            var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 44902, 45592);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SemanticModel
                        f_249_45877_45912(Microsoft.CodeAnalysis.Compilation
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        syntaxTree)
                        {
                            var return_v = this_param.GetSemanticModel(syntaxTree);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 45877, 45912);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        f_249_45977_46000(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        this_param)
                        {
                            var return_v = this_param.Analyzers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 45977, 46000);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                        f_249_46002_46034(Microsoft.CodeAnalysis.SyntaxTree
                        tree)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 46002, 46034);
                            return return_v;
                        }


                        bool
                        f_249_46092_46124(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        this_param)
                        {
                            var return_v = this_param.ConcurrentAnalysis;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 46092, 46124);
                            return return_v;
                        }


                        bool
                        f_249_46126_46161(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        this_param)
                        {
                            var return_v = this_param.CategorizeDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 46126, 46161);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        f_249_45959_46162(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                        analyzers, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                        filterFile, Microsoft.CodeAnalysis.Text.TextSpan?
                        filterSpan, bool
                        isSyntacticSingleFileAnalysis, bool
                        concurrentAnalysis, bool
                        categorizeDiagnostics)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisScope(analyzers, filterFile, filterSpan: filterSpan, isSyntacticSingleFileAnalysis: isSyntacticSingleFileAnalysis, concurrentAnalysis, categorizeDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 45959, 46162);
                            return return_v;
                        }


                        System.Threading.Tasks.Task
                        f_249_46199_46317(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                        this_param, Microsoft.CodeAnalysis.SemanticModel
                        model, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                        analysisScope, System.Threading.CancellationToken
                        cancellationToken, bool
                        forceCompletePartialTrees)
                        {
                            var return_v = this_param.ComputeAnalyzerSemanticDiagnosticsAsync(model, analysisScope, cancellationToken, forceCompletePartialTrees: forceCompletePartialTrees);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 46199, 46317);
                            return return_v;
                        }


                        System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                        f_249_46199_46339(System.Threading.Tasks.Task
                        this_param, bool
                        continueOnCapturedContext)
                        {
                            var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 46199, 46339);
                            return return_v;
                        }


                        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                        f_249_45712_45724_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.SyntaxTree>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 45712, 45724);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 43161, 46424);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 43161, 46424);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 41343, 46435);

                int
                f_249_41604_41644(ref int
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41604, 41644);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_41731_41754(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 41731, 41754);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_249_41688_41755(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetPendingAnalyzers(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41688, 41755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                f_249_41933_42002(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                hasAllAnalyzers)
                {
                    var return_v = this_param.WithAnalyzers(analyzers, hasAllAnalyzers: hasAllAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 41933, 42002);
                    return return_v;
                }


                System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_42474_42575(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Func<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                getPendingEventsOpt, int
                newTaskToken, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ComputeAnalyzerDiagnosticsAsync(analysisScope, getPendingEventsOpt, newTaskToken, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 42474, 42575);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                f_249_42474_42597(System.Threading.Tasks.Task<(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> events, bool hasSymbolStartActions)>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 42474, 42597);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_42825_42893(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                compilationEvents, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope)
                {
                    var return_v = processPartialSymbolLocationsAsync(compilationEvents, analysisScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 42825, 42893);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_42825_42915(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 42825, 42915);
                    return return_v;
                }


                bool
                f_249_43013_43059(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 43013, 43059);
                    return return_v;
                }


                System.Exception
                f_249_43099_43129()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 43099, 43129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 41343, 46435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 41343, 46435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<(ImmutableArray<CompilationEvent> events, bool hasSymbolStartActions)> ComputeAnalyzerDiagnosticsAsync(AnalysisScope analysisScope, Func<ImmutableArray<CompilationEvent>>? getPendingEventsOpt, int newTaskToken, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 46447, 52831);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 46774, 46804);

                    AnalyzerDriver?
                    driver = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 46822, 46847);

                    Task?
                    computeTask = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 46865, 46908);

                    CancellationTokenSource
                    cancellationSource
                    = default(CancellationTokenSource);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47041, 47120);

                        driver = await f_249_47056_47119(f_249_47056_47097(this, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47203, 47238);

                        f_249_47203_47237(f_249_47216_47236(driver));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47260, 47313);

                        f_249_47260_47312(f_249_47273_47311_M(!f_249_47274_47300(driver).IsCanceled));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47337, 47386);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47410, 47470);

                        f_249_47410_47469(this, analysisScope, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47494, 47566);

                        await f_249_47500_47565(f_249_47500_47543(this, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47812, 47827);

                        bool
                        suspended
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47849, 47908);

                        var
                        pendingEvents = ImmutableArray<CompilationEvent>.Empty
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 47930, 52383);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47981, 47999);

                                    suspended = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 48147, 52341);
                                    using (cancellationSource = f_249_48175_48204())
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 48416, 48546);

                                        using var
                                        linkedCancellationSource = f_249_48453_48545(f_249_48501_48525(cancellationSource), cancellationToken)
                                        ;

                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 48849, 48910);

                                            var
                                            linkedCancellationToken = f_249_48879_48909(linkedCancellationSource)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 49025, 51140);

                                            Func<Tuple<Task, CancellationTokenSource>>
                                            getComputeTask = () => Tuple.Create(
                                                                                Task.Run(async () =>
                                                                                {
                                                                                    try
                                                                                    {
                                                                                        AsyncQueue<CompilationEvent> eventQueue = s_EmptyEventQueue;
                                                                                        try
                                                                                        {
                                                // Get event queue with pending events to analyze.
                                                if (getPendingEventsOpt != null)
                                                                                            {
                                                                                                pendingEvents = getPendingEventsOpt();
                                                                                                eventQueue = CreateEventsQueue(pendingEvents);
                                                                                            }

                                                                                            linkedCancellationToken.ThrowIfCancellationRequested();

                                                // Execute analyzer driver on the given analysis scope with the given event queue.
                                                await ComputeAnalyzerDiagnosticsCoreAsync(driver, eventQueue, analysisScope, cancellationToken: linkedCancellationToken).ConfigureAwait(false);
                                                                                        }
                                                                                        finally
                                                                                        {
                                                                                            FreeEventQueue(eventQueue, _eventQueuePool);
                                                                                        }
                                                                                    }
                                                                                    catch (Exception e) when (FatalError.ReportAndPropagateUnlessCanceled(e))
                                                                                    {
                                                                                        throw ExceptionUtilities.Unreachable;
                                                                                    }
                                                                                }, linkedCancellationToken),
                                                                                cancellationSource)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51270, 51417);

                                            computeTask = await f_249_51290_51416(f_249_51290_51394(this, getComputeTask, f_249_51333_51360(analysisScope), newTaskToken, cancellationToken), false);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51453, 51502);

                                            cancellationToken.ThrowIfCancellationRequested();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51538, 51578);

                                            await f_249_51544_51577(computeTask, false);
                                        }
                                        catch (OperationCanceledException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 51639, 52067);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51738, 51787);

                                            cancellationToken.ThrowIfCancellationRequested();

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51821, 51983) || true) && (f_249_51825_51868_M(!cancellationSource.IsCancellationRequested))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 51821, 51983);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 51942, 51948);

                                                throw;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 51821, 51983);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52019, 52036);

                                            suspended = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(249, 51639, 52067);
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 52097, 52314);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52169, 52230);

                                            f_249_52169_52229(this, computeTask, f_249_52201_52228(analysisScope));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52264, 52283);

                                            computeTask = null;
                                            DynAbs.Tracing.TraceSender.TraceExitFinally(249, 52097, 52314);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(249, 48147, 52341);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 47930, 52383);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 47930, 52383) || true) && (suspended)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 47930, 52383);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(249, 47930, 52383);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52407, 52510);

                        return (pendingEvents, hasSymbolStartActions: f_249_52453_52499_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(driver, 249, 52453, 52499)?.HasSymbolStartedActions(analysisScope)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(249, 52453, 52508) ?? false));
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 52547, 52633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52595, 52614);

                        f_249_52595_52613(this, driver);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(249, 52547, 52633);
                    }
                }
                catch (Exception e) when (f_249_52688_52734(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 52662, 52820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 52768, 52805);

                    throw f_249_52774_52804();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 52662, 52820);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 46447, 52831);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_47056_47097(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDriverAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47056, 47097);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_47056_47119(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47056, 47119);
                    return return_v;
                }


                bool
                f_249_47216_47236(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.IsInitialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 47216, 47236);
                    return return_v;
                }


                int
                f_249_47203_47237(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47203, 47237);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_47274_47300(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 47274, 47300);
                    return return_v;
                }


                bool
                f_249_47273_47311_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 47273, 47311);
                    return return_v;
                }


                int
                f_249_47260_47312(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47260, 47312);
                    return 0;
                }


                int
                f_249_47410_47469(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.GenerateCompilationEvents(analysisScope, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47410, 47469);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_47500_47543(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.PopulateEventsCacheAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47500, 47543);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_47500_47565(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 47500, 47565);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_249_48175_48204()
                {
                    var return_v = new System.Threading.CancellationTokenSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 48175, 48204);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_249_48501_48525(System.Threading.CancellationTokenSource
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 48501, 48525);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_249_48453_48545(System.Threading.CancellationToken
                token1, System.Threading.CancellationToken
                token2)
                {
                    var return_v = CancellationTokenSource.CreateLinkedTokenSource(token1, token2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 48453, 48545);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_249_48879_48909(System.Threading.CancellationTokenSource
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 48879, 48909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_249_51333_51360(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 51333, 51360);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Threading.Tasks.Task>
                f_249_51290_51394(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                getNewAnalysisTask, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                fileOpt, int
                newTaskToken, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SetActiveAnalysisTaskAsync(getNewAnalysisTask, fileOpt, newTaskToken, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 51290, 51394);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.Threading.Tasks.Task>
                f_249_51290_51416(System.Threading.Tasks.Task<System.Threading.Tasks.Task>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 51290, 51416);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_51544_51577(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 51544, 51577);
                    return return_v;
                }


                bool
                f_249_51825_51868_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 51825, 51868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_249_52201_52228(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 52201, 52228);
                    return return_v;
                }


                int
                f_249_52169_52229(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.Tasks.Task?
                computeTask, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                fileOpt)
                {
                    this_param.ClearExecutingTask(computeTask, fileOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 52169, 52229);
                    return 0;
                }


                bool?
                f_249_52453_52499_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 52453, 52499);
                    return return_v;
                }


                int
                f_249_52595_52613(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?
                driver)
                {
                    this_param.FreeDriver(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 52595, 52613);
                    return 0;
                }


                bool
                f_249_52688_52734(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 52688, 52734);
                    return return_v;
                }


                System.Exception
                f_249_52774_52804()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 52774, 52804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 46447, 52831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 46447, 52831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateCompilationEvents(AnalysisScope analysisScope, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 52843, 53574);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53125, 53563) || true) && (f_249_53129_53156(analysisScope) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 53125, 53563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53198, 53249);

                    _ = f_249_53202_53248(_compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 53125, 53563);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 53125, 53563);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53283, 53563) || true) && (f_249_53287_53331_M(!analysisScope.IsSyntacticSingleFileAnalysis))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 53283, 53563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53365, 53461);

                        var
                        mappedModel = f_249_53383_53460(_compilation, analysisScope.FilterFileOpt!.Value.SourceTree!)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53479, 53548);

                        _ = f_249_53483_53547(mappedModel, cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 53283, 53563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 53125, 53563);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 52843, 53574);

                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_249_53129_53156(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 53129, 53156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_53202_53248(Microsoft.CodeAnalysis.Compilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 53202, 53248);
                    return return_v;
                }


                bool
                f_249_53287_53331_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 53287, 53331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_249_53383_53460(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 53383, 53460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_53483_53547(Microsoft.CodeAnalysis.SemanticModel
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnostics(cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 53483, 53547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 52843, 53574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 52843, 53574);
            }
        }

        private async Task PopulateEventsCacheAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 53586, 55556);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53691, 54728) || true) && (f_249_53695_53725_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_249_53695_53718(_compilation), 249, 53695, 53725)?.Count) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 53691, 54728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53763, 53793);

                    AnalyzerDriver?
                    driver = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53855, 53934);

                        driver = await f_249_53870_53933(f_249_53870_53911(this, cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 53956, 54005);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 54029, 54274);

                        Func<AsyncQueue<CompilationEvent>, ImmutableArray<AdditionalText>, ImmutableArray<CompilationEvent>>
                        getCompilationEvents =
                                                (eventQueue, additionalFiles) => dequeueGeneratedCompilationEvents(eventQueue, additionalFiles)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 54296, 54400);

                        var
                        additionalFiles = f_249_54318_54359_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_249_54318_54342(_analysisOptions), 249, 54318, 54359)?.AdditionalFiles) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?>(249, 54318, 54399) ?? ImmutableArray<AdditionalText>.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 54422, 54590);

                        await f_249_54428_54589(f_249_54428_54567(_analysisState, getCompilationEvents, f_249_54499_54522(_compilation), additionalFiles, driver, cancellationToken), false);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 54627, 54713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 54675, 54694);

                        f_249_54675_54693(this, driver);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(249, 54627, 54713);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 53691, 54728);
                }

                static ImmutableArray<CompilationEvent> dequeueGeneratedCompilationEvents(AsyncQueue<CompilationEvent> eventQueue, ImmutableArray<AdditionalText> additionalFiles)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 54744, 55545);
                        Microsoft.CodeAnalysis.Diagnostics.CompilationEvent compilationEvent = default(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 54939, 55002);

                        var
                        builder = f_249_54953_55001()
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55022, 55481) || true) && (f_249_55029_55089(eventQueue, out compilationEvent))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 55022, 55481);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55131, 55408) || true) && (compilationEvent is CompilationStartedEvent compilationStartedEvent && (DynAbs.Tracing.TraceSender.Expression_True(249, 55135, 55255) && f_249_55231_55255_M(!additionalFiles.IsEmpty)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 55131, 55408);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55305, 55385);

                                    compilationEvent = f_249_55324_55384(compilationStartedEvent, additionalFiles);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 55131, 55408);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55432, 55462);

                                f_249_55432_55461(
                                                    builder, compilationEvent);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 55022, 55481);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 55022, 55481);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(249, 55022, 55481);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55501, 55530);

                        return f_249_55508_55529(builder);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 54744, 55545);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>.Builder
                        f_249_54953_55001()
                        {
                            var return_v = ImmutableArray.CreateBuilder<CompilationEvent>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 54953, 55001);
                            return return_v;
                        }


                        bool
                        f_249_55029_55089(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        this_param, out Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                        d)
                        {
                            var return_v = this_param.TryDequeue(out d);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 55029, 55089);
                            return return_v;
                        }


                        bool
                        f_249_55231_55255_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 55231, 55255);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent
                        f_249_55324_55384(Microsoft.CodeAnalysis.Diagnostics.CompilationStartedEvent
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                        additionalFiles)
                        {
                            var return_v = this_param.WithAdditionalFiles(additionalFiles);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 55324, 55384);
                            return return_v;
                        }


                        int
                        f_249_55432_55461(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>.Builder
                        this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 55432, 55461);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        f_249_55508_55529(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 55508, 55529);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 54744, 55545);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 54744, 55545);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 53586, 55556);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                f_249_53695_53718(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 53695, 53718);
                    return return_v;
                }


                int?
                f_249_53695_53725_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 53695, 53725);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_53870_53911(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDriverAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 53870, 53911);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_53870_53933(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 53870, 53933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                f_249_54318_54342(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 54318, 54342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
                f_249_54318_54359_M(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 54318, 54359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_249_54499_54522(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.EventQueue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 54499, 54522);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_54428_54567(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Func<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                getCompilationEvents, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalFiles, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.OnCompilationEventsGeneratedAsync(getCompilationEvents, eventQueue, additionalFiles, driver, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 54428, 54567);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_54428_54589(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 54428, 54589);
                    return return_v;
                }


                int
                f_249_54675_54693(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?
                driver)
                {
                    this_param.FreeDriver(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 54675, 54693);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 53586, 55556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 53586, 55556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<AnalyzerDriver> GetAnalyzerDriverAsync(CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 55568, 57050);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55723, 55772);

                    cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55866, 55913);

                    AnalyzerDriver
                    driver = f_249_55890_55912(_driverPool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 55933, 55954);

                    bool
                    success = false
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56084, 56317) || true) && (f_249_56088_56109_M(!driver.IsInitialized))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 56084, 56317);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56159, 56294);

                            f_249_56159_56293(driver, _compilation, _analysisOptions, _compilationData, categorizeDiagnostics: true, cancellationToken: cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 56084, 56317);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56514, 56569);

                        await f_249_56520_56568(f_249_56520_56546(driver), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56593, 56608);

                        success = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56630, 56644);

                        return driver;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 56681, 56852);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56729, 56833) || true) && (!success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 56729, 56833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56791, 56810);

                            f_249_56791_56809(this, driver);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 56729, 56833);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(249, 56681, 56852);
                    }
                }
                catch (Exception e) when (f_249_56907_56953(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 56881, 57039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 56987, 57024);

                    throw f_249_56993_57023();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 56881, 57039);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 55568, 57050);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_249_55890_55912(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 55890, 55912);
                    return return_v;
                }


                bool
                f_249_56088_56109_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 56088, 56109);
                    return return_v;
                }


                int
                f_249_56159_56293(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                analysisOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
                compilationData, bool
                categorizeDiagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Initialize(compilation, analysisOptions, compilationData, categorizeDiagnostics: categorizeDiagnostics, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 56159, 56293);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_56520_56546(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 56520, 56546);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_56520_56568(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 56520, 56568);
                    return return_v;
                }


                int
                f_249_56791_56809(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver)
                {
                    this_param.FreeDriver(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 56791, 56809);
                    return 0;
                }


                bool
                f_249_56907_56953(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 56907, 56953);
                    return return_v;
                }


                System.Exception
                f_249_56993_57023()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 56993, 57023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 55568, 57050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 55568, 57050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FreeDriver(AnalyzerDriver? driver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 57062, 57575);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57134, 57564) || true) && (driver != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 57134, 57564);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57275, 57549) || true) && (f_249_57279_57300_M(!driver.IsInitialized) || (DynAbs.Tracing.TraceSender.Expression_False(249, 57279, 57341) || f_249_57304_57341(f_249_57304_57330(driver))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 57275, 57549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57383, 57423);

                        f_249_57383_57422(_driverPool, driver);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 57275, 57549);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 57275, 57549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57505, 57530);

                        f_249_57505_57529(_driverPool, driver);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 57275, 57549);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 57134, 57564);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 57062, 57575);

                bool
                f_249_57279_57300_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57279, 57300);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_57304_57330(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57304, 57330);
                    return return_v;
                }


                bool
                f_249_57304_57341(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.IsCanceled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57304, 57341);
                    return return_v;
                }


                int
                f_249_57383_57422(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                old)
                {
                    this_param.ForgetTrackedObject(old);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 57383, 57422);
                    return 0;
                }


                int
                f_249_57505_57529(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 57505, 57529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 57062, 57575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 57062, 57575);
            }
        }

        private async Task ComputeAnalyzerDiagnosticsCoreAsync(AnalyzerDriver driver, AsyncQueue<CompilationEvent> eventQueue, AnalysisScope analysisScope, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 57684, 59154);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57929, 57964);

                    f_249_57929_57963(f_249_57942_57962(driver));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 57982, 58035);

                    f_249_57982_58034(f_249_57995_58033_M(!f_249_57996_58022(driver).IsCanceled));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 58055, 58956) || true) && (f_249_58059_58075(eventQueue) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(249, 58059, 58137) || f_249_58083_58137(_analysisState, analysisScope)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 58055, 58956);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 58304, 58342);

                            f_249_58304_58341(f_249_58317_58340_M(!eventQueue.IsCompleted));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 58368, 58520);

                            await f_249_58374_58519(f_249_58374_58497(driver, eventQueue, analysisScope, _analysisState, cancellationToken: cancellationToken), false);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 58565, 58937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 58728, 58914);

                            f_249_58728_58913(                        // Update the diagnostic results based on the diagnostics reported on the driver.
                                                    _analysisResultBuilder, analysisScope, driver, _compilation, _analysisState.GetAnalyzerActionCounts, fullAnalysisResultForAnalyzersInScope: false);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(249, 58565, 58937);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 58055, 58956);
                    }
                }
                catch (Exception e) when (f_249_59011_59057(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 58985, 59143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 59091, 59128);

                    throw f_249_59097_59127();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 58985, 59143);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 57684, 59154);

                bool
                f_249_57942_57962(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.IsInitialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57942, 57962);
                    return return_v;
                }


                int
                f_249_57929_57963(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 57929, 57963);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_57996_58022(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.WhenInitializedTask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57996, 58022);
                    return return_v;
                }


                bool
                f_249_57995_58033_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 57995, 58033);
                    return return_v;
                }


                int
                f_249_57982_58034(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 57982, 58034);
                    return 0;
                }


                int
                f_249_58059_58075(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 58059, 58075);
                    return return_v;
                }


                bool
                f_249_58083_58137(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope)
                {
                    var return_v = this_param.HasPendingSyntaxAnalysis(analysisScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 58083, 58137);
                    return return_v;
                }


                bool
                f_249_58317_58340_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 58317, 58340);
                    return return_v;
                }


                int
                f_249_58304_58341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 58304, 58341);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_58374_58497(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                eventQueue, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                analysisState, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.AttachQueueAndProcessAllEventsAsync(eventQueue, analysisScope, analysisState, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 58374, 58497);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_58374_58519(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 58374, 58519);
                    return return_v;
                }


                int
                f_249_58728_58913(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                analysisScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, Microsoft.CodeAnalysis.Compilation
                compilation, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                getAnalyzerActionCounts, bool
                fullAnalysisResultForAnalyzersInScope)
                {
                    this_param.ApplySuppressionsAndStoreAnalysisResult(analysisScope, driver, compilation, getAnalyzerActionCounts, fullAnalysisResultForAnalyzersInScope: fullAnalysisResultForAnalyzersInScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 58728, 58913);
                    return 0;
                }


                bool
                f_249_59011_59057(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 59011, 59057);
                    return return_v;
                }


                System.Exception
                f_249_59097_59127()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 59097, 59127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 57684, 59154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 57684, 59154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Task<Task> SetActiveAnalysisTaskAsync(Func<Tuple<Task, CancellationTokenSource>> getNewAnalysisTask, SourceOrAdditionalFile? fileOpt, int newTaskToken, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 59166, 59723);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 59387, 59712) || true) && (fileOpt.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 59387, 59712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 59441, 59547);

                    return f_249_59448_59546(this, getNewAnalysisTask, fileOpt.Value, newTaskToken, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 59387, 59712);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 59387, 59712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 59613, 59697);

                    return f_249_59620_59696(this, getNewAnalysisTask, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 59387, 59712);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 59166, 59723);

                System.Threading.Tasks.Task<System.Threading.Tasks.Task>
                f_249_59448_59546(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                getNewTreeAnalysisTask, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                tree, int
                newTaskToken, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SetActiveTreeAnalysisTaskAsync(getNewTreeAnalysisTask, tree, newTaskToken, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 59448, 59546);
                    return return_v;
                }


                System.Threading.Tasks.Task<System.Threading.Tasks.Task>
                f_249_59620_59696(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                getNewCompilationTask, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SetActiveCompilationAnalysisTaskAsync(getNewCompilationTask, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 59620, 59696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 59166, 59723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 59166, 59723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<Task> SetActiveCompilationAnalysisTaskAsync(Func<Tuple<Task, CancellationTokenSource>> getNewCompilationTask, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 59735, 60767);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 59925, 60756) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 59925, 60756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60066, 60233);

                        await f_249_60072_60232(f_249_60072_60210(this, waitForTreeTasks: true, waitForCompilationOrNonConcurrentTask: true, cancellationToken: cancellationToken), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60259, 60278);

                        lock (_executingTasksLock)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60320, 60722) || true) && ((_executingConcurrentTreeTasksOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(249, 60325, 60412) || f_249_60369_60407(_executingConcurrentTreeTasksOpt) == 0)) && (DynAbs.Tracing.TraceSender.Expression_True(249, 60324, 60494) && _executingCompilationOrNonConcurrentTreeTask == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 60320, 60722);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60544, 60615);

                                _executingCompilationOrNonConcurrentTreeTask = f_249_60591_60614(getNewCompilationTask);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60641, 60699);

                                return f_249_60648_60698(_executingCompilationOrNonConcurrentTreeTask);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 60320, 60722);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 59925, 60756);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 59925, 60756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(249, 59925, 60756);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 59735, 60767);

                System.Threading.Tasks.Task
                f_249_60072_60210(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, bool
                waitForTreeTasks, bool
                waitForCompilationOrNonConcurrentTask, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.WaitForActiveAnalysisTasksAsync(waitForTreeTasks: waitForTreeTasks, waitForCompilationOrNonConcurrentTask: waitForCompilationOrNonConcurrentTask, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 60072, 60210);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_60072_60232(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 60072, 60232);
                    return return_v;
                }


                int
                f_249_60369_60407(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 60369, 60407);
                    return return_v;
                }


                System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                f_249_60591_60614(System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 60591, 60614);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_60648_60698(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 60648, 60698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 59735, 60767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 59735, 60767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task WaitForActiveAnalysisTasksAsync(bool waitForTreeTasks, bool waitForCompilationOrNonConcurrentTask, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 60779, 62315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 60958, 61030);

                f_249_60958_61029(waitForTreeTasks || (DynAbs.Tracing.TraceSender.Expression_False(249, 60971, 61028) || waitForCompilationOrNonConcurrentTask));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61046, 61132);

                var
                executingTasks = f_249_61067_61131()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61148, 62304) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 61148, 62304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61193, 61242);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61268, 61287);

                        lock (_executingTasksLock)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61329, 61534) || true) && (waitForTreeTasks && (DynAbs.Tracing.TraceSender.Expression_True(249, 61333, 61396) && f_249_61353_61392_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_executingConcurrentTreeTasksOpt, 249, 61353, 61392)?.Count) > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 61329, 61534);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61446, 61511);

                                f_249_61446_61510(executingTasks, f_249_61470_61509(_executingConcurrentTreeTasksOpt));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 61329, 61534);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61558, 61793) || true) && (waitForCompilationOrNonConcurrentTask && (DynAbs.Tracing.TraceSender.Expression_True(249, 61562, 61655) && _executingCompilationOrNonConcurrentTreeTask != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 61558, 61793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61705, 61770);

                                f_249_61705_61769(executingTasks, _executingCompilationOrNonConcurrentTreeTask);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 61558, 61793);
                            }
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61832, 61973) || true) && (f_249_61836_61856(executingTasks) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 61832, 61973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61903, 61925);

                            f_249_61903_61924(executingTasks);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61947, 61954);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 61832, 61973);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 61993, 62246);
                            foreach (var task in f_249_62014_62028_I(executingTasks))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 61993, 62246);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62070, 62119);

                                cancellationToken.ThrowIfCancellationRequested();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62141, 62227);

                                await f_249_62147_62226(f_249_62147_62204(f_249_62173_62183(task), alwaysYield: false), false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 61993, 62246);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 254);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 254);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62266, 62289);

                        f_249_62266_62288(
                                        executingTasks);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 61148, 62304);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 61148, 62304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(249, 61148, 62304);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 60779, 62315);

                int
                f_249_60958_61029(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 60958, 61029);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                f_249_61067_61131()
                {
                    var return_v = ArrayBuilder<Tuple<Task, CancellationTokenSource>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 61067, 61131);
                    return return_v;
                }


                int?
                f_249_61353_61392_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 61353, 61392);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>.ValueCollection
                f_249_61470_61509(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 61470, 61509);
                    return return_v;
                }


                int
                f_249_61446_61510(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>.ValueCollection
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 61446, 61510);
                    return 0;
                }


                int
                f_249_61705_61769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 61705, 61769);
                    return 0;
                }


                int
                f_249_61836_61856(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 61836, 61856);
                    return return_v;
                }


                int
                f_249_61903_61924(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 61903, 61924);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_62173_62183(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 62173, 62183);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_62147_62204(System.Threading.Tasks.Task
                executingTask, bool
                alwaysYield)
                {
                    var return_v = WaitForExecutingTaskAsync(executingTask, alwaysYield: alwaysYield);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 62147, 62204);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_62147_62226(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 62147, 62226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                f_249_62014_62028_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 62014, 62028);
                    return return_v;
                }


                int
                f_249_62266_62288(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 62266, 62288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 60779, 62315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 60779, 62315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<Task> SetActiveTreeAnalysisTaskAsync(Func<Tuple<Task, CancellationTokenSource>> getNewTreeAnalysisTask, SourceOrAdditionalFile tree, int newTaskToken, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 62327, 65640);
                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62594, 65442) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 62594, 65442);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62757, 62820);

                            Tuple<Task, CancellationTokenSource>?
                            executingTreeTask = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62850, 62869);

                            lock (_executingTasksLock)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 62919, 63719) || true) && (f_249_62923_62959_M(!_analysisOptions.ConcurrentAnalysis))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 62919, 63719);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63119, 63485) || true) && (_executingCompilationOrNonConcurrentTreeTask != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 63119, 63485);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63241, 63368);

                                        f_249_63241_63367(this, f_249_63264_63314(_executingCompilationOrNonConcurrentTreeTask), f_249_63316_63366(_executingCompilationOrNonConcurrentTreeTask));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63402, 63454);

                                        _executingCompilationOrNonConcurrentTreeTask = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 63119, 63485);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63517, 63556);

                                    var
                                    newTask = f_249_63531_63555(getNewTreeAnalysisTask)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63586, 63641);

                                    _executingCompilationOrNonConcurrentTreeTask = newTask;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63671, 63692);

                                    return f_249_63678_63691(newTask);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 62919, 63719);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63747, 63802);

                                f_249_63747_63801(_executingConcurrentTreeTasksOpt != null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63828, 63879);

                                f_249_63828_63878(_concurrentTreeTaskTokensOpt != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 63907, 65058) || true) && (!f_249_63912_63985(_executingConcurrentTreeTasksOpt, tree, out executingTreeTask) || (DynAbs.Tracing.TraceSender.Expression_False(249, 63911, 64086) || f_249_64018_64071(_concurrentTreeTaskTokensOpt, f_249_64047_64070(executingTreeTask)) < newTaskToken))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 63907, 65058);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64144, 64343) || true) && (executingTreeTask != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 64144, 64343);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64239, 64312);

                                        f_249_64239_64311(this, f_249_64262_64285(executingTreeTask), f_249_64287_64310(executingTreeTask));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 64144, 64343);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64375, 64741) || true) && (_executingCompilationOrNonConcurrentTreeTask != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 64375, 64741);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64497, 64624);

                                        f_249_64497_64623(this, f_249_64520_64570(_executingCompilationOrNonConcurrentTreeTask), f_249_64572_64622(_executingCompilationOrNonConcurrentTreeTask));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64658, 64710);

                                        _executingCompilationOrNonConcurrentTreeTask = null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 64375, 64741);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64773, 64812);

                                    var
                                    newTask = f_249_64787_64811(getNewTreeAnalysisTask)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64842, 64901);

                                    _concurrentTreeTaskTokensOpt[f_249_64871_64884(newTask)] = newTaskToken;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 64931, 64980);

                                    _executingConcurrentTreeTasksOpt[tree] = newTask;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65010, 65031);

                                    return f_249_65017_65030(newTask);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 63907, 65058);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65325, 65423);

                            await f_249_65331_65422(f_249_65331_65400(f_249_65357_65380(executingTreeTask), alwaysYield: true), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 62594, 65442);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 62594, 65442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(249, 62594, 65442);
                    }
                }
                catch (Exception e) when (f_249_65497_65543(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 65471, 65629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65577, 65614);

                    throw f_249_65583_65613();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 65471, 65629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 62327, 65640);

                bool
                f_249_62923_62959_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 62923, 62959);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_63264_63314(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 63264, 63314);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_249_63316_63366(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 63316, 63366);
                    return return_v;
                }


                int
                f_249_63241_63367(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.Tasks.Task
                computeTask, System.Threading.CancellationTokenSource
                cts)
                {
                    this_param.SuspendAnalysis_NoLock(computeTask, cts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 63241, 63367);
                    return 0;
                }


                System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                f_249_63531_63555(System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 63531, 63555);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_63678_63691(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 63678, 63691);
                    return return_v;
                }


                int
                f_249_63747_63801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 63747, 63801);
                    return 0;
                }


                int
                f_249_63828_63878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 63828, 63878);
                    return 0;
                }


                bool
                f_249_63912_63985(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                key, out System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 63912, 63985);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_64047_64070(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64047, 64070);
                    return return_v;
                }


                int
                f_249_64018_64071(System.Collections.Generic.Dictionary<System.Threading.Tasks.Task, int>
                this_param, System.Threading.Tasks.Task
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64018, 64071);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_64262_64285(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64262, 64285);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_249_64287_64310(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64287, 64310);
                    return return_v;
                }


                int
                f_249_64239_64311(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.Tasks.Task
                computeTask, System.Threading.CancellationTokenSource
                cts)
                {
                    this_param.SuspendAnalysis_NoLock(computeTask, cts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 64239, 64311);
                    return 0;
                }


                System.Threading.Tasks.Task
                f_249_64520_64570(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64520, 64570);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_249_64572_64622(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64572, 64622);
                    return return_v;
                }


                int
                f_249_64497_64623(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.Tasks.Task
                computeTask, System.Threading.CancellationTokenSource
                cts)
                {
                    this_param.SuspendAnalysis_NoLock(computeTask, cts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 64497, 64623);
                    return 0;
                }


                System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                f_249_64787_64811(System.Func<System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 64787, 64811);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_64871_64884(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 64871, 64884);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_65017_65030(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 65017, 65030);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_65357_65380(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 65357, 65380);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_65331_65400(System.Threading.Tasks.Task
                executingTask, bool
                alwaysYield)
                {
                    var return_v = WaitForExecutingTaskAsync(executingTask, alwaysYield: alwaysYield);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 65331, 65400);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_65331_65422(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 65331, 65422);
                    return return_v;
                }


                bool
                f_249_65497_65543(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 65497, 65543);
                    return return_v;
                }


                System.Exception
                f_249_65583_65613()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 65583, 65613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 62327, 65640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 62327, 65640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static async Task WaitForExecutingTaskAsync(Task executingTask, bool alwaysYield)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 65652, 66339);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65766, 66086) || true) && (f_249_65770_65795(executingTask))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 65766, 66086);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65829, 66044) || true) && (alwaysYield)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 65829, 66044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 65984, 66025);

                        await f_249_65990_66002().ConfigureAwait(false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 65829, 66044);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66064, 66071);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 65766, 66086);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66138, 66180);

                    await f_249_66144_66179(executingTask, false);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 66209, 66328);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 66209, 66328);
                    // Handle cancelled tasks gracefully.
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 65652, 66339);

                bool
                f_249_65770_65795(System.Threading.Tasks.Task
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 65770, 65795);
                    return return_v;
                }


                System.Runtime.CompilerServices.YieldAwaitable
                f_249_65990_66002()
                {
                    var return_v = Task.Yield();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 65990, 66002);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_249_66144_66179(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 66144, 66179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 65652, 66339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 65652, 66339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SuspendAnalysis_NoLock(Task computeTask, CancellationTokenSource cts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 66351, 66597);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66458, 66586) || true) && (f_249_66462_66486_M(!computeTask.IsCompleted))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 66458, 66586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66558, 66571);

                    f_249_66558_66570(                // Suspend analysis.
                                    cts);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 66458, 66586);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 66351, 66597);

                bool
                f_249_66462_66486_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 66462, 66486);
                    return return_v;
                }


                int
                f_249_66558_66570(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 66558, 66570);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 66351, 66597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 66351, 66597);
            }
        }

        private void ClearExecutingTask(Task? computeTask, SourceOrAdditionalFile? fileOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 66609, 67982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66717, 67971) || true) && (computeTask != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 66717, 67971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66780, 66799);
                    lock (_executingTasksLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66841, 66893);

                        Tuple<Task, CancellationTokenSource>?
                        executingTask
                        = default(Tuple<Task, CancellationTokenSource>?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 66915, 67937) || true) && (fileOpt.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(249, 66919, 66974) && f_249_66939_66974(_analysisOptions)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 66915, 67937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67024, 67079);

                            f_249_67024_67078(_executingConcurrentTreeTasksOpt != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67105, 67156);

                            f_249_67105_67155(_concurrentTreeTaskTokensOpt != null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67184, 67473) || true) && (f_249_67188_67266(_executingConcurrentTreeTasksOpt, fileOpt.Value, out executingTask) && (DynAbs.Tracing.TraceSender.Expression_True(249, 67188, 67333) && f_249_67299_67318(executingTask) == computeTask))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 67184, 67473);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67391, 67446);

                                f_249_67391_67445(_executingConcurrentTreeTasksOpt, fileOpt.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 67184, 67473);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67501, 67692) || true) && (f_249_67505_67558(_concurrentTreeTaskTokensOpt, computeTask))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 67501, 67692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67616, 67665);

                                f_249_67616_67664(_concurrentTreeTaskTokensOpt, computeTask);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 67501, 67692);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 66915, 67937);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 66915, 67937);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67742, 67937) || true) && (f_249_67746_67797_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_executingCompilationOrNonConcurrentTreeTask, 249, 67746, 67797)?.Item1) == computeTask)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 67742, 67937);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 67862, 67914);

                                _executingCompilationOrNonConcurrentTreeTask = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 67742, 67937);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 66915, 67937);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 66717, 67971);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 66609, 67982);

                bool
                f_249_66939_66974(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 66939, 66974);
                    return return_v;
                }


                int
                f_249_67024_67078(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67024, 67078);
                    return 0;
                }


                int
                f_249_67105_67155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67105, 67155);
                    return 0;
                }


                bool
                f_249_67188_67266(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                key, out System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67188, 67266);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_249_67299_67318(System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 67299, 67318);
                    return return_v;
                }


                bool
                f_249_67391_67445(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67391, 67445);
                    return return_v;
                }


                bool
                f_249_67505_67558(System.Collections.Generic.Dictionary<System.Threading.Tasks.Task, int>
                this_param, System.Threading.Tasks.Task
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67505, 67558);
                    return return_v;
                }


                bool
                f_249_67616_67664(System.Collections.Generic.Dictionary<System.Threading.Tasks.Task, int>
                this_param, System.Threading.Tasks.Task
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 67616, 67664);
                    return return_v;
                }


                System.Threading.Tasks.Task?
                f_249_67746_67797_M(System.Threading.Tasks.Task?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 67746, 67797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 66609, 67982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 66609, 67982);
            }
        }

        private AsyncQueue<CompilationEvent> CreateEventsQueue(ImmutableArray<CompilationEvent> compilationEvents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 67994, 68590);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68125, 68228) || true) && (compilationEvents.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 68125, 68228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68188, 68213);

                    return s_EmptyEventQueue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 68125, 68228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68244, 68288);

                var
                eventQueue = f_249_68261_68287(_eventQueuePool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68302, 68340);

                f_249_68302_68339(f_249_68315_68338_M(!eventQueue.IsCompleted));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68354, 68390);

                f_249_68354_68389(f_249_68367_68383(eventQueue) == 0);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68406, 68545);
                    foreach (var compilationEvent in f_249_68439_68456_I(compilationEvents))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 68406, 68545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68490, 68530);

                        f_249_68490_68529(eventQueue, compilationEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 68406, 68545);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68561, 68579);

                return eventQueue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 67994, 68590);

                Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_249_68261_68287(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68261, 68287);
                    return return_v;
                }


                bool
                f_249_68315_68338_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 68315, 68338);
                    return return_v;
                }


                int
                f_249_68302_68339(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68302, 68339);
                    return 0;
                }


                int
                f_249_68367_68383(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 68367, 68383);
                    return return_v;
                }


                int
                f_249_68354_68389(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68354, 68389);
                    return 0;
                }


                bool
                f_249_68490_68529(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                value)
                {
                    var return_v = this_param.TryEnqueue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68490, 68529);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_249_68439_68456_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68439, 68456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 67994, 68590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 67994, 68590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FreeEventQueue(AsyncQueue<CompilationEvent> eventQueue, ObjectPool<AsyncQueue<CompilationEvent>> eventQueuePool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 68602, 69262);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68759, 68887) || true) && (eventQueue == null || (DynAbs.Tracing.TraceSender.Expression_False(249, 68763, 68831) || f_249_68785_68831(eventQueue, s_EmptyEventQueue)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 68759, 68887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68865, 68872);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 68759, 68887);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68903, 69014) || true) && (f_249_68907_68923(eventQueue) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 68903, 69014);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68961, 68999) || true) && (f_249_68968_68996(eventQueue, out _))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 68961, 68999);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 68998, 68999);
                            ;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 68961, 68999);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 68961, 68999);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(249, 68961, 68999);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 68903, 69014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 69030, 69251) || true) && (f_249_69034_69057_M(!eventQueue.IsCompleted))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 69030, 69251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 69091, 69123);

                    f_249_69091_69122(eventQueuePool, eventQueue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 69030, 69251);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 69030, 69251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 69189, 69236);

                    f_249_69189_69235(eventQueuePool, eventQueue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 69030, 69251);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 68602, 69262);

                bool
                f_249_68785_68831(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                objA, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68785, 68831);
                    return return_v;
                }


                int
                f_249_68907_68923(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 68907, 68923);
                    return return_v;
                }


                bool
                f_249_68968_68996(Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, out Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                d)
                {
                    var return_v = this_param.TryDequeue(out d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 68968, 68996);
                    return return_v;
                }


                bool
                f_249_69034_69057_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 69034, 69057);
                    return return_v;
                }


                int
                f_249_69091_69122(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 69091, 69122);
                    return 0;
                }


                int
                f_249_69189_69235(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                old)
                {
                    this_param.ForgetTrackedObject(old);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 69189, 69235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 68602, 69262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 68602, 69262);
            }
        }

        public static IEnumerable<Diagnostic> GetEffectiveDiagnostics(IEnumerable<Diagnostic> diagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 70108, 70180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 70111, 70180);
                return f_249_70111_70180(f_249_70135_70166(diagnostics), compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(249, 70108, 70180);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 70108, 70180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 70108, 70180);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            f_249_70135_70166(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            items)
            {
                var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.Diagnostic>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 70135, 70166);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            f_249_70111_70180(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics, Microsoft.CodeAnalysis.Compilation
            compilation)
            {
                var return_v = GetEffectiveDiagnostics(diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 70111, 70180);
                return return_v;
            }

        }

        public static IEnumerable<Diagnostic> GetEffectiveDiagnostics(ImmutableArray<Diagnostic> diagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 70890, 71397);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71041, 71168) || true) && (diagnostics.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 71041, 71168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71100, 71153);

                    throw f_249_71106_71152(nameof(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 71041, 71168);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71184, 71309) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 71184, 71309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71241, 71294);

                    throw f_249_71247_71293(nameof(compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 71184, 71309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71325, 71386);

                return f_249_71332_71385(diagnostics, compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 70890, 71397);

                System.ArgumentNullException
                f_249_71106_71152(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71106, 71152);
                    return return_v;
                }


                System.ArgumentNullException
                f_249_71247_71293(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71247, 71293);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_249_71332_71385(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = GetEffectiveDiagnosticsImpl(diagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71332, 71385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 70890, 71397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 70890, 71397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<Diagnostic> GetEffectiveDiagnosticsImpl(ImmutableArray<Diagnostic> diagnostics, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 71409, 72436);

                var listYield = new List<Diagnostic>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71565, 71649) || true) && (diagnostics.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 71565, 71649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71622, 71634);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 71565, 71649);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71665, 71847) || true) && (f_249_71669_71702(compilation) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 71665, 71847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71744, 71832);

                    compilation = f_249_71758_71831(compilation, f_249_71796_71830());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 71665, 71847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71863, 71937);

                var
                suppressMessageState = f_249_71890_71936(compilation)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 71951, 72425);
                    foreach (var diagnostic in f_249_71978_71989_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 71951, 72425);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 72023, 72410) || true) && (diagnostic != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 72023, 72410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 72087, 72186);

                            var
                            effectiveDiagnostic = f_249_72113_72185(f_249_72113_72132(compilation), diagnostic, CancellationToken.None)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 72208, 72391) || true) && (effectiveDiagnostic != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 72208, 72391);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 72289, 72368);

                                listYield.Add(f_249_72302_72367(suppressMessageState, effectiveDiagnostic));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(249, 72208, 72391);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(249, 72023, 72410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(249, 71951, 72425);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(249, 1, 475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(249, 1, 475);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 71409, 72436);

                return listYield;

                Microsoft.CodeAnalysis.SemanticModelProvider?
                f_249_71669_71702(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SemanticModelProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 71669, 71702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                f_249_71796_71830()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71796, 71830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_249_71758_71831(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                semanticModelProvider)
                {
                    var return_v = this_param.WithSemanticModelProvider((Microsoft.CodeAnalysis.SemanticModelProvider)semanticModelProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71758, 71831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                f_249_71890_71936(Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71890, 71936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_249_72113_72132(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 72113, 72132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_249_72113_72185(Microsoft.CodeAnalysis.CompilationOptions
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.FilterDiagnostic(diagnostic, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 72113, 72185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_249_72302_72367(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic)
                {
                    var return_v = this_param.ApplySourceSuppressions(diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 72302, 72367);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_249_71978_71989_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 71978, 71989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 71409, 72436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 71409, 72436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDiagnosticAnalyzerSuppressed(
                    DiagnosticAnalyzer analyzer,
                    CompilationOptions options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic>? onAnalyzerException = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 73066, 73854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73316, 73362);

                f_249_73316_73361(analyzer);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73378, 73495) || true) && (options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 73378, 73495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73431, 73480);

                    throw f_249_73437_73479(nameof(options));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 73378, 73495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73511, 73563);

                var
                analyzerManager = f_249_73533_73562(analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73577, 73685);

                var
                analyzerExecutor = f_249_73600_73684(onAnalyzerException, analyzerManager)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 73699, 73843);

                return f_249_73706_73842(analyzer, options, analyzerManager, analyzerExecutor, severityFilter: SeverityFilter.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 73066, 73854);

                int
                f_249_73316_73361(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    VerifyAnalyzerArgumentForStaticApis(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 73316, 73361);
                    return 0;
                }


                System.ArgumentNullException
                f_249_73437_73479(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 73437, 73479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_249_73533_73562(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 73533, 73562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                f_249_73600_73684(System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
                onAnalyzerException, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager)
                {
                    var return_v = AnalyzerExecutor.CreateForSupportedDiagnostics(onAnalyzerException, analyzerManager);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 73600, 73684);
                    return return_v;
                }


                bool
                f_249_73706_73842(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter)
                {
                    var return_v = AnalyzerDriver.IsDiagnosticAnalyzerSuppressed(analyzer, options, analyzerManager, analyzerExecutor, severityFilter: severityFilter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 73706, 73842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 73066, 73854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 73066, 73854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Obsolete("This API is no longer required to be invoked. Analyzer state is automatically cleaned up when CompilationWithAnalyzers instance is released.")]
        public static void ClearAnalyzerState(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(249, 74258, 74527);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(249, 74258, 74527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 74258, 74527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 74258, 74527);
            }
        }

        public async Task<AnalyzerTelemetryInfo> GetAnalyzerTelemetryInfoAsync(DiagnosticAnalyzer analyzer, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 74795, 75611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 74956, 74989);

                f_249_74956_74988(this, analyzer);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75041, 75146);

                    var
                    actionCounts = await f_249_75066_75145(f_249_75066_75123(this, analyzer, cancellationToken), false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75164, 75235);

                    var
                    suppressionActionCounts = (DynAbs.Tracing.TraceSender.Conditional_F1(249, 75194, 75226) || ((analyzer is DiagnosticSuppressor && DynAbs.Tracing.TraceSender.Conditional_F2(249, 75229, 75230)) || DynAbs.Tracing.TraceSender.Conditional_F3(249, 75233, 75234))) ? 1 : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75253, 75308);

                    var
                    executionTime = f_249_75273_75307(this, analyzer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75326, 75413);

                    return f_249_75333_75412(actionCounts, suppressionActionCounts, executionTime);
                }
                catch (Exception e) when (f_249_75468_75514(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(249, 75442, 75600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75548, 75585);

                    throw f_249_75554_75584();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(249, 75442, 75600);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 74795, 75611);

                int
                f_249_74956_74988(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    this_param.VerifyAnalyzerArgument(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 74956, 74988);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_75066_75123(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerActionCountsAsync(analyzer, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75066, 75123);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_75066_75145(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75066, 75145);
                    return return_v;
                }


                System.TimeSpan
                f_249_75273_75307(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionTime(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75273, 75307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo
                f_249_75333_75412(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                actionCounts, int
                suppressionActionCounts, System.TimeSpan
                executionTime)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerTelemetryInfo(actionCounts, suppressionActionCounts, executionTime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75333, 75412);
                    return return_v;
                }


                bool
                f_249_75468_75514(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75468, 75514);
                    return return_v;
                }


                System.Exception
                f_249_75554_75584()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 75554, 75584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 74795, 75611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 74795, 75611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<AnalyzerActionCounts> GetAnalyzerActionCountsAsync(DiagnosticAnalyzer analyzer, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 75738, 76381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75898, 75928);

                AnalyzerDriver?
                driver = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 75978, 76057);

                    driver = await f_249_75993_76056(f_249_75993_76034(this, cancellationToken), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76075, 76124);

                    cancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76142, 76267);

                    return await f_249_76155_76266(f_249_76155_76244(_analysisState, analyzer, driver, cancellationToken), false);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(249, 76296, 76370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76336, 76355);

                    f_249_76336_76354(this, driver);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(249, 76296, 76370);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 75738, 76381);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_75993_76034(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerDriverAsync(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75993, 76034);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                f_249_75993_76056(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 75993, 76056);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_76155_76244(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOrComputeAnalyzerActionCountsAsync(analyzer, driver, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 76155, 76244);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_249_76155_76266(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 76155, 76266);
                    return return_v;
                }


                int
                f_249_76336_76354(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?
                driver)
                {
                    this_param.FreeDriver(driver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 76336, 76354);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 75738, 76381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 75738, 76381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TimeSpan GetAnalyzerExecutionTime(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(249, 76501, 76798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76596, 76706) || true) && (f_249_76600_76642_M(!_analysisOptions.LogAnalyzerExecutionTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(249, 76596, 76706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76676, 76691);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(249, 76596, 76706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 76722, 76787);

                return f_249_76729_76786(_analysisResultBuilder, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(249, 76501, 76798);

                bool
                f_249_76600_76642_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 76600, 76642);
                    return return_v;
                }


                System.TimeSpan
                f_249_76729_76786(Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionTime(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 76729, 76786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(249, 76501, 76798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 76501, 76798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationWithAnalyzers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(249, 677, 76805);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(249, 3861, 3915);
            s_EmptyEventQueue = f_249_3881_3915(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(249, 677, 76805);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(249, 677, 76805);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(249, 677, 76805);

        Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostic>
        f_249_2324_2355()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.Diagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 2324, 2355);
            return return_v;
        }


        object
        f_249_2583_2595()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 2583, 2595);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
        f_249_3711_3797(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 3711, 3797);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
        f_249_3881_3915()
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 3881, 3915);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        f_249_5583_5779(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
        options, System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>?
        onAnalyzerException, System.Func<System.Exception, bool>?
        analyzerExceptionFilter, bool
        concurrentAnalysis, bool
        logAnalyzerExecutionTime, bool
        reportSuppressedDiagnostics)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions(options, onAnalyzerException: onAnalyzerException, analyzerExceptionFilter: analyzerExceptionFilter, concurrentAnalysis: concurrentAnalysis, logAnalyzerExecutionTime: logAnalyzerExecutionTime, reportSuppressedDiagnostics: reportSuppressedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 5583, 5779);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_249_5559_5570_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(249, 5373, 5821);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_249_6415_6426_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(249, 6243, 6520);
            return return_v;
        }


        static int
        f_249_6746_6802(Microsoft.CodeAnalysis.Compilation
        compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        analysisOptions)
        {
            VerifyArguments(compilation, analyzers, analysisOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 6746, 6802);
            return 0;
        }


        static Microsoft.CodeAnalysis.CompilationOptions
        f_249_6875_6894(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 6875, 6894);
            return return_v;
        }


        static bool
        f_249_6927_6970(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        this_param)
        {
            var return_v = this_param.ReportSuppressedDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 6927, 6970);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CompilationOptions
        f_249_6875_6971(Microsoft.CodeAnalysis.CompilationOptions
        this_param, bool
        value)
        {
            var return_v = this_param.WithReportSuppressedDiagnostics(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 6875, 6971);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_249_6833_6972(Microsoft.CodeAnalysis.Compilation
        this_param, Microsoft.CodeAnalysis.CompilationOptions
        options)
        {
            var return_v = this_param.WithOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 6833, 6972);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
        f_249_7017_7051()
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7017, 7051);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_249_6833_7052(Microsoft.CodeAnalysis.Compilation
        this_param, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
        semanticModelProvider)
        {
            var return_v = this_param.WithSemanticModelProvider((Microsoft.CodeAnalysis.SemanticModelProvider)semanticModelProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 6833, 7052);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
        f_249_7086_7120()
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7086, 7120);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_249_6833_7121(Microsoft.CodeAnalysis.Compilation
        this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
        eventQueue)
        {
            var return_v = this_param.WithEventQueue(eventQueue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 6833, 7121);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
        f_249_7337_7370(Microsoft.CodeAnalysis.Compilation
        compilation)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7337, 7370);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
        f_249_7431_7469(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.CompilationData
        this_param)
        {
            var return_v = this_param.SemanticModelProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7431, 7469);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CompilationOptions
        f_249_7471_7491(Microsoft.CodeAnalysis.Compilation
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7471, 7491);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalysisState
        f_249_7402_7492(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers, Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
        semanticModelProvider, Microsoft.CodeAnalysis.CompilationOptions
        compilationOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState(analyzers, semanticModelProvider, compilationOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7402, 7492);
            return return_v;
        }


        static bool
        f_249_7558_7598(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        this_param)
        {
            var return_v = this_param.LogAnalyzerExecutionTime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7558, 7598);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
        f_249_7611_7635(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7611, 7635);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
        f_249_7611_7652_M(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7611, 7652);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder
        f_249_7532_7693(bool
        logAnalyzerExecutionTime, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        additionalFiles)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisResultBuilder(logAnalyzerExecutionTime, analyzers, additionalFiles);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7532, 7693);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
        f_249_7727_7757(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7727, 7757);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>
        f_249_7786_7923(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 7786, 7923);
            return return_v;
        }


        static bool
        f_249_7973_8007(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        this_param)
        {
            var return_v = this_param.ConcurrentAnalysis;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 7973, 8007);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>
        f_249_8010_8088()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, System.Tuple<System.Threading.Tasks.Task, System.Threading.CancellationTokenSource>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 8010, 8088);
            return return_v;
        }


        static bool
        f_249_8141_8175(Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
        this_param)
        {
            var return_v = this_param.ConcurrentAnalysis;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(249, 8141, 8175);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Threading.Tasks.Task, int>
        f_249_8178_8205()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Threading.Tasks.Task, int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(249, 8178, 8205);
            return return_v;
        }

    }
}
