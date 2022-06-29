// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerManager
    {
        private readonly ImmutableDictionary<DiagnosticAnalyzer, AnalyzerExecutionContext> _analyzerExecutionContextMap;

        public AnalyzerManager(ImmutableArray<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(236, 1476, 1656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 1435, 1463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 1569, 1645);

                _analyzerExecutionContextMap = f_236_1600_1644(this, analyzers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(236, 1476, 1656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 1476, 1656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 1476, 1656);
            }
        }

        public AnalyzerManager(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(236, 1668, 1874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 1435, 1463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 1744, 1863);

                _analyzerExecutionContextMap = f_236_1775_1862(this, f_236_1809_1861(analyzer));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(236, 1668, 1874);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 1668, 1874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 1668, 1874);
            }
        }

        private ImmutableDictionary<DiagnosticAnalyzer, AnalyzerExecutionContext> CreateAnalyzerExecutionContextMap(IEnumerable<DiagnosticAnalyzer> analyzers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 1886, 2372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2061, 2157);

                var
                builder = f_236_2075_2156()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2171, 2316);
                    foreach (var analyzer in f_236_2196_2205_I(analyzers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 2171, 2316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2239, 2301);

                        f_236_2239_2300(builder, analyzer, f_236_2261_2299(analyzer));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 2171, 2316);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2332, 2361);

                return f_236_2339_2360(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 1886, 2372);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>.Builder
                f_236_2075_2156()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<DiagnosticAnalyzer, AnalyzerExecutionContext>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2075, 2156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_2261_2299(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2261, 2299);
                    return return_v;
                }


                int
                f_236_2239_2300(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>.Builder
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                key, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2239, 2300);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                f_236_2196_2205_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2196, 2205);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
                f_236_2339_2360(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2339, 2360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 1886, 2372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 1886, 2372);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerExecutionContext GetAnalyzerExecutionContext(DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 2474, 2515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2477, 2515);
                return f_236_2477_2515(_analyzerExecutionContextMap, analyzer); DynAbs.Tracing.TraceSender.TraceExitMethod(236, 2474, 2515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 2474, 2515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 2474, 2515);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
            f_236_2477_2515(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
            this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            i0)
            {
                var return_v = this_param[i0];
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 2477, 2515);
                return return_v;
            }

        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/26778",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<HostCompilationStartAnalysisScope> GetCompilationAnalysisScopeAsync(
                    DiagnosticAnalyzer analyzer,
                    HostSessionStartAnalysisScope sessionScope,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 2528, 3160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 2936, 3005);

                var
                analyzerExecutionContext = f_236_2967_3004(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 3019, 3149);

                return await f_236_3032_3126(this, sessionScope, analyzerExecutor, analyzerExecutionContext).ConfigureAwait(false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 2528, 3160);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_2967_3004(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 2967, 3004);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                f_236_3032_3126(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                sessionScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetCompilationAnalysisScopeCoreAsync(sessionScope, analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 3032, 3126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 2528, 3160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 2528, 3160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/26778",
                    OftenCompletesSynchronously = true)]
        private async ValueTask<HostCompilationStartAnalysisScope> GetCompilationAnalysisScopeCoreAsync(
                    HostSessionStartAnalysisScope sessionScope,
                    AnalyzerExecutor analyzerExecutor,
                    AnalyzerExecutionContext analyzerExecutionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 3172, 4326);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 3642, 3767);

                    return await f_236_3655_3766(f_236_3655_3744(analyzerExecutionContext, sessionScope, analyzerExecutor), false);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(236, 3796, 4315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 4013, 4066);

                    f_236_4013_4065(                // Task to compute the scope was cancelled.
                                                    // Clear the compilation scope for analyzer, so we can attempt a retry.
                                    analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 4086, 4152);

                    analyzerExecutor.CancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 4170, 4300);

                    return await f_236_4183_4277(this, sessionScope, analyzerExecutor, analyzerExecutionContext).ConfigureAwait(false);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(236, 3796, 4315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 3172, 4326);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                f_236_3655_3744(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                sessionScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetCompilationAnalysisScopeAsync(sessionScope, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 3655, 3744);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                f_236_3655_3766(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 3655, 3766);
                    return return_v;
                }


                int
                f_236_4013_4065(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param)
                {
                    this_param.ClearCompilationScopeTask();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 4013, 4065);
                    return 0;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                f_236_4183_4277(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                sessionScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetCompilationAnalysisScopeCoreAsync(sessionScope, analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 4183, 4277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 3172, 4326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 3172, 4326);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<HostSymbolStartAnalysisScope> GetSymbolAnalysisScopeAsync(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    ImmutableArray<SymbolStartAnalyzerAction> symbolStartActions,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 4338, 4867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 4634, 4703);

                var
                analyzerExecutionContext = f_236_4665_4702(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 4717, 4856);

                return await f_236_4730_4855(f_236_4730_4833(this, symbol, symbolStartActions, analyzerExecutor, analyzerExecutionContext), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 4338, 4867);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_4665_4702(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 4665, 4702);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_4730_4833(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                symbolStartActions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetSymbolAnalysisScopeCoreAsync(symbol, symbolStartActions, analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 4730, 4833);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_4730_4855(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 4730, 4855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 4338, 4867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 4338, 4867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private async Task<HostSymbolStartAnalysisScope> GetSymbolAnalysisScopeCoreAsync(
                    ISymbol symbol,
                    ImmutableArray<SymbolStartAnalyzerAction> symbolStartActions,
                    AnalyzerExecutor analyzerExecutor,
                    AnalyzerExecutionContext analyzerExecutionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 4879, 5935);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 5237, 5371);

                    return await f_236_5250_5370(f_236_5250_5348(analyzerExecutionContext, symbol, symbolStartActions, analyzerExecutor), false);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(236, 5400, 5924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 5612, 5666);

                    f_236_5612_5665(                // Task to compute the scope was cancelled.
                                                    // Clear the symbol scope for analyzer, so we can attempt a retry.
                                    analyzerExecutionContext, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 5686, 5752);

                    analyzerExecutor.CancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 5770, 5909);

                    return await f_236_5783_5908(f_236_5783_5886(this, symbol, symbolStartActions, analyzerExecutor, analyzerExecutionContext), false);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(236, 5400, 5924);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 4879, 5935);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_5250_5348(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                symbolStartActions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSymbolAnalysisScopeAsync(symbol, symbolStartActions, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 5250, 5348);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_5250_5370(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 5250, 5370);
                    return return_v;
                }


                int
                f_236_5612_5665(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.ClearSymbolScopeTask(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 5612, 5665);
                    return 0;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_5783_5886(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                symbolStartActions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetSymbolAnalysisScopeCoreAsync(symbol, symbolStartActions, analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 5783, 5886);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_5783_5908(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 5783, 5908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 4879, 5935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 4879, 5935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        private async ValueTask<HostSessionStartAnalysisScope> GetSessionAnalysisScopeAsync(
                    DiagnosticAnalyzer analyzer,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 5947, 6469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 6263, 6332);

                var
                analyzerExecutionContext = f_236_6294_6331(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 6346, 6458);

                return await f_236_6359_6435(this, analyzerExecutor, analyzerExecutionContext).ConfigureAwait(false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 5947, 6469);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_6294_6331(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 6294, 6331);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_6359_6435(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetSessionAnalysisScopeCoreAsync(analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 6359, 6435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 5947, 6469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 5947, 6469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        private async ValueTask<HostSessionStartAnalysisScope> GetSessionAnalysisScopeCoreAsync(
                    AnalyzerExecutor analyzerExecutor,
                    AnalyzerExecutionContext analyzerExecutionContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 6481, 7538);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 6859, 6942);

                    var
                    task = f_236_6870_6941(analyzerExecutionContext, analyzerExecutor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 6960, 7000);

                    return await f_236_6973_6999(task, false);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(236, 7029, 7527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 7247, 7296);

                    f_236_7247_7295(                // Task to compute the scope was cancelled.
                                                    // Clear the entry in scope map for analyzer, so we can attempt a retry.
                                    analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 7316, 7382);

                    analyzerExecutor.CancellationToken.ThrowIfCancellationRequested();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 7400, 7512);

                    return await f_236_7413_7489(this, analyzerExecutor, analyzerExecutionContext).ConfigureAwait(false);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(236, 7029, 7527);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 6481, 7538);

                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_6870_6941(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSessionAnalysisScopeAsync(analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 6870, 6941);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_6973_6999(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 6973, 6999);
                    return return_v;
                }


                int
                f_236_7247_7295(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param)
                {
                    this_param.ClearSessionScopeTask();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 7247, 7295);
                    return 0;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_7413_7489(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                analyzerExecutionContext)
                {
                    var return_v = this_param.GetSessionAnalysisScopeCoreAsync(analyzerExecutor, analyzerExecutionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 7413, 7489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 6481, 7538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 6481, 7538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        public async ValueTask<AnalyzerActions> GetAnalyzerActionsAsync(DiagnosticAnalyzer analyzer, AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 7968, 8795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 8237, 8341);

                var
                sessionScope = await f_236_8262_8318(this, analyzer, analyzerExecutor).ConfigureAwait(false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 8355, 8719) || true) && (f_236_8359_8400(sessionScope, analyzer).CompilationStartActionsCount > 0 && (DynAbs.Tracing.TraceSender.Expression_True(236, 8359, 8473) && f_236_8437_8465(analyzerExecutor) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 8355, 8719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 8507, 8633);

                    var
                    compilationScope = await f_236_8536_8610(this, analyzer, sessionScope, analyzerExecutor).ConfigureAwait(false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 8651, 8704);

                    return f_236_8658_8703(compilationScope, analyzer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 8355, 8719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 8735, 8784);

                return f_236_8742_8783(sessionScope, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 7968, 8795);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_8262_8318(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSessionAnalysisScopeAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 8262, 8318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_236_8359_8400(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 8359, 8400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_236_8437_8465(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 8437, 8465);
                    return return_v;
                }


                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                f_236_8536_8610(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                sessionScope, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetCompilationAnalysisScopeAsync(analyzer, sessionScope, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 8536, 8610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_236_8658_8703(Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 8658, 8703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_236_8742_8783(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 8742, 8783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 7968, 8795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 7968, 8795);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        public async ValueTask<AnalyzerActions> GetPerSymbolAnalyzerActionsAsync(ISymbol symbol, DiagnosticAnalyzer analyzer, AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 9104, 11274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9398, 9500);

                var
                analyzerActions = await f_236_9426_9477(this, analyzer, analyzerExecutor).ConfigureAwait(false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9514, 10032) || true) && (analyzerActions.SymbolStartActionsCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 9514, 10032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9595, 9689);

                    var
                    filteredSymbolStartActions = f_236_9628_9688(analyzerActions.SymbolStartActions)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9707, 10017) || true) && (filteredSymbolStartActions.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 9707, 10017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9790, 9928);

                        var
                        symbolScope = await f_236_9814_9927(f_236_9814_9905(this, symbol, analyzer, filteredSymbolStartActions, analyzerExecutor), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 9950, 9998);

                        return f_236_9957_9997(symbolScope, analyzer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 9707, 10017);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 9514, 10032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10048, 10077);

                return AnalyzerActions.Empty;

                ImmutableArray<SymbolStartAnalyzerAction> getFilteredActionsByKind(ImmutableArray<SymbolStartAnalyzerAction> symbolStartActions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 10093, 11263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10254, 10328);

                        ArrayBuilder<SymbolStartAnalyzerAction>?
                        filteredActionsBuilderOpt = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10355, 10360);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10346, 11117) || true) && (i < symbolStartActions.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10393, 10396)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(236, 10346, 11117))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 10346, 11117);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10438, 10484);

                                var
                                symbolStartAction = symbolStartActions[i]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10506, 11098) || true) && (f_236_10510_10532(symbolStartAction) != f_236_10536_10547(symbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 10506, 11098);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10597, 10889) || true) && (filteredActionsBuilderOpt == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 10597, 10889);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10692, 10774);

                                        filteredActionsBuilderOpt = f_236_10720_10773();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10804, 10862);

                                        f_236_10804_10861(filteredActionsBuilderOpt, symbolStartActions, i);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 10597, 10889);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 10506, 11098);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 10506, 11098);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 10939, 11098) || true) && (filteredActionsBuilderOpt != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 10939, 11098);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 11026, 11075);

                                        f_236_11026_11074(filteredActionsBuilderOpt, symbolStartAction);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 10939, 11098);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 10506, 11098);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 772);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 772);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 11137, 11248);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(236, 11144, 11177) || ((filteredActionsBuilderOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(236, 11180, 11226)) || DynAbs.Tracing.TraceSender.Conditional_F3(236, 11229, 11247))) ? f_236_11180_11226(filteredActionsBuilderOpt) : symbolStartActions;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(236, 10093, 11263);

                        Microsoft.CodeAnalysis.SymbolKind
                        f_236_10510_10532(Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 10510, 10532);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_236_10536_10547(Microsoft.CodeAnalysis.ISymbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 10536, 10547);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        f_236_10720_10773()
                        {
                            var return_v = ArrayBuilder<SymbolStartAnalyzerAction>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 10720, 10773);
                            return return_v;
                        }


                        int
                        f_236_10804_10861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        items, int
                        length)
                        {
                            this_param.AddRange(items, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 10804, 10861);
                            return 0;
                        }


                        int
                        f_236_11026_11074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 11026, 11074);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        f_236_11180_11226(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 11180, 11226);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 10093, 11263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 10093, 11263);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 9104, 11274);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions>
                f_236_9426_9477(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetAnalyzerActionsAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 9426, 9477);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                f_236_9628_9688(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                symbolStartActions)
                {
                    var return_v = getFilteredActionsByKind(symbolStartActions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 9628, 9688);
                    return return_v;
                }


                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_9814_9905(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                symbolStartActions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSymbolAnalysisScopeAsync(symbol, analyzer, symbolStartActions, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 9814, 9905);
                    return return_v;
                }


                System.Runtime.CompilerServices.ConfiguredTaskAwaitable<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                f_236_9814_9927(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                this_param, bool
                continueOnCapturedContext)
                {
                    var return_v = this_param.ConfigureAwait(continueOnCapturedContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 9814, 9927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                f_236_9957_9997(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerActions(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 9957, 9997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 9104, 11274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 9104, 11274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<bool> IsConcurrentAnalyzerAsync(DiagnosticAnalyzer analyzer, AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 11481, 11799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 11619, 11723);

                var
                sessionScope = await f_236_11644_11700(this, analyzer, analyzerExecutor).ConfigureAwait(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 11737, 11788);

                return f_236_11744_11787(sessionScope, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 11481, 11799);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_11644_11700(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSessionAnalysisScopeAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 11644, 11700);
                    return return_v;
                }


                bool
                f_236_11744_11787(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.IsConcurrentAnalyzer(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 11744, 11787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 11481, 11799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 11481, 11799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public async Task<GeneratedCodeAnalysisFlags> GetGeneratedCodeAnalysisFlagsAsync(DiagnosticAnalyzer analyzer, AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 12087, 12445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12256, 12360);

                var
                sessionScope = await f_236_12281_12337(this, analyzer, analyzerExecutor).ConfigureAwait(false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12374, 12434);

                return f_236_12381_12433(sessionScope, analyzer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 12087, 12445);

                System.Threading.Tasks.ValueTask<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                f_236_12281_12337(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSessionAnalysisScopeAsync(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 12281, 12337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                f_236_12381_12433(Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetGeneratedCodeAnalysisFlags(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 12381, 12433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 12087, 12445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 12087, 12445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ForceLocalizableStringExceptions(LocalizableString localizableString, EventHandler<Exception> handler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(236, 12457, 12851);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12604, 12840) || true) && (f_236_12608_12644(localizableString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 12604, 12840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12678, 12719);

                    localizableString.OnException += handler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12737, 12766);

                    f_236_12737_12765(localizableString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 12784, 12825);

                    localizableString.OnException -= handler;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 12604, 12840);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(236, 12457, 12851);

                bool
                f_236_12608_12644(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.CanThrowExceptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 12608, 12644);
                    return return_v;
                }


                string
                f_236_12737_12765(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 12737, 12765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 12457, 12851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 12457, 12851);
            }
        }

        public ImmutableArray<DiagnosticDescriptor> GetSupportedDiagnosticDescriptors(
                    DiagnosticAnalyzer analyzer,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 13022, 13403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 13215, 13284);

                var
                analyzerExecutionContext = f_236_13246_13283(this, analyzer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 13298, 13392);

                return f_236_13305_13391(analyzerExecutionContext, analyzer, analyzerExecutor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 13022, 13403);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_13246_13283(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 13246, 13283);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_236_13305_13391(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetOrComputeDiagnosticDescriptors(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 13305, 13391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 13022, 13403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 13022, 13403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SuppressionDescriptor> GetSupportedSuppressionDescriptors(
                    DiagnosticSuppressor suppressor,
                    AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 13579, 13971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 13778, 13849);

                var
                analyzerExecutionContext = f_236_13809_13848(this, suppressor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 13863, 13960);

                return f_236_13870_13959(analyzerExecutionContext, suppressor, analyzerExecutor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 13579, 13971);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_13809_13848(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext((Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer)analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 13809, 13848);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_236_13870_13959(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                suppressor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetOrComputeSuppressionDescriptors(suppressor, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 13870, 13959);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 13579, 13971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 13579, 13971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsSupportedDiagnostic(DiagnosticAnalyzer analyzer, Diagnostic diagnostic, Func<DiagnosticAnalyzer, bool> isCompilerAnalyzer, AnalyzerExecutor analyzerExecutor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 13983, 15166);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 14337, 14430) || true) && (f_236_14341_14369(isCompilerAnalyzer, analyzer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 14337, 14430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 14403, 14415);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 14337, 14430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 14779, 14868);

                var
                supportedDescriptors = f_236_14806_14867(this, analyzer, analyzerExecutor)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 14882, 15126);
                    foreach (var descriptor in f_236_14909_14929_I(supportedDescriptors))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 14882, 15126);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 14963, 15111) || true) && (f_236_14967_15038(f_236_14967_14980(descriptor), f_236_14988_15001(diagnostic), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 14963, 15111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15080, 15092);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 14963, 15111);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 14882, 15126);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 245);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15142, 15155);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 13983, 15166);

                bool
                f_236_14341_14369(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 14341, 14369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_236_14806_14867(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedDiagnosticDescriptors(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 14806, 14867);
                    return return_v;
                }


                string
                f_236_14967_14980(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 14967, 14980);
                    return return_v;
                }


                string
                f_236_14988_15001(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 14988, 15001);
                    return return_v;
                }


                bool
                f_236_14967_15038(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 14967, 15038);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_236_14909_14929_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 14909, 14929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 13983, 15166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 13983, 15166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDiagnosticAnalyzerSuppressed(
                    DiagnosticAnalyzer analyzer,
                    CompilationOptions options,
                    Func<DiagnosticAnalyzer, bool> isCompilerAnalyzer,
                    AnalyzerExecutor analyzerExecutor,
                    SeverityFilter severityFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 15344, 20514);
                Microsoft.CodeAnalysis.Compilation? compilation = default(Microsoft.CodeAnalysis.Compilation?);
                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions? analyzerOptions = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?);
                Microsoft.CodeAnalysis.ReportDiagnostic severity = default(Microsoft.CodeAnalysis.ReportDiagnostic);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15653, 15870) || true) && (f_236_15657_15685(isCompilerAnalyzer, analyzer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 15653, 15870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15842, 15855);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 15653, 15870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15886, 15975);

                var
                supportedDiagnostics = f_236_15913_15974(this, analyzer, analyzerExecutor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 15989, 16047);

                var
                diagnosticOptions = f_236_16013_16046(options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16061, 16160);

                f_236_16061_16159(analyzerExecutor, out compilation, out analyzerOptions);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16176, 18724);
                    foreach (var diag in f_236_16197_16217_I(supportedDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 16176, 18724);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16251, 16809) || true) && (f_236_16255_16293(f_236_16277_16292(diag)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 16251, 16809);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16335, 16790) || true) && (f_236_16339_16362(diag))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 16335, 16790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16543, 16556);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(236, 16335, 16790);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 16335, 16790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16758, 16767);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(236, 16335, 16790);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 16251, 16809);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 16922, 16966);

                        var
                        isSuppressed = f_236_16941_16965_M(!diag.IsEnabledByDefault)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 17414, 18042) || true) && ((f_236_17419_17475(diagnosticOptions, f_236_17449_17456(diag), out severity) || (DynAbs.Tracing.TraceSender.Expression_False(236, 17419, 17667) || f_236_17500_17533(options) is object && (DynAbs.Tracing.TraceSender.Expression_True(236, 17500, 17667) && f_236_17547_17667(f_236_17547_17580(options), f_236_17609_17616(diag), f_236_17618_17652(analyzerExecutor), out severity)))) && (DynAbs.Tracing.TraceSender.Expression_True(236, 17418, 17729) && severity != ReportDiagnostic.Default))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 17414, 18042);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 17771, 17824);

                            isSuppressed = severity == ReportDiagnostic.Suppress;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 17414, 18042);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 17414, 18042);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 17906, 18023);

                            severity = (DynAbs.Tracing.TraceSender.Conditional_F1(236, 17917, 17929) || ((isSuppressed && DynAbs.Tracing.TraceSender.Conditional_F2(236, 17932, 17957)) || DynAbs.Tracing.TraceSender.Conditional_F3(236, 17960, 18022))) ? ReportDiagnostic.Suppress : f_236_17960_18022(f_236_18001_18021(diag));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 17414, 18042);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18132, 18250) || true) && (f_236_18136_18169(severityFilter, severity))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18132, 18250);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18211, 18231);

                            isSuppressed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18132, 18250);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18353, 18598) || true) && (isSuppressed && (DynAbs.Tracing.TraceSender.Expression_True(236, 18357, 18516) && f_236_18394_18516(diag, severityFilter, compilation, analyzerOptions, f_236_18481_18515(analyzerExecutor))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18353, 18598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18558, 18579);

                            isSuppressed = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18353, 18598);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18618, 18709) || true) && (!isSuppressed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18618, 18709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18677, 18690);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18618, 18709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 16176, 18724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 2549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 2549);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18740, 19131) || true) && (analyzer is DiagnosticSuppressor suppressor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18740, 19131);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18821, 19116);
                        foreach (var suppressionDescriptor in f_236_18859_18923_I(f_236_18859_18923(this, suppressor, analyzerExecutor)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18821, 19116);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 18965, 19097) || true) && (!f_236_18970_19011(suppressionDescriptor, options))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 18965, 19097);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 19061, 19074);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18965, 19097);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18821, 19116);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 296);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 296);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 18740, 19131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 19147, 19159);

                return true;

                static bool isEnabledWithAnalyzerConfigOptions(
                                DiagnosticDescriptor descriptor,
                                SeverityFilter severityFilter,
                                Compilation? compilation,
                                AnalyzerOptions? analyzerOptions,
                                CancellationToken cancellationToken)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(236, 19175, 20503);
                        Microsoft.CodeAnalysis.ReportDiagnostic configuredValue = default(Microsoft.CodeAnalysis.ReportDiagnostic);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 19501, 20455) || true) && (compilation != null && (DynAbs.Tracing.TraceSender.Expression_True(236, 19505, 19592) && f_236_19528_19573(f_236_19528_19547(compilation)) is { } treeOptions))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 19501, 20455);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 19634, 20436);
                                foreach (var tree in f_236_19655_19678_I(f_236_19655_19678(compilation)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 19634, 20436);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 19869, 20413) || true) && (f_236_19873_19971(treeOptions, tree, f_236_19913_19926(descriptor), cancellationToken, out configuredValue) || (DynAbs.Tracing.TraceSender.Expression_False(236, 19873, 20126) || f_236_20004_20126(analyzerOptions, tree, compilation, descriptor, cancellationToken, out configuredValue)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 19869, 20413);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20184, 20386) || true) && (configuredValue != ReportDiagnostic.Suppress && (DynAbs.Tracing.TraceSender.Expression_True(236, 20188, 20277) && !f_236_20237_20277(severityFilter, configuredValue)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 20184, 20386);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20343, 20355);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 20184, 20386);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 19869, 20413);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(236, 19634, 20436);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 803);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 803);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 19501, 20455);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20475, 20488);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(236, 19175, 20503);

                        Microsoft.CodeAnalysis.CompilationOptions
                        f_236_19528_19547(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.Options;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 19528, 19547);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                        f_236_19528_19573(Microsoft.CodeAnalysis.CompilationOptions
                        this_param)
                        {
                            var return_v = this_param.SyntaxTreeOptionsProvider;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 19528, 19573);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                        f_236_19655_19678(Microsoft.CodeAnalysis.Compilation
                        this_param)
                        {
                            var return_v = this_param.SyntaxTrees;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 19655, 19678);
                            return return_v;
                        }


                        string
                        f_236_19913_19926(Microsoft.CodeAnalysis.DiagnosticDescriptor
                        this_param)
                        {
                            var return_v = this_param.Id;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 19913, 19926);
                            return return_v;
                        }


                        bool
                        f_236_19873_19971(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                        this_param, Microsoft.CodeAnalysis.SyntaxTree
                        tree, string
                        diagnosticId, System.Threading.CancellationToken
                        cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                        severity)
                        {
                            var return_v = this_param.TryGetDiagnosticValue(tree, diagnosticId, cancellationToken, out severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 19873, 19971);
                            return return_v;
                        }


                        bool
                        f_236_20004_20126(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                        analyzerOptions, Microsoft.CodeAnalysis.SyntaxTree
                        tree, Microsoft.CodeAnalysis.Compilation
                        compilation, Microsoft.CodeAnalysis.DiagnosticDescriptor
                        descriptor, System.Threading.CancellationToken
                        cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                        severity)
                        {
                            var return_v = analyzerOptions.TryGetSeverityFromBulkConfiguration(tree, compilation, descriptor, cancellationToken, out severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 20004, 20126);
                            return return_v;
                        }


                        bool
                        f_236_20237_20277(Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                        severityFilter, Microsoft.CodeAnalysis.ReportDiagnostic
                        severity)
                        {
                            var return_v = severityFilter.Contains(severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 20237, 20277);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                        f_236_19655_19678_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 19655, 19678);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 19175, 20503);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 19175, 20503);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 15344, 20514);

                bool
                f_236_15657_15685(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, bool>
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 15657, 15685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_236_15913_15974(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedDiagnosticDescriptors(analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 15913, 15974);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_236_16013_16046(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 16013, 16046);
                    return return_v;
                }


                bool
                f_236_16061_16159(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param, out Microsoft.CodeAnalysis.Compilation?
                compilation, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions)
                {
                    var return_v = this_param.TryGetCompilationAndAnalyzerOptions(out compilation, out analyzerOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 16061, 16159);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_236_16277_16292(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 16277, 16292);
                    return return_v;
                }


                bool
                f_236_16255_16293(System.Collections.Generic.IEnumerable<string>
                customTags)
                {
                    var return_v = HasNotConfigurableTag(customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 16255, 16293);
                    return return_v;
                }


                bool
                f_236_16339_16362(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 16339, 16362);
                    return return_v;
                }


                bool
                f_236_16941_16965_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 16941, 16965);
                    return return_v;
                }


                string
                f_236_17449_17456(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 17449, 17456);
                    return return_v;
                }


                bool
                f_236_17419_17475(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 17419, 17475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_236_17500_17533(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 17500, 17533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                f_236_17547_17580(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 17547, 17580);
                    return return_v;
                }


                string
                f_236_17609_17616(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 17609, 17616);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_236_17618_17652(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 17618, 17652);
                    return return_v;
                }


                bool
                f_236_17547_17667(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, string
                diagnosticId, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = this_param.TryGetGlobalDiagnosticValue(diagnosticId, cancellationToken, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 17547, 17667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_236_18001_18021(Microsoft.CodeAnalysis.DiagnosticDescriptor
                this_param)
                {
                    var return_v = this_param.DefaultSeverity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 18001, 18021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_236_17960_18022(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = DiagnosticDescriptor.MapSeverityToReport(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 17960, 18022);
                    return return_v;
                }


                bool
                f_236_18136_18169(Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = severityFilter.Contains(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 18136, 18169);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_236_18481_18515(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 18481, 18515);
                    return return_v;
                }


                bool
                f_236_18394_18516(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, Microsoft.CodeAnalysis.Compilation?
                compilation, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                analyzerOptions, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = isEnabledWithAnalyzerConfigOptions(descriptor, severityFilter, compilation, analyzerOptions, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 18394, 18516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_236_16197_16217_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 16197, 16217);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_236_18859_18923(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                suppressor, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = this_param.GetSupportedSuppressionDescriptors(suppressor, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 18859, 18923);
                    return return_v;
                }


                bool
                f_236_18970_19011(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param, Microsoft.CodeAnalysis.CompilationOptions
                compilationOptions)
                {
                    var return_v = this_param.IsDisabled(compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 18970, 19011);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_236_18859_18923_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 18859, 18923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 15344, 20514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 15344, 20514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasNotConfigurableTag(IEnumerable<string> customTags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(236, 20526, 20879);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20625, 20839);
                    foreach (var customTag in f_236_20651_20661_I(customTags))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 20625, 20839);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20695, 20824) || true) && (customTag == WellKnownDiagnosticTags.NotConfigurable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 20695, 20824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20793, 20805);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(236, 20695, 20824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 20625, 20839);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 20855, 20868);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(236, 20526, 20879);

                System.Collections.Generic.IEnumerable<string>
                f_236_20651_20661_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 20651, 20661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 20526, 20879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 20526, 20879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryProcessCompletedMemberAndGetPendingSymbolEndActionsForContainer(
                    ISymbol containingSymbol,
                    ISymbol processedMemberSymbol,
                    DiagnosticAnalyzer analyzer,
                    out (ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, SymbolDeclaredCompilationEvent symbolDeclaredEvent) containerEndActionsAndEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 20891, 21474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 21277, 21463);

                return f_236_21284_21462(f_236_21284_21321(this, analyzer), containingSymbol, processedMemberSymbol, out containerEndActionsAndEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 20891, 21474);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_21284_21321(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 21284, 21321);
                    return return_v;
                }


                bool
                f_236_21284_21462(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.ISymbol
                containingSymbol, Microsoft.CodeAnalysis.ISymbol
                processedMemberSymbol, out (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction> symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent symbolDeclaredEvent)
                containerEndActionsAndEvent)
                {
                    var return_v = this_param.TryProcessCompletedMemberAndGetPendingSymbolEndActionsForContainer(containingSymbol, processedMemberSymbol, out containerEndActionsAndEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 21284, 21462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 20891, 21474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 20891, 21474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TryStartExecuteSymbolEndActions(ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, DiagnosticAnalyzer analyzer, SymbolDeclaredCompilationEvent symbolDeclaredEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 21486, 21820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 21693, 21809);

                return f_236_21700_21808(f_236_21700_21737(this, analyzer), symbolEndActions, symbolDeclaredEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 21486, 21820);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_21700_21737(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 21700, 21737);
                    return return_v;
                }


                bool
                f_236_21700_21808(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent)
                {
                    var return_v = this_param.TryStartExecuteSymbolEndActions(symbolEndActions, symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 21700, 21808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 21486, 21820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 21486, 21820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void MarkSymbolEndAnalysisPending(
                    ISymbol symbol,
                    DiagnosticAnalyzer analyzer,
                    ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions,
                    SymbolDeclaredCompilationEvent symbolDeclaredEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 21832, 22230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 22105, 22219);

                f_236_22105_22218(f_236_22105_22142(this, analyzer), symbol, symbolEndActions, symbolDeclaredEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 21832, 22230);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_22105_22142(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22105, 22142);
                    return return_v;
                }


                int
                f_236_22105_22218(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                symbolDeclaredEvent)
                {
                    this_param.MarkSymbolEndAnalysisPending(symbol, symbolEndActions, symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22105, 22218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 21832, 22230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 21832, 22230);
            }
        }

        public void MarkSymbolEndAnalysisComplete(ISymbol symbol, DiagnosticAnalyzer analyzer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 22242, 22440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 22353, 22429);

                f_236_22353_22428(f_236_22353_22390(this, analyzer), symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 22242, 22440);

                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                f_236_22353_22390(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer)
                {
                    var return_v = this_param.GetAnalyzerExecutionContext(analyzer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22353, 22390);
                    return return_v;
                }


                int
                f_236_22353_22428(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    this_param.MarkSymbolEndAnalysisComplete(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22353, 22428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 22242, 22440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 22242, 22440);
            }
        }

        [Conditional("DEBUG")]
        public void VerifyAllSymbolEndActionsExecuted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(236, 22452, 22753);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 22556, 22742);
                    foreach (var analyzerExecutionContext in f_236_22597_22632_I(f_236_22597_22632(_analyzerExecutionContextMap)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(236, 22556, 22742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(236, 22666, 22727);

                        f_236_22666_22726(analyzerExecutionContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(236, 22556, 22742);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(236, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(236, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(236, 22452, 22753);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
                f_236_22597_22632(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(236, 22597, 22632);
                    return return_v;
                }


                int
                f_236_22666_22726(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                this_param)
                {
                    this_param.VerifyAllSymbolEndActionsExecuted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22666, 22726);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
                f_236_22597_22632_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 22597, 22632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(236, 22452, 22753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(236, 22452, 22753);
            }
        }

        static System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
        f_236_1600_1644(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers)
        {
            var return_v = this_param.CreateAnalyzerExecutionContextMap((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>)analyzers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 1600, 1644);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        f_236_1809_1861(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
        value)
        {
            var return_v = SpecializedCollections.SingletonEnumerable(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 1809, 1861);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext>
        f_236_1775_1862(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
        this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
        analyzers)
        {
            var return_v = this_param.CreateAnalyzerExecutionContextMap(analyzers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(236, 1775, 1862);
            return return_v;
        }

    }
}
