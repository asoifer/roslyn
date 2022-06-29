// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalysisState
    {
        private class PerAnalyzerState
        {
            private readonly object _gate;

            private readonly Dictionary<CompilationEvent, AnalyzerStateData?> _pendingEvents;

            private readonly Dictionary<ISymbol, AnalyzerStateData?> _pendingSymbols;

            private readonly Dictionary<ISymbol, Dictionary<int, DeclarationAnalyzerStateData>?> _pendingDeclarations;

            private Dictionary<SourceOrAdditionalFile, AnalyzerStateData>? _lazyFilesWithAnalysisData;

            private int _pendingSyntaxAnalysisFilesCount;

            private Dictionary<ISymbol, AnalyzerStateData?>? _lazyPendingSymbolEndAnalyses;

            private readonly ObjectPool<AnalyzerStateData> _analyzerStateDataPool;

            private readonly ObjectPool<DeclarationAnalyzerStateData> _declarationAnalyzerStateDataPool;

            private readonly ObjectPool<Dictionary<int, DeclarationAnalyzerStateData>> _currentlyAnalyzingDeclarationsMapPool;

            public PerAnalyzerState(
                            ObjectPool<AnalyzerStateData> analyzerStateDataPool,
                            ObjectPool<DeclarationAnalyzerStateData> declarationAnalyzerStateDataPool,
                            ObjectPool<Dictionary<int, DeclarationAnalyzerStateData>> currentlyAnalyzingDeclarationsMapPool)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(213, 1649, 2556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 747, 752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 833, 847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 919, 934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1034, 1054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1134, 1160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1187, 1219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1283, 1312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1376, 1398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1471, 1504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1594, 1632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 1982, 2003);

                    _gate = f_213_1990_2002();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2021, 2093);

                    _pendingEvents = f_213_2038_2092();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2111, 2175);

                    _pendingSymbols = f_213_2129_2174();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2193, 2290);

                    _pendingDeclarations = f_213_2216_2289();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2310, 2357);

                    _analyzerStateDataPool = analyzerStateDataPool;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2375, 2444);

                    _declarationAnalyzerStateDataPool = declarationAnalyzerStateDataPool;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2462, 2541);

                    _currentlyAnalyzingDeclarationsMapPool = currentlyAnalyzingDeclarationsMapPool;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(213, 1649, 2556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 1649, 2556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 1649, 2556);
                }
            }

            public void AddPendingEvents(HashSet<CompilationEvent> uniqueEvents)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 2572, 2912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2679, 2684);
                    lock (_gate)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2726, 2878);
                            foreach (var pendingEvent in f_213_2755_2774_I(f_213_2755_2774(_pendingEvents)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 2726, 2878);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 2824, 2855);

                                f_213_2824_2854(uniqueEvents, pendingEvent);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 2726, 2878);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(213, 1, 153);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(213, 1, 153);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 2572, 2912);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>.KeyCollection
                    f_213_2755_2774(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 2755, 2774);
                        return return_v;
                    }


                    bool
                    f_213_2824_2854(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 2824, 2854);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>.KeyCollection
                    f_213_2755_2774_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>.KeyCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 2755, 2774);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 2572, 2912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 2572, 2912);
                }
            }

            public bool HasPendingSyntaxAnalysis(SourceOrAdditionalFile? file)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 2928, 3927);
                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData state = default(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3033, 3038);
                    lock (_gate)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3080, 3207) || true) && (_pendingSyntaxAnalysisFilesCount == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 3080, 3207);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3171, 3184);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 3080, 3207);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3231, 3280);

                        f_213_3231_3279(_lazyFilesWithAnalysisData != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3304, 3490) || true) && (f_213_3308_3322_M(!file.HasValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 3304, 3490);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3455, 3467);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 3304, 3490);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3514, 3745) || true) && (!f_213_3519_3584(_lazyFilesWithAnalysisData, file.Value, out state))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 3514, 3745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3710, 3722);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 3514, 3745);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 3842, 3893);

                        return f_213_3849_3864(state) != StateKind.FullyProcessed;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 2928, 3927);

                    int
                    f_213_3231_3279(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 3231, 3279);
                        return 0;
                    }


                    bool
                    f_213_3308_3322_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 3308, 3322);
                        return return_v;
                    }


                    bool
                    f_213_3519_3584(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 3519, 3584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_3849_3864(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 3849, 3864);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 2928, 3927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 2928, 3927);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool HasPendingSymbolAnalysis(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 3943, 4245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 4034, 4039);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 4081, 4211);

                        return f_213_4088_4123(_pendingSymbols, symbol) || (DynAbs.Tracing.TraceSender.Expression_False(213, 4088, 4210) || f_213_4152_4202_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_lazyPendingSymbolEndAnalyses, 213, 4152, 4202)?.ContainsKey(symbol)) == true);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 3943, 4245);

                    bool
                    f_213_4088_4123(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 4088, 4123);
                        return return_v;
                    }


                    bool?
                    f_213_4152_4202_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 4152, 4202);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 3943, 4245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 3943, 4245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryStartProcessingEntity<TAnalysisEntity, TAnalyzerStateData>(
                            TAnalysisEntity analysisEntity,
                            Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities,
                            ObjectPool<TAnalyzerStateData> pool,
                            [NotNullWhen(returnValue: true)] out TAnalyzerStateData? newState)
                            where TAnalyzerStateData : AnalyzerStateData, new()
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 4261, 4936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 4763, 4768);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 4810, 4902);

                        // LAFHIS
                        return f_213_4817_4901(analysisEntity, pendingEntities, pool, out newState);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 4261, 4936);

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 4261, 4936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 4261, 4936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool f_213_4817_4901<TAnalysisEntity, TAnalyzerStateData>(TAnalysisEntity
                analysisEntity, System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<TAnalyzerStateData>
                pool, out TAnalyzerStateData?
                state)
                where TAnalyzerStateData : AnalyzerStateData
                where TAnalysisEntity : notnull
            {
                var return_v = TryStartProcessingEntity_NoLock(analysisEntity, pendingEntities, pool, out state);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 4817, 4901);
                return return_v;
            }

            private static bool TryStartProcessingEntity_NoLock<TAnalysisEntity, TAnalyzerStateData>(
                            TAnalysisEntity analysisEntity,
                            Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities,
                            ObjectPool<TAnalyzerStateData> pool,
                            [NotNullWhen(returnValue: true)] out TAnalyzerStateData? state)
                            where TAnalyzerStateData : AnalyzerStateData
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(213, 4952, 6086);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5452, 6007) || true) && (f_213_5456_5510(pendingEntities, analysisEntity, out state) && (DynAbs.Tracing.TraceSender.Expression_True(213, 5456, 5597) && (state == null || (DynAbs.Tracing.TraceSender.Expression_False(213, 5536, 5596) || f_213_5553_5568(state) == StateKind.ReadyToProcess))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 5452, 6007);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5639, 5753) || true) && (state == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 5639, 5753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5706, 5730);

                            state = f_213_5714_5729(pool);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 5639, 5753);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5777, 5817);

                        f_213_5777_5816(
                                            state, StateKind.InProcess);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5839, 5892);

                        f_213_5839_5891(f_213_5852_5867(state) == StateKind.InProcess);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5914, 5954);

                        pendingEntities[analysisEntity] = state;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 5976, 5988);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 5452, 6007);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 6027, 6040);

                    state = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 6058, 6071);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(213, 4952, 6086);

                    bool
                    f_213_5456_5510<TAnalyzerStateData>(System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                    this_param, TAnalysisEntity
                    key, out TAnalyzerStateData?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 5456, 5510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_5553_5568(TAnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 5553, 5568);
                        return return_v;
                    }


                    TAnalyzerStateData
                    f_213_5714_5729(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<TAnalyzerStateData>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 5714, 5729);
                        return return_v;
                    }


                    int
                    f_213_5777_5816(TAnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 5777, 5816);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_5852_5867(TAnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 5852, 5867);
                        return return_v;
                    }


                    int
                    f_213_5839_5891(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 5839, 5891);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 4952, 6086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 4952, 6086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void MarkEntityProcessed<TAnalysisEntity, TAnalyzerStateData>(
                            TAnalysisEntity analysisEntity,
                            Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities,
                            ObjectPool<TAnalyzerStateData> pool)
                            where TAnalyzerStateData : AnalyzerStateData
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 6102, 6655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 6508, 6513);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 6555, 6621);

                        // LAFHIS
                        f_213_6555_6620(analysisEntity, pendingEntities, pool);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 6102, 6655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 6102, 6655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 6102, 6655);
                }
            }

            bool
            f_213_6555_6620<TAnalysisEntity, TAnalyzerStateData>(TAnalysisEntity
            analysisEntity, System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
            pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<TAnalyzerStateData>
            pool)
                where TAnalyzerStateData : AnalyzerStateData
                where TAnalysisEntity : notnull
            {
                var return_v = MarkEntityProcessed_NoLock(analysisEntity, pendingEntities, pool);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 6555, 6620);
                return return_v;
            }

            private static bool MarkEntityProcessed_NoLock<TAnalysisEntity, TAnalyzerStateData>(
                            TAnalysisEntity analysisEntity,
                            Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities,
                            ObjectPool<TAnalyzerStateData> pool)
                            where TAnalyzerStateData : AnalyzerStateData
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(213, 6671, 7381);
                    TAnalyzerStateData? state = default(TAnalyzerStateData?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7085, 7333) || true) && (f_213_7089_7147(pendingEntities, analysisEntity, out state))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 7085, 7333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7189, 7228);

                        f_213_7189_7227(pendingEntities, analysisEntity);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7250, 7280);

                        f_213_7250_7279(state, pool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7302, 7314);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 7085, 7333);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7353, 7366);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(213, 6671, 7381);

                    bool
                    f_213_7089_7147<TAnalyzerStateData>(System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                    this_param, TAnalysisEntity
                    key, out TAnalyzerStateData?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 7089, 7147);
                        return return_v;
                    }


                    bool
                    f_213_7189_7227<TAnalyzerStateData>(System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                    this_param, TAnalysisEntity
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 7189, 7227);
                        return return_v;
                    }


                    int
                    f_213_7250_7279(TAnalyzerStateData?
                    state, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<TAnalyzerStateData>
                    pool)
                    {
                        FreeState_NoLock(state, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 7250, 7279);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 6671, 7381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 6671, 7381);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryStartSyntaxAnalysis_NoLock(SourceOrAdditionalFile file, [NotNullWhen(returnValue: true)] out AnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 7397, 8454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7564, 7613);

                    f_213_7564_7612(_lazyFilesWithAnalysisData != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7633, 7783) || true) && (_pendingSyntaxAnalysisFilesCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 7633, 7783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7716, 7729);

                        state = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7751, 7764);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 7633, 7783);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7803, 8219) || true) && (f_213_7807_7862(_lazyFilesWithAnalysisData, file, out state))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 7803, 8219);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 7904, 8076) || true) && (f_213_7908_7923(state) != StateKind.ReadyToProcess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 7904, 8076);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8001, 8014);

                            state = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8040, 8053);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 7904, 8076);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 7803, 8219);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 7803, 8219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8158, 8200);

                        state = f_213_8166_8199(_analyzerStateDataPool);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 7803, 8219);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8239, 8279);

                    f_213_8239_8278(
                                    state, StateKind.InProcess);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8297, 8350);

                    f_213_8297_8349(f_213_8310_8325(state) == StateKind.InProcess);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8368, 8409);

                    _lazyFilesWithAnalysisData[file] = state;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8427, 8439);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 7397, 8454);

                    int
                    f_213_7564_7612(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 7564, 7612);
                        return 0;
                    }


                    bool
                    f_213_7807_7862(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 7807, 7862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_7908_7923(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 7908, 7923);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    f_213_8166_8199(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 8166, 8199);
                        return return_v;
                    }


                    int
                    f_213_8239_8278(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 8239, 8278);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_8310_8325(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 8310, 8325);
                        return return_v;
                    }


                    int
                    f_213_8297_8349(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 8297, 8349);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 7397, 8454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 7397, 8454);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void MarkSyntaxAnalysisComplete_NoLock(SourceOrAdditionalFile file)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 8470, 9509);
                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData state = default(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8578, 8687) || true) && (_pendingSyntaxAnalysisFilesCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 8578, 8687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8661, 8668);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 8578, 8687);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8707, 8756);

                    f_213_8707_8755(_lazyFilesWithAnalysisData != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8776, 8813);

                    var
                    wasAlreadyFullyProcessed = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8831, 9253) || true) && (f_213_8835_8894(_lazyFilesWithAnalysisData, file, out state))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 8831, 9253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 8936, 9234) || true) && (f_213_8940_8955(state) != StateKind.FullyProcessed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 8936, 9234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9033, 9081);

                            f_213_9033_9080(state, _analyzerStateDataPool);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 8936, 9234);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 8936, 9234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9179, 9211);

                            wasAlreadyFullyProcessed = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 8936, 9234);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 8831, 9253);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9273, 9398) || true) && (!wasAlreadyFullyProcessed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 9273, 9398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9344, 9379);

                        _pendingSyntaxAnalysisFilesCount--;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 9273, 9398);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9418, 9494);

                    _lazyFilesWithAnalysisData[file] = AnalyzerStateData.FullyProcessedInstance;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 8470, 9509);

                    int
                    f_213_8707_8755(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 8707, 8755);
                        return 0;
                    }


                    bool
                    f_213_8835_8894(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 8835, 8894);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_8940_8955(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 8940, 8955);
                        return return_v;
                    }


                    int
                    f_213_9033_9080(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    state, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool)
                    {
                        FreeState_NoLock(state, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 9033, 9080);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 8470, 9509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 8470, 9509);
                }
            }

            private Dictionary<int, DeclarationAnalyzerStateData> EnsureDeclarationDataMap_NoLock(ISymbol symbol, Dictionary<int, DeclarationAnalyzerStateData>? declarationDataMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 9525, 10106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9726, 9791);

                    f_213_9726_9790(f_213_9739_9767(_pendingDeclarations, symbol) == declarationDataMap);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9811, 10045) || true) && (declarationDataMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 9811, 10045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9883, 9954);

                        declarationDataMap = f_213_9904_9953(_currentlyAnalyzingDeclarationsMapPool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 9976, 10026);

                        _pendingDeclarations[symbol] = declarationDataMap;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 9811, 10045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10065, 10091);

                    return declarationDataMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 9525, 10106);

                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    f_213_9739_9767(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 9739, 9767);
                        return return_v;
                    }


                    int
                    f_213_9726_9790(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 9726, 9790);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    f_213_9904_9953(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 9904, 9953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 9525, 10106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 9525, 10106);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryStartAnalyzingDeclaration_NoLock(
                            ISymbol symbol,
                            int declarationIndex,
                            [NotNullWhen(returnValue: true)] out DeclarationAnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 10122, 11340);
                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>? declarationDataMap = default(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10367, 10549) || true) && (!f_213_10372_10440(_pendingDeclarations, symbol, out declarationDataMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 10367, 10549);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10482, 10495);

                        state = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10517, 10530);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 10367, 10549);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10569, 10650);

                    declarationDataMap = f_213_10590_10649(this, symbol, declarationDataMap);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10670, 11101) || true) && (f_213_10674_10733(declarationDataMap, declarationIndex, out state))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 10670, 11101);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10775, 10947) || true) && (f_213_10779_10794(state) != StateKind.ReadyToProcess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 10775, 10947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10872, 10885);

                            state = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 10911, 10924);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 10775, 10947);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 10670, 11101);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 10670, 11101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11029, 11082);

                        state = f_213_11037_11081(_declarationAnalyzerStateDataPool);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 10670, 11101);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11121, 11161);

                    f_213_11121_11160(
                                    state, StateKind.InProcess);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11179, 11232);

                    f_213_11179_11231(f_213_11192_11207(state) == StateKind.InProcess);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11250, 11295);

                    declarationDataMap[declarationIndex] = state;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11313, 11325);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 10122, 11340);

                    bool
                    f_213_10372_10440(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 10372, 10440);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    f_213_10590_10649(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    declarationDataMap)
                    {
                        var return_v = this_param.EnsureDeclarationDataMap_NoLock(symbol, declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 10590, 10649);
                        return return_v;
                    }


                    bool
                    f_213_10674_10733(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param, int
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 10674, 10733);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_10779_10794(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 10779, 10794);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    f_213_11037_11081(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11037, 11081);
                        return return_v;
                    }


                    int
                    f_213_11121_11160(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    stateKind)
                    {
                        this_param.SetStateKind(stateKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11121, 11160);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_11192_11207(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 11192, 11207);
                        return return_v;
                    }


                    int
                    f_213_11179_11231(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11179, 11231);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 10122, 11340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 10122, 11340);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void MarkDeclarationProcessed_NoLock(ISymbol symbol, int declarationIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 11356, 12030);
                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>? declarationDataMap = default(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?);
                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData state = default(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11471, 11612) || true) && (!f_213_11476_11544(_pendingDeclarations, symbol, out declarationDataMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 11471, 11612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11586, 11593);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 11471, 11612);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11632, 11713);

                    declarationDataMap = f_213_11653_11712(this, symbol, declarationDataMap);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11733, 11904) || true) && (f_213_11737_11800(declarationDataMap, declarationIndex, out state))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 11733, 11904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11842, 11885);

                        f_213_11842_11884(this, state);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 11733, 11904);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 11924, 12015);

                    declarationDataMap[declarationIndex] = DeclarationAnalyzerStateData.FullyProcessedInstance;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 11356, 12030);

                    bool
                    f_213_11476_11544(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11476, 11544);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    f_213_11653_11712(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    declarationDataMap)
                    {
                        var return_v = this_param.EnsureDeclarationDataMap_NoLock(symbol, declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11653, 11712);
                        return return_v;
                    }


                    bool
                    f_213_11737_11800(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param, int
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11737, 11800);
                        return return_v;
                    }


                    int
                    f_213_11842_11884(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    state)
                    {
                        this_param.FreeDeclarationAnalyzerState_NoLock(state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 11842, 11884);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 11356, 12030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 11356, 12030);
                }
            }

            private void MarkDeclarationsProcessed_NoLock(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 12046, 12396);
                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>? declarationDataMap = default(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12140, 12381) || true) && (f_213_12144_12212(_pendingDeclarations, symbol, out declarationDataMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 12140, 12381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12254, 12304);

                        f_213_12254_12303(this, declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12326, 12362);

                        f_213_12326_12361(_pendingDeclarations, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 12140, 12381);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 12046, 12396);

                    bool
                    f_213_12144_12212(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12144, 12212);
                        return return_v;
                    }


                    int
                    f_213_12254_12303(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    declarationDataMap)
                    {
                        this_param.FreeDeclarationDataMap_NoLock(declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12254, 12303);
                        return 0;
                    }


                    bool
                    f_213_12326_12361(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12326, 12361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 12046, 12396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 12046, 12396);
                }
            }

            private void FreeDeclarationDataMap_NoLock(Dictionary<int, DeclarationAnalyzerStateData>? declarationDataMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 12412, 12775);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12554, 12760) || true) && (declarationDataMap is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 12554, 12760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12628, 12655);

                        f_213_12628_12654(declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12677, 12741);

                        f_213_12677_12740(_currentlyAnalyzingDeclarationsMapPool, declarationDataMap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 12554, 12760);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 12412, 12775);

                    int
                    f_213_12628_12654(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param)
                    {
                        this_param.Clear();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12628, 12654);
                        return 0;
                    }


                    int
                    f_213_12677_12740(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>>
                    this_param, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12677, 12740);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 12412, 12775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 12412, 12775);
                }
            }

            private void FreeDeclarationAnalyzerState_NoLock(DeclarationAnalyzerStateData state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 12791, 13149);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 12908, 13055) || true) && (f_213_12912_12987(state, DeclarationAnalyzerStateData.FullyProcessedInstance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 12908, 13055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13029, 13036);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 12908, 13055);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13075, 13134);

                    f_213_13075_13133(state, _declarationAnalyzerStateDataPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 12791, 13149);

                    bool
                    f_213_12912_12987(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    objA, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 12912, 12987);
                        return return_v;
                    }


                    int
                    f_213_13075_13133(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    state, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    pool)
                    {
                        FreeState_NoLock(state, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 13075, 13133);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 12791, 13149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 12791, 13149);
                }
            }

            private static void FreeState_NoLock<TAnalyzerStateData>(TAnalyzerStateData? state, ObjectPool<TAnalyzerStateData> pool)
                            where TAnalyzerStateData : AnalyzerStateData
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(213, 13165, 13594);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13380, 13579) || true) && (state != null && (DynAbs.Tracing.TraceSender.Expression_True(213, 13384, 13466) && !f_213_13402_13466(state, AnalyzerStateData.FullyProcessedInstance)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 13380, 13579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13508, 13521);

                        f_213_13508_13520(state);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13543, 13560);

                        f_213_13543_13559(pool, state);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 13380, 13579);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(213, 13165, 13594);

                    bool
                    f_213_13402_13466(TAnalyzerStateData
                    objA, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 13402, 13466);
                        return return_v;
                    }


                    int
                    f_213_13508_13520(TAnalyzerStateData
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 13508, 13520);
                        return 0;
                    }


                    int
                    f_213_13543_13559(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<TAnalyzerStateData>
                    this_param, TAnalyzerStateData
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 13543, 13559);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 13165, 13594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 13165, 13594);
                }
            }

            private bool IsEntityFullyProcessed<TAnalysisEntity, TAnalyzerStateData>(TAnalysisEntity analysisEntity, Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities)
                            where TAnalyzerStateData : AnalyzerStateData
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 13610, 14081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13930, 13935);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 13977, 14047);

                        return f_213_13984_14046(analysisEntity, pendingEntities);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 13610, 14081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 13610, 14081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 13610, 14081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool f_213_13984_14046<TAnalysisEntity, TAnalyzerStateData>(TAnalysisEntity
                analysisEntity, System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                pendingEntities)
                where TAnalyzerStateData : AnalyzerStateData
                where TAnalysisEntity : notnull
            {
                var return_v = IsEntityFullyProcessed_NoLock<TAnalysisEntity, TAnalyzerStateData>(analysisEntity, pendingEntities);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 13984, 14046);
                return return_v;
            }

            private static bool IsEntityFullyProcessed_NoLock<TAnalysisEntity, TAnalyzerStateData>(TAnalysisEntity analysisEntity, Dictionary<TAnalysisEntity, TAnalyzerStateData?> pendingEntities)
                            where TAnalyzerStateData : AnalyzerStateData
                            where TAnalysisEntity : notnull
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(213, 14097, 14576);
                    TAnalyzerStateData? state = default(TAnalyzerStateData?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 14425, 14561);

                    return !f_213_14433_14491(pendingEntities, analysisEntity, out state) || (DynAbs.Tracing.TraceSender.Expression_False(213, 14432, 14560) || f_213_14516_14532_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(state, 213, 14516, 14532)?.StateKind) == StateKind.FullyProcessed);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(213, 14097, 14576);

                    bool
                    f_213_14433_14491<TAnalyzerStateData>(System.Collections.Generic.Dictionary<TAnalysisEntity, TAnalyzerStateData?>
                    this_param, TAnalysisEntity
                    key, out TAnalyzerStateData?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 14433, 14491);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind?
                    f_213_14516_14532_M(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 14516, 14532);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 14097, 14576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 14097, 14576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsDeclarationComplete_NoLock(ISymbol symbol, int declarationIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 14592, 15149);
                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>? declarationDataMap = default(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?);
                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData state = default(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 14704, 14850) || true) && (!f_213_14709_14777(_pendingDeclarations, symbol, out declarationDataMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 14704, 14850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 14819, 14831);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 14704, 14850);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 14870, 15063) || true) && (declarationDataMap == null || (DynAbs.Tracing.TraceSender.Expression_False(213, 14874, 14989) || !f_213_14926_14989(declarationDataMap, declarationIndex, out state)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 14870, 15063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15031, 15044);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 14870, 15063);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15083, 15134);

                    return f_213_15090_15105(state) == StateKind.FullyProcessed;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 14592, 15149);

                    bool
                    f_213_14709_14777(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 14709, 14777);
                        return return_v;
                    }


                    bool
                    f_213_14926_14989(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param, int
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 14926, 14989);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalysisState.StateKind
                    f_213_15090_15105(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData
                    this_param)
                    {
                        var return_v = this_param.StateKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 15090, 15105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 14592, 15149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 14592, 15149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreDeclarationsProcessed_NoLock(ISymbol symbol, int declarationsCount)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 15165, 15678);
                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>? declarationDataMap = default(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15281, 15317);

                    f_213_15281_15316(declarationsCount > 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15335, 15481) || true) && (!f_213_15340_15408(_pendingDeclarations, symbol, out declarationDataMap))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 15335, 15481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15450, 15462);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 15335, 15481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15501, 15663);

                    return f_213_15508_15533_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(declarationDataMap, 213, 15508, 15533)?.Count) == declarationsCount && (DynAbs.Tracing.TraceSender.Expression_True(213, 15508, 15662) && f_213_15579_15662(f_213_15579_15604(declarationDataMap), state => state.StateKind == StateKind.FullyProcessed));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 15165, 15678);

                    int
                    f_213_15281_15316(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 15281, 15316);
                        return 0;
                    }


                    bool
                    f_213_15340_15408(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 15340, 15408);
                        return return_v;
                    }


                    int?
                    f_213_15508_15533_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 15508, 15533);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>.ValueCollection
                    f_213_15579_15604(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>
                    this_param)
                    {
                        var return_v = this_param.Values;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 15579, 15604);
                        return return_v;
                    }


                    bool
                    f_213_15579_15662(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>.ValueCollection
                    source, System.Func<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData, bool>
                    predicate)
                    {
                        var return_v = source.All<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 15579, 15662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 15165, 15678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 15165, 15678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryStartProcessingEvent(CompilationEvent compilationEvent, [NotNullWhen(returnValue: true)] out AnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 15694, 15976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 15860, 15961);

                    return f_213_15867_15960(this, compilationEvent, _pendingEvents, _analyzerStateDataPool, out state);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 15694, 15976);

                    bool
                    f_213_15867_15960(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                    newState)
                    {
                        var return_v = this_param.TryStartProcessingEntity<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool, out newState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 15867, 15960);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 15694, 15976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 15694, 15976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void MarkEventComplete(CompilationEvent compilationEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 15992, 16182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 16089, 16167);

                    f_213_16089_16166(this, compilationEvent, _pendingEvents, _analyzerStateDataPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 15992, 16182);

                    int
                    f_213_16089_16166(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool)
                    {
                        this_param.MarkEntityProcessed<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 16089, 16166);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 15992, 16182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 15992, 16182);
                }
            }

            public bool TryStartAnalyzingSymbol(ISymbol symbol, [NotNullWhen(returnValue: true)] out AnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 16198, 16452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 16345, 16437);

                    return f_213_16352_16436(this, symbol, _pendingSymbols, _analyzerStateDataPool, out state);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 16198, 16452);

                    bool
                    f_213_16352_16436(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                    newState)
                    {
                        var return_v = this_param.TryStartProcessingEntity<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool, out newState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 16352, 16436);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 16198, 16452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 16198, 16452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryStartSymbolEndAnalysis(ISymbol symbol, [NotNullWhen(returnValue: true)] out AnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 16468, 16808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 16617, 16669);

                    f_213_16617_16668(_lazyPendingSymbolEndAnalyses != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 16687, 16793);

                    return f_213_16694_16792(this, symbol, _lazyPendingSymbolEndAnalyses, _analyzerStateDataPool, out state);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 16468, 16808);

                    int
                    f_213_16617_16668(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 16617, 16668);
                        return 0;
                    }


                    bool
                    f_213_16694_16792(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                    newState)
                    {
                        var return_v = this_param.TryStartProcessingEntity<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool, out newState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 16694, 16792);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 16468, 16808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 16468, 16808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void MarkSymbolComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 16824, 16987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 16903, 16972);

                    f_213_16903_16971(this, symbol, _pendingSymbols, _analyzerStateDataPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 16824, 16987);

                    int
                    f_213_16903_16971(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool)
                    {
                        this_param.MarkEntityProcessed<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 16903, 16971);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 16824, 16987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 16824, 16987);
                }
            }

            public void MarkSymbolEndAnalysisComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 17003, 17293);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17093, 17278) || true) && (_lazyPendingSymbolEndAnalyses != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 17093, 17278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17176, 17259);

                        f_213_17176_17258(this, symbol, _lazyPendingSymbolEndAnalyses, _analyzerStateDataPool);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 17093, 17278);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 17003, 17293);

                    int
                    f_213_17176_17258(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool)
                    {
                        this_param.MarkEntityProcessed<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 17176, 17258);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 17003, 17293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 17003, 17293);
                }
            }

            public bool TryStartAnalyzingDeclaration(
                            ISymbol symbol,
                            int declarationIndex,
                            [NotNullWhen(returnValue: true)] out DeclarationAnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 17309, 17713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17552, 17557);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17599, 17679);

                        return f_213_17606_17678(this, symbol, declarationIndex, out state);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 17309, 17713);

                    bool
                    f_213_17606_17678(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, int
                    declarationIndex, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData?
                    state)
                    {
                        var return_v = this_param.TryStartAnalyzingDeclaration_NoLock(symbol, declarationIndex, out state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 17606, 17678);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 17309, 17713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 17309, 17713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool IsDeclarationComplete(ISymbol symbol, int declarationIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 17729, 17982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17839, 17844);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 17886, 17948);

                        return f_213_17893_17947(this, symbol, declarationIndex);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 17729, 17982);

                    bool
                    f_213_17893_17947(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, int
                    declarationIndex)
                    {
                        var return_v = this_param.IsDeclarationComplete_NoLock(symbol, declarationIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 17893, 17947);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 17729, 17982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 17729, 17982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void MarkDeclarationComplete(ISymbol symbol, int declarationIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 17998, 18249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18110, 18115);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18157, 18215);

                        f_213_18157_18214(this, symbol, declarationIndex);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 17998, 18249);

                    int
                    f_213_18157_18214(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, int
                    declarationIndex)
                    {
                        this_param.MarkDeclarationProcessed_NoLock(symbol, declarationIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 18157, 18214);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 17998, 18249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 17998, 18249);
                }
            }

            public void MarkDeclarationsComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 18265, 18478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18356, 18361);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18403, 18444);

                        f_213_18403_18443(this, symbol);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 18265, 18478);

                    int
                    f_213_18403_18443(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol)
                    {
                        this_param.MarkDeclarationsProcessed_NoLock(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 18403, 18443);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 18265, 18478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 18265, 18478);
                }
            }

            public bool TryStartSyntaxAnalysis(SourceOrAdditionalFile tree, [NotNullWhen(returnValue: true)] out AnalyzerStateData? state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 18494, 18865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18659, 18664);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18706, 18755);

                        f_213_18706_18754(_lazyFilesWithAnalysisData != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18777, 18831);

                        return f_213_18784_18830(this, tree, out state);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 18494, 18865);

                    int
                    f_213_18706_18754(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 18706, 18754);
                        return 0;
                    }


                    bool
                    f_213_18784_18830(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                    file, out Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?
                    state)
                    {
                        var return_v = this_param.TryStartSyntaxAnalysis_NoLock(file, out state);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 18784, 18830);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 18494, 18865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 18494, 18865);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void MarkSyntaxAnalysisComplete(SourceOrAdditionalFile file)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 18881, 19108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 18987, 18992);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19034, 19074);

                        f_213_19034_19073(this, file);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 18881, 19108);

                    int
                    f_213_19034_19073(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
                    file)
                    {
                        this_param.MarkSyntaxAnalysisComplete_NoLock(file);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 19034, 19073);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 18881, 19108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 18881, 19108);
                }
            }

            public void OnCompilationEventGenerated(CompilationEvent compilationEvent, AnalyzerActionCounts actionCounts)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 19124, 21836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19272, 19277);
                    lock (_gate)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19319, 21738) || true) && (compilationEvent is SymbolDeclaredCompilationEvent symbolEvent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 19319, 21738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19435, 19461);

                            var
                            needsAnalysis = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19487, 19519);

                            var
                            symbol = f_213_19500_19518(symbolEvent)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19545, 19622);

                            var
                            skipSymbolAnalysis = f_213_19570_19621(symbolEvent)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19648, 19877) || true) && (!skipSymbolAnalysis && (DynAbs.Tracing.TraceSender.Expression_True(213, 19652, 19710) && f_213_19675_19706(actionCounts) > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 19648, 19877);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19768, 19789);

                                needsAnalysis = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19819, 19850);

                                _pendingSymbols[symbol] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 19648, 19877);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 19905, 19987);

                            var
                            skipDeclarationAnalysis = f_213_19935_19986(symbol)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20013, 20286) || true) && (!skipDeclarationAnalysis && (DynAbs.Tracing.TraceSender.Expression_True(213, 20017, 20114) && f_213_20074_20114(actionCounts)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 20013, 20286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20172, 20193);

                                needsAnalysis = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20223, 20259);

                                _pendingDeclarations[symbol] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 20013, 20286);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20314, 20702) || true) && (f_213_20318_20354(actionCounts) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(213, 20318, 20411) && (!skipSymbolAnalysis || (DynAbs.Tracing.TraceSender.Expression_False(213, 20363, 20410) || !skipDeclarationAnalysis))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 20314, 20702);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20469, 20490);

                                needsAnalysis = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20520, 20600);

                                _lazyPendingSymbolEndAnalyses ??= f_213_20554_20599();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20630, 20675);

                                _lazyPendingSymbolEndAnalyses[symbol] = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 20314, 20702);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20730, 20840) || true) && (!needsAnalysis)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 20730, 20840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20806, 20813);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 20730, 20840);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 19319, 21738);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 19319, 21738);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 20890, 21738) || true) && (compilationEvent is CompilationStartedEvent compilationStartedEvent)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 20890, 21738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21011, 21122);

                                var
                                fileCount = (DynAbs.Tracing.TraceSender.Conditional_F1(213, 21027, 21066) || ((f_213_21027_21062(actionCounts) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(213, 21069, 21117)) || DynAbs.Tracing.TraceSender.Conditional_F3(213, 21120, 21121))) ? f_213_21069_21117(f_213_21069_21109(f_213_21069_21097(compilationEvent))) : 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21148, 21258);

                                fileCount += (DynAbs.Tracing.TraceSender.Conditional_F1(213, 21161, 21204) || ((f_213_21161_21200(actionCounts) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(213, 21207, 21253)) || DynAbs.Tracing.TraceSender.Conditional_F3(213, 21256, 21257))) ? compilationStartedEvent.AdditionalFiles.Length : 0;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21284, 21550) || true) && (fileCount > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 21284, 21550);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21359, 21448);

                                    _lazyFilesWithAnalysisData = f_213_21388_21447();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21478, 21523);

                                    _pendingSyntaxAnalysisFilesCount = fileCount;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(213, 21284, 21550);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21578, 21715) || true) && (f_213_21582_21618(actionCounts) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 21578, 21715);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21681, 21688);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(213, 21578, 21715);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(213, 20890, 21738);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(213, 19319, 21738);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21762, 21802);

                        _pendingEvents[compilationEvent] = null;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 19124, 21836);

                    Microsoft.CodeAnalysis.ISymbol
                    f_213_19500_19518(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 19500, 19518);
                        return return_v;
                    }


                    bool
                    f_213_19570_19621(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    symbolEvent)
                    {
                        var return_v = AnalysisScope.ShouldSkipSymbolAnalysis(symbolEvent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 19570, 19621);
                        return return_v;
                    }


                    int
                    f_213_19675_19706(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.SymbolActionsCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 19675, 19706);
                        return return_v;
                    }


                    bool
                    f_213_19935_19986(Microsoft.CodeAnalysis.ISymbol
                    symbol)
                    {
                        var return_v = AnalysisScope.ShouldSkipDeclarationAnalysis(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 19935, 19986);
                        return return_v;
                    }


                    bool
                    f_213_20074_20114(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.HasAnyExecutableCodeActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 20074, 20114);
                        return return_v;
                    }


                    int
                    f_213_20318_20354(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.SymbolStartActionsCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 20318, 20354);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    f_213_20554_20599()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 20554, 20599);
                        return return_v;
                    }


                    int
                    f_213_21027_21062(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.SyntaxTreeActionsCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 21027, 21062);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Compilation
                    f_213_21069_21097(Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 21069, 21097);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    f_213_21069_21109(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.SyntaxTrees;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 21069, 21109);
                        return return_v;
                    }


                    int
                    f_213_21069_21117(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                    source)
                    {
                        var return_v = source.Count<Microsoft.CodeAnalysis.SyntaxTree>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 21069, 21117);
                        return return_v;
                    }


                    int
                    f_213_21161_21200(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.AdditionalFileActionsCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 21161, 21200);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    f_213_21388_21447()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 21388, 21447);
                        return return_v;
                    }


                    int
                    f_213_21582_21618(Microsoft.CodeAnalysis.Diagnostics.Telemetry.AnalyzerActionCounts
                    this_param)
                    {
                        var return_v = this_param.CompilationActionsCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 21582, 21618);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 19124, 21836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 19124, 21836);
                }
            }

            public bool IsEventAnalyzed(CompilationEvent compilationEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 21852, 22026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 21947, 22011);

                    return f_213_21954_22010(this, compilationEvent, _pendingEvents);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 21852, 22026);

                    bool
                    f_213_21954_22010(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.CompilationEvent
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities)
                    {
                        var return_v = this_param.IsEntityFullyProcessed<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 21954, 22010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 21852, 22026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 21852, 22026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool IsSymbolComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 22042, 22189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 22119, 22174);

                    return f_213_22126_22173(this, symbol, _pendingSymbols);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 22042, 22189);

                    bool
                    f_213_22126_22173(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities)
                    {
                        var return_v = this_param.IsEntityFullyProcessed<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 22126, 22173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 22042, 22189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 22042, 22189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool IsSymbolEndAnalysisComplete(ISymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 22205, 22447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 22293, 22345);

                    f_213_22293_22344(_lazyPendingSymbolEndAnalyses != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 22363, 22432);

                    return f_213_22370_22431(this, symbol, _lazyPendingSymbolEndAnalyses);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 22205, 22447);

                    int
                    f_213_22293_22344(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 22293, 22344);
                        return 0;
                    }


                    bool
                    f_213_22370_22431(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities)
                    {
                        var return_v = this_param.IsEntityFullyProcessed<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>(analysisEntity, pendingEntities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 22370, 22431);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 22205, 22447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 22205, 22447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool OnSymbolDeclaredEventProcessed(SymbolDeclaredCompilationEvent symbolDeclaredEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 22463, 22743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 22596, 22601);
                    lock (_gate)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 22643, 22709);

                        return f_213_22650_22708(this, symbolDeclaredEvent);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 22463, 22743);

                    bool
                    f_213_22650_22708(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    symbolDeclaredEvent)
                    {
                        var return_v = this_param.OnSymbolDeclaredEventProcessed_NoLock(symbolDeclaredEvent);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 22650, 22708);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 22463, 22743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 22463, 22743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool OnSymbolDeclaredEventProcessed_NoLock(SymbolDeclaredCompilationEvent symbolDeclaredEvent)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(213, 22759, 24120);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23034, 23187) || true) && (!f_213_23039_23113(f_213_23069_23095(symbolDeclaredEvent), _pendingSymbols))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 23034, 23187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23155, 23168);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 23034, 23187);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23298, 23490) || true) && (!f_213_23303_23416(this, f_213_23335_23361(symbolDeclaredEvent), symbolDeclaredEvent.DeclaringSyntaxReferences.Length))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 23298, 23490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23458, 23471);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 23298, 23490);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23577, 23785) || true) && (_lazyPendingSymbolEndAnalyses != null && (DynAbs.Tracing.TraceSender.Expression_True(213, 23581, 23711) && !f_213_23623_23711(f_213_23653_23679(symbolDeclaredEvent), _lazyPendingSymbolEndAnalyses)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(213, 23577, 23785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23753, 23766);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(213, 23577, 23785);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 23865, 23926);

                    f_213_23865_23925(this, f_213_23898_23924(symbolDeclaredEvent));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(213, 24010, 24105);

                    return f_213_24017_24104(symbolDeclaredEvent, _pendingEvents, _analyzerStateDataPool);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(213, 22759, 24120);

                    Microsoft.CodeAnalysis.ISymbol
                    f_213_23069_23095(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 23069, 23095);
                        return return_v;
                    }


                    bool
                    f_213_23039_23113(Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities)
                    {
                        var return_v = IsEntityFullyProcessed_NoLock(analysisEntity, pendingEntities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 23039, 23113);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_213_23335_23361(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 23335, 23361);
                        return return_v;
                    }


                    bool
                    f_213_23303_23416(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol, int
                    declarationsCount)
                    {
                        var return_v = this_param.AreDeclarationsProcessed_NoLock(symbol, declarationsCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 23303, 23416);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_213_23653_23679(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 23653, 23679);
                        return return_v;
                    }


                    bool
                    f_213_23623_23711(Microsoft.CodeAnalysis.ISymbol
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities)
                    {
                        var return_v = IsEntityFullyProcessed_NoLock(analysisEntity, pendingEntities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 23623, 23711);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_213_23898_23924(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(213, 23898, 23924);
                        return return_v;
                    }


                    int
                    f_213_23865_23925(Microsoft.CodeAnalysis.Diagnostics.AnalysisState.PerAnalyzerState
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    symbol)
                    {
                        this_param.MarkDeclarationsProcessed_NoLock(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 23865, 23925);
                        return 0;
                    }


                    bool
                    f_213_24017_24104(Microsoft.CodeAnalysis.Diagnostics.SymbolDeclaredCompilationEvent
                    analysisEntity, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
                    pendingEntities, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData>
                    pool)
                    {
                        var return_v = MarkEntityProcessed_NoLock((Microsoft.CodeAnalysis.Diagnostics.CompilationEvent)analysisEntity, pendingEntities, pool);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 24017, 24104);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(213, 22759, 24120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 22759, 24120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PerAnalyzerState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(213, 668, 24131);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(213, 668, 24131);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(213, 668, 24131);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(213, 668, 24131);

            static object
            f_213_1990_2002()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 1990, 2002);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
            f_213_2038_2092()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Diagnostics.CompilationEvent, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 2038, 2092);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>
            f_213_2129_2174()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.AnalyzerStateData?>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 2129, 2174);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>
            f_213_2216_2289()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Diagnostics.AnalysisState.DeclarationAnalyzerStateData>?>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(213, 2216, 2289);
                return return_v;
            }

        }
    }
}
