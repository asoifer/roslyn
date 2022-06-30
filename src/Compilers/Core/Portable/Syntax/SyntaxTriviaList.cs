// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    [StructLayout(LayoutKind.Auto)]
    public readonly partial struct SyntaxTriviaList : IEquatable<SyntaxTriviaList>, IReadOnlyList<SyntaxTrivia>
    {

        public static SyntaxTriviaList Empty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 863, 891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 866, 891);
                    return default(SyntaxTriviaList); DynAbs.Tracing.TraceSender.TraceExitMethod(706, 863, 891);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 863, 891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 863, 891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SyntaxTriviaList(in SyntaxToken token, GreenNode? node, int position, int index = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(706, 904, 1135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1022, 1036);

                Token = token;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1050, 1062);

                Node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1076, 1096);

                Position = position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1110, 1124);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(706, 904, 1135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 904, 1135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 904, 1135);
            }
        }

        internal SyntaxTriviaList(in SyntaxToken token, GreenNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(706, 1147, 1351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1236, 1250);

                Token = token;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1264, 1276);

                Node = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1290, 1316);

                Position = token.Position;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1330, 1340);

                Index = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(706, 1147, 1351);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 1147, 1351);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 1147, 1351);
            }
        }

        public SyntaxTriviaList(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(706, 1363, 1566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1432, 1461);

                Token = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1475, 1504);

                Node = trivia.UnderlyingNode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1518, 1531);

                Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 1545, 1555);

                Index = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(706, 1363, 1566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 1363, 1566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 1363, 1566);
            }
        }

        public SyntaxTriviaList(params SyntaxTrivia[] trivias)
        : this(f_706_1802_1809_C(default), CreateNode(trivias), 0, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(706, 1727, 1859);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(706, 1727, 1859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 1727, 1859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 1727, 1859);
            }
        }

        public SyntaxTriviaList(IEnumerable<SyntaxTrivia>? trivias)
        : this(f_706_2102_2109_C(default), f_706_2111_2150(trivias).Node, 0, 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(706, 2022, 2184);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(706, 2022, 2184);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 2022, 2184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 2022, 2184);
            }
        }

        private static GreenNode? CreateNode(SyntaxTrivia[]? trivias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 2196, 2525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2282, 2362) || true) && (trivias == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 2282, 2362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2335, 2347);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 2282, 2362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2378, 2436);

                var
                builder = f_706_2392_2435(f_706_2420_2434(trivias))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2450, 2471);

                f_706_2450_2470(builder, trivias);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2485, 2514);

                return f_706_2492_2508(builder).Node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 2196, 2525);

                int
                f_706_2420_2434(Microsoft.CodeAnalysis.SyntaxTrivia[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 2420, 2434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_706_2392_2435(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 2392, 2435);
                    return return_v;
                }


                int
                f_706_2450_2470(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia[]
                items)
                {
                    this_param.Add(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 2450, 2470);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_706_2492_2508(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 2492, 2508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 2196, 2525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 2196, 2525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SyntaxToken Token { get; }

        internal GreenNode? Node { get; }

        internal int Position { get; }

        internal int Index { get; }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 2751, 2820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2757, 2818);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(706, 2764, 2776) || ((Node == null && DynAbs.Tracing.TraceSender.Conditional_F2(706, 2779, 2780)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 2783, 2817))) ? 0 : ((DynAbs.Tracing.TraceSender.Conditional_F1(706, 2784, 2795) || ((f_706_2784_2795(Node) && DynAbs.Tracing.TraceSender.Conditional_F2(706, 2798, 2812)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 2815, 2816))) ? f_706_2798_2812(Node) : 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(706, 2751, 2820);

                    bool
                    f_706_2784_2795(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 2784, 2795);
                        return return_v;
                    }


                    int
                    f_706_2798_2812(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 2798, 2812);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 2710, 2831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 2710, 2831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTrivia ElementAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 2843, 2938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 2908, 2927);

                return this[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 2843, 2938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 2843, 2938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 2843, 2938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Gets the trivia at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the trivia to get.</param>
        /// <returns>The token at the specified index.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index" /> is less than 0.-or-<paramref name="index" /> is equal to or greater than <see cref="Count" />. </exception>
        public SyntaxTrivia this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 3467, 4163);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3503, 4075) || true) && (Node != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 3503, 4075);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3561, 4056) || true) && (f_706_3565_3576(Node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 3561, 4056);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3626, 3865) || true) && (unchecked((uint)index < (uint)f_706_3660_3674(Node)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 3626, 3865);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3733, 3838);

                                return f_706_3740_3837(Token, f_706_3764_3783(Node, index), Position + f_706_3796_3821(Node, index), Index + index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(706, 3626, 3865);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(706, 3561, 4056);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 3561, 4056);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3915, 4056) || true) && (index == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 3915, 4056);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 3979, 4033);

                                return f_706_3986_4032(Token, Node, Position, Index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(706, 3915, 4056);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(706, 3561, 4056);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(706, 3503, 4075);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 4095, 4148);

                    throw f_706_4101_4147(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(706, 3467, 4163);

                    bool
                    f_706_3565_3576(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.IsList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 3565, 3576);
                        return return_v;
                    }


                    int
                    f_706_3660_3674(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.SlotCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 3660, 3674);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.GreenNode?
                    f_706_3764_3783(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlot(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 3764, 3783);
                        return return_v;
                    }


                    int
                    f_706_3796_3821(Microsoft.CodeAnalysis.GreenNode
                    this_param, int
                    index)
                    {
                        var return_v = this_param.GetSlotOffset(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 3796, 3821);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_706_3740_3837(Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.GreenNode?
                    triviaNode, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 3740, 3837);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxTrivia
                    f_706_3986_4032(Microsoft.CodeAnalysis.SyntaxToken
                    token, Microsoft.CodeAnalysis.GreenNode
                    triviaNode, int
                    position, int
                    index)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 3986, 4032);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_706_4101_4147(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 4101, 4147);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 3467, 4163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 3467, 4163);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 4423, 4647);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 4459, 4561) || true) && (Node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 4459, 4561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 4517, 4542);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(706, 4459, 4561);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 4581, 4632);

                    return f_706_4588_4631(this.Position, f_706_4616_4630(Node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(706, 4423, 4647);

                    int
                    f_706_4616_4630(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 4616, 4630);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_706_4588_4631(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 4588, 4631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 4374, 4658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 4374, 4658);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 4907, 5228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 4943, 5045) || true) && (Node == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 4943, 5045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 5001, 5026);

                        return default(TextSpan);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(706, 4943, 5045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 5065, 5213);

                    return TextSpan.FromBounds(Position + f_706_5103_5131(Node), Position + f_706_5165_5179(Node) - f_706_5182_5211(Node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(706, 4907, 5228);

                    int
                    f_706_5103_5131(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetLeadingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 5103, 5131);
                        return return_v;
                    }


                    int
                    f_706_5165_5179(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 5165, 5179);
                        return return_v;
                    }


                    int
                    f_706_5182_5211(Microsoft.CodeAnalysis.GreenNode
                    this_param)
                    {
                        var return_v = this_param.GetTrailingTriviaWidth();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 5182, 5211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 4862, 5239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 4862, 5239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxTrivia First()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 5507, 5697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 5559, 5632) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 5559, 5632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 5602, 5617);

                    return this[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 5559, 5632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 5648, 5686);

                throw f_706_5654_5685();
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 5507, 5697);

                System.InvalidOperationException
                f_706_5654_5685()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 5654, 5685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 5507, 5697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 5507, 5697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTrivia Last()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 5963, 6165);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6014, 6100) || true) && (Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 6014, 6100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6057, 6085);

                    return this[this.Count - 1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 6014, 6100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6116, 6154);

                throw f_706_6122_6153();
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 5963, 6165);

                System.InvalidOperationException
                f_706_6122_6153()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 6122, 6153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 5963, 6165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 5963, 6165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Any()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 6268, 6341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6310, 6330);

                return Node != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 6268, 6341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 6268, 6341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 6268, 6341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Reversed Reverse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 6644, 6731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6694, 6720);

                return f_706_6701_6719(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 6644, 6731);

                Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed
                f_706_6701_6719(Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Reversed(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 6701, 6719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 6644, 6731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 6644, 6731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Enumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 6743, 6843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6801, 6832);

                return f_706_6808_6831(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 6743, 6843);

                Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator
                f_706_6808_6831(Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.Enumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 6808, 6831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 6743, 6843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 6743, 6843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int IndexOf(SyntaxTrivia triviaInList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 6855, 7188);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6934, 6939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6941, 6955);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6925, 7151) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 6964, 6967)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(706, 6925, 7151))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 6925, 7151);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7001, 7022);

                        var
                        trivia = this[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7040, 7136) || true) && (trivia == triviaInList)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 7040, 7136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7108, 7117);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(706, 7040, 7136);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(706, 1, 227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(706, 1, 227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7167, 7177);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 6855, 7188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 6855, 7188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 6855, 7188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int IndexOf(int rawKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 7200, 7486);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7267, 7272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7274, 7288);
                    for (int
        i = 0
        ,
        n = this.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7258, 7449) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7297, 7300)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(706, 7258, 7449))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 7258, 7449);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7334, 7434) || true) && (this[i].RawKind == rawKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 7334, 7434);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7406, 7415);

                            return i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(706, 7334, 7434);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(706, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(706, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7465, 7475);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 7200, 7486);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 7200, 7486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 7200, 7486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList Add(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 7708, 7826);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 7781, 7815);

                return Insert(this.Count, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 7708, 7826);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 7708, 7826);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 7708, 7826);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList AddRange(IEnumerable<SyntaxTrivia> trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 8048, 8189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 8139, 8178);

                return InsertRange(this.Count, trivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 8048, 8189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 8048, 8189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 8048, 8189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList Insert(int index, SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 8507, 8803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 8594, 8732) || true) && (trivia == default(SyntaxTrivia))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 8594, 8732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 8663, 8717);

                    throw f_706_8669_8716(nameof(trivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 8594, 8732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 8748, 8792);

                return InsertRange(index, new[] { trivia });
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 8507, 8803);

                System.ArgumentOutOfRangeException
                f_706_8669_8716(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 8669, 8716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 8507, 8803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 8507, 8803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<SyntaxTriviaListBuilder> s_builderPool;

        private static SyntaxTriviaListBuilder GetBuilder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 9061, 9088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 9064, 9088);
                return f_706_9064_9088(s_builderPool); DynAbs.Tracing.TraceSender.TraceExitMethod(706, 9061, 9088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 9061, 9088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 9061, 9088);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
            f_706_9064_9088(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>
            this_param)
            {
                var return_v = this_param.Allocate();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 9064, 9088);
                return return_v;
            }

        }

        private static void ClearAndFreeBuilder(SyntaxTriviaListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 9101, 9704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 9501, 9532);

                const int
                MaxBuilderCount = 16
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 9546, 9693) || true) && (f_706_9550_9563(builder) <= MaxBuilderCount)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 9546, 9693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 9616, 9632);

                    f_706_9616_9631(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 9650, 9678);

                    f_706_9650_9677(s_builderPool, builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 9546, 9693);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 9101, 9704);

                int
                f_706_9550_9563(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 9550, 9563);
                    return return_v;
                }


                int
                f_706_9616_9631(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 9616, 9631);
                    return 0;
                }


                int
                f_706_9650_9677(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>
                this_param, Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 9650, 9677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 9101, 9704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 9101, 9704);
            }
        }

        public SyntaxTriviaList InsertRange(int index, IEnumerable<SyntaxTrivia> trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 10022, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10127, 10154);

                var
                thisCount = this.Count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10168, 10304) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(706, 10172, 10202) || index > thisCount))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 10168, 10304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10236, 10289);

                    throw f_706_10242_10288(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 10168, 10304);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10320, 10435) || true) && (trivia == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 10320, 10435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10372, 10420);

                    throw f_706_10378_10419(nameof(trivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 10320, 10435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10531, 10590);

                var
                triviaCollection = trivia as ICollection<SyntaxTrivia>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10604, 10724) || true) && (triviaCollection != null && (DynAbs.Tracing.TraceSender.Expression_True(706, 10608, 10663) && f_706_10636_10658(triviaCollection) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 10604, 10724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10697, 10709);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 10604, 10724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10740, 10767);

                var
                builder = GetBuilder()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10826, 10831);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10817, 10929) || true) && (i < index)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10844, 10847)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(706, 10817, 10929))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 10817, 10929);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10889, 10910);

                            f_706_10889_10909(builder, this[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(706, 1, 113);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(706, 1, 113);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10949, 10974);

                    f_706_10949_10973(
                                    builder, trivia);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11003, 11012);

                        for (int
        i = index
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 10994, 11114) || true) && (i < thisCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11029, 11032)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(706, 10994, 11114))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 10994, 11114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11074, 11095);

                            f_706_11074_11094(builder, this[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(706, 1, 121);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(706, 1, 121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11134, 11194);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(706, 11141, 11167) || ((f_706_11141_11154(builder) == thisCount && DynAbs.Tracing.TraceSender.Conditional_F2(706, 11170, 11174)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 11177, 11193))) ? this : f_706_11177_11193(builder);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(706, 11223, 11307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11263, 11292);

                    ClearAndFreeBuilder(builder);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(706, 11223, 11307);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 10022, 11318);

                System.ArgumentOutOfRangeException
                f_706_10242_10288(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 10242, 10288);
                    return return_v;
                }


                System.ArgumentNullException
                f_706_10378_10419(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 10378, 10419);
                    return return_v;
                }


                int
                f_706_10636_10658(System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.SyntaxTrivia>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 10636, 10658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_706_10889_10909(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 10889, 10909);
                    return return_v;
                }


                int
                f_706_10949_10973(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 10949, 10973);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_706_11074_11094(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11074, 11094);
                    return return_v;
                }


                int
                f_706_11141_11154(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 11141, 11154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_706_11177_11193(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11177, 11193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 10022, 11318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 10022, 11318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 11570, 11999);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11638, 11776) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(706, 11642, 11674) || index >= this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 11638, 11776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11708, 11761);

                    throw f_706_11714_11760(nameof(index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 11638, 11776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11792, 11817);

                // LAFHIS
                //var list = f_706_11803_11816(ref this);
                var list = this.ToList<Microsoft.CodeAnalysis.SyntaxTrivia>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11803, 11816);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11831, 11852);

                f_706_11831_11851(list, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 11866, 11988);

                return f_706_11873_11987(default(SyntaxToken), f_706_11916_11980(list, static n => n.RequiredUnderlyingNode), 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 11570, 11999);

                System.ArgumentOutOfRangeException
                f_706_11714_11760(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11714, 11760);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_706_11803_11816(ref Microsoft.CodeAnalysis.SyntaxTriviaList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11803, 11816);
                    return return_v;
                }


                int
                f_706_11831_11851(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11831, 11851);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_706_11916_11980(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11916, 11980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_706_11873_11987(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 11873, 11987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 11570, 11999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 11570, 11999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList Remove(SyntaxTrivia triviaInList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 12230, 12517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 12312, 12351);

                var
                index = this.IndexOf(triviaInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 12365, 12478) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(706, 12369, 12401) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 12365, 12478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 12435, 12463);

                    return this.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 12365, 12478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 12494, 12506);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 12230, 12517);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 12230, 12517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 12230, 12517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList Replace(SyntaxTrivia triviaInList, SyntaxTrivia newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 12851, 13184);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 12958, 13102) || true) && (newTrivia == default(SyntaxTrivia))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 12958, 13102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13030, 13087);

                    throw f_706_13036_13086(nameof(newTrivia));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 12958, 13102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13118, 13173);

                return ReplaceRange(triviaInList, new[] { newTrivia });
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 12851, 13184);

                System.ArgumentOutOfRangeException
                f_706_13036_13086(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13036, 13086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 12851, 13184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 12851, 13184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SyntaxTriviaList ReplaceRange(SyntaxTrivia triviaInList, IEnumerable<SyntaxTrivia> newTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 13518, 14125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13643, 13682);

                var
                index = this.IndexOf(triviaInList)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13696, 14038) || true) && (index >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(706, 13700, 13732) && index < this.Count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 13696, 14038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13766, 13791);

                    // LAFHIS
                    //var list = f_706_13777_13790(ref this);
                    var list = this.ToList<Microsoft.CodeAnalysis.SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13777, 13790);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13809, 13830);

                    f_706_13809_13829(list, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13848, 13883);

                    f_706_13848_13882(list, index, newTrivia);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 13901, 14023);

                    return f_706_13908_14022(default(SyntaxToken), f_706_13951_14015(list, static n => n.RequiredUnderlyingNode), 0, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 13696, 14038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14054, 14114);

                throw f_706_14060_14113(nameof(triviaInList));
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 13518, 14125);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_706_13777_13790(ref Microsoft.CodeAnalysis.SyntaxTriviaList
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13777, 13790);
                    return return_v;
                }


                int
                f_706_13809_13829(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13809, 13829);
                    return 0;
                }


                int
                f_706_13848_13882(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                this_param, int
                index, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
                collection)
                {
                    this_param.InsertRange(index, collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13848, 13882);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_706_13951_14015(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTrivia>
                list, System.Func<Microsoft.CodeAnalysis.SyntaxTrivia, Microsoft.CodeAnalysis.GreenNode>
                select)
                {
                    var return_v = GreenNode.CreateList(list, select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13951, 14015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_706_13908_14022(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 13908, 14022);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_706_14060_14113(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14060, 14113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 13518, 14125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 13518, 14125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxTrivia[] Nodes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 14192, 14209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14195, 14209);
                    
                    // LAFHIS
                    //return f_706_14195_14209(ref this);

                    var return_v = this.ToArray<Microsoft.CodeAnalysis.SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14195, 14209);
                    return return_v;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(706, 14192, 14209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 14192, 14209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 14192, 14209);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerator<SyntaxTrivia> IEnumerable<SyntaxTrivia>.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 14222, 14503);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14314, 14441) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 14314, 14441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14364, 14426);

                    return f_706_14371_14425();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 14314, 14441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14457, 14492);

                // LAFHIS
                return f_706_14464_14491(this);

                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 14222, 14503);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_706_14371_14425()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14371, 14425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.EnumeratorImpl
                f_706_14464_14491(Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14464, 14491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 14222, 14503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 14222, 14503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 14515, 14768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14579, 14706) || true) && (Node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 14579, 14706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14629, 14691);

                    return f_706_14636_14690();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 14579, 14706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14722, 14757);

                return f_706_14729_14756(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 14515, 14768);

                System.Collections.Generic.IEnumerator<Microsoft.CodeAnalysis.SyntaxTrivia>
                f_706_14636_14690()
                {
                    var return_v = SpecializedCollections.EmptyEnumerator<SyntaxTrivia>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14636, 14690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList.EnumeratorImpl
                f_706_14729_14756(Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList.EnumeratorImpl(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14729, 14756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 14515, 14768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 14515, 14768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GreenNode? GetGreenNodeAt(int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 14880, 15030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14945, 14974);

                f_706_14945_14973(Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 14988, 15019);

                return GetGreenNodeAt(Node, i);
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 14880, 15030);

                int
                f_706_14945_14973(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14945, 14973);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 14880, 15030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 14880, 15030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GreenNode? GetGreenNodeAt(GreenNode node, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 15042, 15253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15130, 15184);

                f_706_15130_15183(f_706_15143_15154(node) || (DynAbs.Tracing.TraceSender.Expression_False(706, 15143, 15182) || (i == 0 && (DynAbs.Tracing.TraceSender.Expression_True(706, 15159, 15181) && f_706_15169_15181_M(!node.IsList)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15198, 15242);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(706, 15205, 15216) || ((f_706_15205_15216(node) && DynAbs.Tracing.TraceSender.Conditional_F2(706, 15219, 15234)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 15237, 15241))) ? f_706_15219_15234(node, i) : node;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 15042, 15253);

                bool
                f_706_15143_15154(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 15143, 15154);
                    return return_v;
                }


                bool
                f_706_15169_15181_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 15169, 15181);
                    return return_v;
                }


                int
                f_706_15130_15183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 15130, 15183);
                    return 0;
                }


                bool
                f_706_15205_15216(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(706, 15205, 15216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_706_15219_15234(Microsoft.CodeAnalysis.GreenNode
                this_param, int
                index)
                {
                    var return_v = this_param.GetSlot(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 15219, 15234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15042, 15253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15042, 15253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SyntaxTriviaList other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 15265, 15422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15332, 15411);

                return Node == other.Node && (DynAbs.Tracing.TraceSender.Expression_True(706, 15339, 15381) && Index == other.Index) && (DynAbs.Tracing.TraceSender.Expression_True(706, 15339, 15410) && Token.Equals(other.Token));
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 15265, 15422);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15265, 15422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15265, 15422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxTriviaList left, SyntaxTriviaList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 15434, 15573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15536, 15562);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 15434, 15573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15434, 15573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15434, 15573);
            }
        }

        public static bool operator !=(SyntaxTriviaList left, SyntaxTriviaList right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 15585, 15725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15687, 15714);

                return !left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 15585, 15725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15585, 15725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15585, 15725);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 15737, 15867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15802, 15856);

                return (obj is SyntaxTriviaList list) && (DynAbs.Tracing.TraceSender.Expression_True(706, 15809, 15855) && Equals(list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 15737, 15867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15737, 15867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15737, 15867);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 15879, 16016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 15937, 16005);

                return f_706_15944_16004(Token.GetHashCode(), f_706_15978_16003(Node, Index));
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 15879, 16016);

                int
                f_706_15978_16003(Microsoft.CodeAnalysis.GreenNode?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 15978, 16003);
                    return return_v;
                }


                int
                f_706_15944_16004(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 15944, 16004);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 15879, 16016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 15879, 16016);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CopyTo(int offset, SyntaxTrivia[] array, int arrayOffset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 16261, 17189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16368, 16512) || true) && (offset < 0 || (DynAbs.Tracing.TraceSender.Expression_False(706, 16372, 16395) || count < 0) || (DynAbs.Tracing.TraceSender.Expression_False(706, 16372, 16426) || this.Count < offset + count))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 16368, 16512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16460, 16497);

                    throw f_706_16466_16496();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 16368, 16512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16528, 16598) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 16528, 16598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16576, 16583);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(706, 16528, 16598);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16674, 16699);

                var
                first = this[offset]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16713, 16740);

                array[arrayOffset] = first;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16835, 16865);

                var
                position = first.Position
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16879, 16899);

                var
                current = first
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16924, 16929);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16915, 17178) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16942, 16945)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(706, 16915, 17178))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(706, 16915, 17178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 16979, 17009);

                        position += current.FullWidth;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 17027, 17110);

                        current = f_706_17037_17109(Token, GetGreenNodeAt(offset + i), position, Index + i);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 17130, 17163);

                        array[arrayOffset + i] = current;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(706, 1, 264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(706, 1, 264);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 16261, 17189);

                System.IndexOutOfRangeException
                f_706_16466_16496()
                {
                    var return_v = new System.IndexOutOfRangeException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 16466, 16496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_706_17037_17109(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode?
                triviaNode, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTrivia(token, triviaNode, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 17037, 17109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 16261, 17189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 16261, 17189);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 17201, 17323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 17259, 17312);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(706, 17266, 17278) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(706, 17281, 17296)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 17299, 17311))) ? f_706_17281_17296(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 17201, 17323);

                string
                f_706_17281_17296(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 17281, 17296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 17201, 17323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 17201, 17323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ToFullString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(706, 17335, 17456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 17388, 17445);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(706, 17395, 17407) || ((Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(706, 17410, 17429)) || DynAbs.Tracing.TraceSender.Conditional_F3(706, 17432, 17444))) ? f_706_17410_17429(Node) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(706, 17335, 17456);

                string
                f_706_17410_17429(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.ToFullString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 17410, 17429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 17335, 17456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 17335, 17456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxTriviaList Create(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(706, 17468, 17598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 17551, 17587);

                return f_706_17558_17586(trivia);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(706, 17468, 17598);

                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_706_17558_17586(Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 17558, 17586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(706, 17468, 17598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 17468, 17598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SyntaxTriviaList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(706, 665, 17605);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(706, 8875, 8983);
            s_builderPool = f_706_8904_8983(() => SyntaxTriviaListBuilder.Create()); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(706, 665, 17605);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(706, 665, 17605);
        }

        static Microsoft.CodeAnalysis.SyntaxToken
        f_706_1802_1809_C(Microsoft.CodeAnalysis.SyntaxToken
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(706, 1727, 1859);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTriviaList
        f_706_2111_2150(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>?
        trivia)
        {
            var return_v = SyntaxTriviaListBuilder.Create(trivia);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 2111, 2150);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxToken
        f_706_2102_2109_C(Microsoft.CodeAnalysis.SyntaxToken
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(706, 2022, 2184);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>
        f_706_8904_8983(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 8904, 8983);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTrivia[]
        f_706_14195_14209(ref Microsoft.CodeAnalysis.SyntaxTriviaList
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTrivia>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(706, 14195, 14209);
            return return_v;
        }

    }
}
