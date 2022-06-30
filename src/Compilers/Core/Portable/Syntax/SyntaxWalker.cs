// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public abstract class SyntaxWalker
    {
        protected SyntaxWalkerDepth Depth { get; }

        protected SyntaxWalker(SyntaxWalkerDepth depth = SyntaxWalkerDepth.Node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(710, 864, 991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 619, 661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 961, 980);

                this.Depth = depth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(710, 864, 991);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 864, 991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 864, 991);
            }
        }

        public virtual void Visit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(710, 1387, 2018);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1454, 2007);
                    foreach (var child in f_710_1476_1502_I(f_710_1476_1502(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1454, 2007);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1536, 1992) || true) && (child.IsNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1536, 1992);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1594, 1730) || true) && (f_710_1598_1608(this) >= SyntaxWalkerDepth.Node)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1594, 1730);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1684, 1707);

                                f_710_1684_1706(this, child.AsNode()!);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1594, 1730);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1536, 1992);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1536, 1992);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1772, 1992) || true) && (child.IsToken)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1772, 1992);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1831, 1973) || true) && (f_710_1835_1845(this) >= SyntaxWalkerDepth.Token)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 1831, 1973);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 1922, 1950);

                                    f_710_1922_1949(this, child.AsToken());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1831, 1973);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1772, 1992);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1536, 1992);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(710, 1454, 2007);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(710, 1, 554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(710, 1, 554);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(710, 1387, 2018);

                Microsoft.CodeAnalysis.ChildSyntaxList
                f_710_1476_1502(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodesAndTokens();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 1476, 1502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_710_1598_1608(Microsoft.CodeAnalysis.SyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(710, 1598, 1608);
                    return return_v;
                }


                int
                f_710_1684_1706(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 1684, 1706);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_710_1835_1845(Microsoft.CodeAnalysis.SyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(710, 1835, 1845);
                    return return_v;
                }


                int
                f_710_1922_1949(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 1922, 1949);
                    return 0;
                }


                Microsoft.CodeAnalysis.ChildSyntaxList
                f_710_1476_1502_I(Microsoft.CodeAnalysis.ChildSyntaxList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 1476, 1502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 1387, 2018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 1387, 2018);
            }
        }

        protected virtual void VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(710, 2418, 2678);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2495, 2667) || true) && (f_710_2499_2509(this) >= SyntaxWalkerDepth.Trivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 2495, 2667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2571, 2602);

                    f_710_2571_2601(this, token);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2620, 2652);

                    f_710_2620_2651(this, token);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(710, 2495, 2667);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(710, 2418, 2678);

                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_710_2499_2509(Microsoft.CodeAnalysis.SyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(710, 2499, 2509);
                    return return_v;
                }


                int
                f_710_2571_2601(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitLeadingTrivia(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 2571, 2601);
                    return 0;
                }


                int
                f_710_2620_2651(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    this_param.VisitTrailingTrivia(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 2620, 2651);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 2418, 2678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 2418, 2678);
            }
        }

        private void VisitLeadingTrivia(in SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(710, 2690, 2977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2768, 2966) || true) && (token.HasLeadingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 2768, 2966);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2828, 2951);
                        foreach (var trivia in f_710_2851_2870_I(token.LeadingTrivia))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 2828, 2951);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 2912, 2932);

                            f_710_2912_2931(this, trivia);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(710, 2828, 2951);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(710, 1, 124);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(710, 1, 124);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(710, 2768, 2966);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(710, 2690, 2977);

                int
                f_710_2912_2931(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 2912, 2931);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_710_2851_2870_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 2851, 2870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 2690, 2977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 2690, 2977);
            }
        }

        private void VisitTrailingTrivia(in SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(710, 2989, 3279);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 3068, 3268) || true) && (token.HasTrailingTrivia)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 3068, 3268);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 3129, 3253);
                        foreach (var trivia in f_710_3152_3172_I(token.TrailingTrivia))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 3129, 3253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 3214, 3234);

                            f_710_3214_3233(this, trivia);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(710, 3129, 3253);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(710, 1, 125);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(710, 1, 125);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(710, 3068, 3268);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(710, 2989, 3279);

                int
                f_710_3214_3233(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 3214, 3233);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_710_3152_3172_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 3152, 3172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 2989, 3279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 2989, 3279);
            }
        }

        protected virtual void VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(710, 3705, 3955);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 3785, 3944) || true) && (f_710_3789_3799(this) >= SyntaxWalkerDepth.StructuredTrivia && (DynAbs.Tracing.TraceSender.Expression_True(710, 3789, 3860) && trivia.HasStructure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(710, 3785, 3944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(710, 3894, 3929);

                    f_710_3894_3928(this, trivia.GetStructure()!);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(710, 3785, 3944);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(710, 3705, 3955);

                Microsoft.CodeAnalysis.SyntaxWalkerDepth
                f_710_3789_3799(Microsoft.CodeAnalysis.SyntaxWalker
                this_param)
                {
                    var return_v = this_param.Depth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(710, 3789, 3799);
                    return return_v;
                }


                int
                f_710_3894_3928(Microsoft.CodeAnalysis.SyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(710, 3894, 3928);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(710, 3705, 3955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 3705, 3955);
            }
        }

        static SyntaxWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(710, 449, 3962);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(710, 449, 3962);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(710, 449, 3962);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(710, 449, 3962);
    }
}
