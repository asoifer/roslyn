// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public partial struct SyntaxTriviaList
    {

        public readonly struct Reversed : IEnumerable<SyntaxTrivia>, IEquatable<Reversed>
        {

            private readonly SyntaxTriviaList _list;

            public Reversed(SyntaxTriviaList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(708, 717, 816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 788, 801);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(708, 717, 816);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 717, 816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 717, 816);
                }
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 832, 945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 898, 930);

                    return f_708_905_929(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 832, 945);

                    Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.Enumerator
                    f_708_905_929(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.Enumerator(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 905, 929);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 832, 945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 832, 945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<SyntaxTrivia> IEnumerable<SyntaxTrivia>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 961, 1283);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1061, 1204) || true) && (_list.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(708, 1061, 1204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1123, 1185);

                        return f_708_1130_1184();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(708, 1061, 1204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1224, 1268);

                    return f_708_1231_1267(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 961, 1283);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxTrivia>
                    f_708_1130_1184()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxTrivia>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 1130, 1184);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.ReversedEnumeratorImpl
                    f_708_1231_1267(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.ReversedEnumeratorImpl(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 1231, 1267);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 961, 1283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 961, 1283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator
                            IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 1299, 1610);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1388, 1531) || true) && (_list.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(708, 1388, 1531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1450, 1512);

                        return f_708_1457_1511();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(708, 1388, 1531);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1551, 1595);

                    return f_708_1558_1594(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 1299, 1610);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxTrivia>
                    f_708_1457_1511()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxTrivia>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 1457, 1511);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.ReversedEnumeratorImpl
                    f_708_1558_1594(Microsoft.CodeAnalysis.SyntaxTriviaList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.ReversedEnumeratorImpl(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 1558, 1594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 1299, 1610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 1299, 1610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 1626, 1734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1692, 1719);

                    return _list.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 1626, 1734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 1626, 1734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 1626, 1734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 1750, 1886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1823, 1871);

                    return obj is Reversed && (DynAbs.Tracing.TraceSender.Expression_True(708, 1830, 1870) && Equals(obj));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 1750, 1886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 1750, 1886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 1750, 1886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(Reversed other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 1902, 2017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 1969, 2002);

                    return _list.Equals(other._list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(708, 1902, 2017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 1902, 2017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 1902, 2017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Auto)]
            public struct Enumerator
            {

                private readonly SyntaxToken _token;

                private readonly GreenNode? _singleNodeOrList;

                private readonly int _baseIndex;

                private readonly int _count;

                private int _index;

                private GreenNode? _current;

                private int _position;

                internal Enumerator(in SyntaxTriviaList list)
                                    : this()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(708, 2476, 3085);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2592, 3066) || true) && (list.Node is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(708, 2592, 3066);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2665, 2685);

                            _token = list.Token;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2711, 2741);

                            _singleNodeOrList = list.Node;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2767, 2791);

                            _baseIndex = list.Index;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2817, 2837);

                            _count = list.Count;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2865, 2881);

                            _index = _count;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2907, 2923);

                            _current = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 2951, 2974);

                            var
                            last = list.Last()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3000, 3043);

                            _position = last.Position + last.FullWidth;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(708, 2592, 3066);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(708, 2476, 3085);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 2476, 3085);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 2476, 3085);
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 3105, 3664);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3168, 3326) || true) && (_count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(708, 3172, 3198) || _index <= 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(708, 3168, 3326);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3248, 3264);

                            _current = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3290, 3303);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(708, 3168, 3326);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3350, 3392);

                        f_708_3350_3391(_singleNodeOrList is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3414, 3423);

                        _index--;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3447, 3500);

                        _current = GetGreenNodeAt(_singleNodeOrList, _index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3522, 3555);

                        f_708_3522_3554(_current is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3577, 3609);

                        _position -= f_708_3590_3608(_current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3633, 3645);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(708, 3105, 3664);

                        int
                        f_708_3350_3391(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 3350, 3391);
                            return 0;
                        }


                        int
                        f_708_3522_3554(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 3522, 3554);
                            return 0;
                        }


                        int
                        f_708_3590_3608(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.FullWidth;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(708, 3590, 3608);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 3105, 3664);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 3105, 3664);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public SyntaxTrivia Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 3752, 4072);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3804, 3947) || true) && (_current == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(708, 3804, 3947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3882, 3920);

                                throw f_708_3888_3919();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(708, 3804, 3947);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 3975, 4049);

                            return f_708_3982_4048(_token, _current, _position, _baseIndex + _index);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(708, 3752, 4072);

                            System.InvalidOperationException
                            f_708_3888_3919()
                            {
                                var return_v = new System.InvalidOperationException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 3888, 3919);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxTrivia
                            f_708_3982_4048(Microsoft.CodeAnalysis.SyntaxToken
                            token, Microsoft.CodeAnalysis.GreenNode
                            triviaNode, int
                            position, int
                            index)
                            {
                                var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 3982, 4048);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 3684, 4091);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 3684, 4091);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(708, 2033, 4106);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(708, 2033, 4106);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 2033, 4106);
                }
            }
            private class ReversedEnumeratorImpl : IEnumerator<SyntaxTrivia>
            {
                private Enumerator _enumerator;

                internal ReversedEnumeratorImpl(in SyntaxTriviaList list)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(708, 4354, 4509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 4452, 4490);

                        _enumerator = f_708_4466_4489(list);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(708, 4354, 4509);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4354, 4509);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4354, 4509);
                    }
                }

                public SyntaxTrivia Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 4557, 4579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 4560, 4579);
                            return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(708, 4557, 4579);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4557, 4579);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4557, 4579);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 4627, 4649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 4630, 4649);
                            return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(708, 4627, 4649);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4627, 4649);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4627, 4649);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 4670, 4782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 4733, 4763);

                        return _enumerator.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(708, 4670, 4782);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4670, 4782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4670, 4782);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 4802, 4915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(708, 4862, 4896);

                        throw f_708_4868_4895();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(708, 4802, 4915);

                        System.NotSupportedException
                        f_708_4868_4895()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 4868, 4895);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4802, 4915);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4802, 4915);
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(708, 4935, 4994);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(708, 4935, 4994);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(708, 4935, 4994);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4935, 4994);
                    }
                }

                static ReversedEnumeratorImpl()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(708, 4122, 5009);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(708, 4122, 5009);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 4122, 5009);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(708, 4122, 5009);

                static Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.Enumerator
                f_708_4466_4489(Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(708, 4466, 4489);
                    return return_v;
                }

            }
            static Reversed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(708, 555, 5020);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(708, 555, 5020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(708, 555, 5020);
            }
        }

        // LAFHIS
        //static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>
        //f_706_8904_8983(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>.Factory
        //factory)
        //{
        //    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>(factory);
        //    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 8904, 8983);
        //    return return_v;
        //}

    }
}
