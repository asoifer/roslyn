// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundTupleBinaryOperator BindTupleBinaryOperator(BinaryExpressionSyntax node, BinaryOperatorKind kind,
                    BoundExpression left, BoundExpression right, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 969, 1764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1189, 1306);

                TupleBinaryOperatorInfo.Multiple
                operators = f_10320_1234_1305(this, node, kind, left, right, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1322, 1420);

                BoundExpression
                convertedLeft = f_10320_1354_1419(this, left, operators, isRight: false, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1434, 1533);

                BoundExpression
                convertedRight = f_10320_1467_1532(this, right, operators, isRight: true, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1549, 1635);

                TypeSymbol
                resultType = f_10320_1573_1634(this, SpecialType.System_Boolean, diagnostics, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1651, 1753);

                return f_10320_1658_1752(node, convertedLeft, convertedRight, kind, operators, resultType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 969, 1764);

                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10320_1234_1305(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTupleBinaryOperatorNestedInfo(node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 1234, 1305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_1354_1419(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                @operator, bool
                isRight, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ApplyConvertedTypes(expr, (Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo)@operator, isRight: isRight, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 1354, 1419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_1467_1532(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                @operator, bool
                isRight, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ApplyConvertedTypes(expr, (Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo)@operator, isRight: isRight, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 1467, 1532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_1573_1634(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 1573, 1634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                f_10320_1658_1752(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                operators, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, left, right, operatorKind, operators, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 1658, 1752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 969, 1764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 969, 1764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ApplyConvertedTypes(BoundExpression expr, TupleBinaryOperatorInfo @operator, bool isRight, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 1776, 3956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 1942, 2044);

                TypeSymbol
                convertedType = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 1969, 1976) || ((isRight && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 1979, 2010)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 2013, 2043))) ? @operator.RightConvertedTypeOpt : @operator.LeftConvertedTypeOpt
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2060, 3734) || true) && (convertedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 2060, 3734);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2281, 3564) || true) && (f_10320_2285_2303(@operator) == TupleBinaryOperatorInfoKind.Multiple && (DynAbs.Tracing.TraceSender.Expression_True(10320, 2285, 2378) && expr is BoundTupleLiteral tuple))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 2281, 3564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2533, 2592);

                        var
                        multiple = (TupleBinaryOperatorInfo.Multiple)@operator
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2614, 2792) || true) && (multiple.Operators.Length == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 2614, 2792);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2698, 2769);

                            return f_10320_2705_2768(this, expr, diagnostics, reportNoTargetType: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 2614, 2792);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2816, 2876);

                        ImmutableArray<BoundExpression>
                        arguments = f_10320_2860_2875(tuple)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2898, 2928);

                        int
                        length = arguments.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 2950, 3000);

                        f_10320_2950_2999(length == multiple.Operators.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3024, 3088);

                        var
                        builder = f_10320_3038_3087(length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3119, 3124);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3110, 3306) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3138, 3141)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 3110, 3306))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 3110, 3306);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3191, 3283);

                                f_10320_3191_3282(builder, f_10320_3203_3281(this, arguments[i], multiple.Operators[i], isRight, diagnostics));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10320, 1, 197);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10320, 1, 197);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3330, 3545);

                        return f_10320_3337_3544(tuple.Syntax, tuple, wasTargetTyped: false, f_10320_3438_3466(builder), f_10320_3468_3490(tuple), f_10320_3492_3514(tuple), f_10320_3516_3526(tuple), f_10320_3528_3543(tuple));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 2281, 3564);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3648, 3719);

                    return f_10320_3655_3718(this, expr, diagnostics, reportNoTargetType: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 2060, 3734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 3872, 3945);

                return f_10320_3879_3944(this, convertedType, expr, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 1776, 3956);

                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfoKind
                f_10320_2285_2303(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                this_param)
                {
                    var return_v = this_param.InfoKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 2285, 2303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_2705_2768(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                reportNoTargetType)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics, reportNoTargetType: reportNoTargetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 2705, 2768);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10320_2860_2875(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 2860, 2875);
                    return return_v;
                }


                int
                f_10320_2950_2999(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 2950, 2999);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10320_3038_3087(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3038, 3087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_3203_3281(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                @operator, bool
                isRight, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ApplyConvertedTypes(expr, @operator, isRight, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3203, 3281);
                    return return_v;
                }


                int
                f_10320_3191_3282(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3191, 3282);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10320_3438_3466(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3438, 3466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10320_3468_3490(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 3468, 3490);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10320_3492_3514(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.InferredNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 3492, 3514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_3516_3526(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 3516, 3526);
                    return return_v;
                }


                bool
                f_10320_3528_3543(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 3528, 3543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10320_3337_3544(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax, sourceTuple, wasTargetTyped: wasTargetTyped, arguments, argumentNamesOpt, inferredNamesOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3337, 3544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_3655_3718(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                reportNoTargetType)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics, reportNoTargetType: reportNoTargetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3655, 3718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_3879_3944(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 3879, 3944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 1776, 3956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 1776, 3956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TupleBinaryOperatorInfo BindTupleBinaryOperatorInfo(BinaryExpressionSyntax node, BinaryOperatorKind kind,
                    BoundExpression left, BoundExpression right, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 4236, 5854);
                Microsoft.CodeAnalysis.CSharp.Conversion conversionIntoBoolOperator = default(Microsoft.CodeAnalysis.CSharp.Conversion);
                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature boolOperator = default(Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4459, 4491);

                TypeSymbol
                leftType = f_10320_4481_4490(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4505, 4539);

                TypeSymbol
                rightType = f_10320_4528_4538(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4555, 4796) || true) && ((object)leftType != null && (DynAbs.Tracing.TraceSender.Expression_True(10320, 4559, 4607) && f_10320_4587_4607(leftType)) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 4559, 4661) || (object)rightType != null && (DynAbs.Tracing.TraceSender.Expression_True(10320, 4611, 4661) && f_10320_4640_4661(rightType))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 4555, 4796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4695, 4781);

                    return f_10320_4702_4780(this, node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 4555, 4796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4812, 4979) || true) && (f_10320_4816_4851(left, right))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 4812, 4979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4885, 4964);

                    return f_10320_4892_4963(this, node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 4812, 4979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 4995, 5081);

                BoundExpression
                comparison = f_10320_5024_5080(this, node, diagnostics, left, right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 5095, 5843);

                switch (comparison)
                {

                    case BoundLiteral _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 5095, 5843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 5259, 5309);

                        return f_10320_5266_5308(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 5095, 5843);

                    case BoundBinaryOperator binary:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 5095, 5843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 5383, 5543);

                        f_10320_5383_5542(this, f_10320_5421_5432(binary), node, kind, diagnostics, out conversionIntoBoolOperator, out boolOperator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 5565, 5725);

                        return f_10320_5572_5724(f_10320_5607_5623(f_10320_5607_5618(binary)), f_10320_5625_5642(f_10320_5625_5637(binary)), f_10320_5644_5663(binary), f_10320_5665_5681(binary), conversionIntoBoolOperator, boolOperator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 5095, 5843);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 5095, 5843);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 5775, 5828);

                        throw f_10320_5781_5827(comparison);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 5095, 5843);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 4236, 5854);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_4481_4490(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 4481, 4490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_4528_4538(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 4528, 4538);
                    return return_v;
                }


                bool
                f_10320_4587_4607(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 4587, 4607);
                    return return_v;
                }


                bool
                f_10320_4640_4661(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 4640, 4661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                f_10320_4702_4780(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTupleDynamicBinaryOperatorSingleInfo(node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 4702, 4780);
                    return return_v;
                }


                bool
                f_10320_4816_4851(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = IsTupleBinaryOperation(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 4816, 4851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10320_4892_4963(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTupleBinaryOperatorNestedInfo(node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 4892, 4963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_5024_5080(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.BindSimpleBinaryOperator(node, diagnostics, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 5024, 5080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.NullNull
                f_10320_5266_5308(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.NullNull(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 5266, 5308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_5421_5432(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5421, 5432);
                    return return_v;
                }


                int
                f_10320_5383_5542(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                binaryOperator, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversionForBool, out Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                boolOperator)
                {
                    this_param.PrepareBoolConversionAndTruthOperator(type, node, binaryOperator, diagnostics, out conversionForBool, out boolOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 5383, 5542);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_5607_5618(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5607, 5618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_5607_5623(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5607, 5623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_5625_5637(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5625, 5637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_5625_5642(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5625, 5642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10320_5644_5663(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5644, 5663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10320_5665_5681(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 5665, 5681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Single
                f_10320_5572_5724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                leftConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                rightConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodSymbolOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                conversionForBool, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                boolOperator)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Single(leftConvertedTypeOpt, rightConvertedTypeOpt, kind, methodSymbolOpt, conversionForBool, boolOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 5572, 5724);
                    return return_v;
                }


                System.Exception
                f_10320_5781_5827(Microsoft.CodeAnalysis.CSharp.BoundExpression
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 5781, 5827);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 4236, 5854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 4236, 5854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PrepareBoolConversionAndTruthOperator(TypeSymbol type, BinaryExpressionSyntax node, BinaryOperatorKind binaryOperator, DiagnosticBag diagnostics,
                    out Conversion conversionForBool, out UnaryOperatorSignature boolOperator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 6301, 8707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 6637, 6687);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 6701, 6784);

                TypeSymbol
                boolean = f_10320_6722_6783(this, SpecialType.System_Boolean, diagnostics, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 6798, 6913);

                Conversion
                conversion = f_10320_6822_6912(f_10320_6822_6838(this), type, boolean, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 6927, 6969);

                f_10320_6927_6968(diagnostics, node, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 6985, 7257) || true) && (conversion.IsImplicit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 6985, 7257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7044, 7127);

                    f_10320_7044_7126(this, diagnostics, conversion, node, hasBaseReceiver: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7145, 7176);

                    conversionForBool = conversion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7194, 7217);

                    boolOperator = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7235, 7242);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 6985, 7257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7347, 7376);

                UnaryOperatorKind
                boolOpKind
                = default(UnaryOperatorKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7390, 7820);

                switch (binaryOperator)
                {

                    case BinaryOperatorKind.Equal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 7390, 7820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7498, 7535);

                        boolOpKind = UnaryOperatorKind.False;
                        DynAbs.Tracing.TraceSender.TraceBreak(10320, 7557, 7563);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 7390, 7820);

                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 7390, 7820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7636, 7672);

                        boolOpKind = UnaryOperatorKind.True;
                        DynAbs.Tracing.TraceSender.TraceBreak(10320, 7694, 7700);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 7390, 7820);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 7390, 7820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7748, 7805);

                        throw f_10320_7754_7804(binaryOperator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 7390, 7820);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7836, 7864);

                LookupResultKind
                resultKind
                = default(LookupResultKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7878, 7936);

                ImmutableArray<MethodSymbol>
                originalUserDefinedOperators
                = default(ImmutableArray<MethodSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 7950, 8030);

                BoundExpression
                comparisonResult = f_10320_7985_8029(node, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8044, 8215);

                UnaryOperatorAnalysisResult
                best = f_10320_8079_8214(this, boolOpKind, comparisonResult, node, diagnostics, out resultKind, out originalUserDefinedOperators)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8229, 8404) || true) && (best.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 8229, 8404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8280, 8316);

                    conversionForBool = best.Conversion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8334, 8364);

                    boolOperator = best.Signature;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8382, 8389);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 8229, 8404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8490, 8580);

                f_10320_8490_8579(this, diagnostics, node, conversion, comparisonResult, boolean);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8594, 8638);

                conversionForBool = Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8652, 8675);

                boolOperator = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 8689, 8696);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 6301, 8707);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_6722_6783(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 6722, 6783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10320_6822_6838(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 6822, 6838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10320_6822_6912(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 6822, 6912);
                    return return_v;
                }


                bool
                f_10320_6927_6968(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 6927, 6968);
                    return return_v;
                }


                int
                f_10320_7044_7126(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.SyntaxNode
                node, bool
                hasBaseReceiver)
                {
                    this_param.ReportDiagnosticsIfObsolete(diagnostics, conversion, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)node, hasBaseReceiver: hasBaseReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 7044, 7126);
                    return 0;
                }


                System.Exception
                f_10320_7754_7804(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 7754, 7804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleOperandPlaceholder
                f_10320_7985_8029(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTupleOperandPlaceholder((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 7985, 8029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                f_10320_8079_8214(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                originalUserDefinedOperators)
                {
                    var return_v = this_param.UnaryOperatorOverloadResolution(kind, operand, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, diagnostics, out resultKind, out originalUserDefinedOperators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 8079, 8214);
                    return return_v;
                }


                int
                f_10320_8490_8579(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateImplicitConversionError(diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax, conversion, operand, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 8490, 8579);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 6301, 8707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 6301, 8707);
            }
        }

        private TupleBinaryOperatorInfo BindTupleDynamicBinaryOperatorSingleInfo(BinaryExpressionSyntax node, BinaryOperatorKind kind,
                    BoundExpression left, BoundExpression right, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 8719, 10261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9063, 9184);

                f_10320_9063_9183((object)f_10320_9084_9093(left) != null && (DynAbs.Tracing.TraceSender.Expression_True(10320, 9076, 9126) && f_10320_9105_9126(f_10320_9105_9114(left))) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 9076, 9182) || (object)f_10320_9138_9148(right) != null && (DynAbs.Tracing.TraceSender.Expression_True(10320, 9130, 9182) && f_10320_9160_9182(f_10320_9160_9170(right)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9200, 9222);

                bool
                hasError = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9236, 9580) || true) && (!f_10320_9241_9268(left) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 9240, 9301) || !f_10320_9273_9301(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 9236, 9580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9424, 9531);

                    f_10320_9424_9530(diagnostics, ErrorCode.ERR_BadBinaryOps, node, node.OperatorToken.Text, f_10320_9502_9514(left), f_10320_9516_9529(right));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9549, 9565);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 9236, 9580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9596, 9697);

                BinaryOperatorKind
                elementOperatorKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 9637, 9645) || ((hasError && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 9648, 9652)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 9655, 9696))) ? kind : f_10320_9655_9696(kind, BinaryOperatorKind.Dynamic)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 9711, 9791);

                TypeSymbol
                dynamicType = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 9736, 9744) || ((hasError && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 9747, 9764)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 9767, 9790))) ? f_10320_9747_9764(this) : f_10320_9767_9790(f_10320_9767_9778())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10058, 10250);

                return f_10320_10065_10249(dynamicType, dynamicType, elementOperatorKind, methodSymbolOpt: null, conversionForBool: Conversion.Identity, boolOperator: default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 8719, 10261);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_9084_9093(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9084, 9093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_9105_9114(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9105, 9114);
                    return return_v;
                }


                bool
                f_10320_9105_9126(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9105, 9126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_9138_9148(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9138, 9148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_9160_9170(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9160, 9170);
                    return return_v;
                }


                bool
                f_10320_9160_9182(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9160, 9182);
                    return return_v;
                }


                int
                f_10320_9063_9183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9063, 9183);
                    return 0;
                }


                bool
                f_10320_9241_9268(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = IsLegalDynamicOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9241, 9268);
                    return return_v;
                }


                bool
                f_10320_9273_9301(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = IsLegalDynamicOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9273, 9301);
                    return return_v;
                }


                object
                f_10320_9502_9514(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9502, 9514);
                    return return_v;
                }


                object
                f_10320_9516_9529(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9516, 9529);
                    return return_v;
                }


                int
                f_10320_9424_9530(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9424, 9530);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10320_9655_9696(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                type)
                {
                    var return_v = kind.WithType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9655, 9696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_9747_9764(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 9747, 9764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10320_9767_9778()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9767, 9778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_9767_9790(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 9767, 9790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Single
                f_10320_10065_10249(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodSymbolOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                conversionForBool, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                boolOperator)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Single(leftConvertedTypeOpt, rightConvertedTypeOpt, kind, methodSymbolOpt: methodSymbolOpt, conversionForBool: conversionForBool, boolOperator: boolOperator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10065, 10249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 8719, 10261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 8719, 10261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TupleBinaryOperatorInfo.Multiple BindTupleBinaryOperatorNestedInfo(BinaryExpressionSyntax node, BinaryOperatorKind kind,
                    BoundExpression left, BoundExpression right, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 10273, 13392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10511, 10574);

                left = f_10320_10518_10573(left, f_10320_10562_10572(right));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10588, 10652);

                right = f_10320_10596_10651(right, f_10320_10641_10650(left));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10668, 11015) || true) && (f_10320_10672_10719(left) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 10672, 10788) || f_10320_10740_10788(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 10668, 11015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10822, 10928);

                    f_10320_10822_10927(node, diagnostics, f_10320_10867_10885(node), left, right, LookupResultKind.Ambiguous);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 10946, 11000);

                    return TupleBinaryOperatorInfo.Multiple.ErrorInstance;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 10668, 11015);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11183, 11262);

                f_10320_11183_11261((object)f_10320_11204_11213(left) != null || (DynAbs.Tracing.TraceSender.Expression_False(10320, 11196, 11260) || f_10320_11225_11234(left) == BoundKind.TupleLiteral));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11276, 11357);

                f_10320_11276_11356((object)f_10320_11297_11307(right) != null || (DynAbs.Tracing.TraceSender.Expression_False(10320, 11289, 11355) || f_10320_11319_11329(right) == BoundKind.TupleLiteral));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11373, 11421);

                int
                leftCardinality = f_10320_11395_11420(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11435, 11485);

                int
                rightCardinality = f_10320_11458_11484(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11501, 11764) || true) && (leftCardinality != rightCardinality)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 11501, 11764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11574, 11677);

                    f_10320_11574_11676(diagnostics, ErrorCode.ERR_TupleSizesMismatchForBinOps, node, leftCardinality, rightCardinality);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11695, 11749);

                    return TupleBinaryOperatorInfo.Multiple.ErrorInstance;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 11501, 11764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11780, 11898);

                (ImmutableArray<BoundExpression> leftParts, ImmutableArray<string> leftNames) = f_10320_11860_11897(left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 11912, 12033);

                (ImmutableArray<BoundExpression> rightParts, ImmutableArray<string> rightNames) = f_10320_11994_12032(right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12047, 12123);

                f_10320_12047_12122(left, right, leftNames, rightNames, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12139, 12169);

                int
                length = leftParts.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12183, 12225);

                f_10320_12183_12224(length == rightParts.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12241, 12322);

                var
                operatorsBuilder = f_10320_12264_12321(length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12347, 12352);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12338, 12522) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12366, 12369)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 12338, 12522))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 12338, 12522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12403, 12507);

                        f_10320_12403_12506(operatorsBuilder, f_10320_12424_12505(this, node, kind, leftParts[i], rightParts[i], diagnostics));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10320, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10320, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12538, 12573);

                var
                compilation = f_10320_12556_12572(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12587, 12641);

                var
                operators = f_10320_12603_12640(operatorsBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12714, 12770);

                bool
                leftNullable = f_10320_12744_12761(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10320_12734_12743(left), 10320, 12734, 12761)) == true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12784, 12842);

                bool
                rightNullable = f_10320_12816_12833(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10320_12805_12815(right), 10320, 12805, 12833)) == true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12856, 12904);

                bool
                isNullable = leftNullable || (DynAbs.Tracing.TraceSender.Expression_False(10320, 12874, 12903) || rightNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 12920, 13090);

                TypeSymbol
                leftTupleType = f_10320_12947_13089(this, operators.SelectAsArray(o => o.LeftConvertedTypeOpt), f_10320_13019_13028(node), leftParts, leftNames, isNullable, compilation, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 13104, 13279);

                TypeSymbol
                rightTupleType = f_10320_13132_13278(this, operators.SelectAsArray(o => o.RightConvertedTypeOpt), f_10320_13205_13215(node), rightParts, rightNames, isNullable, compilation, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 13295, 13381);

                return f_10320_13302_13380(operators, leftTupleType, rightTupleType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 10273, 13392);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_10562_10572(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 10562, 10572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_10518_10573(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                targetType)
                {
                    var return_v = GiveTupleTypeToDefaultLiteralIfNeeded(expr, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10518, 10573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_10641_10650(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 10641, 10650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10320_10596_10651(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                targetType)
                {
                    var return_v = GiveTupleTypeToDefaultLiteralIfNeeded(expr, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10596, 10651);
                    return return_v;
                }


                bool
                f_10320_10672_10719(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefaultOrImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10672, 10719);
                    return return_v;
                }


                bool
                f_10320_10740_10788(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefaultOrImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10740, 10788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10320_10867_10885(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.OperatorToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 10867, 10885);
                    return return_v;
                }


                int
                f_10320_10822_10927(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxToken
                operatorToken, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    ReportBinaryOperatorError((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node, diagnostics, operatorToken, left, right, resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 10822, 10927);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_11204_11213(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 11204, 11213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10320_11225_11234(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 11225, 11234);
                    return return_v;
                }


                int
                f_10320_11183_11261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11183, 11261);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_11297_11307(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 11297, 11307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10320_11319_11329(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 11319, 11329);
                    return return_v;
                }


                int
                f_10320_11276_11356(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11276, 11356);
                    return 0;
                }


                int
                f_10320_11395_11420(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleCardinality(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11395, 11420);
                    return return_v;
                }


                int
                f_10320_11458_11484(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleCardinality(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11458, 11484);
                    return return_v;
                }


                int
                f_10320_11574_11676(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11574, 11676);
                    return 0;
                }


                (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression> Elements, System.Collections.Immutable.ImmutableArray<string> Names)
                f_10320_11860_11897(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleArgumentsOrPlaceholders(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11860, 11897);
                    return return_v;
                }


                (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression> Elements, System.Collections.Immutable.ImmutableArray<string> Names)
                f_10320_11994_12032(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleArgumentsOrPlaceholders(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 11994, 12032);
                    return return_v;
                }


                int
                f_10320_12047_12122(Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, System.Collections.Immutable.ImmutableArray<string>
                leftNames, System.Collections.Immutable.ImmutableArray<string>
                rightNames, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportNamesMismatchesIfAny(left, right, leftNames, rightNames, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12047, 12122);
                    return 0;
                }


                int
                f_10320_12183_12224(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12183, 12224);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
                f_10320_12264_12321(int
                capacity)
                {
                    var return_v = ArrayBuilder<TupleBinaryOperatorInfo>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12264, 12321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                f_10320_12424_12505(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTupleBinaryOperatorInfo(node, kind, left, right, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12424, 12505);
                    return return_v;
                }


                int
                f_10320_12403_12506(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12403, 12506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10320_12556_12572(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 12556, 12572);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
                f_10320_12603_12640(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12603, 12640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_12734_12743(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 12734, 12743);
                    return return_v;
                }


                bool?
                f_10320_12744_12761(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12744, 12761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_12805_12815(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 12805, 12815);
                    return return_v;
                }


                bool?
                f_10320_12816_12833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12816, 12833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10320_13019_13028(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 13019, 13028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_12947_13089(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>
                convertedTypes, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements, System.Collections.Immutable.ImmutableArray<string>
                names, bool
                isNullable, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeConvertedType(convertedTypes, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, elements, names, isNullable, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 12947, 13089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10320_13205_13215(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 13205, 13215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_13132_13278(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>
                convertedTypes, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements, System.Collections.Immutable.ImmutableArray<string>
                names, bool
                isNullable, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeConvertedType(convertedTypes, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, elements, names, isNullable, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 13132, 13278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10320_13302_13380(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
                operators, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightConvertedTypeOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple(operators, leftConvertedTypeOpt, rightConvertedTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 13302, 13380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 10273, 13392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 10273, 13392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportNamesMismatchesIfAny(BoundExpression left, BoundExpression right,
                    ImmutableArray<string> leftNames, ImmutableArray<string> rightNames, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10320, 13960, 16689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14185, 14240);

                bool
                leftIsTupleLiteral = left is BoundTupleExpression
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14254, 14311);

                bool
                rightIsTupleLiteral = right is BoundTupleExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14327, 14430) || true) && (!leftIsTupleLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10320, 14331, 14374) && !rightIsTupleLiteral))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 14327, 14430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14408, 14415);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 14327, 14430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14446, 14485);

                bool
                leftNoNames = leftNames.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14499, 14540);

                bool
                rightNoNames = rightNames.IsDefault
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14556, 14643) || true) && (leftNoNames && (DynAbs.Tracing.TraceSender.Expression_True(10320, 14560, 14587) && rightNoNames))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 14556, 14643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14621, 14628);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 14556, 14643);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14659, 14742);

                f_10320_14659_14741(leftNoNames || (DynAbs.Tracing.TraceSender.Expression_False(10320, 14672, 14699) || rightNoNames) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 14672, 14740) || leftNames.Length == rightNames.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14758, 14871);

                ImmutableArray<bool>
                leftInferred = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 14794, 14812) || ((leftIsTupleLiteral && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 14815, 14860)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 14863, 14870))) ? f_10320_14815_14860(((BoundTupleExpression)left)) : default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14885, 14935);

                bool
                leftNoInferredNames = leftInferred.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 14951, 15067);

                ImmutableArray<bool>
                rightInferred = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 14988, 15007) || ((rightIsTupleLiteral && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15010, 15056)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15059, 15066))) ? f_10320_15010_15056(((BoundTupleExpression)right)) : default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15081, 15133);

                bool
                rightNoInferredNames = rightInferred.IsDefault
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15149, 15213);

                int
                length = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 15162, 15173) || ((leftNoNames && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15176, 15193)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15196, 15212))) ? rightNames.Length : leftNames.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15236, 15241);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15227, 16678) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15255, 15258)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 15227, 16678))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 15227, 16678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15292, 15344);

                        string
                        leftName = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 15310, 15321) || ((leftNoNames && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15324, 15328)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15331, 15343))) ? null : leftNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15362, 15417);

                        string
                        rightName = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 15381, 15393) || ((rightNoNames && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15396, 15400)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15403, 15416))) ? null : rightNames[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15437, 15502);

                        bool
                        different = f_10320_15454_15496(rightName, leftName) != 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15520, 15604) || true) && (!different)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 15520, 15604);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15576, 15585);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 15520, 15604);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15624, 15693);

                        bool
                        leftWasInferred = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 15647, 15666) || ((leftNoInferredNames && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15669, 15674)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15677, 15692))) ? false : leftInferred[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15711, 15783);

                        bool
                        rightWasInferred = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 15735, 15755) || ((rightNoInferredNames && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 15758, 15763)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 15766, 15782))) ? false : rightInferred[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15803, 15883);

                        bool
                        leftComplaint = leftIsTupleLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10320, 15824, 15862) && leftName != null) && (DynAbs.Tracing.TraceSender.Expression_True(10320, 15824, 15882) && !leftWasInferred)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 15901, 15985);

                        bool
                        rightComplaint = rightIsTupleLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10320, 15923, 15963) && rightName != null) && (DynAbs.Tracing.TraceSender.Expression_True(10320, 15923, 15984) && !rightWasInferred)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16005, 16165) || true) && (!leftComplaint && (DynAbs.Tracing.TraceSender.Expression_True(10320, 16009, 16042) && !rightComplaint))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 16005, 16165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16137, 16146);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 16005, 16165);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16271, 16360);

                        bool
                        useRight = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 16287, 16320) || (((leftComplaint && (DynAbs.Tracing.TraceSender.Expression_True(10320, 16288, 16319) && rightComplaint)) && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 16323, 16342)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 16345, 16359))) ? rightIsTupleLiteral : rightComplaint
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16378, 16484);

                        Location
                        location = f_10320_16398_16483(f_10320_16398_16474(f_10320_16398_16457(((BoundTupleExpression)((DynAbs.Tracing.TraceSender.Conditional_F1(10320, 16422, 16430) || ((useRight && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 16433, 16438)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 16441, 16445))) ? right : left)))[i].Syntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16502, 16557);

                        string
                        complaintName = (DynAbs.Tracing.TraceSender.Conditional_F1(10320, 16525, 16533) || ((useRight && DynAbs.Tracing.TraceSender.Conditional_F2(10320, 16536, 16545)) || DynAbs.Tracing.TraceSender.Conditional_F3(10320, 16548, 16556))) ? rightName : leftName
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16577, 16663);

                        f_10320_16577_16662(
                                        diagnostics, ErrorCode.WRN_TupleBinopLiteralNameMismatch, location, complaintName);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10320, 1, 1452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10320, 1, 1452);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10320, 13960, 16689);

                int
                f_10320_14659_14741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 14659, 14741);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10320_14815_14860(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.InferredNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 14815, 14860);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<bool>
                f_10320_15010_15056(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.InferredNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 15010, 15056);
                    return return_v;
                }


                int
                f_10320_15454_15496(string?
                strA, string?
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 15454, 15496);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10320_16398_16457(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 16398, 16457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10320_16398_16474(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 16398, 16474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10320_16398_16483(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 16398, 16483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10320_16577_16662(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 16577, 16662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 13960, 16689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 13960, 16689);
            }
        }

        internal static BoundExpression GiveTupleTypeToDefaultLiteralIfNeeded(BoundExpression expr, TypeSymbol targetType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10320, 16701, 17103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16840, 16951) || true) && (!f_10320_16845_16868(expr) || (DynAbs.Tracing.TraceSender.Expression_False(10320, 16844, 16890) || targetType is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 16840, 16951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16924, 16936);

                    return expr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 16840, 16951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 16967, 17019);

                f_10320_16967_17018(f_10320_16980_17017(f_10320_16980_17005(targetType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17033, 17092);

                return f_10320_17040_17091(expr.Syntax, targetType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10320, 16701, 17103);

                bool
                f_10320_16845_16868(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 16845, 16868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_16980_17005(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 16980, 17005);
                    return return_v;
                }


                bool
                f_10320_16980_17017(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 16980, 17017);
                    return return_v;
                }


                int
                f_10320_16967_17018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 16967, 17018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10320_17040_17091(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 17040, 17091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 16701, 17103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 16701, 17103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsTupleBinaryOperation(BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10320, 17115, 17667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17227, 17299);

                bool
                leftDefaultOrNew = f_10320_17251_17298(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17313, 17387);

                bool
                rightDefaultOrNew = f_10320_17338_17386(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17401, 17504) || true) && (leftDefaultOrNew && (DynAbs.Tracing.TraceSender.Expression_True(10320, 17405, 17442) && rightDefaultOrNew))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 17401, 17504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17476, 17489);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 17401, 17504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17520, 17656);

                return (f_10320_17528_17553(left) > 1 || (DynAbs.Tracing.TraceSender.Expression_False(10320, 17528, 17577) || leftDefaultOrNew)) && (DynAbs.Tracing.TraceSender.Expression_True(10320, 17527, 17655) && (f_10320_17603_17629(right) > 1 || (DynAbs.Tracing.TraceSender.Expression_False(10320, 17603, 17654) || rightDefaultOrNew)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10320, 17115, 17667);

                bool
                f_10320_17251_17298(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefaultOrImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 17251, 17298);
                    return return_v;
                }


                bool
                f_10320_17338_17386(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefaultOrImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 17338, 17386);
                    return return_v;
                }


                int
                f_10320_17528_17553(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleCardinality(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 17528, 17553);
                    return return_v;
                }


                int
                f_10320_17603_17629(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = GetTupleCardinality(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 17603, 17629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 17115, 17667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 17115, 17667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetTupleCardinality(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10320, 17679, 18231);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17764, 17881) || true) && (expr is BoundTupleExpression tuple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 17764, 17881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17836, 17866);

                    return tuple.Arguments.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 17764, 17881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17897, 17925);

                TypeSymbol
                type = f_10320_17915_17924(expr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17939, 18014) || true) && (type is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 17939, 18014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 17989, 17999);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 17939, 18014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18030, 18194) || true) && (f_10320_18034_18053(type) is { IsTupleType: true } tupleType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 18030, 18194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18122, 18179);

                    return tupleType.TupleElementTypesWithAnnotations.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 18030, 18194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18210, 18220);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10320, 17679, 18231);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_17915_17924(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 17915, 17924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_18034_18053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 18034, 18053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 17679, 18231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 17679, 18231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (ImmutableArray<BoundExpression> Elements, ImmutableArray<string> Names) GetTupleArgumentsOrPlaceholders(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10320, 18504, 19288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18670, 18806) || true) && (expr is BoundTupleExpression tuple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 18670, 18806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18742, 18791);

                    return (f_10320_18750_18765(tuple), f_10320_18767_18789(tuple));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 18670, 18806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 18941, 18989);

                TypeSymbol
                tupleType = f_10320_18964_18988(f_10320_18964_18973(expr))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 19003, 19210);

                ImmutableArray<BoundExpression>
                placeholders = tupleType.TupleElementTypesWithAnnotations
                                .SelectAsArray((t, s) => (BoundExpression)new BoundTupleOperandPlaceholder(s, t.Type), expr.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 19226, 19277);

                return (placeholders, f_10320_19248_19275(tupleType));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10320, 18504, 19288);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10320_18750_18765(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 18750, 18765);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10320_18767_18789(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 18767, 18789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10320_18964_18973(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 18964, 18973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10320_18964_18988(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 18964, 18988);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10320_19248_19275(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10320, 19248, 19275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 18504, 19288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 18504, 19288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol MakeConvertedType(ImmutableArray<TypeSymbol> convertedTypes, CSharpSyntaxNode syntax,
                    ImmutableArray<BoundExpression> elements, ImmutableArray<string> names,
                    bool isNullable, CSharpCompilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10320, 19598, 20930);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 19900, 20091);
                    foreach (var convertedType in f_10320_19930_19944_I(convertedTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 19900, 20091);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 19978, 20076) || true) && (convertedType is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 19978, 20076);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20045, 20057);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 19978, 20076);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 19900, 20091);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10320, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10320, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20107, 20198);

                ImmutableArray<Location>
                elementLocations = elements.SelectAsArray(e => e.Syntax.Location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20214, 20574);

                var
                tuple = f_10320_20226_20573(locationOpt: null, elementTypesWithAnnotations: convertedTypes.SelectAsArray(t => TypeWithAnnotations.Create(t)), elementLocations, elementNames: names, compilation, shouldCheckConstraints: true, includeNullability: false, errorPositions: default, syntax, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20590, 20667) || true) && (!isNullable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10320, 20590, 20667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20639, 20652);

                    return tuple;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10320, 20590, 20667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20776, 20871);

                NamedTypeSymbol
                nullableT = f_10320_20804_20870(this, SpecialType.System_Nullable_T, diagnostics, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10320, 20885, 20919);

                return f_10320_20892_20918(nullableT, tuple);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10320, 19598, 20930);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10320_19930_19944_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 19930, 19944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_20226_20573(Microsoft.CodeAnalysis.Location?
                locationOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                elementLocations, System.Collections.Immutable.ImmutableArray<string>
                elementNames, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                shouldCheckConstraints, bool
                includeNullability, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = NamedTypeSymbol.CreateTuple(locationOpt: locationOpt, elementTypesWithAnnotations: elementTypesWithAnnotations, elementLocations, elementNames: elementNames, compilation, shouldCheckConstraints: shouldCheckConstraints, includeNullability: includeNullability, errorPositions: errorPositions, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 20226, 20573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_20804_20870(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 20804, 20870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10320_20892_20918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10320, 20892, 20918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10320, 19598, 20930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10320, 19598, 20930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
