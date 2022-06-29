// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalysisState
    {
        private readonly SemaphoreSlim _gate;

        private readonly ImmutableDictionary<DiagnosticAnalyzer, int> _analyzerStateMap;

        private readonly ImmutableArray<PerAnalyzerState> _analyzerStates;

        private readonly Dictionary<SyntaxTree, HashSet<CompilationEvent>> _pendingSourceEvents;

        private readonly HashSet<CompilationEvent> _pendingNonSourceEvents;

        private ImmutableDictionary<DiagnosticAnalyzer, AnalyzerActionCounts>? _lazyAnalyzerActionCountsMap;

        private ImmutableDictionary<DiagnosticAnalyzer, AnalyzerActionCounts> AnalyzerActionCountsMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 2252, 2408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2288, 2339);

                    f_212_2288_2338(_lazyAnalyzerActionCountsMap != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2357, 2393);

                    return _lazyAnalyzerActionCountsMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(212, 2252, 2408);

                    int
                    f_212_2288_2338(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 2288, 2338);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 2134, 2419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 2134, 2419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly HashSet<ISymbol> _partialSymbolsWithGeneratedSourceEvents;

        private readonly CachingSemanticModelProvider _semanticModelProvider;

        private readonly CompilationOptions _compilationOptions;

        private readonly ObjectPool<HashSet<CompilationEvent>> _compilationEventsPool;

        private readonly HashSet<CompilationEvent> _pooledEventsWithAnyActionsSet;

        public AnalysisState(ImmutableArray<DiagnosticAnalyzer> analyzers, CachingSemanticModelProvider semanticModelProvider, CompilationOptions compilationOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(212, 2837, 3722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 832, 837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 1104, 1121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 1617, 1637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 1900, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2095, 2123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2465, 2505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2562, 2584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2631, 2650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2718, 2740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 2794, 2824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3019, 3062);

                _gate = f_212_3027_3061(initialCount: 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3076, 3151);

                _analyzerStateMap = f_212_3096_3150(analyzers, out _analyzerStates);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3165, 3212);

                _semanticModelProvider = semanticModelProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3226, 3267);

                _compilationOptions = compilationOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3281, 3360);

                _pendingSourceEvents = f_212_3304_3359();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3374, 3432);

                _pendingNonSourceEvents = f_212_3400_3431();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3446, 3512);

                _partialSymbolsWithGeneratedSourceEvents = f_212_3489_3511();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3526, 3632);

                _compilationEventsPool = f_212_3551_3631(() => new HashSet<CompilationEvent>());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3646, 3711);

                _pooledEventsWithAnyActionsSet = f_212_3679_3710();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(212, 2837, 3722);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 2837, 3722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 2837, 3722);
            }
        }

        private static ImmutableDictionary<DiagnosticAnalyzer, int> CreateAnalyzerStateMap(ImmutableArray<DiagnosticAnalyzer> analyzers, out ImmutableArray<PerAnalyzerState> analyzerStates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(212, 3734, 4978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 3940, 4033);

                var
                analyzerStateDataPool = f_212_3968_4032(() => new AnalyzerStateData())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4047, 4173);

                var
                declarationAnalyzerStateDataPool = f_212_4086_4172(() => new DeclarationAnalyzerStateData())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4187, 4370);

                var
                currentlyAnalyzingDeclarationsMapPool = f_212_4231_4369(() => new Dictionary<int, DeclarationAnalyzerStateData>())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4386, 4455);

                var
                statesBuilder = f_212_4406_4454()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4469, 4540);

                var
                map = f_212_4479_4539()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4554, 4568);

                var
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4582, 4867);
                    foreach (var analyzer in f_212_4607_4616_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 4582, 4867);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4650, 4786);

                        f_212_4650_4785(statesBuilder, f_212_4668_4784(analyzerStateDataPool, declarationAnalyzerStateDataPool, currentlyAnalyzingDeclarationsMapPool));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4804, 4826);

                        map[analyzer] = index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4844, 4852);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 4582, 4867);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4883, 4928);

                analyzerStates = f_212_4900_4927(statesBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 4942, 4967);

                return f_212_4949_4966(map);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(212, 3734, 4978);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                f_212_3968_4032(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>.Factory
                factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3968, 4032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                f_212_4086_4172(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>.Factory
                factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4086, 4172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>
                f_212_4231_4369(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>.Factory
                factory)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>(factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4231, 4369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>.Builder
                f_212_4406_4454()
                {
                    var return_v = ImmutableArray.CreateBuilder<PerAnalyzerState>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4406, 4454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>.Builder
                f_212_4479_4539()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4479, 4539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_4668_4784(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                analyzerStateDataPool, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                declarationAnalyzerStateDataPool, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>
                currentlyAnalyzingDeclarationsMapPool)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState(analyzerStateDataPool, declarationAnalyzerStateDataPool, currentlyAnalyzingDeclarationsMapPool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4668, 4784);
                    return return_v;
                }


                int
                f_212_4650_4785(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4650, 4785);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_4607_4616_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4607, 4616);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                f_212_4900_4927(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4900, 4927);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                f_212_4949_4966(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 4949, 4966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 3734, 4978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 3734, 4978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PerAnalyzerState GetAnalyzerState(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 4990, 5180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 5085, 5125);

                var
                index = f_212_5097_5124(_analyzerStateMap, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 5139, 5169);

                return _analyzerStates[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 4990, 5180);

                int
                f_212_5097_5124(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 5097, 5124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 4990, 5180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 4990, 5180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task OnCompilationEventsGeneratedAsync(
                    Func<AsyncQueue<CompilationEvent>, ImmutableArray<AdditionalText>, ImmutableArray<CompilationEvent>> getCompilationEvents,
                    AsyncQueue<CompilationEvent> eventQueue,
                    ImmutableArray<AdditionalText> additionalFiles,
                    AnalyzerDriver driver,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 5192, 6266);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 5642, 5740);

                    await f_212_5648_5739(f_212_5648_5717(this, driver, cancellationToken), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 5760, 6068);
                    using (_gate.DisposableWait(cancellationToken))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 5962, 6049);

                        f_212_5962_6048(this, f_212_5998_6047(getCompilationEvents, eventQueue, additionalFiles));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(212, 5760, 6068);
                    }
                }
                catch (Exception e) when (f_212_6123_6169(e))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(212, 6097, 6255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6203, 6240);

                    throw f_212_6209_6239();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(212, 6097, 6255);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 5192, 6266);

                System.Threading.Tasks.Task
                f_212_5648_5717(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.EnsureAnalyzerActionCountsInitializedAsync(driver, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 5648, 5717);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_212_5648_5739(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 5648, 5739);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_5998_6047(System.Func<Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.Diagnostics.AsyncQueue<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                arg1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 5998, 6047);
                    return return_v;
                }


                int
                f_212_5962_6048(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                compilationEvents)
                {
                    this_param.OnCompilationEventsGenerated_NoLock(compilationEvents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 5962, 6048);
                    return 0;
                }


                bool
                f_212_6123_6169(System.Exception
                exception)
                {
                    var return_v = FatalError.ReportAndPropagateUnlessCanceled(exception);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 6123, 6169);
                    return return_v;
                }


                System.Exception
                f_212_6209_6239()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 6209, 6239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 5192, 6266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 5192, 6266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void OnCompilationEventsGenerated_NoLock(ImmutableArray<CompilationEvent> compilationEvents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 6278, 8766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6468, 6509);

                f_212_6468_6508(this, compilationEvents);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6589, 6637);

                ArrayBuilder<ISymbol>?
                newPartialSymbols = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6651, 6707);

                f_212_6651_6706(f_212_6664_6700(_pooledEventsWithAnyActionsSet) == 0);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6721, 8170);
                    foreach (var kvp in f_212_6741_6758_I(_analyzerStateMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 6721, 8170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6792, 6815);

                        var
                        analyzer = kvp.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6833, 6880);

                        var
                        analyzerState = _analyzerStates[kvp.Value]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6898, 6951);

                        var
                        actionCounts = f_212_6917_6950(f_212_6917_6940(), analyzer)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 6971, 8155);
                            foreach (var compilationEvent in f_212_7004_7021_I(compilationEvents))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 6971, 8155);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7063, 8136) || true) && (f_212_7067_7117(compilationEvent, actionCounts))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 7063, 8136);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7167, 7220);

                                    f_212_7167_7219(_pooledEventsWithAnyActionsSet, compilationEvent);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7248, 7325);

                                    var
                                    symbolDeclaredEvent = compilationEvent as SymbolDeclaredCompilationEvent
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7351, 8011) || true) && (f_212_7355_7408_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbolDeclaredEvent, 212, 7355, 7408)?.DeclaringSyntaxReferences.Length) > 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 7351, 8011);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7470, 7984) || true) && (f_212_7474_7551(_partialSymbolsWithGeneratedSourceEvents, f_212_7524_7550(symbolDeclaredEvent)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 7470, 7984);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7672, 7681);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 7470, 7984);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 7470, 7984);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7811, 7869);

                                            newPartialSymbols ??= f_212_7833_7868();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 7903, 7953);

                                            f_212_7903_7952(newPartialSymbols, f_212_7925_7951(symbolDeclaredEvent));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 7470, 7984);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 7351, 8011);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8039, 8113);

                                    f_212_8039_8112(
                                                            analyzerState, compilationEvent, actionCounts);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 7063, 8136);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(212, 6971, 8155);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 1185);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 1185);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 6721, 8170);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 1450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 1450);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8186, 8551);
                    foreach (var compilationEvent in f_212_8219_8236_I(compilationEvents))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 8186, 8551);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8270, 8536) || true) && (!f_212_8275_8330(_pooledEventsWithAnyActionsSet, compilationEvent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 8270, 8536);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8464, 8517);

                            f_212_8464_8516(this, compilationEvent, add: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 8270, 8536);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 8186, 8551);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 366);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8567, 8755) || true) && (newPartialSymbols != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 8567, 8755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8630, 8697);

                    f_212_8630_8696(_partialSymbolsWithGeneratedSourceEvents, newPartialSymbols);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8715, 8740);

                    f_212_8715_8739(newPartialSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 8567, 8755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 6278, 8766);

                int
                f_212_6468_6508(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                compilationEvents)
                {
                    this_param.AddToEventsMap_NoLock(compilationEvents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 6468, 6508);
                    return 0;
                }


                int
                f_212_6664_6700(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 6664, 6700);
                    return return_v;
                }


                int
                f_212_6651_6706(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 6651, 6706);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_212_6917_6940()
                {
                    var return_v = AnalyzerActionCountsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 6917, 6940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                f_212_6917_6950(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 6917, 6950);
                    return return_v;
                }


                bool
                f_212_7067_7117(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                actionCounts)
                {
                    var return_v = HasActionsForEvent(compilationEvent, actionCounts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7067, 7117);
                    return return_v;
                }


                bool
                f_212_7167_7219(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7167, 7219);
                    return return_v;
                }


                int?
                f_212_7355_7408_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 7355, 7408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_212_7524_7550(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 7524, 7550);
                    return return_v;
                }


                bool
                f_212_7474_7551(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                this_param, Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7474, 7551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                f_212_7833_7868()
                {
                    var return_v = ArrayBuilder<ISymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7833, 7868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_212_7925_7951(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 7925, 7951);
                    return return_v;
                }


                int
                f_212_7903_7952(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                this_param, Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7903, 7952);
                    return 0;
                }


                int
                f_212_8039_8112(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                actionCounts)
                {
                    this_param.OnCompilationEventGenerated(compilationEvent, actionCounts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8039, 8112);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_7004_7021_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 7004, 7021);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                f_212_6741_6758_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 6741, 6758);
                    return return_v;
                }


                bool
                f_212_8275_8330(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8275, 8330);
                    return return_v;
                }


                int
                f_212_8464_8516(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, bool
                add)
                {
                    this_param.UpdateEventsMap_NoLock(compilationEvent, add: add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8464, 8516);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_8219_8236_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8219, 8236);
                    return return_v;
                }


                bool
                f_212_8630_8696(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                set, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                values)
                {
                    var return_v = set.AddAll<Microsoft.CodeAnalysis.ISymbol>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8630, 8696);
                    return return_v;
                }


                int
                f_212_8715_8739(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8715, 8739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 6278, 8766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 6278, 8766);
            }
        }

        private void AddToEventsMap_NoLock(ImmutableArray<CompilationEvent> compilationEvents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 8778, 9051);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8889, 9040);
                    foreach (var compilationEvent in f_212_8922_8939_I(compilationEvents))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 8889, 9040);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 8973, 9025);

                        f_212_8973_9024(this, compilationEvent, add: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 8889, 9040);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 8778, 9051);

                int
                f_212_8973_9024(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, bool
                add)
                {
                    this_param.UpdateEventsMap_NoLock(compilationEvent, add: add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8973, 9024);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_8922_8939_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 8922, 8939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 8778, 9051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 8778, 9051);
            }
        }

        private void UpdateEventsMap_NoLock(CompilationEvent compilationEvent, bool add)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 9063, 11966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9168, 11406);

                switch (compilationEvent)
                {

                    case SymbolDeclaredCompilationEvent symbolEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9168, 11406);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9515, 10130);
                            foreach (var location in f_212_9540_9568_I(f_212_9540_9568(f_212_9540_9558(symbolEvent))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9515, 10130);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9618, 10107) || true) && (f_212_9622_9641(location) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9618, 10107);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9707, 10080) || true) && (add)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9707, 10080);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9780, 9848);

                                        f_212_9780_9847(this, f_212_9809_9828(location), compilationEvent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9707, 10080);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9707, 10080);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 9978, 10049);

                                        f_212_9978_10048(this, f_212_10010_10029(location), compilationEvent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9707, 10080);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9618, 10107);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9515, 10130);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 616);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 616);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(212, 10154, 10160);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9168, 11406);

                    case CompilationUnitCompletedEvent compilationUnitCompletedEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9168, 11406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10337, 10394);

                        var
                        tree = f_212_10348_10393(compilationUnitCompletedEvent)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10416, 10703) || true) && (add)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 10416, 10703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10473, 10526);

                            f_212_10473_10525(this, tree, compilationEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 10416, 10703);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 10416, 10703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10624, 10680);

                            f_212_10624_10679(this, tree, compilationEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 10416, 10703);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(212, 10727, 10733);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9168, 11406);

                    case CompilationStartedEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9168, 11406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10804, 10868);

                        f_212_10804_10867(compilationEvent, add);
                        DynAbs.Tracing.TraceSender.TraceBreak(212, 10890, 10896);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9168, 11406);

                    case CompilationCompletedEvent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9168, 11406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 10969, 11033);

                        f_212_10969_11032(compilationEvent, add);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11055, 11200) || true) && (!add)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 11055, 11200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11113, 11177);

                            f_212_11113_11176(_semanticModelProvider, f_212_11147_11175(compilationEvent));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 11055, 11200);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(212, 11224, 11230);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9168, 11406);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 9168, 11406);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11280, 11391);

                        throw f_212_11286_11390("Unexpected compilation event of type " + f_212_11358_11389(f_212_11358_11384(compilationEvent)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 9168, 11406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11422, 11429);

                return;

                void compilationStartedOrCompletedEventCommon(CompilationEvent compilationEvent, bool add)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 11445, 11955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11568, 11675);

                        f_212_11568_11674(compilationEvent is CompilationStartedEvent || (DynAbs.Tracing.TraceSender.Expression_False(212, 11581, 11673) || compilationEvent is CompilationCompletedEvent));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11695, 11940) || true) && (add)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 11695, 11940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11744, 11790);

                            f_212_11744_11789(_pendingNonSourceEvents, compilationEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 11695, 11940);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 11695, 11940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 11872, 11921);

                            f_212_11872_11920(_pendingNonSourceEvents, compilationEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 11695, 11940);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(212, 11445, 11955);

                        int
                        f_212_11568_11674(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11568, 11674);
                            return 0;
                        }


                        bool
                        f_212_11744_11789(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11744, 11789);
                            return return_v;
                        }


                        bool
                        f_212_11872_11920(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                        this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                        item)
                        {
                            var return_v = this_param.Remove(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11872, 11920);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 11445, 11955);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 11445, 11955);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 9063, 11966);

                Microsoft.CodeAnalysis.ISymbol
                f_212_9540_9558(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 9540, 9558);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_212_9540_9568(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 9540, 9568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_212_9622_9641(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 9622, 9641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_212_9809_9828(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 9809, 9828);
                    return return_v;
                }


                int
                f_212_9780_9847(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.AddPendingSourceEvent_NoLock(tree, compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 9780, 9847);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_212_10010_10029(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 10010, 10029);
                    return return_v;
                }


                int
                f_212_9978_10048(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.RemovePendingSourceEvent_NoLock(tree, compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 9978, 10048);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_212_9540_9568_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 9540, 9568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_212_10348_10393(Microsoft.CodeAnalysis.Diagnostics.CompilationUnitCompletedEvent
                this_param)
                {
                    var return_v = this_param.CompilationUnit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 10348, 10393);
                    return return_v;
                }


                int
                f_212_10473_10525(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.AddPendingSourceEvent_NoLock(tree, compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 10473, 10525);
                    return 0;
                }


                int
                f_212_10624_10679(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.RemovePendingSourceEvent_NoLock(tree, compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 10624, 10679);
                    return 0;
                }


                int
                f_212_10804_10867(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, bool
                add)
                {
                    compilationStartedOrCompletedEventCommon(compilationEvent, add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 10804, 10867);
                    return 0;
                }


                int
                f_212_10969_11032(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, bool
                add)
                {
                    compilationStartedOrCompletedEventCommon(compilationEvent, add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 10969, 11032);
                    return 0;
                }


                Microsoft.CodeAnalysis.Compilation
                f_212_11147_11175(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 11147, 11175);
                    return return_v;
                }


                int
                f_212_11113_11176(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ClearCache(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11113, 11176);
                    return 0;
                }


                System.Type
                f_212_11358_11384(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11358, 11384);
                    return return_v;
                }


                string
                f_212_11358_11389(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 11358, 11389);
                    return return_v;
                }


                System.InvalidOperationException
                f_212_11286_11390(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 11286, 11390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 9063, 11966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 9063, 11966);
            }
        }

        private void AddPendingSourceEvent_NoLock(SyntaxTree tree, CompilationEvent compilationEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 11978, 12471);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> currentEvents = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12096, 12408) || true) && (!f_212_12101_12162(_pendingSourceEvents, tree, out currentEvents))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 12096, 12408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12196, 12244);

                    currentEvents = f_212_12212_12243();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12262, 12305);

                    _pendingSourceEvents[tree] = currentEvents;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12323, 12393);

                    f_212_12323_12392(_semanticModelProvider, tree, f_212_12363_12391(compilationEvent));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 12096, 12408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12424, 12460);

                f_212_12424_12459(
                            currentEvents, compilationEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 11978, 12471);

                bool
                f_212_12101_12162(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12101, 12162);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_12212_12243()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12212, 12243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_212_12363_12391(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 12363, 12391);
                    return return_v;
                }


                int
                f_212_12323_12392(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ClearCache(tree, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12323, 12392);
                    return 0;
                }


                bool
                f_212_12424_12459(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12424, 12459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 11978, 12471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 11978, 12471);
            }
        }

        private void RemovePendingSourceEvent_NoLock(SyntaxTree tree, CompilationEvent compilationEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 12483, 12986);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> currentEvents = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12604, 12975) || true) && (f_212_12608_12669(_pendingSourceEvents, tree, out currentEvents))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 12604, 12975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12703, 12960) || true) && (f_212_12707_12745(currentEvents, compilationEvent) && (DynAbs.Tracing.TraceSender.Expression_True(212, 12707, 12773) && f_212_12749_12768(currentEvents) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 12703, 12960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12815, 12849);

                        f_212_12815_12848(_pendingSourceEvents, tree);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 12871, 12941);

                        f_212_12871_12940(_semanticModelProvider, tree, f_212_12911_12939(compilationEvent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 12703, 12960);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 12604, 12975);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 12483, 12986);

                bool
                f_212_12608_12669(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12608, 12669);
                    return return_v;
                }


                bool
                f_212_12707_12745(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12707, 12745);
                    return return_v;
                }


                int
                f_212_12749_12768(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 12749, 12768);
                    return return_v;
                }


                bool
                f_212_12815_12848(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12815, 12848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_212_12911_12939(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 12911, 12939);
                    return return_v;
                }


                int
                f_212_12871_12940(Microsoft.CodeAnalysis.Diagnostics.CachingSemanticModelProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ClearCache(tree, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 12871, 12940);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 12483, 12986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 12483, 12986);
            }
        }

        private async Task EnsureAnalyzerActionCountsInitializedAsync(AnalyzerDriver driver, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 12998, 13764);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13144, 13753) || true) && (_lazyAnalyzerActionCountsMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 13144, 13753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13218, 13310);

                    var
                    builder = f_212_13232_13309()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13328, 13627);
                        foreach (var (analyzer, _) in f_212_13358_13375_I(_analyzerStateMap))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 13328, 13627);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13417, 13550);

                            var
                            actionCounts = await f_212_13442_13549(f_212_13442_13527(driver, analyzer, _compilationOptions, cancellationToken), false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13572, 13608);

                            f_212_13572_13607(builder, analyzer, actionCounts);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 13328, 13627);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 300);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13647, 13738);

                    f_212_13647_13737(ref _lazyAnalyzerActionCountsMap, f_212_13709_13730(builder), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 13144, 13753);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 12998, 13764);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>.Builder
                f_212_13232_13309()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, AnalyzerActionCounts>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13232, 13309);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_212_13442_13527(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.CompilationOptions
                compilationOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetAnalyzerActionCountsAsync(analyzer, compilationOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13442, 13527);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_212_13442_13549(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13442, 13549);
                    return return_v;
                }


                int
                f_212_13572_13607(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13572, 13607);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                f_212_13358_13375_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13358, 13375);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_212_13709_13730(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13709, 13730);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>?
                f_212_13647_13737(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>?
                location1, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                value, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13647, 13737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 12998, 13764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 12998, 13764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal async Task<AnalyzerActionCounts> GetOrComputeAnalyzerActionCountsAsync(DiagnosticAnalyzer analyzer, AnalyzerDriver driver, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 13776, 14133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 13969, 14067);

                await f_212_13975_14066(f_212_13975_14044(this, driver, cancellationToken), false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14081, 14122);

                return f_212_14088_14121(f_212_14088_14111(), analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 13776, 14133);

                System.Threading.Tasks.Task
                f_212_13975_14044(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                driver, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.EnsureAnalyzerActionCountsInitializedAsync(driver, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13975, 14044);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_212_13975_14066(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 13975, 14066);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                f_212_14088_14111()
                {
                    var return_v = AnalyzerActionCountsMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14088, 14111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                f_212_14088_14121(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14088, 14121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 13776, 14133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 13776, 14133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AnalyzerActionCounts GetAnalyzerActionCounts(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 14241, 14277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14244, 14277);
                return f_212_14244_14277(f_212_14244_14267(), analyzer); DynAbs.Tracing.TraceSender.TraceExitMethod(212, 14241, 14277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 14241, 14277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 14241, 14277);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
            f_212_14244_14267()
            {
                var return_v = AnalyzerActionCountsMap;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14244, 14267);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
            f_212_14244_14277(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts>
            this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            i0)
            {
                var return_v = this_param[i0];
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14244, 14277);
                return return_v;
            }

        }

        private static bool HasActionsForEvent(CompilationEvent compilationEvent, AnalyzerActionCounts actionCounts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(212, 14290, 14959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14423, 14948);

                return compilationEvent switch
                {
                    CompilationStartedEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14486, 14643) && DynAbs.Tracing.TraceSender.Expression_True(212, 14486, 14643))
    => f_212_14513_14549(actionCounts) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(212, 14513, 14596) || f_212_14557_14592(actionCounts) > 0) || (DynAbs.Tracing.TraceSender.Expression_False(212, 14513, 14643) || f_212_14600_14639(actionCounts) > 0),
                    CompilationCompletedEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14662, 14734) && DynAbs.Tracing.TraceSender.Expression_True(212, 14662, 14734))
    => f_212_14691_14730(actionCounts) > 0,
                    SymbolDeclaredCompilationEvent when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14753, 14866) && DynAbs.Tracing.TraceSender.Expression_True(212, 14753, 14866))
    => f_212_14787_14818(actionCounts) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(212, 14787, 14866) || f_212_14826_14866(actionCounts)),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 14885, 14932) && DynAbs.Tracing.TraceSender.Expression_True(212, 14885, 14932))
    => f_212_14890_14928(actionCounts) > 0
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(212, 14290, 14959);

                int
                f_212_14513_14549(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.CompilationActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14513, 14549);
                    return return_v;
                }


                int
                f_212_14557_14592(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.SyntaxTreeActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14557, 14592);
                    return return_v;
                }


                int
                f_212_14600_14639(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.AdditionalFileActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14600, 14639);
                    return return_v;
                }


                int
                f_212_14691_14730(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.CompilationEndActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14691, 14730);
                    return return_v;
                }


                int
                f_212_14787_14818(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.SymbolActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14787, 14818);
                    return return_v;
                }


                bool
                f_212_14826_14866(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.HasAnyExecutableCodeActions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14826, 14866);
                    return return_v;
                }


                int
                f_212_14890_14928(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                this_param)
                {
                    var return_v = this_param.SemanticModelActionsCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 14890, 14928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 14290, 14959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 14290, 14959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task OnSymbolDeclaredEventProcessedAsync(
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    Func<ISymbol, DiagnosticAnalyzer, Task> onSymbolAndMembersProcessedAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 14971, 15650);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 15262, 15639);
                    foreach (var analyzer in f_212_15287_15296_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 15262, 15639);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 15330, 15377);

                        var
                        analyzerState = f_212_15350_15376(this, analyzer)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 15395, 15624) || true) && (f_212_15399_15464(analyzerState, symbolDeclaredEvent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 15395, 15624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 15506, 15605);

                            await f_212_15512_15604(f_212_15512_15582(onSymbolAndMembersProcessedAsync, f_212_15545_15571(symbolDeclaredEvent), analyzer), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 15395, 15624);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 15262, 15639);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 378);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 14971, 15650);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_15350_15376(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 15350, 15376);
                    return return_v;
                }


                bool
                f_212_15399_15464(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent)
                {
                    var return_v = this_param.OnSymbolDeclaredEventProcessed(symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 15399, 15464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_212_15545_15571(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 15545, 15571);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_212_15512_15582(System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.Tasks.Task>
                this_param, Microsoft.CodeAnalysis.ISymbol
                arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 15512, 15582);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_212_15512_15604(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 15512, 15604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_15287_15296_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 15287, 15296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 14971, 15650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 14971, 15650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task OnCompilationEventProcessedAsync(CompilationEvent compilationEvent, ImmutableArray<DiagnosticAnalyzer> analyzers, Func<ISymbol, DiagnosticAnalyzer, Task> onSymbolAndMembersProcessedAsync)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 15974, 17166);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 16296, 16549) || true) && (compilationEvent is SymbolDeclaredCompilationEvent symbolDeclaredEvent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 16296, 16549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 16404, 16534);

                    await f_212_16410_16533(f_212_16410_16511(this, symbolDeclaredEvent, analyzers, onSymbolAndMembersProcessedAsync), false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 16296, 16549);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 16633, 16847);
                    foreach (var analyzerState in f_212_16663_16678_I(_analyzerStates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 16633, 16847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 16712, 16832) || true) && (!f_212_16717_16764(analyzerState, compilationEvent))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 16712, 16832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 16806, 16813);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 16712, 16832);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 16633, 16847);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17024, 17155);
                using (_gate.DisposableWait())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17087, 17140);

                    f_212_17087_17139(this, compilationEvent, add: false);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(212, 17024, 17155);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 15974, 17166);

                System.Threading.Tasks.Task
                f_212_16410_16511(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.Tasks.Task>
                onSymbolAndMembersProcessedAsync)
                {
                    var return_v = this_param.OnSymbolDeclaredEventProcessedAsync(symbolDeclaredEvent, analyzers, onSymbolAndMembersProcessedAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 16410, 16511);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable
                f_212_16410_16533(System.Threading.Tasks.Task
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 16410, 16533);
                    return return_v;
                }


                bool
                f_212_16717_16764(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    var return_v = this_param.IsEventAnalyzed(compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 16717, 16764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                f_212_16663_16678_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 16663, 16678);
                    return return_v;
                }


                int
                f_212_17087_17139(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, bool
                add)
                {
                    this_param.UpdateEventsMap_NoLock(compilationEvent, add: add);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17087, 17139);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 15974, 17166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 15974, 17166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<CompilationEvent> GetPendingEvents(ImmutableArray<DiagnosticAnalyzer> analyzers, SyntaxTree tree, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 17312, 17647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17493, 17636);
                using (_gate.DisposableWait(cancellationToken))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17573, 17621);

                    return f_212_17580_17620(this, analyzers, tree);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(212, 17493, 17636);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 17312, 17647);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_17580_17620(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetPendingEvents_NoLock(analyzers, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17580, 17620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 17312, 17647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 17312, 17647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HashSet<CompilationEvent> GetPendingEvents_NoLock(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 17659, 18094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17787, 17840);

                var
                uniqueEvents = f_212_17806_17839(_compilationEventsPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17854, 18047);
                    foreach (var analyzer in f_212_17879_17888_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 17854, 18047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17922, 17969);

                        var
                        analyzerState = f_212_17942_17968(this, analyzer)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 17987, 18032);

                        f_212_17987_18031(analyzerState, uniqueEvents);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 17854, 18047);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18063, 18083);

                return uniqueEvents;
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 17659, 18094);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_17806_17839(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17806, 17839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_17942_17968(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17942, 17968);
                    return return_v;
                }


                int
                f_212_17987_18031(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                uniqueEvents)
                {
                    this_param.AddPendingEvents(uniqueEvents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17987, 18031);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_17879_17888_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 17879, 17888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 17659, 18094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 17659, 18094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<CompilationEvent> GetPendingEvents_NoLock(ImmutableArray<DiagnosticAnalyzer> analyzers, SyntaxTree tree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 18240, 19269);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> compilationEventsForTree = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18392, 19196) || true) && (f_212_18396_18468(_pendingSourceEvents, tree, out compilationEventsForTree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 18392, 19196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18502, 19181) || true) && (f_212_18506_18537_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(compilationEventsForTree, 212, 18506, 18537)?.Count) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 18502, 19181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18583, 18631);

                        HashSet<CompilationEvent>?
                        pendingEvents = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18705, 18756);

                            pendingEvents = f_212_18721_18755(this, analyzers);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18782, 19018) || true) && (f_212_18786_18805(pendingEvents) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 18782, 19018);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18867, 18921);

                                f_212_18867_18920(pendingEvents, compilationEventsForTree);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 18951, 18991);

                                return f_212_18958_18990(pendingEvents);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(212, 18782, 19018);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(212, 19063, 19162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 19119, 19139);

                            f_212_19119_19138(this, pendingEvents);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(212, 19063, 19162);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 18502, 19181);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 18392, 19196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 19212, 19258);

                return ImmutableArray<CompilationEvent>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 18240, 19269);

                bool
                f_212_18396_18468(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 18396, 18468);
                    return return_v;
                }


                int?
                f_212_18506_18537_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 18506, 18537);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_18721_18755(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetPendingEvents_NoLock(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 18721, 18755);
                    return return_v;
                }


                int
                f_212_18786_18805(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 18786, 18805);
                    return return_v;
                }


                int
                f_212_18867_18920(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                other)
                {
                    this_param.IntersectWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 18867, 18920);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_18958_18990(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 18958, 18990);
                    return return_v;
                }


                int
                f_212_19119_19138(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                events)
                {
                    this_param.Free(events);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 19119, 19138);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 18240, 19269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 18240, 19269);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<CompilationEvent> GetPendingEvents(
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    bool includeSourceEvents,
                    bool includeNonSourceEvents,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 19823, 20288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20095, 20277);
                using (_gate.DisposableWait(cancellationToken))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20175, 20262);

                    return f_212_20182_20261(this, analyzers, includeSourceEvents, includeNonSourceEvents);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(212, 20095, 20277);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 19823, 20288);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_20182_20261(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, bool
                includeSourceEvents, bool
                includeNonSourceEvents)
                {
                    var return_v = this_param.GetPendingEvents_NoLock(analyzers, includeSourceEvents, includeNonSourceEvents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 20182, 20261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 19823, 20288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 19823, 20288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<CompilationEvent> GetPendingEvents_NoLock(ImmutableArray<DiagnosticAnalyzer> analyzers, bool includeSourceEvents, bool includeNonSourceEvents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 20300, 21832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20490, 20559);

                HashSet<CompilationEvent>?
                pendingEvents = null
                ,
                uniqueEvents = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20609, 20660);

                    pendingEvents = f_212_20625_20659(this, analyzers);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20678, 20813) || true) && (f_212_20682_20701(pendingEvents) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 20678, 20813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20748, 20794);

                        return ImmutableArray<CompilationEvent>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 20678, 20813);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20833, 20882);

                    uniqueEvents = f_212_20848_20881(_compilationEventsPool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20902, 21290) || true) && (includeSourceEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 20902, 21290);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 20967, 21271);
                            foreach (var compilationEvents in f_212_21001_21028_I(f_212_21001_21028(_pendingSourceEvents)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 20967, 21271);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21078, 21248);
                                    foreach (var compilationEvent in f_212_21111_21128_I(compilationEvents))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 21078, 21248);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21186, 21221);

                                        f_212_21186_21220(uniqueEvents, compilationEvent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 21078, 21248);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 171);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 171);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(212, 20967, 21271);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 305);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 305);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 20902, 21290);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21310, 21561) || true) && (includeNonSourceEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 21310, 21561);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21378, 21542);
                            foreach (var compilationEvent in f_212_21411_21434_I(_pendingNonSourceEvents))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 21378, 21542);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21484, 21519);

                                f_212_21484_21518(uniqueEvents, compilationEvent);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(212, 21378, 21542);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 165);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 165);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 21310, 21561);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21581, 21623);

                    f_212_21581_21622(
                                    uniqueEvents, pendingEvents);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21641, 21680);

                    return f_212_21648_21679(uniqueEvents);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(212, 21709, 21821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21749, 21769);

                    f_212_21749_21768(this, pendingEvents);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21787, 21806);

                    f_212_21787_21805(this, uniqueEvents);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(212, 21709, 21821);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 20300, 21832);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_20625_20659(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = this_param.GetPendingEvents_NoLock(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 20625, 20659);
                    return return_v;
                }


                int
                f_212_20682_20701(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 20682, 20701);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_20848_20881(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 20848, 20881);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>.ValueCollection
                f_212_21001_21028(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 21001, 21028);
                    return return_v;
                }


                bool
                f_212_21186_21220(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21186, 21220);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_21111_21128_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21111, 21128);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>.ValueCollection
                f_212_21001_21028_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21001, 21028);
                    return return_v;
                }


                bool
                f_212_21484_21518(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21484, 21518);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_21411_21434_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21411, 21434);
                    return return_v;
                }


                int
                f_212_21581_21622(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                other)
                {
                    this_param.IntersectWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21581, 21622);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                f_212_21648_21679(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21648, 21679);
                    return return_v;
                }


                int
                f_212_21749_21768(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                events)
                {
                    this_param.Free(events);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21749, 21768);
                    return 0;
                }


                int
                f_212_21787_21805(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>?
                events)
                {
                    this_param.Free(events);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21787, 21805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 20300, 21832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 20300, 21832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Free(HashSet<CompilationEvent>? events)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 21844, 22068);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21921, 22057) || true) && (events != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 21921, 22057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 21973, 21988);

                    f_212_21973_21987(events);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22006, 22042);

                    f_212_22006_22041(_compilationEventsPool, events);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 21921, 22057);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 21844, 22068);

                int
                f_212_21973_21987(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 21973, 21987);
                    return 0;
                }


                int
                f_212_22006_22041(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 22006, 22041);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 21844, 22068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 21844, 22068);
            }
        }

        public bool HasPendingSyntaxAnalysis(AnalysisScope analysisScope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 22218, 22818);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22308, 22456) || true) && (f_212_22312_22346(analysisScope) && (DynAbs.Tracing.TraceSender.Expression_True(212, 22312, 22394) && f_212_22350_22394_M(!analysisScope.IsSyntacticSingleFileAnalysis)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 22308, 22456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22428, 22441);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 22308, 22456);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22472, 22778);
                    foreach (var analyzer in f_212_22497_22520_I(f_212_22497_22520(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 22472, 22778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22554, 22601);

                        var
                        analyzerState = f_212_22574_22600(this, analyzer)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22619, 22763) || true) && (f_212_22623_22690(analyzerState, f_212_22662_22689(analysisScope)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 22619, 22763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22732, 22744);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 22619, 22763);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 22472, 22778);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 22794, 22807);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 22218, 22818);

                bool
                f_212_22312_22346(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.IsSingleFileAnalysis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 22312, 22346);
                    return return_v;
                }


                bool
                f_212_22350_22394_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 22350, 22394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_22497_22520(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 22497, 22520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_22574_22600(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 22574, 22600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                f_212_22662_22689(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.FilterFileOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 22662, 22689);
                    return return_v;
                }


                bool
                f_212_22623_22690(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile?
                file)
                {
                    var return_v = this_param.HasPendingSyntaxAnalysis(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 22623, 22690);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_22497_22520_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 22497, 22520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 22218, 22818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 22218, 22818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasPendingSymbolAnalysis(AnalysisScope analysisScope, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 22968, 24006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23095, 23146);

                f_212_23095_23145(analysisScope.FilterFileOpt.HasValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23160, 23227);

                f_212_23160_23226(analysisScope.FilterFileOpt.Value.SourceTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23243, 23366);

                var
                symbolDeclaredEvents = f_212_23270_23365(this, analysisScope.FilterFileOpt.Value.SourceTree, cancellationToken)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23380, 23966);
                    foreach (var symbolDeclaredEvent in f_212_23416_23436_I(symbolDeclaredEvents))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 23380, 23966);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23470, 23951) || true) && (f_212_23474_23529(analysisScope, f_212_23502_23528(symbolDeclaredEvent)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 23470, 23951);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23571, 23932);
                                foreach (var analyzer in f_212_23596_23619_I(f_212_23596_23619(analysisScope)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 23571, 23932);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23669, 23716);

                                    var
                                    analyzerState = f_212_23689_23715(this, analyzer)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23742, 23909) || true) && (f_212_23746_23812(analyzerState, f_212_23785_23811(symbolDeclaredEvent)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 23742, 23909);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23870, 23882);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 23742, 23909);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 23571, 23932);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 362);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 362);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 23470, 23951);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 23380, 23966);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 23982, 23995);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 22968, 24006);

                int
                f_212_23095_23145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23095, 23145);
                    return 0;
                }


                int
                f_212_23160_23226(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23160, 23226);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                f_212_23270_23365(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetPendingSymbolDeclaredEvents(tree, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23270, 23365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_212_23502_23528(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 23502, 23528);
                    return return_v;
                }


                bool
                f_212_23474_23529(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.ShouldAnalyze(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23474, 23529);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_23596_23619(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 23596, 23619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_23689_23715(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23689, 23715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_212_23785_23811(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 23785, 23811);
                    return return_v;
                }


                bool
                f_212_23746_23812(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.HasPendingSymbolAnalysis(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23746, 23812);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_23596_23619_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23596, 23619);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                f_212_23416_23436_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 23416, 23436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 22968, 24006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 22968, 24006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<SymbolDeclaredCompilationEvent> GetPendingSymbolDeclaredEvents(SyntaxTree tree, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 24018, 24584);
                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent> compilationEvents = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 24182, 24573);
                using (_gate.DisposableWait(cancellationToken))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 24262, 24453) || true) && (!f_212_24267_24332(_pendingSourceEvents, tree, out compilationEvents))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 24262, 24453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 24374, 24434);

                        return ImmutableArray<SymbolDeclaredCompilationEvent>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 24262, 24453);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 24473, 24558);

                    return f_212_24480_24557(f_212_24480_24538(compilationEvents));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(212, 24182, 24573);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 24018, 24584);

                bool
                f_212_24267_24332(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 24267, 24332);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                f_212_24480_24538(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 24480, 24538);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                f_212_24480_24557(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 24480, 24557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 24018, 24584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 24018, 24584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryStartProcessingEvent(
                    CompilationEvent compilationEvent,
                    DiagnosticAnalyzer analyzer,
                    [NotNullWhen(true)] out AnalyzerStateData? state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 25063, 25375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 25277, 25364);

                return f_212_25284_25363(f_212_25284_25310(this, analyzer), compilationEvent, out state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 25063, 25375);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_25284_25310(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 25284, 25310);
                    return return_v;
                }


                bool
                f_212_25284_25363(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartProcessingEvent(compilationEvent, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 25284, 25363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 25063, 25375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 25063, 25375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkEventComplete(CompilationEvent compilationEvent, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 25511, 25703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 25629, 25692);

                f_212_25629_25691(f_212_25629_25655(this, analyzer), compilationEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 25511, 25703);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_25629_25655(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 25629, 25655);
                    return return_v;
                }


                int
                f_212_25629_25691(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.MarkEventComplete(compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 25629, 25691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 25511, 25703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 25511, 25703);
            }
        }

        public void MarkEventComplete(CompilationEvent compilationEvent, IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 25840, 26129);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 25972, 26118);
                    foreach (var analyzer in f_212_25997_26006_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 25972, 26118);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 26040, 26103);

                        f_212_26040_26102(f_212_26040_26066(this, analyzer), compilationEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 25972, 26118);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 25840, 26129);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_26040_26066(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 26040, 26066);
                    return return_v;
                }


                int
                f_212_26040_26102(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    this_param.MarkEventComplete(compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 26040, 26102);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_25997_26006_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 25997, 26006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 25840, 26129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 25840, 26129);
            }
        }

        public void MarkEventCompleteForUnprocessedAnalyzers(
                    CompilationEvent completedEvent,
                    AnalysisScope analysisScope,
                    HashSet<DiagnosticAnalyzer> processedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 26515, 26631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 26518, 26631);
                f_212_26518_26631(analysisScope, processedAnalyzers, MarkEventComplete, completedEvent); DynAbs.Tracing.TraceSender.TraceExitMethod(212, 26515, 26631);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 26515, 26631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 26515, 26631);
            }

            int
            f_212_26518_26631(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
            analysisScope, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            processedAnalyzers, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            markComplete, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
            arg)
            {
                MarkAnalysisCompleteForUnprocessedAnalyzers(analysisScope, processedAnalyzers, markComplete, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 26518, 26631);
                return 0;
            }

        }

        public bool IsEventComplete(CompilationEvent compilationEvent, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 26778, 26973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 26894, 26962);

                return f_212_26901_26961(f_212_26901_26927(this, analyzer), compilationEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 26778, 26973);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_26901_26927(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 26901, 26927);
                    return return_v;
                }


                bool
                f_212_26901_26961(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                compilationEvent)
                {
                    var return_v = this_param.IsEventAnalyzed(compilationEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 26901, 26961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 26778, 26973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 26778, 26973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryStartAnalyzingSymbol(ISymbol symbol, DiagnosticAnalyzer analyzer, [NotNullWhen(true)] out AnalyzerStateData? state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 27460, 27703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 27615, 27692);

                return f_212_27622_27691(f_212_27622_27648(this, analyzer), symbol, out state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 27460, 27703);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_27622_27648(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 27622, 27648);
                    return return_v;
                }


                bool
                f_212_27622_27691(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartAnalyzingSymbol(symbol, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 27622, 27691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 27460, 27703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 27460, 27703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryStartSymbolEndAnalysis(ISymbol symbol, DiagnosticAnalyzer analyzer, [NotNullWhen(true)] out AnalyzerStateData? state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 28210, 28457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 28367, 28446);

                return f_212_28374_28445(f_212_28374_28400(this, analyzer), symbol, out state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 28210, 28457);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_28374_28400(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 28374, 28400);
                    return return_v;
                }


                bool
                f_212_28374_28445(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartSymbolEndAnalysis(symbol, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 28374, 28445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 28210, 28457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 28210, 28457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkSymbolComplete(ISymbol symbol, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 28594, 28759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 28694, 28748);

                f_212_28694_28747(f_212_28694_28720(this, analyzer), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 28594, 28759);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_28694_28720(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 28694, 28720);
                    return return_v;
                }


                int
                f_212_28694_28747(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.MarkSymbolComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 28694, 28747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 28594, 28759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 28594, 28759);
            }
        }

        public void MarkSymbolCompleteForUnprocessedAnalyzers(
                    ISymbol symbol,
                    AnalysisScope analysisScope,
                    HashSet<DiagnosticAnalyzer> processedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 29130, 29239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 29133, 29239);
                f_212_29133_29239(analysisScope, processedAnalyzers, MarkSymbolComplete, symbol); DynAbs.Tracing.TraceSender.TraceExitMethod(212, 29130, 29239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 29130, 29239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 29130, 29239);
            }

            int
            f_212_29133_29239(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
            analysisScope, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            processedAnalyzers, System.Action<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            markComplete, Microsoft.CodeAnalysis.ISymbol
            arg)
            {
                MarkAnalysisCompleteForUnprocessedAnalyzers(analysisScope, processedAnalyzers, markComplete, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 29133, 29239);
                return 0;
            }

        }

        public bool IsSymbolComplete(ISymbol symbol, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 29379, 29547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 29477, 29536);

                return f_212_29484_29535(f_212_29484_29510(this, analyzer), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 29379, 29547);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_29484_29510(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 29484, 29510);
                    return return_v;
                }


                bool
                f_212_29484_29535(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsSymbolComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 29484, 29535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 29379, 29547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 29379, 29547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkSymbolEndAnalysisComplete(ISymbol symbol, IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 29697, 29964);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 29822, 29953);
                    foreach (var analyzer in f_212_29847_29856_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 29822, 29953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 29890, 29938);

                        f_212_29890_29937(this, symbol, analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 29822, 29953);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 29697, 29964);

                int
                f_212_29890_29937(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol, analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 29890, 29937);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_29847_29856_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 29847, 29856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 29697, 29964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 29697, 29964);
            }
        }

        public void MarkSymbolEndAnalysisComplete(ISymbol symbol, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 30113, 30300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 30224, 30289);

                f_212_30224_30288(f_212_30224_30250(this, analyzer), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 30113, 30300);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_30224_30250(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 30224, 30250);
                    return return_v;
                }


                int
                f_212_30224_30288(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 30224, 30288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 30113, 30300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 30113, 30300);
            }
        }

        public bool IsSymbolEndAnalysisComplete(ISymbol symbol, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 30446, 30636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 30555, 30625);

                return f_212_30562_30624(f_212_30562_30588(this, analyzer), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 30446, 30636);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_30562_30588(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 30562, 30588);
                    return return_v;
                }


                bool
                f_212_30562_30624(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = this_param.IsSymbolEndAnalysisComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 30562, 30624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 30446, 30636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 30446, 30636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryStartAnalyzingDeclaration(
                    ISymbol symbol,
                    int declarationIndex,
                    DiagnosticAnalyzer analyzer,
                    [NotNullWhen(true)] out DeclarationAnalyzerStateData? state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 31165, 31522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 31411, 31511);

                return f_212_31418_31510(f_212_31418_31444(this, analyzer), symbol, declarationIndex, out state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 31165, 31522);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_31418_31444(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 31418, 31444);
                    return return_v;
                }


                bool
                f_212_31418_31510(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartAnalyzingDeclaration(symbol, declarationIndex, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 31418, 31510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 31165, 31522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 31165, 31522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDeclarationComplete(ISymbol symbol, int declarationIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 31672, 31851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 31768, 31840);

                return f_212_31775_31839(symbol, declarationIndex, _analyzerStates);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 31672, 31851);

                bool
                f_212_31775_31839(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                analyzerStates)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>)analyzerStates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 31775, 31839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 31672, 31851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 31672, 31851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDeclarationComplete(ISymbol symbol, int declarationIndex, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 32002, 32313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32127, 32174);

                var
                analyzerState = f_212_32147_32173(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32188, 32302);

                return f_212_32195_32301(symbol, declarationIndex, f_212_32243_32300(analyzerState));
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 32002, 32313);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_32147_32173(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 32147, 32173);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                f_212_32243_32300(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 32243, 32300);
                    return return_v;
                }


                bool
                f_212_32195_32301(Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                analyzerStates)
                {
                    var return_v = IsDeclarationComplete(symbol, declarationIndex, analyzerStates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 32195, 32301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 32002, 32313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 32002, 32313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDeclarationComplete(ISymbol symbol, int declarationIndex, IEnumerable<PerAnalyzerState> analyzerStates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(212, 32325, 32747);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32475, 32708);
                    foreach (var analyzerState in f_212_32505_32519_I(analyzerStates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 32475, 32708);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32553, 32693) || true) && (!f_212_32558_32619(analyzerState, symbol, declarationIndex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 32553, 32693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32661, 32674);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 32553, 32693);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 32475, 32708);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 32724, 32736);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(212, 32325, 32747);

                bool
                f_212_32558_32619(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex)
                {
                    var return_v = this_param.IsDeclarationComplete(symbol, declarationIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 32558, 32619);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                f_212_32505_32519_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 32505, 32519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 32325, 32747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 32325, 32747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkDeclarationComplete(ISymbol symbol, int declarationIndex, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 32896, 33111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 33023, 33100);

                f_212_33023_33099(f_212_33023_33049(this, analyzer), symbol, declarationIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 32896, 33111);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_33023_33049(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33023, 33049);
                    return return_v;
                }


                int
                f_212_33023_33099(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex)
                {
                    this_param.MarkDeclarationComplete(symbol, declarationIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33023, 33099);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 32896, 33111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 32896, 33111);
            }
        }

        public void MarkDeclarationComplete(ISymbol symbol, int declarationIndex, IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 33261, 33573);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 33402, 33562);
                    foreach (var analyzer in f_212_33427_33436_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 33402, 33562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 33470, 33547);

                        f_212_33470_33546(f_212_33470_33496(this, analyzer), symbol, declarationIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 33402, 33562);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 33261, 33573);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_33470_33496(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33470, 33496);
                    return return_v;
                }


                int
                f_212_33470_33546(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, int
                declarationIndex)
                {
                    this_param.MarkDeclarationComplete(symbol, declarationIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33470, 33546);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_33427_33436_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33427, 33436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 33261, 33573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 33261, 33573);
            }
        }

        public void MarkDeclarationsComplete(ISymbol symbol, IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 33747, 34021);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 33867, 34010);
                    foreach (var analyzer in f_212_33892_33901_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 33867, 34010);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 33935, 33995);

                        f_212_33935_33994(f_212_33935_33961(this, analyzer), symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 33867, 34010);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 33747, 34021);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_33935_33961(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33935, 33961);
                    return return_v;
                }


                int
                f_212_33935_33994(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.MarkDeclarationsComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33935, 33994);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_33892_33901_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 33892, 33901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 33747, 34021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 33747, 34021);
            }
        }

        public bool TryStartSyntaxAnalysis(
                    SourceOrAdditionalFile file,
                    DiagnosticAnalyzer analyzer,
                    [NotNullWhen(true)] out AnalyzerStateData? state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 34572, 34864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 34779, 34853);

                return f_212_34786_34852(f_212_34786_34812(this, analyzer), file, out state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 34572, 34864);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_34786_34812(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 34786, 34812);
                    return return_v;
                }


                bool
                f_212_34786_34852(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                tree, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                state)
                {
                    var return_v = this_param.TryStartSyntaxAnalysis(tree, out state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 34786, 34852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 34572, 34864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 34572, 34864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkSyntaxAnalysisComplete(SourceOrAdditionalFile file, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 35013, 35205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 35134, 35194);

                f_212_35134_35193(f_212_35134_35160(this, analyzer), file);
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 35013, 35205);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_35134_35160(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 35134, 35160);
                    return return_v;
                }


                int
                f_212_35134_35193(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file)
                {
                    this_param.MarkSyntaxAnalysisComplete(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 35134, 35193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 35013, 35205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 35013, 35205);
            }
        }

        public void MarkSyntaxAnalysisComplete(SourceOrAdditionalFile file, IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 35355, 35644);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 35490, 35633);
                    foreach (var analyzer in f_212_35515_35524_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 35490, 35633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 35558, 35618);

                        f_212_35558_35617(f_212_35558_35584(this, analyzer), file);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 35490, 35633);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(212, 35355, 35644);

                Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                f_212_35558_35584(Microsoft.CodeAnalysis.Diagnostics.AnalysisState
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerState(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 35558, 35584);
                    return return_v;
                }


                int
                f_212_35558_35617(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                file)
                {
                    this_param.MarkSyntaxAnalysisComplete(file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 35558, 35617);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_35515_35524_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 35515, 35524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 35355, 35644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 35355, 35644);
            }
        }

        public void MarkSyntaxAnalysisCompleteForUnprocessedAnalyzers(
                    SourceOrAdditionalFile file,
                    AnalysisScope analysisScope,
                    HashSet<DiagnosticAnalyzer> processedAnalyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(212, 36048, 36163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36051, 36163);
                f_212_36051_36163(analysisScope, processedAnalyzers, MarkSyntaxAnalysisComplete, file); DynAbs.Tracing.TraceSender.TraceExitMethod(212, 36048, 36163);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 36048, 36163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 36048, 36163);
            }

            int
            f_212_36051_36163(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
            analysisScope, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            processedAnalyzers, System.Action<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
            markComplete, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
            arg)
            {
                MarkAnalysisCompleteForUnprocessedAnalyzers(analysisScope, processedAnalyzers, markComplete, arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36051, 36163);
                return 0;
            }

        }

        private static void MarkAnalysisCompleteForUnprocessedAnalyzers<T>(
                    AnalysisScope analysisScope,
                    HashSet<DiagnosticAnalyzer> processedAnalyzers,
                    Action<T, DiagnosticAnalyzer> markComplete,
                    T arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(212, 36176, 36896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36448, 36509);

                f_212_36448_36508(f_212_36461_36507(processedAnalyzers, analysisScope.Contains));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36523, 36641) || true) && (analysisScope.Analyzers.Length == f_212_36561_36585(processedAnalyzers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 36523, 36641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36619, 36626);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(212, 36523, 36641);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36657, 36885);
                    foreach (var analyzer in f_212_36682_36705_I(f_212_36682_36705(analysisScope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 36657, 36885);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36739, 36870) || true) && (!f_212_36744_36781(processedAnalyzers, analyzer))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(212, 36739, 36870);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(212, 36823, 36851);

                            f_212_36823_36850(markComplete, arg, analyzer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(212, 36739, 36870);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(212, 36657, 36885);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(212, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(212, 1, 229);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(212, 36176, 36896);

                bool
                f_212_36461_36507(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                source, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                predicate)
                {
                    var return_v = source.All<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36461, 36507);
                    return return_v;
                }


                int
                f_212_36448_36508(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36448, 36508);
                    return 0;
                }


                int
                f_212_36561_36585(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 36561, 36585);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_36682_36705(Microsoft.CodeAnalysis.Diagnostics.AnalysisScope
                this_param)
                {
                    var return_v = this_param.Analyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(212, 36682, 36705);
                    return return_v;
                }


                bool
                f_212_36744_36781(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36744, 36781);
                    return return_v;
                }


                int
                f_212_36823_36850(System.Action<T, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                this_param, T?
                arg1, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg2)
                {
                    this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36823, 36850);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_212_36682_36705_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 36682, 36705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(212, 36176, 36896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(212, 36176, 36896);
            }
        }

        static System.Threading.SemaphoreSlim
        f_212_3027_3061(int
        initialCount)
        {
            var return_v = new System.Threading.SemaphoreSlim(initialCount: initialCount);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3027, 3061);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, int>
        f_212_3096_3150(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState>
        analyzerStates)
        {
            var return_v = CreateAnalyzerStateMap(analyzers, out analyzerStates);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3096, 3150);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
        f_212_3304_3359()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxTree, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3304, 3359);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
        f_212_3400_3431()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3400, 3431);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
        f_212_3489_3511()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3489, 3511);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>
        f_212_3551_3631(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3551, 3631);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
        f_212_3679_3710()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(212, 3679, 3710);
            return return_v;
        }

    }
}
