// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class LambdaUtilities
    {
        public static bool IsLambda(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 585, 1726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 654, 1686);

                switch (f_10777_662_673(node))
                {

                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                    case SyntaxKind.LetClause:
                    case SyntaxKind.WhereClause:
                    case SyntaxKind.AscendingOrdering:
                    case SyntaxKind.DescendingOrdering:
                    case SyntaxKind.JoinClause:
                    case SyntaxKind.GroupClause:
                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 654, 1686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1235, 1247);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 654, 1686);

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 654, 1686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1318, 1362);

                        var
                        selectClause = (SelectClauseSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1384, 1462);

                        return !f_10777_1392_1461(selectClause, f_10777_1437_1460(selectClause));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 654, 1686);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 654, 1686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1616, 1671);

                        return !f_10777_1624_1670(f_10777_1624_1635(node), SyntaxKind.QueryExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 654, 1686);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1702, 1715);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 585, 1726);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_662_673(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 662, 673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_1437_1460(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 1437, 1460);
                    return return_v;
                }


                bool
                f_10777_1392_1461(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 1392, 1461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_1624_1635(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 1624, 1635);
                    return return_v;
                }


                bool
                f_10777_1624_1670(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 1624, 1670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 585, 1726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 585, 1726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNotLambda(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10777, 1786, 1804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 1789, 1804);
                return !f_10777_1790_1804(node); DynAbs.Tracing.TraceSender.TraceExitMethod(10777, 1786, 1804);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 1786, 1804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 1786, 1804);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10777_1790_1804(Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = IsLambda(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 1790, 1804);
                return return_v;
            }

        }

        public static SyntaxNode GetLambda(SyntaxNode lambdaBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 1963, 2685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2045, 2087);

                f_10777_2045_2086(f_10777_2058_2075(lambdaBody) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2101, 2132);

                var
                lambda = f_10777_2114_2131(lambdaBody)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2146, 2599) || true) && (f_10777_2150_2197(lambda, SyntaxKind.ArrowExpressionClause))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2146, 2599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2480, 2503);

                    lambda = f_10777_2489_2502(lambda);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2521, 2584);

                    f_10777_2521_2583(f_10777_2534_2582(lambda, SyntaxKind.LocalFunctionStatement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2146, 2599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2615, 2646);

                f_10777_2615_2645(f_10777_2628_2644(lambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2660, 2674);

                return lambda;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 1963, 2685);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_2058_2075(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 2058, 2075);
                    return return_v;
                }


                int
                f_10777_2045_2086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2045, 2086);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_2114_2131(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 2114, 2131);
                    return return_v;
                }


                bool
                f_10777_2150_2197(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2150, 2197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_2489_2502(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 2489, 2502);
                    return return_v;
                }


                bool
                f_10777_2534_2582(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2534, 2582);
                    return return_v;
                }


                int
                f_10777_2521_2583(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2521, 2583);
                    return 0;
                }


                bool
                f_10777_2628_2644(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsLambda(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2628, 2644);
                    return return_v;
                }


                int
                f_10777_2615_2645(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2615, 2645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 1963, 2685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 1963, 2685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SyntaxNode? TryGetCorrespondingLambdaBody(SyntaxNode oldBody, SyntaxNode newLambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 2800, 5451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2924, 2963);

                f_10777_2924_2962(f_10777_2937_2951(oldBody) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 2979, 5440);

                switch (f_10777_2987_3003(newLambda))
                {

                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3222, 3281);

                        return f_10777_3229_3280(((AnonymousFunctionExpressionSyntax)newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3350, 3398);

                        return f_10777_3357_3397(((FromClauseSyntax)newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.LetClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3466, 3513);

                        return f_10777_3473_3512(((LetClauseSyntax)newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3583, 3631);

                        return f_10777_3590_3630(((WhereClauseSyntax)newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.AscendingOrdering:
                    case SyntaxKind.DescendingOrdering:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3760, 3806);

                        return f_10777_3767_3805(((OrderingSyntax)newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 3877, 3926);

                        var
                        selectClause = (SelectClauseSyntax)newLambda
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4138, 4248);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10777, 4145, 4214) || ((f_10777_4145_4214(selectClause, f_10777_4190_4213(selectClause)) && DynAbs.Tracing.TraceSender.Conditional_F2(10777, 4217, 4221)) || DynAbs.Tracing.TraceSender.Conditional_F3(10777, 4224, 4247))) ? null : f_10777_4224_4247(selectClause);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.JoinClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4317, 4364);

                        var
                        oldJoin = (JoinClauseSyntax)f_10777_4349_4363(oldBody)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4386, 4428);

                        var
                        newJoin = (JoinClauseSyntax)newLambda
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4450, 4536);

                        f_10777_4450_4535(f_10777_4463_4485(oldJoin) == oldBody || (DynAbs.Tracing.TraceSender.Expression_False(10777, 4463, 4534) || f_10777_4500_4523(oldJoin) == oldBody));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4558, 4652);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10777, 4565, 4600) || (((f_10777_4566_4588(oldJoin) == oldBody) && DynAbs.Tracing.TraceSender.Conditional_F2(10777, 4603, 4625)) || DynAbs.Tracing.TraceSender.Conditional_F3(10777, 4628, 4651))) ? f_10777_4603_4625(newJoin) : f_10777_4628_4651(newJoin);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.GroupClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4722, 4771);

                        var
                        oldGroup = (GroupClauseSyntax)f_10777_4756_4770(oldBody)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4793, 4837);

                        var
                        newGroup = (GroupClauseSyntax)newLambda
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4859, 4945);

                        f_10777_4859_4944(f_10777_4872_4896(oldGroup) == oldBody || (DynAbs.Tracing.TraceSender.Expression_False(10777, 4872, 4943) || f_10777_4911_4932(oldGroup) == oldBody));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 4967, 5166);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10777, 4974, 5011) || (((f_10777_4975_4999(oldGroup) == oldBody) && DynAbs.Tracing.TraceSender.Conditional_F2(10777, 5039, 5141)) || DynAbs.Tracing.TraceSender.Conditional_F3(10777, 5144, 5165))) ? ((DynAbs.Tracing.TraceSender.Conditional_F1(10777, 5040, 5106) || ((f_10777_5040_5106(newGroup, f_10777_5081_5105(newGroup)) && DynAbs.Tracing.TraceSender.Conditional_F2(10777, 5109, 5113)) || DynAbs.Tracing.TraceSender.Conditional_F3(10777, 5116, 5140))) ? null : f_10777_5116_5140(newGroup)) : f_10777_5144_5165(newGroup);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5247, 5316);

                        return f_10777_5254_5315(newLambda);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 2979, 5440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5366, 5425);

                        throw f_10777_5372_5424(f_10777_5407_5423(newLambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 2979, 5440);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 2800, 5451);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_2937_2951(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 2937, 2951);
                    return return_v;
                }


                int
                f_10777_2924_2962(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2924, 2962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_2987_3003(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 2987, 3003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10777_3229_3280(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 3229, 3280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_3357_3397(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 3357, 3397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_3473_3512(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 3473, 3512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_3590_3630(Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 3590, 3630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_3767_3805(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 3767, 3805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4190_4213(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4190, 4213);
                    return return_v;
                }


                bool
                f_10777_4145_4214(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 4145, 4214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4224_4247(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4224, 4247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_4349_4363(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4349, 4363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4463_4485(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4463, 4485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4500_4523(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4500, 4523);
                    return return_v;
                }


                int
                f_10777_4450_4535(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 4450, 4535);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4566_4588(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4566, 4588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4603_4625(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4603, 4625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4628_4651(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4628, 4651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_4756_4770(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4756, 4770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4872_4896(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4872, 4896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4911_4932(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4911, 4932);
                    return return_v;
                }


                int
                f_10777_4859_4944(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 4859, 4944);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_4975_4999(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 4975, 4999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_5081_5105(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5081, 5105);
                    return return_v;
                }


                bool
                f_10777_5040_5106(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 5040, 5106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_5116_5140(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5116, 5140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_5144_5165(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5144, 5165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_5254_5315(Microsoft.CodeAnalysis.SyntaxNode
                localFunctionStatementSyntax)
                {
                    var return_v = GetLocalFunctionBody((Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax)localFunctionStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 5254, 5315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_5407_5423(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 5407, 5423);
                    return return_v;
                }


                System.Exception
                f_10777_5372_5424(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 5372, 5424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 2800, 5451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 2800, 5451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SyntaxNode GetNestedFunctionBody(SyntaxNode nestedFunction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10777, 5550, 6003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5553, 6003);
                return nestedFunction switch
                {
                    AnonymousFunctionExpressionSyntax anonymousFunctionExpressionSyntax when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5607, 5716) && DynAbs.Tracing.TraceSender.Expression_True(10777, 5607, 5716))
    => f_10777_5678_5716(anonymousFunctionExpressionSyntax),
                    LocalFunctionStatementSyntax localFunctionStatementSyntax when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5735, 5907) && DynAbs.Tracing.TraceSender.Expression_True(10777, 5735, 5907))
    => (CSharpSyntaxNode?)f_10777_5815_5848(localFunctionStatementSyntax) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?>(10777, 5796, 5907) ?? f_10777_5852_5907(localFunctionStatementSyntax.ExpressionBody!)),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 5926, 5987) && DynAbs.Tracing.TraceSender.Expression_True(10777, 5926, 5987))
    => throw f_10777_5937_5987(nestedFunction),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10777, 5550, 6003);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 5550, 6003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 5550, 6003);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            f_10777_5678_5716(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5678, 5716);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
            f_10777_5815_5848(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5815, 5848);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
            f_10777_5852_5907(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
            this_param)
            {
                var return_v = this_param.Expression;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 5852, 5907);
                return return_v;
            }


            System.Exception
            f_10777_5937_5987(Microsoft.CodeAnalysis.SyntaxNode
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 5937, 5987);
                return return_v;
            }

        }

        public static bool IsNotLambdaBody(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 6016, 6130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6092, 6119);

                return !f_10777_6100_6118(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 6016, 6130);

                bool
                f_10777_6100_6118(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 6100, 6118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 6016, 6130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 6016, 6130);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLambdaBody(SyntaxNode node, bool allowReducedLambdas = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 6287, 9032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6394, 6420);

                var
                parent = f_10777_6407_6419_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(node, 10777, 6407, 6419)?.Parent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6434, 6514) || true) && (parent == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6434, 6514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6486, 6499);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6434, 6514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6530, 8992);

                switch (f_10777_6538_6551(parent))
                {

                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6770, 6836);

                        var
                        anonymousFunction = (AnonymousFunctionExpressionSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6858, 6896);

                        return f_10777_6865_6887(anonymousFunction) == node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 6977, 7034);

                        var
                        localFunction = (LocalFunctionStatementSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7056, 7090);

                        return f_10777_7063_7081(localFunction) == node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.ArrowExpressionClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7170, 7234);

                        var
                        arrowExpressionClause = (ArrowExpressionClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7256, 7368);

                        return f_10777_7263_7295(arrowExpressionClause) == node && (DynAbs.Tracing.TraceSender.Expression_True(10777, 7263, 7367) && f_10777_7307_7335(arrowExpressionClause) is LocalFunctionStatementSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7437, 7479);

                        var
                        fromClause = (FromClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7501, 7578);

                        return f_10777_7508_7529(fromClause) == node && (DynAbs.Tracing.TraceSender.Expression_True(10777, 7508, 7577) && f_10777_7541_7558(fromClause) is QueryBodySyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.JoinClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7647, 7689);

                        var
                        joinClause = (JoinClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7711, 7790);

                        return f_10777_7718_7743(joinClause) == node || (DynAbs.Tracing.TraceSender.Expression_False(10777, 7718, 7789) || f_10777_7755_7781(joinClause) == node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.LetClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7858, 7898);

                        var
                        letClause = (LetClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 7920, 7956);

                        return f_10777_7927_7947(letClause) == node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8026, 8070);

                        var
                        whereClause = (WhereClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8092, 8129);

                        return f_10777_8099_8120(whereClause) == node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.AscendingOrdering:
                    case SyntaxKind.DescendingOrdering:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8258, 8296);

                        var
                        ordering = (OrderingSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8318, 8353);

                        return f_10777_8325_8344(ordering) == node;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8424, 8470);

                        var
                        selectClause = (SelectClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8492, 8630);

                        return f_10777_8499_8522(selectClause) == node && (DynAbs.Tracing.TraceSender.Expression_True(10777, 8499, 8629) && (allowReducedLambdas || (DynAbs.Tracing.TraceSender.Expression_False(10777, 8535, 8628) || !f_10777_8559_8628(selectClause, f_10777_8604_8627(selectClause)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);

                    case SyntaxKind.GroupClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 6530, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8700, 8744);

                        var
                        groupClause = (GroupClauseSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 8766, 8977);

                        return (f_10777_8774_8801(groupClause) == node && (DynAbs.Tracing.TraceSender.Expression_True(10777, 8774, 8911) && (allowReducedLambdas || (DynAbs.Tracing.TraceSender.Expression_False(10777, 8814, 8910) || !f_10777_8838_8910(groupClause, f_10777_8882_8909(groupClause)))))) || (DynAbs.Tracing.TraceSender.Expression_False(10777, 8773, 8976) || f_10777_8944_8968(groupClause) == node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 6530, 8992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 9008, 9021);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 6287, 9032);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_6407_6419_M(Microsoft.CodeAnalysis.SyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 6407, 6419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_6538_6551(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 6538, 6551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10777_6865_6887(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 6865, 6887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10777_7063_7081(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7063, 7081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_7263_7295(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7263, 7295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10777_7307_7335(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7307, 7335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_7508_7529(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7508, 7529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10777_7541_7558(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7541, 7558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_7718_7743(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7718, 7743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_7755_7781(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7755, 7781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_7927_7947(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 7927, 7947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8099_8120(Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8099, 8120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8325_8344(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8325, 8344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8499_8522(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8499, 8522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8604_8627(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8604, 8627);
                    return return_v;
                }


                bool
                f_10777_8559_8628(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 8559, 8628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8774_8801(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8774, 8801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8882_8909(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8882, 8909);
                    return return_v;
                }


                bool
                f_10777_8838_8910(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 8838, 8910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_8944_8968(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 8944, 8968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 6287, 9032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 6287, 9032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsReducedSelectOrGroupByClause(SelectOrGroupClauseSyntax selectOrGroupClause, ExpressionSyntax selectOrGroupExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 10732, 12617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 10896, 11020) || true) && (!f_10777_10901_10958(selectOrGroupExpression, SyntaxKind.IdentifierName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 10896, 11020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 10992, 11005);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 10896, 11020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11036, 11120);

                var
                selectorIdentifier = f_10777_11061_11119(((IdentifierNameSyntax)selectOrGroupExpression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11136, 11165);

                SyntaxToken
                sourceIdentifier
                = default(SyntaxToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11179, 11210);

                QueryBodySyntax
                containingBody
                = default(QueryBodySyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11226, 11285);

                f_10777_11226_11284(f_10777_11239_11273(selectOrGroupClause.Parent!) is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11299, 11369);

                var
                containingQueryOrContinuation = f_10777_11335_11368(f_10777_11335_11361(selectOrGroupClause))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11383, 11990) || true) && (f_10777_11387_11451(containingQueryOrContinuation, SyntaxKind.QueryExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 11383, 11990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11485, 11560);

                    var
                    containingQuery = (QueryExpressionSyntax)containingQueryOrContinuation
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11578, 11616);

                    containingBody = f_10777_11595_11615(containingQuery);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11634, 11691);

                    sourceIdentifier = f_10777_11653_11690(f_10777_11653_11679(containingQuery));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 11383, 11990);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 11383, 11990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11757, 11841);

                    var
                    containingContinuation = (QueryContinuationSyntax)containingQueryOrContinuation
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11859, 11912);

                    sourceIdentifier = f_10777_11878_11911(containingContinuation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 11930, 11975);

                    containingBody = f_10777_11947_11974(containingContinuation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 11383, 11990);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12006, 12138) || true) && (!f_10777_12011_12076(sourceIdentifier, selectorIdentifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 12006, 12138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12110, 12123);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 12006, 12138);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12154, 12308) || true) && (f_10777_12158_12209(selectOrGroupClause, SyntaxKind.SelectClause) && (DynAbs.Tracing.TraceSender.Expression_True(10777, 12158, 12246) && containingBody.Clauses.Count == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 12154, 12308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12280, 12293);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 12154, 12308);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12324, 12578);
                    foreach (var clause in f_10777_12347_12369_I(f_10777_12347_12369(containingBody)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 12324, 12578);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12403, 12563) || true) && (!f_10777_12408_12445(clause, SyntaxKind.WhereClause) && (DynAbs.Tracing.TraceSender.Expression_True(10777, 12407, 12489) && !f_10777_12450_12489(clause, SyntaxKind.OrderByClause)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 12403, 12563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12531, 12544);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 12403, 12563);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 12324, 12578);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10777, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10777, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 12594, 12606);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 10732, 12617);

                bool
                f_10777_10901_10958(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 10901, 10958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10777_11061_11119(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11061, 11119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10777_11239_11273(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11239, 11273);
                    return return_v;
                }


                int
                f_10777_11226_11284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 11226, 11284);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10777_11335_11361(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11335, 11361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10777_11335_11368(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11335, 11368);
                    return return_v;
                }


                bool
                f_10777_11387_11451(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 11387, 11451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10777_11595_11615(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11595, 11615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                f_10777_11653_11679(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.FromClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11653, 11679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10777_11653_11690(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11653, 11690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10777_11878_11911(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11878, 11911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10777_11947_11974(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 11947, 11974);
                    return return_v;
                }


                bool
                f_10777_12011_12076(Microsoft.CodeAnalysis.SyntaxToken
                oldToken, Microsoft.CodeAnalysis.SyntaxToken
                newToken)
                {
                    var return_v = SyntaxFactory.AreEquivalent(oldToken, newToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 12011, 12076);
                    return return_v;
                }


                bool
                f_10777_12158_12209(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 12158, 12209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10777_12347_12369(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 12347, 12369);
                    return return_v;
                }


                bool
                f_10777_12408_12445(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 12408, 12445);
                    return return_v;
                }


                bool
                f_10777_12450_12489(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 12450, 12489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10777_12347_12369_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 12347, 12369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 10732, 12617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 10732, 12617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLambdaBodyStatementOrExpression(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 12952, 13083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13046, 13072);

                return f_10777_13053_13071(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 12952, 13083);

                bool
                f_10777_13053_13071(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 13053, 13071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 12952, 13083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 12952, 13083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLambdaBodyStatementOrExpression(SyntaxNode node, out SyntaxNode lambdaBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 13095, 13285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13216, 13234);

                lambdaBody = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13248, 13274);

                return f_10777_13255_13273(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 13095, 13285);

                bool
                f_10777_13255_13273(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 13255, 13273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 13095, 13285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 13095, 13285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryGetLambdaBodies(SyntaxNode node, [NotNullWhen(true)] out SyntaxNode? lambdaBody1, out SyntaxNode? lambdaBody2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 13459, 16395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13616, 13635);

                lambdaBody1 = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13649, 13668);

                lambdaBody2 = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13684, 16355);

                switch (f_10777_13692_13703(node))
                {

                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 13922, 13983);

                        lambdaBody1 = f_10777_13936_13982(((AnonymousFunctionExpressionSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14005, 14017);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14171, 14307) || true) && (f_10777_14175_14221(f_10777_14175_14186(node), SyntaxKind.QueryExpression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 14171, 14307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14271, 14284);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 14171, 14307);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14331, 14381);

                        lambdaBody1 = f_10777_14345_14380(((FromClauseSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14403, 14415);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.JoinClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14484, 14524);

                        var
                        joinClause = (JoinClauseSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14546, 14586);

                        lambdaBody1 = f_10777_14560_14585(joinClause);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14608, 14649);

                        lambdaBody2 = f_10777_14622_14648(joinClause);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14671, 14683);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.LetClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14751, 14800);

                        lambdaBody1 = f_10777_14765_14799(((LetClauseSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14822, 14834);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14904, 14954);

                        lambdaBody1 = f_10777_14918_14953(((WhereClauseSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 14976, 14988);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.AscendingOrdering:
                    case SyntaxKind.DescendingOrdering:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15117, 15165);

                        lambdaBody1 = f_10777_15131_15164(((OrderingSyntax)node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15187, 15199);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15270, 15314);

                        var
                        selectClause = (SelectClauseSyntax)node
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15336, 15495) || true) && (f_10777_15340_15409(selectClause, f_10777_15385_15408(selectClause)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 15336, 15495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15459, 15472);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 15336, 15495);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15519, 15557);

                        lambdaBody1 = f_10777_15533_15556(selectClause);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15579, 15591);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.GroupClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15661, 15703);

                        var
                        groupClause = (GroupClauseSyntax)node
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15725, 16118) || true) && (f_10777_15729_15801(groupClause, f_10777_15773_15800(groupClause)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 15725, 16118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15851, 15890);

                            lambdaBody1 = f_10777_15865_15889(groupClause);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 15725, 16118);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 15725, 16118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 15988, 16030);

                            lambdaBody1 = f_10777_16002_16029(groupClause);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16056, 16095);

                            lambdaBody2 = f_10777_16070_16094(groupClause);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 15725, 16118);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16142, 16154);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);

                    case SyntaxKind.LocalFunctionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 13684, 16355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16235, 16306);

                        lambdaBody1 = f_10777_16249_16305(node);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16328, 16340);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 13684, 16355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16371, 16384);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 13459, 16395);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_13692_13703(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 13692, 13703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10777_13936_13982(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 13936, 13982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_14175_14186(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14175, 14186);
                    return return_v;
                }


                bool
                f_10777_14175_14221(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 14175, 14221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_14345_14380(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14345, 14380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_14560_14585(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14560, 14585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_14622_14648(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14622, 14648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_14765_14799(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14765, 14799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_14918_14953(Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 14918, 14953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_15131_15164(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 15131, 15164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_15385_15408(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 15385, 15408);
                    return return_v;
                }


                bool
                f_10777_15340_15409(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 15340, 15409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_15533_15556(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 15533, 15556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_15773_15800(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 15773, 15800);
                    return return_v;
                }


                bool
                f_10777_15729_15801(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                selectOrGroupClause, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                selectOrGroupExpression)
                {
                    var return_v = IsReducedSelectOrGroupByClause((Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax)selectOrGroupClause, selectOrGroupExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 15729, 15801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_15865_15889(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 15865, 15889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_16002_16029(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 16002, 16029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_16070_16094(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 16070, 16094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_16249_16305(Microsoft.CodeAnalysis.SyntaxNode
                localFunctionStatementSyntax)
                {
                    var return_v = GetLocalFunctionBody((Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax)localFunctionStatementSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 16249, 16305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 13459, 16395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 13459, 16395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool AreEquivalentIgnoringLambdaBodies(SyntaxNode oldNode, SyntaxNode newNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 16532, 17044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16712, 16822);

                var
                oldTokens = f_10777_16728_16821(oldNode, node => node == oldNode || !IsLambdaBodyStatementOrExpression(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16836, 16946);

                var
                newTokens = f_10777_16852_16945(newNode, node => node == newNode || !IsLambdaBodyStatementOrExpression(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 16962, 17033);

                return f_10777_16969_17032(oldTokens, newTokens, SyntaxFactory.AreEquivalent);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 16532, 17044);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_10777_16728_16821(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantTokens(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 16728, 16821);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_10777_16852_16945(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                descendIntoChildren)
                {
                    var return_v = this_param.DescendantTokens(descendIntoChildren);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 16852, 16945);
                    return return_v;
                }


                bool
                f_10777_16969_17032(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                second, System.Func<Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, bool>
                comparer)
                {
                    var return_v = first.SequenceEqual<Microsoft.CodeAnalysis.SyntaxToken>(second, comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 16969, 17032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 16532, 17044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 16532, 17044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsQueryPairLambda(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 17232, 17676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 17500, 17665);

                return f_10777_17507_17544(syntax, SyntaxKind.GroupClause) || (DynAbs.Tracing.TraceSender.Expression_False(10777, 17507, 17604) || f_10777_17568_17604(syntax, SyntaxKind.JoinClause)) || (DynAbs.Tracing.TraceSender.Expression_False(10777, 17507, 17664) || f_10777_17628_17664(syntax, SyntaxKind.FromClause));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 17232, 17676);

                bool
                f_10777_17507_17544(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 17507, 17544);
                    return return_v;
                }


                bool
                f_10777_17568_17604(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 17568, 17604);
                    return return_v;
                }


                bool
                f_10777_17628_17664(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 17628, 17664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 17232, 17676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 17232, 17676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsClosureScope(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 17982, 21712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 18059, 21379);

                switch (f_10777_18067_18078(node))
                {

                    case SyntaxKind.CompilationUnit:
                    case SyntaxKind.Block:
                    case SyntaxKind.SwitchStatement:
                    case SyntaxKind.ArrowExpressionClause:  // expression-bodied member
                    case SyntaxKind.CatchClause:
                    case SyntaxKind.ForStatement:
                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                    case SyntaxKind.UsingStatement:

                    // ctor parameter captured by a lambda in a ctor initializer
                    case SyntaxKind.ConstructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 18059, 21379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 18730, 18742);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 18059, 21379);

                    case SyntaxKind.DoStatement:
                    case SyntaxKind.ExpressionStatement:
                    case SyntaxKind.FixedStatement:
                    case SyntaxKind.GotoCaseStatement:
                    case SyntaxKind.IfStatement:
                    case SyntaxKind.LockStatement:
                    case SyntaxKind.ReturnStatement:
                    case SyntaxKind.ThrowStatement:
                    case SyntaxKind.WhileStatement:
                    case SyntaxKind.YieldReturnStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 18059, 21379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 19374, 19386);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 18059, 21379);

                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 18059, 21379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 19963, 19975);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 18059, 21379);

                    case SyntaxKind.SwitchExpression:
                    case SyntaxKind.AwaitExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 18059, 21379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 20380, 20392);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 18059, 21379);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 18059, 21379);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 20616, 21334) || true) && (f_10777_20620_20631(node) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 20616, 21334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 20689, 21311);

                            switch (f_10777_20697_20715(f_10777_20697_20708(node)))
                            {

                                case SyntaxKind.EqualsValueClause:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 20689, 21311);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 20841, 20853);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 20689, 21311);

                                case SyntaxKind.ForStatement:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 20689, 21311);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 20948, 21048);

                                    SeparatedSyntaxList<ExpressionSyntax>
                                    incrementors = f_10777_21001_21047(((ForStatementSyntax)f_10777_21022_21033(node)))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21082, 21244) || true) && (incrementors.FirstOrDefault() == node)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 21082, 21244);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21197, 21209);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 21082, 21244);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10777, 21278, 21284);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 20689, 21311);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 20616, 21334);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10777, 21358, 21364);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 18059, 21379);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21395, 21478) || true) && (f_10777_21399_21417(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 21395, 21478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21451, 21463);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 21395, 21478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21530, 21672) || true) && (node is ExpressionSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10777, 21534, 21581) && f_10777_21562_21573(node) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10777, 21534, 21611) && f_10777_21585_21603(f_10777_21585_21596(node)) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10777, 21530, 21672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21645, 21657);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10777, 21530, 21672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 21688, 21701);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 17982, 21712);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_18067_18078(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 18067, 18078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_20620_20631(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 20620, 20631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_20697_20708(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 20697, 20708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10777_20697_20715(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 20697, 20715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_21022_21033(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 21022, 21033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10777_21001_21047(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Incrementors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 21001, 21047);
                    return return_v;
                }


                bool
                f_10777_21399_21417(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsLambdaBody(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10777, 21399, 21417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_21562_21573(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 21562, 21573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10777_21585_21596(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 21585, 21596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10777_21585_21603(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 21585, 21603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 17982, 21712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 17982, 21712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetDeclaratorPosition(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 21985, 22334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 22206, 22323);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10777, 22213, 22262) || (((node is SwitchExpressionSyntax) && DynAbs.Tracing.TraceSender.Conditional_F2(10777, 22265, 22305)) || DynAbs.Tracing.TraceSender.Conditional_F3(10777, 22308, 22322))) ? ((SwitchExpressionSyntax)node).SwitchKeyword.SpanStart : f_10777_22308_22322(node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 21985, 22334);

                int
                f_10777_22308_22322(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 22308, 22322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 21985, 22334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 21985, 22334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode GetLocalFunctionBody(LocalFunctionStatementSyntax localFunctionStatementSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10777, 22346, 22600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10777, 22476, 22589);

                return (SyntaxNode?)f_10777_22496_22529(localFunctionStatementSyntax) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SyntaxNode?>(10777, 22483, 22588) ?? f_10777_22533_22588(localFunctionStatementSyntax.ExpressionBody!));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10777, 22346, 22600);

                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10777_22496_22529(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 22496, 22529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10777_22533_22588(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10777, 22533, 22588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10777, 22346, 22600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 22346, 22600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LambdaUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10777, 415, 22607);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10777, 415, 22607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10777, 415, 22607);
        }

    }
}
