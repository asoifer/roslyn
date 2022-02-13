// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    partial class Binder
    {
        private BoundExpression BindIsPatternExpression(IsPatternExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 595, 1952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 726, 813);

                BoundExpression
                expression = f_10315_755_812(this, f_10315_783_798(node), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 827, 895);

                bool
                hasErrors = f_10315_844_894(this, node, ref expression, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 909, 954);

                TypeSymbol?
                expressionType = f_10315_938_953(expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 968, 1403) || true) && (expressionType is null || (DynAbs.Tracing.TraceSender.Expression_False(10315, 972, 1025) || f_10315_998_1025(expressionType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 968, 1403);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1059, 1310) || true) && (!hasErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 1059, 1310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1154, 1252);

                        f_10315_1154_1251(                    // value expected
                                            diagnostics, ErrorCode.ERR_BadPatternExpression, f_10315_1206_1230(f_10315_1206_1221(node)), f_10315_1232_1250(expression));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1274, 1291);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 1059, 1310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1330, 1388);

                    expression = f_10315_1343_1387(this, expression.Syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 968, 1403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1419, 1456);

                f_10315_1419_1455(f_10315_1432_1447(expression) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1470, 1534);

                uint
                inputValEscape = f_10315_1492_1533(expression, f_10315_1517_1532())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1548, 1702);

                BoundPattern
                pattern = f_10315_1571_1701(this, f_10315_1583_1595(node), f_10315_1597_1612(expression), inputValEscape, permitDesignations: true, hasErrors, diagnostics, underIsPattern: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1716, 1747);

                hasErrors |= f_10315_1729_1746(pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 1761, 1941);

                return f_10315_1768_1940(this, node, expression, pattern, f_10315_1837_1898(this, SpecialType.System_Boolean, diagnostics, node), hasErrors, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 595, 1952);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_783_798(Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 783, 798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_755_812(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 755, 812);
                    return return_v;
                }


                bool
                f_10315_844_894(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                node, ref Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.IsOperandErrors((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, ref operand, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 844, 894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_938_953(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 938, 953);
                    return return_v;
                }


                bool
                f_10315_998_1025(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 998, 1025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_1206_1221(Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1206, 1221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_1206_1230(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1206, 1230);
                    return return_v;
                }


                object
                f_10315_1232_1250(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1232, 1250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_1154_1251(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1154, 1251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10315_1343_1387(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.BadExpression(syntax, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1343, 1387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_1432_1447(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1432, 1447);
                    return return_v;
                }


                int
                f_10315_1419_1455(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1419, 1455);
                    return 0;
                }


                uint
                f_10315_1517_1532()
                {
                    var return_v = LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1517, 1532);
                    return return_v;
                }


                uint
                f_10315_1492_1533(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1492, 1533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_1583_1595(Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1583, 1595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_1597_1612(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1597, 1612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_1571_1701(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                underIsPattern)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations: permitDesignations, hasErrors, diagnostics, underIsPattern: underIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1571, 1701);
                    return return_v;
                }


                bool
                f_10315_1729_1746(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 1729, 1746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_1837_1898(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1837, 1898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_1768_1940(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IsPatternExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                boolType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeIsPatternExpression((Microsoft.CodeAnalysis.SyntaxNode)node, expression, pattern, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)boolType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 1768, 1940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 595, 1952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 595, 1952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeIsPatternExpression(
                    SyntaxNode node,
                    BoundExpression expression,
                    BoundPattern pattern,
                    TypeSymbol boolType,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 1964, 6860);
                Microsoft.CodeAnalysis.CSharp.BoundPattern innerPattern = default(Microsoft.CodeAnalysis.CSharp.BoundPattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 2396, 2469);

                LabelSymbol
                whenTrueLabel = f_10315_2424_2468("isPatternSuccess")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 2483, 2557);

                LabelSymbol
                whenFalseLabel = f_10315_2512_2556("isPatternFailure")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 2573, 2628);

                bool
                negated = f_10315_2588_2627(pattern, out innerPattern)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 2642, 2875);

                BoundDecisionDag
                decisionDag = f_10315_2673_2874(f_10315_2740_2756(this), pattern.Syntax, expression, innerPattern, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 2891, 5914) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10315, 2895, 3001) && f_10315_2909_2979(decisionDag, negated, whenTrueLabel, whenFalseLabel) is { } constantResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 2891, 5914);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3035, 4533) || true) && (!constantResult)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3035, 4533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3096, 3179);

                        f_10315_3096_3178(diagnostics, ErrorCode.ERR_IsPatternImpossible, f_10315_3147_3160(node), f_10315_3162_3177(expression));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3201, 3218);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3035, 4533);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3035, 4533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3300, 4514);

                        switch (pattern)
                        {

                            case BoundConstantPattern _:
                            case BoundITuplePattern _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3300, 4514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3543, 3580);

                                throw f_10315_3549_3579();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3300, 4514);

                            case BoundRelationalPattern _:
                            case BoundTypePattern _:
                            case BoundNegatedPattern _:
                            case BoundBinaryPattern _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3300, 4514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 3821, 3900);

                                f_10315_3821_3899(diagnostics, ErrorCode.WRN_IsPatternAlways, f_10315_3868_3881(node), f_10315_3883_3898(expression));
                                DynAbs.Tracing.TraceSender.TraceBreak(10315, 3930, 3936);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3300, 4514);

                            case BoundDiscardPattern _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3300, 4514);
                                DynAbs.Tracing.TraceSender.TraceBreak(10315, 4222, 4228);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3300, 4514);

                            case BoundDeclarationPattern _:
                            case BoundRecursivePattern _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 3300, 4514);
                                DynAbs.Tracing.TraceSender.TraceBreak(10315, 4485, 4491);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3300, 4514);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 3035, 4533);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 2891, 5914);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 2891, 5914);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 4567, 5914) || true) && (f_10315_4571_4595(expression) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 4567, 5914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 4637, 4710);

                        decisionDag = f_10315_4651_4709(decisionDag, expression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 4728, 5899) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10315, 4732, 4840) && f_10315_4746_4816(decisionDag, negated, whenTrueLabel, whenFalseLabel) is { } simplifiedResult))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 4728, 5899);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 4882, 5880) || true) && (!simplifiedResult)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 4882, 5880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 4953, 5034);

                                f_10315_4953_5033(diagnostics, ErrorCode.WRN_GivenExpressionNeverMatchesPattern, f_10315_5019_5032(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 4882, 5880);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 4882, 5880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 5132, 5857);

                                switch (pattern)
                                {

                                    case BoundConstantPattern _:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 5132, 5857);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 5267, 5350);

                                        f_10315_5267_5349(diagnostics, ErrorCode.WRN_GivenExpressionAlwaysMatchesConstant, f_10315_5335_5348(node));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 5384, 5390);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 5132, 5857);

                                    case BoundRelationalPattern _:
                                    case BoundTypePattern _:
                                    case BoundNegatedPattern _:
                                    case BoundBinaryPattern _:
                                    case BoundDiscardPattern _:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 5132, 5857);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 5708, 5790);

                                        f_10315_5708_5789(diagnostics, ErrorCode.WRN_GivenExpressionAlwaysMatchesPattern, f_10315_5775_5788(node));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 5824, 5830);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 5132, 5857);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 4882, 5880);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 4728, 5899);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 4567, 5914);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 2891, 5914);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6151, 6337);

                return f_10315_6158_6336(node, expression, pattern, negated, decisionDag, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel, boolType, hasErrors);

                static bool? getConstantResult(BoundDecisionDag decisionDag, bool negated, LabelSymbol whenTrueLabel, LabelSymbol whenFalseLabel)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 6353, 6849);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6515, 6804) || true) && (!f_10315_6520_6571(f_10315_6520_6547(decisionDag), whenTrueLabel))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 6515, 6804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6613, 6628);

                            return negated;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 6515, 6804);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 6515, 6804);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6670, 6804) || true) && (!f_10315_6675_6727(f_10315_6675_6702(decisionDag), whenFalseLabel))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 6670, 6804);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6769, 6785);

                                return !negated;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 6670, 6804);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 6515, 6804);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6822, 6834);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 6353, 6849);

                        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10315_6520_6547(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                        this_param)
                        {
                            var return_v = this_param.ReachableLabels;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 6520, 6547);
                            return return_v;
                        }


                        bool
                        f_10315_6520_6571(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 6520, 6571);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10315_6675_6702(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                        this_param)
                        {
                            var return_v = this_param.ReachableLabels;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 6675, 6702);
                            return return_v;
                        }


                        bool
                        f_10315_6675_6727(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 6675, 6727);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 6353, 6849);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 6353, 6849);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 1964, 6860);

                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10315_2424_2468(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 2424, 2468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10315_2512_2556(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 2512, 2556);
                    return return_v;
                }


                bool
                f_10315_2588_2627(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param, out Microsoft.CodeAnalysis.CSharp.BoundPattern
                innerPattern)
                {
                    var return_v = this_param.IsNegated(out innerPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 2588, 2627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_2740_2756(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 2740, 2756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10315_2673_2874(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                inputExpression, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenTrueLabel, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenFalseLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecisionDagBuilder.CreateDecisionDagForIsPattern(compilation, syntax, inputExpression, pattern, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 2673, 2874);
                    return return_v;
                }


                bool?
                f_10315_2909_2979(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, bool
                negated, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenTrueLabel, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenFalseLabel)
                {
                    var return_v = getConstantResult(decisionDag, negated, whenTrueLabel, whenFalseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 2909, 2979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_3147_3160(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 3147, 3160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_3162_3177(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 3162, 3177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_3096_3178(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 3096, 3178);
                    return return_v;
                }


                System.Exception
                f_10315_3549_3579()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 3549, 3579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_3868_3881(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 3868, 3881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_3883_3898(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 3883, 3898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_3821_3899(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 3821, 3899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_4571_4595(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 4571, 4595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10315_4651_4709(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                input)
                {
                    var return_v = this_param.SimplifyDecisionDagIfConstantInput(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 4651, 4709);
                    return return_v;
                }


                bool?
                f_10315_4746_4816(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, bool
                negated, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenTrueLabel, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenFalseLabel)
                {
                    var return_v = getConstantResult(decisionDag, negated, whenTrueLabel, whenFalseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 4746, 4816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_5019_5032(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 5019, 5032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_4953_5033(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 4953, 5033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_5335_5348(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 5335, 5348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_5267_5349(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 5267, 5349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_5775_5788(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 5775, 5788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_5708_5789(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 5708, 5789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                f_10315_6158_6336(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, bool
                isNegated, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenTrueLabel, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenFalseLabel, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression(syntax, expression, pattern, isNegated, decisionDag, whenTrueLabel: whenTrueLabel, whenFalseLabel: whenFalseLabel, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 6158, 6336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 1964, 6860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 1964, 6860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindSwitchExpression(SwitchExpressionSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 6872, 7244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 6997, 7029);

                f_10315_6997_7028(node is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7043, 7087);

                Binder?
                switchBinder = f_10315_7066_7086(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7101, 7141);

                f_10315_7101_7140(switchBinder is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7155, 7233);

                return f_10315_7162_7232(switchBinder, node, switchBinder, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 6872, 7244);

                int
                f_10315_6997_7028(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 6997, 7028);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10315_7066_7086(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7066, 7086);
                    return return_v;
                }


                int
                f_10315_7101_7140(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7101, 7140);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_7162_7232(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchExpressionCore(node, originalBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7162, 7232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 6872, 7244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 6872, 7244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual BoundExpression BindSwitchExpressionCore(
                    SwitchExpressionSyntax node,
                    Binder originalBinder,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 7256, 7596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7457, 7494);

                f_10315_7457_7493(f_10315_7476_7485(this) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7508, 7585);

                return f_10315_7515_7584(f_10315_7515_7524(this), node, originalBinder, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 7256, 7596);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10315_7476_7485(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 7476, 7485);
                    return return_v;
                }


                int
                f_10315_7457_7493(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7457, 7493);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10315_7515_7524(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 7515, 7524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_7515_7584(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchExpressionCore(node, originalBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7515, 7584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 7256, 7596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 7256, 7596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundPattern BindPattern(
                    PatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics,
                    bool underIsPattern = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 7608, 9301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7918, 9290);

                return node switch
                {
                    DiscardPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 7969, 8027) && DynAbs.Tracing.TraceSender.Expression_True(10315, 7969, 8027))
    => f_10315_7995_8027(this, p, inputType),
                    DeclarationPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8046, 8172) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8046, 8172))
    => f_10315_8076_8172(this, p, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics),
                    ConstantPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8191, 8300) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8191, 8300))
    => f_10315_8218_8300(this, p, inputType, hasErrors, diagnostics),
                    RecursivePatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8319, 8441) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8319, 8441))
    => f_10315_8347_8441(this, p, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics),
                    VarPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8460, 8570) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8460, 8570))
    => f_10315_8482_8570(this, p, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics),
                    ParenthesizedPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8589, 8730) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8589, 8730))
    => f_10315_8621_8730(this, f_10315_8633_8642(p), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics, underIsPattern),
                    BinaryPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8749, 8865) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8749, 8865))
    => f_10315_8774_8865(this, p, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics),
                    UnaryPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 8884, 8994) && DynAbs.Tracing.TraceSender.Expression_True(10315, 8884, 8994))
    => f_10315_8908_8994(this, p, inputType, inputValEscape, hasErrors, diagnostics, underIsPattern),
                    RelationalPatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 9013, 9101) && DynAbs.Tracing.TraceSender.Expression_True(10315, 9013, 9101))
    => f_10315_9042_9101(this, p, inputType, hasErrors, diagnostics),
                    TypePatternSyntax p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 9120, 9196) && DynAbs.Tracing.TraceSender.Expression_True(10315, 9120, 9196))
    => f_10315_9143_9196(this, p, inputType, hasErrors, diagnostics),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 9215, 9273) && DynAbs.Tracing.TraceSender.Expression_True(10315, 9215, 9273))
    => throw f_10315_9226_9273(f_10315_9261_9272(node)),
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 7608, 9301);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_7995_8027(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DiscardPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType)
                {
                    var return_v = this_param.BindDiscardPattern(node, inputType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 7995, 8027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8076_8172(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeclarationPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8076, 8172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8218_8300(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstantPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstantPatternWithFallbackToTypePattern(node, inputType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8218, 8300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8347_8441(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRecursivePattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8347, 8441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8482_8570(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindVarPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8482, 8570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_8633_8642(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedPatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 8633, 8642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8621_8730(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                underIsPattern)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics, underIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8621, 8730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8774_8865(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBinaryPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8774, 8865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_8908_8994(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UnaryPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                underIsPattern)
                {
                    var return_v = this_param.BindUnaryPattern(node, inputType, inputValEscape, hasErrors, diagnostics, underIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 8908, 8994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_9042_9101(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRelationalPattern(node, inputType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9042, 9101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_9143_9196(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypePatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypePattern(node, inputType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9143, 9196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_9261_9272(Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9261, 9272);
                    return return_v;
                }


                System.Exception
                f_10315_9226_9273(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9226, 9273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 7608, 9301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 7608, 9301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindDiscardPattern(DiscardPatternSyntax node, TypeSymbol inputType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 9313, 9521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 9426, 9510);

                return f_10315_9433_9509(node, inputType: inputType, narrowedType: inputType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 9313, 9521);

                Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                f_10315_9433_9509(Microsoft.CodeAnalysis.CSharp.Syntax.DiscardPatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, inputType: inputType, narrowedType: narrowedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9433, 9509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 9313, 9521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 9313, 9521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindConstantPatternWithFallbackToTypePattern(
                    ConstantPatternSyntax node,
                    TypeSymbol inputType,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 9533, 9890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 9769, 9879);

                return f_10315_9776_9878(this, node, f_10315_9827_9842(node), inputType, hasErrors, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 9533, 9890);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_9827_9842(Microsoft.CodeAnalysis.CSharp.Syntax.ConstantPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 9827, 9842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_9776_9878(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstantPatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstantPatternWithFallbackToTypePattern((Microsoft.CodeAnalysis.SyntaxNode)node, expression, inputType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 9776, 9878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 9533, 9890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 9533, 9890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundPattern BindConstantPatternWithFallbackToTypePattern(
                    SyntaxNode node,
                    ExpressionSyntax expression,
                    TypeSymbol inputType,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 9902, 11457);
                Microsoft.CodeAnalysis.ConstantValue? constantValueOpt = default(Microsoft.CodeAnalysis.ConstantValue?);
                bool wasExpression = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10170, 10247);

                ExpressionSyntax
                innerExpression = f_10315_10205_10246(this, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10261, 10482) || true) && (f_10315_10265_10287(innerExpression) == SyntaxKind.DefaultLiteralExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 10261, 10482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10360, 10432);

                    f_10315_10360_10431(diagnostics, ErrorCode.ERR_DefaultPattern, f_10315_10406_10430(innerExpression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10450, 10467);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 10261, 10482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10498, 10661);

                var
                convertedExpression = f_10315_10524_10660(this, inputType, innerExpression, ref hasErrors, diagnostics, out constantValueOpt, out wasExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10675, 11446) || true) && (wasExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 10675, 11446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 10726, 10935);

                    return f_10315_10733_10934(node, convertedExpression, constantValueOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ConstantValue?>(10315, 10807, 10844) ?? f_10315_10827_10844()), inputType, f_10315_10857_10881(convertedExpression) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10315, 10857, 10894) ?? inputType), hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10315, 10896, 10933) || constantValueOpt is null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 10675, 11446);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 10675, 11446);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11001, 11127) || true) && (!hasErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 11001, 11127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11038, 11127);

                        f_10315_11038_11126(innerExpression, MessageID.IDS_FeatureTypePattern, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 11001, 11127);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11147, 11204);

                    var
                    boundType = (BoundTypeExpression)convertedExpression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11222, 11307);

                    bool
                    isExplicitNotNullTest = f_10315_11251_11277(f_10315_11251_11265(boundType)) == SpecialType.System_Object
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11325, 11431);

                    return f_10315_11332_11430(node, boundType, isExplicitNotNullTest, inputType, f_10315_11404_11418(boundType), hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 10675, 11446);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 9902, 11457);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_10205_10246(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                e)
                {
                    var return_v = this_param.SkipParensAndNullSuppressions(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 10205, 10246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_10265_10287(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 10265, 10287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_10406_10430(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 10406, 10430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_10360_10431(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 10360, 10431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_10524_10660(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                patternExpression, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, out bool
                wasExpression)
                {
                    var return_v = this_param.BindExpressionOrTypeForPattern(inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt, out wasExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 10524, 10660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_10827_10844()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 10827, 10844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_10857_10881(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 10857, 10881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                f_10315_10733_10934(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConstantPattern(syntax, value, constantValue, inputType, narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 10733, 10934);
                    return return_v;
                }


                bool
                f_10315_11038_11126(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 11038, 11126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_11251_11265(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 11251, 11265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10315_11251_11277(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 11251, 11277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_11404_11418(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 11404, 11418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                f_10315_11332_11430(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                declaredType, bool
                isExplicitNotNullTest, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypePattern(syntax, declaredType, isExplicitNotNullTest, inputType, narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 11332, 11430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 9902, 11457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 9902, 11457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionSyntax SkipParensAndNullSuppressions(ExpressionSyntax e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 11469, 12079);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11568, 12068) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 11568, 12068);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11613, 12053);

                        switch (e)
                        {

                            case ParenthesizedExpressionSyntax p:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 11613, 12053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11727, 11744);

                                e = f_10315_11731_11743(p);
                                DynAbs.Tracing.TraceSender.TraceBreak(10315, 11770, 11776);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 11613, 12053);

                            case PostfixUnaryExpressionSyntax { RawKind: (int)SyntaxKind.SuppressNullableWarningExpression } p:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 11613, 12053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 11923, 11937);

                                e = f_10315_11927_11936(p);
                                DynAbs.Tracing.TraceSender.TraceBreak(10315, 11963, 11969);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 11613, 12053);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 11613, 12053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12025, 12034);

                                return e;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 11613, 12053);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 11568, 12068);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 11568, 12068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 11568, 12068);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 11469, 12079);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_11731_11743(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 11731, 11743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_11927_11936(Microsoft.CodeAnalysis.CSharp.Syntax.PostfixUnaryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 11927, 11936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 11469, 12079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 11469, 12079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindExpressionOrTypeForPattern(
                    TypeSymbol inputType,
                    ExpressionSyntax patternExpression,
                    ref bool hasErrors,
                    DiagnosticBag diagnostics,
                    out ConstantValue? constantValueOpt,
                    out bool wasExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 12348, 13388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12672, 12696);

                constantValueOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12710, 12788);

                BoundExpression
                expression = f_10315_12739_12787(this, patternExpression, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12802, 12862);

                wasExpression = f_10315_12818_12833(expression) != BoundKind.TypeExpression;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12876, 13377) || true) && (wasExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 12876, 13377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 12927, 13060);

                    return f_10315_12934_13059(this, expression, inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 12876, 13377);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 12876, 13377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 13126, 13200);

                    f_10315_13126_13199(expression is { Kind: BoundKind.TypeExpression, Type: { } });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 13218, 13326);

                    hasErrors |= f_10315_13231_13325(this, patternExpression, inputType, f_10315_13283_13298(expression), diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 13344, 13362);

                    return expression;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 12876, 13377);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 12348, 13388);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_12739_12787(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindTypeOrRValue(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 12739, 12787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10315_12818_12833(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 12818, 12833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_12934_13059(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                patternExpression, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = this_param.BindExpressionForPatternContinued(expression, inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 12934, 13059);
                    return return_v;
                }


                int
                f_10315_13126_13199(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 13126, 13199);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_13283_13298(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 13283, 13298);
                    return return_v;
                }


                bool
                f_10315_13231_13325(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValidPatternType((Microsoft.CodeAnalysis.SyntaxNode)typeSyntax, inputType, patternType, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 13231, 13325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 12348, 13388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 12348, 13388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindExpressionForPattern(
                    TypeSymbol inputType,
                    ExpressionSyntax patternExpression,
                    ref bool hasErrors,
                    DiagnosticBag diagnostics,
                    out ConstantValue? constantValueOpt,
                    out bool wasExpression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 13549, 14422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 13867, 13891);

                constantValueOpt = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 13905, 14014);

                var
                expression = f_10315_13922_14013(this, patternExpression, diagnostics: diagnostics, invoked: false, indexed: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14028, 14099);

                expression = f_10315_14041_14098(this, expression, BindValueKind.RValue, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14113, 14235);

                wasExpression = f_10315_14129_14144(expression) switch
                {
                    BoundKind.BadExpression when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14154, 14186) && DynAbs.Tracing.TraceSender.Expression_True(10315, 14154, 14186))
=> false,
                    BoundKind.TypeExpression when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14188, 14221) && DynAbs.Tracing.TraceSender.Expression_True(10315, 14188, 14221))
          => false,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14223, 14232) && DynAbs.Tracing.TraceSender.Expression_True(10315, 14223, 14232))
          => true
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14249, 14411);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 14256, 14269) || ((wasExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 14272, 14397)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 14400, 14410))) ? f_10315_14272_14397(this, expression, inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt) : expression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 13549, 14422);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_13922_14013(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invoked, bool
                indexed)
                {
                    var return_v = this_param.BindExpression(node, diagnostics: diagnostics, invoked: invoked, indexed: indexed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 13922, 14013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_14041_14098(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 14041, 14098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10315_14129_14144(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 14129, 14144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_14272_14397(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                patternExpression, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = this_param.BindExpressionForPatternContinued(expression, inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 14272, 14397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 13549, 14422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 13549, 14422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindExpressionForPatternContinued(
                    BoundExpression expression,
                    TypeSymbol inputType,
                    ExpressionSyntax patternExpression,
                    ref bool hasErrors,
                    DiagnosticBag diagnostics,
                    out ConstantValue? constantValueOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 14434, 16211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14765, 14934);

                BoundExpression
                convertedExpression = f_10315_14803_14933(this, inputType, patternExpression, expression, out constantValueOpt, hasErrors, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 14950, 15027);

                f_10315_14950_15026(expression, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15043, 15591) || true) && (f_10315_15047_15077_M(!convertedExpression.HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 15047, 15091) && !hasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 15043, 15591);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15125, 15576) || true) && (constantValueOpt == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 15125, 15576);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15195, 15271);

                        f_10315_15195_15270(diagnostics, ErrorCode.ERR_ConstantExpected, f_10315_15243_15269(patternExpression));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15293, 15310);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 15125, 15576);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 15125, 15576);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15352, 15576) || true) && (f_10315_15356_15381(inputType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 15352, 15576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15423, 15557);

                            f_10315_15423_15556(patternExpression, MessageID.IDS_FeatureNullPointerConstantPattern, diagnostics, f_10315_15529_15555(patternExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 15352, 15576);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 15125, 15576);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 15043, 15591);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15607, 16157) || true) && (f_10315_15611_15635(convertedExpression) is null && (DynAbs.Tracing.TraceSender.Expression_True(10315, 15611, 15685) && constantValueOpt != f_10315_15667_15685()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 15607, 16157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15719, 15743);

                    f_10315_15719_15742(hasErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 15761, 16142);

                    convertedExpression = new BoundConversion(
                                        convertedExpression.Syntax, convertedExpression, Conversion.NoConversion, isBaseConversion: false, @checked: false,
                                        explicitCastInCode: false, constantValueOpt: constantValueOpt, conversionGroupOpt: null, type: f_10315_16057_16074(this), hasErrors: true)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10315, 15783, 16141) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 15607, 16157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 16173, 16200);

                return convertedExpression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 14434, 16211);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_14803_14933(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, out Microsoft.CodeAnalysis.ConstantValue?
                constantValue, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ConvertPatternExpression(inputType, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, expression, out constantValue, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 14803, 14933);
                    return return_v;
                }


                int
                f_10315_14950_15026(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ConstantValueUtils.CheckLangVersionForConstantValue(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 14950, 15026);
                    return 0;
                }


                bool
                f_10315_15047_15077_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 15047, 15077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_15243_15269(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 15243, 15269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_15195_15270(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 15195, 15270);
                    return return_v;
                }


                bool
                f_10315_15356_15381(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 15356, 15381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_15529_15555(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 15529, 15555);
                    return return_v;
                }


                bool
                f_10315_15423_15556(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 15423, 15556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_15611_15635(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 15611, 15635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_15667_15685()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 15667, 15685);
                    return return_v;
                }


                int
                f_10315_15719_15742(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 15719, 15742);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_16057_16074(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 16057, 16074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 14434, 16211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 14434, 16211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression ConvertPatternExpression(
                    TypeSymbol inputType,
                    CSharpSyntaxNode node,
                    BoundExpression expression,
                    out ConstantValue? constantValue,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 16223, 21947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 16526, 16562);

                BoundExpression
                convertedExpression
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 16804, 21829) || true) && (f_10315_16808_16841(inputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 16804, 21829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 16875, 16908);

                    convertedExpression = expression;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17036, 19163) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10315, 17040, 17088) && f_10315_17054_17078(expression) is object))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 17036, 19163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17130, 17181);

                        HashSet<DiagnosticInfo>?
                        useSiteDiagnostics = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17203, 18386) || true) && (f_10315_17207_17231(expression) == f_10315_17235_17253())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 17203, 18386);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17425, 17810) || true) && (f_10315_17429_17463(inputType) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 17429, 17506) && !f_10315_17468_17506(inputType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 17425, 17810);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17650, 17736);

                                f_10315_17650_17735(                            // We do not permit matching null against a struct type.
                                                            diagnostics, ErrorCode.ERR_ValueCantBeNull, f_10315_17697_17723(expression.Syntax), inputType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17766, 17783);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 17425, 17810);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 17203, 18386);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 17203, 18386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17908, 17951);

                            f_10315_17908_17950(f_10315_17927_17942(expression) is { });

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 17977, 18363) || true) && (f_10315_17981_18115(f_10315_18016_18027(), inputType, f_10315_18040_18055(expression), ref useSiteDiagnostics, out _, operandConstantValue: null) == false)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 17977, 18363);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18182, 18289);

                                f_10315_18182_18288(diagnostics, ErrorCode.ERR_PatternWrongType, f_10315_18230_18256(expression.Syntax), inputType, f_10315_18269_18287(expression));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18319, 18336);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 17977, 18363);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 17203, 18386);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18410, 19078) || true) && (!hasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 18410, 19078);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18474, 18553);

                            var
                            requiredVersion = f_10315_18496_18552(MessageID.IDS_FeatureRecursivePatterns)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18579, 19055) || true) && (f_10315_18583_18610(f_10315_18583_18594()) < requiredVersion && (DynAbs.Tracing.TraceSender.Expression_True(10315, 18583, 18769) && f_10315_18661_18769_M(!f_10315_18662_18758(f_10315_18662_18678(this), expression, inputType, ref useSiteDiagnostics).IsImplicit)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 18579, 19055);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 18827, 19028);

                                f_10315_18827_19027(diagnostics, ErrorCode.ERR_ConstantPatternVsOpenType, f_10315_18917_18943(expression.Syntax), inputType, f_10315_18956_18974(expression), f_10315_18976_19026(requiredVersion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 18579, 19055);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 18410, 19078);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19102, 19144);

                        f_10315_19102_19143(
                                            diagnostics, node, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 17036, 19163);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 16804, 21829);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 16804, 21829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19566, 19656);

                    convertedExpression = f_10315_19588_19655(this, inputType, expression, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19676, 21814) || true) && (f_10315_19680_19704(convertedExpression) == BoundKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 19676, 21814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19770, 19824);

                        var
                        conversion = (BoundConversion)convertedExpression
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19846, 19891);

                        BoundExpression
                        operand = f_10315_19872_19890(conversion)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 19913, 21795) || true) && (f_10315_19917_19943(inputType) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 19917, 20035) && (f_10315_19948_19981(convertedExpression) == null || (DynAbs.Tracing.TraceSender.Expression_False(10315, 19948, 20034) || f_10315_19993_20034_M(!f_10315_19994_20027(convertedExpression).IsNull)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 19913, 21795);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 20228, 20283);

                            var
                            discardedDiagnostics = f_10315_20255_20282()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 20374, 20483);

                            convertedExpression = f_10315_20396_20482(this, operand, f_10315_20422_20459(inputType), discardedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 20509, 20537);

                            f_10315_20509_20536(discardedDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 19913, 21795);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 19913, 21795);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 20587, 21795) || true) && ((f_10315_20592_20617(conversion) == ConversionKind.Boxing || (DynAbs.Tracing.TraceSender.Expression_False(10315, 20592, 20707) || f_10315_20646_20671(conversion) == ConversionKind.ImplicitReference))
                            && (DynAbs.Tracing.TraceSender.Expression_True(10315, 20591, 20766) && f_10315_20737_20758(operand) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 20591, 20811) && f_10315_20770_20803(convertedExpression) == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 20587, 21795);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 21405, 21435);

                                convertedExpression = operand;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 20587, 21795);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 20587, 21795);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 21485, 21795) || true) && (f_10315_21489_21514(conversion) == ConversionKind.ImplicitNullToPointer || (DynAbs.Tracing.TraceSender.Expression_False(10315, 21489, 21692) || (f_10315_21584_21609(conversion) == ConversionKind.NoConversion && (DynAbs.Tracing.TraceSender.Expression_True(10315, 21584, 21691) && f_10315_21669_21683(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10315_21644_21668(convertedExpression), 10315, 21644, 21683)) == true))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 21485, 21795);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 21742, 21772);

                                    convertedExpression = operand;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 21485, 21795);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 20587, 21795);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 19913, 21795);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 19676, 21814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 16804, 21829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 21845, 21895);

                constantValue = f_10315_21861_21894(convertedExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 21909, 21936);

                return convertedExpression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 16223, 21947);

                bool
                f_10315_16808_16841(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 16808, 16841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_17054_17078(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 17054, 17078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_17207_17231(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 17207, 17231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_17235_17253()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 17235, 17253);
                    return return_v;
                }


                bool
                f_10315_17429_17463(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 17429, 17463);
                    return return_v;
                }


                bool
                f_10315_17468_17506(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 17468, 17506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_17697_17723(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 17697, 17723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_17650_17735(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 17650, 17735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_17927_17942(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 17927, 17942);
                    return return_v;
                }


                int
                f_10315_17908_17950(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 17908, 17950);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10315_18016_18027()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18016, 18027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_18040_18055(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18040, 18055);
                    return return_v;
                }


                bool?
                f_10315_17981_18115(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.ConstantValue?
                operandConstantValue)
                {
                    var return_v = ExpressionOfTypeMatchesPatternType(conversions, expressionType, patternType, ref useSiteDiagnostics, out conversion, operandConstantValue: operandConstantValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 17981, 18115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_18230_18256(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18230, 18256);
                    return return_v;
                }


                object
                f_10315_18269_18287(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18269, 18287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_18182_18288(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 18182, 18288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_18496_18552(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 18496, 18552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_18583_18594()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18583, 18594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_18583_18610(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18583, 18610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10315_18662_18678(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18662, 18678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10315_18662_18758(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 18662, 18758);
                    return return_v;
                }


                bool
                f_10315_18661_18769_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18661, 18769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_18917_18943(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18917, 18943);
                    return return_v;
                }


                object
                f_10315_18956_18974(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 18956, 18974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10315_18976_19026(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 18976, 19026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_18827_19027(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 18827, 19027);
                    return return_v;
                }


                bool
                f_10315_19102_19143(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 19102, 19143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_19588_19655(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 19588, 19655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10315_19680_19704(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 19680, 19704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_19872_19890(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 19872, 19890);
                    return return_v;
                }


                bool
                f_10315_19917_19943(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 19917, 19943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_19948_19981(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 19948, 19981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_19994_20027(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 19994, 20027);
                    return return_v;
                }


                bool
                f_10315_19993_20034_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 19993, 20034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10315_20255_20282()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 20255, 20282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_20422_20459(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 20422, 20459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_20396_20482(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateConversion(source, destination, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 20396, 20482);
                    return return_v;
                }


                int
                f_10315_20509_20536(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 20509, 20536);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10315_20592_20617(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 20592, 20617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10315_20646_20671(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 20646, 20671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_20737_20758(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 20737, 20758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_20770_20803(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 20770, 20803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10315_21489_21514(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 21489, 21514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10315_21584_21609(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 21584, 21609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_21644_21668(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 21644, 21668);
                    return return_v;
                }


                bool?
                f_10315_21669_21683(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 21669, 21683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10315_21861_21894(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 21861, 21894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 16223, 21947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 16223, 21947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckValidPatternType(
                    SyntaxNode typeSyntax,
                    TypeSymbol inputType,
                    TypeSymbol patternType,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 22111, 25537);
                Microsoft.CodeAnalysis.CSharp.Conversion conversion = default(Microsoft.CodeAnalysis.CSharp.Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22319, 22365);

                f_10315_22319_22364((object)inputType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22379, 22427);

                f_10315_22379_22426((object)patternType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22443, 25497) || true) && (f_10315_22447_22470(inputType) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 22447, 22499) || f_10315_22474_22499(patternType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22443, 25497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22533, 22546);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22443, 25497);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22443, 25497);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22580, 25497) || true) && (f_10315_22584_22622(inputType) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 22584, 22666) || f_10315_22626_22666(patternType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22580, 25497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22772, 22853);

                        f_10315_22772_22852(                // pattern-matching is not permitted for pointer types
                                        diagnostics, ErrorCode.ERR_PointerTypeInPatternMatching, f_10315_22832_22851(typeSyntax));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22871, 22883);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22580, 25497);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22580, 25497);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 22917, 25497) || true) && (f_10315_22921_22949(patternType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22917, 25497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23120, 23227);

                            f_10315_23120_23226(diagnostics, ErrorCode.ERR_PatternNullableType, typeSyntax, f_10315_23186_23225(patternType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23245, 23257);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22917, 25497);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 22917, 25497);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23291, 25497) || true) && (typeSyntax is NullableTypeSyntax)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 23291, 25497);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23361, 23440);

                                f_10315_23361_23439(diagnostics, ErrorCode.ERR_PatternNullableType, typeSyntax, patternType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23458, 23470);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 23291, 25497);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 23291, 25497);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23504, 25497) || true) && (f_10315_23508_23528(patternType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 23504, 25497);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23562, 23642);

                                    f_10315_23562_23641(diagnostics, ErrorCode.ERR_VarDeclIsStaticClass, typeSyntax, patternType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23660, 23672);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 23504, 25497);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 23504, 25497);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23738, 23925) || true) && (f_10315_23742_23765(patternType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 23738, 23925);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23807, 23872);

                                        f_10315_23807_23871(diagnostics, ErrorCode.ERR_PatternDynamicType, typeSyntax);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23894, 23906);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 23738, 23925);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 23945, 23996);

                                    HashSet<DiagnosticInfo>?
                                    useSiteDiagnostics = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24014, 24235);

                                    bool?
                                    matchPossible = f_10315_24036_24234(f_10315_24093_24104(), inputType, patternType, ref useSiteDiagnostics, out conversion, operandConstantValue: null, operandCouldBeNull: true)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24253, 24301);

                                    f_10315_24253_24300(diagnostics, typeSyntax, useSiteDiagnostics);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24319, 25482) || true) && (matchPossible != false)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 24319, 25482);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24387, 25260) || true) && (f_10315_24391_24409_M(!conversion.Exists) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 24391, 24487) && (f_10315_24414_24447(inputType) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 24414, 24486) || f_10315_24451_24486(patternType)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 24387, 25260);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24638, 24734);

                                            LanguageVersion
                                            requiredVersion = f_10315_24672_24733(MessageID.IDS_FeatureGenericPatternMatching)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24760, 25237) || true) && (requiredVersion > f_10315_24782_24809(f_10315_24782_24793()))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 24760, 25237);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 24867, 25168);

                                                f_10315_24867_25167(diagnostics, ErrorCode.ERR_PatternWrongGenericTypeInVersion, typeSyntax, inputType, patternType, f_10315_25036_25081(f_10315_25036_25063(f_10315_25036_25047())), f_10315_25116_25166(requiredVersion));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 25198, 25210);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 24760, 25237);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 24387, 25260);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 24319, 25482);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 24319, 25482);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 25342, 25429);

                                        f_10315_25342_25428(diagnostics, ErrorCode.ERR_PatternWrongType, typeSyntax, inputType, patternType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 25451, 25463);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 24319, 25482);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 23504, 25497);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 23291, 25497);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22917, 25497);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22580, 25497);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 22443, 25497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 25513, 25526);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 22111, 25537);

                int
                f_10315_22319_22364(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22319, 22364);
                    return 0;
                }


                int
                f_10315_22379_22426(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22379, 22426);
                    return 0;
                }


                bool
                f_10315_22447_22470(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22447, 22470);
                    return return_v;
                }


                bool
                f_10315_22474_22499(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22474, 22499);
                    return return_v;
                }


                bool
                f_10315_22584_22622(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22584, 22622);
                    return return_v;
                }


                bool
                f_10315_22626_22666(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22626, 22666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_22832_22851(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 22832, 22851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_22772_22852(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22772, 22852);
                    return return_v;
                }


                bool
                f_10315_22921_22949(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 22921, 22949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_23186_23225(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23186, 23225);
                    return return_v;
                }


                int
                f_10315_23120_23226(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23120, 23226);
                    return 0;
                }


                int
                f_10315_23361_23439(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23361, 23439);
                    return 0;
                }


                bool
                f_10315_23508_23528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 23508, 23528);
                    return return_v;
                }


                int
                f_10315_23562_23641(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23562, 23641);
                    return 0;
                }


                bool
                f_10315_23742_23765(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23742, 23765);
                    return return_v;
                }


                int
                f_10315_23807_23871(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 23807, 23871);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10315_24093_24104()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 24093, 24104);
                    return return_v;
                }


                bool?
                f_10315_24036_24234(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.ConstantValue?
                operandConstantValue, bool
                operandCouldBeNull)
                {
                    var return_v = ExpressionOfTypeMatchesPatternType(conversions, expressionType, patternType, ref useSiteDiagnostics, out conversion, operandConstantValue: operandConstantValue, operandCouldBeNull: operandCouldBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24036, 24234);
                    return return_v;
                }


                bool
                f_10315_24253_24300(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24253, 24300);
                    return return_v;
                }


                bool
                f_10315_24391_24409_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 24391, 24409);
                    return return_v;
                }


                bool
                f_10315_24414_24447(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24414, 24447);
                    return return_v;
                }


                bool
                f_10315_24451_24486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24451, 24486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_24672_24733(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24672, 24733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_24782_24793()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 24782, 24793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_24782_24809(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 24782, 24809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_25036_25047()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 25036, 25047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_25036_25063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 25036, 25063);
                    return return_v;
                }


                string
                f_10315_25036_25081(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 25036, 25081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10315_25116_25166(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 25116, 25166);
                    return return_v;
                }


                int
                f_10315_24867_25167(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 24867, 25167);
                    return 0;
                }


                int
                f_10315_25342_25428(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 25342, 25428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 22111, 25537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 22111, 25537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool? ExpressionOfTypeMatchesPatternType(
                    Conversions conversions,
                    TypeSymbol expressionType,
                    TypeSymbol patternType,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics,
                    out Conversion conversion,
                    ConstantValue? operandConstantValue = null,
                    bool operandCouldBeNull = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 25906, 27518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26308, 26359);

                f_10315_26308_26358((object)expressionType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26515, 26699) || true) && (f_10315_26519_26587(expressionType, patternType, TypeCompareKind.AllIgnoreOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 26515, 26699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26621, 26654);

                    conversion = Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26672, 26684);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 26515, 26699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26715, 26974) || true) && (f_10315_26719_26745(expressionType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 26715, 26974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26877, 26959);

                    expressionType = f_10315_26894_26958(f_10315_26894_26916(conversions), SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 26715, 26974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 26990, 27094);

                conversion = f_10315_27003_27093(conversions, expressionType, patternType, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 27108, 27254);

                ConstantValue
                result = f_10315_27131_27253(expressionType, patternType, conversion.Kind, operandConstantValue, operandCouldBeNull)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 27268, 27507);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 27292, 27308) || (((result == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 27311, 27322)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 27342, 27506))) ? (bool?)null : (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 27342, 27372) || (((result == f_10315_27353_27371()) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 27375, 27379)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 27399, 27506))) ? true : (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 27399, 27430) || (((result == f_10315_27410_27429()) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 27433, 27438)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 27458, 27506))) ? false : throw f_10315_27464_27506(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 25906, 27518);

                int
                f_10315_26308_26358(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 26308, 26358);
                    return 0;
                }


                bool
                f_10315_26519_26587(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 26519, 26587);
                    return return_v;
                }


                bool
                f_10315_26719_26745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 26719, 26745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10315_26894_26916(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 26894, 26916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_26894_26958(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 26894, 26958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10315_27003_27093(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 27003, 27093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_27131_27253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind, Microsoft.CodeAnalysis.ConstantValue?
                operandConstantValue, bool
                operandCouldBeNull)
                {
                    var return_v = Binder.GetIsOperatorConstantResult(operandType, targetType, conversionKind, operandConstantValue, operandCouldBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 27131, 27253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_27353_27371()
                {
                    var return_v = ConstantValue.True;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 27353, 27371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_27410_27429()
                {
                    var return_v = ConstantValue.False;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 27410, 27429);
                    return return_v;
                }


                System.Exception
                f_10315_27464_27506(Microsoft.CodeAnalysis.ConstantValue
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 27464, 27506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 25906, 27518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 25906, 27518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindDeclarationPattern(
                    DeclarationPatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 27530, 28548);
                Microsoft.CodeAnalysis.CSharp.Symbol? variableSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbol?);
                Microsoft.CodeAnalysis.CSharp.BoundExpression? variableAccess = default(Microsoft.CodeAnalysis.CSharp.BoundExpression?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 27819, 27853);

                TypeSyntax
                typeSyntax = f_10315_27843_27852(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 27867, 27973);

                BoundTypeExpression
                boundDeclType = f_10315_27903_27972(this, typeSyntax, inputType, diagnostics, ref hasErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 27987, 28052);

                var
                valEscape = f_10315_28003_28051(f_10315_28016_28034(boundDeclType), inputValEscape)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28066, 28379);

                f_10315_28066_28378(this, designation: f_10315_28120_28136(node), declType: f_10315_28148_28181(boundDeclType), valEscape, permitDesignations, typeSyntax, diagnostics, hasErrors: ref hasErrors, variableSymbol: out variableSymbol, variableAccess: out variableAccess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28393, 28537);

                return f_10315_28400_28536(node, variableSymbol, variableAccess, boundDeclType, isVar: false, inputType, f_10315_28506_28524(boundDeclType), hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 27530, 28548);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10315_27843_27852(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 27843, 27852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10315_27903_27972(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindTypeForPattern(typeSyntax, inputType, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 27903, 27972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_28016_28034(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 28016, 28034);
                    return return_v;
                }


                uint
                f_10315_28003_28051(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28003, 28051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10315_28120_28136(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 28120, 28136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_28148_28181(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 28148, 28181);
                    return return_v;
                }


                int
                f_10315_28066_28378(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declType, uint
                inputValEscape, bool
                permitDesignations, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, out Microsoft.CodeAnalysis.CSharp.Symbol?
                variableSymbol, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess)
                {
                    this_param.BindPatternDesignation(designation: designation, declType: declType, inputValEscape, permitDesignations, typeSyntax, diagnostics, hasErrors: ref hasErrors, out variableSymbol, out variableAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28066, 28378);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_28506_28524(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 28506, 28524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                f_10315_28400_28536(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationPatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                declaredType, bool
                isVar, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, variable, variableAccess, declaredType, isVar: isVar, inputType, narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28400, 28536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 27530, 28548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 27530, 28548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundTypeExpression BindTypeForPattern(
                    TypeSyntax typeSyntax,
                    TypeSymbol inputType,
                    DiagnosticBag diagnostics,
                    ref bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 28560, 29249);
                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol aliasOpt = default(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28776, 28813);

                f_10315_28776_28812(inputType is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28827, 28918);

                TypeWithAnnotations
                declType = f_10315_28858_28917(this, typeSyntax, diagnostics, out aliasOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28932, 28963);

                f_10315_28932_28962(declType.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 28977, 29090);

                BoundTypeExpression
                boundDeclType = f_10315_29013_29089(typeSyntax, aliasOpt, typeWithAnnotations: declType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29104, 29203);

                hasErrors |= f_10315_29117_29202(this, typeSyntax, inputType, declType.Type, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29217, 29238);

                return boundDeclType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 28560, 29249);

                int
                f_10315_28776_28812(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28776, 28812);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_28858_28917(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, out alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28858, 28917);
                    return return_v;
                }


                int
                f_10315_28932_28962(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 28932, 28962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10315_29013_29089(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt, typeWithAnnotations: typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 29013, 29089);
                    return return_v;
                }


                bool
                f_10315_29117_29202(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValidPatternType((Microsoft.CodeAnalysis.SyntaxNode)typeSyntax, inputType, patternType, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 29117, 29202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 28560, 29249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 28560, 29249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BindPatternDesignation(
                    VariableDesignationSyntax? designation,
                    TypeWithAnnotations declType,
                    uint inputValEscape,
                    bool permitDesignations,
                    TypeSyntax? typeSyntax,
                    DiagnosticBag diagnostics,
                    ref bool hasErrors,
                    out Symbol? variableSymbol,
                    out BoundExpression? variableAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 29261, 33060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29691, 33049);

                switch (designation)
                {

                    case SingleVariableDesignationSyntax singleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 29691, 33049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29829, 29891);

                        SyntaxToken
                        identifier = f_10315_29854_29890(singleVariableDesignation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29913, 29974);

                        SourceLocalSymbol
                        localSymbol = f_10315_29945_29973(this, identifier)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 29998, 30165) || true) && (!permitDesignations && (DynAbs.Tracing.TraceSender.Expression_True(10315, 30002, 30046) && f_10315_30025_30046_M(!identifier.IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 29998, 30165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30073, 30165);

                            f_10315_30073_30164(diagnostics, ErrorCode.ERR_DesignatorBeneathPatternCombinator, identifier.GetLocation());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 29998, 30165);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30189, 32730) || true) && (localSymbol is { })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 30189, 32730);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30261, 30313);

                            f_10315_30261_30312(f_10315_30280_30304() is { });

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30339, 30613) || true) && ((f_10315_30344_30368() || (DynAbs.Tracing.TraceSender.Expression_False(10315, 30344, 30390) || f_10315_30372_30390())) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 30343, 30465) && f_10315_30395_30441(f_10315_30395_30436(f_10315_30395_30419())) == SymbolKind.NamedType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 30339, 30613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30496, 30613);

                                f_10315_30496_30612(designation, MessageID.IDS_FeatureExpressionVariablesInQueriesAndInitializers, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 30339, 30613);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30641, 30686);

                            f_10315_30641_30685(
                                                    localSymbol, declType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30712, 30782);

                            f_10315_30712_30781(localSymbol, f_10315_30737_30780(declType.Type, inputValEscape));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 30877, 30980);

                            hasErrors |= f_10315_30890_30979(f_10315_30890_30913(localSymbol), localSymbol, diagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31008, 31196) || true) && (!hasErrors)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 31008, 31196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31053, 31196);

                                hasErrors = f_10315_31065_31195(f_10315_31098_31127(this), declType.Type, diagnostics, typeSyntax ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?>(10315, 31157, 31194) ?? (SyntaxNode)designation));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 31008, 31196);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31224, 31253);

                            variableSymbol = localSymbol;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31279, 31568);

                            variableAccess = f_10315_31296_31567(syntax: designation, localSymbol: localSymbol, (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 31388, 31405) || ((f_10315_31388_31405(localSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 31408, 31450)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 31453, 31495))) ? BoundLocalDeclarationKind.WithInferredType : BoundLocalDeclarationKind.WithExplicitType, constantValueOpt: null, isNullableUnknown: false, type: declType.Type);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31594, 31601);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 30189, 32730);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 30189, 32730);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31838, 31914);

                            f_10315_31838_31913(f_10315_31851_31886(f_10315_31851_31881(f_10315_31851_31873(designation))) != SourceCodeKind.Regular);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 31940, 32038);

                            GlobalExpressionVariable
                            expressionVariableField = f_10315_31991_32037(this, singleVariableDesignation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32064, 32114);

                            var
                            tempDiagnostics = f_10315_32086_32113()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32140, 32214);

                            f_10315_32140_32213(expressionVariableField, declType, tempDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32240, 32263);

                            f_10315_32240_32262(tempDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32289, 32386);

                            BoundExpression
                            receiver = f_10315_32316_32385(this, designation, expressionVariableField, diagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32414, 32455);

                            variableSymbol = expressionVariableField;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32481, 32674);

                            variableAccess = f_10315_32498_32673(syntax: designation, receiver: receiver, fieldSymbol: expressionVariableField, constantValueOpt: null, hasErrors: hasErrors);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32700, 32707);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 30189, 32730);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 29691, 33049);

                    case DiscardDesignationSyntax _:
                    case null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 29691, 33049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32830, 32852);

                        variableSymbol = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32874, 32896);

                        variableAccess = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32918, 32925);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 29691, 33049);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 29691, 33049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 32973, 33034);

                        throw f_10315_32979_33033(f_10315_33014_33032(designation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 29691, 33049);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 29261, 33060);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10315_29854_29890(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 29854, 29890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10315_29945_29973(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                nameToken)
                {
                    var return_v = this_param.LookupLocal(nameToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 29945, 29973);
                    return return_v;
                }


                bool
                f_10315_30025_30046_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30025, 30046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_30073_30164(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30073, 30164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_30280_30304()
                {
                    var return_v = ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30280, 30304);
                    return return_v;
                }


                int
                f_10315_30261_30312(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30261, 30312);
                    return 0;
                }


                bool
                f_10315_30344_30368()
                {
                    var return_v = InConstructorInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30344, 30368);
                    return return_v;
                }


                bool
                f_10315_30372_30390()
                {
                    var return_v = InFieldInitializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30372, 30390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_30395_30419()
                {
                    var return_v = ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30395, 30419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_30395_30436(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30395, 30436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10315_30395_30441(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30395, 30441);
                    return return_v;
                }


                bool
                f_10315_30496_30612(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckFeatureAvailability((Microsoft.CodeAnalysis.SyntaxNode)syntax, feature, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30496, 30612);
                    return return_v;
                }


                int
                f_10315_30641_30685(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newType)
                {
                    this_param.SetTypeWithAnnotations(newType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30641, 30685);
                    return 0;
                }


                uint
                f_10315_30737_30780(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30737, 30780);
                    return return_v;
                }


                int
                f_10315_30712_30781(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, uint
                value)
                {
                    this_param.SetValEscape(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30712, 30781);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10315_30890_30913(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 30890, 30913);
                    return return_v;
                }


                bool
                f_10315_30890_30979(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 30890, 30979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_31098_31127(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 31098, 31127);
                    return return_v;
                }


                bool
                f_10315_31065_31195(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = CheckRestrictedTypeInAsyncMethod(containingSymbol, type, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 31065, 31195);
                    return return_v;
                }


                bool
                f_10315_31388_31405(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.IsVar;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 31388, 31405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10315_31296_31567(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                localSymbol, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, bool
                isNullableUnknown, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, localSymbol: (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)localSymbol, declarationKind, constantValueOpt: constantValueOpt, isNullableUnknown: isNullableUnknown, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 31296, 31567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10315_31851_31873(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 31851, 31873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10315_31851_31881(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 31851, 31881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10315_31851_31886(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 31851, 31886);
                    return return_v;
                }


                int
                f_10315_31838_31913(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 31838, 31913);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10315_31991_32037(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 31991, 32037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10315_32086_32113()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32086, 32113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_32140_32213(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SetTypeWithAnnotations(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32140, 32213);
                    return return_v;
                }


                int
                f_10315_32240_32262(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32240, 32262);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_32316_32385(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SynthesizeReceiver((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Symbol)member, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32316, 32385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10315_32498_32673(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, receiver: receiver, fieldSymbol: (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol, constantValueOpt: constantValueOpt, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32498, 32673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_33014_33032(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 33014, 33032);
                    return return_v;
                }


                System.Exception
                f_10315_32979_33033(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 32979, 33033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 29261, 33060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 29261, 33060);
            }
        }

        private static uint GetValEscape(TypeSymbol type, uint possibleValEscape)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 33478, 33656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 33576, 33645);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 33583, 33601) || ((f_10315_33583_33601(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 33604, 33621)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 33624, 33644))) ? possibleValEscape : Binder.ExternalScope;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 33478, 33656);

                bool
                f_10315_33583_33601(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsRefLikeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 33583, 33601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 33478, 33656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 33478, 33656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        TypeWithAnnotations BindRecursivePatternType(
                    TypeSyntax? typeSyntax,
                    TypeSymbol inputType,
                    DiagnosticBag diagnostics,
                    ref bool hasErrors,
                    out BoundTypeExpression? boundDeclType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 33668, 34485);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 33936, 34474) || true) && (typeSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 33936, 34474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 33992, 34078);

                    boundDeclType = f_10315_34008_34077(this, typeSyntax, inputType, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 34096, 34137);

                    return f_10315_34103_34136(boundDeclType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 33936, 34474);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 33936, 34474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 34203, 34224);

                    boundDeclType = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 34366, 34459);

                    return TypeWithAnnotations.Create(f_10315_34400_34424(inputType), NullableAnnotation.NotAnnotated);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 33936, 34474);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 33668, 34485);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10315_34008_34077(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindTypeForPattern(typeSyntax, inputType, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 34008, 34077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_34103_34136(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 34103, 34136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_34400_34424(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 34400, 34424);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 33668, 34485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 33668, 34485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsZeroElementTupleType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 34872, 35476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 34957, 35465);

                return f_10315_34964_34983(type) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35012) && f_10315_34987_34996(type) == "ValueTuple") && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35036) && f_10315_35016_35031(type) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35099) && f_10315_35057_35078(type) is var declContainer) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35145) && f_10315_35103_35121(declContainer) == SymbolKind.Namespace) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35179) && f_10315_35149_35167(declContainer) == "System") && (DynAbs.Tracing.TraceSender.Expression_True(10315, 34964, 35464) &&                // LAFHIS
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 //(declContainer.ContainingSymbol as NamespaceSymbol)?.IsGlobalNamespace == true
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10315, 35326, 35377) || (((f_10315_35327_35357(declContainer) is NamespaceSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 35380, 35455)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 35458, 35463))) ? f_10315_35380_35447(((NamespaceSymbol)f_10315_35398_35428(declContainer))) == true : false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 34872, 35476);

                bool
                f_10315_34964_34983(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 34964, 34983);
                    return return_v;
                }


                string
                f_10315_34987_34996(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 34987, 34996);
                    return return_v;
                }


                int
                f_10315_35016_35031(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 35016, 35031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_35057_35078(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35057, 35078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10315_35103_35121(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35103, 35121);
                    return return_v;
                }


                string
                f_10315_35149_35167(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35149, 35167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_35327_35357(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35327, 35357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10315_35398_35428(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35398, 35428);
                    return return_v;
                }


                bool
                f_10315_35380_35447(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35380, 35447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 34872, 35476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 34872, 35476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindRecursivePattern(
                    RecursivePatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 35488, 41349);
                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression? boundDeclType = default(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder> outPlaceholders = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>);
                bool anyDeconstructCandidates = default(bool);
                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol? iTupleType = default(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? iTupleGetLength = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? iTupleGetItem = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbol? variableSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbol?);
                Microsoft.CodeAnalysis.CSharp.BoundExpression? variableAccess = default(Microsoft.CodeAnalysis.CSharp.BoundExpression?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 35773, 36022) || true) && (f_10315_35777_35815(inputType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 35773, 36022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 35849, 35924);

                    f_10315_35849_35923(diagnostics, ErrorCode.ERR_PointerTypeInPatternMatching, f_10315_35909_35922(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 35942, 35959);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 35977, 36007);

                    inputType = f_10315_35989_36006(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 35773, 36022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36038, 36073);

                TypeSyntax?
                typeSyntax = f_10315_36063_36072(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36087, 36249);

                TypeWithAnnotations
                declTypeWithAnnotations = f_10315_36133_36248(this, typeSyntax, inputType, diagnostics, ref hasErrors, out boundDeclType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36263, 36314);

                TypeSymbol
                declType = declTypeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36328, 36384);

                inputValEscape = f_10315_36345_36383(declType, inputValEscape);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36400, 36439);

                MethodSymbol?
                deconstructMethod = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36453, 36521);

                ImmutableArray<BoundSubpattern>
                deconstructionSubpatterns = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36535, 40017) || true) && (f_10315_36539_36567(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 36535, 40017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36609, 36687);

                    PositionalPatternClauseSyntax
                    positionalClause = f_10315_36658_36686(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36705, 36805);

                    var
                    patternsBuilder = f_10315_36727_36804(positionalClause.Subpatterns.Count)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 36823, 39917) || true) && (f_10315_36827_36859(declType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 36823, 39917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 37304, 37508);

                        f_10315_37304_37507(this, positionalClause, declType, ImmutableArray<TypeWithAnnotations>.Empty, inputValEscape, permitDesignations, ref hasErrors, patternsBuilder, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 36823, 39917);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 36823, 39917);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 37550, 39917) || true) && (f_10315_37554_37574(declType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 37550, 39917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 37691, 37869);

                            f_10315_37691_37868(this, positionalClause, declType, f_10315_37745_37786(declType), inputValEscape, permitDesignations, ref hasErrors, patternsBuilder, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 37550, 39917);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 37550, 39917);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 38039, 38116);

                            var
                            inputPlaceholder = f_10315_38062_38115(positionalClause, declType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 38204, 38261);

                            var
                            deconstructDiagnostics = f_10315_38233_38260()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 38283, 38643);

                            BoundExpression
                            deconstruct = f_10315_38313_38642(this, positionalClause.Subpatterns.Count, inputPlaceholder, positionalClause, deconstructDiagnostics, outPlaceholders: out outPlaceholders, out anyDeconstructCandidates)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 38665, 39672) || true) && (!anyDeconstructCandidates && (DynAbs.Tracing.TraceSender.Expression_True(10315, 38669, 38854) && f_10315_38723_38854(this, node, declType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 38665, 39672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39107, 39137);

                                f_10315_39107_39136(                        // There was no Deconstruct, but the constraints for the use of ITuple are satisfied.
                                                                            // Use that and forget any errors from trying to bind Deconstruct.
                                                        deconstructDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39163, 39253);

                                f_10315_39163_39252(this, positionalClause, patternsBuilder, permitDesignations, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39279, 39344);

                                deconstructionSubpatterns = f_10315_39307_39343(patternsBuilder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39370, 39499);

                                return f_10315_39377_39498(node, iTupleGetLength, iTupleGetItem, deconstructionSubpatterns, inputType, iTupleType, hasErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 38665, 39672);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 38665, 39672);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39597, 39649);

                                f_10315_39597_39648(diagnostics, deconstructDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 38665, 39672);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39696, 39898);

                            deconstructMethod = f_10315_39716_39897(this, positionalClause, inputValEscape, permitDesignations, deconstruct, outPlaceholders, patternsBuilder, ref hasErrors, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 37550, 39917);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 36823, 39917);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 39937, 40002);

                    deconstructionSubpatterns = f_10315_39965_40001(patternsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 36535, 40017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40033, 40086);

                ImmutableArray<BoundSubpattern>
                properties = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40100, 40328) || true) && (f_10315_40104_40130(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 40100, 40328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40172, 40313);

                    properties = f_10315_40185_40312(this, f_10315_40211_40237(node), declType, inputValEscape, permitDesignations, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 40100, 40328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40344, 40586);

                f_10315_40344_40585(this, f_10315_40385_40401(node), declTypeWithAnnotations, inputValEscape, permitDesignations, typeSyntax, diagnostics, ref hasErrors, out variableSymbol, out variableAccess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40600, 40863);

                bool
                isExplicitNotNullTest =
                f_10315_40646_40662(node) is null && (DynAbs.Tracing.TraceSender.Expression_True(10315, 40646, 40712) && boundDeclType is null) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 40646, 40760) && properties.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 40646, 40806) && deconstructMethod is null) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 40646, 40862) && deconstructionSubpatterns.IsDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 40877, 41338);

                return f_10315_40884_41337(syntax: node, declaredType: boundDeclType, deconstructMethod: deconstructMethod, deconstruction: deconstructionSubpatterns, properties: properties, variable: variableSymbol, variableAccess: variableAccess, isExplicitNotNullTest: isExplicitNotNullTest, inputType: inputType, narrowedType: f_10315_41267_41286_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(boundDeclType, 10315, 41267, 41286)?.Type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10315, 41267, 41314) ?? f_10315_41290_41314(inputType)), hasErrors: hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 35488, 41349);

                bool
                f_10315_35777_35815(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 35777, 35815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_35909_35922(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 35909, 35922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_35849_35923(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 35849, 35923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_35989_36006(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 35989, 36006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10315_36063_36072(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 36063, 36072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_36133_36248(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, out Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                boundDeclType)
                {
                    var return_v = this_param.BindRecursivePatternType(typeSyntax, inputType, diagnostics, ref hasErrors, out boundDeclType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 36133, 36248);
                    return return_v;
                }


                uint
                f_10315_36345_36383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 36345, 36383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax?
                f_10315_36539_36567(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PositionalPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 36539, 36567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                f_10315_36658_36686(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PositionalPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 36658, 36686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_36727_36804(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSubpattern>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 36727, 36804);
                    return return_v;
                }


                bool
                f_10315_36827_36859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsZeroElementTupleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 36827, 36859);
                    return return_v;
                }


                int
                f_10315_37304_37507(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                declType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, uint
                inputValEscape, bool
                permitDesignations, ref bool
                hasErrors, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                patterns, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindValueTupleSubpatterns(node, declType, elementTypesWithAnnotations, inputValEscape, permitDesignations, ref hasErrors, patterns, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 37304, 37507);
                    return 0;
                }


                bool
                f_10315_37554_37574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 37554, 37574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10315_37745_37786(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 37745, 37786);
                    return return_v;
                }


                int
                f_10315_37691_37868(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                declType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, uint
                inputValEscape, bool
                permitDesignations, ref bool
                hasErrors, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                patterns, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindValueTupleSubpatterns(node, declType, elementTypesWithAnnotations, inputValEscape, permitDesignations, ref hasErrors, patterns, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 37691, 37868);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                f_10315_38062_38115(Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 38062, 38115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10315_38233_38260()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 38233, 38260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_38313_38642(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                numCheckedVariables, Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                receiver, Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                rightSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, out bool
                anyApplicableCandidates)
                {
                    var return_v = this_param.MakeDeconstructInvocationExpression(numCheckedVariables, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.SyntaxNode)rightSyntax, diagnostics, out outPlaceholders, out anyApplicableCandidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 38313, 38642);
                    return return_v;
                }


                bool
                f_10315_38723_38854(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                declType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                iTupleType, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetLength, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetItem)
                {
                    var return_v = this_param.ShouldUseITupleForRecursivePattern(node, declType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 38723, 38854);
                    return return_v;
                }


                int
                f_10315_39107_39136(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39107, 39136);
                    return 0;
                }


                int
                f_10315_39163_39252(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                patterns, bool
                permitDesignations, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindITupleSubpatterns(node, patterns, permitDesignations, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39163, 39252);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_39307_39343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39307, 39343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                f_10315_39377_39498(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getLengthMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getItemMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                subpatterns, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundITuplePattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, getLengthMethod, getItemMethod, subpatterns, inputType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39377, 39498);
                    return return_v;
                }


                int
                f_10315_39597_39648(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39597, 39648);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10315_39716_39897(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                node, uint
                inputValEscape, bool
                permitDesignations, Microsoft.CodeAnalysis.CSharp.BoundExpression
                deconstruct, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                patterns, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeconstructSubpatterns(node, inputValEscape, permitDesignations, deconstruct, outPlaceholders, patterns, ref hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39716, 39897);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_39965_40001(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 39965, 40001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PropertyPatternClauseSyntax?
                f_10315_40104_40130(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PropertyPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 40104, 40130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PropertyPatternClauseSyntax
                f_10315_40211_40237(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PropertyPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 40211, 40237);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_40185_40312(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyPatternClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindPropertyPatternClause(node, inputType, inputValEscape, permitDesignations, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 40185, 40312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10315_40385_40401(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 40385, 40401);
                    return return_v;
                }


                int
                f_10315_40344_40585(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                designation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declType, uint
                inputValEscape, bool
                permitDesignations, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, out Microsoft.CodeAnalysis.CSharp.Symbol?
                variableSymbol, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess)
                {
                    this_param.BindPatternDesignation(designation, declType, inputValEscape, permitDesignations, typeSyntax, diagnostics, ref hasErrors, out variableSymbol, out variableAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 40344, 40585);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10315_40646_40662(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 40646, 40662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_41267_41286_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 41267, 41286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_41290_41314(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 41290, 41314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                f_10315_40884_41337(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                declaredType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                deconstructMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                deconstruction, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                properties, Microsoft.CodeAnalysis.CSharp.Symbol?
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess, bool
                isExplicitNotNullTest, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, declaredType: declaredType, deconstructMethod: deconstructMethod, deconstruction: deconstruction, properties: properties, variable: variable, variableAccess: variableAccess, isExplicitNotNullTest: isExplicitNotNullTest, inputType: inputType, narrowedType: narrowedType, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 40884, 41337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 35488, 41349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 35488, 41349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol? BindDeconstructSubpatterns(
                    PositionalPatternClauseSyntax node,
                    uint inputValEscape,
                    bool permitDesignations,
                    BoundExpression deconstruct,
                    ImmutableArray<BoundDeconstructValuePlaceholder> outPlaceholders,
                    ArrayBuilder<BoundSubpattern> patterns,
                    ref bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 41361, 43758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 41803, 41872);

                var
                deconstructMethod = f_10315_41827_41855(deconstruct) as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 41886, 41951) || true) && (deconstructMethod is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 41886, 41951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 41934, 41951);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 41886, 41951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 41967, 42053);

                int
                skippedExtensionParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 42000, 42044) || ((f_10315_42000_42036_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(deconstructMethod, 10315, 42000, 42036)?.IsExtensionMethod) == true && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 42047, 42048)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 42051, 42052))) ? 1 : 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42076, 42081);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42067, 43706) || true) && (i < node.Subpatterns.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42111, 42114)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 42067, 43706))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 42067, 43706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42148, 42185);

                        var
                        subPattern = f_10315_42165_42181(node)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42203, 42295);

                        bool
                        isError = hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10315, 42218, 42263) || outPlaceholders.IsDefaultOrEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 42218, 42294) || i >= outPlaceholders.Length)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42313, 42392);

                        TypeSymbol
                        elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 42338, 42345) || ((isError && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 42348, 42365)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 42368, 42391))) ? f_10315_42348_42365(this) : f_10315_42368_42391(outPlaceholders[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42410, 42444);

                        ParameterSymbol?
                        parameter = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42462, 43341) || true) && (f_10315_42466_42486(subPattern) != null && (DynAbs.Tracing.TraceSender.Expression_True(10315, 42466, 42506) && !isError))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 42462, 43341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42656, 42708);

                            int
                            parameterIndex = i + skippedExtensionParameters
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42730, 43322) || true) && (parameterIndex < f_10315_42751_42784(deconstructMethod!))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 42730, 43322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42834, 42891);

                                parameter = f_10315_42846_42874(deconstructMethod)[parameterIndex];
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 42917, 42978);

                                string
                                name = f_10315_42931_42956(f_10315_42931_42951(subPattern)).Identifier.ValueText
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43004, 43042);

                                string
                                parameterName = f_10315_43027_43041(parameter)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43068, 43299) || true) && (name != parameterName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 43068, 43299);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43151, 43272);

                                    f_10315_43151_43271(diagnostics, ErrorCode.ERR_DeconstructParameterNameMismatch, f_10315_43215_43249(f_10315_43215_43240(f_10315_43215_43235(subPattern))), name, parameterName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 43068, 43299);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 42730, 43322);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 42462, 43341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43361, 43643);

                        var
                        boundSubpattern = f_10315_43383_43642(subPattern, parameter, f_10315_43490_43619(this, f_10315_43502_43520(subPattern), elementType, f_10315_43535_43576(elementType, inputValEscape), permitDesignations, isError, diagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43661, 43691);

                        f_10315_43661_43690(patterns, boundSubpattern);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 1640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 1640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 43722, 43747);

                return deconstructMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 41361, 43758);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_41827_41855(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ExpressionSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 41827, 41855);
                    return return_v;
                }


                bool?
                f_10315_42000_42036_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42000, 42036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_42165_42181(Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42165, 42181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_42348_42365(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 42348, 42365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_42368_42391(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42368, 42391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10315_42466_42486(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42466, 42486);
                    return return_v;
                }


                int
                f_10315_42751_42784(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42751, 42784);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10315_42846_42874(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42846, 42874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10315_42931_42951(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42931, 42951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10315_42931_42956(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 42931, 42956);
                    return return_v;
                }


                string
                f_10315_43027_43041(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 43027, 43041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10315_43215_43235(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 43215, 43235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10315_43215_43240(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 43215, 43240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_43215_43249(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 43215, 43249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_43151_43271(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 43151, 43271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_43502_43520(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 43502, 43520);
                    return return_v;
                }


                uint
                f_10315_43535_43576(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 43535, 43576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_43490_43619(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 43490, 43619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_43383_43642(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 43383, 43642);
                    return return_v;
                }


                int
                f_10315_43661_43690(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 43661, 43690);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 41361, 43758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 41361, 43758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BindITupleSubpatterns(
                    PositionalPatternClauseSyntax node,
                    ArrayBuilder<BoundSubpattern> patterns,
                    bool permitDesignations,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 43770, 44922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44089, 44133);

                const uint
                valEscape = Binder.ExternalScope
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44147, 44218);

                var
                objectType = f_10315_44164_44217(f_10315_44164_44175(), SpecialType.System_Object)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44232, 44911);
                    foreach (var subpatternSyntax in f_10315_44265_44281_I(f_10315_44265_44281(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 44232, 44911);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44315, 44585) || true) && (f_10315_44319_44345(subpatternSyntax) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 44315, 44585);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44470, 44566);

                            f_10315_44470_44565(                    // error: name not permitted in ITuple deconstruction
                                                diagnostics, ErrorCode.ERR_ArgumentNameInITuplePattern, f_10315_44529_44564(f_10315_44529_44555(subpatternSyntax)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 44315, 44585);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44605, 44848);

                        var
                        boundSubpattern = f_10315_44627_44847(subpatternSyntax, null, f_10315_44735_44846(this, f_10315_44747_44771(subpatternSyntax), objectType, valEscape, permitDesignations, hasErrors: false, diagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 44866, 44896);

                        f_10315_44866_44895(patterns, boundSubpattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 44232, 44911);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 680);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 43770, 44922);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_44164_44175()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44164, 44175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_44164_44217(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44164, 44217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_44265_44281(Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44265, 44281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10315_44319_44345(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44319, 44345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10315_44529_44555(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44529, 44555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_44529_44564(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44529, 44564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_44470_44565(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44470, 44565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_44747_44771(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 44747, 44771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_44735_44846(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)inputType, inputValEscape, permitDesignations, hasErrors: hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44735, 44846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_44627_44847(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44627, 44847);
                    return return_v;
                }


                int
                f_10315_44866_44895(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44866, 44895);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_44265_44281_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 44265, 44281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 43770, 44922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 43770, 44922);
            }
        }

        private void BindITupleSubpatterns(
                    ParenthesizedVariableDesignationSyntax node,
                    ArrayBuilder<BoundSubpattern> patterns,
                    bool permitDesignations,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 44934, 45827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45262, 45306);

                const uint
                valEscape = Binder.ExternalScope
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45320, 45391);

                var
                objectType = f_10315_45337_45390(f_10315_45337_45348(), SpecialType.System_Object)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45405, 45816);
                    foreach (var variable in f_10315_45430_45444_I(f_10315_45430_45444(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 45405, 45816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45478, 45604);

                        BoundPattern
                        pattern = f_10315_45501_45603(this, variable, objectType, valEscape, permitDesignations, hasErrors: false, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45622, 45753);

                        var
                        boundSubpattern = f_10315_45644_45752(variable, null, pattern)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 45771, 45801);

                        f_10315_45771_45800(patterns, boundSubpattern);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 45405, 45816);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 412);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 44934, 45827);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_45337_45348()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 45337, 45348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_45337_45390(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 45337, 45390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10315_45430_45444(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 45430, 45444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_45501_45603(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindVarDesignation(node, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)inputType, inputValEscape, permitDesignations, hasErrors: hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 45501, 45603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_45644_45752(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 45644, 45752);
                    return return_v;
                }


                int
                f_10315_45771_45800(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 45771, 45800);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10315_45430_45444_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 45430, 45444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 44934, 45827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 44934, 45827);
            }
        }

        private void BindValueTupleSubpatterns(
                    PositionalPatternClauseSyntax node,
                    TypeSymbol declType,
                    ImmutableArray<TypeWithAnnotations> elementTypesWithAnnotations,
                    uint inputValEscape,
                    bool permitDesignations,
                    ref bool hasErrors,
                    ArrayBuilder<BoundSubpattern> patterns,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 45839, 47648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46262, 46565) || true) && (elementTypesWithAnnotations.Length != node.Subpatterns.Count && (DynAbs.Tracing.TraceSender.Expression_True(10315, 46266, 46340) && !hasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 46262, 46565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46374, 46515);

                    f_10315_46374_46514(diagnostics, ErrorCode.ERR_WrongNumberOfSubpatterns, f_10315_46430_46443(node), declType, elementTypesWithAnnotations.Length, node.Subpatterns.Count);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46533, 46550);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 46262, 46565);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46590, 46595);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46581, 47637) || true) && (i < node.Subpatterns.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46625, 46628)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 46581, 47637))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 46581, 47637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46662, 46705);

                        var
                        subpatternSyntax = f_10315_46685_46701(node)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46723, 46778);

                        bool
                        isError = i >= elementTypesWithAnnotations.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46796, 46887);

                        TypeSymbol
                        elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 46821, 46828) || ((isError && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 46831, 46848)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 46851, 46886))) ? f_10315_46831_46848(this) : elementTypesWithAnnotations[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46905, 46936);

                        FieldSymbol?
                        foundField = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 46954, 47269) || true) && (f_10315_46958_46984(subpatternSyntax) != null && (DynAbs.Tracing.TraceSender.Expression_True(10315, 46958, 47004) && !isError))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 46954, 47269);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 47046, 47113);

                            string
                            name = f_10315_47060_47091(f_10315_47060_47086(subpatternSyntax)).Identifier.ValueText
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 47135, 47250);

                            foundField = f_10315_47148_47249(f_10315_47168_47199(f_10315_47168_47194(subpatternSyntax)), declType, name, i, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 46954, 47269);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 47289, 47574);

                        BoundSubpattern
                        boundSubpattern = f_10315_47323_47573(subpatternSyntax, foundField, f_10315_47437_47572(this, f_10315_47449_47473(subpatternSyntax), elementType, f_10315_47488_47529(elementType, inputValEscape), permitDesignations, isError, diagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 47592, 47622);

                        f_10315_47592_47621(patterns, boundSubpattern);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 1057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 1057);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 45839, 47648);

                Microsoft.CodeAnalysis.Location
                f_10315_46430_46443(Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 46430, 46443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_46374_46514(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 46374, 46514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_46685_46701(Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 46685, 46701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_46831_46848(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 46831, 46848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10315_46958_46984(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 46958, 46984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10315_47060_47086(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 47060, 47086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10315_47060_47091(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 47060, 47091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10315_47168_47194(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 47168, 47194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10315_47168_47199(Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 47168, 47199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10315_47148_47249(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                tupleType, string
                name, int
                tupleIndex, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = CheckIsTupleElement((Microsoft.CodeAnalysis.SyntaxNode)node, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)tupleType, name, tupleIndex, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 47148, 47249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_47449_47473(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 47449, 47473);
                    return return_v;
                }


                uint
                f_10315_47488_47529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 47488, 47529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_47437_47572(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 47437, 47572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_47323_47573(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbol?)symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 47323, 47573);
                    return return_v;
                }


                int
                f_10315_47592_47621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 47592, 47621);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 45839, 47648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 45839, 47648);
            }
        }

        private bool ShouldUseITupleForRecursivePattern(
                    RecursivePatternSyntax node,
                    TypeSymbol declType,
                    DiagnosticBag diagnostics,
                    [NotNullWhen(true)] out NamedTypeSymbol? iTupleType,
                    [NotNullWhen(true)] out MethodSymbol? iTupleGetLength,
                    [NotNullWhen(true)] out MethodSymbol? iTupleGetItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 47660, 49194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48049, 48067);

                iTupleType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48081, 48120);

                iTupleGetLength = iTupleGetItem = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48134, 48298) || true) && (f_10315_48138_48147(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 48134, 48298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48270, 48283);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 48134, 48298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48314, 48501) || true) && (f_10315_48318_48344(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 48314, 48501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48473, 48486);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 48314, 48501);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48517, 48796) || true) && (f_10315_48521_48549(node) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 48517, 48796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48768, 48781);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 48517, 48796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 48812, 49059) || true) && (f_10315_48816_48840_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10315_48816_48832(node), 10315, 48816, 48840).Kind()) == SyntaxKind.SingleVariableDesignation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 48812, 49059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49031, 49044);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 48812, 49059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49075, 49183);

                return f_10315_49082_49182(this, node, declType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 47660, 49194);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10315_48138_48147(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 48138, 48147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PropertyPatternClauseSyntax?
                f_10315_48318_48344(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PropertyPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 48318, 48344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PositionalPatternClauseSyntax?
                f_10315_48521_48549(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.PositionalPatternClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 48521, 48549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax?
                f_10315_48816_48832(Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 48816, 48832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10315_48816_48840_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 48816, 48840);
                    return return_v;
                }


                bool
                f_10315_49082_49182(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecursivePatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                declType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                iTupleType, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetLength, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetItem)
                {
                    var return_v = this_param.ShouldUseITuple((Microsoft.CodeAnalysis.SyntaxNode)node, declType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49082, 49182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 47660, 49194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 47660, 49194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ShouldUseITuple(
                    SyntaxNode node,
                    TypeSymbol declType,
                    DiagnosticBag diagnostics,
                    [NotNullWhen(true)] out NamedTypeSymbol? iTupleType,
                    [NotNullWhen(true)] out MethodSymbol? iTupleGetLength,
                    [NotNullWhen(true)] out MethodSymbol? iTupleGetItem)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 49206, 51860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49564, 49582);

                iTupleType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49596, 49635);

                iTupleGetLength = iTupleGetItem = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49649, 49685);

                f_10315_49649_49684(f_10315_49662_49683_M(!declType.IsTupleType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49699, 49747);

                f_10315_49699_49746(!f_10315_49713_49745(declType));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49763, 49915) || true) && (f_10315_49767_49794(f_10315_49767_49778()) < f_10315_49797_49853(MessageID.IDS_FeatureRecursivePatterns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 49763, 49915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49887, 49900);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 49763, 49915);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 49931, 50027);

                iTupleType = f_10315_49944_50026(f_10315_49944_49955(), WellKnownType.System_Runtime_CompilerServices_ITuple);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 50041, 50290) || true) && (f_10315_50045_50064(iTupleType) != TypeKind.Interface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 50041, 50290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 50262, 50275);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 50041, 50290);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 50472, 50786) || true) && (declType != (object)f_10315_50496_50549(f_10315_50496_50507(), SpecialType.System_Object) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 50476, 50613) && declType != (object)f_10315_50590_50613(f_10315_50590_50601())) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 50476, 50664) && declType != (object)iTupleType) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 50476, 50724) && !f_10315_50686_50724(declType, iTupleType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 50472, 50786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 50758, 50771);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 50472, 50786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 50857, 50993);

                iTupleGetLength = (MethodSymbol?)f_10315_50890_50992(f_10315_50890_50901(), WellKnownMember.System_Runtime_CompilerServices_ITuple__get_Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51007, 51139);

                iTupleGetItem = (MethodSymbol?)f_10315_51038_51138(f_10315_51038_51049(), WellKnownMember.System_Runtime_CompilerServices_ITuple__get_Item);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51153, 51332) || true) && (iTupleGetLength is null || (DynAbs.Tracing.TraceSender.Expression_False(10315, 51157, 51205) || iTupleGetItem is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 51153, 51332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51304, 51317);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 51153, 51332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51408, 51420);

                return true;

                bool hasBaseInterface(TypeSymbol type, NamedTypeSymbol possibleBaseInterface)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 51436, 51849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51546, 51597);

                        HashSet<DiagnosticInfo>?
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51615, 51742);

                        var
                        result = f_10315_51628_51730(f_10315_51628_51651(f_10315_51628_51639()), type, possibleBaseInterface, ref useSiteDiagnostics).IsImplicit
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51760, 51802);

                        f_10315_51760_51801(diagnostics, node, useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 51820, 51834);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 51436, 51849);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10315_51628_51639()
                        {
                            var return_v = Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 51628, 51639);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversions
                        f_10315_51628_51651(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Conversions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 51628, 51651);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Conversion
                        f_10315_51628_51730(Microsoft.CodeAnalysis.CSharp.Conversions
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.ClassifyBuiltInConversion(source, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 51628, 51730);
                            return return_v;
                        }


                        bool
                        f_10315_51760_51801(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                        node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = diagnostics.Add(node, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 51760, 51801);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 51436, 51849);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 51436, 51849);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 49206, 51860);

                bool
                f_10315_49662_49683_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 49662, 49683);
                    return return_v;
                }


                int
                f_10315_49649_49684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49649, 49684);
                    return 0;
                }


                bool
                f_10315_49713_49745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsZeroElementTupleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49713, 49745);
                    return return_v;
                }


                int
                f_10315_49699_49746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49699, 49746);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_49767_49778()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 49767, 49778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_49767_49794(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 49767, 49794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_49797_49853(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49797, 49853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_49944_49955()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 49944, 49955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_49944_50026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 49944, 50026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10315_50045_50064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 50045, 50064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_50496_50507()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 50496, 50507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_50496_50549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 50496, 50549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_50590_50601()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 50590, 50601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_50590_50613(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 50590, 50613);
                    return return_v;
                }


                bool
                f_10315_50686_50724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                possibleBaseInterface)
                {
                    var return_v = hasBaseInterface(type, possibleBaseInterface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 50686, 50724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_50890_50901()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 50890, 50901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_50890_50992(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 50890, 50992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_51038_51049()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 51038, 51049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_51038_51138(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 51038, 51138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 49206, 51860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 49206, 51860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FieldSymbol? CheckIsTupleElement(SyntaxNode node, NamedTypeSymbol tupleType, string name, int tupleIndex, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 52030, 52800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52202, 52235);

                FieldSymbol?
                foundElement = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52249, 52514);
                    foreach (var symbol in f_10315_52272_52298_I(f_10315_52272_52298(tupleType, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 52249, 52514);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52332, 52499) || true) && (symbol is FieldSymbol field && (DynAbs.Tracing.TraceSender.Expression_True(10315, 52336, 52389) && f_10315_52367_52389(field)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 52332, 52499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52431, 52452);

                            foundElement = field;
                            DynAbs.Tracing.TraceSender.TraceBreak(10315, 52474, 52480);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 52332, 52499);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 52249, 52514);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 266);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52530, 52753) || true) && (foundElement is null || (DynAbs.Tracing.TraceSender.Expression_False(10315, 52534, 52602) || f_10315_52558_52588(foundElement) != tupleIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 52530, 52753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52636, 52738);

                    f_10315_52636_52737(diagnostics, ErrorCode.ERR_TupleElementNameMismatch, f_10315_52692_52705(node), name, $"Item{tupleIndex + 1}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 52530, 52753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 52769, 52789);

                return foundElement;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 52030, 52800);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10315_52272_52298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 52272, 52298);
                    return return_v;
                }


                bool
                f_10315_52367_52389(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 52367, 52389);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10315_52272_52298_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 52272, 52298);
                    return return_v;
                }


                int
                f_10315_52558_52588(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 52558, 52588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_52692_52705(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 52692, 52705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_52636_52737(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 52636, 52737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 52030, 52800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 52030, 52800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindVarPattern(
                    VarPatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 52812, 54155);
                bool isVar = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53085, 53548) || true) && ((f_10315_53090_53128(inputType) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 53090, 53202) && f_10315_53132_53155(f_10315_53132_53148(node)) == SyntaxKind.ParenthesizedVariableDesignation))
                || (DynAbs.Tracing.TraceSender.Expression_False(10315, 53089, 53341) || (f_10315_53225_53250(inputType) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 53225, 53340) && f_10315_53254_53281(f_10315_53254_53265()) < f_10315_53284_53340(MessageID.IDS_FeatureRecursivePatterns)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 53085, 53548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53375, 53450);

                    f_10315_53375_53449(diagnostics, ErrorCode.ERR_PointerTypeInPatternMatching, f_10315_53435_53448(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53468, 53485);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53503, 53533);

                    inputType = f_10315_53515_53532(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 53085, 53548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53564, 53596);

                TypeSymbol
                declType = inputType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53610, 53715);

                Symbol
                foundSymbol = f_10315_53631_53707(this, f_10315_53656_53671(node), node, diagnostics, out isVar).Symbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53729, 54013) || true) && (!isVar)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 53729, 54013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53850, 53963);

                    f_10315_53850_53962(                // Give an error if there is a bindable type "var" in scope
                                    diagnostics, ErrorCode.ERR_VarMayNotBindToType, node.VarKeyword.GetLocation(), f_10315_53932_53961(foundSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 53981, 53998);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 53729, 54013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 54029, 54144);

                return f_10315_54036_54143(this, f_10315_54055_54071(node), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 52812, 54155);

                bool
                f_10315_53090_53128(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53090, 53128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10315_53132_53148(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 53132, 53148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_53132_53155(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53132, 53155);
                    return return_v;
                }


                bool
                f_10315_53225_53250(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53225, 53250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_53254_53265()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 53254, 53265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_53254_53281(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 53254, 53281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10315_53284_53340(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53284, 53340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_53435_53448(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 53435, 53448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_53375_53449(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53375, 53449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_53515_53532(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53515, 53532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10315_53656_53671(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.VarKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 53656, 53671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10315_53631_53707(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                identifier, Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out bool
                isKeyword)
                {
                    var return_v = this_param.BindTypeOrAliasOrKeyword(identifier, (Microsoft.CodeAnalysis.SyntaxNode)syntax, diagnostics, out isKeyword);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53631, 53707);
                    return return_v;
                }


                string
                f_10315_53932_53961(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53932, 53961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_53850_53962(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 53850, 53962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10315_54055_54071(Microsoft.CodeAnalysis.CSharp.Syntax.VarPatternSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 54055, 54071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_54036_54143(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindVarDesignation(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 54036, 54143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 52812, 54155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 52812, 54155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindVarDesignation(
                    VariableDesignationSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 54167, 62389);
                Microsoft.CodeAnalysis.CSharp.Symbol? variableSymbol = default(Microsoft.CodeAnalysis.CSharp.Symbol?);
                Microsoft.CodeAnalysis.CSharp.BoundExpression? variableAccess = default(Microsoft.CodeAnalysis.CSharp.BoundExpression?);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder> outPlaceholders = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>);
                bool anyDeconstructCandidates = default(bool);
                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol? iTupleType = default(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? iTupleGetLength = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol? iTupleGetItem = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 54453, 62378);

                switch (f_10315_54461_54472(node))
                {

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 54453, 62378);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 54590, 54674);

                            return f_10315_54597_54673(node, inputType: inputType, narrowedType: inputType);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 54453, 62378);

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 54453, 62378);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 54806, 54889);

                            var
                            declType = TypeWithState.ForType(inputType).ToTypeWithAnnotations(f_10315_54876_54887())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 54915, 55304);

                            f_10315_54915_55303(this, designation: node, declType: declType, inputValEscape: inputValEscape, permitDesignations: permitDesignations, typeSyntax: null, diagnostics: diagnostics, hasErrors: ref hasErrors, variableSymbol: out variableSymbol, variableAccess: out variableAccess);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 55330, 55438);

                            var
                            boundOperandType = f_10315_55353_55437(syntax: node, aliasOpt: null, typeWithAnnotations: declType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 55637, 55670);

                            f_10315_55637_55669(f_10315_55650_55661(node) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 55696, 56092);

                            return f_10315_55703_56091((DynAbs.Tracing.TraceSender.Conditional_F1(10315, 55761, 55804) || ((f_10315_55761_55779(f_10315_55761_55772(node)) == SyntaxKind.VarPattern && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 55807, 55818)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 55821, 55825))) ? f_10315_55807_55818(node) : node, variableSymbol, variableAccess, boundOperandType, isVar: true, inputType: inputType, narrowedType: inputType, hasErrors: hasErrors);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 54453, 62378);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 54453, 62378);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 56231, 56299);

                            var
                            tupleDesignation = (ParenthesizedVariableDesignationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 56325, 56419);

                            var
                            subPatterns = f_10315_56343_56418(tupleDesignation.Variables.Count)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 56445, 56484);

                            MethodSymbol?
                            deconstructMethod = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 56510, 56559);

                            var
                            strippedInputType = f_10315_56534_56558(inputType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 56587, 60439) || true) && (f_10315_56591_56632(strippedInputType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 56587, 60439);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57117, 57183);

                                f_10315_57117_57182(ImmutableArray<TypeWithAnnotations>.Empty);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 56587, 60439);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 56587, 60439);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57241, 60439) || true) && (f_10315_57245_57274(strippedInputType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 57241, 60439);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57415, 57490);

                                    f_10315_57415_57489(f_10315_57438_57488(strippedInputType));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 57241, 60439);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 57241, 60439);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57700, 57774);

                                    var
                                    inputPlaceholder = f_10315_57723_57773(node, strippedInputType)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57870, 57927);

                                    var
                                    deconstructDiagnostics = f_10315_57899_57926()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 57957, 58327);

                                    BoundExpression
                                    deconstruct = f_10315_57987_58326(this, tupleDesignation.Variables.Count, inputPlaceholder, node, deconstructDiagnostics, outPlaceholders: out outPlaceholders, out anyDeconstructCandidates)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 58357, 59391) || true) && (!anyDeconstructCandidates && (DynAbs.Tracing.TraceSender.Expression_True(10315, 58361, 58544) && f_10315_58423_58544(this, node, strippedInputType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 58357, 59391);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 58850, 58880);

                                        f_10315_58850_58879(                                // There was no applicable candidate Deconstruct, and the constraints for the use of ITuple are satisfied.
                                                                                            // Use that and forget any errors from trying to bind Deconstruct.
                                                                        deconstructDiagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 58914, 59000);

                                        f_10315_58914_58999(this, tupleDesignation, subPatterns, permitDesignations, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59034, 59178);

                                        return f_10315_59041_59177(node, iTupleGetLength, iTupleGetItem, f_10315_59102_59134(subPatterns), strippedInputType, iTupleType, hasErrors);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 58357, 59391);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 58357, 59391);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59308, 59360);

                                        f_10315_59308_59359(diagnostics, deconstructDiagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 58357, 59391);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59423, 59488);

                                    deconstructMethod = f_10315_59443_59471(deconstruct) as MethodSymbol;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59518, 59667) || true) && (!hasErrors)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 59518, 59667);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59567, 59667);

                                        hasErrors = outPlaceholders.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10315, 59579, 59666) || tupleDesignation.Variables.Count != outPlaceholders.Length);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 59518, 59667);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59708, 59713);

                                        for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59699, 60412) || true) && (i < tupleDesignation.Variables.Count)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59753, 59756)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 59699, 60412))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 59699, 60412);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59822, 59867);

                                            var
                                            variable = f_10315_59837_59863(tupleDesignation)[i]
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 59901, 59980);

                                            bool
                                            isError = outPlaceholders.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10315, 59916, 59979) || i >= outPlaceholders.Length)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 60014, 60093);

                                            TypeSymbol
                                            elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 60039, 60046) || ((isError && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 60049, 60066)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 60069, 60092))) ? f_10315_60049_60066(this) : f_10315_60069_60092(outPlaceholders[i])
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 60127, 60277);

                                            BoundPattern
                                            pattern = f_10315_60150_60276(this, variable, elementType, f_10315_60192_60233(elementType, inputValEscape), permitDesignations, isError, diagnostics)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 60311, 60381);

                                            f_10315_60311_60380(subPatterns, f_10315_60327_60379(variable, symbol: null, pattern));
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 714);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 714);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 57241, 60439);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 56587, 60439);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 60467, 60883);

                            return f_10315_60474_60882(syntax: node, declaredType: null, deconstructMethod: deconstructMethod, deconstruction: f_10315_60647_60679(subPatterns), properties: default, variable: null, variableAccess: null, isExplicitNotNullTest: false, inputType: inputType, narrowedType: f_10315_60835_60859(inputType), hasErrors: hasErrors);


                            int
                            f_10315_57415_57489(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            elementTypes)
                            {
                                addSubpatternsForTuple(elementTypes);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 57415, 57489);
                                return 0;
                            }

                            int
                            f_10315_57117_57182(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                            elementTypes)
                            {
                                addSubpatternsForTuple(elementTypes);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 57117, 57182);
                                return 0;
                            }

                            void addSubpatternsForTuple(ImmutableArray<TypeWithAnnotations> elementTypes)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 60911, 62188);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61045, 61460) || true) && (elementTypes.Length != tupleDesignation.Variables.Count && (DynAbs.Tracing.TraceSender.Expression_True(10315, 61049, 61118) && !hasErrors))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 61045, 61460);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61184, 61378);

                                        f_10315_61184_61377(diagnostics, ErrorCode.ERR_WrongNumberOfSubpatterns, f_10315_61240_61265(tupleDesignation), strippedInputType, elementTypes.Length, tupleDesignation.Variables.Count);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61412, 61429);

                                        hasErrors = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 61045, 61460);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61499, 61504);
                                        for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61490, 62161) || true) && (i < tupleDesignation.Variables.Count)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61544, 61547)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 61490, 62161))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 61490, 62161);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61613, 61658);

                                            var
                                            variable = f_10315_61628_61654(tupleDesignation)[i]
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61692, 61732);

                                            bool
                                            isError = i >= elementTypes.Length
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61766, 61842);

                                            TypeSymbol
                                            elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(10315, 61791, 61798) || ((isError && DynAbs.Tracing.TraceSender.Conditional_F2(10315, 61801, 61818)) || DynAbs.Tracing.TraceSender.Conditional_F3(10315, 61821, 61841))) ? f_10315_61801_61818(this) : elementTypes[i].Type
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 61876, 62026);

                                            BoundPattern
                                            pattern = f_10315_61899_62025(this, variable, elementType, f_10315_61941_61982(elementType, inputValEscape), permitDesignations, isError, diagnostics)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62060, 62130);

                                            f_10315_62060_62129(subPatterns, f_10315_62076_62128(variable, symbol: null, pattern));
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 672);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 672);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 60911, 62188);

                                    Microsoft.CodeAnalysis.Location
                                    f_10315_61240_61265(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                                    this_param)
                                    {
                                        var return_v = this_param.Location;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 61240, 61265);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                    f_10315_61184_61377(Microsoft.CodeAnalysis.DiagnosticBag
                                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                    code, Microsoft.CodeAnalysis.Location
                                    location, params object[]
                                    args)
                                    {
                                        var return_v = diagnostics.Add(code, location, args);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 61184, 61377);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                                    f_10315_61628_61654(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                                    this_param)
                                    {
                                        var return_v = this_param.Variables;
                                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 61628, 61654);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                    f_10315_61801_61818(Microsoft.CodeAnalysis.CSharp.Binder
                                    this_param)
                                    {
                                        var return_v = this_param.CreateErrorType();
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 61801, 61818);
                                        return return_v;
                                    }


                                    uint
                                    f_10315_61941_61982(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                    type, uint
                                    possibleValEscape)
                                    {
                                        var return_v = GetValEscape(type, possibleValEscape);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 61941, 61982);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundPattern
                                    f_10315_61899_62025(Microsoft.CodeAnalysis.CSharp.Binder
                                    this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                                    node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                                    inputType, uint
                                    inputValEscape, bool
                                    permitDesignations, bool
                                    hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                                    diagnostics)
                                    {
                                        var return_v = this_param.BindVarDesignation(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 61899, 62025);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                                    f_10315_62076_62128(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                                    syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                                    symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                                    pattern)
                                    {
                                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, symbol: symbol, pattern);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62076, 62128);
                                        return return_v;
                                    }


                                    int
                                    f_10315_62060_62129(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                                    item)
                                    {
                                        this_param.Add(item);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62060, 62129);
                                        return 0;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 60911, 62188);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 60911, 62188);
                                }
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 54453, 62378);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 54453, 62378);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62286, 62340);

                            throw f_10315_62292_62339(f_10315_62327_62338(node));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 54453, 62378);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 54167, 62389);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_54461_54472(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 54461, 54472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                f_10315_54597_54673(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, inputType: inputType, narrowedType: narrowedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 54597, 54673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10315_54876_54887()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 54876, 54887);
                    return return_v;
                }


                int
                f_10315_54915_55303(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declType, uint
                inputValEscape, bool
                permitDesignations, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                typeSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, out Microsoft.CodeAnalysis.CSharp.Symbol?
                variableSymbol, out Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess)
                {
                    this_param.BindPatternDesignation(designation: designation, declType: declType, inputValEscape: inputValEscape, permitDesignations: permitDesignations, typeSyntax: typeSyntax, diagnostics: diagnostics, hasErrors: ref hasErrors, out variableSymbol, out variableAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 54915, 55303);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10315_55353_55437(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol?
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypeExpression(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, aliasOpt: aliasOpt, typeWithAnnotations: typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 55353, 55437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10315_55650_55661(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 55650, 55661);
                    return return_v;
                }


                int
                f_10315_55637_55669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 55637, 55669);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10315_55761_55772(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 55761, 55772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_55761_55779(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 55761, 55779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10315_55807_55818(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 55807, 55818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                f_10315_55703_56091(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                declaredType, bool
                isVar, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, variable, variableAccess, declaredType, isVar: isVar, inputType: inputType, narrowedType: narrowedType, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 55703, 56091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_56343_56418(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSubpattern>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 56343, 56418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_56534_56558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 56534, 56558);
                    return return_v;
                }


                bool
                f_10315_56591_56632(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsZeroElementTupleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 56591, 56632);
                    return return_v;
                }


                bool
                f_10315_57245_57274(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 57245, 57274);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10315_57438_57488(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 57438, 57488);
                    return return_v;
                }




                Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                f_10315_57723_57773(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 57723, 57773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10315_57899_57926()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 57899, 57926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_57987_58326(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                numCheckedVariables, Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                receiver, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                rightSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, out bool
                anyApplicableCandidates)
                {
                    var return_v = this_param.MakeDeconstructInvocationExpression(numCheckedVariables, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.SyntaxNode)rightSyntax, diagnostics, out outPlaceholders, out anyApplicableCandidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 57987, 58326);
                    return return_v;
                }


                bool
                f_10315_58423_58544(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                declType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                iTupleType, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetLength, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                iTupleGetItem)
                {
                    var return_v = this_param.ShouldUseITuple((Microsoft.CodeAnalysis.SyntaxNode)node, declType, diagnostics, out iTupleType, out iTupleGetLength, out iTupleGetItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 58423, 58544);
                    return return_v;
                }


                int
                f_10315_58850_58879(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 58850, 58879);
                    return 0;
                }


                int
                f_10315_58914_58999(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                patterns, bool
                permitDesignations, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.BindITupleSubpatterns(node, patterns, permitDesignations, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 58914, 58999);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_59102_59134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 59102, 59134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                f_10315_59041_59177(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getLengthMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getItemMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                subpatterns, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundITuplePattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, getLengthMethod, getItemMethod, subpatterns, inputType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 59041, 59177);
                    return return_v;
                }


                int
                f_10315_59308_59359(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRangeAndFree(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 59308, 59359);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_59443_59471(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ExpressionSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 59443, 59471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10315_59837_59863(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 59837, 59863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_60049_60066(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60049, 60066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_60069_60092(Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 60069, 60092);
                    return return_v;
                }


                uint
                f_10315_60192_60233(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60192, 60233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_60150_60276(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindVarDesignation(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60150, 60276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_60327_60379(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, symbol: symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60327, 60379);
                    return return_v;
                }


                int
                f_10315_60311_60380(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60311, 60380);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_60647_60679(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60647, 60679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_60835_60859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60835, 60859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                f_10315_60474_60882(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                declaredType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                deconstructMethod, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                deconstruction, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                properties, Microsoft.CodeAnalysis.CSharp.Symbol?
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                variableAccess, bool
                isExplicitNotNullTest, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, declaredType: declaredType, deconstructMethod: deconstructMethod, deconstruction: deconstruction, properties: properties, variable: variable, variableAccess: variableAccess, isExplicitNotNullTest: isExplicitNotNullTest, inputType: inputType, narrowedType: narrowedType, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 60474, 60882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_62327_62338(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62327, 62338);
                    return return_v;
                }


                System.Exception
                f_10315_62292_62339(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62292, 62339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 54167, 62389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 54167, 62389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<BoundSubpattern> BindPropertyPatternClause(
                    PropertyPatternClauseSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    DiagnosticBag diagnostics,
                    ref bool hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 62401, 63884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62711, 62791);

                var
                builder = f_10315_62725_62790(node.Subpatterns.Count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62805, 63821);
                    foreach (SubpatternSyntax p in f_10315_62836_62852_I(f_10315_62836_62852(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 62805, 63821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62886, 62933);

                        IdentifierNameSyntax?
                        name = f_10315_62915_62932_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10315_62915_62926(p), 10315, 62915, 62932)?.Name)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 62951, 62985);

                        PatternSyntax
                        pattern = f_10315_62975_62984(p)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63003, 63025);

                        Symbol?
                        member = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63043, 63065);

                        TypeSymbol
                        memberType
                        = default(TypeSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63083, 63563) || true) && (name == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 63083, 63563);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63141, 63267) || true) && (!hasErrors)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 63141, 63267);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63182, 63267);

                                f_10315_63182_63266(diagnostics, ErrorCode.ERR_PropertyPatternNameMissing, f_10315_63240_63256(pattern), pattern);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 63141, 63267);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63291, 63322);

                            memberType = f_10315_63304_63321(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63344, 63361);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 63083, 63563);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 63083, 63563);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63443, 63544);

                            member = f_10315_63452_63543(this, inputType, name, diagnostics, ref hasErrors, out memberType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 63083, 63563);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63583, 63730);

                        BoundPattern
                        boundPattern = f_10315_63611_63729(this, pattern, memberType, f_10315_63644_63684(memberType, inputValEscape), permitDesignations, hasErrors, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63748, 63806);

                        f_10315_63748_63805(builder, f_10315_63760_63804(p, member, boundPattern));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 62805, 63821);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 1017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 1017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 63837, 63873);

                return f_10315_63844_63872(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 62401, 63884);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_62725_62790(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSubpattern>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62725, 62790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_62836_62852(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyPatternClauseSyntax
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 62836, 62852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10315_62915_62926(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 62915, 62926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?
                f_10315_62915_62932_M(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 62915, 62932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_62975_62984(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 62975, 62984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_63240_63256(Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 63240, 63256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_63182_63266(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63182, 63266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_63304_63321(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63304, 63321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_63452_63543(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                memberType)
                {
                    var return_v = this_param.LookupMemberForPropertyPattern(inputType, name, diagnostics, ref hasErrors, out memberType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63452, 63543);
                    return return_v;
                }


                uint
                f_10315_63644_63684(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63644, 63684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_63611_63729(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63611, 63729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                f_10315_63760_63804(Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSubpattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, symbol, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63760, 63804);
                    return return_v;
                }


                int
                f_10315_63748_63805(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63748, 63805);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                f_10315_62836_62852_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SubpatternSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 62836, 62852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10315_63844_63872(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 63844, 63872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 62401, 63884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 62401, 63884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol? LookupMemberForPropertyPattern(
                    TypeSymbol inputType, IdentifierNameSyntax name, DiagnosticBag diagnostics, ref bool hasErrors, out TypeSymbol memberType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 63896, 64440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64104, 64192);

                Symbol?
                symbol = f_10315_64121_64191(this, inputType, name, ref hasErrors, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64208, 64399) || true) && (f_10315_64212_64235(inputType) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 64212, 64248) || hasErrors) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 64212, 64266) || symbol is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 64208, 64399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64285, 64316);

                    memberType = f_10315_64298_64315(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 64208, 64399);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 64208, 64399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64352, 64399);

                    memberType = f_10315_64365_64393(symbol).Type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 64208, 64399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64415, 64429);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 63896, 64440);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_64121_64191(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                memberName, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPropertyPatternMember(inputType, memberName, ref hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64121, 64191);
                    return return_v;
                }


                bool
                f_10315_64212_64235(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64212, 64235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10315_64298_64315(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64298, 64315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10315_64365_64393(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64365, 64393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 63896, 64440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 63896, 64440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol? BindPropertyPatternMember(
                    TypeSymbol inputType,
                    IdentifierNameSyntax memberName,
                    ref bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 64452, 67509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64765, 64855);

                BoundImplicitReceiver
                implicitReceiver = f_10315_64806_64854(memberName, inputType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64869, 64915);

                string
                name = memberName.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 64931, 65452);

                BoundExpression
                boundMember = f_10315_64961_65451(this, node: memberName, right: memberName, boundLeft: implicitReceiver, rightName: name, rightArity: 0, typeArgumentsSyntax: default(SeparatedSyntaxList<TypeSyntax>), typeArgumentsWithAnnotations: default(ImmutableArray<TypeWithAnnotations>), invoked: false, indexed: false, diagnostics: diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 65468, 65722) || true) && (f_10315_65472_65488(boundMember) == BoundKind.PropertyGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 65468, 65722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 65549, 65707);

                    boundMember = f_10315_65563_65706(this, boundMember, mustHaveAllOptionalParameters: true, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 65468, 65722);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 65738, 65809);

                hasErrors |= f_10315_65751_65775(boundMember) || (DynAbs.Tracing.TraceSender.Expression_False(10315, 65751, 65808) || f_10315_65779_65808(implicitReceiver));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 65825, 67158);

                switch (f_10315_65833_65849(boundMember))
                {

                    case BoundKind.FieldAccess:
                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 65825, 67158);
                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 65980, 65986);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 65825, 67158);

                    case BoundKind.IndexerAccess:
                    case BoundKind.DynamicIndexerAccess:
                    case BoundKind.EventAccess:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 65825, 67158);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66182, 67044) || true) && (!hasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 66182, 67044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66246, 67021);

                            switch (f_10315_66254_66276(boundMember))
                            {

                                case LookupResultKind.Empty:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 66246, 67021);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66396, 66484);

                                    f_10315_66396_66483(diagnostics, ErrorCode.ERR_NoSuchMember, memberName, f_10315_66455_66476(implicitReceiver), name);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10315, 66518, 66524);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 66246, 67021);

                                case LookupResultKind.Inaccessible:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 66246, 67021);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66625, 66698);

                                    boundMember = f_10315_66639_66697(this, boundMember, BindValueKind.RValue, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66732, 66771);

                                    f_10315_66732_66770(f_10315_66745_66769(boundMember));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10315, 66805, 66811);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 66246, 67021);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 66246, 67021);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 66885, 66954);

                                    f_10315_66885_66953(diagnostics, ErrorCode.ERR_PropertyLacksGet, memberName, name);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10315, 66988, 66994);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 66246, 67021);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 66182, 67044);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67068, 67085);

                        hasErrors = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67107, 67143);

                        return f_10315_67114_67142(boundMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 65825, 67158);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67174, 67446) || true) && (hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10315, 67178, 67380) || !f_10315_67192_67380(this, node: f_10315_67213_67230(memberName), expr: boundMember, valueKind: BindValueKind.RValue, checkingReceiver: false, diagnostics: diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 67174, 67446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67414, 67431);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 67174, 67446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67462, 67498);

                return f_10315_67469_67497(boundMember);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 64452, 67509);

                Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                f_10315_64806_64854(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver((Microsoft.CodeAnalysis.SyntaxNode)syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64806, 64854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_64961_65451(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                right, Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                boundLeft, string
                rightName, int
                rightArity, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInstanceMemberAccess(node: (Microsoft.CodeAnalysis.SyntaxNode)node, right: (Microsoft.CodeAnalysis.SyntaxNode)right, boundLeft: (Microsoft.CodeAnalysis.CSharp.BoundExpression)boundLeft, rightName: rightName, rightArity: rightArity, typeArgumentsSyntax: typeArgumentsSyntax, typeArgumentsWithAnnotations: typeArgumentsWithAnnotations, invoked: invoked, indexed: indexed, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 64961, 65451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10315_65472_65488(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 65472, 65488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_65563_65706(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                propertyGroup, bool
                mustHaveAllOptionalParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindIndexedPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundPropertyGroup)propertyGroup, mustHaveAllOptionalParameters: mustHaveAllOptionalParameters, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 65563, 65706);
                    return return_v;
                }


                bool
                f_10315_65751_65775(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 65751, 65775);
                    return return_v;
                }


                bool
                f_10315_65779_65808(Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 65779, 65808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10315_65833_65849(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 65833, 65849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10315_66254_66276(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 66254, 66276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_66455_66476(Microsoft.CodeAnalysis.CSharp.BoundImplicitReceiver
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 66455, 66476);
                    return return_v;
                }


                int
                f_10315_66396_66483(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 66396, 66483);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_66639_66697(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 66639, 66697);
                    return return_v;
                }


                bool
                f_10315_66745_66769(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 66745, 66769);
                    return return_v;
                }


                int
                f_10315_66732_66770(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 66732, 66770);
                    return 0;
                }


                int
                f_10315_66885_66953(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 66885, 66953);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_67114_67142(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ExpressionSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67114, 67142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10315_67213_67230(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67213, 67230);
                    return return_v;
                }


                bool
                f_10315_67192_67380(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, bool
                checkingReceiver, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValueKind(node: (Microsoft.CodeAnalysis.SyntaxNode?)node, expr: expr, valueKind: valueKind, checkingReceiver: checkingReceiver, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 67192, 67380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10315_67469_67497(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ExpressionSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67469, 67497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 64452, 67509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 64452, 67509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindTypePattern(
                    TypePatternSyntax node,
                    TypeSymbol inputType,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 67521, 68047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67724, 67811);

                var
                patternType = f_10315_67742_67810(this, f_10315_67761_67770(node), inputType, diagnostics, ref hasErrors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67825, 67912);

                bool
                isExplicitNotNullTest = f_10315_67854_67882(f_10315_67854_67870(patternType)) == SpecialType.System_Object
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 67926, 68036);

                return f_10315_67933_68035(node, patternType, isExplicitNotNullTest, inputType, f_10315_68007_68023(patternType), hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 67521, 68047);

                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10315_67761_67770(Microsoft.CodeAnalysis.CSharp.Syntax.TypePatternSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67761, 67770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10315_67742_67810(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref bool
                hasErrors)
                {
                    var return_v = this_param.BindTypeForPattern(typeSyntax, inputType, diagnostics, ref hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 67742, 67810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_67854_67870(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67854, 67870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10315_67854_67882(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 67854, 67882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_68007_68023(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 68007, 68023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                f_10315_67933_68035(Microsoft.CodeAnalysis.CSharp.Syntax.TypePatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                declaredType, bool
                isExplicitNotNullTest, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTypePattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, declaredType, isExplicitNotNullTest, inputType, narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 67933, 68035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 67521, 68047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 67521, 68047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindRelationalPattern(
                    RelationalPatternSyntax node,
                    TypeSymbol inputType,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 68059, 71099);
                Microsoft.CodeAnalysis.ConstantValue? constantValueOpt = default(Microsoft.CodeAnalysis.ConstantValue?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68274, 68412);

                BoundExpression
                value = f_10315_68298_68411(this, inputType, f_10315_68334_68349(node), ref hasErrors, diagnostics, out constantValueOpt, out _)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68426, 68508);

                ExpressionSyntax
                innerExpression = f_10315_68461_68507(this, f_10315_68491_68506(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68522, 68743) || true) && (f_10315_68526_68548(innerExpression) == SyntaxKind.DefaultLiteralExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 68522, 68743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68621, 68693);

                    f_10315_68621_68692(diagnostics, ErrorCode.ERR_DefaultPattern, f_10315_68667_68691(innerExpression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68711, 68728);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 68522, 68743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68757, 68795);

                f_10315_68757_68794(f_10315_68776_68786(value) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68809, 68897);

                BinaryOperatorKind
                operation = f_10315_68840_68896(node.OperatorToken.Kind())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68911, 69142) || true) && (operation == BinaryOperatorKind.Equal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 68911, 69142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 68986, 69092);

                    f_10315_68986_69091(diagnostics, ErrorCode.ERR_InvalidExprTerm, node.OperatorToken.GetLocation(), node.OperatorToken.Text);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69110, 69127);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 68911, 69142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69158, 69248);

                BinaryOperatorKind
                opType = f_10315_69186_69247(f_10315_69209_69246(f_10315_69209_69219(value)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69262, 70203);

                switch (opType)
                {

                    case BinaryOperatorKind.Float:
                    case BinaryOperatorKind.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 69262, 70203);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69411, 69724) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10315, 69415, 69453) && constantValueOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 69415, 69480) && f_10315_69457_69480_M(!constantValueOpt.IsBad)) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 69415, 69526) && f_10315_69484_69526(f_10315_69497_69525(constantValueOpt))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 69411, 69724);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69576, 69658);

                            f_10315_69576_69657(diagnostics, ErrorCode.ERR_RelationalPatternWithNaN, f_10315_69632_69656(f_10315_69632_69647(node)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69684, 69701);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 69411, 69724);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 69746, 69752);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 69262, 70203);

                    case BinaryOperatorKind.String:
                    case BinaryOperatorKind.Bool:
                    case BinaryOperatorKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 69262, 70203);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69918, 70160) || true) && (!hasErrors)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 69918, 70160);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 69982, 70094);

                            f_10315_69982_70093(diagnostics, ErrorCode.ERR_UnsupportedTypeForRelationalPattern, f_10315_70049_70062(node), f_10315_70064_70092(f_10315_70064_70074(value)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70120, 70137);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 69918, 70160);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 70182, 70188);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 69262, 70203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70219, 70368) || true) && (constantValueOpt is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 70219, 70368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70281, 70298);

                    hasErrors = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70316, 70353);

                    constantValueOpt = f_10315_70335_70352();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 70219, 70368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70384, 70503);

                return f_10315_70391_70502(node, operation | opType, value, constantValueOpt, inputType, f_10315_70480_70490(value), hasErrors);

                static BinaryOperatorKind tokenKindToBinaryOperatorKind(SyntaxKind kind)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 70592, 71087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70595, 71087);
                        return kind switch
                        {
                            SyntaxKind.LessThanEqualsToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70639, 70707) && DynAbs.Tracing.TraceSender.Expression_True(10315, 70639, 70707))
            => BinaryOperatorKind.LessThanOrEqual,
                            SyntaxKind.LessThanToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70726, 70781) && DynAbs.Tracing.TraceSender.Expression_True(10315, 70726, 70781))
            => BinaryOperatorKind.LessThan,
                            SyntaxKind.GreaterThanToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70800, 70861) && DynAbs.Tracing.TraceSender.Expression_True(10315, 70800, 70861))
            => BinaryOperatorKind.GreaterThan,
                            SyntaxKind.GreaterThanEqualsToken when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 70880, 70954) && DynAbs.Tracing.TraceSender.Expression_True(10315, 70880, 70954))
            => BinaryOperatorKind.GreaterThanOrEqual,
                            // The following occurs in error recovery scenarios
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71042, 71071) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71042, 71071))
            => BinaryOperatorKind.Equal,
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 70592, 71087);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 70592, 71087);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 70592, 71087);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 68059, 71099);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_68334_68349(Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 68334, 68349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10315_68298_68411(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                patternExpression, ref bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, out bool
                wasExpression)
                {
                    var return_v = this_param.BindExpressionForPattern(inputType, patternExpression, ref hasErrors, diagnostics, out constantValueOpt, out wasExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68298, 68411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_68491_68506(Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 68491, 68506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_68461_68507(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                e)
                {
                    var return_v = this_param.SkipParensAndNullSuppressions(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68461, 68507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_68526_68548(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68526, 68548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_68667_68691(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 68667, 68691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_68621_68692(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68621, 68692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10315_68776_68786(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 68776, 68786);
                    return return_v;
                }


                int
                f_10315_68757_68794(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68757, 68794);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10315_68840_68896(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = tokenKindToBinaryOperatorKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68840, 68896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_68986_69091(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 68986, 69091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_69209_69219(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 69209, 69219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_69209_69246(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 69209, 69246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10315_69186_69247(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = RelationalOperatorType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 69186, 69247);
                    return return_v;
                }


                bool
                f_10315_69457_69480_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 69457, 69480);
                    return return_v;
                }


                double
                f_10315_69497_69525(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 69497, 69525);
                    return return_v;
                }


                bool
                f_10315_69484_69526(double
                d)
                {
                    var return_v = double.IsNaN(d);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 69484, 69526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10315_69632_69647(Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 69632, 69647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_69632_69656(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 69632, 69656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_69576_69657(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 69576, 69657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10315_70049_70062(Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 70049, 70062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_70064_70074(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 70064, 70074);
                    return return_v;
                }


                string
                f_10315_70064_70092(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 70064, 70092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10315_69982_70093(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 69982, 70093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10315_70335_70352()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 70335, 70352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_70480_70490(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 70480, 70490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                f_10315_70391_70502(Microsoft.CodeAnalysis.CSharp.Syntax.RelationalPatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, relation, value, constantValue, inputType, narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 70391, 70502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 68059, 71099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 68059, 71099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BinaryOperatorKind RelationalOperatorType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 71488, 72844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71491, 72844);
                return f_10315_71491_71507(type) switch
                {
                    SpecialType.System_Single when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71539, 71592) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71539, 71592))
        => BinaryOperatorKind.Float,
                    SpecialType.System_Double when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71607, 71661) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71607, 71661))
        => BinaryOperatorKind.Double,
                    SpecialType.System_Char when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71676, 71726) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71676, 71726))
        => BinaryOperatorKind.Char,
                    SpecialType.System_SByte when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71741, 71791) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71741, 71791))
        => BinaryOperatorKind.Int, // operands are converted to int
                    SpecialType.System_Byte when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71839, 71888) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71839, 71888))
        => BinaryOperatorKind.Int, // operands are converted to int
                    SpecialType.System_UInt16 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 71936, 71987) && DynAbs.Tracing.TraceSender.Expression_True(10315, 71936, 71987))
        => BinaryOperatorKind.Int, // operands are converted to int
                    SpecialType.System_Int16 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72035, 72085) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72035, 72085))
        => BinaryOperatorKind.Int, // operands are converted to int
                    SpecialType.System_Int32 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72133, 72183) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72133, 72183))
        => BinaryOperatorKind.Int,
                    SpecialType.System_UInt32 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72198, 72250) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72198, 72250))
        => BinaryOperatorKind.UInt,
                    SpecialType.System_Int64 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72265, 72316) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72265, 72316))
        => BinaryOperatorKind.Long,
                    SpecialType.System_UInt64 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72331, 72384) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72331, 72384))
        => BinaryOperatorKind.ULong,
                    SpecialType.System_Decimal when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72399, 72455) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72399, 72455))
        => BinaryOperatorKind.Decimal,
                    SpecialType.System_String when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72470, 72524) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72470, 72524))
        => BinaryOperatorKind.String,
                    SpecialType.System_Boolean when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72539, 72592) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72539, 72592))
        => BinaryOperatorKind.Bool,
                    SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72633, 72662) || true) && (f_10315_72638_72662(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 72633, 72662) || true)
        => BinaryOperatorKind.NInt,
                    SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72731, 72760) || true) && (f_10315_72736_72760(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10315, 72731, 72760) || true)
        => BinaryOperatorKind.NUInt,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 72803, 72832) && DynAbs.Tracing.TraceSender.Expression_True(10315, 72803, 72832))
        => BinaryOperatorKind.Error,
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 71488, 72844);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 71488, 72844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 71488, 72844);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.SpecialType
            f_10315_71491_71507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.SpecialType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 71491, 71507);
                return return_v;
            }


            bool
            f_10315_72638_72662(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.IsNativeIntegerType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 72638, 72662);
                return return_v;
            }


            bool
            f_10315_72736_72760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.IsNativeIntegerType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 72736, 72760);
                return return_v;
            }

        }

        private BoundPattern BindUnaryPattern(
                    UnaryPatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool hasErrors,
                    DiagnosticBag diagnostics,
                    bool underIsPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 72857, 73509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73130, 73171);

                bool
                permitDesignations = underIsPattern
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73247, 73377);

                var
                subPattern = f_10315_73264_73376(this, f_10315_73276_73288(node), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics, underIsPattern)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73391, 73498);

                return f_10315_73398_73497(node, subPattern, inputType: inputType, narrowedType: inputType, hasErrors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 72857, 73509);

                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_73276_73288(Microsoft.CodeAnalysis.CSharp.Syntax.UnaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 73276, 73288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_73264_73376(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                underIsPattern)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics, underIsPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 73264, 73376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                f_10315_73398_73497(Microsoft.CodeAnalysis.CSharp.Syntax.UnaryPatternSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundPattern
                negated, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, negated, inputType: inputType, narrowedType: narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 73398, 73497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 72857, 73509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 72857, 73509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundPattern BindBinaryPattern(
                    BinaryPatternSyntax node,
                    TypeSymbol inputType,
                    uint inputValEscape,
                    bool permitDesignations,
                    bool hasErrors,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 73521, 79168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73800, 73857);

                bool
                isDisjunction = f_10315_73821_73832(node) == SyntaxKind.OrPattern
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73871, 79157) || true) && (isDisjunction)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 73871, 79157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 73922, 73949);

                    permitDesignations = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74001, 74106);

                    var
                    left = f_10315_74012_74105(this, f_10315_74024_74033(node), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74124, 74231);

                    var
                    right = f_10315_74136_74230(this, f_10315_74148_74158(node), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74374, 74443);

                    var
                    narrowedTypeCandidates = f_10315_74403_74442(2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74461, 74509);

                    f_10315_74461_74508(left, narrowedTypeCandidates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74527, 74576);

                    f_10315_74527_74575(right, narrowedTypeCandidates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74594, 74687);

                    var
                    narrowedType = f_10315_74613_74673(node, narrowedTypeCandidates, diagnostics) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10315, 74613, 74686) ?? inputType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74705, 74735);

                    f_10315_74705_74734(narrowedTypeCandidates);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 74755, 74893);

                    return f_10315_74762_74892(node, disjunction: isDisjunction, left, right, inputType: inputType, narrowedType: narrowedType, hasErrors);


                    static int
                    f_10315_75141_75178(Microsoft.CodeAnalysis.CSharp.BoundPattern
                    pat, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    candidates)
                    {
                        collectCandidates(pat, candidates);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 75141, 75178);
                        return 0;
                    }

                    static int
                    f_10315_75205_75243(Microsoft.CodeAnalysis.CSharp.BoundPattern
                    pat, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    candidates)
                    {
                        collectCandidates(pat, candidates);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 75205, 75243);
                        return 0;
                    }

                    int
                    f_10315_74461_74508(Microsoft.CodeAnalysis.CSharp.BoundPattern
                    pat, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    candidates)
                    {
                        collectCandidates(pat, candidates);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74461, 74508);
                        return 0;
                    }


                    int
                    f_10315_74527_74575(Microsoft.CodeAnalysis.CSharp.BoundPattern
                    pat, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    candidates)
                    {
                        collectCandidates(pat, candidates);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74527, 74575);
                        return 0;
                    }


                    static void collectCandidates(BoundPattern pat, ArrayBuilder<TypeSymbol> candidates)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10315, 74913, 75417);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75038, 75398) || true) && (pat is BoundBinaryPattern { Disjunction: true } p)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 75038, 75398);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75141, 75179);

                                f_10315_75141_75178(f_10315_75159_75165(p), candidates);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75205, 75244);

                                f_10315_75205_75243(f_10315_75223_75230(p), candidates);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 75038, 75398);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 75038, 75398);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75342, 75375);

                                f_10315_75342_75374(candidates, f_10315_75357_75373(pat));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 75038, 75398);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10315, 74913, 75417);

                            Microsoft.CodeAnalysis.CSharp.BoundPattern
                            f_10315_75159_75165(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                            this_param)
                            {
                                var return_v = this_param.Left;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75159, 75165);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundPattern
                            f_10315_75223_75230(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                            this_param)
                            {
                                var return_v = this_param.Right;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75223, 75230);
                                return return_v;
                            }



                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10315_75357_75373(Microsoft.CodeAnalysis.CSharp.BoundPattern
                            this_param)
                            {
                                var return_v = this_param.NarrowedType;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75357, 75373);
                                return return_v;
                            }


                            int
                            f_10315_75342_75374(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            item)
                            {
                                this_param.Add(item);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 75342, 75374);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 74913, 75417);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 74913, 75417);
                        }
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10315_74613_74673(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                    node, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    candidates, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = leastSpecificType((Microsoft.CodeAnalysis.SyntaxNode)node, candidates, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74613, 74673);
                        return return_v;
                    }

                    TypeSymbol? leastSpecificType(SyntaxNode node, ArrayBuilder<TypeSymbol> candidates, DiagnosticBag diagnostics)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 75437, 77042);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75588, 75624);

                            f_10315_75588_75623(f_10315_75601_75617(candidates) >= 2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75646, 75697);

                            HashSet<DiagnosticInfo>?
                            useSiteDiagnostics = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75719, 75757);

                            TypeSymbol?
                            bestSoFar = f_10315_75743_75756(candidates, 0)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75899, 75904);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75906, 75926);
                                // first pass: select a candidate for which no other has been shown to be an improvement.
                                for (int
            i = 1
            ,
            n = f_10315_75910_75926(candidates)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75890, 76167) || true) && (i < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75935, 75938)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 75890, 76167))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 75890, 76167);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 75988, 76025);

                                    TypeSymbol
                                    candidate = f_10315_76011_76024(candidates, i)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76051, 76144);

                                    bestSoFar = f_10315_76063_76130(bestSoFar, candidate, ref useSiteDiagnostics) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10315, 76063, 76143) ?? bestSoFar);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 278);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 278);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76289, 76294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76296, 76316);
                                // second pass: check that it is no more specific than any candidate.
                                for (int
            i = 0
            ,
            n = f_10315_76300_76316(candidates)
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76280, 76909) || true) && (i < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76325, 76328)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 76280, 76909))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 76280, 76909);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76378, 76415);

                                    TypeSymbol
                                    candidate = f_10315_76401_76414(candidates, i)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76441, 76531);

                                    TypeSymbol?
                                    spoiler = f_10315_76463_76530(candidate, bestSoFar, ref useSiteDiagnostics)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76557, 76714) || true) && (spoiler is null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 76557, 76714);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76634, 76651);

                                        bestSoFar = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10315, 76681, 76687);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 76557, 76714);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76810, 76886);

                                    f_10315_76810_76885(f_10315_76823_76884(spoiler, bestSoFar, TypeCompareKind.ConsiderEverything));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10315, 1, 630);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10315, 1, 630);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 76933, 76984);

                            f_10315_76933_76983(
                                                diagnostics, f_10315_76949_76962(node), useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 77006, 77023);

                            return bestSoFar;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 75437, 77042);

                            int
                            f_10315_75601_75617(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param)
                            {
                                var return_v = this_param.Count;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75601, 75617);
                                return return_v;
                            }


                            int
                            f_10315_75588_75623(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 75588, 75623);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10315_75743_75756(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param, int
                            i0)
                            {
                                var return_v = this_param[i0];
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75743, 75756);
                                return return_v;
                            }


                            int
                            f_10315_75910_75926(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param)
                            {
                                var return_v = this_param.Count;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 75910, 75926);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10315_76011_76024(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param, int
                            i0)
                            {
                                var return_v = this_param[i0];
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 76011, 76024);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                            f_10315_76063_76130(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            bestSoFar, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            possiblyLessSpecificCandidate, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                            useSiteDiagnostics)
                            {
                                var return_v = lessSpecificCandidate(bestSoFar, possiblyLessSpecificCandidate, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 76063, 76130);
                                return return_v;
                            }


                            int
                            f_10315_76300_76316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param)
                            {
                                var return_v = this_param.Count;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 76300, 76316);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10315_76401_76414(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                            this_param, int
                            i0)
                            {
                                var return_v = this_param[i0];
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 76401, 76414);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                            f_10315_76463_76530(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            bestSoFar, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            possiblyLessSpecificCandidate, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                            useSiteDiagnostics)
                            {
                                var return_v = lessSpecificCandidate(bestSoFar, possiblyLessSpecificCandidate, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 76463, 76530);
                                return return_v;
                            }


                            bool
                            f_10315_76823_76884(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            t2, Microsoft.CodeAnalysis.TypeCompareKind
                            compareKind)
                            {
                                var return_v = this_param.Equals(t2, compareKind);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 76823, 76884);
                                return return_v;
                            }


                            int
                            f_10315_76810_76885(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 76810, 76885);
                                return 0;
                            }


                            Microsoft.CodeAnalysis.Location
                            f_10315_76949_76962(Microsoft.CodeAnalysis.SyntaxNode
                            this_param)
                            {
                                var return_v = this_param.Location;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 76949, 76962);
                                return return_v;
                            }


                            bool
                            f_10315_76933_76983(Microsoft.CodeAnalysis.DiagnosticBag
                            diagnostics, Microsoft.CodeAnalysis.Location
                            location, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                            useSiteDiagnostics)
                            {
                                var return_v = diagnostics.Add(location, useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 76933, 76983);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 75437, 77042);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 75437, 77042);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    TypeSymbol? lessSpecificCandidate(TypeSymbol bestSoFar, TypeSymbol possiblyLessSpecificCandidate, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10315, 77190, 78579);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 77377, 78560) || true) && (f_10315_77381_77462(bestSoFar, possiblyLessSpecificCandidate, TypeCompareKind.AllIgnoreOptions))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 77377, 78560);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 77583, 77670);

                                return f_10315_77590_77669(bestSoFar, possiblyLessSpecificCandidate, VarianceKind.Out);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 77377, 78560);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 77377, 78560);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 77720, 78560) || true) && (f_10315_77724_77832(f_10315_77724_77735(), bestSoFar, possiblyLessSpecificCandidate, ref useSiteDiagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 77720, 78560);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 77989, 78026);

                                    return possiblyLessSpecificCandidate;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 77720, 78560);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 77720, 78560);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78076, 78560) || true) && (f_10315_78080_78177(f_10315_78080_78091(), bestSoFar, possiblyLessSpecificCandidate, ref useSiteDiagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 78076, 78560);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78322, 78359);

                                        return possiblyLessSpecificCandidate;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 78076, 78560);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 78076, 78560);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78525, 78537);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 78076, 78560);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 77720, 78560);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 77377, 78560);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 77190, 78579);

                            bool
                            f_10315_77381_77462(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            t2, Microsoft.CodeAnalysis.TypeCompareKind
                            compareKind)
                            {
                                var return_v = this_param.Equals(t2, compareKind);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 77381, 77462);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10315_77590_77669(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            other, Microsoft.CodeAnalysis.VarianceKind
                            variance)
                            {
                                var return_v = this_param.MergeEquivalentTypes(other, variance);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 77590, 77669);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Conversions
                            f_10315_77724_77735()
                            {
                                var return_v = Conversions;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 77724, 77735);
                                return return_v;
                            }


                            bool
                            f_10315_77724_77832(Microsoft.CodeAnalysis.CSharp.Conversions
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                            useSiteDiagnostics)
                            {
                                var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 77724, 77832);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Conversions
                            f_10315_78080_78091()
                            {
                                var return_v = Conversions;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 78080, 78091);
                                return return_v;
                            }


                            bool
                            f_10315_78080_78177(Microsoft.CodeAnalysis.CSharp.Conversions
                            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                            useSiteDiagnostics)
                            {
                                var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 78080, 78177);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 77190, 78579);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 77190, 78579);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 73871, 79157);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10315, 73871, 79157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78645, 78750);

                    var
                    left = f_10315_78656_78749(this, f_10315_78668_78677(node), inputType, inputValEscape, permitDesignations, hasErrors, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78768, 78842);

                    var
                    leftOutputValEscape = f_10315_78794_78841(f_10315_78807_78824(left), inputValEscape)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78860, 78980);

                    var
                    right = f_10315_78872_78979(this, f_10315_78884_78894(node), f_10315_78896_78913(left), leftOutputValEscape, permitDesignations, hasErrors, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10315, 78998, 79142);

                    return f_10315_79005_79141(node, disjunction: isDisjunction, left, right, inputType: inputType, narrowedType: f_10315_79111_79129(right), hasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10315, 73871, 79157);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10315, 73521, 79168);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10315_73821_73832(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 73821, 73832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_74024_74033(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 74024, 74033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_74012_74105(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74012, 74105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_74148_74158(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 74148, 74158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_74136_74230(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74136, 74230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10315_74403_74442(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74403, 74442);
                    return return_v;
                }




                int
                f_10315_74705_74734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74705, 74734);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                f_10315_74762_74892(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                syntax, bool
                disjunction, Microsoft.CodeAnalysis.CSharp.BoundPattern
                left, Microsoft.CodeAnalysis.CSharp.BoundPattern
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, disjunction: disjunction, left, right, inputType: inputType, narrowedType: narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 74762, 74892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_78668_78677(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 78668, 78677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_78656_78749(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 78656, 78749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_78807_78824(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 78807, 78824);
                    return return_v;
                }


                uint
                f_10315_78794_78841(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, uint
                possibleValEscape)
                {
                    var return_v = GetValEscape(type, possibleValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 78794, 78841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10315_78884_78894(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 78884, 78894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_78896_78913(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 78896, 78913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10315_78872_78979(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 78872, 78979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10315_79111_79129(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10315, 79111, 79129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                f_10315_79005_79141(Microsoft.CodeAnalysis.CSharp.Syntax.BinaryPatternSyntax
                syntax, bool
                disjunction, Microsoft.CodeAnalysis.CSharp.BoundPattern
                left, Microsoft.CodeAnalysis.CSharp.BoundPattern
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, disjunction: disjunction, left, right, inputType: inputType, narrowedType: narrowedType, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10315, 79005, 79141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10315, 73521, 79168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10315, 73521, 79168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
