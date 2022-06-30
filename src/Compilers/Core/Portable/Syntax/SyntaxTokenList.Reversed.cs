// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public partial struct SyntaxTokenList
    {

        public readonly struct Reversed : IEnumerable<SyntaxToken>, IEquatable<Reversed>
        {

            private readonly SyntaxTokenList _list;

            public Reversed(SyntaxTokenList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(700, 754, 852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 824, 837);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(700, 754, 852);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 754, 852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 754, 852);
                }
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 868, 981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 934, 966);

                    return f_700_941_965(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 868, 981);

                    Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.Enumerator
                    f_700_941_965(Microsoft.CodeAnalysis.SyntaxTokenList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.Enumerator(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 941, 965);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 868, 981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 868, 981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<SyntaxToken> IEnumerable<SyntaxToken>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 997, 1308);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1095, 1237) || true) && (_list.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(700, 1095, 1237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1157, 1218);

                        return f_700_1164_1217();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(700, 1095, 1237);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1257, 1293);

                    return f_700_1264_1292(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 997, 1308);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxToken>
                    f_700_1164_1217()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 1164, 1217);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.EnumeratorImpl
                    f_700_1264_1292(Microsoft.CodeAnalysis.SyntaxTokenList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.EnumeratorImpl(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 1264, 1292);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 997, 1308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 997, 1308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 1324, 1609);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1396, 1538) || true) && (_list.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(700, 1396, 1538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1458, 1519);

                        return f_700_1465_1518();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(700, 1396, 1538);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1558, 1594);

                    return f_700_1565_1593(_list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 1324, 1609);

                    System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxToken>
                    f_700_1465_1518()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerator<SyntaxToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 1465, 1518);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.EnumeratorImpl
                    f_700_1565_1593(Microsoft.CodeAnalysis.SyntaxTokenList
                    list)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.EnumeratorImpl(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 1565, 1593);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 1324, 1609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 1324, 1609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 1625, 1751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1698, 1736);

                    return obj is Reversed r && (DynAbs.Tracing.TraceSender.Expression_True(700, 1705, 1735) && Equals(r));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 1625, 1751);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 1625, 1751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 1625, 1751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(Reversed other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 1767, 1882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1834, 1867);

                    return _list.Equals(other._list);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 1767, 1882);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 1767, 1882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 1767, 1882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 1898, 2006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 1964, 1991);

                    return _list.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(700, 1898, 2006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 1898, 2006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 1898, 2006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
            [StructLayout(LayoutKind.Auto)]
            public struct Enumerator
            {

                private readonly SyntaxNode? _parent;

                private readonly GreenNode? _singleNodeOrList;

                private readonly int _baseIndex;

                private readonly int _count;

                private int _index;

                private GreenNode? _current;

                private int _position;

                internal Enumerator(in SyntaxTokenList list)
                                    : this()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(700, 2575, 3178);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2690, 3159) || true) && (list.Any())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(700, 2690, 3159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2754, 2777);

                            _parent = list._parent;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2803, 2833);

                            _singleNodeOrList = list.Node;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2859, 2884);

                            _baseIndex = list._index;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2910, 2930);

                            _count = list.Count;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 2958, 2974);

                            _index = _count;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3000, 3016);

                            _current = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3044, 3067);

                            var
                            last = list.Last()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3093, 3136);

                            _position = last.Position + last.FullWidth;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(700, 2690, 3159);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(700, 2575, 3178);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 2575, 3178);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 2575, 3178);
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 3198, 3757);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3261, 3419) || true) && (_count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(700, 3265, 3291) || _index <= 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(700, 3261, 3419);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3341, 3357);

                            _current = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3383, 3396);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(700, 3261, 3419);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3443, 3452);

                        _index--;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3476, 3518);

                        f_700_3476_3517(_singleNodeOrList is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3540, 3593);

                        _current = GetGreenNodeAt(_singleNodeOrList, _index);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3615, 3648);

                        f_700_3615_3647(_current is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3670, 3702);

                        _position -= f_700_3683_3701(_current);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3726, 3738);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 3198, 3757);

                        int
                        f_700_3476_3517(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 3476, 3517);
                            return 0;
                        }


                        int
                        f_700_3615_3647(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 3615, 3647);
                            return 0;
                        }


                        int
                        f_700_3683_3701(Microsoft.CodeAnalysis.GreenNode
                        this_param)
                        {
                            var return_v = this_param.FullWidth;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(700, 3683, 3701);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 3198, 3757);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 3198, 3757);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public SyntaxToken Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 3844, 4164);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3896, 4039) || true) && (_current == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(700, 3896, 4039);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 3974, 4012);

                                throw f_700_3980_4011();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(700, 3896, 4039);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 4067, 4141);

                            return f_700_4074_4140(_parent, _current, _position, _baseIndex + _index);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(700, 3844, 4164);

                            System.InvalidOperationException
                            f_700_3980_4011()
                            {
                                var return_v = new System.InvalidOperationException();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 3980, 4011);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.SyntaxToken
                            f_700_4074_4140(Microsoft.CodeAnalysis.SyntaxNode?
                            parent, Microsoft.CodeAnalysis.GreenNode
                            token, int
                            position, int
                            index)
                            {
                                var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 4074, 4140);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 3777, 4183);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 3777, 4183);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 4203, 4337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 4284, 4318);

                        throw f_700_4290_4317();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 4203, 4337);

                        System.NotSupportedException
                        f_700_4290_4317()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 4290, 4317);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 4203, 4337);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 4203, 4337);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 4357, 4484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 4431, 4465);

                        throw f_700_4437_4464();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 4357, 4484);

                        System.NotSupportedException
                        f_700_4437_4464()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 4437, 4464);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 4357, 4484);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 4357, 4484);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                static Enumerator()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(700, 2022, 4499);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(700, 2022, 4499);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 2022, 4499);
                }
            }
            private class EnumeratorImpl : IEnumerator<SyntaxToken>
            {
                private Enumerator _enumerator;

                internal EnumeratorImpl(in SyntaxTokenList list)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(700, 4738, 4884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 4827, 4865);

                        _enumerator = f_700_4841_4864(list);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(700, 4738, 4884);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 4738, 4884);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 4738, 4884);
                    }
                }

                public SyntaxToken Current
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 4931, 4953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 4934, 4953);
                            return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(700, 4931, 4953);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 4931, 4953);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 4931, 4953);
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
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 5001, 5023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 5004, 5023);
                            return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(700, 5001, 5023);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 5001, 5023);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 5001, 5023);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public bool MoveNext()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 5044, 5156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 5107, 5137);

                        return _enumerator.MoveNext();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 5044, 5156);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 5044, 5156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 5044, 5156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public void Reset()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 5176, 5289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(700, 5236, 5270);

                        throw f_700_5242_5269();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 5176, 5289);

                        System.NotSupportedException
                        f_700_5242_5269()
                        {
                            var return_v = new System.NotSupportedException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 5242, 5269);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 5176, 5289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 5176, 5289);
                    }
                }

                public void Dispose()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(700, 5309, 5368);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(700, 5309, 5368);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(700, 5309, 5368);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 5309, 5368);
                    }
                }

                static EnumeratorImpl()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(700, 4515, 5383);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(700, 4515, 5383);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 4515, 5383);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(700, 4515, 5383);

                static Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.Enumerator
                f_700_4841_4864(Microsoft.CodeAnalysis.SyntaxTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Reversed.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(700, 4841, 4864);
                    return return_v;
                }

            }
            static Reversed()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(700, 594, 5394);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(700, 594, 5394);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(700, 594, 5394);
            }
        }
    }
}
