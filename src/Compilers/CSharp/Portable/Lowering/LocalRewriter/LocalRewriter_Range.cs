// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Linq;
using Roslyn.Utilities;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter
    {
        public override BoundNode VisitRangeExpression(BoundRangeExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 558, 2731);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol nullableCtor = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 656, 709);

                f_10522_656_708(node != null && (DynAbs.Tracing.TraceSender.Expression_True(10522, 669, 707) && f_10522_685_699(node) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 725, 750);

                bool
                needLifting = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 764, 781);

                var
                F = _factory
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 797, 828);

                var
                left = f_10522_808_827(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 842, 939) || true) && (left != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 842, 939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 892, 924);

                    left = f_10522_899_923(left);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 842, 939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 955, 988);

                var
                right = f_10522_967_987(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1002, 1102) || true) && (right != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 1002, 1102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1053, 1087);

                    right = f_10522_1061_1086(right);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 1002, 1102);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1118, 1877) || true) && (needLifting)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 1118, 1877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1167, 1213);

                    return f_10522_1174_1212(this, node, left, right);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 1118, 1877);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 1118, 1877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1279, 1360);

                    BoundExpression
                    rangeCreation = f_10522_1311_1359(this, f_10522_1331_1345(node), left, right)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1380, 1821) || true) && (f_10522_1384_1410(f_10522_1384_1393(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 1380, 1821);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1452, 1695) || true) && (!f_10522_1457_1571(this, node.Syntax, f_10522_1491_1500(node), SpecialMember.System_Nullable_T__ctor, out nullableCtor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 1452, 1695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1621, 1672);

                            return f_10522_1628_1671(node.Syntax, f_10522_1655_1664(node), node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 1452, 1695);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1719, 1802);

                        return f_10522_1726_1801(node.Syntax, nullableCtor, rangeCreation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 1380, 1821);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1841, 1862);

                    return rangeCreation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 1118, 1877);
                }

                BoundExpression tryOptimizeOperand(BoundExpression operand)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 1893, 2720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 1985, 2015);

                        f_10522_1985_2014(operand != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2033, 2068);

                        operand = f_10522_2043_2067(this, operand);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2086, 2120);

                        f_10522_2086_2119(f_10522_2099_2111(operand) is { });

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2140, 2670) || true) && (f_10522_2144_2174(operand))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 2140, 2670);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2216, 2311);

                            operand = f_10522_2226_2310(operand.Syntax, f_10522_2269_2309(f_10522_2269_2281(operand)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 2140, 2670);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 2140, 2670);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2393, 2446);

                            operand = f_10522_2403_2434(operand) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10522, 2403, 2445) ?? operand);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2468, 2502);

                            f_10522_2468_2501(f_10522_2481_2493(operand) is { });

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2526, 2651) || true) && (f_10522_2530_2559(f_10522_2530_2542(operand)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 2526, 2651);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2609, 2628);

                                needLifting = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 2526, 2651);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 2140, 2670);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2690, 2705);

                        return operand;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 1893, 2720);

                        int
                        f_10522_1985_2014(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1985, 2014);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10522_2043_2067(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        node)
                        {
                            var return_v = this_param.VisitExpression(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2043, 2067);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10522_2099_2111(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2099, 2111);
                            return return_v;
                        }


                        int
                        f_10522_2086_2119(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2086, 2119);
                            return 0;
                        }


                        bool
                        f_10522_2144_2174(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = NullableNeverHasValue(expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2144, 2174);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10522_2269_2281(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2269, 2281);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10522_2269_2309(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.GetNullableUnderlyingType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2269, 2309);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                        f_10522_2226_2310(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2226, 2310);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10522_2403_2434(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = NullableAlwaysHasValue(expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2403, 2434);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10522_2481_2493(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2481, 2493);
                            return return_v;
                        }


                        int
                        f_10522_2468_2501(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2468, 2501);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10522_2530_2542(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2530, 2542);
                            return return_v;
                        }


                        bool
                        f_10522_2530_2559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2530, 2559);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 1893, 2720);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 1893, 2720);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 558, 2731);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10522_685_699(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 685, 699);
                    return return_v;
                }


                int
                f_10522_656_708(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 656, 708);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10522_808_827(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.LeftOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 808, 827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_899_923(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = tryOptimizeOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 899, 923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10522_967_987(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.RightOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 967, 987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_1061_1086(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = tryOptimizeOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1061, 1086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_1174_1212(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right)
                {
                    var return_v = this_param.LiftRangeExpression(node, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1174, 1212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10522_1331_1345(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 1331, 1345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_1311_1359(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructionMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right)
                {
                    var return_v = this_param.MakeRangeExpression(constructionMethod, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1311, 1359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_1384_1393(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 1384, 1393);
                    return return_v;
                }


                bool
                f_10522_1384_1410(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1384, 1410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_1491_1500(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 1491, 1500);
                    return return_v;
                }


                bool
                f_10522_1457_1571(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                result)
                {
                    var return_v = this_param.TryGetNullableMethod(syntax, nullableType, member, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1457, 1571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_1655_1664(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 1655, 1664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_1628_1671(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                child)
                {
                    var return_v = BadExpression(syntax, resultType, (Microsoft.CodeAnalysis.CSharp.BoundExpression)child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1628, 1671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10522_1726_1801(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 1726, 1801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 558, 2731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 558, 2731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression LiftRangeExpression(BoundRangeExpression node, BoundExpression? left, BoundExpression? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 2743, 6390);
                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol nullableCtor = default(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2885, 2926);

                f_10522_2885_2925(f_10522_2898_2924(f_10522_2898_2907(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 2963, 3121);

                f_10522_2963_3120((left != null && (DynAbs.Tracing.TraceSender.Expression_True(10522, 2977, 3013) && !(f_10522_2995_3004(left) is null)) && (DynAbs.Tracing.TraceSender.Expression_True(10522, 2977, 3043) && f_10522_3017_3043(f_10522_3017_3026(left)))) || (DynAbs.Tracing.TraceSender.Expression_False(10522, 2976, 3119) || (right != null && (DynAbs.Tracing.TraceSender.Expression_True(10522, 3049, 3087) && !(f_10522_3068_3078(right) is null)) && (DynAbs.Tracing.TraceSender.Expression_True(10522, 3049, 3118) && f_10522_3091_3118(f_10522_3091_3101(right))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3135, 3182);

                f_10522_3135_3181(!(left is null && (DynAbs.Tracing.TraceSender.Expression_True(10522, 3150, 3179) && right is null)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3196, 3232);

                f_10522_3196_3231(f_10522_3209_3223(node) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3248, 3310);

                var
                sideeffects = f_10522_3266_3309()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3324, 3377);

                var
                locals = f_10522_3337_3376()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3472, 3506);

                BoundExpression?
                condition = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3520, 3562);

                left = f_10522_3527_3561(left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3576, 3620);

                right = f_10522_3584_3619(right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3634, 3699);

                var
                rangeExpr = f_10522_3650_3698(this, f_10522_3670_3684(node), left, right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3715, 3747);

                f_10522_3715_3746(condition != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3763, 3982) || true) && (!f_10522_3768_3882(this, node.Syntax, f_10522_3802_3811(node), SpecialMember.System_Nullable_T__ctor, out nullableCtor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 3763, 3982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 3916, 3967);

                    return f_10522_3923_3966(node.Syntax, f_10522_3950_3959(node), node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 3763, 3982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 4091, 4193);

                BoundExpression
                consequence = f_10522_4121_4192(node.Syntax, nullableCtor, rangeExpr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 4233, 4314);

                BoundExpression
                alternative = f_10522_4263_4313(node.Syntax, f_10522_4303_4312(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 4507, 4880);

                BoundExpression
                conditionalExpression = f_10522_4547_4879(syntax: node.Syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: f_10522_4838_4847(node), isRef: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 4896, 5159);

                return f_10522_4903_5158(syntax: node.Syntax, locals: f_10522_4985_5012(locals), sideEffects: f_10522_5044_5076(sideeffects), value: conditionalExpression, type: f_10522_5148_5157(node));

                BoundExpression? getIndexFromPossibleNullable(BoundExpression? arg)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 5175, 6379);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5275, 5325) || true) && (arg is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 5275, 5325);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5313, 5325);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 5275, 5325);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5345, 5433);

                        BoundExpression
                        tempOperand = f_10522_5375_5432(this, arg, sideeffects, locals)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5451, 5489);

                        f_10522_5451_5488(f_10522_5464_5480(tempOperand) is { });

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5509, 6364) || true) && (f_10522_5513_5546(f_10522_5513_5529(tempOperand)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 5509, 6364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5588, 5677);

                            BoundExpression
                            operandHasValue = f_10522_5622_5676(this, tempOperand.Syntax, tempOperand)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5701, 6149) || true) && (condition is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 5701, 6149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5772, 5800);

                                condition = operandHasValue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 5701, 6149);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 5701, 6149);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 5898, 5976);

                                TypeSymbol
                                boolType = f_10522_5920_5975(_compilation, SpecialType.System_Boolean)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 6002, 6126);

                                condition = f_10522_6014_6125(this, node.Syntax, BinaryOperatorKind.BoolAnd, condition, operandHasValue, boolType, method: null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 5701, 6149);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 6173, 6244);

                            return f_10522_6180_6243(this, tempOperand.Syntax, tempOperand);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 5509, 6364);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 5509, 6364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 6326, 6345);

                            return tempOperand;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 5509, 6364);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 5175, 6379);

                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10522_5375_5432(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        sideeffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        locals)
                        {
                            var return_v = this_param.CaptureExpressionInTempIfNeeded(operand, sideeffects, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5375, 5432);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10522_5464_5480(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 5464, 5480);
                            return return_v;
                        }


                        int
                        f_10522_5451_5488(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5451, 5488);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10522_5513_5529(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 5513, 5529);
                            return return_v;
                        }


                        bool
                        f_10522_5513_5546(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5513, 5546);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10522_5622_5676(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.MakeOptimizedHasValue(syntax, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5622, 5676);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10522_5920_5975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5920, 5975);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10522_6014_6125(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        method)
                        {
                            var return_v = this_param.MakeBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, type, method: method);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 6014, 6125);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10522_6180_6243(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.MakeOptimizedGetValueOrDefault(syntax, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 6180, 6243);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 5175, 6379);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 5175, 6379);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 2743, 6390);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_2898_2907(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2898, 2907);
                    return return_v;
                }


                bool
                f_10522_2898_2924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2898, 2924);
                    return return_v;
                }


                int
                f_10522_2885_2925(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2885, 2925);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10522_2995_3004(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 2995, 3004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_3017_3026(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3017, 3026);
                    return return_v;
                }


                bool
                f_10522_3017_3043(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3017, 3043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10522_3068_3078(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3068, 3078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_3091_3101(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3091, 3101);
                    return return_v;
                }


                bool
                f_10522_3091_3118(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3091, 3118);
                    return return_v;
                }


                int
                f_10522_2963_3120(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 2963, 3120);
                    return 0;
                }


                int
                f_10522_3135_3181(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3135, 3181);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10522_3209_3223(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3209, 3223);
                    return return_v;
                }


                int
                f_10522_3196_3231(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3196, 3231);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10522_3266_3309()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3266, 3309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10522_3337_3376()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3337, 3376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10522_3527_3561(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                arg)
                {
                    var return_v = getIndexFromPossibleNullable(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3527, 3561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10522_3584_3619(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                arg)
                {
                    var return_v = getIndexFromPossibleNullable(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3584, 3619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10522_3670_3684(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3670, 3684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_3650_3698(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructionMethod, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right)
                {
                    var return_v = this_param.MakeRangeExpression(constructionMethod, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3650, 3698);
                    return return_v;
                }


                int
                f_10522_3715_3746(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3715, 3746);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_3802_3811(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3802, 3811);
                    return return_v;
                }


                bool
                f_10522_3768_3882(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                result)
                {
                    var return_v = this_param.TryGetNullableMethod(syntax, nullableType, member, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3768, 3882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_3950_3959(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 3950, 3959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_3923_3966(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                child)
                {
                    var return_v = BadExpression(syntax, resultType, (Microsoft.CodeAnalysis.CSharp.BoundExpression)child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 3923, 3966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10522_4121_4192(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 4121, 4192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_4303_4312(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 4303, 4312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10522_4263_4313(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 4263, 4313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_4838_4847(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 4838, 4847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_4547_4879(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenConsequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenAlternative, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                isRef)
                {
                    var return_v = RewriteConditionalOperator(syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 4547, 4879);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10522_4985_5012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 4985, 5012);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10522_5044_5076(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 5044, 5076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10522_5148_5157(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 5148, 5157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10522_4903_5158(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 4903, 5158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 2743, 6390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 2743, 6390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeRangeExpression(
                    MethodSymbol constructionMethod,
                    BoundExpression? left,
                    BoundExpression? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 6402, 9150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 6590, 6607);

                var
                F = _factory
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 6849, 8850);

                switch (f_10522_6857_6886(constructionMethod))
                {

                    case MethodKind.Constructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 6849, 8850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7257, 7301);

                        left = left ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10522, 7264, 7300) ?? f_10522_7272_7300(fromEnd: false));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7323, 7368);

                        right = right ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10522, 7331, 7367) ?? f_10522_7340_7367(fromEnd: true));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7392, 7461);

                        return f_10522_7399_7460(F, constructionMethod, f_10522_7425_7459(left, right));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 6849, 8850);

                    case MethodKind.Ordinary:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 6849, 8850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7763, 7806);

                        f_10522_7763_7805(left is null ^ right is null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7828, 7967);

                        f_10522_7828_7966(f_10522_7841_7872(constructionMethod) == "StartAt" || (DynAbs.Tracing.TraceSender.Expression_False(10522, 7841, 7965) || f_10522_7923_7954(constructionMethod) == "EndAt"));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 7989, 8031);

                        f_10522_7989_8030(f_10522_8002_8029(constructionMethod));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8053, 8077);

                        var
                        arg = left ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10522, 8063, 8076) ?? right)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8099, 8124);

                        f_10522_8099_8123(arg is { });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8146, 8214);

                        return f_10522_8153_8213(F, constructionMethod, f_10522_8186_8212(arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 6849, 8850);

                    case MethodKind.PropertyGet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 6849, 8850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8423, 8482);

                        f_10522_8423_8481(f_10522_8436_8467(constructionMethod) == "get_All");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8504, 8546);

                        f_10522_8504_8545(f_10522_8517_8544(constructionMethod));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8568, 8612);

                        f_10522_8568_8611(left is null && (DynAbs.Tracing.TraceSender.Expression_True(10522, 8581, 8610) && right is null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8634, 8713);

                        return f_10522_8641_8712(F, constructionMethod, ImmutableArray<BoundExpression>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 6849, 8850);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10522, 6849, 8850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8763, 8835);

                        throw f_10522_8769_8834(f_10522_8804_8833(constructionMethod));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10522, 6849, 8850);
                }

                BoundExpression newIndexZero(bool fromEnd)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10522, 8909, 9138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10522, 8980, 9138);
                        return f_10522_8980_9138(                // new Index(0, fromEnd: fromEnd)
                                        F, WellKnownMember.System_Index__ctor, f_10522_9065_9137(f_10522_9104_9116(F, 0), f_10522_9118_9136(F, fromEnd))); DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 8909, 9138);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 8909, 9138);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 8909, 9138);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10522, 6402, 9150);

                Microsoft.CodeAnalysis.MethodKind
                f_10522_6857_6886(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 6857, 6886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_7272_7300(bool
                fromEnd)
                {
                    var return_v = newIndexZero(fromEnd: fromEnd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7272, 7300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_7340_7367(bool
                fromEnd)
                {
                    var return_v = newIndexZero(fromEnd: fromEnd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7340, 7367);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10522_7425_7459(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7425, 7459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10522_7399_7460(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7399, 7460);
                    return return_v;
                }


                int
                f_10522_7763_7805(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7763, 7805);
                    return 0;
                }


                string
                f_10522_7841_7872(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 7841, 7872);
                    return return_v;
                }


                string
                f_10522_7923_7954(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 7923, 7954);
                    return return_v;
                }


                int
                f_10522_7828_7966(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7828, 7966);
                    return 0;
                }


                bool
                f_10522_8002_8029(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 8002, 8029);
                    return return_v;
                }


                int
                f_10522_7989_8030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 7989, 8030);
                    return 0;
                }


                int
                f_10522_8099_8123(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8099, 8123);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10522_8186_8212(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8186, 8212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_8153_8213(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.StaticCall(method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8153, 8213);
                    return return_v;
                }


                string
                f_10522_8436_8467(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 8436, 8467);
                    return return_v;
                }


                int
                f_10522_8423_8481(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8423, 8481);
                    return 0;
                }


                bool
                f_10522_8517_8544(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 8517, 8544);
                    return return_v;
                }


                int
                f_10522_8504_8545(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8504, 8545);
                    return 0;
                }


                int
                f_10522_8568_8611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8568, 8611);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10522_8641_8712(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.StaticCall(method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8641, 8712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10522_8804_8833(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10522, 8804, 8833);
                    return return_v;
                }


                System.Exception
                f_10522_8769_8834(Microsoft.CodeAnalysis.MethodKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8769, 8834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10522_9104_9116(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 9104, 9116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10522_9118_9136(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 9118, 9136);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10522_9065_9137(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item1, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                item2)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item1, (Microsoft.CodeAnalysis.CSharp.BoundExpression)item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 9065, 9137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10522_8980_9138(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.New(wm, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10522, 8980, 9138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10522, 6402, 9150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10522, 6402, 9150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
