// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class NullableWalker
    {
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal sealed class VariablesSnapshot
        {
            internal readonly int Id;

            internal readonly VariablesSnapshot? Container;

            internal readonly Symbol? Symbol;

            internal readonly ImmutableArray<KeyValuePair<VariableIdentifier, int>> VariableSlot;

            internal readonly ImmutableDictionary<Symbol, TypeWithAnnotations> VariableTypes;

            internal VariablesSnapshot(int id, VariablesSnapshot? container, Symbol? symbol, ImmutableArray<KeyValuePair<VariableIdentifier, int>> variableSlot, ImmutableDictionary<Symbol, TypeWithAnnotations> variableTypes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10903, 2079, 2515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 1011, 1013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 1230, 1239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 1633, 1639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2049, 2062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2324, 2332);

                    Id = id;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2350, 2372);

                    Container = container;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2390, 2406);

                    Symbol = symbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2424, 2452);

                    VariableSlot = variableSlot;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2470, 2500);

                    VariableTypes = variableTypes;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10903, 2079, 2515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 2079, 2515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 2079, 2515);
                }
            }

            internal bool TryGetType(Symbol symbol, out TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 2531, 2699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2633, 2684);

                    return f_10903_2640_2683(VariableTypes, symbol, out type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 2531, 2699);

                    bool
                    f_10903_2640_2683(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 2640, 2683);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 2531, 2699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 2531, 2699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 2715, 2921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2783, 2824);

                    var
                    symbol = (object?)Symbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10903, 2796, 2823) ?? "<null>")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 2842, 2906);

                    return $"Id={Id}, Symbol={symbol}, Count={VariableSlot.Length}";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 2715, 2921);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 2715, 2921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 2715, 2921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static VariablesSnapshot()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10903, 623, 2932);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10903, 623, 2932);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 623, 2932);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10903, 623, 2932);
        }
        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        internal sealed class Variables
        {
            private const int
            MaxSlotDepth = 5
            ;

            private const int
            IdOffset = 16
            ;

            private const int
            IdMask = (1 << 15) - 1
            ;

            private const int
            IndexMask = (1 << 16) - 1
            ;

            private readonly Random _nextIdOffset;

            internal readonly int Id;

            internal readonly Variables? Container;

            internal readonly Symbol? Symbol;

            private readonly PooledDictionary<VariableIdentifier, int> _variableSlot;

            private readonly PooledDictionary<Symbol, TypeWithAnnotations> _variableTypes;

            private readonly ArrayBuilder<VariableIdentifier> _variableBySlot;

            internal static Variables Create(Symbol? symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10903, 7065, 7214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7146, 7199);

                    return f_10903_7153_7198(id: 0, container: null, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10903, 7065, 7214);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_7153_7198(int
                    id, Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    container, Microsoft.CodeAnalysis.CSharp.Symbol?
                    symbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables(id: id, container: container, symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7153, 7198);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 7065, 7214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 7065, 7214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static Variables Create(VariablesSnapshot snapshot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10903, 7230, 7588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7323, 7402);

                    var
                    container = (DynAbs.Tracing.TraceSender.Conditional_F1(10903, 7339, 7365) || ((snapshot.Container is null && DynAbs.Tracing.TraceSender.Conditional_F2(10903, 7368, 7372)) || DynAbs.Tracing.TraceSender.Conditional_F3(10903, 7375, 7401))) ? null : f_10903_7375_7401(snapshot.Container)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7420, 7491);

                    var
                    variables = f_10903_7436_7490(snapshot.Id, container, snapshot.Symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7509, 7538);

                    f_10903_7509_7537(variables, snapshot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7556, 7573);

                    return variables;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10903, 7230, 7588);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_7375_7401(Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot
                    snapshot)
                    {
                        var return_v = Create(snapshot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7375, 7401);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_7436_7490(int
                    id, Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    container, Microsoft.CodeAnalysis.CSharp.Symbol?
                    symbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables(id, container, symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7436, 7490);
                        return return_v;
                    }


                    int
                    f_10903_7509_7537(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot
                    snapshot)
                    {
                        this_param.Populate(snapshot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7509, 7537);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 7230, 7588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 7230, 7588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int GetNextId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 7604, 7784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7660, 7769);

                    return Id +
                    f_10903_7704_7735(_nextIdOffset, maxValue: 7) +
                                        1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 7604, 7784);

                    int
                    f_10903_7704_7735(System.Random
                    this_param, int
                    maxValue)
                    {
                        var return_v = this_param.Next(maxValue: maxValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7704, 7735);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 7604, 7784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 7604, 7784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void Populate(VariablesSnapshot snapshot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 7800, 8610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7882, 7921);

                    f_10903_7882_7920(f_10903_7895_7914(_variableSlot) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7939, 7979);

                    f_10903_7939_7978(f_10903_7952_7972(_variableTypes) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 7997, 8038);

                    f_10903_7997_8037(f_10903_8010_8031(_variableBySlot) == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8058, 8121);

                    f_10903_8058_8120(
                                    _variableBySlot, default, snapshot.VariableSlot.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8139, 8430);
                        foreach (var pair in f_10903_8160_8181_I(snapshot.VariableSlot))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 8139, 8430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8223, 8249);

                            var
                            identifier = pair.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8271, 8294);

                            var
                            index = pair.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8316, 8353);

                            f_10903_8316_8352(_variableSlot, identifier, index);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8375, 8411);

                            _variableBySlot[index] = identifier;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 8139, 8430);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 1, 292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 1, 292);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8450, 8595);
                        foreach (var pair in f_10903_8471_8493_I(snapshot.VariableTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 8450, 8595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8535, 8576);

                            f_10903_8535_8575(_variableTypes, pair.Key, pair.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 8450, 8595);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 1, 146);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 1, 146);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 7800, 8610);

                    int
                    f_10903_7895_7914(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 7895, 7914);
                        return return_v;
                    }


                    int
                    f_10903_7882_7920(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7882, 7920);
                        return 0;
                    }


                    int
                    f_10903_7952_7972(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 7952, 7972);
                        return return_v;
                    }


                    int
                    f_10903_7939_7978(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7939, 7978);
                        return 0;
                    }


                    int
                    f_10903_8010_8031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 8010, 8031);
                        return return_v;
                    }


                    int
                    f_10903_7997_8037(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 7997, 8037);
                        return 0;
                    }


                    int
                    f_10903_8058_8120(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    item, int
                    count)
                    {
                        this_param.AddMany(item, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8058, 8120);
                        return 0;
                    }


                    int
                    f_10903_8316_8352(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8316, 8352);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>>
                    f_10903_8160_8181_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8160, 8181);
                        return return_v;
                    }


                    int
                    f_10903_8535_8575(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8535, 8575);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10903_8471_8493_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8471, 8493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 7800, 8610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 7800, 8610);
                }
            }

            private Variables(int id, Variables? container, Symbol? symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10903, 8626, 9069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 4785, 4798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 5082, 5084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 5285, 5294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 5688, 5694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 5932, 6003);
                    this._variableSlot = f_10903_5948_6003(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 6231, 6341);
                    this._variableTypes = f_10903_6248_6341(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 6974, 7048);
                    this._variableBySlot = f_10903_6992_7048(1, default); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8722, 8744);

                    f_10903_8722_8743(id >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8762, 8789);

                    f_10903_8762_8788(id <= IdMask);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8807, 8860);

                    f_10903_8807_8859(container is null || (DynAbs.Tracing.TraceSender.Expression_False(10903, 8820, 8858) || container.Id < id));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8889, 8946);

                    _nextIdOffset = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(container, 10903, 8905, 8929)?._nextIdOffset ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Random?>(10903, 8905, 8945) ?? f_10903_8933_8945());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8972, 8980);

                    Id = id;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 8998, 9020);

                    Container = container;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9038, 9054);

                    Symbol = symbol;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10903, 8626, 9069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 8626, 9069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 8626, 9069);
                }
            }

            internal void Free()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 9085, 9291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9138, 9156);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Container, 10903, 9138, 9155)?.Free(), 10903, 9148, 9155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9174, 9197);

                    f_10903_9174_9196(_variableBySlot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9215, 9237);

                    f_10903_9215_9236(_variableTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9255, 9276);

                    f_10903_9255_9275(_variableSlot);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 9085, 9291);

                    int
                    f_10903_9174_9196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9174, 9196);
                        return 0;
                    }


                    int
                    f_10903_9215_9236(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9215, 9236);
                        return 0;
                    }


                    int
                    f_10903_9255_9275(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9255, 9275);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 9085, 9291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 9085, 9291);
                }
            }

            internal VariablesSnapshot CreateSnapshot()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 9307, 9666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9383, 9651);

                    return f_10903_9390_9650(Id, f_10903_9459_9486_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Container, 10903, 9459, 9486)?.CreateSnapshot()), Symbol, f_10903_9538_9579(_variableSlot), f_10903_9602_9649(_variableTypes));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 9307, 9666);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot?
                    f_10903_9459_9486_I(Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9459, 9486);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>>
                    f_10903_9538_9579(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    items)
                    {
                        var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9538, 9579);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10903_9602_9649(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    items)
                    {
                        var return_v = ImmutableDictionary.CreateRange((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9602, 9649);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot
                    f_10903_9390_9650(int
                    id, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot?
                    container, Microsoft.CodeAnalysis.CSharp.Symbol?
                    symbol, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>>
                    variableSlot, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    variableTypes)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.VariablesSnapshot(id, container, symbol, variableSlot, variableTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9390, 9650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 9307, 9666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 9307, 9666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Variables CreateNestedMethodScope(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 9682, 10144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9778, 9835);

                    f_10903_9778_9834(f_10903_9791_9825(this, method) is null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 9853, 10057);

                    f_10903_9853_10056(!(f_10903_9868_9891(method) is MethodSymbol containingMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10903, 9866, 10013) || ((object?)f_10903_9960_10004(this, containingMethod) == this)) || (DynAbs.Tracing.TraceSender.Expression_False(10903, 9866, 10055) || Container is null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10077, 10129);

                    return f_10903_10084_10128(id: f_10903_10102_10113(this), this, method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 9682, 10144);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    f_10903_9791_9825(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.GetVariablesForMethodScope(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9791, 9825);
                        return return_v;
                    }


                    int
                    f_10903_9778_9834(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9778, 9834);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10903_9868_9891(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 9868, 9891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    f_10903_9960_10004(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.GetVariablesForMethodScope(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9960, 10004);
                        return return_v;
                    }


                    int
                    f_10903_9853_10056(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 9853, 10056);
                        return 0;
                    }


                    int
                    f_10903_10102_10113(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param)
                    {
                        var return_v = this_param.GetNextId();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 10102, 10113);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_10084_10128(int
                    id, Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    symbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables(id: id, container, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 10084, 10128);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 9682, 10144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 9682, 10144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal int RootSlot(int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 10160, 10608);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10224, 10593) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 10224, 10593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10277, 10324);

                            int
                            containingSlot = this[slot].ContainingSlot
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10346, 10574) || true) && (containingSlot == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 10346, 10574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10419, 10431);

                                return slot;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 10346, 10574);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 10346, 10574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10529, 10551);

                                slot = containingSlot;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 10346, 10574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 10224, 10593);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 10224, 10593);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 10224, 10593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 10160, 10608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 10160, 10608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 10160, 10608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool TryGetValue(VariableIdentifier identifier, out int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 10624, 10871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10727, 10779);

                    var
                    variables = f_10903_10743_10778(this, identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10797, 10856);

                    return f_10903_10804_10855(variables, identifier, out slot);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 10624, 10871);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_10743_10778(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    identifier)
                    {
                        var return_v = this_param.GetVariablesForVariable(identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 10743, 10778);
                        return return_v;
                    }


                    bool
                    f_10903_10804_10855(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    identifier, out int
                    slot)
                    {
                        var return_v = this_param.TryGetValueInternal(identifier, out slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 10804, 10855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 10624, 10871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 10624, 10871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool TryGetValueInternal(VariableIdentifier identifier, out int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 10887, 11254);
                    int index = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 10997, 11180) || true) && (f_10903_11001_11053(_variableSlot, identifier, out index))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 10997, 11180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11095, 11127);

                        slot = f_10903_11102_11126(Id, index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11149, 11161);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 10997, 11180);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11198, 11208);

                    slot = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11226, 11239);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 10887, 11254);

                    bool
                    f_10903_11001_11053(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    key, out int
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11001, 11053);
                        return return_v;
                    }


                    int
                    f_10903_11102_11126(int
                    id, int
                    index)
                    {
                        var return_v = ConstructSlot(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11102, 11126);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 10887, 11254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 10887, 11254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal int Add(VariableIdentifier identifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 11270, 11784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11350, 11402);

                    var
                    variables = f_10903_11366_11401(this, identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11420, 11465);

                    int
                    slot = f_10903_11431_11464(variables, identifier)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11562, 11739);

                    f_10903_11562_11738(slot <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(10903, 11575, 11639) || identifier.ContainingSlot <= 0) || (DynAbs.Tracing.TraceSender.Expression_False(10903, 11575, 11737) || f_10903_11664_11685(slot).Id == f_10903_11692_11734(identifier.ContainingSlot).Id));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11757, 11769);

                    return slot;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 11270, 11784);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_11366_11401(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    identifier)
                    {
                        var return_v = this_param.GetVariablesForVariable(identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11366, 11401);
                        return return_v;
                    }


                    int
                    f_10903_11431_11464(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    identifier)
                    {
                        var return_v = this_param.AddInternal(identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11431, 11464);
                        return return_v;
                    }


                    (int Id, int Index)
                    f_10903_11664_11685(int
                    slot)
                    {
                        var return_v = DeconstructSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11664, 11685);
                        return return_v;
                    }


                    (int Id, int Index)
                    f_10903_11692_11734(int
                    slot)
                    {
                        var return_v = DeconstructSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11692, 11734);
                        return return_v;
                    }


                    int
                    f_10903_11562_11738(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11562, 11738);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 11270, 11784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 11270, 11784);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int AddInternal(VariableIdentifier identifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 11800, 12805);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11887, 12017) || true) && (f_10903_11891_11930(identifier.ContainingSlot) >= MaxSlotDepth)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 11887, 12017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 11988, 11998);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 11887, 12017);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12035, 12066);

                    int
                    index = f_10903_12047_12065()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12084, 12176) || true) && (index > IndexMask)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 12084, 12176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12147, 12157);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 12084, 12176);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12194, 12231);

                    f_10903_12194_12230(_variableSlot, identifier, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12249, 12281);

                    f_10903_12249_12280(_variableBySlot, identifier);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12299, 12331);

                    return f_10903_12306_12330(Id, index);

                    int getSlotDepth(int slot)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 12351, 12790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12418, 12432);

                            int
                            depth = 0
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12454, 12736) || true) && (slot > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 12454, 12736);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12519, 12527);

                                    depth++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12553, 12593);

                                    var (id, index) = f_10903_12571_12592(slot);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12619, 12642);

                                    f_10903_12619_12641(id == Id);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12668, 12713);

                                    slot = _variableBySlot[index].ContainingSlot;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 12454, 12736);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 12454, 12736);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 12454, 12736);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12758, 12771);

                            return depth;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 12351, 12790);

                            (int Id, int Index)
                            f_10903_12571_12592(int
                            slot)
                            {
                                var return_v = DeconstructSlot(slot);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12571, 12592);
                                return return_v;
                            }


                            int
                            f_10903_12619_12641(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12619, 12641);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 12351, 12790);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 12351, 12790);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 11800, 12805);

                    int
                    f_10903_11891_11930(int
                    slot)
                    {
                        var return_v = getSlotDepth(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 11891, 11930);
                        return return_v;
                    }


                    int
                    f_10903_12047_12065()
                    {
                        var return_v = NextAvailableIndex;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 12047, 12065);
                        return return_v;
                    }


                    int
                    f_10903_12194_12230(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12194, 12230);
                        return 0;
                    }


                    int
                    f_10903_12249_12280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12249, 12280);
                        return 0;
                    }


                    int
                    f_10903_12306_12330(int
                    id, int
                    index)
                    {
                        var return_v = ConstructSlot(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12306, 12330);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 11800, 12805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 11800, 12805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool TryGetType(Symbol symbol, out TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 12821, 13071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12923, 12976);

                    var
                    variables = f_10903_12939_12975(this, symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 12994, 13056);

                    return f_10903_13001_13055(variables._variableTypes, symbol, out type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 12821, 13071);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_12939_12975(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.GetVariablesContainingSymbol(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 12939, 12975);
                        return return_v;
                    }


                    bool
                    f_10903_13001_13055(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13001, 13055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 12821, 13071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 12821, 13071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void SetType(Symbol symbol, TypeWithAnnotations type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 13087, 13366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13182, 13235);

                    var
                    variables = f_10903_13198_13234(this, symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13253, 13293);

                    f_10903_13253_13292((object)variables == this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13311, 13351);

                    variables._variableTypes[symbol] = type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 13087, 13366);

                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_13198_13234(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.GetVariablesContainingSymbol(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13198, 13234);
                        return return_v;
                    }


                    int
                    f_10903_13253_13292(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13253, 13292);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 13087, 13366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 13087, 13366);
                }
            }

            internal VariableIdentifier this[int slot]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 13457, 13687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13501, 13545);

                        (int id, int index) = f_10903_13523_13544(slot);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13567, 13605);

                        var
                        variables = f_10903_13583_13604(this, id)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13627, 13668);

                        return f_10903_13634_13667(variables!._variableBySlot, index);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 13457, 13687);

                        (int Id, int Index)
                        f_10903_13523_13544(int
                        slot)
                        {
                            var return_v = DeconstructSlot(slot);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13523, 13544);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                        f_10903_13583_13604(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                        this_param, int
                        id)
                        {
                            var return_v = this_param.GetVariablesForId(id);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13583, 13604);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                        f_10903_13634_13667(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 13634, 13667);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 13457, 13687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 13457, 13687);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal int NextAvailableIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 13750, 13774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13753, 13774);
                        return f_10903_13753_13774(_variableBySlot); DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 13750, 13774);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 13750, 13774);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 13750, 13774);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal int GetTotalVariableCount()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 13791, 13996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13860, 13920);

                    int
                    fromContainer = f_10903_13880_13914_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Container, 10903, 13880, 13914)?.GetTotalVariableCount()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10903, 13880, 13919) ?? 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 13938, 13981);

                    return fromContainer + f_10903_13961_13980(_variableSlot);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 13791, 13996);

                    int?
                    f_10903_13880_13914_I(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 13880, 13914);
                        return return_v;
                    }


                    int
                    f_10903_13961_13980(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 13961, 13980);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 13791, 13996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 13791, 13996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void GetMembers(ArrayBuilder<(VariableIdentifier, int)> builder, int containingSlot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 14012, 14686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14138, 14192);

                    (int id, int index) = f_10903_14160_14191(containingSlot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14210, 14249);

                    var
                    variables = f_10903_14226_14247(this, id)!
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14267, 14314);

                    var
                    variableBySlot = variables._variableBySlot
                    ;
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14337, 14344)
   , index++; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14332, 14671) || true) && (index < f_10903_14354_14374(variableBySlot))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14376, 14383)
   , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 14332, 14671))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 14332, 14671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14425, 14462);

                            var
                            variable = f_10903_14440_14461(variableBySlot, index)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14484, 14652) || true) && (variable.ContainingSlot == containingSlot)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 14484, 14652);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14579, 14629);

                                f_10903_14579_14628(builder, (variable, f_10903_14602_14626(id, index)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 14484, 14652);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 1, 340);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 1, 340);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 14012, 14686);

                    (int Id, int Index)
                    f_10903_14160_14191(int
                    slot)
                    {
                        var return_v = DeconstructSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14160, 14191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    f_10903_14226_14247(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, int
                    id)
                    {
                        var return_v = this_param.GetVariablesForId(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14226, 14247);
                        return return_v;
                    }


                    int
                    f_10903_14354_14374(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 14354, 14374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
                    f_10903_14440_14461(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 14440, 14461);
                        return return_v;
                    }


                    int
                    f_10903_14602_14626(int
                    id, int
                    index)
                    {
                        var return_v = ConstructSlot(id, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14602, 14626);
                        return return_v;
                    }


                    int
                    f_10903_14579_14628(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int)>
                    this_param, (Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier variable, int)
                    item)
                    {
                        this_param.Add(((Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int))item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14579, 14628);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 14012, 14686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 14012, 14686);
                }
            }

            private Variables GetVariablesForVariable(VariableIdentifier identifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 14702, 15105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14807, 14854);

                    int
                    containingSlot = identifier.ContainingSlot
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14872, 15017) || true) && (containingSlot > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 14872, 15017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 14936, 14998);

                        return f_10903_14943_14996(this, f_10903_14961_14992(containingSlot).Id)!;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 14872, 15017);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 15035, 15090);

                    return f_10903_15042_15089(this, identifier.Symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 14702, 15105);

                    (int Id, int Index)
                    f_10903_14961_14992(int
                    slot)
                    {
                        var return_v = DeconstructSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14961, 14992);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    f_10903_14943_14996(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, int
                    id)
                    {
                        var return_v = this_param.GetVariablesForId(id);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 14943, 14996);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_15042_15089(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.GetVariablesContainingSymbol(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 15042, 15089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 14702, 15105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 14702, 15105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Variables GetVariablesContainingSymbol(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 15121, 16040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 15215, 15644);

                    switch (symbol)
                    {

                        case LocalSymbol:
                        case ParameterSymbol:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 15215, 15644);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 15357, 15593) || true) && (f_10903_15361_15384(symbol) is MethodSymbol method && (DynAbs.Tracing.TraceSender.Expression_True(10903, 15361, 15491) && f_10903_15440_15474(this, method) is { } variables))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 15357, 15593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 15549, 15566);

                                return variables;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 15357, 15593);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10903, 15619, 15625);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 15215, 15644);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16003, 16025);

                    return f_10903_16010_16024(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 15121, 16040);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10903_15361_15384(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 15361, 15384);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables?
                    f_10903_15440_15474(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.GetVariablesForMethodScope(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 15440, 15474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    f_10903_16010_16024(Microsoft.CodeAnalysis.CSharp.NullableWalker.Variables
                    this_param)
                    {
                        var return_v = this_param.GetRootScope();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 16010, 16024);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 15121, 16040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 15121, 16040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Variables GetRootScope()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 16056, 16337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16122, 16143);

                    var
                    variables = this
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16161, 16287) || true) && (variables.Container is { } container)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 16161, 16287);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16246, 16268);

                            variables = container;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 16161, 16287);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 16161, 16287);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 16161, 16287);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16305, 16322);

                    return variables;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 16056, 16337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 16056, 16337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 16056, 16337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Variables? GetVariablesForId(int id)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 16353, 16785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16430, 16451);

                    var
                    variables = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 16469, 16740);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16512, 16624) || true) && (variables.Id == id)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 16512, 16624);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16584, 16601);

                                    return variables;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 16512, 16624);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16646, 16678);

                                variables = variables.Container;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 16469, 16740);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16469, 16740) || true) && (variables is { })
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 16469, 16740);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 16469, 16740);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16758, 16770);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 16353, 16785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 16353, 16785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 16353, 16785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Variables? GetVariablesForMethodScope(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 16801, 17407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16901, 16953);

                    method = f_10903_16910_16942(method) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10903, 16910, 16952) ?? method);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 16971, 16992);

                    var
                    variables = this
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17010, 17392) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 17010, 17392);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17063, 17191) || true) && ((object)method == variables.Symbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 17063, 17191);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17151, 17168);

                                return variables;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 17063, 17191);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17213, 17245);

                            variables = variables.Container;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17267, 17373) || true) && (variables is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10903, 17267, 17373);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17338, 17350);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 17267, 17373);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10903, 17010, 17392);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10903, 17010, 17392);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10903, 17010, 17392);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 16801, 17407);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10903_16910_16942(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.PartialImplementationPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 16910, 16942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 16801, 17407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 16801, 17407);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static int ConstructSlot(int id, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10903, 17423, 17756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17508, 17530);

                    f_10903_17508_17529(id >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17548, 17575);

                    f_10903_17548_17574(id <= IdMask);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17593, 17618);

                    f_10903_17593_17617(index >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17636, 17669);

                    f_10903_17636_17668(index <= IndexMask);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17689, 17741);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10903, 17696, 17705) || ((index < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10903, 17708, 17713)) || DynAbs.Tracing.TraceSender.Conditional_F3(10903, 17716, 17740))) ? index : (id << IdOffset) | index;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10903, 17423, 17756);

                    int
                    f_10903_17508_17529(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 17508, 17529);
                        return 0;
                    }


                    int
                    f_10903_17548_17574(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 17548, 17574);
                        return 0;
                    }


                    int
                    f_10903_17593_17617(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 17593, 17617);
                        return 0;
                    }


                    int
                    f_10903_17636_17668(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 17636, 17668);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 17423, 17756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 17423, 17756);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal static (int Id, int Index) DeconstructSlot(int slot)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10903, 17772, 17999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17866, 17890);

                    f_10903_17866_17889(slot > -1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 17908, 17984);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10903, 17915, 17923) || ((slot < 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10903, 17926, 17935)) || DynAbs.Tracing.TraceSender.Conditional_F3(10903, 17938, 17983))) ? (0, slot) : (slot >> IdOffset & IdMask, slot & IndexMask);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10903, 17772, 17999);

                    int
                    f_10903_17866_17889(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 17866, 17889);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 17772, 17999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 17772, 17999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10903, 18015, 18221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 18083, 18124);

                    var
                    symbol = (object?)Symbol ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10903, 18096, 18123) ?? "<null>")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 18142, 18206);

                    return $"Id={Id}, Symbol={symbol}, Count={f_10903_18184_18203(_variableSlot)}";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10903, 18015, 18221);

                    int
                    f_10903_18184_18203(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 18184, 18203);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10903, 18015, 18221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 18015, 18221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Variables()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10903, 3686, 18232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 3998, 4014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 4416, 4429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 4462, 4484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10903, 4517, 4542);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10903, 3686, 18232);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10903, 3686, 18232);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10903, 3686, 18232);

            Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier, int>
            f_10903_5948_6003()
            {
                var return_v = PooledDictionary<VariableIdentifier, int>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 5948, 6003);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            f_10903_6248_6341()
            {
                var return_v = SpecializedSymbolCollections.GetPooledSymbolDictionaryInstance<Symbol, TypeWithAnnotations>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 6248, 6341);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
            f_10903_6992_7048(int
            capacity, Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier
            fillWithValue)
            {
                var return_v = ArrayBuilder<VariableIdentifier>.GetInstance(capacity, fillWithValue);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 6992, 7048);
                return return_v;
            }


            int
            f_10903_8722_8743(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8722, 8743);
                return 0;
            }


            int
            f_10903_8762_8788(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8762, 8788);
                return 0;
            }


            int
            f_10903_8807_8859(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8807, 8859);
                return 0;
            }


            System.Random
            f_10903_8933_8945()
            {
                var return_v = new System.Random();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10903, 8933, 8945);
                return return_v;
            }


            int
            f_10903_13753_13774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.LocalDataFlowPass<Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalState, Microsoft.CodeAnalysis.CSharp.NullableWalker.LocalFunctionState>.VariableIdentifier>
            this_param)
            {
                var return_v = this_param.Count;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10903, 13753, 13774);
                return return_v;
            }

        }
    }
}
