// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Syntax.InternalSyntax
{
    internal abstract partial class SyntaxList : GreenNode
    {
        internal SyntaxList()
        : base(f_825_438_456_C(GreenNode.ListKind))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(825, 396, 479);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(825, 396, 479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 396, 479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 396, 479);
            }
        }

        internal SyntaxList(DiagnosticInfo[]? diagnostics, SyntaxAnnotation[]? annotations)
        : base(f_825_595_613_C(GreenNode.ListKind), diagnostics, annotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(825, 491, 662);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(825, 491, 662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 491, 662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 491, 662);
            }
        }

        internal SyntaxList(ObjectReader reader)
        : base(f_825_735_741_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(825, 674, 764);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(825, 674, 764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 674, 764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 674, 764);
            }
        }

        internal static GreenNode List(GreenNode child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 776, 872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 848, 861);

                return child;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 776, 872);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 776, 872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 776, 872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static WithTwoChildren List(GreenNode child0, GreenNode child1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 884, 1499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 981, 1016);

                f_825_981_1015(child0 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1030, 1065);

                f_825_1030_1064(child1 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1081, 1090);

                int
                hash
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1104, 1197);

                GreenNode?
                cached = f_825_1124_1196(GreenNode.ListKind, child0, child1, out hash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1211, 1279) || true) && (cached != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 1211, 1279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1248, 1279);

                    return (WithTwoChildren)cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 1211, 1279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1295, 1344);

                var
                result = f_825_1308_1343(child0, child1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1358, 1458) || true) && (hash >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 1358, 1458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1405, 1443);

                    f_825_1405_1442(result, hash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 1358, 1458);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1474, 1488);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 884, 1499);

                int
                f_825_981_1015(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 981, 1015);
                    return 0;
                }


                int
                f_825_1030_1064(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1030, 1064);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_825_1124_1196(int
                kind, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2, out int
                hash)
                {
                    var return_v = SyntaxNodeCache.TryGetNode(kind, child1, child2, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1124, 1196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_825_1308_1343(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1308, 1343);
                    return return_v;
                }


                int
                f_825_1405_1442(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                node, int
                hash)
                {
                    SyntaxNodeCache.AddNode((Microsoft.CodeAnalysis.GreenNode)node, hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1405, 1442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 884, 1499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 884, 1499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static WithThreeChildren List(GreenNode child0, GreenNode child1, GreenNode child2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 1511, 2215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1628, 1663);

                f_825_1628_1662(child0 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1677, 1712);

                f_825_1677_1711(child1 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1726, 1761);

                f_825_1726_1760(child2 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1777, 1786);

                int
                hash
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1800, 1901);

                GreenNode?
                cached = f_825_1820_1900(GreenNode.ListKind, child0, child1, child2, out hash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1915, 1985) || true) && (cached != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 1915, 1985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 1952, 1985);

                    return (WithThreeChildren)cached;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 1915, 1985);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2001, 2060);

                var
                result = f_825_2014_2059(child0, child1, child2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2074, 2174) || true) && (hash >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 2074, 2174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2121, 2159);

                    f_825_2121_2158(result, hash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 2074, 2174);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2190, 2204);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 1511, 2215);

                int
                f_825_1628_1662(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1628, 1662);
                    return 0;
                }


                int
                f_825_1677_1711(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1677, 1711);
                    return 0;
                }


                int
                f_825_1726_1760(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1726, 1760);
                    return 0;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_825_1820_1900(int
                kind, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2, Microsoft.CodeAnalysis.GreenNode
                child3, out int
                hash)
                {
                    var return_v = SyntaxNodeCache.TryGetNode(kind, child1, child2, child3, out hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 1820, 1900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                f_825_2014_2059(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1, Microsoft.CodeAnalysis.GreenNode
                child2)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren(child0, child1, child2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 2014, 2059);
                    return return_v;
                }


                int
                f_825_2121_2158(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithThreeChildren
                node, int
                hash)
                {
                    SyntaxNodeCache.AddNode((Microsoft.CodeAnalysis.GreenNode)node, hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 2121, 2158);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 1511, 2215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 1511, 2215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode List(GreenNode?[] nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 2227, 2346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2302, 2335);

                return f_825_2309_2334(nodes, f_825_2321_2333(nodes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 2227, 2346);

                int
                f_825_2321_2333(Microsoft.CodeAnalysis.GreenNode?[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 2321, 2333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_825_2309_2334(Microsoft.CodeAnalysis.GreenNode?[]
                nodes, int
                count)
                {
                    var return_v = List(nodes, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 2309, 2334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 2227, 2346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 2227, 2346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static GreenNode List(GreenNode?[] nodes, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 2358, 2737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2444, 2491);

                var
                array = new ArrayElement<GreenNode>[count]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2514, 2519);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2505, 2691) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2532, 2535)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(825, 2505, 2691))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 2505, 2691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2569, 2589);

                        var
                        node = nodes[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2607, 2636);

                        f_825_2607_2635(node is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2654, 2676);

                        array[i].Value = node;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(825, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(825, 1, 187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 2707, 2726);

                return f_825_2714_2725(array);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 2358, 2737);

                int
                f_825_2607_2635(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 2607, 2635);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_825_2714_2725(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 2714, 2725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 2358, 2737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 2358, 2737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxList List(ArrayElement<GreenNode>[] children)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 2749, 3235);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3007, 3224) || true) && (f_825_3011_3026(children) < 10)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3007, 3224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3065, 3103);

                    return f_825_3072_3102(children);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3007, 3224);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3007, 3224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3169, 3209);

                    return f_825_3176_3208(children);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3007, 3224);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 2749, 3235);

                int
                f_825_3011_3026(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 3011, 3026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren
                f_825_3072_3102(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithManyChildren(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 3072, 3102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren
                f_825_3176_3208(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithLotsOfChildren(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 3176, 3208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 2749, 3235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 2749, 3235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void CopyTo(ArrayElement<GreenNode>[] array, int offset);

        internal static GreenNode? Concat(GreenNode? left, GreenNode? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(825, 3334, 4732);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3427, 3505) || true) && (left == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3427, 3505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3477, 3490);

                    return right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3427, 3505);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3521, 3599) || true) && (right == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3521, 3599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3572, 3584);

                    return left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3521, 3599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3615, 3649);

                var
                leftList = left as SyntaxList
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3663, 3699);

                var
                rightList = right as SyntaxList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3713, 4721) || true) && (leftList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3713, 4721);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3767, 4347) || true) && (rightList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3767, 4347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3830, 3902);

                        var
                        tmp = new ArrayElement<GreenNode>[f_825_3868_3882(left) + f_825_3885_3900(right)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3924, 3948);

                        f_825_3924_3947(leftList, tmp, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 3970, 4008);

                        f_825_3970_4007(rightList, tmp, f_825_3992_4006(left));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4030, 4047);

                        return f_825_4037_4046(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3767, 4347);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3767, 4347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4129, 4187);

                        var
                        tmp = new ArrayElement<GreenNode>[f_825_4167_4181(left) + 1]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4209, 4233);

                        f_825_4209_4232(leftList, tmp, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4255, 4289);

                        tmp[f_825_4259_4273(left)].Value = right;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4311, 4328);

                        return f_825_4318_4327(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3767, 4347);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3713, 4721);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 3713, 4721);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4381, 4721) || true) && (rightList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 4381, 4721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4436, 4499);

                        var
                        tmp = new ArrayElement<GreenNode>[f_825_4474_4493(rightList) + 1]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4517, 4537);

                        tmp[0].Value = left;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4555, 4580);

                        f_825_4555_4579(rightList, tmp, 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4598, 4615);

                        return f_825_4605_4614(tmp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(825, 4381, 4721);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(825, 4381, 4721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4681, 4706);

                        return f_825_4688_4705(left, right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(825, 4381, 4721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(825, 3713, 4721);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(825, 3334, 4732);

                int
                f_825_3868_3882(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 3868, 3882);
                    return return_v;
                }


                int
                f_825_3885_3900(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 3885, 3900);
                    return return_v;
                }


                int
                f_825_3924_3947(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                array, int
                offset)
                {
                    this_param.CopyTo(array, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 3924, 3947);
                    return 0;
                }


                int
                f_825_3992_4006(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 3992, 4006);
                    return return_v;
                }


                int
                f_825_3970_4007(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                array, int
                offset)
                {
                    this_param.CopyTo(array, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 3970, 4007);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_825_4037_4046(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4037, 4046);
                    return return_v;
                }


                int
                f_825_4167_4181(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 4167, 4181);
                    return return_v;
                }


                int
                f_825_4209_4232(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                array, int
                offset)
                {
                    this_param.CopyTo(array, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4209, 4232);
                    return 0;
                }


                int
                f_825_4259_4273(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 4259, 4273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_825_4318_4327(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4318, 4327);
                    return return_v;
                }


                int
                f_825_4474_4493(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 4474, 4493);
                    return return_v;
                }


                int
                f_825_4555_4579(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                this_param, Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                array, int
                offset)
                {
                    this_param.CopyTo(array, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4555, 4579);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList
                f_825_4605_4614(Microsoft.CodeAnalysis.ArrayElement<Microsoft.CodeAnalysis.GreenNode>[]
                children)
                {
                    var return_v = List(children);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4605, 4614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxList.WithTwoChildren
                f_825_4688_4705(Microsoft.CodeAnalysis.GreenNode
                child0, Microsoft.CodeAnalysis.GreenNode
                child1)
                {
                    var return_v = List(child0, child1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(825, 4688, 4705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 3334, 4732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 3334, 4732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(825, 4807, 4895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 4843, 4880);

                    throw f_825_4849_4879();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(825, 4807, 4895);

                    System.Exception
                    f_825_4849_4879()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 4849, 4879);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 4744, 4906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 4744, 4906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string KindText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(825, 4981, 5069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 5017, 5054);

                    throw f_825_5023_5053();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(825, 4981, 5069);

                    System.Exception
                    f_825_5023_5053()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 5023, 5053);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 4918, 5080);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 4918, 5080);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SyntaxNode GetStructure(SyntaxTrivia parentTrivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(825, 5092, 5238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 5190, 5227);

                throw f_825_5196_5226();
                DynAbs.Tracing.TraceSender.TraceExitMethod(825, 5092, 5238);

                System.Exception
                f_825_5196_5226()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 5196, 5226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 5092, 5238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 5092, 5238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override SyntaxToken CreateSeparator<TNode>(SyntaxNode element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(825, 5250, 5400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 5352, 5389);

                throw f_825_5358_5388();
                DynAbs.Tracing.TraceSender.TraceExitMethod(825, 5250, 5400);

                System.Exception
                f_825_5358_5388()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(825, 5358, 5388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 5250, 5400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 5250, 5400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsTriviaWithEndOfLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(825, 5412, 5512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(825, 5488, 5501);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(825, 5412, 5512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(825, 5412, 5512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 5412, 5512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(825, 325, 5519);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(825, 325, 5519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(825, 325, 5519);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(825, 325, 5519);

        static ushort
        f_825_438_456_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(825, 396, 479);
            return return_v;
        }


        static ushort
        f_825_595_613_C(ushort
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(825, 491, 662);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_825_735_741_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(825, 674, 764);
            return return_v;
        }

    }
}
