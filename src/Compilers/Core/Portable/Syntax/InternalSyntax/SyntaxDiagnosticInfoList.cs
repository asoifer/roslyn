// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{

    internal struct SyntaxDiagnosticInfoList
    {

        private readonly GreenNode _node;

        internal SyntaxDiagnosticInfoList(GreenNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(824, 497, 595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 571, 584);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(824, 497, 595);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 497, 595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 497, 595);
            }
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 607, 705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 665, 694);

                return f_824_672_693(_node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(824, 607, 705);

                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator
                f_824_672_693(Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 672, 693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 607, 705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 607, 705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Any(Func<DiagnosticInfo, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 717, 1029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 797, 830);

                var
                enumerator = GetEnumerator()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 844, 989) || true) && (enumerator.MoveNext())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 844, 989);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 906, 974) || true) && (f_824_910_939(predicate, enumerator.Current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 906, 974);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 962, 974);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(824, 906, 974);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 844, 989);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(824, 844, 989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(824, 844, 989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1005, 1018);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(824, 717, 1029);

                bool
                f_824_910_939(System.Func<Microsoft.CodeAnalysis.DiagnosticInfo, bool>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 910, 939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 717, 1029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 717, 1029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public struct Enumerator
        {

            private struct NodeIteration
            {

                internal readonly GreenNode Node;

                internal int DiagnosticIndex;

                internal int SlotIndex;

                internal NodeIteration(GreenNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(824, 1292, 1497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1371, 1388);

                        this.Node = node;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1410, 1430);

                        this.SlotIndex = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1452, 1478);

                        this.DiagnosticIndex = -1;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(824, 1292, 1497);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 1292, 1497);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 1292, 1497);
                    }
                }
                static NodeIteration()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(824, 1090, 1512);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(824, 1090, 1512);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 1090, 1512);
                }
            }

            private NodeIteration[]? _stack;

            private int _count;

            public DiagnosticInfo Current { get; private set; }

            internal Enumerator(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(824, 1676, 2038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1744, 1760);

                    Current = null!;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1778, 1792);

                    _stack = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1810, 1821);

                    _count = 0;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1839, 2023) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(824, 1843, 1883) && f_824_1859_1883(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 1839, 2023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1925, 1955);

                        _stack = new NodeIteration[8];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 1977, 2004);

                        this.PushNodeOrToken(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 1839, 2023);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(824, 1676, 2038);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 1676, 2038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 1676, 2038);
                }
            }

            public bool MoveNext()
            {
                while (_count > 0)
                {
                    var diagIndex = _stack![_count - 1].DiagnosticIndex;
                    var node = _stack[_count - 1].Node;
                    var diags = node.GetDiagnostics();
                    if (diagIndex < diags.Length - 1)
                    {
                        diagIndex++;
                        Current = diags[diagIndex];
                        _stack[_count - 1].DiagnosticIndex = diagIndex;
                        return true;
                    }

                    var slotIndex = _stack[_count - 1].SlotIndex;
tryAgain:
                    if (slotIndex < node.SlotCount - 1)
                    {
                        slotIndex++;
                        var child = node.GetSlot(slotIndex);
                        if (child == null || !child.ContainsDiagnostics)
                        {
                            goto tryAgain;
                        }

                        _stack[_count - 1].SlotIndex = slotIndex;
                        this.PushNodeOrToken(child);
                    }
                    else
                    {
                        this.Pop();
                    }
                }

                return false;
            }

            private void PushNodeOrToken(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 3406, 3694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3483, 3679) || true) && (f_824_3487_3499(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 3483, 3679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3541, 3562);

                        this.PushToken(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 3483, 3679);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 3483, 3679);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3644, 3660);

                        this.Push(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 3483, 3679);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(824, 3406, 3694);

                    bool
                    f_824_3487_3499(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(824, 3487, 3499);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 3406, 3694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 3406, 3694);
                }
            }

            private void PushToken(GreenNode token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 3710, 4176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3782, 3827);

                    var
                    trailing = f_824_3797_3826(token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3845, 3946) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 3845, 3946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3907, 3927);

                        this.Push(trailing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 3845, 3946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 3966, 3983);

                    this.Push(token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4001, 4044);

                    var
                    leading = f_824_4015_4043(token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4062, 4161) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 4062, 4161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4123, 4142);

                        this.Push(leading);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 4062, 4161);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(824, 3710, 4176);

                    Microsoft.CodeAnalysis.GreenNode?
                    f_824_3797_3826(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 3797, 3826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_824_4015_4043(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 4015, 4043);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 3710, 4176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 3710, 4176);
                }
            }

            private void Push(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 4192, 4647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4258, 4295);

                    f_824_4258_4294(_stack is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4313, 4544) || true) && (_count >= f_824_4327_4340(_stack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(824, 4313, 4544);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4382, 4429);

                        var
                        tmp = new NodeIteration[f_824_4410_4423(_stack) * 2]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4451, 4490);

                        f_824_4451_4489(_stack, tmp, f_824_4475_4488(_stack));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4512, 4525);

                        _stack = tmp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(824, 4313, 4544);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4564, 4605);

                    _stack[_count] = f_824_4581_4604(node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4623, 4632);

                    _count++;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(824, 4192, 4647);

                    int
                    f_824_4258_4294(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 4258, 4294);
                        return 0;
                    }


                    int
                    f_824_4327_4340(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(824, 4327, 4340);
                        return return_v;
                    }


                    int
                    f_824_4410_4423(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(824, 4410, 4423);
                        return return_v;
                    }


                    int
                    f_824_4475_4488(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(824, 4475, 4488);
                        return return_v;
                    }


                    int
                    f_824_4451_4489(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration[]
                    sourceArray, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration[]
                    destinationArray, int
                    length)
                    {
                        Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 4451, 4489);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration
                    f_824_4581_4604(Microsoft.CodeAnalysis.GreenNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxDiagnosticInfoList.Enumerator.NodeIteration(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(824, 4581, 4604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 4192, 4647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 4192, 4647);
                }
            }

            private void Pop()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(824, 4663, 4738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(824, 4714, 4723);

                    _count--;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(824, 4663, 4738);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(824, 4663, 4738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 4663, 4738);
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(824, 1041, 4749);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(824, 1041, 4749);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 1041, 4749);
            }

            static bool
            f_824_1859_1883(Microsoft.CodeAnalysis.GreenNode
            this_param)
            {
                var return_v = this_param.ContainsDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(824, 1859, 1883);
                return return_v;
            }

        }
        static SyntaxDiagnosticInfoList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(824, 395, 4756);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(824, 395, 4756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(824, 395, 4756);
        }
    }
}
