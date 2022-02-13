// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class OperatorKindExtensions
    {
        public static RefKind RefKinds(this ImmutableArray<RefKind> ArgumentRefKinds, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10434, 539, 895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 652, 884) || true) && (f_10434_656_683_M(!ArgumentRefKinds.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10434, 656, 718) && index < ArgumentRefKinds.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 652, 884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 752, 783);

                    return ArgumentRefKinds[index];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 652, 884);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 652, 884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 849, 869);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 652, 884);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10434, 539, 895);

                bool
                f_10434_656_683_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 656, 683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10434, 539, 895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10434, 539, 895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OperatorKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10434, 470, 902);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10434, 470, 902);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10434, 470, 902);
        }

    }
    internal static partial class BoundExpressionExtensions
    {
        public static bool NullableAlwaysHasValue(this BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10434, 982, 2632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1075, 1102);

                f_10434_1075_1101(expr != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1116, 1207) || true) && ((object)f_10434_1128_1137(expr) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1116, 1207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1179, 1192);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1116, 1207);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1223, 1310) || true) && (f_10434_1227_1248(f_10434_1227_1236(expr)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1223, 1310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1282, 1295);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1223, 1310);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1326, 1418) || true) && (!f_10434_1331_1357(f_10434_1331_1340(expr)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1326, 1418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1391, 1403);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1326, 1418);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1484, 2592) || true) && (f_10434_1488_1497(expr) == BoundKind.ObjectCreationExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1484, 2592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1569, 1620);

                    var
                    creation = (BoundObjectCreationExpression)expr
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1638, 1686);

                    return f_10434_1645_1680(f_10434_1645_1665(creation)) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1484, 2592);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1484, 2592);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1720, 2592) || true) && (f_10434_1724_1733(expr) == BoundKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1720, 2592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1791, 1830);

                        var
                        conversion = (BoundConversion)expr
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 1848, 2577);

                        switch (f_10434_1856_1881(conversion))
                        {

                            case ConversionKind.ImplicitNullable:
                            case ConversionKind.ExplicitNullable:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1848, 2577);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2192, 2243);

                                return f_10434_2199_2242(f_10434_2199_2217(conversion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1848, 2577);

                            case ConversionKind.ImplicitEnumeration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 1848, 2577);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2507, 2558);

                                return f_10434_2514_2557(f_10434_2514_2532(conversion));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1848, 2577);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1720, 2592);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 1484, 2592);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2608, 2621);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10434, 982, 2632);

                int
                f_10434_1075_1101(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 1075, 1101);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10434_1128_1137(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1128, 1137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10434_1227_1236(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1227, 1236);
                    return return_v;
                }


                bool
                f_10434_1227_1248(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 1227, 1248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10434_1331_1340(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1331, 1340);
                    return return_v;
                }


                bool
                f_10434_1331_1357(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 1331, 1357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10434_1488_1497(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1488, 1497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10434_1645_1665(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1645, 1665);
                    return return_v;
                }


                int
                f_10434_1645_1680(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1645, 1680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10434_1724_1733(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1724, 1733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10434_1856_1881(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 1856, 1881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10434_2199_2217(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2199, 2217);
                    return return_v;
                }


                bool
                f_10434_2199_2242(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 2199, 2242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10434_2514_2532(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2514, 2532);
                    return return_v;
                }


                bool
                f_10434_2514_2557(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 2514, 2557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10434, 982, 2632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10434, 982, 2632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool NullableNeverHasValue(this BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10434, 2644, 4822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2736, 2763);

                f_10434_2736_2762(expr != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2779, 2913) || true) && ((object)f_10434_2791_2800(expr) == null && (DynAbs.Tracing.TraceSender.Expression_True(10434, 2783, 2852) && f_10434_2812_2830(expr) == f_10434_2834_2852()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 2779, 2913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2886, 2898);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 2779, 2913);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 2929, 3051) || true) && ((object)f_10434_2941_2950(expr) == null || (DynAbs.Tracing.TraceSender.Expression_False(10434, 2933, 2989) || !f_10434_2963_2989(f_10434_2963_2972(expr))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 2929, 3051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3023, 3036);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 2929, 3051);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3133, 3259) || true) && (expr is BoundDefaultLiteral || (DynAbs.Tracing.TraceSender.Expression_False(10434, 3137, 3198) || expr is BoundDefaultExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3133, 3259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3232, 3244);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3133, 3259);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3354, 3571) || true) && (f_10434_3358_3367(expr) == BoundKind.ObjectCreationExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3354, 3571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3439, 3490);

                    var
                    creation = (BoundObjectCreationExpression)expr
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3508, 3556);

                    return f_10434_3515_3550(f_10434_3515_3535(creation)) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3354, 3571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3587, 4595) || true) && (f_10434_3591_3600(expr) == BoundKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3587, 4595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3658, 3697);

                    var
                    conversion = (BoundConversion)expr
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 3715, 4580);

                    switch (f_10434_3723_3748(conversion))
                    {

                        case ConversionKind.NullLiteral:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3715, 4580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4028, 4040);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3715, 4580);

                        case ConversionKind.DefaultLiteral:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3715, 4580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4216, 4228);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3715, 4580);

                        case ConversionKind.ImplicitNullable:
                        case ConversionKind.ExplicitNullable:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 3715, 4580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4511, 4561);

                            return f_10434_4518_4560(f_10434_4518_4536(conversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3715, 4580);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 3587, 4595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4798, 4811);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10434, 2644, 4822);

                int
                f_10434_2736_2762(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 2736, 2762);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10434_2791_2800(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2791, 2800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10434_2812_2830(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2812, 2830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10434_2834_2852()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2834, 2852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10434_2941_2950(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2941, 2950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10434_2963_2972(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 2963, 2972);
                    return return_v;
                }


                bool
                f_10434_2963_2989(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 2963, 2989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10434_3358_3367(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 3358, 3367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10434_3515_3535(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 3515, 3535);
                    return return_v;
                }


                int
                f_10434_3515_3550(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 3515, 3550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10434_3591_3600(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 3591, 3600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10434_3723_3748(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 3723, 3748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10434_4518_4536(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 4518, 4536);
                    return return_v;
                }


                bool
                f_10434_4518_4560(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 4518, 4560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10434, 2644, 4822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10434, 2644, 4822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsNullableNonBoolean(this BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10434, 4834, 5148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4925, 4952);

                f_10434_4925_4951(expr != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 4966, 5110) || true) && (f_10434_4970_4996(f_10434_4970_4979(expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10434, 4970, 5079) && f_10434_5000_5049(f_10434_5000_5037(f_10434_5000_5009(expr))) != SpecialType.System_Boolean))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10434, 4966, 5110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 5098, 5110);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10434, 4966, 5110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10434, 5124, 5137);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10434, 4834, 5148);

                int
                f_10434_4925_4951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 4925, 4951);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10434_4970_4979(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 4970, 4979);
                    return return_v;
                }


                bool
                f_10434_4970_4996(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 4970, 4996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10434_5000_5009(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 5000, 5009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10434_5000_5037(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10434, 5000, 5037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10434_5000_5049(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10434, 5000, 5049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10434, 4834, 5148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10434, 4834, 5148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
