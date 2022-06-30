// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Syntax
{
    internal class SyntaxTokenListBuilder
    {
        private GreenNode?[] _nodes;

        private int _count;

        public SyntaxTokenListBuilder(int size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(701, 423, 553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 375, 381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 404, 410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 487, 517);

                _nodes = new GreenNode?[size];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 531, 542);

                _count = 0;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(701, 423, 553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 423, 553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 423, 553);
            }
        }

        public static SyntaxTokenListBuilder Create()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(701, 565, 683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 635, 672);

                return f_701_642_671(8);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(701, 565, 683);

                Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                f_701_642_671(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 642, 671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 565, 683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 565, 683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 736, 801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 772, 786);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(701, 736, 801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 695, 812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 695, 812);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Add(SyntaxToken item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 824, 961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 882, 916);

                f_701_882_915(item.Node is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 930, 950);

                f_701_930_949(this, item.Node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 824, 961);

                int
                f_701_882_915(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 882, 915);
                    return 0;
                }


                int
                f_701_930_949(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.GreenNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 930, 949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 824, 961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 824, 961);
            }
        }

        internal void Add(GreenNode item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 973, 1094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1031, 1045);

                f_701_1031_1044(this, 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1059, 1083);

                _nodes[_count++] = item;
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 973, 1094);

                int
                f_701_1031_1044(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, int
                delta)
                {
                    this_param.CheckSpace(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 1031, 1044);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 973, 1094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 973, 1094);
            }
        }

        public void Add(SyntaxTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 1106, 1209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1168, 1198);

                f_701_1168_1197(this, list, 0, list.Count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 1106, 1209);

                int
                f_701_1168_1197(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 1168, 1197);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 1106, 1209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 1106, 1209);
            }
        }

        public void Add(SyntaxTokenList list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 1221, 1426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1307, 1326);

                f_701_1307_1325(this, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1340, 1384);

                list.CopyTo(offset, _nodes, _count, length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1398, 1415);

                _count += length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 1221, 1426);

                int
                f_701_1307_1325(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, int
                delta)
                {
                    this_param.CheckSpace(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 1307, 1325);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 1221, 1426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 1221, 1426);
            }
        }

        public void Add(SyntaxToken[] list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 1438, 1540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1498, 1529);

                f_701_1498_1528(this, list, 0, f_701_1516_1527(list));
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 1438, 1540);

                int
                f_701_1516_1527(Microsoft.CodeAnalysis.SyntaxToken[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(701, 1516, 1527);
                    return return_v;
                }


                int
                f_701_1498_1528(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxToken[]
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 1498, 1528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 1438, 1540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 1438, 1540);
            }
        }

        public void Add(SyntaxToken[] list, int offset, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 1552, 1834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1636, 1655);

                f_701_1636_1654(this, length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1678, 1683);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1669, 1792) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1697, 1700)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(701, 1669, 1792))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 1669, 1792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1734, 1777);

                        _nodes[_count + i] = list[offset + i].Node;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(701, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(701, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1806, 1823);

                _count += length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 1552, 1834);

                int
                f_701_1636_1654(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, int
                delta)
                {
                    this_param.CheckSpace(delta);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 1636, 1654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 1552, 1834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 1552, 1834);
            }
        }

        private void CheckSpace(int delta)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 1846, 2069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1905, 1939);

                var
                requiredSize = _count + delta
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 1953, 2058) || true) && (requiredSize > f_701_1972_1985(_nodes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 1953, 2058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2019, 2043);

                    f_701_2019_2042(this, requiredSize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(701, 1953, 2058);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 1846, 2069);

                int
                f_701_1972_1985(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(701, 1972, 1985);
                    return return_v;
                }


                int
                f_701_2019_2042(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, int
                newSize)
                {
                    this_param.Grow(newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2019, 2042);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 1846, 2069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 1846, 2069);
            }
        }

        private void Grow(int newSize)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 2081, 2260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2136, 2169);

                var
                tmp = new GreenNode[newSize]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2183, 2222);

                f_701_2183_2221(_nodes, tmp, f_701_2207_2220(_nodes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2236, 2249);

                _nodes = tmp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 2081, 2260);

                int
                f_701_2207_2220(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(701, 2207, 2220);
                    return return_v;
                }


                int
                f_701_2183_2221(Microsoft.CodeAnalysis.GreenNode?[]
                sourceArray, Microsoft.CodeAnalysis.GreenNode[]
                destinationArray, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, (System.Array)destinationArray, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2183, 2221);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 2081, 2260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 2081, 2260);
            }
        }

        public SyntaxTokenList ToList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(701, 2272, 3413);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2328, 3402) || true) && (_count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2328, 3402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2376, 3289);

                    switch (_count)
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2376, 3289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2465, 2515);

                            return f_701_2472_2514(null, _nodes[0], 0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2376, 3289);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2376, 3289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2570, 2604);

                            f_701_2570_2603(_nodes[0] is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2630, 2664);

                            f_701_2630_2663(_nodes[1] is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2690, 2785);

                            return f_701_2697_2784(null, f_701_2723_2777(_nodes[0]!, _nodes[1]!), 0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2376, 3289);

                        case 3:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2376, 3289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2840, 2874);

                            f_701_2840_2873(_nodes[0] is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2900, 2934);

                            f_701_2900_2933(_nodes[1] is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 2960, 2994);

                            f_701_2960_2993(_nodes[2] is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 3020, 3127);

                            return f_701_3027_3126(null, f_701_3053_3119(_nodes[0]!, _nodes[1]!, _nodes[2]!), 0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2376, 3289);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2376, 3289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 3183, 3270);

                            return f_701_3190_3269(null, f_701_3216_3262(_nodes, _count), 0, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2376, 3289);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2328, 3402);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(701, 2328, 3402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 3355, 3387);

                    return default(SyntaxTokenList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(701, 2328, 3402);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(701, 2272, 3413);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_701_2472_2514(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2472, 2514);
                    return return_v;
                }


                int
                f_701_2570_2603(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2570, 2603);
                    return 0;
                }


                int
                f_701_2630_2663(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2630, 2663);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_701_2723_2777(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2723, 2777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_701_2697_2784(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, (Microsoft.CodeAnalysis.GreenNode)tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2697, 2784);
                    return return_v;
                }


                int
                f_701_2840_2873(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2840, 2873);
                    return 0;
                }


                int
                f_701_2900_2933(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2900, 2933);
                    return 0;
                }


                int
                f_701_2960_2993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 2960, 2993);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_701_3053_3119(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = InternalSyntax.SyntaxList.List(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 3053, 3119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_701_3027_3126(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, (Microsoft.CodeAnalysis.GreenNode)tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 3027, 3126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_701_3216_3262(Microsoft.CodeAnalysis.GreenNode?[]
                nodes, int
                count)
                {
                    var return_v = InternalSyntax.SyntaxList.List(nodes, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 3216, 3262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_701_3190_3269(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 3190, 3269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 2272, 3413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 2272, 3413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static implicit operator SyntaxTokenList(SyntaxTokenListBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(701, 3425, 3564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(701, 3529, 3553);

                return f_701_3536_3552(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(701, 3425, 3564);

                Microsoft.CodeAnalysis.SyntaxTokenList
                f_701_3536_3552(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(701, 3536, 3552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(701, 3425, 3564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 3425, 3564);
            }
        }
        static SyntaxTokenListBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(701, 300, 3571);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(701, 300, 3571);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(701, 300, 3571);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(701, 300, 3571);
    }
}
