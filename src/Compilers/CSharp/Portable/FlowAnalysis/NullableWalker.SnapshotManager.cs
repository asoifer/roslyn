// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class NullableWalker
    {
        internal sealed class SnapshotManager
        {
            private readonly ImmutableArray<SharedWalkerState> _walkerSharedStates;

            private readonly ImmutableArray<(int position, Snapshot snapshot)> _incrementalSnapshots;

            private readonly ImmutableDictionary<(BoundNode?, Symbol), Symbol> _updatedSymbolsMap;

            private static readonly Func<(int position, Snapshot snapshot), int, int> BinarySearchComparer;

            private SnapshotManager(ImmutableArray<SharedWalkerState> walkerSharedStates, ImmutableArray<(int position, Snapshot snapshot)> incrementalSnapshots, ImmutableDictionary<(BoundNode?, Symbol), Symbol> updatedSymbolsMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10902, 1531, 2438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1327, 1345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1782, 1823);

                    _walkerSharedStates = walkerSharedStates;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1841, 1886);

                    _incrementalSnapshots = incrementalSnapshots;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1904, 1943);

                    _updatedSymbolsMap = updatedSymbolsMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1974, 2027);

                    f_10902_1974_2026(f_10902_1987_2025_M(!incrementalSnapshots.IsDefaultOrEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2045, 2101);

                    int
                    previousPosition = incrementalSnapshots[0].position
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2128, 2133);
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2119, 2415) || true) && (i < incrementalSnapshots.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2168, 2171)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 2119, 2415))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 2119, 2415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2213, 2268);

                            int
                            currentPosition = incrementalSnapshots[i].position
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2290, 2339);

                            f_10902_2290_2338(currentPosition > previousPosition);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2361, 2396);

                            previousPosition = currentPosition;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10902, 1, 297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10902, 1, 297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10902, 1531, 2438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 1531, 2438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 1531, 2438);
                }
            }

            internal (VariablesSnapshot, LocalStateSnapshot) GetSnapshot(int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 2454, 2818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2561, 2625);

                    Snapshot
                    incrementalSnapshot = f_10902_2592_2624(this, position)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2643, 2719);

                    var
                    sharedState = _walkerSharedStates[incrementalSnapshot.SharedStateIndex]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2737, 2803);

                    return (sharedState.Variables, incrementalSnapshot.VariableState);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 2454, 2818);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot
                    f_10902_2592_2624(Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                    this_param, int
                    position)
                    {
                        var return_v = this_param.GetSnapshotForPosition(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 2592, 2624);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 2454, 2818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 2454, 2818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal TypeWithAnnotations? GetUpdatedTypeForLocalSymbol(SourceLocalSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 2834, 3316);
                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations updatedType = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 2951, 3023);

                    var
                    snapshot = f_10902_2966_3022(this, symbol.IdentifierToken.SpanStart)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3041, 3106);

                    var
                    sharedState = _walkerSharedStates[snapshot.SharedStateIndex]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3124, 3269) || true) && (f_10902_3128_3189(sharedState.Variables, symbol, out updatedType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 3124, 3269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3231, 3250);

                        return updatedType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 3124, 3269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3289, 3301);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 2834, 3316);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot
                    f_10902_2966_3022(Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                    this_param, int
                    position)
                    {
                        var return_v = this_param.GetSnapshotForPosition(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 2966, 3022);
                        return return_v;
                    }


                    bool
                    f_10902_3128_3189(Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                    symbol, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type)
                    {
                        var return_v = this_param.TryGetType((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, out type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 3128, 3189);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 2834, 3316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 2834, 3316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal NamedTypeSymbol? GetUpdatedDelegateTypeForLambda(LambdaSymbol lambda)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 3332, 3666);
                    Microsoft.CodeAnalysis.CSharp.Symbol updatedDelegate = default(Microsoft.CodeAnalysis.CSharp.Symbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3443, 3619) || true) && (f_10902_3447_3518(_updatedSymbolsMap, (null, lambda), out updatedDelegate))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 3443, 3619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3560, 3600);

                        return (NamedTypeSymbol)updatedDelegate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 3443, 3619);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3639, 3651);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 3332, 3666);

                    bool
                    f_10902_3447_3518(System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, (Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol lambda)
                    key, out Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(((Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol))key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 3447, 3518);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 3332, 3666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 3332, 3666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool TryGetUpdatedSymbol(BoundNode node, Symbol symbol, [NotNullWhen(true)] out Symbol? updatedSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 3682, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 3826, 3899);

                    return f_10902_3833_3898(_updatedSymbolsMap, (node, symbol), out updatedSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 3682, 3914);

                    bool
                    f_10902_3833_3898(System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, (Microsoft.CodeAnalysis.CSharp.BoundNode node, Microsoft.CodeAnalysis.CSharp.Symbol symbol)
                    key, out Microsoft.CodeAnalysis.CSharp.Symbol?
                    value)
                    {
                        var return_v = this_param.TryGetValue(((Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol))key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 3833, 3898);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 3682, 3914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 3682, 3914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Snapshot GetSnapshotForPosition(int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 3930, 4633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4016, 4103);

                    var
                    snapshotIndex = _incrementalSnapshots.BinarySearch(position, BinarySearchComparer)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4123, 4545) || true) && (snapshotIndex < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 4123, 4545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4319, 4356);

                        snapshotIndex = (~snapshotIndex) - 1;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4485, 4526) || true) && (snapshotIndex < 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 4485, 4526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4508, 4526);

                            snapshotIndex = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 4485, 4526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 4123, 4545);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4565, 4618);

                    return _incrementalSnapshots[snapshotIndex].snapshot;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 3930, 4633);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 3930, 4633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 3930, 4633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void VerifyNode(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 4660, 5392);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4733, 4871) || true) && (f_10902_4737_4746(node) == BoundKind.TypeExpression || (DynAbs.Tracing.TraceSender.Expression_False(10902, 4737, 4803) || f_10902_4778_4803(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 4733, 4871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4845, 4852);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 4733, 4871);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4891, 4932);

                    int
                    nodePosition = f_10902_4910_4931(node.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 4950, 5036);

                    int
                    position = _incrementalSnapshots.BinarySearch(nodePosition, BinarySearchComparer)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5056, 5200) || true) && (position < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 5056, 5200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5114, 5181);

                        f_10902_5114_5180($"Did not find a snapshot for {node} `{node.Syntax}.`");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 5056, 5200);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5218, 5377);

                    f_10902_5218_5376(_walkerSharedStates.Length > _incrementalSnapshots[position].snapshot.SharedStateIndex, $"Did not find shared state for {node} `{node.Syntax}`.");
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 4660, 5392);

                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10902_4737_4746(Microsoft.CodeAnalysis.CSharp.BoundNode
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 4737, 4746);
                        return return_v;
                    }


                    bool
                    f_10902_4778_4803(Microsoft.CodeAnalysis.CSharp.BoundNode
                    this_param)
                    {
                        var return_v = this_param.WasCompilerGenerated;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 4778, 4803);
                        return return_v;
                    }


                    int
                    f_10902_4910_4931(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SpanStart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 4910, 4931);
                        return return_v;
                    }


                    int
                    f_10902_5114_5180(string
                    message)
                    {
                        Debug.Fail(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5114, 5180);
                        return 0;
                    }


                    int
                    f_10902_5218_5376(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5218, 5376);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 4660, 5392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 4660, 5392);
                }
            }

            internal void VerifyUpdatedSymbols()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 5408, 6396);
                    foreach (var ((expr, originalSymbol), updatedSymbol) in _updatedSymbolsMap)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5624, 5727);

                        var
                        debugText = ((DynAbs.Tracing.TraceSender.Conditional_F1(10902, 5641, 5653) || ((expr != null && DynAbs.Tracing.TraceSender.Conditional_F2(10902, 5656, 5682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10902, 5685, 5689))) ? f_10902_5656_5682(expr.Syntax) : null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10902, 5640, 5726) ?? f_10902_5694_5726(originalSymbol))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5749, 5850);

                        f_10902_5749_5849((object)originalSymbol != updatedSymbol, $"Recorded exact same symbol for {debugText}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5872, 5967);

                        f_10902_5872_5966(originalSymbol is object, $"Recorded null original symbol for {debugText}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 5989, 6082);

                        f_10902_5989_6081(updatedSymbol is object, $"Recorded null updated symbol for {debugText}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 6104, 6362);

                        f_10902_6104_6361(f_10902_6117_6162(originalSymbol, updatedSymbol), @$"Symbol for `{debugText}` changed:
Was {f_10902_6207_6279(originalSymbol, f_10902_6238_6278())}
Now {f_10902_6287_6358(updatedSymbol, f_10902_6317_6357())}");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 5408, 6396);

                    string
                    f_10902_5656_5682(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.ToFullString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5656, 5682);
                        return return_v;
                    }


                    string
                    f_10902_5694_5726(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ToDisplayString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5694, 5726);
                        return return_v;
                    }


                    int
                    f_10902_5749_5849(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5749, 5849);
                        return 0;
                    }


                    int
                    f_10902_5872_5966(bool
                    b, string
                    message)
                    {
                        RoslynDebug.Assert(b, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5872, 5966);
                        return 0;
                    }


                    int
                    f_10902_5989_6081(bool
                    b, string
                    message)
                    {
                        RoslynDebug.Assert(b, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 5989, 6081);
                        return 0;
                    }


                    bool
                    f_10902_6117_6162(Microsoft.CodeAnalysis.CSharp.Symbol
                    original, Microsoft.CodeAnalysis.CSharp.Symbol
                    updated)
                    {
                        var return_v = AreCloseEnough(original, updated);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 6117, 6162);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolDisplayFormat
                    f_10902_6238_6278()
                    {
                        var return_v = SymbolDisplayFormat.FullyQualifiedFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 6238, 6278);
                        return return_v;
                    }


                    string
                    f_10902_6207_6279(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 6207, 6279);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolDisplayFormat
                    f_10902_6317_6357()
                    {
                        var return_v = SymbolDisplayFormat.FullyQualifiedFormat;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 6317, 6357);
                        return return_v;
                    }


                    string
                    f_10902_6287_6358(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 6287, 6358);
                        return return_v;
                    }


                    int
                    f_10902_6104_6361(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 6104, 6361);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 5408, 6396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 5408, 6396);
                }
            }
            internal sealed class Builder
            {
                private readonly ImmutableDictionary<(BoundNode?, Symbol), Symbol>.Builder _updatedSymbolMap;

                private readonly ArrayBuilder<SharedWalkerState> _walkerStates;

                private readonly SortedDictionary<int, Snapshot> _incrementalSnapshots;

                private readonly PooledDictionary<Symbol, int> _symbolToSlot;

                private int _currentWalkerSlot;

                internal SnapshotManager ToManagerAndFree()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 8993, 9752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9077, 9179);

                        f_10902_9077_9178(_currentWalkerSlot == -1, "Attempting to finalize snapshots before all walks completed");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9201, 9258);

                        f_10902_9201_9257(f_10902_9214_9233(_symbolToSlot) == f_10902_9237_9256(_walkerStates));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9280, 9318);

                        f_10902_9280_9317(f_10902_9293_9312(_symbolToSlot) > 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9340, 9361);

                        f_10902_9340_9360(_symbolToSlot);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9383, 9539);

                        var
                        snapshotsArray = f_10902_9404_9538(_incrementalSnapshots, (kvp) => (kvp.Key, kvp.Value))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9563, 9616);

                        var
                        updatedSymbols = f_10902_9584_9615(_updatedSymbolMap)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9638, 9733);

                        return f_10902_9645_9732(f_10902_9665_9699(_walkerStates), snapshotsArray, updatedSymbols);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 8993, 9752);

                        int
                        f_10902_9077_9178(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9077, 9178);
                            return 0;
                        }


                        int
                        f_10902_9214_9233(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 9214, 9233);
                            return return_v;
                        }


                        int
                        f_10902_9237_9256(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 9237, 9256);
                            return return_v;
                        }


                        int
                        f_10902_9201_9257(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9201, 9257);
                            return 0;
                        }


                        int
                        f_10902_9293_9312(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 9293, 9312);
                            return return_v;
                        }


                        int
                        f_10902_9280_9317(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9280, 9317);
                            return 0;
                        }


                        int
                        f_10902_9340_9360(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9340, 9360);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<(int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot)>
                        f_10902_9404_9538(System.Collections.Generic.SortedDictionary<int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot>
                        source, System.Func<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot>, (int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot)>
                        selector)
                        {
                            var return_v = source.SelectAsArray<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot>, (int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot)>(selector);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9404, 9538);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10902_9584_9615(System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9584, 9615);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                        f_10902_9665_9699(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9665, 9699);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager
                        f_10902_9645_9732(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                        walkerSharedStates, System.Collections.Immutable.ImmutableArray<(int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot)>
                        incrementalSnapshots, System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>
                        updatedSymbolsMap)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.SnapshotManager(walkerSharedStates, incrementalSnapshots, updatedSymbolsMap);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9645, 9732);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 8993, 9752);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 8993, 9752);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal int EnterNewWalker(Symbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 9772, 10594);
                        int slot = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9855, 9892);

                        f_10902_9855_9891(symbol is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 9914, 9952);

                        var
                        previousSlot = _currentWalkerSlot
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10170, 10531) || true) && (f_10902_10174_10221(_symbolToSlot, symbol, out slot))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 10170, 10531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10271, 10297);

                            _currentWalkerSlot = slot;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 10170, 10531);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 10170, 10531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10395, 10436);

                            _currentWalkerSlot = f_10902_10416_10435(_symbolToSlot);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10462, 10508);

                            f_10902_10462_10507(_symbolToSlot, symbol, _currentWalkerSlot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 10170, 10531);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10555, 10575);

                        return previousSlot;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 9772, 10594);

                        int
                        f_10902_9855_9891(bool
                        b)
                        {
                            RoslynDebug.Assert(b);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 9855, 9891);
                            return 0;
                        }


                        bool
                        f_10902_10174_10221(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, out int
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 10174, 10221);
                            return return_v;
                        }


                        int
                        f_10902_10416_10435(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 10416, 10435);
                            return return_v;
                        }


                        int
                        f_10902_10462_10507(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, int
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 10462, 10507);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 9772, 10594);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 9772, 10594);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal void ExitWalker(SharedWalkerState stableState, int previousSlot)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 10614, 10858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10728, 10783);

                        f_10902_10728_10782(_walkerStates, _currentWalkerSlot, stableState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10805, 10839);

                        _currentWalkerSlot = previousSlot;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 10614, 10858);

                        int
                        f_10902_10728_10782(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                        this_param, int
                        index, Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState
                        value)
                        {
                            this_param.SetItem(index, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 10728, 10782);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 10614, 10858);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 10614, 10858);
                    }
                }

                internal void TakeIncrementalSnapshot(BoundNode? node, LocalState currentState)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 10878, 11454);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 10998, 11123) || true) && (node == null || (DynAbs.Tracing.TraceSender.Expression_False(10902, 11002, 11043) || f_10902_11018_11043(node)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 10998, 11123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 11093, 11100);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 10998, 11123);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 11324, 11435);

                        _incrementalSnapshots[f_10902_11346_11367(node.Syntax)] = f_10902_11371_11434(currentState.CreateSnapshot(), _currentWalkerSlot);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 10878, 11454);

                        bool
                        f_10902_11018_11043(Microsoft.CodeAnalysis.CSharp.BoundNode
                        this_param)
                        {
                            var return_v = this_param.WasCompilerGenerated;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 11018, 11043);
                            return return_v;
                        }


                        int
                        f_10902_11346_11367(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.SpanStart;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 11346, 11367);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot
                        f_10902_11371_11434(Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalStateSnapshot
                        variableState, int
                        sharedStateIndex)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot(variableState, sharedStateIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11371, 11434);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 10878, 11454);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 10878, 11454);
                    }
                }

                internal void SetUpdatedSymbol(BoundNode node, Symbol originalSymbol, Symbol updatedSymbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 11474, 11790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 11617, 11677);

                        f_10902_11617_11676(f_10902_11630_11675(originalSymbol, updatedSymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 11707, 11771);

                        _updatedSymbolMap[f_10902_11725_11753(node, originalSymbol)] = updatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 11474, 11790);

                        bool
                        f_10902_11630_11675(Microsoft.CodeAnalysis.CSharp.Symbol
                        original, Microsoft.CodeAnalysis.CSharp.Symbol
                        updated)
                        {
                            var return_v = AreCloseEnough(original, updated);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11630, 11675);
                            return return_v;
                        }


                        int
                        f_10902_11617_11676(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11617, 11676);
                            return 0;
                        }


                        (Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol)
                        f_10902_11725_11753(Microsoft.CodeAnalysis.CSharp.BoundNode
                        node, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = GetKey(node, symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11725, 11753);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 11474, 11790);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 11474, 11790);
                    }
                }

                internal void RemoveSymbolIfPresent(BoundNode node, Symbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10902, 11810, 11983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 11917, 11964);

                        f_10902_11917_11963(_updatedSymbolMap, f_10902_11942_11962(node, symbol));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10902, 11810, 11983);

                        (Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol)
                        f_10902_11942_11962(Microsoft.CodeAnalysis.CSharp.BoundNode
                        node, Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = GetKey(node, symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11942, 11962);
                            return return_v;
                        }


                        bool
                        f_10902_11917_11963(System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                        this_param, (Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol)
                        key)
                        {
                            var return_v = this_param.Remove(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 11917, 11963);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 11810, 11983);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 11810, 11983);
                    }
                }

                private static (BoundNode?, Symbol) GetKey(BoundNode node, Symbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10902, 12003, 12400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 12117, 12381) || true) && (node is BoundLambda && (DynAbs.Tracing.TraceSender.Expression_True(10902, 12121, 12166) && symbol is LambdaSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 12117, 12381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 12216, 12238);

                            return (null, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 12117, 12381);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10902, 12117, 12381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 12336, 12358);

                            return (node, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10902, 12117, 12381);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10902, 12003, 12400);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 12003, 12400);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 12003, 12400);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public Builder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10902, 6420, 12415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 7253, 7433);
                    this._updatedSymbolMap = f_10902_7273_7433(ExpressionAndSymbolEqualityComparer.Instance, Symbols.SymbolEqualityComparer.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 7996, 8057);
                    this._walkerStates = f_10902_8012_8057(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 8324, 8385);
                    this._incrementalSnapshots = f_10902_8348_8385(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 8859, 8918);
                    this._symbolToSlot = f_10902_8875_8918(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 8949, 8972);
                    this._currentWalkerSlot = -1; DynAbs.Tracing.TraceSender.TraceExitConstructor(10902, 6420, 12415);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 6420, 12415);
                }


                static Builder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10902, 6420, 12415);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10902, 6420, 12415);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 6420, 12415);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10902, 6420, 12415);

                System.Collections.Immutable.ImmutableDictionary<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol), Microsoft.CodeAnalysis.CSharp.Symbol>.Builder
                f_10902_7273_7433(Microsoft.CodeAnalysis.CSharp.NullableWalker.ExpressionAndSymbolEqualityComparer
                keyComparer, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                valueComparer)
                {
                    var return_v = ImmutableDictionary.CreateBuilder<(BoundNode?, Symbol), Symbol>((System.Collections.Generic.IEqualityComparer<(Microsoft.CodeAnalysis.CSharp.BoundNode?, Microsoft.CodeAnalysis.CSharp.Symbol)>)keyComparer, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)valueComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 7273, 7433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.NullableWalker.SharedWalkerState>
                f_10902_8012_8057()
                {
                    var return_v = ArrayBuilder<SharedWalkerState>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 8012, 8057);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot>
                f_10902_8348_8385()
                {
                    var return_v = new System.Collections.Generic.SortedDictionary<int, Microsoft.CodeAnalysis.CSharp.NullableWalker.Snapshot>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 8348, 8385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, int>
                f_10902_8875_8918()
                {
                    var return_v = PooledDictionary<Symbol, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 8875, 8918);
                    return return_v;
                }

            }

            static SnapshotManager()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10902, 628, 12426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 1436, 1514);
                BinarySearchComparer = (current, target) => current.position.CompareTo(target); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10902, 628, 12426);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 628, 12426);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10902, 628, 12426);

            bool
            f_10902_1987_2025_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10902, 1987, 2025);
                return return_v;
            }


            int
            f_10902_1974_2026(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 1974, 2026);
                return 0;
            }


            int
            f_10902_2290_2338(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10902, 2290, 2338);
                return 0;
            }

        }

        internal struct SharedWalkerState
        {

            internal readonly VariablesSnapshot Variables;

            internal SharedWalkerState(VariablesSnapshot variables)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10902, 12691, 12816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 12779, 12801);

                    Variables = variables;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10902, 12691, 12816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 12691, 12816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 12691, 12816);
                }
            }
            static SharedWalkerState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10902, 12571, 12827);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10902, 12571, 12827);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 12571, 12827);
            }
        }

        private readonly struct Snapshot
        {

            internal readonly LocalStateSnapshot VariableState;

            internal readonly int SharedStateIndex;

            internal Snapshot(LocalStateSnapshot variableState, int sharedStateIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10902, 13314, 13519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 13420, 13450);

                    VariableState = variableState;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10902, 13468, 13504);

                    SharedStateIndex = sharedStateIndex;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10902, 13314, 13519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10902, 13314, 13519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 13314, 13519);
                }
            }
            static Snapshot()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10902, 13137, 13530);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10902, 13137, 13530);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10902, 13137, 13530);
            }
        }
    }
}
