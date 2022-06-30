// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Syntax
{
    internal static class SyntaxListBuilderExtensions
    {
        public static SyntaxTokenList ToTokenList(this SyntaxListBuilder? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(682, 322, 631);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 421, 543) || true) && (builder == null || (DynAbs.Tracing.TraceSender.Expression_False(682, 425, 462) || f_682_444_457(builder) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(682, 421, 543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 496, 528);

                    return default(SyntaxTokenList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(682, 421, 543);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 559, 620);

                return f_682_566_619(null, f_682_592_612(builder), 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(682, 322, 631);

                int
                f_682_444_457(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(682, 444, 457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_682_592_612(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param)
                {
                    var return_v = this_param.ToListNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 592, 612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_682_566_619(Microsoft.CodeAnalysis.SyntaxNode?
                parent, Microsoft.CodeAnalysis.GreenNode?
                tokenOrList, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTokenList(parent, tokenOrList, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 566, 619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(682, 322, 631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(682, 322, 631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<SyntaxNode> ToList(this SyntaxListBuilder? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(682, 643, 962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 744, 781);

                var
                listNode = f_682_759_780_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder, 682, 759, 780)?.ToListNode())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 795, 879) || true) && (listNode is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(682, 795, 879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 849, 864);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(682, 795, 879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 895, 951);

                return f_682_902_950(f_682_929_949(listNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(682, 643, 962);

                Microsoft.CodeAnalysis.GreenNode?
                f_682_759_780_I(Microsoft.CodeAnalysis.GreenNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 759, 780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_682_929_949(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 929, 949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_682_902_950(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 902, 950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(682, 643, 962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(682, 643, 962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxList<TNode> ToList<TNode>(this SyntaxListBuilder? builder)
                    where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(682, 974, 1328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1115, 1152);

                var
                listNode = f_682_1130_1151_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder, 682, 1130, 1151)?.ToListNode())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1166, 1250) || true) && (listNode is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(682, 1166, 1250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1220, 1235);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(682, 1166, 1250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1266, 1317);

                return f_682_1273_1316(f_682_1295_1315(listNode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(682, 974, 1328);

                Microsoft.CodeAnalysis.GreenNode?
                f_682_1130_1151_I(Microsoft.CodeAnalysis.GreenNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1130, 1151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_682_1295_1315(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1295, 1315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<TNode>
                f_682_1273_1316(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxList<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1273, 1316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(682, 974, 1328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(682, 974, 1328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SeparatedSyntaxList<TNode> ToSeparatedList<TNode>(this SyntaxListBuilder? builder) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(682, 1340, 1738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1486, 1523);

                var
                listNode = f_682_1501_1522_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(builder, 682, 1501, 1522)?.ToListNode())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1537, 1621) || true) && (listNode is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(682, 1537, 1621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1591, 1606);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(682, 1537, 1621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(682, 1637, 1727);

                return f_682_1644_1726(f_682_1675_1725(f_682_1701_1721(listNode), 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(682, 1340, 1738);

                Microsoft.CodeAnalysis.GreenNode?
                f_682_1501_1522_I(Microsoft.CodeAnalysis.GreenNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1501, 1522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_682_1701_1721(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1701, 1721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_682_1675_1725(Microsoft.CodeAnalysis.SyntaxNode
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList(node, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1675, 1725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>
                f_682_1644_1726(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(682, 1644, 1726);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(682, 1340, 1738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(682, 1340, 1738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxListBuilderExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(682, 256, 1745);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(682, 256, 1745);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(682, 256, 1745);
        }

    }
}
