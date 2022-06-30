// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{

    public partial struct SeparatedSyntaxList<TNode>
    {

        [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
        public struct Enumerator
        {

            private readonly SeparatedSyntaxList<TNode> _list;

            private int _index;

            internal Enumerator(in SeparatedSyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(670, 897, 1043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 985, 998);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1016, 1028);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(670, 897, 1043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 897, 1043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 897, 1043);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 1059, 1345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1114, 1140);

                    int
                    newIndex = _index + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1158, 1297) || true) && (newIndex < _list.Count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(670, 1158, 1297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1226, 1244);

                        _index = newIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1266, 1278);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(670, 1158, 1297);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1317, 1330);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 1059, 1345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 1059, 1345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1059, 1345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 1414, 1498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1458, 1479);

                        return _list[_index];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(670, 1414, 1498);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 1361, 1513);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1361, 1513);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 1529, 1608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1581, 1593);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 1529, 1608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 1529, 1608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1529, 1608);
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 1624, 1746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1697, 1731);

                    throw f_670_1703_1730();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 1624, 1746);

                    System.NotSupportedException
                    f_670_1703_1730()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(670, 1703, 1730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 1624, 1746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1624, 1746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 1762, 1877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 1828, 1862);

                    throw f_670_1834_1861();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 1762, 1877);

                    System.NotSupportedException
                    f_670_1834_1861()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(670, 1834, 1861);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 1762, 1877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1762, 1877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(670, 644, 1888);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(670, 644, 1888);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 644, 1888);
            }
        }
        private class EnumeratorImpl : IEnumerator<TNode>
        {
            private Enumerator _e;

            internal EnumeratorImpl(in SeparatedSyntaxList<TNode> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(670, 2060, 2196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 2152, 2181);

                    _e = f_670_2157_2180(list);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(670, 2060, 2196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2060, 2196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2060, 2196);
                }
            }

            public TNode Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 2265, 2346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 2309, 2327);

                        return _e.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(670, 2265, 2346);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2212, 2361);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2212, 2361);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 2436, 2517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 2480, 2498);

                        return _e.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(670, 2436, 2517);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2377, 2532);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2377, 2532);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 2548, 2599);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 2548, 2599);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2548, 2599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2548, 2599);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 2615, 2706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 2670, 2691);

                    return _e.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 2615, 2706);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2615, 2706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2615, 2706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(670, 2722, 2800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(670, 2774, 2785);

                    _e.Reset();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(670, 2722, 2800);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(670, 2722, 2800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 2722, 2800);
                }
            }

            static EnumeratorImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(670, 1948, 2811);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(670, 1948, 2811);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(670, 1948, 2811);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(670, 1948, 2811);

            static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.Enumerator
            f_670_2157_2180(Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
            list)
            {
                var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>.Enumerator(list);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(670, 2157, 2180);
                return return_v;
            }

        }
    }
}
