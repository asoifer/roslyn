// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private void EmitUnaryOperatorExpression(BoundUnaryOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 518, 1808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 625, 668);

                var
                operatorKind = f_10965_644_667(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 684, 839) || true) && (f_10965_688_712(operatorKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 684, 839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 746, 799);

                    f_10965_746_798(this, expression, used);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 817, 824);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 684, 839);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 855, 986) || true) && (!used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 855, 986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 898, 946);

                    f_10965_898_945(this, f_10965_913_931(expression), used: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 964, 971);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 855, 986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1002, 1180) || true) && (operatorKind == UnaryOperatorKind.BoolLogicalNegation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1002, 1180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1093, 1140);

                    f_10965_1093_1139(this, f_10965_1106_1124(expression), sense: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1158, 1165);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1002, 1180);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1196, 1243);

                f_10965_1196_1242(this, f_10965_1211_1229(expression), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1257, 1797);

                switch (f_10965_1265_1288(operatorKind))
                {

                    case UnaryOperatorKind.UnaryMinus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1257, 1797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1378, 1412);

                        f_10965_1378_1411(_builder, ILOpCode.Neg);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 1434, 1440);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1257, 1797);

                    case UnaryOperatorKind.BitwiseComplement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1257, 1797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1523, 1557);

                        f_10965_1523_1556(_builder, ILOpCode.Not);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 1579, 1585);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1257, 1797);

                    case UnaryOperatorKind.UnaryPlus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1257, 1797);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 1660, 1666);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1257, 1797);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1257, 1797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1716, 1782);

                        throw f_10965_1722_1781(f_10965_1757_1780(operatorKind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1257, 1797);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 518, 1808);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_644_667(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 644, 667);
                    return return_v;
                }


                bool
                f_10965_688_712(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 688, 712);
                    return return_v;
                }


                int
                f_10965_746_798(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                expression, bool
                used)
                {
                    this_param.EmitUnaryCheckedOperatorExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 746, 798);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_913_931(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 913, 931);
                    return return_v;
                }


                int
                f_10965_898_945(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 898, 945);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_1106_1124(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 1106, 1124);
                    return return_v;
                }


                int
                f_10965_1093_1139(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                sense)
                {
                    this_param.EmitCondExpr(condition, sense: sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1093, 1139);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_1211_1229(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 1211, 1229);
                    return return_v;
                }


                int
                f_10965_1196_1242(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1196, 1242);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_1265_1288(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1265, 1288);
                    return return_v;
                }


                int
                f_10965_1378_1411(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1378, 1411);
                    return 0;
                }


                int
                f_10965_1523_1556(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1523, 1556);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_1757_1780(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1757, 1780);
                    return return_v;
                }


                System.Exception
                f_10965_1722_1781(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1722, 1781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 518, 1808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 518, 1808);
            }
        }

        private void EmitBinaryOperatorExpression(BoundBinaryOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 1820, 2961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1929, 1972);

                var
                operatorKind = f_10965_1948_1971(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 1988, 2912) || true) && (f_10965_1992_2032(operatorKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1988, 2912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2066, 2097);

                    f_10965_2066_2096(this, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1988, 2912);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 1988, 2912);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2361, 2631) || true) && (!used && (DynAbs.Tracing.TraceSender.Expression_True(10965, 2365, 2399) && !f_10965_2375_2399(operatorKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10965, 2365, 2440) && !f_10965_2404_2440(operatorKind)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 2361, 2631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2482, 2521);

                        f_10965_2482_2520(this, f_10965_2497_2512(expression), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2543, 2583);

                        f_10965_2543_2582(this, f_10965_2558_2574(expression), false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2605, 2612);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 2361, 2631);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2651, 2897) || true) && (f_10965_2655_2682(operatorKind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 2651, 2897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2724, 2765);

                        f_10965_2724_2764(this, expression, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 2651, 2897);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 2651, 2897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2847, 2878);

                        f_10965_2847_2877(this, expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 2651, 2897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 1988, 2912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 2928, 2950);

                f_10965_2928_2949(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 1820, 2961);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_1948_1971(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 1948, 1971);
                    return return_v;
                }


                bool
                f_10965_1992_2032(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.EmitsAsCheckedInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 1992, 2032);
                    return return_v;
                }


                int
                f_10965_2066_2096(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperator(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2066, 2096);
                    return 0;
                }


                bool
                f_10965_2375_2399(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2375, 2399);
                    return return_v;
                }


                bool
                f_10965_2404_2440(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = OperatorHasSideEffects(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2404, 2440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_2497_2512(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 2497, 2512);
                    return return_v;
                }


                int
                f_10965_2482_2520(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2482, 2520);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_2558_2574(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 2558, 2574);
                    return return_v;
                }


                int
                f_10965_2543_2582(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2543, 2582);
                    return 0;
                }


                bool
                f_10965_2655_2682(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind)
                {
                    var return_v = IsConditional(opKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2655, 2682);
                    return return_v;
                }


                int
                f_10965_2724_2764(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                binOp, bool
                sense)
                {
                    this_param.EmitBinaryCondOperator(binOp, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2724, 2764);
                    return 0;
                }


                int
                f_10965_2847_2877(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperator(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2847, 2877);
                    return 0;
                }


                int
                f_10965_2928_2949(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 2928, 2949);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 1820, 2961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 1820, 2961);
            }
        }

        private void EmitBinaryOperator(BoundBinaryOperator expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 2973, 5127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3061, 3101);

                BoundExpression
                child = f_10965_3085_3100(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3117, 3301) || true) && (f_10965_3121_3131(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10965, 3121, 3190) || f_10965_3163_3182(child) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 3117, 3301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3224, 3261);

                    f_10965_3224_3260(this, expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3279, 3286);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 3117, 3301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3317, 3373);

                BoundBinaryOperator
                binary = (BoundBinaryOperator)child
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3387, 3426);

                var
                operatorKind = f_10965_3406_3425(binary)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3442, 3629) || true) && (!f_10965_3447_3487(operatorKind) && (DynAbs.Tracing.TraceSender.Expression_True(10965, 3446, 3518) && f_10965_3491_3518(operatorKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 3442, 3629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3552, 3589);

                    f_10965_3552_3588(this, expression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3607, 3614);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 3442, 3629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3720, 3780);

                var
                stack = f_10965_3732_3779()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3794, 3817);

                f_10965_3794_3816(stack, expression);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3833, 4382) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 3833, 4382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3878, 3897);

                        f_10965_3878_3896(stack, binary);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3915, 3935);

                        child = f_10965_3923_3934(binary);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 3955, 4095) || true) && (f_10965_3959_3969(child) != BoundKind.BinaryOperator || (DynAbs.Tracing.TraceSender.Expression_False(10965, 3959, 4028) || f_10965_4001_4020(child) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 3955, 4095);
                            DynAbs.Tracing.TraceSender.TraceBreak(10965, 4070, 4076);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 3955, 4095);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4115, 4151);

                        binary = (BoundBinaryOperator)child;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4169, 4204);

                        operatorKind = f_10965_4184_4203(binary);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4224, 4367) || true) && (!f_10965_4229_4269(operatorKind) && (DynAbs.Tracing.TraceSender.Expression_True(10965, 4228, 4300) && f_10965_4273_4300(operatorKind)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 4224, 4367);
                            DynAbs.Tracing.TraceSender.TraceBreak(10965, 4342, 4348);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 4224, 4367);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 3833, 4382);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10965, 3833, 4382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10965, 3833, 4382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4398, 4426);

                f_10965_4398_4425(this, child, true);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 4442, 5030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4477, 4498);

                            binary = f_10965_4486_4497(stack);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4518, 4553);

                            f_10965_4518_4552(this, f_10965_4533_4545(binary), true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4571, 4636);

                            bool
                            isChecked = f_10965_4588_4635(f_10965_4588_4607(binary))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4654, 4893) || true) && (isChecked)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 4654, 4893);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4709, 4754);

                                f_10965_4709_4753(this, binary);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 4654, 4893);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 4654, 4893);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4836, 4874);

                                f_10965_4836_4873(this, binary);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 4654, 4893);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4913, 4977);

                            f_10965_4913_4976(this, binary, @checked: isChecked);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 4442, 5030);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 4442, 5030) || true) && (f_10965_5013_5024(stack) > 0)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10965, 4442, 5030);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10965, 4442, 5030);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5046, 5089);

                f_10965_5046_5088((object)binary == expression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5103, 5116);

                f_10965_5103_5115(stack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 2973, 5127);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_3085_3100(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3085, 3100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10965_3121_3131(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3121, 3131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10965_3163_3182(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3163, 3182);
                    return return_v;
                }


                int
                f_10965_3224_3260(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperatorSimple(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3224, 3260);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_3406_3425(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3406, 3425);
                    return return_v;
                }


                bool
                f_10965_3447_3487(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.EmitsAsCheckedInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3447, 3487);
                    return return_v;
                }


                bool
                f_10965_3491_3518(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind)
                {
                    var return_v = IsConditional(opKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3491, 3518);
                    return return_v;
                }


                int
                f_10965_3552_3588(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperatorSimple(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3552, 3588);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                f_10965_3732_3779()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3732, 3779);
                    return return_v;
                }


                int
                f_10965_3794_3816(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3794, 3816);
                    return 0;
                }


                int
                f_10965_3878_3896(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 3878, 3896);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_3923_3934(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3923, 3934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10965_3959_3969(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 3959, 3969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10965_4001_4020(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 4001, 4020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_4184_4203(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 4184, 4203);
                    return return_v;
                }


                bool
                f_10965_4229_4269(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.EmitsAsCheckedInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4229, 4269);
                    return return_v;
                }


                bool
                f_10965_4273_4300(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind)
                {
                    var return_v = IsConditional(opKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4273, 4300);
                    return return_v;
                }


                int
                f_10965_4398_4425(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4398, 4425);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10965_4486_4497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4486, 4497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_4533_4545(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 4533, 4545);
                    return return_v;
                }


                int
                f_10965_4518_4552(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4518, 4552);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_4588_4607(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 4588, 4607);
                    return return_v;
                }


                bool
                f_10965_4588_4635(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.EmitsAsCheckedInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4588, 4635);
                    return return_v;
                }


                int
                f_10965_4709_4753(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryCheckedOperatorInstruction(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4709, 4753);
                    return 0;
                }


                int
                f_10965_4836_4873(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperatorInstruction(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4836, 4873);
                    return 0;
                }


                int
                f_10965_4913_4976(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression, bool
                @checked)
                {
                    this_param.EmitConversionToEnumUnderlyingType(expression, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 4913, 4976);
                    return 0;
                }


                int
                f_10965_5013_5024(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 5013, 5024);
                    return return_v;
                }


                int
                f_10965_5046_5088(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5046, 5088);
                    return 0;
                }


                int
                f_10965_5103_5115(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5103, 5115);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 2973, 5127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 2973, 5127);
            }
        }

        private void EmitBinaryOperatorSimple(BoundBinaryOperator expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 5139, 5737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5233, 5271);

                f_10965_5233_5270(this, f_10965_5248_5263(expression), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5285, 5324);

                f_10965_5285_5323(this, f_10965_5300_5316(expression), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5340, 5409);

                bool
                isChecked = f_10965_5357_5408(f_10965_5357_5380(expression))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5423, 5642) || true) && (isChecked)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5423, 5642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5470, 5519);

                    f_10965_5470_5518(this, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5423, 5642);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5423, 5642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5585, 5627);

                    f_10965_5585_5626(this, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5423, 5642);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5658, 5726);

                f_10965_5658_5725(this, expression, @checked: isChecked);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 5139, 5737);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_5248_5263(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 5248, 5263);
                    return return_v;
                }


                int
                f_10965_5233_5270(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5233, 5270);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_5300_5316(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 5300, 5316);
                    return return_v;
                }


                int
                f_10965_5285_5323(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5285, 5323);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_5357_5380(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 5357, 5380);
                    return return_v;
                }


                bool
                f_10965_5357_5408(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.EmitsAsCheckedInstruction();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5357, 5408);
                    return return_v;
                }


                int
                f_10965_5470_5518(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryCheckedOperatorInstruction(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5470, 5518);
                    return 0;
                }


                int
                f_10965_5585_5626(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    this_param.EmitBinaryOperatorInstruction(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5585, 5626);
                    return 0;
                }


                int
                f_10965_5658_5725(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression, bool
                @checked)
                {
                    this_param.EmitConversionToEnumUnderlyingType(expression, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5658, 5725);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 5139, 5737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 5139, 5737);
            }
        }

        private void EmitBinaryOperatorInstruction(BoundBinaryOperator expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 5749, 8167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5848, 8156);

                switch (f_10965_5856_5890(f_10965_5856_5879(expression)))
                {

                    case BinaryOperatorKind.Multiplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 5985, 6019);

                        f_10965_5985_6018(_builder, ILOpCode.Mul);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 6041, 6047);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6122, 6156);

                        f_10965_6122_6155(_builder, ILOpCode.Add);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 6178, 6184);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6262, 6296);

                        f_10965_6262_6295(_builder, ILOpCode.Sub);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 6318, 6324);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Division:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6399, 6681) || true) && (f_10965_6403_6439(expression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 6399, 6681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6489, 6526);

                            f_10965_6489_6525(_builder, ILOpCode.Div_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 6399, 6681);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 6399, 6681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6624, 6658);

                            f_10965_6624_6657(_builder, ILOpCode.Div);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 6399, 6681);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 6703, 6709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Remainder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6785, 7067) || true) && (f_10965_6789_6825(expression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 6785, 7067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 6875, 6912);

                            f_10965_6875_6911(_builder, ILOpCode.Rem_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 6785, 7067);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 6785, 7067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7010, 7044);

                            f_10965_7010_7043(_builder, ILOpCode.Rem);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 6785, 7067);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 7089, 7095);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.LeftShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7171, 7205);

                        f_10965_7171_7204(_builder, ILOpCode.Shl);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 7227, 7233);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.RightShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7310, 7592) || true) && (f_10965_7314_7350(expression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 7310, 7592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7400, 7437);

                            f_10965_7400_7436(_builder, ILOpCode.Shr_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 7310, 7592);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 7310, 7592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7535, 7569);

                            f_10965_7535_7568(_builder, ILOpCode.Shr);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 7310, 7592);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 7614, 7620);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7690, 7724);

                        f_10965_7690_7723(_builder, ILOpCode.And);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 7746, 7752);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7822, 7856);

                        f_10965_7822_7855(_builder, ILOpCode.Xor);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 7878, 7884);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    case BinaryOperatorKind.Or:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 7953, 7986);

                        f_10965_7953_7985(_builder, ILOpCode.Or);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 8008, 8014);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 5848, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 8064, 8141);

                        throw f_10965_8070_8140(f_10965_8105_8139(f_10965_8105_8128(expression)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 5848, 8156);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 5749, 8167);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_5856_5879(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 5856, 5879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_5856_5890(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5856, 5890);
                    return return_v;
                }


                int
                f_10965_5985_6018(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 5985, 6018);
                    return 0;
                }


                int
                f_10965_6122_6155(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6122, 6155);
                    return 0;
                }


                int
                f_10965_6262_6295(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6262, 6295);
                    return 0;
                }


                bool
                f_10965_6403_6439(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                op)
                {
                    var return_v = IsUnsignedBinaryOperator(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6403, 6439);
                    return return_v;
                }


                int
                f_10965_6489_6525(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6489, 6525);
                    return 0;
                }


                int
                f_10965_6624_6657(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6624, 6657);
                    return 0;
                }


                bool
                f_10965_6789_6825(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                op)
                {
                    var return_v = IsUnsignedBinaryOperator(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6789, 6825);
                    return return_v;
                }


                int
                f_10965_6875_6911(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 6875, 6911);
                    return 0;
                }


                int
                f_10965_7010_7043(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7010, 7043);
                    return 0;
                }


                int
                f_10965_7171_7204(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7171, 7204);
                    return 0;
                }


                bool
                f_10965_7314_7350(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                op)
                {
                    var return_v = IsUnsignedBinaryOperator(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7314, 7350);
                    return return_v;
                }


                int
                f_10965_7400_7436(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7400, 7436);
                    return 0;
                }


                int
                f_10965_7535_7568(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7535, 7568);
                    return 0;
                }


                int
                f_10965_7690_7723(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7690, 7723);
                    return 0;
                }


                int
                f_10965_7822_7855(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7822, 7855);
                    return 0;
                }


                int
                f_10965_7953_7985(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 7953, 7985);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_8105_8128(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 8105, 8128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_8105_8139(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 8105, 8139);
                    return return_v;
                }


                System.Exception
                f_10965_8070_8140(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 8070, 8140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 5749, 8167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 5749, 8167);
            }
        }

        private void EmitShortCircuitingOperator(BoundBinaryOperator condition, bool sense, bool stopSense, bool stopValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 8179, 9523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 8736, 8766);

                object
                lazyFallThrough = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 8782, 8845);

                f_10965_8782_8844(this, f_10965_8797_8811(condition), ref lazyFallThrough, stopSense);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 8859, 8896);

                f_10965_8859_8895(this, f_10965_8872_8887(condition), sense);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9053, 9136) || true) && (lazyFallThrough == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 9053, 9136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9114, 9121);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 9053, 9136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9152, 9178);

                var
                labEnd = f_10965_9165_9177()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9192, 9233);

                f_10965_9192_9232(_builder, ILOpCode.Br, labEnd);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9343, 9368);

                f_10965_9343_9367(
                            // if we get to fallThrough, we should not have Right on stack. Adjust for that.
                            _builder, -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9384, 9420);

                f_10965_9384_9419(
                            _builder, lazyFallThrough);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9434, 9471);

                f_10965_9434_9470(_builder, stopValue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 9485, 9512);

                f_10965_9485_9511(_builder, labEnd);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 8179, 9523);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_8797_8811(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 8797, 8811);
                    return return_v;
                }


                int
                f_10965_8782_8844(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object?
                dest, bool
                sense)
                {
                    this_param.EmitCondBranch(condition, ref dest, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 8782, 8844);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_8872_8887(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 8872, 8887);
                    return return_v;
                }


                int
                f_10965_8859_8895(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, bool
                sense)
                {
                    this_param.EmitCondExpr(condition, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 8859, 8895);
                    return 0;
                }


                object
                f_10965_9165_9177()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9165, 9177);
                    return return_v;
                }


                int
                f_10965_9192_9232(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9192, 9232);
                    return 0;
                }


                int
                f_10965_9343_9367(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9343, 9367);
                    return 0;
                }


                int
                f_10965_9384_9419(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9384, 9419);
                    return 0;
                }


                int
                f_10965_9434_9470(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                value)
                {
                    this_param.EmitBoolConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9434, 9470);
                    return 0;
                }


                int
                f_10965_9485_9511(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 9485, 9511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 8179, 9523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 8179, 9523);
            }
        }

        private static readonly ILOpCode[] s_compOpCodes;

        //NOTE: The result of this should be a boolean on the stack.
        private void EmitBinaryCondOperator(BoundBinaryOperator binOp, bool sense)
        {
            bool andOrSense = sense;
            int opIdx;

            switch (binOp.OperatorKind.OperatorWithLogical())
            {
                case BinaryOperatorKind.LogicalOr:
                    Debug.Assert(binOp.Left.Type.SpecialType == SpecialType.System_Boolean);
                    Debug.Assert(binOp.Right.Type.SpecialType == SpecialType.System_Boolean);

                    // Rewrite (a || b) as ~(~a && ~b)
                    andOrSense = !andOrSense;
                    // Fall through
                    goto case BinaryOperatorKind.LogicalAnd;

                case BinaryOperatorKind.LogicalAnd:
                    Debug.Assert(binOp.Left.Type.SpecialType == SpecialType.System_Boolean);
                    Debug.Assert(binOp.Right.Type.SpecialType == SpecialType.System_Boolean);

                    // ~(a && b) is equivalent to (~a || ~b)
                    if (!andOrSense)
                    {
                        // generate (~a || ~b)
                        EmitShortCircuitingOperator(binOp, sense, sense, true);
                    }
                    else
                    {
                        // generate (a && b)
                        EmitShortCircuitingOperator(binOp, sense, !sense, false);
                    }
                    return;

                case BinaryOperatorKind.And:
                    Debug.Assert(binOp.Left.Type.SpecialType == SpecialType.System_Boolean);
                    Debug.Assert(binOp.Right.Type.SpecialType == SpecialType.System_Boolean);
                    EmitBinaryCondOperatorHelper(ILOpCode.And, binOp.Left, binOp.Right, sense);
                    return;

                case BinaryOperatorKind.Or:
                    Debug.Assert(binOp.Left.Type.SpecialType == SpecialType.System_Boolean);
                    Debug.Assert(binOp.Right.Type.SpecialType == SpecialType.System_Boolean);
                    EmitBinaryCondOperatorHelper(ILOpCode.Or, binOp.Left, binOp.Right, sense);
                    return;

                case BinaryOperatorKind.Xor:
                    Debug.Assert(binOp.Left.Type.SpecialType == SpecialType.System_Boolean);
                    Debug.Assert(binOp.Right.Type.SpecialType == SpecialType.System_Boolean);

                    // Xor is equivalent to not equal.
                    if (sense)
                        EmitBinaryCondOperatorHelper(ILOpCode.Xor, binOp.Left, binOp.Right, true);
                    else
                        EmitBinaryCondOperatorHelper(ILOpCode.Ceq, binOp.Left, binOp.Right, true);
                    return;

                case BinaryOperatorKind.NotEqual:
                    // neq  is emitted as  !eq
                    sense = !sense;
                    goto case BinaryOperatorKind.Equal;

                case BinaryOperatorKind.Equal:

                    var constant = binOp.Left.ConstantValue;
                    var comparand = binOp.Right;

                    if (constant == null)
                    {
                        constant = comparand.ConstantValue;
                        comparand = binOp.Left;
                    }

                    if (constant != null)
                    {
                        if (constant.IsDefaultValue)
                        {
                            if (!constant.IsFloating)
                            {
                                if (sense)
                                {
                                    EmitIsNullOrZero(comparand, constant);
                                }
                                else
                                {
                                    //  obj != null/0   for pointers and integral numerics is emitted as cgt.un
                                    EmitIsNotNullOrZero(comparand, constant);
                                }
                                return;
                            }
                        }
                        else if (constant.IsBoolean)
                        {
                            // treat  "x = True" ==> "x"
                            EmitExpression(comparand, true);
                            EmitIsSense(sense);
                            return;
                        }
                    }

                    EmitBinaryCondOperatorHelper(ILOpCode.Ceq, binOp.Left, binOp.Right, sense);
                    return;

                case BinaryOperatorKind.LessThan:
                    opIdx = 0;
                    break;

                case BinaryOperatorKind.LessThanOrEqual:
                    opIdx = 1;
                    sense = !sense; // lte is emitted as !gt 
                    break;

                case BinaryOperatorKind.GreaterThan:
                    opIdx = 2;
                    break;

                case BinaryOperatorKind.GreaterThanOrEqual:
                    opIdx = 3;
                    sense = !sense; // gte is emitted as !lt 
                    break;

                default:
                    throw ExceptionUtilities.UnexpectedValue(binOp.OperatorKind.OperatorWithLogical());
            }

            if (IsUnsignedBinaryOperator(binOp))
            {
                opIdx += 4;
            }
            else if (IsFloat(binOp.OperatorKind))
            {
                opIdx += 8;
            }

            EmitBinaryCondOperatorHelper(s_compOpCodes[opIdx], binOp.Left, binOp.Right, sense);
            return;
        }

        private void EmitIsNotNullOrZero(BoundExpression comparand, ConstantValue nullOrZero)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 15790, 16277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 15900, 15932);

                f_10965_15900_15931(this, comparand, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 15948, 15983);

                var
                comparandType = f_10965_15968_15982(comparand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 15997, 16160) || true) && (f_10965_16001_16030(comparandType) && (DynAbs.Tracing.TraceSender.Expression_True(10965, 16001, 16070) && !f_10965_16035_16070(comparandType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 15997, 16160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16104, 16145);

                    f_10965_16104_16144(this, comparandType, comparand.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 15997, 16160);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16176, 16215);

                f_10965_16176_16214(
                            _builder, nullOrZero);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16229, 16266);

                f_10965_16229_16265(_builder, ILOpCode.Cgt_un);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 15790, 16277);

                int
                f_10965_15900_15931(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 15900, 15931);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_15968_15982(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 15968, 15982);
                    return return_v;
                }


                bool
                f_10965_16001_16030(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 16001, 16030);
                    return return_v;
                }


                bool
                f_10965_16035_16070(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16035, 16070);
                    return return_v;
                }


                int
                f_10965_16104_16144(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16104, 16144);
                    return 0;
                }


                int
                f_10965_16176_16214(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16176, 16214);
                    return 0;
                }


                int
                f_10965_16229_16265(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16229, 16265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 15790, 16277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 15790, 16277);
            }
        }

        private void EmitIsNullOrZero(BoundExpression comparand, ConstantValue nullOrZero)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 16289, 16770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16396, 16428);

                f_10965_16396_16427(this, comparand, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16444, 16479);

                var
                comparandType = f_10965_16464_16478(comparand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16493, 16656) || true) && (f_10965_16497_16526(comparandType) && (DynAbs.Tracing.TraceSender.Expression_True(10965, 16497, 16566) && !f_10965_16531_16566(comparandType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 16493, 16656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16600, 16641);

                    f_10965_16600_16640(this, comparandType, comparand.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 16493, 16656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16672, 16711);

                f_10965_16672_16710(
                            _builder, nullOrZero);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16725, 16759);

                f_10965_16725_16758(_builder, ILOpCode.Ceq);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 16289, 16770);

                int
                f_10965_16396_16427(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16396, 16427);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_16464_16478(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 16464, 16478);
                    return return_v;
                }


                bool
                f_10965_16497_16526(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 16497, 16526);
                    return return_v;
                }


                bool
                f_10965_16531_16566(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16531, 16566);
                    return return_v;
                }


                int
                f_10965_16600_16640(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16600, 16640);
                    return 0;
                }


                int
                f_10965_16672_16710(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16672, 16710);
                    return 0;
                }


                int
                f_10965_16725_16758(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16725, 16758);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 16289, 16770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 16289, 16770);
            }
        }

        private void EmitBinaryCondOperatorHelper(ILOpCode opCode, BoundExpression left, BoundExpression right, bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 16782, 17077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16922, 16949);

                f_10965_16922_16948(this, left, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 16963, 16991);

                f_10965_16963_16990(this, right, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17005, 17033);

                f_10965_17005_17032(_builder, opCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17047, 17066);

                f_10965_17047_17065(this, sense);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 16782, 17077);

                int
                f_10965_16922_16948(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16922, 16948);
                    return 0;
                }


                int
                f_10965_16963_16990(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 16963, 16990);
                    return 0;
                }


                int
                f_10965_17005_17032(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 17005, 17032);
                    return 0;
                }


                int
                f_10965_17047_17065(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                sense)
                {
                    this_param.EmitIsSense(sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 17047, 17065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 16782, 17077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 16782, 17077);
            }
        }

        private void EmitCondExpr(BoundExpression condition, bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 17250, 18562);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17339, 17644) || true) && (f_10965_17346_17360(condition) == BoundKind.UnaryOperator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 17339, 17644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17421, 17462);

                        var
                        unOp = (BoundUnaryOperator)condition
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17480, 17553);

                        f_10965_17480_17552(f_10965_17493_17510(unOp) == UnaryOperatorKind.BoolLogicalNegation);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17571, 17596);

                        condition = f_10965_17583_17595(unOp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17614, 17629);

                        sense = !sense;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 17339, 17644);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10965, 17339, 17644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10965, 17339, 17644);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17660, 17731);

                f_10965_17660_17730(f_10965_17673_17699(f_10965_17673_17687(condition)) == SpecialType.System_Boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17747, 17791);

                var
                constantValue = f_10965_17767_17790(condition)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17805, 18111) || true) && (constantValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 17805, 18111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17864, 17948);

                    f_10965_17864_17947(f_10965_17877_17904(constantValue) == ConstantValueTypeDiscriminator.Boolean);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 17966, 18008);

                    var
                    constant = f_10965_17981_18007(constantValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18026, 18071);

                    f_10965_18026_18070(_builder, constant == sense);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18089, 18096);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 17805, 18111);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18127, 18447) || true) && (f_10965_18131_18145(condition) == BoundKind.BinaryOperator)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 18127, 18447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18207, 18250);

                    var
                    binOp = (BoundBinaryOperator)condition
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18268, 18432) || true) && (f_10965_18272_18305(f_10965_18286_18304(binOp)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 18268, 18432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18347, 18384);

                        f_10965_18347_18383(this, binOp, sense);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18406, 18413);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 18268, 18432);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 18127, 18447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18463, 18495);

                f_10965_18463_18494(this, condition, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18509, 18528);

                f_10965_18509_18527(this, sense);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18544, 18551);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 17250, 18562);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10965_17346_17360(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17346, 17360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_17493_17510(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17493, 17510);
                    return return_v;
                }


                int
                f_10965_17480_17552(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 17480, 17552);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_17583_17595(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17583, 17595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_17673_17687(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17673, 17687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_17673_17699(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17673, 17699);
                    return return_v;
                }


                int
                f_10965_17660_17730(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 17660, 17730);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10965_17767_17790(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17767, 17790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10965_17877_17904(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17877, 17904);
                    return return_v;
                }


                int
                f_10965_17864_17947(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 17864, 17947);
                    return 0;
                }


                bool
                f_10965_17981_18007(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.BooleanValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 17981, 18007);
                    return return_v;
                }


                int
                f_10965_18026_18070(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                value)
                {
                    this_param.EmitBoolConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18026, 18070);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10965_18131_18145(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 18131, 18145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_18286_18304(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 18286, 18304);
                    return return_v;
                }


                bool
                f_10965_18272_18305(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind)
                {
                    var return_v = IsConditional(opKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18272, 18305);
                    return return_v;
                }


                int
                f_10965_18347_18383(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                binOp, bool
                sense)
                {
                    this_param.EmitBinaryCondOperator(binOp, sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18347, 18383);
                    return 0;
                }


                int
                f_10965_18463_18494(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18463, 18494);
                    return 0;
                }


                int
                f_10965_18509_18527(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                sense)
                {
                    this_param.EmitIsSense(sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18509, 18527);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 17250, 18562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 17250, 18562);
            }
        }

        private void EmitUnaryCheckedOperatorExpression(BoundUnaryOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 18574, 20120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18688, 18769);

                f_10965_18688_18768(f_10965_18701_18735(f_10965_18701_18724(expression)) == UnaryOperatorKind.UnaryMinus);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 18783, 18833);

                var
                type = f_10965_18794_18832(f_10965_18794_18817(expression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 19559, 19637);

                f_10965_19559_19636(type == UnaryOperatorKind.Int || (DynAbs.Tracing.TraceSender.Expression_False(10965, 19572, 19635) || type == UnaryOperatorKind.Long));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 19780, 19819);

                f_10965_19780_19818(
                            // ldc.i4.0
                            // conv.i8  (when the operand is 64bit)
                            // <expr>
                            // sub.ovf

                            _builder, ILOpCode.Ldc_i4_0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 19835, 19956) || true) && (type == UnaryOperatorKind.Long)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 19835, 19956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 19903, 19941);

                    f_10965_19903_19940(_builder, ILOpCode.Conv_i8);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 19835, 19956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 19972, 20019);

                f_10965_19972_20018(this, f_10965_19987_20005(expression), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 20033, 20071);

                f_10965_20033_20070(_builder, ILOpCode.Sub_ovf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 20087, 20109);

                f_10965_20087_20108(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 18574, 20120);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_18701_18724(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 18701, 18724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_18701_18735(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18701, 18735);
                    return return_v;
                }


                int
                f_10965_18688_18768(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18688, 18768);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_18794_18817(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 18794, 18817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10965_18794_18832(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 18794, 18832);
                    return return_v;
                }


                int
                f_10965_19559_19636(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 19559, 19636);
                    return 0;
                }


                int
                f_10965_19780_19818(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 19780, 19818);
                    return 0;
                }


                int
                f_10965_19903_19940(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 19903, 19940);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_19987_20005(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 19987, 20005);
                    return return_v;
                }


                int
                f_10965_19972_20018(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 19972, 20018);
                    return 0;
                }


                int
                f_10965_20033_20070(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 20033, 20070);
                    return 0;
                }


                int
                f_10965_20087_20108(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 20087, 20108);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 18574, 20120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 18574, 20120);
            }
        }

        private void EmitConversionToEnumUnderlyingType(BoundBinaryOperator expression, bool @checked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 20132, 23713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 21451, 21471);

                TypeSymbol
                enumType
                = default(TypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 21487, 22545);

                switch (f_10965_21495_21529(f_10965_21495_21518(expression)) | f_10965_21532_21570(f_10965_21532_21555(expression)))
                {

                    case BinaryOperatorKind.EnumAndUnderlyingAddition:
                    case BinaryOperatorKind.EnumSubtraction:
                    case BinaryOperatorKind.EnumAndUnderlyingSubtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 21487, 22545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 21805, 21837);

                        enumType = f_10965_21816_21836(f_10965_21816_21831(expression));
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 21859, 21865);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 21487, 22545);

                    case BinaryOperatorKind.EnumAnd:
                    case BinaryOperatorKind.EnumOr:
                    case BinaryOperatorKind.EnumXor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 21487, 22545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22036, 22150);

                        f_10965_22036_22149(f_10965_22049_22148(f_10965_22067_22087(f_10965_22067_22082(expression)), f_10965_22089_22110(f_10965_22089_22105(expression)), TypeCompareKind.ConsiderEverything2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22172, 22188);

                        enumType = null;
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 22210, 22216);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 21487, 22545);

                    case BinaryOperatorKind.UnderlyingAndEnumSubtraction:
                    case BinaryOperatorKind.UnderlyingAndEnumAddition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 21487, 22545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22377, 22410);

                        enumType = f_10965_22388_22409(f_10965_22388_22404(expression));
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 22432, 22438);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 21487, 22545);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 21487, 22545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22486, 22502);

                        enumType = null;
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 22524, 22530);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 21487, 22545);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22561, 22645) || true) && ((object)enumType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 22561, 22645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22623, 22630);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 22561, 22645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22661, 22697);

                f_10965_22661_22696(f_10965_22674_22695(enumType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22713, 22777);

                SpecialType
                type = f_10965_22732_22776(f_10965_22732_22764(enumType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22791, 23702);

                switch (type)
                {

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 22791, 23702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 22888, 23007);

                        f_10965_22888_23006(_builder, Microsoft.Cci.PrimitiveTypeCode.Int32, Microsoft.Cci.PrimitiveTypeCode.UInt8, @checked);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 23029, 23035);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 22791, 23702);

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 22791, 23702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 23105, 23223);

                        f_10965_23105_23222(_builder, Microsoft.Cci.PrimitiveTypeCode.Int32, Microsoft.Cci.PrimitiveTypeCode.Int8, @checked);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 23245, 23251);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 22791, 23702);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 22791, 23702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 23321, 23440);

                        f_10965_23321_23439(_builder, Microsoft.Cci.PrimitiveTypeCode.Int32, Microsoft.Cci.PrimitiveTypeCode.Int16, @checked);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 23462, 23468);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 22791, 23702);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 22791, 23702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 23539, 23659);

                        f_10965_23539_23658(_builder, Microsoft.Cci.PrimitiveTypeCode.Int32, Microsoft.Cci.PrimitiveTypeCode.UInt16, @checked);
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 23681, 23687);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 22791, 23702);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 20132, 23713);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_21495_21518(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 21495, 21518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_21495_21529(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 21495, 21529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_21532_21555(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 21532, 21555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_21532_21570(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 21532, 21570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_21816_21831(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 21816, 21831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_21816_21836(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 21816, 21836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_22067_22082(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22067, 22082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_22067_22087(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22067, 22087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_22089_22105(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22089, 22105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_22089_22110(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22089, 22110);
                    return return_v;
                }


                bool
                f_10965_22049_22148(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22049, 22148);
                    return return_v;
                }


                int
                f_10965_22036_22149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22036, 22149);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_22388_22404(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22388, 22404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_22388_22409(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22388, 22409);
                    return return_v;
                }


                bool
                f_10965_22674_22695(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22674, 22695);
                    return return_v;
                }


                int
                f_10965_22661_22696(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22661, 22696);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10965_22732_22764(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22732, 22764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_22732_22776(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 22732, 22776);
                    return return_v;
                }


                int
                f_10965_22888_23006(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 22888, 23006);
                    return 0;
                }


                int
                f_10965_23105_23222(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 23105, 23222);
                    return 0;
                }


                int
                f_10965_23321_23439(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 23321, 23439);
                    return 0;
                }


                int
                f_10965_23539_23658(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 23539, 23658);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 20132, 23713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 20132, 23713);
            }
        }

        private void EmitBinaryCheckedOperatorInstruction(BoundBinaryOperator expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 23725, 25212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 23831, 23883);

                var
                unsigned = f_10965_23846_23882(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 23899, 25201);

                switch (f_10965_23907_23941(f_10965_23907_23930(expression)))
                {

                    case BinaryOperatorKind.Multiplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 23899, 25201);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24036, 24298) || true) && (unsigned)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24036, 24298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24098, 24139);

                            f_10965_24098_24138(_builder, ILOpCode.Mul_ovf_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24036, 24298);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24036, 24298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24237, 24275);

                            f_10965_24237_24274(_builder, ILOpCode.Mul_ovf);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24036, 24298);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 24320, 24326);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 23899, 25201);

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 23899, 25201);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24401, 24663) || true) && (unsigned)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24401, 24663);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24463, 24504);

                            f_10965_24463_24503(_builder, ILOpCode.Add_ovf_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24401, 24663);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24401, 24663);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24602, 24640);

                            f_10965_24602_24639(_builder, ILOpCode.Add_ovf);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24401, 24663);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 24685, 24691);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 23899, 25201);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 23899, 25201);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24769, 25031) || true) && (unsigned)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24769, 25031);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24831, 24872);

                            f_10965_24831_24871(_builder, ILOpCode.Sub_ovf_un);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24769, 25031);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 24769, 25031);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 24970, 25008);

                            f_10965_24970_25007(_builder, ILOpCode.Sub_ovf);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 24769, 25031);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10965, 25053, 25059);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 23899, 25201);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 23899, 25201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25109, 25186);

                        throw f_10965_25115_25185(f_10965_25150_25184(f_10965_25150_25173(expression)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 23899, 25201);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 23725, 25212);

                bool
                f_10965_23846_23882(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                op)
                {
                    var return_v = IsUnsignedBinaryOperator(op);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 23846, 23882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_23907_23930(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 23907, 23930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_23907_23941(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 23907, 23941);
                    return return_v;
                }


                int
                f_10965_24098_24138(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24098, 24138);
                    return 0;
                }


                int
                f_10965_24237_24274(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24237, 24274);
                    return 0;
                }


                int
                f_10965_24463_24503(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24463, 24503);
                    return 0;
                }


                int
                f_10965_24602_24639(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24602, 24639);
                    return 0;
                }


                int
                f_10965_24831_24871(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24831, 24871);
                    return 0;
                }


                int
                f_10965_24970_25007(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 24970, 25007);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_25150_25173(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 25150, 25173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_25150_25184(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25150, 25184);
                    return return_v;
                }


                System.Exception
                f_10965_25115_25185(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25115, 25185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 23725, 25212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 23725, 25212);
            }
        }

        private static bool OperatorHasSideEffects(BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10965, 25224, 25590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25316, 25579);

                switch (f_10965_25324_25339(kind))
                {

                    case BinaryOperatorKind.Division:
                    case BinaryOperatorKind.Remainder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 25316, 25579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25480, 25492);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 25316, 25579);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 25316, 25579);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25540, 25564);

                        return f_10965_25547_25563(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 25316, 25579);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10965, 25224, 25590);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_25324_25339(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25324, 25339);
                    return return_v;
                }


                bool
                f_10965_25547_25563(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25547, 25563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 25224, 25590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 25224, 25590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitIsSense(bool sense)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10965, 25699, 25921);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25760, 25910) || true) && (!sense)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 25760, 25910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25804, 25843);

                    f_10965_25804_25842(_builder, ILOpCode.Ldc_i4_0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 25861, 25895);

                    f_10965_25861_25894(_builder, ILOpCode.Ceq);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 25760, 25910);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10965, 25699, 25921);

                int
                f_10965_25804_25842(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25804, 25842);
                    return 0;
                }


                int
                f_10965_25861_25894(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 25861, 25894);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 25699, 25921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 25699, 25921);
            }
        }

        private static bool IsUnsigned(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10965, 25933, 26315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26006, 26277);

                switch (type)
                {

                    case SpecialType.System_Byte:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 26006, 26277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26250, 26262);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 26006, 26277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26291, 26304);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10965, 25933, 26315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 25933, 26315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 25933, 26315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsUnsignedBinaryOperator(BoundBinaryOperator op)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10965, 26327, 27930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26420, 26464);

                BinaryOperatorKind
                opKind = f_10965_26448_26463(op)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26478, 26526);

                BinaryOperatorKind
                type = f_10965_26504_26525(opKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26540, 27919);

                switch (type)
                {

                    case BinaryOperatorKind.Enum:
                    case BinaryOperatorKind.EnumAndUnderlying:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 26540, 27919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26697, 26793);

                        return f_10965_26704_26792(f_10965_26715_26791(f_10965_26742_26790(f_10965_26742_26778(f_10965_26742_26754(f_10965_26742_26749(op))))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 26540, 27919);

                    case BinaryOperatorKind.UnderlyingAndEnum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 26540, 27919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 26877, 26974);

                        return f_10965_26884_26973(f_10965_26895_26972(f_10965_26922_26971(f_10965_26922_26959(f_10965_26922_26935(f_10965_26922_26930(op))))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 26540, 27919);

                    case BinaryOperatorKind.UInt:
                    case BinaryOperatorKind.NUInt:
                    case BinaryOperatorKind.ULong:
                    case BinaryOperatorKind.ULongAndPointer:
                    case BinaryOperatorKind.PointerAndInt:
                    case BinaryOperatorKind.PointerAndUInt:
                    case BinaryOperatorKind.PointerAndLong:
                    case BinaryOperatorKind.PointerAndULong:
                    case BinaryOperatorKind.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 26540, 27919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 27477, 27489);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 26540, 27919);

                    case BinaryOperatorKind.IntAndPointer:
                    case BinaryOperatorKind.LongAndPointer:
                    // Dev10 converts the uint to a native int, so it counts as signed.
                    case BinaryOperatorKind.UIntAndPointer:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 26540, 27919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 27891, 27904);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 26540, 27919);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10965, 26327, 27930);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_26448_26463(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26448, 26463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_26504_26525(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26504, 26525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_26742_26749(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26742, 26749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_26742_26754(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26742, 26754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10965_26742_26778(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26742, 26778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_26742_26790(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26742, 26790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_26715_26791(Microsoft.CodeAnalysis.SpecialType
                underlyingType)
                {
                    var return_v = Binder.GetEnumPromotedType(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26715, 26791);
                    return return_v;
                }


                bool
                f_10965_26704_26792(Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = IsUnsigned(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26704, 26792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10965_26922_26930(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26922, 26930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10965_26922_26935(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26922, 26935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10965_26922_26959(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26922, 26959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_26922_26971(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10965, 26922, 26971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10965_26895_26972(Microsoft.CodeAnalysis.SpecialType
                underlyingType)
                {
                    var return_v = Binder.GetEnumPromotedType(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26895, 26972);
                    return return_v;
                }


                bool
                f_10965_26884_26973(Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = IsUnsigned(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 26884, 26973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 26327, 27930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 26327, 27930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsConditional(BinaryOperatorKind opKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10965, 27942, 28813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28027, 28773);

                switch (f_10965_28035_28063(opKind))
                {

                    case BinaryOperatorKind.LogicalAnd:
                    case BinaryOperatorKind.LogicalOr:
                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.LessThanOrEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 28027, 28773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28529, 28541);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 28027, 28773);

                    case BinaryOperatorKind.And:
                    case BinaryOperatorKind.Or:
                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 28027, 28773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28702, 28758);

                        return f_10965_28709_28730(opKind) == BinaryOperatorKind.Bool;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 28027, 28773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28789, 28802);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10965, 27942, 28813);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_28035_28063(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperatorWithLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 28035, 28063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_28709_28730(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 28709, 28730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 27942, 28813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 27942, 28813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsFloat(BinaryOperatorKind opKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10965, 28825, 29197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28904, 28937);

                var
                type = f_10965_28915_28936(opKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 28951, 29186);

                switch (type)
                {

                    case BinaryOperatorKind.Float:
                    case BinaryOperatorKind.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 28951, 29186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 29098, 29110);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 28951, 29186);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10965, 28951, 29186);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10965, 29158, 29171);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10965, 28951, 29186);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10965, 28825, 29197);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10965_28915_28936(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10965, 28915, 28936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10965, 28825, 29197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10965, 28825, 29197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
