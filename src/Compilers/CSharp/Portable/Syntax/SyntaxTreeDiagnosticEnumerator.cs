// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct SyntaxTreeDiagnosticEnumerator
    {

        private readonly SyntaxTree? _syntaxTree;

        private NodeIterationStack _stack;

        private Diagnostic? _current;

        private int _position;

        private const int
        DefaultStackCapacity = 8
        ;

        internal SyntaxTreeDiagnosticEnumerator(SyntaxTree syntaxTree, GreenNode? node, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10812, 704, 1268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 822, 841);

                _syntaxTree = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 855, 871);

                _current = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 885, 906);

                _position = position;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 920, 1257) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10812, 924, 964) && f_10812_940_964(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 920, 1257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 998, 1023);

                    _syntaxTree = syntaxTree;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 1041, 1095);

                    _stack = f_10812_1050_1094(DefaultStackCapacity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 1113, 1142);

                    _stack.PushNodeOrToken(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 920, 1257);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 920, 1257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 1208, 1242);

                    _stack = f_10812_1217_1241();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 920, 1257);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10812, 704, 1268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 704, 1268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 704, 1268);
            }
        }

        /// <summary>
        /// Moves the enumerator to the next diagnostic instance in the diagnostic list.
        /// </summary>
        /// <returns>Returns true if enumerator moved to the next diagnostic, false if the
        /// enumerator was at the end of the diagnostic list.</returns>
        public bool MoveNext()
        {
            while (_stack.Any())
            {
                var diagIndex = _stack.Top.DiagnosticIndex;
                var node = _stack.Top.Node;
                var diags = node.GetDiagnostics();
                if (diagIndex < diags.Length - 1)
                {
                    diagIndex++;
                    var sdi = (SyntaxDiagnosticInfo)diags[diagIndex];

                    //for tokens, we've already seen leading trivia on the stack, so we have to roll back
                    //for nodes, we have yet to see the leading trivia
                    int leadingWidthAlreadyCounted = node.IsToken ? node.GetLeadingTriviaWidth() : 0;

                    // don't produce locations outside of tree span
                    Debug.Assert(_syntaxTree is object);
                    var length = _syntaxTree.GetRoot().FullSpan.Length;
                    var spanStart = Math.Min(_position - leadingWidthAlreadyCounted + sdi.Offset, length);
                    var spanWidth = Math.Min(spanStart + sdi.Width, length) - spanStart;

                    _current = new CSDiagnostic(sdi, new SourceLocation(_syntaxTree, new TextSpan(spanStart, spanWidth)));

                    _stack.UpdateDiagnosticIndexForStackTop(diagIndex);
                    return true;
                }

                var slotIndex = _stack.Top.SlotIndex;
tryAgain:
                if (slotIndex < node.SlotCount - 1)
                {
                    slotIndex++;
                    var child = node.GetSlot(slotIndex);
                    if (child == null)
                    {
                        goto tryAgain;
                    }

                    if (!child.ContainsDiagnostics)
                    {
                        _position += child.FullWidth;
                        goto tryAgain;
                    }

                    _stack.UpdateSlotIndexForStackTop(slotIndex);
                    _stack.PushNodeOrToken(child);
                }
                else
                {
                    if (node.SlotCount == 0)
                    {
                        _position += node.Width;
                    }

                    _stack.Pop();
                }
            }

            return false;
        }

        public Diagnostic Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 4104, 4162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4110, 4143);

                    f_10812_4110_4142(_current is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4144, 4160);

                    return _current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 4104, 4162);

                    int
                    f_10812_4110_4142(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 4110, 4142);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 4054, 4173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4054, 4173);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private struct NodeIteration
        {

            internal readonly GreenNode Node;

            internal int DiagnosticIndex;

            internal int SlotIndex;

            internal NodeIteration(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10812, 4367, 4552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4438, 4455);

                    this.Node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4473, 4493);

                    this.SlotIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4511, 4537);

                    this.DiagnosticIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10812, 4367, 4552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 4367, 4552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4367, 4552);
                }
            }
            static NodeIteration()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10812, 4185, 4563);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10812, 4185, 4563);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4185, 4563);
            }
        }

        private struct NodeIterationStack
        {

            private NodeIteration[] _stack;

            private int _count;

            internal NodeIterationStack(int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10812, 4713, 4913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4787, 4814);

                    f_10812_4787_4813(capacity > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4832, 4869);

                    _stack = new NodeIteration[capacity];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 4887, 4898);

                    _count = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10812, 4713, 4913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 4713, 4913);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4713, 4913);
                }
            }

            internal void PushNodeOrToken(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 4929, 5282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5007, 5061);

                    var
                    token = node as Syntax.InternalSyntax.SyntaxToken
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5079, 5267) || true) && (token != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 5079, 5267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5138, 5155);

                        PushToken(token);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 5079, 5267);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 5079, 5267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5237, 5248);

                        Push(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 5079, 5267);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 4929, 5282);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 4929, 5282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4929, 5282);
                }
            }

            private void PushToken(Syntax.InternalSyntax.SyntaxToken token)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 5298, 5780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5394, 5435);

                    var
                    trailing = f_10812_5409_5434(token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5453, 5554) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 5453, 5554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5515, 5535);

                        this.Push(trailing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 5453, 5554);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5574, 5591);

                    this.Push(token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5609, 5648);

                    var
                    leading = f_10812_5623_5647(token)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5666, 5765) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 5666, 5765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5727, 5746);

                        this.Push(leading);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 5666, 5765);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 5298, 5780);

                    Microsoft.CodeAnalysis.GreenNode
                    f_10812_5409_5434(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 5409, 5434);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_10812_5623_5647(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTrivia();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 5623, 5647);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 5298, 5780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 5298, 5780);
                }
            }

            private void Push(GreenNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 5796, 6196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5862, 6093) || true) && (_count >= f_10812_5876_5889(_stack))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10812, 5862, 6093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 5931, 5978);

                        var
                        tmp = new NodeIteration[f_10812_5959_5972(_stack) * 2]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6000, 6039);

                        f_10812_6000_6038(_stack, tmp, f_10812_6024_6037(_stack));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6061, 6074);

                        _stack = tmp;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10812, 5862, 6093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6113, 6154);

                    _stack[_count] = f_10812_6130_6153(node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6172, 6181);

                    _count++;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 5796, 6196);

                    int
                    f_10812_5876_5889(Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10812, 5876, 5889);
                        return return_v;
                    }


                    int
                    f_10812_5959_5972(Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10812, 5959, 5972);
                        return return_v;
                    }


                    int
                    f_10812_6024_6037(Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10812, 6024, 6037);
                        return return_v;
                    }


                    int
                    f_10812_6000_6038(Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration[]
                    sourceArray, Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration[]
                    destinationArray, int
                    length)
                    {
                        Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 6000, 6038);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration
                    f_10812_6130_6153(Microsoft.CodeAnalysis.GreenNode
                    node)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIteration(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 6130, 6153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 5796, 6196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 5796, 6196);
                }
            }

            internal void Pop()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 6212, 6288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6264, 6273);

                    _count--;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 6212, 6288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 6212, 6288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 6212, 6288);
                }
            }

            internal bool Any()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 6304, 6389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6356, 6374);

                    return _count > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 6304, 6389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 6304, 6389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 6304, 6389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal NodeIteration Top
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 6464, 6551);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6508, 6532);

                        return this[_count - 1];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 6464, 6551);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 6405, 6566);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 6405, 6566);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal NodeIteration this[int index]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 6653, 6853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6697, 6726);

                        f_10812_6697_6725(_stack != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6748, 6791);

                        f_10812_6748_6790(index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10812, 6761, 6789) && index < _count));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6813, 6834);

                        return _stack[index];
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 6653, 6853);

                        int
                        f_10812_6697_6725(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 6697, 6725);
                            return 0;
                        }


                        int
                        f_10812_6748_6790(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 6748, 6790);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 6653, 6853);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 6653, 6853);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal void UpdateSlotIndexForStackTop(int slotIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 6884, 7118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 6972, 7001);

                    f_10812_6972_7000(_stack != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 7019, 7044);

                    f_10812_7019_7043(_count > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 7062, 7103);

                    _stack[_count - 1].SlotIndex = slotIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 6884, 7118);

                    int
                    f_10812_6972_7000(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 6972, 7000);
                        return 0;
                    }


                    int
                    f_10812_7019_7043(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 7019, 7043);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 6884, 7118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 6884, 7118);
                }
            }

            internal void UpdateDiagnosticIndexForStackTop(int diagnosticIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10812, 7134, 7392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 7234, 7263);

                    f_10812_7234_7262(_stack != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 7281, 7306);

                    f_10812_7281_7305(_count > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 7324, 7377);

                    _stack[_count - 1].DiagnosticIndex = diagnosticIndex;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10812, 7134, 7392);

                    int
                    f_10812_7234_7262(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 7234, 7262);
                        return 0;
                    }


                    int
                    f_10812_7281_7305(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 7281, 7305);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10812, 7134, 7392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 7134, 7392);
                }
            }
            static NodeIterationStack()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10812, 4575, 7403);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10812, 4575, 7403);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 4575, 7403);
            }

            static int
            f_10812_4787_4813(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 4787, 4813);
                return 0;
            }

        }
        static SyntaxTreeDiagnosticEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10812, 420, 7410);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10812, 667, 691);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10812, 420, 7410);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10812, 420, 7410);
        }

        static bool
        f_10812_940_964(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.ContainsDiagnostics;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10812, 940, 964);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIterationStack
        f_10812_1050_1094(int
        capacity)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIterationStack(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 1050, 1094);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIterationStack
        f_10812_1217_1241()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxTreeDiagnosticEnumerator.NodeIterationStack();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10812, 1217, 1241);
            return return_v;
        }

    }
}
