// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis
{

    public partial struct SyntaxTokenList
    {

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
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(699, 2084, 2438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2161, 2184);

                    _parent = list._parent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2202, 2232);

                    _singleNodeOrList = list.Node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2250, 2275);

                    _baseIndex = list._index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2293, 2313);

                    _count = list.Count;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2333, 2345);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2363, 2379);

                    _current = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2397, 2423);

                    _position = list.Position;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(699, 2084, 2438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 2084, 2438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 2084, 2438);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 2772, 3557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2827, 3022) || true) && (_count == 0 || (DynAbs.Tracing.TraceSender.Expression_False(699, 2831, 2866) || _count <= _index + 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(699, 2827, 3022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2952, 2968);

                        _current = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 2990, 3003);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(699, 2827, 3022);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3042, 3051);

                    _index++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3215, 3328) || true) && (_current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(699, 3215, 3328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3277, 3309);

                        _position += f_699_3290_3308(_current);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(699, 3215, 3328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3348, 3390);

                    f_699_3348_3389(_singleNodeOrList is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3408, 3461);

                    _current = GetGreenNodeAt(_singleNodeOrList, _index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3479, 3512);

                    f_699_3479_3511(_current is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3530, 3542);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 2772, 3557);

                    int
                    f_699_3290_3308(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(699, 3290, 3308);
                        return return_v;
                    }


                    int
                    f_699_3348_3389(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 3348, 3389);
                        return 0;
                    }


                    int
                    f_699_3479_3511(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 3479, 3511);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 2772, 3557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 2772, 3557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxToken Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 3748, 4227);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3792, 3923) || true) && (_current == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(699, 3792, 3923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 3862, 3900);

                            throw f_699_3868_3899();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(699, 3792, 3923);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4134, 4208);

                        return f_699_4141_4207(_parent, _current, _position, _baseIndex + _index);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(699, 3748, 4227);

                        System.InvalidOperationException
                        f_699_3868_3899()
                        {
                            var return_v = new System.InvalidOperationException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 3868, 3899);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxToken
                        f_699_4141_4207(Microsoft.CodeAnalysis.SyntaxNode?
                        parent, Microsoft.CodeAnalysis.GreenNode
                        token, int
                        position, int
                        index)
                        {
                            var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 4141, 4207);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 3689, 4242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 3689, 4242);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 4258, 4380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4331, 4365);

                    throw f_699_4337_4364();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 4258, 4380);

                    System.NotSupportedException
                    f_699_4337_4364()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 4337, 4364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 4258, 4380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4258, 4380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 4396, 4511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4462, 4496);

                    throw f_699_4468_4495();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 4396, 4511);

                    System.NotSupportedException
                    f_699_4468_4495()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 4468, 4495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 4396, 4511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4396, 4511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(699, 716, 4522);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(699, 716, 4522);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 716, 4522);
            }
        }
        private class EnumeratorImpl : IEnumerator<SyntaxToken>
        {
            private Enumerator _enumerator;

            internal EnumeratorImpl(in SyntaxTokenList list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(699, 4741, 4875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4822, 4860);

                    _enumerator = f_699_4836_4859(list);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(699, 4741, 4875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 4741, 4875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4741, 4875);
                }
            }

            public SyntaxToken Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 4918, 4940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4921, 4940);
                        return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(699, 4918, 4940);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 4918, 4940);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4918, 4940);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 4984, 5006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 4987, 5006);
                        return _enumerator.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(699, 4984, 5006);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 4984, 5006);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4984, 5006);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 5023, 5123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 5078, 5108);

                    return _enumerator.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 5023, 5123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 5023, 5123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 5023, 5123);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 5139, 5240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(699, 5191, 5225);

                    throw f_699_5197_5224();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 5139, 5240);

                    System.NotSupportedException
                    f_699_5197_5224()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 5197, 5224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 5139, 5240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 5139, 5240);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(699, 5256, 5307);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(699, 5256, 5307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(699, 5256, 5307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 5256, 5307);
                }
            }

            static EnumeratorImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(699, 4534, 5318);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(699, 4534, 5318);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(699, 4534, 5318);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(699, 4534, 5318);

            static Microsoft.CodeAnalysis.SyntaxTokenList.Enumerator
            f_699_4836_4859(Microsoft.CodeAnalysis.SyntaxTokenList
            list)
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Enumerator(list);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(699, 4836, 4859);
                return return_v;
            }

        }
    }
}
