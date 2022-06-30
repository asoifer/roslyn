// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly partial struct ChildSyntaxList
    {

        public readonly partial struct Reversed : IEnumerable<SyntaxNodeOrToken>, IEquatable<Reversed>
        {

            private readonly SyntaxNode? _node;

            private readonly int _count;

            internal Reversed(SyntaxNode node, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(659, 695, 834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 773, 786);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 804, 819);

                    _count = count;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(659, 695, 834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 695, 834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 695, 834);
                }
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 850, 1016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 916, 946);

                    f_659_916_945(_node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 964, 1001);

                    return f_659_971_1000(_node, _count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 850, 1016);

                    int
                    f_659_916_945(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 916, 945);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                    f_659_971_1000(Microsoft.CodeAnalysis.SyntaxNode
                    node, int
                    count)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator(node, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 971, 1000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 850, 1016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 850, 1016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<SyntaxNodeOrToken> IEnumerable<SyntaxNodeOrToken>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 1032, 1363);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1142, 1287) || true) && (_node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(659, 1142, 1287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1201, 1268);

                        return f_659_1208_1267();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(659, 1142, 1287);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1307, 1348);

                    return f_659_1314_1347(_node, _count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 1032, 1363);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                    f_659_1208_1267()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1208, 1267);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.EnumeratorImpl
                    f_659_1314_1347(Microsoft.CodeAnalysis.SyntaxNode
                    node, int
                    count)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.EnumeratorImpl(node, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1314, 1347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 1032, 1363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 1032, 1363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 1379, 1672);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1451, 1596) || true) && (_node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(659, 1451, 1596);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1510, 1577);

                        return f_659_1517_1576();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(659, 1451, 1596);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1616, 1657);

                    return f_659_1623_1656(_node, _count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 1379, 1672);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                    f_659_1517_1576()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1517, 1576);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.EnumeratorImpl
                    f_659_1623_1656(Microsoft.CodeAnalysis.SyntaxNode
                    node, int
                    count)
                    {
                        var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.EnumeratorImpl(node, count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1623, 1656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 1379, 1672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 1379, 1672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 1688, 1838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1754, 1823);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(659, 1761, 1774) || ((_node != null && DynAbs.Tracing.TraceSender.Conditional_F2(659, 1777, 1818)) || DynAbs.Tracing.TraceSender.Conditional_F3(659, 1821, 1822))) ? f_659_1777_1818(f_659_1790_1809(_node), _count) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 1688, 1838);

                    int
                    f_659_1790_1809(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1790, 1809);
                        return return_v;
                    }


                    int
                    f_659_1777_1818(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 1777, 1818);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 1688, 1838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 1688, 1838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 1854, 1982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 1927, 1967);

                    return (obj is Reversed r) && (DynAbs.Tracing.TraceSender.Expression_True(659, 1934, 1966) && Equals(r));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 1854, 1982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 1854, 1982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 1854, 1982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(Reversed other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 1998, 2155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2065, 2140);

                    return _node == other._node
                    && (DynAbs.Tracing.TraceSender.Expression_True(659, 2072, 2139) && _count == other._count);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(659, 1998, 2155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 1998, 2155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 1998, 2155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public struct Enumerator
            {

                private readonly SyntaxNode? _node;

                private readonly int _count;

                private int _childIndex;

                internal Enumerator(SyntaxNode node, int count)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(659, 2371, 2570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2459, 2472);

                        _node = node;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2494, 2509);

                        _count = count;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2531, 2551);

                        _childIndex = count;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(659, 2371, 2570);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 2371, 2570);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 2371, 2570);
                    }
                }

                [MemberNotNullWhen(true, nameof(_node))]
                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 2590, 2756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2711, 2737);

                        return --_childIndex >= 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(659, 2590, 2756);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 2590, 2756);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 2590, 2756);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public SyntaxNodeOrToken Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 2849, 3020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2901, 2931);

                            f_659_2901_2930(_node is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 2957, 2997);

                            return ItemInternal(_node, _childIndex);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(659, 2849, 3020);

                            int
                            f_659_2901_2930(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 2901, 2930);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 2776, 3039);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 2776, 3039);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 3059, 3159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 3119, 3140);

                        _childIndex = _count;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(659, 3059, 3159);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 3059, 3159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 3059, 3159);
                    }
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(659, 2171, 3174);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(659, 2171, 3174);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 2171, 3174);
                }
            }
            private class EnumeratorImpl : IEnumerator<SyntaxNodeOrToken>
            {
                private Enumerator _enumerator;

                internal EnumeratorImpl(SyntaxNode node, int count)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(659, 3335, 3488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 3427, 3469);

                        _enumerator = f_659_3441_3468(node, count);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(659, 3335, 3488);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 3335, 3488);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 3335, 3488);
                    }
                }

                public SyntaxNodeOrToken Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 3902, 3937);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 3908, 3935);

                            return _enumerator.Current;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(659, 3902, 3937);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 3829, 3956);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 3829, 3956);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 4364, 4399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 4370, 4397);

                            return _enumerator.Current;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(659, 4364, 4399);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 4297, 4418);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 4297, 4418);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 4941, 5053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 5004, 5034);

                        return _enumerator.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(659, 4941, 5053);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 4941, 5053);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 4941, 5053);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 5395, 5494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(659, 5455, 5475);

                        _enumerator.Reset();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(659, 5395, 5494);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 5395, 5494);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 5395, 5494);
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(659, 5703, 5745);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(659, 5703, 5745);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(659, 5703, 5745);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 5703, 5745);
                    }
                }

                static EnumeratorImpl()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(659, 3190, 5760);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(659, 3190, 5760);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 3190, 5760);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(659, 3190, 5760);

                static Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator
                f_659_3441_3468(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                count)
                {
                    var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Reversed.Enumerator(node, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(659, 3441, 3468);
                    return return_v;
                }

            }
            static Reversed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(659, 483, 5771);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(659, 483, 5771);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(659, 483, 5771);
            }
        }
    }
}
