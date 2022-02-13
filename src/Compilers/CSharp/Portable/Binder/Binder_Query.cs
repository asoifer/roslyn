// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private const string
        transparentIdentifierPrefix = "<>h__TransparentIdentifier"
        ;

        internal BoundExpression BindQuery(QueryExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 843, 4267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 957, 990);

                var
                fromClause = f_10316_974_989(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1004, 1108);

                var
                boundFromExpression = f_10316_1030_1107(this, f_10316_1072_1093(fromClause), diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1384, 1790) || true) && (f_10316_1388_1424(boundFromExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 1384, 1790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1458, 1537);

                    f_10316_1458_1536(diagnostics, ErrorCode.ERR_BadDynamicQuery, f_10316_1505_1535(f_10316_1505_1526(fromClause)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1555, 1635);

                    boundFromExpression = f_10316_1577_1634(this, f_10316_1591_1612(fromClause), boundFromExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 1384, 1790);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 1384, 1790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1701, 1775);

                    boundFromExpression = f_10316_1723_1774(this, boundFromExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 1384, 1790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1806, 1864);

                QueryTranslationState
                state = f_10316_1836_1863()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1878, 1957);

                state.fromExpression = f_10316_1901_1956(this, boundFromExpression, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 1973, 2068);

                var
                x = state.rangeVariable = f_10316_2003_2067(state, this, f_10316_2032_2053(fromClause), diagnostics)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2091, 2122);
                    for (int
        i = f_10316_2095_2104(node).Clauses.Count - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2082, 2225) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2132, 2135)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 2082, 2225))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 2082, 2225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2169, 2210);

                        f_10316_2169_2209(state.clauses, f_10316_2188_2205(f_10316_2188_2197(node))[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2241, 2287);

                state.selectOrGroup = f_10316_2263_2286(f_10316_2263_2272(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2503, 2532);

                BoundExpression?
                cast = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2546, 2871) || true) && (f_10316_2550_2565(fromClause) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 2546, 2871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2607, 2676);

                    var
                    typeRestriction = f_10316_2629_2675(this, f_10316_2646_2661(fromClause), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2694, 2810);

                    cast = f_10316_2701_2809(this, fromClause, state.fromExpression, "Cast", f_10316_2763_2778(fromClause), typeRestriction, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2828, 2856);

                    state.fromExpression = cast;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 2546, 2871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2887, 2985);

                state.fromExpression = f_10316_2910_2984(this, fromClause, state.fromExpression, x, castInvocation: cast);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 2999, 3063);

                BoundExpression
                result = f_10316_3024_3062(this, state, diagnostics)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3107, 3144);
                    for (QueryContinuationSyntax?
        continuation = f_10316_3122_3144(f_10316_3122_3131(node))
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3077, 4176) || true) && (continuation != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3168, 3213)
        , continuation = f_10316_3183_3213(f_10316_3183_3200(continuation)), DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 3077, 4176))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 3077, 4176);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3440, 3454);

                        f_10316_3440_3453(                // A query expression with a continuation
                                                          //     from ... into x ...
                                                          // is translated into
                                                          //     from x in ( from ... ) ...
                                        state);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3472, 3502);

                        state.fromExpression = result;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3520, 3613);

                        x = state.rangeVariable = f_10316_3546_3612(state, this, f_10316_3575_3598(continuation), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3631, 3669);

                        f_10316_3631_3668(f_10316_3644_3667(state.clauses));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3687, 3727);

                        var
                        clauses = f_10316_3701_3726(f_10316_3701_3718(continuation))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3754, 3775);
                            for (int
            i = clauses.Count - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3745, 3880) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3785, 3788)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 3745, 3880))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 3745, 3880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3830, 3861);

                                f_10316_3830_3860(state.clauses, clauses[i]);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 1, 136);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 1, 136);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3900, 3954);

                        state.selectOrGroup = f_10316_3922_3953(f_10316_3922_3939(continuation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 3972, 4020);

                        result = f_10316_3981_4019(this, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4038, 4093);

                        result = f_10316_4047_4092(this, f_10316_4063_4080(continuation), result, x);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4111, 4161);

                        result = f_10316_4120_4160(this, continuation, result, x);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 1, 1100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 1, 1100);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4192, 4205);

                f_10316_4192_4204(
                            state);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4219, 4256);

                return f_10316_4226_4255(this, node, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 843, 4267);

                Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                f_10316_974_989(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.FromClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 974, 989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_1072_1093(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 1072, 1093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_1030_1107(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindLeftOfPotentialColorColorMemberAccess(left, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1030, 1107);
                    return return_v;
                }


                bool
                f_10316_1388_1424(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1388, 1424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_1505_1526(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 1505, 1526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_1505_1535(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 1505, 1535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_1458_1536(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1458, 1536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_1591_1612(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 1591, 1612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_1577_1634(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.BadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1577, 1634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_1723_1774(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1723, 1774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                f_10316_1836_1863()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1836, 1863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_1901_1956(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeMemberAccessValue(expr, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 1901, 1956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_2032_2053(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2032, 2053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_2003_2067(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 2003, 2067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_2095_2104(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2095, 2104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_2188_2197(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2188, 2197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10316_2188_2205(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2188, 2205);
                    return return_v;
                }


                int
                f_10316_2169_2209(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 2169, 2209);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_2263_2272(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2263, 2272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                f_10316_2263_2286(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.SelectOrGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2263, 2286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10316_2550_2565(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2550, 2565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_2646_2661(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2646, 2661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10316_2629_2675(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgument, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeArgument(typeArgument, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 2629, 2675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_2763_2778(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 2763, 2778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_2701_2809(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, typeArgSyntax, typeArg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 2701, 2809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_2910_2984(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                castInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol, castInvocation: castInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 2910, 2984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_3024_3062(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindQueryInternal1(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3024, 3062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_3122_3131(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3122, 3131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                f_10316_3122_3144(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Continuation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3122, 3144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_3183_3200(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3183, 3200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax?
                f_10316_3183_3213(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Continuation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3183, 3213);
                    return return_v;
                }


                int
                f_10316_3440_3453(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3440, 3453);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_3575_3598(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3575, 3598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_3546_3612(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3546, 3612);
                    return return_v;
                }


                bool
                f_10316_3644_3667(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3644, 3667);
                    return return_v;
                }


                int
                f_10316_3631_3668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3631, 3668);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_3701_3718(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3701, 3718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                f_10316_3701_3726(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3701, 3726);
                    return return_v;
                }


                int
                f_10316_3830_3860(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3830, 3860);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_3922_3939(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3922, 3939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                f_10316_3922_3953(Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                this_param)
                {
                    var return_v = this_param.SelectOrGroup;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 3922, 3953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_3981_4019(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindQueryInternal1(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 3981, 4019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                f_10316_4063_4080(Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 4063, 4080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_4047_4092(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryBodySyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4047, 4092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_4120_4160(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4120, 4160);
                    return return_v;
                }


                int
                f_10316_4192_4204(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4192, 4204);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_4226_4255(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4226, 4255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 843, 4267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 843, 4267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindQueryInternal1(QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 4279, 4834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4711, 4823);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 4718, 4742) || ((f_10316_4718_4742(state) && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 4745, 4781)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 4784, 4822))) ? f_10316_4745_4781(this, state, diagnostics) : f_10316_4784_4822(this, state, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 4279, 4834);

                bool
                f_10316_4718_4742(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state)
                {
                    var return_v = IsDegenerateQuery(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4718, 4742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_4745_4781(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FinalTranslation(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4745, 4781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_4784_4822(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindQueryInternal2(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4784, 4822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 4279, 4834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 4279, 4834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDegenerateQuery(QueryTranslationState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10316, 4846, 5341);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4937, 4980) || true) && (!f_10316_4942_4965(state.clauses))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 4937, 4980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 4967, 4980);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 4937, 4980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5070, 5125);

                var
                select = state.selectOrGroup as SelectClauseSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5139, 5172) || true) && (select == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 5139, 5172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5159, 5172);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 5139, 5172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5186, 5239);

                var
                name = f_10316_5197_5214(select) as IdentifierNameSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5253, 5330);

                return name != null && (DynAbs.Tracing.TraceSender.Expression_True(10316, 5260, 5329) && f_10316_5276_5300(state.rangeVariable) == name.Identifier.ValueText);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10316, 4846, 5341);

                bool
                f_10316_4942_4965(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 4942, 4965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_5197_5214(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 5197, 5214);
                    return return_v;
                }


                string
                f_10316_5276_5300(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 5276, 5300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 4846, 5341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 4846, 5341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindQueryInternal2(QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 5353, 6834);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5549, 6823) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 5549, 6823);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5594, 6756) || true) && (f_10316_5598_5621(state.clauses))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 5594, 6756);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5663, 5819) || true) && (state.selectOrGroup == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 5663, 5819);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5744, 5772);

                                return state.fromExpression;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 5663, 5819);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 5841, 6669) || true) && (f_10316_5845_5869(state))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 5841, 6669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6116, 6150);

                                var
                                result = state.fromExpression
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6248, 6302);

                                DiagnosticBag
                                discarded = f_10316_6274_6301()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6328, 6394);

                                BoundExpression?
                                unoptimized = f_10316_6359_6393(this, state, discarded)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6420, 6437);

                                f_10316_6420_6436(discarded);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6465, 6538) || true) && (f_10316_6469_6493(unoptimized) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 6469, 6517) && f_10316_6497_6517_M(!result.HasAnyErrors)))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 6465, 6538);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6519, 6538);

                                    unoptimized = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 6465, 6538);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6564, 6646);

                                return f_10316_6571_6645(this, state.selectOrGroup, result, unoptimizedForm: unoptimized);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 5841, 6669);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6693, 6737);

                            return f_10316_6700_6736(this, state, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 5594, 6756);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6776, 6808);

                        f_10316_6776_6807(this, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 5549, 6823);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 5549, 6823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 5549, 6823);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 5353, 6834);

                bool
                f_10316_5598_5621(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 5598, 5621);
                    return return_v;
                }


                bool
                f_10316_5845_5869(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state)
                {
                    var return_v = IsDegenerateQuery(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 5845, 5869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10316_6274_6301()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6274, 6301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_6359_6393(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FinalTranslation(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6359, 6393);
                    return return_v;
                }


                int
                f_10316_6420_6436(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6420, 6436);
                    return 0;
                }


                bool
                f_10316_6469_6493(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 6469, 6493);
                    return return_v;
                }


                bool
                f_10316_6497_6517_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 6497, 6517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_6571_6645(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                unoptimizedForm)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, unoptimizedForm: unoptimizedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6571, 6645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_6700_6736(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FinalTranslation(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6700, 6736);
                    return return_v;
                }


                int
                f_10316_6776_6807(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceQuery(state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6776, 6807);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 5353, 6834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 5353, 6834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression FinalTranslation(QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 6846, 10918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 6967, 7005);

                f_10316_6967_7004(f_10316_6980_7003(state.clauses));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7019, 10907);

                switch (f_10316_7027_7053(state.selectOrGroup))
                {

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 7019, 10907);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7382, 7441);

                            var
                            selectClause = (SelectClauseSyntax)state.selectOrGroup
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7467, 7495);

                            var
                            x = state.rangeVariable
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7521, 7550);

                            var
                            e = state.fromExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7576, 7608);

                            var
                            v = f_10316_7584_7607(selectClause)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7634, 7702);

                            var
                            lambda = f_10316_7647_7701(this, f_10316_7670_7694(state), x, v)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7728, 7816);

                            var
                            result = f_10316_7741_7815(this, state.selectOrGroup, e, "Select", lambda, diagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 7842, 7912);

                            return f_10316_7849_7911(this, selectClause, result, queryInvocation: result);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 7019, 10907);

                    case SyntaxKind.GroupClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 7019, 10907);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8402, 8459);

                            var
                            groupClause = (GroupClauseSyntax)state.selectOrGroup
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8485, 8513);

                            var
                            x = state.rangeVariable
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8539, 8568);

                            var
                            e = state.fromExpression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8594, 8630);

                            var
                            v = f_10316_8602_8629(groupClause)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8656, 8689);

                            var
                            k = f_10316_8664_8688(groupClause)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8715, 8751);

                            var
                            vId = v as IdentifierNameSyntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8777, 8794);

                            BoundCall
                            result
                            = default(BoundCall);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 8820, 8892);

                            var
                            lambdaLeft = f_10316_8837_8891(this, f_10316_8860_8884(state), x, k)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9010, 9046);

                            var
                            d = f_10316_9018_9045()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9072, 9157);

                            BoundExpression
                            lambdaRight = f_10316_9102_9156(this, f_10316_9125_9149(state), x, v)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9183, 9298);

                            result = f_10316_9192_9297(this, state.selectOrGroup, e, "GroupBy", f_10316_9247_9293(lambdaLeft, lambdaRight), d);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9426, 9472);

                            result = f_10316_9435_9471(result);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9500, 9540);

                            BoundExpression?
                            unoptimizedForm = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9566, 10193) || true) && (vId != null && (DynAbs.Tracing.TraceSender.Expression_True(10316, 9570, 9619) && vId.Identifier.ValueText == f_10316_9613_9619(x)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 9566, 10193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9773, 9798);

                                unoptimizedForm = result;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9828, 9917);

                                result = f_10316_9837_9916(this, state.selectOrGroup, e, "GroupBy", lambdaLeft, diagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 9947, 10028) || true) && (f_10316_9951_9979(unoptimizedForm) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 9951, 10003) && f_10316_9983_10003_M(!result.HasAnyErrors)))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 9947, 10028);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10005, 10028);

                                    unoptimizedForm = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 9947, 10028);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 9566, 10193);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 9566, 10193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10142, 10166);

                                f_10316_10142_10165(diagnostics, d);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 9566, 10193);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10221, 10230);

                            f_10316_10221_10229(
                                                    d);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10256, 10359);

                            return f_10316_10263_10358(this, groupClause, result, queryInvocation: result, unoptimizedForm: unoptimizedForm);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 7019, 10907);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 7019, 10907);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10539, 10586);

                            f_10316_10539_10585(f_10316_10552_10577(state.fromExpression) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 10612, 10869);

                            return f_10316_10619_10868(state.selectOrGroup, LookupResultKind.OverloadResolutionFailure, ImmutableArray<Symbol?>.Empty, f_10316_10797_10840(state.fromExpression), f_10316_10842_10867(state.fromExpression));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 7019, 10907);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 6846, 10918);

                bool
                f_10316_6980_7003(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6980, 7003);
                    return return_v;
                }


                int
                f_10316_6967_7004(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 6967, 7004);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10316_7027_7053(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 7027, 7053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_7584_7607(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 7584, 7607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_7670_7694(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 7670, 7694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_7647_7701(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 7647, 7701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_7741_7815(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                arg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 7741, 7815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_7849_7911(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, queryInvocation: (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 7849, 7911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_8602_8629(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.GroupExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 8602, 8629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_8664_8688(Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.ByExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 8664, 8688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_8860_8884(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 8860, 8884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_8837_8891(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 8837, 8891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10316_9018_9045()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9018, 9045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_9125_9149(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9125, 9149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_9102_9156(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9102, 9156);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_9247_9293(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create((Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9247, 9293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_9192_9297(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9192, 9297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_9435_9471(Microsoft.CodeAnalysis.CSharp.BoundCall
                result)
                {
                    var return_v = ReverseLastTwoParameterOrder(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9435, 9471);
                    return return_v;
                }


                string
                f_10316_9613_9619(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 9613, 9619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_9837_9916(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                arg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 9837, 9916);
                    return return_v;
                }


                bool
                f_10316_9951_9979(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 9951, 9979);
                    return return_v;
                }


                bool
                f_10316_9983_10003_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 9983, 10003);
                    return return_v;
                }


                int
                f_10316_10142_10165(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10142, 10165);
                    return 0;
                }


                int
                f_10316_10221_10229(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10221, 10229);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_10263_10358(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.GroupClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                unoptimizedForm)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, queryInvocation: (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation, unoptimizedForm: unoptimizedForm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10263, 10358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_10552_10577(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 10552, 10577);
                    return return_v;
                }


                int
                f_10316_10539_10585(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10539, 10585);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_10797_10840(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10797, 10840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_10842_10867(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 10842, 10867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_10619_10868(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 10619, 10868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 6846, 10918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 6846, 10918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundCall ReverseLastTwoParameterOrder(BoundCall result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10316, 10930, 12516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11408, 11440);

                int
                n = result.Arguments.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11454, 11514);

                var
                arguments = f_10316_11470_11513()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11528, 11565);

                f_10316_11528_11564(arguments, f_10316_11547_11563(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11579, 11615);

                var
                lastArgument = f_10316_11598_11614(arguments, n - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11629, 11665);

                arguments[n - 1] = f_10316_11648_11664(arguments, n - 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11679, 11711);

                arguments[n - 2] = lastArgument;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11725, 11776);

                var
                argsToParams = f_10316_11744_11775()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11790, 11836);

                f_10316_11790_11835(argsToParams, f_10316_11812_11834(0, n));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11850, 11878);

                argsToParams[n - 1] = n - 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11892, 11920);

                argsToParams[n - 2] = n - 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 11934, 11989);

                var
                defaultArguments = result.DefaultArguments.Clone()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12003, 12107);

                (defaultArguments[n - 1], defaultArguments[n - 2]) = (defaultArguments[n - 2], defaultArguments[n - 1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12123, 12505);

                return f_10316_12130_12504(result, f_10316_12162_12180(result), f_10316_12182_12195(result), f_10316_12197_12227(arguments), argumentNamesOpt: default, argumentRefKindsOpt: default, f_10316_12303_12324(result), f_10316_12326_12341(result), f_10316_12343_12374(result), f_10316_12393_12426(argsToParams), defaultArguments, f_10316_12446_12463(result), f_10316_12465_12490(result), f_10316_12492_12503(result));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10316, 10930, 12516);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_11470_11513()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 11470, 11513);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_11547_11563(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 11547, 11563);
                    return return_v;
                }


                int
                f_10316_11528_11564(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 11528, 11564);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_11598_11614(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 11598, 11614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_11648_11664(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 11648, 11664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10316_11744_11775()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 11744, 11775);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<int>
                f_10316_11812_11834(int
                start, int
                count)
                {
                    var return_v = Enumerable.Range(start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 11812, 11834);
                    return return_v;
                }


                int
                f_10316_11790_11835(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, System.Collections.Generic.IEnumerable<int>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 11790, 11835);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_12162_12180(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12162, 12180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10316_12182_12195(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12182, 12195);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_12197_12227(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12197, 12227);
                    return return_v;
                }


                bool
                f_10316_12303_12324(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12303, 12324);
                    return return_v;
                }


                bool
                f_10316_12326_12341(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12326, 12341);
                    return return_v;
                }


                bool
                f_10316_12343_12374(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12343, 12374);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10316_12393_12426(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12393, 12426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10316_12446_12463(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12446, 12463);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10316_12465_12490(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.OriginalMethodsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12465, 12490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_12492_12503(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 12492, 12503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_12130_12504(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalMethodsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt: argumentNamesOpt, argumentRefKindsOpt: argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, originalMethodsOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12130, 12504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 10930, 12516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 10930, 12516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReduceQuery(QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 12528, 13640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12633, 12669);

                var
                topClause = f_10316_12649_12668(state.clauses)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12683, 13629);

                switch (f_10316_12691_12707(topClause))
                {

                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12791, 12853);

                        f_10316_12791_12852(this, topClause, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10316, 12875, 12881);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);

                    case SyntaxKind.JoinClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 12948, 13008);

                        f_10316_12948_13007(this, topClause, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10316, 13030, 13036);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);

                    case SyntaxKind.OrderByClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 13106, 13172);

                        f_10316_13106_13171(this, topClause, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10316, 13194, 13200);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 13267, 13327);

                        f_10316_13267_13326(this, topClause, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10316, 13349, 13355);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);

                    case SyntaxKind.LetClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 13421, 13479);

                        f_10316_13421_13478(this, topClause, state, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10316, 13501, 13507);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 12683, 13629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 13555, 13614);

                        throw f_10316_13561_13613(f_10316_13596_13612(topClause));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 12683, 13629);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 12528, 13640);

                Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                f_10316_12649_12668(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12649, 12668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10316_12691_12707(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12691, 12707);
                    return return_v;
                }


                int
                f_10316_12791_12852(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                where, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceWhere((Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax)where, state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12791, 12852);
                    return 0;
                }


                int
                f_10316_12948_13007(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                join, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceJoin((Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax)join, state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 12948, 13007);
                    return 0;
                }


                int
                f_10316_13106_13171(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                orderby, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceOrderBy((Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax)orderby, state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 13106, 13171);
                    return 0;
                }


                int
                f_10316_13267_13326(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                from, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceFrom((Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)from, state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 13267, 13326);
                    return 0;
                }


                int
                f_10316_13421_13478(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                let, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReduceLet((Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax)let, state, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 13421, 13478);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10316_13596_13612(Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 13596, 13612);
                    return return_v;
                }


                System.Exception
                f_10316_13561_13613(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 13561, 13613);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 12528, 13640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 12528, 13640);
            }
        }

        private void ReduceWhere(WhereClauseSyntax where, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 13652, 14333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14011, 14111);

                var
                lambda = f_10316_14024_14110(this, f_10316_14047_14071(state), state.rangeVariable, f_10316_14094_14109(where))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14125, 14221);

                var
                invocation = f_10316_14142_14220(this, where, state.fromExpression, "Where", lambda, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14235, 14322);

                state.fromExpression = f_10316_14258_14321(this, where, invocation, queryInvocation: invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 13652, 14333);

                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_14047_14071(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14047, 14071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_14094_14109(Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 14094, 14109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_14024_14110(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14024, 14110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_14142_14220(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                arg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14142, 14220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_14258_14321(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhereClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, queryInvocation: (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14258, 14321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 13652, 14333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 13652, 14333);
            }
        }

        private void ReduceJoin(JoinClauseSyntax join, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 14345, 21720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14472, 14551);

                var
                inExpression = f_10316_14491_14550(this, f_10316_14519_14536(join), diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14827, 15064) || true) && (f_10316_14831_14860(inExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 14827, 15064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14894, 14969);

                    f_10316_14894_14968(diagnostics, ErrorCode.ERR_BadDynamicQuery, f_10316_14941_14967(f_10316_14941_14958(join)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 14987, 15049);

                    inExpression = f_10316_15002_15048(this, f_10316_15016_15033(join), inExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 14827, 15064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15080, 15119);

                BoundExpression?
                castInvocation = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15133, 15672) || true) && (f_10316_15137_15146(join) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 15133, 15672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15436, 15492);

                    var
                    castType = f_10316_15451_15491(this, f_10316_15468_15477(join), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15510, 15609);

                    castInvocation = f_10316_15527_15608(this, join, inExpression, "Cast", f_10316_15575_15584(join), castType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15627, 15657);

                    inExpression = castInvocation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 15133, 15672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15688, 15808);

                var
                outerKeySelectorLambda = f_10316_15717_15807(this, f_10316_15740_15764(state), state.rangeVariable, f_10316_15787_15806(join))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15824, 15853);

                var
                x1 = state.rangeVariable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15867, 15935);

                var
                x2 = f_10316_15876_15934(state, this, f_10316_15905_15920(join), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 15949, 16071);

                var
                innerKeySelectorLambda = f_10316_15978_16070(this, f_10316_16001_16043(x2), x2, f_10316_16049_16069(join))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16087, 21709) || true) && (f_10316_16091_16114(state.clauses) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 16091, 16171) && f_10316_16118_16144(state.selectOrGroup) == SyntaxKind.SelectClause))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 16087, 21709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16205, 16258);

                    var
                    select = (SelectClauseSyntax)state.selectOrGroup
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16276, 16297);

                    BoundCall
                    invocation
                    = default(BoundCall);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16315, 18754) || true) && (f_10316_16319_16328(join) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 16315, 18754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16753, 16879);

                        var
                        resultSelectorLambda = f_10316_16780_16878(this, f_10316_16803_16827(state), f_10316_16829_16858(x1, x2), f_10316_16860_16877(select))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 16903, 17218);

                        invocation = f_10316_16916_17217(this, join, state.fromExpression, "Join", f_10316_17073_17178(inExpression, outerKeySelectorLambda, innerKeySelectorLambda, resultSelectorLambda), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 16315, 18754);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 16315, 18754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 17683, 17718);

                        f_10316_17683_17717(f_10316_17683_17710(state.allRangeVariables, x2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 17740, 17775);

                        f_10316_17740_17774(state.allRangeVariables, x2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 17797, 17869);

                        var
                        g = f_10316_17805_17868(state, this, f_10316_17834_17854(f_10316_17834_17843(join)), diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 17893, 18018);

                        var
                        resultSelectorLambda = f_10316_17920_18017(this, f_10316_17943_17967(state), f_10316_17969_17997(x1, g), f_10316_17999_18016(select))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18042, 18362);

                        invocation = f_10316_18055_18361(this, join, state.fromExpression, "GroupJoin", f_10316_18217_18322(inExpression, outerKeySelectorLambda, innerKeySelectorLambda, resultSelectorLambda), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18451, 18488);

                        var
                        arguments = f_10316_18467_18487(invocation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18510, 18626);

                        arguments = arguments.SetItem(arguments.Length - 1, f_10316_18562_18624(this, f_10316_18578_18587(join), arguments[arguments.Length - 1], g));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18650, 18735);

                        invocation = f_10316_18663_18734(invocation, f_10316_18681_18703(invocation), f_10316_18705_18722(invocation), arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 16315, 18754);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18774, 18788);

                    f_10316_18774_18787(
                                    state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18840, 18929);

                    state.fromExpression = f_10316_18863_18928(this, join, invocation, x2, invocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 18947, 19016);

                    state.fromExpression = f_10316_18970_19015(this, select, state.fromExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 16087, 21709);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 16087, 21709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 19082, 19103);

                    BoundCall
                    invocation
                    = default(BoundCall);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 19121, 21585) || true) && (f_10316_19125_19134(join) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 19121, 21585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 19665, 19728);

                        var
                        resultSelectorLambda = f_10316_19692_19727(this, join, state, x1, x2)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 19752, 20067);

                        invocation = f_10316_19765_20066(this, join, state.fromExpression, "Join", f_10316_19922_20027(inExpression, outerKeySelectorLambda, innerKeySelectorLambda, resultSelectorLambda), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 19121, 21585);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 19121, 21585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 20642, 20677);

                        f_10316_20642_20676(f_10316_20642_20669(state.allRangeVariables, x2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 20699, 20734);

                        f_10316_20699_20733(state.allRangeVariables, x2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 20758, 20830);

                        var
                        g = f_10316_20766_20829(state, this, f_10316_20795_20815(f_10316_20795_20804(join)), diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 20852, 20914);

                        var
                        resultSelectorLambda = f_10316_20879_20913(this, join, state, x1, g)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 20938, 21258);

                        invocation = f_10316_20951_21257(this, join, state.fromExpression, "GroupJoin", f_10316_21113_21218(inExpression, outerKeySelectorLambda, innerKeySelectorLambda, resultSelectorLambda), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 21282, 21319);

                        var
                        arguments = f_10316_21298_21318(invocation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 21341, 21457);

                        arguments = arguments.SetItem(arguments.Length - 1, f_10316_21393_21455(this, f_10316_21409_21418(join), arguments[arguments.Length - 1], g));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 21481, 21566);

                        invocation = f_10316_21494_21565(invocation, f_10316_21512_21534(invocation), f_10316_21536_21553(invocation), arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 19121, 21585);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 21605, 21694);

                    state.fromExpression = f_10316_21628_21693(this, join, invocation, x2, invocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 16087, 21709);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 14345, 21720);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_14519_14536(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.InExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 14519, 14536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_14491_14550(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14491, 14550);
                    return return_v;
                }


                bool
                f_10316_14831_14860(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14831, 14860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_14941_14958(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.InExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 14941, 14958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_14941_14967(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 14941, 14967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_14894_14968(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 14894, 14968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_15016_15033(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.InExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15016, 15033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_15002_15048(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.BadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15002, 15048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10316_15137_15146(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15137, 15146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_15468_15477(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15468, 15477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10316_15451_15491(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgument, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeArgument(typeArgument, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15451, 15491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_15575_15584(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15575, 15584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_15527_15608(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, typeArgSyntax, typeArg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15527, 15608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_15740_15764(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15740, 15764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_15787_15806(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15787, 15806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_15717_15807(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15717, 15807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_15905_15920(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 15905, 15920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_15876_15934(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15876, 15934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_16001_16043(params Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol[]
                parameters)
                {
                    var return_v = QueryTranslationState.RangeVariableMap(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16001, 16043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_16049_16069(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 16049, 16069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_15978_16070(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 15978, 16070);
                    return return_v;
                }


                bool
                f_10316_16091_16114(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16091, 16114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10316_16118_16144(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16118, 16144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax?
                f_10316_16319_16328(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 16319, 16328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_16803_16827(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16803, 16827);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_16829_16858(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16829, 16858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_16860_16877(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 16860, 16877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_16780_16878(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16780, 16878);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_17073_17178(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item3, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item3, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17073, 17178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_16916_17217(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 16916, 17217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10316_17683_17710(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 17683, 17710);
                    return return_v;
                }


                int
                f_10316_17683_17717(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17683, 17717);
                    return 0;
                }


                bool
                f_10316_17740_17774(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17740, 17774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                f_10316_17834_17843(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 17834, 17843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_17834_17854(Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 17834, 17854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_17805_17868(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17805, 17868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_17943_17967(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17943, 17967);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_17969_17997(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17969, 17997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_17999_18016(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 17999, 18016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_17920_18017(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 17920, 18017);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_18217_18322(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item3, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item3, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18217, 18322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_18055_18361(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18055, 18361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_18467_18487(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 18467, 18487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                f_10316_18578_18587(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 18578, 18587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_18562_18624(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18562, 18624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_18681_18703(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 18681, 18703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10316_18705_18722(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 18705, 18722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_18663_18734(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18663, 18734);
                    return return_v;
                }


                int
                f_10316_18774_18787(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18774, 18787);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_18863_18928(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                castInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, definedSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18863, 18928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_18970_19015(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 18970, 19015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax?
                f_10316_19125_19134(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 19125, 19134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_19692_19727(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x2)
                {
                    var return_v = this_param.MakePairLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, state, x1, x2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 19692, 19727);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_19922_20027(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item3, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item3, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 19922, 20027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_19765_20066(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 19765, 20066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10316_20642_20669(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 20642, 20669);
                    return return_v;
                }


                int
                f_10316_20642_20676(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 20642, 20676);
                    return 0;
                }


                bool
                f_10316_20699_20733(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 20699, 20733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                f_10316_20795_20804(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 20795, 20804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_20795_20815(Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 20795, 20815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_20766_20829(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 20766, 20829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_20879_20913(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x2)
                {
                    var return_v = this_param.MakePairLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, state, x1, x2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 20879, 20913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_21113_21218(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item3, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item4)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item3, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 21113, 21218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_20951_21257(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 20951, 21257);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_21298_21318(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 21298, 21318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                f_10316_21409_21418(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.Into;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 21409, 21418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_21393_21455(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 21393, 21455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_21512_21534(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 21512, 21534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10316_21536_21553(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 21536, 21553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_21494_21565(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 21494, 21565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_21628_21693(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                castInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, definedSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 21628, 21693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 14345, 21720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 14345, 21720);
            }
        }

        private void ReduceOrderBy(OrderByClauseSyntax orderby, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 21732, 23174);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22450, 22468);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22482, 23077);
                    foreach (var ordering in f_10316_22507_22524_I(f_10316_22507_22524(orderby)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 22482, 23077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22558, 22680);

                        string
                        methodName = ((DynAbs.Tracing.TraceSender.Conditional_F1(10316, 22579, 22584) || ((first && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 22587, 22596)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 22599, 22607))) ? "OrderBy" : "ThenBy") + ((DynAbs.Tracing.TraceSender.Conditional_F1(10316, 22612, 22658) || ((f_10316_22612_22658(ordering, SyntaxKind.DescendingOrdering) && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 22661, 22673)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 22676, 22678))) ? "Descending" : "")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22698, 22802);

                        var
                        lambda = f_10316_22711_22801(this, f_10316_22734_22758(state), state.rangeVariable, f_10316_22781_22800(ordering))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22820, 22922);

                        var
                        invocation = f_10316_22837_22921(this, ordering, state.fromExpression, methodName, lambda, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 22940, 23030);

                        state.fromExpression = f_10316_22963_23029(this, ordering, invocation, queryInvocation: invocation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23048, 23062);

                        first = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 22482, 23077);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 1, 596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 1, 596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23093, 23163);

                state.fromExpression = f_10316_23116_23162(this, orderby, state.fromExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 21732, 23174);

                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax>
                f_10316_22507_22524(Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax
                this_param)
                {
                    var return_v = this_param.Orderings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 22507, 22524);
                    return return_v;
                }


                bool
                f_10316_22612_22658(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22612, 22658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_22734_22758(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22734, 22758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_22781_22800(Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 22781, 22800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_22711_22801(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22711, 22801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_22837_22921(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                arg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22837, 22921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_22963_23029(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, queryInvocation: (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22963, 23029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax>
                f_10316_22507_22524_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 22507, 22524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_23116_23162(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderByClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23116, 23162);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 21732, 23174);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 21732, 23174);
            }
        }

        private void ReduceFrom(FromClauseSyntax from, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 23186, 27325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23313, 23342);

                var
                x1 = state.rangeVariable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23358, 23399);

                BoundExpression
                collectionSelectorLambda
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23413, 23804) || true) && (f_10316_23417_23426(from) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 23413, 23804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23468, 23565);

                    collectionSelectorLambda = f_10316_23495_23564(this, f_10316_23518_23542(state), x1, f_10316_23548_23563(from));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 23413, 23804);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 23413, 23804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23631, 23789);

                    collectionSelectorLambda = f_10316_23658_23788(this, f_10316_23689_23713(state), x1, f_10316_23719_23734(from), f_10316_23736_23745(from), f_10316_23747_23787(this, f_10316_23764_23773(from), diagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 23413, 23804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23820, 23888);

                var
                x2 = f_10316_23829_23887(state, this, f_10316_23858_23873(from), diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 23904, 27314) || true) && (f_10316_23908_23931(state.clauses) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 23908, 23986) && f_10316_23935_23986(state.selectOrGroup, SyntaxKind.SelectClause)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 23904, 27314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 24020, 24073);

                    var
                    select = (SelectClauseSyntax)state.selectOrGroup
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 24409, 24535);

                    var
                    resultSelectorLambda = f_10316_24436_24534(this, f_10316_24459_24483(state), f_10316_24485_24514(x1, x2), f_10316_24516_24533(select))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 24555, 24824);

                    var
                    invocation = f_10316_24572_24823(this, from, state.fromExpression, "SelectMany", f_10316_24719_24788(collectionSelectorLambda, resultSelectorLambda), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 24983, 25080);

                    BoundExpression?
                    castInvocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 25017, 25036) || (((f_10316_25018_25027(from) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 25039, 25072)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 25075, 25079))) ? f_10316_25039_25072(invocation) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 25100, 25137);

                    var
                    arguments = f_10316_25116_25136(invocation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 25155, 25422);

                    invocation = f_10316_25168_25421(invocation, f_10316_25208_25230(invocation), f_10316_25253_25270(invocation), arguments.SetItem(arguments.Length - 2, f_10316_25333_25419(this, from, arguments[arguments.Length - 2], x2, invocation, castInvocation)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 25442, 25456);

                    f_10316_25442_25455(
                                    state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 25474, 25579);

                    state.fromExpression = f_10316_25497_25578(this, from, invocation, definedSymbol: x2, queryInvocation: invocation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 25597, 25666);

                    state.fromExpression = f_10316_25620_25665(this, select, state.fromExpression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 23904, 27314);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 23904, 27314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 26723, 26786);

                    var
                    resultSelectorLambda = f_10316_26750_26785(this, from, state, x1, x2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 26806, 27075);

                    var
                    invocation = f_10316_26823_27074(this, from, state.fromExpression, "SelectMany", f_10316_26970_27039(collectionSelectorLambda, resultSelectorLambda), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27095, 27192);

                    BoundExpression?
                    castInvocation = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 27129, 27148) || (((f_10316_27130_27139(from) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 27151, 27184)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 27187, 27191))) ? f_10316_27151_27184(invocation) : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27210, 27299);

                    state.fromExpression = f_10316_27233_27298(this, from, invocation, x2, invocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 23904, 27314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 23186, 27325);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10316_23417_23426(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23417, 23426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_23518_23542(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23518, 23542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_23548_23563(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23548, 23563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_23495_23564(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23495, 23564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_23689_23713(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23689, 23713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_23719_23734(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23719, 23734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_23736_23745(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23736, 23745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10316_23764_23773(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23764, 23773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10316_23747_23787(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeArgument, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeArgument(typeArgument, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23747, 23787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_23658_23788(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                castTypeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                castType)
                {
                    var return_v = this_param.MakeQueryUnboundLambdaWithCast(qvm, parameter, expression, castTypeSyntax, castType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23658, 23788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_23858_23873(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 23858, 23873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_23829_23887(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23829, 23887);
                    return return_v;
                }


                bool
                f_10316_23908_23931(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>
                source)
                {
                    var return_v = source.IsEmpty<Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23908, 23931);
                    return return_v;
                }


                bool
                f_10316_23935_23986(Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 23935, 23986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_24459_24483(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 24459, 24483);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_24485_24514(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 24485, 24514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_24516_24533(Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 24516, 24533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_24436_24534(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 24436, 24534);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_24719_24788(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 24719, 24788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_24572_24823(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 24572, 24823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10316_25018_25027(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 25018, 25027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_25039_25072(Microsoft.CodeAnalysis.CSharp.BoundCall
                invocation)
                {
                    var return_v = ExtractCastInvocation(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25039, 25072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_25116_25136(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 25116, 25136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_25208_25230(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 25208, 25230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10316_25253_25270(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 25253, 25270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_25333_25419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                castInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression, definedSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25333, 25419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_25168_25421(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25168, 25421);
                    return return_v;
                }


                int
                f_10316_25442_25455(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25442, 25455);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_25497_25578(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, definedSymbol: definedSymbol, queryInvocation: (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25497, 25578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_25620_25665(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 25620, 25665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_26750_26785(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                x2)
                {
                    var return_v = this_param.MakePairLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, state, x1, x2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 26750, 26785);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_26970_27039(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 26970, 27039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_26823_27074(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 26823, 27074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10316_27130_27139(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27130, 27139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_27151_27184(Microsoft.CodeAnalysis.CSharp.BoundCall
                invocation)
                {
                    var return_v = ExtractCastInvocation(invocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 27151, 27184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_27233_27298(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                castInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, definedSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation, castInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 27233, 27298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 23186, 27325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 23186, 27325);
            }
        }

        private static BoundExpression? ExtractCastInvocation(BoundCall invocation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10316, 27337, 27829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27437, 27493);

                int
                index = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 27449, 27484) || ((f_10316_27449_27484(invocation) && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 27487, 27488)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 27491, 27492))) ? 1 : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27507, 27563);

                var
                c1 = f_10316_27516_27536(invocation)[index] as BoundConversion
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27577, 27632);

                var
                l1 = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 27586, 27596) || ((c1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 27599, 27624)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 27627, 27631))) ? f_10316_27599_27609(c1) as BoundLambda : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27646, 27721);

                var
                r1 = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 27655, 27665) || ((l1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 27668, 27713)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 27716, 27720))) ? f_10316_27668_27686(f_10316_27668_27675(l1))[0] as BoundReturnStatement : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27735, 27794);

                var
                i1 = (DynAbs.Tracing.TraceSender.Conditional_F1(10316, 27744, 27754) || ((r1 != null && DynAbs.Tracing.TraceSender.Conditional_F2(10316, 27757, 27786)) || DynAbs.Tracing.TraceSender.Conditional_F3(10316, 27789, 27793))) ? f_10316_27757_27773(r1) as BoundCall : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 27808, 27818);

                return i1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10316, 27337, 27829);

                bool
                f_10316_27449_27484(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27449, 27484);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_27516_27536(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27516, 27536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_27599_27609(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27599, 27609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10316_27668_27675(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27668, 27675);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10316_27668_27686(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27668, 27686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10316_27757_27773(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 27757, 27773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 27337, 27829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 27337, 27829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnboundLambda MakePairLambda(CSharpSyntaxNode node, QueryTranslationState state, RangeVariableSymbol x1, RangeVariableSymbol x2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 27841, 29094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28002, 28056);

                f_10316_28002_28055(f_10316_28015_28054(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28072, 28705);

                LambdaBodyFactory
                bodyFactory = (LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag d) =>
                            {
                                var x1Expression = new BoundParameter(node, lambdaSymbol.Parameters[0]) { WasCompilerGenerated = true };
                                var x2Expression = new BoundParameter(node, lambdaSymbol.Parameters[1]) { WasCompilerGenerated = true };
                                var construction = MakePair(node, x1.Name, x1Expression, x2.Name, x2Expression, state, d);
                                return lambdaBodyBinder.CreateBlockFromExpression(node, ImmutableArray<LocalSymbol>.Empty, RefKind.None, construction, null, d);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28721, 28833);

                var
                result = f_10316_28734_28832(this, f_10316_28757_28781(state), f_10316_28783_28812(x1, x2), node, bodyFactory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28847, 28906);

                state.rangeVariable = f_10316_28869_28905(state, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28920, 28960);

                f_10316_28920_28959(state, f_10316_28951_28958(x1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 28974, 29012);

                var
                x2m = f_10316_28984_29011(state.allRangeVariables, x2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 29026, 29055);

                x2m[f_10316_29030_29039(x2m) - 1] = f_10316_29047_29054(x2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 29069, 29083);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 27841, 29094);

                bool
                f_10316_28015_28054(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = LambdaUtilities.IsQueryPairLambda((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28015, 28054);
                    return return_v;
                }


                int
                f_10316_28002_28055(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28002, 28055);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_28757_28781(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28757, 28781);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_28783_28812(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28783, 28812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_28734_28832(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                bodyFactory)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, node, bodyFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28734, 28832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_28869_28905(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = this_param.TransparentRangeVariable(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28869, 28905);
                    return return_v;
                }


                string
                f_10316_28951_28958(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 28951, 28958);
                    return return_v;
                }


                int
                f_10316_28920_28959(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, string
                name)
                {
                    this_param.AddTransparentIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 28920, 28959);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10316_28984_29011(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 28984, 29011);
                    return return_v;
                }


                int
                f_10316_29030_29039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 29030, 29039);
                    return return_v;
                }


                string
                f_10316_29047_29054(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 29047, 29054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 27841, 29094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 27841, 29094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReduceLet(LetClauseSyntax let, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 29106, 32692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 29500, 29528);

                var
                x = state.rangeVariable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 30100, 32077);

                LambdaBodyFactory
                bodyFactory = (LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag d) =>
                            {
                                var xExpression = new BoundParameter(let, lambdaSymbol.Parameters[0]) { WasCompilerGenerated = true };

                                lambdaBodyBinder = lambdaBodyBinder.GetRequiredBinder(let.Expression);

                                var yExpression = lambdaBodyBinder.BindRValueWithoutTargetType(let.Expression, d);
                                SourceLocation errorLocation = new SourceLocation(let.SyntaxTree, new TextSpan(let.Identifier.SpanStart, let.Expression.Span.End - let.Identifier.SpanStart));
                                if (!yExpression.HasAnyErrors && !yExpression.HasExpressionType())
                                {
                                    Error(d, ErrorCode.ERR_QueryRangeVariableAssignedBadValue, errorLocation, yExpression.Display);
                                    yExpression = new BoundBadExpression(yExpression.Syntax, LookupResultKind.Empty, ImmutableArray<Symbol?>.Empty, ImmutableArray.Create(yExpression), CreateErrorType());
                                }
                                else if (!yExpression.HasAnyErrors && yExpression.Type!.IsVoidType())
                                {
                                    Error(d, ErrorCode.ERR_QueryRangeVariableAssignedBadValue, errorLocation, yExpression.Type!);
                                    Debug.Assert(yExpression.Type is { });
                                    yExpression = new BoundBadExpression(yExpression.Syntax, LookupResultKind.Empty, ImmutableArray<Symbol?>.Empty, ImmutableArray.Create(yExpression), yExpression.Type);
                                }

                                var construction = MakePair(let, x.Name, xExpression, let.Identifier.ValueText, yExpression, state, d);

                // The bound block represents a closure scope for transparent identifiers captured in the let clause.
                // Such closures shall be associated with the lambda body expression.
                return lambdaBodyBinder.CreateLambdaBlockForQueryClause(let.Expression, construction, d);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32093, 32210);

                var
                lambda = f_10316_32106_32209(this, f_10316_32129_32153(state), f_10316_32155_32179(x), f_10316_32181_32195(let), bodyFactory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32224, 32283);

                state.rangeVariable = f_10316_32246_32282(state, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32297, 32336);

                f_10316_32297_32335(state, f_10316_32328_32334(x));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32350, 32416);

                var
                y = f_10316_32358_32415(state, this, f_10316_32387_32401(let), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32430, 32487);

                f_10316_32430_32486(f_10316_32430_32456(state.allRangeVariables, y), let.Identifier.ValueText);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32501, 32596);

                var
                invocation = f_10316_32518_32595(this, let, state.fromExpression, "Select", lambda, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32610, 32681);

                state.fromExpression = f_10316_32633_32680(this, let, invocation, y, invocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 29106, 32692);

                Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                f_10316_32129_32153(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.RangeVariableMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32129, 32153);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_32155_32179(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32155, 32179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10316_32181_32195(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 32181, 32195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_32106_32209(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                bodyFactory)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, bodyFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32106, 32209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_32246_32282(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = this_param.TransparentRangeVariable(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32246, 32282);
                    return return_v;
                }


                string
                f_10316_32328_32334(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 32328, 32334);
                    return return_v;
                }


                int
                f_10316_32297_32335(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, string
                name)
                {
                    this_param.AddTransparentIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32297, 32335);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10316_32387_32401(Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 32387, 32401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10316_32358_32415(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AddRangeVariable(binder, identifier, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32358, 32415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10316_32430_32456(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 32430, 32456);
                    return return_v;
                }


                int
                f_10316_32430_32486(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32430, 32486);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_32518_32595(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                arg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, receiver, methodName, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32518, 32595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_32633_32680(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LetClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundCall
                queryInvocation)
                {
                    var return_v = this_param.MakeQueryClause((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, definedSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)queryInvocation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32633, 32680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 29106, 32692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 29106, 32692);
            }
        }

        private BoundBlock CreateLambdaBlockForQueryClause(ExpressionSyntax expression, BoundExpression result, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 32704, 33266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32859, 32915);

                var
                locals = f_10316_32872_32914(this, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32929, 33134) || true) && (locals.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 32929, 33134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 32979, 33119);

                    f_10316_32979_33118(expression, MessageID.IDS_FeatureExpressionVariablesInQueriesAndInitializers, diagnostics, f_10316_33095_33114(locals[0])[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 32929, 33134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 33150, 33255);

                return f_10316_33157_33254(this, expression, locals, RefKind.None, result, expression, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 32704, 33266);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10316_32872_32914(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32872, 32914);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10316_33095_33114(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 33095, 33114);
                    return return_v;
                }


                bool
                f_10316_32979_33118(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 32979, 33118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10316_33157_33254(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expressionSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateBlockFromExpression((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, locals, refKind, expression, expressionSyntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 33157, 33254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 32704, 33266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 32704, 33266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundQueryClause MakeQueryClause(
                    CSharpSyntaxNode syntax,
                    BoundExpression expression,
                    RangeVariableSymbol? definedSymbol = null,
                    BoundExpression? queryInvocation = null,
                    BoundExpression? castInvocation = null,
                    BoundExpression? unoptimizedForm = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 33278, 34102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 33640, 33752) || true) && (unoptimizedForm != null && (DynAbs.Tracing.TraceSender.Expression_True(10316, 33644, 33699) && f_10316_33671_33699(unoptimizedForm)) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 33644, 33727) && f_10316_33703_33727_M(!expression.HasAnyErrors)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 33640, 33752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 33729, 33752);

                    unoptimizedForm = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 33640, 33752);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 33766, 34091);

                return f_10316_33773_34090(syntax: syntax, value: expression, definedSymbol: definedSymbol, operation: queryInvocation, binder: this, cast: castInvocation, unoptimizedForm: unoptimizedForm, type: f_10316_34066_34089(this, expression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 33278, 34102);

                bool
                f_10316_33671_33699(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 33671, 33699);
                    return return_v;
                }


                bool
                f_10316_33703_33727_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 33703, 33727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_34066_34089(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.TypeOrError(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34066, 34089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                f_10316_33773_34090(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                operation, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                cast, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                unoptimizedForm, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundQueryClause(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, value: value, definedSymbol: definedSymbol, operation: operation, binder: binder, cast: cast, unoptimizedForm: unoptimizedForm, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 33773, 34090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 33278, 34102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 33278, 34102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakePair(CSharpSyntaxNode node, string field1Name, BoundExpression field1Value, string field2Name, BoundExpression field2Value, QueryTranslationState state, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 34114, 35968);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 34346, 34723) || true) && (field1Name == field2Name)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 34346, 34723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 34468, 34518);

                    field2Name = f_10316_34481_34517(state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 34536, 34708);

                    field2Value = f_10316_34550_34707(field2Value.Syntax, LookupResultKind.Empty, ImmutableArray<Symbol?>.Empty, f_10316_34648_34682(field2Value), f_10316_34684_34700(field2Value), true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 34346, 34723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 34739, 35652);

                AnonymousTypeDescriptor
                typeDescriptor = f_10316_34780_35651(f_10316_34870_35519(f_10316_34978_35183(field1Name, f_10316_35013_35040(field1Value.Syntax), TypeWithAnnotations.Create(f_10316_35157_35181(this, field1Value))), f_10316_35250_35456(field2Name, f_10316_35285_35312(field2Value.Syntax), TypeWithAnnotations.Create(f_10316_35430_35454(this, field2Value)))), f_10316_35582_35595(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 35668, 35737);

                AnonymousTypeManager
                manager = f_10316_35699_35736(f_10316_35699_35715(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 35751, 35836);

                NamedTypeSymbol
                anonymousType = f_10316_35783_35835(manager, typeDescriptor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 35850, 35957);

                return f_10316_35857_35956(this, node, anonymousType, f_10316_35895_35942(field1Value, field2Value), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 34114, 35968);

                string
                f_10316_34481_34517(Microsoft.CodeAnalysis.CSharp.Binder.QueryTranslationState
                this_param)
                {
                    var return_v = this_param.TransparentRangeVariableName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34481, 34517);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_34648_34682(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34648, 34682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_34684_34700(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 34684, 34700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_34550_34707(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34550, 34707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_35013_35040(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 35013, 35040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_35157_35181(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.TypeOrError(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35157, 35181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
                f_10316_34978_35183(string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField(name, location, typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34978, 35183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_35285_35312(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 35285, 35312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_35430_35454(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.TypeOrError(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35430, 35454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
                f_10316_35250_35456(string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField(name, location, typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35250, 35456);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                f_10316_34870_35519(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
                item2)
                {
                    var return_v = ImmutableArray.Create<AnonymousTypeField>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34870, 35519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_35582_35595(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 35582, 35595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                f_10316_34780_35651(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                fields, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor(fields, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 34780, 35651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10316_35699_35715(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 35699, 35715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10316_35699_35736(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 35699, 35736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10316_35783_35835(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                typeDescr)
                {
                    var return_v = this_param.ConstructAnonymousTypeSymbol(typeDescr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35783, 35835);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_35895_35942(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35895, 35942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_35857_35956(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCreate, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeConstruction(node, toCreate, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 35857, 35956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 34114, 35968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 34114, 35968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol TypeOrError(BoundExpression e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 35980, 36100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 36054, 36089);

                return f_10316_36061_36067(e) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10316, 36061, 36088) ?? f_10316_36071_36088(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 35980, 36100);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_36061_36067(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 36061, 36067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10316_36071_36088(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 36071, 36088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 35980, 36100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 35980, 36100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnboundLambda MakeQueryUnboundLambda(RangeVariableMap qvm, RangeVariableSymbol parameter, ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 36112, 36355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 36263, 36344);

                return f_10316_36270_36343(this, qvm, f_10316_36298_36330(parameter), expression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 36112, 36355);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_36298_36330(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 36298, 36330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_36270_36343(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                qvm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.MakeQueryUnboundLambda(qvm, parameters, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 36270, 36343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 36112, 36355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 36112, 36355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnboundLambda MakeQueryUnboundLambda(RangeVariableMap qvm, ImmutableArray<RangeVariableSymbol> parameters, ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 36367, 37133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 36535, 37122);

                return f_10316_36542_37121(expression, f_10316_36577_37120(this, qvm, parameters, (LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics) =>
                            {
                                lambdaBodyBinder = lambdaBodyBinder.GetRequiredBinder(expression);
                                Debug.Assert(lambdaSymbol != null);
                                BoundExpression boundExpression = lambdaBodyBinder.BindValue(expression, diagnostics, BindValueKind.RValue);
                                return lambdaBodyBinder.CreateLambdaBlockForQueryClause(expression, boundExpression, diagnostics);
                            }));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 36367, 37133);

                Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                f_10316_36577_37120(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                rangeVariableMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                bodyFactory)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState(binder, rangeVariableMap, parameters, bodyFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 36577, 37120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_36542_37121(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                state)
                {
                    var return_v = MakeQueryUnboundLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 36542, 37121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 36367, 37133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 36367, 37133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnboundLambda MakeQueryUnboundLambdaWithCast(RangeVariableMap qvm, RangeVariableSymbol parameter, ExpressionSyntax expression, TypeSyntax castTypeSyntax, TypeWithAnnotations castType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 37145, 38172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 37361, 38161);

                return f_10316_37368_38160(expression, f_10316_37403_38159(this, qvm, f_10316_37442_37474(parameter), (LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics) =>
                            {
                                lambdaBodyBinder = lambdaBodyBinder.GetRequiredBinder(expression);
                                BoundExpression boundExpression = lambdaBodyBinder.BindValue(expression, diagnostics, BindValueKind.RValue);

                // We transform the expression from "expr" to "expr.Cast<castTypeOpt>()".
                boundExpression = lambdaBodyBinder.MakeQueryInvocation(expression, boundExpression, "Cast", castTypeSyntax, castType, diagnostics);

                                return lambdaBodyBinder.CreateLambdaBlockForQueryClause(expression, boundExpression, diagnostics);
                            }));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 37145, 38172);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                f_10316_37442_37474(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 37442, 37474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                f_10316_37403_38159(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                rangeVariableMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                bodyFactory)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState(binder, rangeVariableMap, parameters, bodyFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 37403, 38159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_37368_38160(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                state)
                {
                    var return_v = MakeQueryUnboundLambda((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 37368, 38160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 37145, 38172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 37145, 38172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UnboundLambda MakeQueryUnboundLambda(RangeVariableMap qvm, ImmutableArray<RangeVariableSymbol> parameters, CSharpSyntaxNode node, LambdaBodyFactory bodyFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 38184, 38489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 38377, 38478);

                return f_10316_38384_38477(node, f_10316_38413_38476(this, qvm, parameters, bodyFactory));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 38184, 38489);

                Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                f_10316_38413_38476(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Binder.RangeVariableMap
                rangeVariableMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Binder.LambdaBodyFactory
                bodyFactory)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState(binder, rangeVariableMap, parameters, bodyFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 38413, 38476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10316_38384_38477(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                state)
                {
                    var return_v = MakeQueryUnboundLambda(node, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 38384, 38477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 38184, 38489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 38184, 38489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static UnboundLambda MakeQueryUnboundLambda(CSharpSyntaxNode node, QueryUnboundLambdaState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10316, 38501, 38905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 38631, 38713);

                f_10316_38631_38712(node is ExpressionSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10316, 38644, 38711) || f_10316_38672_38711(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 38727, 38821);

                var
                lambda = new UnboundLambda(node, state, hasErrors: false) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10316, 38740, 38820) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 38835, 38866);

                f_10316_38835_38865(state, lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 38880, 38894);

                return lambda;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10316, 38501, 38905);

                bool
                f_10316_38672_38711(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = LambdaUtilities.IsQueryPairLambda((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 38672, 38711);
                    return return_v;
                }


                int
                f_10316_38631_38712(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 38631, 38712);
                    return 0;
                }


                int
                f_10316_38835_38865(Microsoft.CodeAnalysis.CSharp.Binder.QueryUnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                unbound)
                {
                    this_param.SetUnboundLambda(unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 38835, 38865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 38501, 38905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 38501, 38905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundCall MakeQueryInvocation(CSharpSyntaxNode node, BoundExpression receiver, string methodName, BoundExpression arg, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 38917, 39292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 39097, 39281);

                return f_10316_39104_39280(this, node, receiver, methodName, default(SeparatedSyntaxList<TypeSyntax>), default(ImmutableArray<TypeWithAnnotations>), f_10316_39240_39266(arg), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 38917, 39292);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_39240_39266(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39240, 39266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_39104_39280(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation(node, receiver, methodName, typeArgsSyntax, typeArgs, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39104, 39280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 38917, 39292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 38917, 39292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundCall MakeQueryInvocation(CSharpSyntaxNode node, BoundExpression receiver, string methodName, ImmutableArray<BoundExpression> args, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 39304, 39674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 39501, 39663);

                return f_10316_39508_39662(this, node, receiver, methodName, default(SeparatedSyntaxList<TypeSyntax>), default(ImmutableArray<TypeWithAnnotations>), args, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 39304, 39674);

                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_39508_39662(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation(node, receiver, methodName, typeArgsSyntax, typeArgs, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39508, 39662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 39304, 39674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 39304, 39674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundCall MakeQueryInvocation(CSharpSyntaxNode node, BoundExpression receiver, string methodName, TypeSyntax typeArgSyntax, TypeWithAnnotations typeArg, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 39686, 40132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 39900, 40121);

                return f_10316_39907_40120(this, node, receiver, methodName, f_10316_39955_40035(f_10316_39991_40034(typeArgSyntax, 0)), f_10316_40037_40067(typeArg), ImmutableArray<BoundExpression>.Empty, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 39686, 40132);

                Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                f_10316_39991_40034(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.SyntaxNodeOrTokenList((Microsoft.CodeAnalysis.SyntaxNode)node, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39991, 40034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                f_10316_39955_40035(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
                list)
                {
                    var return_v = new Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39955, 40035);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10316_40037_40067(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 40037, 40067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10316_39907_40120(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgs, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeQueryInvocation(node, receiver, methodName, typeArgsSyntax, typeArgs, args, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 39907, 40120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 39686, 40132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 39686, 40132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundCall MakeQueryInvocation(CSharpSyntaxNode node, BoundExpression receiver, string methodName, SeparatedSyntaxList<TypeSyntax> typeArgsSyntax, ImmutableArray<TypeWithAnnotations> typeArgs, ImmutableArray<BoundExpression> args, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 40144, 46470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40473, 40505);

                var
                ultimateReceiver = receiver
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40519, 40683) || true) && (f_10316_40526_40547(ultimateReceiver) == BoundKind.QueryClause)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 40519, 40683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40606, 40668);

                        ultimateReceiver = f_10316_40625_40667(((BoundQueryClause)ultimateReceiver));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 40519, 40683);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10316, 40519, 40683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10316, 40519, 40683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40697, 40768);

                f_10316_40697_40767(f_10316_40710_40723(receiver) is object || (DynAbs.Tracing.TraceSender.Expression_False(10316, 40710, 40766) || f_10316_40737_40758(ultimateReceiver) is null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40782, 45088) || true) && ((object?)f_10316_40795_40816(ultimateReceiver) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 40782, 45088);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 40858, 43364) || true) && (f_10316_40862_40891(ultimateReceiver) || (DynAbs.Tracing.TraceSender.Expression_False(10316, 40862, 40909) || f_10316_40895_40909(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 40858, 43364);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 40858, 43364);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 40858, 43364);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41023, 43364) || true) && (f_10316_41027_41059(ultimateReceiver))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41023, 43364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41101, 41160);

                            f_10316_41101_41159(diagnostics, ErrorCode.ERR_NullNotValid, f_10316_41145_41158(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41023, 43364);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41023, 43364);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41202, 43364) || true) && (f_10316_41206_41241(ultimateReceiver))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41202, 43364);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41283, 41352);

                                f_10316_41283_41351(diagnostics, ErrorCode.ERR_DefaultLiteralNotValid, f_10316_41337_41350(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41202, 43364);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41202, 43364);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41394, 43364) || true) && (f_10316_41398_41441(ultimateReceiver))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41394, 43364);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41483, 41560);

                                    f_10316_41483_41559(diagnostics, ErrorCode.ERR_ImplicitObjectCreationNotValid, f_10316_41545_41558(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41394, 43364);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41394, 43364);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41602, 43364) || true) && (f_10316_41606_41627(ultimateReceiver) == BoundKind.NamespaceExpression)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41602, 43364);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41702, 41881);

                                        f_10316_41702_41880(diagnostics, ErrorCode.ERR_BadSKunknown, f_10316_41746_41778(ultimateReceiver.Syntax), f_10316_41780_41840(((BoundNamespaceExpression)ultimateReceiver)), f_10316_41842_41879(MessageID.IDS_SK_NAMESPACE));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41602, 43364);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41602, 43364);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 41923, 43364) || true) && (f_10316_41927_41948(ultimateReceiver) == BoundKind.Lambda || (DynAbs.Tracing.TraceSender.Expression_False(10316, 41927, 42020) || f_10316_41972_41993(ultimateReceiver) == BoundKind.UnboundLambda))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41923, 43364);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42181, 42292);

                                            f_10316_42181_42291(                    // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.
                                                                diagnostics, ErrorCode.ERR_QueryNoProvider, f_10316_42228_42241(node), f_10316_42243_42278(MessageID.IDS_AnonMethod), methodName);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41923, 43364);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 41923, 43364);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42334, 43364) || true) && (f_10316_42338_42359(ultimateReceiver) == BoundKind.MethodGroup)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 42334, 43364);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42426, 42479);

                                                var
                                                methodGroup = (BoundMethodGroup)ultimateReceiver
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42501, 42552);

                                                HashSet<DiagnosticInfo>?
                                                useSiteDiagnostics = null
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42574, 42729);

                                                var
                                                resolution = f_10316_42591_42728(this, methodGroup, analyzedArguments: null, isMethodGroupConversion: false, useSiteDiagnostics: ref useSiteDiagnostics)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42751, 42793);

                                                f_10316_42751_42792(diagnostics, node, useSiteDiagnostics);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42815, 42860);

                                                f_10316_42815_42859(diagnostics, resolution.Diagnostics);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42882, 43305) || true) && (resolution.HasAnyErrors)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 42882, 43305);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 42959, 43014);

                                                    receiver = f_10316_42970_43013(this, methodGroup);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 42882, 43305);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 42882, 43305);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43112, 43146);

                                                    f_10316_43112_43145(f_10316_43125_43144_M(!resolution.IsEmpty));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43172, 43282);

                                                    f_10316_43172_43281(diagnostics, ErrorCode.ERR_QueryNoProvider, f_10316_43219_43232(node), f_10316_43234_43268(MessageID.IDS_SK_METHOD), methodName);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 42882, 43305);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43327, 43345);

                                                resolution.Free();
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 42334, 43364);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41923, 43364);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41602, 43364);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41394, 43364);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41202, 43364);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 41023, 43364);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 40858, 43364);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43384, 43546);

                    receiver = f_10316_43395_43545(receiver.Syntax, LookupResultKind.NotAValue, ImmutableArray<Symbol?>.Empty, f_10316_43494_43525(receiver), f_10316_43527_43544(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 40782, 45088);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 40782, 45088);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43580, 45088) || true) && (f_10316_43584_43605(ultimateReceiver) == BoundKind.TypeExpression)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 43580, 45088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43667, 43918) || true) && (f_10316_43671_43701(f_10316_43671_43692(ultimateReceiver)) == TypeKind.TypeParameter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 43667, 43918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43769, 43899);

                            f_10316_43769_43898(diagnostics, ErrorCode.ERR_BadSKunknown, ultimateReceiver.Syntax, f_10316_43841_43862(ultimateReceiver), f_10316_43864_43897(MessageID.IDS_SK_TYVAR));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 43667, 43918);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 43580, 45088);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 43580, 45088);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 43952, 45088) || true) && (f_10316_43956_43977(ultimateReceiver) == BoundKind.TypeOrValueExpression)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 43952, 45088);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 43952, 45088);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 43952, 45088);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44265, 45088) || true) && (f_10316_44269_44296(receiver.Type!))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 44265, 45088);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44330, 44518) || true) && (f_10316_44334_44356_M(!receiver.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10316, 44334, 44375) && f_10316_44360_44375_M(!node.HasErrors)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 44330, 44518);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44417, 44499);

                                    f_10316_44417_44498(diagnostics, ErrorCode.ERR_QueryNoProvider, f_10316_44464_44477(node), "void", methodName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 44330, 44518);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44538, 44700);

                                receiver = f_10316_44549_44699(receiver.Syntax, LookupResultKind.NotAValue, ImmutableArray<Symbol?>.Empty, f_10316_44648_44679(receiver), f_10316_44681_44698(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 44265, 45088);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 44265, 45088);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44766, 44860);

                                var
                                checkedUltimateReceiver = f_10316_44796_44859(this, ultimateReceiver, BindValueKind.RValue, diagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44878, 45073) || true) && (checkedUltimateReceiver != ultimateReceiver)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 44878, 45073);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 44967, 45054);

                                    receiver = f_10316_44978_45053(receiver, ultimateReceiver, checkedUltimateReceiver);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 44878, 45073);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 44265, 45088);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 43952, 45088);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 43580, 45088);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 40782, 45088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 45104, 45627);

                return (BoundCall)f_10316_45122_45626(this, node, receiver, methodName, args, diagnostics, typeArgsSyntax, typeArgs, queryClause: node, allowFieldsAndProperties: true);

                static BoundExpression updateUltimateReceiver(BoundExpression receiver, BoundExpression originalUltimateReceiver, BoundExpression replacementUltimateReceiver)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10316, 45643, 46459);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 45834, 46320) || true) && (receiver is BoundQueryClause query)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10316, 45834, 46320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 45914, 46301);

                            return f_10316_45921_46300(query, f_10316_45960_46050(f_10316_45983_45994(query), originalUltimateReceiver, replacementUltimateReceiver), f_10316_46077_46096(query), f_10316_46123_46138(query), f_10316_46165_46175(query), f_10316_46202_46214(query), f_10316_46241_46262(query), f_10316_46289_46299(query));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10316, 45834, 46320);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46340, 46391);

                        f_10316_46340_46390(receiver == originalUltimateReceiver);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46409, 46444);

                        return replacementUltimateReceiver;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10316, 45643, 46459);

                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10316_45983_45994(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 45983, 45994);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10316_45960_46050(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        receiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        originalUltimateReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        replacementUltimateReceiver)
                        {
                            var return_v = updateUltimateReceiver(receiver, originalUltimateReceiver, replacementUltimateReceiver);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 45960, 46050);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                        f_10316_46077_46096(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.DefinedSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46077, 46096);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10316_46123_46138(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.Operation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46123, 46138);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10316_46165_46175(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.Cast;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46165, 46175);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Binder
                        f_10316_46202_46214(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.Binder;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46202, 46214);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10316_46241_46262(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.UnoptimizedForm;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46241, 46262);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10316_46289_46299(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46289, 46299);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        f_10316_45921_46300(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        value, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                        definedSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        operation, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        cast, Microsoft.CodeAnalysis.CSharp.Binder
                        binder, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        unoptimizedForm, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = this_param.Update(value, definedSymbol, operation, cast, binder, unoptimizedForm, type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 45921, 46300);
                            return return_v;
                        }


                        int
                        f_10316_46340_46390(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 46340, 46390);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 45643, 46459);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 45643, 46459);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 40144, 46470);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_40526_40547(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40526, 40547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_40625_40667(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40625, 40667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_40710_40723(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40710, 40723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_40737_40758(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40737, 40758);
                    return return_v;
                }


                int
                f_10316_40697_40767(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 40697, 40767);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10316_40795_40816(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40795, 40816);
                    return return_v;
                }


                bool
                f_10316_40862_40891(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40862, 40891);
                    return return_v;
                }


                bool
                f_10316_40895_40909(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 40895, 40909);
                    return return_v;
                }


                bool
                f_10316_41027_41059(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41027, 41059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_41145_41158(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41145, 41158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_41101_41159(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41101, 41159);
                    return return_v;
                }


                bool
                f_10316_41206_41241(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41206, 41241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_41337_41350(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41337, 41350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_41283_41351(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41283, 41351);
                    return return_v;
                }


                bool
                f_10316_41398_41441(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41398, 41441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_41545_41558(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41545, 41558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_41483_41559(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41483, 41559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_41606_41627(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41606, 41627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_41746_41778(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41746, 41778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10316_41780_41840(Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression
                this_param)
                {
                    var return_v = this_param.NamespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41780, 41840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10316_41842_41879(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41842, 41879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_41702_41880(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 41702, 41880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_41927_41948(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41927, 41948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_41972_41993(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 41972, 41993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_42228_42241(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 42228, 42241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10316_42243_42278(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42243, 42278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_42181_42291(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42181, 42291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_42338_42359(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 42338, 42359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodGroupResolution
                f_10316_42591_42728(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, bool
                isMethodGroupConversion, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ResolveMethodGroup(node, analyzedArguments: analyzedArguments, isMethodGroupConversion: isMethodGroupConversion, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42591, 42728);
                    return return_v;
                }


                bool
                f_10316_42751_42792(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42751, 42792);
                    return return_v;
                }


                int
                f_10316_42815_42859(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42815, 42859);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_42970_43013(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node)
                {
                    var return_v = this_param.BindMemberAccessBadResult(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 42970, 43013);
                    return return_v;
                }


                bool
                f_10316_43125_43144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43125, 43144);
                    return return_v;
                }


                int
                f_10316_43112_43145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43112, 43145);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_43219_43232(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43219, 43232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10316_43234_43268(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43234, 43268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_43172_43281(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43172, 43281);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_43494_43525(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43494, 43525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10316_43527_43544(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43527, 43544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_43395_43545(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43395, 43545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_43584_43605(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43584, 43605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_43671_43692(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43671, 43692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10316_43671_43701(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43671, 43701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10316_43841_43862(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43841, 43862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10316_43864_43897(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43864, 43897);
                    return return_v;
                }


                int
                f_10316_43769_43898(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 43769, 43898);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10316_43956_43977(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 43956, 43977);
                    return return_v;
                }


                bool
                f_10316_44269_44296(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44269, 44296);
                    return return_v;
                }


                bool
                f_10316_44334_44356_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 44334, 44356);
                    return return_v;
                }


                bool
                f_10316_44360_44375_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 44360, 44375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10316_44464_44477(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 44464, 44477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10316_44417_44498(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44417, 44498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10316_44648_44679(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44648, 44679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10316_44681_44698(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44681, 44698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10316_44549_44699(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol?>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44549, 44699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_44796_44859(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44796, 44859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_44978_45053(Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                originalUltimateReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression
                replacementUltimateReceiver)
                {
                    var return_v = updateUltimateReceiver(receiver, originalUltimateReceiver, replacementUltimateReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 44978, 45053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_45122_45626(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, string
                methodName, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgs, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause, bool
                allowFieldsAndProperties)
                {
                    var return_v = this_param.MakeInvocationExpression((Microsoft.CodeAnalysis.SyntaxNode)node, receiver, methodName, args, diagnostics, typeArgsSyntax, typeArgs, queryClause: queryClause, allowFieldsAndProperties: allowFieldsAndProperties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 45122, 45626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 40144, 46470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 40144, 46470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundExpression MakeConstruction(CSharpSyntaxNode node, NamedTypeSymbol toCreate, ImmutableArray<BoundExpression> args, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10316, 46482, 47041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46663, 46733);

                AnalyzedArguments
                analyzedArguments = f_10316_46701_46732()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46747, 46790);

                f_10316_46747_46789(analyzedArguments.Arguments, args);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46804, 46914);

                var
                result = f_10316_46817_46913(this, node, f_10316_46851_46864(toCreate), node, toCreate, analyzedArguments, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46928, 46963);

                result.WasCompilerGenerated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 46977, 47002);

                f_10316_46977_47001(analyzedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10316, 47016, 47030);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10316, 46482, 47041);

                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10316_46701_46732()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 46701, 46732);
                    return return_v;
                }


                int
                f_10316_46747_46789(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 46747, 46789);
                    return 0;
                }


                string
                f_10316_46851_46864(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10316, 46851, 46864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10316_46817_46913(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, string
                typeName, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                typeNode, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindClassCreationExpression((Microsoft.CodeAnalysis.SyntaxNode)node, typeName, (Microsoft.CodeAnalysis.SyntaxNode)typeNode, type, analyzedArguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 46817, 46913);
                    return return_v;
                }


                int
                f_10316_46977_47001(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10316, 46977, 47001);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10316, 46482, 47041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10316, 46482, 47041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
