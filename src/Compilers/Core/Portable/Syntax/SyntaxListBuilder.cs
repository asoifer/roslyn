// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal class SyntaxListBuilder
    {
        private ArrayElement<GreenNode?>[] _nodes;

        public int Count { get; private set; }

        public SyntaxListBuilder(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(681, 451, 565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 384, 390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 401, 439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 510, 554);

                _nodes = new ArrayElement<GreenNode?>[size];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(681, 451, 565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 451, 565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 451, 565);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 577, 647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 621, 636);

                this.Count = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 577, 647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 577, 647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 577, 647);
            }
        }

        public void Add(SyntaxNode item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 659, 751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 716, 740);

                f_681_716_739(this, f_681_728_738(item));
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 659, 751);

                Microsoft.CodeAnalysis.GreenNode
                f_681_728_738(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 728, 738);
                    return return_v;
                }


                int
                f_681_716_739(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.AddInternal(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 716, 739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 659, 751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 659, 751);
            }
        }

        internal void AddInternal(GreenNode item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 763, 1121);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 829, 928) || true) && (item == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 829, 928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 879, 913);

                    throw f_681_885_912();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 829, 928);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 944, 1065) || true) && (f_681_948_953() >= f_681_957_970(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 944, 1065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1004, 1050);

                    f_681_1004_1049(this, (DynAbs.Tracing.TraceSender.Conditional_F1(681, 1014, 1024) || ((f_681_1014_1019() == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(681, 1027, 1028)) || DynAbs.Tracing.TraceSender.Conditional_F3(681, 1031, 1048))) ? 8 : f_681_1031_1044(_nodes) * 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 944, 1065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1081, 1110);

                _nodes[f_681_1088_1095_M(Count++)].Value = item;
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 763, 1121);

                System.ArgumentNullException
                f_681_885_912()
                {
                    var return_v = new System.ArgumentNullException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 885, 912);
                    return return_v;
                }


                int
                f_681_948_953()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 948, 953);
                    return return_v;
                }


                int
                f_681_957_970(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 957, 970);
                    return return_v;
                }


                int
                f_681_1014_1019()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1014, 1019);
                    return return_v;
                }


                int
                f_681_1031_1044(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1031, 1044);
                    return return_v;
                }


                int
                f_681_1004_1049(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 1004, 1049);
                    return 0;
                }


                int
                f_681_1088_1095_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1088, 1095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 763, 1121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 763, 1121);
            }
        }

        public void AddRange(SyntaxNode[] items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 1133, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1198, 1236);

                f_681_1198_1235(this, items, 0, f_681_1222_1234(items));
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 1133, 1247);

                int
                f_681_1222_1234(Microsoft.CodeAnalysis.SyntaxNode[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1222, 1234);
                    return return_v;
                }


                int
                f_681_1198_1235(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode[]
                items, int
                offset, int
                length)
                {
                    this_param.AddRange(items, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 1198, 1235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 1133, 1247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 1133, 1247);
            }
        }

        public void AddRange(SyntaxNode[] items, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 1259, 1728);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1348, 1457) || true) && (f_681_1352_1357() + length > f_681_1369_1382(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 1348, 1457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1416, 1442);

                    f_681_1416_1441(this, f_681_1426_1431() + length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 1348, 1457);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1482, 1492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1494, 1503);

                    for (int
        i = offset
        ,
        j = f_681_1498_1503()
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1473, 1616) || true) && (i < offset + length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1526, 1529)
        , ++i, DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1531, 1534)
        , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 1473, 1616))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 1473, 1616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1568, 1601);

                        _nodes[j].Value = f_681_1586_1600(items[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1632, 1650);

                int
                start = f_681_1644_1649()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1664, 1680);

                Count += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => length, 681, 1664, 1669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1694, 1717);

                f_681_1694_1716(this, start, f_681_1710_1715());
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 1259, 1728);

                int
                f_681_1352_1357()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1352, 1357);
                    return return_v;
                }


                int
                f_681_1369_1382(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1369, 1382);
                    return return_v;
                }


                int
                f_681_1426_1431()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1426, 1431);
                    return return_v;
                }


                int
                f_681_1416_1441(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 1416, 1441);
                    return 0;
                }


                int
                f_681_1498_1503()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1498, 1503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_681_1586_1600(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1586, 1600);
                    return return_v;
                }


                int
                f_681_1644_1649()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1644, 1649);
                    return return_v;
                }


                int
                f_681_1710_1715()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 1710, 1715);
                    return return_v;
                }


                int
                f_681_1694_1716(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                start, int
                end)
                {
                    this_param.Validate(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 1694, 1716);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 1259, 1728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 1259, 1728);
            }
        }

        [Conditional("DEBUG")]
        private void Validate(int start, int end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 1740, 2073);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1847, 1856);
                    for (int
        i = start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1838, 2062) || true) && (i < end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1867, 1870)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 1838, 2062))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 1838, 2062);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1904, 2047) || true) && (_nodes[i].Value == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 1904, 2047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 1973, 2028);

                            throw f_681_1979_2027("Cannot add a null node.");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(681, 1904, 2047);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 225);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 1740, 2073);

                System.ArgumentException
                f_681_1979_2027(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 1979, 2027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 1740, 2073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 1740, 2073);
            }
        }

        public void AddRange(SyntaxList<SyntaxNode> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 2085, 2205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2159, 2194);

                f_681_2159_2193(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 2085, 2205);

                int
                f_681_2159_2193(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                list, int
                offset, int
                count)
                {
                    this_param.AddRange(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 2159, 2193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 2085, 2205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 2085, 2205);
            }
        }

        public void AddRange(SyntaxList<SyntaxNode> list, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 2217, 2768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2314, 2426) || true) && (f_681_2318_2328(this) + count > f_681_2339_2352(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 2314, 2426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2386, 2411);

                    f_681_2386_2410(this, f_681_2396_2401() + count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 2314, 2426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2442, 2463);

                var
                dst = f_681_2452_2462(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2486, 2496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2498, 2520);
                    for (int
        i = offset
        ,
        limit = offset + count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2477, 2657) || true) && (i < limit)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2533, 2536)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 2477, 2657))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 2477, 2657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2570, 2618);

                        _nodes[dst].Value = f_681_2590_2617(list.ItemInternal(i)!);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2636, 2642);

                        dst++;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2673, 2691);

                int
                start = f_681_2685_2690()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2705, 2720);

                Count += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => count, 681, 2705, 2710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2734, 2757);

                f_681_2734_2756(this, start, f_681_2750_2755());
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 2217, 2768);

                int
                f_681_2318_2328(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2318, 2328);
                    return return_v;
                }


                int
                f_681_2339_2352(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2339, 2352);
                    return return_v;
                }


                int
                f_681_2396_2401()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2396, 2401);
                    return return_v;
                }


                int
                f_681_2386_2410(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 2386, 2410);
                    return 0;
                }


                int
                f_681_2452_2462(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2452, 2462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_681_2590_2617(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2590, 2617);
                    return return_v;
                }


                int
                f_681_2685_2690()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2685, 2690);
                    return return_v;
                }


                int
                f_681_2750_2755()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 2750, 2755);
                    return return_v;
                }


                int
                f_681_2734_2756(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                start, int
                end)
                {
                    this_param.Validate(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 2734, 2756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 2217, 2768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 2217, 2768);
            }
        }

        public void AddRange<TNode>(SyntaxList<TNode> list) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 2780, 2927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 2881, 2916);

                f_681_2881_2915(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 2780, 2927);

                int
                f_681_2881_2915(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<TNode>
                list, int
                offset, int
                count)
                {
                    this_param.AddRange<TNode>(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 2881, 2915);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 2780, 2927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 2780, 2927);
            }
        }

        public void AddRange<TNode>(SyntaxList<TNode> list, int offset, int count) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 2939, 3142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3063, 3131);

                f_681_3063_3130(this, f_681_3077_3114(list.Node), offset, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 2939, 3142);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_681_3077_3114(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3077, 3114);
                    return return_v;
                }


                int
                f_681_3063_3130(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                list, int
                offset, int
                count)
                {
                    this_param.AddRange(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3063, 3130);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 2939, 3142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 2939, 3142);
            }
        }

        public void AddRange(SyntaxNodeOrTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 3154, 3273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3227, 3262);

                f_681_3227_3261(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 3154, 3273);

                int
                f_681_3227_3261(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list, int
                offset, int
                count)
                {
                    this_param.AddRange(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3227, 3261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 3154, 3273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 3154, 3273);
            }
        }

        public void AddRange(SyntaxNodeOrTokenList list, int offset, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 3285, 3830);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3381, 3493) || true) && (f_681_3385_3395(this) + count > f_681_3406_3419(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 3381, 3493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3453, 3478);

                    f_681_3453_3477(this, f_681_3463_3468() + count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 3381, 3493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3509, 3530);

                var
                dst = f_681_3519_3529(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3553, 3563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3565, 3587);
                    for (int
        i = offset
        ,
        limit = offset + count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3544, 3719) || true) && (i < limit)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3600, 3603)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 3544, 3719))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 3544, 3719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3637, 3680);

                        _nodes[dst].Value = list[i].UnderlyingNode;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3698, 3704);

                        dst++;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3735, 3753);

                int
                start = f_681_3747_3752()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3767, 3782);

                Count += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => count, 681, 3767, 3772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3796, 3819);

                f_681_3796_3818(this, start, f_681_3812_3817());
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 3285, 3830);

                int
                f_681_3385_3395(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3385, 3395);
                    return return_v;
                }


                int
                f_681_3406_3419(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3406, 3419);
                    return return_v;
                }


                int
                f_681_3463_3468()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3463, 3468);
                    return return_v;
                }


                int
                f_681_3453_3477(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                size)
                {
                    this_param.Grow(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3453, 3477);
                    return 0;
                }


                int
                f_681_3519_3529(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3519, 3529);
                    return return_v;
                }


                int
                f_681_3747_3752()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3747, 3752);
                    return return_v;
                }


                int
                f_681_3812_3817()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 3812, 3817);
                    return return_v;
                }


                int
                f_681_3796_3818(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, int
                start, int
                end)
                {
                    this_param.Validate(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3796, 3818);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 3285, 3830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 3285, 3830);
            }
        }

        public void AddRange(SyntaxTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 3842, 3955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 3909, 3944);

                f_681_3909_3943(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 3842, 3955);

                int
                f_681_3909_3943(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                list, int
                offset, int
                length)
                {
                    this_param.AddRange(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 3909, 3943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 3842, 3955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 3842, 3955);
            }
        }

        public void AddRange(SyntaxTokenList list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 3967, 4198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4058, 4092);

                f_681_4058_4091(list.Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4106, 4187);

                f_681_4106_4186(this, f_681_4120_4169(f_681_4147_4168(list.Node)), offset, length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 3967, 4198);

                int
                f_681_4058_4091(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4058, 4091);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_681_4147_4168(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4147, 4168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_681_4120_4169(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4120, 4169);
                    return return_v;
                }


                int
                f_681_4106_4186(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                list, int
                offset, int
                count)
                {
                    this_param.AddRange(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4106, 4186);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 3967, 4198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 3967, 4198);
            }
        }

        private void Grow(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 4210, 4398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4262, 4307);

                var
                tmp = new ArrayElement<GreenNode?>[size]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4321, 4360);

                f_681_4321_4359(_nodes, tmp, f_681_4345_4358(_nodes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4374, 4387);

                _nodes = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 4210, 4398);

                int
                f_681_4345_4358(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 4345, 4358);
                    return return_v;
                }


                int
                f_681_4321_4359(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                sourceArray, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode?>[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4321, 4359);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 4210, 4398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 4210, 4398);
            }
        }

        public bool Any(int kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 4410, 4688);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4469, 4474);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4460, 4648) || true) && (i < f_681_4480_4485())
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4487, 4490)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4460, 4648))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4460, 4648);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4524, 4633) || true) && (f_681_4528_4552(_nodes[i].Value!) == kind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4524, 4633);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4602, 4614);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4524, 4633);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4664, 4677);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 4410, 4688);

                int
                f_681_4480_4485()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 4480, 4485);
                    return return_v;
                }


                int
                f_681_4528_4552(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.RawKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 4528, 4552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 4410, 4688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 4410, 4688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GreenNode? ToListNode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 4700, 5533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4757, 5522);

                switch (f_681_4765_4775(this))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4757, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4838, 4850);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4757, 5522);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4757, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4897, 4920);

                        return _nodes[0].Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4757, 5522);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4757, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 4967, 5041);

                        return f_681_4974_5040(_nodes[0].Value!, _nodes[1].Value!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4757, 5522);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4757, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5088, 5180);

                        return f_681_5095_5179(_nodes[0].Value!, _nodes[1].Value!, _nodes[2].Value!);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4757, 5522);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 4757, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5228, 5278);

                        var
                        tmp = new ArrayElement<GreenNode>[f_681_5266_5276(this)]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5309, 5314);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5300, 5440) || true) && (i < f_681_5320_5330(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5332, 5335)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(681, 5300, 5440))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 5300, 5440);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5385, 5417);

                                tmp[i].Value = _nodes[i].Value!;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(681, 1, 141);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(681, 1, 141);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5464, 5507);

                        return f_681_5471_5506(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(681, 4757, 5522);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 4700, 5533);

                int
                f_681_4765_4775(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 4765, 4775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_681_4974_5040(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 4974, 5040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_681_5095_5179(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 5095, 5179);
                    return return_v;
                }


                int
                f_681_5266_5276(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 5266, 5276);
                    return return_v;
                }


                int
                f_681_5320_5330(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 5320, 5330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_681_5471_5506(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = InternalSyntax.SyntaxList.List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 5471, 5506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 4700, 5533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 4700, 5533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxList<SyntaxNode>(SyntaxListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(681, 5545, 5809);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5651, 5758) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(681, 5651, 5758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5704, 5743);

                    return default(SyntaxList<SyntaxNode>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(681, 5651, 5758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5774, 5798);

                return f_681_5781_5797(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(681, 5545, 5809);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_681_5781_5797(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                builder)
                {
                    var return_v = builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(681, 5781, 5797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 5545, 5809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 5545, 5809);
            }
        }
        internal void RemoveLast()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(681, 5821, 5942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5872, 5888);

                this.Count -= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => 1, 681, 5872, 5882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(681, 5902, 5931);

                this._nodes[f_681_5914_5919()] = default;
                DynAbs.Tracing.TraceSender.TraceExitMethod(681, 5821, 5942);

                int
                f_681_5914_5919()
                {
                    var return_v = Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(681, 5914, 5919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(681, 5821, 5942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 5821, 5942);
            }
        }

        static SyntaxListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(681, 300, 5949);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(681, 300, 5949);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(681, 300, 5949);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(681, 300, 5949);
    }
}
