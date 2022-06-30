// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    public readonly struct SyntaxNodeOrTokenList : IEquatable<SyntaxNodeOrTokenList>, IReadOnlyCollection<SyntaxNodeOrToken>
    {

        private readonly SyntaxNode? _node;

        internal readonly int index;

        internal SyntaxNodeOrTokenList(SyntaxNode? node, int index)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(693, 1298, 1585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 1404, 1445);

                f_693_1404_1444(node != null || (DynAbs.Tracing.TraceSender.Expression_False(693, 1417, 1443) || index == 0));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 1459, 1574) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 1459, 1574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 1509, 1522);

                    _node = node;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 1540, 1559);

                    this.index = index;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 1459, 1574);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(693, 1298, 1585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 1298, 1585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 1298, 1585);
            }
        }

        public SyntaxNodeOrTokenList(IEnumerable<SyntaxNodeOrToken> nodesAndTokens)
        : this(f_693_1933_1959_C(CreateNode(nodesAndTokens)), 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(693, 1837, 1985);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(693, 1837, 1985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 1837, 1985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 1837, 1985);
            }
        }

        public SyntaxNodeOrTokenList(params SyntaxNodeOrToken[] nodesAndTokens)
        : this(f_693_2315_2361_C((IEnumerable<SyntaxNodeOrToken>)nodesAndTokens))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(693, 2223, 2384);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(693, 2223, 2384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 2223, 2384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 2223, 2384);
            }
        }

        private static SyntaxNode? CreateNode(IEnumerable<SyntaxNodeOrToken> nodesAndTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(693, 2396, 2798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2505, 2636) || true) && (nodesAndTokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 2505, 2636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2565, 2621);

                    throw f_693_2571_2620(nameof(nodesAndTokens));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 2505, 2636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2652, 2702);

                var
                builder = f_693_2666_2701(8)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2716, 2744);

                f_693_2716_2743(builder, nodesAndTokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2758, 2787);

                return f_693_2765_2781(builder).Node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(693, 2396, 2798);

                System.ArgumentNullException
                f_693_2571_2620(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 2571, 2620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                f_693_2666_2701(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 2666, 2701);
                    return return_v;
                }


                int
                f_693_2716_2743(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                nodeOrTokens)
                {
                    this_param.Add(nodeOrTokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 2716, 2743);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_693_2765_2781(Microsoft.CodeAnalysis.Syntax.SyntaxNodeOrTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 2765, 2781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 2396, 2798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 2396, 2798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxNode? Node
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 2929, 2937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2932, 2937);
                    return _node; DynAbs.Tracing.TraceSender.TraceExitMethod(693, 2929, 2937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 2929, 2937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 2929, 2937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int Position
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 2972, 2995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 2975, 2995);
                    return f_693_2975_2990_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 693, 2975, 2990)?.Position) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(693, 2975, 2995) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(693, 2972, 2995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 2972, 2995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 2972, 2995);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxNode? Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 3036, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3039, 3052);
                    return f_693_3039_3052_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 693, 3039, 3052)?.Parent); DynAbs.Tracing.TraceSender.TraceExitMethod(693, 3036, 3052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 3036, 3052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 3036, 3052);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 3203, 3279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3209, 3277);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 3216, 3229) || ((_node == null && DynAbs.Tracing.TraceSender.Conditional_F2(693, 3232, 3233)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 3236, 3276))) ? 0 : (DynAbs.Tracing.TraceSender.Conditional_F1(693, 3236, 3254) || ((f_693_3236_3254(f_693_3236_3247(_node)) && DynAbs.Tracing.TraceSender.Conditional_F2(693, 3257, 3272)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 3275, 3276))) ? f_693_3257_3272(_node) : 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 3203, 3279);

                    Microsoft.CodeAnalysis.GreenNode
                    f_693_3236_3247(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 3236, 3247);
                        return return_v;
                    }


                    bool
                    f_693_3236_3254(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 3236, 3254);
                        return return_v;
                    }


                    int
                    f_693_3257_3272(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 3257, 3272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 3162, 3290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 3162, 3290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Gets the <see cref="SyntaxNodeOrToken"/> at the specified index. 
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"><paramref name="index"/> is out of range.</exception>
        public SyntaxNodeOrToken this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 3603, 4597);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3639, 4509) || true) && (_node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 3639, 4509);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3698, 4490) || true) && (f_693_3702_3715_M(!_node.IsList))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 3698, 4490);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3765, 3877) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 3765, 3877);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3837, 3850);

                                return _node;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(693, 3765, 3877);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(693, 3698, 4490);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 3698, 4490);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 3975, 4467) || true) && (unchecked((uint)index < (uint)f_693_4009_4024(_node)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 3975, 4467);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4083, 4130);

                                var
                                green = f_693_4095_4129(f_693_4095_4106(_node), index)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4160, 4368) || true) && (f_693_4164_4177(green))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 4160, 4368);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4243, 4337);

                                    return f_693_4250_4336(this.Parent, green, f_693_4286_4315(_node, index), this.index + index);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 4160, 4368);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4400, 4440);

                                return f_693_4407_4439(_node, index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(693, 3975, 4467);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(693, 3698, 4490);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(693, 3639, 4509);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4529, 4582);

                    throw f_693_4535_4581(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 3603, 4597);

                    bool
                    f_693_3702_3715_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 3702, 3715);
                        return return_v;
                    }


                    int
                    f_693_4009_4024(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 4009, 4024);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_693_4095_4106(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Green;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 4095, 4106);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode
                    f_693_4095_4129(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetRequiredSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 4095, 4129);
                        return return_v;
                    }


                    bool
                    f_693_4164_4177(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 4164, 4177);
                        return return_v;
                    }


                    int
                    f_693_4286_4315(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetChildPosition(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 4286, 4315);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_693_4250_4336(Microsoft.CodeAnalysis.SyntaxNode?
                    parent, Microsoft.CodeAnalysis.GreenNode
                    token, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 4250, 4336);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_693_4407_4439(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, int
                    slot)
                    {
                        var return_v = this_param.GetRequiredNodeSlot(slot);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 4407, 4439);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_693_4535_4581(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 4535, 4581);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 3603, 4597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 3603, 4597);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TextSpan FullSpan
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 4833, 4872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 4836, 4872);
                    return f_693_4836_4851_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 693, 4836, 4851)?.FullSpan) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Text.TextSpan?>(693, 4836, 4872) ?? default(TextSpan)); DynAbs.Tracing.TraceSender.TraceExitMethod(693, 4833, 4872);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 4833, 4872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 4833, 4872);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 5098, 5133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 5101, 5133);
                    return f_693_5101_5112_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 693, 5101, 5112)?.Span) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Text.TextSpan?>(693, 5101, 5133) ?? default(TextSpan)); DynAbs.Tracing.TraceSender.TraceExitMethod(693, 5098, 5133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 5098, 5133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 5098, 5133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 5632, 5790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 5690, 5779);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 5697, 5710) || ((_node != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(693, 5730, 5746)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 5766, 5778))) ? f_693_5730_5746(_node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 5632, 5790);

                string
                f_693_5730_5746(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 5730, 5746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 5632, 5790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 5632, 5790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 6288, 6445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 6341, 6434);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 6348, 6361) || ((_node != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(693, 6381, 6401)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 6421, 6433))) ? f_693_6381_6401(_node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 6288, 6445);

                string
                f_693_6381_6401(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 6381, 6401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 6288, 6445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 6288, 6445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 6576, 6659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 6633, 6648);

                return this[0];
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 6576, 6659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 6576, 6659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 6576, 6659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken FirstOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 6834, 7002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 6900, 6991);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 6907, 6917) || ((this.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(693, 6937, 6944)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 6964, 6990))) ? this[0]
                : default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 6834, 7002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 6834, 7002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 6834, 7002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 7132, 7227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 7188, 7216);

                return this[this.Count - 1];
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 7132, 7227);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 7132, 7227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 7132, 7227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrToken LastOrDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 7401, 7581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 7466, 7570);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 7473, 7483) || ((this.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(693, 7503, 7523)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 7543, 7569))) ? this[this.Count - 1]
                : default(SyntaxNodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 7401, 7581);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 7401, 7581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 7401, 7581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 7917, 8245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 7991, 8001);

                var
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8015, 8208);
                    foreach (var child in f_693_8037_8041_I(this))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 8015, 8208);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8075, 8169) || true) && (child == nodeOrToken)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 8075, 8169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8141, 8150);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(693, 8075, 8169);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8189, 8193);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(693, 8015, 8208);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(693, 1, 194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(693, 1, 194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8224, 8234);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 7917, 8245);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_693_8037_8041_I(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 8037, 8041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 7917, 8245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 7917, 8245);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 8471, 8545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 8513, 8534);

                return _node != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 8471, 8545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 8471, 8545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 8471, 8545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CopyTo(int offset, GreenNode?[] array, int arrayOffset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 9004, 9256);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 9118, 9123);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 9109, 9245) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 9136, 9139)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(693, 9109, 9245))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 9109, 9245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 9173, 9230);

                        array[arrayOffset + i] = this[i + offset].UnderlyingNode;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(693, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(693, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 9004, 9256);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 9004, 9256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 9004, 9256);
            }
        }

        public SyntaxNodeOrTokenList Add(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 9502, 9640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 9590, 9629);

                return Insert(this.Count, nodeOrToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 9502, 9640);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 9502, 9640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 9502, 9640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList AddRange(IEnumerable<SyntaxNodeOrToken> nodesOrTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 9892, 10057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 10000, 10046);

                return InsertRange(this.Count, nodesOrTokens);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 9892, 10057);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 9892, 10057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 9892, 10057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList Insert(int index, SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 10376, 10741);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 10478, 10631) || true) && (nodeOrToken == default(SyntaxNodeOrToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 10478, 10631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 10557, 10616);

                    throw f_693_10563_10615(nameof(nodeOrToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 10478, 10631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 10647, 10730);

                return InsertRange(index, f_693_10673_10728(nodeOrToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 10376, 10741);

                System.ArgumentOutOfRangeException
                f_693_10563_10615(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 10563, 10615);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_10673_10728(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 10673, 10728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 10376, 10741);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 10376, 10741);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList InsertRange(int index, IEnumerable<SyntaxNodeOrToken> nodesAndTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 11067, 11726);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11190, 11327) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(693, 11194, 11225) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 11190, 11327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11259, 11312);

                    throw f_693_11265_11311(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 11190, 11327);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11343, 11474) || true) && (nodesAndTokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 11343, 11474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11403, 11459);

                    throw f_693_11409_11458(nameof(nodesAndTokens));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 11343, 11474);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11490, 11579) || true) && (f_693_11494_11518(nodesAndTokens))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 11490, 11579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11552, 11564);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 11490, 11579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11595, 11621);

                // LAFHIS
                //var nodes = f_693_11607_11620(ref this);
                var nodes = this.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11607, 11620);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11635, 11676);

                f_693_11635_11675(nodes, index, nodesAndTokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11690, 11715);

                return CreateList(nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 11067, 11726);

                System.ArgumentOutOfRangeException
                f_693_11265_11311(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11265, 11311);
                    return return_v;
                }


                System.ArgumentNullException
                f_693_11409_11458(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11409, 11458);
                    return return_v;
                }


                bool
                f_693_11494_11518(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11494, 11518);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_11607_11620(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11607, 11620);
                    return return_v;
                }


                int
                f_693_11635_11675(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, int
                index, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11635, 11675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 11067, 11726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 11067, 11726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNodeOrTokenList CreateList(List<SyntaxNodeOrToken> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(693, 11738, 12376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11841, 11948) || true) && (f_693_11845_11856(items) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 11841, 11948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11895, 11933);

                    return default(SyntaxNodeOrTokenList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 11841, 11948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 11964, 12046);

                var
                newGreen = f_693_11979_12044(items, static n => n.RequiredUnderlyingNode)!
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12060, 12291) || true) && (f_693_12064_12080(newGreen))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 12060, 12291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12114, 12276);

                    newGreen = f_693_12125_12275(new[]
                                    {
                    new ArrayElement<GreenNode> {Value = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => newGreen,693,12209,12255)}
                });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 12060, 12291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12307, 12365);

                return f_693_12314_12364(f_693_12340_12360(newGreen), 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(693, 11738, 12376);

                int
                f_693_11845_11856(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 11845, 11856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_693_11979_12044(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxNodeOrToken, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 11979, 12044);
                    return return_v;
                }


                bool
                f_693_12064_12080(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 12064, 12080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_693_12125_12275(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = Syntax.InternalSyntax.SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12125, 12275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_693_12340_12360(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12340, 12360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_693_12314_12364(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12314, 12364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 11738, 12376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 11738, 12376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 12624, 12963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12697, 12835) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(693, 12701, 12733) || index >= this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 12697, 12835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12767, 12820);

                    throw f_693_12773_12819(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 12697, 12835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12851, 12877);

                // LAFHIS
                //var nodes = f_693_12863_12876(ref this);
                var nodes = this.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12863, 12876);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12891, 12913);

                f_693_12891_12912(nodes, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 12927, 12952);

                return CreateList(nodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 12624, 12963);

                System.ArgumentOutOfRangeException
                f_693_12773_12819(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12773, 12819);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_12863_12876(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12863, 12876);
                    return return_v;
                }


                int
                f_693_12891_12912(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 12891, 12912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 12624, 12963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 12624, 12963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList Remove(SyntaxNodeOrToken nodeOrTokenInList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 13197, 13504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 13294, 13338);

                var
                index = this.IndexOf(nodeOrTokenInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 13352, 13465) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(693, 13356, 13388) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 13352, 13465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 13422, 13450);

                    return this.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 13352, 13465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 13481, 13493);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 13197, 13504);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 13197, 13504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 13197, 13504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList Replace(SyntaxNodeOrToken nodeOrTokenInList, SyntaxNodeOrToken newNodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 13838, 14221);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 13970, 14129) || true) && (newNodeOrToken == default(SyntaxNodeOrToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 13970, 14129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14052, 14114);

                    throw f_693_14058_14113(nameof(newNodeOrToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 13970, 14129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14145, 14210);

                return ReplaceRange(nodeOrTokenInList, new[] { newNodeOrToken });
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 13838, 14221);

                System.ArgumentOutOfRangeException
                f_693_14058_14113(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 14058, 14113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 13838, 14221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 13838, 14221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxNodeOrTokenList ReplaceRange(SyntaxNodeOrToken nodeOrTokenInList, IEnumerable<SyntaxNodeOrToken> newNodesAndTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 14564, 15123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14717, 14761);

                var
                index = this.IndexOf(nodeOrTokenInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14775, 15031) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(693, 14779, 14811) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 14775, 15031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14845, 14871);

                    // LAFHIS
                    //var nodes = f_693_14857_14870(ref this);
                    var nodes = this.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 14857, 14870);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14889, 14911);

                    f_693_14889_14910(nodes, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14929, 14973);

                    f_693_14929_14972(nodes, index, newNodesAndTokens);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 14991, 15016);

                    return CreateList(nodes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(693, 14775, 15031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 15047, 15112);

                throw f_693_15053_15111(nameof(nodeOrTokenInList));
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 14564, 15123);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_14857_14870(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 14857, 14870);
                    return return_v;
                }


                int
                f_693_14889_14910(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 14889, 14910);
                    return 0;
                }


                int
                f_693_14929_14972(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                this_param, int
                index, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 14929, 14972);
                    return 0;
                }


                System.ArgumentOutOfRangeException
                f_693_15053_15111(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 15053, 15111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 14564, 15123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 14564, 15123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxNodeOrToken[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 15219, 15249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 15225, 15247);

                    // LAFHIS
                    //return f_693_15232_15246(ref this);

                    var return_v = this.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 15232, 15246);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 15219, 15249);

                    Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
                    f_693_15232_15246(ref Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                    source)
                    {
                        var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxNodeOrToken>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 15232, 15246);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 15161, 15260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 15161, 15260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 15353, 15450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 15411, 15439);

                return f_693_15418_15438(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 15353, 15450);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList.Enumerator
                f_693_15418_15438(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 15418, 15438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 15353, 15450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 15353, 15450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<SyntaxNodeOrToken> IEnumerable<SyntaxNodeOrToken>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 15725, 15978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 15827, 15967);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 15834, 15847) || ((_node == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(693, 15867, 15926)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 15946, 15966))) ? f_693_15867_15926() : this.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 15725, 15978);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_15867_15926()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 15867, 15926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 15725, 15978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 15725, 15978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 16256, 16471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 16320, 16460);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(693, 16327, 16340) || ((_node == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(693, 16360, 16419)) || DynAbs.Tracing.TraceSender.Conditional_F3(693, 16439, 16459))) ? f_693_16360_16419() : this.GetEnumerator();
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 16256, 16471);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
                f_693_16360_16419()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxNodeOrToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 16360, 16419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 16256, 16471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 16256, 16471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxNodeOrTokenList left, SyntaxNodeOrTokenList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(693, 16827, 16976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 16939, 16965);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(693, 16827, 16976);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 16827, 16976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 16827, 16976);
            }
        }

        public static bool operator !=(SyntaxNodeOrTokenList left, SyntaxNodeOrTokenList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(693, 17336, 17486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 17448, 17475);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(693, 17336, 17486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 17336, 17486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 17336, 17486);
            }
        }

        public bool Equals(SyntaxNodeOrTokenList other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 17904, 18015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 17976, 18004);

                return _node == other._node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 17904, 18015);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 17904, 18015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 17904, 18015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 18427, 18577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 18492, 18566);

                return obj is SyntaxNodeOrTokenList && (DynAbs.Tracing.TraceSender.Expression_True(693, 18499, 18565) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 18427, 18577);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 18427, 18577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 18427, 18577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 18858, 18960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 18916, 18949);

                return f_693_18923_18943_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_node, 693, 18923, 18943)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(693, 18923, 18948) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(693, 18858, 18960);

                int?
                f_693_18923_18943_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 18923, 18943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 18858, 18960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 18858, 18960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
        public struct Enumerator : IEnumerator<SyntaxNodeOrToken>
        {

            private readonly SyntaxNodeOrTokenList _list;

            private int _index;

            internal Enumerator(in SyntaxNodeOrTokenList list)
                            : this()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(693, 19364, 19531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 19473, 19486);

                    _list = list;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 19504, 19516);

                    _index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(693, 19364, 19531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 19364, 19531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 19364, 19531);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 20022, 20234);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 20077, 20171) || true) && (_index < _list.Count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(693, 20077, 20171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 20143, 20152);

                        _index++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(693, 20077, 20171);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 20191, 20219);

                    return _index < _list.Count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 20022, 20234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 20022, 20234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 20022, 20234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SyntaxNodeOrToken Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 20427, 20443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 20430, 20443);
                        return _list[_index]; DynAbs.Tracing.TraceSender.TraceExitMethod(693, 20427, 20443);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 20427, 20443);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 20427, 20443);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 20631, 20646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 20634, 20646);
                        return this.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(693, 20631, 20646);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 20631, 20646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 20631, 20646);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 20969, 21075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 21026, 21060);

                    throw f_693_21032_21059();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 20969, 21075);

                    System.NotSupportedException
                    f_693_21032_21059()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 21032, 21059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 20969, 21075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 20969, 21075);
                }
            }

            void IDisposable.Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 21268, 21324);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 21268, 21324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 21268, 21324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 21268, 21324);
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 21340, 21462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 21413, 21447);

                    throw f_693_21419_21446();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 21340, 21462);

                    System.NotSupportedException
                    f_693_21419_21446()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 21419, 21446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 21340, 21462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 21340, 21462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(693, 21478, 21593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(693, 21544, 21578);

                    throw f_693_21550_21577();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(693, 21478, 21593);

                    System.NotSupportedException
                    f_693_21550_21577()
                    {
                        var return_v = new System.NotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 21550, 21577);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(693, 21478, 21593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 21478, 21593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(693, 19083, 21604);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(693, 19083, 21604);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 19083, 21604);
            }
        }
        static SyntaxNodeOrTokenList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(693, 616, 21611);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(693, 616, 21611);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(693, 616, 21611);
        }

        static int
        f_693_1404_1444(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(693, 1404, 1444);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode?
        f_693_1933_1959_C(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(693, 1837, 1985);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        f_693_2315_2361_C(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(693, 2223, 2384);
            return return_v;
        }


        int?
        f_693_2975_2990_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 2975, 2990);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode?
        f_693_3039_3052_M(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 3039, 3052);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan?
        f_693_4836_4851_M(Microsoft.CodeAnalysis.Text.TextSpan?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 4836, 4851);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan?
        f_693_5101_5112_M(Microsoft.CodeAnalysis.Text.TextSpan?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(693, 5101, 5112);
            return return_v;
        }

    }
}
