// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerManager
    {
        private sealed class AnalyzerExecutionContext
        {
            private readonly DiagnosticAnalyzer _analyzer;

            private readonly object _gate;

            private Dictionary<ISymbol, HashSet<ISymbol>?>? _lazyPendingMemberSymbolsMap;

            private Dictionary<ISymbol, (ImmutableArray<SymbolEndAnalyzerAction>, SymbolDeclaredCompilationEvent)>? _lazyPendingSymbolEndActionsMap;

            private Task<HostSessionStartAnalysisScope>? _lazySessionScopeTask;

            private Task<HostCompilationStartAnalysisScope>? _lazyCompilationScopeTask;

            private Dictionary<ISymbol, Task<HostSymbolStartAnalysisScope>>? _lazySymbolScopeTasks;

            private ImmutableArray<DiagnosticDescriptor> _lazyDiagnosticDescriptors;

            private ImmutableArray<SuppressionDescriptor> _lazySuppressionDescriptors;

            public AnalyzerExecutionContext(DiagnosticAnalyzer analyzer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(235, 2733, 2901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 614, 623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 662, 667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 915, 943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 1224, 1255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 1597, 1618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 1915, 1940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 2238, 2259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 2826, 2847);

                    _analyzer = analyzer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 2865, 2886);

                    _gate = f_235_2873_2885();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(235, 2733, 2901);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 2733, 2901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 2733, 2901);
                }
            }

            [PerformanceSensitive(
                            "https://github.com/dotnet/roslyn/issues/26778",
                            AllowCaptures = false)]
            public Task<HostSessionStartAnalysisScope> GetSessionAnalysisScopeAsync(AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 2917, 4223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3205, 3210);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3252, 3293);

                        Task<HostSessionStartAnalysisScope>
                        task
                        = default(Task<HostSessionStartAnalysisScope>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3315, 3450) || true) && (_lazySessionScopeTask != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 3315, 3450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3398, 3427);

                            return _lazySessionScopeTask;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 3315, 3450);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3474, 3537);

                        task = f_235_3481_3536(this, analyzerExecutor);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3559, 3588);

                        _lazySessionScopeTask = task;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3610, 3622);

                        return task;

                        System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                    f_235_3481_3536(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                    context, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    executor)
                        {
                            var return_v = getSessionAnalysisScopeTaskSlow(context, executor);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 3481, 3536);
                            return return_v;
                        }

                        static Task<HostSessionStartAnalysisScope> getSessionAnalysisScopeTaskSlow(AnalyzerExecutionContext context, AnalyzerExecutor executor)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(235, 3646, 4189);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 3830, 4166);

                                return f_235_3837_4165(() =>
                                                        {
                                                            var sessionScope = new HostSessionStartAnalysisScope();
                                                            executor.ExecuteInitializeMethod(context._analyzer, sessionScope);
                                                            return sessionScope;
                                                        }, f_235_4138_4164(executor));
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(235, 3646, 4189);

                                System.Threading.CancellationToken
                                f_235_4138_4164(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                                this_param)
                                {
                                    var return_v = this_param.CancellationToken;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 4138, 4164);
                                    return return_v;
                                }


                                System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                                f_235_3837_4165(System.Func<Microsoft.CodeAnalysis.Diagnostics.HostSessionStartAnalysisScope>
                                function, System.Threading.CancellationToken
                                cancellationToken)
                                {
                                    var return_v = Task.Run(function, cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 3837, 4165);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 3646, 4189);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 3646, 4189);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 2917, 4223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 2917, 4223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 2917, 4223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void ClearSessionScopeTask()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 4239, 4423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 4313, 4318);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 4360, 4389);

                        _lazySessionScopeTask = null;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 4239, 4423);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 4239, 4423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 4239, 4423);
                }
            }

            public Task<HostCompilationStartAnalysisScope> GetCompilationAnalysisScopeAsync(
                            HostSessionStartAnalysisScope sessionScope,
                            AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 4439, 5400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 4671, 4676);
                    lock (_gate)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 4718, 5309) || true) && (_lazyCompilationScopeTask == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 4718, 5309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 4805, 5286);

                            _lazyCompilationScopeTask = f_235_4833_5285(() =>
                                                    {
                                                        var compilationAnalysisScope = new HostCompilationStartAnalysisScope(sessionScope);
                                                        analyzerExecutor.ExecuteCompilationStartActions(sessionScope.GetAnalyzerActions(_analyzer).CompilationStartActions, compilationAnalysisScope);
                                                        return compilationAnalysisScope;
                                                    }, f_235_5250_5284(analyzerExecutor));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 4718, 5309);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 5333, 5366);

                        return _lazyCompilationScopeTask;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 4439, 5400);

                    System.Threading.CancellationToken
                    f_235_5250_5284(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    this_param)
                    {
                        var return_v = this_param.CancellationToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 5250, 5284);
                        return return_v;
                    }


                    System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                    f_235_4833_5285(System.Func<Microsoft.CodeAnalysis.Diagnostics.HostCompilationStartAnalysisScope>
                    function, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = Task.Run(function, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 4833, 5285);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 4439, 5400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 4439, 5400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void ClearCompilationScopeTask()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 5416, 5608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 5494, 5499);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 5541, 5574);

                        _lazyCompilationScopeTask = null;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 5416, 5608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 5416, 5608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 5416, 5608);
                }
            }

            public Task<HostSymbolStartAnalysisScope> GetSymbolAnalysisScopeAsync(
                            ISymbol symbol,
                            ImmutableArray<SymbolStartAnalyzerAction> symbolStartActions,
                            AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 5624, 9472);
                    System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope> symbolScopeTask = default(System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 5897, 5902);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 5944, 6032);

                        _lazySymbolScopeTasks ??= f_235_5970_6031();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6054, 6374) || true) && (!f_235_6059_6125(_lazySymbolScopeTasks, symbol, out symbolScopeTask))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 6054, 6374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6175, 6274);

                            symbolScopeTask = f_235_6193_6273(() => getSymbolAnalysisScopeCore(), f_235_6238_6272(analyzerExecutor));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6300, 6351);

                            f_235_6300_6350(_lazySymbolScopeTasks, symbol, symbolScopeTask);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 6054, 6374);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6398, 6421);

                        return symbolScopeTask;

                        HostSymbolStartAnalysisScope getSymbolAnalysisScopeCore()
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 6445, 7614);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6551, 6612);

                                var
                                symbolAnalysisScope = f_235_6577_6611()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6638, 6741);

                                f_235_6638_6740(analyzerExecutor, symbol, _analyzer, symbolStartActions, symbolAnalysisScope);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6769, 6842);

                                var
                                symbolEndActions = f_235_6792_6841(symbolAnalysisScope, _analyzer)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6868, 7536) || true) && (symbolEndActions.SymbolEndActionsCount > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 6868, 7536);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 6972, 7017);

                                    var
                                    dependentSymbols = f_235_6995_7016()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7053, 7058);
                                    lock (_gate)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7124, 7202);

                                        _lazyPendingMemberSymbolsMap ??= f_235_7157_7201();
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7321, 7388);

                                        f_235_7321_7387(this, symbol, dependentSymbols);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7422, 7478);

                                        _lazyPendingMemberSymbolsMap[symbol] = dependentSymbols;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(235, 6868, 7536);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7564, 7591);

                                return symbolAnalysisScope;
                                DynAbs.Tracing.TraceSender.TraceExitMethod(235, 6445, 7614);

                                Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                                f_235_6577_6611()
                                {
                                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6577, 6611);
                                    return return_v;
                                }


                                int
                                f_235_6638_6740(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                                this_param, Microsoft.CodeAnalysis.ISymbol
                                symbol, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                                analyzer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolStartAnalyzerAction>
                                actions, Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                                symbolScope)
                                {
                                    this_param.ExecuteSymbolStartActions(symbol, analyzer, actions, symbolScope);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6638, 6740);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                                f_235_6792_6841(Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope
                                this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                                analyzer)
                                {
                                    var return_v = this_param.GetAnalyzerActions(analyzer);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6792, 6841);
                                    return return_v;
                                }


                                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?
                                f_235_6995_7016()
                                {
                                    var return_v = getDependentSymbols();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6995, 7016);
                                    return return_v;
                                }


                                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>
                                f_235_7157_7201()
                                {
                                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 7157, 7201);
                                    return return_v;
                                }


                                int
                                f_235_7321_7387(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                                this_param, Microsoft.CodeAnalysis.ISymbol
                                symbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?
                                dependentSymbols)
                                {
                                    this_param.VerifyNewEntryForPendingMemberSymbolsMap(symbol, dependentSymbols);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 7321, 7387);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 6445, 7614);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 6445, 7614);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                    }

                    HashSet<ISymbol>? getDependentSymbols()
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 7653, 9457);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7733, 7768);

                            HashSet<ISymbol>?
                            memberSet = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7790, 8206);

                            switch (f_235_7798_7809(symbol))
                            {

                                case SymbolKind.NamedType:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 7790, 8206);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 7915, 7971);

                                    f_235_7915_7970(f_235_7930_7969(((INamedTypeSymbol)symbol)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(235, 8001, 8007);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(235, 7790, 8206);

                                case SymbolKind.Namespace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 7790, 8206);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8091, 8147);

                                    f_235_8091_8146(f_235_8106_8145(((INamespaceSymbol)symbol)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(235, 8177, 8183);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(235, 7790, 8206);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8230, 8247);

                            return memberSet;

                            void processMembers(IEnumerable<ISymbol> members)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 8271, 9438);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8369, 9415);
                                        foreach (var member in f_235_8392_8399_I(members))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 8369, 9415);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8457, 9115) || true) && (f_235_8461_8489_M(!member.IsImplicitlyDeclared) && (DynAbs.Tracing.TraceSender.Expression_True(235, 8461, 8512) && f_235_8493_8512(member)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 8457, 9115);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8578, 8615);

                                                memberSet ??= f_235_8592_8614();
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8649, 8671);

                                                f_235_8649_8670(memberSet, member);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 8809, 9084) || true) && (member is IMethodSymbol method && (DynAbs.Tracing.TraceSender.Expression_True(235, 8813, 8927) && !(f_235_8886_8918(method) is null)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 8809, 9084);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9001, 9049);

                                                    f_235_9001_9048(memberSet, f_235_9015_9047(method));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(235, 8809, 9084);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(235, 8457, 9115);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9147, 9388) || true) && (f_235_9151_9162(member) != f_235_9166_9177(symbol) && (DynAbs.Tracing.TraceSender.Expression_True(235, 9151, 9251) && member is INamedTypeSymbol typeMember))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 9147, 9388);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9317, 9357);

                                                f_235_9317_9356(f_235_9332_9355(typeMember));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(235, 9147, 9388);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 8369, 9415);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(235, 1, 1047);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(235, 1, 1047);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 8271, 9438);

                                    bool
                                    f_235_8461_8489_M(bool
                                    i)
                                    {
                                        var return_v = i;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 8461, 8489);
                                        return return_v;
                                    }


                                    bool
                                    f_235_8493_8512(Microsoft.CodeAnalysis.ISymbol
                                    symbol)
                                    {
                                        var return_v = symbol.IsInSource();
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8493, 8512);
                                        return return_v;
                                    }


                                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                                    f_235_8592_8614()
                                    {
                                        var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>();
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8592, 8614);
                                        return return_v;
                                    }


                                    bool
                                    f_235_8649_8670(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                                    this_param, Microsoft.CodeAnalysis.ISymbol
                                    item)
                                    {
                                        var return_v = this_param.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8649, 8670);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.IMethodSymbol?
                                    f_235_8886_8918(Microsoft.CodeAnalysis.IMethodSymbol
                                    this_param)
                                    {
                                        var return_v = this_param.PartialImplementationPart;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 8886, 8918);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.IMethodSymbol
                                    f_235_9015_9047(Microsoft.CodeAnalysis.IMethodSymbol
                                    this_param)
                                    {
                                        var return_v = this_param.PartialImplementationPart;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 9015, 9047);
                                        return return_v;
                                    }


                                    bool
                                    f_235_9001_9048(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                                    item)
                                    {
                                        var return_v = this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 9001, 9048);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.SymbolKind
                                    f_235_9151_9162(Microsoft.CodeAnalysis.ISymbol
                                    this_param)
                                    {
                                        var return_v = this_param.Kind;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 9151, 9162);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.SymbolKind
                                    f_235_9166_9177(Microsoft.CodeAnalysis.ISymbol
                                    this_param)
                                    {
                                        var return_v = this_param.Kind;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 9166, 9177);
                                        return return_v;
                                    }


                                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                                    f_235_9332_9355(Microsoft.CodeAnalysis.INamedTypeSymbol
                                    this_param)
                                    {
                                        var return_v = this_param.GetMembers();
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 9332, 9355);
                                        return return_v;
                                    }


                                    int
                                    f_235_9317_9356(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                                    members)
                                    {
                                        processMembers((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)members);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 9317, 9356);
                                        return 0;
                                    }


                                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                                    f_235_8392_8399_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                                    i)
                                    {
                                        var return_v = i;
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8392, 8399);
                                        return return_v;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 8271, 9438);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 8271, 9438);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(235, 7653, 9457);

                            Microsoft.CodeAnalysis.SymbolKind
                            f_235_7798_7809(Microsoft.CodeAnalysis.ISymbol
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 7798, 7809);
                                return return_v;
                            }


                            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                            f_235_7930_7969(Microsoft.CodeAnalysis.INamedTypeSymbol
                            this_param)
                            {
                                var return_v = this_param.GetMembers();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 7930, 7969);
                                return return_v;
                            }


                            int
                            f_235_7915_7970(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                            members)
                            {
                                processMembers((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)members);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 7915, 7970);
                                return 0;
                            }


                            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                            f_235_8106_8145(Microsoft.CodeAnalysis.INamespaceSymbol
                            this_param)
                            {
                                var return_v = this_param.GetMembers();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8106, 8145);
                                return return_v;
                            }


                            int
                            f_235_8091_8146(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.INamespaceOrTypeSymbol>
                            members)
                            {
                                processMembers((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)members);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 8091, 8146);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 7653, 9457);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 7653, 9457);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 5624, 9472);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>>
                    f_235_5970_6031()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 5970, 6031);
                        return return_v;
                    }


                    bool
                    f_235_6059_6125(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6059, 6125);
                        return return_v;
                    }


                    System.Threading.CancellationToken
                    f_235_6238_6272(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    this_param)
                    {
                        var return_v = this_param.CancellationToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 6238, 6272);
                        return return_v;
                    }


                    System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                    f_235_6193_6273(System.Func<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                    function, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = Task.Run(function, cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6193, 6273);
                        return return_v;
                    }


                    int
                    f_235_6300_6350(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Diagnostics.HostSymbolStartAnalysisScope>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 6300, 6350);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 5624, 9472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 5624, 9472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [Conditional("DEBUG")]
            private void VerifyNewEntryForPendingMemberSymbolsMap(ISymbol symbol, HashSet<ISymbol>? dependentSymbols)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 9488, 10575);
                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>? existingDependentSymbols = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9662, 9793);

                    f_235_9662_9792(_lazyPendingMemberSymbolsMap != null, $"{nameof(_lazyPendingMemberSymbolsMap)} was expected to be a non-null value.");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9813, 10560) || true) && (f_235_9817_9899(_lazyPendingMemberSymbolsMap, symbol, out existingDependentSymbols))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 9813, 10560);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 9941, 10541) || true) && (existingDependentSymbols == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 9941, 10541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10027, 10122);

                            f_235_10027_10121(dependentSymbols == null, $"{nameof(dependentSymbols)} was expected to be null.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 9941, 10541);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 9941, 10541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10220, 10327);

                            f_235_10220_10326(dependentSymbols != null, $"{nameof(dependentSymbols)} was expected to be a non-null value.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10353, 10518);

                            f_235_10353_10517(f_235_10366_10419(existingDependentSymbols, dependentSymbols), $"{nameof(existingDependentSymbols)} was expected to be a subset of {nameof(dependentSymbols)}");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 9941, 10541);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(235, 9813, 10560);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 9488, 10575);

                    int
                    f_235_9662_9792(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 9662, 9792);
                        return 0;
                    }


                    bool
                    f_235_9817_9899(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 9817, 9899);
                        return return_v;
                    }


                    int
                    f_235_10027_10121(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10027, 10121);
                        return 0;
                    }


                    int
                    f_235_10220_10326(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10220, 10326);
                        return 0;
                    }


                    bool
                    f_235_10366_10419(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                    this_param, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                    other)
                    {
                        var return_v = this_param.IsSubsetOf((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10366, 10419);
                        return return_v;
                    }


                    int
                    f_235_10353_10517(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10353, 10517);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 9488, 10575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 9488, 10575);
                }
            }

            public void ClearSymbolScopeTask(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 10591, 10797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10678, 10683);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10725, 10763);

                        f_235_10725_10762_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazySymbolScopeTasks, 235, 10725, 10762)?.Remove(symbol));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 10591, 10797);

                    bool?
                    f_235_10725_10762_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10725, 10762);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 10591, 10797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 10591, 10797);
                }
            }

            public ImmutableArray<DiagnosticDescriptor> GetOrComputeDiagnosticDescriptors(DiagnosticAnalyzer analyzer, AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 10972, 11088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 10975, 11088);
                    return f_235_10975_11088(ref _lazyDiagnosticDescriptors, ComputeDiagnosticDescriptors, analyzer, analyzerExecutor); DynAbs.Tracing.TraceSender.TraceExitMethod(235, 10972, 11088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 10972, 11088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 10972, 11088);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                f_235_10975_11088(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                lazyDescriptors, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>>
                computeDescriptors, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = GetOrComputeDescriptors(ref lazyDescriptors, computeDescriptors, analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 10975, 11088);
                    return return_v;
                }

            }

            public ImmutableArray<SuppressionDescriptor> GetOrComputeSuppressionDescriptors(DiagnosticSuppressor suppressor, AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 11270, 11390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 11273, 11390);
                    return f_235_11273_11390(ref _lazySuppressionDescriptors, ComputeSuppressionDescriptors, suppressor, analyzerExecutor); DynAbs.Tracing.TraceSender.TraceExitMethod(235, 11270, 11390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 11270, 11390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 11270, 11390);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_235_11273_11390(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>
                lazyDescriptors, System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SuppressionDescriptor>>
                computeDescriptors, Microsoft.CodeAnalysis.Diagnostics.DiagnosticSuppressor
                analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                analyzerExecutor)
                {
                    var return_v = GetOrComputeDescriptors(ref lazyDescriptors, computeDescriptors, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer)analyzer, analyzerExecutor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 11273, 11390);
                    return return_v;
                }

            }

            private static ImmutableArray<TDescriptor> GetOrComputeDescriptors<TDescriptor>(
                            ref ImmutableArray<TDescriptor> lazyDescriptors,
                            Func<DiagnosticAnalyzer, AnalyzerExecutor, ImmutableArray<TDescriptor>> computeDescriptors,
                            DiagnosticAnalyzer analyzer,
                            AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(235, 11407, 12324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 11793, 11907) || true) && (f_235_11797_11823_M(!lazyDescriptors.IsDefault))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 11793, 11907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 11865, 11888);

                        return lazyDescriptors;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(235, 11793, 11907);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 12106, 12171);

                    var
                    descriptors = f_235_12124_12170(computeDescriptors, analyzer, analyzerExecutor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 12191, 12268);

                    f_235_12191_12267(ref lazyDescriptors, descriptors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 12286, 12309);

                    return lazyDescriptors;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(235, 11407, 12324);

                    bool
                    f_235_11797_11823_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 11797, 11823);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TDescriptor>
                    f_235_12124_12170(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor, System.Collections.Immutable.ImmutableArray<TDescriptor>>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    arg1, Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    arg2)
                    {
                        var return_v = this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 12124, 12170);
                        return return_v;
                    }


                    bool
                    f_235_12191_12267(ref System.Collections.Immutable.ImmutableArray<TDescriptor>
                    location, System.Collections.Immutable.ImmutableArray<TDescriptor>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 12191, 12267);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 11407, 12324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 11407, 12324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ImmutableArray<DiagnosticDescriptor> ComputeDiagnosticDescriptors(
                            DiagnosticAnalyzer analyzer,
                            AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(235, 12539, 15032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 12751, 12821);

                    var
                    supportedDiagnostics = ImmutableArray<DiagnosticDescriptor>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 12912, 13952);

                    f_235_12912_13951(
                                    // Catch Exception from analyzer.SupportedDiagnostics
                                    analyzerExecutor, analyzer, _ =>
                                        {
                                            var supportedDiagnosticsLocal = analyzer.SupportedDiagnostics;
                                            if (!supportedDiagnosticsLocal.IsDefaultOrEmpty)
                                            {
                                                foreach (var descriptor in supportedDiagnosticsLocal)
                                                {
                                                    if (descriptor == null)
                                                    {
                                    // Disallow null descriptors.
                                    throw new ArgumentException(string.Format(CodeAnalysisResources.SupportedDiagnosticsHasNullDescriptor, analyzer.ToString()), nameof(DiagnosticAnalyzer.SupportedDiagnostics));
                                                    }
                                                }

                                                supportedDiagnostics = supportedDiagnosticsLocal;
                                            }
                                        }, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14075, 14184);

                    Action<Exception, DiagnosticAnalyzer, Diagnostic>
                    onAnalyzerException = f_235_14147_14183(analyzerExecutor)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14202, 14969) || true) && (onAnalyzerException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 14202, 14969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14275, 14560);

                        var
                        handler = new EventHandler<Exception>((sender, ex) =>
                                            {
                                                var diagnostic = AnalyzerExecutor.CreateAnalyzerExceptionDiagnostic(analyzer, ex);
                                                onAnalyzerException(ex, analyzer, diagnostic);
                                            })
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14584, 14950);
                            foreach (var descriptor in f_235_14611_14631_I(supportedDiagnostics))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 14584, 14950);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14681, 14741);

                                f_235_14681_14740(f_235_14714_14730(descriptor), handler);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14767, 14835);

                                f_235_14767_14834(f_235_14800_14824(descriptor), handler);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14861, 14927);

                                f_235_14861_14926(f_235_14894_14916(descriptor), handler);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(235, 14584, 14950);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(235, 1, 367);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(235, 1, 367);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(235, 14202, 14969);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 14989, 15017);

                    return supportedDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(235, 12539, 15032);

                    int
                    f_235_12912_13951(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Action<object>
                    analyze, object?
                    argument)
                    {
                        this_param.ExecuteAndCatchIfThrows<object?>(analyzer, analyze, argument: argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 12912, 13951);
                        return 0;
                    }


                    System.Action<System.Exception, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostic>
                    f_235_14147_14183(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    this_param)
                    {
                        var return_v = this_param.OnAnalyzerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 14147, 14183);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_235_14714_14730(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Title;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 14714, 14730);
                        return return_v;
                    }


                    int
                    f_235_14681_14740(Microsoft.CodeAnalysis.LocalizableString
                    localizableString, System.EventHandler<System.Exception>
                    handler)
                    {
                        ForceLocalizableStringExceptions(localizableString, handler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 14681, 14740);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_235_14800_14824(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.MessageFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 14800, 14824);
                        return return_v;
                    }


                    int
                    f_235_14767_14834(Microsoft.CodeAnalysis.LocalizableString
                    localizableString, System.EventHandler<System.Exception>
                    handler)
                    {
                        ForceLocalizableStringExceptions(localizableString, handler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 14767, 14834);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.LocalizableString
                    f_235_14894_14916(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    this_param)
                    {
                        var return_v = this_param.Description;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 14894, 14916);
                        return return_v;
                    }


                    int
                    f_235_14861_14926(Microsoft.CodeAnalysis.LocalizableString
                    localizableString, System.EventHandler<System.Exception>
                    handler)
                    {
                        ForceLocalizableStringExceptions(localizableString, handler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 14861, 14926);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_235_14611_14631_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 14611, 14631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 12539, 15032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 12539, 15032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ImmutableArray<SuppressionDescriptor> ComputeSuppressionDescriptors(
                            DiagnosticAnalyzer analyzer,
                            AnalyzerExecutor analyzerExecutor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(235, 15048, 16658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 15262, 15324);

                    var
                    descriptors = ImmutableArray<SuppressionDescriptor>.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 15344, 16604) || true) && (analyzer is DiagnosticSuppressor suppressor)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 15344, 16604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 15511, 16585);

                        f_235_15511_16584(                    // Catch Exception from suppressor.SupportedSuppressions
                                            analyzerExecutor, analyzer, _ =>
                                                {
                                                    var descriptorsLocal = suppressor.SupportedSuppressions;
                                                    if (!descriptorsLocal.IsDefaultOrEmpty)
                                                    {
                                                        foreach (var descriptor in descriptorsLocal)
                                                        {
                                                            if (descriptor == null)
                                                            {
                                        // Disallow null descriptors.
                                        throw new ArgumentException(string.Format(CodeAnalysisResources.SupportedSuppressionsHasNullDescriptor, analyzer.ToString()), nameof(DiagnosticSuppressor.SupportedSuppressions));
                                                            }
                                                        }

                                                        descriptors = descriptorsLocal;
                                                    }
                                                }, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(235, 15344, 16604);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 16624, 16643);

                    return descriptors;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(235, 15048, 16658);

                    int
                    f_235_15511_16584(Microsoft.CodeAnalysis.Diagnostics.AnalyzerExecutor
                    this_param, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, System.Action<object>
                    analyze, object?
                    argument)
                    {
                        this_param.ExecuteAndCatchIfThrows<object?>(analyzer, analyze, argument: argument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 15511, 16584);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 15048, 16658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 15048, 16658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryProcessCompletedMemberAndGetPendingSymbolEndActionsForContainer(
                            ISymbol containingSymbol,
                            ISymbol processedMemberSymbol,
                            out (ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, SymbolDeclaredCompilationEvent symbolDeclaredEvent) containerEndActionsAndEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 16674, 18032);
                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>? pendingMemberSymbols = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17038, 17076);

                    containerEndActionsAndEvent = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17100, 17105);
                    lock (_gate)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17147, 17391) || true) && (_lazyPendingMemberSymbolsMap == null || (DynAbs.Tracing.TraceSender.Expression_False(235, 17151, 17305) || !f_235_17217_17305(_lazyPendingMemberSymbolsMap, containingSymbol, out pendingMemberSymbols)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 17147, 17391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17355, 17368);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 17147, 17391);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17415, 17458);

                        f_235_17415_17457(pendingMemberSymbols != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17482, 17547);

                        var
                        removed = f_235_17496_17546(pendingMemberSymbols, processedMemberSymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17571, 17883) || true) && (f_235_17575_17601(pendingMemberSymbols) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(235, 17575, 17673) || _lazyPendingSymbolEndActionsMap == null) || (DynAbs.Tracing.TraceSender.Expression_False(235, 17575, 17797) || !f_235_17703_17797(_lazyPendingSymbolEndActionsMap, containingSymbol, out containerEndActionsAndEvent)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 17571, 17883);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17847, 17860);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 17571, 17883);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17907, 17964);

                        f_235_17907_17963(
                                            _lazyPendingSymbolEndActionsMap, containingSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 17986, 17998);

                        return true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 16674, 18032);

                    bool
                    f_235_17217_17305(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 17217, 17305);
                        return return_v;
                    }


                    int
                    f_235_17415_17457(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 17415, 17457);
                        return 0;
                    }


                    bool
                    f_235_17496_17546(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        var return_v = this_param.Remove(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 17496, 17546);
                        return return_v;
                    }


                    int
                    f_235_17575_17601(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 17575, 17601);
                        return return_v;
                    }


                    bool
                    f_235_17703_17797(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent)>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction> symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent symbolDeclaredEvent)
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 17703, 17797);
                        return return_v;
                    }


                    bool
                    f_235_17907_17963(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent)>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 17907, 17963);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 16674, 18032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 16674, 18032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryStartExecuteSymbolEndActions(ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, SymbolDeclaredCompilationEvent symbolDeclaredEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 18048, 19221);
                    System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>? pendingMemberSymbols = default(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18234, 18274);

                    f_235_18234_18273(f_235_18247_18272_M(!symbolEndActions.IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18294, 18334);

                    var
                    symbol = f_235_18307_18333(symbolDeclaredEvent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18358, 18363);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18405, 18456);

                        f_235_18405_18455(_lazyPendingMemberSymbolsMap != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18480, 18944) || true) && (f_235_18484_18562(_lazyPendingMemberSymbolsMap, symbol, out pendingMemberSymbols) && (DynAbs.Tracing.TraceSender.Expression_True(235, 18484, 18622) && f_235_18591_18618_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pendingMemberSymbols, 235, 18591, 18618)?.Count) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(235, 18480, 18944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18799, 18882);

                            f_235_18799_18881(this, symbol, symbolEndActions, symbolDeclaredEvent);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 18908, 18921);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(235, 18480, 18944);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19105, 19153);

                        f_235_19105_19152_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyPendingSymbolEndActionsMap, 235, 19105, 19152)?.Remove(symbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19175, 19187);

                        return true;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 18048, 19221);

                    bool
                    f_235_18247_18272_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 18247, 18272);
                        return return_v;
                    }


                    int
                    f_235_18234_18273(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 18234, 18273);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_235_18307_18333(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 18307, 18333);
                        return return_v;
                    }


                    int
                    f_235_18405_18455(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 18405, 18455);
                        return 0;
                    }


                    bool
                    f_235_18484_18562(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 18484, 18562);
                        return return_v;
                    }


                    int?
                    f_235_18591_18618_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 18591, 18618);
                        return return_v;
                    }


                    int
                    f_235_18799_18881(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                    symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    symbolDeclaredEvent)
                    {
                        this_param.MarkSymbolEndAnalysisPending_NoLock(symbol, symbolEndActions, symbolDeclaredEvent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 18799, 18881);
                        return 0;
                    }


                    bool?
                    f_235_19105_19152_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 19105, 19152);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 18048, 19221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 18048, 19221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void MarkSymbolEndAnalysisComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 19237, 19459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19333, 19338);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19380, 19425);

                        f_235_19380_19424_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyPendingMemberSymbolsMap, 235, 19380, 19424)?.Remove(symbol));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 19237, 19459);

                    bool?
                    f_235_19380_19424_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 19380, 19424);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 19237, 19459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 19237, 19459);
                }
            }

            public void MarkSymbolEndAnalysisPending(ISymbol symbol, ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, SymbolDeclaredCompilationEvent symbolDeclaredEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 19475, 19844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19680, 19685);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 19727, 19810);

                        f_235_19727_19809(this, symbol, symbolEndActions, symbolDeclaredEvent);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 19475, 19844);

                    int
                    f_235_19727_19809(Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager.AnalyzerExecutionContext
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>
                    symbolEndActions, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    symbolDeclaredEvent)
                    {
                        this_param.MarkSymbolEndAnalysisPending_NoLock(symbol, symbolEndActions, symbolDeclaredEvent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 19727, 19809);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 19475, 19844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 19475, 19844);
                }
            }

            private void MarkSymbolEndAnalysisPending_NoLock(ISymbol symbol, ImmutableArray<SymbolEndAnalyzerAction> symbolEndActions, SymbolDeclaredCompilationEvent symbolDeclaredEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 19860, 20319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 20067, 20204);

                    _lazyPendingSymbolEndActionsMap ??= f_235_20103_20203();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 20222, 20304);

                    _lazyPendingSymbolEndActionsMap[symbol] = (symbolEndActions, symbolDeclaredEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 19860, 20319);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent)>
                    f_235_20103_20203()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent)>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 20103, 20203);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 19860, 20319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 19860, 20319);
                }
            }

            [Conditional("DEBUG")]
            public void VerifyAllSymbolEndActionsExecuted()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(235, 20335, 20754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 20457, 20462);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 20504, 20598);

                        f_235_20504_20597(_lazyPendingMemberSymbolsMap == null || (DynAbs.Tracing.TraceSender.Expression_False(235, 20517, 20596) || f_235_20557_20591(_lazyPendingMemberSymbolsMap) == 0));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(235, 20620, 20720);

                        f_235_20620_20719(_lazyPendingSymbolEndActionsMap == null || (DynAbs.Tracing.TraceSender.Expression_False(235, 20633, 20718) || f_235_20676_20713(_lazyPendingSymbolEndActionsMap) == 0));
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(235, 20335, 20754);

                    int
                    f_235_20557_20591(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.ISymbol>?>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 20557, 20591);
                        return return_v;
                    }


                    int
                    f_235_20504_20597(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 20504, 20597);
                        return 0;
                    }


                    int
                    f_235_20676_20713(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SymbolEndAnalyzerAction>, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent)>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(235, 20676, 20713);
                        return return_v;
                    }


                    int
                    f_235_20620_20719(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 20620, 20719);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(235, 20335, 20754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 20335, 20754);
                }
            }

            static AnalyzerExecutionContext()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(235, 508, 20765);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(235, 508, 20765);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 508, 20765);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(235, 508, 20765);

            static object
            f_235_2873_2885()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(235, 2873, 2885);
                return return_v;
            }

        }

        static AnalyzerManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(235, 453, 20772);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(235, 453, 20772);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(235, 453, 20772);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(235, 453, 20772);
    }
}
