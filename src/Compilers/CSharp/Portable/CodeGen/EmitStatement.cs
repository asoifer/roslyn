// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.CSharp.Binder;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private void EmitStatement(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 836, 4210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 913, 3995);

                switch (f_10967_921_935(statement))
                {

                    case BoundKind.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1012, 1045);

                        f_10967_1012_1044(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1067, 1073);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.Scope:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1136, 1169);

                        f_10967_1136_1168(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1191, 1197);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.SequencePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1268, 1331);

                        f_10967_1268_1330(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1353, 1359);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.SequencePointWithSpan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1438, 1509);

                        f_10967_1438_1508(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1531, 1537);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.SavePreviousSequencePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1620, 1698);

                        f_10967_1620_1697(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1720, 1726);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.RestorePreviousSequencePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 1812, 1896);

                        f_10967_1812_1895(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 1918, 1924);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.StepThroughSequencePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2006, 2082);

                        f_10967_2006_2081(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2104, 2110);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.ExpressionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2187, 2259);

                        f_10967_2187_2258(this, f_10967_2202_2250(((BoundExpressionStatement)statement)), false);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2281, 2287);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.StatementList:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2358, 2407);

                        f_10967_2358_2406(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2429, 2435);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.ReturnStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2508, 2561);

                        f_10967_2508_2560(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2583, 2589);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.GotoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2660, 2709);

                        f_10967_2660_2708(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2731, 2737);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.LabelStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2809, 2860);

                        f_10967_2809_2859(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 2882, 2888);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.ConditionalGoto:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 2961, 3014);

                        f_10967_2961_3013(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3036, 3042);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.ThrowStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3114, 3165);

                        f_10967_3114_3164(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3187, 3193);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.TryStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3263, 3310);

                        f_10967_3263_3309(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3332, 3338);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.SwitchDispatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3410, 3461);

                        f_10967_3410_3460(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3483, 3489);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.StateMachineScope:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3564, 3621);

                        f_10967_3564_3620(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3643, 3649);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    case BoundKind.NoOpStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3720, 3769);

                        f_10967_3720_3768(this, statement);
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 3791, 3797);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 913, 3995);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 3923, 3980);

                        throw f_10967_3929_3979(f_10967_3964_3978(statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 913, 3995);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4022, 4150) || true) && (_stackLocals == null || (DynAbs.Tracing.TraceSender.Expression_False(10967, 4026, 4073) || f_10967_4050_4068(_stackLocals) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4022, 4150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4107, 4135);

                    f_10967_4107_4134(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4022, 4150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4174, 4199);

                f_10967_4174_4198(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 836, 4210);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10967_921_935(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 921, 935);
                    return return_v;
                }


                int
                f_10967_1012_1044(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                block)
                {
                    this_param.EmitBlock((Microsoft.CodeAnalysis.CSharp.BoundBlock)block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1012, 1044);
                    return 0;
                }


                int
                f_10967_1136_1168(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                block)
                {
                    this_param.EmitScope((Microsoft.CodeAnalysis.CSharp.BoundScope)block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1136, 1168);
                    return 0;
                }


                int
                f_10967_1268_1330(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    this_param.EmitSequencePointStatement((Microsoft.CodeAnalysis.CSharp.BoundSequencePoint)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1268, 1330);
                    return 0;
                }


                int
                f_10967_1438_1508(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    this_param.EmitSequencePointStatement((Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1438, 1508);
                    return 0;
                }


                int
                f_10967_1620_1697(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitSavePreviousSequencePoint((Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1620, 1697);
                    return 0;
                }


                int
                f_10967_1812_1895(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    this_param.EmitRestorePreviousSequencePoint((Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 1812, 1895);
                    return 0;
                }


                int
                f_10967_2006_2081(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    this_param.EmitStepThroughSequencePoint((Microsoft.CodeAnalysis.CSharp.BoundStepThroughSequencePoint)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2006, 2081);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_2202_2250(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 2202, 2250);
                    return return_v;
                }


                int
                f_10967_2187_2258(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2187, 2258);
                    return 0;
                }


                int
                f_10967_2358_2406(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                list)
                {
                    this_param.EmitStatementList((Microsoft.CodeAnalysis.CSharp.BoundStatementList)list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2358, 2406);
                    return 0;
                }


                int
                f_10967_2508_2560(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundReturnStatement)
                {
                    this_param.EmitReturnStatement((Microsoft.CodeAnalysis.CSharp.BoundReturnStatement)boundReturnStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2508, 2560);
                    return 0;
                }


                int
                f_10967_2660_2708(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundGotoStatement)
                {
                    this_param.EmitGotoStatement((Microsoft.CodeAnalysis.CSharp.BoundGotoStatement)boundGotoStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2660, 2708);
                    return 0;
                }


                int
                f_10967_2809_2859(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundLabelStatement)
                {
                    this_param.EmitLabelStatement((Microsoft.CodeAnalysis.CSharp.BoundLabelStatement)boundLabelStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2809, 2859);
                    return 0;
                }


                int
                f_10967_2961_3013(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundConditionalGoto)
                {
                    this_param.EmitConditionalGoto((Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto)boundConditionalGoto);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 2961, 3013);
                    return 0;
                }


                int
                f_10967_3114_3164(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    this_param.EmitThrowStatement((Microsoft.CodeAnalysis.CSharp.BoundThrowStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3114, 3164);
                    return 0;
                }


                int
                f_10967_3263_3309(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitTryStatement((Microsoft.CodeAnalysis.CSharp.BoundTryStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3263, 3309);
                    return 0;
                }


                int
                f_10967_3410_3460(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                dispatch)
                {
                    this_param.EmitSwitchDispatch((Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch)dispatch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3410, 3460);
                    return 0;
                }


                int
                f_10967_3564_3620(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                scope)
                {
                    this_param.EmitStateMachineScope((Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope)scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3564, 3620);
                    return 0;
                }


                int
                f_10967_3720_3768(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitNoOpStatement((Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3720, 3768);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10967_3964_3978(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 3964, 3978);
                    return return_v;
                }


                System.Exception
                f_10967_3929_3979(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 3929, 3979);
                    return return_v;
                }


                int
                f_10967_4050_4068(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 4050, 4068);
                    return return_v;
                }


                int
                f_10967_4107_4134(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.AssertStackEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 4107, 4134);
                    return 0;
                }


                int
                f_10967_4174_4198(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.ReleaseExpressionTemps();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 4174, 4198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 836, 4210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 836, 4210);
            }
        }

        private int EmitStatementAndCountInstructions(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 4222, 4464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4318, 4355);

                int
                n = f_10967_4326_4354(_builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4369, 4399);

                f_10967_4369_4398(this, statement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4413, 4453);

                return f_10967_4420_4448(_builder) - n;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 4222, 4464);

                int
                f_10967_4326_4354(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.InstructionsEmitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 4326, 4354);
                    return return_v;
                }


                int
                f_10967_4369_4398(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 4369, 4398);
                    return 0;
                }


                int
                f_10967_4420_4448(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.InstructionsEmitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 4420, 4448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 4222, 4464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 4222, 4464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitStatementList(BoundStatementList list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 4476, 4704);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4565, 4570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4572, 4598);
                    for (int
        i = 0
        ,
        n = list.Statements.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4556, 4693) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4607, 4610)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4556, 4693))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4556, 4693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4644, 4678);

                        f_10967_4644_4677(this, f_10967_4658_4673(list)[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 4476, 4704);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10967_4658_4673(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 4658, 4673);
                    return return_v;
                }


                int
                f_10967_4644_4677(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 4644, 4677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 4476, 4704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 4476, 4704);
            }
        }

        private void EmitNoOpStatement(BoundNoOpStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 4716, 6198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4801, 6187);

                switch (f_10967_4809_4825(statement))
                {

                    case NoOpStatementFlavor.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4801, 6187);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 4914, 5058) || true) && (_ilEmitStyle == ILEmitStyle.Debug)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4914, 5058);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5001, 5035);

                            f_10967_5001_5034(_builder, ILOpCode.Nop);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4914, 5058);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 5080, 5086);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4801, 6187);

                    case NoOpStatementFlavor.AwaitYieldPoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4801, 6187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5169, 5243);

                        f_10967_5169_5242((_asyncYieldPoints == null) == (_asyncResumePoints == null));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5265, 5498) || true) && (_asyncYieldPoints == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 5265, 5498);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5344, 5396);

                            _asyncYieldPoints = f_10967_5364_5395();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5422, 5475);

                            _asyncResumePoints = f_10967_5443_5474();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 5265, 5498);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5520, 5586);

                        f_10967_5520_5585(f_10967_5533_5556(_asyncYieldPoints) == f_10967_5560_5584(_asyncResumePoints));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5608, 5659);

                        f_10967_5608_5658(_asyncYieldPoints, f_10967_5630_5657(_builder));
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 5681, 5687);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4801, 6187);

                    case NoOpStatementFlavor.AwaitResumePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4801, 6187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5771, 5811);

                        f_10967_5771_5810(_asyncYieldPoints != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5833, 5873);

                        f_10967_5833_5872(_asyncYieldPoints != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5895, 5947);

                        f_10967_5895_5946(_asyncResumePoints, f_10967_5918_5945(_builder));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 5969, 6035);

                        f_10967_5969_6034(f_10967_5982_6005(_asyncYieldPoints) == f_10967_6009_6033(_asyncResumePoints));
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 6057, 6063);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4801, 6187);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 4801, 6187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6113, 6172);

                        throw f_10967_6119_6171(f_10967_6154_6170(statement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 4801, 6187);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 4716, 6198);

                Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                f_10967_4809_4825(Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                this_param)
                {
                    var return_v = this_param.Flavor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 4809, 4825);
                    return return_v;
                }


                int
                f_10967_5001_5034(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5001, 5034);
                    return 0;
                }


                int
                f_10967_5169_5242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5169, 5242);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10967_5364_5395()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5364, 5395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_10967_5443_5474()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5443, 5474);
                    return return_v;
                }


                int
                f_10967_5533_5556(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 5533, 5556);
                    return return_v;
                }


                int
                f_10967_5560_5584(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>?
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 5560, 5584);
                    return return_v;
                }


                int
                f_10967_5520_5585(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5520, 5585);
                    return 0;
                }


                int
                f_10967_5630_5657(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AllocateILMarker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5630, 5657);
                    return return_v;
                }


                int
                f_10967_5608_5658(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5608, 5658);
                    return 0;
                }


                int
                f_10967_5771_5810(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5771, 5810);
                    return 0;
                }


                int
                f_10967_5833_5872(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5833, 5872);
                    return 0;
                }


                int
                f_10967_5918_5945(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AllocateILMarker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5918, 5945);
                    return return_v;
                }


                int
                f_10967_5895_5946(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5895, 5946);
                    return 0;
                }


                int
                f_10967_5982_6005(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 5982, 6005);
                    return return_v;
                }


                int
                f_10967_6009_6033(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6009, 6033);
                    return return_v;
                }


                int
                f_10967_5969_6034(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 5969, 6034);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                f_10967_6154_6170(Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                this_param)
                {
                    var return_v = this_param.Flavor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6154, 6170);
                    return return_v;
                }


                System.Exception
                f_10967_6119_6171(Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 6119, 6171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 4716, 6198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 4716, 6198);
            }
        }

        private void EmitThrowStatement(BoundThrowStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 6210, 6333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6292, 6322);

                f_10967_6292_6321(this, f_10967_6302_6320(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 6210, 6333);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_6302_6320(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6302, 6320);
                    return return_v;
                }


                int
                f_10967_6292_6321(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                thrown)
                {
                    this_param.EmitThrow(thrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 6292, 6321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 6210, 6333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 6210, 6333);
            }
        }

        private void EmitThrow(BoundExpression thrown)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 6345, 6870);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6416, 6797) || true) && (thrown != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 6416, 6797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6468, 6502);

                    f_10967_6468_6501(this, thrown, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6522, 6549);

                    var
                    exprType = f_10967_6537_6548(thrown)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6635, 6782) || true) && (f_10967_6639_6657_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(exprType, 10967, 6639, 6657)?.TypeKind) == TypeKind.TypeParameter)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 6635, 6782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6725, 6763);

                        f_10967_6725_6762(this, exprType, thrown.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 6635, 6782);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 6416, 6797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6813, 6859);

                f_10967_6813_6858(
                            _builder, isRethrow: thrown == null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 6345, 6870);

                int
                f_10967_6468_6501(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 6468, 6501);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_6537_6548(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6537, 6548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind?
                f_10967_6639_6657_M(Microsoft.CodeAnalysis.TypeKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6639, 6657);
                    return return_v;
                }


                int
                f_10967_6725_6762(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 6725, 6762);
                    return 0;
                }


                int
                f_10967_6813_6858(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                isRethrow)
                {
                    this_param.EmitThrow(isRethrow: isRethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 6813, 6858);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 6345, 6870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 6345, 6870);
            }
        }

        private void EmitConditionalGoto(BoundConditionalGoto boundConditionalGoto)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 6882, 7182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 6982, 7024);

                object
                label = f_10967_6997_7023(boundConditionalGoto)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7038, 7066);

                f_10967_7038_7065(label != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7080, 7171);

                f_10967_7080_7170(this, f_10967_7095_7125(boundConditionalGoto), ref label, f_10967_7138_7169(boundConditionalGoto));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 6882, 7182);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10967_6997_7023(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 6997, 7023);
                    return return_v;
                }


                int
                f_10967_7038_7065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 7038, 7065);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_7095_7125(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 7095, 7125);
                    return return_v;
                }


                bool
                f_10967_7138_7169(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.JumpIfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 7138, 7169);
                    return return_v;
                }


                int
                f_10967_7080_7170(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranch(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 7080, 7170);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 6882, 7182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 6882, 7182);
            }
        }

        private static bool CanPassToBrfalse(TypeSymbol ts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10967, 7478, 8437);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7554, 7685) || true) && (f_10967_7558_7573(ts))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 7554, 7685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7658, 7670);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 7554, 7685);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7701, 7731);

                var
                tc = f_10967_7710_7730(ts)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7745, 8426);

                switch (tc)
                {

                    case Microsoft.Cci.PrimitiveTypeCode.Float32:
                    case Microsoft.Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 7745, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 7919, 7932);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 7745, 8426);

                    case Microsoft.Cci.PrimitiveTypeCode.NotPrimitive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 7745, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8160, 8186);

                        return f_10967_8167_8185(ts);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 7745, 8426);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 7745, 8426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8236, 8296);

                        f_10967_8236_8295(tc != Microsoft.Cci.PrimitiveTypeCode.Invalid);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8318, 8375);

                        f_10967_8318_8374(tc != Microsoft.Cci.PrimitiveTypeCode.Void);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8399, 8411);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 7745, 8426);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10967, 7478, 8437);

                bool
                f_10967_7558_7573(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 7558, 7573);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10967_7710_7730(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 7710, 7730);
                    return return_v;
                }


                bool
                f_10967_8167_8185(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8167, 8185);
                    return return_v;
                }


                int
                f_10967_8236_8295(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 8236, 8295);
                    return 0;
                }


                int
                f_10967_8318_8374(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 8318, 8374);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 7478, 8437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 7478, 8437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression TryReduce(BoundBinaryOperator condition, ref bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10967, 8449, 10158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8561, 8608);

                var
                opKind = f_10967_8574_8607(f_10967_8574_8596(condition))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8624, 8739);

                f_10967_8624_8738(opKind == BinaryOperatorKind.Equal || (DynAbs.Tracing.TraceSender.Expression_False(10967, 8637, 8737) || opKind == BinaryOperatorKind.NotEqual));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8755, 8782);

                BoundExpression
                nonConstOp
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8796, 8885);

                BoundExpression
                constOp = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 8822, 8860) || (((f_10967_8823_8851(f_10967_8823_8837(condition)) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 8863, 8877)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 8880, 8884))) ? f_10967_8863_8877(condition) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8901, 9295) || true) && (constOp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 8901, 9295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 8954, 8983);

                    nonConstOp = f_10967_8967_8982(condition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 8901, 9295);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 8901, 9295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9049, 9124);

                    constOp = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 9059, 9098) || (((f_10967_9060_9089(f_10967_9060_9075(condition)) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 9101, 9116)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 9119, 9123))) ? f_10967_9101_9116(condition) : null;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9142, 9234) || true) && (constOp == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 9142, 9234);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9203, 9215);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 9142, 9234);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9252, 9280);

                    nonConstOp = f_10967_9265_9279(condition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 8901, 9295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9311, 9346);

                var
                nonConstType = f_10967_9330_9345(nonConstOp)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9360, 9456) || true) && (!f_10967_9365_9395(nonConstType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 9360, 9456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9429, 9441);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 9360, 9456);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9472, 9560);

                bool
                isBool = f_10967_9486_9516(nonConstType) == Microsoft.Cci.PrimitiveTypeCode.Boolean
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9574, 9625);

                bool
                isZero = f_10967_9588_9624(f_10967_9588_9609(constOp))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9719, 9802) || true) && (!isBool && (DynAbs.Tracing.TraceSender.Expression_True(10967, 9723, 9741) && !isZero))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 9719, 9802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9775, 9787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 9719, 9802);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9871, 9945) || true) && (isZero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 9871, 9945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 9915, 9930);

                    sense = !sense;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 9871, 9945);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 10008, 10113) || true) && (opKind == BinaryOperatorKind.NotEqual)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 10008, 10113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 10083, 10098);

                    sense = !sense;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 10008, 10113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 10129, 10147);

                return nonConstOp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10967, 8449, 10158);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_8574_8596(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8574, 8596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_8574_8607(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 8574, 8607);
                    return return_v;
                }


                int
                f_10967_8624_8738(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 8624, 8738);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_8823_8837(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8823, 8837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10967_8823_8851(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8823, 8851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_8863_8877(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8863, 8877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_8967_8982(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 8967, 8982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_9060_9075(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9060, 9075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10967_9060_9089(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9060, 9089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_9101_9116(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9101, 9116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_9265_9279(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9265, 9279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_9330_9345(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9330, 9345);
                    return return_v;
                }


                bool
                f_10967_9365_9395(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                ts)
                {
                    var return_v = CanPassToBrfalse(ts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 9365, 9395);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10967_9486_9516(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9486, 9516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10967_9588_9609(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9588, 9609);
                    return return_v;
                }


                bool
                f_10967_9588_9624(Microsoft.CodeAnalysis.ConstantValue?
                this_param)
                {
                    var return_v = this_param.IsDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 9588, 9624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 8449, 10158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 8449, 10158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        IL_OP_CODE_ROW_LENGTH = 4
        ;

        private static readonly ILOpCode[] s_condJumpOpCodes;

        private static ILOpCode CodeForJump(BoundBinaryOperator op, bool sense, out ILOpCode revOpCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10967, 11203, 13054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11323, 11333);

                int
                opIdx
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11349, 12390);

                switch (f_10967_11357_11383(f_10967_11357_11372(op)))
                {

                    case BinaryOperatorKind.Equal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11469, 11521);

                        revOpCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 11481, 11487) || ((!sense && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 11490, 11502)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 11505, 11520))) ? ILOpCode.Beq : ILOpCode.Bne_un;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11543, 11589);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 11550, 11555) || ((sense && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 11558, 11570)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 11573, 11588))) ? ILOpCode.Beq : ILOpCode.Bne_un;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11664, 11716);

                        revOpCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 11676, 11682) || ((!sense && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 11685, 11700)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 11703, 11715))) ? ILOpCode.Bne_un : ILOpCode.Beq;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11738, 11784);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 11745, 11750) || ((sense && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 11753, 11768)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 11771, 11783))) ? ILOpCode.Bne_un : ILOpCode.Beq;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    case BinaryOperatorKind.LessThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11859, 11869);

                        opIdx = 0;
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 11891, 11897);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 11979, 11989);

                        opIdx = 1;
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 12011, 12017);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    case BinaryOperatorKind.GreaterThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12095, 12105);

                        opIdx = 2;
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 12127, 12133);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    case BinaryOperatorKind.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12218, 12228);

                        opIdx = 3;
                        DynAbs.Tracing.TraceSender.TraceBreak(10967, 12250, 12256);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 11349, 12390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12306, 12375);

                        throw f_10967_12312_12374(f_10967_12347_12373(f_10967_12347_12362(op)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 11349, 12390);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12406, 12673) || true) && (f_10967_12410_12438(op))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 12406, 12673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12472, 12507);

                    opIdx += 2 * IL_OP_CODE_ROW_LENGTH;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 12406, 12673);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 12406, 12673);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12552, 12673) || true) && (f_10967_12556_12580(f_10967_12564_12579(op)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 12552, 12673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12614, 12649);

                        opIdx += 4 * IL_OP_CODE_ROW_LENGTH;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 12552, 12673);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 12406, 12673);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12689, 12710);

                int
                revOpIdx = opIdx
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12726, 12941) || true) && (!sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 12726, 12941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12770, 12801);

                    opIdx += IL_OP_CODE_ROW_LENGTH;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 12726, 12941);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 12726, 12941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12879, 12913);

                    revOpIdx += IL_OP_CODE_ROW_LENGTH;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 12726, 12941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 12957, 12997);

                revOpCode = s_condJumpOpCodes[revOpIdx];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13011, 13043);

                return s_condJumpOpCodes[opIdx];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10967, 11203, 13054);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_11357_11372(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 11357, 11372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_11357_11383(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 11357, 11383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_12347_12362(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 12347, 12362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_12347_12373(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 12347, 12373);
                    return return_v;
                }


                System.Exception
                f_10967_12312_12374(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 12312, 12374);
                    return return_v;
                }


                bool
                f_10967_12410_12438(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                op)
                {
                    var return_v = IsUnsignedBinaryOperator(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 12410, 12438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10967_12564_12579(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 12564, 12579);
                    return return_v;
                }


                bool
                f_10967_12556_12580(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind)
                {
                    var return_v = IsFloat(opKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 12556, 12580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 11203, 13054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 11203, 13054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitCondBranch(BoundExpression condition, ref object dest, bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 13134, 13646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13242, 13260);

                _recursionDepth++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13276, 13601) || true) && (_recursionDepth > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 13276, 13601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13333, 13392);

                    f_10967_13333_13391(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13412, 13459);

                    f_10967_13412_13458(this, condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 13276, 13601);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 13276, 13601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13525, 13586);

                    f_10967_13525_13585(this, condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 13276, 13601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13617, 13635);

                _recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 13134, 13646);

                int
                f_10967_13333_13391(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13333, 13391);
                    return 0;
                }


                int
                f_10967_13412_13458(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranchCore(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13412, 13458);
                    return 0;
                }


                int
                f_10967_13525_13585(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranchCoreWithStackGuard(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13525, 13585);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 13134, 13646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 13134, 13646);
            }
        }

        private void EmitCondBranchCoreWithStackGuard(BoundExpression condition, ref object dest, bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 13658, 14342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13784, 13819);

                f_10967_13784_13818(_recursionDepth == 1);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13871, 13918);

                    f_10967_13871_13917(this, condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 13936, 13971);

                    f_10967_13936_13970(_recursionDepth == 1);
                }
                catch (InsufficientExecutionStackException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10967, 14000, 14331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 14076, 14263);

                    f_10967_14076_14262(_diagnostics, ErrorCode.ERR_InsufficientStack, f_10967_14160_14261(condition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 14281, 14316);

                    throw f_10967_14287_14315();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10967, 14000, 14331);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 13658, 14342);

                int
                f_10967_13784_13818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13784, 13818);
                    return 0;
                }


                int
                f_10967_13871_13917(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranchCore(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13871, 13917);
                    return 0;
                }


                int
                f_10967_13936_13970(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 13936, 13970);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10967_14160_14261(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = BoundTreeVisitor.CancelledByStackGuardException.GetTooLongOrComplexExpressionErrorLocation((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 14160, 14261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10967_14076_14262(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 14076, 14262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.EmitCancelledException
                f_10967_14287_14315()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.EmitCancelledException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 14287, 14315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 13658, 14342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 13658, 14342);
            }
        }

        private void EmitCondBranchCore(BoundExpression condition, ref object dest, bool sense)
        {
oneMoreTime:

            ILOpCode ilcode;

            if (condition.ConstantValue != null)
            {
                bool taken = condition.ConstantValue.IsDefaultValue != sense;

                if (taken)
                {
                    dest = dest ?? new object();
                    _builder.EmitBranch(ILOpCode.Br, dest);
                }
                else
                {
                    // otherwise this branch will never be taken, so just fall through...
                }

                return;
            }

            switch (condition.Kind)
            {
                case BoundKind.BinaryOperator:
                    var binOp = (BoundBinaryOperator)condition;
                    bool testBothArgs = sense;

                    switch (binOp.OperatorKind.OperatorWithLogical())
                    {
                        case BinaryOperatorKind.LogicalOr:
                            testBothArgs = !testBothArgs;
                            // Fall through
                            goto case BinaryOperatorKind.LogicalAnd;

                        case BinaryOperatorKind.LogicalAnd:
                            if (testBothArgs)
                            {
                                // gotoif(a != sense) fallThrough
                                // gotoif(b == sense) dest
                                // fallThrough:

                                object fallThrough = null;

                                EmitCondBranch(binOp.Left, ref fallThrough, !sense);
                                EmitCondBranch(binOp.Right, ref dest, sense);

                                if (fallThrough != null)
                                {
                                    _builder.MarkLabel(fallThrough);
                                }
                            }
                            else
                            {
                                // gotoif(a == sense) labDest
                                // gotoif(b == sense) labDest

                                EmitCondBranch(binOp.Left, ref dest, sense);
                                condition = binOp.Right;
                                goto oneMoreTime;
                            }
                            return;

                        case BinaryOperatorKind.Equal:
                        case BinaryOperatorKind.NotEqual:
                            var reduced = TryReduce(binOp, ref sense);
                            if (reduced != null)
                            {
                                condition = reduced;
                                goto oneMoreTime;
                            }
                            // Fall through
                            goto case BinaryOperatorKind.LessThan;

                        case BinaryOperatorKind.LessThan:
                        case BinaryOperatorKind.LessThanOrEqual:
                        case BinaryOperatorKind.GreaterThan:
                        case BinaryOperatorKind.GreaterThanOrEqual:
                            EmitExpression(binOp.Left, true);
                            EmitExpression(binOp.Right, true);
                            ILOpCode revOpCode;
                            ilcode = CodeForJump(binOp, sense, out revOpCode);
                            dest = dest ?? new object();
                            _builder.EmitBranch(ilcode, dest, revOpCode);
                            return;
                    }

                    // none of above. 
                    // then it is regular binary expression - Or, And, Xor ...
                    goto default;

                case BoundKind.LoweredConditionalAccess:
                    {
                        var ca = (BoundLoweredConditionalAccess)condition;
                        var receiver = ca.Receiver;
                        var receiverType = receiver.Type;

                        // we need a copy if we deal with nonlocal value (to capture the value)
                        // or if we deal with stack local (reads are destructive)
                        var complexCase = !receiverType.IsReferenceType ||
                                          LocalRewriter.CanChangeValueBetweenReads(receiver, localsMayBeAssignedOrCaptured: false) ||
                                          (receiver.Kind == BoundKind.Local && IsStackLocal(((BoundLocal)receiver).LocalSymbol)) ||
                                          (ca.WhenNullOpt?.IsDefaultValue() == false);

                        if (complexCase)
                        {
                            goto default;
                        }

                        if (sense)
                        {
                            // gotoif(receiver != null) fallThrough
                            // gotoif(receiver.Access) dest
                            // fallThrough:

                            object fallThrough = null;

                            EmitCondBranch(receiver, ref fallThrough, sense: false);
                            // receiver is a reference type, and we only intend to read it
                            EmitReceiverRef(receiver, AddressKind.ReadOnly);
                            EmitCondBranch(ca.WhenNotNull, ref dest, sense: true);

                            if (fallThrough != null)
                            {
                                _builder.MarkLabel(fallThrough);
                            }
                        }
                        else
                        {
                            // gotoif(receiver == null) labDest
                            // gotoif(!receiver.Access) labDest
                            EmitCondBranch(receiver, ref dest, sense: false);
                            // receiver is a reference type, and we only intend to read it
                            EmitReceiverRef(receiver, AddressKind.ReadOnly);
                            condition = ca.WhenNotNull;
                            goto oneMoreTime;
                        }
                    }
                    return;

                case BoundKind.UnaryOperator:
                    var unOp = (BoundUnaryOperator)condition;
                    if (unOp.OperatorKind == UnaryOperatorKind.BoolLogicalNegation)
                    {
                        sense = !sense;
                        condition = unOp.Operand;
                        goto oneMoreTime;
                    }
                    goto default;

                case BoundKind.IsOperator:
                    var isOp = (BoundIsOperator)condition;
                    var operand = isOp.Operand;
                    EmitExpression(operand, true);
                    Debug.Assert((object)operand.Type != null);
                    if (!operand.Type.IsVerifierReference())
                    {
                        // box the operand for isinst if it is not a verifier reference
                        EmitBox(operand.Type, operand.Syntax);
                    }
                    _builder.EmitOpCode(ILOpCode.Isinst);
                    EmitSymbolToken(isOp.TargetType.Type, isOp.TargetType.Syntax);
                    ilcode = sense ? ILOpCode.Brtrue : ILOpCode.Brfalse;
                    dest = dest ?? new object();
                    _builder.EmitBranch(ilcode, dest);
                    return;

                case BoundKind.Sequence:
                    var seq = (BoundSequence)condition;
                    EmitSequenceCondBranch(seq, ref dest, sense);
                    return;

                default:
                    EmitExpression(condition, true);

                    var conditionType = condition.Type;
                    if (conditionType.IsReferenceType && !conditionType.IsVerifierReference())
                    {
                        EmitBox(conditionType, condition.Syntax);
                    }

                    ilcode = sense ? ILOpCode.Brtrue : ILOpCode.Brfalse;
                    dest = dest ?? new object();
                    _builder.EmitBranch(ilcode, dest);
                    return;
            }
        }

        private void EmitSequenceCondBranch(BoundSequence sequence, ref object dest, bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 22759, 23113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 22872, 22895);

                f_10967_22872_22894(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 22909, 22935);

                f_10967_22909_22934(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 22949, 22997);

                f_10967_22949_22996(this, f_10967_22964_22978(sequence), ref dest, sense);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 23081, 23102);

                f_10967_23081_23101(this, sequence);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 22759, 23113);

                int
                f_10967_22872_22894(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.DefineLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 22872, 22894);
                    return 0;
                }


                int
                f_10967_22909_22934(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.EmitSideEffects(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 22909, 22934);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_22964_22978(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 22964, 22978);
                    return return_v;
                }


                int
                f_10967_22949_22996(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranch(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 22949, 22996);
                    return 0;
                }


                int
                f_10967_23081_23101(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.FreeLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 23081, 23101);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 22759, 23113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 22759, 23113);
            }
        }

        private void EmitLabelStatement(BoundLabelStatement boundLabelStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 23125, 23279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 23222, 23268);

                f_10967_23222_23267(_builder, f_10967_23241_23266(boundLabelStatement));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 23125, 23279);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10967_23241_23266(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 23241, 23266);
                    return return_v;
                }


                int
                f_10967_23222_23267(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.MarkLabel((object)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 23222, 23267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 23125, 23279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 23125, 23279);
            }
        }

        private void EmitGotoStatement(BoundGotoStatement boundGotoStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 23291, 23455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 23385, 23444);

                f_10967_23385_23443(_builder, ILOpCode.Br, f_10967_23418_23442(boundGotoStatement));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 23291, 23455);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10967_23418_23442(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 23418, 23442);
                    return return_v;
                }


                int
                f_10967_23385_23443(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    this_param.EmitBranch(code, (object)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 23385, 23443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 23291, 23455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 23291, 23455);
            }
        }

        private bool IsLastBlockInMethod(BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 23833, 24382);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 23908, 23992) || true) && (_boundBody == block)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 23908, 23992);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 23965, 23977);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 23908, 23992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24163, 24207);

                var
                list = _boundBody as BoundStatementList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24221, 24342) || true) && (list != null && (DynAbs.Tracing.TraceSender.Expression_True(10967, 24225, 24281) && list.Statements.LastOrDefault() == block))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 24221, 24342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24315, 24327);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 24221, 24342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24358, 24371);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 23833, 24382);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 23833, 24382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 23833, 24382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitBlock(BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 24394, 25639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24459, 24497);

                var
                hasLocals = f_10967_24475_24496_M(!block.Locals.IsEmpty)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24513, 25161) || true) && (hasLocals)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 24513, 25161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24560, 24586);

                    f_10967_24560_24585(_builder);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24606, 25146);
                        foreach (var local in f_10967_24628_24640_I(f_10967_24628_24640(block)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 24606, 25146);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24682, 24904);

                            f_10967_24682_24903(f_10967_24695_24708(local) == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10967, 24695, 24763) || f_10967_24728_24763(f_10967_24728_24749(local))), "A ref local ended up in a block and claims it is shortlived. That is dangerous. Are we sure it is short lived?");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 24928, 24986);

                            var
                            declaringReferences = f_10967_24954_24985(local)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25008, 25127);

                            f_10967_25008_25126(this, local, (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 25027, 25055) || ((f_10967_25027_25055_M(!declaringReferences.IsEmpty) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 25058, 25110)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 25113, 25125))) ? (CSharpSyntaxNode)f_10967_25076_25110(declaringReferences[0]) : block.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 24606, 25146);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 541);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 541);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 24513, 25161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25177, 25210);

                f_10967_25177_25209(this, f_10967_25192_25208(block));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25226, 25391) || true) && (_indirectReturnState == IndirectReturnState.Needed && (DynAbs.Tracing.TraceSender.Expression_True(10967, 25230, 25327) && f_10967_25301_25327(this, block)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 25226, 25391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25361, 25376);

                    f_10967_25361_25375(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 25226, 25391);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25407, 25628) || true) && (hasLocals)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 25407, 25628);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25454, 25566);
                        foreach (var local in f_10967_25476_25488_I(f_10967_25476_25488(block)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 25454, 25566);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25530, 25547);

                            f_10967_25530_25546(this, local);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 25454, 25566);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 113);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 113);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25586, 25613);

                    f_10967_25586_25612(
                                    _builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 25407, 25628);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 24394, 25639);

                bool
                f_10967_24475_24496_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 24475, 24496);
                    return return_v;
                }


                int
                f_10967_24560_24585(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.OpenLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 24560, 24585);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_24628_24640(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 24628, 24640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_24695_24708(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 24695, 24708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_24728_24749(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 24728, 24749);
                    return return_v;
                }


                bool
                f_10967_24728_24763(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 24728, 24763);
                    return return_v;
                }


                int
                f_10967_24682_24903(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 24682, 24903);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10967_24954_24985(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 24954, 24985);
                    return return_v;
                }


                bool
                f_10967_25027_25055_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 25027, 25055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10967_25076_25110(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25076, 25110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_25008_25126(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.DefineLocal(local, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25008, 25126);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_24628_24640_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 24628, 24640);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10967_25192_25208(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 25192, 25208);
                    return return_v;
                }


                int
                f_10967_25177_25209(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.EmitStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25177, 25209);
                    return 0;
                }


                bool
                f_10967_25301_25327(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    var return_v = this_param.IsLastBlockInMethod(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25301, 25327);
                    return return_v;
                }


                int
                f_10967_25361_25375(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.HandleReturn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25361, 25375);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_25476_25488(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 25476, 25488);
                    return return_v;
                }


                int
                f_10967_25530_25546(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.FreeLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25530, 25546);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_25476_25488_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25476, 25488);
                    return return_v;
                }


                int
                f_10967_25586_25612(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25586, 25612);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 24394, 25639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 24394, 25639);
            }
        }

        private void EmitStatements(ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 25651, 25867);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25746, 25856);
                    foreach (var statement in f_10967_25772_25782_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 25746, 25856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25816, 25841);

                        f_10967_25816_25840(this, statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 25746, 25856);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 25651, 25867);

                int
                f_10967_25816_25840(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25816, 25840);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10967_25772_25782_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25772, 25782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 25651, 25867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 25651, 25867);
            }
        }

        private void EmitScope(BoundScope block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 25879, 26693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25944, 25980);

                f_10967_25944_25979(f_10967_25957_25978_M(!block.Locals.IsEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 25996, 26022);

                f_10967_25996_26021(
                            _builder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26038, 26590);
                    foreach (var local in f_10967_26060_26072_I(f_10967_26060_26072(block)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 26038, 26590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26106, 26139);

                        f_10967_26106_26138(f_10967_26119_26129(local) != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26157, 26386);

                        f_10967_26157_26385(f_10967_26170_26191(local) == SynthesizedLocalKind.UserDefined && (DynAbs.Tracing.TraceSender.Expression_True(10967, 26170, 26384) && (f_10967_26278_26285(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10967_26253_26277(local), 10967, 26253, 26285)) == SyntaxKind.SwitchSection || (DynAbs.Tracing.TraceSender.Expression_False(10967, 26253, 26383) || f_10967_26342_26349(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10967_26317_26341(local), 10967, 26317, 26349)) == SyntaxKind.SwitchExpressionArm))));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26404, 26575) || true) && (f_10967_26408_26422_M(!local.IsConst) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 26408, 26446) && !f_10967_26427_26446(this, local)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 26404, 26575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26488, 26556);

                            f_10967_26488_26555(_builder, f_10967_26513_26554(_builder.LocalSlotManager, local));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 26404, 26575);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 26038, 26590);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26606, 26639);

                f_10967_26606_26638(this, f_10967_26621_26637(block));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26655, 26682);

                f_10967_26655_26681(
                            _builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 25879, 26693);

                bool
                f_10967_25957_25978_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 25957, 25978);
                    return return_v;
                }


                int
                f_10967_25944_25979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25944, 25979);
                    return 0;
                }


                int
                f_10967_25996_26021(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.OpenLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 25996, 26021);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_26060_26072(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26060, 26072);
                    return return_v;
                }


                string
                f_10967_26119_26129(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26119, 26129);
                    return return_v;
                }


                int
                f_10967_26106_26138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26106, 26138);
                    return 0;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_26170_26191(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26170, 26191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10967_26253_26277(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26253, 26277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10967_26278_26285(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26278, 26285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10967_26317_26341(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26317, 26341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10967_26342_26349(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26342, 26349);
                    return return_v;
                }


                int
                f_10967_26157_26385(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26157, 26385);
                    return 0;
                }


                bool
                f_10967_26408_26422_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26408, 26422);
                    return return_v;
                }


                bool
                f_10967_26427_26446(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26427, 26446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_26513_26554(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetLocal((Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26513, 26554);
                    return return_v;
                }


                int
                f_10967_26488_26555(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.AddLocalToScope(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26488, 26555);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_26060_26072_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26060, 26072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10967_26621_26637(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26621, 26637);
                    return return_v;
                }


                int
                f_10967_26606_26638(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.EmitStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26606, 26638);
                    return 0;
                }


                int
                f_10967_26655_26681(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26655, 26681);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 25879, 26693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 25879, 26693);
            }
        }

        private void EmitStateMachineScope(BoundStateMachineScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 26705, 27114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26794, 26850);

                f_10967_26794_26849(_builder, ScopeType.StateMachineVariable);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26864, 27015);
                    foreach (var field in f_10967_26886_26898_I(f_10967_26886_26898(scope)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 26864, 27015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 26932, 27000);

                        f_10967_26932_26999(_builder, field.SlotIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 26864, 27015);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 27031, 27062);

                f_10967_27031_27061(this, f_10967_27045_27060(scope));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 27076, 27103);

                f_10967_27076_27102(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 26705, 27114);

                int
                f_10967_26794_26849(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType)
                {
                    this_param.OpenLocalScope(scopeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26794, 26849);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10967_26886_26898(Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                this_param)
                {
                    var return_v = this_param.Fields;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 26886, 26898);
                    return return_v;
                }


                int
                f_10967_26932_26999(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                slotIndex)
                {
                    this_param.DefineUserDefinedStateMachineHoistedLocal(slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26932, 26999);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                f_10967_26886_26898_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.StateMachineFieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 26886, 26898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10967_27045_27060(Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 27045, 27060);
                    return return_v;
                }


                int
                f_10967_27031_27061(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.EmitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 27031, 27061);
                    return 0;
                }


                int
                f_10967_27076_27102(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 27076, 27102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 26705, 27114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 26705, 27114);
            }
        }

        private bool ShouldUseIndirectReturn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 27498, 28533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 28280, 28522);

                return _ilEmitStyle == ILEmitStyle.Debug && (DynAbs.Tracing.TraceSender.Expression_True(10967, 28287, 28349) && f_10967_28324_28349(_method)) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 28287, 28403) && _methodBodySyntaxOpt is not null) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 28287, 28470) && f_10967_28425_28470(_methodBodySyntaxOpt, SyntaxKind.Block)) || (DynAbs.Tracing.TraceSender.Expression_False(10967, 28287, 28521) || f_10967_28494_28521(_builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 27498, 28533);

                bool
                f_10967_28324_28349(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GenerateDebugInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 28324, 28349);
                    return return_v;
                }


                bool
                f_10967_28425_28470(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 28425, 28470);
                    return return_v;
                }


                bool
                f_10967_28494_28521(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.InExceptionHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 28494, 28521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 27498, 28533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 27498, 28533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CanHandleReturnLabel(BoundReturnStatement boundReturnStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 28896, 29231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 28997, 29220);

                return f_10967_29004_29045(boundReturnStatement) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 29004, 29166) && (f_10967_29071_29123(boundReturnStatement.Syntax, SyntaxKind.Block) || (DynAbs.Tracing.TraceSender.Expression_False(10967, 29071, 29165) || f_10967_29127_29157_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_method, 10967, 29127, 29157)?.IsImplicitConstructor) == true))) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 29004, 29219) && f_10967_29191_29219_M(!_builder.InExceptionHandler));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 28896, 29231);

                bool
                f_10967_29004_29045(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29004, 29045);
                    return return_v;
                }


                bool
                f_10967_29071_29123(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = node.IsKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 29071, 29123);
                    return return_v;
                }


                bool?
                f_10967_29127_29157_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29127, 29157);
                    return return_v;
                }


                bool
                f_10967_29191_29219_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29191, 29219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 28896, 29231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 28896, 29231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitReturnStatement(BoundReturnStatement boundReturnStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 29243, 31619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29343, 29398);

                var
                expressionOpt = f_10967_29363_29397(boundReturnStatement)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29412, 29975) || true) && (f_10967_29416_29444(boundReturnStatement) == RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 29412, 29975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29494, 29535);

                    f_10967_29494_29534(this, expressionOpt, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 29412, 29975);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 29412, 29975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29729, 29880);

                    var
                    unexpectedTemp = f_10967_29750_29879(this, expressionOpt, (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 29782, 29825) || ((f_10967_29782_29802(this._method) == RefKind.RefReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 29828, 29854)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 29857, 29878))) ? AddressKind.ReadOnlyStrict : AddressKind.Writeable)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29898, 29960);

                    f_10967_29898_29959(unexpectedTemp == null, "ref-returning a temp?");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 29412, 29975);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 29991, 31608) || true) && (f_10967_29995_30020(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 29991, 31608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30054, 30180) || true) && (expressionOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30054, 30180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30121, 30161);

                        f_10967_30121_30160(_builder, f_10967_30145_30159());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30054, 30180);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30200, 30711) || true) && (_indirectReturnState != IndirectReturnState.Emitted && (DynAbs.Tracing.TraceSender.Expression_True(10967, 30204, 30301) && f_10967_30259_30301(this, boundReturnStatement)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30200, 30711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30343, 30358);

                        f_10967_30343_30357(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30200, 30711);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30200, 30711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30440, 30488);

                        f_10967_30440_30487(_builder, ILOpCode.Br, s_returnLabel);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30512, 30692) || true) && (_indirectReturnState == IndirectReturnState.NotNeeded)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30512, 30692);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30619, 30669);

                            _indirectReturnState = IndirectReturnState.Needed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30512, 30692);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30200, 30711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 29991, 31608);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 29991, 31608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30777, 31593) || true) && (_indirectReturnState == IndirectReturnState.Needed && (DynAbs.Tracing.TraceSender.Expression_True(10967, 30781, 30877) && f_10967_30835_30877(this, boundReturnStatement)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30777, 31593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30919, 31057) || true) && (expressionOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30919, 31057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 30994, 31034);

                            f_10967_30994_31033(_builder, f_10967_31018_31032());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30919, 31057);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31081, 31096);

                        f_10967_31081_31095(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30777, 31593);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 30777, 31593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31178, 31512) || true) && (expressionOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 31178, 31512);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31408, 31489);

                            f_10967_31408_31488(                        // Ensure the return type has been translated. (Necessary
                                                                        // for cases of untranslated anonymous types.)
                                                    _module, f_10967_31426_31444(expressionOpt), boundReturnStatement.Syntax, _diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 31178, 31512);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31534, 31574);

                        f_10967_31534_31573(_builder, expressionOpt == null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 30777, 31593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 29991, 31608);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 29243, 31619);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_29363_29397(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29363, 29397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_29416_29444(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29416, 29444);
                    return return_v;
                }


                int
                f_10967_29494_29534(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 29494, 29534);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_29782_29802(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 29782, 29802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_29750_29879(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 29750, 29879);
                    return return_v;
                }


                int
                f_10967_29898_29959(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 29898, 29959);
                    return 0;
                }


                bool
                f_10967_29995_30020(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    var return_v = this_param.ShouldUseIndirectReturn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 29995, 30020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_30145_30159()
                {
                    var return_v = LazyReturnTemp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 30145, 30159);
                    return return_v;
                }


                int
                f_10967_30121_30160(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30121, 30160);
                    return 0;
                }


                bool
                f_10967_30259_30301(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                boundReturnStatement)
                {
                    var return_v = this_param.CanHandleReturnLabel(boundReturnStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30259, 30301);
                    return return_v;
                }


                int
                f_10967_30343_30357(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.HandleReturn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30343, 30357);
                    return 0;
                }


                int
                f_10967_30440_30487(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30440, 30487);
                    return 0;
                }


                bool
                f_10967_30835_30877(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                boundReturnStatement)
                {
                    var return_v = this_param.CanHandleReturnLabel(boundReturnStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30835, 30877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_31018_31032()
                {
                    var return_v = LazyReturnTemp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 31018, 31032);
                    return return_v;
                }


                int
                f_10967_30994_31033(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 30994, 31033);
                    return 0;
                }


                int
                f_10967_31081_31095(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.HandleReturn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 31081, 31095);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_31426_31444(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 31426, 31444);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10967_31408_31488(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 31408, 31488);
                    return return_v;
                }


                int
                f_10967_31534_31573(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                isVoid)
                {
                    this_param.EmitRet(isVoid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 31534, 31573);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 29243, 31619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 29243, 31619);
            }
        }

        private void EmitTryStatement(BoundTryStatement statement, bool emitCatchesOnly = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 31631, 34416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31744, 31791);

                f_10967_31744_31790(f_10967_31757_31789_M(!statement.CatchBlocks.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 31870, 31898);

                f_10967_31870_31897(
                            // Stack must be empty at beginning of try block.
                            _builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32108, 32262);

                bool
                emitNestedScopes = (!emitCatchesOnly && (DynAbs.Tracing.TraceSender.Expression_True(10967, 32133, 32204) && (statement.CatchBlocks.Length > 0)) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 32133, 32260) && (f_10967_32226_32251(statement) != null)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32278, 32329);

                f_10967_32278_32328(
                            _builder, ScopeType.TryCatchFinally);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32345, 32384);

                f_10967_32345_32383(
                            _builder, ScopeType.Try);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32594, 32613);

                _tryNestingLevel++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32627, 32843) || true) && (emitNestedScopes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 32627, 32843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32681, 32732);

                    f_10967_32681_32731(this, statement, emitCatchesOnly: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 32627, 32843);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 32627, 32843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32798, 32828);

                    f_10967_32798_32827(this, f_10967_32808_32826(statement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 32627, 32843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32859, 32878);

                _tryNestingLevel--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32928, 32955);

                f_10967_32928_32954(            // Close the Try scope
                            _builder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 32971, 33177) || true) && (!emitNestedScopes)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 32971, 33177);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33026, 33162);
                        foreach (var catchBlock in f_10967_33053_33074_I(f_10967_33053_33074(statement)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 33026, 33162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33116, 33143);

                            f_10967_33116_33142(this, catchBlock);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 33026, 33162);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 32971, 33177);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33193, 34405) || true) && (!emitCatchesOnly && (DynAbs.Tracing.TraceSender.Expression_True(10967, 33197, 33252) && (f_10967_33218_33243(statement) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 33193, 34405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33286, 33378);

                    f_10967_33286_33377(_builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 33310, 33338) || ((f_10967_33310_33338(statement) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 33341, 33356)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 33359, 33376))) ? ScopeType.Fault : ScopeType.Finally);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33396, 33433);

                    f_10967_33396_33432(this, f_10967_33406_33431(statement));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33493, 33520);

                    f_10967_33493_33519(
                                    // close Finally scope
                                    _builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 33596, 33623);

                    f_10967_33596_33622(
                                    // close the whole try statement scope
                                    _builder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 34041, 34241) || true) && (f_10967_34045_34073(statement))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 34041, 34241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 34115, 34176);

                        var
                        finallyClone = f_10967_34134_34175(statement)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 34198, 34222);

                        f_10967_34198_34221(this, finallyClone);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 34041, 34241);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 33193, 34405);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 33193, 34405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 34363, 34390);

                    f_10967_34363_34389(                // close the whole try statement scope
                                    _builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 33193, 34405);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 31631, 34416);

                bool
                f_10967_31757_31789_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 31757, 31789);
                    return return_v;
                }


                int
                f_10967_31744_31790(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 31744, 31790);
                    return 0;
                }


                int
                f_10967_31870_31897(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.AssertStackEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 31870, 31897);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10967_32226_32251(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 32226, 32251);
                    return return_v;
                }


                int
                f_10967_32278_32328(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType)
                {
                    this_param.OpenLocalScope(scopeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 32278, 32328);
                    return 0;
                }


                int
                f_10967_32345_32383(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType)
                {
                    this_param.OpenLocalScope(scopeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 32345, 32383);
                    return 0;
                }


                int
                f_10967_32681_32731(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                statement, bool
                emitCatchesOnly)
                {
                    this_param.EmitTryStatement(statement, emitCatchesOnly: emitCatchesOnly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 32681, 32731);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10967_32808_32826(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 32808, 32826);
                    return return_v;
                }


                int
                f_10967_32798_32827(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    this_param.EmitBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 32798, 32827);
                    return 0;
                }


                int
                f_10967_32928_32954(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 32928, 32954);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10967_33053_33074(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 33053, 33074);
                    return return_v;
                }


                int
                f_10967_33116_33142(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock)
                {
                    this_param.EmitCatchBlock(catchBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33116, 33142);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10967_33053_33074_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33053, 33074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10967_33218_33243(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 33218, 33243);
                    return return_v;
                }


                bool
                f_10967_33310_33338(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 33310, 33338);
                    return return_v;
                }


                int
                f_10967_33286_33377(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType)
                {
                    this_param.OpenLocalScope(scopeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33286, 33377);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10967_33406_33431(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 33406, 33431);
                    return return_v;
                }


                int
                f_10967_33396_33432(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    this_param.EmitBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33396, 33432);
                    return 0;
                }


                int
                f_10967_33493_33519(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33493, 33519);
                    return 0;
                }


                int
                f_10967_33596_33622(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 33596, 33622);
                    return 0;
                }


                bool
                f_10967_34045_34073(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.PreferFaultHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 34045, 34073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10967_34134_34175(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node)
                {
                    var return_v = FinallyCloner.MakeFinallyClone(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 34134, 34175);
                    return return_v;
                }


                int
                f_10967_34198_34221(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    this_param.EmitBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 34198, 34221);
                    return 0;
                }


                int
                f_10967_34363_34389(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 34363, 34389);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 31631, 34416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 31631, 34416);
            }
        }

        private void EmitCatchBlock(BoundCatchBlock catchBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 35767, 44040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 35847, 35882);

                object
                typeCheckFailedLabel = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 35900, 35924);

                f_10967_35900_35923(

                            _builder, 1);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 36183, 39289) || true) && (f_10967_36187_36216(catchBlock) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 36183, 39289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 36258, 36533);

                    var
                    exceptionType = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 36278, 36323) || ((((object)f_10967_36287_36314(catchBlock) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 36347, 36426)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 36450, 36532))) ? f_10967_36347_36426(_module, f_10967_36365_36392(catchBlock), catchBlock.Syntax, _diagnostics) : f_10967_36450_36532(_module, SpecialType.System_Object, catchBlock.Syntax, _diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 36553, 36609);

                    f_10967_36553_36608(
                                    _builder, ScopeType.Catch, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 36629, 36671);

                    f_10967_36629_36670(this, catchBlock);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37166, 37939) || true) && (_emitPdbSequencePoints)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 37166, 37939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37234, 37286);

                        var
                        syntax = catchBlock.Syntax as CatchClauseSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37308, 37920) || true) && (syntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 37308, 37920);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37376, 37392);

                            TextSpan
                            spSpan
                            = default(TextSpan);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37418, 37455);

                            var
                            declaration = f_10967_37436_37454(syntax)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37483, 37815) || true) && (declaration == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 37483, 37815);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37564, 37598);

                                spSpan = syntax.CatchKeyword.Span;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 37483, 37815);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 37483, 37815);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37712, 37788);

                                spSpan = TextSpan.FromBounds(f_10967_37741_37757(syntax), f_10967_37759_37777(syntax).Span.End);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 37483, 37815);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 37843, 37897);

                            f_10967_37843_37896(
                                                    this, f_10967_37866_37887(catchBlock), spSpan);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 37308, 37920);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 37166, 37939);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 36183, 39289);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 36183, 39289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38005, 38047);

                    f_10967_38005_38046(_builder, ScopeType.Filter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38067, 38109);

                    f_10967_38067_38108(this, catchBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38281, 38321);

                    var
                    typeCheckPassedLabel = f_10967_38308_38320()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38339, 38375);

                    typeCheckFailedLabel = f_10967_38362_38374();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38395, 39213) || true) && ((object)f_10967_38407_38434(catchBlock) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 38395, 39213);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38484, 38584);

                        var
                        exceptionType = f_10967_38504_38583(_module, f_10967_38522_38549(catchBlock), catchBlock.Syntax, _diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38608, 38645);

                        f_10967_38608_38644(
                                            _builder, ILOpCode.Isinst);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38667, 38734);

                        f_10967_38667_38733(_builder, exceptionType, catchBlock.Syntax, _diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38756, 38790);

                        f_10967_38756_38789(_builder, ILOpCode.Dup);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38812, 38871);

                        f_10967_38812_38870(_builder, ILOpCode.Brtrue, typeCheckPassedLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38893, 38927);

                        f_10967_38893_38926(_builder, ILOpCode.Pop);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38949, 38977);

                        f_10967_38949_38976(_builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 38999, 39054);

                        f_10967_38999_39053(_builder, ILOpCode.Br, typeCheckFailedLabel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 38395, 39213);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 38395, 39213);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 38395, 39213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39233, 39274);

                    f_10967_39233_39273(
                                    _builder, typeCheckPassedLabel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 36183, 39289);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39305, 39641);
                    foreach (var local in f_10967_39327_39344_I(f_10967_39327_39344(catchBlock)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 39305, 39641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39378, 39436);

                        var
                        declaringReferences = f_10967_39404_39435(local)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39454, 39576);

                        var
                        localSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 39472, 39500) || ((f_10967_39472_39500_M(!declaringReferences.IsEmpty) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 39503, 39555)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 39558, 39575))) ? (CSharpSyntaxNode)f_10967_39521_39555(declaringReferences[0]) : catchBlock.Syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39594, 39626);

                        f_10967_39594_39625(this, local, localSyntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 39305, 39641);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 1, 337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 1, 337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39657, 39712);

                var
                exceptionSourceOpt = f_10967_39682_39711(catchBlock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 39726, 42867) || true) && (exceptionSourceOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 39726, 42867);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40038, 40391) || true) && (!f_10967_40043_40088(f_10967_40043_40066(exceptionSourceOpt)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 40038, 40391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40130, 40186);

                        f_10967_40130_40185(f_10967_40143_40184(f_10967_40143_40166(exceptionSourceOpt)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40242, 40282);

                        f_10967_40242_40281(_builder, ILOpCode.Unbox_any);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40304, 40372);

                        f_10967_40304_40371(this, f_10967_40320_40343(exceptionSourceOpt), exceptionSourceOpt.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 40038, 40391);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40411, 40464);

                    BoundExpression
                    exceptionSource = exceptionSourceOpt
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40482, 40790) || true) && (f_10967_40489_40509(exceptionSource) == BoundKind.Sequence)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 40482, 40790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40573, 40614);

                            var
                            seq = (BoundSequence)exceptionSource
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40636, 40678);

                            f_10967_40636_40677(seq.Locals.IsDefaultOrEmpty);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40700, 40721);

                            f_10967_40700_40720(this, seq);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40743, 40771);

                            exceptionSource = f_10967_40761_40770(seq);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 40482, 40790);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10967, 40482, 40790);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10967, 40482, 40790);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40810, 42752);

                    switch (f_10967_40818_40838(exceptionSource))
                    {

                        case BoundKind.Local:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 40810, 42752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 40927, 40982);

                            var
                            exceptionSourceLocal = (BoundLocal)exceptionSource
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41008, 41079);

                            f_10967_41008_41078(f_10967_41021_41061(f_10967_41021_41053(exceptionSourceLocal)) == RefKind.None);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41105, 41297) || true) && (!f_10967_41110_41156(this, f_10967_41123_41155(exceptionSourceLocal)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 41105, 41297);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41214, 41270);

                                f_10967_41214_41269(_builder, f_10967_41238_41268(this, exceptionSourceLocal));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 41105, 41297);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10967, 41325, 41331);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 40810, 42752);

                        case BoundKind.FieldAccess:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 40810, 42752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41408, 41453);

                            var
                            left = (BoundFieldAccess)exceptionSource
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41479, 41537);

                            f_10967_41479_41536(f_10967_41492_41518_M(!f_10967_41493_41509(left).IsStatic), "Not supported");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41563, 41618);

                            f_10967_41563_41617(!f_10967_41577_41616(f_10967_41577_41598(f_10967_41577_41593(left))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41646, 41714);

                            var
                            stateMachineField = f_10967_41670_41686(left) as StateMachineFieldSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41740, 41982) || true) && (((object)stateMachineField != null) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 41744, 41817) && (stateMachineField.SlotIndex >= 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 41740, 41982);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 41875, 41955);

                                f_10967_41875_41954(_builder, stateMachineField.SlotIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 41740, 41982);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42142, 42212);

                            var
                            temp = f_10967_42153_42211(this, f_10967_42166_42186(exceptionSource), exceptionSource.Syntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42238, 42268);

                            f_10967_42238_42267(_builder, temp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42296, 42372);

                            var
                            receiverTemp = f_10967_42315_42371(this, f_10967_42331_42347(left), AddressKind.Writeable)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42398, 42433);

                            f_10967_42398_42432(receiverTemp == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42461, 42490);

                            f_10967_42461_42489(
                                                    _builder, temp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42516, 42531);

                            f_10967_42516_42530(this, temp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42559, 42580);

                            f_10967_42559_42579(this, left);
                            DynAbs.Tracing.TraceSender.TraceBreak(10967, 42606, 42612);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 40810, 42752);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 40810, 42752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42670, 42733);

                            throw f_10967_42676_42732(f_10967_42711_42731(exceptionSource));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 40810, 42752);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 39726, 42867);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 39726, 42867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42818, 42852);

                    f_10967_42818_42851(_builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 39726, 42867);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42883, 43100) || true) && (f_10967_42887_42924(catchBlock) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 42883, 43100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 42966, 43002);

                    f_10967_42966_43001(f_10967_42979_43000(_builder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43020, 43085);

                    f_10967_43020_43084(this, f_10967_43035_43083(f_10967_43035_43072(catchBlock)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 42883, 43100);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43222, 43943) || true) && (f_10967_43226_43255(catchBlock) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 43222, 43943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43297, 43347);

                    f_10967_43297_43346(this, f_10967_43310_43339(catchBlock), true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43494, 43522);

                    f_10967_43494_43521(                // Normalize the return value because values other than 0 or 1
                                                        // produce unspecified results.
                                    _builder, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43540, 43577);

                    f_10967_43540_43576(_builder, ILOpCode.Cgt_un);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43595, 43636);

                    f_10967_43595_43635(_builder, typeCheckFailedLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43715, 43749);

                    f_10967_43715_43748(
                                    // Now we are starting the actual handler
                                    _builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43894, 43928);

                    f_10967_43894_43927(
                                    // Pop the exception; it should have already been stored to the
                                    // variable by the filter.
                                    _builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 43222, 43943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 43959, 43986);

                f_10967_43959_43985(this, f_10967_43969_43984(catchBlock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44002, 44029);

                f_10967_44002_44028(
                            _builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 35767, 44040);

                int
                f_10967_35900_35923(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 35900, 35923);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_36187_36216(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 36187, 36216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_36287_36314(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 36287, 36314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_36365_36392(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 36365, 36392);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10967_36347_36426(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 36347, 36426);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10967_36450_36532(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSpecialType(specialType, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 36450, 36532);
                    return return_v;
                }


                int
                f_10967_36553_36608(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType, Microsoft.Cci.ITypeReference
                exceptionType)
                {
                    this_param.OpenLocalScope(scopeType, exceptionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 36553, 36608);
                    return 0;
                }


                int
                f_10967_36629_36670(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock)
                {
                    this_param.RecordAsyncCatchHandlerOffset(catchBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 36629, 36670);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax?
                f_10967_37436_37454(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 37436, 37454);
                    return return_v;
                }


                int
                f_10967_37741_37757(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 37741, 37757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.CatchDeclarationSyntax?
                f_10967_37759_37777(Microsoft.CodeAnalysis.CSharp.Syntax.CatchClauseSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 37759, 37777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10967_37866_37887(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 37866, 37887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10967_37843_37896(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.EmitSequencePoint(syntaxTree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 37843, 37896);
                    return return_v;
                }


                int
                f_10967_38005_38046(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                scopeType)
                {
                    this_param.OpenLocalScope(scopeType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38005, 38046);
                    return 0;
                }


                int
                f_10967_38067_38108(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock)
                {
                    this_param.RecordAsyncCatchHandlerOffset(catchBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38067, 38108);
                    return 0;
                }


                object
                f_10967_38308_38320()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38308, 38320);
                    return return_v;
                }


                object
                f_10967_38362_38374()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38362, 38374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_38407_38434(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 38407, 38434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_38522_38549(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 38522, 38549);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10967_38504_38583(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38504, 38583);
                    return return_v;
                }


                int
                f_10967_38608_38644(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38608, 38644);
                    return 0;
                }


                int
                f_10967_38667_38733(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.ITypeReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38667, 38733);
                    return 0;
                }


                int
                f_10967_38756_38789(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38756, 38789);
                    return 0;
                }


                int
                f_10967_38812_38870(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38812, 38870);
                    return 0;
                }


                int
                f_10967_38893_38926(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38893, 38926);
                    return 0;
                }


                int
                f_10967_38949_38976(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38949, 38976);
                    return 0;
                }


                int
                f_10967_38999_39053(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 38999, 39053);
                    return 0;
                }


                int
                f_10967_39233_39273(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 39233, 39273);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_39327_39344(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 39327, 39344);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10967_39404_39435(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 39404, 39435);
                    return return_v;
                }


                bool
                f_10967_39472_39500_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 39472, 39500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10967_39521_39555(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 39521, 39555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_39594_39625(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.DefineLocal(local, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 39594, 39625);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10967_39327_39344_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 39327, 39344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_39682_39711(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 39682, 39711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_40043_40066(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40043, 40066);
                    return return_v;
                }


                bool
                f_10967_40043_40088(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40043, 40088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_40143_40166(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40143, 40166);
                    return return_v;
                }


                bool
                f_10967_40143_40184(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40143, 40184);
                    return return_v;
                }


                int
                f_10967_40130_40185(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40130, 40185);
                    return 0;
                }


                int
                f_10967_40242_40281(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40242, 40281);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_40320_40343(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40320, 40343);
                    return return_v;
                }


                int
                f_10967_40304_40371(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40304, 40371);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10967_40489_40509(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40489, 40509);
                    return return_v;
                }


                int
                f_10967_40636_40677(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40636, 40677);
                    return 0;
                }


                int
                f_10967_40700_40720(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.EmitSideEffects(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 40700, 40720);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_40761_40770(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40761, 40770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10967_40818_40838(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 40818, 40838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10967_41021_41053(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41021, 41053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_41021_41061(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41021, 41061);
                    return return_v;
                }


                int
                f_10967_41008_41078(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41008, 41078);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10967_41123_41155(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41123, 41155);
                    return return_v;
                }


                bool
                f_10967_41110_41156(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41110, 41156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_41238_41268(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                localExpression)
                {
                    var return_v = this_param.GetLocal(localExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41238, 41268);
                    return return_v;
                }


                int
                f_10967_41214_41269(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41214, 41269);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10967_41493_41509(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41493, 41509);
                    return return_v;
                }


                bool
                f_10967_41492_41518_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41492, 41518);
                    return return_v;
                }


                int
                f_10967_41479_41536(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41479, 41536);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_41577_41593(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41577, 41593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_41577_41598(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41577, 41598);
                    return return_v;
                }


                bool
                f_10967_41577_41616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41577, 41616);
                    return return_v;
                }


                int
                f_10967_41563_41617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41563, 41617);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10967_41670_41686(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 41670, 41686);
                    return return_v;
                }


                int
                f_10967_41875_41954(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                slotIndex)
                {
                    this_param.DefineUserDefinedStateMachineHoistedLocal(slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 41875, 41954);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_42166_42186(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 42166, 42186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_42153_42211(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42153, 42211);
                    return return_v;
                }


                int
                f_10967_42238_42267(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42238, 42267);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_42331_42347(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 42331, 42347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_42315_42371(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42315, 42371);
                    return return_v;
                }


                int
                f_10967_42398_42432(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42398, 42432);
                    return 0;
                }


                int
                f_10967_42461_42489(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42461, 42489);
                    return 0;
                }


                int
                f_10967_42516_42530(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42516, 42530);
                    return 0;
                }


                int
                f_10967_42559_42579(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess)
                {
                    this_param.EmitFieldStore(fieldAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42559, 42579);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10967_42711_42731(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 42711, 42731);
                    return return_v;
                }


                System.Exception
                f_10967_42676_42732(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42676, 42732);
                    return return_v;
                }


                int
                f_10967_42818_42851(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42818, 42851);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10967_42887_42924(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 42887, 42924);
                    return return_v;
                }


                bool
                f_10967_42979_43000(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.IsStackEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 42979, 43000);
                    return return_v;
                }


                int
                f_10967_42966_43001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 42966, 43001);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10967_43035_43072(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 43035, 43072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10967_43035_43083(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 43035, 43083);
                    return return_v;
                }


                int
                f_10967_43020_43084(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.EmitStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43020, 43084);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10967_43226_43255(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 43226, 43255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_43310_43339(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 43310, 43339);
                    return return_v;
                }


                int
                f_10967_43297_43346(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                sense)
                {
                    this_param.EmitCondExpr(condition, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43297, 43346);
                    return 0;
                }


                int
                f_10967_43494_43521(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43494, 43521);
                    return 0;
                }


                int
                f_10967_43540_43576(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43540, 43576);
                    return 0;
                }


                int
                f_10967_43595_43635(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object?
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43595, 43635);
                    return 0;
                }


                int
                f_10967_43715_43748(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.MarkFilterConditionEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43715, 43748);
                    return 0;
                }


                int
                f_10967_43894_43927(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43894, 43927);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10967_43969_43984(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 43969, 43984);
                    return return_v;
                }


                int
                f_10967_43959_43985(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    this_param.EmitBlock(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 43959, 43985);
                    return 0;
                }


                int
                f_10967_44002_44028(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44002, 44028);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 35767, 44040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 35767, 44040);
            }
        }

        private void RecordAsyncCatchHandlerOffset(BoundCatchBlock catchBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 44052, 44385);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44147, 44374) || true) && (f_10967_44151_44188(catchBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 44147, 44374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44222, 44265);

                    f_10967_44222_44264(_asyncCatchHandlerOffset < 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44304, 44359);

                    _asyncCatchHandlerOffset = f_10967_44331_44358(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 44147, 44374);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 44052, 44385);

                bool
                f_10967_44151_44188(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44151, 44188);
                    return return_v;
                }


                int
                f_10967_44222_44264(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44222, 44264);
                    return 0;
                }


                int
                f_10967_44331_44358(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AllocateILMarker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44331, 44358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 44052, 44385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 44052, 44385);
            }
        }

        private void EmitSwitchDispatch(BoundSwitchDispatch dispatch)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 44397, 45261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44557, 44612);

                f_10967_44557_44611((object)f_10967_44578_44602(f_10967_44578_44597(dispatch)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44626, 44696);

                f_10967_44626_44695(f_10967_44639_44694(f_10967_44639_44663(f_10967_44639_44658(dispatch))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44808, 44865);

                f_10967_44808_44864(!f_10967_44822_44863(f_10967_44822_44846(f_10967_44822_44841(dispatch))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44947, 44982);

                f_10967_44947_44981(dispatch.Cases.Any());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 44998, 45250);

                f_10967_44998_45249(this, f_10967_45033_45052(dispatch), f_10967_45071_45166(dispatch.Cases.Select(p => new KeyValuePair<ConstantValue, object>(p.value, p.label))), f_10967_45185_45206(dispatch), f_10967_45225_45248(dispatch));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 44397, 45261);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_44578_44597(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44578, 44597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10967_44578_44602(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44578, 44602);
                    return return_v;
                }


                int
                f_10967_44557_44611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44557, 44611);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_44639_44658(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44639, 44658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_44639_44663(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44639, 44663);
                    return return_v;
                }


                bool
                f_10967_44639_44694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidV6SwitchGoverningType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44639, 44694);
                    return return_v;
                }


                int
                f_10967_44626_44695(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44626, 44695);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_44822_44841(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44822, 44841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_44822_44846(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 44822, 44846);
                    return return_v;
                }


                bool
                f_10967_44822_44863(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44822, 44863);
                    return return_v;
                }


                int
                f_10967_44808_44864(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44808, 44864);
                    return 0;
                }


                int
                f_10967_44947_44981(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44947, 44981);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10967_45033_45052(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 45033, 45052);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                f_10967_45071_45166(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>
                source)
                {
                    var return_v = source.ToArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 45071, 45166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10967_45185_45206(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.DefaultLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 45185, 45206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10967_45225_45248(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                this_param)
                {
                    var return_v = this_param.EqualityMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 45225, 45248);
                    return return_v;
                }


                int
                f_10967_44998_45249(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                switchCaseLabels, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                fallThroughLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                equalityMethod)
                {
                    this_param.EmitSwitchHeader(expression, switchCaseLabels, fallThroughLabel, equalityMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 44998, 45249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 44397, 45261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 44397, 45261);
            }
        }

        private void EmitSwitchHeader(
            BoundExpression expression,
            KeyValuePair<ConstantValue, object>[] switchCaseLabels,
            LabelSymbol fallThroughLabel,
            MethodSymbol equalityMethod)
        {
            Debug.Assert(expression.ConstantValue == null);
            Debug.Assert((object)expression.Type != null &&
                expression.Type.IsValidV6SwitchGoverningType());
            Debug.Assert(switchCaseLabels.Length > 0);

            Debug.Assert(switchCaseLabels != null);

            LocalDefinition temp = null;
            LocalOrParameter key;
            BoundSequence sequence = null;

            if (expression.Kind == BoundKind.Sequence)
            {
                sequence = (BoundSequence)expression;
                DefineLocals(sequence);
                EmitSideEffects(sequence);
                expression = sequence.Value;
            }

            if (expression.Kind == BoundKind.SequencePointExpression)
            {
                var sequencePointExpression = (BoundSequencePointExpression)expression;
                EmitSequencePoint(sequencePointExpression);
                expression = sequencePointExpression.Expression;
            }

            switch (expression.Kind)
            {
                case BoundKind.Local:
                    var local = ((BoundLocal)expression).LocalSymbol;
                    if (local.RefKind == RefKind.None && !IsStackLocal(local))
                    {
                        key = this.GetLocal(local);
                        break;
                    }
                    goto default;

                case BoundKind.Parameter:
                    var parameter = (BoundParameter)expression;
                    if (parameter.ParameterSymbol.RefKind == RefKind.None)
                    {
                        key = ParameterSlot(parameter);
                        break;
                    }
                    goto default;

                default:
                    EmitExpression(expression, true);
                    temp = AllocateTemp(expression.Type, expression.Syntax);
                    _builder.EmitLocalStore(temp);
                    key = temp;
                    break;
            }

            // Emit switch jump table
            if (expression.Type.SpecialType != SpecialType.System_String)
            {
                _builder.EmitIntegerSwitchJumpTable(switchCaseLabels, fallThroughLabel, key, expression.Type.EnumUnderlyingTypeOrSelf().PrimitiveTypeCode);
            }
            else
            {
                this.EmitStringSwitchJumpTable(switchCaseLabels, fallThroughLabel, key, expression.Syntax, equalityMethod);
            }

            if (temp != null)
            {
                FreeTemp(temp);
            }

            if (sequence != null)
            {
                // sequence was used as a value, can release all its locals.
                FreeLocals(sequence);
            }
        }

        private void EmitStringSwitchJumpTable(
                    KeyValuePair<ConstantValue, object>[] switchCaseLabels,
                    LabelSymbol fallThroughLabel,
                    LocalOrParameter key,
                    SyntaxNode syntaxNode,
                    MethodSymbol equalityMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 48359, 53116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 48648, 48679);

                LocalDefinition
                keyHash = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 48810, 50306) || true) && (SwitchStringJumpTableEmitter.ShouldGenerateHashTableSwitch(_module, f_10967_48882_48905(switchCaseLabels)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 48810, 50306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 48940, 48987);

                    f_10967_48940_48986(f_10967_48953_48985(_module));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49007, 49084);

                    var
                    privateImplClass = f_10967_49030_49083(_module, syntaxNode, _diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49102, 49230);

                    Cci.IReference
                    stringHashMethodRef = f_10967_49139_49229(privateImplClass, PrivateImplementationDetails.SynthesizedStringHashFunctionName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49562, 50291) || true) && (stringHashMethodRef != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 49562, 50291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49855, 49878);

                        f_10967_49855_49877(                    // static uint ComputeStringHash(string s)
                                                                // pop 1 (s)
                                                                // push 1 (uint return value)
                                                                // stackAdjustment = (pushCount - popCount) = 0

                                            _builder, key);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49900, 49955);

                        f_10967_49900_49954(_builder, ILOpCode.Call, stackAdjustment: 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 49977, 50043);

                        f_10967_49977_50042(_builder, stringHashMethodRef, syntaxNode, _diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50067, 50146);

                        var
                        UInt32Type = f_10967_50084_50145(_module.Compilation, SpecialType.System_UInt32)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50168, 50215);

                        keyHash = f_10967_50178_50214(this, UInt32Type, syntaxNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50239, 50272);

                        f_10967_50239_50271(
                                            _builder, keyHash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 49562, 50291);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 48810, 50306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50322, 50423);

                Cci.IReference
                stringEqualityMethodRef = f_10967_50363_50422(_module, equalityMethod, syntaxNode, _diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50439, 50483);

                Cci.IMethodReference
                stringLengthRef = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50497, 50616);

                var
                stringLengthMethod = f_10967_50522_50599(_module.Compilation, SpecialMember.System_String__Length) as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50630, 50830) || true) && (stringLengthMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10967, 50634, 50699) && f_10967_50664_50699_M(!stringLengthMethod.HasUseSiteError)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 50630, 50830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50733, 50815);

                    stringLengthRef = f_10967_50751_50814(_module, stringLengthMethod, syntaxNode, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 50630, 50830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 50846, 52611);

                SwitchStringJumpTableEmitter.EmitStringCompareAndBranch
                emitStringCondBranchDelegate =
                                (keyArg, stringConstant, targetLabel) =>
                                {
                                    if (stringConstant == ConstantValue.Null)
                                    {
                        // if (key == null)
                        //      goto targetLabel
                        _builder.EmitLoad(keyArg);
                                        _builder.EmitBranch(ILOpCode.Brfalse, targetLabel, ILOpCode.Brtrue);
                                    }
                                    else if (stringConstant.StringValue.Length == 0 && stringLengthRef != null)
                                    {
                        // if (key != null && key.Length == 0)
                        //      goto targetLabel

                        object skipToNext = new object();
                                        _builder.EmitLoad(keyArg);
                                        _builder.EmitBranch(ILOpCode.Brfalse, skipToNext, ILOpCode.Brtrue);

                                        _builder.EmitLoad(keyArg);
                        // Stack: key --> length
                        _builder.EmitOpCode(ILOpCode.Call, 0);
                                        var diag = DiagnosticBag.GetInstance();
                                        _builder.EmitToken(stringLengthRef, null, diag);
                                        Debug.Assert(diag.IsEmptyWithoutResolution);
                                        diag.Free();

                                        _builder.EmitBranch(ILOpCode.Brfalse, targetLabel, ILOpCode.Brtrue);
                                        _builder.MarkLabel(skipToNext);
                                    }
                                    else
                                    {
                                        this.EmitStringCompareAndBranch(key, syntaxNode, stringConstant, targetLabel, stringEqualityMethodRef);
                                    }
                                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 52627, 53003);

                f_10967_52627_53002(
                            _builder, caseLabels: switchCaseLabels, fallThroughLabel: fallThroughLabel, key: key, keyHash: keyHash, emitStringCondBranchDelegate: emitStringCondBranchDelegate, computeStringHashcodeDelegate: SynthesizedStringSwitchHashMethod.ComputeStringHash);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 53019, 53105) || true) && (keyHash != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 53019, 53105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 53072, 53090);

                    f_10967_53072_53089(this, keyHash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 53019, 53105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 48359, 53116);

                int
                f_10967_48882_48905(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 48882, 48905);
                    return return_v;
                }


                bool
                f_10967_48953_48985(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.SupportsPrivateImplClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 48953, 48985);
                    return return_v;
                }


                int
                f_10967_48940_48986(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 48940, 48986);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                f_10967_49030_49083(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetPrivateImplClass(syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 49030, 49083);
                    return return_v;
                }


                Microsoft.Cci.IMethodDefinition?
                f_10967_49139_49229(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 49139, 49229);
                    return return_v;
                }


                int
                f_10967_49855_49877(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 49855, 49877);
                    return 0;
                }


                int
                f_10967_49900_49954(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 49900, 49954);
                    return 0;
                }


                int
                f_10967_49977_50042(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken(value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 49977, 50042);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10967_50084_50145(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50084, 50145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_50178_50214(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50178, 50214);
                    return return_v;
                }


                int
                f_10967_50239_50271(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50239, 50271);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_10967_50363_50422(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50363, 50422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10967_50522_50599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50522, 50599);
                    return return_v;
                }


                bool
                f_10967_50664_50699_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 50664, 50699);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10967_50751_50814(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 50751, 50814);
                    return return_v;
                }


                int
                f_10967_52627_53002(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                caseLabels, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                fallThroughLabel, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                key, Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                keyHash, Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.EmitStringCompareAndBranch
                emitStringCondBranchDelegate, Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.GetStringHashCode
                computeStringHashcodeDelegate)
                {
                    this_param.EmitStringSwitchJumpTable(caseLabels: caseLabels, fallThroughLabel: (object)fallThroughLabel, key: key, keyHash: keyHash, emitStringCondBranchDelegate: emitStringCondBranchDelegate, computeStringHashcodeDelegate: computeStringHashcodeDelegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 52627, 53002);
                    return 0;
                }


                int
                f_10967_53072_53089(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 53072, 53089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 48359, 53116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 48359, 53116);
            }
        }

        private void EmitStringCompareAndBranch(LocalOrParameter key, SyntaxNode syntaxNode, ConstantValue stringConstant, object targetLabel, Microsoft.Cci.IReference stringEqualityMethodRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 53669, 55012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54005, 54051);

                f_10967_54005_54050(stringEqualityMethodRef != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54078, 54130);

                var
                assertDiagnostics = f_10967_54102_54129()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54144, 54350);

                f_10967_54144_54349(stringEqualityMethodRef == f_10967_54184_54348(_module, f_10967_54216_54298(_module.Compilation, SpecialMember.System_String__op_Equality), (CSharpSyntaxNode)syntaxNode, assertDiagnostics));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54364, 54389);

                f_10967_54364_54388(assertDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54613, 54636);

                f_10967_54613_54635(
                            // static bool String.Equals(string a, string b)
                            // pop 2 (a, b)
                            // push 1 (bool return value)

                            // stackAdjustment = (pushCount - popCount) = -1

                            _builder, key);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54650, 54693);

                f_10967_54650_54692(_builder, stringConstant);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54707, 54763);

                f_10967_54707_54762(_builder, ILOpCode.Call, stackAdjustment: -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54777, 54847);

                f_10967_54777_54846(_builder, stringEqualityMethodRef, syntaxNode, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 54933, 55001);

                f_10967_54933_55000(
                            // Branch to targetLabel if String.Equals returned true.
                            _builder, ILOpCode.Brtrue, targetLabel, ILOpCode.Brfalse);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 53669, 55012);

                int
                f_10967_54005_54050(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54005, 54050);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10967_54102_54129()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54102, 54129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10967_54216_54298(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54216, 54298);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10967_54184_54348(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)methodSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54184, 54348);
                    return return_v;
                }


                int
                f_10967_54144_54349(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54144, 54349);
                    return 0;
                }


                int
                f_10967_54364_54388(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54364, 54388);
                    return 0;
                }


                int
                f_10967_54613_54635(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                localOrParameter)
                {
                    this_param.EmitLoad(localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54613, 54635);
                    return 0;
                }


                int
                f_10967_54650_54692(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54650, 54692);
                    return 0;
                }


                int
                f_10967_54707_54762(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54707, 54762);
                    return 0;
                }


                int
                f_10967_54777_54846(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken(value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54777, 54846);
                    return 0;
                }


                int
                f_10967_54933_55000(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label, System.Reflection.Metadata.ILOpCode
                revOpCode)
                {
                    this_param.EmitBranch(code, label, revOpCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 54933, 55000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 53669, 55012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 53669, 55012);
            }
        }

        private LocalDefinition GetLocal(BoundLocal localExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 55129, 55304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 55214, 55255);

                var
                symbol = f_10967_55227_55254(localExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 55269, 55293);

                return f_10967_55276_55292(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 55129, 55304);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10967_55227_55254(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55227, 55254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_55276_55292(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetLocal(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55276, 55292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 55129, 55304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 55129, 55304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition GetLocal(LocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 55316, 55454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 55393, 55443);

                return f_10967_55400_55442(_builder.LocalSlotManager, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 55316, 55454);

                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_55400_55442(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.GetLocal((Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55400, 55442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 55316, 55454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 55316, 55454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private LocalDefinition DefineLocal(LocalSymbol local, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 55466, 59790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 55568, 55799);

                var
                dynamicTransformFlags = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 55596, 55654) || ((f_10967_55596_55622_M(!local.IsCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 55596, 55654) && f_10967_55626_55654(f_10967_55626_55636(local))) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 55674, 55752)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 55772, 55798))) ? f_10967_55674_55752(f_10967_55724_55734(local), RefKind.None, 0) : ImmutableArray<bool>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 55813, 56021);

                var
                tupleElementNames = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 55837, 55898) || ((f_10967_55837_55863_M(!local.IsCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 55837, 55898) && f_10967_55867_55898(f_10967_55867_55877(local))) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 55918, 55972)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 55992, 56020))) ? f_10967_55918_55972(f_10967_55961_55971(local)) : ImmutableArray<string>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56037, 56735) || true) && (f_10967_56041_56054(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 56037, 56735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56088, 56125);

                    f_10967_56088_56124(f_10967_56101_56123(local));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56143, 56261);

                    MetadataConstant
                    compileTimeValue = f_10967_56179_56260(_module, f_10967_56202_56212(local), f_10967_56214_56233(local), syntaxNode, _diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56279, 56621);

                    LocalConstantDefinition
                    localConstantDef = f_10967_56322_56620(f_10967_56372_56382(local), local.Locations.FirstOrDefault() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10967, 56405, 56454) ?? f_10967_56441_56454()), compileTimeValue, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56639, 56690);

                    f_10967_56639_56689(_builder, localConstantDef);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56708, 56720);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 56037, 56735);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56751, 56835) || true) && (f_10967_56755_56774(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 56751, 56835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56808, 56820);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 56751, 56835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56851, 56884);

                LocalSlotConstraints
                constraints
                = default(LocalSlotConstraints);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56898, 56932);

                Cci.ITypeReference
                translatedType
                = default(Cci.ITypeReference);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 56948, 58277) || true) && (f_10967_56952_56973(local) == LocalDeclarationKind.FixedVariable && (DynAbs.Tracing.TraceSender.Expression_True(10967, 56952, 57029) && f_10967_57015_57029(local)))
                ) // Excludes pointer local and string local in fixed string case.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 56948, 58277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57128, 57172);

                    f_10967_57128_57171(f_10967_57141_57154(local) == RefKind.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57190, 57251);

                    f_10967_57190_57250(f_10967_57203_57249(local.TypeWithAnnotations.Type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57271, 57342);

                    constraints = LocalSlotConstraints.ByRef | LocalSlotConstraints.Pinned;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57360, 57422);

                    PointerTypeSymbol
                    pointerType = (PointerTypeSymbol)f_10967_57411_57421(local)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57440, 57493);

                    TypeSymbol
                    pointedAtType = f_10967_57467_57492(pointerType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57679, 57904);

                    translatedType = (DynAbs.Tracing.TraceSender.Conditional_F1(10967, 57696, 57722) || ((f_10967_57696_57722(pointedAtType) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 57746, 57821)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 57845, 57903))) ? f_10967_57746_57821(_module, SpecialType.System_IntPtr, syntaxNode, _diagnostics) : f_10967_57845_57903(_module, pointedAtType, syntaxNode, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 56948, 58277);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 56948, 58277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 57970, 58171);

                    constraints = ((DynAbs.Tracing.TraceSender.Conditional_F1(10967, 57985, 57999) || ((f_10967_57985_57999(local) && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 58002, 58029)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 58032, 58057))) ? LocalSlotConstraints.Pinned : LocalSlotConstraints.None) |
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10967, 58083, 58112) || ((f_10967_58083_58096(local) != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10967, 58115, 58141)) || DynAbs.Tracing.TraceSender.Conditional_F3(10967, 58144, 58169))) ? LocalSlotConstraints.ByRef : LocalSlotConstraints.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 58189, 58262);

                    translatedType = f_10967_58206_58261(_module, f_10967_58224_58234(local), syntaxNode, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 56948, 58277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 58566, 58640);

                f_10967_58566_58639(
                            // Even though we don't need the token immediately, we will need it later when signature for the local is emitted.
                            // Also, requesting the token has side-effect of registering types used, which is critical for embedded types (NoPia, VBCore, etc).
                            _module, translatedType, syntaxNode, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 58656, 58677);

                LocalDebugId
                localId
                = default(LocalDebugId);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 58691, 58740);

                var
                name = f_10967_58702_58739(this, local, out localId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 58756, 59327);

                var
                localDef = f_10967_58771_59326(_builder.LocalSlotManager, type: translatedType, symbol: local, name: name, kind: f_10967_58934_58955(local), id: localId, pdbAttributes: f_10967_59019_59056(f_10967_59019_59040(local)), constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames, isSlotReusable: f_10967_59252_59325(f_10967_59252_59273(local), _ilEmitStyle != ILEmitStyle.Release))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 59402, 59747) || true) && (f_10967_59406_59419(localDef) != null && (DynAbs.Tracing.TraceSender.Expression_True(10967, 59406, 59593) && !(f_10967_59450_59471(local) == SynthesizedLocalKind.UserDefined && (DynAbs.Tracing.TraceSender.Expression_True(10967, 59450, 59592) && f_10967_59557_59564(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10967_59532_59556(local), 10967, 59532, 59564)) == SyntaxKind.SwitchSection))))
                ) // Visibility scope of such locals is represented by BoundScope node.

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 59402, 59747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 59697, 59732);

                    f_10967_59697_59731(_builder, localDef);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 59402, 59747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 59763, 59779);

                return localDef;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 55466, 59790);

                bool
                f_10967_55596_55622_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55596, 55622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_55626_55636(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55626, 55636);
                    return return_v;
                }


                bool
                f_10967_55626_55654(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55626, 55654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_55724_55734(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55724, 55734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10967_55674_55752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.RefKind
                refKind, int
                customModifiersCount)
                {
                    var return_v = CSharpCompilation.DynamicTransformsEncoder.Encode(type, refKind, customModifiersCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55674, 55752);
                    return return_v;
                }


                bool
                f_10967_55837_55863_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55837, 55863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_55867_55877(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55867, 55877);
                    return return_v;
                }


                bool
                f_10967_55867_55898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55867, 55898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_55961_55971(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 55961, 55971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10967_55918_55972(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = CSharpCompilation.TupleNamesEncoder.Encode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 55918, 55972);
                    return return_v;
                }


                bool
                f_10967_56041_56054(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56041, 56054);
                    return return_v;
                }


                bool
                f_10967_56101_56123(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.HasConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56101, 56123);
                    return return_v;
                }


                int
                f_10967_56088_56124(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 56088, 56124);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_56202_56212(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56202, 56212);
                    return return_v;
                }


                object
                f_10967_56214_56233(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56214, 56233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                f_10967_56179_56260(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, object
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConstant(type, value, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 56179, 56260);
                    return return_v;
                }


                string
                f_10967_56372_56382(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56372, 56382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10967_56441_56454()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56441, 56454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                f_10967_56322_56620(string
                name, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CodeGen.MetadataConstant
                compileTimeValue, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string?>
                tupleElementNames)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition(name, location, compileTimeValue, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 56322, 56620);
                    return return_v;
                }


                int
                f_10967_56639_56689(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                localConstant)
                {
                    this_param.AddLocalConstantToScope(localConstant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 56639, 56689);
                    return 0;
                }


                bool
                f_10967_56755_56774(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 56755, 56774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                f_10967_56952_56973(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 56952, 56973);
                    return return_v;
                }


                bool
                f_10967_57015_57029(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsPinned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 57015, 57029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_57141_57154(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 57141, 57154);
                    return return_v;
                }


                int
                f_10967_57128_57171(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57128, 57171);
                    return 0;
                }


                bool
                f_10967_57203_57249(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57203, 57249);
                    return return_v;
                }


                int
                f_10967_57190_57250(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57190, 57250);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_57411_57421(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 57411, 57421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_57467_57492(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 57467, 57492);
                    return return_v;
                }


                bool
                f_10967_57696_57722(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57696, 57722);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10967_57746_57821(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSpecialType(specialType, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57746, 57821);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10967_57845_57903(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 57845, 57903);
                    return return_v;
                }


                bool
                f_10967_57985_57999(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsPinned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 57985, 57999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10967_58083_58096(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 58083, 58096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10967_58224_58234(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 58224, 58234);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10967_58206_58261(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 58206, 58261);
                    return return_v;
                }


                uint
                f_10967_58566_58639(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.Cci.ITypeReference
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetFakeSymbolTokenForIL((Microsoft.Cci.IReference)symbol, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 58566, 58639);
                    return return_v;
                }


                string
                f_10967_58702_58739(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, out Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                localId)
                {
                    var return_v = this_param.GetLocalDebugName((Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)local, out localId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 58702, 58739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_58934_58955(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 58934, 58955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_59019_59040(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 59019, 59040);
                    return return_v;
                }


                System.Reflection.Metadata.LocalVariableAttributes
                f_10967_59019_59056(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.PdbAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 59019, 59056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_59252_59273(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 59252, 59273);
                    return return_v;
                }


                bool
                f_10967_59252_59325(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, bool
                isDebug)
                {
                    var return_v = kind.IsSlotReusable(isDebug);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 59252, 59325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_58771_59326(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, string
                name, Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                id, System.Reflection.Metadata.LocalVariableAttributes
                pdbAttributes, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints, System.Collections.Immutable.ImmutableArray<bool>
                dynamicTransformFlags, System.Collections.Immutable.ImmutableArray<string?>
                tupleElementNames, bool
                isSlotReusable)
                {
                    var return_v = this_param.DeclareLocal(type: type, symbol: (Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)symbol, name: name, kind: kind, id: id, pdbAttributes: pdbAttributes, constraints: constraints, dynamicTransformFlags: dynamicTransformFlags, tupleElementNames: tupleElementNames, isSlotReusable: isSlotReusable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 58771, 59326);
                    return return_v;
                }


                string?
                f_10967_59406_59419(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 59406, 59419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_59450_59471(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 59450, 59471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10967_59532_59556(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 59532, 59556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10967_59557_59564(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 59557, 59564);
                    return return_v;
                }


                int
                f_10967_59697_59731(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.AddLocalToScope(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 59697, 59731);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 55466, 59790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 55466, 59790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetLocalDebugName(ILocalSymbolInternal local, out LocalDebugId localId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 59952, 61733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60063, 60091);

                localId = LocalDebugId.None;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60107, 60206) || true) && (f_10967_60111_60139(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 60107, 60206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60173, 60191);

                    return f_10967_60180_60190(local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 60107, 60206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60222, 60260);

                var
                localKind = f_10967_60238_60259(local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60350, 60436);

                f_10967_60350_60435((f_10967_60364_60374(local) == null) == (localKind != SynthesizedLocalKind.UserDefined));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60854, 61003) || true) && (!f_10967_60859_60882(localKind) || (DynAbs.Tracing.TraceSender.Expression_False(10967, 60858, 60942) || localKind == SynthesizedLocalKind.InstrumentationPayload))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 60854, 61003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 60976, 60988);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 60854, 61003);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61019, 61615) || true) && (_ilEmitStyle == ILEmitStyle.Debug)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 61019, 61615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61090, 61131);

                    var
                    syntax = f_10967_61103_61130(local)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61149, 61269);

                    int
                    syntaxOffset = f_10967_61168_61268(_method, f_10967_61203_61248(syntax), f_10967_61250_61267(syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61287, 61371);

                    int
                    ordinal = f_10967_61301_61370(_synthesizedLocalOrdinals, localKind, syntaxOffset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61454, 61530);

                    f_10967_61454_61529(ordinal == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10967, 61467, 61528) || localKind != SynthesizedLocalKind.UserDefined));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61550, 61600);

                    localId = f_10967_61560_61599(syntaxOffset, ordinal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 61019, 61615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61631, 61722);

                return f_10967_61638_61648(local) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10967, 61638, 61721) ?? f_10967_61652_61721(localKind, ref _uniqueNameId));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 59952, 61733);

                bool
                f_10967_60111_60139(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.IsImportedFromMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 60111, 60139);
                    return return_v;
                }


                string
                f_10967_60180_60190(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 60180, 60190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_60238_60259(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 60238, 60259);
                    return return_v;
                }


                string
                f_10967_60364_60374(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 60364, 60374);
                    return return_v;
                }


                int
                f_10967_60350_60435(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 60350, 60435);
                    return 0;
                }


                bool
                f_10967_60859_60882(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 60859, 60882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10967_61103_61130(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetDeclaratorSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61103, 61130);
                    return return_v;
                }


                int
                f_10967_61203_61248(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.GetDeclaratorPosition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61203, 61248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10967_61250_61267(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 61250, 61267);
                    return return_v;
                }


                int
                f_10967_61168_61268(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                localPosition, Microsoft.CodeAnalysis.SyntaxTree
                localTree)
                {
                    var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61168, 61268);
                    return return_v;
                }


                int
                f_10967_61301_61370(Microsoft.CodeAnalysis.CodeGen.SynthesizedLocalOrdinalsDispenser
                this_param, Microsoft.CodeAnalysis.SynthesizedLocalKind
                localKind, int
                syntaxOffset)
                {
                    var return_v = this_param.AssignLocalOrdinal(localKind, syntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61301, 61370);
                    return return_v;
                }


                int
                f_10967_61454_61529(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61454, 61529);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDebugId
                f_10967_61560_61599(int
                syntaxOffset, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(syntaxOffset, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61560, 61599);
                    return return_v;
                }


                string?
                f_10967_61638_61648(Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 61638, 61648);
                    return return_v;
                }


                string
                f_10967_61652_61721(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, ref int
                uniqueId)
                {
                    var return_v = GeneratedNames.MakeSynthesizedLocalName(kind, ref uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61652, 61721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 59952, 61733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 59952, 61733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSlotReusable(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 61745, 61908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 61816, 61897);

                return f_10967_61823_61896(f_10967_61823_61844(local), _ilEmitStyle != ILEmitStyle.Release);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 61745, 61908);

                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10967_61823_61844(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 61823, 61844);
                    return return_v;
                }


                bool
                f_10967_61823_61896(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, bool
                isDebug)
                {
                    var return_v = kind.IsSlotReusable(isDebug);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 61823, 61896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 61745, 61908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 61745, 61908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FreeLocal(LocalSymbol local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 61998, 62291);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 62117, 62280) || true) && (f_10967_62121_62131(local) == null && (DynAbs.Tracing.TraceSender.Expression_True(10967, 62121, 62164) && f_10967_62143_62164(this, local)) && (DynAbs.Tracing.TraceSender.Expression_True(10967, 62121, 62188) && !f_10967_62169_62188(this, local)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 62117, 62280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 62222, 62265);

                    f_10967_62222_62264(_builder.LocalSlotManager, local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 62117, 62280);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 61998, 62291);

                string
                f_10967_62121_62131(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 62121, 62131);
                    return return_v;
                }


                bool
                f_10967_62143_62164(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsSlotReusable(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62143, 62164);
                    return return_v;
                }


                bool
                f_10967_62169_62188(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62169, 62188);
                    return return_v;
                }


                int
                f_10967_62222_62264(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    this_param.FreeLocal((Microsoft.CodeAnalysis.Symbols.ILocalSymbolInternal)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62222, 62264);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 61998, 62291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 61998, 62291);
            }
        }

        private LocalDefinition AllocateTemp(TypeSymbol type, SyntaxNode syntaxNode, LocalSlotConstraints slotConstraints = LocalSlotConstraints.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 62398, 62725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 62565, 62714);

                return f_10967_62572_62713(_builder.LocalSlotManager, f_10967_62629_62678(_module, type, syntaxNode, _diagnostics), slotConstraints);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 62398, 62725);

                Microsoft.Cci.ITypeReference
                f_10967_62629_62678(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62629, 62678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10967_62572_62713(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.Cci.ITypeReference
                type, Microsoft.CodeAnalysis.LocalSlotConstraints
                constraints)
                {
                    var return_v = this_param.AllocateSlot(type, constraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62572, 62713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 62398, 62725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 62398, 62725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FreeTemp(LocalDefinition temp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 62811, 62931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 62879, 62920);

                f_10967_62879_62919(_builder.LocalSlotManager, temp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 62811, 62931);

                int
                f_10967_62879_62919(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                slot)
                {
                    this_param.FreeSlot(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 62879, 62919);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 62811, 62931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 62811, 62931);
            }
        }

        private void FreeOptTemp(LocalDefinition temp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 63027, 63189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 63098, 63178) || true) && (temp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 63098, 63178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 63148, 63163);

                    f_10967_63148_63162(this, temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 63098, 63178);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 63027, 63189);

                int
                f_10967_63148_63162(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 63148, 63162);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 63027, 63189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 63027, 63189);
            }
        }
        private class FinallyCloner : BoundTreeRewriterWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            private Dictionary<LabelSymbol, GeneratedLabelSymbol> _labelClones;

            private FinallyCloner()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10967, 63670, 63697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 63641, 63653);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10967, 63670, 63697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 63670, 63697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 63670, 63697);
                }
            }

            public static BoundBlock MakeFinallyClone(BoundTryStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10967, 63969, 64187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64067, 64100);

                    var
                    cloner = f_10967_64080_64099()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64118, 64172);

                    return (BoundBlock)f_10967_64137_64171(cloner, f_10967_64150_64170(node));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10967, 63969, 64187);

                    Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    f_10967_64080_64099()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64080, 64099);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    f_10967_64150_64170(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                    this_param)
                    {
                        var return_v = this_param.FinallyBlockOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 64150, 64170);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10967_64137_64171(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64137, 64171);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 63969, 64187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 63969, 64187);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLabelStatement(BoundLabelStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 64203, 64368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64307, 64353);

                    return f_10967_64314_64352(node, f_10967_64326_64351(this, f_10967_64340_64350(node)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 64203, 64368);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10967_64340_64350(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 64340, 64350);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_64326_64351(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.GetLabelClone(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64326, 64351);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10967_64314_64352(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    label)
                    {
                        var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64314, 64352);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 64203, 64368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 64203, 64368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitGotoStatement(BoundGotoStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 64384, 64919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64486, 64529);

                    var
                    labelClone = f_10967_64503_64528(this, f_10967_64517_64527(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64615, 64674);

                    BoundExpression
                    caseExpressionOpt = f_10967_64651_64673(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64758, 64814);

                    BoundLabel
                    labelExpressionOpt = f_10967_64790_64813(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 64834, 64904);

                    return f_10967_64841_64903(node, labelClone, caseExpressionOpt, labelExpressionOpt);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 64384, 64919);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10967_64517_64527(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 64517, 64527);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_64503_64528(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.GetLabelClone(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64503, 64528);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10967_64651_64673(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    this_param)
                    {
                        var return_v = this_param.CaseExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 64651, 64673);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabel?
                    f_10967_64790_64813(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    this_param)
                    {
                        var return_v = this_param.LabelExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 64790, 64813);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10967_64841_64903(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    label, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    caseExpressionOpt, Microsoft.CodeAnalysis.CSharp.BoundLabel?
                    labelExpressionOpt)
                    {
                        var return_v = this_param.Update((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label, caseExpressionOpt, labelExpressionOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 64841, 64903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 64384, 64919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 64384, 64919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 64935, 65307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65041, 65084);

                    var
                    labelClone = f_10967_65058_65083(this, f_10967_65072_65082(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65170, 65213);

                    BoundExpression
                    condition = f_10967_65198_65212(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65233, 65292);

                    return f_10967_65240_65291(node, condition, f_10967_65263_65278(node), labelClone);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 64935, 65307);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10967_65072_65082(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65072, 65082);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_65058_65083(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.GetLabelClone(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65058, 65083);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10967_65198_65212(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                    this_param)
                    {
                        var return_v = this_param.Condition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65198, 65212);
                        return return_v;
                    }


                    bool
                    f_10967_65263_65278(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                    this_param)
                    {
                        var return_v = this_param.JumpIfTrue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65263, 65278);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                    f_10967_65240_65291(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    condition, bool
                    jumpIfTrue, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    label)
                    {
                        var return_v = this_param.Update(condition, jumpIfTrue, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65240, 65291);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 64935, 65307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 64935, 65307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitSwitchDispatch(BoundSwitchDispatch node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 65323, 66008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65493, 65538);

                    BoundExpression
                    expression = f_10967_65522_65537(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65558, 65610);

                    var
                    defaultClone = f_10967_65577_65609(this, f_10967_65591_65608(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65628, 65704);

                    var
                    casesBuilder = f_10967_65647_65703()
                    ;
                    foreach (var (value, label) in f_10967_65753_65763(node))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65805, 65853);

                        f_10967_65805_65852(casesBuilder, (value, f_10967_65830_65850(this, label)));
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 65892, 65993);

                    return f_10967_65899_65992(node, expression, f_10967_65923_65956(casesBuilder), defaultClone, f_10967_65972_65991(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 65323, 66008);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10967_65522_65537(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65522, 65537);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10967_65591_65608(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    this_param)
                    {
                        var return_v = this_param.DefaultLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65591, 65608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_65577_65609(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.GetLabelClone(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65577, 65609);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)>
                    f_10967_65647_65703()
                    {
                        var return_v = ArrayBuilder<(ConstantValue, LabelSymbol)>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65647, 65703);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol label)>
                    f_10967_65753_65763(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    this_param)
                    {
                        var return_v = this_param.Cases;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65753, 65763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_65830_65850(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.FinallyCloner
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.GetLabelClone(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65830, 65850);
                        return return_v;
                    }


                    int
                    f_10967_65805_65852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)>
                    this_param, (Microsoft.CodeAnalysis.ConstantValue value, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)
                    item)
                    {
                        this_param.Add(((Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol))item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65805, 65852);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)>
                    f_10967_65923_65956(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65923, 65956);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10967_65972_65991(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    this_param)
                    {
                        var return_v = this_param.EqualityMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 65972, 65991);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    f_10967_65899_65992(Microsoft.CodeAnalysis.CSharp.BoundSwitchDispatch
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.ConstantValue, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)>
                    cases, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    equalityMethod)
                    {
                        var return_v = this_param.Update(expression, cases, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)defaultLabel, equalityMethod);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 65899, 65992);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 65323, 66008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 65323, 66008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 66024, 66231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66204, 66216);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 66024, 66231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 66024, 66231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 66024, 66231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private GeneratedLabelSymbol GetLabelClone(LabelSymbol label)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10967, 66247, 66884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66341, 66372);

                    var
                    labelClones = _labelClones
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66390, 66555) || true) && (labelClones == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 66390, 66555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66455, 66536);

                        _labelClones = labelClones = f_10967_66484_66535();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 66390, 66555);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66575, 66602);

                    GeneratedLabelSymbol
                    clone
                    = default(GeneratedLabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66620, 66836) || true) && (!f_10967_66625_66666(labelClones, label, out clone))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10967, 66620, 66836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66708, 66765);

                        clone = f_10967_66716_66764("cloned_" + f_10967_66753_66763(label));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66787, 66817);

                        f_10967_66787_66816(labelClones, label, clone);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10967, 66620, 66836);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10967, 66856, 66869);

                    return clone;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10967, 66247, 66884);

                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol>
                    f_10967_66484_66535()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 66484, 66535);
                        return return_v;
                    }


                    bool
                    f_10967_66625_66666(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 66625, 66666);
                        return return_v;
                    }


                    string
                    f_10967_66753_66763(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10967, 66753, 66763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10967_66716_66764(string
                    name)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 66716, 66764);
                        return return_v;
                    }


                    int
                    f_10967_66787_66816(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10967, 66787, 66816);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10967, 66247, 66884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 66247, 66884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static FinallyCloner()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10967, 63460, 66895);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10967, 63460, 66895);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10967, 63460, 66895);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10967, 63460, 66895);
        }
    }
}
