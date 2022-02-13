// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private BoundExpression BindInterpolatedString(InterpolatedStringExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10309, 492, 8466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 631, 689);

                var
                builder = f_10309_645_688()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 703, 781);

                var
                stringType = f_10309_720_780(this, SpecialType.System_String, diagnostics, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 795, 832);

                ConstantValue?
                resultConstant = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 846, 875);

                bool
                isResultConstant = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 891, 8267) || true) && (node.Contents.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 891, 8267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 953, 1005);

                    resultConstant = f_10309_970_1004(string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 891, 8267);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 891, 8267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1071, 1149);

                    var
                    objectType = f_10309_1088_1148(this, SpecialType.System_Object, diagnostics, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1167, 1241);

                    var
                    intType = f_10309_1181_1240(this, SpecialType.System_Int32, diagnostics, node)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1259, 8128);
                        foreach (var content in f_10309_1283_1296_I(f_10309_1283_1296(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1259, 8128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1338, 8109);

                            switch (f_10309_1346_1360(content))
                            {

                                case SyntaxKind.Interpolation:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1338, 8109);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1505, 1554);

                                        var
                                        interpolation = (InterpolationSyntax)content
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1588, 1671);

                                        var
                                        value = f_10309_1600_1670(this, f_10309_1610_1634(interpolation), diagnostics, BindValueKind.RValue)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1705, 2206) || true) && (f_10309_1709_1719(value) is null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1705, 2206);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 1801, 1873);

                                            value = f_10309_1809_1872(this, objectType, value, diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1705, 2206);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1705, 2206);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 2019, 2065);

                                            value = f_10309_2027_2064(this, value, diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 2103, 2171);

                                            _ = f_10309_2107_2170(this, objectType, value, diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1705, 2206);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 2891, 2925);

                                        BoundExpression?
                                        alignment = null
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 2959, 2987);

                                        BoundLiteral?
                                        format = null
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3021, 4756) || true) && (f_10309_3025_3054(interpolation) != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 3021, 4756);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3136, 3292);

                                            alignment = f_10309_3148_3291(this, intType, f_10309_3189_3277(this, f_10309_3199_3234(f_10309_3199_3228(interpolation)), diagnostics, Binder.BindValueKind.RValue), diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3330, 3378);

                                            var
                                            alignmentConstant = f_10309_3354_3377(alignment)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3416, 4721) || true) && (alignmentConstant != null && (DynAbs.Tracing.TraceSender.Expression_True(10309, 3420, 3473) && f_10309_3449_3473_M(!alignmentConstant.IsBad)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 3416, 4721);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3555, 3588);

                                                const int
                                                magnitudeLimit = 32767
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3731, 3781);

                                                int
                                                alignmentValue = f_10309_3752_3780(alignmentConstant)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 3993, 4066);

                                                alignmentValue = (DynAbs.Tracing.TraceSender.Conditional_F1(10309, 4010, 4030) || (((alignmentValue > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10309, 4033, 4048)) || DynAbs.Tracing.TraceSender.Conditional_F3(10309, 4051, 4065))) ? -alignmentValue : alignmentValue;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4108, 4400) || true) && (alignmentValue < -magnitudeLimit)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 4108, 4400);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4234, 4357);

                                                    f_10309_4234_4356(diagnostics, ErrorCode.WRN_AlignmentMagnitude, f_10309_4284_4309(alignment.Syntax), f_10309_4311_4339(alignmentConstant), magnitudeLimit);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 4108, 4400);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 3416, 4721);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 3416, 4721);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4482, 4721) || true) && (f_10309_4486_4506_M(!alignment.HasErrors))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 4482, 4721);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4588, 4682);

                                                    f_10309_4588_4681(diagnostics, ErrorCode.ERR_ConstantExpected, f_10309_4636_4680(f_10309_4636_4671(f_10309_4636_4665(interpolation))));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 4482, 4721);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 3416, 4721);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 3021, 4756);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4792, 6014) || true) && (f_10309_4796_4822(interpolation) != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 4792, 6014);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 4904, 4970);

                                            var
                                            text = f_10309_4915_4941(interpolation).FormatStringToken.ValueText
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5008, 5022);

                                            char
                                            lastChar
                                            = default(char);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5060, 5083);

                                            bool
                                            hasErrors = false
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5121, 5834) || true) && (f_10309_5125_5136(text) == 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 5121, 5834);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5223, 5312);

                                                f_10309_5223_5311(diagnostics, ErrorCode.ERR_EmptyFormatSpecifier, f_10309_5275_5310(f_10309_5275_5301(interpolation)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5354, 5371);

                                                hasErrors = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 5121, 5834);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 5121, 5834);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5453, 5834) || true) && (f_10309_5457_5515(lastChar = f_10309_5493_5514(text, f_10309_5498_5509(text) - 1)) || (DynAbs.Tracing.TraceSender.Expression_False(10309, 5457, 5550) || f_10309_5519_5550(lastChar)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 5453, 5834);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5632, 5736);

                                                    f_10309_5632_5735(diagnostics, ErrorCode.ERR_TrailingWhitespaceInFormatSpecifier, f_10309_5699_5734(f_10309_5699_5725(interpolation)));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5778, 5795);

                                                    hasErrors = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 5453, 5834);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 5121, 5834);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 5874, 5979);

                                            format = f_10309_5883_5978(f_10309_5900_5926(interpolation), f_10309_5928_5954(text), stringType, hasErrors);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 4792, 6014);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6050, 6132);

                                        f_10309_6050_6131(
                                                                        builder, f_10309_6062_6130(interpolation, value, alignment, format, null));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6166, 6641) || true) && (!isResultConstant || (DynAbs.Tracing.TraceSender.Expression_False(10309, 6170, 6255) || f_10309_6228_6247(value) == null) || (DynAbs.Tracing.TraceSender.Expression_False(10309, 6170, 6361) || !(interpolation is { FormatClause: null, AlignmentClause: null })) || (DynAbs.Tracing.TraceSender.Expression_False(10309, 6170, 6460) || !(f_10309_6404_6423(value) is { IsString: true, IsBad: false })))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 6166, 6641);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6534, 6559);

                                            isResultConstant = false;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6597, 6606);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 6166, 6641);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6675, 6916);

                                        resultConstant = (DynAbs.Tracing.TraceSender.Conditional_F1(10309, 6692, 6716) || (((resultConstant is null)
                                        && DynAbs.Tracing.TraceSender.Conditional_F2(10309, 6756, 6775)) || DynAbs.Tracing.TraceSender.Conditional_F3(10309, 6815, 6915))) ? f_10309_6756_6775(value) : f_10309_6815_6915(BinaryOperatorKind.StringConcatenation, resultConstant, f_10309_6895_6914(value));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 6950, 6959);

                                        continue;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1338, 8109);

                                case SyntaxKind.InterpolatedStringText:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1338, 8109);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7120, 7191);

                                        var
                                        text = ((InterpolatedStringTextSyntax)content).TextToken.ValueText
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7225, 7331);

                                        f_10309_7225_7330(builder, f_10309_7237_7329(content, f_10309_7263_7316(text, SpecialType.System_String), stringType));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7365, 7891) || true) && (isResultConstant)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 7365, 7891);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7459, 7585);

                                            var
                                            constantVal = f_10309_7477_7584(f_10309_7498_7556(text), SpecialType.System_String)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7623, 7856);

                                            resultConstant = (DynAbs.Tracing.TraceSender.Conditional_F1(10309, 7640, 7664) || (((resultConstant is null)
                                            && DynAbs.Tracing.TraceSender.Conditional_F2(10309, 7708, 7719)) || DynAbs.Tracing.TraceSender.Conditional_F3(10309, 7763, 7855))) ? constantVal
                                            : f_10309_7763_7855(BinaryOperatorKind.StringConcatenation, resultConstant, constantVal);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 7365, 7891);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 7925, 7934);

                                        continue;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1338, 8109);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 1338, 8109);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 8029, 8086);

                                    throw f_10309_8035_8085(f_10309_8070_8084(content));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1338, 8109);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 1259, 8128);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10309, 1, 6870);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10309, 1, 6870);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 8148, 8252) || true) && (!isResultConstant)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10309, 8148, 8252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 8211, 8233);

                        resultConstant = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 8148, 8252);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10309, 891, 8267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 8283, 8342);

                f_10309_8283_8341(isResultConstant == (resultConstant != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10309, 8356, 8455);

                return f_10309_8363_8454(node, f_10309_8397_8425(builder), resultConstant, stringType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10309, 492, 8466);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10309_645_688()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 645, 688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10309_720_780(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 720, 780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_970_1004(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 970, 1004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10309_1088_1148(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1088, 1148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10309_1181_1240(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1181, 1240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax>
                f_10309_1283_1296(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Contents;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 1283, 1296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10309_1346_1360(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1346, 1360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10309_1610_1634(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 1610, 1634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_1600_1670(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1600, 1670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10309_1709_1719(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 1709, 1719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_1809_1872(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1809, 1872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_2027_2064(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 2027, 2064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_2107_2170(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 2107, 2170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax?
                f_10309_3025_3054(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.AlignmentClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3025, 3054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax
                f_10309_3199_3228(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.AlignmentClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3199, 3228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10309_3199_3234(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3199, 3234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_3189_3277(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 3189, 3277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10309_3148_3291(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 3148, 3291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10309_3354_3377(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3354, 3377);
                    return return_v;
                }


                bool
                f_10309_3449_3473_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3449, 3473);
                    return return_v;
                }


                int
                f_10309_3752_3780(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 3752, 3780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10309_4284_4309(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4284, 4309);
                    return return_v;
                }


                int
                f_10309_4311_4339(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4311, 4339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10309_4234_4356(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 4234, 4356);
                    return return_v;
                }


                bool
                f_10309_4486_4506_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4486, 4506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax
                f_10309_4636_4665(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.AlignmentClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4636, 4665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10309_4636_4671(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationAlignmentClauseSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4636, 4671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10309_4636_4680(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4636, 4680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10309_4588_4681(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 4588, 4681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax?
                f_10309_4796_4822(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.FormatClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4796, 4822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                f_10309_4915_4941(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.FormatClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 4915, 4941);
                    return return_v;
                }


                int
                f_10309_5125_5136(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5125, 5136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                f_10309_5275_5301(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.FormatClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5275, 5301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10309_5275_5310(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5275, 5310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10309_5223_5311(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5223, 5311);
                    return return_v;
                }


                int
                f_10309_5498_5509(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5498, 5509);
                    return return_v;
                }


                char
                f_10309_5493_5514(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5493, 5514);
                    return return_v;
                }


                bool
                f_10309_5457_5515(char
                ch)
                {
                    var return_v = SyntaxFacts.IsWhitespace(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5457, 5515);
                    return return_v;
                }


                bool
                f_10309_5519_5550(char
                ch)
                {
                    var return_v = SyntaxFacts.IsNewLine(ch);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5519, 5550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                f_10309_5699_5725(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.FormatClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5699, 5725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10309_5699_5734(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5699, 5734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10309_5632_5735(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5632, 5735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                f_10309_5900_5926(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                this_param)
                {
                    var return_v = this_param.FormatClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 5900, 5926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_5928_5954(string
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5928, 5954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10309_5883_5978(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationFormatClauseSyntax
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral((Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 5883, 5978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                f_10309_6062_6130(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                alignment, Microsoft.CodeAnalysis.CSharp.BoundLiteral?
                format, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStringInsert((Microsoft.CodeAnalysis.SyntaxNode)syntax, value, alignment, format, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 6062, 6130);
                    return return_v;
                }


                int
                f_10309_6050_6131(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 6050, 6131);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10309_6228_6247(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 6228, 6247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_6404_6423(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 6404, 6423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_6756_6775(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 6756, 6775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_6895_6914(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10309, 6895, 6914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10309_6815_6915(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.ConstantValue
                valueLeft, Microsoft.CodeAnalysis.ConstantValue
                valueRight)
                {
                    var return_v = FoldStringConcatenation(kind, valueLeft, valueRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 6815, 6915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_7263_7316(string
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create((object)value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7263, 7316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10309_7237_7329(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral((Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7237, 7329);
                    return return_v;
                }


                int
                f_10309_7225_7330(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7225, 7330);
                    return 0;
                }


                string
                f_10309_7498_7556(string
                s)
                {
                    var return_v = ConstantValueUtils.UnescapeInterpolatedStringLiteral(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7498, 7556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10309_7477_7584(string
                value, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = ConstantValue.Create((object)value, st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7477, 7584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10309_7763_7855(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.ConstantValue
                valueLeft, Microsoft.CodeAnalysis.ConstantValue
                valueRight)
                {
                    var return_v = FoldStringConcatenation(kind, valueLeft, valueRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 7763, 7855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10309_8070_8084(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 8070, 8084);
                    return return_v;
                }


                System.Exception
                f_10309_8035_8085(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 8035, 8085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax>
                f_10309_1283_1296_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringContentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 1283, 1296);
                    return return_v;
                }


                int
                f_10309_8283_8341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 8283, 8341);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10309_8397_8425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 8397, 8425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
                f_10309_8363_8454(Microsoft.CodeAnalysis.CSharp.Syntax.InterpolatedStringExpressionSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                parts, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString((Microsoft.CodeAnalysis.SyntaxNode)syntax, parts, constantValueOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10309, 8363, 8454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10309, 492, 8466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10309, 492, 8466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
