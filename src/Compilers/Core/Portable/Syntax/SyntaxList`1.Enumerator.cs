// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{

    public readonly partial struct SyntaxList<TNode>
    {

        [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
        public struct Enumerator
        {

            private readonly SyntaxList<TNode> _list;

            private int _index;

            internal Enumerator(SyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(685, 677, 811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 753, 766);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 784, 796);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(685, 677, 811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 677, 811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 677, 811);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 827, 1113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 882, 908);

                    int
                    newIndex = _index + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 926, 1065) || true) && (newIndex < _list.Count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(685, 926, 1065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 994, 1012);

                        _index = newIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1034, 1046);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(685, 926, 1065);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1085, 1098);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 827, 1113);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 827, 1113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 827, 1113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 1182, 1287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1226, 1268);

                        return (TNode)_list.ItemInternal(_index)!;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(685, 1182, 1287);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1129, 1302);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1129, 1302);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 1318, 1397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1370, 1382);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 1318, 1397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1318, 1397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1318, 1397);
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 1413, 1535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1486, 1520);

                    throw f_685_1492_1519();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 1413, 1535);

                    System.NotSupportedException
                    f_685_1492_1519()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(685, 1492, 1519);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1413, 1535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1413, 1535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 1551, 1666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1617, 1651);

                    throw f_685_1623_1650();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 1551, 1666);

                    System.NotSupportedException
                    f_685_1623_1650()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(685, 1623, 1650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1551, 1666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1551, 1666);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(685, 433, 1677);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(685, 433, 1677);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 433, 1677);
            }
        }
        private class EnumeratorImpl : IEnumerator<TNode>
        {
            private Enumerator _e;

            internal EnumeratorImpl(in SyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(685, 1801, 1925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1884, 1910);

                    _e = f_685_1889_1909(list);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(685, 1801, 1925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1801, 1925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1801, 1925);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 1941, 2032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 1996, 2017);

                    return _e.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 1941, 2032);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 1941, 2032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1941, 2032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 2101, 2182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 2145, 2163);

                        return _e.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(685, 2101, 2182);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 2048, 2197);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 2048, 2197);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IDisposable.Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 2213, 2269);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 2213, 2269);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 2213, 2269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 2213, 2269);
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 2344, 2425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 2388, 2406);

                        return _e.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(685, 2344, 2425);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 2285, 2440);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 2285, 2440);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(685, 2456, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(685, 2513, 2524);

                    _e.Reset();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(685, 2456, 2539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(685, 2456, 2539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 2456, 2539);
                }
            }

            static EnumeratorImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(685, 1689, 2550);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(685, 1689, 2550);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(685, 1689, 2550);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(685, 1689, 2550);

            static Microsoft.CodeAnalysis.SyntaxList<TNode>.Enumerator
            f_685_1889_1909(Microsoft.CodeAnalysis.SyntaxList<TNode>
            list)
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>.Enumerator(list);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(685, 1889, 1909);
                return return_v;
            }

        }
    }
}
