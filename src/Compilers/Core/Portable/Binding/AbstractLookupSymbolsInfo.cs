// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract class AbstractLookupSymbolsInfo<TSymbol>
            where TSymbol : class, ISymbolInternal
    {
        public struct ArityEnumerator : IEnumerator<int>
        {

            private int _current;

            private readonly int _low32bits;

            private int[]? _arities;

            private const int
            resetValue = -1
            ;

            private const int
            reachedEndValue = int.MaxValue
            ;

            internal ArityEnumerator(int bitVector, HashSet<int>? arities)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(47, 842, 1283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 937, 959);

                    _current = resetValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 977, 1000);

                    _low32bits = bitVector;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1018, 1268) || true) && (arities == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 1018, 1268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1079, 1095);

                        _arities = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 1018, 1268);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 1018, 1268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1177, 1206);

                        _arities = f_47_1188_1205(arities);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1228, 1249);

                        f_47_1228_1248(_arities);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 1018, 1268);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(47, 842, 1283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 842, 1283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 842, 1283);
                }
            }

            public int Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 1318, 1329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1321, 1329);
                        return _current; DynAbs.Tracing.TraceSender.TraceExitMethod(47, 1318, 1329);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 1318, 1329);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 1318, 1329);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 1368, 1386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1371, 1386);
                    _arities = null; DynAbs.Tracing.TraceSender.TraceExitMethod(47, 1368, 1386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 1368, 1386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 1368, 1386);
                }
            }

            object? System.Collections.IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 1450, 1461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1453, 1461);
                        return _current; DynAbs.Tracing.TraceSender.TraceExitMethod(47, 1450, 1461);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 1450, 1461);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 1450, 1461);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 1478, 2696);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1533, 1686) || true) && (_current == reachedEndValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 1533, 1686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1654, 1667);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 1533, 1686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1748, 1758);

                    int
                    arity
                    = default(int);
                    try
                    {
                        // Find the next set bit
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1825, 1843)
        , arity = ++_current; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1820, 2089) || true) && (arity < 32)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1857, 1864)
        , arity++, DynAbs.Tracing.TraceSender.TraceExitCondition(47, 1820, 2089))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 1820, 2089);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1906, 2070) || true) && (((_low32bits >> arity) & 1) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 1906, 2070);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 1992, 2009);

                                _current = arity;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2035, 2047);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(47, 1906, 2070);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(47, 1, 270);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(47, 1, 270);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2109, 2603) || true) && (_arities != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 2109, 2603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2231, 2272);

                        int
                        index = f_47_2243_2271(_arities, arity)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2294, 2395) || true) && (index < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 2294, 2395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2357, 2372);

                            index = ~index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(47, 2294, 2395);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2419, 2584) || true) && (index < f_47_2431_2446(_arities))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 2419, 2584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2496, 2523);

                            _current = _arities[index];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2549, 2561);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(47, 2419, 2584);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 2109, 2603);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2623, 2650);

                    _current = reachedEndValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2668, 2681);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(47, 1478, 2696);

                    int
                    f_47_2243_2271(int[]
                    array, int
                    value)
                    {
                        var return_v = array.BinarySearch(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 2243, 2271);
                        return return_v;
                    }


                    int
                    f_47_2431_2446(int[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 2431, 2446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 1478, 2696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 1478, 2696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 2732, 2756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 2735, 2756);
                    _current = resetValue; DynAbs.Tracing.TraceSender.TraceExitMethod(47, 2732, 2756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 2732, 2756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 2732, 2756);
                }
            }
            static ArityEnumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(47, 535, 2768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 747, 762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 795, 825);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(47, 535, 2768);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 535, 2768);
            }

            static int[]
            f_47_1188_1205(System.Collections.Generic.HashSet<int>
            source)
            {
                var return_v = source.ToArray<int>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 1188, 1205);
                return return_v;
            }


            static int
            f_47_1228_1248(int[]
            array)
            {
                Array.Sort(array);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 1228, 1248);
                return 0;
            }

        }

        // TODO: Is the cost of boxing every instance of UniqueSymbolOrArities that we
        // hand out justified by the benefit of not being able to call our internal
        // APIs incorrectly (without an explicit cast)?
        public interface IArityEnumerable
        {

            ArityEnumerator GetEnumerator();

            int Count { get; }
        }

        private struct UniqueSymbolOrArities : IArityEnumerable
        {

            private object? _uniqueSymbolOrArities;

            private int _arityBitVectorOrUniqueArity;

            public UniqueSymbolOrArities(int arity, TSymbol uniqueSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(47, 4574, 4922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 4668, 4706);

                    _uniqueSymbolOrArities = uniqueSymbol;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 4724, 4761);

                    _arityBitVectorOrUniqueArity = arity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 4854, 4907);

                    f_47_4854_4906((uniqueSymbol != null) || (DynAbs.Tracing.TraceSender.Expression_False(47, 4867, 4905) || (arity == 0)));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(47, 4574, 4922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 4574, 4922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 4574, 4922);
                }
            }

            public void AddSymbol(TSymbol symbol, int arity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 4938, 5840);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5019, 5215) || true) && (symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(47, 5023, 5073) && symbol == _uniqueSymbolOrArities))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 5019, 5215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5115, 5167);

                        f_47_5115_5166(arity == _arityBitVectorOrUniqueArity);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5189, 5196);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 5019, 5215);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5235, 5789) || true) && (this.HasUniqueSymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 5235, 5789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5500, 5548);

                        f_47_5500_5547(_uniqueSymbolOrArities is TSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5570, 5600);

                        _uniqueSymbolOrArities = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5624, 5671);

                        int
                        uniqueArity = _arityBitVectorOrUniqueArity
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5693, 5726);

                        _arityBitVectorOrUniqueArity = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5748, 5770);

                        AddArity(uniqueArity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 5235, 5789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5809, 5825);

                    AddArity(arity);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(47, 4938, 5840);

                    int
                    f_47_5115_5166(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 5115, 5166);
                        return 0;
                    }


                    int
                    f_47_5500_5547(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 5500, 5547);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 4938, 5840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 4938, 5840);
                }
            }

            private bool HasUniqueSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 5885, 5963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 5888, 5963);
                        return _uniqueSymbolOrArities != null && (DynAbs.Tracing.TraceSender.Expression_True(47, 5888, 5963) && !(_uniqueSymbolOrArities is HashSet<int>)); DynAbs.Tracing.TraceSender.TraceExitMethod(47, 5885, 5963);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 5885, 5963);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 5885, 5963);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private void AddArity(int arity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 5980, 6795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6045, 6081);

                    f_47_6045_6080(f_47_6058_6079_M(!this.HasUniqueSymbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6173, 6441) || true) && (arity < 32)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 6173, 6441);
                        unchecked
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6287, 6308);

                            int
                            bit = 1 << arity
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6334, 6370);

                            _arityBitVectorOrUniqueArity |= bit;
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6415, 6422);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 6173, 6441);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6506, 6559);

                    var
                    hashSet = _uniqueSymbolOrArities as HashSet<int>
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6577, 6741) || true) && (hashSet == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 6577, 6741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6638, 6667);

                        hashSet = f_47_6648_6666();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6689, 6722);

                        _uniqueSymbolOrArities = hashSet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 6577, 6741);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6761, 6780);

                    f_47_6761_6779(
                                    hashSet, arity);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(47, 5980, 6795);

                    bool
                    f_47_6058_6079_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 6058, 6079);
                        return return_v;
                    }


                    int
                    f_47_6045_6080(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 6045, 6080);
                        return 0;
                    }


                    System.Collections.Generic.HashSet<int>
                    f_47_6648_6666()
                    {
                        var return_v = new System.Collections.Generic.HashSet<int>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 6648, 6666);
                        return return_v;
                    }


                    bool
                    f_47_6761_6779(System.Collections.Generic.HashSet<int>
                    this_param, int
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 6761, 6779);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 5980, 6795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 5980, 6795);
                }
            }

            public void GetUniqueSymbolOrArities(out IArityEnumerable? arities, out TSymbol? uniqueSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 6811, 7482);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 6938, 7467) || true) && (this.HasUniqueSymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 6938, 7467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7004, 7019);

                        arities = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7147, 7194);

                        uniqueSymbol = (TSymbol)_uniqueSymbolOrArities;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 6938, 7467);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 6938, 7467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7294, 7406);

                        arities = (DynAbs.Tracing.TraceSender.Conditional_F1(47, 7304, 7373) || (((_uniqueSymbolOrArities == null && (DynAbs.Tracing.TraceSender.Expression_True(47, 7305, 7372) && _arityBitVectorOrUniqueArity == 0)) && DynAbs.Tracing.TraceSender.Conditional_F2(47, 7376, 7380)) || DynAbs.Tracing.TraceSender.Conditional_F3(47, 7383, 7405))) ? null : (IArityEnumerable)this;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7428, 7448);

                        uniqueSymbol = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(47, 6938, 7467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(47, 6811, 7482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 6811, 7482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 6811, 7482);
                }
            }

            public ArityEnumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 7498, 7734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7569, 7605);

                    f_47_7569_7604(f_47_7582_7603_M(!this.HasUniqueSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7623, 7719);

                    return f_47_7630_7718(_arityBitVectorOrUniqueArity, (HashSet<int>?)_uniqueSymbolOrArities);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(47, 7498, 7734);

                    bool
                    f_47_7582_7603_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 7582, 7603);
                        return return_v;
                    }


                    int
                    f_47_7569_7604(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 7569, 7604);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.ArityEnumerator
                    f_47_7630_7718(int
                    bitVector, object?
                    arities)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.ArityEnumerator(bitVector, (System.Collections.Generic.HashSet<int>?)arities);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 7630, 7718);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 7498, 7734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 7498, 7734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 7799, 8231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7843, 7879);

                        f_47_7843_7878(f_47_7856_7877_M(!this.HasUniqueSymbol));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7901, 7976);

                        int
                        count = f_47_7913_7975(_arityBitVectorOrUniqueArity)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 7998, 8046);

                        var
                        set = (HashSet<int>?)_uniqueSymbolOrArities
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8068, 8175) || true) && (set != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 8068, 8175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8133, 8152);

                            count += f_47_8142_8151(set);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(47, 8068, 8175);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8199, 8212);

                        return count;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(47, 7799, 8231);

                        bool
                        f_47_7856_7877_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 7856, 7877);
                            return return_v;
                        }


                        int
                        f_47_7843_7878(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 7843, 7878);
                            return 0;
                        }


                        int
                        f_47_7913_7975(int
                        v)
                        {
                            var return_v = BitArithmeticUtilities.CountBits(v);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 7913, 7975);
                            return return_v;
                        }


                        int
                        f_47_8142_8151(System.Collections.Generic.HashSet<int>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 8142, 8151);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 7750, 8246);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 7750, 8246);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal TSymbol? UniqueSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 8304, 8340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8307, 8340);
                        return _uniqueSymbolOrArities as TSymbol; DynAbs.Tracing.TraceSender.TraceExitMethod(47, 8304, 8340);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 8304, 8340);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 8304, 8340);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static UniqueSymbolOrArities()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(47, 3268, 8360);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(47, 3268, 8360);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 3268, 8360);
            }

            static int
            f_47_4854_4906(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 4854, 4906);
                return 0;
            }

        }

        private readonly IEqualityComparer<string> _comparer;

        private readonly Dictionary<string, UniqueSymbolOrArities> _nameMap;

        internal string? FilterName { get; set; }

        protected AbstractLookupSymbolsInfo(IEqualityComparer<string> comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(47, 8566, 8775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8415, 8424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8494, 8502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8513, 8554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8662, 8683);

                _comparer = comparer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8697, 8764);

                _nameMap = f_47_8708_8763(comparer);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(47, 8566, 8775);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 8566, 8775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 8566, 8775);
            }
        }

        public bool CanBeAdded(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 8823, 8882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8826, 8882);
                return FilterName == null || (DynAbs.Tracing.TraceSender.Expression_False(47, 8826, 8882) || f_47_8848_8882(_comparer, name, FilterName)); DynAbs.Tracing.TraceSender.TraceExitMethod(47, 8823, 8882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 8823, 8882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 8823, 8882);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_47_8848_8882(System.Collections.Generic.IEqualityComparer<string>
            this_param, string
            x, string
            y)
            {
                var return_v = this_param.Equals(x, y);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 8848, 8882);
                return return_v;
            }

        }

        public void AddSymbol(TSymbol symbol, string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 8895, 10020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 8981, 9008);

                UniqueSymbolOrArities
                pair
                = default(UniqueSymbolOrArities);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9022, 9667) || true) && (!f_47_9027_9063(_nameMap, name, out pair))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 9022, 9667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9327, 9375);

                    pair = f_47_9334_9374(arity, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9393, 9418);

                    f_47_9393_9417(_nameMap, name, pair);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(47, 9022, 9667);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 9022, 9667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9484, 9514);

                    pair.AddSymbol(symbol, arity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9630, 9652);

                    _nameMap[name] = pair;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(47, 9022, 9667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 9930, 10001);

                f_47_9930_10000(pair.UniqueSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(47, 9943, 9999) || pair.UniqueSymbol == symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(47, 8895, 10020);

                bool
                f_47_9027_9063(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
                this_param, string
                key, out Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 9027, 9063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities
                f_47_9334_9374(int
                arity, TSymbol
                uniqueSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities(arity, uniqueSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 9334, 9374);
                    return return_v;
                }


                int
                f_47_9393_9417(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
                this_param, string
                key, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 9393, 9417);
                    return 0;
                }


                int
                f_47_9930_10000(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 9930, 10000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 8895, 10020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 8895, 10020);
            }
        }
        
        public ICollection<String> Names
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 10065, 10081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10068, 10081);
                    return f_47_10068_10081(_nameMap); DynAbs.Tracing.TraceSender.TraceExitMethod(47, 10065, 10081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 10065, 10081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 10065, 10081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 10111, 10128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10114, 10128);
                    return f_47_10114_10128(_nameMap); DynAbs.Tracing.TraceSender.TraceExitMethod(47, 10111, 10128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 10111, 10128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 10111, 10128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// If <paramref name="uniqueSymbol"/> is set, then <paramref name="arities"/> will be null.
        /// The only arity in that case will be encoded in the symbol. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arities"></param>
        /// <param name="uniqueSymbol"></param>
        /// <returns></returns>
        public bool TryGetAritiesAndUniqueSymbol(
                    string name,
                    out IArityEnumerable? arities,
                    out TSymbol? uniqueSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 10530, 11214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10706, 10737);

                f_47_10706_10736(f_47_10719_10735(this, name));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10753, 10780);

                UniqueSymbolOrArities
                pair
                = default(UniqueSymbolOrArities);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10794, 10968) || true) && (!f_47_10799_10835(_nameMap, name, out pair))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(47, 10794, 10968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10869, 10884);

                    arities = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10902, 10922);

                    uniqueSymbol = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 10940, 10953);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(47, 10794, 10968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 11116, 11177);

                pair.GetUniqueSymbolOrArities(out arities, out uniqueSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 11191, 11203);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(47, 10530, 11214);

                bool
                f_47_10719_10735(Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>
                this_param, string
                name)
                {
                    var return_v = this_param.CanBeAdded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 10719, 10735);
                    return return_v;
                }


                int
                f_47_10706_10736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 10706, 10736);
                    return 0;
                }


                bool
                f_47_10799_10835(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
                this_param, string
                key, out Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 10799, 10835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 10530, 11214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 10530, 11214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(47, 11226, 11330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 11270, 11287);

                f_47_11270_11286(_nameMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(47, 11301, 11319);

                FilterName = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(47, 11226, 11330);

                int
                f_47_11270_11286(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 11270, 11286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(47, 11226, 11330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 11226, 11330);
            }
        }

        static AbstractLookupSymbolsInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(47, 412, 11337);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(47, 412, 11337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(47, 412, 11337);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(47, 412, 11337);

        static System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
        f_47_8708_8763(System.Collections.Generic.IEqualityComparer<string>
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>(comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(47, 8708, 8763);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>.KeyCollection
        f_47_10068_10081(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
        this_param)
        {
            var return_v = this_param.Keys;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 10068, 10081);
            return return_v;
        }


        int
        f_47_10114_10128(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.AbstractLookupSymbolsInfo<TSymbol>.UniqueSymbolOrArities>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(47, 10114, 10128);
            return return_v;
        }

    }
}
