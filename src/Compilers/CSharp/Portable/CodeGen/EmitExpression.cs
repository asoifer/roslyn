// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

using static System.Linq.ImmutableArrayExtensions;
using static Microsoft.CodeAnalysis.CSharp.Binder;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private int _recursionDepth;
        private class EmitCancelledException : Exception
        {
            public EmitCancelledException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10964, 710, 771);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10964, 710, 771);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 710, 771);
            }


            static EmitCancelledException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10964, 710, 771);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10964, 710, 771);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 710, 771);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10964, 710, 771);
        }

        private enum UseKind
        {
            Unused,
            UsedAsValue,
            UsedAsAddress
        }

        private void EmitExpression(BoundExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 911, 2055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1002, 1080) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1002, 1080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1058, 1065);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1002, 1080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1096, 1141);

                var
                constantValue = f_10964_1116_1140(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1155, 1655) || true) && (constantValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1155, 1655);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1214, 1354) || true) && (!used)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1214, 1354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1328, 1335);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1214, 1354);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1374, 1640) || true) && ((object)f_10964_1386_1401(expression) == null || (DynAbs.Tracing.TraceSender.Expression_False(10964, 1378, 1470) || f_10964_1413_1440(f_10964_1413_1428(expression)) != SpecialType.System_Decimal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1374, 1640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1512, 1592);

                        f_10964_1512_1591(this, f_10964_1535_1550(expression), constantValue, used, expression.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1614, 1621);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1374, 1640);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1155, 1655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1671, 1689);

                _recursionDepth++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1705, 2010) || true) && (_recursionDepth > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1705, 2010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1762, 1821);

                    f_10964_1762_1820(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1841, 1878);

                    f_10964_1841_1877(this, expression, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1705, 2010);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 1705, 2010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 1944, 1995);

                    f_10964_1944_1994(this, expression, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 1705, 2010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2026, 2044);

                _recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 911, 2055);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_1116_1140(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 1116, 1140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_1386_1401(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 1386, 1401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_1413_1428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 1413, 1428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_1413_1440(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 1413, 1440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_1535_1550(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 1535, 1550);
                    return return_v;
                }


                int
                f_10964_1512_1591(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.ConstantValue
                constantValue, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitConstantExpression(type, constantValue, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 1512, 1591);
                    return 0;
                }


                int
                f_10964_1762_1820(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 1762, 1820);
                    return 0;
                }


                int
                f_10964_1841_1877(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpressionCore(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 1841, 1877);
                    return 0;
                }


                int
                f_10964_1944_1994(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpressionCoreWithStackGuard(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 1944, 1994);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 911, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 911, 2055);
            }
        }

        private void EmitExpressionCoreWithStackGuard(BoundExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 2067, 2725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2176, 2211);

                f_10964_2176_2210(_recursionDepth == 1);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2263, 2300);

                    f_10964_2263_2299(this, expression, used);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2318, 2353);

                    f_10964_2318_2352(_recursionDepth == 1);
                }
                catch (InsufficientExecutionStackException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10964, 2382, 2714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2458, 2646);

                    f_10964_2458_2645(_diagnostics, ErrorCode.ERR_InsufficientStack, f_10964_2542_2644(expression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2664, 2699);

                    throw f_10964_2670_2698();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10964, 2382, 2714);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 2067, 2725);

                int
                f_10964_2176_2210(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2176, 2210);
                    return 0;
                }


                int
                f_10964_2263_2299(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpressionCore(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2263, 2299);
                    return 0;
                }


                int
                f_10964_2318_2352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2318, 2352);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10964_2542_2644(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = BoundTreeVisitor.CancelledByStackGuardException.GetTooLongOrComplexExpressionErrorLocation((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2542, 2644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10964_2458_2645(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2458, 2645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.EmitCancelledException
                f_10964_2670_2698()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.EmitCancelledException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2670, 2698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 2067, 2725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 2067, 2725);
            }
        }

        private void EmitExpressionCore(BoundExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 2737, 13113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2832, 13102);

                switch (f_10964_2840_2855(expression))
                {

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 2945, 3052);

                        f_10964_2945_3051(this, expression, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 3007, 3011) || ((used && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 3014, 3033)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 3036, 3050))) ? UseKind.UsedAsValue : UseKind.Unused);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 3074, 3080);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 3142, 3229);

                        f_10964_3142_3228(this, expression, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 3184, 3188) || ((used && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 3191, 3210)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 3213, 3227))) ? UseKind.UsedAsValue : UseKind.Unused);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 3251, 3257);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 3339, 3417);

                        f_10964_3339_3416(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 3439, 3445);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.DelegateCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 3529, 3611);

                        f_10964_3529_3610(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 3633, 3639);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ArrayCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 3710, 3776);

                        f_10964_3710_3775(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 3798, 3804);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ConvertedStackAllocExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 3891, 3979);

                        f_10964_3891_3978(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4001, 4007);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ReadOnlySpanFromArray:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4086, 4168);

                        f_10964_4086_4167(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4190, 4196);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4264, 4324);

                        f_10964_4264_4323(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4346, 4352);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4415, 4459);

                        f_10964_4415_4458(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4481, 4487);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Dup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4548, 4594);

                        f_10964_4548_4593(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4616, 4622);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.PassByCopy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4690, 4753);

                        f_10964_4690_4752(this, f_10964_4705_4745(((BoundPassByCopy)expression)), used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 4775, 4781);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4848, 5016) || true) && (used)
                        )  // unused parameter has no side-effects

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 4848, 5016);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 4947, 4993);

                            f_10964_4947_4992(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 4848, 5016);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 5038, 5044);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5113, 5163);

                        f_10964_5113_5162(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 5185, 5191);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5260, 5317);

                        f_10964_5260_5316(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 5339, 5345);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ArrayLength:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5414, 5466);

                        f_10964_5414_5465(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 5488, 5494);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5565, 5741) || true) && (used)
                        ) // unused this has no side-effects

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 5565, 5741);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5658, 5718);

                            f_10964_5658_5717(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 5565, 5741);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 5763, 5769);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.PreviousSubmissionReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 5948, 6006);

                        throw f_10964_5954_6005(f_10964_5989_6004(expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.BaseReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6077, 6543) || true) && (used)
                        ) // unused base has no side-effects

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 6077, 6543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6170, 6208);

                            var
                            thisType = f_10964_6185_6207(_method)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6234, 6272);

                            f_10964_6234_6271(_builder, ILOpCode.Ldarg_0);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6298, 6520) || true) && (f_10964_6302_6322(thisType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 6298, 6520);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6380, 6426);

                                f_10964_6380_6425(this, thisType, expression.Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6456, 6493);

                                f_10964_6456_6492(this, thisType, expression.Syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 6298, 6520);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 6077, 6543);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 6565, 6571);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6637, 6693);

                        f_10964_6637_6692(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 6715, 6721);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.SequencePointExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6802, 6878);

                        f_10964_6802_6877(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 6900, 6906);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.UnaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 6977, 7043);

                        f_10964_6977_7042(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7065, 7071);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.BinaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7143, 7211);

                        f_10964_7143_7210(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7233, 7239);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.NullCoalescingOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7319, 7393);

                        f_10964_7319_7392(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7415, 7421);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.IsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7489, 7541);

                        f_10964_7489_7540(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7563, 7569);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.AsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7637, 7689);

                        f_10964_7637_7688(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7711, 7717);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.DefaultExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7792, 7856);

                        f_10964_7792_7855(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 7878, 7884);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.TypeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 7956, 8128) || true) && (used)
                        ) // unused typeof has no side-effects

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 7956, 8128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8051, 8105);

                            f_10964_8051_8104(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 7956, 8128);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 8150, 8156);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.SizeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8228, 8400) || true) && (used)
                        ) // unused sizeof has no side-effects

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 8228, 8400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8323, 8377);

                            f_10964_8323_8376(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 8228, 8400);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 8422, 8428);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ModuleVersionId:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8501, 8520);

                        f_10964_8501_8519(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8542, 8600);

                        f_10964_8542_8599(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 8622, 8628);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ModuleVersionIdString:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8707, 8726);

                        f_10964_8707_8725(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8748, 8818);

                        f_10964_8748_8817(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 8840, 8846);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.InstrumentationPayloadRoot:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8930, 8949);

                        f_10964_8930_8948(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 8971, 9051);

                        f_10964_8971_9050(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 9073, 9079);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.MethodDefIndex:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9151, 9170);

                        f_10964_9151_9169(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9192, 9254);

                        f_10964_9192_9253(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 9276, 9282);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.MaximumMethodDefIndex:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9361, 9380);

                        f_10964_9361_9379(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9402, 9478);

                        f_10964_9402_9477(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 9500, 9506);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.SourceDocumentIndex:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9583, 9602);

                        f_10964_9583_9601(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9624, 9686);

                        f_10964_9624_9685(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 9708, 9714);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.MethodInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9782, 9917) || true) && (used)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 9782, 9917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 9840, 9894);

                            f_10964_9840_9893(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 9782, 9917);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 9939, 9945);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.FieldInfo:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10012, 10145) || true) && (used)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 10012, 10145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10070, 10122);

                            f_10964_10070_10121(this, expression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 10012, 10145);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 10167, 10173);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10250, 10318);

                        f_10964_10250_10317(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 10340, 10346);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.AddressOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10421, 10487);

                        f_10964_10421_10486(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 10509, 10515);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.PointerIndirectionOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10599, 10681);

                        f_10964_10599_10680(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 10703, 10709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ArgList:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10774, 10792);

                        f_10964_10774_10791(this, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 10814, 10820);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ArgListOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10893, 10912);

                        f_10964_10893_10911(used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 10934, 10988);

                        f_10964_10934_10987(this, expression);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11010, 11016);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.RefTypeOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11089, 11149);

                        f_10964_11089_11148(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11171, 11177);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.MakeRefOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11250, 11310);

                        f_10964_11250_11309(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11332, 11338);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.RefValueOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11412, 11474);

                        f_10964_11412_11473(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11496, 11502);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.LoweredConditionalAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11584, 11672);

                        f_10964_11584_11671(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11694, 11700);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ConditionalReceiver:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11777, 11845);

                        f_10964_11777_11844(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 11867, 11873);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ComplexConditionalReceiver:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 11957, 12039);

                        f_10964_11957_12038(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 12061, 12067);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.PseudoVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 12139, 12202);

                        f_10964_12139_12201(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 12224, 12230);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.ThrowExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 12303, 12363);

                        f_10964_12303_12362(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 12385, 12391);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 12474, 12573);

                        f_10964_12474_12572(this, expression, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 12528, 12532) || ((used && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 12535, 12554)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 12557, 12571))) ? UseKind.UsedAsValue : UseKind.Unused);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 12595, 12601);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    case BoundKind.FunctionPointerLoad:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 12678, 12739);

                        f_10964_12678_12738(this, expression, used);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 12761, 12767);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 2832, 13102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 12893, 12950);

                        f_10964_12893_12949(f_10964_12906_12921(expression) != BoundKind.BadExpression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13029, 13087);

                        throw f_10964_13035_13086(f_10964_13070_13085(expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 2832, 13102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 2737, 13113);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_2840_2855(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 2840, 2855);
                    return return_v;
                }


                int
                f_10964_2945_3051(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                assignmentOperator, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind)
                {
                    this_param.EmitAssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator)assignmentOperator, useKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 2945, 3051);
                    return 0;
                }


                int
                f_10964_3142_3228(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                call, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind)
                {
                    this_param.EmitCallExpression((Microsoft.CodeAnalysis.CSharp.BoundCall)call, useKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 3142, 3228);
                    return 0;
                }


                int
                f_10964_3339_3416(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitObjectCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 3339, 3416);
                    return 0;
                }


                int
                f_10964_3529_3610(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitDelegateCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 3529, 3610);
                    return 0;
                }


                int
                f_10964_3710_3775(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitArrayCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundArrayCreation)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 3710, 3775);
                    return 0;
                }


                int
                f_10964_3891_3978(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitConvertedStackAllocExpression((Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 3891, 3978);
                    return 0;
                }


                int
                f_10964_4086_4167(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitReadOnlySpanFromArrayExpression((Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4086, 4167);
                    return 0;
                }


                int
                f_10964_4264_4323(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                conversion, bool
                used)
                {
                    this_param.EmitConversionExpression((Microsoft.CodeAnalysis.CSharp.BoundConversion)conversion, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4264, 4323);
                    return 0;
                }


                int
                f_10964_4415_4458(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                local, bool
                used)
                {
                    this_param.EmitLocalLoad((Microsoft.CodeAnalysis.CSharp.BoundLocal)local, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4415, 4458);
                    return 0;
                }


                int
                f_10964_4548_4593(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitDupExpression((Microsoft.CodeAnalysis.CSharp.BoundDup)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4548, 4593);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_4705_4745(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 4705, 4745);
                    return return_v;
                }


                int
                f_10964_4690_4752(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4690, 4752);
                    return 0;
                }


                int
                f_10964_4947_4992(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                parameter)
                {
                    this_param.EmitParameterLoad((Microsoft.CodeAnalysis.CSharp.BoundParameter)parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 4947, 4992);
                    return 0;
                }


                int
                f_10964_5113_5162(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                fieldAccess, bool
                used)
                {
                    this_param.EmitFieldLoad((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess)fieldAccess, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 5113, 5162);
                    return 0;
                }


                int
                f_10964_5260_5316(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arrayAccess, bool
                used)
                {
                    this_param.EmitArrayElementLoad((Microsoft.CodeAnalysis.CSharp.BoundArrayAccess)arrayAccess, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 5260, 5316);
                    return 0;
                }


                int
                f_10964_5414_5465(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitArrayLength((Microsoft.CodeAnalysis.CSharp.BoundArrayLength)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 5414, 5465);
                    return 0;
                }


                int
                f_10964_5658_5717(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                thisRef)
                {
                    this_param.EmitThisReferenceExpression((Microsoft.CodeAnalysis.CSharp.BoundThisReference)thisRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 5658, 5717);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_5989_6004(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 5989, 6004);
                    return return_v;
                }


                System.Exception
                f_10964_5954_6005(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 5954, 6005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_6185_6207(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 6185, 6207);
                    return return_v;
                }


                int
                f_10964_6234_6271(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6234, 6271);
                    return 0;
                }


                bool
                f_10964_6302_6322(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 6302, 6322);
                    return return_v;
                }


                int
                f_10964_6380_6425(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6380, 6425);
                    return 0;
                }


                int
                f_10964_6456_6492(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6456, 6492);
                    return 0;
                }


                int
                f_10964_6637_6692(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sequence, bool
                used)
                {
                    this_param.EmitSequenceExpression((Microsoft.CodeAnalysis.CSharp.BoundSequence)sequence, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6637, 6692);
                    return 0;
                }


                int
                f_10964_6802_6877(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                used)
                {
                    this_param.EmitSequencePointExpression((Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression)node, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6802, 6877);
                    return 0;
                }


                int
                f_10964_6977_7042(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitUnaryOperatorExpression((Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 6977, 7042);
                    return 0;
                }


                int
                f_10964_7143_7210(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitBinaryOperatorExpression((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 7143, 7210);
                    return 0;
                }


                int
                f_10964_7319_7392(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, bool
                used)
                {
                    this_param.EmitNullCoalescingOperator((Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator)expr, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 7319, 7392);
                    return 0;
                }


                int
                f_10964_7489_7540(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                isOp, bool
                used)
                {
                    this_param.EmitIsExpression((Microsoft.CodeAnalysis.CSharp.BoundIsOperator)isOp, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 7489, 7540);
                    return 0;
                }


                int
                f_10964_7637_7688(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                asOp, bool
                used)
                {
                    this_param.EmitAsExpression((Microsoft.CodeAnalysis.CSharp.BoundAsOperator)asOp, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 7637, 7688);
                    return 0;
                }


                int
                f_10964_7792_7855(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitDefaultExpression((Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 7792, 7855);
                    return 0;
                }


                int
                f_10964_8051_8104(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundTypeOfOperator)
                {
                    this_param.EmitTypeOfExpression((Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator)boundTypeOfOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8051, 8104);
                    return 0;
                }


                int
                f_10964_8323_8376(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundSizeOfOperator)
                {
                    this_param.EmitSizeOfExpression((Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator)boundSizeOfOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8323, 8376);
                    return 0;
                }


                int
                f_10964_8501_8519(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8501, 8519);
                    return 0;
                }


                int
                f_10964_8542_8599(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitModuleVersionIdLoad((Microsoft.CodeAnalysis.CSharp.BoundModuleVersionId)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8542, 8599);
                    return 0;
                }


                int
                f_10964_8707_8725(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8707, 8725);
                    return 0;
                }


                int
                f_10964_8748_8817(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitModuleVersionIdStringLoad((Microsoft.CodeAnalysis.CSharp.BoundModuleVersionIdString)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8748, 8817);
                    return 0;
                }


                int
                f_10964_8930_8948(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8930, 8948);
                    return 0;
                }


                int
                f_10964_8971_9050(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitInstrumentationPayloadRootLoad((Microsoft.CodeAnalysis.CSharp.BoundInstrumentationPayloadRoot)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 8971, 9050);
                    return 0;
                }


                int
                f_10964_9151_9169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9151, 9169);
                    return 0;
                }


                int
                f_10964_9192_9253(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitMethodDefIndexExpression((Microsoft.CodeAnalysis.CSharp.BoundMethodDefIndex)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9192, 9253);
                    return 0;
                }


                int
                f_10964_9361_9379(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9361, 9379);
                    return 0;
                }


                int
                f_10964_9402_9477(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitMaximumMethodDefIndexExpression((Microsoft.CodeAnalysis.CSharp.BoundMaximumMethodDefIndex)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9402, 9477);
                    return 0;
                }


                int
                f_10964_9583_9601(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9583, 9601);
                    return 0;
                }


                int
                f_10964_9624_9685(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitSourceDocumentIndex((Microsoft.CodeAnalysis.CSharp.BoundSourceDocumentIndex)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9624, 9685);
                    return 0;
                }


                int
                f_10964_9840_9893(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitMethodInfoExpression((Microsoft.CodeAnalysis.CSharp.BoundMethodInfo)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 9840, 9893);
                    return 0;
                }


                int
                f_10964_10070_10121(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.EmitFieldInfoExpression((Microsoft.CodeAnalysis.CSharp.BoundFieldInfo)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10070, 10121);
                    return 0;
                }


                int
                f_10964_10250_10317(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, bool
                used)
                {
                    this_param.EmitConditionalOperator((Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator)expr, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10250, 10317);
                    return 0;
                }


                int
                f_10964_10421_10486(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitAddressOfExpression((Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10421, 10486);
                    return 0;
                }


                int
                f_10964_10599_10680(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitPointerIndirectionOperator((Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10599, 10680);
                    return 0;
                }


                int
                f_10964_10774_10791(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitArgList(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10774, 10791);
                    return 0;
                }


                int
                f_10964_10893_10911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10893, 10911);
                    return 0;
                }


                int
                f_10964_10934_10987(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    this_param.EmitArgListOperator((Microsoft.CodeAnalysis.CSharp.BoundArgListOperator)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 10934, 10987);
                    return 0;
                }


                int
                f_10964_11089_11148(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitRefTypeOperator((Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11089, 11148);
                    return 0;
                }


                int
                f_10964_11250_11309(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitMakeRefOperator((Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11250, 11309);
                    return 0;
                }


                int
                f_10964_11412_11473(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitRefValueOperator((Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11412, 11473);
                    return 0;
                }


                int
                f_10964_11584_11671(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitLoweredConditionalAccessExpression((Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11584, 11671);
                    return 0;
                }


                int
                f_10964_11777_11844(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitConditionalReceiver((Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11777, 11844);
                    return 0;
                }


                int
                f_10964_11957_12038(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitComplexConditionalReceiver((Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 11957, 12038);
                    return 0;
                }


                int
                f_10964_12139_12201(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitPseudoVariableValue((Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable)expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 12139, 12201);
                    return 0;
                }


                int
                f_10964_12303_12362(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                used)
                {
                    this_param.EmitThrowExpression((Microsoft.CodeAnalysis.CSharp.BoundThrowExpression)node, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 12303, 12362);
                    return 0;
                }


                int
                f_10964_12474_12572(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                ptrInvocation, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind)
                {
                    this_param.EmitCalli((Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation)ptrInvocation, useKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 12474, 12572);
                    return 0;
                }


                int
                f_10964_12678_12738(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                load, bool
                used)
                {
                    this_param.EmitLoadFunction((Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad)load, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 12678, 12738);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_12906_12921(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 12906, 12921);
                    return return_v;
                }


                int
                f_10964_12893_12949(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 12893, 12949);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_13070_13085(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13070, 13085);
                    return return_v;
                }


                System.Exception
                f_10964_13035_13086(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13035, 13086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 2737, 13113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 2737, 13113);
            }
        }

        private void EmitThrowExpression(BoundThrowExpression node, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 13125, 13427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13220, 13252);

                f_10964_13220_13251(this, f_10964_13235_13250(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13369, 13416);

                f_10964_13369_13415(this, f_10964_13386_13395(node), used, node.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 13125, 13427);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_13235_13250(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13235, 13250);
                    return return_v;
                }


                int
                f_10964_13220_13251(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                thrown)
                {
                    this_param.EmitThrow(thrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13220, 13251);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_13386_13395(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13386, 13395);
                    return return_v;
                }


                int
                f_10964_13369_13415(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitDefaultValue(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13369, 13415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 13125, 13427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 13125, 13427);
            }
        }

        private void EmitComplexConditionalReceiver(BoundComplexConditionalReceiver expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 13439, 14352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13562, 13609);

                f_10964_13562_13608(f_10964_13575_13607_M(!f_10964_13576_13591(expression).IsReferenceType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13623, 13666);

                f_10964_13623_13665(f_10964_13636_13664_M(!f_10964_13637_13652(expression).IsValueType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13682, 13717);

                var
                receiverType = f_10964_13701_13716(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13733, 13771);

                var
                whenValueTypeLabel = f_10964_13758_13770()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13785, 13814);

                var
                doneLabel = f_10964_13801_13813()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13830, 13881);

                f_10964_13830_13880(this, receiverType, true, expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13895, 13936);

                f_10964_13895_13935(this, receiverType, expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 13950, 14007);

                f_10964_13950_14006(_builder, ILOpCode.Brtrue, whenValueTypeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14023, 14078);

                f_10964_14023_14077(this, f_10964_14038_14070(expression), used);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14092, 14136);

                f_10964_14092_14135(_builder, ILOpCode.Br, doneLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14150, 14175);

                f_10964_14150_14174(_builder, -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14191, 14230);

                f_10964_14191_14229(
                            _builder, whenValueTypeLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14244, 14295);

                f_10964_14244_14294(this, f_10964_14259_14287(expression), used);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14311, 14341);

                f_10964_14311_14340(
                            _builder, doneLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 13439, 14352);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_13576_13591(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13576, 13591);
                    return return_v;
                }


                bool
                f_10964_13575_13607_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13575, 13607);
                    return return_v;
                }


                int
                f_10964_13562_13608(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13562, 13608);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_13637_13652(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13637, 13652);
                    return return_v;
                }


                bool
                f_10964_13636_13664_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13636, 13664);
                    return return_v;
                }


                int
                f_10964_13623_13665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13623, 13665);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_13701_13716(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 13701, 13716);
                    return return_v;
                }


                object
                f_10964_13758_13770()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13758, 13770);
                    return return_v;
                }


                object
                f_10964_13801_13813()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13801, 13813);
                    return return_v;
                }


                int
                f_10964_13830_13880(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitInitObj(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13830, 13880);
                    return 0;
                }


                int
                f_10964_13895_13935(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13895, 13935);
                    return 0;
                }


                int
                f_10964_13950_14006(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 13950, 14006);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_14038_14070(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ReferenceTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14038, 14070);
                    return return_v;
                }


                int
                f_10964_14023_14077(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14023, 14077);
                    return 0;
                }


                int
                f_10964_14092_14135(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14092, 14135);
                    return 0;
                }


                int
                f_10964_14150_14174(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14150, 14174);
                    return 0;
                }


                int
                f_10964_14191_14229(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14191, 14229);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_14259_14287(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ValueTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14259, 14287);
                    return return_v;
                }


                int
                f_10964_14244_14294(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14244, 14294);
                    return 0;
                }


                int
                f_10964_14311_14340(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14311, 14340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 13439, 14352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 13439, 14352);
            }
        }

        private void EmitLoweredConditionalAccessExpression(BoundLoweredConditionalAccess expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 14364, 22716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14493, 14528);

                var
                receiver = f_10964_14508_14527(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14544, 14577);

                var
                receiverType = f_10964_14563_14576(receiver)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14591, 14627);

                LocalDefinition
                receiverTemp = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14641, 14816);

                f_10964_14641_14815(f_10964_14654_14679_M(!receiverType.IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 14654, 14771) || (f_10964_14701_14730(receiverType) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 14701, 14770) && f_10964_14734_14762(expression) != null))), "conditional receiver cannot be a struct");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14832, 14878);

                var
                receiverConstant = f_10964_14855_14877(receiver)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 14892, 15500) || true) && (f_10964_14896_14920_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiverConstant, 10964, 14896, 14920)?.IsNull) == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 14892, 15500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15028, 15077);

                    f_10964_15028_15076(f_10964_15041_15075(receiverType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15208, 15271);

                    receiverTemp = f_10964_15223_15270(this, receiver, AddressKind.ReadOnly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15289, 15334);

                    f_10964_15289_15333(this, f_10964_15304_15326(expression), used);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15352, 15460) || true) && (receiverTemp != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 15352, 15460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15418, 15441);

                        f_10964_15418_15440(this, receiverTemp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 15352, 15460);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15478, 15485);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 14892, 15500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15539, 15578);

                object
                whenNotNullLabel = f_10964_15565_15577()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15592, 15624);

                object
                doneLabel = f_10964_15611_15623()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15638, 15671);

                LocalDefinition
                cloneTemp = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 15687, 15767);

                var
                notConstrained = f_10964_15708_15737_M(!receiverType.IsReferenceType) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 15708, 15766) && f_10964_15741_15766_M(!receiverType.IsValueType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 16075, 16433);

                var
                nullCheckOnCopy = f_10964_16097_16185(receiver, localsMayBeAssignedOrCaptured: false) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 16097, 16306) || (f_10964_16226_16254(receiverType) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 16226, 16305) && f_10964_16258_16279(receiverType) == TypeKind.TypeParameter))) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 16097, 16432) || (f_10964_16347_16360(receiver) == BoundKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10964, 16347, 16431) && f_10964_16383_16431(this, f_10964_16396_16430(((BoundLocal)receiver))))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 16480, 20015) || true) && (nullCheckOnCopy)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16480, 20015);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 16533, 19411) || true) && (notConstrained)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16533, 19411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 16690, 16756);

                        receiverTemp = f_10964_16705_16755(this, receiver, AddressKind.Constrained);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 16780, 18899) || true) && (receiverTemp is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16780, 18899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17561, 17615);

                            f_10964_17561_17614(this, receiverType, true, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17641, 17680);

                            f_10964_17641_17679(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17706, 17761);

                            f_10964_17706_17760(_builder, ILOpCode.Brtrue, whenNotNullLabel);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17787, 17835);

                            f_10964_17787_17834(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17863, 17919);

                            cloneTemp = f_10964_17875_17918(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 17945, 17980);

                            f_10964_17945_17979(_builder, cloneTemp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18006, 18043);

                            f_10964_18006_18042(_builder, cloneTemp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18069, 18103);

                            f_10964_18069_18102(_builder, cloneTemp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18129, 18168);

                            f_10964_18129_18167(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16780, 18899);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16780, 18899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18703, 18737);

                            f_10964_18703_18736(                        // We are calling the expression on a copy of the target anyway, 
                                                                        // so even if T is a struct, we don't need to make sure we call the expression on the original target.

                                                    // We currently have an address on the stack. Duplicate it, and load the value of the address.
                                                    _builder, ILOpCode.Dup);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18763, 18811);

                            f_10964_18763_18810(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 18837, 18876);

                            f_10964_18837_18875(this, receiverType, receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16780, 18899);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16533, 19411);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16533, 19411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 19120, 19159);

                        var
                        addressKind = AddressKind.ReadOnly
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 19183, 19237);

                        receiverTemp = f_10964_19198_19236(this, receiver, addressKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 19259, 19293);

                        f_10964_19259_19292(_builder, ILOpCode.Dup);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16533, 19411);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16480, 20015);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 16480, 20015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 19773, 19836);

                    receiverTemp = f_10964_19788_19835(this, receiver, AddressKind.ReadOnly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 16480, 20015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20065, 20112);

                var
                hasValueOpt = f_10964_20083_20111(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20126, 20388) || true) && (hasValueOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 20126, 20388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20183, 20228);

                    f_10964_20183_20227(f_10964_20196_20226(f_10964_20196_20209(receiver)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20246, 20301);

                    f_10964_20246_20300(_builder, ILOpCode.Call, stackAdjustment: 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20319, 20373);

                    f_10964_20319_20372(this, hasValueOpt, expression.Syntax, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 20126, 20388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20404, 20459);

                f_10964_20404_20458(
                            _builder, ILOpCode.Brtrue, whenNotNullLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20544, 20698) || true) && (receiverTemp != null && (DynAbs.Tracing.TraceSender.Expression_True(10964, 20548, 20588) && !nullCheckOnCopy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 20544, 20698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20622, 20645);

                    f_10964_20622_20644(this, receiverTemp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20663, 20683);

                    receiverTemp = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 20544, 20698);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20746, 20848) || true) && (nullCheckOnCopy)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 20746, 20848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20799, 20833);

                    f_10964_20799_20832(_builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 20746, 20848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20864, 20902);

                var
                whenNull = f_10964_20879_20901(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20916, 21141) || true) && (whenNull == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 20916, 21141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 20970, 21029);

                    f_10964_20970_21028(this, f_10964_20987_21002(expression), used, expression.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 20916, 21141);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 20916, 21141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21095, 21126);

                    f_10964_21095_21125(this, whenNull, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 20916, 21141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21157, 21201);

                f_10964_21157_21200(
                            _builder, ILOpCode.Br, doneLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21256, 21593) || true) && (nullCheckOnCopy)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 21256, 21593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21553, 21578);

                    f_10964_21553_21577(                // notNull branch pops copy of receiver off the stack when nullCheckOnCopy
                                                        // however on the isNull branch we still have the stack as it was and need 
                                                        // to adjust stack depth correspondingly.
                                    _builder, +1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 21256, 21593);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21609, 21916) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 21609, 21916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21876, 21901);

                    f_10964_21876_21900(                // notNull branch pushes default on the stack when used
                                                        // however on the isNull branch we still have the stack as it was and need 
                                                        // to adjust stack depth correspondingly.
                                    _builder, -1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 21609, 21916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21932, 21969);

                f_10964_21932_21968(
                            _builder, whenNotNullLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 21985, 22353) || true) && (!nullCheckOnCopy)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 21985, 22353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22039, 22074);

                    f_10964_22039_22073(receiverTemp == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22190, 22256);

                    receiverTemp = f_10964_22205_22255(this, receiver, AddressKind.Constrained);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22274, 22338);

                    f_10964_22274_22337(receiverTemp == null || (DynAbs.Tracing.TraceSender.Expression_False(10964, 22287, 22336) || f_10964_22311_22336(receiver)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 21985, 22353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22369, 22414);

                f_10964_22369_22413(this, f_10964_22384_22406(expression), used);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22457, 22487);

                f_10964_22457_22486(
                            // ===== DONE
                            _builder, doneLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22503, 22593) || true) && (cloneTemp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 22503, 22593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22558, 22578);

                    f_10964_22558_22577(this, cloneTemp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 22503, 22593);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22609, 22705) || true) && (receiverTemp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 22609, 22705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22667, 22690);

                    f_10964_22667_22689(this, receiverTemp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 22609, 22705);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 14364, 22716);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_14508_14527(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14508, 14527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_14563_14576(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14563, 14576);
                    return return_v;
                }


                bool
                f_10964_14654_14679_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14654, 14679);
                    return return_v;
                }


                bool
                f_10964_14701_14730(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14701, 14730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_14734_14762(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14734, 14762);
                    return return_v;
                }


                int
                f_10964_14641_14815(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 14641, 14815);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_14855_14877(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14855, 14877);
                    return return_v;
                }


                bool?
                f_10964_14896_14920_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 14896, 14920);
                    return return_v;
                }


                bool
                f_10964_15041_15075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15041, 15075);
                    return return_v;
                }


                int
                f_10964_15028_15076(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15028, 15076);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_15223_15270(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15223, 15270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_15304_15326(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 15304, 15326);
                    return return_v;
                }


                int
                f_10964_15289_15333(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15289, 15333);
                    return 0;
                }


                int
                f_10964_15418_15440(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15418, 15440);
                    return 0;
                }


                object
                f_10964_15565_15577()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15565, 15577);
                    return return_v;
                }


                object
                f_10964_15611_15623()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 15611, 15623);
                    return return_v;
                }


                bool
                f_10964_15708_15737_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 15708, 15737);
                    return return_v;
                }


                bool
                f_10964_15741_15766_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 15741, 15766);
                    return return_v;
                }


                bool
                f_10964_16097_16185(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                localsMayBeAssignedOrCaptured)
                {
                    var return_v = LocalRewriter.CanChangeValueBetweenReads(expression, localsMayBeAssignedOrCaptured: localsMayBeAssignedOrCaptured);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 16097, 16185);
                    return return_v;
                }


                bool
                f_10964_16226_16254(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 16226, 16254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10964_16258_16279(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 16258, 16279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_16347_16360(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 16347, 16360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_16396_16430(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 16396, 16430);
                    return return_v;
                }


                bool
                f_10964_16383_16431(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 16383, 16431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_16705_16755(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 16705, 16755);
                    return return_v;
                }


                int
                f_10964_17561_17614(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitDefaultValue(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17561, 17614);
                    return 0;
                }


                int
                f_10964_17641_17679(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17641, 17679);
                    return 0;
                }


                int
                f_10964_17706_17760(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17706, 17760);
                    return 0;
                }


                int
                f_10964_17787_17834(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17787, 17834);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_17875_17918(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17875, 17918);
                    return return_v;
                }


                int
                f_10964_17945_17979(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 17945, 17979);
                    return 0;
                }


                int
                f_10964_18006_18042(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalAddress(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18006, 18042);
                    return 0;
                }


                int
                f_10964_18069_18102(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18069, 18102);
                    return 0;
                }


                int
                f_10964_18129_18167(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18129, 18167);
                    return 0;
                }


                int
                f_10964_18703_18736(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18703, 18736);
                    return 0;
                }


                int
                f_10964_18763_18810(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18763, 18810);
                    return 0;
                }


                int
                f_10964_18837_18875(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 18837, 18875);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_19198_19236(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 19198, 19236);
                    return return_v;
                }


                int
                f_10964_19259_19292(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 19259, 19292);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_19788_19835(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 19788, 19835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_20083_20111(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 20083, 20111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_20196_20209(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 20196, 20209);
                    return return_v;
                }


                bool
                f_10964_20196_20226(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20196, 20226);
                    return return_v;
                }


                int
                f_10964_20183_20227(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20183, 20227);
                    return 0;
                }


                int
                f_10964_20246_20300(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20246, 20300);
                    return 0;
                }


                int
                f_10964_20319_20372(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20319, 20372);
                    return 0;
                }


                int
                f_10964_20404_20458(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20404, 20458);
                    return 0;
                }


                int
                f_10964_20622_20644(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20622, 20644);
                    return 0;
                }


                int
                f_10964_20799_20832(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20799, 20832);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_20879_20901(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 20879, 20901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_20987_21002(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 20987, 21002);
                    return return_v;
                }


                int
                f_10964_20970_21028(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitDefaultValue(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 20970, 21028);
                    return 0;
                }


                int
                f_10964_21095_21125(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 21095, 21125);
                    return 0;
                }


                int
                f_10964_21157_21200(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 21157, 21200);
                    return 0;
                }


                int
                f_10964_21553_21577(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 21553, 21577);
                    return 0;
                }


                int
                f_10964_21876_21900(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 21876, 21900);
                    return 0;
                }


                int
                f_10964_21932_21968(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 21932, 21968);
                    return 0;
                }


                int
                f_10964_22039_22073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22039, 22073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_22205_22255(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22205, 22255);
                    return return_v;
                }


                bool
                f_10964_22311_22336(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22311, 22336);
                    return return_v;
                }


                int
                f_10964_22274_22337(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22274, 22337);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_22384_22406(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22384, 22406);
                    return return_v;
                }


                int
                f_10964_22369_22413(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22369, 22413);
                    return 0;
                }


                int
                f_10964_22457_22486(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22457, 22486);
                    return 0;
                }


                int
                f_10964_22558_22577(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22558, 22577);
                    return 0;
                }


                int
                f_10964_22667_22689(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22667, 22689);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 14364, 22716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 14364, 22716);
            }
        }

        private void EmitConditionalReceiver(BoundConditionalReceiver expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 22728, 23083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22837, 22880);

                f_10964_22837_22879(f_10964_22850_22878_M(!f_10964_22851_22866(expression).IsValueType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22896, 23034) || true) && (f_10964_22900_22932_M(!f_10964_22901_22916(expression).IsReferenceType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 22896, 23034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 22966, 23019);

                    f_10964_22966_23018(this, f_10964_22983_22998(expression), expression.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 22896, 23034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23050, 23072);

                f_10964_23050_23071(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 22728, 23083);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_22851_22866(Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22851, 22866);
                    return return_v;
                }


                bool
                f_10964_22850_22878_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22850, 22878);
                    return return_v;
                }


                int
                f_10964_22837_22879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22837, 22879);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_22901_22916(Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22901, 22916);
                    return return_v;
                }


                bool
                f_10964_22900_22932_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22900, 22932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_22983_22998(Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 22983, 22998);
                    return return_v;
                }


                int
                f_10964_22966_23018(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 22966, 23018);
                    return 0;
                }


                int
                f_10964_23050_23071(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23050, 23071);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 22728, 23083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 22728, 23083);
            }
        }

        private void EmitRefValueOperator(BoundRefValueOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 23095, 23344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23198, 23230);

                f_10964_23198_23229(this, expression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23244, 23297);

                f_10964_23244_23296(this, f_10964_23261_23276(expression), expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23311, 23333);

                f_10964_23311_23332(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 23095, 23344);

                int
                f_10964_23198_23229(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                refValue)
                {
                    this_param.EmitRefValueAddress(refValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23198, 23229);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_23261_23276(Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 23261, 23276);
                    return return_v;
                }


                int
                f_10964_23244_23296(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23244, 23296);
                    return 0;
                }


                int
                f_10964_23311_23332(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23311, 23332);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 23095, 23344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 23095, 23344);
            }
        }

        private void EmitMakeRefOperator(BoundMakeRefOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 23356, 23915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23589, 23655);

                var
                temp = f_10964_23600_23654(this, f_10964_23612_23630(expression), AddressKind.Writeable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23669, 23731);

                f_10964_23669_23730(temp == null, "makeref should not create temps");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23747, 23786);

                f_10964_23747_23785(
                            _builder, ILOpCode.Mkrefany);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23800, 23868);

                f_10964_23800_23867(this, f_10964_23816_23839(f_10964_23816_23834(expression)), f_10964_23841_23859(expression).Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 23882, 23904);

                f_10964_23882_23903(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 23356, 23915);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_23612_23630(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 23612, 23630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_23600_23654(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23600, 23654);
                    return return_v;
                }


                int
                f_10964_23669_23730(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23669, 23730);
                    return 0;
                }


                int
                f_10964_23747_23785(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23747, 23785);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_23816_23834(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 23816, 23834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_23816_23839(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 23816, 23839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_23841_23859(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 23841, 23859);
                    return return_v;
                }


                int
                f_10964_23800_23867(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23800, 23867);
                    return 0;
                }


                int
                f_10964_23882_23903(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 23882, 23903);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 23356, 23915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 23356, 23915);
            }
        }

        private void EmitRefTypeOperator(BoundRefTypeOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 23927, 24635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24232, 24273);

                f_10964_24232_24272(this, f_10964_24247_24265(expression), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24287, 24328);

                f_10964_24287_24327(_builder, ILOpCode.Refanytype);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24342, 24397);

                f_10964_24342_24396(_builder, ILOpCode.Call, stackAdjustment: 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24411, 24460);

                var
                getTypeMethod = f_10964_24431_24459(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24474, 24518);

                f_10964_24474_24517((object)getTypeMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24532, 24588);

                f_10964_24532_24587(this, getTypeMethod, expression.Syntax, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24602, 24624);

                f_10964_24602_24623(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 23927, 24635);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_24247_24265(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 24247, 24265);
                    return return_v;
                }


                int
                f_10964_24232_24272(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24232, 24272);
                    return 0;
                }


                int
                f_10964_24287_24327(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24287, 24327);
                    return 0;
                }


                int
                f_10964_24342_24396(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24342, 24396);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_24431_24459(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.GetTypeFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 24431, 24459);
                    return return_v;
                }


                int
                f_10964_24474_24517(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24474, 24517);
                    return 0;
                }


                int
                f_10964_24532_24587(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24532, 24587);
                    return 0;
                }


                int
                f_10964_24602_24623(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24602, 24623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 23927, 24635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 23927, 24635);
            }
        }

        private void EmitArgList(bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 24647, 24792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24707, 24745);

                f_10964_24707_24744(_builder, ILOpCode.Arglist);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24759, 24781);

                f_10964_24759_24780(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 24647, 24792);

                int
                f_10964_24707_24744(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24707, 24744);
                    return 0;
                }


                int
                f_10964_24759_24780(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 24759, 24780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 24647, 24792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 24647, 24792);
            }
        }

        private void EmitArgListOperator(BoundArgListOperator expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 24804, 25242);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24903, 24908);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24894, 25231) || true) && (i < expression.Arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24943, 24946)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 24894, 25231))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 24894, 25231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 24980, 25031);

                        BoundExpression
                        argument = f_10964_25007_25027(expression)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25049, 25166);

                        RefKind
                        refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 25067, 25114) || ((expression.ArgumentRefKindsOpt.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 25117, 25129)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 25132, 25165))) ? RefKind.None : f_10964_25132_25162(expression)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25184, 25216);

                        f_10964_25184_25215(this, argument, refKind);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 338);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 24804, 25242);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_25007_25027(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 25007, 25027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10964_25132_25162(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 25132, 25162);
                    return return_v;
                }


                int
                f_10964_25184_25215(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    this_param.EmitArgument(argument, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 25184, 25215);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 24804, 25242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 24804, 25242);
            }
        }

        private void EmitArgument(BoundExpression argument, RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 25254, 26444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25347, 26433);

                switch (refKind)
                {

                    case RefKind.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 25347, 26433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25436, 25467);

                        f_10964_25436_25466(this, argument, true);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 25489, 25495);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 25347, 26433);

                    case RefKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 25347, 26433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25553, 25608);

                        var
                        temp = f_10964_25564_25607(this, argument, AddressKind.ReadOnly)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25630, 25654);

                        f_10964_25630_25653(this, temp);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 25676, 25682);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 25347, 26433);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 25347, 26433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 25882, 26017);

                        var
                        unexpectedTemp = f_10964_25903_26016(this, argument, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 25925, 25962) || ((refKind == RefKindExtensions.StrictIn && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 25965, 25991)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 25994, 26015))) ? AddressKind.ReadOnlyStrict : AddressKind.Writeable)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26039, 26388) || true) && (unexpectedTemp != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 26039, 26388);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26210, 26305);

                            f_10964_26210_26304(f_10964_26223_26248(f_10964_26223_26236(argument)), "passing args byref should not clone them into temps");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26331, 26365);

                            f_10964_26331_26364(this, unexpectedTemp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 26039, 26388);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 26412, 26418);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 25347, 26433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 25254, 26444);

                int
                f_10964_25436_25466(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 25436, 25466);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_25564_25607(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 25564, 25607);
                    return return_v;
                }


                int
                f_10964_25630_25653(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 25630, 25653);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_25903_26016(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 25903, 26016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_26223_26236(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 26223, 26236);
                    return return_v;
                }


                bool
                f_10964_26223_26248(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 26223, 26248);
                    return return_v;
                }


                int
                f_10964_26210_26304(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 26210, 26304);
                    return 0;
                }


                int
                f_10964_26331_26364(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 26331, 26364);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 25254, 26444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 25254, 26444);
            }
        }

        private void EmitAddressOfExpression(BoundAddressOfOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 26456, 27727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26697, 26768);

                var
                temp = f_10964_26708_26767(this, f_10964_26720_26738(expression), AddressKind.ReadOnlyStrict)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26782, 26878);

                f_10964_26782_26877(temp == null, "If the operand is addressable, then a temp shouldn't be required.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 26894, 27678) || true) && (used && (DynAbs.Tracing.TraceSender.Expression_True(10964, 26898, 26927) && f_10964_26906_26927_M(!expression.IsManaged)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 26894, 27678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 27626, 27663);

                    f_10964_27626_27662(                // When computing an address to be used to initialize a fixed-statement variable, we have to be careful
                                                        // not to convert the managed reference to an unmanaged pointer before storing it.  Otherwise the GC might
                                                        // come along and move memory around, invalidating the pointer before it is pinned by being stored in
                                                        // the fixed variable.  But elsewhere in the code we do use a conv.u instruction to convert the managed
                                                        // reference to the underlying type for unmanaged pointers, which is the type "unsigned int" (see CLI
                                                        // standard, Partition I section 12.1.1.1).
                                    _builder, ILOpCode.Conv_u);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 26894, 27678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 27694, 27716);

                f_10964_27694_27715(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 26456, 27727);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_26720_26738(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 26720, 26738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_26708_26767(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 26708, 26767);
                    return return_v;
                }


                int
                f_10964_26782_26877(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 26782, 26877);
                    return 0;
                }


                bool
                f_10964_26906_26927_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 26906, 26927);
                    return return_v;
                }


                int
                f_10964_27626_27662(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 27626, 27662);
                    return 0;
                }


                int
                f_10964_27694_27715(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 27694, 27715);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 26456, 27727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 26456, 27727);
            }
        }

        private void EmitPointerIndirectionOperator(BoundPointerIndirectionOperator expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 27739, 28023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 27862, 27909);

                f_10964_27862_27908(this, f_10964_27877_27895(expression), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 27923, 27976);

                f_10964_27923_27975(this, f_10964_27940_27955(expression), expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 27990, 28012);

                f_10964_27990_28011(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 27739, 28023);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_27877_27895(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 27877, 27895);
                    return return_v;
                }


                int
                f_10964_27862_27908(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 27862, 27908);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_27940_27955(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 27940, 27955);
                    return return_v;
                }


                int
                f_10964_27923_27975(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 27923, 27975);
                    return 0;
                }


                int
                f_10964_27990_28011(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 27990, 28011);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 27739, 28023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 27739, 28023);
            }
        }

        private void EmitDupExpression(BoundDup expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 28035, 28633);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28122, 28622) || true) && (f_10964_28126_28144(expression) == RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 28122, 28622);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28233, 28336) || true) && (used)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 28233, 28336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28283, 28317);

                        f_10964_28283_28316(_builder, ILOpCode.Dup);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 28233, 28336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 28122, 28622);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 28122, 28622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28402, 28436);

                    f_10964_28402_28435(_builder, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28514, 28567);

                    f_10964_28514_28566(this, f_10964_28531_28546(expression), expression.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28585, 28607);

                    f_10964_28585_28606(this, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 28122, 28622);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 28035, 28633);

                Microsoft.CodeAnalysis.RefKind
                f_10964_28126_28144(Microsoft.CodeAnalysis.CSharp.BoundDup
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28126, 28144);
                    return return_v;
                }


                int
                f_10964_28283_28316(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28283, 28316);
                    return 0;
                }


                int
                f_10964_28402_28435(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28402, 28435);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_28531_28546(Microsoft.CodeAnalysis.CSharp.BoundDup
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28531, 28546);
                    return return_v;
                }


                int
                f_10964_28514_28566(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28514, 28566);
                    return 0;
                }


                int
                f_10964_28585_28606(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28585, 28606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 28035, 28633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 28035, 28633);
            }
        }

        private void EmitDelegateCreationExpression(BoundDelegateCreationExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 28645, 29158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28768, 28817);

                var
                mg = f_10964_28777_28796(expression) as BoundMethodGroup
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28831, 28896);

                var
                receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 28846, 28856) || ((mg != null && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 28859, 28873)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 28876, 28895))) ? f_10964_28859_28873(mg) : f_10964_28876_28895(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28910, 28982);

                var
                meth = f_10964_28921_28941(expression) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10964, 28921, 28981) ?? f_10964_28945_28981(f_10964_28945_28958(receiver)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 28996, 29031);

                f_10964_28996_29030((object)meth != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29045, 29147);

                f_10964_29045_29146(this, expression, receiver, f_10964_29088_29116(expression), meth, f_10964_29124_29139(expression), used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 28645, 29158);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_28777_28796(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28777, 28796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_28859_28873(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28859, 28873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_28876_28895(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28876, 28895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_28921_28941(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28921, 28941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_28945_28958(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 28945, 28958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_28945_28981(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.DelegateInvokeMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28945, 28981);
                    return return_v;
                }


                int
                f_10964_28996_29030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 28996, 29030);
                    return 0;
                }


                bool
                f_10964_29088_29116(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29088, 29116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_29124_29139(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29124, 29139);
                    return return_v;
                }


                int
                f_10964_29045_29146(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, bool
                used)
                {
                    this_param.EmitDelegateCreation((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, receiver, isExtensionMethod, method, delegateType, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29045, 29146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 28645, 29158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 28645, 29158);
            }
        }

        private void EmitThisReferenceExpression(BoundThisReference thisRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 29170, 29558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29263, 29291);

                var
                thisType = f_10964_29278_29290(thisRef)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29305, 29363);

                f_10964_29305_29362(f_10964_29318_29335(thisType) != TypeKind.TypeParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29379, 29417);

                f_10964_29379_29416(
                            _builder, ILOpCode.Ldarg_0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29431, 29547) || true) && (f_10964_29435_29455(thisType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 29431, 29547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29489, 29532);

                    f_10964_29489_29531(this, thisType, thisRef.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 29431, 29547);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 29170, 29558);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_29278_29290(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29278, 29290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10964_29318_29335(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29318, 29335);
                    return return_v;
                }


                int
                f_10964_29305_29362(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29305, 29362);
                    return 0;
                }


                int
                f_10964_29379_29416(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29379, 29416);
                    return 0;
                }


                bool
                f_10964_29435_29455(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29435, 29455);
                    return return_v;
                }


                int
                f_10964_29489_29531(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29489, 29531);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 29170, 29558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 29170, 29558);
            }
        }

        private void EmitPseudoVariableValue(BoundPseudoVariable expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 29570, 29769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29674, 29758);

                f_10964_29674_29757(this, f_10964_29689_29750(f_10964_29689_29715(expression), expression, _diagnostics), used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 29570, 29769);

                Microsoft.CodeAnalysis.CSharp.PseudoVariableExpressions
                f_10964_29689_29715(Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable
                this_param)
                {
                    var return_v = this_param.EmitExpressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 29689, 29715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_29689_29750(Microsoft.CodeAnalysis.CSharp.PseudoVariableExpressions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPseudoVariable
                variable, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetValue(variable, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29689, 29750);
                    return return_v;
                }


                int
                f_10964_29674_29757(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29674, 29757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 29570, 29769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 29570, 29769);
            }
        }

        private void EmitSequencePointExpression(BoundSequencePointExpression node, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 29781, 30088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29892, 29916);

                f_10964_29892_29915(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 29997, 30041);

                f_10964_29997_30040(this, f_10964_30012_30027(node), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30055, 30077);

                f_10964_30055_30076(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 29781, 30088);

                int
                f_10964_29892_29915(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                node)
                {
                    this_param.EmitSequencePoint(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29892, 29915);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_30012_30027(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 30012, 30027);
                    return return_v;
                }


                int
                f_10964_29997_30040(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 29997, 30040);
                    return 0;
                }


                int
                f_10964_30055_30076(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 30055, 30076);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 29781, 30088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 29781, 30088);
            }
        }

        private void EmitSequencePoint(BoundSequencePointExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 30100, 30528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30190, 30215);

                var
                syntax = node.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30229, 30517) || true) && (_emitPdbSequencePoints)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 30229, 30517);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30289, 30502) || true) && (syntax == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 30289, 30502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30349, 30375);

                        f_10964_30349_30374(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 30289, 30502);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 30289, 30502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30457, 30483);

                        f_10964_30457_30482(this, syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 30289, 30502);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 30229, 30517);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 30100, 30528);

                int
                f_10964_30349_30374(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param)
                {
                    this_param.EmitHiddenSequencePoint();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 30349, 30374);
                    return 0;
                }


                int
                f_10964_30457_30482(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitSequencePoint(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 30457, 30482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 30100, 30528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 30100, 30528);
            }
        }

        private void EmitSequenceExpression(BoundSequence sequence, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 30540, 31752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30635, 30658);

                f_10964_30635_30657(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 30672, 30698);

                f_10964_30672_30697(this, sequence);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31414, 31485);

                f_10964_31414_31484(f_10964_31427_31446(f_10964_31427_31441(sequence)) != BoundKind.TypeExpression || (DynAbs.Tracing.TraceSender.Expression_False(10964, 31427, 31483) || !used));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31499, 31636) || true) && (f_10964_31503_31522(f_10964_31503_31517(sequence)) != BoundKind.TypeExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 31499, 31636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31584, 31621);

                    f_10964_31584_31620(this, f_10964_31599_31613(sequence), used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 31499, 31636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31720, 31741);

                f_10964_31720_31740(this, sequence);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 30540, 31752);

                int
                f_10964_30635_30657(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.DefineLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 30635, 30657);
                    return 0;
                }


                int
                f_10964_30672_30697(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.EmitSideEffects(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 30672, 30697);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_31427_31441(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 31427, 31441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_31427_31446(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 31427, 31446);
                    return return_v;
                }


                int
                f_10964_31414_31484(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 31414, 31484);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_31503_31517(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 31503, 31517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_31503_31522(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 31503, 31522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_31599_31613(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 31599, 31613);
                    return return_v;
                }


                int
                f_10964_31584_31620(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 31584, 31620);
                    return 0;
                }


                int
                f_10964_31720_31740(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                sequence)
                {
                    this_param.FreeLocals(sequence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 31720, 31740);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 30540, 31752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 30540, 31752);
            }
        }

        private void DefineLocals(BoundSequence sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 31764, 32112);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31838, 31921) || true) && (sequence.Locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 31838, 31921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31899, 31906);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 31838, 31921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31937, 31963);

                f_10964_31937_31962(
                            _builder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 31979, 32101);
                    foreach (var local in f_10964_32001_32016_I(f_10964_32001_32016(sequence)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 31979, 32101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32050, 32086);

                        f_10964_32050_32085(this, local, sequence.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 31979, 32101);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 31764, 32112);

                int
                f_10964_31937_31962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.OpenLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 31937, 31962);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_32001_32016(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 32001, 32016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_32050_32085(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.DefineLocal(local, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32050, 32085);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_32001_32016_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32001, 32016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 31764, 32112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 31764, 32112);
            }
        }

        private void FreeLocals(BoundSequence sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 32124, 32452);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32196, 32279) || true) && (sequence.Locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 32196, 32279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32257, 32264);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 32196, 32279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32295, 32322);

                f_10964_32295_32321(
                            _builder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32338, 32441);
                    foreach (var local in f_10964_32360_32375_I(f_10964_32360_32375(sequence)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 32338, 32441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32409, 32426);

                        f_10964_32409_32425(this, local);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 32338, 32441);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 104);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 32124, 32452);

                int
                f_10964_32295_32321(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32295, 32321);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_32360_32375(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 32360, 32375);
                    return return_v;
                }


                int
                f_10964_32409_32425(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    this_param.FreeLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32409, 32425);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_32360_32375_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32360, 32375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 32124, 32452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 32124, 32452);
            }
        }

        private void DefineAndRecordLocals(BoundSequence sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 32755, 33173);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32838, 32921) || true) && (sequence.Locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 32838, 32921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32899, 32906);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 32838, 32921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32937, 32963);

                f_10964_32937_32962(
                            _builder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 32979, 33162);
                    foreach (var local in f_10964_33001_33016_I(f_10964_33001_33016(sequence)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 32979, 33162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33050, 33101);

                        var
                        seqLocal = f_10964_33065_33100(this, local, sequence.Syntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33119, 33147);

                        f_10964_33119_33146(this, seqLocal);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 32979, 33162);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 184);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 32755, 33173);

                int
                f_10964_32937_32962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.OpenLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 32937, 32962);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_33001_33016(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 33001, 33016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_33065_33100(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.DefineLocal(local, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 33065, 33100);
                    return return_v;
                }


                int
                f_10964_33119_33146(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 33119, 33146);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10964_33001_33016_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 33001, 33016);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 32755, 33173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 32755, 33173);
            }
        }

        private void CloseScopeAndKeepLocals(BoundSequence sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 33549, 33771);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33634, 33717) || true) && (sequence.Locals.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 33634, 33717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33695, 33702);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 33634, 33717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33733, 33760);

                f_10964_33733_33759(
                            _builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 33549, 33771);

                int
                f_10964_33733_33759(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.CloseLocalScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 33733, 33759);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 33549, 33771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 33549, 33771);
            }
        }

        private void EmitSideEffects(BoundSequence sequence)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 33783, 34123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33860, 33899);

                var
                sideEffects = f_10964_33878_33898(sequence)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33913, 34112) || true) && (f_10964_33917_33946_M(!sideEffects.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 33913, 34112);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 33980, 34097);
                        foreach (var se in f_10964_33999_34010_I(sideEffects))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 33980, 34097);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34052, 34078);

                            f_10964_34052_34077(this, se, false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 33980, 34097);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 118);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 118);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 33913, 34112);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 33783, 34123);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_33878_33898(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 33878, 33898);
                    return return_v;
                }


                bool
                f_10964_33917_33946_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 33917, 33946);
                    return return_v;
                }


                int
                f_10964_34052_34077(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 34052, 34077);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_33999_34010_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 33999, 34010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 33783, 34123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 33783, 34123);
            }
        }

        private void EmitArguments(ImmutableArray<BoundExpression> arguments, ImmutableArray<ParameterSymbol> parameters, ImmutableArray<RefKind> argRefKindsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 34135, 35130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34402, 34544);

                f_10964_34402_34543(arguments.Length == parameters.Length || (DynAbs.Tracing.TraceSender.Expression_False(10964, 34415, 34497) || arguments.Length == parameters.Length + 1), "argument count must match parameter count");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34558, 34712);

                f_10964_34558_34711(parameters.All(p => p.RefKind == RefKind.None) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 34571, 34646) || f_10964_34621_34646_M(!argRefKindsOpt.IsDefault)), "there are nontrivial parameters, so we must have argRefKinds");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34726, 34874);

                f_10964_34726_34873(argRefKindsOpt.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10964, 34739, 34808) || argRefKindsOpt.Length == arguments.Length), "if we have argRefKinds, we should have one for each argument");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34899, 34904);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34890, 35119) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34928, 34931)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 34890, 35119))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 34890, 35119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 34965, 35047);

                        RefKind
                        argRefKind = f_10964_34986_35046(arguments, parameters, argRefKindsOpt, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35065, 35104);

                        f_10964_35065_35103(this, arguments[i], argRefKind);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 34135, 35130);

                int
                f_10964_34402_34543(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 34402, 34543);
                    return 0;
                }


                bool
                f_10964_34621_34646_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 34621, 34646);
                    return return_v;
                }


                int
                f_10964_34558_34711(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 34558, 34711);
                    return 0;
                }


                int
                f_10964_34726_34873(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 34726, 34873);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_34986_35046(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt, int
                i)
                {
                    var return_v = GetArgumentRefKind(arguments, parameters, argRefKindsOpt, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 34986, 35046);
                    return return_v;
                }


                int
                f_10964_35065_35103(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    this_param.EmitArgument(argument, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 35065, 35103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 34135, 35130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 34135, 35130);
            }
        }

        internal static RefKind GetArgumentRefKind(ImmutableArray<BoundExpression> arguments, ImmutableArray<ParameterSymbol> parameters, ImmutableArray<RefKind> argRefKindsOpt, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 35340, 36625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35541, 35560);

                RefKind
                argRefKind
                = default(RefKind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35574, 36580) || true) && (i < parameters.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 35574, 36580);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35633, 36362) || true) && (f_10964_35637_35662_M(!argRefKindsOpt.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 35637, 35691) && i < argRefKindsOpt.Length))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 35633, 36362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35821, 35852);

                        argRefKind = argRefKindsOpt[i];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 35876, 36151);

                        f_10964_35876_36150(argRefKind == f_10964_35903_35924(parameters[i]) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 35889, 36036) || argRefKind == RefKindExtensions.StrictIn && (DynAbs.Tracing.TraceSender.Expression_True(10964, 35957, 36036) && f_10964_36001_36022(parameters[i]) == RefKind.In)), "in Emit the argument RefKind must be compatible with the corresponding parameter");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 35633, 36362);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 35633, 36362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36308, 36343);

                        argRefKind = f_10964_36321_36342(parameters[i]);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 35633, 36362);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 35574, 36580);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 35574, 36580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36460, 36521);

                    f_10964_36460_36520(f_10964_36473_36490(arguments[i]) == BoundKind.ArgListOperator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36539, 36565);

                    argRefKind = RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 35574, 36580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36596, 36614);

                return argRefKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 35340, 36625);

                bool
                f_10964_35637_35662_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 35637, 35662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_35903_35924(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 35903, 35924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_36001_36022(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36001, 36022);
                    return return_v;
                }


                int
                f_10964_35876_36150(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 35876, 36150);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_36321_36342(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36321, 36342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_36473_36490(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36473, 36490);
                    return return_v;
                }


                int
                f_10964_36460_36520(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 36460, 36520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 35340, 36625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 35340, 36625);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitArrayElementLoad(BoundArrayAccess arrayAccess, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 36637, 40840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36736, 36787);

                f_10964_36736_36786(this, f_10964_36751_36773(arrayAccess), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36801, 36839);

                f_10964_36801_36838(this, f_10964_36818_36837(arrayAccess));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36855, 40791) || true) && (f_10964_36859_36915(((ArrayTypeSymbol)f_10964_36877_36904(f_10964_36877_36899(arrayAccess)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 36855, 40791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 36949, 36984);

                    var
                    elementType = f_10964_36967_36983(arrayAccess)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37002, 37225) || true) && (f_10964_37006_37030(elementType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37002, 37225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37142, 37206);

                        elementType = f_10964_37156_37205(((NamedTypeSymbol)elementType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37002, 37225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37245, 40570);

                    switch (f_10964_37253_37282(elementType))
                    {

                        case Microsoft.Cci.PrimitiveTypeCode.Int8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37392, 37432);

                            f_10964_37392_37431(_builder, ILOpCode.Ldelem_i1);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 37458, 37464);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Boolean:
                        case Microsoft.Cci.PrimitiveTypeCode.UInt8:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37624, 37664);

                            f_10964_37624_37663(_builder, ILOpCode.Ldelem_u1);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 37690, 37696);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 37789, 37829);

                            f_10964_37789_37828(_builder, ILOpCode.Ldelem_i2);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 37855, 37861);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Char:
                        case Microsoft.Cci.PrimitiveTypeCode.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 38019, 38059);

                            f_10964_38019_38058(_builder, ILOpCode.Ldelem_u2);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 38085, 38091);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 38184, 38224);

                            f_10964_38184_38223(_builder, ILOpCode.Ldelem_i4);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 38250, 38256);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 38350, 38390);

                            f_10964_38350_38389(_builder, ILOpCode.Ldelem_u4);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 38416, 38422);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Int64:
                        case Microsoft.Cci.PrimitiveTypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 38581, 38621);

                            f_10964_38581_38620(_builder, ILOpCode.Ldelem_i8);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 38647, 38653);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.IntPtr:
                        case Microsoft.Cci.PrimitiveTypeCode.UIntPtr:
                        case Microsoft.Cci.PrimitiveTypeCode.Pointer:
                        case Microsoft.Cci.PrimitiveTypeCode.FunctionPointer:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 38956, 38995);

                            f_10964_38956_38994(_builder, ILOpCode.Ldelem_i);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 39021, 39027);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Float32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39122, 39162);

                            f_10964_39122_39161(_builder, ILOpCode.Ldelem_r4);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 39188, 39194);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        case Microsoft.Cci.PrimitiveTypeCode.Float64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39289, 39329);

                            f_10964_39289_39328(_builder, ILOpCode.Ldelem_r8);
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 39355, 39361);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 37245, 40570);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39419, 40519) || true) && (f_10964_39423_39456(elementType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 39419, 40519);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39514, 39555);

                                f_10964_39514_39554(_builder, ILOpCode.Ldelem_ref);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 39419, 40519);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 39419, 40519);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39669, 40411) || true) && (used)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 39669, 40411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 39743, 39780);

                                    f_10964_39743_39779(_builder, ILOpCode.Ldelem);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 39669, 40411);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 39669, 40411);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40108, 40306) || true) && (f_10964_40112_40132(elementType) == TypeKind.TypeParameter)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 40108, 40306);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40232, 40271);

                                        f_10964_40232_40270(_builder, ILOpCode.Readonly);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 40108, 40306);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40342, 40380);

                                    f_10964_40342_40379(
                                                                    _builder, ILOpCode.Ldelema);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 39669, 40411);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40443, 40492);

                                f_10964_40443_40491(this, elementType, arrayAccess.Syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 39419, 40519);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10964, 40545, 40551);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 37245, 40570);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 36855, 40791);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 36855, 40791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40636, 40776);

                    f_10964_40636_40775(_builder, f_10964_40666_40729(_module, f_10964_40701_40728(f_10964_40701_40723(arrayAccess))), f_10964_40731_40753(arrayAccess).Syntax, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 36855, 40791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40807, 40829);

                f_10964_40807_40828(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 36637, 40840);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_36751_36773(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36751, 36773);
                    return return_v;
                }


                int
                f_10964_36736_36786(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 36736, 36786);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_36818_36837(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36818, 36837);
                    return return_v;
                }


                int
                f_10964_36801_36838(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    this_param.EmitArrayIndices(indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 36801, 36838);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_36877_36899(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36877, 36899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_36877_36904(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36877, 36904);
                    return return_v;
                }


                bool
                f_10964_36859_36915(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36859, 36915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_36967_36983(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 36967, 36983);
                    return return_v;
                }


                bool
                f_10964_37006_37030(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 37006, 37030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_37156_37205(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 37156, 37205);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10964_37253_37282(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 37253, 37282);
                    return return_v;
                }


                int
                f_10964_37392_37431(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 37392, 37431);
                    return 0;
                }


                int
                f_10964_37624_37663(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 37624, 37663);
                    return 0;
                }


                int
                f_10964_37789_37828(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 37789, 37828);
                    return 0;
                }


                int
                f_10964_38019_38058(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 38019, 38058);
                    return 0;
                }


                int
                f_10964_38184_38223(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 38184, 38223);
                    return 0;
                }


                int
                f_10964_38350_38389(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 38350, 38389);
                    return 0;
                }


                int
                f_10964_38581_38620(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 38581, 38620);
                    return 0;
                }


                int
                f_10964_38956_38994(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 38956, 38994);
                    return 0;
                }


                int
                f_10964_39122_39161(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 39122, 39161);
                    return 0;
                }


                int
                f_10964_39289_39328(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 39289, 39328);
                    return 0;
                }


                bool
                f_10964_39423_39456(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 39423, 39456);
                    return return_v;
                }


                int
                f_10964_39514_39554(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 39514, 39554);
                    return 0;
                }


                int
                f_10964_39743_39779(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 39743, 39779);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10964_40112_40132(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 40112, 40132);
                    return return_v;
                }


                int
                f_10964_40232_40270(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40232, 40270);
                    return 0;
                }


                int
                f_10964_40342_40379(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40342, 40379);
                    return 0;
                }


                int
                f_10964_40443_40491(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40443, 40491);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_40701_40723(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 40701, 40723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_40701_40728(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 40701, 40728);
                    return return_v;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10964_40666_40729(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40666, 40729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_40731_40753(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 40731, 40753);
                    return return_v;
                }


                int
                f_10964_40636_40775(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayElementLoad(arrayType, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40636, 40775);
                    return 0;
                }


                int
                f_10964_40807_40828(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 40807, 40828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 36637, 40840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 36637, 40840);
            }
        }

        private void EmitFieldLoad(BoundFieldAccess fieldAccess, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 40852, 43594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40944, 40980);

                var
                field = f_10964_40956_40979(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 40996, 41708) || true) && (!used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 40996, 41708);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41123, 41216) || true) && (f_10964_41127_41148(field))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 41123, 41216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41190, 41197);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 41123, 41216);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41460, 41693) || true) && (f_10964_41464_41481_M(!field.IsVolatile) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 41464, 41500) && f_10964_41485_41500_M(!field.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 41464, 41550) && f_10964_41504_41550(f_10964_41504_41532(f_10964_41504_41527(fieldAccess)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 41460, 41693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41592, 41645);

                        f_10964_41592_41644(this, f_10964_41607_41630(fieldAccess), used: false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41667, 41674);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 41460, 41693);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 40996, 41708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 41724, 41903);

                f_10964_41724_41902(f_10964_41737_41751_M(!field.IsConst) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 41737, 41817) || f_10964_41755_41787(f_10964_41755_41775(field)) == SpecialType.System_Decimal), "rewriter should lower constant fields into constant expressions");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42069, 43547) || true) && (f_10964_42073_42087(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 42069, 43547);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42121, 42241) || true) && (f_10964_42125_42141(field))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 42121, 42241);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42183, 42222);

                        f_10964_42183_42221(_builder, ILOpCode.Volatile);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 42121, 42241);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42259, 42296);

                    f_10964_42259_42295(_builder, ILOpCode.Ldsfld);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42314, 42357);

                    f_10964_42314_42356(this, field, fieldAccess.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 42069, 43547);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 42069, 43547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42423, 42462);

                    var
                    receiver = f_10964_42438_42461(fieldAccess)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42480, 42514);

                    TypeSymbol
                    fieldType = f_10964_42503_42513(field)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42532, 43532) || true) && (f_10964_42536_42557(fieldType) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 42536, 42603) && (object)fieldType == (object)f_10964_42590_42603(receiver)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 42532, 43532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42835, 42866);

                        f_10964_42835_42865(this, receiver, used);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 42532, 43532);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 42532, 43532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 42948, 42991);

                        var
                        temp = f_10964_42959_42990(this, receiver)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43013, 43232) || true) && (temp != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 43013, 43232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43079, 43168);

                            f_10964_43079_43167(f_10964_43092_43121(receiver), "only clr-ambiguous structs use temps here");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43194, 43209);

                            f_10964_43194_43208(this, temp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 43013, 43232);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43256, 43388) || true) && (f_10964_43260_43276(field))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 43256, 43388);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43326, 43365);

                            f_10964_43326_43364(_builder, ILOpCode.Volatile);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 43256, 43388);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43412, 43448);

                        f_10964_43412_43447(
                                            _builder, ILOpCode.Ldfld);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43470, 43513);

                        f_10964_43470_43512(this, field, fieldAccess.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 42532, 43532);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 42069, 43547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43561, 43583);

                f_10964_43561_43582(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 40852, 43594);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_40956_40979(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 40956, 40979);
                    return return_v;
                }


                bool
                f_10964_41127_41148(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsCapturedFrame;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41127, 41148);
                    return return_v;
                }


                bool
                f_10964_41464_41481_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41464, 41481);
                    return return_v;
                }


                bool
                f_10964_41485_41500_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41485, 41500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_41504_41527(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41504, 41527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_41504_41532(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41504, 41532);
                    return return_v;
                }


                bool
                f_10964_41504_41550(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 41504, 41550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_41607_41630(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41607, 41630);
                    return return_v;
                }


                int
                f_10964_41592_41644(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 41592, 41644);
                    return 0;
                }


                bool
                f_10964_41737_41751_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41737, 41751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_41755_41775(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41755, 41775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_41755_41787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 41755, 41787);
                    return return_v;
                }


                int
                f_10964_41724_41902(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 41724, 41902);
                    return 0;
                }


                bool
                f_10964_42073_42087(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42073, 42087);
                    return return_v;
                }


                bool
                f_10964_42125_42141(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42125, 42141);
                    return return_v;
                }


                int
                f_10964_42183_42221(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 42183, 42221);
                    return 0;
                }


                int
                f_10964_42259_42295(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 42259, 42295);
                    return 0;
                }


                int
                f_10964_42314_42356(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 42314, 42356);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_42438_42461(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42438, 42461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_42503_42513(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42503, 42513);
                    return return_v;
                }


                bool
                f_10964_42536_42557(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42536, 42557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_42590_42603(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 42590, 42603);
                    return return_v;
                }


                int
                f_10964_42835_42865(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 42835, 42865);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_42959_42990(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.EmitFieldLoadReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 42959, 42990);
                    return return_v;
                }


                bool
                f_10964_43092_43121(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr)
                {
                    var return_v = FieldLoadMustUseRef(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43092, 43121);
                    return return_v;
                }


                int
                f_10964_43079_43167(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43079, 43167);
                    return 0;
                }


                int
                f_10964_43194_43208(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43194, 43208);
                    return 0;
                }


                bool
                f_10964_43260_43276(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 43260, 43276);
                    return return_v;
                }


                int
                f_10964_43326_43364(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43326, 43364);
                    return 0;
                }


                int
                f_10964_43412_43447(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43412, 43447);
                    return 0;
                }


                int
                f_10964_43470_43512(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43470, 43512);
                    return 0;
                }


                int
                f_10964_43561_43582(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43561, 43582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 40852, 43594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 40852, 43594);
            }
        }

        private LocalDefinition EmitFieldLoadReceiver(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 43606, 44268);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 43966, 44184) || true) && (f_10964_43970_43999(receiver) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 43970, 44032) || f_10964_44003_44032(this, receiver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 43966, 44184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 44066, 44169);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 44073, 44111) || ((f_10964_44073_44111(this, receiver) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 44114, 44118)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 44121, 44168))) ? null : f_10964_44121_44168(this, receiver, AddressKind.ReadOnly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 43966, 44184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 44200, 44231);

                f_10964_44200_44230(this, receiver, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 44245, 44257);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 43606, 44268);

                bool
                f_10964_43970_43999(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = FieldLoadMustUseRef(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 43970, 43999);
                    return return_v;
                }


                bool
                f_10964_44003_44032(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.FieldLoadPrefersRef(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 44003, 44032);
                    return return_v;
                }


                bool
                f_10964_44073_44111(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.EmitFieldLoadReceiverAddress(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 44073, 44111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_44121_44168(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 44121, 44168);
                    return return_v;
                }


                int
                f_10964_44200_44230(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 44200, 44230);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 43606, 44268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 43606, 44268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EmitFieldLoadReceiverAddress(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 44780, 46116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 44872, 46076) || true) && (receiver == null || (DynAbs.Tracing.TraceSender.Expression_False(10964, 44876, 44922) || f_10964_44896_44922_M(!f_10964_44897_44910(receiver).IsValueType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 44872, 46076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 44956, 44969);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 44872, 46076);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 44872, 46076);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45003, 46076) || true) && (f_10964_45007_45020(receiver) == BoundKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 45003, 46076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45078, 45121);

                        var
                        conversion = (BoundConversion)receiver
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45139, 45459) || true) && (f_10964_45143_45168(conversion) == ConversionKind.Unboxing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 45139, 45459);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45237, 45278);

                            f_10964_45237_45277(this, f_10964_45252_45270(conversion), true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45300, 45336);

                            f_10964_45300_45335(_builder, ILOpCode.Unbox);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45358, 45406);

                            f_10964_45358_45405(this, f_10964_45374_45387(receiver), receiver.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45428, 45440);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 45139, 45459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 45003, 46076);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 45003, 46076);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45493, 46076) || true) && (f_10964_45497_45510(receiver) == BoundKind.FieldAccess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 45493, 46076);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45569, 45614);

                            var
                            fieldAccess = (BoundFieldAccess)receiver
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45632, 45668);

                            var
                            field = f_10964_45644_45667(fieldAccess)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45688, 46061) || true) && (f_10964_45692_45707_M(!field.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 45692, 45764) && f_10964_45711_45764(this, f_10964_45740_45763(fieldAccess))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 45688, 46061);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45806, 45882);

                                f_10964_45806_45881(f_10964_45819_45836_M(!field.IsVolatile), "volatile valuetype fields are unexpected");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45906, 45943);

                                f_10964_45906_45942(
                                                    _builder, ILOpCode.Ldflda);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 45965, 46008);

                                f_10964_45965_46007(this, field, fieldAccess.Syntax);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46030, 46042);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 45688, 46061);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 45493, 46076);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 45003, 46076);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 44872, 46076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46092, 46105);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 44780, 46116);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_44897_44910(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 44897, 44910);
                    return return_v;
                }


                bool
                f_10964_44896_44922_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 44896, 44922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_45007_45020(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45007, 45020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10964_45143_45168(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45143, 45168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_45252_45270(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45252, 45270);
                    return return_v;
                }


                int
                f_10964_45237_45277(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45237, 45277);
                    return 0;
                }


                int
                f_10964_45300_45335(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45300, 45335);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_45374_45387(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45374, 45387);
                    return return_v;
                }


                int
                f_10964_45358_45405(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45358, 45405);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_45497_45510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45497, 45510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_45644_45667(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45644, 45667);
                    return return_v;
                }


                bool
                f_10964_45692_45707_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45692, 45707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_45740_45763(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45740, 45763);
                    return return_v;
                }


                bool
                f_10964_45711_45764(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.EmitFieldLoadReceiverAddress(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45711, 45764);
                    return return_v;
                }


                bool
                f_10964_45819_45836_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 45819, 45836);
                    return return_v;
                }


                int
                f_10964_45806_45881(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45806, 45881);
                    return 0;
                }


                int
                f_10964_45906_45942(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45906, 45942);
                    return 0;
                }


                int
                f_10964_45965_46007(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 45965, 46007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 44780, 46116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 44780, 46116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool FieldLoadPrefersRef(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 46493, 48259);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46641, 46738) || true) && (!f_10964_46646_46677(f_10964_46646_46659(receiver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 46641, 46738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46711, 46723);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 46641, 46738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46801, 46976) || true) && (f_10964_46805_46818(receiver) == BoundKind.Conversion && (DynAbs.Tracing.TraceSender.Expression_True(10964, 46805, 46915) && f_10964_46846_46888(((BoundConversion)receiver)) == ConversionKind.Unboxing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 46801, 46976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 46949, 46961);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 46801, 46976);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47036, 47142) || true) && (!f_10964_47041_47080(this, receiver, AddressKind.ReadOnly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47036, 47142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47114, 47127);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47036, 47142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47158, 48220);

                switch (f_10964_47166_47179(receiver))
                {

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47158, 48220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47309, 47383);

                        return f_10964_47316_47366(f_10964_47316_47358(((BoundParameter)receiver))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47158, 48220);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47158, 48220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47495, 47561);

                        return f_10964_47502_47544(f_10964_47502_47536(((BoundLocal)receiver))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47158, 48220);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47158, 48220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47627, 47687);

                        return f_10964_47634_47686(this, f_10964_47654_47685(((BoundSequence)receiver)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47158, 48220);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47158, 48220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47756, 47801);

                        var
                        fieldAccess = (BoundFieldAccess)receiver
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47823, 47944) || true) && (f_10964_47827_47859(f_10964_47827_47850(fieldAccess)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47823, 47944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47909, 47921);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47823, 47944);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 47968, 48129) || true) && (f_10964_47972_48043(fieldAccess, _module.Compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 47968, 48129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48093, 48106);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47968, 48129);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48153, 48205);

                        return f_10964_48160_48204(this, f_10964_48180_48203(fieldAccess));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 47158, 48220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48236, 48248);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 46493, 48259);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_46646_46659(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 46646, 46659);
                    return return_v;
                }


                bool
                f_10964_46646_46677(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 46646, 46677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_46805_46818(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 46805, 46818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10964_46846_46888(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 46846, 46888);
                    return return_v;
                }


                bool
                f_10964_47041_47080(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 47041, 47080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_47166_47179(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47166, 47179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_47316_47358(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47316, 47358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_47316_47366(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47316, 47366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_47502_47536(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47502, 47536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_47502_47544(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47502, 47544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_47654_47685(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47654, 47685);
                    return return_v;
                }


                bool
                f_10964_47634_47686(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.FieldLoadPrefersRef(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 47634, 47686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_47827_47850(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47827, 47850);
                    return return_v;
                }


                bool
                f_10964_47827_47859(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 47827, 47859);
                    return return_v;
                }


                bool
                f_10964_47972_48043(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = DiagnosticsPass.IsNonAgileFieldAccess(fieldAccess, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 47972, 48043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_48180_48203(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 48180, 48203);
                    return return_v;
                }


                bool
                f_10964_48160_48204(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.FieldLoadPrefersRef(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 48160, 48204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 46493, 48259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 46493, 48259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool FieldLoadMustUseRef(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 48271, 50806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48358, 48379);

                var
                type = f_10964_48369_48378(expr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48471, 48558) || true) && (f_10964_48475_48497(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 48471, 48558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48531, 48543);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 48471, 48558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 48930, 50600);

                switch (f_10964_48938_48954(type))
                {

                    case SpecialType.System_Byte:
                    // case PT_SHORT:
                    case SpecialType.System_Int16:
                    // case PT_INT:
                    case SpecialType.System_Int32:
                    // case PT_LONG:
                    case SpecialType.System_Int64:
                    // case PT_CHAR:
                    case SpecialType.System_Char:
                    // case PT_BOOL:
                    case SpecialType.System_Boolean:
                    // case PT_SBYTE:
                    case SpecialType.System_SByte:
                    // case PT_USHORT:
                    case SpecialType.System_UInt16:
                    // case PT_UINT:
                    case SpecialType.System_UInt32:
                    // case PT_ULONG:
                    case SpecialType.System_UInt64:
                    // case PT_INTPTR:
                    case SpecialType.System_IntPtr:
                    // case PT_UINTPTR:
                    case SpecialType.System_UIntPtr:
                    // case PT_FLOAT:
                    case SpecialType.System_Single:
                    // case PT_DOUBLE:
                    case SpecialType.System_Double:
                    // case PT_TYPEHANDLE:
                    case SpecialType.System_RuntimeTypeHandle:
                    // case PT_FIELDHANDLE:
                    case SpecialType.System_RuntimeFieldHandle:
                    // case PT_METHODHANDLE:
                    case SpecialType.System_RuntimeMethodHandle:
                    //case PT_ARGUMENTHANDLE:
                    case SpecialType.System_RuntimeArgumentHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 48930, 50600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 50573, 50585);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 48930, 50600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 50770, 50795);

                return f_10964_50777_50794(type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 48271, 50806);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_48369_48378(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 48369, 48378);
                    return return_v;
                }


                bool
                f_10964_48475_48497(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 48475, 48497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_48938_48954(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 48938, 48954);
                    return return_v;
                }


                bool
                f_10964_50777_50794(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 50777, 50794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 48271, 50806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 48271, 50806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int ParameterSlot(BoundParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 50820, 51133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 50903, 50939);

                var
                sym = f_10964_50913_50938(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 50953, 50976);

                int
                slot = f_10964_50964_50975(sym)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 50990, 51096) || true) && (f_10964_50994_51024_M(!f_10964_50995_51015(sym).IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 50990, 51096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51058, 51065);

                    slot++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 50990, 51096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51110, 51122);

                return slot;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 50820, 51133);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_50913_50938(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 50913, 50938);
                    return return_v;
                }


                int
                f_10964_50964_50975(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 50964, 50975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10964_50995_51015(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 50995, 51015);
                    return return_v;
                }


                bool
                f_10964_50994_51024_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 50994, 51024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 50820, 51133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 50820, 51133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitLocalLoad(BoundLocal local, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 51145, 51971);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51225, 51787) || true) && (f_10964_51229_51260(this, f_10964_51242_51259(local)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 51225, 51787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51349, 51371);

                    f_10964_51349_51370(this, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 51225, 51787);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 51225, 51787);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51437, 51772) || true) && (used)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 51437, 51772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51487, 51532);

                        LocalDefinition
                        definition = f_10964_51516_51531(this, local)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51554, 51589);

                        f_10964_51554_51588(_builder, definition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 51437, 51772);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 51437, 51772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51746, 51753);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 51437, 51772);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 51225, 51787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51803, 51960) || true) && (used && (DynAbs.Tracing.TraceSender.Expression_True(10964, 51807, 51856) && f_10964_51815_51840(f_10964_51815_51832(local)) != RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 51803, 51960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 51890, 51945);

                    f_10964_51890_51944(this, f_10964_51907_51929(f_10964_51907_51924(local)), local.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 51803, 51960);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 51145, 51971);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_51242_51259(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 51242, 51259);
                    return return_v;
                }


                bool
                f_10964_51229_51260(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 51229, 51260);
                    return return_v;
                }


                int
                f_10964_51349_51370(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 51349, 51370);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_51516_51531(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                localExpression)
                {
                    var return_v = this_param.GetLocal(localExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 51516, 51531);
                    return return_v;
                }


                int
                f_10964_51554_51588(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 51554, 51588);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_51815_51832(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 51815, 51832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_51815_51840(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 51815, 51840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_51907_51924(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 51907, 51924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_51907_51929(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 51907, 51929);
                    return return_v;
                }


                int
                f_10964_51890_51944(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 51890, 51944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 51145, 51971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 51145, 51971);
            }
        }

        private void EmitParameterLoad(BoundParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 51983, 52400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52064, 52100);

                int
                slot = f_10964_52075_52099(parameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52114, 52152);

                f_10964_52114_52151(_builder, slot);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52168, 52389) || true) && (f_10964_52172_52205(f_10964_52172_52197(parameter)) != RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52168, 52389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52255, 52306);

                    var
                    parameterType = f_10964_52275_52305(f_10964_52275_52300(parameter))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52324, 52374);

                    f_10964_52324_52373(this, parameterType, parameter.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52168, 52389);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 51983, 52400);

                int
                f_10964_52075_52099(Microsoft.CodeAnalysis.CSharp.BoundParameter
                parameter)
                {
                    var return_v = ParameterSlot(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 52075, 52099);
                    return return_v;
                }


                int
                f_10964_52114_52151(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                argNumber)
                {
                    this_param.EmitLoadArgumentOpcode(argNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 52114, 52151);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_52172_52197(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52172, 52197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_52172_52205(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52172, 52205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_52275_52300(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52275, 52300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_52275_52305(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52275, 52305);
                    return return_v;
                }


                int
                f_10964_52324_52373(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 52324, 52373);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 51983, 52400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 51983, 52400);
            }
        }

        private void EmitLoadIndirect(TypeSymbol type, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 52412, 55100);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52506, 52692) || true) && (f_10964_52510_52527(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52506, 52692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52627, 52677);

                    type = f_10964_52634_52676(((NamedTypeSymbol)type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52506, 52692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52708, 55089);

                switch (f_10964_52716_52738(type))
                {

                    case Microsoft.Cci.PrimitiveTypeCode.Int8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 52836, 52875);

                        f_10964_52836_52874(_builder, ILOpCode.Ldind_i1);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 52897, 52903);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Boolean:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53051, 53090);

                        f_10964_53051_53089(_builder, ILOpCode.Ldind_u1);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53112, 53118);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53203, 53242);

                        f_10964_53203_53241(_builder, ILOpCode.Ldind_i2);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53264, 53270);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Char:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53416, 53455);

                        f_10964_53416_53454(_builder, ILOpCode.Ldind_u2);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53477, 53483);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53568, 53607);

                        f_10964_53568_53606(_builder, ILOpCode.Ldind_i4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53629, 53635);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53721, 53760);

                        f_10964_53721_53759(_builder, ILOpCode.Ldind_u4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53782, 53788);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Int64:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 53935, 53974);

                        f_10964_53935_53973(_builder, ILOpCode.Ldind_i8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 53996, 54002);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.IntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.UIntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.Pointer:
                    case Microsoft.Cci.PrimitiveTypeCode.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54285, 54323);

                        f_10964_54285_54322(_builder, ILOpCode.Ldind_i);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 54345, 54351);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Float32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54438, 54477);

                        f_10964_54438_54476(_builder, ILOpCode.Ldind_r4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 54499, 54505);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    case Microsoft.Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54592, 54631);

                        f_10964_54592_54630(_builder, ILOpCode.Ldind_r8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 54653, 54659);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 52708, 55089);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54709, 55046) || true) && (f_10964_54713_54739(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 54709, 55046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54789, 54829);

                            f_10964_54789_54828(_builder, ILOpCode.Ldind_ref);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 54709, 55046);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 54709, 55046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54927, 54963);

                            f_10964_54927_54962(_builder, ILOpCode.Ldobj);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 54989, 55023);

                            f_10964_54989_55022(this, type, syntaxNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 54709, 55046);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 55068, 55074);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 52708, 55089);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 52412, 55100);

                bool
                f_10964_52510_52527(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 52510, 52527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_52634_52676(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52634, 52676);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10964_52716_52738(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 52716, 52738);
                    return return_v;
                }


                int
                f_10964_52836_52874(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 52836, 52874);
                    return 0;
                }


                int
                f_10964_53051_53089(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53051, 53089);
                    return 0;
                }


                int
                f_10964_53203_53241(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53203, 53241);
                    return 0;
                }


                int
                f_10964_53416_53454(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53416, 53454);
                    return 0;
                }


                int
                f_10964_53568_53606(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53568, 53606);
                    return 0;
                }


                int
                f_10964_53721_53759(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53721, 53759);
                    return 0;
                }


                int
                f_10964_53935_53973(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 53935, 53973);
                    return 0;
                }


                int
                f_10964_54285_54322(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54285, 54322);
                    return 0;
                }


                int
                f_10964_54438_54476(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54438, 54476);
                    return 0;
                }


                int
                f_10964_54592_54630(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54592, 54630);
                    return 0;
                }


                bool
                f_10964_54713_54739(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54713, 54739);
                    return return_v;
                }


                int
                f_10964_54789_54828(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54789, 54828);
                    return 0;
                }


                int
                f_10964_54927_54962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54927, 54962);
                    return 0;
                }


                int
                f_10964_54989_55022(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 54989, 55022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 52412, 55100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 52412, 55100);
            }
        }

        private bool CanUseCallOnRefTypeReceiver(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 55407, 59048);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 55644, 55741) || true) && (f_10964_55648_55679(f_10964_55648_55661(receiver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 55644, 55741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 55713, 55726);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 55644, 55741);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 55757, 55834);

                f_10964_55757_55833(f_10964_55770_55805(f_10964_55770_55783(receiver)), "this is not a reference");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 55848, 55934);

                f_10964_55848_55933(f_10964_55861_55874(receiver) != BoundKind.BaseReference, "base should always use call");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 55950, 55988);

                var
                constVal = f_10964_55965_55987(receiver)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56002, 56169) || true) && (constVal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56002, 56169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56130, 56154);

                    return f_10964_56137_56153_M(!constVal.IsNull);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56002, 56169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56185, 59008);

                switch (f_10964_56193_56206(receiver))
                {

                    case BoundKind.ArrayCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56291, 56303);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56510, 56522);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56590, 56633);

                        var
                        conversion = (BoundConversion)receiver
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56657, 57397);

                        switch (f_10964_56665_56690(conversion))
                        {

                            case ConversionKind.Boxing:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56657, 57397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 56981, 56993);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56657, 57397);

                            case ConversionKind.MethodGroup:
                            case ConversionKind.AnonymousFunction:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56657, 57397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 57147, 57159);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56657, 57397);

                            case ConversionKind.ExplicitReference:
                            case ConversionKind.ImplicitReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56657, 57397);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 57319, 57374);

                                return f_10964_57326_57373(this, f_10964_57354_57372(conversion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56657, 57397);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 57419, 57425);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 57826, 57838);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 57966, 58030);

                        return f_10964_57973_58029(f_10964_57973_58013(((BoundFieldAccess)receiver)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58152, 58245);

                        return f_10964_58159_58209(f_10964_58159_58193(((BoundLocal)receiver))) == SynthesizedLocalKind.FrameCache;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.DelegateCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58329, 58341);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58407, 58456);

                        var
                        seqValue = f_10964_58422_58455(((BoundSequence)(receiver)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58478, 58523);

                        return f_10964_58485_58522(this, seqValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58599, 58651);

                        var
                        rhs = f_10964_58609_58650(((BoundAssignmentOperator)receiver))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58673, 58713);

                        return f_10964_58680_58712(this, rhs);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.TypeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58785, 58797);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                    case BoundKind.ConditionalReceiver:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 56185, 59008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 58874, 58886);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 56185, 59008);

                        //TODO: there could be more cases where we can be sure that receiver is not a null.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59024, 59037);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 55407, 59048);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_55648_55661(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 55648, 55661);
                    return return_v;
                }


                bool
                f_10964_55648_55679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 55648, 55679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_55770_55783(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 55770, 55783);
                    return return_v;
                }


                bool
                f_10964_55770_55805(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 55770, 55805);
                    return return_v;
                }


                int
                f_10964_55757_55833(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 55757, 55833);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_55861_55874(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 55861, 55874);
                    return return_v;
                }


                int
                f_10964_55848_55933(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 55848, 55933);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_55965_55987(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 55965, 55987);
                    return return_v;
                }


                bool
                f_10964_56137_56153_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 56137, 56153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_56193_56206(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 56193, 56206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10964_56665_56690(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 56665, 56690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_57354_57372(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 57354, 57372);
                    return return_v;
                }


                bool
                f_10964_57326_57373(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.CanUseCallOnRefTypeReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 57326, 57373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_57973_58013(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 57973, 58013);
                    return return_v;
                }


                bool
                f_10964_57973_58029(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsCapturedFrame;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 57973, 58029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_58159_58193(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 58159, 58193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10964_58159_58209(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 58159, 58209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_58422_58455(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 58422, 58455);
                    return return_v;
                }


                bool
                f_10964_58485_58522(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.CanUseCallOnRefTypeReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 58485, 58522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_58609_58650(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 58609, 58650);
                    return return_v;
                }


                bool
                f_10964_58680_58712(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.CanUseCallOnRefTypeReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 58680, 58712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 55407, 59048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 55407, 59048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsThisReceiver(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 59162, 59582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59240, 59542);

                switch (f_10964_59248_59261(receiver))
                {

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 59240, 59542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59346, 59358);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 59240, 59542);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 59240, 59542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59424, 59473);

                        var
                        seqValue = f_10964_59439_59472(((BoundSequence)(receiver)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59495, 59527);

                        return f_10964_59502_59526(this, seqValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 59240, 59542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59558, 59571);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 59162, 59582);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_59248_59261(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 59248, 59261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_59439_59472(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 59439, 59472);
                    return return_v;
                }


                bool
                f_10964_59502_59526(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.IsThisReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 59502, 59526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 59162, 59582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 59162, 59582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum CallKind
        {
            Call,
            CallVirt,
            ConstrainedCallVirt,
        }

        private void EmitCallExpression(BoundCall call, UseKind useKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 59725, 69687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59814, 59839);

                var
                method = f_10964_59827_59838(call)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59853, 59885);

                var
                receiver = f_10964_59868_59884(call)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 59899, 59930);

                LocalDefinition
                tempOpt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60302, 60931) || true) && (f_10964_60306_60344(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 60302, 60931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60378, 60420);

                    f_10964_60378_60419(f_10964_60391_60418(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60438, 60545);

                    f_10964_60438_60544(f_10964_60451_60543(f_10964_60469_60490(method), f_10964_60492_60505(receiver), TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60563, 60618);

                    f_10964_60563_60617(f_10964_60576_60589(receiver) == BoundKind.ThisReference);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60638, 60697);

                    tempOpt = f_10964_60648_60696(this, receiver, AddressKind.Writeable);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60715, 60753);

                    f_10964_60715_60752(_builder, ILOpCode.Initobj);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60798, 60850);

                    f_10964_60798_60849(this, f_10964_60814_60835(method), call.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60868, 60889);

                    f_10964_60868_60888(this, tempOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60909, 60916);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 60302, 60931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60947, 60978);

                var
                arguments = f_10964_60963_60977(call)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 60994, 61012);

                CallKind
                callKind
                = default(CallKind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61028, 65520) || true) && (f_10964_61032_61064_M(!method.RequiresInstanceReceiver))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61028, 65520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61098, 61123);

                    callKind = CallKind.Call;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61028, 65520);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61028, 65520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61189, 61222);

                    var
                    receiverType = f_10964_61208_61221(receiver)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61242, 65505) || true) && (f_10964_61246_61280(receiverType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61242, 65505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61322, 61359);

                        f_10964_61322_61358(this, receiver, used: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61552, 61909) || true) && (f_10964_61556_61585(receiver) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 61556, 61684) || (!f_10964_61616_61642(method) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 61615, 61683) && f_10964_61646_61683(this, receiver)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61552, 61909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61734, 61759);

                            callKind = CallKind.Call;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61552, 61909);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61552, 61909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61857, 61886);

                            callKind = CallKind.CallVirt;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61552, 61909);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61242, 65505);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61242, 65505);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 61951, 65505) || true) && (f_10964_61955_61985(receiverType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61951, 65505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 62027, 62088);

                            NamedTypeSymbol
                            methodContainingType = f_10964_62066_62087(method)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 62110, 64807) || true) && (f_10964_62114_62152(methodContainingType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 62110, 64807);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 62399, 62663);

                                var
                                receiverAddresskind = (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 62425, 62469) || ((f_10964_62425_62469(this, method, methodContainingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 62545, 62565)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 62641, 62662))) ? AddressKind.ReadOnly : AddressKind.Writeable
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 62689, 63731) || true) && (f_10964_62693_62726(method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 62689, 63731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 63200, 63321);

                                    f_10964_63200_63320(f_10964_63213_63319(receiverType, methodContainingType, TypeCompareKind.ObliviousNullableModifierMatchesAny));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 63351, 63408);

                                    tempOpt = f_10964_63361_63407(this, receiver, receiverAddresskind);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 63438, 63463);

                                    callKind = CallKind.Call;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 62689, 63731);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 62689, 63731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 63577, 63634);

                                    tempOpt = f_10964_63587_63633(this, receiver, receiverAddresskind);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 63664, 63704);

                                    callKind = CallKind.ConstrainedCallVirt;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 62689, 63731);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 62110, 64807);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 62110, 64807);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64099, 64784) || true) && (f_10964_64103_64129(method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 64099, 64784);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64354, 64412);

                                    tempOpt = f_10964_64364_64411(this, receiver, AddressKind.ReadOnly);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64442, 64482);

                                    callKind = CallKind.ConstrainedCallVirt;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 64099, 64784);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 64099, 64784);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64596, 64633);

                                    f_10964_64596_64632(this, receiver, used: true);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64663, 64702);

                                    f_10964_64663_64701(this, receiverType, receiver.Syntax);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 64732, 64757);

                                    callKind = CallKind.Call;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 64099, 64784);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 62110, 64807);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61951, 65505);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 61951, 65505);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 65157, 65334);

                            callKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 65168, 65216) || ((f_10964_65168_65196(receiverType) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 65168, 65216) && !f_10964_65201_65216(this, receiver)) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 65252, 65269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 65305, 65333))) ? CallKind.CallVirt : CallKind.ConstrainedCallVirt;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 65358, 65486);

                            tempOpt = f_10964_65368_65485(this, receiver, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 65394, 65434) || ((callKind == CallKind.ConstrainedCallVirt && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 65437, 65460)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 65463, 65484))) ? AddressKind.Constrained : AddressKind.Writeable);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61951, 65505);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61242, 65505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 61028, 65520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 65861, 65913);

                MethodSymbol
                actualMethodTargetedByTheCall = method
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 65927, 66154) || true) && (f_10964_65931_65948(method) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 65931, 65977) && callKind != CallKind.Call))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 65927, 66154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 66011, 66139);

                    actualMethodTargetedByTheCall = f_10964_66043_66138(method, f_10964_66086_66108(_method), requireSameReturnType: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 65927, 66154);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 66170, 66575) || true) && (callKind == CallKind.ConstrainedCallVirt && (DynAbs.Tracing.TraceSender.Expression_True(10964, 66174, 66274) && f_10964_66218_66274(f_10964_66218_66262(actualMethodTargetedByTheCall))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 66170, 66575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 66535, 66560);

                    callKind = CallKind.Call;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 66170, 66575);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 66662, 68552) || true) && (callKind == CallKind.CallVirt)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 66662, 68552);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 67350, 68537) || true) && (f_10964_67354_67378(this, receiver) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 67354, 67435) && f_10964_67382_67435(f_10964_67382_67426(actualMethodTargetedByTheCall))) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 67354, 67554) && (object)f_10964_67472_67518(actualMethodTargetedByTheCall) == (object)f_10964_67530_67554(_method)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 67350, 68537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 67686, 67736);

                        f_10964_67686_67735(f_10964_67699_67734(f_10964_67699_67712(receiver)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 67758, 67783);

                        callKind = CallKind.Call;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 67350, 68537);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 67350, 68537);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68195, 68537) || true) && (f_10964_68199_68244(actualMethodTargetedByTheCall) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 68199, 68285) && f_10964_68248_68285(this, receiver)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 68195, 68537);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68421, 68471);

                            f_10964_68421_68470(f_10964_68434_68469(f_10964_68434_68447(receiver)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68493, 68518);

                            callKind = CallKind.Call;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 68195, 68537);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 67350, 68537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 66662, 68552);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68568, 68638);

                f_10964_68568_68637(this, arguments, f_10964_68593_68610(method), f_10964_68612_68636(call));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68652, 68722);

                int
                stackBehavior = f_10964_68672_68721(f_10964_68693_68704(call), f_10964_68706_68720(call))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68736, 69359);

                switch (callKind)
                {

                    case CallKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 68736, 69359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68827, 68877);

                        f_10964_68827_68876(_builder, ILOpCode.Call, stackBehavior);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 68899, 68905);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 68736, 69359);

                    case CallKind.CallVirt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 68736, 69359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 68970, 69024);

                        f_10964_68970_69023(_builder, ILOpCode.Callvirt, stackBehavior);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 69046, 69052);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 68736, 69359);

                    case CallKind.ConstrainedCallVirt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 68736, 69359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69128, 69170);

                        f_10964_69128_69169(_builder, ILOpCode.Constrained);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69192, 69240);

                        f_10964_69192_69239(this, f_10964_69208_69221(receiver), receiver.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69262, 69316);

                        f_10964_69262_69315(_builder, ILOpCode.Callvirt, stackBehavior);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 69338, 69344);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 68736, 69359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69375, 69577);

                f_10964_69375_69576(this, actualMethodTargetedByTheCall, call.Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 69464, 69502) || ((f_10964_69464_69502(actualMethodTargetedByTheCall) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 69505, 69568)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 69571, 69575))) ? (BoundArgListOperator)f_10964_69527_69541(call)[call.Arguments.Length - 1] : null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69593, 69639);

                f_10964_69593_69638(this, call.Syntax, useKind, method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69655, 69676);

                f_10964_69655_69675(this, tempOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 59725, 69687);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_59827_59838(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 59827, 59838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10964_59868_59884(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 59868, 59884);
                    return return_v;
                }


                bool
                f_10964_60306_60344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60306, 60344);
                    return return_v;
                }


                bool
                f_10964_60391_60418(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60391, 60418);
                    return return_v;
                }


                int
                f_10964_60378_60419(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60378, 60419);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_60469_60490(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60469, 60490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_60492_60505(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60492, 60505);
                    return return_v;
                }


                bool
                f_10964_60451_60543(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60451, 60543);
                    return return_v;
                }


                int
                f_10964_60438_60544(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60438, 60544);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_60576_60589(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60576, 60589);
                    return return_v;
                }


                int
                f_10964_60563_60617(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60563, 60617);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_60648_60696(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60648, 60696);
                    return return_v;
                }


                int
                f_10964_60715_60752(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60715, 60752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_60814_60835(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60814, 60835);
                    return return_v;
                }


                int
                f_10964_60798_60849(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60798, 60849);
                    return 0;
                }


                int
                f_10964_60868_60888(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeOptTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 60868, 60888);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_60963_60977(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 60963, 60977);
                    return return_v;
                }


                bool
                f_10964_61032_61064_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 61032, 61064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_61208_61221(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 61208, 61221);
                    return return_v;
                }


                bool
                f_10964_61246_61280(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 61246, 61280);
                    return return_v;
                }


                int
                f_10964_61322_61358(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 61322, 61358);
                    return 0;
                }


                bool
                f_10964_61556_61585(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.SuppressVirtualCalls;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 61556, 61585);
                    return return_v;
                }


                bool
                f_10964_61616_61642(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 61616, 61642);
                    return return_v;
                }


                bool
                f_10964_61646_61683(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.CanUseCallOnRefTypeReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 61646, 61683);
                    return return_v;
                }


                bool
                f_10964_61955_61985(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 61955, 61985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_62066_62087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 62066, 62087);
                    return return_v;
                }


                bool
                f_10964_62114_62152(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 62114, 62152);
                    return return_v;
                }


                bool
                f_10964_62425_62469(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                methodContainingType)
                {
                    var return_v = this_param.IsReadOnlyCall(method, methodContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 62425, 62469);
                    return return_v;
                }


                bool
                f_10964_62693_62726(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = MayUseCallForStructMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 62693, 62726);
                    return return_v;
                }


                bool
                f_10964_63213_63319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 63213, 63319);
                    return return_v;
                }


                int
                f_10964_63200_63320(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 63200, 63320);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_63361_63407(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 63361, 63407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_63587_63633(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 63587, 63633);
                    return return_v;
                }


                bool
                f_10964_64103_64129(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 64103, 64129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_64364_64411(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 64364, 64411);
                    return return_v;
                }


                int
                f_10964_64596_64632(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 64596, 64632);
                    return 0;
                }


                int
                f_10964_64663_64701(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 64663, 64701);
                    return 0;
                }


                bool
                f_10964_65168_65196(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 65168, 65196);
                    return return_v;
                }


                bool
                f_10964_65201_65216(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.IsRef(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 65201, 65216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_65368_65485(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitReceiverRef(receiver, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 65368, 65485);
                    return return_v;
                }


                bool
                f_10964_65931_65948(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 65931, 65948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_66086_66108(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 66086, 66108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_66043_66138(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetConstructedLeastOverriddenMethod(accessingTypeOpt, requireSameReturnType: requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 66043, 66138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_66218_66262(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 66218, 66262);
                    return return_v;
                }


                bool
                f_10964_66218_66274(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 66218, 66274);
                    return return_v;
                }


                bool
                f_10964_67354_67378(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.IsThisReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 67354, 67378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_67382_67426(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 67382, 67426);
                    return return_v;
                }


                bool
                f_10964_67382_67435(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 67382, 67435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10964_67472_67518(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 67472, 67518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10964_67530_67554(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 67530, 67554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_67699_67712(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 67699, 67712);
                    return return_v;
                }


                bool
                f_10964_67699_67734(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 67699, 67734);
                    return return_v;
                }


                int
                f_10964_67686_67735(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 67686, 67735);
                    return 0;
                }


                bool
                f_10964_68199_68244(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataFinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68199, 68244);
                    return return_v;
                }


                bool
                f_10964_68248_68285(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver)
                {
                    var return_v = this_param.CanUseCallOnRefTypeReceiver(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68248, 68285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_68434_68447(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68434, 68447);
                    return return_v;
                }


                bool
                f_10964_68434_68469(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68434, 68469);
                    return return_v;
                }


                int
                f_10964_68421_68470(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68421, 68470);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10964_68593_68610(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68593, 68610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10964_68612_68636(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68612, 68636);
                    return return_v;
                }


                int
                f_10964_68568_68637(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    this_param.EmitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68568, 68637);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_68693_68704(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68693, 68704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_68706_68720(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 68706, 68720);
                    return return_v;
                }


                int
                f_10964_68672_68721(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = GetCallStackBehavior(method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68672, 68721);
                    return return_v;
                }


                int
                f_10964_68827_68876(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68827, 68876);
                    return 0;
                }


                int
                f_10964_68970_69023(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 68970, 69023);
                    return 0;
                }


                int
                f_10964_69128_69169(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69128, 69169);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_69208_69221(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 69208, 69221);
                    return return_v;
                }


                int
                f_10964_69192_69239(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69192, 69239);
                    return 0;
                }


                int
                f_10964_69262_69315(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69262, 69315);
                    return 0;
                }


                bool
                f_10964_69464_69502(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 69464, 69502);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_69527_69541(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 69527, 69541);
                    return return_v;
                }


                int
                f_10964_69375_69576(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator?
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69375, 69576);
                    return 0;
                }


                int
                f_10964_69593_69638(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.EmitCallCleanup(syntax, useKind, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69593, 69638);
                    return 0;
                }


                int
                f_10964_69655_69675(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                temp)
                {
                    this_param.FreeOptTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69655, 69675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 59725, 69687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 59725, 69687);
            }
        }

        private bool IsReadOnlyCall(MethodSymbol method, NamedTypeSymbol methodContainingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 69699, 70749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69810, 69900);

                f_10964_69810_69899(f_10964_69823_69861(methodContainingType), "only struct calls can be readonly");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 69916, 70056) || true) && (f_10964_69920_69948(method) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 69920, 69995) && f_10964_69952_69969(method) != MethodKind.Constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 69916, 70056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70029, 70041);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 69916, 70056);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70072, 70709) || true) && (f_10964_70076_70113(methodContainingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 70072, 70709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70147, 70194);

                    var
                    originalMethod = f_10964_70168_70193(method)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70214, 70694) || true) && ((object)originalMethod == f_10964_70244_70340(this._module.Compilation, SpecialMember.System_Nullable_T_GetValueOrDefault) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 70218, 70479) || (object)originalMethod == f_10964_70391_70479(this._module.Compilation, SpecialMember.System_Nullable_T_get_Value)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 70218, 70621) || (object)originalMethod == f_10964_70530_70621(this._module.Compilation, SpecialMember.System_Nullable_T_get_HasValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 70214, 70694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70663, 70675);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 70214, 70694);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 70072, 70709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 70725, 70738);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 69699, 70749);

                bool
                f_10964_69823_69861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69823, 69861);
                    return return_v;
                }


                int
                f_10964_69810_69899(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 69810, 69899);
                    return 0;
                }


                bool
                f_10964_69920_69948(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsEffectivelyReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 69920, 69948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10964_69952_69969(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 69952, 69969);
                    return return_v;
                }


                bool
                f_10964_70076_70113(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 70076, 70113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_70168_70193(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 70168, 70193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10964_70244_70340(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 70244, 70340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10964_70391_70479(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 70391, 70479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10964_70530_70621(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 70530, 70621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 69699, 70749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 69699, 70749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsRef(BoundExpression receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 70944, 71903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71013, 71863);

                switch (f_10964_71021_71034(receiver))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71111, 71177);

                        return f_10964_71118_71160(f_10964_71118_71152(((BoundLocal)receiver))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71244, 71318);

                        return f_10964_71251_71301(f_10964_71251_71293(((BoundParameter)receiver))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71380, 71440);

                        return f_10964_71387_71423(f_10964_71387_71415(((BoundCall)receiver))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);

                    case BoundKind.FunctionPointerInvocation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71523, 71623);

                        return f_10964_71530_71606(f_10964_71530_71598(f_10964_71530_71588(((BoundFunctionPointerInvocation)receiver)))) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);

                    case BoundKind.Dup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71684, 71736);

                        return f_10964_71691_71719(((BoundDup)receiver)) != RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 71013, 71863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71802, 71848);

                        return f_10964_71809_71847(this, f_10964_71815_71846(((BoundSequence)receiver)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 71013, 71863);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 71879, 71892);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 70944, 71903);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_71021_71034(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71021, 71034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_71118_71152(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71118, 71152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_71118_71160(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71118, 71160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_71251_71293(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71251, 71293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_71251_71301(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71251, 71301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_71387_71415(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71387, 71415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_71387_71423(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71387, 71423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10964_71530_71588(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71530, 71588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10964_71530_71598(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71530, 71598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_71530_71606(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71530, 71606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_71691_71719(Microsoft.CodeAnalysis.CSharp.BoundDup
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71691, 71719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_71815_71846(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 71815, 71846);
                    return return_v;
                }


                bool
                f_10964_71809_71847(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver)
                {
                    var return_v = this_param.IsRef(receiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 71809, 71847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 70944, 71903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 70944, 71903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetCallStackBehavior(MethodSymbol method, ImmutableArray<BoundExpression> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 71915, 72959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72043, 72057);

                int
                stack = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72073, 72221) || true) && (f_10964_72077_72096_M(!method.ReturnsVoid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 72073, 72221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72195, 72206);

                    stack += 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 72073, 72221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72237, 72394) || true) && (f_10964_72241_72272(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 72237, 72394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72368, 72379);

                    stack -= 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 72237, 72394);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72410, 72919) || true) && (f_10964_72414_72429(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 72410, 72919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72536, 72577);

                    int
                    fixedArgCount = arguments.Length - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72595, 72679);

                    int
                    varArgCount = ((BoundArgListOperator)arguments[fixedArgCount]).Arguments.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72697, 72720);

                    stack -= fixedArgCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72738, 72759);

                    stack -= varArgCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 72410, 72919);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 72410, 72919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72878, 72904);

                    stack -= arguments.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 72410, 72919);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 72935, 72948);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 71915, 72959);

                bool
                f_10964_72077_72096_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 72077, 72096);
                    return return_v;
                }


                bool
                f_10964_72241_72272(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 72241, 72272);
                    return return_v;
                }


                bool
                f_10964_72414_72429(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 72414, 72429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 71915, 72959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 71915, 72959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetObjCreationStackBehavior(BoundObjectCreationExpression objCreation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 72971, 73814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73085, 73099);

                int
                stack = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73179, 73190);

                stack += 1;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73206, 73774) || true) && (f_10964_73210_73242(f_10964_73210_73233(objCreation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 73206, 73774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73352, 73405);

                    int
                    fixedArgCount = objCreation.Arguments.Length - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73423, 73519);

                    int
                    varArgCount = ((BoundArgListOperator)f_10964_73464_73485(objCreation)[fixedArgCount]).Arguments.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73537, 73560);

                    stack -= fixedArgCount;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73578, 73599);

                    stack -= varArgCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 73206, 73774);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 73206, 73774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73721, 73759);

                    stack -= objCreation.Arguments.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 73206, 73774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 73790, 73803);

                return stack;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 72971, 73814);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_73210_73233(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 73210, 73233);
                    return return_v;
                }


                bool
                f_10964_73210_73242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 73210, 73242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_73464_73485(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 73464, 73485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 72971, 73814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 72971, 73814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MayUseCallForStructMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 74116, 74905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74208, 74290);

                f_10964_74208_74289(f_10964_74221_74260(f_10964_74221_74242(method)), "this is not a value type");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74306, 74398) || true) && (!f_10964_74311_74337(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 74306, 74398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74371, 74383);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 74306, 74398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74414, 74461);

                var
                overriddenMethod = f_10964_74437_74460(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74475, 74603) || true) && ((object)overriddenMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10964, 74479, 74542) || f_10964_74515_74542(overriddenMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 74475, 74603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74576, 74588);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 74475, 74603);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74619, 74662);

                var
                containingType = f_10964_74640_74661(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 74840, 74894);

                return f_10964_74847_74873(containingType) != SpecialType.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 74116, 74905);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_74221_74242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 74221, 74242);
                    return return_v;
                }


                bool
                f_10964_74221_74260(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVerifierValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 74221, 74260);
                    return return_v;
                }


                int
                f_10964_74208_74289(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 74208, 74289);
                    return 0;
                }


                bool
                f_10964_74311_74337(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 74311, 74337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_74437_74460(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 74437, 74460);
                    return return_v;
                }


                bool
                f_10964_74515_74542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 74515, 74542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_74640_74661(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 74640, 74661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_74847_74873(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 74847, 74873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 74116, 74905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 74116, 74905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void TreatLongsAsNative(Microsoft.Cci.PrimitiveTypeCode tc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 75130, 75530);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 75222, 75519) || true) && (tc == Microsoft.Cci.PrimitiveTypeCode.Int64)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 75222, 75519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 75303, 75344);

                    f_10964_75303_75343(_builder, ILOpCode.Conv_ovf_i);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 75222, 75519);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 75222, 75519);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 75378, 75519) || true) && (tc == Microsoft.Cci.PrimitiveTypeCode.UInt64)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 75378, 75519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 75460, 75504);

                        f_10964_75460_75503(_builder, ILOpCode.Conv_ovf_i_un);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 75378, 75519);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 75222, 75519);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 75130, 75530);

                int
                f_10964_75303_75343(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 75303, 75343);
                    return 0;
                }


                int
                f_10964_75460_75503(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 75460, 75503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 75130, 75530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 75130, 75530);
            }
        }

        private void EmitArrayLength(BoundArrayLength expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 75542, 77548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 76059, 76283);

                f_10964_76059_76282(f_10964_76072_76099(f_10964_76072_76087(expression)) == SpecialType.System_Int32 || (DynAbs.Tracing.TraceSender.Expression_False(10964, 76072, 76203) || f_10964_76148_76175(f_10964_76148_76163(expression)) == SpecialType.System_Int64) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 76072, 76281) || f_10964_76224_76251(f_10964_76224_76239(expression)) == SpecialType.System_UIntPtr));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 76373, 76423);

                f_10964_76373_76422(this, f_10964_76388_76409(expression), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 76437, 76473);

                f_10964_76437_76472(_builder, ILOpCode.Ldlen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 76489, 76536);

                var
                typeTo = f_10964_76502_76535(f_10964_76502_76517(expression))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 76853, 76971);

                var
                typeFrom = (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 76868, 76887) || ((f_10964_76868_76887(typeTo) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 76890, 76929)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 76932, 76970))) ? Microsoft.Cci.PrimitiveTypeCode.UIntPtr : Microsoft.Cci.PrimitiveTypeCode.IntPtr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77433, 77499);

                f_10964_77433_77498(
                            // NOTE: In Dev10 C# this cast is unchecked.
                            // That seems to be wrong since that would cause silent truncation on 64bit platform if that implements large arrays. 
                            // 
                            // Emitting checked conversion however results in redundant overflow checks on 64bit and also inhibits range check hoisting in loops.
                            // Therefore we will emit unchecked conversion here as C# compiler always did.
                            _builder, typeFrom, typeTo, @checked: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77515, 77537);

                f_10964_77515_77536(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 75542, 77548);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_76072_76087(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76072, 76087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_76072_76099(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76072, 76099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_76148_76163(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76148, 76163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_76148_76175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76148, 76175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_76224_76239(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76224, 76239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_76224_76251(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76224, 76251);
                    return return_v;
                }


                int
                f_10964_76059_76282(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 76059, 76282);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_76388_76409(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76388, 76409);
                    return return_v;
                }


                int
                f_10964_76373_76422(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 76373, 76422);
                    return 0;
                }


                int
                f_10964_76437_76472(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 76437, 76472);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_76502_76517(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76502, 76517);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10964_76502_76535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 76502, 76535);
                    return return_v;
                }


                bool
                f_10964_76868_76887(Microsoft.Cci.PrimitiveTypeCode
                kind)
                {
                    var return_v = kind.IsUnsigned();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 76868, 76887);
                    return return_v;
                }


                int
                f_10964_77433_77498(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 77433, 77498);
                    return 0;
                }


                int
                f_10964_77515_77536(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 77515, 77536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 75542, 77548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 75542, 77548);
            }
        }

        private void EmitArrayCreationExpression(BoundArrayCreation expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 77560, 78417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77667, 77716);

                var
                arrayType = (ArrayTypeSymbol)f_10964_77700_77715(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77732, 77768);

                f_10964_77732_77767(this, f_10964_77749_77766(expression));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77784, 78125) || true) && (f_10964_77788_77807(arrayType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 77784, 78125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77841, 77878);

                    f_10964_77841_77877(_builder, ILOpCode.Newarr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 77896, 77954);

                    f_10964_77896_77953(this, f_10964_77912_77933(arrayType), expression.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 77784, 78125);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 77784, 78125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78020, 78110);

                    f_10964_78020_78109(_builder, f_10964_78047_78075(_module, arrayType), expression.Syntax, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 77784, 78125);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78141, 78287) || true) && (f_10964_78145_78170(expression) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 78141, 78287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78212, 78272);

                    f_10964_78212_78271(this, arrayType, f_10964_78245_78270(expression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 78141, 78287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78384, 78406);

                f_10964_78384_78405(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 77560, 78417);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_77700_77715(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 77700, 77715);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_77749_77766(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Bounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 77749, 77766);
                    return return_v;
                }


                int
                f_10964_77732_77767(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    this_param.EmitArrayIndices(indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 77732, 77767);
                    return 0;
                }


                bool
                f_10964_77788_77807(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 77788, 77807);
                    return return_v;
                }


                int
                f_10964_77841_77877(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 77841, 77877);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_77912_77933(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 77912, 77933);
                    return return_v;
                }


                int
                f_10964_77896_77953(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 77896, 77953);
                    return 0;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10964_78047_78075(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78047, 78075);
                    return return_v;
                }


                int
                f_10964_78020_78109(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayCreation(arrayType, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78020, 78109);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10964_78145_78170(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 78145, 78170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10964_78245_78270(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 78245, 78270);
                    return return_v;
                }


                int
                f_10964_78212_78271(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                inits)
                {
                    this_param.EmitArrayInitializers(arrayType, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78212, 78271);
                    return 0;
                }


                int
                f_10964_78384_78405(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78384, 78405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 77560, 78417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 77560, 78417);
            }
        }

        private void EmitConvertedStackAllocExpression(BoundConvertedStackAllocExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 78429, 79540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78558, 78597);

                f_10964_78558_78596(this, f_10964_78573_78589(expression), used);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78786, 78922) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 78786, 78922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78828, 78850);

                    _sawStackalloc = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78868, 78907);

                    f_10964_78868_78906(_builder, ILOpCode.Localloc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 78786, 78922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78938, 78982);

                var
                initializer = f_10964_78956_78981(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 78996, 79529) || true) && (initializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 78996, 79529);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79053, 79514) || true) && (used)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79053, 79514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79103, 79160);

                        f_10964_79103_79159(this, f_10964_79130_79145(expression), initializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79053, 79514);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79053, 79514);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79343, 79495);
                            foreach (var init in f_10964_79364_79388_I(f_10964_79364_79388(initializer)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79343, 79495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79438, 79472);

                                f_10964_79438_79471(this, init, used: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79343, 79495);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 153);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 153);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79053, 79514);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 78996, 79529);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 78429, 79540);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_78573_78589(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 78573, 78589);
                    return return_v;
                }


                int
                f_10964_78558_78596(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78558, 78596);
                    return 0;
                }


                int
                f_10964_78868_78906(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 78868, 78906);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10964_78956_78981(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 78956, 78981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_79130_79145(Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 79130, 79145);
                    return return_v;
                }


                int
                f_10964_79103_79159(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                inits)
                {
                    this_param.EmitStackAllocInitializers(type, inits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 79103, 79159);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_79364_79388(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 79364, 79388);
                    return return_v;
                }


                int
                f_10964_79438_79471(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 79438, 79471);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_79364_79388_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 79364, 79388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 78429, 79540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 78429, 79540);
            }
        }

        private void EmitObjectCreationExpression(BoundObjectCreationExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 79552, 81521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79671, 79721);

                MethodSymbol
                constructor = f_10964_79698_79720(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79735, 81510) || true) && (f_10964_79739_79782(constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79735, 81510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79816, 79870);

                    f_10964_79816_79869(this, f_10964_79828_79843(expression), used, expression.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79735, 81510);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79735, 81510);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 79990, 80370) || true) && (!used && (DynAbs.Tracing.TraceSender.Expression_True(10964, 79994, 80043) && f_10964_80003_80043(this, constructor)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 79990, 80370);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80174, 80320);
                            foreach (var arg in f_10964_80194_80214_I(f_10964_80194_80214(expression)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 80174, 80320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80264, 80297);

                                f_10964_80264_80296(this, arg, used: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 80174, 80320);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10964, 1, 147);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10964, 1, 147);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80344, 80351);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79990, 80370);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80464, 80843) || true) && (f_10964_80468_80528(this._module.Compilation, f_10964_80512_80527(expression)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 80468, 80585) && expression.Arguments.Length == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 80464, 80843);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80627, 80824) || true) && (f_10964_80631_80744(this, f_10964_80681_80696(expression), f_10964_80698_80718(expression)[0], used, inPlace: false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 80627, 80824);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80794, 80801);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 80627, 80824);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 80464, 80843);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 80935, 81027);

                    f_10964_80935_81026(this, f_10964_80949_80969(expression), f_10964_80971_80993(constructor), f_10964_80995_81025(expression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81047, 81109);

                    var
                    stackAdjustment = f_10964_81069_81108(expression)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81127, 81181);

                    f_10964_81127_81180(_builder, ILOpCode.Newobj, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81265, 81453);

                    f_10964_81265_81452(this, constructor, expression.Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 81346, 81366) || ((f_10964_81346_81366(constructor) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 81369, 81444)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 81447, 81451))) ? (BoundArgListOperator)f_10964_81391_81411(expression)[expression.Arguments.Length - 1] : null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81473, 81495);

                    f_10964_81473_81494(this, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 79735, 81510);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 79552, 81521);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_79698_79720(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 79698, 79720);
                    return return_v;
                }


                bool
                f_10964_79739_79782(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 79739, 79782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_79828_79843(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 79828, 79843);
                    return return_v;
                }


                int
                f_10964_79816_79869(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitInitObj(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 79816, 79869);
                    return 0;
                }


                bool
                f_10964_80003_80043(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor)
                {
                    var return_v = this_param.ConstructorNotSideEffecting(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80003, 80043);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_80194_80214(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80194, 80214);
                    return return_v;
                }


                int
                f_10964_80264_80296(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80264, 80296);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_80194_80214_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80194, 80214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_80512_80527(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80512, 80527);
                    return return_v;
                }


                bool
                f_10964_80468_80528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsReadOnlySpanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80468, 80528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_80681_80696(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80681, 80696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_80698_80718(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80698, 80718);
                    return return_v;
                }


                bool
                f_10964_80631_80744(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                spanType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                wrappedExpression, bool
                used, bool
                inPlace)
                {
                    var return_v = this_param.TryEmitReadonlySpanAsBlobWrapper((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)spanType, wrappedExpression, used, inPlace: inPlace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80631, 80744);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_80949_80969(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80949, 80969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10964_80971_80993(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80971, 80993);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10964_80995_81025(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 80995, 81025);
                    return return_v;
                }


                int
                f_10964_80935_81026(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    this_param.EmitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 80935, 81026);
                    return 0;
                }


                int
                f_10964_81069_81108(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                objCreation)
                {
                    var return_v = GetObjCreationStackBehavior(objCreation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 81069, 81108);
                    return return_v;
                }


                int
                f_10964_81127_81180(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 81127, 81180);
                    return 0;
                }


                bool
                f_10964_81346_81366(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 81346, 81366);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_81391_81411(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 81391, 81411);
                    return return_v;
                }


                int
                f_10964_81265_81452(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator?
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 81265, 81452);
                    return 0;
                }


                int
                f_10964_81473_81494(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 81473, 81494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 79552, 81521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 79552, 81521);
            }
        }

        private bool ConstructorNotSideEffecting(MethodSymbol constructor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 81720, 83218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81811, 81860);

                var
                originalDef = f_10964_81829_81859(constructor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81874, 81912);

                var
                compilation = _module.Compilation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 81928, 82079) || true) && (originalDef == f_10964_81947_82018(compilation, SpecialMember.System_Nullable_T__ctor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 81928, 82079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 82052, 82064);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 81928, 82079);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 82095, 83178) || true) && (f_10964_82099_82130(f_10964_82099_82125(originalDef)) == NamedTypeSymbol.ValueTupleTypeName && (DynAbs.Tracing.TraceSender.Expression_True(10964, 82099, 83117) && (originalDef == f_10964_82209_82287(compilation, WellKnownMember.System_ValueTuple_T2__ctor) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82405) || originalDef == f_10964_82327_82405(compilation, WellKnownMember.System_ValueTuple_T3__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82523) || originalDef == f_10964_82445_82523(compilation, WellKnownMember.System_ValueTuple_T4__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82641) || originalDef == f_10964_82563_82641(compilation, WellKnownMember.System_ValueTuple_T5__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82759) || originalDef == f_10964_82681_82759(compilation, WellKnownMember.System_ValueTuple_T6__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82877) || originalDef == f_10964_82799_82877(compilation, WellKnownMember.System_ValueTuple_T7__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 82998) || originalDef == f_10964_82917_82998(compilation, WellKnownMember.System_ValueTuple_TRest__ctor)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 82194, 83116) || originalDef == f_10964_83038_83116(compilation, WellKnownMember.System_ValueTuple_T1__ctor)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 82095, 83178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 83151, 83163);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 82095, 83178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 83194, 83207);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 81720, 83218);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_81829_81859(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 81829, 81859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10964_81947_82018(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                specialMember)
                {
                    var return_v = this_param.GetSpecialTypeMember(specialMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 81947, 82018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_82099_82125(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 82099, 82125);
                    return return_v;
                }


                string
                f_10964_82099_82130(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 82099, 82130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82209_82287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82209, 82287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82327_82405(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82327, 82405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82445_82523(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82445, 82523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82563_82641(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82563, 82641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82681_82759(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82681, 82759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82799_82877(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82799, 82877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_82917_82998(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 82917, 82998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10964_83038_83116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 83038, 83116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 81720, 83218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 81720, 83218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitAssignmentExpression(BoundAssignmentOperator assignmentOperator, UseKind useKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 83230, 87061);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 83353, 83484) || true) && (f_10964_83357_83428(this, assignmentOperator, useKind != UseKind.Unused))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 83353, 83484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 83462, 83469);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 83353, 83484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 86712, 86775);

                bool
                lhsUsesStack = f_10964_86732_86774(this, assignmentOperator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 86789, 86829);

                f_10964_86789_86828(this, assignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 86843, 86935);

                LocalDefinition
                temp = f_10964_86866_86934(this, assignmentOperator, useKind, lhsUsesStack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 86949, 86979);

                f_10964_86949_86978(this, assignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 86993, 87050);

                f_10964_86993_87049(this, assignmentOperator, temp, useKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 83230, 87061);

                bool
                f_10964_83357_83428(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignmentOperator, bool
                used)
                {
                    var return_v = this_param.TryEmitAssignmentInPlace(assignmentOperator, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 83357, 83428);
                    return return_v;
                }


                bool
                f_10964_86732_86774(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignmentOperator)
                {
                    var return_v = this_param.EmitAssignmentPreamble(assignmentOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 86732, 86774);
                    return return_v;
                }


                int
                f_10964_86789_86828(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignmentOperator)
                {
                    this_param.EmitAssignmentValue(assignmentOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 86789, 86828);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_86866_86934(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignmentOperator, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind, bool
                lhsUsesStack)
                {
                    var return_v = this_param.EmitAssignmentDuplication(assignmentOperator, useKind, lhsUsesStack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 86866, 86934);
                    return return_v;
                }


                int
                f_10964_86949_86978(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignment)
                {
                    this_param.EmitStore(assignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 86949, 86978);
                    return 0;
                }


                int
                f_10964_86993_87049(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                assignment, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind)
                {
                    this_param.EmitAssignmentPostfix(assignment, temp, useKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 86993, 87049);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 83230, 87061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 83230, 87061);
            }
        }

        private bool TryEmitAssignmentInPlace(BoundAssignmentOperator assignmentOperator, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 87698, 90675);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88041, 88131) || true) && (f_10964_88045_88069(assignmentOperator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 88041, 88131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88103, 88116);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 88041, 88131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88147, 88182);

                var
                left = f_10964_88158_88181(assignmentOperator)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88380, 88478) || true) && (used && (DynAbs.Tracing.TraceSender.Expression_True(10964, 88384, 88416) && !f_10964_88393_88416(left)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 88380, 88478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88450, 88463);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 88380, 88478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88494, 88632) || true) && (!f_10964_88499_88532(this, left))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 88494, 88632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88604, 88617);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 88494, 88632);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88648, 88685);

                var
                right = f_10964_88660_88684(assignmentOperator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88699, 88726);

                var
                rightType = f_10964_88715_88725(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88820, 89092) || true) && (!f_10964_88825_88852(rightType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 88820, 89092);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 88886, 89077) || true) && (f_10964_88890_88915(rightType) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 88890, 89003) || (f_10964_88920_88939(right) != null && (DynAbs.Tracing.TraceSender.Expression_True(10964, 88920, 89002) && f_10964_88951_88972(rightType) != SpecialType.System_Decimal))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 88886, 89077);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89045, 89058);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 88886, 89077);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 88820, 89092);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89108, 89237) || true) && (f_10964_89112_89134(right))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 89108, 89237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89168, 89192);

                    f_10964_89168_89191(this, left, used);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89210, 89222);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 89108, 89237);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89253, 90635) || true) && (right is BoundObjectCreationExpression objCreation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 89253, 90635);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89640, 89826) || true) && (objCreation.Arguments.Length > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10964, 89644, 89752) && f_10964_89680_89709(f_10964_89680_89701(objCreation)[0]) == BoundKind.ConvertedStackAllocExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 89640, 89826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 89794, 89807);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 89640, 89826);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90055, 90620) || true) && (f_10964_90059_90094(this, left))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 90055, 90620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90136, 90171);

                        var
                        ctor = f_10964_90147_90170(objCreation)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90313, 90601) || true) && (System.Linq.ImmutableArrayExtensions.All(f_10964_90358_90373(ctor), p => p.RefKind == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 90317, 90449) && f_10964_90435_90449_M(!ctor.IsVararg)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 90313, 90601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90499, 90540);

                            f_10964_90499_90539(this, left, objCreation, used);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90566, 90578);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 90313, 90601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 90055, 90620);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 89253, 90635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90651, 90664);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 87698, 90675);

                bool
                f_10964_88045_88069(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88045, 88069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_88158_88181(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88158, 88181);
                    return return_v;
                }


                bool
                f_10964_88393_88416(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = TargetIsNotOnHeap(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 88393, 88416);
                    return return_v;
                }


                bool
                f_10964_88499_88532(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = this_param.SafeToGetWriteableReference(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 88499, 88532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_88660_88684(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88660, 88684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_88715_88725(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88715, 88725);
                    return return_v;
                }


                bool
                f_10964_88825_88852(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 88825, 88852);
                    return return_v;
                }


                bool
                f_10964_88890_88915(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88890, 88915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_88920_88939(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88920, 88939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_88951_88972(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 88951, 88972);
                    return return_v;
                }


                bool
                f_10964_89112_89134(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 89112, 89134);
                    return return_v;
                }


                int
                f_10964_89168_89191(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                target, bool
                used)
                {
                    this_param.InPlaceInit(target, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 89168, 89191);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_89680_89701(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 89680, 89701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_89680_89709(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 89680, 89709);
                    return return_v;
                }


                bool
                f_10964_90059_90094(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = this_param.PartialCtorResultCannotEscape(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 90059, 90094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_90147_90170(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 90147, 90170);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10964_90358_90373(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 90358, 90373);
                    return return_v;
                }


                bool
                f_10964_90435_90449_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 90435, 90449);
                    return return_v;
                }


                int
                f_10964_90499_90539(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                target, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                objCreation, bool
                used)
                {
                    this_param.InPlaceCtorCall(target, objCreation, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 90499, 90539);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 87698, 90675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 87698, 90675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SafeToGetWriteableReference(BoundExpression left)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 90687, 91664);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90774, 90877) || true) && (!f_10964_90779_90815(this, left, AddressKind.Writeable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 90774, 90877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 90849, 90862);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 90774, 90877);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91081, 91255) || true) && (f_10964_91085_91094(left) == BoundKind.ArrayAccess && (DynAbs.Tracing.TraceSender.Expression_True(10964, 91085, 91167) && f_10964_91123_91141(f_10964_91123_91132(left)) == TypeKind.TypeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 91085, 91193) && f_10964_91171_91193_M(!f_10964_91172_91181(left).IsValueType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 91081, 91255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91227, 91240);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 91081, 91255);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91271, 91625) || true) && (f_10964_91275_91284(left) == BoundKind.FieldAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 91271, 91625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91343, 91384);

                    var
                    fieldAccess = (BoundFieldAccess)left
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91402, 91610) || true) && (f_10964_91406_91440(f_10964_91406_91429(fieldAccess)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 91406, 91536) || f_10964_91465_91536(fieldAccess, _module.Compilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 91402, 91610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91578, 91591);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 91402, 91610);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 91271, 91625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91641, 91653);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 90687, 91664);

                bool
                f_10964_90779_90815(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.HasHome(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 90779, 90815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_91085_91094(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91085, 91094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_91123_91132(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91123, 91132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10964_91123_91141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91123, 91141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_91172_91181(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91172, 91181);
                    return return_v;
                }


                bool
                f_10964_91171_91193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91171, 91193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_91275_91284(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91275, 91284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_91406_91429(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91406, 91429);
                    return return_v;
                }


                bool
                f_10964_91406_91440(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 91406, 91440);
                    return return_v;
                }


                bool
                f_10964_91465_91536(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = DiagnosticsPass.IsNonAgileFieldAccess(fieldAccess, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 91465, 91536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 90687, 91664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 90687, 91664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void InPlaceInit(BoundExpression target, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 91676, 92278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91760, 91814);

                var
                temp = f_10964_91771_91813(this, target, AddressKind.Writeable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91828, 91903);

                f_10964_91828_91902(temp == null, "in-place init target should not create temps");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91919, 91957);

                f_10964_91919_91956(
                            _builder, ILOpCode.Initobj);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 91998, 92042);

                f_10964_91998_92041(this, f_10964_92014_92025(target), target.Syntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92058, 92267) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 92058, 92267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92100, 92205);

                    f_10964_92100_92204(f_10964_92113_92138(target), "cannot read-back the target since it could have been modified");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92223, 92252);

                    f_10964_92223_92251(this, target, used);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 92058, 92267);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 91676, 92278);

                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_91771_91813(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 91771, 91813);
                    return return_v;
                }


                int
                f_10964_91828_91902(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 91828, 91902);
                    return 0;
                }


                int
                f_10964_91919_91956(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 91919, 91956);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_92014_92025(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 92014, 92025);
                    return return_v;
                }


                int
                f_10964_91998_92041(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 91998, 92041);
                    return 0;
                }


                bool
                f_10964_92113_92138(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = TargetIsNotOnHeap(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92113, 92138);
                    return return_v;
                }


                int
                f_10964_92100_92204(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92100, 92204);
                    return 0;
                }


                int
                f_10964_92223_92251(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92223, 92251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 91676, 92278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 91676, 92278);
            }
        }

        private void InPlaceCtorCall(BoundExpression target, BoundObjectCreationExpression objCreation, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 92290, 94009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92421, 92515);

                f_10964_92421_92514(f_10964_92434_92459(target), "in-place construction target should not be on heap");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92531, 92585);

                var
                temp = f_10964_92542_92584(this, target, AddressKind.Writeable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92599, 92674);

                f_10964_92599_92673(temp == null, "in-place ctor target should not create temps");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92760, 93235) || true) && (f_10964_92764_92825(this._module.Compilation, f_10964_92808_92824(objCreation)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 92764, 92862) && objCreation.Arguments.Length == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 92760, 93235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 92896, 93220) || true) && (f_10964_92900_93014(this, f_10964_92950_92966(objCreation), f_10964_92968_92989(objCreation)[0], used, inPlace: true))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 92896, 93220);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93056, 93172) || true) && (used)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 93056, 93172);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93114, 93149);

                            f_10964_93114_93148(this, target, used: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 93056, 93172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93194, 93201);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 92896, 93220);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 92760, 93235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93251, 93293);

                var
                constructor = f_10964_93269_93292(objCreation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93307, 93401);

                f_10964_93307_93400(this, f_10964_93321_93342(objCreation), f_10964_93344_93366(constructor), f_10964_93368_93399(objCreation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93496, 93563);

                var
                stackAdjustment = f_10964_93518_93558(objCreation) - 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93577, 93629);

                f_10964_93577_93628(_builder, ILOpCode.Call, stackAdjustment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93703, 93890);

                f_10964_93703_93889(this, constructor, objCreation.Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 93781, 93801) || ((f_10964_93781_93801(constructor) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 93804, 93881)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 93884, 93888))) ? (BoundArgListOperator)f_10964_93826_93847(objCreation)[objCreation.Arguments.Length - 1] : null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93906, 93998) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 93906, 93998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 93948, 93983);

                    f_10964_93948_93982(this, target, used: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 93906, 93998);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 92290, 94009);

                bool
                f_10964_92434_92459(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = TargetIsNotOnHeap(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92434, 92459);
                    return return_v;
                }


                int
                f_10964_92421_92514(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92421, 92514);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_92542_92584(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92542, 92584);
                    return return_v;
                }


                int
                f_10964_92599_92673(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92599, 92673);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_92808_92824(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 92808, 92824);
                    return return_v;
                }


                bool
                f_10964_92764_92825(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsReadOnlySpanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92764, 92825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_92950_92966(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 92950, 92966);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_92968_92989(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 92968, 92989);
                    return return_v;
                }


                bool
                f_10964_92900_93014(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                spanType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                wrappedExpression, bool
                used, bool
                inPlace)
                {
                    var return_v = this_param.TryEmitReadonlySpanAsBlobWrapper((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)spanType, wrappedExpression, used, inPlace: inPlace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 92900, 93014);
                    return return_v;
                }


                int
                f_10964_93114_93148(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93114, 93148);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_93269_93292(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93269, 93292);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_93321_93342(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93321, 93342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10964_93344_93366(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93344, 93366);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10964_93368_93399(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93368, 93399);
                    return return_v;
                }


                int
                f_10964_93307_93400(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    this_param.EmitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93307, 93400);
                    return 0;
                }


                int
                f_10964_93518_93558(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                objCreation)
                {
                    var return_v = GetObjCreationStackBehavior(objCreation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93518, 93558);
                    return return_v;
                }


                int
                f_10964_93577_93628(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93577, 93628);
                    return 0;
                }


                bool
                f_10964_93781_93801(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93781, 93801);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_93826_93847(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 93826, 93847);
                    return return_v;
                }


                int
                f_10964_93703_93889(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator?
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93703, 93889);
                    return 0;
                }


                int
                f_10964_93948_93982(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 93948, 93982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 92290, 94009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 92290, 94009);
            }
        }

        private bool PartialCtorResultCannotEscape(BoundExpression left)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 94241, 95138);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94330, 95025) || true) && (f_10964_94334_94357(left))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 94330, 95025);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94391, 94903) || true) && (_tryNestingLevel != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 94391, 94903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94458, 94489);

                        var
                        local = left as BoundLocal
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94511, 94750) || true) && (local != null && (DynAbs.Tracing.TraceSender.Expression_True(10964, 94515, 94586) && !f_10964_94533_94586(_builder, f_10964_94570_94585(this, local))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 94511, 94750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94715, 94727);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 94511, 94750);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94871, 94884);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 94391, 94903);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 94998, 95010);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 94330, 95025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 95114, 95127);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 94241, 95138);

                bool
                f_10964_94334_94357(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left)
                {
                    var return_v = TargetIsNotOnHeap(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 94334, 94357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_94570_94585(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                localExpression)
                {
                    var return_v = this_param.GetLocal(localExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 94570, 94585);
                    return return_v;
                }


                bool
                f_10964_94533_94586(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    var return_v = this_param.PossiblyDefinedOutsideOfTry(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 94533, 94586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 94241, 95138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 94241, 95138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TargetIsNotOnHeap(BoundExpression left)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 95228, 95829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 95312, 95789);

                switch (f_10964_95320_95329(left))
                {

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 95312, 95789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 95410, 95480);

                        return f_10964_95417_95463(f_10964_95417_95455(((BoundParameter)left))) == RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 95312, 95789);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 95312, 95789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 95712, 95774);

                        return f_10964_95719_95757(f_10964_95719_95749(((BoundLocal)left))) == RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 95312, 95789);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 95805, 95818);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 95228, 95829);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_95320_95329(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 95320, 95329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_95417_95455(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 95417, 95455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_95417_95463(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 95417, 95463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_95719_95749(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 95719, 95749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_95719_95757(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 95719, 95757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 95228, 95829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 95228, 95829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }


        private bool EmitAssignmentPreamble(BoundAssignmentOperator assignmentOperator)
        {
            var assignmentTarget = assignmentOperator.Left;
            bool lhsUsesStack = false;

            switch (assignmentTarget.Kind)
            {
                case BoundKind.RefValueOperator:
                    EmitRefValueAddress((BoundRefValueOperator)assignmentTarget);
                    break;

                case BoundKind.FieldAccess:
                    {
                        var left = (BoundFieldAccess)assignmentTarget;
                        if (!left.FieldSymbol.IsStatic)
                        {
                            var temp = EmitReceiverRef(left.ReceiverOpt, AddressKind.Writeable);
                            Debug.Assert(temp == null, "temp is unexpected when assigning to a field");
                            lhsUsesStack = true;
                        }
                    }
                    break;

                case BoundKind.Parameter:
                    {
                        var left = (BoundParameter)assignmentTarget;
                        if (left.ParameterSymbol.RefKind != RefKind.None &&
                            !assignmentOperator.IsRef)
                        {
                            _builder.EmitLoadArgumentOpcode(ParameterSlot(left));
                            lhsUsesStack = true;
                        }
                    }
                    break;

                case BoundKind.Local:
                    {
                        var left = (BoundLocal)assignmentTarget;

                        // Again, consider our earlier case:
                        //
                        // ref int addr = ref N().s;
                        // int sum = addr + 10; 
                        // addr = sum;
                        //
                        // There are three different ways we could be assigning to a local.
                        //
                        // In the first case, we want to simply call N(), take the address
                        // of s, and then store that address in addr.
                        //
                        // In the second case again we simply want to compute the sum and
                        // store the result in sum.
                        //
                        // In the third case however we want to first load the contents of
                        // addr -- the address of field s -- then put the sum on the stack,
                        // and then do an indirect store. In that case we need to have the
                        // contents of addr on the stack.

                        if (left.LocalSymbol.RefKind != RefKind.None && !assignmentOperator.IsRef)
                        {
                            if (!IsStackLocal(left.LocalSymbol))
                            {
                                LocalDefinition localDefinition = GetLocal(left);
                                _builder.EmitLocalLoad(localDefinition);
                            }
                            else
                            {
                                // this is a case of indirect assignment to a stack temp.
                                // currently byref temp can only be a stack local in scenarios where 
                                // there is only one assignment and it is the last one. 
                                // I do not yet know how to support cases where we assign more than once. 
                                // That where Dup of LHS would be needed, but as a general scenario 
                                // it is not always possible to handle. Fortunately all the cases where we
                                // indirectly assign to a byref temp come from rewriter and all
                                // they all are write-once cases.
                                //
                                // For now analyzer asserts that indirect writes are final reads of 
                                // a ref local. And we never need a dup here.

                                // builder.EmitOpCode(ILOpCode.Dup);
                            }

                            lhsUsesStack = true;
                        }
                    }
                    break;

                case BoundKind.ArrayAccess:
                    {
                        var left = (BoundArrayAccess)assignmentTarget;
                        EmitExpression(left.Expression, used: true);
                        EmitArrayIndices(left.Indices);
                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.ThisReference:
                    {
                        var left = (BoundThisReference)assignmentTarget;

                        var temp = EmitAddress(left, AddressKind.Writeable);
                        Debug.Assert(temp == null, "taking ref of this should not create a temp");

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.Dup:
                    {
                        var left = (BoundDup)assignmentTarget;

                        var temp = EmitAddress(left, AddressKind.Writeable);
                        Debug.Assert(temp == null, "taking ref of Dup should not create a temp");

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.ConditionalOperator:
                    {
                        var left = (BoundConditionalOperator)assignmentTarget;
                        Debug.Assert(left.IsRef);

                        var temp = EmitAddress(left, AddressKind.Writeable);
                        Debug.Assert(temp == null, "taking ref of this should not create a temp");

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.PointerIndirectionOperator:
                    {
                        var left = (BoundPointerIndirectionOperator)assignmentTarget;

                        EmitExpression(left.Operand, used: true);

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.Sequence:
                    {
                        var sequence = (BoundSequence)assignmentTarget;

                        // NOTE: not releasing sequence locals right away. 
                        // Since sequence is used as a variable, we will keep the locals for the extent of the containing expression
                        DefineAndRecordLocals(sequence);
                        EmitSideEffects(sequence);
                        lhsUsesStack = EmitAssignmentPreamble(assignmentOperator.Update(sequence.Value, assignmentOperator.Right, assignmentOperator.IsRef, assignmentOperator.Type));
                        CloseScopeAndKeepLocals(sequence);
                    }
                    break;

                case BoundKind.Call:
                    {
                        var left = (BoundCall)assignmentTarget;

                        Debug.Assert(left.Method.RefKind != RefKind.None);
                        EmitCallExpression(left, UseKind.UsedAsAddress);

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.FunctionPointerInvocation:
                    {
                        var left = (BoundFunctionPointerInvocation)assignmentTarget;

                        Debug.Assert(left.FunctionPointer.Signature.RefKind != RefKind.None);
                        EmitCalli(left, UseKind.UsedAsAddress);

                        lhsUsesStack = true;
                    }
                    break;

                case BoundKind.PropertyAccess:
                case BoundKind.IndexerAccess:
                // Property access should have been rewritten.
                case BoundKind.PreviousSubmissionReference:
                    // Script references are lowered to a this reference and a field access.
                    throw ExceptionUtilities.UnexpectedValue(assignmentTarget.Kind);

                case BoundKind.PseudoVariable:
                    EmitPseudoVariableAddress((BoundPseudoVariable)assignmentTarget);
                    lhsUsesStack = true;
                    break;

                case BoundKind.ModuleVersionId:
                case BoundKind.InstrumentationPayloadRoot:
                    break;

                case BoundKind.AssignmentOperator:
                    var assignment = (BoundAssignmentOperator)assignmentTarget;
                    if (!assignment.IsRef)
                    {
                        goto default;
                    }
                    EmitAssignmentExpression(assignment, UseKind.UsedAsAddress);
                    break;

                default:
                    throw ExceptionUtilities.UnexpectedValue(assignmentTarget.Kind);
            }

            return lhsUsesStack;
        }

        private void EmitAssignmentValue(BoundAssignmentOperator assignmentOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 105132, 107360);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 105233, 107349) || true) && (f_10964_105237_105262_M(!assignmentOperator.IsRef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 105233, 107349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 105296, 105349);

                    f_10964_105296_105348(this, f_10964_105311_105335(assignmentOperator), used: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 105233, 107349);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 105233, 107349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 105415, 105466);

                    int
                    exprTempsBefore = f_10964_105437_105460_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_expressionTemps, 10964, 105437, 105460)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10964, 105437, 105465) ?? 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 105484, 105530);

                    BoundExpression
                    lhs = f_10964_105506_105529(assignmentOperator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 105692, 105847);

                    LocalDefinition
                    temp = f_10964_105715_105846(this, f_10964_105727_105751(assignmentOperator), (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 105753, 105792) || ((f_10964_105753_105769(lhs) == RefKind.RefReadOnly && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 105795, 105821)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 105824, 105845))) ? AddressKind.ReadOnlyStrict : AddressKind.Writeable)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 106179, 106203);

                    f_10964_106179_106202(this, temp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 106223, 106273);

                    var
                    exprTempsAfter = f_10964_106244_106267_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_expressionTemps, 10964, 106244, 106267)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10964, 106244, 106272) ?? 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 106408, 106491);

                    f_10964_106408_106490(f_10964_106421_106429(lhs) != BoundKind.Parameter || (DynAbs.Tracing.TraceSender.Expression_False(10964, 106421, 106489) || exprTempsAfter <= exprTempsBefore));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 106511, 107334) || true) && (f_10964_106515_106523(lhs) == BoundKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10964, 106515, 106605) && f_10964_106546_106605(f_10964_106546_106591(f_10964_106546_106575(((BoundLocal)lhs))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 106511, 107334);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107165, 107315) || true) && (exprTempsAfter > exprTempsBefore)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 107165, 107315);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107251, 107292);

                            _expressionTemps.Count = exprTempsBefore;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 107165, 107315);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 106511, 107334);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 105233, 107349);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 105132, 107360);

                bool
                f_10964_105237_105262_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 105237, 105262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_105311_105335(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 105311, 105335);
                    return return_v;
                }


                int
                f_10964_105296_105348(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 105296, 105348);
                    return 0;
                }


                int?
                f_10964_105437_105460_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 105437, 105460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_105506_105529(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 105506, 105529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_105727_105751(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 105727, 105751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_105753_105769(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.GetRefKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 105753, 105769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_105715_105846(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Binder.AddressKind
                addressKind)
                {
                    var return_v = this_param.EmitAddress(expression, addressKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 105715, 105846);
                    return return_v;
                }


                int
                f_10964_106179_106202(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.AddExpressionTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 106179, 106202);
                    return 0;
                }


                int?
                f_10964_106244_106267_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 106244, 106267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_106421_106429(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 106421, 106429);
                    return return_v;
                }


                int
                f_10964_106408_106490(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 106408, 106490);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_106515_106523(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 106515, 106523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_106546_106575(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 106546, 106575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10964_106546_106591(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 106546, 106591);
                    return return_v;
                }


                bool
                f_10964_106546_106605(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind)
                {
                    var return_v = kind.IsLongLived();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 106546, 106605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 105132, 107360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 105132, 107360);
            }
        }

        private LocalDefinition EmitAssignmentDuplication(BoundAssignmentOperator assignmentOperator, UseKind useKind, bool lhsUsesStack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 107372, 109082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107526, 107554);

                LocalDefinition
                temp = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107568, 109045) || true) && (useKind != UseKind.Unused)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 107568, 109045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107631, 107665);

                    f_10964_107631_107664(_builder, ILOpCode.Dup);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 107685, 109030) || true) && (lhsUsesStack)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 107685, 109030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 108718, 108959);

                        temp = f_10964_108725_108958(this, f_10964_108764_108792(f_10964_108764_108787(assignmentOperator)), f_10964_108819_108842(assignmentOperator).Syntax, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 108876, 108900) || ((f_10964_108876_108900(assignmentOperator) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 108903, 108929)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 108932, 108957))) ? LocalSlotConstraints.ByRef : LocalSlotConstraints.None);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 108981, 109011);

                        f_10964_108981_109010(_builder, temp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 107685, 109030);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 107568, 109045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 109059, 109071);

                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 107372, 109082);

                int
                f_10964_107631_107664(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 107631, 107664);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_108764_108787(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 108764, 108787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_108764_108792(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 108764, 108792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_108819_108842(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 108819, 108842);
                    return return_v;
                }


                bool
                f_10964_108876_108900(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 108876, 108900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_108725_108958(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.LocalSlotConstraints
                slotConstraints)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode, slotConstraints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 108725, 108958);
                    return return_v;
                }


                int
                f_10964_108981_109010(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 108981, 109010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 107372, 109082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 107372, 109082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitStore(BoundAssignmentOperator assignment)
        {
            BoundExpression expression = assignment.Left;
            switch (expression.Kind)
            {
                case BoundKind.FieldAccess:
                    EmitFieldStore((BoundFieldAccess)expression);
                    break;

                case BoundKind.Local:
                    // If we are doing a 'normal' local assignment like 'int t = 10;', or
                    // if we are initializing a temporary like 'ref int t = ref M().s;' then
                    // we just emit a local store. If we are doing an assignment through
                    // a ref local temporary then we assume that the instruction to load
                    // the address is already on the stack, and we must indirect through it.

                    // See the comments in EmitAssignmentExpression above for details.
                    BoundLocal local = (BoundLocal)expression;
                    if (local.LocalSymbol.RefKind != RefKind.None && !assignment.IsRef)
                    {
                        EmitIndirectStore(local.LocalSymbol.Type, local.Syntax);
                    }
                    else
                    {
                        if (IsStackLocal(local.LocalSymbol))
                        {
                            // assign to stack var == leave original value on stack
                            break;
                        }
                        else
                        {
                            _builder.EmitLocalStore(GetLocal(local));
                        }
                    }
                    break;

                case BoundKind.ArrayAccess:
                    var array = ((BoundArrayAccess)expression).Expression;
                    var arrayType = (ArrayTypeSymbol)array.Type;
                    EmitArrayElementStore(arrayType, expression.Syntax);
                    break;

                case BoundKind.ThisReference:
                    EmitThisStore((BoundThisReference)expression);
                    break;

                case BoundKind.Parameter:
                    EmitParameterStore((BoundParameter)expression, assignment.IsRef);
                    break;

                case BoundKind.Dup:
                    Debug.Assert(((BoundDup)expression).RefKind != RefKind.None);
                    EmitIndirectStore(expression.Type, expression.Syntax);
                    break;

                case BoundKind.ConditionalOperator:
                    Debug.Assert(((BoundConditionalOperator)expression).IsRef);
                    EmitIndirectStore(expression.Type, expression.Syntax);
                    break;

                case BoundKind.RefValueOperator:
                case BoundKind.PointerIndirectionOperator:
                case BoundKind.PseudoVariable:
                    EmitIndirectStore(expression.Type, expression.Syntax);
                    break;

                case BoundKind.Sequence:
                    {
                        var sequence = (BoundSequence)expression;
                        EmitStore(assignment.Update(sequence.Value, assignment.Right, assignment.IsRef, assignment.Type));
                    }
                    break;

                case BoundKind.Call:
                    Debug.Assert(((BoundCall)expression).Method.RefKind != RefKind.None);
                    EmitIndirectStore(expression.Type, expression.Syntax);
                    break;

                case BoundKind.FunctionPointerInvocation:
                    Debug.Assert(((BoundFunctionPointerInvocation)expression).FunctionPointer.Signature.RefKind != RefKind.None);
                    EmitIndirectStore(expression.Type, expression.Syntax);
                    break;

                case BoundKind.ModuleVersionId:
                    EmitModuleVersionIdStore((BoundModuleVersionId)expression);
                    break;

                case BoundKind.InstrumentationPayloadRoot:
                    EmitInstrumentationPayloadRootStore((BoundInstrumentationPayloadRoot)expression);
                    break;

                case BoundKind.AssignmentOperator:
                    var nested = (BoundAssignmentOperator)expression;
                    if (!nested.IsRef)
                    {
                        goto default;
                    }
                    EmitIndirectStore(nested.Type, expression.Syntax);
                    break;

                case BoundKind.PreviousSubmissionReference:
                // Script references are lowered to a this reference and a field access.
                default:
                    throw ExceptionUtilities.UnexpectedValue(expression.Kind);
            }
        }

        private void EmitAssignmentPostfix(BoundAssignmentOperator assignment, LocalDefinition temp, UseKind useKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 113944, 114599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114078, 114416) || true) && (temp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114078, 114416);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114128, 114368) || true) && (useKind == UseKind.UsedAsAddress)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114128, 114368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114206, 114238);

                        f_10964_114206_114237(_builder, temp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114128, 114368);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114128, 114368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114320, 114349);

                        f_10964_114320_114348(_builder, temp);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114128, 114368);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114386, 114401);

                    f_10964_114386_114400(this, temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114078, 114416);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114432, 114588) || true) && (useKind == UseKind.UsedAsValue && (DynAbs.Tracing.TraceSender.Expression_True(10964, 114436, 114486) && f_10964_114470_114486(assignment)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114432, 114588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114520, 114573);

                    f_10964_114520_114572(this, f_10964_114537_114552(assignment), assignment.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114432, 114588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 113944, 114599);

                int
                f_10964_114206_114237(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalAddress(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114206, 114237);
                    return 0;
                }


                int
                f_10964_114320_114348(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114320, 114348);
                    return 0;
                }


                int
                f_10964_114386_114400(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114386, 114400);
                    return 0;
                }


                bool
                f_10964_114470_114486(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114470, 114486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_114537_114552(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114537, 114552);
                    return return_v;
                }


                int
                f_10964_114520_114572(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114520, 114572);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 113944, 114599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 113944, 114599);
            }
        }

        private void EmitThisStore(BoundThisReference thisRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 114611, 114852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114690, 114729);

                f_10964_114690_114728(f_10964_114703_114727(f_10964_114703_114715(thisRef)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114745, 114781);

                f_10964_114745_114780(
                            _builder, ILOpCode.Stobj);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114795, 114841);

                f_10964_114795_114840(this, f_10964_114811_114823(thisRef), thisRef.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 114611, 114852);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_114703_114715(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114703, 114715);
                    return return_v;
                }


                bool
                f_10964_114703_114727(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114703, 114727);
                    return return_v;
                }


                int
                f_10964_114690_114728(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114690, 114728);
                    return 0;
                }


                int
                f_10964_114745_114780(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114745, 114780);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_114811_114823(Microsoft.CodeAnalysis.CSharp.BoundThisReference
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114811, 114823);
                    return return_v;
                }


                int
                f_10964_114795_114840(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 114795, 114840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 114611, 114852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 114611, 114852);
            }
        }

        private void EmitArrayElementStore(ArrayTypeSymbol arrayType, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 114864, 115255);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 114973, 115244) || true) && (f_10964_114977_114996(arrayType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114973, 115244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115030, 115076);

                    f_10964_115030_115075(this, arrayType, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114973, 115244);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 114973, 115244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115142, 115229);

                    f_10964_115142_115228(_builder, f_10964_115173_115201(_module, arrayType), syntaxNode, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 114973, 115244);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 114864, 115255);

                bool
                f_10964_114977_114996(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 114977, 114996);
                    return return_v;
                }


                int
                f_10964_115030_115075(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitVectorElementStore(arrayType, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 115030, 115075);
                    return 0;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10964_115173_115201(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 115173, 115201);
                    return return_v;
                }


                int
                f_10964_115142_115228(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitArrayElementStore(arrayType, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 115142, 115228);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 114864, 115255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 114864, 115255);
            }
        }

        private void EmitVectorElementStore(ArrayTypeSymbol arrayType, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 115393, 117931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115503, 115543);

                var
                elementType = f_10964_115521_115542(arrayType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115559, 115766) || true) && (f_10964_115563_115587(elementType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115559, 115766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115687, 115751);

                    elementType = f_10964_115701_115750(((NamedTypeSymbol)elementType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115559, 115766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 115782, 117920);

                switch (f_10964_115790_115819(elementType))
                {

                    case Microsoft.Cci.PrimitiveTypeCode.Boolean:
                    case Microsoft.Cci.PrimitiveTypeCode.Int8:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 116041, 116081);

                        f_10964_116041_116080(_builder, ILOpCode.Stelem_i1);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 116103, 116109);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.Char:
                    case Microsoft.Cci.PrimitiveTypeCode.Int16:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 116316, 116356);

                        f_10964_116316_116355(_builder, ILOpCode.Stelem_i2);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 116378, 116384);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.Int32:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 116531, 116571);

                        f_10964_116531_116570(_builder, ILOpCode.Stelem_i4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 116593, 116599);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.Int64:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 116746, 116786);

                        f_10964_116746_116785(_builder, ILOpCode.Stelem_i8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 116808, 116814);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.IntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.UIntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.Pointer:
                    case Microsoft.Cci.PrimitiveTypeCode.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117097, 117136);

                        f_10964_117097_117135(_builder, ILOpCode.Stelem_i);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 117158, 117164);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.Float32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117251, 117291);

                        f_10964_117251_117290(_builder, ILOpCode.Stelem_r4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 117313, 117319);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    case Microsoft.Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117406, 117446);

                        f_10964_117406_117445(_builder, ILOpCode.Stelem_r8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 117468, 117474);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 115782, 117920);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117524, 117877) || true) && (f_10964_117528_117561(elementType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 117524, 117877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117611, 117652);

                            f_10964_117611_117651(_builder, ILOpCode.Stelem_ref);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 117524, 117877);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 117524, 117877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117750, 117787);

                            f_10964_117750_117786(_builder, ILOpCode.Stelem);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 117813, 117854);

                            f_10964_117813_117853(this, elementType, syntaxNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 117524, 117877);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 117899, 117905);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 115782, 117920);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 115393, 117931);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_115521_115542(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 115521, 115542);
                    return return_v;
                }


                bool
                f_10964_115563_115587(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 115563, 115587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_115701_115750(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 115701, 115750);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10964_115790_115819(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 115790, 115819);
                    return return_v;
                }


                int
                f_10964_116041_116080(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 116041, 116080);
                    return 0;
                }


                int
                f_10964_116316_116355(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 116316, 116355);
                    return 0;
                }


                int
                f_10964_116531_116570(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 116531, 116570);
                    return 0;
                }


                int
                f_10964_116746_116785(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 116746, 116785);
                    return 0;
                }


                int
                f_10964_117097_117135(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117097, 117135);
                    return 0;
                }


                int
                f_10964_117251_117290(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117251, 117290);
                    return 0;
                }


                int
                f_10964_117406_117445(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117406, 117445);
                    return 0;
                }


                bool
                f_10964_117528_117561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117528, 117561);
                    return return_v;
                }


                int
                f_10964_117611_117651(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117611, 117651);
                    return 0;
                }


                int
                f_10964_117750_117786(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117750, 117786);
                    return 0;
                }


                int
                f_10964_117813_117853(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 117813, 117853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 115393, 117931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 115393, 117931);
            }
        }

        private void EmitFieldStore(BoundFieldAccess fieldAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 117943, 118340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118025, 118061);

                var
                field = f_10964_118037_118060(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118077, 118185) || true) && (f_10964_118081_118097(field))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 118077, 118185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118131, 118170);

                    f_10964_118131_118169(_builder, ILOpCode.Volatile);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 118077, 118185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118201, 118272);

                f_10964_118201_118271(
                            _builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10964, 118221, 118235) || ((f_10964_118221_118235(field) && DynAbs.Tracing.TraceSender.Conditional_F2(10964, 118238, 118253)) || DynAbs.Tracing.TraceSender.Conditional_F3(10964, 118256, 118270))) ? ILOpCode.Stsfld : ILOpCode.Stfld);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118286, 118329);

                f_10964_118286_118328(this, field, fieldAccess.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 117943, 118340);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_118037_118060(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118037, 118060);
                    return return_v;
                }


                bool
                f_10964_118081_118097(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118081, 118097);
                    return return_v;
                }


                int
                f_10964_118131_118169(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118131, 118169);
                    return 0;
                }


                bool
                f_10964_118221_118235(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118221, 118235);
                    return return_v;
                }


                int
                f_10964_118201_118271(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118201, 118271);
                    return 0;
                }


                int
                f_10964_118286_118328(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118286, 118328);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 117943, 118340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 117943, 118340);
            }
        }

        private void EmitParameterStore(BoundParameter parameter, bool refAssign)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 118352, 118944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118450, 118486);

                int
                slot = f_10964_118461_118485(parameter)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118502, 118933) || true) && (f_10964_118506_118539(f_10964_118506_118531(parameter)) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10964, 118506, 118569) && !refAssign))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 118502, 118933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118745, 118813);

                    f_10964_118745_118812(this, f_10964_118763_118793(f_10964_118763_118788(parameter)), parameter.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 118502, 118933);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 118502, 118933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 118879, 118918);

                    f_10964_118879_118917(_builder, slot);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 118502, 118933);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 118352, 118944);

                int
                f_10964_118461_118485(Microsoft.CodeAnalysis.CSharp.BoundParameter
                parameter)
                {
                    var return_v = ParameterSlot(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118461, 118485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_118506_118531(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118506, 118531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_118506_118539(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118506, 118539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10964_118763_118788(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118763, 118788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_118763_118793(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 118763, 118793);
                    return return_v;
                }


                int
                f_10964_118745_118812(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitIndirectStore(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118745, 118812);
                    return 0;
                }


                int
                f_10964_118879_118917(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                argNumber)
                {
                    this_param.EmitStoreArgumentOpcode(argNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 118879, 118917);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 118352, 118944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 118352, 118944);
            }
        }

        private void EmitIndirectStore(TypeSymbol type, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 118956, 121372);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119051, 119237) || true) && (f_10964_119055_119072(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119051, 119237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119172, 119222);

                    type = f_10964_119179_119221(((NamedTypeSymbol)type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119051, 119237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119253, 121361);

                switch (f_10964_119261_119283(type))
                {

                    case Microsoft.Cci.PrimitiveTypeCode.Boolean:
                    case Microsoft.Cci.PrimitiveTypeCode.Int8:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119505, 119544);

                        f_10964_119505_119543(_builder, ILOpCode.Stind_i1);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 119566, 119572);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.Char:
                    case Microsoft.Cci.PrimitiveTypeCode.Int16:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119779, 119818);

                        f_10964_119779_119817(_builder, ILOpCode.Stind_i2);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 119840, 119846);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.Int32:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 119993, 120032);

                        f_10964_119993_120031(_builder, ILOpCode.Stind_i4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 120054, 120060);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.Int64:
                    case Microsoft.Cci.PrimitiveTypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 120207, 120246);

                        f_10964_120207_120245(_builder, ILOpCode.Stind_i8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 120268, 120274);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.IntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.UIntPtr:
                    case Microsoft.Cci.PrimitiveTypeCode.Pointer:
                    case Microsoft.Cci.PrimitiveTypeCode.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 120557, 120595);

                        f_10964_120557_120594(_builder, ILOpCode.Stind_i);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 120617, 120623);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.Float32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 120710, 120749);

                        f_10964_120710_120748(_builder, ILOpCode.Stind_r4);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 120771, 120777);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    case Microsoft.Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 120864, 120903);

                        f_10964_120864_120902(_builder, ILOpCode.Stind_r8);
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 120925, 120931);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 119253, 121361);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 120981, 121318) || true) && (f_10964_120985_121011(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 120981, 121318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121061, 121101);

                            f_10964_121061_121100(_builder, ILOpCode.Stind_ref);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 120981, 121318);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 120981, 121318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121199, 121235);

                            f_10964_121199_121234(_builder, ILOpCode.Stobj);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121261, 121295);

                            f_10964_121261_121294(this, type, syntaxNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 120981, 121318);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 121340, 121346);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 119253, 121361);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 118956, 121372);

                bool
                f_10964_119055_119072(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 119055, 119072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_119179_119221(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 119179, 119221);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10964_119261_119283(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 119261, 119283);
                    return return_v;
                }


                int
                f_10964_119505_119543(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 119505, 119543);
                    return 0;
                }


                int
                f_10964_119779_119817(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 119779, 119817);
                    return 0;
                }


                int
                f_10964_119993_120031(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 119993, 120031);
                    return 0;
                }


                int
                f_10964_120207_120245(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 120207, 120245);
                    return 0;
                }


                int
                f_10964_120557_120594(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 120557, 120594);
                    return 0;
                }


                int
                f_10964_120710_120748(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 120710, 120748);
                    return 0;
                }


                int
                f_10964_120864_120902(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 120864, 120902);
                    return 0;
                }


                bool
                f_10964_120985_121011(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 120985, 121011);
                    return return_v;
                }


                int
                f_10964_121061_121100(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121061, 121100);
                    return 0;
                }


                int
                f_10964_121199_121234(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121199, 121234);
                    return 0;
                }


                int
                f_10964_121261_121294(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121261, 121294);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 118956, 121372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 118956, 121372);
            }
        }

        private void EmitPopIfUnused(bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 121384, 121551);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121448, 121540) || true) && (!used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 121448, 121540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121491, 121525);

                    f_10964_121491_121524(_builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 121448, 121540);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 121384, 121551);

                int
                f_10964_121491_121524(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121491, 121524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 121384, 121551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 121384, 121551);
            }
        }

        private void EmitIsExpression(BoundIsOperator isOp, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 121563, 122321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121650, 121677);

                var
                operand = f_10964_121664_121676(isOp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121691, 121721);

                f_10964_121691_121720(this, operand, used);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121735, 122310) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 121735, 122310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121777, 121820);

                    f_10964_121777_121819((object)f_10964_121798_121810(operand) != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 121838, 122061) || true) && (!f_10964_121843_121877(f_10964_121843_121855(operand)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 121838, 122061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122004, 122042);

                        f_10964_122004_122041(this, f_10964_122012_122024(operand), operand.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 121838, 122061);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122079, 122116);

                    f_10964_122079_122115(_builder, ILOpCode.Isinst);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122134, 122185);

                    f_10964_122134_122184(this, f_10964_122150_122170(f_10964_122150_122165(isOp)), isOp.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122203, 122240);

                    f_10964_122203_122239(_builder, ILOpCode.Ldnull);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122258, 122295);

                    f_10964_122258_122294(_builder, ILOpCode.Cgt_un);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 121735, 122310);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 121563, 122321);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_121664_121676(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 121664, 121676);
                    return return_v;
                }


                int
                f_10964_121691_121720(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121691, 121720);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_121798_121810(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 121798, 121810);
                    return return_v;
                }


                int
                f_10964_121777_121819(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121777, 121819);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_121843_121855(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 121843, 121855);
                    return return_v;
                }


                bool
                f_10964_121843_121877(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 121843, 121877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_122012_122024(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122012, 122024);
                    return return_v;
                }


                int
                f_10964_122004_122041(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122004, 122041);
                    return 0;
                }


                int
                f_10964_122079_122115(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122079, 122115);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10964_122150_122165(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122150, 122165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_122150_122170(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122150, 122170);
                    return return_v;
                }


                int
                f_10964_122134_122184(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122134, 122184);
                    return 0;
                }


                int
                f_10964_122203_122239(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122203, 122239);
                    return 0;
                }


                int
                f_10964_122258_122294(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122258, 122294);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 121563, 122321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 121563, 122321);
            }
        }

        private void EmitAsExpression(BoundAsOperator asOp, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 122333, 123472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122420, 122479);

                f_10964_122420_122478(!f_10964_122434_122477(asOp.Conversion.Kind));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122495, 122522);

                var
                operand = f_10964_122509_122521(asOp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122536, 122566);

                f_10964_122536_122565(this, operand, used);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122582, 123461) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 122582, 123461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122624, 122655);

                    var
                    operandType = f_10964_122642_122654(operand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122673, 122700);

                    var
                    targetType = f_10964_122690_122699(asOp)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122718, 122759);

                    f_10964_122718_122758((object)targetType != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122777, 123029) || true) && ((object)operandType != null && (DynAbs.Tracing.TraceSender.Expression_True(10964, 122781, 122846) && !f_10964_122813_122846(operandType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 122777, 123029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 122973, 123010);

                        f_10964_122973_123009(this, operandType, operand.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 122777, 123029);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123047, 123084);

                    f_10964_123047_123083(_builder, ILOpCode.Isinst);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123102, 123143);

                    f_10964_123102_123142(this, targetType, asOp.Syntax);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123161, 123446) || true) && (!f_10964_123166_123198(targetType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 123161, 123446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123324, 123364);

                        f_10964_123324_123363(                    // We need to unbox if the target type is not a reference type
                                            _builder, ILOpCode.Unbox_any);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123386, 123427);

                        f_10964_123386_123426(this, targetType, asOp.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 123161, 123446);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 122582, 123461);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 122333, 123472);

                bool
                f_10964_122434_122477(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122434, 122477);
                    return return_v;
                }


                int
                f_10964_122420_122478(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122420, 122478);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_122509_122521(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122509, 122521);
                    return return_v;
                }


                int
                f_10964_122536_122565(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122536, 122565);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_122642_122654(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122642, 122654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_122690_122699(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 122690, 122699);
                    return return_v;
                }


                int
                f_10964_122718_122758(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122718, 122758);
                    return 0;
                }


                bool
                f_10964_122813_122846(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122813, 122846);
                    return return_v;
                }


                int
                f_10964_122973_123009(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 122973, 123009);
                    return 0;
                }


                int
                f_10964_123047_123083(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123047, 123083);
                    return 0;
                }


                int
                f_10964_123102_123142(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123102, 123142);
                    return 0;
                }


                bool
                f_10964_123166_123198(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123166, 123198);
                    return return_v;
                }


                int
                f_10964_123324_123363(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123324, 123363);
                    return 0;
                }


                int
                f_10964_123386_123426(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123386, 123426);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 122333, 123472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 122333, 123472);
            }
        }

        private void EmitDefaultValue(TypeSymbol type, bool used, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 123484, 124836);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123589, 124825) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 123589, 124825);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123736, 124112) || true) && (!f_10964_123741_123763(type) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 123740, 123813) && f_10964_123767_123783(type) != SpecialType.System_Decimal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 123736, 124112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123855, 123898);

                        var
                        constantValue = f_10964_123875_123897(type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123920, 124093) || true) && (constantValue != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 123920, 124093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 123995, 124037);

                            f_10964_123995_124036(_builder, constantValue);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124063, 124070);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 123920, 124093);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 123736, 124112);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124132, 124810) || true) && (f_10964_124136_124169(type) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 124136, 124219) || f_10964_124173_124189(type) == SpecialType.System_UIntPtr))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 124132, 124810);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124344, 124383);

                        f_10964_124344_124382(                    // default(whatever*) and default(UIntPtr) can be emitted as:
                                            _builder, ILOpCode.Ldc_i4_0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124405, 124442);

                        f_10964_124405_124441(_builder, ILOpCode.Conv_u);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 124132, 124810);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 124132, 124810);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124484, 124810) || true) && (f_10964_124488_124504(type) == SpecialType.System_IntPtr)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 124484, 124810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124575, 124614);

                            f_10964_124575_124613(_builder, ILOpCode.Ldc_i4_0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124636, 124673);

                            f_10964_124636_124672(_builder, ILOpCode.Conv_i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 124484, 124810);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 124484, 124810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124755, 124791);

                            f_10964_124755_124790(this, type, true, syntaxNode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 124484, 124810);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 124132, 124810);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 123589, 124825);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 123484, 124836);

                bool
                f_10964_123741_123763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123741, 123763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_123767_123783(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 123767, 123783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_123875_123897(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123875, 123897);
                    return return_v;
                }


                int
                f_10964_123995_124036(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 123995, 124036);
                    return 0;
                }


                bool
                f_10964_124136_124169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124136, 124169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_124173_124189(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 124173, 124189);
                    return return_v;
                }


                int
                f_10964_124344_124382(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124344, 124382);
                    return 0;
                }


                int
                f_10964_124405_124441(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124405, 124441);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_124488_124504(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 124488, 124504);
                    return return_v;
                }


                int
                f_10964_124575_124613(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124575, 124613);
                    return 0;
                }


                int
                f_10964_124636_124672(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124636, 124672);
                    return 0;
                }


                int
                f_10964_124755_124790(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitInitObj(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124755, 124790);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 123484, 124836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 123484, 124836);
            }
        }

        private void EmitDefaultExpression(BoundDefaultExpression expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 124848, 125447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 124953, 125132);

                f_10964_124953_125131(f_10964_124966_124993(f_10964_124966_124981(expression)) == SpecialType.System_Decimal || (DynAbs.Tracing.TraceSender.Expression_False(10964, 124966, 125085) || f_10964_125044_125077(f_10964_125044_125059(expression)) == null), "constant should be set on this expression");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 125377, 125436);

                f_10964_125377_125435(this, f_10964_125394_125409(expression), used, expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 124848, 125447);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_124966_124981(Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 124966, 124981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_124966_124993(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 124966, 124993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_125044_125059(Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 125044, 125059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_125044_125077(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDefaultValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 125044, 125077);
                    return return_v;
                }


                int
                f_10964_124953_125131(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 124953, 125131);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_125394_125409(Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 125394, 125409);
                    return return_v;
                }


                int
                f_10964_125377_125435(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitDefaultValue(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 125377, 125435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 124848, 125447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 124848, 125447);
            }
        }

        private void EmitConstantExpression(TypeSymbol type, ConstantValue constantValue, bool used, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 125459, 126121);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 125599, 126110) || true) && (used)
                )  // unused constant has no side-effects

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 125599, 126110);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 125779, 126095) || true) && (((object)type != null) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 125783, 125850) && (f_10964_125810_125823(type) == TypeKind.TypeParameter)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 125783, 125874) && f_10964_125854_125874(constantValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 125779, 126095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 125916, 125952);

                        f_10964_125916_125951(this, type, used, syntaxNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 125779, 126095);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 125779, 126095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126034, 126076);

                        f_10964_126034_126075(_builder, constantValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 125779, 126095);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 125599, 126110);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 125459, 126121);

                Microsoft.CodeAnalysis.TypeKind
                f_10964_125810_125823(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 125810, 125823);
                    return return_v;
                }


                bool
                f_10964_125854_125874(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 125854, 125874);
                    return return_v;
                }


                int
                f_10964_125916_125951(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                used, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitInitObj(type, used, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 125916, 125951);
                    return 0;
                }


                int
                f_10964_126034_126075(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    this_param.EmitConstantValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126034, 126075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 125459, 126121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 125459, 126121);
            }
        }

        private void EmitInitObj(TypeSymbol type, bool used, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 126133, 126689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126233, 126678) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 126233, 126678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126275, 126322);

                    var
                    temp = f_10964_126286_126321(this, type, syntaxNode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126340, 126372);

                    f_10964_126340_126371(_builder, temp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126423, 126461);

                    f_10964_126423_126460(_builder, ILOpCode.Initobj);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126514, 126548);

                    f_10964_126514_126547(this, type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126566, 126595);

                    f_10964_126566_126594(_builder, temp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126648, 126663);

                    f_10964_126648_126662(this, temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 126233, 126678);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 126133, 126689);

                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_126286_126321(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126286, 126321);
                    return return_v;
                }


                int
                f_10964_126340_126371(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalAddress(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126340, 126371);
                    return 0;
                }


                int
                f_10964_126423_126460(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126423, 126460);
                    return 0;
                }


                int
                f_10964_126514_126547(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126514, 126547);
                    return 0;
                }


                int
                f_10964_126566_126594(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126566, 126594);
                    return 0;
                }


                int
                f_10964_126648_126662(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126648, 126662);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 126133, 126689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 126133, 126689);
            }
        }

        private void EmitGetTypeFromHandle(BoundTypeOf boundTypeOf)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 126701, 127119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126785, 126840);

                f_10964_126785_126839(_builder, ILOpCode.Call, stackAdjustment: 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126886, 126936);

                var
                getTypeMethod = f_10964_126906_126935(boundTypeOf)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 126950, 126994);

                f_10964_126950_126993((object)getTypeMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127051, 127108);

                f_10964_127051_127107(this, getTypeMethod, boundTypeOf.Syntax, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 126701, 127119);

                int
                f_10964_126785_126839(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126785, 126839);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_126906_126935(Microsoft.CodeAnalysis.CSharp.BoundTypeOf
                this_param)
                {
                    var return_v = this_param.GetTypeFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 126906, 126935);
                    return return_v;
                }


                int
                f_10964_126950_126993(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 126950, 126993);
                    return 0;
                }


                int
                f_10964_127051_127107(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127051, 127107);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 126701, 127119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 126701, 127119);
            }
        }

        private void EmitTypeOfExpression(BoundTypeOfOperator boundTypeOfOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 127131, 127479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127230, 127284);

                TypeSymbol
                type = f_10964_127248_127283(f_10964_127248_127278(boundTypeOfOperator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127298, 127336);

                f_10964_127298_127335(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127350, 127411);

                f_10964_127350_127410(this, type, f_10964_127372_127402(boundTypeOfOperator).Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127425, 127468);

                f_10964_127425_127467(this, boundTypeOfOperator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 127131, 127479);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10964_127248_127278(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127248, 127278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_127248_127283(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127248, 127283);
                    return return_v;
                }


                int
                f_10964_127298_127335(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127298, 127335);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10964_127372_127402(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127372, 127402);
                    return return_v;
                }


                int
                f_10964_127350_127410(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127350, 127410);
                    return 0;
                }


                int
                f_10964_127425_127467(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                boundTypeOf)
                {
                    this_param.EmitGetTypeFromHandle((Microsoft.CodeAnalysis.CSharp.BoundTypeOf)boundTypeOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127425, 127467);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 127131, 127479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 127131, 127479);
            }
        }

        private void EmitSizeOfExpression(BoundSizeOfOperator boundSizeOfOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 127491, 127781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127590, 127644);

                TypeSymbol
                type = f_10964_127608_127643(f_10964_127608_127638(boundSizeOfOperator))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127658, 127695);

                f_10964_127658_127694(_builder, ILOpCode.Sizeof);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127709, 127770);

                f_10964_127709_127769(this, type, f_10964_127731_127761(boundSizeOfOperator).Syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 127491, 127781);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10964_127608_127638(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127608, 127638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_127608_127643(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127608, 127643);
                    return return_v;
                }


                int
                f_10964_127658_127694(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127658, 127694);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10964_127731_127761(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127731, 127761);
                    return return_v;
                }


                int
                f_10964_127709_127769(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127709, 127769);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 127491, 127781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 127491, 127781);
            }
        }

        private void EmitMethodDefIndexExpression(BoundMethodDefIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 127793, 128845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127885, 127924);

                f_10964_127885_127923(f_10964_127898_127922(f_10964_127898_127909(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 127938, 128002);

                f_10964_127938_128001(f_10964_127951_127972(f_10964_127951_127960(node)) == SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 128016, 128054);

                f_10964_128016_128053(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 128679, 128741);

                var
                symbol = f_10964_128692_128725(f_10964_128692_128703(node)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10964, 128692, 128740) ?? f_10964_128729_128740(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 128757, 128834);

                f_10964_128757_128833(this, symbol, node.Syntax, null, encodeAsRawDefinitionToken: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 127793, 128845);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_127898_127909(Microsoft.CodeAnalysis.CSharp.BoundMethodDefIndex
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127898, 127909);
                    return return_v;
                }


                bool
                f_10964_127898_127922(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127898, 127922);
                    return return_v;
                }


                int
                f_10964_127885_127923(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127885, 127923);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_127951_127960(Microsoft.CodeAnalysis.CSharp.BoundMethodDefIndex
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127951, 127960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_127951_127972(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 127951, 127972);
                    return return_v;
                }


                int
                f_10964_127938_128001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 127938, 128001);
                    return 0;
                }


                int
                f_10964_128016_128053(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 128016, 128053);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_128692_128703(Microsoft.CodeAnalysis.CSharp.BoundMethodDefIndex
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 128692, 128703);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_128692_128725(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 128692, 128725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_128729_128740(Microsoft.CodeAnalysis.CSharp.BoundMethodDefIndex
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 128729, 128740);
                    return return_v;
                }


                int
                f_10964_128757_128833(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList, bool
                encodeAsRawDefinitionToken)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList, encodeAsRawDefinitionToken: encodeAsRawDefinitionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 128757, 128833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 127793, 128845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 127793, 128845);
            }
        }

        private void EmitMaximumMethodDefIndexExpression(BoundMaximumMethodDefIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 128857, 129139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 128963, 129027);

                f_10964_128963_129026(f_10964_128976_128997(f_10964_128976_128985(node)) == SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129041, 129079);

                f_10964_129041_129078(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129093, 129128);

                f_10964_129093_129127(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 128857, 129139);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_128976_128985(Microsoft.CodeAnalysis.CSharp.BoundMaximumMethodDefIndex
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 128976, 128985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_128976_128997(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 128976, 128997);
                    return return_v;
                }


                int
                f_10964_128963_129026(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 128963, 129026);
                    return 0;
                }


                int
                f_10964_129041_129078(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129041, 129078);
                    return 0;
                }


                int
                f_10964_129093_129127(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EmitGreatestMethodToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129093, 129127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 128857, 129139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 128857, 129139);
            }
        }

        private void EmitModuleVersionIdLoad(BoundModuleVersionId node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 129151, 129332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129239, 129276);

                f_10964_129239_129275(_builder, ILOpCode.Ldsfld);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129290, 129321);

                f_10964_129290_129320(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 129151, 129332);

                int
                f_10964_129239_129275(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129239, 129275);
                    return 0;
                }


                int
                f_10964_129290_129320(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundModuleVersionId
                node)
                {
                    this_param.EmitModuleVersionIdToken(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129290, 129320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 129151, 129332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 129151, 129332);
            }
        }

        private void EmitModuleVersionIdStore(BoundModuleVersionId node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 129344, 129526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129433, 129470);

                f_10964_129433_129469(_builder, ILOpCode.Stsfld);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129484, 129515);

                f_10964_129484_129514(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 129344, 129526);

                int
                f_10964_129433_129469(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129433, 129469);
                    return 0;
                }


                int
                f_10964_129484_129514(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundModuleVersionId
                node)
                {
                    this_param.EmitModuleVersionIdToken(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129484, 129514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 129344, 129526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 129344, 129526);
            }
        }

        private void EmitModuleVersionIdToken(BoundModuleVersionId node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 129538, 129796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129627, 129785);

                f_10964_129627_129784(_builder, f_10964_129646_129756(_module, f_10964_129673_129728(_module, f_10964_129691_129700(node), node.Syntax, _diagnostics), node.Syntax, _diagnostics), node.Syntax, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 129538, 129796);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_129691_129700(Microsoft.CodeAnalysis.CSharp.BoundModuleVersionId
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 129691, 129700);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10964_129673_129728(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129673, 129728);
                    return return_v;
                }


                Microsoft.Cci.IFieldReference
                f_10964_129646_129756(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.Cci.ITypeReference
                mvidType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetModuleVersionId(mvidType, syntaxOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129646, 129756);
                    return return_v;
                }


                int
                f_10964_129627_129784(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129627, 129784);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 129538, 129796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 129538, 129796);
            }
        }

        private void EmitModuleVersionIdStringLoad(BoundModuleVersionIdString node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 129808, 130011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129908, 129944);

                f_10964_129908_129943(_builder, ILOpCode.Ldstr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 129958, 130000);

                f_10964_129958_129999(_builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 129808, 130011);

                int
                f_10964_129908_129943(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129908, 129943);
                    return 0;
                }


                int
                f_10964_129958_129999(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EmitModuleVersionIdStringToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 129958, 129999);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 129808, 130011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 129808, 130011);
            }
        }

        private void EmitInstrumentationPayloadRootLoad(BoundInstrumentationPayloadRoot node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 130023, 130237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130133, 130170);

                f_10964_130133_130169(_builder, ILOpCode.Ldsfld);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130184, 130226);

                f_10964_130184_130225(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 130023, 130237);

                int
                f_10964_130133_130169(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130133, 130169);
                    return 0;
                }


                int
                f_10964_130184_130225(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundInstrumentationPayloadRoot
                node)
                {
                    this_param.EmitInstrumentationPayloadRootToken(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130184, 130225);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 130023, 130237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 130023, 130237);
            }
        }

        private void EmitInstrumentationPayloadRootStore(BoundInstrumentationPayloadRoot node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 130249, 130464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130360, 130397);

                f_10964_130360_130396(_builder, ILOpCode.Stsfld);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130411, 130453);

                f_10964_130411_130452(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 130249, 130464);

                int
                f_10964_130360_130396(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130360, 130396);
                    return 0;
                }


                int
                f_10964_130411_130452(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundInstrumentationPayloadRoot
                node)
                {
                    this_param.EmitInstrumentationPayloadRootToken(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130411, 130452);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 130249, 130464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 130249, 130464);
            }
        }

        private void EmitInstrumentationPayloadRootToken(BoundInstrumentationPayloadRoot node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 130476, 130786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130587, 130775);

                f_10964_130587_130774(_builder, f_10964_130606_130746(_module, f_10964_130644_130661(node), f_10964_130663_130718(_module, f_10964_130681_130690(node), node.Syntax, _diagnostics), node.Syntax, _diagnostics), node.Syntax, _diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 130476, 130786);

                int
                f_10964_130644_130661(Microsoft.CodeAnalysis.CSharp.BoundInstrumentationPayloadRoot
                this_param)
                {
                    var return_v = this_param.AnalysisKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 130644, 130661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_130681_130690(Microsoft.CodeAnalysis.CSharp.BoundInstrumentationPayloadRoot
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 130681, 130690);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10964_130663_130718(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130663, 130718);
                    return return_v;
                }


                Microsoft.Cci.IFieldReference
                f_10964_130606_130746(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, int
                analysisKind, Microsoft.Cci.ITypeReference
                payloadType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetInstrumentationPayloadRoot(analysisKind, payloadType, syntaxOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130606, 130746);
                    return return_v;
                }


                int
                f_10964_130587_130774(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130587, 130774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 130476, 130786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 130476, 130786);
            }
        }

        private void EmitSourceDocumentIndex(BoundSourceDocumentIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 130798, 131084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130890, 130954);

                f_10964_130890_130953(f_10964_130903_130924(f_10964_130903_130912(node)) == SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 130968, 131006);

                f_10964_130968_131005(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131020, 131073);

                f_10964_131020_131072(_builder, f_10964_131058_131071(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 130798, 131084);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_130903_130912(Microsoft.CodeAnalysis.CSharp.BoundSourceDocumentIndex
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 130903, 130912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10964_130903_130924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 130903, 130924);
                    return return_v;
                }


                int
                f_10964_130890_130953(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130890, 130953);
                    return 0;
                }


                int
                f_10964_130968_131005(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 130968, 131005);
                    return 0;
                }


                Microsoft.Cci.DebugSourceDocument
                f_10964_131058_131071(Microsoft.CodeAnalysis.CSharp.BoundSourceDocumentIndex
                this_param)
                {
                    var return_v = this_param.Document;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131058, 131071);
                    return return_v;
                }


                int
                f_10964_131020_131072(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    this_param.EmitSourceDocumentIndexToken(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131020, 131072);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 130798, 131084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 130798, 131084);
            }
        }

        private void EmitMethodInfoExpression(BoundMethodInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 131096, 132261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131180, 131218);

                f_10964_131180_131217(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131232, 131280);

                f_10964_131232_131279(this, f_10964_131248_131259(node), node.Syntax, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131296, 131346);

                MethodSymbol
                getMethod = f_10964_131321_131345(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131360, 131400);

                f_10964_131360_131399((object)getMethod != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131416, 131935) || true) && (f_10964_131420_131444(getMethod) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 131416, 131935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131483, 131538);

                    f_10964_131483_131537(_builder, ILOpCode.Call, stackAdjustment: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 131416, 131935);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 131416, 131935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131636, 131680);

                    f_10964_131636_131679(f_10964_131649_131673(getMethod) == 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131698, 131736);

                    f_10964_131698_131735(_builder, ILOpCode.Ldtoken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131754, 131811);

                    f_10964_131754_131810(this, f_10964_131770_131796(f_10964_131770_131781(node)), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131829, 131885);

                    f_10964_131829_131884(_builder, ILOpCode.Call, stackAdjustment: -1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 131416, 131935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 131951, 131997);

                f_10964_131951_131996(this, getMethod, node.Syntax, null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132011, 132250) || true) && (!f_10964_132016_132103(f_10964_132034_132043(node), f_10964_132045_132065(getMethod), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 132011, 132250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132137, 132177);

                    f_10964_132137_132176(_builder, ILOpCode.Castclass);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132195, 132235);

                    f_10964_132195_132234(this, f_10964_132211_132220(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 132011, 132250);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 131096, 132261);

                int
                f_10964_131180_131217(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131180, 131217);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_131248_131259(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131248, 131259);
                    return return_v;
                }


                int
                f_10964_131232_131279(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131232, 131279);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_131321_131345(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.GetMethodFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131321, 131345);
                    return return_v;
                }


                int
                f_10964_131360_131399(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131360, 131399);
                    return 0;
                }


                int
                f_10964_131420_131444(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131420, 131444);
                    return return_v;
                }


                int
                f_10964_131483_131537(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131483, 131537);
                    return 0;
                }


                int
                f_10964_131649_131673(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131649, 131673);
                    return return_v;
                }


                int
                f_10964_131636_131679(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131636, 131679);
                    return 0;
                }


                int
                f_10964_131698_131735(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131698, 131735);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_131770_131781(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131770, 131781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_131770_131796(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 131770, 131796);
                    return return_v;
                }


                int
                f_10964_131754_131810(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131754, 131810);
                    return 0;
                }


                int
                f_10964_131829_131884(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131829, 131884);
                    return 0;
                }


                int
                f_10964_131951_131996(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 131951, 131996);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_132034_132043(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132034, 132043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_132045_132065(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132045, 132065);
                    return return_v;
                }


                bool
                f_10964_132016_132103(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132016, 132103);
                    return return_v;
                }


                int
                f_10964_132137_132176(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132137, 132176);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_132211_132220(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132211, 132220);
                    return return_v;
                }


                int
                f_10964_132195_132234(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132195, 132234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 131096, 132261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 131096, 132261);
            }
        }

        private void EmitFieldInfoExpression(BoundFieldInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 132273, 133419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132355, 132393);

                f_10964_132355_132392(_builder, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132407, 132448);

                f_10964_132407_132447(this, f_10964_132423_132433(node), node.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132462, 132510);

                MethodSymbol
                getField = f_10964_132486_132509(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132524, 132563);

                f_10964_132524_132562((object)getField != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132579, 133095) || true) && (f_10964_132583_132606(getField) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 132579, 133095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132645, 132700);

                    f_10964_132645_132699(_builder, ILOpCode.Call, stackAdjustment: 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 132579, 133095);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 132579, 133095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132798, 132841);

                    f_10964_132798_132840(f_10964_132811_132834(getField) == 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132859, 132897);

                    f_10964_132859_132896(_builder, ILOpCode.Ldtoken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132915, 132971);

                    f_10964_132915_132970(this, f_10964_132931_132956(f_10964_132931_132941(node)), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 132989, 133045);

                    f_10964_132989_133044(_builder, ILOpCode.Call, stackAdjustment: -1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 132579, 133095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 133111, 133156);

                f_10964_133111_133155(this, getField, node.Syntax, null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 133170, 133408) || true) && (!f_10964_133175_133261(f_10964_133193_133202(node), f_10964_133204_133223(getField), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 133170, 133408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 133295, 133335);

                    f_10964_133295_133334(_builder, ILOpCode.Castclass);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 133353, 133393);

                    f_10964_133353_133392(this, f_10964_133369_133378(node), node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 133170, 133408);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 132273, 133419);

                int
                f_10964_132355_132392(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132355, 132392);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_132423_132433(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132423, 132433);
                    return return_v;
                }


                int
                f_10964_132407_132447(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132407, 132447);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10964_132486_132509(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.GetFieldFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132486, 132509);
                    return return_v;
                }


                int
                f_10964_132524_132562(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132524, 132562);
                    return 0;
                }


                int
                f_10964_132583_132606(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132583, 132606);
                    return return_v;
                }


                int
                f_10964_132645_132699(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132645, 132699);
                    return 0;
                }


                int
                f_10964_132811_132834(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132811, 132834);
                    return return_v;
                }


                int
                f_10964_132798_132840(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132798, 132840);
                    return 0;
                }


                int
                f_10964_132859_132896(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132859, 132896);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10964_132931_132941(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132931, 132941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10964_132931_132956(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 132931, 132956);
                    return return_v;
                }


                int
                f_10964_132915_132970(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132915, 132970);
                    return 0;
                }


                int
                f_10964_132989_133044(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 132989, 133044);
                    return 0;
                }


                int
                f_10964_133111_133155(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 133111, 133155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_133193_133202(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 133193, 133202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_133204_133223(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 133204, 133223);
                    return return_v;
                }


                bool
                f_10964_133175_133261(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 133175, 133261);
                    return return_v;
                }


                int
                f_10964_133295_133334(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 133295, 133334);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_133369_133378(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 133369, 133378);
                    return return_v;
                }


                int
                f_10964_133353_133392(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 133353, 133392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 132273, 133419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 132273, 133419);
            }
        }

        private void EmitConditionalOperator(BoundConditionalOperator expr, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 133817, 137165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 133920, 134013);

                f_10964_133920_134012(f_10964_133933_133951(expr) == null, "Constant value should have been emitted directly");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 134029, 134068);

                object
                consequenceLabel = f_10964_134055_134067()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 134082, 134114);

                object
                doneLabel = f_10964_134101_134113()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 134130, 134196);

                f_10964_134130_134195(this, f_10964_134145_134159(expr), ref consequenceLabel, sense: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 134210, 134249);

                f_10964_134210_134248(this, f_10964_134225_134241(expr), used);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135535, 135597);

                var
                mergeTypeOfAlternative = f_10964_135564_135596(this, f_10964_135579_135595(expr))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135611, 136126) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 135611, 136126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135653, 136111) || true) && (f_10964_135657_135706(f_10964_135672_135681(expr), mergeTypeOfAlternative))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 135653, 136111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135748, 135787);

                        f_10964_135748_135786(this, f_10964_135763_135772(expr), expr.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135809, 135844);

                        mergeTypeOfAlternative = f_10964_135834_135843(expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 135653, 136111);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 135653, 136111);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 135886, 136111) || true) && (f_10964_135890_135917(f_10964_135890_135899(expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 135890, 136011) && !f_10964_135922_136011(f_10964_135940_135949(expr), mergeTypeOfAlternative, TypeCompareKind.ConsiderEverything2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 135886, 136111);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136053, 136092);

                            f_10964_136053_136091(this, f_10964_136068_136077(expr), expr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 135886, 136111);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 135653, 136111);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 135611, 136126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136142, 136186);

                f_10964_136142_136185(
                            _builder, ILOpCode.Br, doneLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136200, 136391) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 136200, 136391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136351, 136376);

                    f_10964_136351_136375(                // If we get to consequenceLabel, we should not have Alternative on stack, adjust for that.
                                    _builder, -1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 136200, 136391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136407, 136444);

                f_10964_136407_136443(
                            _builder, consequenceLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136458, 136497);

                f_10964_136458_136496(this, f_10964_136473_136489(expr), used);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136513, 137108) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 136513, 137108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136555, 136617);

                    var
                    mergeTypeOfConsequence = f_10964_136584_136616(this, f_10964_136599_136615(expr))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136635, 137093) || true) && (f_10964_136639_136688(f_10964_136654_136663(expr), mergeTypeOfConsequence))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 136635, 137093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136730, 136769);

                        f_10964_136730_136768(this, f_10964_136745_136754(expr), expr.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136791, 136826);

                        mergeTypeOfConsequence = f_10964_136816_136825(expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 136635, 137093);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 136635, 137093);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 136868, 137093) || true) && (f_10964_136872_136899(f_10964_136872_136881(expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 136872, 136993) && !f_10964_136904_136993(f_10964_136922_136931(expr), mergeTypeOfConsequence, TypeCompareKind.ConsiderEverything2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 136868, 137093);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137035, 137074);

                            f_10964_137035_137073(this, f_10964_137050_137059(expr), expr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 136868, 137093);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 136635, 137093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 136513, 137108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137124, 137154);

                f_10964_137124_137153(
                            _builder, doneLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 133817, 137165);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10964_133933_133951(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 133933, 133951);
                    return return_v;
                }


                int
                f_10964_133920_134012(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 133920, 134012);
                    return 0;
                }


                object
                f_10964_134055_134067()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 134055, 134067);
                    return return_v;
                }


                object
                f_10964_134101_134113()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 134101, 134113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_134145_134159(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 134145, 134159);
                    return return_v;
                }


                int
                f_10964_134130_134195(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, ref object
                dest, bool
                sense)
                {
                    this_param.EmitCondBranch(condition, ref dest, sense: sense);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 134130, 134195);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_134225_134241(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 134225, 134241);
                    return return_v;
                }


                int
                f_10964_134210_134248(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 134210, 134248);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_135579_135595(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135579, 135595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135564_135596(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 135564, 135596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135672_135681(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135672, 135681);
                    return return_v;
                }


                bool
                f_10964_135657_135706(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                from)
                {
                    var return_v = IsVarianceCast(to, from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 135657, 135706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135763_135772(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135763, 135772);
                    return return_v;
                }


                int
                f_10964_135748_135786(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 135748, 135786);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135834_135843(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135834, 135843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135890_135899(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135890, 135899);
                    return return_v;
                }


                bool
                f_10964_135890_135917(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 135890, 135917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_135940_135949(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 135940, 135949);
                    return return_v;
                }


                bool
                f_10964_135922_136011(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 135922, 136011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136068_136077(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136068, 136077);
                    return return_v;
                }


                int
                f_10964_136053_136091(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136053, 136091);
                    return 0;
                }


                int
                f_10964_136142_136185(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136142, 136185);
                    return 0;
                }


                int
                f_10964_136351_136375(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                stackAdjustment)
                {
                    this_param.AdjustStack(stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136351, 136375);
                    return 0;
                }


                int
                f_10964_136407_136443(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136407, 136443);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_136473_136489(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136473, 136489);
                    return return_v;
                }


                int
                f_10964_136458_136496(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136458, 136496);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_136599_136615(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136599, 136615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136584_136616(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136584, 136616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136654_136663(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136654, 136663);
                    return return_v;
                }


                bool
                f_10964_136639_136688(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                from)
                {
                    var return_v = IsVarianceCast(to, from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136639, 136688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136745_136754(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136745, 136754);
                    return return_v;
                }


                int
                f_10964_136730_136768(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136730, 136768);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136816_136825(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136816, 136825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136872_136881(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136872, 136881);
                    return return_v;
                }


                bool
                f_10964_136872_136899(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136872, 136899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_136922_136931(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 136922, 136931);
                    return return_v;
                }


                bool
                f_10964_136904_136993(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 136904, 136993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_137050_137059(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 137050, 137059);
                    return return_v;
                }


                int
                f_10964_137035_137073(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137035, 137073);
                    return 0;
                }


                int
                f_10964_137124_137153(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137124, 137153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 133817, 137165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 133817, 137165);
            }
        }

        private void EmitNullCoalescingOperator(BoundNullCoalescingOperator expr, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 137522, 139463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137631, 137751);

                f_10964_137631_137750(expr.LeftConversion.IsIdentity, "coalesce with nontrivial left conversions are lowered into conditional.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137765, 137805);

                f_10964_137765_137804(f_10964_137778_137803(f_10964_137778_137787(expr)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137821, 137866);

                f_10964_137821_137865(this, f_10964_137836_137852(expr), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 137970, 138030);

                var
                mergeTypeOfLeftValue = f_10964_137997_138029(this, f_10964_138012_138028(expr))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138044, 138607) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138044, 138607);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138086, 138538) || true) && (f_10964_138090_138137(f_10964_138105_138114(expr), mergeTypeOfLeftValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138086, 138538);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138179, 138218);

                        f_10964_138179_138217(this, f_10964_138194_138203(expr), expr.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138240, 138273);

                        mergeTypeOfLeftValue = f_10964_138263_138272(expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138086, 138538);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138086, 138538);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138315, 138538) || true) && (f_10964_138319_138346(f_10964_138319_138328(expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 138319, 138438) && !f_10964_138351_138438(f_10964_138369_138378(expr), mergeTypeOfLeftValue, TypeCompareKind.ConsiderEverything2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138315, 138538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138480, 138519);

                            f_10964_138480_138518(this, f_10964_138495_138504(expr), expr.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138315, 138538);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138086, 138538);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138558, 138592);

                    f_10964_138558_138591(
                                    _builder, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138044, 138607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138623, 138747) || true) && (f_10964_138627_138654(f_10964_138627_138636(expr)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138623, 138747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138688, 138732);

                    f_10964_138688_138731(this, f_10964_138696_138705(expr), f_10964_138707_138723(expr).Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138623, 138747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138763, 138804);

                object
                ifLeftNotNullLabel = f_10964_138791_138803()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138818, 138875);

                f_10964_138818_138874(_builder, ILOpCode.Brtrue, ifLeftNotNullLabel);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138891, 138982) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 138891, 138982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138933, 138967);

                    f_10964_138933_138966(_builder, ILOpCode.Pop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 138891, 138982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 138998, 139038);

                f_10964_138998_139037(this, f_10964_139013_139030(expr), used);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139052, 139397) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 139052, 139397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139094, 139156);

                    var
                    mergeTypeOfRightValue = f_10964_139122_139155(this, f_10964_139137_139154(expr))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139174, 139382) || true) && (f_10964_139178_139226(f_10964_139193_139202(expr), mergeTypeOfRightValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 139174, 139382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139268, 139307);

                        f_10964_139268_139306(this, f_10964_139283_139292(expr), expr.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139329, 139363);

                        mergeTypeOfRightValue = f_10964_139353_139362(expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 139174, 139382);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 139052, 139397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 139413, 139452);

                f_10964_139413_139451(
                            _builder, ifLeftNotNullLabel);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 137522, 139463);

                int
                f_10964_137631_137750(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137631, 137750);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_137778_137787(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 137778, 137787);
                    return return_v;
                }


                bool
                f_10964_137778_137803(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 137778, 137803);
                    return return_v;
                }


                int
                f_10964_137765_137804(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137765, 137804);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_137836_137852(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 137836, 137852);
                    return return_v;
                }


                int
                f_10964_137821_137865(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137821, 137865);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_138012_138028(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138012, 138028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_137997_138029(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 137997, 138029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138105_138114(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138105, 138114);
                    return return_v;
                }


                bool
                f_10964_138090_138137(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                from)
                {
                    var return_v = IsVarianceCast(to, from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138090, 138137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138194_138203(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138194, 138203);
                    return return_v;
                }


                int
                f_10964_138179_138217(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138179, 138217);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138263_138272(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138263, 138272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138319_138328(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138319, 138328);
                    return return_v;
                }


                bool
                f_10964_138319_138346(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138319, 138346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138369_138378(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138369, 138378);
                    return return_v;
                }


                bool
                f_10964_138351_138438(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138351, 138438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138495_138504(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138495, 138504);
                    return return_v;
                }


                int
                f_10964_138480_138518(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138480, 138518);
                    return 0;
                }


                int
                f_10964_138558_138591(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138558, 138591);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138627_138636(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138627, 138636);
                    return return_v;
                }


                bool
                f_10964_138627_138654(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138627, 138654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_138696_138705(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138696, 138705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_138707_138723(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 138707, 138723);
                    return return_v;
                }


                int
                f_10964_138688_138731(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138688, 138731);
                    return 0;
                }


                object
                f_10964_138791_138803()
                {
                    var return_v = new object();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138791, 138803);
                    return return_v;
                }


                int
                f_10964_138818_138874(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, object
                label)
                {
                    this_param.EmitBranch(code, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138818, 138874);
                    return 0;
                }


                int
                f_10964_138933_138966(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138933, 138966);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_139013_139030(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 139013, 139030);
                    return return_v;
                }


                int
                f_10964_138998_139037(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 138998, 139037);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_139137_139154(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 139137, 139154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_139122_139155(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 139122, 139155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_139193_139202(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 139193, 139202);
                    return return_v;
                }


                bool
                f_10964_139178_139226(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                from)
                {
                    var return_v = IsVarianceCast(to, from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 139178, 139226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_139283_139292(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 139283, 139292);
                    return return_v;
                }


                int
                f_10964_139268_139306(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 139268, 139306);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_139353_139362(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 139353, 139362);
                    return return_v;
                }


                int
                f_10964_139413_139451(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, object
                label)
                {
                    this_param.MarkLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 139413, 139451);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 137522, 139463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 137522, 139463);
            }
        }

        private TypeSymbol StackMergeType(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 140511, 142707);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 140690, 140820) || true) && (!(f_10964_140696_140723(f_10964_140696_140705(expr)) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 140696, 140753) || f_10964_140727_140753(f_10964_140727_140736(expr)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 140690, 140820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 140788, 140805);

                    return f_10964_140795_140804(expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 140690, 140820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141057, 142663);

                switch (f_10964_141065_141074(expr))
                {

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141057, 142663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141156, 141195);

                        var
                        conversion = (BoundConversion)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141217, 141264);

                        var
                        conversionKind = f_10964_141238_141263(conversion)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141286, 141396);

                        f_10964_141286_141395(conversionKind != ConversionKind.NullLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10964, 141299, 141394) && conversionKind != ConversionKind.DefaultLiteral));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141420, 141798) || true) && (f_10964_141424_141461(conversionKind) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 141424, 141534) && conversionKind != ConversionKind.MethodGroup) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 141424, 141607) && conversionKind != ConversionKind.NullLiteral) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 141424, 141683) && conversionKind != ConversionKind.DefaultLiteral))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141420, 141798);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141733, 141775);

                            return f_10964_141740_141774(this, f_10964_141755_141773(conversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141420, 141798);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 141820, 141826);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141057, 142663);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141057, 142663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141902, 141949);

                        var
                        assignment = (BoundAssignmentOperator)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 141971, 142011);

                        return f_10964_141978_142010(this, f_10964_141993_142009(assignment));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141057, 142663);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141057, 142663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142077, 142112);

                        var
                        sequence = (BoundSequence)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142134, 142172);

                        return f_10964_142141_142171(this, f_10964_142156_142170(sequence));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141057, 142663);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141057, 142663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142235, 142264);

                        var
                        local = (BoundLocal)expr
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142286, 142481) || true) && (f_10964_142290_142326(this, f_10964_142308_142325(local)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 142286, 142481);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142446, 142458);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 142286, 142481);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10964, 142503, 142509);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141057, 142663);

                    case BoundKind.Dup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 141057, 142663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142636, 142648);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 141057, 142663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 142679, 142696);

                return f_10964_142686_142695(expr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 140511, 142707);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_140696_140705(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 140696, 140705);
                    return return_v;
                }


                bool
                f_10964_140696_140723(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 140696, 140723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_140727_140736(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 140727, 140736);
                    return return_v;
                }


                bool
                f_10964_140727_140753(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 140727, 140753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_140795_140804(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 140795, 140804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10964_141065_141074(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 141065, 141074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10964_141238_141263(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 141238, 141263);
                    return return_v;
                }


                int
                f_10964_141286_141395(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 141286, 141395);
                    return 0;
                }


                bool
                f_10964_141424_141461(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 141424, 141461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_141755_141773(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 141755, 141773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_141740_141774(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 141740, 141774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_141993_142009(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 141993, 142009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_141978_142010(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 141978, 142010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_142156_142170(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 142156, 142170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_142141_142171(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.StackMergeType(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 142141, 142171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10964_142308_142325(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 142308, 142325);
                    return return_v;
                }


                bool
                f_10964_142290_142326(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.IsStackLocal(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 142290, 142326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_142686_142695(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 142686, 142695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 140511, 142707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 140511, 142707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsVarianceCast(TypeSymbol to, TypeSymbol from)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10964, 143105, 144136);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143196, 143326) || true) && (f_10964_143200_143264(to, from, TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 143196, 143326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143298, 143311);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 143196, 143326);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143342, 143504) || true) && ((object)from == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 143342, 143504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143477, 143489);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 143342, 143504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143685, 143844) || true) && (f_10964_143689_143701(to))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 143685, 143844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143735, 143829);

                    return f_10964_143742_143828(f_10964_143757_143790(((ArrayTypeSymbol)to)), f_10964_143792_143827(((ArrayTypeSymbol)from)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 143685, 143844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 143860, 144125);

                return (f_10964_143868_143887(to) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 143868, 143956) && !f_10964_143892_143956(to, from, TypeCompareKind.ConsiderEverything2))) || (DynAbs.Tracing.TraceSender.Expression_False(10964, 143867, 144124) || (f_10964_143982_144002(to) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 143982, 144028) && f_10964_144006_144028(from)) && (DynAbs.Tracing.TraceSender.Expression_True(10964, 143982, 144123) && !f_10964_144033_144123(f_10964_144033_144090(from), to))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10964, 143105, 144136);

                bool
                f_10964_143200_143264(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143200, 143264);
                    return return_v;
                }


                bool
                f_10964_143689_143701(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143689, 143701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_143757_143790(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 143757, 143790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_143792_143827(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 143792, 143827);
                    return return_v;
                }


                bool
                f_10964_143742_143828(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                from)
                {
                    var return_v = IsVarianceCast(to, from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143742, 143828);
                    return return_v;
                }


                bool
                f_10964_143868_143887(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143868, 143887);
                    return return_v;
                }


                bool
                f_10964_143892_143956(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143892, 143956);
                    return return_v;
                }


                bool
                f_10964_143982_144002(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 143982, 144002);
                    return return_v;
                }


                bool
                f_10964_144006_144028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144006, 144028);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10964_144033_144090(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesAndTheirBaseInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 144033, 144090);
                    return return_v;
                }


                bool
                f_10964_144033_144123(Roslyn.Utilities.MultiDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                k)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)k);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144033, 144123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 143105, 144136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 143105, 144136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitStaticCast(TypeSymbol to, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 144148, 145075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 144234, 144273);

                f_10964_144234_144272(f_10964_144247_144271(to));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 144912, 144948);

                var
                temp = f_10964_144923_144947(this, to, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 144962, 144992);

                f_10964_144962_144991(_builder, temp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145006, 145035);

                f_10964_145006_145034(_builder, temp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145049, 145064);

                f_10964_145049_145063(this, temp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 144148, 145075);

                bool
                f_10964_144247_144271(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144247, 144271);
                    return return_v;
                }


                int
                f_10964_144234_144272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144234, 144272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_144923_144947(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144923, 144947);
                    return return_v;
                }


                int
                f_10964_144962_144991(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 144962, 144991);
                    return 0;
                }


                int
                f_10964_145006_145034(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145006, 145034);
                    return 0;
                }


                int
                f_10964_145049_145063(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145049, 145063);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 144148, 145075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 144148, 145075);
            }
        }

        private void EmitBox(TypeSymbol type, SyntaxNode syntaxNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 145087, 145315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145172, 145206);

                f_10964_145172_145205(f_10964_145185_145204_M(!type.IsRefLikeType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145222, 145256);

                f_10964_145222_145255(
                            _builder, ILOpCode.Box);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145270, 145304);

                f_10964_145270_145303(this, type, syntaxNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 145087, 145315);

                bool
                f_10964_145185_145204_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 145185, 145204);
                    return return_v;
                }


                int
                f_10964_145172_145205(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145172, 145205);
                    return 0;
                }


                int
                f_10964_145222_145255(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145222, 145255);
                    return 0;
                }


                int
                f_10964_145270_145303(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145270, 145303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 145087, 145315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 145087, 145315);
            }
        }

        private void EmitCalli(BoundFunctionPointerInvocation ptrInvocation, UseKind useKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 145327, 146878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145437, 145497);

                f_10964_145437_145496(this, f_10964_145452_145483(ptrInvocation), used: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145511, 145539);

                LocalDefinition
                temp = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 145964, 146179) || true) && (ptrInvocation.Arguments.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 145964, 146179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146036, 146116);

                    temp = f_10964_146043_146115(this, f_10964_146056_146092(f_10964_146056_146087(ptrInvocation)), ptrInvocation.Syntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146134, 146164);

                    f_10964_146134_146163(_builder, temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 145964, 146179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146195, 146272);

                FunctionPointerMethodSymbol
                method = f_10964_146232_146271(f_10964_146232_146261(ptrInvocation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146286, 146379);

                f_10964_146286_146378(this, f_10964_146300_146323(ptrInvocation), f_10964_146325_146342(method), f_10964_146344_146377(ptrInvocation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146393, 146500);

                var
                stackBehavior = f_10964_146413_146499(f_10964_146434_146473(f_10964_146434_146463(ptrInvocation)), f_10964_146475_146498(ptrInvocation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146516, 146645) || true) && (temp is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 146516, 146645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146568, 146597);

                    f_10964_146568_146596(_builder, temp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146615, 146630);

                    f_10964_146615_146629(this, temp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 146516, 146645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146661, 146712);

                f_10964_146661_146711(
                            _builder, ILOpCode.Calli, stackBehavior);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146726, 146798);

                f_10964_146726_146797(this, f_10964_146745_146774(ptrInvocation), ptrInvocation.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 146812, 146867);

                f_10964_146812_146866(this, ptrInvocation.Syntax, useKind, method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 145327, 146878);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_145452_145483(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.InvokedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 145452, 145483);
                    return return_v;
                }


                int
                f_10964_145437_145496(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used: used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 145437, 145496);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10964_146056_146087(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.InvokedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146056, 146087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10964_146056_146092(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146056, 146092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                f_10964_146043_146115(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    var return_v = this_param.AllocateTemp(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146043, 146115);
                    return return_v;
                }


                int
                f_10964_146134_146163(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalStore(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146134, 146163);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10964_146232_146261(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146232, 146261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10964_146232_146271(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146232, 146271);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_146300_146323(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146300, 146323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10964_146325_146342(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146325, 146342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10964_146344_146377(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146344, 146377);
                    return return_v;
                }


                int
                f_10964_146286_146378(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argRefKindsOpt)
                {
                    this_param.EmitArguments(arguments, parameters, argRefKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146286, 146378);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10964_146434_146463(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146434, 146463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10964_146434_146473(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146434, 146473);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10964_146475_146498(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146475, 146498);
                    return return_v;
                }


                int
                f_10964_146413_146499(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments)
                {
                    var return_v = GetCallStackBehavior((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146413, 146499);
                    return return_v;
                }


                int
                f_10964_146568_146596(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146568, 146596);
                    return 0;
                }


                int
                f_10964_146615_146629(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                temp)
                {
                    this_param.FreeTemp(temp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146615, 146629);
                    return 0;
                }


                int
                f_10964_146661_146711(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146661, 146711);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10964_146745_146774(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 146745, 146774);
                    return return_v;
                }


                int
                f_10964_146726_146797(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSignatureToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146726, 146797);
                    return 0;
                }


                int
                f_10964_146812_146866(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator.UseKind
                useKind, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                method)
                {
                    this_param.EmitCallCleanup(syntax, useKind, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 146812, 146866);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 145327, 146878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 145327, 146878);
            }
        }

        private void EmitCallCleanup(SyntaxNode syntax, UseKind useKind, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 146890, 150315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 147000, 149978) || true) && (f_10964_147004_147023_M(!method.ReturnsVoid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 147000, 149978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 147057, 147100);

                    f_10964_147057_147099(this, useKind != UseKind.Unused);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 147000, 149978);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 147000, 149978);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 147134, 149978) || true) && (_ilEmitStyle == ILEmitStyle.Debug)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 147134, 149978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 147375, 147459);

                        f_10964_147375_147458(useKind == UseKind.Unused, "Using the return value of a void method.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 147477, 147555);

                        f_10964_147477_147554(f_10964_147490_147515(_method), "Implied by this.emitSequencePoints");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 149929, 149963);

                        f_10964_149929_149962(
                                        // DevDiv #15135.  When a method like System.Diagnostics.Debugger.Break() is called, the
                                        // debugger sees an event indicating that a user break (vs a breakpoint) has occurred.
                                        // When this happens, it uses ICorDebugILFrame.GetIP(out uint, out CorDebugMappingResult)
                                        // to determine the current instruction pointer.  This method returns the instruction
                                        // *after* the call.  The source location is then given by the last sequence point before
                                        // or on this instruction.  As a result, if the instruction after the call has its own
                                        // sequence point, then that sequence point will be used to determine the source location
                                        // and the debugging experience will be disrupted.  The easiest way to ensure that the next
                                        // instruction does not have a sequence point is to insert a nop.  Obviously, we only do this
                                        // if debugging is enabled and optimization is disabled.

                                        // From ILGENREC::genCall:
                                        //   We want to generate a NOP after CALL opcodes that end a statement so the debugger
                                        //   has better stepping behavior

                                        // CONSIDER: In the native compiler, there's an additional restriction on when this nop is
                                        // inserted.  It is quite complicated, but it basically seems to say that, if we thought
                                        // we could omit the temp-and-copy for a struct construction and it turned out that we
                                        // couldn't (perhaps because the assigned local was captured by a lambda), and if we're
                                        // not using the result of the constructor call (how can this even happen?), then we don't
                                        // want to insert the nop.  Since the consequence of not implementing this complicated logic
                                        // is an extra nop in debug code, this is likely not a priority.

                                        // CONSIDER: The native compiler also checks !(tree->flags & EXF_NODEBUGINFO).  We don't have
                                        // this mutable bit on our bound nodes, so we can't exactly match the behavior.  We might be
                                        // able to approximate the native behavior by inspecting call.WasCompilerGenerated, but it is
                                        // not in a reliable state after lowering.

                                        _builder, ILOpCode.Nop);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 147134, 149978);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 147000, 149978);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 149994, 150304) || true) && (useKind == UseKind.UsedAsValue && (DynAbs.Tracing.TraceSender.Expression_True(10964, 149998, 150062) && f_10964_150032_150046(method) != RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 149994, 150304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150096, 150140);

                    f_10964_150096_150139(this, f_10964_150113_150130(method), syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 149994, 150304);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 149994, 150304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150174, 150304) || true) && (useKind == UseKind.UsedAsAddress)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 150174, 150304);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150244, 150289);

                        f_10964_150244_150288(f_10964_150257_150271(method) != RefKind.None);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 150174, 150304);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 149994, 150304);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 146890, 150315);

                bool
                f_10964_147004_147023_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 147004, 147023);
                    return return_v;
                }


                int
                f_10964_147057_147099(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 147057, 147099);
                    return 0;
                }


                int
                f_10964_147375_147458(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 147375, 147458);
                    return 0;
                }


                bool
                f_10964_147490_147515(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GenerateDebugInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 147490, 147515);
                    return return_v;
                }


                int
                f_10964_147477_147554(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 147477, 147554);
                    return 0;
                }


                int
                f_10964_149929_149962(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 149929, 149962);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_150032_150046(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 150032, 150046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_150113_150130(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 150113, 150130);
                    return return_v;
                }


                int
                f_10964_150096_150139(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitLoadIndirect(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 150096, 150139);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10964_150257_150271(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 150257, 150271);
                    return return_v;
                }


                int
                f_10964_150244_150288(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 150244, 150288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 146890, 150315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 146890, 150315);
            }
        }

        private void EmitLoadFunction(BoundFunctionPointerLoad load, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10964, 150327, 150693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150423, 150489);

                f_10964_150423_150488(f_10964_150436_150445(load) is { TypeKind: TypeKind.FunctionPointer });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150505, 150682) || true) && (used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10964, 150505, 150682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150547, 150583);

                    f_10964_150547_150582(_builder, ILOpCode.Ldftn);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10964, 150601, 150667);

                    f_10964_150601_150666(this, f_10964_150617_150634(load), load.Syntax, optArgList: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10964, 150505, 150682);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10964, 150327, 150693);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10964_150436_150445(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 150436, 150445);
                    return return_v;
                }


                int
                f_10964_150423_150488(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 150423, 150488);
                    return 0;
                }


                int
                f_10964_150547_150582(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 150547, 150582);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10964_150617_150634(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10964, 150617, 150634);
                    return return_v;
                }


                int
                f_10964_150601_150666(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList: optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10964, 150601, 150666);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10964, 150327, 150693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10964, 150327, 150693);
            }
        }
    }
}
