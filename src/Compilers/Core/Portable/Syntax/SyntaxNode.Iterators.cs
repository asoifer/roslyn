// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract partial class SyntaxNode
    {
        private IEnumerable<SyntaxNode> DescendantNodesImpl(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren, bool descendIntoTrivia, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 511, 944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 689, 933);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(688, 696, 713) || ((descendIntoTrivia
                && DynAbs.Tracing.TraceSender.Conditional_F2(688, 733, 853)) || DynAbs.Tracing.TraceSender.Conditional_F3(688, 873, 932))) ? f_688_733_853(f_688_733_828(f_688_733_807(this, span, descendIntoChildren, true, includeSelf), e => e.IsNode), e => e.AsNode()!) : f_688_873_932(this, span, descendIntoChildren, includeSelf);
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 511, 944);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_688_733_807(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                descendIntoTrivia, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensImpl(span, descendIntoChildren, descendIntoTrivia, includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 733, 807);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_688_733_828(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNodeOrToken>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 733, 828);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_688_733_853(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.SyntaxNode>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 733, 853);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_688_873_932(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesOnly(span, descendIntoChildren, includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 873, 932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 511, 944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 511, 944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokensImpl(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren, bool descendIntoTrivia, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 956, 1368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 1150, 1357);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(688, 1157, 1174) || ((descendIntoTrivia
                && DynAbs.Tracing.TraceSender.Conditional_F2(688, 1194, 1268)) || DynAbs.Tracing.TraceSender.Conditional_F3(688, 1288, 1356))) ? f_688_1194_1268(this, span, descendIntoChildren, includeSelf) : f_688_1288_1356(this, span, descendIntoChildren, includeSelf);
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 956, 1368);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_688_1194_1268(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensIntoTrivia(span, descendIntoChildren, includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 1194, 1268);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_688_1288_1356(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren, bool
                includeSelf)
                {
                    var return_v = this_param.DescendantNodesAndTokensOnly(span, descendIntoChildren, includeSelf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 1288, 1356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 956, 1368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 956, 1368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxTrivia> DescendantTriviaImpl(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren = null, bool descendIntoTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 1380, 1734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 1558, 1723);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(688, 1565, 1582) || ((descendIntoTrivia
                && DynAbs.Tracing.TraceSender.Conditional_F2(688, 1602, 1655)) || DynAbs.Tracing.TraceSender.Conditional_F3(688, 1675, 1722))) ? f_688_1602_1655(this, span, descendIntoChildren) : f_688_1675_1722(this, span, descendIntoChildren);
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 1380, 1734);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_688_1602_1655(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantTriviaIntoTrivia(span, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 1602, 1655);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_688_1675_1722(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantTriviaOnly(span, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 1675, 1722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 1380, 1734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 1380, 1734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInSpan(in TextSpan span, TextSpan childSpan)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(688, 1746, 2061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 1837, 2050);

                return span.OverlapsWith(childSpan) || (DynAbs.Tracing.TraceSender.Expression_False(688, 1844, 2049) || (childSpan.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(688, 1993, 2048) && span.IntersectsWith(childSpan))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(688, 1746, 2061);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 1746, 2061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 1746, 2061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct ChildSyntaxListEnumeratorStack : IDisposable
        {

            private static readonly ObjectPool<ChildSyntaxList.Enumerator[]> s_stackPool;

            private ChildSyntaxList.Enumerator[]? _stack;

            private int _stackPtr;

            public ChildSyntaxListEnumeratorStack(SyntaxNode startingNode, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(688, 2436, 2982);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2576, 2967) || true) && (descendIntoChildren == null || (DynAbs.Tracing.TraceSender.Expression_False(688, 2580, 2644) || f_688_2611_2644(descendIntoChildren, startingNode)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 2576, 2967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2686, 2718);

                        _stack = f_688_2695_2717(s_stackPool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2740, 2754);

                        _stackPtr = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2776, 2815);

                        _stack[0].InitializeFrom(startingNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 2576, 2967);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 2576, 2967);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2897, 2911);

                        _stack = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2933, 2948);

                        _stackPtr = -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 2576, 2967);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(688, 2436, 2982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 2436, 2982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 2436, 2982);
                }
            }

            public bool IsNotEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 3023, 3053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3029, 3051);

                        return _stackPtr >= 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(688, 3023, 3053);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 2998, 3055);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 2998, 3055);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool TryGetNextInSpan(in TextSpan span, out SyntaxNodeOrToken value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 3071, 3549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3179, 3210);

                    f_688_3179_3209(_stack is object);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3228, 3471) || true) && (_stack[_stackPtr].TryMoveNextAndGetCurrent(out value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 3228, 3471);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3330, 3452) || true) && (f_688_3334_3367(span, value.FullSpan))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 3330, 3452);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3417, 3429);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 3330, 3452);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 3228, 3471);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 3228, 3471);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 3228, 3471);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3491, 3503);

                    _stackPtr--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3521, 3534);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 3071, 3549);

                    int
                    f_688_3179_3209(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 3179, 3209);
                        return 0;
                    }


                    bool
                    f_688_3334_3367(Microsoft.CodeAnalysis.Text.TextSpan
                    span, Microsoft.CodeAnalysis.Text.TextSpan
                    childSpan)
                    {
                        var return_v = IsInSpan(span, childSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 3334, 3367);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 3071, 3549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 3071, 3549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxNode? TryGetNextAsNodeInSpan(in TextSpan span)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 3565, 4094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3657, 3688);

                    f_688_3657_3687(_stack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3706, 3728);

                    SyntaxNode?
                    nodeValue
                    = default(SyntaxNode?);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3746, 4017) || true) && ((nodeValue = _stack[_stackPtr].TryMoveNextAndGetCurrentAsNode()) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 3746, 4017);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3867, 3998) || true) && (f_688_3871_3908(span, f_688_3889_3907(nodeValue)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 3867, 3998);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 3958, 3975);

                                return nodeValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 3867, 3998);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 3746, 4017);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 3746, 4017);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 3746, 4017);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4037, 4049);

                    _stackPtr--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4067, 4079);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 3565, 4094);

                    int
                    f_688_3657_3687(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 3657, 3687);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_688_3889_3907(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.FullSpan;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 3889, 3907);
                        return return_v;
                    }


                    bool
                    f_688_3871_3908(Microsoft.CodeAnalysis.Text.TextSpan
                    span, Microsoft.CodeAnalysis.Text.TextSpan
                    childSpan)
                    {
                        var return_v = IsInSpan(span, childSpan);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 3871, 3908);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 3565, 4094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 3565, 4094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void PushChildren(SyntaxNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 4110, 4490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4184, 4215);

                    f_688_4184_4214(_stack is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4233, 4416) || true) && (++_stackPtr >= f_688_4252_4265(_stack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 4233, 4416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4348, 4397);

                        f_688_4348_4396(ref _stack, checked(_stackPtr * 2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 4233, 4416);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4436, 4475);

                    _stack[_stackPtr].InitializeFrom(node);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 4110, 4490);

                    int
                    f_688_4184_4214(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 4184, 4214);
                        return 0;
                    }


                    int
                    f_688_4252_4265(Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 4252, 4265);
                        return return_v;
                    }


                    int
                    f_688_4348_4396(ref Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
                    array, int
                    newSize)
                    {
                        Array.Resize(ref array, newSize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 4348, 4396);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 4110, 4490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 4110, 4490);
                }
            }

            public void PushChildren(SyntaxNode node, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 4506, 4780);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4625, 4765) || true) && (descendIntoChildren == null || (DynAbs.Tracing.TraceSender.Expression_False(688, 4629, 4685) || f_688_4660_4685(descendIntoChildren, node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 4625, 4765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4727, 4746);

                        PushChildren(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 4625, 4765);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 4506, 4780);

                    bool
                    f_688_4660_4685(System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 4660, 4685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 4506, 4780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 4506, 4780);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 4796, 5104);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4919, 5089) || true) && (f_688_4923_4937_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_stack, 688, 4923, 4937)?.Length) < 256)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 4919, 5089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 4985, 5023);

                        f_688_4985_5022(_stack, 0, f_688_5008_5021(_stack));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5045, 5070);

                        f_688_5045_5069(s_stackPool, _stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 4919, 5089);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 4796, 5104);

                    int?
                    f_688_4923_4937_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 4923, 4937);
                        return return_v;
                    }


                    int
                    f_688_5008_5021(Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 5008, 5021);
                        return return_v;
                    }


                    int
                    f_688_4985_5022(Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
                    array, int
                    index, int
                    length)
                    {
                        Array.Clear((System.Array)array, index, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 4985, 5022);
                        return 0;
                    }


                    int
                    f_688_5045_5069(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]>
                    this_param, Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 5045, 5069);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 4796, 5104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 4796, 5104);
                }
            }
            static ChildSyntaxListEnumeratorStack()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(688, 2073, 5115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 2222, 2322);
                s_stackPool = f_688_2236_2322(() => new ChildSyntaxList.Enumerator[16]); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(688, 2073, 5115);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 2073, 5115);
            }

            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]>
            f_688_2236_2322(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]>.Factory
            factory)
            {
                var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]>(factory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 2236, 2322);
                return return_v;
            }


            static bool
            f_688_2611_2644(System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            arg)
            {
                var return_v = this_param.Invoke(arg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 2611, 2644);
                return return_v;
            }


            static Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]
            f_688_2695_2717(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.ChildSyntaxList.Enumerator[]>
            this_param)
            {
                var return_v = this_param.Allocate();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 2695, 2717);
                return return_v;
            }

        }

        private struct TriviaListEnumeratorStack : IDisposable
        {

            private static readonly ObjectPool<SyntaxTriviaList.Enumerator[]> s_stackPool;

            private SyntaxTriviaList.Enumerator[] _stack;

            private int _stackPtr;

            public bool TryGetNext(out SyntaxTrivia value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 5488, 5775);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5567, 5697) || true) && (_stack[_stackPtr].TryMoveNextAndGetCurrent(out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 5567, 5697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5666, 5678);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 5567, 5697);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5717, 5729);

                    _stackPtr--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5747, 5760);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 5488, 5775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 5488, 5775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 5488, 5775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void PushLeadingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 5791, 5971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5875, 5882);

                    Grow();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5900, 5956);

                    _stack[_stackPtr].InitializeFromLeadingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 5791, 5971);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 5791, 5971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 5791, 5971);
                }
            }

            public void PushTrailingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 5987, 6169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6072, 6079);

                    Grow();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6097, 6154);

                    _stack[_stackPtr].InitializeFromTrailingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 5987, 6169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 5987, 6169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 5987, 6169);
                }
            }

            private void Grow()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 6185, 6603);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6237, 6385) || true) && (_stack == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 6237, 6385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6297, 6329);

                        _stack = f_688_6306_6328(s_stackPool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6351, 6366);

                        _stackPtr = -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 6237, 6385);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6405, 6588) || true) && (++_stackPtr >= f_688_6424_6437(_stack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 6405, 6588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6520, 6569);

                        f_688_6520_6568(ref _stack, checked(_stackPtr * 2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 6405, 6588);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 6185, 6603);

                    Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    f_688_6306_6328(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 6306, 6328);
                        return return_v;
                    }


                    int
                    f_688_6424_6437(Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 6424, 6437);
                        return return_v;
                    }


                    int
                    f_688_6520_6568(ref Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    array, int
                    newSize)
                    {
                        Array.Resize(ref array, newSize);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 6520, 6568);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 6185, 6603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 6185, 6603);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 6619, 6927);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6742, 6912) || true) && (f_688_6746_6760_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_stack, 688, 6746, 6760)?.Length) < 256)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 6742, 6912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6808, 6846);

                        f_688_6808_6845(_stack, 0, f_688_6831_6844(_stack));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 6868, 6893);

                        f_688_6868_6892(s_stackPool, _stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 6742, 6912);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 6619, 6927);

                    int?
                    f_688_6746_6760_M(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 6746, 6760);
                        return return_v;
                    }


                    int
                    f_688_6831_6844(Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 6831, 6844);
                        return return_v;
                    }


                    int
                    f_688_6808_6845(Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    array, int
                    index, int
                    length)
                    {
                        Array.Clear((System.Array)array, index, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 6808, 6845);
                        return 0;
                    }


                    int
                    f_688_6868_6892(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]>
                    this_param, Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]
                    obj)
                    {
                        this_param.Free(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 6868, 6892);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 6619, 6927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 6619, 6927);
                }
            }
            static TriviaListEnumeratorStack()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(688, 5127, 6938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 5272, 5374);
                s_stackPool = f_688_5286_5374(() => new SyntaxTriviaList.Enumerator[16]); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(688, 5127, 6938);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 5127, 6938);
            }

            static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]>
            f_688_5286_5374(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]>.Factory
            factory)
            {
                var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator[]>(factory);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 5286, 5374);
                return return_v;
            }

        }

        private struct TwoEnumeratorListStack : IDisposable
        {
            public enum Which : byte
            {
                Node,
                Trivia
            }

            private ChildSyntaxListEnumeratorStack _nodeStack;

            private TriviaListEnumeratorStack _triviaStack;

            private readonly ArrayBuilder<Which>? _discriminatorStack;

            public TwoEnumeratorListStack(SyntaxNode startingNode, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(688, 7342, 7965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7474, 7557);

                    _nodeStack = f_688_7487_7556(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7575, 7622);

                    _triviaStack = f_688_7590_7621();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7640, 7950) || true) && (_nodeStack.IsNotEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 7640, 7950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7707, 7763);

                        _discriminatorStack = f_688_7729_7762();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7785, 7822);

                        f_688_7785_7821(_discriminatorStack, Which.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 7640, 7950);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 7640, 7950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 7904, 7931);

                        _discriminatorStack = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 7640, 7950);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(688, 7342, 7965);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 7342, 7965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 7342, 7965);
                }
            }

            public bool IsNotEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 8006, 8052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8012, 8050);

                        return f_688_8019_8045_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_discriminatorStack, 688, 8019, 8045)?.Count) > 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(688, 8006, 8052);

                        int?
                        f_688_8019_8045_M(int?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 8019, 8045);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 7981, 8054);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 7981, 8054);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Which PeekNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 8070, 8237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8126, 8170);

                    f_688_8126_8169(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8188, 8222);

                    return f_688_8195_8221(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 8070, 8237);

                    int
                    f_688_8126_8169(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8126, 8169);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    f_688_8195_8221(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Peek<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8195, 8221);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 8070, 8237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 8070, 8237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetNextInSpan(in TextSpan span, out SyntaxNodeOrToken value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 8253, 8639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8361, 8485) || true) && (_nodeStack.TryGetNextInSpan(in span, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 8361, 8485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8454, 8466);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 8361, 8485);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8505, 8549);

                    f_688_8505_8548(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8567, 8593);

                    f_688_8567_8592(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8611, 8624);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 8253, 8639);

                    int
                    f_688_8505_8548(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8505, 8548);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    f_688_8567_8592(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8567, 8592);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 8253, 8639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 8253, 8639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetNext(out SyntaxTrivia value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 8655, 8999);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8734, 8845) || true) && (_triviaStack.TryGetNext(out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 8734, 8845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8814, 8826);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 8734, 8845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8865, 8909);

                    f_688_8865_8908(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8927, 8953);

                    f_688_8927_8952(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 8971, 8984);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 8655, 8999);

                    int
                    f_688_8865_8908(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8865, 8908);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    f_688_8927_8952(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 8927, 8952);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 8655, 8999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 8655, 8999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void PushChildren(SyntaxNode node, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 9015, 9425);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9134, 9410) || true) && (descendIntoChildren == null || (DynAbs.Tracing.TraceSender.Expression_False(688, 9138, 9194) || f_688_9169_9194(descendIntoChildren, node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 9134, 9410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9236, 9280);

                        f_688_9236_9279(_discriminatorStack is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9302, 9332);

                        _nodeStack.PushChildren(node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9354, 9391);

                        f_688_9354_9390(_discriminatorStack, Which.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 9134, 9410);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 9015, 9425);

                    bool
                    f_688_9169_9194(System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9169, 9194);
                        return return_v;
                    }


                    int
                    f_688_9236_9279(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9236, 9279);
                        return 0;
                    }


                    int
                    f_688_9354_9390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9354, 9390);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 9015, 9425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 9015, 9425);
                }
            }

            public void PushLeadingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 9441, 9700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9525, 9569);

                    f_688_9525_9568(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9587, 9628);

                    _triviaStack.PushLeadingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9646, 9685);

                    f_688_9646_9684(_discriminatorStack, Which.Trivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 9441, 9700);

                    int
                    f_688_9525_9568(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9525, 9568);
                        return 0;
                    }


                    int
                    f_688_9646_9684(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9646, 9684);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 9441, 9700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 9441, 9700);
                }
            }

            public void PushTrailingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 9716, 9977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9801, 9845);

                    f_688_9801_9844(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9863, 9905);

                    _triviaStack.PushTrailingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 9923, 9962);

                    f_688_9923_9961(_discriminatorStack, Which.Trivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 9716, 9977);

                    int
                    f_688_9801_9844(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9801, 9844);
                        return 0;
                    }


                    int
                    f_688_9923_9961(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 9923, 9961);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 9716, 9977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 9716, 9977);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 9993, 10170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10047, 10068);

                    _nodeStack.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10086, 10109);

                    _triviaStack.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10127, 10155);

                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_discriminatorStack, 688, 10127, 10154)?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 10147, 10154);
                    
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 9993, 10170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 9993, 10170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 9993, 10170);
                }
            }
            static TwoEnumeratorListStack()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(688, 6950, 10181);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(688, 6950, 10181);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 6950, 10181);
            }

            static Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack
            f_688_7487_7556(Microsoft.CodeAnalysis.SyntaxNode
            startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
            descendIntoChildren)
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack(startingNode, descendIntoChildren);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 7487, 7556);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode.TriviaListEnumeratorStack
            f_688_7590_7621()
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxNode.TriviaListEnumeratorStack();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 7590, 7621);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
            f_688_7729_7762()
            {
                var return_v = ArrayBuilder<Which>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 7729, 7762);
                return return_v;
            }


            static int
            f_688_7785_7821(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>
            builder, Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which
            e)
            {
                builder.Push<Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack.Which>(e);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 7785, 7821);
                return 0;
            }

        }

        private struct ThreeEnumeratorListStack : IDisposable
        {
            public enum Which : byte
            {
                Node,
                Trivia,
                Token
            }

            private ChildSyntaxListEnumeratorStack _nodeStack;

            private TriviaListEnumeratorStack _triviaStack;

            private readonly ArrayBuilder<SyntaxNodeOrToken>? _tokenStack;

            private readonly ArrayBuilder<Which>? _discriminatorStack;

            public ThreeEnumeratorListStack(SyntaxNode startingNode, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(688, 10687, 11435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10821, 10904);

                    _nodeStack = f_688_10834_10903(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10922, 10969);

                    _triviaStack = f_688_10937_10968();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 10987, 11420) || true) && (_nodeStack.IsNotEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 10987, 11420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11054, 11114);

                        _tokenStack = f_688_11068_11113();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11136, 11192);

                        _discriminatorStack = f_688_11158_11191();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11214, 11251);

                        f_688_11214_11250(_discriminatorStack, Which.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 10987, 11420);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 10987, 11420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11333, 11352);

                        _tokenStack = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11374, 11401);

                        _discriminatorStack = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 10987, 11420);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(688, 10687, 11435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 10687, 11435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 10687, 11435);
                }
            }

            public bool IsNotEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 11476, 11522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11482, 11520);

                        return f_688_11489_11515_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_discriminatorStack, 688, 11489, 11515)?.Count) > 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(688, 11476, 11522);

                        int?
                        f_688_11489_11515_M(int?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 11489, 11515);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 11451, 11524);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 11451, 11524);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Which PeekNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 11540, 11707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11596, 11640);

                    f_688_11596_11639(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11658, 11692);

                    return f_688_11665_11691(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 11540, 11707);

                    int
                    f_688_11596_11639(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11596, 11639);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    f_688_11665_11691(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Peek<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11665, 11691);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 11540, 11707);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 11540, 11707);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetNextInSpan(in TextSpan span, out SyntaxNodeOrToken value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 11723, 12109);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11831, 11955) || true) && (_nodeStack.TryGetNextInSpan(in span, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 11831, 11955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11924, 11936);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 11831, 11955);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 11975, 12019);

                    f_688_11975_12018(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12037, 12063);

                    f_688_12037_12062(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12081, 12094);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 11723, 12109);

                    int
                    f_688_11975_12018(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11975, 12018);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    f_688_12037_12062(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12037, 12062);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 11723, 12109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 11723, 12109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetNext(out SyntaxTrivia value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 12125, 12469);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12204, 12315) || true) && (_triviaStack.TryGetNext(out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 12204, 12315);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12284, 12296);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 12204, 12315);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12335, 12379);

                    f_688_12335_12378(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12397, 12423);

                    f_688_12397_12422(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12441, 12454);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 12125, 12469);

                    int
                    f_688_12335_12378(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12335, 12378);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    f_688_12397_12422(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12397, 12422);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 12125, 12469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 12125, 12469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxNodeOrToken PopToken()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 12485, 12753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12553, 12597);

                    f_688_12553_12596(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12615, 12651);

                    f_688_12615_12650(_tokenStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12669, 12695);

                    f_688_12669_12694(_discriminatorStack);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12713, 12738);

                    return f_688_12720_12737(_tokenStack);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 12485, 12753);

                    int
                    f_688_12553_12596(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12553, 12596);
                        return 0;
                    }


                    int
                    f_688_12615_12650(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12615, 12650);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    f_688_12669_12694(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12669, 12694);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNodeOrToken
                    f_688_12720_12737(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                    builder)
                    {
                        var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12720, 12737);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 12485, 12753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 12485, 12753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void PushChildren(SyntaxNode node, Func<SyntaxNode, bool>? descendIntoChildren)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 12769, 13179);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12888, 13164) || true) && (descendIntoChildren == null || (DynAbs.Tracing.TraceSender.Expression_False(688, 12892, 12948) || f_688_12923_12948(descendIntoChildren, node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 12888, 13164);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 12990, 13034);

                        f_688_12990_13033(_discriminatorStack is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13056, 13086);

                        _nodeStack.PushChildren(node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13108, 13145);

                        f_688_13108_13144(_discriminatorStack, Which.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 12888, 13164);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 12769, 13179);

                    bool
                    f_688_12923_12948(System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12923, 12948);
                        return return_v;
                    }


                    int
                    f_688_12990_13033(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 12990, 13033);
                        return 0;
                    }


                    int
                    f_688_13108_13144(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13108, 13144);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 12769, 13179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 12769, 13179);
                }
            }

            public void PushLeadingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 13195, 13454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13279, 13323);

                    f_688_13279_13322(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13341, 13382);

                    _triviaStack.PushLeadingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13400, 13439);

                    f_688_13400_13438(_discriminatorStack, Which.Trivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 13195, 13454);

                    int
                    f_688_13279_13322(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13279, 13322);
                        return 0;
                    }


                    int
                    f_688_13400_13438(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13400, 13438);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 13195, 13454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 13195, 13454);
                }
            }

            public void PushTrailingTrivia(in SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 13470, 13731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13555, 13599);

                    f_688_13555_13598(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13617, 13659);

                    _triviaStack.PushTrailingTrivia(in token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13677, 13716);

                    f_688_13677_13715(_discriminatorStack, Which.Trivia);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 13470, 13731);

                    int
                    f_688_13555_13598(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13555, 13598);
                        return 0;
                    }


                    int
                    f_688_13677_13715(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13677, 13715);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 13470, 13731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 13470, 13731);
                }
            }

            public void PushToken(in SyntaxNodeOrToken value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 13747, 14040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13829, 13873);

                    f_688_13829_13872(_discriminatorStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13891, 13927);

                    f_688_13891_13926(_tokenStack is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13945, 13969);

                    _tokenStack.Push(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 13987, 14025);

                    f_688_13987_14024(_discriminatorStack, Which.Token);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 13747, 14040);

                    int
                    f_688_13829_13872(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13829, 13872);
                        return 0;
                    }


                    int
                    f_688_13891_13926(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13891, 13926);
                        return 0;
                    }


                    int
                    f_688_13987_14024(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
                    builder, Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
                    e)
                    {
                        builder.Push<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 13987, 14024);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 13747, 14040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 13747, 14040);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 14056, 14271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14110, 14131);

                    _nodeStack.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14149, 14172);

                    _triviaStack.Dispose();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14190, 14210);

                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_tokenStack, 688, 14190, 14209)?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 14202, 14209); 

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14228, 14256);

                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_discriminatorStack, 688, 14228, 14255)?.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 14248, 14255);

                    DynAbs.Tracing.TraceSender.TraceExitMethod(688, 14056, 14271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 14056, 14271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 14056, 14271);
                }
            }
            static ThreeEnumeratorListStack()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(688, 10193, 14282);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(688, 10193, 14282);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 10193, 14282);
            }

            static Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack
            f_688_10834_10903(Microsoft.CodeAnalysis.SyntaxNode
            startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
            descendIntoChildren)
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack(startingNode, descendIntoChildren);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 10834, 10903);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode.TriviaListEnumeratorStack
            f_688_10937_10968()
            {
                var return_v = new Microsoft.CodeAnalysis.SyntaxNode.TriviaListEnumeratorStack();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 10937, 10968);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
            f_688_11068_11113()
            {
                var return_v = ArrayBuilder<SyntaxNodeOrToken>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11068, 11113);
                return return_v;
            }


            static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
            f_688_11158_11191()
            {
                var return_v = ArrayBuilder<Which>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11158, 11191);
                return return_v;
            }


            static int
            f_688_11214_11250(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>
            builder, Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which
            e)
            {
                builder.Push<Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack.Which>(e);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 11214, 11250);
                return 0;
            }

        }

        private IEnumerable<SyntaxNode> DescendantNodesOnly(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 14294, 15338);

                var listYield = new List<SyntaxNode>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14448, 14566) || true) && (includeSelf && (DynAbs.Tracing.TraceSender.Expression_True(688, 14452, 14499) && f_688_14467_14499(span, f_688_14485_14498(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 14448, 14566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14533, 14551);

                    listYield.Add(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 14448, 14566);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14582, 15327);
                using (var
                stack = f_688_14601_14662(this, descendIntoChildren)
                )
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14696, 15312) || true) && (stack.IsNotEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 14696, 15312);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14761, 14823);

                            SyntaxNode?
                            nodeValue = stack.TryGetNextAsNodeInSpan(in span)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 14845, 15293) || true) && (nodeValue != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 14845, 15293);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15168, 15219);

                                stack.PushChildren(nodeValue, descendIntoChildren);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15247, 15270);

                                listYield.Add(nodeValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 14845, 15293);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 14696, 15312);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 14696, 15312);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 14696, 15312);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(688, 14582, 15327);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 14294, 15338);

                return listYield;

                Microsoft.CodeAnalysis.Text.TextSpan
                f_688_14485_14498(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 14485, 14498);
                    return return_v;
                }


                bool
                f_688_14467_14499(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 14467, 14499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack
                f_688_14601_14662(Microsoft.CodeAnalysis.SyntaxNode
                startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 14601, 14662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 14294, 15338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 14294, 15338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokensOnly(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 15350, 16552);

                var listYield = new List<SyntaxNodeOrToken>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15520, 15638) || true) && (includeSelf && (DynAbs.Tracing.TraceSender.Expression_True(688, 15524, 15571) && f_688_15539_15571(span, f_688_15557_15570(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 15520, 15638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15605, 15623);

                    listYield.Add(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 15520, 15638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15654, 16541);
                using (var
                stack = f_688_15673_15734(this, descendIntoChildren)
                )
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15768, 16526) || true) && (stack.IsNotEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 15768, 16526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15833, 15857);

                            SyntaxNodeOrToken
                            value
                            = default(SyntaxNodeOrToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 15879, 16507) || true) && (stack.TryGetNextInSpan(in span, out value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 15879, 16507);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16223, 16254);

                                var
                                nodeValue = value.AsNode()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16280, 16437) || true) && (nodeValue != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 16280, 16437);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16359, 16410);

                                    stack.PushChildren(nodeValue, descendIntoChildren);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 16280, 16437);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16465, 16484);

                                listYield.Add(value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 15879, 16507);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 15768, 16526);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 15768, 16526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 15768, 16526);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(688, 15654, 16541);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 15350, 16552);

                return listYield;

                Microsoft.CodeAnalysis.Text.TextSpan
                f_688_15557_15570(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 15557, 15570);
                    return return_v;
                }


                bool
                f_688_15539_15571(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 15539, 15571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack
                f_688_15673_15734(Microsoft.CodeAnalysis.SyntaxNode
                startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 15673, 15734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 15350, 16552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 15350, 16552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxNodeOrToken> DescendantNodesAndTokensIntoTrivia(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren, bool includeSelf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 16564, 21177);
                Microsoft.CodeAnalysis.SyntaxNode? structureNode = default(Microsoft.CodeAnalysis.SyntaxNode?);

                var listYield = new List<SyntaxNodeOrToken>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16740, 16858) || true) && (includeSelf && (DynAbs.Tracing.TraceSender.Expression_True(688, 16744, 16791) && f_688_16759_16791(span, f_688_16777_16790(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 16740, 16858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16825, 16843);

                    listYield.Add(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 16740, 16858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16874, 21166);
                using (var
                stack = f_688_16893_16948(this, descendIntoChildren)
                )
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 16982, 21151) || true) && (stack.IsNotEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 16982, 21151);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17047, 21132);

                            switch (stack.PeekNext())
                            {

                                case ThreeEnumeratorListStack.Which.Node:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17047, 21132);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17192, 17216);

                                    SyntaxNodeOrToken
                                    value
                                    = default(SyntaxNodeOrToken);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17246, 19796) || true) && (stack.TryGetNextInSpan(in span, out value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17246, 19796);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17670, 19412) || true) && (value.IsNode)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17670, 19412);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17858, 17915);

                                            stack.PushChildren(value.AsNode()!, descendIntoChildren);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17670, 19412);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17670, 19412);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 17989, 19412) || true) && (value.IsToken)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17989, 19412);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18080, 18108);

                                                var
                                                token = value.AsToken()
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18248, 19287) || true) && (token.HasStructuredTrivia)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 18248, 19287);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18430, 18625) || true) && (token.HasTrailingTrivia)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 18430, 18625);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18547, 18582);

                                                        stack.PushTrailingTrivia(in token);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 18430, 18625);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18761, 18787);

                                                    stack.PushToken(in value);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 18902, 19095) || true) && (token.HasLeadingTrivia)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 18902, 19095);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 19018, 19052);

                                                        stack.PushLeadingTrivia(in token);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 18902, 19095);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 19242, 19248);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 18248, 19287);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17989, 19412);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17670, 19412);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 19746, 19765);

                                        listYield.Add(value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17246, 19796);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 19828, 19834);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17047, 21132);

                                case ThreeEnumeratorListStack.Which.Trivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17047, 21132);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 20018, 20038);

                                    SyntaxTrivia
                                    trivia
                                    = default(SyntaxTrivia);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 20068, 20907) || true) && (stack.TryGetNext(out trivia))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 20068, 20907);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 20166, 20876) || true) && (trivia.TryGetStructure(out structureNode
                                        ) && (DynAbs.Tracing.TraceSender.Expression_True(688, 20170, 20253) && f_688_20219_20253(span, trivia.FullSpan)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 20166, 20876);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 20719, 20774);

                                            stack.PushChildren(structureNode, descendIntoChildren);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 20814, 20841);

                                            listYield.Add(structureNode);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 20166, 20876);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 20068, 20907);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 20937, 20943);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17047, 21132);

                                case ThreeEnumeratorListStack.Which.Token:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 17047, 21132);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21043, 21073);

                                    listYield.Add(stack.PopToken());
                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 21103, 21109);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 17047, 21132);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 16982, 21151);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 16982, 21151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 16982, 21151);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(688, 16874, 21166);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 16564, 21177);

                return listYield;

                Microsoft.CodeAnalysis.Text.TextSpan
                f_688_16777_16790(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FullSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(688, 16777, 16790);
                    return return_v;
                }


                bool
                f_688_16759_16791(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 16759, 16791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack
                f_688_16893_16948(Microsoft.CodeAnalysis.SyntaxNode
                startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ThreeEnumeratorListStack(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 16893, 16948);
                    return return_v;
                }


                bool
                f_688_20219_20253(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 20219, 20253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 16564, 21177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 16564, 21177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxTrivia> DescendantTriviaOnly(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 21189, 22726);
                Microsoft.CodeAnalysis.SyntaxNode? nodeValue = default(Microsoft.CodeAnalysis.SyntaxNode?);

                var listYield = new List<SyntaxTrivia>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21328, 22715);
                using (var
                stack = f_688_21347_21408(this, descendIntoChildren)
                )
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21442, 22700) || true) && (stack.IsNotEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21442, 22700);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21507, 21531);

                            SyntaxNodeOrToken
                            value
                            = default(SyntaxNodeOrToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21553, 22681) || true) && (stack.TryGetNextInSpan(in span, out value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21553, 22681);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21649, 22658) || true) && (value.AsNode(out nodeValue
                                ))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21649, 22658);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21742, 21793);

                                    stack.PushChildren(nodeValue, descendIntoChildren);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21649, 22658);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21649, 22658);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21851, 22658) || true) && (value.IsToken)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21851, 22658);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21926, 21954);

                                        var
                                        token = value.AsToken()
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 21986, 22292);
                                            foreach (var trivia in f_688_22009_22028_I(token.LeadingTrivia))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 21986, 22292);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22094, 22261) || true) && (f_688_22098_22132(span, trivia.FullSpan))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 22094, 22261);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22206, 22226);

                                                    listYield.Add(trivia);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 22094, 22261);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21986, 22292);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 1, 307);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(688, 1, 307);
                                        }
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22324, 22631);
                                            foreach (var trivia in f_688_22347_22367_I(token.TrailingTrivia))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 22324, 22631);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22433, 22600) || true) && (f_688_22437_22471(span, trivia.FullSpan))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 22433, 22600);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22545, 22565);

                                                    listYield.Add(trivia);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 22433, 22600);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 22324, 22631);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 1, 308);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(688, 1, 308);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21851, 22658);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21649, 22658);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21553, 22681);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 21442, 22700);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 21442, 22700);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 21442, 22700);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(688, 21328, 22715);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 21189, 22726);

                return listYield;

                Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack
                f_688_21347_21408(Microsoft.CodeAnalysis.SyntaxNode
                startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNode.ChildSyntaxListEnumeratorStack(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 21347, 21408);
                    return return_v;
                }


                bool
                f_688_22098_22132(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 22098, 22132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_688_22009_22028_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 22009, 22028);
                    return return_v;
                }


                bool
                f_688_22437_22471(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 22437, 22471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_688_22347_22367_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 22347, 22367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 21189, 22726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 21189, 22726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<SyntaxTrivia> DescendantTriviaIntoTrivia(TextSpan span, Func<SyntaxNode, bool>? descendIntoChildren)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(688, 22738, 25420);
                Microsoft.CodeAnalysis.SyntaxNode? nodeValue = default(Microsoft.CodeAnalysis.SyntaxNode?);
                Microsoft.CodeAnalysis.SyntaxNode? structureNode = default(Microsoft.CodeAnalysis.SyntaxNode?);

                var listYield = new List<SyntaxTrivia>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22883, 25409);
                using (var
                stack = f_688_22902_22955(this, descendIntoChildren)
                )
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 22989, 25394) || true) && (stack.IsNotEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 22989, 25394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23054, 25375);

                            switch (stack.PeekNext())
                            {

                                case TwoEnumeratorListStack.Which.Node:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23054, 25375);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23197, 23221);

                                    SyntaxNodeOrToken
                                    value
                                    = default(SyntaxNodeOrToken);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23251, 24226) || true) && (stack.TryGetNextInSpan(in span, out value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23251, 24226);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23363, 24195) || true) && (value.AsNode(out nodeValue
                                        ))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23363, 24195);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23472, 23523);

                                            stack.PushChildren(nodeValue, descendIntoChildren);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23363, 24195);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23363, 24195);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23597, 24195) || true) && (value.IsToken)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23597, 24195);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23688, 23716);

                                                var
                                                token = value.AsToken()
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23756, 23939) || true) && (token.HasTrailingTrivia)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23756, 23939);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23865, 23900);

                                                    stack.PushTrailingTrivia(in token);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23756, 23939);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 23979, 24160) || true) && (token.HasLeadingTrivia)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23979, 24160);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 24087, 24121);

                                                    stack.PushLeadingTrivia(in token);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23979, 24160);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23597, 24195);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23363, 24195);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23251, 24226);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 24258, 24264);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23054, 25375);

                                case TwoEnumeratorListStack.Which.Trivia:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 23054, 25375);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 24446, 24466);

                                    SyntaxTrivia
                                    trivia
                                    = default(SyntaxTrivia);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 24496, 25314) || true) && (stack.TryGetNext(out trivia))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 24496, 25314);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 24867, 25080) || true) && (trivia.TryGetStructure(out structureNode
                                        ))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 24867, 25080);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 24990, 25045);

                                            stack.PushChildren(structureNode, descendIntoChildren);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 24867, 25080);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 25116, 25283) || true) && (f_688_25120_25154(span, trivia.FullSpan))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(688, 25116, 25283);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(688, 25228, 25248);

                                            listYield.Add(trivia);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 25116, 25283);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(688, 24496, 25314);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(688, 25346, 25352);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(688, 23054, 25375);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(688, 22989, 25394);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(688, 22989, 25394);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(688, 22989, 25394);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(688, 22883, 25409);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(688, 22738, 25420);

                return listYield;

                Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack
                f_688_22902_22955(Microsoft.CodeAnalysis.SyntaxNode
                startingNode, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNode.TwoEnumeratorListStack(startingNode, descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 22902, 22955);
                    return return_v;
                }


                bool
                f_688_25120_25154(Microsoft.CodeAnalysis.Text.TextSpan
                span, Microsoft.CodeAnalysis.Text.TextSpan
                childSpan)
                {
                    var return_v = IsInSpan(span, childSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(688, 25120, 25154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(688, 22738, 25420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(688, 22738, 25420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
