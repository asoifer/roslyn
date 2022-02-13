// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class ExpressionVariableFinder<TFieldOrLocalSymbol> : CSharpSyntaxWalker where TFieldOrLocalSymbol : Symbol
    {
        private ArrayBuilder<TFieldOrLocalSymbol> _variablesBuilder;

        private SyntaxNode _nodeToBind;

        protected void FindExpressionVariables(
                    ArrayBuilder<TFieldOrLocalSymbol> builder,
                    CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 809, 2758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 965, 992);

                f_10336_965_991(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 1008, 1067);

                ArrayBuilder<TFieldOrLocalSymbol>
                save = _variablesBuilder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 1081, 1109);

                _variablesBuilder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 1321, 2660);

                switch (f_10336_1329_1340(node))
                {

                    case SyntaxKind.EqualsValueClause:
                    case SyntaxKind.ArrowExpressionClause:
                    case SyntaxKind.SwitchSection:
                    case SyntaxKind.Attribute:
                    case SyntaxKind.ThrowStatement:
                    case SyntaxKind.ReturnStatement:
                    case SyntaxKind.YieldReturnStatement:
                    case SyntaxKind.ExpressionStatement:
                    case SyntaxKind.LockStatement:
                    case SyntaxKind.IfStatement:
                    case SyntaxKind.SwitchStatement:
                    case SyntaxKind.VariableDeclarator:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.SwitchExpressionArm:
                    case SyntaxKind.GotoCaseStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 1321, 2660);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 2146, 2152);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 1321, 2660);

                    case SyntaxKind.ArgumentList:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 1321, 2660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2221, 2330);

                        f_10336_2221_2329(f_10336_2234_2245(node) is ConstructorInitializerSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10336, 2234, 2328) || f_10336_2281_2292(node) is PrimaryConstructorBaseTypeSyntax));
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 2352, 2358);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 1321, 2660);

                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 1321, 2660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2432, 2502);

                        f_10336_2432_2501(f_10336_2445_2490(((RecordDeclarationSyntax)node)) is object);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 2524, 2530);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 1321, 2660);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 1321, 2660);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2578, 2617);

                        f_10336_2578_2616(node is ExpressionSyntax);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 2639, 2645);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 1321, 2660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2684, 2706);

                f_10336_2684_2705(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2722, 2747);

                _variablesBuilder = save;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 809, 2758);

                int
                f_10336_965_991(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 965, 991);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_1329_1340(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 1329, 1340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10336_2234_2245(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 2234, 2245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10336_2281_2292(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 2281, 2292);
                    return return_v;
                }


                int
                f_10336_2221_2329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 2221, 2329);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10336_2445_2490(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 2445, 2490);
                    return return_v;
                }


                int
                f_10336_2432_2501(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 2432, 2501);
                    return 0;
                }


                int
                f_10336_2578_2616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 2578, 2616);
                    return 0;
                }


                int
                f_10336_2684_2705(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.VisitNodeToBind(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 2684, 2705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 809, 2758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 809, 2758);
            }
        }

        public override void Visit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 2770, 2986);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2838, 2975) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 2838, 2975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 2922, 2960);

                    f_10336_2922_2959(                // no stackguard
                                    ((CSharpSyntaxNode)node), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 2838, 2975);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 2770, 2986);

                int
                f_10336_2922_2959(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 2922, 2959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 2770, 2986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 2770, 2986);
            }
        }

        public override void VisitSwitchExpression(SwitchExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 2998, 3182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3094, 3126);

                f_10336_3094_3125(this, f_10336_3100_3124(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 2998, 3182);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_3100_3124(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3100, 3124);
                    return return_v;
                }


                int
                f_10336_3094_3125(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3094, 3125);
                    return 0;
                }

                // Each case has its own scope.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 2998, 3182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 2998, 3182);
            }
        }

        public override void VisitSwitchExpressionArm(SwitchExpressionArmSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 3194, 3550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3296, 3340);

                SyntaxNode
                previousNodeToBind = _nodeToBind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3354, 3373);

                _nodeToBind = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3387, 3407);

                f_10336_3387_3406(this, f_10336_3393_3405(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3421, 3455);

                f_10336_3421_3454(this, f_10336_3427_3453_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10336_3427_3442(node), 10336, 3427, 3453)?.Condition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3469, 3492);

                f_10336_3469_3491(this, f_10336_3475_3490(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3506, 3539);

                _nodeToBind = previousNodeToBind;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 3194, 3550);

                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10336_3393_3405(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3393, 3405);
                    return return_v;
                }


                int
                f_10336_3387_3406(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3387, 3406);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10336_3427_3442(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3427, 3442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10336_3427_3453_M(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3427, 3453);
                    return return_v;
                }


                int
                f_10336_3421_3454(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3421, 3454);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_3475_3490(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3475, 3490);
                    return return_v;
                }


                int
                f_10336_3469_3491(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3469, 3491);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 3194, 3550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 3194, 3550);
            }
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 3562, 3942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3662, 3881) || true) && (f_10336_3666_3683(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 3662, 3881);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3725, 3866);
                        foreach (ArgumentSyntax arg in f_10336_3756_3783_I(f_10336_3756_3783(f_10336_3756_3773(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 3725, 3866);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3825, 3847);

                            f_10336_3825_3846(this, f_10336_3831_3845(arg));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 3725, 3866);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 142);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 3662, 3881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 3897, 3931);

                f_10336_3897_3930(this, f_10336_3913_3929(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 3562, 3942);

                Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax?
                f_10336_3666_3683(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3666, 3683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                f_10336_3756_3773(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3756, 3773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10336_3756_3783(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3756, 3783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_3831_3845(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3831, 3845);
                    return return_v;
                }


                int
                f_10336_3825_3846(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3825, 3846);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10336_3756_3783_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3756, 3783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10336_3913_3929(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 3913, 3929);
                    return return_v;
                }


                int
                f_10336_3897_3930(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 3897, 3930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 3562, 3942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 3562, 3942);
            }
        }

        public override void VisitGotoStatement(GotoStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 3954, 4144);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4044, 4133) || true) && (f_10336_4048_4059(node) == SyntaxKind.GotoCaseStatement)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 4044, 4133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4110, 4133);

                    f_10336_4110_4132(this, f_10336_4116_4131(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 4044, 4133);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 3954, 4144);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_4048_4059(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4048, 4059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10336_4116_4131(Microsoft.CodeAnalysis.CSharp.Syntax.GotoStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 4116, 4131);
                    return return_v;
                }


                int
                f_10336_4110_4132(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4110, 4132);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 3954, 4144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 3954, 4144);
            }
        }

        private void VisitNodeToBind(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 4156, 4393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4232, 4276);

                SyntaxNode
                previousNodeToBind = _nodeToBind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4290, 4309);

                _nodeToBind = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4323, 4335);

                f_10336_4323_4334(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4349, 4382);

                _nodeToBind = previousNodeToBind;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 4156, 4393);

                int
                f_10336_4323_4334(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4323, 4334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 4156, 4393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 4156, 4393);
            }
        }

        protected void FindExpressionVariables(
                    ArrayBuilder<TFieldOrLocalSymbol> builder,
                    SeparatedSyntaxList<ExpressionSyntax> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 4405, 4900);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4583, 4613);

                f_10336_4583_4612(nodes.Count > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4627, 4686);

                ArrayBuilder<TFieldOrLocalSymbol>
                save = _variablesBuilder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4700, 4728);

                _variablesBuilder = builder;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4744, 4848);
                    foreach (ExpressionSyntax n in f_10336_4775_4780_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 4744, 4848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4814, 4833);

                        f_10336_4814_4832(this, n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 4744, 4848);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 4864, 4889);

                _variablesBuilder = save;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 4405, 4900);

                int
                f_10336_4583_4612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4583, 4612);
                    return 0;
                }


                int
                f_10336_4814_4832(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4814, 4832);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10336_4775_4780_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 4775, 4780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 4405, 4900);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 4405, 4900);
            }
        }

        public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 4912, 5049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5010, 5038);

                f_10336_5010_5037(this, f_10336_5026_5036(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 4912, 5049);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_5026_5036(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5026, 5036);
                    return return_v;
                }


                int
                f_10336_5010_5037(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5010, 5037);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 4912, 5049);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 4912, 5049);
            }
        }

        public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 5061, 5211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5167, 5200);

                f_10336_5167_5199(this, f_10336_5183_5198(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 5061, 5211);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_5183_5198(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5183, 5198);
                    return return_v;
                }


                int
                f_10336_5167_5199(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5167, 5199);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 5061, 5211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 5061, 5211);
            }
        }

        public override void VisitSwitchSection(SwitchSectionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 5223, 6463);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5313, 6452);
                    foreach (SwitchLabelSyntax label in f_10336_5349_5360_I(f_10336_5349_5360(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 5313, 6452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5394, 6437);

                        switch (f_10336_5402_5414(label))
                        {

                            case SyntaxKind.CasePatternSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 5394, 6437);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5552, 5606);

                                    var
                                    switchLabel = (CasePatternSwitchLabelSyntax)label
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5636, 5680);

                                    SyntaxNode
                                    previousNodeToBind = _nodeToBind
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5710, 5736);

                                    _nodeToBind = switchLabel;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5766, 5793);

                                    f_10336_5766_5792(this, f_10336_5772_5791(switchLabel));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5823, 6004) || true) && (f_10336_5827_5849(switchLabel) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 5823, 6004);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 5923, 5973);

                                        f_10336_5923_5972(this, f_10336_5939_5971(f_10336_5939_5961(switchLabel)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 5823, 6004);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6036, 6069);

                                    _nodeToBind = previousNodeToBind;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10336, 6099, 6105);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 5394, 6437);

                            case SyntaxKind.CaseSwitchLabel:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 5394, 6437);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6243, 6290);

                                    var
                                    switchlabel = (CaseSwitchLabelSyntax)label
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6320, 6355);

                                    f_10336_6320_6354(this, f_10336_6336_6353(switchlabel));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10336, 6385, 6391);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 5394, 6437);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 5313, 6452);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 1140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 1140);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 5223, 6463);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10336_5349_5360(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5349, 5360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_5402_5414(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5402, 5414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10336_5772_5791(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5772, 5791);
                    return return_v;
                }


                int
                f_10336_5766_5792(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5766, 5792);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10336_5827_5849(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5827, 5849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                f_10336_5939_5961(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5939, 5961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_5939_5971(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 5939, 5971);
                    return return_v;
                }


                int
                f_10336_5923_5972(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5923, 5972);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_6336_6353(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6336, 6353);
                    return return_v;
                }


                int
                f_10336_6320_6354(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 6320, 6354);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10336_5349_5360_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 5349, 5360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 5223, 6463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 5223, 6463);
            }
        }

        public override void VisitAttribute(AttributeSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 6475, 6816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6557, 6805) || true) && (f_10336_6561_6578(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 6557, 6805);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6620, 6790);
                        foreach (AttributeArgumentSyntax argument in f_10336_6665_6692_I(f_10336_6665_6692(f_10336_6665_6682(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 6620, 6790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6734, 6771);

                            f_10336_6734_6770(this, f_10336_6750_6769(argument));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 6620, 6790);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 171);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 171);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 6557, 6805);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 6475, 6816);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10336_6561_6578(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6561, 6578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                f_10336_6665_6682(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6665, 6682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10336_6665_6692(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6665, 6692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_6750_6769(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6750, 6769);
                    return return_v;
                }


                int
                f_10336_6734_6770(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 6734, 6770);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10336_6665_6692_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 6665, 6692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 6475, 6816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 6475, 6816);
            }
        }

        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 6828, 6964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 6920, 6953);

                f_10336_6920_6952(this, f_10336_6936_6951(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 6828, 6964);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10336_6936_6951(Microsoft.CodeAnalysis.CSharp.Syntax.ThrowStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 6936, 6951);
                    return return_v;
                }


                int
                f_10336_6920_6952(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 6920, 6952);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 6828, 6964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 6828, 6964);
            }
        }

        public override void VisitReturnStatement(ReturnStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 6976, 7114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7070, 7103);

                f_10336_7070_7102(this, f_10336_7086_7101(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 6976, 7114);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10336_7086_7101(Microsoft.CodeAnalysis.CSharp.Syntax.ReturnStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7086, 7101);
                    return return_v;
                }


                int
                f_10336_7070_7102(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7070, 7102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 6976, 7114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 6976, 7114);
            }
        }

        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7126, 7262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7218, 7251);

                f_10336_7218_7250(this, f_10336_7234_7249(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7126, 7262);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                f_10336_7234_7249(Microsoft.CodeAnalysis.CSharp.Syntax.YieldStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7234, 7249);
                    return return_v;
                }


                int
                f_10336_7218_7250(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7218, 7250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7126, 7262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7126, 7262);
            }
        }

        public override void VisitExpressionStatement(ExpressionStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7274, 7420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7376, 7409);

                f_10336_7376_7408(this, f_10336_7392_7407(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7274, 7420);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_7392_7407(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7392, 7407);
                    return return_v;
                }


                int
                f_10336_7376_7408(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7376, 7408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7274, 7420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7274, 7420);
            }
        }

        public override void VisitLockStatement(LockStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7432, 7566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7522, 7555);

                f_10336_7522_7554(this, f_10336_7538_7553(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7432, 7566);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_7538_7553(Microsoft.CodeAnalysis.CSharp.Syntax.LockStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7538, 7553);
                    return return_v;
                }


                int
                f_10336_7522_7554(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7522, 7554);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7432, 7566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7432, 7566);
            }
        }

        public override void VisitIfStatement(IfStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7578, 7707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7664, 7696);

                f_10336_7664_7695(this, f_10336_7680_7694(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7578, 7707);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_7680_7694(Microsoft.CodeAnalysis.CSharp.Syntax.IfStatementSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7680, 7694);
                    return return_v;
                }


                int
                f_10336_7664_7695(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7664, 7695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7578, 7707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7578, 7707);
            }
        }

        public override void VisitSwitchStatement(SwitchStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7719, 7857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7813, 7846);

                f_10336_7813_7845(this, f_10336_7829_7844(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7719, 7857);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_7829_7844(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7829, 7844);
                    return return_v;
                }


                int
                f_10336_7813_7845(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7813, 7845);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7719, 7857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7719, 7857);
            }
        }

        public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 7869, 8673);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 7969, 8611) || true) && (f_10336_7973_7997_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10336_7973_7989(node), 10336, 7973, 7997).Kind()) == SyntaxKind.SingleVariableDesignation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 7969, 8611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8071, 8197);

                    TFieldOrLocalSymbol
                    variable = f_10336_8102_8196(this, f_10336_8122_8131(node), f_10336_8166_8182(node), _nodeToBind)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8215, 8336) || true) && ((object)variable != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 8215, 8336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8285, 8317);

                        f_10336_8285_8316(_variablesBuilder, variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 8215, 8336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 7969, 8611);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 7969, 8611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8497, 8596);

                    f_10336_8497_8595(f_10336_8510_8526(node) == null || (DynAbs.Tracing.TraceSender.Expression_False(10336, 8510, 8594) || f_10336_8538_8561(f_10336_8538_8554(node)) == SyntaxKind.DiscardDesignation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 7969, 8611);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8627, 8662);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDeclarationPattern(node), 10336, 8627, 8661);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 7869, 8673);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_7973_7989(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 7973, 7989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10336_7973_7997_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 7973, 7997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10336_8122_8131(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 8122, 8131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_8166_8182(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 8166, 8182);
                    return return_v;
                }


                TFieldOrLocalSymbol
                f_10336_8102_8196(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(type, (Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax)designation, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8102, 8196);
                    return return_v;
                }


                int
                f_10336_8285_8316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TFieldOrLocalSymbol>
                this_param, TFieldOrLocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8285, 8316);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10336_8510_8526(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 8510, 8526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_8538_8554(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 8538, 8554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_8538_8561(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8538, 8561);
                    return return_v;
                }


                int
                f_10336_8497_8595(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8497, 8595);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 7869, 8673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 7869, 8673);
            }
        }

        public override void VisitVarPattern(VarPatternSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 8685, 8863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8769, 8811);

                f_10336_8769_8810(this, f_10336_8793_8809(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8825, 8852);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitVarPattern(node), 10336, 8825, 8851);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 8685, 8863);

                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_8793_8809(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 8793, 8809);
                    return return_v;
                }


                int
                f_10336_8769_8810(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node)
                {
                    this_param.VisitPatternDesignation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8769, 8810);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 8685, 8863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 8685, 8863);
            }
        }

        private void VisitPatternDesignation(VariableDesignationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 8875, 9911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 8968, 9900);

                switch (f_10336_8976_8987(node))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 8968, 9900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9085, 9194);

                        TFieldOrLocalSymbol
                        variable = f_10336_9116_9193(this, null, node, _nodeToBind)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9216, 9349) || true) && ((object)variable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 9216, 9349);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9294, 9326);

                            f_10336_9294_9325(_variablesBuilder, variable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 9216, 9349);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 9371, 9377);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 8968, 9900);

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 8968, 9900);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 9452, 9458);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 8968, 9900);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 8968, 9900);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9547, 9753);
                            foreach (VariableDesignationSyntax nested in f_10336_9592_9648_I(f_10336_9592_9648(((ParenthesizedVariableDesignationSyntax)node))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 9547, 9753);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9698, 9730);

                                f_10336_9698_9729(this, nested);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 9547, 9753);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 207);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 207);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 9775, 9781);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 8968, 9900);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 8968, 9900);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 9831, 9885);

                        throw f_10336_9837_9884(f_10336_9872_9883(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 8968, 9900);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 8875, 9911);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_8976_8987(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 8976, 8987);
                    return return_v;
                }


                TFieldOrLocalSymbol
                f_10336_9116_9193(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(type, (Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax)designation, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9116, 9193);
                    return return_v;
                }


                int
                f_10336_9294_9325(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TFieldOrLocalSymbol>
                this_param, TFieldOrLocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9294, 9325);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_9592_9648(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 9592, 9648);
                    return return_v;
                }


                int
                f_10336_9698_9729(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node)
                {
                    this_param.VisitPatternDesignation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9698, 9729);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_9592_9648_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9592, 9648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_9872_9883(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9872, 9883);
                    return return_v;
                }


                System.Exception
                f_10336_9837_9884(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 9837, 9884);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 8875, 9911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 8875, 9911);
            }
        }

        public override void VisitRecursivePattern(RecursivePatternSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 9923, 10272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 10019, 10089);

                TFieldOrLocalSymbol
                variable = f_10336_10050_10088(this, node, _nodeToBind)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 10103, 10212) || true) && ((object)variable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 10103, 10212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 10165, 10197);

                    f_10336_10165_10196(_variablesBuilder, variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 10103, 10212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 10228, 10261);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitRecursivePattern(node), 10336, 10228, 10260);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 9923, 10272);

                TFieldOrLocalSymbol
                f_10336_10050_10088(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                node, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(node, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 10050, 10088);
                    return return_v;
                }


                int
                f_10336_10165_10196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TFieldOrLocalSymbol>
                this_param, TFieldOrLocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 10165, 10196);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 9923, 10272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 9923, 10272);
            }
        }

        protected abstract TFieldOrLocalSymbol MakePatternVariable(TypeSyntax type, SingleVariableDesignationSyntax designation, SyntaxNode nodeToBind);

        protected abstract TFieldOrLocalSymbol MakePatternVariable(RecursivePatternSyntax node, SyntaxNode nodeToBind);

        public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 10561, 10662);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 10561, 10662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 10561, 10662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 10561, 10662);
            }
        }

        public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 10672, 10759);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 10672, 10759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 10672, 10759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 10672, 10759);
            }
        }

        public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 10769, 10862);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 10769, 10862);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 10769, 10862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 10769, 10862);
            }
        }

        public override void VisitQueryExpression(QueryExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 10874, 11180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11094, 11138);

                f_10336_11094_11137(this, f_10336_11110_11136(f_10336_11110_11125(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11152, 11169);

                f_10336_11152_11168(this, f_10336_11158_11167(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 10874, 11180);

                Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                f_10336_11110_11125(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.FromClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11110, 11125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_11110_11136(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11110, 11136);
                    return return_v;
                }


                int
                f_10336_11094_11137(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11094, 11137);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10336_11158_11167(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11158, 11167);
                    return return_v;
                }


                int
                f_10336_11152_11168(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11152, 11168);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 10874, 11180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 10874, 11180);
            }
        }

        public override void VisitQueryBody(QueryBodySyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 11192, 11710);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11400, 11658);
                    foreach (QueryClauseSyntax clause in f_10336_11437_11449_I(f_10336_11437_11449(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 11400, 11658);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11483, 11643) || true) && (f_10336_11487_11500(clause) == SyntaxKind.JoinClause)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 11483, 11643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11567, 11624);

                            f_10336_11567_11623(this, f_10336_11583_11622(((JoinClauseSyntax)clause)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 11483, 11643);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 11400, 11658);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 11674, 11699);

                f_10336_11674_11698(this, f_10336_11680_11697(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 11192, 11710);

                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10336_11437_11449(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11437, 11449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_11487_11500(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11487, 11500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_11583_11622(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.InExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11583, 11622);
                    return return_v;
                }


                int
                f_10336_11567_11623(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11567, 11623);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10336_11437_11449_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11437, 11449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                f_10336_11680_11697(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Continuation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 11680, 11697);
                    return return_v;
                }


                int
                f_10336_11674_11698(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 11674, 11698);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 11192, 11710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 11192, 11710);
            }
        }

        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 11722, 12767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12229, 12289);

                var
                operands = f_10336_12244_12288()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12303, 12335);

                ExpressionSyntax
                current = node
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 12349, 12583);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12384, 12428);

                            var
                            binOp = (BinaryExpressionSyntax)current
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12446, 12473);

                            f_10336_12446_12472(operands, f_10336_12460_12471(binOp));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12491, 12512);

                            current = f_10336_12501_12511(binOp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 12349, 12583);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12349, 12583) || true) && (current is BinaryExpressionSyntax)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 12349, 12583);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 12349, 12583);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12599, 12614);

                f_10336_12599_12613(this, current);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12628, 12724) || true) && (f_10336_12635_12649(operands) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 12628, 12724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12687, 12709);

                        f_10336_12687_12708(this, f_10336_12693_12707(operands));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 12628, 12724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 12628, 12724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 12628, 12724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12740, 12756);

                f_10336_12740_12755(
                            operands);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 11722, 12767);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10336_12244_12288()
                {
                    var return_v = ArrayBuilder<ExpressionSyntax>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12244, 12288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_12460_12471(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 12460, 12471);
                    return return_v;
                }


                int
                f_10336_12446_12472(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                builder, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12446, 12472);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_12501_12511(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 12501, 12511);
                    return return_v;
                }


                int
                f_10336_12599_12613(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12599, 12613);
                    return 0;
                }


                int
                f_10336_12635_12649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 12635, 12649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_12693_12707(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12693, 12707);
                    return return_v;
                }


                int
                f_10336_12687_12708(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12687, 12708);
                    return 0;
                }


                int
                f_10336_12740_12755(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 12740, 12755);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 11722, 12767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 11722, 12767);
            }
        }

        public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 12779, 13139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12885, 12936);

                var
                argumentSyntax = f_10336_12906_12917(node) as ArgumentSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 12950, 13027);

                var
                argumentListSyntaxOpt = f_10336_12978_13000_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argumentSyntax, 10336, 12978, 13000)?.Parent) as BaseArgumentListSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13043, 13128);

                f_10336_13043_13127(this, node, f_10336_13087_13103(node), argumentListSyntaxOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 12779, 13139);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10336_12906_12917(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 12906, 12917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10336_12978_13000_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 12978, 13000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_13087_13103(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 13087, 13103);
                    return return_v;
                }


                int
                f_10336_13043_13127(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax?
                argumentListSyntaxOpt)
                {
                    this_param.VisitDeclarationExpressionDesignation(node, designation, argumentListSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 13043, 13127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 12779, 13139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 12779, 13139);
            }
        }

        private void VisitDeclarationExpressionDesignation(DeclarationExpressionSyntax node, VariableDesignationSyntax designation, BaseArgumentListSyntax argumentListSyntaxOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 13151, 14400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13345, 14389);

                switch (f_10336_13353_13371(designation))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13345, 14389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13469, 13622);

                        TFieldOrLocalSymbol
                        variable = f_10336_13500_13621(this, node, designation, argumentListSyntaxOpt, _nodeToBind)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13644, 13777) || true) && ((object)variable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13644, 13777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13722, 13754);

                            f_10336_13722_13753(_variablesBuilder, variable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13644, 13777);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 13799, 13805);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13345, 14389);

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13345, 14389);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 13882, 13888);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13345, 14389);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13345, 14389);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 13979, 14235);
                            foreach (VariableDesignationSyntax nested in f_10336_14024_14087_I(f_10336_14024_14087(((ParenthesizedVariableDesignationSyntax)designation))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13979, 14235);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14137, 14212);

                                f_10336_14137_14211(this, node, nested, argumentListSyntaxOpt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13979, 14235);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 257);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 257);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 14257, 14263);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13345, 14389);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 13345, 14389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14313, 14374);

                        throw f_10336_14319_14373(f_10336_14354_14372(designation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 13345, 14389);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 13151, 14400);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_13353_13371(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 13353, 13371);
                    return return_v;
                }


                TFieldOrLocalSymbol
                f_10336_13500_13621(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax
                argumentListSyntax, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakeDeclarationExpressionVariable(node, (Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax)designation, argumentListSyntax, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 13500, 13621);
                    return return_v;
                }


                int
                f_10336_13722_13753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TFieldOrLocalSymbol>
                this_param, TFieldOrLocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 13722, 13753);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_14024_14087(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14024, 14087);
                    return return_v;
                }


                int
                f_10336_14137_14211(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax
                argumentListSyntaxOpt)
                {
                    this_param.VisitDeclarationExpressionDesignation(node, designation, argumentListSyntaxOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14137, 14211);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_14024_14087_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14024, 14087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_14354_14372(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14354, 14372);
                    return return_v;
                }


                System.Exception
                f_10336_14319_14373(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14319, 14373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 13151, 14400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 13151, 14400);
            }
        }

        public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 14412, 14772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14516, 14727) || true) && (f_10336_14520_14543(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 14516, 14727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14577, 14629);

                    f_10336_14577_14628(this, f_10336_14612_14621(node), node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 14516, 14727);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 14516, 14727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14695, 14712);

                    f_10336_14695_14711(this, f_10336_14701_14710(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 14516, 14727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14743, 14761);

                f_10336_14743_14760(this, f_10336_14749_14759(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 14412, 14772);

                bool
                f_10336_14520_14543(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                self)
                {
                    var return_v = self.IsDeconstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14520, 14543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_14612_14621(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14612, 14621);
                    return return_v;
                }


                int
                f_10336_14577_14628(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                possibleTupleDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    this_param.CollectVariablesFromDeconstruction(possibleTupleDeclaration, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14577, 14628);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_14701_14710(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14701, 14710);
                    return return_v;
                }


                int
                f_10336_14695_14711(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14695, 14711);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_14749_14759(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14749, 14759);
                    return return_v;
                }


                int
                f_10336_14743_14760(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14743, 14760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 14412, 14772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 14412, 14772);
            }
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 14784, 15014);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14892, 15003) || true) && (f_10336_14896_14912(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 14892, 15003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 14954, 14988);

                    f_10336_14954_14987(this, f_10336_14970_14986(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 14892, 15003);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 14784, 15014);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10336_14896_14912(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14896, 14912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10336_14970_14986(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 14970, 14986);
                    return return_v;
                }


                int
                f_10336_14954_14987(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 14954, 14987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 14784, 15014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 14784, 15014);
            }
        }

        public override void VisitRecordDeclaration(RecordDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 15026, 15367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15124, 15167);

                f_10336_15124_15166(f_10336_15137_15155(node) is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15183, 15356) || true) && (f_10336_15187_15218(node) is PrimaryConstructorBaseTypeSyntax baseWithArguments)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 15183, 15356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15306, 15341);

                    f_10336_15306_15340(this, baseWithArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 15183, 15356);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 15026, 15367);

                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10336_15137_15155(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 15137, 15155);
                    return return_v;
                }


                int
                f_10336_15124_15166(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 15124, 15166);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10336_15187_15218(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 15187, 15218);
                    return return_v;
                }


                int
                f_10336_15306_15340(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                node)
                {
                    this_param.VisitNodeToBind((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 15306, 15340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 15026, 15367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 15026, 15367);
            }
        }

        private void CollectVariablesFromDeconstruction(
                    ExpressionSyntax possibleTupleDeclaration,
                    AssignmentExpressionSyntax deconstruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 15379, 16627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15564, 16616);

                switch (f_10336_15572_15603(possibleTupleDeclaration))
                {

                    case SyntaxKind.TupleExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 15564, 16616);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15718, 15778);

                            var
                            tuple = (TupleExpressionSyntax)possibleTupleDeclaration
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15804, 16002);
                                foreach (ArgumentSyntax arg in f_10336_15835_15850_I(f_10336_15835_15850(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 15804, 16002);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 15908, 15975);

                                    f_10336_15908_15974(this, f_10336_15943_15957(arg), deconstruction);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 15804, 16002);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 199);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 199);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10336, 16028, 16034);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 15564, 16616);

                    case SyntaxKind.DeclarationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 15564, 16616);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 16162, 16244);

                            var
                            declarationExpression = (DeclarationExpressionSyntax)possibleTupleDeclaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 16270, 16384);

                            f_10336_16270_16383(this, f_10336_16305_16338(declarationExpression), f_10336_16340_16366(declarationExpression), deconstruction);
                            DynAbs.Tracing.TraceSender.TraceBreak(10336, 16410, 16416);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 15564, 16616);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 15564, 16616);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 16514, 16546);

                            f_10336_16514_16545(this, possibleTupleDeclaration);
                            DynAbs.Tracing.TraceSender.TraceBreak(10336, 16572, 16578);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 15564, 16616);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 15379, 16627);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_15572_15603(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 15572, 15603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10336_15835_15850(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 15835, 15850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10336_15943_15957(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 15943, 15957);
                    return return_v;
                }


                int
                f_10336_15908_15974(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                possibleTupleDeclaration, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    this_param.CollectVariablesFromDeconstruction(possibleTupleDeclaration, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 15908, 15974);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10336_15835_15850_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 15835, 15850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10336_16305_16338(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 16305, 16338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10336_16340_16366(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 16340, 16366);
                    return return_v;
                }


                int
                f_10336_16270_16383(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    this_param.CollectVariablesFromDeconstruction(designation, closestTypeSyntax, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 16270, 16383);
                    return 0;
                }


                int
                f_10336_16514_16545(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    this_param.Visit((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 16514, 16545);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 15379, 16627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 15379, 16627);
            }
        }

        private void CollectVariablesFromDeconstruction(
                    VariableDesignationSyntax designation,
                    TypeSyntax closestTypeSyntax,
                    AssignmentExpressionSyntax deconstruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 16639, 18115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 16863, 18104);

                switch (f_10336_16871_16889(designation))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 16863, 18104);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17014, 17072);

                            var
                            single = (SingleVariableDesignationSyntax)designation
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17098, 17199);

                            TFieldOrLocalSymbol
                            variable = f_10336_17129_17198(this, closestTypeSyntax, single, deconstruction)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17225, 17370) || true) && ((object)variable != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 17225, 17370);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17311, 17343);

                                f_10336_17311_17342(_variablesBuilder, variable);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 17225, 17370);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10336, 17396, 17402);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 16863, 18104);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 16863, 18104);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17541, 17605);

                            var
                            tuple = (ParenthesizedVariableDesignationSyntax)designation
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17631, 17844);
                                foreach (VariableDesignationSyntax d in f_10336_17671_17686_I(f_10336_17671_17686(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 17631, 17844);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 17744, 17817);

                                    f_10336_17744_17816(this, d, closestTypeSyntax, deconstruction);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 17631, 17844);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10336, 1, 214);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10336, 1, 214);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10336, 17870, 17876);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 16863, 18104);

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 16863, 18104);
                        DynAbs.Tracing.TraceSender.TraceBreak(10336, 17974, 17980);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 16863, 18104);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 16863, 18104);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 18028, 18089);

                        throw f_10336_18034_18088(f_10336_18069_18087(designation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 16863, 18104);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 16639, 18115);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_16871_16889(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 16871, 16889);
                    return return_v;
                }


                TFieldOrLocalSymbol
                f_10336_17129_17198(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    var return_v = this_param.MakeDeconstructionVariable(closestTypeSyntax, designation, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 17129, 17198);
                    return return_v;
                }


                int
                f_10336_17311_17342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TFieldOrLocalSymbol>
                this_param, TFieldOrLocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 17311, 17342);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_17671_17686(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 17671, 17686);
                    return return_v;
                }


                int
                f_10336_17744_17816(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder<TFieldOrLocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    this_param.CollectVariablesFromDeconstruction(designation, closestTypeSyntax, deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 17744, 17816);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10336_17671_17686_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 17671, 17686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_18069_18087(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 18069, 18087);
                    return return_v;
                }


                System.Exception
                f_10336_18034_18088(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 18034, 18088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 16639, 18115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 16639, 18115);
            }
        }

        protected abstract TFieldOrLocalSymbol MakeDeclarationExpressionVariable(DeclarationExpressionSyntax node, SingleVariableDesignationSyntax designation, BaseArgumentListSyntax argumentListSyntax, SyntaxNode nodeToBind);

        protected abstract TFieldOrLocalSymbol MakeDeconstructionVariable(
                                                            TypeSyntax closestTypeSyntax,
                                                            SingleVariableDesignationSyntax designation,
                                                            AssignmentExpressionSyntax deconstruction);

        public ExpressionVariableFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10336, 554, 19246);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 738, 755);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 785, 796);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10336, 554, 19246);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 554, 19246);
        }


        static ExpressionVariableFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10336, 554, 19246);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10336, 554, 19246);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 554, 19246);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10336, 554, 19246);
    }
    internal class ExpressionVariableFinder : ExpressionVariableFinder<LocalSymbol>
    {
        private Binder _scopeBinder;

        private Binder _enclosingBinder;

        internal static void FindExpressionVariables(
                    Binder scopeBinder,
                    ArrayBuilder<LocalSymbol> builder,
                    CSharpSyntaxNode node,
                    Binder enclosingBinderOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10336, 19434, 20141);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19668, 19740) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 19668, 19740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19718, 19725);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 19668, 19740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19756, 19816);

                ExpressionVariableFinder
                finder = f_10336_19790_19815(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19830, 19864);

                finder._scopeBinder = scopeBinder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19878, 19938);

                finder._enclosingBinder = enclosingBinderOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Binder?>(10336, 19904, 19937) ?? scopeBinder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19954, 20000);

                f_10336_19954_19999(
                            finder, builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20016, 20043);

                finder._scopeBinder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20057, 20088);

                finder._enclosingBinder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20102, 20130);

                f_10336_20102_20129(s_poolInstance, finder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10336, 19434, 20141);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                f_10336_19790_19815(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 19790, 19815);
                    return return_v;
                }


                int
                f_10336_19954_19999(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.FindExpressionVariables(builder, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 19954, 19999);
                    return 0;
                }


                int
                f_10336_20102_20129(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
                this_param, Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 20102, 20129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 19434, 20141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 19434, 20141);
            }
        }

        internal static void FindExpressionVariables(
                    Binder binder,
                    ArrayBuilder<LocalSymbol> builder,
                    SeparatedSyntaxList<ExpressionSyntax> nodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10336, 20153, 20803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20357, 20433) || true) && (nodes.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 20357, 20433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20411, 20418);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 20357, 20433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20449, 20509);

                ExpressionVariableFinder
                finder = f_10336_20483_20508(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20523, 20552);

                finder._scopeBinder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20566, 20599);

                finder._enclosingBinder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20615, 20662);

                f_10336_20615_20661(
                            finder, builder, nodes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20678, 20705);

                finder._scopeBinder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20719, 20750);

                finder._enclosingBinder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20764, 20792);

                f_10336_20764_20791(s_poolInstance, finder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10336, 20153, 20803);

                Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                f_10336_20483_20508(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 20483, 20508);
                    return return_v;
                }


                int
                f_10336_20615_20661(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                builder, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                nodes)
                {
                    this_param.FindExpressionVariables(builder, nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 20615, 20661);
                    return 0;
                }


                int
                f_10336_20764_20791(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
                this_param, Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 20764, 20791);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 20153, 20803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 20153, 20803);
            }
        }

        protected override LocalSymbol MakePatternVariable(TypeSyntax type, SingleVariableDesignationSyntax designation, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 20815, 21044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 20975, 21033);

                return f_10336_20982_21032(this, type, designation, nodeToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 20815, 21044);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10336_20982_21032(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignation, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(type, (Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax)variableDesignation, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 20982, 21032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 20815, 21044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 20815, 21044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalSymbol MakePatternVariable(RecursivePatternSyntax node, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 21056, 21262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21183, 21251);

                return f_10336_21190_21250(this, f_10336_21210_21219(node), f_10336_21221_21237(node), nodeToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 21056, 21262);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10336_21210_21219(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 21210, 21219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10336_21221_21237(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 21221, 21237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10336_21190_21250(Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                type, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                variableDesignation, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(type, variableDesignation, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 21190, 21250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 21056, 21262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 21056, 21262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalSymbol MakePatternVariable(TypeSyntax type, VariableDesignationSyntax variableDesignation, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 21274, 22617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21425, 21498);

                var
                designation = variableDesignation as SingleVariableDesignationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21512, 21719) || true) && (designation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 21512, 21719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21569, 21674);

                    f_10336_21569_21673(variableDesignation == null || (DynAbs.Tracing.TraceSender.Expression_False(10336, 21582, 21672) || f_10336_21613_21639(variableDesignation) == SyntaxKind.DiscardDesignation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21692, 21704);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 21512, 21719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21735, 21791);

                NamedTypeSymbol
                container = f_10336_21763_21790(_scopeBinder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 21805, 22052) || true) && ((object)container != null && (DynAbs.Tracing.TraceSender.Expression_True(10336, 21809, 21861) && f_10336_21838_21861(container)) && (DynAbs.Tracing.TraceSender.Expression_True(10336, 21809, 21943) && (object)f_10336_21890_21935(_scopeBinder, designation) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 21805, 22052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 22025, 22037);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 21805, 22052);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 22068, 22606);

                return f_10336_22075_22605(f_10336_22159_22196(_scopeBinder), scopeBinder: _scopeBinder, nodeBinder: _enclosingBinder, typeSyntax: type, identifierToken: f_10336_22406_22428(designation), kind: LocalDeclarationKind.PatternVariable, nodeToBind: nodeToBind, forbiddenZone: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 21274, 22617);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10336_21613_21639(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 21613, 21639);
                    return return_v;
                }


                int
                f_10336_21569_21673(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 21569, 21673);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10336_21763_21790(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 21763, 21790);
                    return return_v;
                }


                bool
                f_10336_21838_21861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 21838, 21861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_21890_21935(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 21890, 21935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10336_22159_22196(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 22159, 22196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10336_22406_22428(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 22406, 22428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10336_22075_22605(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind, Microsoft.CodeAnalysis.SyntaxNode
                forbiddenZone)
                {
                    var return_v = SourceLocalSymbol.MakeLocalSymbolWithEnclosingContext(containingSymbol, scopeBinder: scopeBinder, nodeBinder: nodeBinder, typeSyntax: typeSyntax, identifierToken: identifierToken, kind: kind, nodeToBind: nodeToBind, forbiddenZone: forbiddenZone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 22075, 22605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 21274, 22617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 21274, 22617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalSymbol MakeDeclarationExpressionVariable(DeclarationExpressionSyntax node, SingleVariableDesignationSyntax designation, BaseArgumentListSyntax argumentListSyntaxOpt, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 22629, 23868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 22866, 22922);

                NamedTypeSymbol
                container = f_10336_22894_22921(_scopeBinder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 22938, 23185) || true) && ((object)container != null && (DynAbs.Tracing.TraceSender.Expression_True(10336, 22942, 22994) && f_10336_22971_22994(container)) && (DynAbs.Tracing.TraceSender.Expression_True(10336, 22942, 23076) && (object)f_10336_23023_23068(_scopeBinder, designation) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 22938, 23185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 23158, 23170);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 22938, 23185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 23201, 23857);

                return f_10336_23208_23856(containingSymbol: f_10336_23310_23347(_scopeBinder), scopeBinder: _scopeBinder, nodeBinder: _enclosingBinder, typeSyntax: f_10336_23505_23514(node), identifierToken: f_10336_23562_23584(designation), kind: (DynAbs.Tracing.TraceSender.Conditional_F1(10336, 23621, 23647) || ((f_10336_23621_23647(node) && DynAbs.Tracing.TraceSender.Conditional_F2(10336, 23650, 23682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10336, 23685, 23735))) ? LocalDeclarationKind.OutVariable : LocalDeclarationKind.DeclarationExpressionVariable, nodeToBind: nodeToBind, forbiddenZone: argumentListSyntaxOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 22629, 23868);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10336_22894_22921(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 22894, 22921);
                    return return_v;
                }


                bool
                f_10336_22971_22994(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 22971, 22994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_23023_23068(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 23023, 23068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10336_23310_23347(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 23310, 23347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10336_23505_23514(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 23505, 23514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10336_23562_23584(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 23562, 23584);
                    return return_v;
                }


                bool
                f_10336_23621_23647(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                p)
                {
                    var return_v = p.IsOutVarDeclaration();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 23621, 23647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10336_23208_23856(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind, Microsoft.CodeAnalysis.CSharp.Syntax.BaseArgumentListSyntax
                forbiddenZone)
                {
                    var return_v = SourceLocalSymbol.MakeLocalSymbolWithEnclosingContext(containingSymbol: containingSymbol, scopeBinder: scopeBinder, nodeBinder: nodeBinder, typeSyntax: typeSyntax, identifierToken: identifierToken, kind: kind, nodeToBind: nodeToBind, forbiddenZone: (Microsoft.CodeAnalysis.SyntaxNode)forbiddenZone);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 23208, 23856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 22629, 23868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 22629, 23868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LocalSymbol MakeDeconstructionVariable(
                                                    TypeSyntax closestTypeSyntax,
                                                    SingleVariableDesignationSyntax designation,
                                                    AssignmentExpressionSyntax deconstruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 23880, 25161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 24216, 24272);

                NamedTypeSymbol
                container = f_10336_24244_24271(_scopeBinder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 24288, 24535) || true) && ((object)container != null && (DynAbs.Tracing.TraceSender.Expression_True(10336, 24292, 24344) && f_10336_24321_24344(container)) && (DynAbs.Tracing.TraceSender.Expression_True(10336, 24292, 24426) && (object)f_10336_24373_24418(_scopeBinder, designation) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 24288, 24535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 24508, 24520);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 24288, 24535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 24551, 25150);

                return f_10336_24558_25149(containingSymbol: f_10336_24658_24695(_scopeBinder), scopeBinder: _scopeBinder, nodeBinder: _enclosingBinder, closestTypeSyntax: closestTypeSyntax, identifierToken: f_10336_24965_24987(designation), kind: LocalDeclarationKind.DeconstructionVariable, deconstruction: deconstruction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 23880, 25161);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10336_24244_24271(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 24244, 24271);
                    return return_v;
                }


                bool
                f_10336_24321_24344(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 24321, 24344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_24373_24418(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 24373, 24418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10336_24658_24695(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 24658, 24695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10336_24965_24987(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 24965, 24987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10336_24558_25149(Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                scopeBinder, Microsoft.CodeAnalysis.CSharp.Binder
                nodeBinder, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                closestTypeSyntax, Microsoft.CodeAnalysis.SyntaxToken
                identifierToken, Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction)
                {
                    var return_v = SourceLocalSymbol.MakeDeconstructionLocal(containingSymbol: containingSymbol, scopeBinder: scopeBinder, nodeBinder: nodeBinder, closestTypeSyntax: closestTypeSyntax, identifierToken: identifierToken, kind: kind, deconstruction: (Microsoft.CodeAnalysis.SyntaxNode)deconstruction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 24558, 25149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 23880, 25161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 23880, 25161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<ExpressionVariableFinder> s_poolInstance;

        public static ObjectPool<ExpressionVariableFinder> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10336, 25298, 25487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 25386, 25476);

                return f_10336_25393_25475(() => new ExpressionVariableFinder(), 10);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10336, 25298, 25487);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
                f_10336_25393_25475(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 25393, 25475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 25298, 25487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 25298, 25487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ExpressionVariableFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10336, 19254, 25514);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19365, 19377);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 19403, 19419);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10336, 19254, 25514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 19254, 25514);
        }


        static ExpressionVariableFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10336, 19254, 25514);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 25256, 25285);
            s_poolInstance = f_10336_25273_25285(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10336, 19254, 25514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 19254, 25514);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10336, 19254, 25514);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionVariableFinder>
        f_10336_25273_25285()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 25273, 25285);
            return return_v;
        }

    }
    internal class ExpressionFieldFinder : ExpressionVariableFinder<Symbol>
    {
        private SourceMemberContainerTypeSymbol _containingType;

        private DeclarationModifiers _modifiers;

        private FieldSymbol _containingFieldOpt;

        internal static void FindExpressionVariables(
                    ArrayBuilder<Symbol> builder,
                    CSharpSyntaxNode node,
                    SourceMemberContainerTypeSymbol containingType,
                    DeclarationModifiers modifiers,
                    FieldSymbol containingFieldOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10336, 25778, 26652);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26078, 26150) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10336, 26078, 26150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26128, 26135);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10336, 26078, 26150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26166, 26223);

                ExpressionFieldFinder
                finder = f_10336_26197_26222(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26237, 26277);

                finder._containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26291, 26321);

                finder._modifiers = modifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26335, 26383);

                finder._containingFieldOpt = containingFieldOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26399, 26445);

                f_10336_26399_26444(
                            finder, builder, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26461, 26491);

                finder._containingType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26505, 26551);

                finder._modifiers = DeclarationModifiers.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26565, 26599);

                finder._containingFieldOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26613, 26641);

                f_10336_26613_26640(s_poolInstance, finder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10336, 25778, 26652);

                Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder
                f_10336_26197_26222(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 26197, 26222);
                    return return_v;
                }


                int
                f_10336_26399_26444(Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    this_param.FindExpressionVariables(builder, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 26399, 26444);
                    return 0;
                }


                int
                f_10336_26613_26640(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>
                this_param, Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 26613, 26640);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 25778, 26652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 25778, 26652);
            }
        }

        protected override Symbol MakePatternVariable(TypeSyntax type, SingleVariableDesignationSyntax designation, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 26664, 27092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 26819, 27081);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10336, 26826, 26845) || ((designation == null && DynAbs.Tracing.TraceSender.Conditional_F2(10336, 26848, 26852)) || DynAbs.Tracing.TraceSender.Conditional_F3(10336, 26855, 27080))) ? null : f_10336_26855_27080(_containingType, _modifiers, type, designation.Identifier.ValueText, designation, f_10336_27004_27029(designation), _containingFieldOpt, nodeToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 26664, 27092);

                Microsoft.CodeAnalysis.Location
                f_10336_27004_27029(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 27004, 27029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_26855_27080(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, string
                name, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containingFieldOpt, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = GlobalExpressionVariable.Create(containingType, modifiers, typeSyntax, name, (Microsoft.CodeAnalysis.SyntaxNode)syntax, location, containingFieldOpt, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 26855, 27080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 26664, 27092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 26664, 27092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Symbol MakePatternVariable(RecursivePatternSyntax node, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 27104, 27340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 27226, 27329);

                return f_10336_27233_27328(this, f_10336_27253_27262(node), f_10336_27264_27280(node) as SingleVariableDesignationSyntax, nodeToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 27104, 27340);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10336_27253_27262(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 27253, 27262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10336_27264_27280(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 27264, 27280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10336_27233_27328(Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                type, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                designation, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = this_param.MakePatternVariable(type, (Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax?)designation, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 27233, 27328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 27104, 27340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 27104, 27340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Symbol MakeDeclarationExpressionVariable(DeclarationExpressionSyntax node, SingleVariableDesignationSyntax designation, BaseArgumentListSyntax argumentListSyntaxOpt, SyntaxNode nodeToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 27352, 27844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 27584, 27833);

                return f_10336_27591_27832(_containingType, _modifiers, f_10336_27670_27679(node), designation.Identifier.ValueText, designation, designation.Identifier.GetLocation(), _containingFieldOpt, nodeToBind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 27352, 27844);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10336_27670_27679(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 27670, 27679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_27591_27832(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, string
                name, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containingFieldOpt, Microsoft.CodeAnalysis.SyntaxNode
                nodeToBind)
                {
                    var return_v = GlobalExpressionVariable.Create(containingType, modifiers, typeSyntax, name, (Microsoft.CodeAnalysis.SyntaxNode)syntax, location, containingFieldOpt, nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 27591, 27832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 27352, 27844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 27352, 27844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Symbol MakeDeconstructionVariable(
                                                TypeSyntax closestTypeSyntax,
                                                SingleVariableDesignationSyntax designation,
                                                AssignmentExpressionSyntax deconstruction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10336, 27856, 28662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 28175, 28651);

                return f_10336_28182_28650(containingType: _containingType, modifiers: DeclarationModifiers.Private, typeSyntax: closestTypeSyntax, name: designation.Identifier.ValueText, syntax: designation, location: f_10336_28529_28549(designation), containingFieldOpt: null, nodeToBind: deconstruction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10336, 27856, 28662);

                Microsoft.CodeAnalysis.Location
                f_10336_28529_28549(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10336, 28529, 28549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10336_28182_28650(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
                modifiers, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, string
                name, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containingFieldOpt, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                nodeToBind)
                {
                    var return_v = GlobalExpressionVariable.Create(containingType: containingType, modifiers: modifiers, typeSyntax: typeSyntax, name: name, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, location: location, containingFieldOpt: containingFieldOpt, nodeToBind: (Microsoft.CodeAnalysis.SyntaxNode)nodeToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 28182, 28650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 27856, 28662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 27856, 28662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ObjectPool<ExpressionFieldFinder> s_poolInstance;

        public static ObjectPool<ExpressionFieldFinder> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10336, 28796, 28976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 28881, 28965);

                return f_10336_28888_28964(() => new ExpressionFieldFinder(), 10);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10336, 28796, 28976);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>
                f_10336_28888_28964(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 28888, 28964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10336, 28796, 28976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 28796, 28976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ExpressionFieldFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10336, 25522, 29003);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 25650, 25665);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 25705, 25715);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 25746, 25765);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10336, 25522, 29003);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 25522, 29003);
        }


        static ExpressionFieldFinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10336, 25522, 29003);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10336, 28754, 28783);
            s_poolInstance = f_10336_28771_28783(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10336, 25522, 29003);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10336, 25522, 29003);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10336, 25522, 29003);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.ExpressionFieldFinder>
        f_10336_28771_28783()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10336, 28771, 28783);
            return return_v;
        }

    }
}
