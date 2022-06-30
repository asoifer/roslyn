// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly partial struct SyntaxList<TNode> : IReadOnlyList<TNode>, IEquatable<SyntaxList<TNode>>
            where TNode : SyntaxNode
    {

        private readonly SyntaxNode? _node;

        internal SyntaxList(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(684, 758, 844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 820, 833);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(684, 758, 844);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 758, 844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 758, 844);
            }
        }

        public SyntaxList(TNode? node)
        : this(f_684_1074_1091_C((SyntaxNode?)node))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(684, 1023, 1114);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(684, 1023, 1114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 1023, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 1023, 1114);
            }
        }

        public SyntaxList(IEnumerable<TNode>? nodes)
        : this(f_684_1353_1370_C(CreateNode(nodes)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(684, 1288, 1393);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(684, 1288, 1393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 1288, 1393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 1288, 1393);
            }
        }

        private static SyntaxNode? CreateNode(IEnumerable<TNode>? nodes)
        {
            if (nodes == null)
            {
                return null;
            }

            var collection = nodes as ICollection<TNode>;
            var builder = (collection != null) ? new SyntaxListBuilder<TNode>(collection.Count) : SyntaxListBuilder<TNode>.Create();

            foreach (TNode node in nodes)
            {
                builder.Add(node);
            }

            return builder.ToList().Node;
        }

        internal SyntaxNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 1996, 2060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2032, 2045);

                    return _node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 1996, 2060);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 1946, 2071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 1946, 2071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 2217, 2332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2253, 2317);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(684, 2260, 2273) || ((_node == null && DynAbs.Tracing.TraceSender.Conditional_F2(684, 2276, 2277)) || DynAbs.Tracing.TraceSender.Conditional_F3(684, 2280, 2316))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(684, 2281, 2293) || ((f_684_2281_2293(_node) && DynAbs.Tracing.TraceSender.Conditional_F2(684, 2296, 2311)) || DynAbs.Tracing.TraceSender.Conditional_F3(684, 2314, 2315))) ? f_684_2296_2311(_node) : 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 2217, 2332);

                    bool
                    f_684_2281_2293(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 2281, 2293);
                        return return_v;
                    }


                    int
                    f_684_2296_2311(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 2296, 2311);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 2176, 2343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 2176, 2343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Gets the node at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the node to get or set.</param>
        /// <returns>The node at the specified index.</returns>
        public TNode this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 2660, 3258);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2696, 3172) || true) && (_node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 2696, 3172);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2755, 3153) || true) && (f_684_2759_2771(_node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 2755, 3153);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2821, 2996) || true) && (unchecked((uint)index < (uint)f_684_2855_2870(_node)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 2821, 2996);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 2929, 2969);

                                return (TNode)f_684_2943_2967(_node, index)!;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(684, 2821, 2996);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 2755, 3153);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 2755, 3153);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3046, 3153) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 3046, 3153);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3110, 3130);

                                return (TNode)_node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(684, 3046, 3153);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 2755, 3153);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 2696, 3172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3190, 3243);

                    throw f_684_3196_3242(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 2660, 3258);

                    bool
                    f_684_2759_2771(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 2759, 2771);
                        return return_v;
                    }


                    int
                    f_684_2855_2870(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 2855, 2870);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_684_2943_2967(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, int
                    slot)
                    {
                        var return_v = this_param.GetNodeSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 2943, 2967);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_684_3196_3242(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 3196, 3242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 2660, 3258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 2660, 3258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxNode? ItemInternal(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 3281, 3535);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3350, 3456) || true) && (f_684_3354_3367_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 684, 3354, 3367)?.IsList) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 3350, 3456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3409, 3441);

                    return f_684_3416_3440(_node, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 3350, 3456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3472, 3497);

                f_684_3472_3496(index == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3511, 3524);

                return _node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 3281, 3535);

                bool?
                f_684_3354_3367_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 3354, 3367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_684_3416_3440(Microsoft.CodeAnalysis.SyntaxNode
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNodeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 3416, 3440);
                    return return_v;
                }


                int
                f_684_3472_3496(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 3472, 3496);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 3281, 3535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 3281, 3535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextSpan FullSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 3784, 4108);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3820, 4093) || true) && (this.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 3820, 4093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3881, 3906);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 3820, 4093);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 3820, 4093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 3988, 4074);

                        return TextSpan.FromBounds(this[0].FullSpan.Start, this[this.Count - 1].FullSpan.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 3820, 4093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 3784, 4108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 3735, 4119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 3735, 4119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan Span
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 4368, 4684);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 4404, 4669) || true) && (this.Count == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 4404, 4669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 4465, 4490);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 4404, 4669);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 4404, 4669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 4572, 4650);

                        return TextSpan.FromBounds(this[0].Span.Start, this[this.Count - 1].Span.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 4404, 4669);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 4368, 4684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 4323, 4695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 4323, 4695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 5135, 5259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 5193, 5248);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(684, 5200, 5213) || ((_node != null && DynAbs.Tracing.TraceSender.Conditional_F2(684, 5216, 5232)) || DynAbs.Tracing.TraceSender.Conditional_F3(684, 5235, 5247))) ? f_684_5216_5232(_node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 5135, 5259);

                string
                f_684_5216_5232(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 5216, 5232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 5135, 5259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 5135, 5259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 5699, 5822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 5752, 5811);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(684, 5759, 5772) || ((_node != null && DynAbs.Tracing.TraceSender.Conditional_F2(684, 5775, 5795)) || DynAbs.Tracing.TraceSender.Conditional_F3(684, 5798, 5810))) ? f_684_5775_5795(_node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 5699, 5822);

                string
                f_684_5775_5795(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 5775, 5795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 5699, 5822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 5699, 5822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> Add(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 6012, 6125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 6077, 6114);

                return this.Insert(this.Count, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 6012, 6125);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 6012, 6125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 6012, 6125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> AddRange(IEnumerable<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 6318, 6456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 6402, 6445);

                return this.InsertRange(this.Count, nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 6318, 6456);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 6318, 6456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 6318, 6456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxList<TNode> Insert(int index, TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 6719, 6978);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 6798, 6909) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 6798, 6909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 6848, 6894);

                    throw f_684_6854_6893(nameof(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 6798, 6909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 6925, 6967);

                return InsertRange(index, new[] { node });
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 6719, 6978);

                System.ArgumentNullException
                f_684_6854_6893(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 6854, 6893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 6719, 6978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 6719, 6978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified nodes inserted at the index.
        /// </summary>
        /// <param name="index">The index to insert at.</param>
        /// <param name="nodes">The nodes to insert.</param>
        public SyntaxList<TNode> InsertRange(int index, IEnumerable<TNode> nodes)
        {
            if (index < 0 || index > this.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (nodes == null)
            {
                throw new ArgumentNullException(nameof(nodes));
            }

            var list = this.ToList();
            list.InsertRange(index, nodes);

            if (list.Count == 0)
            {
                return this;
            }
            else
            {
                return CreateList(list);
            }
        }

        public SyntaxList<TNode> RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 8104, 8369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 8173, 8310) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(684, 8177, 8208) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 8173, 8310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 8242, 8295);

                    throw f_684_8248_8294(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 8173, 8310);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 8326, 8358);

                return this.Remove(this[index]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 8104, 8369);

                System.ArgumentOutOfRangeException
                f_684_8248_8294(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 8248, 8294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 8104, 8369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 8104, 8369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the element removed.
        /// </summary>
        /// <param name="node">The element to remove.</param>
        public SyntaxList<TNode> Remove(TNode node)
        {
            return CreateList(this.Where(x => x != node).ToList());
        }

        public SyntaxList<TNode> Replace(TNode nodeInList, TNode newNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 8956, 9108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9046, 9097);

                return ReplaceRange(nodeInList, new[] { newNode });
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 8956, 9108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 8956, 9108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 8956, 9108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates a new list with the specified element replaced with new nodes.
        /// </summary>
        /// <param name="nodeInList">The element to replace.</param>
        /// <param name="newNodes">The new nodes.</param>
        public SyntaxList<TNode> ReplaceRange(TNode nodeInList, IEnumerable<TNode> newNodes)
        {
            if (nodeInList == null)
            {
                throw new ArgumentNullException(nameof(nodeInList));
            }

            if (newNodes == null)
            {
                throw new ArgumentNullException(nameof(newNodes));
            }

            var index = this.IndexOf(nodeInList);
            if (index >= 0 && index < this.Count)
            {
                var list = this.ToList();
                list.RemoveAt(index);
                list.InsertRange(index, newNodes);
                return CreateList(list);
            }
            else
            {
                throw new ArgumentException(nameof(nodeInList));
            }
        }

        private static SyntaxList<TNode> CreateList(List<TNode> items)
        {
            if (items.Count == 0)
            {
                return default(SyntaxList<TNode>);
            }

            var newGreen = GreenNode.CreateList(items, static n => n.Green);
            return new SyntaxList<TNode>(newGreen!.CreateRed());
        }

        public TNode First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 10641, 10712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10686, 10701);

                return this[0];
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 10641, 10712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 10641, 10712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 10641, 10712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode? FirstOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 10844, 11066);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10899, 11055) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 10899, 11055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10947, 10962);

                    return this[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 10899, 11055);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 10899, 11055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11028, 11040);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 10899, 11055);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 10844, 11066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 10844, 11066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 10844, 11066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 11165, 11248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11209, 11237);

                return this[this.Count - 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 11165, 11248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 11165, 11248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 11165, 11248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TNode? LastOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 11379, 11613);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11433, 11602) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 11433, 11602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11481, 11509);

                    return this[this.Count - 1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 11433, 11602);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 11433, 11602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11575, 11587);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 11433, 11602);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 11379, 11613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 11379, 11613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 11379, 11613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 11725, 11855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11767, 11809);

                f_684_11767_11808(_node == null || (DynAbs.Tracing.TraceSender.Expression_False(684, 11780, 11807) || Count != 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11823, 11844);

                return _node != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 11725, 11855);

                int
                f_684_11767_11808(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 11767, 11808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 11725, 11855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 11725, 11855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool All(Func<TNode, bool> predicate)
        {
            foreach (var item in this)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }

        private TNode[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 12229, 12259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12235, 12257);

                    // LAFHIS
                    //return f_684_12242_12256(ref this);
                    var return_v = this.ToArray<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12242, 12256);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(684, 12229, 12259);

                    TNode[]
                    f_684_12242_12256(ref Microsoft.CodeAnalysis.SyntaxList<TNode>
                    source)
                    {
                        var return_v = source.ToArray<TNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12242, 12256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 12183, 12270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 12183, 12270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Get's the enumerator for this list.
        /// </summary>
#pragma warning disable RS0041 // uses oblivious reference types
        public Enumerator GetEnumerator()
#pragma warning restore RS0041 // uses oblivious reference types
        {
            return new Enumerator(this);
        }

        IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
        {
            if (this.Any())
            {
                return new EnumeratorImpl(this);
            }

            return SpecializedCollections.EmptyEnumerator<TNode>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (this.Any())
            {
                return new EnumeratorImpl(this);
            }

            return SpecializedCollections.EmptyEnumerator<TNode>();
        }

        public static bool operator ==(SyntaxList<TNode> left, SyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 13139, 13287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13243, 13276);

                return left._node == right._node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 13139, 13287);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13139, 13287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13139, 13287);
            }
        }

        public static bool operator !=(SyntaxList<TNode> left, SyntaxList<TNode> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 13299, 13447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13403, 13436);

                return left._node != right._node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 13299, 13447);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13299, 13447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13299, 13447);
            }
        }

        public bool Equals(SyntaxList<TNode> other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 13459, 13566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13527, 13555);

                return _node == other._node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 13459, 13566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13459, 13566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13459, 13566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 13578, 13720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13643, 13709);

                return obj is SyntaxList<TNode> && (DynAbs.Tracing.TraceSender.Expression_True(684, 13650, 13708) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 13578, 13720);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13578, 13720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13578, 13720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 13732, 13834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13790, 13823);

                return f_684_13797_13817_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 684, 13797, 13817)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(684, 13797, 13822) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 13732, 13834);

                int?
                f_684_13797_13817_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 13797, 13817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13732, 13834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13732, 13834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxList<TNode>(SyntaxList<SyntaxNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 13846, 14003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13950, 13992);

                return f_684_13957_13991(nodes._node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 13846, 14003);

                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_13957_13991(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 13957, 13991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 13846, 14003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 13846, 14003);
            }
        }
        public static implicit operator SyntaxList<SyntaxNode>(SyntaxList<TNode> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 14015, 14176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14119, 14165);

                return f_684_14126_14164(nodes.Node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 14015, 14176);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_684_14126_14164(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 14126, 14164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 14015, 14176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 14015, 14176);
            }
        }
        /// <summary>
        /// The index of the node in this list, or -1 if the node is not in the list.
        /// </summary>
        public int IndexOf(TNode node)
        {
            var index = 0;
            foreach (var child in this)
            {
                if (object.Equals(child, node))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public int IndexOf(Func<TNode, bool> predicate)
        {
            var index = 0;
            foreach (var child in this)
            {
                if (predicate(child))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        internal int IndexOf(int rawKind)
        {
            var index = 0;
            foreach (var child in this)
            {
                if (child.RawKind == rawKind)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public int LastIndexOf(TNode node)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (object.Equals(this[i], node))
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(Func<TNode, bool> predicate)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (predicate(this[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        static SyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(684, 558, 15947);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(684, 558, 15947);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 558, 15947);
        }

        static Microsoft.CodeAnalysis.SyntaxNode?
        f_684_1074_1091_C(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(684, 1023, 1114);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode?
        f_684_1353_1370_C(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(684, 1288, 1393);
            return return_v;
        }

    }
}
