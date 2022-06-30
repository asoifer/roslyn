// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [StructLayout(LayoutKind.Auto)]
    public readonly partial struct SyntaxTokenList : IEquatable<SyntaxTokenList>, IReadOnlyList<SyntaxToken>
    {

        private readonly SyntaxNode? _parent;

        private readonly int _index;

        internal SyntaxTokenList(SyntaxNode? parent, GreenNode? tokenOrList, int position, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(698, 864, 1344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 982, 1067);

                f_698_982_1066(tokenOrList != null || (DynAbs.Tracing.TraceSender.Expression_False(698, 995, 1065) || (position == 0 && (DynAbs.Tracing.TraceSender.Expression_True(698, 1019, 1046) && index == 0) && (DynAbs.Tracing.TraceSender.Expression_True(698, 1019, 1064) && parent == null))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1081, 1109);

                f_698_1081_1108(position >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1123, 1206);

                f_698_1123_1205(tokenOrList == null || (DynAbs.Tracing.TraceSender.Expression_False(698, 1136, 1180) || (f_698_1160_1179(tokenOrList))) || (DynAbs.Tracing.TraceSender.Expression_False(698, 1136, 1204) || (f_698_1185_1203(tokenOrList))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1220, 1237);

                _parent = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1251, 1270);

                Node = tokenOrList;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1284, 1304);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1318, 1333);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(698, 864, 1344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 864, 1344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 864, 1344);
            }
        }

        public SyntaxTokenList(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(698, 1356, 1553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1422, 1445);

                _parent = token.Parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1459, 1477);

                Node = token.Node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1491, 1517);

                Position = token.Position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 1531, 1542);

                _index = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(698, 1356, 1553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 1356, 1553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 1356, 1553);
            }
        }

        public SyntaxTokenList(params SyntaxToken[] tokens)
        : this(f_698_1785_1789_C(null), CreateNode(tokens), 0, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(698, 1713, 1838);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(698, 1713, 1838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 1713, 1838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 1713, 1838);
            }
        }

        public SyntaxTokenList(IEnumerable<SyntaxToken> tokens)
        : this(f_698_2012_2016_C(null), CreateNode(tokens), 0, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(698, 1936, 2065);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(698, 1936, 2065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 1936, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 1936, 2065);
            }
        }

        private static GreenNode? CreateNode(SyntaxToken[] tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 2077, 2722);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2160, 2239) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 2160, 2239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2212, 2224);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 2160, 2239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2400, 2456);

                var
                builder = f_698_2414_2455(f_698_2441_2454(tokens))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2479, 2484);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2470, 2666) || true) && (i < f_698_2490_2503(tokens))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2505, 2508)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(698, 2470, 2666))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 2470, 2666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2542, 2568);

                        var
                        node = tokens[i].Node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2586, 2615);

                        f_698_2586_2614(node is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2633, 2651);

                        f_698_2633_2650(builder, node);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(698, 1, 197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(698, 1, 197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2682, 2711);

                return f_698_2689_2705(builder).Node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 2077, 2722);

                int
                f_698_2441_2454(Microsoft.CodeAnalysis.SyntaxToken[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 2441, 2454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                f_698_2414_2455(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 2414, 2455);
                    return return_v;
                }


                int
                f_698_2490_2503(Microsoft.CodeAnalysis.SyntaxToken[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 2490, 2503);
                    return return_v;
                }


                int
                f_698_2586_2614(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 2586, 2614);
                    return 0;
                }


                int
                f_698_2633_2650(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 2633, 2650);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_2689_2705(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 2689, 2705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 2077, 2722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 2077, 2722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GreenNode? CreateNode(IEnumerable<SyntaxToken> tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 2734, 3193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2828, 2907) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 2828, 2907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2880, 2892);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 2828, 2907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2923, 2969);

                var
                builder = f_698_2937_2968()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 2983, 3137);
                    foreach (var token in f_698_3005_3011_I(tokens))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 2983, 3137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 3045, 3080);

                        f_698_3045_3079(token.Node is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 3098, 3122);

                        f_698_3098_3121(builder, token.Node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(698, 2983, 3137);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(698, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(698, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 3153, 3182);

                return f_698_3160_3176(builder).Node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 2734, 3193);

                Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                f_698_2937_2968()
                {
                    var return_v = SyntaxTokenListBuilder.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 2937, 2968);
                    return return_v;
                }


                int
                f_698_3045_3079(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 3045, 3079);
                    return 0;
                }


                int
                f_698_3098_3121(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 3098, 3121);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_3005_3011_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 3005, 3011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_3160_3176(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 3160, 3176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 2734, 3193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 2734, 3193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? Node { get; }

        internal int Position { get; }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 3411, 3467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 3414, 3467);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(698, 3414, 3426) || ((Node == null && DynAbs.Tracing.TraceSender.Conditional_F2(698, 3429, 3430)) || DynAbs.Tracing.TraceSender.Conditional_F3(698, 3433, 3467))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(698, 3434, 3445) || ((f_698_3434_3445(Node) && DynAbs.Tracing.TraceSender.Conditional_F2(698, 3448, 3462)) || DynAbs.Tracing.TraceSender.Conditional_F3(698, 3465, 3466))) ? f_698_3448_3462(Node) : 1); DynAbs.Tracing.TraceSender.TraceExitMethod(698, 3411, 3467);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 3411, 3467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 3411, 3467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Gets the token at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the token to get.</param>
        /// <returns>The token at the specified index.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="Count" />. </exception>
        public SyntaxToken this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 3994, 4694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4030, 4606) || true) && (Node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4030, 4606);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4088, 4587) || true) && (f_698_4092_4103(Node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4088, 4587);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4153, 4394) || true) && (unchecked((uint)index < (uint)f_698_4187_4201(Node)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4153, 4394);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4260, 4367);

                                return f_698_4267_4366(_parent, f_698_4292_4311(Node, index), Position + f_698_4324_4349(Node, index), _index + index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4153, 4394);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4088, 4587);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4088, 4587);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4444, 4587) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4444, 4587);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4508, 4564);

                                return f_698_4515_4563(_parent, Node, Position, _index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4444, 4587);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4088, 4587);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4030, 4606);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4626, 4679);

                    throw f_698_4632_4678(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(698, 3994, 4694);

                    bool
                    f_698_4092_4103(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 4092, 4103);
                        return return_v;
                    }


                    int
                    f_698_4187_4201(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 4187, 4201);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_698_4292_4311(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 4292, 4311);
                        return return_v;
                    }


                    int
                    f_698_4324_4349(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlotOffset(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 4324, 4349);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_698_4267_4366(Microsoft.CodeAnalysis.SyntaxNode?
                    parent, Microsoft.CodeAnalysis.GreenNode?
                    token, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 4267, 4366);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_698_4515_4563(Microsoft.CodeAnalysis.SyntaxNode?
                    parent, Microsoft.CodeAnalysis.GreenNode
                    token, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxToken(parent, token, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 4515, 4563);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_698_4632_4678(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 4632, 4678);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 3994, 4694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 3994, 4694);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 4954, 5178);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 4990, 5092) || true) && (Node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 4990, 5092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 5048, 5073);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(698, 4990, 5092);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 5112, 5163);

                    return f_698_5119_5162(this.Position, f_698_5147_5161(Node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(698, 4954, 5178);

                    int
                    f_698_5147_5161(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 5147, 5161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_698_5119_5162(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 5119, 5162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 4905, 5189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 4905, 5189);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 5438, 5759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 5474, 5576) || true) && (Node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 5474, 5576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 5532, 5557);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(698, 5474, 5576);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 5596, 5744);

                    return TextSpan.FromBounds(Position + f_698_5634_5662(Node), Position + f_698_5696_5710(Node) - f_698_5713_5742(Node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(698, 5438, 5759);

                    int
                    f_698_5634_5662(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 5634, 5662);
                        return return_v;
                    }


                    int
                    f_698_5696_5710(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 5696, 5710);
                        return return_v;
                    }


                    int
                    f_698_5713_5742(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 5713, 5742);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 5393, 5770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 5393, 5770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 6216, 6338);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 6274, 6327);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(698, 6281, 6293) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(698, 6296, 6311)) || DynAbs.Tracing.TraceSender.Conditional_F3(698, 6314, 6326))) ? f_698_6296_6311(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 6216, 6338);

                string
                f_698_6296_6311(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 6296, 6311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 6216, 6338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 6216, 6338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 6784, 6905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 6837, 6894);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(698, 6844, 6856) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(698, 6859, 6878)) || DynAbs.Tracing.TraceSender.Conditional_F3(698, 6881, 6893))) ? f_698_6859_6878(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 6784, 6905);

                string
                f_698_6859_6878(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 6859, 6878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 6784, 6905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 6784, 6905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 7171, 7360);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7222, 7295) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 7222, 7295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7265, 7280);

                    return this[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 7222, 7295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7311, 7349);

                throw f_698_7317_7348();
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 7171, 7360);

                System.InvalidOperationException
                f_698_7317_7348()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 7317, 7348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 7171, 7360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 7171, 7360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxToken Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 7625, 7826);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7675, 7761) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 7675, 7761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7718, 7746);

                    return this[this.Count - 1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 7675, 7761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 7777, 7815);

                throw f_698_7783_7814();
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 7625, 7826);

                System.InvalidOperationException
                f_698_7783_7814()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 7783, 7814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 7625, 7826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 7625, 7826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 8005, 8078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8047, 8067);

                return Node != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 8005, 8078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 8005, 8078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 8005, 8078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Reversed Reverse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 8379, 8466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8429, 8455);

                return f_698_8436_8454(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 8379, 8466);

                Microsoft.CodeAnalysis.SyntaxTokenList.Reversed
                f_698_8436_8454(Microsoft.CodeAnalysis.SyntaxTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Reversed(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 8436, 8454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 8379, 8466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 8379, 8466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CopyTo(int offset, GreenNode?[] array, int arrayOffset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 8478, 8784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8583, 8626);

                f_698_8583_8625(this.Count >= offset + count);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8651, 8656);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8642, 8773) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8669, 8672)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(698, 8642, 8773))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 8642, 8773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8706, 8758);

                        array[arrayOffset + i] = GetGreenNodeAt(offset + i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(698, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(698, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 8478, 8784);

                int
                f_698_8583_8625(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 8583, 8625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 8478, 8784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 8478, 8784);
            }
        }

        private GreenNode? GetGreenNodeAt(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 8893, 9043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 8958, 8987);

                f_698_8958_8986(Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9001, 9032);

                return GetGreenNodeAt(Node, i);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 8893, 9043);

                int
                f_698_8958_8986(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 8958, 8986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 8893, 9043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 8893, 9043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GreenNode? GetGreenNodeAt(GreenNode node, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 9152, 9363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9240, 9294);

                f_698_9240_9293(f_698_9253_9264(node) || (DynAbs.Tracing.TraceSender.Expression_False(698, 9253, 9292) || (i == 0 && (DynAbs.Tracing.TraceSender.Expression_True(698, 9269, 9291) && f_698_9279_9291_M(!node.IsList)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9308, 9352);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(698, 9315, 9326) || ((f_698_9315_9326(node) && DynAbs.Tracing.TraceSender.Conditional_F2(698, 9329, 9344)) || DynAbs.Tracing.TraceSender.Conditional_F3(698, 9347, 9351))) ? f_698_9329_9344(node, i) : node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 9152, 9363);

                bool
                f_698_9253_9264(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 9253, 9264);
                    return return_v;
                }


                bool
                f_698_9279_9291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 9279, 9291);
                    return return_v;
                }


                int
                f_698_9240_9293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 9240, 9293);
                    return 0;
                }


                bool
                f_698_9315_9326(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 9315, 9326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_698_9329_9344(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 9329, 9344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 9152, 9363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 9152, 9363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(SyntaxToken tokenInList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 9375, 9703);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9452, 9457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9459, 9473);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9443, 9666) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9482, 9485)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(698, 9443, 9666))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 9443, 9666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9519, 9539);

                        var
                        token = this[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9557, 9651) || true) && (token == tokenInList)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 9557, 9651);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9623, 9632);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(698, 9557, 9651);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(698, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(698, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9682, 9692);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 9375, 9703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 9375, 9703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 9375, 9703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int IndexOf(int rawKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 9715, 10001);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9782, 9787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9789, 9803);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9773, 9964) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9812, 9815)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(698, 9773, 9964))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 9773, 9964);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9849, 9949) || true) && (this[i].RawKind == rawKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 9849, 9949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9921, 9930);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(698, 9849, 9949);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(698, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(698, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 9980, 9990);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 9715, 10001);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 9715, 10001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 9715, 10001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList Add(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 10219, 10333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 10289, 10322);

                return Insert(this.Count, token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 10219, 10333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 10219, 10333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 10219, 10333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList AddRange(IEnumerable<SyntaxToken> tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 10554, 10693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 10643, 10682);

                return InsertRange(this.Count, tokens);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 10554, 10693);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 10554, 10693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 10554, 10693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList Insert(int index, SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 10993, 11282);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11077, 11212) || true) && (token == default(SyntaxToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 11077, 11212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11144, 11197);

                    throw f_698_11150_11196(nameof(token));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 11077, 11212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11228, 11271);

                return InsertRange(index, new[] { token });
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 10993, 11282);

                System.ArgumentOutOfRangeException
                f_698_11150_11196(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 11150, 11196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 10993, 11282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 10993, 11282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList InsertRange(int index, IEnumerable<SyntaxToken> tokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 11586, 12401);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11689, 11826) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(698, 11693, 11724) || index > this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 11689, 11826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11758, 11811);

                    throw f_698_11764_11810(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 11689, 11826);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11842, 11957) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 11842, 11957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11894, 11942);

                    throw f_698_11900_11941(nameof(tokens));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 11842, 11957);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 11973, 12001);

                var
                items = f_698_11985_12000(tokens)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12015, 12096) || true) && (f_698_12019_12030(items) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 12015, 12096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12069, 12081);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 12015, 12096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12112, 12137);

                // LAFHIS
                //var list = f_698_12123_12136(ref this);
                var list = this.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12123, 12136);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12151, 12183);

                f_698_12151_12182(list, index, tokens);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12199, 12279) || true) && (f_698_12203_12213(list) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 12199, 12279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12252, 12264);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 12199, 12279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12295, 12390);

                return f_698_12302_12389(null, f_698_12328_12382(list, static n => n.RequiredNode), 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 11586, 12401);

                System.ArgumentOutOfRangeException
                f_698_11764_11810(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 11764, 11810);
                    return return_v;
                }


                System.ArgumentNullException
                f_698_11900_11941(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 11900, 11941);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_11985_12000(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 11985, 12000);
                    return return_v;
                }


                int
                f_698_12019_12030(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 12019, 12030);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_12123_12136(ref Microsoft.CodeAnalysis.SyntaxTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12123, 12136);
                    return return_v;
                }


                int
                f_698_12151_12182(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param, int
                index, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12151, 12182);
                    return 0;
                }


                int
                f_698_12203_12213(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 12203, 12213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_698_12328_12382(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12328, 12382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_12302_12389(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12302, 12389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 11586, 12401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 11586, 12401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 12639, 13040);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12706, 12844) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(698, 12710, 12742) || index >= this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 12706, 12844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12776, 12829);

                    throw f_698_12782_12828(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 12706, 12844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12860, 12885);

                // LAFHIS
                //var list = f_698_12871_12884(ref this);
                var list = this.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12871, 12884);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12899, 12920);

                f_698_12899_12919(list, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 12934, 13029);

                return f_698_12941_13028(null, f_698_12967_13021(list, static n => n.RequiredNode), 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 12639, 13040);

                System.ArgumentOutOfRangeException
                f_698_12782_12828(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12782, 12828);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_12871_12884(ref Microsoft.CodeAnalysis.SyntaxTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12871, 12884);
                    return return_v;
                }


                int
                f_698_12899_12919(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12899, 12919);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_698_12967_13021(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12967, 13021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_12941_13028(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 12941, 13028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 12639, 13040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 12639, 13040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList Remove(SyntaxToken tokenInList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 13258, 13537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 13337, 13375);

                var
                index = this.IndexOf(tokenInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 13389, 13498) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(698, 13393, 13426) && index <= this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 13389, 13498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 13460, 13483);

                    return RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 13389, 13498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 13514, 13526);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 13258, 13537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 13258, 13537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 13258, 13537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList Replace(SyntaxToken tokenInList, SyntaxToken newToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 13833, 14156);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 13935, 14076) || true) && (newToken == default(SyntaxToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 13935, 14076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14005, 14061);

                    throw f_698_14011_14060(nameof(newToken));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 13935, 14076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14092, 14145);

                return ReplaceRange(tokenInList, new[] { newToken });
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 13833, 14156);

                System.ArgumentOutOfRangeException
                f_698_14011_14060(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14011, 14060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 13833, 14156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 13833, 14156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTokenList ReplaceRange(SyntaxToken tokenInList, IEnumerable<SyntaxToken> newTokens)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 14453, 15028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14574, 14612);

                var
                index = this.IndexOf(tokenInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14626, 14942) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(698, 14630, 14663) && index <= this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 14626, 14942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14697, 14722);

                    //var list = f_698_14708_14721(ref this);
                    var list = this.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14708, 14721);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14740, 14761);

                    f_698_14740_14760(list, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14779, 14814);

                    f_698_14779_14813(list, index, newTokens);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14832, 14927);

                    return f_698_14839_14926(null, f_698_14865_14919(list, static n => n.RequiredNode), 0, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 14626, 14942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 14958, 15017);

                throw f_698_14964_15016(nameof(tokenInList));
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 14453, 15028);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_14708_14721(ref Microsoft.CodeAnalysis.SyntaxTokenList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14708, 14721);
                    return return_v;
                }


                int
                f_698_14740_14760(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14740, 14760);
                    return 0;
                }


                int
                f_698_14779_14813(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                this_param, int
                index, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14779, 14813);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_698_14865_14919(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxToken>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14865, 14919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_14839_14926(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14839, 14926);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_698_14964_15016(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 14964, 15016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 14453, 15028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 14453, 15028);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxToken[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 15094, 15111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15097, 15111);
                    
                    // LAFHIS
                    //return f_698_15097_15111(ref this);
                    var return_v = this.ToArray<Microsoft.CodeAnalysis.SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15097, 15111);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(698, 15094, 15111);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 15094, 15111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 15094, 15111);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 15258, 15358);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15316, 15347);

                return f_698_15323_15346(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 15258, 15358);

                Microsoft.CodeAnalysis.SyntaxTokenList.Enumerator
                f_698_15323_15346(Microsoft.CodeAnalysis.SyntaxTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15323, 15346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 15258, 15358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 15258, 15358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator<SyntaxToken> IEnumerable<SyntaxToken>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 15370, 15648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15460, 15586) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 15460, 15586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15510, 15571);

                    return f_698_15517_15570();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 15460, 15586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15602, 15637);

                return f_698_15609_15636(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 15370, 15648);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_15517_15570()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15517, 15570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList.EnumeratorImpl
                f_698_15609_15636(Microsoft.CodeAnalysis.SyntaxTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15609, 15636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 15370, 15648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 15370, 15648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 15660, 15912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15724, 15850) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(698, 15724, 15850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15774, 15835);

                    return f_698_15781_15834();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(698, 15724, 15850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 15866, 15901);

                return f_698_15873_15900(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 15660, 15912);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxToken>
                f_698_15781_15834()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15781, 15834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList.EnumeratorImpl
                f_698_15873_15900(Microsoft.CodeAnalysis.SyntaxTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15873, 15900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 15660, 15912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 15660, 15912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxTokenList left, SyntaxTokenList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 16233, 16370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 16333, 16359);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 16233, 16370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 16233, 16370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 16233, 16370);
            }
        }

        public static bool operator !=(SyntaxTokenList left, SyntaxTokenList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 16697, 16835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 16797, 16824);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 16697, 16835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 16697, 16835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 16697, 16835);
            }
        }

        public bool Equals(SyntaxTokenList other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 16847, 17004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 16913, 16993);

                return Node == other.Node && (DynAbs.Tracing.TraceSender.Expression_True(698, 16920, 16966) && _parent == other._parent) && (DynAbs.Tracing.TraceSender.Expression_True(698, 16920, 16992) && _index == other._index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 16847, 17004);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 16847, 17004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 16847, 17004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 17234, 17361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 17299, 17350);

                return obj is SyntaxTokenList list && (DynAbs.Tracing.TraceSender.Expression_True(698, 17306, 17349) && Equals(list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 17234, 17361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 17234, 17361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 17234, 17361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(698, 17497, 17657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 17612, 17646);

                return f_698_17619_17645(Node, _index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(698, 17497, 17657);

                int
                f_698_17619_17645(Microsoft.CodeAnalysis.GreenNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 17619, 17645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 17497, 17657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 17497, 17657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTokenList Create(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(698, 17827, 17952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(698, 17907, 17941);

                return f_698_17914_17940(token);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(698, 17827, 17952);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_698_17914_17940(Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 17914, 17940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(698, 17827, 17952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 17827, 17952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxTokenList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(698, 619, 17959);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(698, 619, 17959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(698, 619, 17959);
        }

        static int
        f_698_982_1066(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 982, 1066);
            return 0;
        }


        static int
        f_698_1081_1108(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 1081, 1108);
            return 0;
        }


        static bool
        f_698_1160_1179(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 1160, 1179);
            return return_v;
        }


        static bool
        f_698_1185_1203(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 1185, 1203);
            return return_v;
        }


        static int
        f_698_1123_1205(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 1123, 1205);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode?
        f_698_1785_1789_C(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(698, 1713, 1838);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode?
        f_698_2012_2016_C(Microsoft.CodeAnalysis.SyntaxNode?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(698, 1936, 2065);
            return return_v;
        }


        bool
        f_698_3434_3445(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.IsList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 3434, 3445);
            return return_v;
        }


        int
        f_698_3448_3462(Microsoft.CodeAnalysis.GreenNode
        this_param)
        {
            var return_v = this_param.SlotCount;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(698, 3448, 3462);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxToken[]
        f_698_15097_15111(ref Microsoft.CodeAnalysis.SyntaxTokenList
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxToken>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(698, 15097, 15111);
            return return_v;
        }

    }
}
