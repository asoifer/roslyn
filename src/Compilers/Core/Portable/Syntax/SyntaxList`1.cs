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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 1405, 1934);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1494, 1572) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 1494, 1572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1545, 1557);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 1494, 1572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1588, 1633);

                var
                collection = nodes as ICollection<TNode>
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1647, 1767);

                var
                builder = (DynAbs.Tracing.TraceSender.Conditional_F1(684, 1661, 1681) || (((collection != null) && DynAbs.Tracing.TraceSender.Conditional_F2(684, 1684, 1730)) || DynAbs.Tracing.TraceSender.Conditional_F3(684, 1733, 1766))) ? f_684_1684_1730(f_684_1713_1729(collection)) : SyntaxListBuilder<TNode>.Create()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1783, 1878);
                    foreach (TNode node in f_684_1806_1811_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 1783, 1878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1845, 1863);

                        builder.Add(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 1783, 1878);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 96);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 96);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 1894, 1923);

                return builder.ToList().Node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 1405, 1934);

                int
                f_684_1713_1729(System.Collections.Generic.ICollection<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 1713, 1729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder<TNode>
                f_684_1684_1730(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 1684, 1730);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TNode>
                f_684_1806_1811_I(System.Collections.Generic.IEnumerable<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 1806, 1811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 1405, 1934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 1405, 1934);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 7244, 7891);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7342, 7479) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(684, 7346, 7377) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 7342, 7479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7411, 7464);

                    throw f_684_7417_7463(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 7342, 7479);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7495, 7608) || true) && (nodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 7495, 7608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7546, 7593);

                    throw f_684_7552_7592(nameof(nodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 7495, 7608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7624, 7649);

                // LAFHIS
                //var list = f_684_7635_7648(ref this);
                var list = this.ToList<TNode>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 7635, 7648);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7663, 7694);

                f_684_7663_7693(list, index, nodes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7710, 7880) || true) && (f_684_7714_7724(list) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 7710, 7880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7763, 7775);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 7710, 7880);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 7710, 7880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 7841, 7865);

                    return CreateList(list);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 7710, 7880);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 7244, 7891);

                System.ArgumentOutOfRangeException
                f_684_7417_7463(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 7417, 7463);
                    return return_v;
                }


                System.ArgumentNullException
                f_684_7552_7592(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 7552, 7592);
                    return return_v;
                }


                System.Collections.Generic.List<TNode>
                f_684_7635_7648(ref Microsoft.CodeAnalysis.SyntaxList<TNode>
                source)
                {
                    var return_v = source.ToList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 7635, 7648);
                    return return_v;
                }


                int
                f_684_7663_7693(System.Collections.Generic.List<TNode>
                this_param, int
                index, System.Collections.Generic.IEnumerable<TNode>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 7663, 7693);
                    return 0;
                }


                int
                f_684_7714_7724(System.Collections.Generic.List<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 7714, 7724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 7244, 7891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 7244, 7891);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 8549, 8683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 8617, 8672);

                // LAFHIS
                //return CreateList(f_684_8635_8670(f_684_8635_8661(ref this, x => x != node)));
                var temp = this.Where<TNode>(x => x != node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 8635, 8661);
                return CreateList(f_684_8635_8670(temp));

                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 8549, 8683);

                System.Collections.Generic.IEnumerable<TNode>
                f_684_8635_8661(ref Microsoft.CodeAnalysis.SyntaxList<TNode>
                source, System.Func<TNode, bool>
                predicate)
                {
                    var return_v = source.Where<TNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 8635, 8661);
                    return return_v;
                }


                System.Collections.Generic.List<TNode>
                f_684_8635_8670(System.Collections.Generic.IEnumerable<TNode>
                source)
                {
                    var return_v = source.ToList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 8635, 8670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 8549, 8683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 8549, 8683);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 9380, 10182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9489, 9612) || true) && (nodeInList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 9489, 9612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9545, 9597);

                    throw f_684_9551_9596(nameof(nodeInList));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 9489, 9612);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9628, 9747) || true) && (newNodes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 9628, 9747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9682, 9732);

                    throw f_684_9688_9731(nameof(newNodes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 9628, 9747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9763, 9800);

                var
                index = this.IndexOf(nodeInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9814, 10171) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(684, 9818, 9850) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 9814, 10171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9884, 9909);

                    // LAFHIS
                    // var list = f_684_9895_9908(ref this);
                    var list = this.ToList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9895, 9908);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9927, 9948);

                    f_684_9927_9947(list, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 9966, 10000);

                    f_684_9966_9999(list, index, newNodes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10018, 10042);

                    return CreateList(list);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 9814, 10171);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 9814, 10171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10108, 10156);

                    throw f_684_10114_10155(nameof(nodeInList));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 9814, 10171);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 9380, 10182);

                System.ArgumentNullException
                f_684_9551_9596(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9551, 9596);
                    return return_v;
                }


                System.ArgumentNullException
                f_684_9688_9731(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9688, 9731);
                    return return_v;
                }


                System.Collections.Generic.List<TNode>
                f_684_9895_9908(ref Microsoft.CodeAnalysis.SyntaxList<TNode>
                source)
                {
                    var return_v = source.ToList<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9895, 9908);
                    return return_v;
                }


                int
                f_684_9927_9947(System.Collections.Generic.List<TNode>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9927, 9947);
                    return 0;
                }


                int
                f_684_9966_9999(System.Collections.Generic.List<TNode>
                this_param, int
                index, System.Collections.Generic.IEnumerable<TNode>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 9966, 9999);
                    return 0;
                }


                System.ArgumentException
                f_684_10114_10155(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 10114, 10155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 9380, 10182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 9380, 10182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxList<TNode> CreateList(List<TNode> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(684, 10194, 10541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10281, 10384) || true) && (f_684_10285_10296(items) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 10281, 10384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10335, 10369);

                    return default(SyntaxList<TNode>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 10281, 10384);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10400, 10464);

                var
                newGreen = f_684_10415_10463(items, static n => n.Green)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 10478, 10530);

                return f_684_10485_10529(f_684_10507_10528(newGreen!));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(684, 10194, 10541);

                int
                f_684_10285_10296(System.Collections.Generic.List<TNode>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 10285, 10296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_684_10415_10463(System.Collections.Generic.List<TNode>
                list, System.Func<TNode, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 10415, 10463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_684_10507_10528(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 10507, 10528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_10485_10529(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 10485, 10529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 10194, 10541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 10194, 10541);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 11867, 12145);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11938, 12106);
                    foreach (var item in f_684_11959_11963_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 11938, 12106);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 11997, 12091) || true) && (!f_684_12002_12017(predicate, item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 11997, 12091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12059, 12072);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 11997, 12091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 11938, 12106);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12122, 12134);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 11867, 12145);

                bool
                f_684_12002_12017(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12002, 12017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_11959_11963_I(Microsoft.CodeAnalysis.SyntaxList<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 11959, 11963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 11867, 12145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 11867, 12145);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
        {
            try
#pragma warning restore RS0041 // uses oblivious reference types
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 12444, 12607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12568, 12596);

                return f_684_12575_12595(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 12444, 12607);

                Microsoft.CodeAnalysis.SyntaxList<TNode>.Enumerator
                f_684_12575_12595(Microsoft.CodeAnalysis.SyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12575, 12595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 12444, 12607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 12444, 12607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 12619, 12874);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12697, 12792) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 12697, 12792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12745, 12777);

                    return f_684_12752_12776(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 12697, 12792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12808, 12863);

                return f_684_12815_12862();
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 12619, 12874);

                Microsoft.CodeAnalysis.SyntaxList<TNode>.EnumeratorImpl
                f_684_12752_12776(Microsoft.CodeAnalysis.SyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12752, 12776);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TNode>
                f_684_12815_12862()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 12815, 12862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 12619, 12874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 12619, 12874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 12886, 13127);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12950, 13045) || true) && (this.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 12950, 13045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 12998, 13030);

                    return f_684_13005_13029(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(684, 12950, 13045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 13061, 13116);

                return f_684_13068_13115();
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 12886, 13127);

                Microsoft.CodeAnalysis.SyntaxList<TNode>.EnumeratorImpl
                f_684_13005_13029(Microsoft.CodeAnalysis.SyntaxList<TNode>
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 13005, 13029);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<TNode>
                f_684_13068_13115()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<TNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 13068, 13115);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 12886, 13127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 12886, 13127);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 14322, 14649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14377, 14391);

                var
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14405, 14612);
                    foreach (var child in f_684_14427_14431_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 14405, 14612);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14465, 14569) || true) && (f_684_14469_14495(child, node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 14465, 14569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14537, 14550);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 14465, 14569);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14589, 14597);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 14405, 14612);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14628, 14638);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 14322, 14649);

                bool
                f_684_14469_14495(TNode
                objA, TNode
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 14469, 14495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_14427_14431_I(Microsoft.CodeAnalysis.SyntaxList<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 14427, 14431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 14322, 14649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 14322, 14649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(Func<TNode, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 14661, 14995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14733, 14747);

                var
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14761, 14958);
                    foreach (var child in f_684_14783_14787_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 14761, 14958);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14821, 14915) || true) && (f_684_14825_14841(predicate, child))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 14821, 14915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14883, 14896);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 14821, 14915);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14935, 14943);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 14761, 14958);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 14974, 14984);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 14661, 14995);

                bool
                f_684_14825_14841(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 14825, 14841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_14783_14787_I(Microsoft.CodeAnalysis.SyntaxList<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 14783, 14787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 14661, 14995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 14661, 14995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int IndexOf(int rawKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 15007, 15335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15065, 15079);

                var
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15093, 15298);
                    foreach (var child in f_684_15115_15119_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15093, 15298);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15153, 15255) || true) && (f_684_15157_15170(child) == rawKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15153, 15255);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15223, 15236);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15153, 15255);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15275, 15283);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15093, 15298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15314, 15324);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 15007, 15335);

                int
                f_684_15157_15170(TNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(684, 15157, 15170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_684_15115_15119_I(Microsoft.CodeAnalysis.SyntaxList<TNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 15115, 15119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 15007, 15335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 15007, 15335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int LastIndexOf(TNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 15347, 15634);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15415, 15433);
                    for (int
        i = this.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15406, 15597) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15443, 15446)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15406, 15597))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15406, 15597);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15480, 15582) || true) && (f_684_15484_15512(this[i], node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15480, 15582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15554, 15563);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15480, 15582);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15613, 15623);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 15347, 15634);

                bool
                f_684_15484_15512(TNode
                objA, TNode
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 15484, 15512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 15347, 15634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 15347, 15634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int LastIndexOf(Func<TNode, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(684, 15646, 15940);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15731, 15749);
                    for (int
        i = this.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15722, 15903) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15759, 15762)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15722, 15903))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15722, 15903);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15796, 15888) || true) && (f_684_15800_15818(predicate, this[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(684, 15796, 15888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15860, 15869);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(684, 15796, 15888);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(684, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(684, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(684, 15919, 15929);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(684, 15646, 15940);

                bool
                f_684_15800_15818(System.Func<TNode, bool>
                this_param, TNode
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(684, 15800, 15818);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(684, 15646, 15940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(684, 15646, 15940);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
