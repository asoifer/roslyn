// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class SyntaxNodeExtensions
    {
        public static TNode WithAnnotations<TNode>(this TNode node, params SyntaxAnnotation[] annotations) where TNode : CSharpSyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 389, 619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 543, 608);

                return (TNode)f_10808_557_607<TNode>(f_10808_557_595<TNode>(f_10808_557_567<TNode>(node), annotations));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 389, 619);

                Microsoft.CodeAnalysis.GreenNode
                f_10808_557_567<TNode>(TNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.Green;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 557, 567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GreenNode
                f_10808_557_595<TNode>(Microsoft.CodeAnalysis.GreenNode
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                annotations) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.SetAnnotations(annotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 557, 595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10808_557_607<TNode>(Microsoft.CodeAnalysis.GreenNode
                this_param) where TNode : CSharpSyntaxNode

                {
                    var return_v = this_param.CreateRed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 557, 607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 389, 619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 389, 619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAnonymousFunction(this SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 631, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 718, 747);

                f_10808_718_746(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 761, 1089);

                switch (f_10808_769_782(syntax))
                {

                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 761, 1089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1001, 1013);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 761, 1089);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 761, 1089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1061, 1074);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 761, 1089);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 631, 1100);

                int
                f_10808_718_746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 718, 746);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_769_782(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 769, 782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 631, 1100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 631, 1100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsQuery(this SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 1112, 1860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1187, 1216);

                f_10808_1187_1215(syntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1230, 1849);

                switch (f_10808_1238_1251(syntax))
                {

                    case SyntaxKind.FromClause:
                    case SyntaxKind.GroupClause:
                    case SyntaxKind.JoinClause:
                    case SyntaxKind.JoinIntoClause:
                    case SyntaxKind.LetClause:
                    case SyntaxKind.OrderByClause:
                    case SyntaxKind.QueryContinuation:
                    case SyntaxKind.QueryExpression:
                    case SyntaxKind.SelectClause:
                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 1230, 1849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1761, 1773);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 1230, 1849);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 1230, 1849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 1821, 1834);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 1230, 1849);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 1112, 1860);

                int
                f_10808_1187_1215(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 1187, 1215);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_1238_1251(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 1238, 1251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 1112, 1860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 1112, 1860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CanHaveAssociatedLocalBinder(this SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 2333, 3716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 2431, 2463);

                SyntaxKind
                kind = f_10808_2449_2462(syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 2477, 3705);

                switch (kind)
                {

                    case SyntaxKind.CatchClause:
                    case SyntaxKind.ParenthesizedLambdaExpression:
                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.AnonymousMethodExpression:
                    case SyntaxKind.CatchFilterClause:
                    case SyntaxKind.SwitchSection:
                    case SyntaxKind.EqualsValueClause:
                    case SyntaxKind.Attribute:
                    case SyntaxKind.ArgumentList:
                    case SyntaxKind.ArrowExpressionClause:
                    case SyntaxKind.SwitchExpression:
                    case SyntaxKind.SwitchExpressionArm:
                    case SyntaxKind.BaseConstructorInitializer:
                    case SyntaxKind.ThisConstructorInitializer:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.PrimaryConstructorBaseType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 2477, 3705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 3398, 3410);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 2477, 3705);

                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 2477, 3705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 3486, 3551);

                        return f_10808_3493_3540(((RecordDeclarationSyntax)syntax)) is object;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 2477, 3705);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 2477, 3705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 3601, 3688);

                        return syntax is StatementSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10808, 3608, 3687) || f_10808_3637_3687(syntax as ExpressionSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 2477, 3705);

                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 2333, 3716);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_2449_2462(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 2449, 2462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10808_3493_3540(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 3493, 3540);
                    return return_v;
                }


                bool
                f_10808_3637_3687(Microsoft.CodeAnalysis.SyntaxNode
                expression)
                {
                    var return_v = ((ExpressionSyntax)expression).IsValidScopeDesignator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 3637, 3687);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 2333, 3716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 2333, 3716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsValidScopeDesignator(this ExpressionSyntax? expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 3728, 4902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 3942, 3988);

                CSharpSyntaxNode?
                parent = f_10808_3969_3987_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(expression, 10808, 3969, 3987)?.Parent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4002, 4891);

                switch (f_10808_4010_4024_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 10808, 4010, 4024)?.Kind()))
                {

                    case SyntaxKind.SimpleLambdaExpression:
                    case SyntaxKind.ParenthesizedLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 4002, 4891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4183, 4242);

                        return f_10808_4190_4227(((LambdaExpressionSyntax)parent)) == expression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 4002, 4891);

                    case SyntaxKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 4002, 4891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4316, 4380);

                        return f_10808_4323_4365(((SwitchStatementSyntax)parent)) == expression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 4002, 4891);

                    case SyntaxKind.ForStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 4002, 4891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4451, 4492);

                        var
                        forStmt = (ForStatementSyntax)parent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4514, 4608);

                        return f_10808_4521_4538(forStmt) == expression || (DynAbs.Tracing.TraceSender.Expression_False(10808, 4521, 4607) || forStmt.Incrementors.FirstOrDefault() == expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 4002, 4891);

                    case SyntaxKind.ForEachStatement:
                    case SyntaxKind.ForEachVariableStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 4002, 4891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4742, 4813);

                        return f_10808_4749_4798(((CommonForEachStatementSyntax)parent)) == expression;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 4002, 4891);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 4002, 4891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 4863, 4876);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 4002, 4891);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 3728, 4902);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10808_3969_3987_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 3969, 3987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10808_4010_4024_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 4010, 4024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10808_4190_4227(Microsoft.CodeAnalysis.CSharp.Syntax.LambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 4190, 4227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10808_4323_4365(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 4323, 4365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10808_4521_4538(Microsoft.CodeAnalysis.CSharp.Syntax.ForStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 4521, 4538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10808_4749_4798(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 4749, 4798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 3728, 4902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 3728, 4902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsLegalCSharp73SpanStackAllocPosition(this SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 5330, 6697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5435, 5462);

                f_10808_5435_5461(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5478, 5595) || true) && (f_10808_5482_5527(f_10808_5482_5493(node), SyntaxKind.CastExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 5478, 5595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5561, 5580);

                    node = f_10808_5568_5579(node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 5478, 5595);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5611, 5738) || true) && (f_10808_5618_5670(f_10808_5618_5629(node), SyntaxKind.ConditionalExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 5611, 5738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5704, 5723);

                        node = f_10808_5711_5722(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 5611, 5738);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10808, 5611, 5738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10808, 5611, 5738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5754, 5791);

                SyntaxNode?
                parentNode = f_10808_5779_5790(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5807, 5891) || true) && (parentNode is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 5807, 5891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5863, 5876);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 5807, 5891);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 5907, 6657);

                switch (f_10808_5915_5932(parentNode))
                {

                    case SyntaxKind.EqualsValueClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 5907, 6657);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 6116, 6167);

                            SyntaxNode?
                            variableDeclarator = f_10808_6149_6166(parentNode)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 6195, 6356);

                            return f_10808_6202_6258(variableDeclarator, SyntaxKind.VariableDeclarator) && (DynAbs.Tracing.TraceSender.Expression_True(10808, 6202, 6355) && f_10808_6291_6355(f_10808_6291_6316(variableDeclarator), SyntaxKind.VariableDeclaration));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 5907, 6657);

                    case SyntaxKind.SimpleAssignmentExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 5907, 6657);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 6555, 6619);

                            return f_10808_6562_6618(f_10808_6562_6579(parentNode), SyntaxKind.ExpressionStatement);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 5907, 6657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 6673, 6686);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 5330, 6697);

                int
                f_10808_5435_5461(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 5435, 5461);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_5482_5493(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 5482, 5493);
                    return return_v;
                }


                bool
                f_10808_5482_5527(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 5482, 5527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10808_5568_5579(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 5568, 5579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_5618_5629(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 5618, 5629);
                    return return_v;
                }


                bool
                f_10808_5618_5670(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 5618, 5670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10808_5711_5722(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 5711, 5722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_5779_5790(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 5779, 5790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_5915_5932(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 5915, 5932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_6149_6166(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 6149, 6166);
                    return return_v;
                }


                bool
                f_10808_6202_6258(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 6202, 6258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_6291_6316(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 6291, 6316);
                    return return_v;
                }


                bool
                f_10808_6291_6355(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 6291, 6355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10808_6562_6579(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 6562, 6579);
                    return return_v;
                }


                bool
                f_10808_6562_6618(Microsoft.CodeAnalysis.SyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 6562, 6618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 5330, 6697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 5330, 6697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSyntaxNode AnonymousFunctionBody(this SyntaxNode lambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10808, 6801, 6852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 6804, 6852);
                return f_10808_6804_6852(((AnonymousFunctionExpressionSyntax)lambda)); DynAbs.Tracing.TraceSender.TraceExitMethod(10808, 6801, 6852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 6801, 6852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 6801, 6852);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            f_10808_6804_6852(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousFunctionExpressionSyntax
            this_param)
            {
                var return_v = this_param.Body;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 6804, 6852);
                return return_v;
            }

        }

        internal static SyntaxToken ExtractAnonymousTypeMemberName(this ExpressionSyntax input)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 7057, 8114);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7169, 8103) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7169, 8103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7214, 8088);

                        switch (f_10808_7222_7234(input))
                        {

                            case SyntaxKind.IdentifierName:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7214, 8088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7333, 7381);

                                return f_10808_7340_7380(((IdentifierNameSyntax)input));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7214, 8088);

                            case SyntaxKind.SimpleMemberAccessExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7214, 8088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7476, 7527);

                                input = f_10808_7484_7526(((MemberAccessExpressionSyntax)input));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7553, 7562);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7214, 8088);

                            case SyntaxKind.ConditionalAccessExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7214, 8088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7656, 7719);

                                input = f_10808_7664_7718(((ConditionalAccessExpressionSyntax)input));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7745, 7946) || true) && (f_10808_7749_7761(input) == SyntaxKind.MemberBindingExpression)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7745, 7946);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7857, 7919);

                                    return f_10808_7864_7918(f_10808_7864_7907(((MemberBindingExpressionSyntax)input)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7745, 7946);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 7974, 7983);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7214, 8088);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 7214, 8088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8041, 8069);

                                return default(SyntaxToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7214, 8088);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 7169, 8103);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10808, 7169, 8103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10808, 7169, 8103);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 7057, 8114);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_7222_7234(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 7222, 7234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10808_7340_7380(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 7340, 7380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10808_7484_7526(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 7484, 7526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10808_7664_7718(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 7664, 7718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_7749_7761(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 7749, 7761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10808_7864_7907(Microsoft.CodeAnalysis.CSharp.Syntax.MemberBindingExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 7864, 7907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10808_7864_7918(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 7864, 7918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 7057, 8114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 7057, 8114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RefKind GetRefKind(this TypeSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 8126, 8281);
                Microsoft.CodeAnalysis.RefKind refKind = default(Microsoft.CodeAnalysis.RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8209, 8241);

                f_10808_8209_8240(syntax, out refKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8255, 8270);

                return refKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 8126, 8281);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10808_8209_8240(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = syntax.SkipRef(out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 8209, 8240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 8126, 8281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 8126, 8281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSyntax SkipRef(this TypeSyntax syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 8293, 8543);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8376, 8502) || true) && (f_10808_8380_8393(syntax) == SyntaxKind.RefType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 8376, 8502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8449, 8487);

                    syntax = f_10808_8458_8486(((RefTypeSyntax)syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 8376, 8502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8518, 8532);

                return syntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 8293, 8543);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_8380_8393(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 8380, 8393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10808_8458_8486(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 8458, 8486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 8293, 8543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 8293, 8543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSyntax SkipRef(this TypeSyntax syntax, out RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 8555, 9070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8659, 8682);

                refKind = RefKind.None;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8696, 9029) || true) && (f_10808_8700_8713(syntax) == SyntaxKind.RefType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 8696, 9029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8769, 8805);

                    var
                    refType = (RefTypeSyntax)syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8823, 8972);

                    refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10808, 8833, 8893) || ((refType.ReadOnlyKeyword.Kind() == SyntaxKind.ReadOnlyKeyword && DynAbs.Tracing.TraceSender.Conditional_F2(10808, 8917, 8936)) || DynAbs.Tracing.TraceSender.Conditional_F3(10808, 8960, 8971))) ? RefKind.RefReadOnly : RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 8992, 9014);

                    syntax = f_10808_9001_9013(refType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 8696, 9029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9045, 9059);

                return syntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 8555, 9070);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_8700_8713(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 8700, 8713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10808_9001_9013(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 9001, 9013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 8555, 9070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 8555, 9070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ExpressionSyntax? CheckAndUnwrapRefExpression(
                    this ExpressionSyntax? syntax,
                    DiagnosticBag diagnostics,
                    out RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 9082, 9628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9287, 9310);

                refKind = RefKind.None;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9324, 9587) || true) && (f_10808_9328_9342_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(syntax, 10808, 9328, 9342)?.Kind()) == SyntaxKind.RefExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 9324, 9587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9404, 9426);

                    refKind = RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9444, 9494);

                    syntax = f_10808_9453_9493(((RefExpressionSyntax)syntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9514, 9572);

                    f_10808_9514_9571(
                                    syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 9324, 9587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9603, 9617);

                return syntax;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 9082, 9628);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10808_9328_9342_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 9328, 9342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10808_9453_9493(Microsoft.CodeAnalysis.CSharp.Syntax.RefExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 9453, 9493);
                    return return_v;
                }


                int
                f_10808_9514_9571(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    expression.CheckDeconstructionCompatibleArgument(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 9514, 9571);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 9082, 9628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 9082, 9628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckDeconstructionCompatibleArgument(this ExpressionSyntax expression, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 9640, 9979);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9784, 9968) || true) && (f_10808_9788_9834(expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 9784, 9968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 9868, 9953);

                    f_10808_9868_9952(diagnostics, ErrorCode.ERR_VarInvocationLvalueReserved, f_10808_9927_9951(expression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 9784, 9968);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 9640, 9979);

                bool
                f_10808_9788_9834(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = IsDeconstructionCompatibleArgument(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 9788, 9834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10808_9927_9951(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 9927, 9951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10808_9868_9952(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 9868, 9952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 9640, 9979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 9640, 9979);
            }
        }

        private static bool IsDeconstructionCompatibleArgument(ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10808, 10533, 11056);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 10641, 11016) || true) && (f_10808_10645_10662(expression) == SyntaxKind.InvocationExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10808, 10641, 11016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 10731, 10787);

                    var
                    invocation = (InvocationExpressionSyntax)expression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 10805, 10850);

                    var
                    invocationTarget = f_10808_10828_10849(invocation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 10870, 11001);

                    return f_10808_10877_10900(invocationTarget) == SyntaxKind.IdentifierName && (DynAbs.Tracing.TraceSender.Expression_True(10808, 10877, 11000) && f_10808_10954_11000(((IdentifierNameSyntax)invocationTarget)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10808, 10641, 11016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10808, 11032, 11045);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10808, 10533, 11056);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_10645_10662(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 10645, 10662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10808_10828_10849(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 10828, 10849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10808_10877_10900(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10808, 10877, 10900);
                    return return_v;
                }


                bool
                f_10808_10954_11000(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10808, 10954, 11000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10808, 10533, 11056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 10533, 11056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxNodeExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10808, 330, 11063);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10808, 330, 11063);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10808, 330, 11063);
        }

    }
}
