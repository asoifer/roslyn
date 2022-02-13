// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class LocalRewriter
    {
        public override BoundNode VisitTupleBinaryOperator(BoundTupleBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 1494, 2346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 1600, 1625);

                var
                boolType = f_10530_1615_1624(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 1670, 1732);

                var
                initEffects = f_10530_1688_1731()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 1746, 1798);

                var
                temps = f_10530_1758_1797()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 1814, 1920);

                BoundExpression
                newLeft = f_10530_1840_1919(this, f_10530_1873_1882(node), f_10530_1884_1898(node), initEffects, temps)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 1934, 2042);

                BoundExpression
                newRight = f_10530_1961_2041(this, f_10530_1994_2004(node), f_10530_2006_2020(node), initEffects, temps)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2058, 2175);

                var
                returnValue = f_10530_2076_2174(this, f_10530_2104_2118(node), newLeft, newRight, boolType, temps, f_10530_2156_2173(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2189, 2307);

                BoundExpression
                result = f_10530_2214_2306(_factory, f_10530_2232_2258(temps), f_10530_2260_2292(initEffects), returnValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2321, 2335);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 1494, 2346);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_1615_1624(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 1615, 1624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_1688_1731()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 1688, 1731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10530_1758_1797()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 1758, 1797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_1873_1882(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 1873, 1882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10530_1884_1898(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Operators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 1884, 1898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_1840_1919(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                operators, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.ReplaceTerminalElementsWithTemps(expr, (Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo)operators, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 1840, 1919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_1994_2004(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 1994, 2004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10530_2006_2020(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Operators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 2006, 2020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_1961_2041(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                operators, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.ReplaceTerminalElementsWithTemps(expr, (Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo)operators, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 1961, 2041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                f_10530_2104_2118(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Operators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 2104, 2118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10530_2156_2173(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 2156, 2173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_2076_2174(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                boolType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind)
                {
                    var return_v = this_param.RewriteTupleNestedOperators(operators, left, right, boolType, temps, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 2076, 2174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10530_2232_2258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 2232, 2258);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_2260_2292(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 2260, 2292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_2214_2306(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 2214, 2306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 1494, 2346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 1494, 2346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsLikeTupleExpression(BoundExpression expr, [NotNullWhen(true)] out BoundTupleExpression? tuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 2358, 5935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2492, 5924);

                switch (expr)
                {

                    case BoundTupleExpression t:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2588, 2598);

                        tuple = t;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2620, 2632);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);

                    case BoundConversion { Conversion: { Kind: ConversionKind.Identity }, Operand: var o }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 2759, 2802);

                        return f_10530_2766_2801(this, o, out tuple);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);

                    case BoundConversion { Conversion: { Kind: ConversionKind.ImplicitTupleLiteral }, Operand: var o }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3119, 3244);

                        f_10530_3119_3243(f_10530_3132_3141(expr) == (object?)f_10530_3154_3160(o) || (DynAbs.Tracing.TraceSender.Expression_False(10530, 3132, 3242) || f_10530_3164_3173(expr) is { } && (DynAbs.Tracing.TraceSender.Expression_True(10530, 3164, 3242) && f_10530_3184_3242(f_10530_3184_3193(expr), f_10530_3201_3207(o), TypeCompareKind.AllIgnoreOptions))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3266, 3309);

                        return f_10530_3273_3308(this, o, out tuple);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);

                    case BoundConversion { Conversion: { Kind: var kind } c, Operand: var o } conversion when
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3412, 3491) || true) && (c.IsTupleConversion || (DynAbs.Tracing.TraceSender.Expression_False(10530, 3442, 3491) || c.IsTupleLiteralConversion)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 3412, 3491) || true)
                    :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3614, 3669) || true) && (!f_10530_3619_3654(this, o, out tuple))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 3614, 3669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3656, 3669);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 3614, 3669);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3695, 3747);

                            var
                            underlyingConversions = c.UnderlyingConversions
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3773, 3840);

                            var
                            resultTypes = f_10530_3791_3839(f_10530_3791_3806(conversion))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3866, 3946);

                            var
                            builder = f_10530_3880_3945(tuple.Arguments.Length)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3981, 3986);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 3972, 4958) || true) && (i < tuple.Arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4016, 4019)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 3972, 4958))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 3972, 4958);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4077, 4110);

                                    var
                                    element = f_10530_4091_4106(tuple)[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4140, 4189);

                                    var
                                    elementConversion = underlyingConversions[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4219, 4257);

                                    var
                                    elementType = resultTypes[i].Type
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4287, 4876);

                                    var
                                    newArgument = f_10530_4305_4875(syntax: expr.Syntax, operand: element, conversion: elementConversion, @checked: f_10530_4538_4556(conversion), explicitCastInCode: f_10530_4611_4640(conversion), conversionGroupOpt: null, constantValueOpt: null, type: elementType, hasErrors: f_10530_4854_4874(conversion))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4906, 4931);

                                    f_10530_4906_4930(builder, newArgument);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10530, 1, 987);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10530, 1, 987);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 4984, 5032);

                            var
                            newArguments = f_10530_5003_5031(builder)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5058, 5323);

                            tuple = f_10530_5066_5322(tuple.Syntax, sourceTuple: null, wasTargetTyped: true, newArguments, ImmutableArray<string?>.Empty, ImmutableArray<bool>.Empty, f_10530_5284_5299(conversion), f_10530_5301_5321(conversion));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5349, 5361);

                            return true;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);

                    case BoundConversion { Conversion: { Kind: var kind }, Operand: var o } when
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5474, 5747) || true) && ((kind == ConversionKind.ImplicitNullable || (DynAbs.Tracing.TraceSender.Expression_False(10530, 5505, 5587) || kind == ConversionKind.ExplicitNullable)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 5504, 5642) && f_10530_5617_5626(expr) is { } exprType) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 5504, 5671) && f_10530_5646_5671(exprType)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 5504, 5747) && f_10530_5675_5747(f_10530_5675_5698(exprType), f_10530_5706_5712(o), TypeCompareKind.AllIgnoreOptions))) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 5474, 5747) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5770, 5813);

                        return f_10530_5777_5812(this, o, out tuple);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 2492, 5924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5861, 5874);

                        tuple = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 5896, 5909);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 2492, 5924);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 2358, 5935);

                bool
                f_10530_2766_2801(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?
                tuple)
                {
                    var return_v = this_param.IsLikeTupleExpression(expr, out tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 2766, 2801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_3132_3141(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3132, 3141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_3154_3160(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3154, 3160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_3164_3173(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3164, 3173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_3184_3193(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3184, 3193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_3201_3207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3201, 3207);
                    return return_v;
                }


                bool
                f_10530_3184_3242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 3184, 3242);
                    return return_v;
                }


                int
                f_10530_3119_3243(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 3119, 3243);
                    return 0;
                }


                bool
                f_10530_3273_3308(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?
                tuple)
                {
                    var return_v = this_param.IsLikeTupleExpression(expr, out tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 3273, 3308);
                    return return_v;
                }


                bool
                f_10530_3619_3654(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?
                tuple)
                {
                    var return_v = this_param.IsLikeTupleExpression(expr, out tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 3619, 3654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_3791_3806(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3791, 3806);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10530_3791_3839(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 3791, 3839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_3880_3945(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 3880, 3945);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_4091_4106(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 4091, 4106);
                    return return_v;
                }


                bool
                f_10530_4538_4556(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 4538, 4556);
                    return return_v;
                }


                bool
                f_10530_4611_4640(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 4611, 4640);
                    return return_v;
                }


                bool
                f_10530_4854_4874(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 4854, 4874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10530_4305_4875(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax: syntax, operand: operand, conversion: conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 4305, 4875);
                    return return_v;
                }


                int
                f_10530_4906_4930(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 4906, 4930);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_5003_5031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5003, 5031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_5284_5299(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 5284, 5299);
                    return return_v;
                }


                bool
                f_10530_5301_5321(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 5301, 5321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10530_5066_5322(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax, sourceTuple: sourceTuple, wasTargetTyped: wasTargetTyped, arguments, argumentNamesOpt, inferredNamesOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5066, 5322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_5617_5626(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 5617, 5626);
                    return return_v;
                }


                bool
                f_10530_5646_5671(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5646, 5671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_5675_5698(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5675, 5698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_5706_5712(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 5706, 5712);
                    return return_v;
                }


                bool
                f_10530_5675_5747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5675, 5747);
                    return return_v;
                }


                bool
                f_10530_5777_5812(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?
                tuple)
                {
                    var return_v = this_param.IsLikeTupleExpression(expr, out tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 5777, 5812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 2358, 5935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 2358, 5935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression PushDownImplicitTupleConversion(
                    BoundExpression expr,
                    ArrayBuilder<BoundExpression> initEffects,
                    ArrayBuilder<LocalSymbol> temps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 5947, 7994);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6165, 7955) || true) && (expr is BoundConversion { ConversionKind: ConversionKind.ImplicitTuple, Conversion: var conversion } boundConversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 6165, 7955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6396, 6432);

                    var
                    syntax = boundConversion.Syntax
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6450, 6481);

                    f_10530_6450_6480(f_10530_6463_6472(expr) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6499, 6565);

                    var
                    destElementTypes = f_10530_6522_6564(f_10530_6522_6531(expr))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6583, 6625);

                    var
                    numElements = destElementTypes.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6643, 6693);

                    f_10530_6643_6692(f_10530_6656_6684(f_10530_6656_6679(boundConversion)) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6711, 6777);

                    var
                    srcElementFields = f_10530_6734_6776(f_10530_6734_6762(f_10530_6734_6757(boundConversion)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6795, 6878);

                    var
                    fieldAccessorsBuilder = f_10530_6823_6877(numElements)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 6896, 7025);

                    var
                    savedTuple = f_10530_6913_7024(this, f_10530_6962_7003(this, f_10530_6979_7002(boundConversion)), initEffects, temps)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7043, 7101);

                    var
                    elementConversions = conversion.UnderlyingConversions
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7130, 7135);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7121, 7660) || true) && (i < numElements)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7154, 7157)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 7121, 7660))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 7121, 7660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7199, 7306);

                            var
                            fieldAccess = f_10530_7217_7305(this, savedTuple, syntax, srcElementFields[i])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7328, 7571);

                            var
                            convertedFieldAccess = f_10530_7355_7570(syntax, fieldAccess, elementConversions[i], f_10530_7445_7468(boundConversion), f_10530_7470_7504(boundConversion), null, null, destElementTypes[i].Type, f_10530_7544_7569(boundConversion))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7593, 7641);

                            f_10530_7593_7640(fieldAccessorsBuilder, convertedFieldAccess);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10530, 1, 540);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10530, 1, 540);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7680, 7940);

                    return f_10530_7687_7939(syntax, sourceTuple: null, wasTargetTyped: true, f_10530_7789_7831(fieldAccessorsBuilder), ImmutableArray<string?>.Empty, ImmutableArray<bool>.Empty, f_10530_7913_7922(expr), f_10530_7924_7938(expr));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 6165, 7955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 7971, 7983);

                return expr;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 5947, 7994);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_6463_6472(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6463, 6472);
                    return return_v;
                }


                int
                f_10530_6450_6480(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 6450, 6480);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_6522_6531(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6522, 6531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10530_6522_6564(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6522, 6564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_6656_6679(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6656, 6679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_6656_6684(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6656, 6684);
                    return return_v;
                }


                int
                f_10530_6643_6692(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 6643, 6692);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_6734_6757(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6734, 6757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_6734_6762(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6734, 6762);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10530_6734_6776(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6734, 6776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_6823_6877(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 6823, 6877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_6979_7002(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 6979, 7002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_6962_7003(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.LowerConversions(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 6962, 7003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_6913_7024(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.DeferSideEffectingArgumentToTempForTupleEquality(expr, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 6913, 7024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_7217_7305(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                tuple, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = this_param.MakeTupleFieldAccessAndReportUseSiteDiagnostics(tuple, syntax, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 7217, 7305);
                    return return_v;
                }


                bool
                f_10530_7445_7468(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 7445, 7468);
                    return return_v;
                }


                bool
                f_10530_7470_7504(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 7470, 7504);
                    return return_v;
                }


                bool
                f_10530_7544_7569(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 7544, 7569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10530_7355_7570(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked, explicitCastInCode, conversionGroupOpt, constantValueOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 7355, 7570);
                    return return_v;
                }


                int
                f_10530_7593_7640(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 7593, 7640);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_7789_7831(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 7789, 7831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_7913_7922(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 7913, 7922);
                    return return_v;
                }


                bool
                f_10530_7924_7938(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 7924, 7938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10530_7687_7939(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax, sourceTuple: sourceTuple, wasTargetTyped: wasTargetTyped, arguments, argumentNamesOpt, inferredNamesOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 7687, 7939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 5947, 7994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 5947, 7994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ReplaceTerminalElementsWithTemps(
                    BoundExpression expr,
                    TupleBinaryOperatorInfo operators,
                    ArrayBuilder<BoundExpression> initEffects,
                    ArrayBuilder<LocalSymbol> temps)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 8338, 10260);
                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression? tuple = default(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 8605, 9910) || true) && (f_10530_8609_8627(operators) == TupleBinaryOperatorInfoKind.Multiple)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 8605, 9910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 8701, 8766);

                    expr = f_10530_8708_8765(this, expr, initEffects, temps);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 8784, 9895) || true) && (f_10530_8788_8848(this, expr, out tuple))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 8784, 9895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9017, 9076);

                        var
                        multiple = (TupleBinaryOperatorInfo.Multiple)operators
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9098, 9178);

                        var
                        builder = f_10530_9112_9177(tuple.Arguments.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9209, 9214);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9200, 9535) || true) && (i < tuple.Arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9244, 9247)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 9200, 9535))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 9200, 9535);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9297, 9331);

                                var
                                argument = f_10530_9312_9327(tuple)[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9357, 9461);

                                var
                                newArgument = f_10530_9375_9460(this, argument, multiple.Operators[i], initEffects, temps)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9487, 9512);

                                f_10530_9487_9511(builder, newArgument);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10530, 1, 336);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10530, 1, 336);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9559, 9607);

                        var
                        newArguments = f_10530_9578_9606(builder)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 9629, 9876);

                        return f_10530_9636_9875(tuple.Syntax, sourceTuple: null, wasTargetTyped: false, newArguments, ImmutableArray<string?>.Empty, ImmutableArray<bool>.Empty, f_10530_9847_9857(tuple), f_10530_9859_9874(tuple));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 8784, 9895);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 8605, 9910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 10167, 10249);

                return f_10530_10174_10248(this, expr, initEffects, temps);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 8338, 10260);

                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfoKind
                f_10530_8609_8627(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                this_param)
                {
                    var return_v = this_param.InfoKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 8609, 8627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_8708_8765(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.PushDownImplicitTupleConversion(expr, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 8708, 8765);
                    return return_v;
                }


                bool
                f_10530_8788_8848(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, out Microsoft.CodeAnalysis.CSharp.BoundTupleExpression?
                tuple)
                {
                    var return_v = this_param.IsLikeTupleExpression(expr, out tuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 8788, 8848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_9112_9177(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 9112, 9177);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_9312_9327(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 9312, 9327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_9375_9460(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                operators, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.ReplaceTerminalElementsWithTemps(expr, operators, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 9375, 9460);
                    return return_v;
                }


                int
                f_10530_9487_9511(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 9487, 9511);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_9578_9606(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 9578, 9606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_9847_9857(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 9847, 9857);
                    return return_v;
                }


                bool
                f_10530_9859_9874(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 9859, 9874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10530_9636_9875(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax, sourceTuple: sourceTuple, wasTargetTyped: wasTargetTyped, arguments, argumentNamesOpt, inferredNamesOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 9636, 9875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_10174_10248(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.DeferSideEffectingArgumentToTempForTupleEquality(expr, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 10174, 10248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 8338, 10260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 8338, 10260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression DeferSideEffectingArgumentToTempForTupleEquality(
                    BoundExpression expr,
                    ArrayBuilder<BoundExpression> effects,
                    ArrayBuilder<LocalSymbol> temps,
                    bool enclosingConversionWasExplicit = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 10808, 15200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11097, 13879);

                switch (expr)
                {

                    case { ConstantValue: { } }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11193, 11222);

                        return f_10530_11200_11221(this, expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundConversion { Conversion: { Kind: ConversionKind.DefaultLiteral } }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11465, 11530);

                        return f_10530_11472_11529(this, expr, effects, temps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundConversion { Conversion: { Kind: var conversionKind } conversion } bc when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11628, 11698) || true) && (f_10530_11633_11698(bc, conversionKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 11628, 11698) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11832, 11897);

                        return f_10530_11839_11896(this, expr, effects, temps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundConversion { Conversion: { IsUserDefined: true } } conv when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 11981, 12043) || true) && (f_10530_11986_12009(conv) || (DynAbs.Tracing.TraceSender.Expression_False(10530, 11986, 12043) || enclosingConversionWasExplicit)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 11981, 12043) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12161, 12226);

                        return f_10530_12168_12225(this, expr, effects, temps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundConversion conv:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12378, 12538);

                            var
                            deferredOperand = f_10530_12400_12537(this, f_10530_12449_12461(conv), effects, temps, f_10530_12479_12502(conv) || (DynAbs.Tracing.TraceSender.Expression_False(10530, 12479, 12536) || enclosingConversionWasExplicit))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12564, 12607);

                            return f_10530_12571_12606(conv, deferredOperand);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundObjectCreationExpression { Arguments: { Length: 0 }, Type: { } eType } _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12731, 12758) || true) && (f_10530_12736_12758(eType)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 12731, 12758) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12781, 12849);

                        return f_10530_12788_12848(expr.Syntax, f_10530_12818_12836(), f_10530_12838_12847(expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    case BoundObjectCreationExpression { Arguments: { Length: 1 }, Type: { } eType } creation when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 12957, 12984) || true) && (f_10530_12962_12984(eType)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 12957, 12984) || true)
                    :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 13034, 13212);

                            var
                            deferredOperand = f_10530_13056_13211(this, f_10530_13135_13153(creation)[0], effects, temps, enclosingConversionWasExplicit: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 13238, 13663);

                            return f_10530_13245_13662(syntax: expr.Syntax, operand: deferredOperand, conversion: Conversion.MakeNullableConversion(ConversionKind.ImplicitNullable, Conversion.Identity), @checked: false, explicitCastInCode: true, conversionGroupOpt: null, constantValueOpt: null, type: eType, hasErrors: f_10530_13647_13661(expr));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 11097, 13879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 13799, 13864);

                        return f_10530_13806_13863(this, expr, effects, temps);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 11097, 13879);
                }

                bool conversionMustBePerformedOnOriginalExpression(BoundConversion expr, ConversionKind kind)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 13895, 15189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 14171, 15174);

                        switch (kind)
                        {

                            case ConversionKind.AnonymousFunction:       // a lambda cannot be saved without a target type
                            case ConversionKind.MethodGroup:             // similarly for a method group
                            case ConversionKind.InterpolatedString:      // an interpolated string must be saved in interpolated form
                            case ConversionKind.SwitchExpression:        // a switch expression must have its arms converted
                            case ConversionKind.StackAllocToPointerType: // a stack alloc is not well-defined without an enclosing conversion
                            case ConversionKind.ConditionalExpression:   // a conditional expression must have its alternatives converted
                            case ConversionKind.StackAllocToSpanType:
                            case ConversionKind.ObjectCreation:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 14171, 15174);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 15074, 15086);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 14171, 15174);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 14171, 15174);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 15142, 15155);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 14171, 15174);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 13895, 15189);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 13895, 15189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 13895, 15189);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 10808, 15200);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10530_11200_11221(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 11200, 11221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_11472_11529(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentToTemp(arg, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 11472, 11529);
                    return return_v;
                }


                bool
                f_10530_11633_11698(Microsoft.CodeAnalysis.CSharp.BoundConversion
                expr, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind)
                {
                    var return_v = conversionMustBePerformedOnOriginalExpression(expr, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 11633, 11698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_11839_11896(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentToTemp(arg, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 11839, 11896);
                    return return_v;
                }


                bool
                f_10530_11986_12009(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 11986, 12009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_12168_12225(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentToTemp(arg, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12168, 12225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_12449_12461(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 12449, 12461);
                    return return_v;
                }


                bool
                f_10530_12479_12502(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 12479, 12502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_12400_12537(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, bool
                enclosingConversionWasExplicit)
                {
                    var return_v = this_param.DeferSideEffectingArgumentToTempForTupleEquality(expr, effects, temps, enclosingConversionWasExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12400, 12537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10530_12571_12606(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = this_param.UpdateOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12571, 12606);
                    return return_v;
                }


                bool
                f_10530_12736_12758(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12736, 12758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10530_12818_12836()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 12818, 12836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_12838_12847(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 12838, 12847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10530_12788_12848(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral(syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12788, 12848);
                    return return_v;
                }


                bool
                f_10530_12962_12984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 12962, 12984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_13135_13153(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 13135, 13153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_13056_13211(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, bool
                enclosingConversionWasExplicit)
                {
                    var return_v = this_param.DeferSideEffectingArgumentToTempForTupleEquality(expr, effects, temps, enclosingConversionWasExplicit: enclosingConversionWasExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 13056, 13211);
                    return return_v;
                }


                bool
                f_10530_13647_13661(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 13647, 13661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10530_13245_13662(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax: syntax, operand: operand, conversion: conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 13245, 13662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_13806_13863(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.EvaluateSideEffectingArgumentToTemp(arg, effects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 13806, 13863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 10808, 15200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 10808, 15200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteTupleOperator(TupleBinaryOperatorInfo @operator,
                    BoundExpression left, BoundExpression right, TypeSymbol boolType,
                    ArrayBuilder<LocalSymbol> temps, BinaryOperatorKind operatorKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 15212, 16332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 15474, 16321);

                switch (f_10530_15482_15500(@operator))
                {

                    case TupleBinaryOperatorInfoKind.Multiple:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 15474, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 15598, 15722);

                        return f_10530_15605_15721(this, @operator, left, right, boolType, temps, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 15474, 16321);

                    case TupleBinaryOperatorInfoKind.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 15474, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 15804, 15918);

                        return f_10530_15811_15917(this, @operator, left, right, boolType, operatorKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 15474, 16321);

                    case TupleBinaryOperatorInfoKind.NullNull:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 15474, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 16002, 16061);

                        var
                        nullnull = (TupleBinaryOperatorInfo.NullNull)@operator
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 16083, 16195);

                        return f_10530_16090_16194(left.Syntax, f_10530_16120_16183(nullnull.Kind == BinaryOperatorKind.Equal), boolType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 15474, 16321);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 15474, 16321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 16245, 16306);

                        throw f_10530_16251_16305(f_10530_16286_16304(@operator));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 15474, 16321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 15212, 16332);

                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfoKind
                f_10530_15482_15500(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                this_param)
                {
                    var return_v = this_param.InfoKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 15482, 15500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_15605_15721(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                boolType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind)
                {
                    var return_v = this_param.RewriteTupleNestedOperators((Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple)operators, left, right, boolType, temps, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 15605, 15721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_15811_15917(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                single, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                boolType, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind)
                {
                    var return_v = this_param.RewriteTupleSingleOperator((Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Single)single, left, right, boolType, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 15811, 15917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10530_16120_16183(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 16120, 16183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10530_16090_16194(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral(syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 16090, 16194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfoKind
                f_10530_16286_16304(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                this_param)
                {
                    var return_v = this_param.InfoKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 16286, 16304);
                    return return_v;
                }


                System.Exception
                f_10530_16251_16305(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfoKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 16251, 16305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 15212, 16332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 15212, 16332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteTupleNestedOperators(TupleBinaryOperatorInfo.Multiple operators, BoundExpression left, BoundExpression right,
                    TypeSymbol boolType, ArrayBuilder<LocalSymbol> temps, BinaryOperatorKind operatorKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 16344, 21142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 17655, 17718);

                var
                outerEffects = f_10530_17674_17717()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 17732, 17795);

                var
                innerEffects = f_10530_17751_17794()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 17811, 17851);

                BoundExpression
                leftHasValue
                = default(BoundExpression),
                leftValue
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 17865, 17885);

                bool
                isLeftNullable
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 17899, 18031);

                f_10530_17899_18030(this, left, temps, innerEffects, outerEffects, saveHasValue: true, out leftHasValue, out leftValue, out isLeftNullable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 18047, 18089);

                BoundExpression
                rightHasValue
                = default(BoundExpression),
                rightValue
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 18103, 18124);

                bool
                isRightNullable
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 18207, 18344);

                f_10530_18207_18343(this, right, temps, innerEffects, outerEffects, saveHasValue: false, out rightHasValue, out rightValue, out isRightNullable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 18464, 18618);

                BoundExpression
                logicalExpression = f_10530_18500_18617(this, operators, leftValue, rightValue, boolType, temps, innerEffects, operatorKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 18912, 19059);

                BoundExpression
                innerSequence = f_10530_18944_19058(_factory, locals: ImmutableArray<LocalSymbol>.Empty, f_10530_19005_19038(innerEffects), logicalExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19075, 19302) || true) && (!isLeftNullable && (DynAbs.Tracing.TraceSender.Expression_True(10530, 19079, 19114) && !isRightNullable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 19075, 19302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19266, 19287);

                    return innerSequence;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 19075, 19302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19318, 19376);

                bool
                boolValue = operatorKind == BinaryOperatorKind.Equal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19406, 19870) || true) && (f_10530_19410_19437(rightHasValue) == f_10530_19441_19460())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 19406, 19870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19676, 19855);

                    return f_10530_19683_19854(_factory, ImmutableArray<LocalSymbol>.Empty, f_10530_19736_19769(outerEffects), result: (DynAbs.Tracing.TraceSender.Conditional_F1(10530, 19800, 19809) || ((boolValue && DynAbs.Tracing.TraceSender.Conditional_F2(10530, 19812, 19838)) || DynAbs.Tracing.TraceSender.Conditional_F3(10530, 19841, 19853))) ? f_10530_19812_19838(_factory, leftHasValue) : leftHasValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 19406, 19870);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 19886, 20352) || true) && (f_10530_19890_19916(leftHasValue) == f_10530_19920_19939())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 19886, 20352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 20156, 20337);

                    return f_10530_20163_20336(_factory, ImmutableArray<LocalSymbol>.Empty, f_10530_20216_20249(outerEffects), result: (DynAbs.Tracing.TraceSender.Conditional_F1(10530, 20280, 20289) || ((boolValue && DynAbs.Tracing.TraceSender.Conditional_F2(10530, 20292, 20319)) || DynAbs.Tracing.TraceSender.Conditional_F3(10530, 20322, 20335))) ? f_10530_20292_20319(_factory, rightHasValue) : rightHasValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 19886, 20352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 20567, 21094);

                BoundExpression
                outerSequence =
                f_10530_20616_21093(_factory, ImmutableArray<LocalSymbol>.Empty, f_10530_20669_20702(outerEffects), f_10530_20725_21092(_factory, f_10530_20772_20852(_factory, BinaryOperatorKind.Equal, boolType, leftHasValue, rightHasValue), f_10530_20879_20984(_factory, leftHasValue, innerSequence, f_10530_20929_20973(this, right.Syntax, boolValue), boolType), f_10530_21011_21056(this, right.Syntax, !boolValue), boolType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 21110, 21131);

                return outerSequence;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 16344, 21142);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_17674_17717()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 17674, 17717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_17751_17794()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 17751, 17794);
                    return return_v;
                }


                int
                f_10530_17899_18030(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                innerEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                outerEffects, bool
                saveHasValue, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                hasValue, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, out bool
                isNullable)
                {
                    this_param.MakeNullableParts(expr, temps, innerEffects, outerEffects, saveHasValue: saveHasValue, out hasValue, out value, out isNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 17899, 18030);
                    return 0;
                }


                int
                f_10530_18207_18343(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                innerEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                outerEffects, bool
                saveHasValue, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                hasValue, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, out bool
                isNullable)
                {
                    this_param.MakeNullableParts(expr, temps, innerEffects, outerEffects, saveHasValue: saveHasValue, out hasValue, out value, out isNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 18207, 18343);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_18500_18617(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind)
                {
                    var return_v = this_param.RewriteNonNullableNestedTupleOperators(operators, left, right, type, temps, effects, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 18500, 18617);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_19005_19038(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 19005, 19038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_18944_19058(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals: locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 18944, 19058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10530_19410_19437(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 19410, 19437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10530_19441_19460()
                {
                    var return_v = ConstantValue.False;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 19441, 19460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_19736_19769(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 19736, 19769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_19812_19838(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Not(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 19812, 19838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_19683_19854(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result: result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 19683, 19854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10530_19890_19916(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 19890, 19916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10530_19920_19939()
                {
                    var return_v = ConstantValue.False;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 19920, 19939);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_20216_20249(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20216, 20249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20292_20319(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Not(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20292, 20319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20163_20336(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result: result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20163, 20336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_20669_20702(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20669, 20702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10530_20772_20852(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20772, 20852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20929_20973(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                value)
                {
                    var return_v = this_param.MakeBooleanConstant(syntax, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20929, 20973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20879_20984(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Conditional(condition, consequence, alternative, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20879, 20984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_21011_21056(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                value)
                {
                    var return_v = this_param.MakeBooleanConstant(syntax, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 21011, 21056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20725_21092(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Conditional((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, consequence, alternative, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20725, 21092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_20616_21093(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 20616, 21093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 16344, 21142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 16344, 21142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void MakeNullableParts(BoundExpression expr, ArrayBuilder<LocalSymbol> temps, ArrayBuilder<BoundExpression> innerEffects,
                    ArrayBuilder<BoundExpression> outerEffects, bool saveHasValue, out BoundExpression hasValue, out BoundExpression value, out bool isNullable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 21408, 24761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 21716, 21811);

                isNullable = !(expr is BoundTupleExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 21729, 21780) && f_10530_21764_21773(expr) is { }) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 21729, 21810) && f_10530_21784_21810(f_10530_21784_21793(expr)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 21825, 22079) || true) && (!isNullable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 21825, 22079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 21874, 21924);

                    hasValue = f_10530_21885_21923(this, expr.Syntax, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 21942, 22008);

                    expr = f_10530_21949_22007(this, expr, innerEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22026, 22039);

                    value = expr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22057, 22064);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 21825, 22079);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22170, 22619) || true) && (f_10530_22174_22201(expr))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 22170, 22619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22235, 22266);

                    f_10530_22235_22265(f_10530_22248_22257(expr) is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22284, 22335);

                    hasValue = f_10530_22295_22334(this, expr.Syntax, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22505, 22579);

                    value = f_10530_22513_22578(expr.Syntax, f_10530_22553_22577(f_10530_22553_22562(expr)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22597, 22604);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 22170, 22619);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22709, 23165) || true) && (f_10530_22713_22741(expr) is BoundExpression knownValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 22709, 23165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22805, 22855);

                    hasValue = f_10530_22816_22854(this, expr.Syntax, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 22965, 23038);

                    value = f_10530_22973_23037(this, knownValue, innerEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23056, 23088);

                    value = f_10530_23064_23087(this, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23106, 23125);

                    isNullable = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23143, 23150);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 22709, 23165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23226, 23264);

                hasValue = f_10530_23237_23263(expr);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23278, 23394) || true) && (saveHasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 23278, 23394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23328, 23379);

                    hasValue = f_10530_23339_23378(this, hasValue, temps, outerEffects);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 23278, 23394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23410, 23468);

                value = f_10530_23418_23467(this, expr, temps, innerEffects);

                BoundExpression makeNullableHasValue(BoundExpression expr)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 23484, 24750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23664, 23695);

                        f_10530_23664_23694(f_10530_23677_23686(expr) is { });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23713, 24735);

                        switch (expr)
                        {

                            case BoundConversion { Conversion: { IsIdentity: true }, Operand: var o }:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 23713, 24735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 23867, 23898);

                                return f_10530_23874_23897(o);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 23713, 24735);

                            case BoundConversion { Conversion: { IsNullable: true, UnderlyingConversions: var underlying }, Operand: var o }
                                                    when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 24062, 24169) || true) && (f_10530_24067_24093(f_10530_24067_24076(expr)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 24067, 24110) && f_10530_24097_24103(o) is { }) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 24067, 24137) && f_10530_24114_24137(f_10530_24114_24120(o))) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 24067, 24169) && f_10530_24141_24169_M(!underlying[0].IsUserDefined))) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 24062, 24169) || true)
                        :
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 23713, 24735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 24582, 24613);

                                return f_10530_24589_24612(o);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 23713, 24735);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 23713, 24735);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 24669, 24716);

                                return f_10530_24676_24715(this, expr.Syntax, expr);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 23713, 24735);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 23484, 24750);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10530_23677_23686(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 23677, 23686);
                            return return_v;
                        }


                        int
                        f_10530_23664_23694(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23664, 23694);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10530_23874_23897(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expr)
                        {
                            var return_v = makeNullableHasValue(expr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23874, 23897);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10530_24067_24076(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 24067, 24076);
                            return return_v;
                        }


                        bool
                        f_10530_24067_24093(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 24067, 24093);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10530_24097_24103(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 24097, 24103);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10530_24114_24120(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 24114, 24120);
                            return return_v;
                        }


                        bool
                        f_10530_24114_24137(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 24114, 24137);
                            return return_v;
                        }


                        bool
                        f_10530_24141_24169_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 24141, 24169);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10530_24589_24612(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expr)
                        {
                            var return_v = makeNullableHasValue(expr);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 24589, 24612);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10530_24676_24715(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                        this_param, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        expression)
                        {
                            var return_v = this_param.MakeNullableHasValue(syntax, expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 24676, 24715);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 23484, 24750);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 23484, 24750);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 21408, 24761);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_21764_21773(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 21764, 21773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_21784_21793(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 21784, 21793);
                    return return_v;
                }


                bool
                f_10530_21784_21810(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 21784, 21810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_21885_21923(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                value)
                {
                    var return_v = this_param.MakeBooleanConstant(syntax, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 21885, 21923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_21949_22007(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.PushDownImplicitTupleConversion(expr, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 21949, 22007);
                    return return_v;
                }


                bool
                f_10530_22174_22201(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableNeverHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22174, 22201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_22248_22257(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 22248, 22257);
                    return return_v;
                }


                int
                f_10530_22235_22265(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22235, 22265);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_22295_22334(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                value)
                {
                    var return_v = this_param.MakeBooleanConstant(syntax, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22295, 22334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_22553_22562(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 22553, 22562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_22553_22577(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22553, 22577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10530_22513_22578(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22513, 22578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10530_22713_22741(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableAlwaysHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22713, 22741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_22816_22854(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                value)
                {
                    var return_v = this_param.MakeBooleanConstant(syntax, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22816, 22854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_22973_23037(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initEffects, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps)
                {
                    var return_v = this_param.PushDownImplicitTupleConversion(expr, initEffects, temps);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 22973, 23037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_23064_23087(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.LowerConversions(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23064, 23087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_23237_23263(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = makeNullableHasValue(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23237, 23263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10530_23339_23378(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredExpression, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects)
                {
                    var return_v = this_param.MakeTemp(loweredExpression, temps, effects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23339, 23378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_23418_23467(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects)
                {
                    var return_v = this_param.MakeValueOrDefaultTemp(expr, temps, effects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 23418, 23467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 21408, 24761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 21408, 24761);
            }
        }

        private BoundLocal MakeTemp(BoundExpression loweredExpression, ArrayBuilder<LocalSymbol> temps, ArrayBuilder<BoundExpression> effects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 24773, 25159);
                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator assignmentToTemp = default(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 24932, 25036);

                BoundLocal
                temp = f_10530_24950_25035(_factory, loweredExpression, out assignmentToTemp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25050, 25080);

                f_10530_25050_25079(effects, assignmentToTemp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25094, 25122);

                f_10530_25094_25121(temps, f_10530_25104_25120(temp));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25136, 25148);

                return temp;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 24773, 25159);

                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10530_24950_25035(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 24950, 25035);
                    return return_v;
                }


                int
                f_10530_25050_25079(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 25050, 25079);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10530_25104_25120(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 25104, 25120);
                    return return_v;
                }


                int
                f_10530_25094_25121(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 25094, 25121);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 24773, 25159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 24773, 25159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeValueOrDefaultTemp(
                    BoundExpression expr,
                    ArrayBuilder<LocalSymbol> temps,
                    ArrayBuilder<BoundExpression> effects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 25300, 28422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25574, 27993);

                switch (expr)
                {

                    case BoundConversion { Conversion: { IsIdentity: true }, Operand: var o }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 25574, 27993);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25716, 25765);

                        return f_10530_25723_25764(this, o, temps, effects);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 25574, 27993);

                    case BoundConversion { Conversion: { IsNullable: true, UnderlyingConversions: var nested }, Operand: var o } conv when
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 25897, 26085) || true) && (f_10530_25927_25936(expr) is { } exprType && (DynAbs.Tracing.TraceSender.Expression_True(10530, 25927, 25981) && f_10530_25956_25981(exprType)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 25927, 25998) && f_10530_25985_25991(o) is { }) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 25927, 26025) && f_10530_26002_26025(f_10530_26002_26008(o))) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 25927, 26085) && nested[0] is { IsTupleConversion: true } tupleConversion)) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 25897, 26085) || true)
                    :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 25574, 27993);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26135, 26166);

                            f_10530_26135_26165(f_10530_26148_26157(expr) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26192, 26248);

                            var
                            operand = f_10530_26206_26247(this, o, temps, effects)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26274, 26308);

                            f_10530_26274_26307(f_10530_26287_26299(operand) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26334, 26417);

                            var
                            types = f_10530_26346_26416(f_10530_26346_26383(f_10530_26346_26355(expr)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26443, 26519);

                            int
                            tupleCardinality = f_10530_26466_26478(operand).TupleElementTypesWithAnnotations.Length
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26545, 26611);

                            var
                            underlyingConversions = tupleConversion.UnderlyingConversions
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26637, 26700);

                            f_10530_26637_26699(underlyingConversions.Length == tupleCardinality);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26726, 26808);

                            var
                            argumentBuilder = f_10530_26748_26807(tupleCardinality)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26843, 26848);
                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26834, 27069) || true) && (i < tupleCardinality)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26872, 26875)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 26834, 27069))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 26834, 27069);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 26933, 27042);

                                    f_10530_26933_27041(argumentBuilder, f_10530_26953_27040(f_10530_26973_26997(this, operand, i), underlyingConversions[i], types[i], conv));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10530, 1, 236);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10530, 1, 236);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 27095, 27655);

                            return f_10530_27102_27654(f_10530_27102_27619(syntax: operand.Syntax, sourceTuple: null, wasTargetTyped: false, arguments: f_10530_27327_27363(argumentBuilder), argumentNamesOpt: ImmutableArray<string?>.Empty, inferredNamesOpt: ImmutableArray<bool>.Empty, type: f_10530_27553_27562(expr), hasErrors: f_10530_27604_27618(expr)), f_10530_27636_27653(expr));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 27681, 27692);

                            throw null;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 25574, 27993);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 25574, 27993);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 27790, 27877);

                            BoundExpression
                            valueOrDefaultCall = f_10530_27827_27876(this, expr.Syntax, expr)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 27903, 27955);

                            return f_10530_27910_27954(this, valueOrDefaultCall, temps, effects);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 25574, 27993);
                }

                BoundExpression MakeBoundConversion(BoundExpression expr, Conversion conversion, TypeWithAnnotations type, BoundConversion enclosing)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 28011, 28409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 28177, 28394);

                        return f_10530_28184_28393(expr.Syntax, expr, conversion, f_10530_28257_28274(enclosing), f_10530_28276_28304(enclosing), conversionGroupOpt: null, constantValueOpt: null, type: type.Type);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 28011, 28409);

                        bool
                        f_10530_28257_28274(Microsoft.CodeAnalysis.CSharp.BoundConversion
                        this_param)
                        {
                            var return_v = this_param.Checked;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 28257, 28274);
                            return return_v;
                        }


                        bool
                        f_10530_28276_28304(Microsoft.CodeAnalysis.CSharp.BoundConversion
                        this_param)
                        {
                            var return_v = this_param.ExplicitCastInCode;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 28276, 28304);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundConversion
                        f_10530_28184_28393(Microsoft.CodeAnalysis.SyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                        operand, Microsoft.CodeAnalysis.CSharp.Conversion
                        conversion, bool
                        @checked, bool
                        explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                        conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                        constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked, explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 28184, 28393);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 28011, 28409);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 28011, 28409);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 25300, 28422);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_25723_25764(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects)
                {
                    var return_v = this_param.MakeValueOrDefaultTemp(expr, temps, effects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 25723, 25764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_25927_25936(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 25927, 25936);
                    return return_v;
                }


                bool
                f_10530_25956_25981(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 25956, 25981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_25985_25991(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 25985, 25991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_26002_26008(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26002, 26008);
                    return return_v;
                }


                bool
                f_10530_26002_26025(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26002, 26025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_26148_26157(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26148, 26157);
                    return return_v;
                }


                int
                f_10530_26135_26165(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26135, 26165);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_26206_26247(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects)
                {
                    var return_v = this_param.MakeValueOrDefaultTemp(expr, temps, effects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26206, 26247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_26287_26299(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26287, 26299);
                    return return_v;
                }


                int
                f_10530_26274_26307(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26274, 26307);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_26346_26355(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26346, 26355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_26346_26383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26346, 26383);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10530_26346_26416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26346, 26416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_26466_26478(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 26466, 26478);
                    return return_v;
                }


                int
                f_10530_26637_26699(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26637, 26699);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_26748_26807(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26748, 26807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_26973_26997(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                tuple, int
                i)
                {
                    var return_v = this_param.GetTuplePart(tuple, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26973, 26997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_26953_27040(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.BoundConversion
                enclosing)
                {
                    var return_v = MakeBoundConversion(expr, conversion, type, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26953, 27040);
                    return return_v;
                }


                int
                f_10530_26933_27041(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 26933, 27041);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_27327_27363(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 27327, 27363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_27553_27562(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 27553, 27562);
                    return return_v;
                }


                bool
                f_10530_27604_27618(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 27604, 27618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                f_10530_27102_27619(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral?
                sourceTuple, bool
                wasTargetTyped, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral(syntax: syntax, sourceTuple: sourceTuple, wasTargetTyped: wasTargetTyped, arguments: arguments, argumentNamesOpt: argumentNamesOpt, inferredNamesOpt: inferredNamesOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 27102, 27619);
                    return return_v;
                }


                bool
                f_10530_27636_27653(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 27636, 27653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_27102_27654(Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                this_param, bool
                suppress)
                {
                    var return_v = this_param.WithSuppression(suppress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 27102, 27654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_27827_27876(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.MakeOptimizedGetValueOrDefault(syntax, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 27827, 27876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10530_27910_27954(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredExpression, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                effects)
                {
                    var return_v = this_param.MakeTemp(loweredExpression, temps, effects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 27910, 27954);
                    return return_v;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 25300, 28422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 25300, 28422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteNonNullableNestedTupleOperators(TupleBinaryOperatorInfo.Multiple operators,
                    BoundExpression left, BoundExpression right, TypeSymbol type,
                    ArrayBuilder<LocalSymbol> temps, ArrayBuilder<BoundExpression> effects, BinaryOperatorKind operatorKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 28582, 29986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 28906, 28984);

                ImmutableArray<TupleBinaryOperatorInfo>
                nestedOperators = operators.Operators
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29000, 29038);

                BoundExpression?
                currentResult = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29061, 29066);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29052, 29889) || true) && (i < nestedOperators.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29096, 29099)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 29052, 29889))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 29052, 29889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29133, 29185);

                        BoundExpression
                        leftElement = f_10530_29163_29184(this, left, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29203, 29257);

                        BoundExpression
                        rightElement = f_10530_29234_29256(this, right, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29275, 29407);

                        BoundExpression
                        nextLogicalOperand = f_10530_29312_29406(this, nestedOperators[i], leftElement, rightElement, type, temps, operatorKind)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29425, 29874) || true) && (currentResult is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 29425, 29874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29492, 29527);

                            currentResult = nextLogicalOperand;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 29425, 29874);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 29425, 29874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29609, 29743);

                            var
                            logicalOperator = (DynAbs.Tracing.TraceSender.Conditional_F1(10530, 29631, 29671) || ((operatorKind == BinaryOperatorKind.Equal && DynAbs.Tracing.TraceSender.Conditional_F2(10530, 29674, 29707)) || DynAbs.Tracing.TraceSender.Conditional_F3(10530, 29710, 29742))) ? BinaryOperatorKind.LogicalBoolAnd : BinaryOperatorKind.LogicalBoolOr
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29765, 29855);

                            currentResult = f_10530_29781_29854(_factory, logicalOperator, type, currentResult, nextLogicalOperand);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 29425, 29874);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10530, 1, 838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10530, 1, 838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29905, 29940);

                f_10530_29905_29939(currentResult is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 29954, 29975);

                return currentResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 28582, 29986);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_29163_29184(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                tuple, int
                i)
                {
                    var return_v = this_param.GetTuplePart(tuple, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 29163, 29184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_29234_29256(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                tuple, int
                i)
                {
                    var return_v = this_param.GetTuplePart(tuple, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 29234, 29256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_29312_29406(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
                @operator, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                boolType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                temps, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind)
                {
                    var return_v = this_param.RewriteTupleOperator(@operator, left, right, boolType, temps, operatorKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 29312, 29406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10530_29781_29854(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 29781, 29854);
                    return return_v;
                }


                int
                f_10530_29905_29939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 29905, 29939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 28582, 29986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 28582, 29986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression GetTuplePart(BoundExpression tuple, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 30180, 30823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 30330, 30464) || true) && (tuple is BoundTupleExpression tupleExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 30330, 30464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 30413, 30449);

                    return f_10530_30420_30445(tupleExpression)[i];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 30330, 30464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 30480, 30530);

                f_10530_30480_30529(f_10530_30493_30503(tuple) is { IsTupleType: true });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 30707, 30812);

                return f_10530_30714_30811(this, tuple, tuple.Syntax, f_10530_30783_30807(f_10530_30783_30793(tuple))[i]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 30180, 30823);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10530_30420_30445(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 30420, 30445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_30493_30503(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 30493, 30503);
                    return return_v;
                }


                int
                f_10530_30480_30529(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 30480, 30529);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_30783_30793(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 30783, 30793);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10530_30783_30807(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 30783, 30807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_30714_30811(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                tuple, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = this_param.MakeTupleFieldAccessAndReportUseSiteDiagnostics(tuple, syntax, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 30714, 30811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 30180, 30823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 30180, 30823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteTupleSingleOperator(TupleBinaryOperatorInfo.Single single,
                    BoundExpression left, BoundExpression right, TypeSymbol boolType, BinaryOperatorKind operatorKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 31389, 34537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 31800, 31830);

                left = f_10530_31807_31829(this, left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 31844, 31876);

                right = f_10530_31852_31875(this, right);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 31892, 32696) || true) && (f_10530_31896_31919(single.Kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 31892, 32696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32075, 32245);

                    BoundExpression
                    dynamicResult = f_10530_32107_32229(_dynamicFactory, single.Kind, left, right, isCompoundAssignment: false, f_10530_32204_32228(_compilation)).ToExpression()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32263, 32681) || true) && (operatorKind == BinaryOperatorKind.Equal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 32263, 32681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32349, 32472);

                        return f_10530_32356_32471(_factory, f_10530_32369_32470(this, UnaryOperatorKind.DynamicFalse, left.Syntax, method: null, dynamicResult, boolType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 32263, 32681);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 32263, 32681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32554, 32662);

                        return f_10530_32561_32661(this, UnaryOperatorKind.DynamicTrue, left.Syntax, method: null, dynamicResult, boolType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 32263, 32681);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 31892, 32696);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32712, 33005) || true) && (f_10530_32716_32736(left) && (DynAbs.Tracing.TraceSender.Expression_True(10530, 32716, 32761) && f_10530_32740_32761(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 32712, 33005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 32879, 32990);

                    return f_10530_32886_32989(left.Syntax, f_10530_32916_32978(operatorKind == BinaryOperatorKind.Equal), boolType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 32712, 33005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33021, 33180);

                BoundExpression
                binary = f_10530_33046_33179(this, f_10530_33065_33080(_factory), single.Kind, left, right, f_10530_33108_33142_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(single.MethodSymbolOpt, 10530, 33108, 33142)?.ReturnType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10530, 33108, 33154) ?? boolType), single.MethodSymbolOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33194, 33252);

                UnaryOperatorSignature
                boolOperator = single.BoolOperator
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33266, 33319);

                Conversion
                boolConversion = single.ConversionForBool
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33335, 33358);

                BoundExpression
                result
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33372, 34496) || true) && (boolOperator.Kind != UnaryOperatorKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 33372, 34496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33574, 33711);

                    BoundExpression
                    convertedBinary = f_10530_33608_33710(this, f_10530_33627_33642(_factory), binary, boolConversion, boolOperator.OperandType, @checked: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33731, 33811);

                    f_10530_33731_33810(f_10530_33744_33779(boolOperator.ReturnType) == SpecialType.System_Boolean);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33829, 33938);

                    result = f_10530_33838_33937(this, boolOperator.Kind, binary.Syntax, boolOperator.Method, convertedBinary, boolType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 33958, 34093) || true) && (operatorKind == BinaryOperatorKind.Equal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 33958, 34093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34044, 34074);

                        result = f_10530_34053_34073(_factory, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 33958, 34093);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 33372, 34496);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 33372, 34496);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34127, 34496) || true) && (f_10530_34131_34157_M(!boolConversion.IsIdentity))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 34127, 34496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34303, 34399);

                        result = f_10530_34312_34398(this, f_10530_34331_34346(_factory), binary, boolConversion, boolType, @checked: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 34127, 34496);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10530, 34127, 34496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34465, 34481);

                        result = binary;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 34127, 34496);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10530, 33372, 34496);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34512, 34526);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 31389, 34537);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_31807_31829(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.LowerConversions(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 31807, 31829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_31852_31875(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.LowerConversions(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 31852, 31875);
                    return return_v;
                }


                bool
                f_10530_31896_31919(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 31896, 31919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_32204_32228(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DynamicType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 32204, 32228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperation
                f_10530_32107_32229(Microsoft.CodeAnalysis.CSharp.LoweredDynamicOperationFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight, bool
                isCompoundAssignment, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeDynamicBinaryOperator(operatorKind, loweredLeft, loweredRight, isCompoundAssignment: isCompoundAssignment, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32107, 32229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_32369_32470(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeUnaryOperator(kind, syntax, method: method, loweredOperand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32369, 32470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_32356_32471(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Not(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32356, 32471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_32561_32661(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeUnaryOperator(kind, syntax, method: method, loweredOperand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32561, 32661);
                    return return_v;
                }


                bool
                f_10530_32716_32736(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32716, 32736);
                    return return_v;
                }


                bool
                f_10530_32740_32761(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32740, 32761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10530_32916_32978(bool
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32916, 32978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10530_32886_32989(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral(syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 32886, 32989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10530_33065_33080(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 33065, 33080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10530_33108_33142_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 33108, 33142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_33046_33179(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.MakeBinaryOperator(syntax, operatorKind, loweredLeft, loweredRight, type, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 33046, 33179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10530_33627_33642(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 33627, 33642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_33608_33710(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 33608, 33710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10530_33744_33779(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 33744, 33779);
                    return return_v;
                }


                int
                f_10530_33731_33810(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 33731, 33810);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_33838_33937(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeUnaryOperator(kind, syntax, method, loweredOperand, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 33838, 33937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_34053_34073(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Not(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 34053, 34073);
                    return return_v;
                }


                bool
                f_10530_34131_34157_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 34131, 34157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10530_34331_34346(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 34331, 34346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_34312_34398(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 34312, 34398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 31389, 34537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 31389, 34537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression LowerConversions(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10530, 34765, 35278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10530, 34852, 35267);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10530, 34859, 34889) || (((expr is BoundConversion)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10530, 34909, 35242)) || DynAbs.Tracing.TraceSender.Conditional_F3(10530, 35262, 35266))) ? f_10530_34909_35242(this, oldNodeOpt: ((BoundConversion)expr), syntax: ((BoundConversion)expr).Syntax, rewrittenOperand: f_10530_35007_35037(this, f_10530_35024_35036(((BoundConversion)expr))), conversion: f_10530_35072_35087(((BoundConversion)expr)), @checked: f_10530_35099_35111(((BoundConversion)expr)), explicitCastInCode: f_10530_35133_35156(((BoundConversion)expr)), constantValueOpt: f_10530_35197_35215(((BoundConversion)expr)), rewrittenType: f_10530_35232_35241(((BoundConversion)expr))) : expr;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10530, 34765, 35278);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_35024_35036(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35024, 35036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_35007_35037(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.LowerConversions(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 35007, 35037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10530_35072_35087(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35072, 35087);
                    return return_v;
                }


                bool
                f_10530_35099_35111(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35099, 35111);
                    return return_v;
                }


                bool
                f_10530_35133_35156(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35133, 35156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10530_35197_35215(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35197, 35215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10530_35232_35241(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10530, 35232, 35241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10530_34909_35242(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                oldNodeOpt, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.MakeConversionNode(oldNodeOpt: oldNodeOpt, syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10530, 34909, 35242);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10530, 34765, 35278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10530, 34765, 35278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
