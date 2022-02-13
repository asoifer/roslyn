// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DebugInfoInjector
    {
        private static BoundStatement AddSequencePoint(BoundStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 552, 704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 644, 693);

                return f_10462_651_692(node.Syntax, node);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 552, 704);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                f_10462_651_692(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePoint(syntax, statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 651, 692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 552, 704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 552, 704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundStatement AddSequencePoint(VariableDeclaratorSyntax declaratorSyntax, BoundStatement rewrittenStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 716, 1201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 866, 882);

                SyntaxNode
                node
                = default(SyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 896, 911);

                TextSpan?
                part
                = default(TextSpan?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 925, 981);

                f_10462_925_980(declaratorSyntax, out node, out part);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 995, 1078);

                var
                result = f_10462_1008_1077(declaratorSyntax, part, rewrittenStatement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1092, 1162);

                result.WasCompilerGenerated = f_10462_1122_1161(rewrittenStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1176, 1190);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 716, 1201);

                int
                f_10462_925_980(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, out Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.Text.TextSpan?
                part)
                {
                    GetBreakpointSpan(declaratorSyntax, out node, out part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 925, 980);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10462_1008_1077(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax, Microsoft.CodeAnalysis.Text.TextSpan?
                part, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = BoundSequencePoint.Create((Microsoft.CodeAnalysis.SyntaxNode)syntax, part, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 1008, 1077);
                    return return_v;
                }


                bool
                f_10462_1122_1161(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1122, 1161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 716, 1201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 716, 1201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundStatement AddSequencePoint(PropertyDeclarationSyntax declarationSyntax, BoundStatement rewrittenStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 1213, 1837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1365, 1417);

                f_10462_1365_1416(f_10462_1378_1407(declarationSyntax) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1431, 1489);

                int
                start = f_10462_1443_1488(f_10462_1443_1478(f_10462_1443_1472(declarationSyntax)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1503, 1552);

                int
                end = f_10462_1513_1542(declarationSyntax).Span.End
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1566, 1614);

                TextSpan
                part = TextSpan.FromBounds(start, end)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1630, 1714);

                var
                result = f_10462_1643_1713(declarationSyntax, part, rewrittenStatement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1728, 1798);

                result.WasCompilerGenerated = f_10462_1758_1797(rewrittenStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1812, 1826);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 1213, 1837);

                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10462_1378_1407(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1378, 1407);
                    return return_v;
                }


                int
                f_10462_1365_1416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 1365, 1416);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                f_10462_1443_1472(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1443, 1472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10462_1443_1478(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1443, 1478);
                    return return_v;
                }


                int
                f_10462_1443_1488(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1443, 1488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                f_10462_1513_1542(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1513, 1542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10462_1643_1713(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.Text.TextSpan
                part, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = BoundSequencePoint.Create((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.Text.TextSpan?)part, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 1643, 1713);
                    return return_v;
                }


                bool
                f_10462_1758_1797(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 1758, 1797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 1213, 1837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 1213, 1837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundStatement AddSequencePoint(UsingStatementSyntax usingSyntax, BoundStatement rewrittenStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 1849, 2250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 1990, 2025);

                int
                start = usingSyntax.Span.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2039, 2086);

                int
                end = usingSyntax.CloseParenToken.Span.End
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2100, 2148);

                TextSpan
                span = TextSpan.FromBounds(start, end)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2162, 2239);

                return f_10462_2169_2238(usingSyntax, rewrittenStatement, span);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 1849, 2250);

                Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                f_10462_2169_2238(Microsoft.CodeAnalysis.CSharp.Syntax.UsingStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan((Microsoft.CodeAnalysis.SyntaxNode)syntax, statementOpt, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 2169, 2238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 1849, 2250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 1849, 2250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TextSpan CreateSpanForConstructorInitializer(ConstructorDeclarationSyntax constructorSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 2262, 3429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2394, 2803) || true) && (f_10462_2398_2427(constructorSyntax) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 2394, 2803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2565, 2635);

                    var
                    start = f_10462_2577_2606(constructorSyntax).ThisOrBaseKeyword.SpanStart
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2653, 2731);

                    var
                    end = f_10462_2663_2705(f_10462_2663_2692(constructorSyntax)).CloseParenToken.Span.End
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2749, 2788);

                    return TextSpan.FromBounds(start, end);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 2394, 2803);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2819, 3192) || true) && (constructorSyntax.Modifiers.Any(SyntaxKind.StaticKeyword))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 2819, 3192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 2985, 3045);

                    var
                    start = f_10462_2997_3019(constructorSyntax).OpenBraceToken.SpanStart
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3063, 3120);

                    var
                    end = f_10462_3073_3095(constructorSyntax).OpenBraceToken.Span.End
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3138, 3177);

                    return TextSpan.FromBounds(start, end);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 2819, 3192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3292, 3418);

                return f_10462_3299_3417(f_10462_3310_3337(constructorSyntax), f_10462_3339_3367(constructorSyntax), f_10462_3369_3416(f_10462_3369_3400(constructorSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 2262, 3429);

                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10462_2398_2427(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 2398, 2427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10462_2577_2606(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 2577, 2606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10462_2663_2692(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 2663, 2692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10462_2663_2705(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 2663, 2705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10462_2997_3019(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 2997, 3019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10462_3073_3095(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 3073, 3095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10462_3310_3337(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 3310, 3337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_3339_3367(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 3339, 3367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10462_3369_3400(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 3369, 3400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_3369_3416(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 3369, 3416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10462_3299_3417(Microsoft.CodeAnalysis.SyntaxTokenList
                startOpt, Microsoft.CodeAnalysis.SyntaxToken
                startFallbackOpt, Microsoft.CodeAnalysis.SyntaxToken
                endOpt)
                {
                    var return_v = CreateSpan(startOpt, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)startFallbackOpt, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)endOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 3299, 3417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 2262, 3429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 2262, 3429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TextSpan CreateSpan(SyntaxTokenList startOpt, SyntaxNodeOrToken startFallbackOpt, SyntaxNodeOrToken endOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 3441, 4433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3588, 3689);

                f_10462_3588_3688(startFallbackOpt != default(SyntaxNodeOrToken) || (DynAbs.Tracing.TraceSender.Expression_False(10462, 3601, 3687) || endOpt != default(SyntaxNodeOrToken)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3705, 3718);

                int
                startPos
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3732, 4091) || true) && (startOpt.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 3732, 4091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3788, 3826);

                    startPos = startOpt.First().SpanStart;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 3732, 4091);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 3732, 4091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3860, 4091) || true) && (startFallbackOpt != default(SyntaxNodeOrToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 3860, 4091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 3944, 3982);

                        startPos = startFallbackOpt.SpanStart;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 3860, 4091);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 3860, 4091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4048, 4076);

                        startPos = endOpt.SpanStart;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 3860, 4091);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 3732, 4091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4107, 4118);

                int
                endPos
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4132, 4361) || true) && (endOpt != default(SyntaxNodeOrToken))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 4132, 4361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4206, 4238);

                    endPos = f_10462_4215_4237(endOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 4132, 4361);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 4132, 4361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4304, 4346);

                    endPos = f_10462_4313_4345(startFallbackOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 4132, 4361);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4377, 4422);

                return TextSpan.FromBounds(startPos, endPos);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 3441, 4433);

                int
                f_10462_3588_3688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 3588, 3688);
                    return 0;
                }


                int
                f_10462_4215_4237(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = GetEndPosition(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 4215, 4237);
                    return return_v;
                }


                int
                f_10462_4313_4345(Microsoft.CodeAnalysis.SyntaxNodeOrToken
                nodeOrToken)
                {
                    var return_v = GetEndPosition(nodeOrToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 4313, 4345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 3441, 4433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 3441, 4433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetEndPosition(SyntaxNodeOrToken nodeOrToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 4445, 4763);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4534, 4752) || true) && (nodeOrToken.IsToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 4534, 4752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4591, 4619);

                    return nodeOrToken.Span.End;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 4534, 4752);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 4534, 4752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4685, 4737);

                    return f_10462_4692_4727(nodeOrToken.AsNode()).Span.End;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 4534, 4752);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 4445, 4763);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_4692_4727(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.GetLastToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 4692, 4727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 4445, 4763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 4445, 4763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GetBreakpointSpan(VariableDeclaratorSyntax declaratorSyntax, out SyntaxNode node, out TextSpan? part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 4775, 7235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 4922, 4997);

                var
                declarationSyntax = (VariableDeclarationSyntax)f_10462_4973_4996(declaratorSyntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5013, 7224) || true) && (declarationSyntax.Variables.First() == declaratorSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5013, 7224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5106, 6931);

                    switch (f_10462_5114_5145(f_10462_5114_5138(declarationSyntax)))
                    {

                        case SyntaxKind.EventFieldDeclaration:
                        case SyntaxKind.FieldDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5106, 6931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5306, 5387);

                            var
                            modifiers = f_10462_5322_5386(((BaseFieldDeclarationSyntax)f_10462_5351_5375(declarationSyntax)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5413, 5539);

                            f_10462_5413_5538((DynAbs.Tracing.TraceSender.Conditional_F1(10462, 5448, 5463) || ((modifiers.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(10462, 5466, 5478)) || DynAbs.Tracing.TraceSender.Conditional_F3(10462, 5481, 5499))) ? modifiers[0] : (SyntaxToken?)null, declaratorSyntax, out node, out part);
                            DynAbs.Tracing.TraceSender.TraceBreak(10462, 5565, 5571);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5106, 6931);

                        case SyntaxKind.LocalDeclarationStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5106, 6931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5763, 5834);

                            var
                            parent = (LocalDeclarationStatementSyntax)f_10462_5809_5833(declarationSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5860, 5898);

                            f_10462_5860_5897(!parent.Modifiers.Any());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 5924, 6157);

                            var
                            firstToken =
                            (DynAbs.Tracing.TraceSender.Conditional_F1(10462, 5970, 6000) || ((f_10462_5970_5989(parent) == default && DynAbs.Tracing.TraceSender.Conditional_F2(10462, 6003, 6021)) || DynAbs.Tracing.TraceSender.Conditional_F3(10462, 6053, 6156))) ? (SyntaxToken?)null : (DynAbs.Tracing.TraceSender.Conditional_F1(10462, 6053, 6083) || ((f_10462_6053_6072(parent) == default && DynAbs.Tracing.TraceSender.Conditional_F2(10462, 6086, 6105)) || DynAbs.Tracing.TraceSender.Conditional_F3(10462, 6137, 6156))) ? f_10462_6086_6105(parent) : f_10462_6137_6156(parent)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 6183, 6268);

                            f_10462_6183_6267(firstToken, declaratorSyntax, out node, out part);
                            DynAbs.Tracing.TraceSender.TraceBreak(10462, 6294, 6300);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5106, 6931);

                        case SyntaxKind.UsingStatement:
                        case SyntaxKind.FixedStatement:
                        case SyntaxKind.ForStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5106, 6931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 6614, 6639);

                            node = declarationSyntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 6665, 6748);

                            part = TextSpan.FromBounds(f_10462_6692_6719(declarationSyntax), declaratorSyntax.Span.End);
                            DynAbs.Tracing.TraceSender.TraceBreak(10462, 6774, 6780);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5106, 6931);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5106, 6931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 6838, 6912);

                            throw f_10462_6844_6911(f_10462_6879_6910(f_10462_6879_6903(declarationSyntax)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5106, 6931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5013, 7224);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 5013, 7224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7155, 7179);

                    node = declaratorSyntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7197, 7209);

                    part = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 5013, 7224);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 4775, 7235);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10462_4973_4996(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 4973, 4996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10462_5114_5138(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 5114, 5138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10462_5114_5145(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 5114, 5145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10462_5351_5375(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 5351, 5375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10462_5322_5386(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 5322, 5386);
                    return return_v;
                }


                int
                f_10462_5413_5538(Microsoft.CodeAnalysis.SyntaxToken?
                firstToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, out Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.Text.TextSpan?
                part)
                {
                    GetFirstLocalOrFieldBreakpointSpan(firstToken, declaratorSyntax, out node, out part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 5413, 5538);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10462_5809_5833(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 5809, 5833);
                    return return_v;
                }


                int
                f_10462_5860_5897(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 5860, 5897);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_5970_5989(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.UsingKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 5970, 5989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_6053_6072(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.AwaitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 6053, 6072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_6086_6105(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.UsingKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 6086, 6105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10462_6137_6156(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.AwaitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 6137, 6156);
                    return return_v;
                }


                int
                f_10462_6183_6267(Microsoft.CodeAnalysis.SyntaxToken?
                firstToken, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declaratorSyntax, out Microsoft.CodeAnalysis.SyntaxNode
                node, out Microsoft.CodeAnalysis.Text.TextSpan?
                part)
                {
                    GetFirstLocalOrFieldBreakpointSpan(firstToken, declaratorSyntax, out node, out part);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 6183, 6267);
                    return 0;
                }


                int
                f_10462_6692_6719(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 6692, 6719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10462_6879_6903(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 6879, 6903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10462_6879_6910(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 6879, 6910);
                    return return_v;
                }


                System.Exception
                f_10462_6844_6911(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 6844, 6911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 4775, 7235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 4775, 7235);
            }
        }

        internal static void GetFirstLocalOrFieldBreakpointSpan(SyntaxToken? firstToken, VariableDeclaratorSyntax declaratorSyntax, out SyntaxNode node, out TextSpan? part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 7247, 8235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7436, 7511);

                var
                declarationSyntax = (VariableDeclarationSyntax)f_10462_7487_7510(declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7609, 7674);

                int
                start = f_10462_7621_7642_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(firstToken, 10462, 7621, 7642)?.SpanStart) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10462, 7621, 7673) ?? f_10462_7646_7673(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7690, 7698);

                int
                end
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7712, 8123) || true) && (declarationSyntax.Variables.Count == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 7712, 8123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 7872, 7912);

                    end = f_10462_7878_7902(declarationSyntax).Span.End;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 7712, 8123);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 7712, 8123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8076, 8108);

                    end = declaratorSyntax.Span.End;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 7712, 8123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8139, 8178);

                part = TextSpan.FromBounds(start, end);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8192, 8224);

                node = f_10462_8199_8223(declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 7247, 8235);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10462_7487_7510(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 7487, 7510);
                    return return_v;
                }


                int?
                f_10462_7621_7642_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 7621, 7642);
                    return return_v;
                }


                int
                f_10462_7646_7673(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax?
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 7646, 7673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10462_7878_7902(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 7878, 7902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10462_8199_8223(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 8199, 8223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 7247, 8235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 7247, 8235);
            }
        }

        private static BoundExpression AddConditionSequencePoint(BoundExpression condition, SyntaxNode synthesizedVariableSyntax, SyntheticBoundNodeFactory factory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10462, 8247, 9671);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8428, 8548) || true) && (f_10462_8432_8482_M(!f_10462_8433_8460(f_10462_8433_8452(factory)).EnableEditAndContinue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10462, 8428, 8548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8516, 8533);

                    return condition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10462, 8428, 8548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 8792, 8931);

                var
                local = f_10462_8804_8930(factory, f_10462_8829_8843(condition), synthesizedVariableSyntax, kind: SynthesizedLocalKind.ConditionalBranchDiscriminator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 9142, 9349);

                var
                valueExpression = (DynAbs.Tracing.TraceSender.Conditional_F1(10462, 9164, 9197) || (((f_10462_9165_9188(condition) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10462, 9217, 9319)) || DynAbs.Tracing.TraceSender.Conditional_F3(10462, 9339, 9348))) ? f_10462_9217_9319(syntax: null, expression: f_10462_9276_9296(factory, local), type: f_10462_9304_9318(condition)) : condition
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10462, 9365, 9660);

                return f_10462_9372_9659(condition.Syntax, f_10462_9443_9471(local), f_10462_9490_9591(f_10462_9529_9590(factory, f_10462_9558_9578(factory, local), condition)), valueExpression, f_10462_9644_9658(condition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10462, 8247, 9671);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10462_8433_8452(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 8433, 8452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10462_8433_8460(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 8433, 8460);
                    return return_v;
                }


                bool
                f_10462_8432_8482_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 8432, 8482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10462_8829_8843(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 8829, 8843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10462_8804_8930(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = this_param.SynthesizedLocal(type, syntax, kind: kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 8804, 8930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10462_9165_9188(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 9165, 9188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10462_9276_9296(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9276, 9296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10462_9304_9318(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 9304, 9318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                f_10462_9217_9319(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression(syntax: syntax, expression: (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9217, 9319);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10462_9443_9471(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9443, 9471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10462_9558_9578(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9558, 9578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10462_9529_9590(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9529, 9590);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10462_9490_9591(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9490, 9591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10462_9644_9658(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10462, 9644, 9658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10462_9372_9659(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax, locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10462, 9372, 9659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10462, 8247, 9671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10462, 8247, 9671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
