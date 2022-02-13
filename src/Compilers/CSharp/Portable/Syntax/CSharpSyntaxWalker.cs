// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    public abstract class CSharpSyntaxWalker : CSharpSyntaxVisitor
    {
        protected SyntaxWalkerDepth Depth { get; }

        protected CSharpSyntaxWalker(SyntaxWalkerDepth depth = SyntaxWalkerDepth.Node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10401, 664, 797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 610, 652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 821, 836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 767, 786);

                this.Depth = depth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10401, 664, 797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 664, 797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 664, 797);
            }
        }

        private int _recursionDepth;

        public override void Visit(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 849, 1185);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 918, 1174) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 918, 1174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 968, 986);

                    _recursionDepth++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1004, 1063);

                    f_10401_1004_1062(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1083, 1121);

                    f_10401_1083_1120(
                                    ((CSharpSyntaxNode)node), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1141, 1159);

                    _recursionDepth--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 918, 1174);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 849, 1185);

                int
                f_10401_1004_1062(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 1004, 1062);
                    return 0;
                }


                int
                f_10401_1083_1120(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 1083, 1120);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 849, 1185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 849, 1185);
            }
        }

        public override void DefaultVisit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 1197, 2039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1272, 1320);

                var
                childCnt = f_10401_1287_1313(node).Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1334, 1344);

                int
                i = 0
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 1360, 2028);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1395, 1463);

                            var
                            child = ChildSyntaxList.ItemInternal(node, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1481, 1485);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1505, 1533);

                            var
                            asNode = child.AsNode()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1551, 1991) || true) && (asNode != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 1551, 1991);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1611, 1743) || true) && (f_10401_1615_1625(this) >= SyntaxWalkerDepth.Node)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 1611, 1743);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1701, 1720);

                                    f_10401_1701_1719(this, asNode);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 1611, 1743);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 1551, 1991);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 1551, 1991);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1825, 1972) || true) && (f_10401_1829_1839(this) >= SyntaxWalkerDepth.Token)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 1825, 1972);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1916, 1949);

                                    f_10401_1916_1948(this, child.AsToken());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 1825, 1972);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 1551, 1991);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 1360, 2028);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 1360, 2028) || true) && (i < childCnt)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10401, 1360, 2028);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10401, 1360, 2028);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 1197, 2039);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_10401_1287_1313(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 1287, 1313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_10401_1615_1625(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10401, 1615, 1625);
                    return return_v;
                }


                int
                f_10401_1701_1719(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 1701, 1719);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_10401_1829_1839(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10401, 1829, 1839);
                    return return_v;
                }


                int
                f_10401_1916_1948(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 1916, 1948);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 1197, 2039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 1197, 2039);
            }
        }

        public virtual void VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 2051, 2308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2125, 2297) || true) && (f_10401_2129_2139(this) >= SyntaxWalkerDepth.Trivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 2125, 2297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2201, 2232);

                    f_10401_2201_2231(this, token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2250, 2282);

                    f_10401_2250_2281(this, token);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 2125, 2297);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 2051, 2308);

                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_10401_2129_2139(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10401, 2129, 2139);
                    return return_v;
                }


                int
                f_10401_2201_2231(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitLeadingTrivia(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2201, 2231);
                    return 0;
                }


                int
                f_10401_2250_2281(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitTrailingTrivia(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2250, 2281);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 2051, 2308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 2051, 2308);
            }
        }

        public virtual void VisitLeadingTrivia(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 2320, 2608);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2402, 2597) || true) && (token.HasLeadingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 2402, 2597);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2462, 2582);
                        foreach (var tr in f_10401_2481_2500_I(token.LeadingTrivia))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 2462, 2582);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2542, 2563);

                            f_10401_2542_2562(this, tr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 2462, 2582);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10401, 1, 121);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10401, 1, 121);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 2402, 2597);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 2320, 2608);

                int
                f_10401_2542_2562(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2542, 2562);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10401_2481_2500_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2481, 2500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 2320, 2608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 2320, 2608);
            }
        }

        public virtual void VisitTrailingTrivia(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 2620, 2911);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2703, 2900) || true) && (token.HasTrailingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 2703, 2900);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2764, 2885);
                        foreach (var tr in f_10401_2783_2803_I(token.TrailingTrivia))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 2764, 2885);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 2845, 2866);

                            f_10401_2845_2865(this, tr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 2764, 2885);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10401, 1, 122);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10401, 1, 122);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 2703, 2900);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 2620, 2911);

                int
                f_10401_2845_2865(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2845, 2865);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10401_2783_2803_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 2783, 2803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 2620, 2911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 2620, 2911);
            }
        }

        public virtual void VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10401, 2923, 3188);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 3000, 3177) || true) && (f_10401_3004_3014(this) >= SyntaxWalkerDepth.StructuredTrivia && (DynAbs.Tracing.TraceSender.Expression_True(10401, 3004, 3075) && trivia.HasStructure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10401, 3000, 3177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10401, 3109, 3162);

                    f_10401_3109_3161(this, (CSharpSyntaxNode)(trivia.GetStructure())!);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10401, 3000, 3177);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10401, 2923, 3188);

                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_10401_3004_3014(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10401, 3004, 3014);
                    return return_v;
                }


                int
                f_10401_3109_3161(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxWalker
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10401, 3109, 3161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10401, 2923, 3188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 2923, 3188);
            }
        }

        static CSharpSyntaxWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10401, 531, 3195);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10401, 531, 3195);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10401, 531, 3195);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10401, 531, 3195);
    }
}
