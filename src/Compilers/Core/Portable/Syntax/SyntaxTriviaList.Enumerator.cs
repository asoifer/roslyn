// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{

    public partial struct SyntaxTriviaList
    {

        [StructLayout(LayoutKind.Auto)]
        public struct Enumerator
        {

            private SyntaxToken _token;

            private GreenNode? _singleNodeOrList;

            private int _baseIndex;

            private int _count;

            private int _index;

            private GreenNode? _current;

            private int _position;

            internal Enumerator(in SyntaxTriviaList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(707, 816, 1167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 894, 914);

                    _token = list.Token;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 932, 962);

                    _singleNodeOrList = list.Node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 980, 1004);

                    _baseIndex = list.Index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1022, 1042);

                    _count = list.Count;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1062, 1074);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1092, 1108);

                    _current = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1126, 1152);

                    _position = list.Position;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(707, 816, 1167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 816, 1167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 816, 1167);
                }
            }

            private void InitializeFrom(in SyntaxToken token, GreenNode greenNode, int index, int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 1264, 1682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1392, 1407);

                    _token = token;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1425, 1455);

                    _singleNodeOrList = greenNode;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1473, 1492);

                    _baseIndex = index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1510, 1562);

                    _count = (DynAbs.Tracing.TraceSender.Conditional_F1(707, 1519, 1535) || ((f_707_1519_1535(greenNode) && DynAbs.Tracing.TraceSender.Conditional_F2(707, 1538, 1557)) || DynAbs.Tracing.TraceSender.Conditional_F3(707, 1560, 1561))) ? f_707_1538_1557(greenNode) : 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1582, 1594);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1612, 1628);

                    _current = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 1646, 1667);

                    _position = position;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 1264, 1682);

                    bool
                    f_707_1519_1535(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 1519, 1535);
                        return return_v;
                    }


                    int
                    f_707_1538_1557(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 1538, 1557);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 1264, 1682);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 1264, 1682);
                }
            }

            internal void InitializeFromLeadingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 1944, 2268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2040, 2075);

                    f_707_2040_2074(token.Node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2093, 2138);

                    var
                    node = f_707_2104_2137(token.Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2156, 2185);

                    f_707_2156_2184(node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2203, 2253);

                    InitializeFrom(in token, node, 0, token.Position);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 1944, 2268);

                    int
                    f_707_2040_2074(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2040, 2074);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_707_2104_2137(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2104, 2137);
                        return return_v;
                    }


                    int
                    f_707_2156_2184(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2156, 2184);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 1944, 2268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 1944, 2268);
                }
            }

            internal void InitializeFromTrailingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 2531, 3359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2628, 2663);

                    f_707_2628_2662(token.Node is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2681, 2729);

                    var
                    leading = f_707_2695_2728(token.Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2747, 2761);

                    int
                    index = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2779, 2906) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 2779, 2906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2840, 2887);

                        index = (DynAbs.Tracing.TraceSender.Conditional_F1(707, 2848, 2862) || ((f_707_2848_2862(leading) && DynAbs.Tracing.TraceSender.Conditional_F2(707, 2865, 2882)) || DynAbs.Tracing.TraceSender.Conditional_F3(707, 2885, 2886))) ? f_707_2865_2882(leading) : 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(707, 2779, 2906);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2926, 2981);

                    var
                    trailingGreen = f_707_2946_2980(token.Node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 2999, 3055);

                    int
                    trailingPosition = token.Position + token.FullWidth
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3073, 3203) || true) && (trailingGreen != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 3073, 3203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3140, 3184);

                        trailingPosition -= f_707_3160_3183(trailingGreen);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(707, 3073, 3203);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3223, 3261);

                    f_707_3223_3260(trailingGreen is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3279, 3344);

                    InitializeFrom(in token, trailingGreen, index, trailingPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 2531, 3359);

                    int
                    f_707_2628_2662(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2628, 2662);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_707_2695_2728(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2695, 2728);
                        return return_v;
                    }


                    bool
                    f_707_2848_2862(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 2848, 2862);
                        return return_v;
                    }


                    int
                    f_707_2865_2882(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 2865, 2882);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_707_2946_2980(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 2946, 2980);
                        return return_v;
                    }


                    int
                    f_707_3160_3183(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 3160, 3183);
                        return return_v;
                    }


                    int
                    f_707_3223_3260(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 3223, 3260);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 2531, 3359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 2531, 3359);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 3375, 4003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3430, 3456);

                    int
                    newIndex = _index + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3474, 3652) || true) && (newIndex >= _count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 3474, 3652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3582, 3598);

                        _current = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3620, 3633);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(707, 3474, 3652);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3672, 3690);

                    _index = newIndex;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3710, 3823) || true) && (_current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 3710, 3823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3772, 3804);

                        _position += f_707_3785_3803(_current);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(707, 3710, 3823);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3843, 3885);

                    f_707_3843_3884(_singleNodeOrList is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3903, 3958);

                    _current = GetGreenNodeAt(_singleNodeOrList, newIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 3976, 3988);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 3375, 4003);

                    int
                    f_707_3785_3803(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(707, 3785, 3803);
                        return return_v;
                    }


                    int
                    f_707_3843_3884(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 3843, 3884);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 3375, 4003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 3375, 4003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxTrivia Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 4079, 4371);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4123, 4254) || true) && (_current == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 4123, 4254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4193, 4231);

                            throw f_707_4199_4230();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(707, 4123, 4254);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4278, 4352);

                        return f_707_4285_4351(_token, _current, _position, _baseIndex + _index);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(707, 4079, 4371);

                        System.InvalidOperationException
                        f_707_4199_4230()
                        {
                            var return_v = new System.InvalidOperationException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 4199, 4230);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxTrivia
                        f_707_4285_4351(Microsoft.CodeAnalysis.SyntaxToken
                        token, Microsoft.CodeAnalysis.GreenNode
                        triviaNode, int
                        position, int
                        index)
                        {
                            var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 4285, 4351);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 4019, 4386);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 4019, 4386);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal bool TryMoveNextAndGetCurrent(out SyntaxTrivia current)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 4402, 4770);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4499, 4628) || true) && (!MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(707, 4499, 4628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4556, 4574);

                        current = default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4596, 4609);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(707, 4499, 4628);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4648, 4725);

                    current = f_707_4658_4724(_token, _current, _position, _baseIndex + _index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 4743, 4755);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 4402, 4770);

                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_707_4658_4724(Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.GreenNode?
                    triviaNode, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 4658, 4724);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 4402, 4770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 4402, 4770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(707, 449, 4781);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(707, 449, 4781);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 449, 4781);
            }
        }
        private class EnumeratorImpl : IEnumerator<SyntaxTrivia>
        {
            private Enumerator _enumerator;

            internal EnumeratorImpl(in SyntaxTriviaList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(707, 5001, 5136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 5083, 5121);

                    _enumerator = f_707_5097_5120(list);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(707, 5001, 5136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5001, 5136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5001, 5136);
                }
            }

            public SyntaxTrivia Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 5180, 5202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 5183, 5202);
                        return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(707, 5180, 5202);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5180, 5202);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5180, 5202);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 5246, 5268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 5249, 5268);
                        return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(707, 5246, 5268);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5246, 5268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5246, 5268);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 5285, 5385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 5340, 5370);

                    return _enumerator.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 5285, 5385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5285, 5385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5285, 5385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 5401, 5502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(707, 5453, 5487);

                    throw f_707_5459_5486();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 5401, 5502);

                    System.NotSupportedException
                    f_707_5459_5486()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 5459, 5486);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5401, 5502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5401, 5502);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(707, 5518, 5569);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(707, 5518, 5569);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(707, 5518, 5569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 5518, 5569);
                }
            }

            static EnumeratorImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(707, 4793, 5580);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(707, 4793, 5580);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(707, 4793, 5580);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(707, 4793, 5580);

            static Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator
            f_707_5097_5120(Microsoft.CodeAnalysis.SyntaxTriviaList
            list)
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator(list);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(707, 5097, 5120);
                return return_v;
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
