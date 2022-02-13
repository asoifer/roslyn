// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter
    {
        public override BoundNode VisitWhileStatement(BoundWhileStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10534, 534, 1549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 630, 657);

                f_10534_630_656(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 673, 730);

                var
                rewrittenCondition = f_10534_698_729(this, f_10534_714_728(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 744, 790);

                var
                rewrittenBody = f_10534_764_789(this, f_10534_779_788(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 804, 839);

                f_10534_804_838(rewrittenBody is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 1063, 1266) || true) && (f_10534_1067_1093_M(!node.WasCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10534, 1067, 1112) && f_10534_1097_1112(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 1063, 1266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 1146, 1251);

                    rewrittenCondition = f_10534_1167_1250(_instrumenter, node, rewrittenCondition, _factory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 1063, 1266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 1282, 1538);

                return f_10534_1289_1537(this, node, f_10534_1352_1363(node), rewrittenCondition, rewrittenBody, f_10534_1451_1466(node), f_10534_1485_1503(node), f_10534_1522_1536(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10534, 534, 1549);

                int
                f_10534_630_656(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 630, 656);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10534_714_728(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 714, 728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10534_698_729(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 698, 729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_779_788(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 779, 788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10534_764_789(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.VisitStatement(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 764, 789);
                    return return_v;
                }


                int
                f_10534_804_838(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 804, 838);
                    return 0;
                }


                bool
                f_10534_1067_1093_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1067, 1093);
                    return return_v;
                }


                bool
                f_10534_1097_1112(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param)
                {
                    var return_v = this_param.Instrument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1097, 1112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10534_1167_1250(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                factory)
                {
                    var return_v = this_param.InstrumentWhileStatementCondition(original, rewrittenCondition, factory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 1167, 1250);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10534_1352_1363(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1352, 1363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10534_1451_1466(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1451, 1466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10534_1485_1503(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1485, 1503);
                    return return_v;
                }


                bool
                f_10534_1522_1536(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1522, 1536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_1289_1537(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                loop, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenBody, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel, bool
                hasErrors)
                {
                    var return_v = this_param.RewriteWhileStatement(loop, locals, rewrittenCondition, rewrittenBody, breakLabel, continueLabel, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 1289, 1537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10534, 534, 1549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10534, 534, 1549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement RewriteWhileStatement(
                    BoundLoopStatement loop,
                    BoundExpression rewrittenCondition,
                    BoundStatement rewrittenBody,
                    GeneratedLabelSymbol breakLabel,
                    GeneratedLabelSymbol continueLabel,
                    bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10534, 1561, 4210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 1885, 1980);

                f_10534_1885_1979(f_10534_1898_1907(loop) == BoundKind.WhileStatement || (DynAbs.Tracing.TraceSender.Expression_False(10534, 1898, 1978) || f_10534_1939_1948(loop) == BoundKind.ForEachStatement));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2330, 2362);

                SyntaxNode
                syntax = loop.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2376, 2427);

                var
                startLabel = f_10534_2393_2426("start")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2441, 2569);

                BoundStatement
                ifConditionGotoStart = f_10534_2479_2568(rewrittenCondition.Syntax, rewrittenCondition, true, startLabel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2583, 2659);

                BoundStatement
                gotoContinue = f_10534_2613_2658(syntax, continueLabel)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2675, 3835) || true) && (f_10534_2679_2694(this) && (DynAbs.Tracing.TraceSender.Expression_True(10534, 2679, 2724) && f_10534_2698_2724_M(!loop.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 2675, 3835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2758, 3421);

                    switch (f_10534_2766_2775(loop))
                    {

                        case BoundKind.WhileStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 2758, 3421);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 2873, 3011);

                            ifConditionGotoStart = f_10534_2896_3010(_instrumenter, loop, ifConditionGotoStart);
                            DynAbs.Tracing.TraceSender.TraceBreak(10534, 3037, 3043);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 2758, 3421);

                        case BoundKind.ForEachStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 2758, 3421);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 3125, 3260);

                            ifConditionGotoStart = f_10534_3148_3259(_instrumenter, loop, ifConditionGotoStart);
                            DynAbs.Tracing.TraceSender.TraceBreak(10534, 3286, 3292);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 2758, 3421);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 2758, 3421);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 3350, 3402);

                            throw f_10534_3356_3401(f_10534_3391_3400(loop));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 2758, 3421);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 3759, 3820);

                    gotoContinue = f_10534_3774_3819(gotoContinue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 2675, 3835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 3851, 4199);

                return f_10534_3858_4198(syntax, hasErrors, gotoContinue, f_10534_3956_3999(syntax, startLabel), rewrittenBody, f_10534_4050_4096(syntax, continueLabel), ifConditionGotoStart, f_10534_4154_4197(syntax, breakLabel));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10534, 1561, 4210);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10534_1898_1907(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1898, 1907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10534_1939_1948(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 1939, 1948);
                    return return_v;
                }


                int
                f_10534_1885_1979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 1885, 1979);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10534_2393_2426(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 2393, 2426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                f_10534_2479_2568(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                jumpIfTrue, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto(syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 2479, 2568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10534_2613_2658(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 2613, 2658);
                    return return_v;
                }


                bool
                f_10534_2679_2694(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param)
                {
                    var return_v = this_param.Instrument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 2679, 2694);
                    return return_v;
                }


                bool
                f_10534_2698_2724_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 2698, 2724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10534_2766_2775(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 2766, 2775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_2896_3010(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                ifConditionGotoStart)
                {
                    var return_v = this_param.InstrumentWhileStatementConditionalGotoStartOrBreak((Microsoft.CodeAnalysis.CSharp.BoundWhileStatement)original, ifConditionGotoStart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 2896, 3010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_3148_3259(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                branchBack)
                {
                    var return_v = this_param.InstrumentForEachStatementConditionalGotoStart((Microsoft.CodeAnalysis.CSharp.BoundForEachStatement)original, branchBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 3148, 3259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10534_3391_3400(Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 3391, 3400);
                    return return_v;
                }


                System.Exception
                f_10534_3356_3401(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 3356, 3401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_3774_3819(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = BoundSequencePoint.CreateHidden(statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 3774, 3819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10534_3956_3999(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 3956, 3999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10534_4050_4096(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 4050, 4096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10534_4154_4197(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 4154, 4197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10534_3858_4198(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                hasErrors, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = BoundStatementList.Synthesized(syntax, hasErrors, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 3858, 4198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10534, 1561, 4210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10534, 1561, 4210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement RewriteWhileStatement(
                    BoundWhileStatement loop,
                    ImmutableArray<LocalSymbol> locals,
                    BoundExpression rewrittenCondition,
                    BoundStatement rewrittenBody,
                    GeneratedLabelSymbol breakLabel,
                    GeneratedLabelSymbol continueLabel,
                    bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10534, 4222, 6415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 4596, 4771) || true) && (locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 4596, 4771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 4648, 4756);

                    return f_10534_4655_4755(this, loop, rewrittenCondition, rewrittenBody, breakLabel, continueLabel, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 4596, 4771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5278, 5310);

                SyntaxNode
                syntax = loop.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5324, 5411);

                BoundStatement
                continueLabelStatement = f_10534_5364_5410(syntax, continueLabel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5425, 5557);

                BoundStatement
                ifNotConditionGotoBreak = f_10534_5466_5556(rewrittenCondition.Syntax, rewrittenCondition, false, breakLabel)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5573, 5893) || true) && (f_10534_5577_5592(this) && (DynAbs.Tracing.TraceSender.Expression_True(10534, 5577, 5622) && f_10534_5596_5622_M(!loop.WasCompilerGenerated)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10534, 5573, 5893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5656, 5779);

                    ifNotConditionGotoBreak = f_10534_5682_5778(_instrumenter, loop, ifNotConditionGotoBreak);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5797, 5878);

                    continueLabelStatement = f_10534_5822_5877(continueLabelStatement);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10534, 5573, 5893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10534, 5909, 6404);

                return f_10534_5916_6403(syntax, hasErrors, continueLabelStatement, f_10534_6024_6340(syntax, locals, f_10534_6119_6339(ifNotConditionGotoBreak, rewrittenBody, f_10534_6293_6338(syntax, continueLabel))), f_10534_6359_6402(syntax, breakLabel));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10534, 4222, 6415);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_4655_4755(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                loop, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewrittenBody, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel, bool
                hasErrors)
                {
                    var return_v = this_param.RewriteWhileStatement((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)loop, rewrittenCondition, rewrittenBody, breakLabel, continueLabel, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 4655, 4755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10534_5364_5410(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 5364, 5410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                f_10534_5466_5556(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                jumpIfTrue, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto(syntax, condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 5466, 5556);
                    return return_v;
                }


                bool
                f_10534_5577_5592(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param)
                {
                    var return_v = this_param.Instrument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 5577, 5592);
                    return return_v;
                }


                bool
                f_10534_5596_5622_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10534, 5596, 5622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_5682_5778(Microsoft.CodeAnalysis.CSharp.Instrumenter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                ifConditionGotoStart)
                {
                    var return_v = this_param.InstrumentWhileStatementConditionalGotoStartOrBreak(original, ifConditionGotoStart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 5682, 5778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10534_5822_5877(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statementOpt)
                {
                    var return_v = BoundSequencePoint.CreateHidden(statementOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 5822, 5877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10534_6293_6338(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGotoStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 6293, 6338);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10534_6119_6339(Microsoft.CodeAnalysis.CSharp.BoundStatement
                item1, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item2, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                item3)
                {
                    var return_v = ImmutableArray.Create(item1, item2, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 6119, 6339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10534_6024_6340(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock(syntax, locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 6024, 6340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10534_6359_6402(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLabelStatement(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 6359, 6402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10534_5916_6403(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                hasErrors, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = BoundStatementList.Synthesized(syntax, hasErrors, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10534, 5916, 6403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10534, 4222, 6415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10534, 4222, 6415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
