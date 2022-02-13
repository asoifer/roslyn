// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    public abstract partial class CSharpSyntaxRewriter : CSharpSyntaxVisitor<SyntaxNode?>
    {
        private readonly bool _visitIntoStructuredTrivia;

        public CSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10753, 829, 987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 790, 816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1146, 1161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 921, 976);

                _visitIntoStructuredTrivia = visitIntoStructuredTrivia;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10753, 829, 987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 829, 987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 829, 987);
            }
        }

        public virtual bool VisitIntoStructuredTrivia
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 1069, 1111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1075, 1109);

                    return _visitIntoStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 1069, 1111);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 999, 1122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 999, 1122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _recursionDepth;

        [return: NotNullIfNotNull("node")]
        public override SyntaxNode? Visit(SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 1174, 1751);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1294, 1740) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 1294, 1740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1344, 1362);

                    _recursionDepth++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1380, 1439);

                    f_10753_1380_1438(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1459, 1510);

                    var
                    result = f_10753_1472_1509(((CSharpSyntaxNode)node), this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1530, 1548);

                    _recursionDepth--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1632, 1647);

                    return result!;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 1294, 1740);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 1294, 1740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 1713, 1725);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 1294, 1740);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 1174, 1751);

                int
                f_10753_1380_1438(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 1380, 1438);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10753_1472_1509(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                visitor)
                {
                    var return_v = this_param.Accept<Microsoft.CodeAnalysis.SyntaxNode?>((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor<Microsoft.CodeAnalysis.SyntaxNode>)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 1472, 1509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 1174, 1751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 1174, 1751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxToken VisitToken(SyntaxToken token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 1763, 4895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2123, 2145);

                var
                node = token.Node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2159, 2237) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 2159, 2237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2209, 2222);

                    return token;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 2159, 2237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2348, 2396);

                var
                leadingTrivia = f_10753_2368_2395(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2410, 2460);

                var
                trailingTrivia = f_10753_2431_2459(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2581, 2673);

                f_10753_2581_2672(leadingTrivia == null || (DynAbs.Tracing.TraceSender.Expression_False(10753, 2594, 2640) || f_10753_2619_2640_M(!leadingTrivia.IsList)) || (DynAbs.Tracing.TraceSender.Expression_False(10753, 2594, 2671) || f_10753_2644_2667(leadingTrivia) > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2687, 2782);

                f_10753_2687_2781(trailingTrivia == null || (DynAbs.Tracing.TraceSender.Expression_False(10753, 2700, 2748) || f_10753_2726_2748_M(!trailingTrivia.IsList)) || (DynAbs.Tracing.TraceSender.Expression_False(10753, 2700, 2780) || f_10753_2752_2776(trailingTrivia) > 0));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2798, 4884) || true) && (leadingTrivia != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 2798, 4884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 2933, 3006);

                    var
                    leading = f_10753_2947_3005(this, f_10753_2962_3004(token, leadingTrivia))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3026, 4140) || true) && (trailingTrivia != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 3026, 4140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3409, 3472);

                        var
                        index = (DynAbs.Tracing.TraceSender.Conditional_F1(10753, 3421, 3441) || ((f_10753_3421_3441(leadingTrivia) && DynAbs.Tracing.TraceSender.Conditional_F2(10753, 3444, 3467)) || DynAbs.Tracing.TraceSender.Conditional_F3(10753, 3470, 3471))) ? f_10753_3444_3467(leadingTrivia) : 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3494, 3636);

                        var
                        trailing = f_10753_3509_3635(this, f_10753_3524_3634(token, trailingTrivia, token.Position + f_10753_3585_3599(node) - f_10753_3602_3626(trailingTrivia), index))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3660, 3807) || true) && (leading.Node != leadingTrivia)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 3660, 3807);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3743, 3784);

                            token = token.WithLeadingTrivia(leading);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 3660, 3807);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 3831, 3915);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10753, 3838, 3869) || ((trailing.Node != trailingTrivia && DynAbs.Tracing.TraceSender.Conditional_F2(10753, 3872, 3906)) || DynAbs.Tracing.TraceSender.Conditional_F3(10753, 3909, 3914))) ? token.WithTrailingTrivia(trailing) : token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 3026, 4140);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 3026, 4140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4041, 4121);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10753, 4048, 4077) || ((leading.Node != leadingTrivia && DynAbs.Tracing.TraceSender.Conditional_F2(10753, 4080, 4112)) || DynAbs.Tracing.TraceSender.Conditional_F3(10753, 4115, 4120))) ? token.WithLeadingTrivia(leading) : token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 3026, 4140);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 2798, 4884);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 2798, 4884);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4174, 4884) || true) && (trailingTrivia != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 4174, 4884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4513, 4658);

                        var
                        trailing = f_10753_4528_4657(this, f_10753_4543_4656(token, trailingTrivia, token.Position + f_10753_4604_4618(node) - f_10753_4621_4645(trailingTrivia), index: 0))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4676, 4760);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10753, 4683, 4714) || ((trailing.Node != trailingTrivia && DynAbs.Tracing.TraceSender.Conditional_F2(10753, 4717, 4751)) || DynAbs.Tracing.TraceSender.Conditional_F3(10753, 4754, 4759))) ? token.WithTrailingTrivia(trailing) : token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 4174, 4884);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 4174, 4884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4856, 4869);

                        return token;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 4174, 4884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 2798, 4884);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 1763, 4895);

                Microsoft.CodeAnalysis.GreenNode?
                f_10753_2368_2395(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetLeadingTriviaCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2368, 2395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode?
                f_10753_2431_2459(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.GetTrailingTriviaCore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2431, 2459);
                    return return_v;
                }


                bool
                f_10753_2619_2640_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 2619, 2640);
                    return return_v;
                }


                int
                f_10753_2644_2667(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 2644, 2667);
                    return return_v;
                }


                int
                f_10753_2581_2672(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2581, 2672);
                    return 0;
                }


                bool
                f_10753_2726_2748_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 2726, 2748);
                    return return_v;
                }


                int
                f_10753_2752_2776(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 2752, 2776);
                    return return_v;
                }


                int
                f_10753_2687_2781(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2687, 2781);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_2962_3004(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2962, 3004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_2947_3005(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = this_param.VisitList(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 2947, 3005);
                    return return_v;
                }


                bool
                f_10753_3421_3441(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.IsList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 3421, 3441);
                    return return_v;
                }


                int
                f_10753_3444_3467(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.SlotCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 3444, 3467);
                    return return_v;
                }


                int
                f_10753_3585_3599(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 3585, 3599);
                    return return_v;
                }


                int
                f_10753_3602_3626(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 3602, 3626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_3524_3634(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 3524, 3634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_3509_3635(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = this_param.VisitList(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 3509, 3635);
                    return return_v;
                }


                int
                f_10753_4604_4618(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 4604, 4618);
                    return return_v;
                }


                int
                f_10753_4621_4645(Microsoft.CodeAnalysis.GreenNode
                this_param)
                {
                    var return_v = this_param.FullWidth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 4621, 4645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_4543_4656(Microsoft.CodeAnalysis.SyntaxToken
                token, Microsoft.CodeAnalysis.GreenNode
                node, int
                position, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxTriviaList(token, node, position, index: index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 4543, 4656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_4528_4657(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list)
                {
                    var return_v = this_param.VisitList(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 4528, 4657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 1763, 4895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 1763, 4895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxTrivia VisitTrivia(SyntaxTrivia trivia)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 4907, 5640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 4992, 5599) || true) && (f_10753_4996_5026(this) && (DynAbs.Tracing.TraceSender.Expression_True(10753, 4996, 5049) && trivia.HasStructure))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 4992, 5599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5083, 5140);

                    var
                    structure = (CSharpSyntaxNode)trivia.GetStructure()!
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5158, 5224);

                    var
                    newStructure = (StructuredTriviaSyntax?)f_10753_5202_5223(this, structure)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5242, 5584) || true) && (newStructure != structure)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 5242, 5584);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5313, 5565) || true) && (newStructure != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 5313, 5565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5387, 5429);

                            return f_10753_5394_5428(newStructure);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 5313, 5565);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 5313, 5565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5527, 5542);

                            return default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 5313, 5565);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 5242, 5584);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 4992, 5599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5615, 5629);

                return trivia;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 4907, 5640);

                bool
                f_10753_4996_5026(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param)
                {
                    var return_v = this_param.VisitIntoStructuredTrivia;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 4996, 5026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10753_5202_5223(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 5202, 5223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10753_5394_5428(Microsoft.CodeAnalysis.CSharp.Syntax.StructuredTriviaSyntax
                node)
                {
                    var return_v = SyntaxFactory.Trivia(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 5394, 5428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 4907, 5640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 4907, 5640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxList<TNode> VisitList<TNode>(SyntaxList<TNode> list) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 5652, 6535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5775, 5811);

                SyntaxListBuilder?
                alternate = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5834, 5839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5841, 5855);
                    for (int
        i = 0
        ,
        n = list.Count
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5825, 6384) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5864, 5867)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 5825, 6384))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 5825, 6384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5901, 5920);

                        var
                        item = list[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5938, 5980);

                        var
                        visited = f_10753_5952_5979<TNode>(this, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 5998, 6189) || true) && (item != visited && (DynAbs.Tracing.TraceSender.Expression_True(10753, 6002, 6038) && alternate == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 5998, 6189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6080, 6117);

                            alternate = f_10753_6092_6116<TNode>(n);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6139, 6170);

                            f_10753_6139_6169<TNode>(alternate, list, 0, i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 5998, 6189);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6209, 6369) || true) && (alternate != null && (DynAbs.Tracing.TraceSender.Expression_True(10753, 6213, 6249) && visited != null) && (DynAbs.Tracing.TraceSender.Expression_True(10753, 6213, 6285) && !f_10753_6254_6285<TNode>(visited, SyntaxKind.None)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 6209, 6369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6327, 6350);

                            f_10753_6327_6349<TNode>(alternate, visited);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 6209, 6369);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10753, 1, 560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10753, 1, 560);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6400, 6496) || true) && (alternate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 6400, 6496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6455, 6481);

                    return f_10753_6462_6480<TNode>(alternate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 6400, 6496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6512, 6524);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 5652, 6535);

                TNode?
                f_10753_5952_5979<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, TNode
                node) where TNode : SyntaxNode

                {
                    var return_v = this_param.VisitListElement<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 5952, 5979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                f_10753_6092_6116<TNode>(int
                size) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6092, 6116);
                    return return_v;
                }


                int
                f_10753_6139_6169<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxList<TNode>
                list, int
                offset, int
                count) where TNode : SyntaxNode

                {
                    this_param.AddRange<TNode>(list, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6139, 6169);
                    return 0;
                }


                bool
                f_10753_6254_6285<TNode>(TNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind) where TNode : SyntaxNode

                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6254, 6285);
                    return return_v;
                }


                int
                f_10753_6327_6349<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                this_param, TNode
                item) where TNode : SyntaxNode

                {
                    this_param.Add((Microsoft.CodeAnalysis.SyntaxNode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6327, 6349);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.SyntaxNode>
                f_10753_6462_6480<TNode>(Microsoft.CodeAnalysis.Syntax.SyntaxListBuilder
                builder) where TNode : SyntaxNode

                {
                    var return_v = builder.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6462, 6480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 5652, 6535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 5652, 6535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TNode? VisitListElement<TNode>(TNode? node) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 6547, 6698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6655, 6687);

                return (TNode?)f_10753_6670_6686<TNode>(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 6547, 6698);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10753_6670_6686<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, TNode?
                node) where TNode : SyntaxNode

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 6670, 6686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 6547, 6698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 6547, 6698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SeparatedSyntaxList<TNode> VisitList<TNode>(SeparatedSyntaxList<TNode> list) where TNode : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 6710, 9235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6851, 6874);

                var
                count = list.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6888, 6923);

                var
                sepCount = list.SeparatorCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 6939, 6993);

                SeparatedSyntaxListBuilder<TNode>
                alternate = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7009, 7019);

                int
                i = 0
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7033, 8463) || true) && (i < sepCount)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7054, 7057)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7033, 8463))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7033, 8463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7091, 7110);

                        var
                        node = list[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7128, 7174);

                        var
                        visitedNode = f_10753_7146_7173<TNode>(this, node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7194, 7231);

                        var
                        separator = list.GetSeparator(i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7249, 7307);

                        var
                        visitedSeparator = f_10753_7272_7306<TNode>(this, separator)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7327, 7648) || true) && (alternate.IsNull)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7327, 7648);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7389, 7629) || true) && (node != visitedNode || (DynAbs.Tracing.TraceSender.Expression_False(10753, 7393, 7445) || separator != visitedSeparator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7389, 7629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7495, 7552);

                                alternate = f_10753_7507_7551<TNode>(count);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7578, 7606);

                                alternate.AddRange(list, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7389, 7629);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7327, 7648);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7668, 8448) || true) && (f_10753_7672_7689_M(!alternate.IsNull))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7668, 8448);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7731, 8429) || true) && (visitedNode != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7731, 8429);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7804, 7831);

                                alternate.Add(visitedNode);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7859, 8056) || true) && (visitedSeparator.RawKind == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7859, 8056);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 7950, 8029);

                                    throw f_10753_7956_8028<TNode>(f_10753_7986_8027<TNode>());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7859, 8056);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8082, 8123);

                                alternate.AddSeparator(visitedSeparator);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7731, 8429);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 7731, 8429);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8221, 8406) || true) && (visitedNode == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 8221, 8406);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8302, 8379);

                                    throw f_10753_8308_8378<TNode>(f_10753_8338_8377<TNode>());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 8221, 8406);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7731, 8429);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 7668, 8448);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10753, 1, 1431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10753, 1, 1431);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8479, 9084) || true) && (i < count)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 8479, 9084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8526, 8545);

                    var
                    node = list[i]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8563, 8609);

                    var
                    visitedNode = f_10753_8581_8608<TNode>(this, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8629, 8917) || true) && (alternate.IsNull)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 8629, 8917);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8691, 8898) || true) && (node != visitedNode)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 8691, 8898);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8764, 8821);

                            alternate = f_10753_8776_8820<TNode>(count);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8847, 8875);

                            alternate.AddRange(list, i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 8691, 8898);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 8629, 8917);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 8937, 9069) || true) && (f_10753_8941_8958_M(!alternate.IsNull) && (DynAbs.Tracing.TraceSender.Expression_True(10753, 8941, 8981) && visitedNode != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 8937, 9069);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9023, 9050);

                        alternate.Add(visitedNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 8937, 9069);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 8479, 9084);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9100, 9196) || true) && (f_10753_9104_9121_M(!alternate.IsNull))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 9100, 9196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9155, 9181);

                    return alternate.ToList();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 9100, 9196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9212, 9224);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 6710, 9235);

                TNode?
                f_10753_7146_7173<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, TNode
                node) where TNode : SyntaxNode

                {
                    var return_v = this_param.VisitListElement<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 7146, 7173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10753_7272_7306<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                separator) where TNode : SyntaxNode

                {
                    var return_v = this_param.VisitListSeparator(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 7272, 7306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>
                f_10753_7507_7551<TNode>(int
                size) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 7507, 7551);
                    return return_v;
                }


                bool
                f_10753_7672_7689_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 7672, 7689);
                    return return_v;
                }


                string
                f_10753_7986_8027<TNode>() where TNode : SyntaxNode

                {
                    var return_v = CodeAnalysisResources.SeparatorIsExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 7986, 8027);
                    return return_v;
                }


                System.InvalidOperationException
                f_10753_7956_8028<TNode>(string
                message) where TNode : SyntaxNode

                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 7956, 8028);
                    return return_v;
                }


                string
                f_10753_8338_8377<TNode>() where TNode : SyntaxNode

                {
                    var return_v = CodeAnalysisResources.ElementIsExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 8338, 8377);
                    return return_v;
                }


                System.InvalidOperationException
                f_10753_8308_8378<TNode>(string
                message) where TNode : SyntaxNode

                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 8308, 8378);
                    return return_v;
                }


                TNode?
                f_10753_8581_8608<TNode>(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, TNode
                node) where TNode : SyntaxNode

                {
                    var return_v = this_param.VisitListElement<TNode>(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 8581, 8608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>
                f_10753_8776_8820<TNode>(int
                size) where TNode : SyntaxNode

                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SeparatedSyntaxListBuilder<TNode>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 8776, 8820);
                    return return_v;
                }


                bool
                f_10753_8941_8958_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 8941, 8958);
                    return return_v;
                }


                bool
                f_10753_9104_9121_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10753, 9104, 9121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 6710, 9235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 6710, 9235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxToken VisitListSeparator(SyntaxToken separator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 9247, 9385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9340, 9374);

                return f_10753_9347_9373(this, separator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 9247, 9385);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10753_9347_9373(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 9347, 9373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 9247, 9385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 9247, 9385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxTokenList VisitList(SyntaxTokenList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 9397, 10329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9484, 9525);

                SyntaxTokenListBuilder?
                alternate = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9539, 9562);

                var
                count = list.Count
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9576, 9591);

                var
                index = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9607, 10178);
                    foreach (var item in f_10753_9628_9632_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 9607, 10178);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9666, 9674);

                        index++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9692, 9728);

                        var
                        visited = f_10753_9706_9727(this, item)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9746, 9945) || true) && (item != visited && (DynAbs.Tracing.TraceSender.Expression_True(10753, 9750, 9786) && alternate == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 9746, 9945);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9828, 9874);

                            alternate = f_10753_9840_9873(count);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9896, 9926);

                            f_10753_9896_9925(alternate, list, 0, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 9746, 9945);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 9965, 10163) || true) && (alternate != null && (DynAbs.Tracing.TraceSender.Expression_True(10753, 9969, 10023) && visited.Kind() != SyntaxKind.None))
                        ) //skip the null check since SyntaxToken is a value type

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 9965, 10163);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10121, 10144);

                            f_10753_10121_10143(alternate, visited);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 9965, 10163);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 9607, 10178);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10753, 1, 572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10753, 1, 572);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10194, 10290) || true) && (alternate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 10194, 10290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10249, 10275);

                    return f_10753_10256_10274(alternate);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 10194, 10290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10306, 10318);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 9397, 10329);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10753_9706_9727(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    var return_v = this_param.VisitToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 9706, 9727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                f_10753_9840_9873(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 9840, 9873);
                    return return_v;
                }


                int
                f_10753_9896_9925(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTokenList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 9896, 9925);
                    return 0;
                }


                int
                f_10753_10121_10143(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 10121, 10143);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10753_9628_9632_I(Microsoft.CodeAnalysis.SyntaxTokenList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 9628, 9632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10753_10256_10274(Microsoft.CodeAnalysis.Syntax.SyntaxTokenListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 10256, 10274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 9397, 10329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 9397, 10329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxTriviaList VisitList(SyntaxTriviaList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 10341, 11446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10430, 10453);

                var
                count = list.Count
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10467, 11407) || true) && (count != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 10467, 11407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10515, 10557);

                    SyntaxTriviaListBuilder?
                    alternate = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10575, 10590);

                    var
                    index = -1
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10610, 11264);
                        foreach (var item in f_10753_10631_10635_I(list))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 10610, 11264);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10677, 10685);

                            index++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10707, 10749);

                            var
                            visited = f_10753_10721_10748(this, item)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10851, 11067) || true) && (visited != item && (DynAbs.Tracing.TraceSender.Expression_True(10753, 10855, 10891) && alternate == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 10851, 11067);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 10941, 10988);

                                alternate = f_10753_10953_10987(count);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11014, 11044);

                                f_10753_11014_11043(alternate, list, 0, index);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 10851, 11067);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11091, 11245) || true) && (alternate != null && (DynAbs.Tracing.TraceSender.Expression_True(10753, 11095, 11149) && visited.Kind() != SyntaxKind.None))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 11091, 11245);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11199, 11222);

                                f_10753_11199_11221(alternate, visited);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 11091, 11245);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 10610, 11264);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10753, 1, 655);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10753, 1, 655);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11284, 11392) || true) && (alternate != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10753, 11284, 11392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11347, 11373);

                        return f_10753_11354_11372(alternate);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 11284, 11392);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10753, 10467, 11407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11423, 11435);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 10341, 11446);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10753_10721_10748(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                element)
                {
                    var return_v = this_param.VisitListElement(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 10721, 10748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_10753_10953_10987(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 10953, 10987);
                    return return_v;
                }


                int
                f_10753_11014_11043(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTriviaList
                list, int
                offset, int
                length)
                {
                    this_param.Add(list, offset, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 11014, 11043);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                f_10753_11199_11221(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 11199, 11221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_10631_10635_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 10631, 10635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTriviaList
                f_10753_11354_11372(Microsoft.CodeAnalysis.Syntax.SyntaxTriviaListBuilder
                this_param)
                {
                    var return_v = this_param.ToList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 11354, 11372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 10341, 11446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 10341, 11446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SyntaxTrivia VisitListElement(SyntaxTrivia element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10753, 11458, 11593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10753, 11549, 11582);

                return f_10753_11556_11581(this, element);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10753, 11458, 11593);

                Microsoft.CodeAnalysis.SyntaxTrivia
                f_10753_11556_11581(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxTrivia
                trivia)
                {
                    var return_v = this_param.VisitTrivia(trivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10753, 11556, 11581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10753, 11458, 11593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 11458, 11593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpSyntaxRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10753, 666, 11600);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10753, 666, 11600);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10753, 666, 11600);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10753, 666, 11600);
    }
}
