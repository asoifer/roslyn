// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{

    public partial struct ChildSyntaxList
    {

        public struct Enumerator
        {

            private SyntaxNode? _node;

            private int _count;

            private int _childIndex;

            internal Enumerator(SyntaxNode node, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(658, 704, 880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 784, 797);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 815, 830);

                    _count = count;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 848, 865);

                    _childIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(658, 704, 880);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 704, 880);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 704, 880);
                }
            }

            internal void InitializeFrom(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 1081, 1272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1159, 1172);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1190, 1222);

                    _count = CountNodes(f_658_1210_1220(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1240, 1257);

                    _childIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 1081, 1272);

                    Microsoft.CodeAnalysis.GreenNode
                    f_658_1210_1220(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(658, 1210, 1220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 1081, 1272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 1081, 1272);
                }
            }

            [MemberNotNullWhen(true, nameof(_node))]
            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 1575, 1970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1684, 1715);

                    var
                    newIndex = _childIndex + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1733, 1922) || true) && (newIndex < _count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(658, 1733, 1922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1796, 1819);

                        _childIndex = newIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1841, 1869);

                        f_658_1841_1868(_node != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1891, 1903);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(658, 1733, 1922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 1942, 1955);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 1575, 1970);

                    int
                    f_658_1841_1868(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(658, 1841, 1868);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 1575, 1970);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 1575, 1970);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxNodeOrToken Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 2276, 2431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2320, 2350);

                        f_658_2320_2349(_node is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2372, 2412);

                        return ItemInternal(_node, _childIndex);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(658, 2276, 2431);

                        int
                        f_658_2320_2349(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(658, 2320, 2349);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 2211, 2446);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 2211, 2446);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 2596, 2680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2648, 2665);

                    _childIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 2596, 2680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 2596, 2680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 2596, 2680);
                }
            }

            internal bool TryMoveNextAndGetCurrent(out SyntaxNodeOrToken current)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 2696, 3035);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2798, 2927) || true) && (!MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(658, 2798, 2927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2855, 2873);

                        current = default;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2895, 2908);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(658, 2798, 2927);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 2947, 2990);

                    current = ItemInternal(_node, _childIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3008, 3020);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 2696, 3035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 2696, 3035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 2696, 3035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal SyntaxNode? TryMoveNextAndGetCurrentAsNode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 3051, 3450);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3137, 3403) || true) && (MoveNext())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(658, 3137, 3403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3196, 3251);

                            var
                            nodeValue = ItemInternalAsNode(_node, _childIndex)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3273, 3384) || true) && (nodeValue != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(658, 3273, 3384);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3344, 3361);

                                return nodeValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(658, 3273, 3384);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(658, 3137, 3403);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(658, 3137, 3403);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(658, 3137, 3403);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3423, 3435);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 3051, 3450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 3051, 3450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 3051, 3450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(658, 542, 3461);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(658, 542, 3461);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 542, 3461);
            }
        }
        private class EnumeratorImpl : IEnumerator<SyntaxNodeOrToken>
        {
            private Enumerator _enumerator;

            internal EnumeratorImpl(SyntaxNode node, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(658, 3606, 3747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 3690, 3732);

                    _enumerator = f_658_3704_3731(node, count);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(658, 3606, 3747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 3606, 3747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 3606, 3747);
                }
            }

            public SyntaxNodeOrToken Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 4125, 4160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 4131, 4158);

                        return _enumerator.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(658, 4125, 4160);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 4060, 4175);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 4060, 4175);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 4547, 4582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 4553, 4580);

                        return _enumerator.Current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(658, 4547, 4582);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 4488, 4597);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 4488, 4597);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 4952, 5052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 5007, 5037);

                    return _enumerator.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 4952, 5052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 4952, 5052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 4952, 5052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 5238, 5325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(658, 5290, 5310);

                    _enumerator.Reset();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 5238, 5325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 5238, 5325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 5238, 5325);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(658, 5518, 5556);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(658, 5518, 5556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(658, 5518, 5556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 5518, 5556);
                }
            }

            static EnumeratorImpl()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(658, 3473, 5567);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(658, 3473, 5567);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(658, 3473, 5567);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(658, 3473, 5567);

            static Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator
            f_658_3704_3731(Microsoft.CodeAnalysis.SyntaxNode
            node, int
            count)
            {
                var return_v = new Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator(node, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(658, 3704, 3731);
                return return_v;
            }

        }
    }
}
