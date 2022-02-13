// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalRewriter
    {
        public override BoundNode VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 541, 1628);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 629, 787) || true) && (f_10490_633_652(node) == ConversionKind.InterpolatedString)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 629, 787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 723, 772);

                    return f_10490_730_771(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 629, 787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 803, 844);

                var
                rewrittenType = f_10490_823_843(this, f_10490_833_842(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 860, 909);

                bool
                wasInExpressionLambda = _inExpressionLambda
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 923, 1088);

                _inExpressionLambda = _inExpressionLambda || (DynAbs.Tracing.TraceSender.Expression_False(10490, 945, 1087) || (f_10490_969_988(node) == ConversionKind.AnonymousFunction && (DynAbs.Tracing.TraceSender.Expression_True(10490, 969, 1050) && !wasInExpressionLambda) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 969, 1086) && f_10490_1054_1086(rewrittenType))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1102, 1155);

                var
                rewrittenOperand = f_10490_1125_1154(this, f_10490_1141_1153(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1169, 1213);

                _inExpressionLambda = wasInExpressionLambda;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1229, 1389);

                var
                result = f_10490_1242_1388(this, node, node.Syntax, rewrittenOperand, f_10490_1298_1313(node), f_10490_1315_1327(node), f_10490_1329_1352(node), f_10490_1354_1372(node), rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1405, 1428);

                var
                toType = f_10490_1418_1427(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1442, 1587);

                f_10490_1442_1586(f_10490_1455_1585(result.Type!, toType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1603, 1617);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 541, 1628);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10490_633_652(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 633, 652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_730_771(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    var return_v = this_param.RewriteInterpolatedStringConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 730, 771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_833_842(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 833, 842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_823_843(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 823, 843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10490_969_988(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 969, 988);
                    return return_v;
                }


                bool
                f_10490_1054_1086(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1054, 1086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_1141_1153(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1141, 1153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_1125_1154(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1125, 1154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_1298_1313(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1298, 1313);
                    return return_v;
                }


                bool
                f_10490_1315_1327(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1315, 1327);
                    return return_v;
                }


                bool
                f_10490_1329_1352(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1329, 1352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10490_1354_1372(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1354, 1372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_1242_1388(Microsoft.CodeAnalysis.CSharp.LocalRewriter
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
                    var return_v = this_param.MakeConversionNode(oldNodeOpt, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode, constantValueOpt, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1242, 1388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_1418_1427(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1418, 1427);
                    return return_v;
                }


                bool
                f_10490_1455_1585(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1455, 1585);
                    return return_v;
                }


                int
                f_10490_1442_1586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1442, 1586);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 541, 1628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 541, 1628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsFloatingPointExpressionOfUnknownPrecision(BoundExpression rewrittenNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 1640, 3524);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1759, 1846) || true) && (rewrittenNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 1759, 1846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1818, 1831);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 1759, 1846);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1862, 1963) || true) && (f_10490_1866_1893(rewrittenNode) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 1862, 1963);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1935, 1948);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 1862, 1963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 1979, 2019);

                f_10490_1979_2018(f_10490_1992_2010(rewrittenNode) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2033, 2063);

                var
                type = f_10490_2044_2062(rewrittenNode)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2077, 2237) || true) && (f_10490_2081_2097(type) != SpecialType.System_Double && (DynAbs.Tracing.TraceSender.Expression_True(10490, 2081, 2175) && f_10490_2130_2146(type) != SpecialType.System_Single))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 2077, 2237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2209, 2222);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 2077, 2237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2253, 3413);

                switch (f_10490_2261_2279(rewrittenNode))
                {

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 2253, 3413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2925, 2969);

                        var
                        sequence = (BoundSequence)rewrittenNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 2991, 3058);

                        return f_10490_2998_3057(f_10490_3042_3056(sequence));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 2253, 3413);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 2253, 3413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 3234, 3282);

                        var
                        conversion = (BoundConversion)rewrittenNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 3304, 3398);

                        return f_10490_3311_3336(conversion) == ConversionKind.Identity && (DynAbs.Tracing.TraceSender.Expression_True(10490, 3311, 3397) && f_10490_3367_3397_M(!conversion.ExplicitCastInCode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 2253, 3413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 3501, 3513);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 1640, 3524);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10490_1866_1893(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1866, 1893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_1992_2010(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 1992, 2010);
                    return return_v;
                }


                int
                f_10490_1979_2018(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 1979, 2018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_2044_2062(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 2044, 2062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_2081_2097(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 2081, 2097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_2130_2146(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 2130, 2146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10490_2261_2279(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 2261, 2279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_3042_3056(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 3042, 3056);
                    return return_v;
                }


                bool
                f_10490_2998_3057(Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenNode)
                {
                    var return_v = IsFloatingPointExpressionOfUnknownPrecision(rewrittenNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 2998, 3057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10490_3311_3336(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 3311, 3336);
                    return return_v;
                }


                bool
                f_10490_3367_3397_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 3367, 3397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 1640, 3524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 1640, 3524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeConversionNode(
                    BoundConversion? oldNodeOpt,
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    ConstantValue? constantValueOpt,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 3644, 5275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 4020, 4169);

                var
                result = f_10490_4033_4168(this, oldNodeOpt, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode, constantValueOpt, rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 4183, 4281);

                f_10490_4183_4280(f_10490_4196_4207(result) is { } rt && (DynAbs.Tracing.TraceSender.Expression_True(10490, 4196, 4279) && f_10490_4221_4279(rt, rewrittenType, TypeCompareKind.AllIgnoreOptions)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 4657, 5234) || true) && (!_inExpressionLambda && (DynAbs.Tracing.TraceSender.Expression_True(10490, 4661, 4720) && explicitCastInCode) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 4661, 4792) && f_10490_4741_4792(result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 4657, 5234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 4826, 5219);

                    result = f_10490_4835_5218(syntax, result, Conversion.Identity, isBaseConversion: false, @checked: false, explicitCastInCode: true, conversionGroupOpt: null, constantValueOpt: null, type: f_10490_5206_5217(result));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 4657, 5234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 5250, 5264);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 3644, 5275);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_4033_4168(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
                oldNodeOpt, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.MakeConversionNodeCore(oldNodeOpt, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode, constantValueOpt, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 4033, 4168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_4196_4207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 4196, 4207);
                    return return_v;
                }


                bool
                f_10490_4221_4279(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 4221, 4279);
                    return return_v;
                }


                int
                f_10490_4183_4280(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 4183, 4280);
                    return 0;
                }


                bool
                f_10490_4741_4792(Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenNode)
                {
                    var return_v = IsFloatingPointExpressionOfUnknownPrecision(rewrittenNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 4741, 4792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_5206_5217(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 5206, 5217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_4835_5218(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isBaseConversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, isBaseConversion: isBaseConversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 4835, 5218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 3644, 5275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 3644, 5275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeConversionNodeCore(
            BoundConversion? oldNodeOpt,
            SyntaxNode syntax,
            BoundExpression rewrittenOperand,
            Conversion conversion,
            bool @checked,
            bool explicitCastInCode,
            ConstantValue? constantValueOpt,
            TypeSymbol rewrittenType)
        {
            Debug.Assert(oldNodeOpt == null || oldNodeOpt.Syntax == syntax);
            Debug.Assert(rewrittenType is { });

            if (_inExpressionLambda)
            {
                @checked = @checked && NeedsCheckedConversionInExpressionTree(rewrittenOperand.Type, rewrittenType, explicitCastInCode);
            }

            switch (conversion.Kind)
            {
                case ConversionKind.Identity:
                    Debug.Assert(rewrittenOperand.Type is { });

                    // Spec 6.1.1:
                    //   An identity conversion converts from any type to the same type. 
                    //   This conversion exists such that an entity that already has a required type can be said to be convertible to that type.
                    //   Because object and dynamic are considered equivalent there is an identity conversion between object and dynamic, 
                    //   and between constructed types that are the same when replacing all occurrences of dynamic with object.

                    // Why ignoreDynamic: false?
                    // Lowering phase treats object and dynamic as equivalent types. So we don't need to produce any conversion here,
                    // but we need to change the Type property on the resulting BoundExpression to match the rewrittenType.
                    // This is necessary so that subsequent lowering transformations see that the expression is dynamic.

                    if (_inExpressionLambda || !rewrittenOperand.Type.Equals(rewrittenType, TypeCompareKind.ConsiderEverything))
                    {
                        break;
                    }

                    if (!explicitCastInCode)
                    {
                        return rewrittenOperand;
                    }

                    // 4.1.6 C# spec: To force a value of a floating point type to the exact precision of its type, an explicit cast can be used.
                    // If this is not an identity conversion of a float with unknown precision, strip away the identity conversion.
                    if (!IsFloatingPointExpressionOfUnknownPrecision(rewrittenOperand))
                    {
                        return rewrittenOperand;
                    }

                    break;

                case ConversionKind.ExplicitUserDefined:
                case ConversionKind.ImplicitUserDefined:
                    return RewriteUserDefinedConversion(
                        syntax: syntax,
                        rewrittenOperand: rewrittenOperand,
                        conversion: conversion,
                        rewrittenType: rewrittenType);

                case ConversionKind.IntPtr:
                    return RewriteIntPtrConversion(oldNodeOpt, syntax, rewrittenOperand, conversion, @checked,
                        explicitCastInCode, constantValueOpt, rewrittenType);

                case ConversionKind.ImplicitNullable:
                case ConversionKind.ExplicitNullable:
                    return RewriteNullableConversion(
                        syntax: syntax,
                        rewrittenOperand: rewrittenOperand,
                        conversion: conversion,
                        @checked: @checked,
                        explicitCastInCode: explicitCastInCode,
                        rewrittenType: rewrittenType);

                case ConversionKind.Boxing:

                    if (!_inExpressionLambda)
                    {
                        // We can perform some optimizations if we have a nullable value type
                        // as the operand and we know its nullability:

                        // * (object)new int?() is the same as (object)null
                        // * (object)new int?(123) is the same as (object)123

                        if (NullableNeverHasValue(rewrittenOperand))
                        {
                            return new BoundDefaultExpression(syntax, rewrittenType);
                        }

                        BoundExpression? nullableValue = NullableAlwaysHasValue(rewrittenOperand);
                        if (nullableValue != null)
                        {
                            // Recurse, eliminating the unnecessary ctor.
                            return MakeConversionNode(oldNodeOpt, syntax, nullableValue, conversion, @checked, explicitCastInCode, constantValueOpt, rewrittenType);
                        }
                    }
                    break;

                case ConversionKind.NullLiteral:
                case ConversionKind.DefaultLiteral:
                    if (!_inExpressionLambda || !explicitCastInCode)
                    {
                        return new BoundDefaultExpression(syntax, rewrittenType);
                    }

                    break;

                case ConversionKind.ImplicitReference:
                case ConversionKind.ExplicitReference:
                    if (rewrittenOperand.IsDefaultValue() && (!_inExpressionLambda || !explicitCastInCode))
                    {
                        return new BoundDefaultExpression(syntax, rewrittenType);
                    }

                    break;

                case ConversionKind.ImplicitConstant:
                    // implicit constant conversions under nullable conversions like "byte? x = 1;
                    // are not folded since a constant cannot be nullable.
                    // As a result these conversions can reach here.
                    // Consider them same as unchecked explicit numeric conversions
                    conversion = Conversion.ExplicitNumeric;
                    @checked = false;
                    goto case ConversionKind.ImplicitNumeric;

                case ConversionKind.ImplicitNumeric:
                case ConversionKind.ExplicitNumeric:
                    Debug.Assert(rewrittenOperand.Type is { });
                    if (rewrittenOperand.IsDefaultValue() && (!_inExpressionLambda || !explicitCastInCode))
                    {
                        return new BoundDefaultExpression(syntax, rewrittenType);
                    }

                    if (rewrittenType.SpecialType == SpecialType.System_Decimal || rewrittenOperand.Type.SpecialType == SpecialType.System_Decimal)
                    {
                        return RewriteDecimalConversion(syntax, rewrittenOperand, rewrittenOperand.Type, rewrittenType, @checked, conversion.Kind.IsImplicitConversion(), constantValueOpt);
                    }
                    break;

                case ConversionKind.ImplicitTupleLiteral:
                case ConversionKind.ExplicitTupleLiteral:
                    {
                        Debug.Assert(rewrittenOperand.Type is { });
                        // we keep tuple literal conversions in the tree for the purpose of semantic model (for example when they are casts in the source)
                        // for the purpose of lowering/codegeneration they are identity conversions.
                        Debug.Assert(rewrittenOperand.Type.Equals(rewrittenType, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                        return rewrittenOperand;
                    }

                case ConversionKind.ImplicitThrow:
                    {
                        // the operand must be a bound throw expression
                        var operand = (BoundThrowExpression)rewrittenOperand;
                        return _factory.ThrowExpression(operand.Expression, rewrittenType);
                    }

                case ConversionKind.ImplicitEnumeration:
                    // A conversion from constant zero to nullable is actually classified as an 
                    // implicit enumeration conversion, not an implicit nullable conversion. 
                    // Lower it to (E?)(E)0.
                    if (rewrittenType.IsNullableType())
                    {
                        var operand = MakeConversionNode(
                            oldNodeOpt,
                            syntax,
                            rewrittenOperand,
                            conversion,
                            @checked,
                            explicitCastInCode,
                            constantValueOpt,
                            rewrittenType.GetNullableUnderlyingType());

                        var outerConversion = new Conversion(ConversionKind.ImplicitNullable, Conversion.IdentityUnderlying);
                        return MakeConversionNode(
                            oldNodeOpt,
                            syntax,
                            operand,
                            outerConversion,
                            @checked,
                            explicitCastInCode,
                            constantValueOpt,
                            rewrittenType);
                    }

                    goto case ConversionKind.ExplicitEnumeration;

                case ConversionKind.ExplicitEnumeration:
                    Debug.Assert(rewrittenOperand.Type is { });
                    if (!rewrittenType.IsNullableType() &&
                        rewrittenOperand.IsDefaultValue() &&
                        (!_inExpressionLambda || !explicitCastInCode))
                    {
                        return new BoundDefaultExpression(syntax, rewrittenType);
                    }

                    if (rewrittenType.SpecialType == SpecialType.System_Decimal)
                    {
                        Debug.Assert(rewrittenOperand.Type.IsEnumType());
                        var underlyingTypeFrom = rewrittenOperand.Type.GetEnumUnderlyingType()!;
                        rewrittenOperand = MakeConversionNode(rewrittenOperand, underlyingTypeFrom, false);
                        return RewriteDecimalConversion(syntax, rewrittenOperand, underlyingTypeFrom, rewrittenType, @checked, isImplicit: false, constantValueOpt: constantValueOpt);
                    }
                    else if (rewrittenOperand.Type.SpecialType == SpecialType.System_Decimal)
                    {
                        // This is where we handle conversion from Decimal to Enum: e.g., E e = (E) d;
                        // where 'e' is of type Enum E and 'd' is of type Decimal.
                        // Conversion can be simply done by applying its underlying numeric type to RewriteDecimalConversion(). 

                        Debug.Assert(rewrittenType.IsEnumType());
                        var underlyingTypeTo = rewrittenType.GetEnumUnderlyingType()!;
                        var rewrittenNode = RewriteDecimalConversion(syntax, rewrittenOperand, rewrittenOperand.Type, underlyingTypeTo, @checked, isImplicit: false, constantValueOpt: constantValueOpt);

                        // However, the type of the rewritten node becomes underlying numeric type, not Enum type,
                        // which violates the overall constraint saying the type cannot be changed during rewriting (see LocalRewriter.cs).

                        // Instead of loosening this constraint, we return BoundConversion from underlying numeric type to Enum type,
                        // which will be eliminated during emitting (see EmitEnumConversion): e.g., E e = (E)(int) d;
                        return new BoundConversion(
                            syntax,
                            rewrittenNode,
                            conversion,
                            isBaseConversion: false,
                            @checked: false,
                            explicitCastInCode: explicitCastInCode,
                            conversionGroupOpt: oldNodeOpt?.ConversionGroupOpt,
                            constantValueOpt: constantValueOpt,
                            type: rewrittenType);
                    }

                    break;

                case ConversionKind.ImplicitDynamic:
                case ConversionKind.ExplicitDynamic:
                    Debug.Assert(conversion.Method is null);
                    Debug.Assert(!conversion.IsExtensionMethod);
                    Debug.Assert(constantValueOpt == null);
                    return _dynamicFactory.MakeDynamicConversion(rewrittenOperand, explicitCastInCode || conversion.Kind == ConversionKind.ExplicitDynamic, conversion.IsArrayIndex, @checked, rewrittenType).ToExpression();

                case ConversionKind.ImplicitTuple:
                case ConversionKind.ExplicitTuple:
                    return RewriteTupleConversion(
                        syntax: syntax,
                        rewrittenOperand: rewrittenOperand,
                        conversion: conversion,
                        @checked: @checked,
                        explicitCastInCode: explicitCastInCode,
                        rewrittenType: (NamedTypeSymbol)rewrittenType);

                case ConversionKind.MethodGroup when oldNodeOpt is { Type: { TypeKind: TypeKind.FunctionPointer } funcPtrType }:
                    {
                        var mg = (BoundMethodGroup)rewrittenOperand;
                        Debug.Assert(oldNodeOpt.SymbolOpt is { });
                        return new BoundFunctionPointerLoad(oldNodeOpt.Syntax, oldNodeOpt.SymbolOpt, type: funcPtrType, hasErrors: false);
                    }

                case ConversionKind.MethodGroup:
                    {
                        // we eliminate the method group conversion entirely from the bound nodes following local lowering
                        Debug.Assert(oldNodeOpt is { });
                        var mg = (BoundMethodGroup)rewrittenOperand;
                        var method = oldNodeOpt.SymbolOpt;
                        Debug.Assert(method is { });
                        var oldSyntax = _factory.Syntax;
                        _factory.Syntax = (mg.ReceiverOpt ?? mg).Syntax;
                        var receiver = (!method.RequiresInstanceReceiver && !oldNodeOpt.IsExtensionMethod) ? _factory.Type(method.ContainingType) : mg.ReceiverOpt;
                        Debug.Assert(receiver is { });
                        _factory.Syntax = oldSyntax;
                        return new BoundDelegateCreationExpression(syntax, argument: receiver, methodOpt: method,
                                                                   isExtensionMethod: oldNodeOpt.IsExtensionMethod, type: rewrittenType);
                    }
                default:
                    break;
            }

            return oldNodeOpt != null ?
                oldNodeOpt.Update(
                    rewrittenOperand,
                    conversion,
                    isBaseConversion: oldNodeOpt.IsBaseConversion,
                    @checked: @checked,
                    explicitCastInCode: explicitCastInCode,
                    conversionGroupOpt: oldNodeOpt.ConversionGroupOpt,
                    constantValueOpt: constantValueOpt,
                    type: rewrittenType) :
                new BoundConversion(
                    syntax,
                    rewrittenOperand,
                    conversion,
                    isBaseConversion: false,
                    @checked: @checked,
                    explicitCastInCode: explicitCastInCode,
                    conversionGroupOpt: null, // BoundConversion.ConversionGroup is not used in lowered tree
                    constantValueOpt: constantValueOpt,
                    type: rewrittenType);
        }

        private static bool NeedsCheckedConversionInExpressionTree(TypeSymbol? source, TypeSymbol target, bool explicitCastInCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 21597, 22687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 21744, 21781);

                f_10490_21744_21780((object)target != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 21797, 21877) || true) && (source is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 21797, 21877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 21849, 21862);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 21797, 21877);
                }

                SpecialType GetUnderlyingSpecialType(TypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 21947, 22025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 21967, 22025);
                        return f_10490_21967_22025(f_10490_21967_22013(f_10490_21967_21986(type))); DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 21947, 22025);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 21947, 22025);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 21947, 22025);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                bool IsInRange(SpecialType type, SpecialType low, SpecialType high)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 22110, 22157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 22130, 22157);
                        return low <= type && (DynAbs.Tracing.TraceSender.Expression_True(10490, 22130, 22157) && type <= high); DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 22110, 22157);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 22110, 22157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 22110, 22157);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 22174, 22230);

                SpecialType
                sourceST = f_10490_22197_22229(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 22244, 22300);

                SpecialType
                targetST = f_10490_22267_22299(target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 22440, 22676);

                return (explicitCastInCode || (DynAbs.Tracing.TraceSender.Expression_False(10490, 22448, 22490) || sourceST != targetST)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 22447, 22583) && f_10490_22512_22583(sourceST, SpecialType.System_Char, SpecialType.System_Double)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 22447, 22675) && f_10490_22604_22675(targetST, SpecialType.System_Char, SpecialType.System_UInt64));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 21597, 22687);

                int
                f_10490_21744_21780(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 21744, 21780);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_21967_21986(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 21967, 21986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_21967_22013(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.EnumUnderlyingTypeOrSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 21967, 22013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_21967_22025(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 21967, 22025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_22197_22229(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = GetUnderlyingSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 22197, 22229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_22267_22299(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = GetUnderlyingSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 22267, 22299);
                    return return_v;
                }


                bool
                f_10490_22512_22583(Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.SpecialType
                low, Microsoft.CodeAnalysis.SpecialType
                high)
                {
                    var return_v = IsInRange(type, low, high);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 22512, 22583);
                    return return_v;
                }


                bool
                f_10490_22604_22675(Microsoft.CodeAnalysis.SpecialType
                type, Microsoft.CodeAnalysis.SpecialType
                low, Microsoft.CodeAnalysis.SpecialType
                high)
                {
                    var return_v = IsInRange(type, low, high);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 22604, 22675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 21597, 22687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 21597, 22687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeConversionNode(BoundExpression rewrittenOperand, TypeSymbol rewrittenType, bool @checked, bool acceptFailingConversion = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 23406, 23975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 23586, 23711);

                Conversion
                conversion = f_10490_23610_23710(rewrittenOperand, rewrittenType, _compilation, _diagnostics, acceptFailingConversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 23725, 23842) || true) && (f_10490_23729_23748_M(!conversion.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 23725, 23842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 23782, 23827);

                    return f_10490_23789_23826(_factory, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 23725, 23842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 23858, 23964);

                return f_10490_23865_23963(this, rewrittenOperand.Syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 23406, 23975);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_23610_23710(Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                acceptFailingConversion)
                {
                    var return_v = MakeConversion(rewrittenOperand, rewrittenType, compilation, diagnostics, acceptFailingConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 23610, 23710);
                    return return_v;
                }


                bool
                f_10490_23729_23748_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 23729, 23748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_23789_23826(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 23789, 23826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_23865_23963(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 23865, 23963);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 23406, 23975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 23406, 23975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Conversion MakeConversion(
                    BoundExpression rewrittenOperand,
                    TypeSymbol rewrittenType,
                    CSharpCompilation compilation,
                    DiagnosticBag diagnostics,
                    bool acceptFailingConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 23987, 25304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24266, 24317);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24331, 24374);

                f_10490_24331_24373(f_10490_24344_24365(rewrittenOperand) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24388, 24525);

                Conversion
                conversion = f_10490_24412_24524(f_10490_24412_24435(compilation), f_10490_24463_24484(rewrittenOperand), rewrittenType, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24539, 24600);

                f_10490_24539_24599(diagnostics, rewrittenOperand.Syntax, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24616, 25259) || true) && (f_10490_24620_24639_M(!conversion.IsValid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 24616, 25259);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 24673, 25244) || true) && (!acceptFailingConversion || (DynAbs.Tracing.TraceSender.Expression_False(10490, 24677, 24880) || f_10490_24727_24760(f_10490_24727_24748(rewrittenOperand)) != SpecialType.System_Decimal && (DynAbs.Tracing.TraceSender.Expression_True(10490, 24727, 24880) && f_10490_24816_24849(f_10490_24816_24837(rewrittenOperand)) != SpecialType.System_DateTime)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 24673, 25244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 25006, 25225);

                        f_10490_25006_25224(                    // error CS0029: Cannot implicitly convert type '{0}' to '{1}'
                                            diagnostics, ErrorCode.ERR_NoImplicitConv, f_10490_25103_25135(rewrittenOperand.Syntax), f_10490_25162_25183(rewrittenOperand), rewrittenType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 24673, 25244);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 24616, 25259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 25275, 25293);

                return conversion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 23987, 25304);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_24344_24365(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24344, 24365);
                    return return_v;
                }


                int
                f_10490_24331_24373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 24331, 24373);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10490_24412_24435(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24412, 24435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_24463_24484(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24463, 24484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_24412_24524(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 24412, 24524);
                    return return_v;
                }


                bool
                f_10490_24539_24599(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 24539, 24599);
                    return return_v;
                }


                bool
                f_10490_24620_24639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24620, 24639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_24727_24748(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24727, 24748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_24727_24760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24727, 24760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_24816_24837(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24816, 24837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_24816_24849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 24816, 24849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10490_25103_25135(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 25103, 25135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_25162_25183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 25162, 25183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10490_25006_25224(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 25006, 25224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 23987, 25304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 23987, 25304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression MakeConversionForIOperation(
                    BoundExpression operand,
                    TypeSymbol type,
                    SyntaxNode syntax,
                    CSharpCompilation compilation,
                    DiagnosticBag diagnostics,
                    bool @checked,
                    bool acceptFailingConversion = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 25316, 26566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 25663, 25768);

                Conversion
                conversion = f_10490_25687_25767(operand, type, compilation, diagnostics, acceptFailingConversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 25784, 25873) || true) && (conversion.IsIdentity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 25784, 25873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 25843, 25858);

                    return operand;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 25784, 25873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 26051, 26555);

                return new BoundConversion(
                                            syntax,
                                            operand,
                                            conversion,
                                            @checked: @checked,
                                            explicitCastInCode: false,
                                            conversionGroupOpt: null,
                                            constantValueOpt: null,
                                            type: type,
                                            hasErrors: f_10490_26489_26508_M(!conversion.IsValid))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10490, 26058, 26554) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 25316, 26566);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_25687_25767(Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                acceptFailingConversion)
                {
                    var return_v = MakeConversion(rewrittenOperand, rewrittenType, compilation, diagnostics, acceptFailingConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 25687, 25767);
                    return return_v;
                }


                bool
                f_10490_26489_26508_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 26489, 26508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 25316, 26566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 25316, 26566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeImplicitConversion(BoundExpression rewrittenOperand, TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 27285, 28273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 27416, 27467);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 27481, 27619);

                Conversion
                conversion = f_10490_27505_27618(f_10490_27505_27529(_compilation), f_10490_27557_27578(rewrittenOperand), rewrittenType, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 27633, 27695);

                f_10490_27633_27694(_diagnostics, rewrittenOperand.Syntax, useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 27709, 28133) || true) && (f_10490_27713_27735_M(!conversion.IsImplicit))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 27709, 28133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 27849, 28053);

                    f_10490_27849_28052(                // error CS0029: Cannot implicitly convert type '{0}' to '{1}'
                                    _diagnostics, ErrorCode.ERR_NoImplicitConv, f_10490_27939_27971(rewrittenOperand.Syntax), f_10490_27994_28015(rewrittenOperand), rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 28073, 28118);

                    return f_10490_28080_28117(_factory, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 27709, 28133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 28149, 28262);

                return f_10490_28156_28261(this, rewrittenOperand.Syntax, rewrittenOperand, conversion, rewrittenType, @checked: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 27285, 28273);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10490_27505_27529(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 27505, 27529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_27557_27578(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 27557, 27578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_27505_27618(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 27505, 27618);
                    return return_v;
                }


                bool
                f_10490_27633_27694(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 27633, 27694);
                    return return_v;
                }


                bool
                f_10490_27713_27735_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 27713, 27735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10490_27939_27971(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 27939, 27971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_27994_28015(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 27994, 28015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10490_27849_28052(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 27849, 28052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_28080_28117(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.NullOrDefault(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 28080, 28117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_28156_28261(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked: @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 28156, 28261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 27285, 28273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 27285, 28273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeConversionNode(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    TypeSymbol rewrittenType,
                    bool @checked,
                    bool explicitCastInCode = false,
                    ConstantValue? constantValueOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 28285, 33639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 28634, 28667);

                f_10490_28634_28666(conversion.IsValid);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30127, 33229) || true) && (f_10490_30131_30172(conversion.Kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 30127, 33229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30206, 30245);

                    f_10490_30206_30244(conversion.Method is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30263, 30329);

                    f_10490_30263_30328(conversion.BestUserDefinedConversionAnalysis is { });

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30347, 30838) || true) && (!f_10490_30352_30484(f_10490_30370_30391(rewrittenOperand), conversion.BestUserDefinedConversionAnalysis.FromType, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 30347, 30838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30526, 30819);

                        rewrittenOperand = f_10490_30545_30818(this, syntax, rewrittenOperand, conversion.UserDefinedFromConversion, conversion.BestUserDefinedConversionAnalysis.FromType, @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 30347, 30838);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 30858, 31237) || true) && (!f_10490_30863_30979(f_10490_30881_30902(rewrittenOperand), f_10490_30904_30941(conversion.Method, 0), TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 30858, 31237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 31021, 31218);

                        rewrittenOperand = f_10490_31040_31217(this, rewrittenOperand, conversion.BestUserDefinedConversionAnalysis.FromType, @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 30858, 31237);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 31257, 31334);

                    TypeSymbol
                    userDefinedConversionRewrittenType = f_10490_31305_31333(conversion.Method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 31506, 31549);

                    f_10490_31506_31548(f_10490_31519_31540(rewrittenOperand) is { });

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 31567, 32127) || true) && (f_10490_31571_31609(f_10490_31571_31592(rewrittenOperand)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 31571, 31767) && f_10490_31638_31767(f_10490_31638_31675(conversion.Method, 0), f_10490_31683_31732(f_10490_31683_31704(rewrittenOperand)), TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 31571, 31848) && !f_10490_31797_31848(userDefinedConversionRewrittenType)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 31571, 31923) && f_10490_31877_31923(userDefinedConversionRewrittenType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 31567, 32127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 31965, 32108);

                        userDefinedConversionRewrittenType = f_10490_32002_32107(((NamedTypeSymbol)f_10490_32020_32060(f_10490_32020_32041(rewrittenOperand))), userDefinedConversionRewrittenType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 31567, 32127);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 32147, 32365);

                    BoundExpression
                    userDefined = f_10490_32177_32364(this, syntax, rewrittenOperand, conversion, userDefinedConversionRewrittenType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 32385, 32761) || true) && (!f_10490_32390_32515(f_10490_32408_32424(userDefined), conversion.BestUserDefinedConversionAnalysis.ToType, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 32385, 32761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 32557, 32742);

                        userDefined = f_10490_32571_32741(this, userDefined, conversion.BestUserDefinedConversionAnalysis.ToType, @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 32385, 32761);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 32781, 33175) || true) && (!f_10490_32786_32873(f_10490_32804_32820(userDefined), rewrittenType, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 32781, 33175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 32915, 33156);

                        userDefined = f_10490_32929_33155(this, syntax, userDefined, conversion.UserDefinedToConversion, rewrittenType, @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 32781, 33175);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 33195, 33214);

                    return userDefined;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 30127, 33229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 33245, 33628);

                return f_10490_33252_33627(this, oldNodeOpt: null, syntax: syntax, rewrittenOperand: rewrittenOperand, conversion: conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 28285, 33639);

                int
                f_10490_28634_28666(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 28634, 28666);
                    return 0;
                }


                bool
                f_10490_30131_30172(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsUserDefinedConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30131, 30172);
                    return return_v;
                }


                int
                f_10490_30206_30244(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30206, 30244);
                    return 0;
                }


                int
                f_10490_30263_30328(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30263, 30328);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_30370_30391(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 30370, 30391);
                    return return_v;
                }


                bool
                f_10490_30352_30484(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30352, 30484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_30545_30818(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30545, 30818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_30881_30902(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 30881, 30902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_30904_30941(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30904, 30941);
                    return return_v;
                }


                bool
                f_10490_30863_30979(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 30863, 30979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_31040_31217(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31040, 31217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_31305_31333(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 31305, 31333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_31519_31540(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 31519, 31540);
                    return return_v;
                }


                int
                f_10490_31506_31548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31506, 31548);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_31571_31592(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 31571, 31592);
                    return return_v;
                }


                bool
                f_10490_31571_31609(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31571, 31609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_31638_31675(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31638, 31675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_31683_31704(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 31683, 31704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_31683_31732(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31683, 31732);
                    return return_v;
                }


                bool
                f_10490_31638_31767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31638, 31767);
                    return return_v;
                }


                bool
                f_10490_31797_31848(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 31797, 31848);
                    return return_v;
                }


                bool
                f_10490_31877_31923(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 31877, 31923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_32020_32041(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 32020, 32041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_32020_32060(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 32020, 32060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10490_32002_32107(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32002, 32107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_32177_32364(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.RewriteUserDefinedConversion(syntax, rewrittenOperand, conversion, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32177, 32364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_32408_32424(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 32408, 32424);
                    return return_v;
                }


                bool
                f_10490_32390_32515(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32390, 32515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_32571_32741(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32571, 32741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_32804_32820(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 32804, 32820);
                    return return_v;
                }


                bool
                f_10490_32786_32873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32786, 32873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_32929_33155(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 32929, 33155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_33252_33627(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 33252, 33627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 28285, 33639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 28285, 33639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteTupleConversion(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    NamedTypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 33651, 35259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 33948, 33991);

                f_10490_33948_33990(f_10490_33961_33982(rewrittenOperand) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34005, 34075);

                var
                destElementTypes = f_10490_34028_34074(rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34089, 34131);

                var
                numElements = destElementTypes.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34147, 34208);

                var
                tupleTypeSymbol = (NamedTypeSymbol)f_10490_34186_34207(rewrittenOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34222, 34275);

                var
                srcElementFields = f_10490_34245_34274(tupleTypeSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34289, 34372);

                var
                fieldAccessorsBuilder = f_10490_34317_34371(numElements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34388, 34429);

                BoundAssignmentOperator
                assignmentToTemp
                = default(BoundAssignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34443, 34521);

                var
                savedTuple = f_10490_34460_34520(_factory, rewrittenOperand, out assignmentToTemp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34535, 34593);

                var
                elementConversions = conversion.UnderlyingConversions
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34618, 34623);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34609, 35031) || true) && (i < numElements)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34642, 34645)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 34609, 35031))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 34609, 35031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34679, 34786);

                        var
                        fieldAccess = f_10490_34697_34785(this, savedTuple, syntax, srcElementFields[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34804, 34950);

                        var
                        convertedFieldAccess = f_10490_34831_34949(this, syntax, fieldAccess, elementConversions[i], destElementTypes[i].Type, @checked, explicitCastInCode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 34968, 35016);

                        f_10490_34968_35015(fieldAccessorsBuilder, convertedFieldAccess);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10490, 1, 423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10490, 1, 423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 35047, 35155);

                var
                result = f_10490_35060_35154(this, syntax, rewrittenType, f_10490_35111_35153(fieldAccessorsBuilder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 35169, 35248);

                return f_10490_35176_35247(_factory, f_10490_35198_35220(savedTuple), assignmentToTemp, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 33651, 35259);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_33961_33982(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 33961, 33982);
                    return return_v;
                }


                int
                f_10490_33948_33990(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 33948, 33990);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10490_34028_34074(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 34028, 34074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_34186_34207(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 34186, 34207);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10490_34245_34274(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 34245, 34274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_34317_34371(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 34317, 34371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10490_34460_34520(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 34460, 34520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_34697_34785(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                tuple, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = this_param.MakeTupleFieldAccessAndReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.BoundExpression)tuple, syntax, field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 34697, 34785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_34831_34949(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked, bool
                explicitCastInCode)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked, explicitCastInCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 34831, 34949);
                    return return_v;
                }


                int
                f_10490_34968_35015(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 34968, 35015);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_35111_35153(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 35111, 35153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_35060_35154(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                rewrittenArguments)
                {
                    var return_v = this_param.MakeTupleCreationExpression(syntax, type, rewrittenArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 35060, 35154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10490_35198_35220(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 35198, 35220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_35176_35247(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                temp, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                parts)
                {
                    var return_v = this_param.MakeSequence(temp, parts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 35176, 35247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 33651, 35259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 33651, 35259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NullableNeverHasValue(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 35271, 35577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 35524, 35566);

                return f_10490_35531_35565(expression);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 35271, 35577);

                bool
                f_10490_35531_35565(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 35531, 35565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 35271, 35577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 35271, 35577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression? NullableAlwaysHasValue(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 36117, 38236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36224, 36261);

                f_10490_36224_36260(f_10490_36237_36252(expression) is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36275, 36343) || true) && (!f_10490_36280_36312(f_10490_36280_36295(expression)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 36275, 36343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36331, 36343);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 36275, 36343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36359, 38225);

                switch (expression)
                {

                    case BoundObjectCreationExpression { Arguments: { Length: 1 } args }:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 36359, 38225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36599, 36614);

                        return args[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 36359, 38225);

                    case BoundConversion { Conversion: { Kind: ConversionKind.ImplicitNullable }, Operand: var convertedArgument }
                                        when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 36938, 37039) || true) && (f_10490_36943_37039(convertedArgument.Type!, f_10490_36974_37004(f_10490_36974_36989(expression)), TypeCompareKind.AllIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 36938, 37039) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 36359, 38225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 37062, 37087);

                        return convertedArgument;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 36359, 38225);

                    case BoundConversion { Conversion: { Kind: ConversionKind.ImplicitNullable, UnderlyingConversions: var underlying }, Operand: var convertedArgument } conversion
                                        when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 37412, 37538) || true) && (underlying.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10490, 37417, 37493) && underlying[0].Kind == ConversionKind.ImplicitTuple) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 37417, 37538) && !f_10490_37498_37538(convertedArgument.Type!))) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 37412, 37538) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 36359, 38225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 37561, 38098);

                        return f_10490_37568_38097(syntax: expression.Syntax, operand: convertedArgument, conversion: underlying[0], @checked: f_10490_37781_37799(conversion), explicitCastInCode: f_10490_37846_37875(conversion), conversionGroupOpt: null, constantValueOpt: null, type: f_10490_38008_38038(f_10490_38008_38023(conversion)), hasErrors: f_10490_38076_38096(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 36359, 38225);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 36359, 38225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38198, 38210);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 36359, 38225);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 36117, 38236);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_36237_36252(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 36237, 36252);
                    return return_v;
                }


                int
                f_10490_36224_36260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 36224, 36260);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_36280_36295(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 36280, 36295);
                    return return_v;
                }


                bool
                f_10490_36280_36312(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 36280, 36312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_36974_36989(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 36974, 36989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_36974_37004(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 36974, 37004);
                    return return_v;
                }


                bool
                f_10490_36943_37039(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 36943, 37039);
                    return return_v;
                }


                bool
                f_10490_37498_37538(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 37498, 37538);
                    return return_v;
                }


                bool
                f_10490_37781_37799(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 37781, 37799);
                    return return_v;
                }


                bool
                f_10490_37846_37875(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 37846, 37875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_38008_38023(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 38008, 38023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_38008_38038(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38008, 38038);
                    return return_v;
                }


                bool
                f_10490_38076_38096(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 38076, 38096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_37568_38097(Microsoft.CodeAnalysis.SyntaxNode
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 37568, 38097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 36117, 38236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 36117, 38236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteNullableConversion(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 38248, 41089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38543, 38587);

                f_10490_38543_38586((object)rewrittenType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38603, 38805) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 38603, 38805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38660, 38790);

                    return f_10490_38667_38789(this, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 38603, 38805);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38821, 38878);

                TypeSymbol?
                rewrittenOperandType = f_10490_38856_38877(rewrittenOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38892, 38934);

                f_10490_38892_38933(rewrittenOperandType is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 38948, 39034);

                f_10490_38948_39033(f_10490_38961_38991(rewrittenType) || (DynAbs.Tracing.TraceSender.Expression_False(10490, 38961, 39032) || f_10490_38995_39032(rewrittenOperandType)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39050, 41078) || true) && (f_10490_39054_39091(rewrittenOperandType) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 39054, 39125) && f_10490_39095_39125(rewrittenType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 39050, 41078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39159, 39265);

                    return f_10490_39166_39264(this, syntax, rewrittenOperand, conversion, @checked, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 39050, 41078);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 39050, 41078);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39299, 41078) || true) && (f_10490_39303_39333(rewrittenType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 39299, 41078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39598, 39771);

                        BoundExpression
                        rewrittenConversion = f_10490_39636_39770(this, syntax, rewrittenOperand, conversion.UnderlyingConversions[0], f_10490_39718_39759(rewrittenType), @checked)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39789, 39895);

                        MethodSymbol
                        ctor = f_10490_39809_39894(this, syntax, rewrittenType, SpecialMember.System_Nullable_T__ctor)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 39913, 39989);

                        return f_10490_39920_39988(syntax, ctor, rewrittenConversion);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 39299, 41078);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 39299, 41078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 40391, 40457);

                        BoundExpression?
                        value = f_10490_40416_40456(rewrittenOperand)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 40475, 40940) || true) && (value == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 40475, 40940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 40710, 40832);

                            MethodSymbol
                            get_Value = f_10490_40735_40831(this, syntax, rewrittenOperandType, SpecialMember.System_Nullable_T_get_Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 40854, 40921);

                            value = f_10490_40862_40920(syntax, rewrittenOperand, get_Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 40475, 40940);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 40960, 41063);

                        return f_10490_40967_41062(this, syntax, value, conversion.UnderlyingConversions[0], rewrittenType, @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 39299, 41078);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 39050, 41078);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 38248, 41089);

                int
                f_10490_38543_38586(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38543, 38586);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_38667_38789(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.RewriteLiftedConversionInExpressionTree(syntax, rewrittenOperand, conversion, @checked, explicitCastInCode, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38667, 38789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_38856_38877(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 38856, 38877);
                    return return_v;
                }


                int
                f_10490_38892_38933(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38892, 38933);
                    return 0;
                }


                bool
                f_10490_38961_38991(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38961, 38991);
                    return return_v;
                }


                bool
                f_10490_38995_39032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38995, 39032);
                    return return_v;
                }


                int
                f_10490_38948_39033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 38948, 39033);
                    return 0;
                }


                bool
                f_10490_39054_39091(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39054, 39091);
                    return return_v;
                }


                bool
                f_10490_39095_39125(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39095, 39125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_39166_39264(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.RewriteFullyLiftedBuiltInConversion(syntax, operand, conversion, @checked, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39166, 39264);
                    return return_v;
                }


                bool
                f_10490_39303_39333(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39303, 39333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_39718_39759(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39718, 39759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_39636_39770(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39636, 39770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_39809_39894(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39809, 39894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10490_39920_39988(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 39920, 39988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_40416_40456(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableAlwaysHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 40416, 40456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_40735_40831(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 40735, 40831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_40862_40920(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = BoundCall.Synthesized(syntax, receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 40862, 40920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_40967_41062(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 40967, 41062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 38248, 41089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 38248, 41089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteLiftedConversionInExpressionTree(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 41101, 44045);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41410, 41454);

                f_10490_41410_41453((object)rewrittenType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41468, 41511);

                f_10490_41468_41510(f_10490_41481_41502(rewrittenOperand) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41525, 41581);

                TypeSymbol
                rewrittenOperandType = f_10490_41559_41580(rewrittenOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41595, 41681);

                f_10490_41595_41680(f_10490_41608_41638(rewrittenType) || (DynAbs.Tracing.TraceSender.Expression_False(10490, 41608, 41679) || f_10490_41642_41679(rewrittenOperandType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41697, 41737);

                ConversionGroup?
                conversionGroup = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41816, 41874);

                TypeSymbol
                typeFrom = f_10490_41838_41873(rewrittenOperandType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41888, 41937);

                TypeSymbol
                typeTo = f_10490_41908_41936(rewrittenType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 41951, 44034) || true) && (!f_10490_41956_42028(typeFrom, typeTo, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 41955, 42136) && (f_10490_42033_42053(typeFrom) == SpecialType.System_Decimal || (DynAbs.Tracing.TraceSender.Expression_False(10490, 42033, 42135) || f_10490_42087_42105(typeTo) == SpecialType.System_Decimal))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 41951, 44034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42261, 42302);

                    TypeSymbol
                    typeFromUnderlying = typeFrom
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42320, 42357);

                    TypeSymbol
                    typeToUnderlying = typeTo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42453, 43215) || true) && (f_10490_42457_42478(typeFrom))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 42453, 43215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42520, 42575);

                        typeFromUnderlying = f_10490_42541_42573(typeFrom)!;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42702, 42875);

                        rewrittenOperandType = (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 42725, 42762) || ((f_10490_42725_42762(rewrittenOperandType) && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 42765, 42853)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 42856, 42874))) ? f_10490_42765_42853(((NamedTypeSymbol)f_10490_42783_42822(rewrittenOperandType)), typeFromUnderlying) : typeFromUnderlying;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 42897, 43038);

                        rewrittenOperand = f_10490_42916_43037(syntax, rewrittenOperand, Conversion.ImplicitEnumeration, rewrittenOperandType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 42453, 43215);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 42453, 43215);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43080, 43215) || true) && (f_10490_43084_43103(typeTo))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 43080, 43215);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43145, 43196);

                            typeToUnderlying = f_10490_43164_43194(typeTo)!;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 43080, 43215);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 42453, 43215);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43235, 43368);

                    var
                    method = (MethodSymbol)f_10490_43262_43367(f_10490_43262_43283(_compilation), f_10490_43305_43366(typeFromUnderlying, typeToUnderlying))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43386, 43520);

                    var
                    conversionKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 43407, 43445) || ((f_10490_43407_43445(conversion.Kind) && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 43448, 43482)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 43485, 43519))) ? ConversionKind.ImplicitUserDefined : ConversionKind.ExplicitUserDefined
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43538, 43750);

                    var
                    result = f_10490_43551_43749(syntax, rewrittenOperand, f_10490_43597_43642(conversionKind, method, false), @checked, explicitCastInCode: explicitCastInCode, conversionGroup, constantValueOpt: null, rewrittenType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43768, 43782);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 41951, 44034);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 41951, 44034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 43848, 44019);

                    return f_10490_43855_44018(syntax, rewrittenOperand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroup, constantValueOpt: null, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 41951, 44034);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 41101, 44045);

                int
                f_10490_41410_41453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41410, 41453);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_41481_41502(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 41481, 41502);
                    return return_v;
                }


                int
                f_10490_41468_41510(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41468, 41510);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_41559_41580(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 41559, 41580);
                    return return_v;
                }


                bool
                f_10490_41608_41638(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41608, 41638);
                    return return_v;
                }


                bool
                f_10490_41642_41679(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41642, 41679);
                    return return_v;
                }


                int
                f_10490_41595_41680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41595, 41680);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_41838_41873(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41838, 41873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_41908_41936(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41908, 41936);
                    return return_v;
                }


                bool
                f_10490_41956_42028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 41956, 42028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_42033_42053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 42033, 42053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_42087_42105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 42087, 42105);
                    return return_v;
                }


                bool
                f_10490_42457_42478(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 42457, 42478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_42541_42573(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 42541, 42573);
                    return return_v;
                }


                bool
                f_10490_42725_42762(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 42725, 42762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_42783_42822(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 42783, 42822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10490_42765_42853(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 42765, 42853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_42916_43037(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.SynthesizedNonUserDefined(syntax, operand, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 42916, 43037);
                    return return_v;
                }


                bool
                f_10490_43084_43103(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43084, 43103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_43164_43194(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43164, 43194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10490_43262_43283(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 43262, 43283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_43305_43366(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeFrom, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeTo)
                {
                    var return_v = DecimalConversionMethod(typeFrom, typeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43305, 43366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10490_43262_43367(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.GetSpecialTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43262, 43367);
                    return return_v;
                }


                bool
                f_10490_43407_43445(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43407, 43445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_43597_43642(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, bool
                isExtensionMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43597, 43642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_43551_43749(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt, constantValueOpt: constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43551, 43749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_43855_44018(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt, constantValueOpt: constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 43855, 44018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 41101, 44045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 41101, 44045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteFullyLiftedBuiltInConversion(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool @checked,
                    TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 44057, 46903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 44731, 44837);

                BoundExpression?
                optimized = f_10490_44760_44836(this, syntax, operand, conversion, @checked, type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 44851, 44938) || true) && (optimized != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 44851, 44938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 44906, 44923);

                    return optimized;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 44851, 44938);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45150, 45189);

                BoundAssignmentOperator
                tempAssignment
                = default(BoundAssignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45203, 45269);

                var
                boundTemp = f_10490_45219_45268(_factory, operand, out tempAssignment)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45283, 45314);

                MethodSymbol
                getValueOrDefault
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45330, 45546) || true) && (!f_10490_45335_45453(this, syntax, f_10490_45364_45378(boundTemp), SpecialMember.System_Nullable_T_GetValueOrDefault, out getValueOrDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 45330, 45546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45487, 45531);

                    return f_10490_45494_45530(syntax, type, operand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 45330, 45546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45562, 45630);

                BoundExpression
                condition = f_10490_45590_45629(this, syntax, boundTemp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 45644, 46122);

                BoundExpression
                consequence = f_10490_45674_46121(syntax, f_10490_45751_45827(this, syntax, type, SpecialMember.System_Nullable_T__ctor), f_10490_45846_46120(this, syntax, f_10490_45916_45975(syntax, boundTemp, getValueOrDefault), conversion.UnderlyingConversions[0], f_10490_46056_46088(type), @checked))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 46136, 46207);

                BoundExpression
                alternative = f_10490_46166_46206(syntax, type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 46221, 46584);

                BoundExpression
                conditionalExpression = f_10490_46261_46583(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: type, isRef: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 46600, 46892);

                return f_10490_46607_46891(syntax: syntax, locals: f_10490_46684_46728(f_10490_46706_46727(boundTemp)), sideEffects: f_10490_46760_46814(tempAssignment), value: conditionalExpression, type: type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 44057, 46903);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_44760_44836(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.OptimizeLiftedBuiltInConversion(syntax, operand, conversion, @checked, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 44760, 44836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10490_45219_45268(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45219, 45268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_45364_45378(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 45364, 45378);
                    return return_v;
                }


                bool
                f_10490_45335_45453(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                result)
                {
                    var return_v = this_param.TryGetNullableMethod(syntax, nullableType, member, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45335, 45453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_45494_45530(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                child)
                {
                    var return_v = BadExpression(syntax, resultType, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45494, 45530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_45590_45629(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.MakeNullableHasValue(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45590, 45629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_45751_45827(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45751, 45827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_45916_45975(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = BoundCall.Synthesized(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45916, 45975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_46056_46088(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46056, 46088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_45846_46120(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundCall
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45846, 46120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10490_45674_46121(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 45674, 46121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10490_46166_46206(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46166, 46206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_46261_46583(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenConsequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenAlternative, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                isRef)
                {
                    var return_v = RewriteConditionalOperator(syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46261, 46583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10490_46706_46727(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 46706, 46727);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10490_46684_46728(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46684, 46728);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_46760_46814(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46760, 46814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10490_46607_46891(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 46607, 46891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 44057, 46903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 44057, 46903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? OptimizeLiftedUserDefinedConversion(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 46915, 48086);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47328, 47459) || true) && (f_10490_47332_47362(operand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 47328, 47459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47396, 47444);

                    return f_10490_47403_47443(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 47328, 47459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47619, 47683);

                BoundExpression?
                nonNullValue = f_10490_47651_47682(operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47697, 47966) || true) && (nonNullValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 47697, 47966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47755, 47794);

                    f_10490_47755_47793(conversion.Method is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47812, 47951);

                    return f_10490_47819_47950(this, f_10490_47862_47943(syntax, receiverOpt: null, conversion.Method, nonNullValue), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 47697, 47966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 47982, 48075);

                return f_10490_47989_48074(this, syntax, operand, conversion, false, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 46915, 48086);

                bool
                f_10490_47332_47362(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableNeverHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47332, 47362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10490_47403_47443(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47403, 47443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_47651_47682(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableAlwaysHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47651, 47682);
                    return return_v;
                }


                int
                f_10490_47755_47793(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47755, 47793);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_47862_47943(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = BoundCall.Synthesized(syntax, receiverOpt: receiverOpt, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47862, 47943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_47819_47950(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                call, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeLiftedUserDefinedConversionConsequence(call, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47819, 47950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_47989_48074(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.DistributeLiftedConversionIntoLiftedOperand(syntax, operand, conversion, @checked, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 47989, 48074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 46915, 48086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 46915, 48086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? OptimizeLiftedBuiltInConversion(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool @checked,
                    TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 48098, 49631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48344, 48374);

                f_10490_48344_48373(operand != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48388, 48423);

                f_10490_48388_48422((object)type != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48581, 48712) || true) && (f_10490_48585_48615(operand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 48581, 48712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48649, 48697);

                    return f_10490_48656_48696(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 48581, 48712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48866, 48930);

                BoundExpression?
                nonNullValue = f_10490_48898_48929(operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 48944, 49457) || true) && (nonNullValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 48944, 49457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 49002, 49442);

                    return f_10490_49009_49441(syntax, f_10490_49094_49170(this, syntax, type, SpecialMember.System_Nullable_T__ctor), f_10490_49193_49440(this, syntax, nonNullValue, conversion.UnderlyingConversions[0], f_10490_49372_49404(type), @checked));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 48944, 49457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 49524, 49620);

                return f_10490_49531_49619(this, syntax, operand, conversion, @checked, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 48098, 49631);

                int
                f_10490_48344_48373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 48344, 48373);
                    return 0;
                }


                int
                f_10490_48388_48422(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 48388, 48422);
                    return 0;
                }


                bool
                f_10490_48585_48615(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableNeverHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 48585, 48615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10490_48656_48696(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 48656, 48696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_48898_48929(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableAlwaysHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 48898, 48929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_49094_49170(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 49094, 49170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_49372_49404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 49372, 49404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_49193_49440(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(syntax, rewrittenOperand, conversion, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 49193, 49440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10490_49009_49441(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 49009, 49441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_49531_49619(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.DistributeLiftedConversionIntoLiftedOperand(syntax, operand, conversion, @checked, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 49531, 49619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 48098, 49631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 48098, 49631);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression? DistributeLiftedConversionIntoLiftedOperand(
                    SyntaxNode syntax,
                    BoundExpression operand,
                    Conversion conversion,
                    bool @checked,
                    TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 49643, 53030);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51134, 52991) || true) && (f_10490_51138_51150(operand) == BoundKind.Sequence)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 51134, 52991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51206, 51249);

                    BoundSequence
                    seq = (BoundSequence)operand
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51267, 52976) || true) && (f_10490_51271_51285(f_10490_51271_51280(seq)) == BoundKind.ConditionalOperator)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 51267, 52976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51360, 51435);

                        BoundConditionalOperator
                        conditional = (BoundConditionalOperator)f_10490_51425_51434(seq)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51457, 51554);

                        f_10490_51457_51553(f_10490_51470_51552(f_10490_51488_51496(seq), f_10490_51498_51514(conditional), TypeCompareKind.ConsiderEverything2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51576, 51693);

                        f_10490_51576_51692(f_10490_51589_51691(f_10490_51607_51623(conditional), f_10490_51625_51653(f_10490_51625_51648(conditional)), TypeCompareKind.ConsiderEverything2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51715, 51832);

                        f_10490_51715_51831(f_10490_51728_51830(f_10490_51746_51762(conditional), f_10490_51764_51792(f_10490_51764_51787(conditional)), TypeCompareKind.ConsiderEverything2));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 51856, 52957) || true) && (f_10490_51860_51907(f_10490_51883_51906(conditional)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10490, 51860, 51965) && f_10490_51919_51965(f_10490_51941_51964(conditional))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 51856, 52957);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 52015, 52934);

                            return f_10490_52022_52933(seq.Syntax, f_10490_52111_52121(seq), f_10490_52152_52167(seq), f_10490_52198_52897(conditional.Syntax, f_10490_52312_52333(conditional), f_10490_52368_52541(this, null, syntax, f_10490_52401_52424(conditional), conversion, @checked, explicitCastInCode: false, constantValueOpt: ConstantValue.NotAvailable, rewrittenType: type), f_10490_52576_52749(this, null, syntax, f_10490_52609_52632(conditional), conversion, @checked, explicitCastInCode: false, constantValueOpt: ConstantValue.NotAvailable, rewrittenType: type), ConstantValue.NotAvailable, type, isRef: false), type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 51856, 52957);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 51267, 52976);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 51134, 52991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53007, 53019);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 49643, 53030);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10490_51138_51150(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51138, 51150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51271_51280(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51271, 51280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10490_51271_51285(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51271, 51285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51425_51434(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51425, 51434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_51488_51496(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51488, 51496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_51498_51514(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51498, 51514);
                    return return_v;
                }


                bool
                f_10490_51470_51552(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51470, 51552);
                    return return_v;
                }


                int
                f_10490_51457_51553(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51457, 51553);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_51607_51623(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51607, 51623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51625_51648(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51625, 51648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_51625_51653(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51625, 51653);
                    return return_v;
                }


                bool
                f_10490_51589_51691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51589, 51691);
                    return return_v;
                }


                int
                f_10490_51576_51692(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51576, 51692);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_51746_51762(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51746, 51762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51764_51787(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51764, 51787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_51764_51792(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51764, 51792);
                    return return_v;
                }


                bool
                f_10490_51728_51830(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51728, 51830);
                    return return_v;
                }


                int
                f_10490_51715_51831(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51715, 51831);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51883_51906(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51883, 51906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_51860_51907(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableAlwaysHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51860, 51907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_51941_51964(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 51941, 51964);
                    return return_v;
                }


                bool
                f_10490_51919_51965(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = NullableNeverHasValue(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 51919, 51965);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10490_52111_52121(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 52111, 52121);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_52152_52167(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 52152, 52167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52312_52333(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 52312, 52333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52401_52424(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 52401, 52424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52368_52541(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
                oldNodeOpt, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.MakeConversionNode(oldNodeOpt, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode: explicitCastInCode, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 52368, 52541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52609_52632(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 52609, 52632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52576_52749(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion?
                oldNodeOpt, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.MakeConversionNode(oldNodeOpt, syntax, rewrittenOperand, conversion, @checked, explicitCastInCode: explicitCastInCode, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 52576, 52749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_52198_52897(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenConsequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenAlternative, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                isRef)
                {
                    var return_v = RewriteConditionalOperator(syntax, rewrittenCondition, rewrittenConsequence, rewrittenAlternative, constantValueOpt, rewrittenType, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 52198, 52897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10490_52022_52933(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax, locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 52022, 52933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 49643, 53030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 49643, 53030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteUserDefinedConversion(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 53042, 54890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53274, 53388);

                f_10490_53274_53387(conversion.Method is { } && (DynAbs.Tracing.TraceSender.Expression_True(10490, 53287, 53345) && f_10490_53315_53345_M(!conversion.Method.ReturnsVoid)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 53287, 53386) && f_10490_53349_53381(conversion.Method) == 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53402, 53445);

                f_10490_53402_53444(f_10490_53415_53436(rewrittenOperand) is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53459, 53997) || true) && (f_10490_53463_53501(f_10490_53463_53484(rewrittenOperand)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 53459, 53997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53535, 53593);

                    var
                    parameterType = f_10490_53555_53592(conversion.Method, 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53611, 53982) || true) && (f_10490_53615_53720(parameterType, f_10490_53636_53685(f_10490_53636_53657(rewrittenOperand)), TypeCompareKind.AllIgnoreOptions) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 53615, 53776) && !f_10490_53746_53776(parameterType)) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 53615, 53826) && f_10490_53801_53826(parameterType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 53611, 53982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 53868, 53963);

                        return f_10490_53875_53962(this, syntax, rewrittenOperand, conversion, rewrittenType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 53611, 53982);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 53459, 53997);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54088, 54331) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 54088, 54331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54145, 54316);

                    return f_10490_54152_54315(syntax, rewrittenOperand, conversion, false, explicitCastInCode: true, conversionGroupOpt: null, constantValueOpt: null, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 54088, 54331);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54347, 54613) || true) && ((f_10490_54352_54383(f_10490_54352_54373(rewrittenOperand))) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 54351, 54434) && f_10490_54388_54434(_compilation, rewrittenType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 54347, 54613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54468, 54598);

                    return new BoundReadOnlySpanFromArray(syntax, rewrittenOperand, conversion.Method, rewrittenType) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10490, 54475, 54597) };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 54347, 54613);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54629, 54740);

                BoundExpression
                result = f_10490_54654_54739(syntax, receiverOpt: null, conversion.Method, rewrittenOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54754, 54851);

                f_10490_54754_54850(f_10490_54767_54849(f_10490_54785_54796(result), rewrittenType, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 54865, 54879);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 53042, 54890);

                bool
                f_10490_53315_53345_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53315, 53345);
                    return return_v;
                }


                int
                f_10490_53349_53381(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53349, 53381);
                    return return_v;
                }


                int
                f_10490_53274_53387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53274, 53387);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_53415_53436(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53415, 53436);
                    return return_v;
                }


                int
                f_10490_53402_53444(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53402, 53444);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_53463_53484(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53463, 53484);
                    return return_v;
                }


                bool
                f_10490_53463_53501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53463, 53501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_53555_53592(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53555, 53592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_53636_53657(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53636, 53657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_53636_53685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53636, 53685);
                    return return_v;
                }


                bool
                f_10490_53615_53720(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53615, 53720);
                    return return_v;
                }


                bool
                f_10490_53746_53776(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53746, 53776);
                    return return_v;
                }


                bool
                f_10490_53801_53826(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 53801, 53826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_53875_53962(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.RewriteLiftedUserDefinedConversion(syntax, rewrittenOperand, conversion, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 53875, 53962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_54152_54315(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54152, 54315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_54352_54373(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 54352, 54373);
                    return return_v;
                }


                bool
                f_10490_54352_54383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54352, 54383);
                    return return_v;
                }


                bool
                f_10490_54388_54434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.IsReadOnlySpanType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54388, 54434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_54654_54739(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = BoundCall.Synthesized(syntax, receiverOpt: receiverOpt, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54654, 54739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_54785_54796(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 54785, 54796);
                    return return_v;
                }


                bool
                f_10490_54767_54849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54767, 54849);
                    return return_v;
                }


                int
                f_10490_54754_54850(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 54754, 54850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 53042, 54890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 53042, 54890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeLiftedUserDefinedConversionConsequence(BoundCall call, TypeSymbol resultType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 54902, 55545);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55032, 55506) || true) && (f_10490_55036_55083(f_10490_55036_55058(f_10490_55036_55047(call))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 55032, 55506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55117, 55281);

                    f_10490_55117_55280(f_10490_55130_55157(resultType) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 55130, 55279) && f_10490_55161_55279(f_10490_55179_55217(resultType), f_10490_55219_55241(f_10490_55219_55230(call)), TypeCompareKind.ConsiderEverything2)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55299, 55407);

                    MethodSymbol
                    ctor = f_10490_55319_55406(this, call.Syntax, resultType, SpecialMember.System_Nullable_T__ctor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55425, 55491);

                    return f_10490_55432_55490(call.Syntax, ctor, call);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 55032, 55506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55522, 55534);

                return call;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 54902, 55545);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_55036_55047(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55036, 55047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_55036_55058(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55036, 55058);
                    return return_v;
                }


                bool
                f_10490_55036_55083(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55036, 55083);
                    return return_v;
                }


                bool
                f_10490_55130_55157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55130, 55157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_55179_55217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55179, 55217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_55219_55230(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55219, 55230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_55219_55241(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55219, 55241);
                    return return_v;
                }


                bool
                f_10490_55161_55279(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55161, 55279);
                    return return_v;
                }


                int
                f_10490_55117_55280(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55117, 55280);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_55319_55406(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55319, 55406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10490_55432_55490(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression(syntax, constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55432, 55490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 54902, 55545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 54902, 55545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteLiftedUserDefinedConversion(
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 55557, 59788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55795, 55838);

                f_10490_55795_55837(f_10490_55808_55829(rewrittenOperand) is { });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55852, 56201) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 55852, 56201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 55909, 56003);

                    Conversion
                    conv = f_10490_55927_56002(this, syntax, conversion, f_10490_55965_55986(rewrittenOperand), rewrittenType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 56021, 56186);

                    return f_10490_56028_56185(syntax, rewrittenOperand, conv, false, explicitCastInCode: true, conversionGroupOpt: null, constantValueOpt: null, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 55852, 56201);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 56779, 56823);

                f_10490_56779_56822((object)rewrittenType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 56837, 56890);

                f_10490_56837_56889(f_10490_56850_56888(f_10490_56850_56871(rewrittenOperand)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 56906, 57024);

                BoundExpression?
                optimized = f_10490_56935_57023(this, syntax, rewrittenOperand, conversion, rewrittenType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 57038, 57125) || true) && (optimized != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 57038, 57125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 57093, 57110);

                    return optimized;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 57038, 57125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 57763, 57802);

                BoundAssignmentOperator
                tempAssignment
                = default(BoundAssignmentOperator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 57816, 57898);

                BoundLocal
                boundTemp = f_10490_57839_57897(_factory, rewrittenOperand, out tempAssignment)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 57912, 58044);

                MethodSymbol
                getValueOrDefault = f_10490_57945_58043(this, syntax, f_10490_57977_57991(boundTemp), SpecialMember.System_Nullable_T_GetValueOrDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58090, 58158);

                BoundExpression
                condition = f_10490_58118_58157(this, syntax, boundTemp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58215, 58309);

                BoundCall
                callGetValueOrDefault = f_10490_58249_58308(syntax, boundTemp, getValueOrDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58379, 58418);

                f_10490_58379_58417(conversion.Method is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58432, 58551);

                BoundCall
                userDefinedCall = f_10490_58460_58550(syntax, receiverOpt: null, conversion.Method, callGetValueOrDefault)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58628, 58733);

                BoundExpression
                consequence = f_10490_58658_58732(this, userDefinedCall, rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58777, 58857);

                BoundExpression
                alternative = f_10490_58807_58856(syntax, rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 58965, 59337);

                BoundExpression
                conditionalExpression = f_10490_59005_59336(syntax: syntax, rewrittenCondition: condition, rewrittenConsequence: consequence, rewrittenAlternative: alternative, constantValueOpt: null, rewrittenType: rewrittenType, isRef: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 59476, 59777);

                return f_10490_59483_59776(syntax: syntax, locals: f_10490_59560_59604(f_10490_59582_59603(boundTemp)), sideEffects: f_10490_59636_59690(tempAssignment), value: conditionalExpression, type: rewrittenType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 55557, 59788);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_55808_55829(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55808, 55829);
                    return return_v;
                }


                int
                f_10490_55795_55837(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55795, 55837);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_55965_55986(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 55965, 55986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_55927_56002(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, conversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 55927, 56002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_56028_56185(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 56028, 56185);
                    return return_v;
                }


                int
                f_10490_56779_56822(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 56779, 56822);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_56850_56871(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 56850, 56871);
                    return return_v;
                }


                bool
                f_10490_56850_56888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 56850, 56888);
                    return return_v;
                }


                int
                f_10490_56837_56889(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 56837, 56889);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10490_56935_57023(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.OptimizeLiftedUserDefinedConversion(syntax, operand, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 56935, 57023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10490_57839_57897(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 57839, 57897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_57977_57991(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 57977, 57991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10490_57945_58043(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nullableType, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.UnsafeGetNullableMethod(syntax, nullableType, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 57945, 58043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_58118_58157(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.MakeNullableHasValue(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58118, 58157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_58249_58308(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = BoundCall.Synthesized(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58249, 58308);
                    return return_v;
                }


                int
                f_10490_58379_58417(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58379, 58417);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_58460_58550(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundCall
                arg0)
                {
                    var return_v = BoundCall.Synthesized(syntax, receiverOpt: receiverOpt, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58460, 58550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_58658_58732(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                call, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType)
                {
                    var return_v = this_param.MakeLiftedUserDefinedConversionConsequence(call, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58658, 58732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression
                f_10490_58807_58856(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 58807, 58856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_59005_59336(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenCondition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenConsequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenAlternative, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                isRef)
                {
                    var return_v = RewriteConditionalOperator(syntax: syntax, rewrittenCondition: rewrittenCondition, rewrittenConsequence: rewrittenConsequence, rewrittenAlternative: rewrittenAlternative, constantValueOpt: constantValueOpt, rewrittenType: rewrittenType, isRef: isRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 59005, 59336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10490_59582_59603(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 59582, 59603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10490_59560_59604(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 59560, 59604);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_59636_59690(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 59636, 59690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10490_59483_59776(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax: syntax, locals: locals, sideEffects: sideEffects, value: value, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 59483, 59776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 55557, 59788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 55557, 59788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteIntPtrConversion(
                    BoundConversion? oldNode,
                    SyntaxNode syntax,
                    BoundExpression rewrittenOperand,
                    Conversion conversion,
                    bool @checked,
                    bool explicitCastInCode,
                    ConstantValue? constantValueOpt,
                    TypeSymbol rewrittenType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 59800, 62252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60178, 60217);

                f_10490_60178_60216(rewrittenOperand != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60231, 60275);

                f_10490_60231_60274((object)rewrittenType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60289, 60332);

                f_10490_60289_60331(f_10490_60302_60323(rewrittenOperand) is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60348, 60390);

                TypeSymbol
                source = f_10490_60368_60389(rewrittenOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60404, 60438);

                TypeSymbol
                target = rewrittenType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60454, 60542);

                SpecialMember
                member = f_10490_60477_60541(source: source, target: rewrittenType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60556, 60576);

                MethodSymbol
                method
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60592, 60759) || true) && (!f_10490_60597_60648(this, syntax, member, out method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 60592, 60759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60682, 60744);

                    return f_10490_60689_60743(syntax, rewrittenType, rewrittenOperand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 60592, 60759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60775, 60809);

                f_10490_60775_60808(f_10490_60788_60807_M(!method.ReturnsVoid));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60823, 60864);

                f_10490_60823_60863(f_10490_60836_60857(method) == 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60880, 60932);

                conversion = conversion.SetConversionMethod(method);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 60948, 61386) || true) && (f_10490_60952_60975(source) && (DynAbs.Tracing.TraceSender.Expression_True(10490, 60952, 61002) && f_10490_60979_61002(target)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 60948, 61386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61036, 61074);

                    f_10490_61036_61073(f_10490_61049_61072(target));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61092, 61187);

                    return f_10490_61099_61186(this, syntax, rewrittenOperand, conversion, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 60948, 61386);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 60948, 61386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61221, 61386) || true) && (f_10490_61225_61248(source))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 61221, 61386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61282, 61371);

                        rewrittenOperand = f_10490_61301_61370(this, rewrittenOperand, f_10490_61338_61359(source), @checked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 61221, 61386);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 60948, 61386);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61402, 61496);

                rewrittenOperand = f_10490_61421_61495(this, rewrittenOperand, f_10490_61458_61484(method, 0), @checked);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61512, 61547);

                var
                returnType = f_10490_61529_61546(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61561, 61602);

                f_10490_61561_61601((object)returnType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61618, 61872) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 61618, 61872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61675, 61857);

                    return f_10490_61682_61856(syntax, rewrittenOperand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: null, constantValueOpt, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 61618, 61872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 61888, 62159);

                var
                rewrittenCall = f_10490_61908_62158(this, syntax: syntax, rewrittenReceiver: null, method: method, rewrittenArguments: f_10490_62079_62118(rewrittenOperand), type: returnType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62175, 62241);

                return f_10490_62182_62240(this, rewrittenCall, rewrittenType, @checked);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 59800, 62252);

                int
                f_10490_60178_60216(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60178, 60216);
                    return 0;
                }


                int
                f_10490_60231_60274(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60231, 60274);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_60302_60323(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 60302, 60323);
                    return return_v;
                }


                int
                f_10490_60289_60331(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60289, 60331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_60368_60389(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 60368, 60389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_60477_60541(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = GetIntPtrConversionMethod(source: source, target: target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60477, 60541);
                    return return_v;
                }


                bool
                f_10490_60597_60648(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.TryGetSpecialTypeMethod(syntax, specialMember, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60597, 60648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_60689_60743(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                resultType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                child)
                {
                    var return_v = BadExpression(syntax, resultType, child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60689, 60743);
                    return return_v;
                }


                bool
                f_10490_60788_60807_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 60788, 60807);
                    return return_v;
                }


                int
                f_10490_60775_60808(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60775, 60808);
                    return 0;
                }


                int
                f_10490_60836_60857(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 60836, 60857);
                    return return_v;
                }


                int
                f_10490_60823_60863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60823, 60863);
                    return 0;
                }


                bool
                f_10490_60952_60975(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60952, 60975);
                    return return_v;
                }


                bool
                f_10490_60979_61002(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 60979, 61002);
                    return return_v;
                }


                bool
                f_10490_61049_61072(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61049, 61072);
                    return return_v;
                }


                int
                f_10490_61036_61073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61036, 61073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_61099_61186(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType)
                {
                    var return_v = this_param.RewriteLiftedUserDefinedConversion(syntax, rewrittenOperand, conversion, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61099, 61186);
                    return return_v;
                }


                bool
                f_10490_61225_61248(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61225, 61248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_61338_61359(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61338, 61359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_61301_61370(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61301, 61370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_61458_61484(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61458, 61484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_61421_61495(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61421, 61495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_61529_61546(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 61529, 61546);
                    return return_v;
                }


                int
                f_10490_61561_61601(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61561, 61601);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_61682_61856(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = BoundConversion.Synthesized(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61682, 61856);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10490_62079_62118(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62079, 62118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_61908_62158(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                rewrittenArguments, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeCall(syntax: syntax, rewrittenReceiver: rewrittenReceiver, method: method, rewrittenArguments: rewrittenArguments, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 61908, 62158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_62182_62240(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62182, 62240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 59800, 62252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 59800, 62252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SpecialMember GetIntPtrConversionMethod(TypeSymbol source, TypeSymbol target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 62264, 67405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62380, 62417);

                f_10490_62380_62416((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62431, 62468);

                f_10490_62431_62467((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62484, 62522);

                TypeSymbol
                t0 = f_10490_62500_62521(target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62536, 62574);

                TypeSymbol
                s0 = f_10490_62552_62573(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62590, 62686);

                SpecialType
                t0Type = (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 62611, 62626) || ((f_10490_62611_62626(t0) && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 62629, 62668)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 62671, 62685))) ? f_10490_62629_62668(f_10490_62629_62655(t0)!) : f_10490_62671_62685(t0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62700, 62796);

                SpecialType
                s0Type = (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 62721, 62736) || ((f_10490_62721_62736(s0) && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 62739, 62778)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 62781, 62795))) ? f_10490_62739_62778(f_10490_62739_62765(s0)!) : f_10490_62781_62795(s0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62812, 67341) || true) && (t0Type == SpecialType.System_IntPtr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 62812, 67341);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62885, 63045) || true) && (f_10490_62889_62924(source))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 62885, 63045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 62966, 63026);

                        return SpecialMember.System_IntPtr__op_Explicit_FromPointer;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 62885, 63045);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 63065, 63915);

                    switch (s0Type)
                    {

                        case SpecialType.System_Byte:
                        case SpecialType.System_SByte:
                        case SpecialType.System_Int16:
                        case SpecialType.System_UInt16:
                        case SpecialType.System_Char:
                        case SpecialType.System_Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 63065, 63915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 63436, 63494);

                            return SpecialMember.System_IntPtr__op_Explicit_FromInt32;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 63065, 63915);

                        case SpecialType.System_UInt32:
                        case SpecialType.System_UInt64:
                        case SpecialType.System_Int64:
                        case SpecialType.System_Single:
                        case SpecialType.System_Double:
                        case SpecialType.System_Decimal:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 63065, 63915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 63838, 63896);

                            return SpecialMember.System_IntPtr__op_Explicit_FromInt64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 63065, 63915);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 62812, 67341);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 62812, 67341);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 63949, 67341) || true) && (t0Type == SpecialType.System_UIntPtr)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 63949, 67341);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 64023, 64184) || true) && (f_10490_64027_64062(source))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 64023, 64184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 64104, 64165);

                            return SpecialMember.System_UIntPtr__op_Explicit_FromPointer;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 64023, 64184);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 64204, 65058);

                        switch (s0Type)
                        {

                            case SpecialType.System_Byte:
                            case SpecialType.System_UInt16:
                            case SpecialType.System_Char:
                            case SpecialType.System_UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 64204, 65058);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 64472, 64532);

                                return SpecialMember.System_UIntPtr__op_Explicit_FromUInt32;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 64204, 65058);

                            case SpecialType.System_SByte:
                            case SpecialType.System_Int16:
                            case SpecialType.System_Int32:
                            case SpecialType.System_UInt64:
                            case SpecialType.System_Int64:
                            case SpecialType.System_Single:
                            case SpecialType.System_Double:
                            case SpecialType.System_Decimal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 64204, 65058);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 64979, 65039);

                                return SpecialMember.System_UIntPtr__op_Explicit_FromUInt64;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 64204, 65058);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 63949, 67341);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 63949, 67341);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 65092, 67341) || true) && (s0Type == SpecialType.System_IntPtr)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 65092, 67341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 65165, 65323) || true) && (f_10490_65169_65204(target))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 65165, 65323);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 65246, 65304);

                                return SpecialMember.System_IntPtr__op_Explicit_ToPointer;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 65165, 65323);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 65343, 66189);

                            switch (t0Type)
                            {

                                case SpecialType.System_Byte:
                                case SpecialType.System_SByte:
                                case SpecialType.System_Int16:
                                case SpecialType.System_UInt16:
                                case SpecialType.System_Char:
                                case SpecialType.System_UInt32:
                                case SpecialType.System_Int32:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 65343, 66189);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 65767, 65823);

                                    return SpecialMember.System_IntPtr__op_Explicit_ToInt32;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 65343, 66189);

                                case SpecialType.System_UInt64:
                                case SpecialType.System_Int64:
                                case SpecialType.System_Single:
                                case SpecialType.System_Double:
                                case SpecialType.System_Decimal:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 65343, 66189);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66114, 66170);

                                    return SpecialMember.System_IntPtr__op_Explicit_ToInt64;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 65343, 66189);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 65092, 67341);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 65092, 67341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66223, 67341) || true) && (s0Type == SpecialType.System_UIntPtr)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 66223, 67341);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66297, 66456) || true) && (f_10490_66301_66336(target))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 66297, 66456);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66378, 66437);

                                    return SpecialMember.System_UIntPtr__op_Explicit_ToPointer;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 66297, 66456);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66476, 67326);

                                switch (t0Type)
                                {

                                    case SpecialType.System_SByte:
                                    case SpecialType.System_Int16:
                                    case SpecialType.System_Int32:
                                    case SpecialType.System_Byte:
                                    case SpecialType.System_UInt16:
                                    case SpecialType.System_Char:
                                    case SpecialType.System_UInt32:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 66476, 67326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 66900, 66958);

                                        return SpecialMember.System_UIntPtr__op_Explicit_ToUInt32;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 66476, 67326);

                                    case SpecialType.System_UInt64:
                                    case SpecialType.System_Int64:
                                    case SpecialType.System_Single:
                                    case SpecialType.System_Double:
                                    case SpecialType.System_Decimal:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 66476, 67326);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67249, 67307);

                                        return SpecialMember.System_UIntPtr__op_Explicit_ToUInt64;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 66476, 67326);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 66223, 67341);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 65092, 67341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 63949, 67341);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 62812, 67341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67357, 67394);

                throw f_10490_67363_67393();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 62264, 67405);

                int
                f_10490_62380_62416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62380, 62416);
                    return 0;
                }


                int
                f_10490_62431_62467(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62431, 62467);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_62500_62521(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62500, 62521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_62552_62573(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62552, 62573);
                    return return_v;
                }


                bool
                f_10490_62611_62626(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62611, 62626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_62629_62655(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62629, 62655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_62629_62668(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 62629, 62668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_62671_62685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 62671, 62685);
                    return return_v;
                }


                bool
                f_10490_62721_62736(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62721, 62736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_62739_62765(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62739, 62765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_62739_62778(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 62739, 62778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_62781_62795(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 62781, 62795);
                    return return_v;
                }


                bool
                f_10490_62889_62924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 62889, 62924);
                    return return_v;
                }


                bool
                f_10490_64027_64062(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 64027, 64062);
                    return return_v;
                }


                bool
                f_10490_65169_65204(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 65169, 65204);
                    return return_v;
                }


                bool
                f_10490_66301_66336(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 66301, 66336);
                    return return_v;
                }


                System.Exception
                f_10490_67363_67393()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 67363, 67393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 62264, 67405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 62264, 67405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SpecialMember DecimalConversionMethod(TypeSymbol typeFrom, TypeSymbol typeTo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10490, 67524, 70737);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67641, 70726) || true) && (f_10490_67645_67665(typeFrom) == SpecialType.System_Decimal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67641, 70726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67776, 69174);

                    switch (f_10490_67784_67802(typeTo))
                    {

                        case SpecialType.System_Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67874, 67930);

                            return SpecialMember.System_Decimal__op_Explicit_ToChar;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 67983, 68040);

                            return SpecialMember.System_Decimal__op_Explicit_ToSByte;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68092, 68148);

                            return SpecialMember.System_Decimal__op_Explicit_ToByte;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68201, 68258);

                            return SpecialMember.System_Decimal__op_Explicit_ToInt16;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68312, 68370);

                            return SpecialMember.System_Decimal__op_Explicit_ToUInt16;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68423, 68480);

                            return SpecialMember.System_Decimal__op_Explicit_ToInt32;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68534, 68592);

                            return SpecialMember.System_Decimal__op_Explicit_ToUInt32;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68645, 68702);

                            return SpecialMember.System_Decimal__op_Explicit_ToInt64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68756, 68814);

                            return SpecialMember.System_Decimal__op_Explicit_ToUInt64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68868, 68926);

                            return SpecialMember.System_Decimal__op_Explicit_ToSingle;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        case SpecialType.System_Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 68980, 69038);

                            return SpecialMember.System_Decimal__op_Explicit_ToDouble;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67776, 69174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69094, 69155);

                            throw f_10490_69100_69154(f_10490_69135_69153(typeTo));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67776, 69174);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67641, 70726);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 67641, 70726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69287, 70711);

                    switch (f_10490_69295_69315(typeFrom))
                    {

                        case SpecialType.System_Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69387, 69445);

                            return SpecialMember.System_Decimal__op_Implicit_FromChar;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69498, 69557);

                            return SpecialMember.System_Decimal__op_Implicit_FromSByte;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69609, 69667);

                            return SpecialMember.System_Decimal__op_Implicit_FromByte;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69720, 69779);

                            return SpecialMember.System_Decimal__op_Implicit_FromInt16;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69833, 69893);

                            return SpecialMember.System_Decimal__op_Implicit_FromUInt16;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 69946, 70005);

                            return SpecialMember.System_Decimal__op_Implicit_FromInt32;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70059, 70119);

                            return SpecialMember.System_Decimal__op_Implicit_FromUInt32;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70172, 70231);

                            return SpecialMember.System_Decimal__op_Implicit_FromInt64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70285, 70345);

                            return SpecialMember.System_Decimal__op_Implicit_FromUInt64;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70399, 70459);

                            return SpecialMember.System_Decimal__op_Explicit_FromSingle;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        case SpecialType.System_Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70513, 70573);

                            return SpecialMember.System_Decimal__op_Explicit_FromDouble;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 69287, 70711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70629, 70692);

                            throw f_10490_70635_70691(f_10490_70670_70690(typeFrom));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 69287, 70711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 67641, 70726);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10490, 67524, 70737);

                Microsoft.CodeAnalysis.SpecialType
                f_10490_67645_67665(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 67645, 67665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_67784_67802(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 67784, 67802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_69135_69153(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 69135, 69153);
                    return return_v;
                }


                System.Exception
                f_10490_69100_69154(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 69100, 69154);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SpecialType
                f_10490_69295_69315(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 69295, 69315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_70670_70690(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 70670, 70690);
                    return return_v;
                }


                System.Exception
                f_10490_70635_70691(Microsoft.CodeAnalysis.SpecialType
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 70635, 70691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 67524, 70737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 67524, 70737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteDecimalConversion(SyntaxNode syntax, BoundExpression operand, TypeSymbol fromType, TypeSymbol toType, bool @checked, bool isImplicit, ConstantValue? constantValueOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 70749, 72569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 70971, 71088);

                f_10490_70971_71087(f_10490_70984_71004(fromType) == SpecialType.System_Decimal || (DynAbs.Tracing.TraceSender.Expression_False(10490, 70984, 71086) || f_10490_71038_71056(toType) == SpecialType.System_Decimal));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71104, 72257) || true) && (f_10490_71108_71128(fromType) == SpecialType.System_Decimal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 71104, 72257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71192, 71650);

                    switch (f_10490_71200_71218(toType))
                    {

                        case SpecialType.System_IntPtr:
                        case SpecialType.System_UIntPtr:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 71192, 71650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71371, 71552);

                            operand = f_10490_71381_71551(this, syntax, operand, fromType, f_10490_71437_71520(_compilation, signed: f_10490_71472_71490(toType) == SpecialType.System_IntPtr), isImplicit, constantValueOpt);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71578, 71631);

                            return f_10490_71585_71630(this, operand, toType, @checked);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 71192, 71650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 71104, 72257);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 71104, 72257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71716, 72242);

                    switch (f_10490_71724_71744(fromType))
                    {

                        case SpecialType.System_IntPtr:
                        case SpecialType.System_UIntPtr:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 71716, 72242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 71897, 72032);

                            operand = f_10490_71907_72031(this, operand, f_10490_71935_72020(_compilation, signed: f_10490_71970_71990(fromType) == SpecialType.System_IntPtr), @checked);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72058, 72092);

                            f_10490_72058_72091(f_10490_72071_72083(operand) is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72118, 72223);

                            return f_10490_72125_72222(this, syntax, operand, f_10490_72171_72183(operand), toType, isImplicit, constantValueOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 71716, 72242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 71104, 72257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72273, 72374);

                return f_10490_72280_72373(this, syntax, operand, fromType, toType, isImplicit, constantValueOpt);

                static TypeSymbol get64BitType(CSharpCompilation compilation, bool signed)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 72465, 72557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72468, 72557);
                        return f_10490_72468_72557(compilation, (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 72495, 72501) || ((signed && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 72504, 72528)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 72531, 72556))) ? SpecialType.System_Int64 : SpecialType.System_UInt64); DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 72465, 72557);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 72465, 72557);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 72465, 72557);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 70749, 72569);

                Microsoft.CodeAnalysis.SpecialType
                f_10490_70984_71004(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 70984, 71004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71038_71056(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71038, 71056);
                    return return_v;
                }


                int
                f_10490_70971_71087(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 70971, 71087);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71108_71128(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71108, 71128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71200_71218(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71200, 71218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71472_71490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71472, 71490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_71437_71520(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                signed)
                {
                    var return_v = get64BitType(compilation, signed: signed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 71437, 71520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_71381_71551(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = this_param.RewriteDecimalConversionCore(syntax, operand, fromType, toType, isImplicit, constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 71381, 71551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_71585_71630(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 71585, 71630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71724_71744(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71724, 71744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_71970_71990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 71970, 71990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_71935_72020(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                signed)
                {
                    var return_v = get64BitType(compilation, signed: signed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 71935, 72020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_71907_72031(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rewrittenOperand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rewrittenType, bool
                @checked)
                {
                    var return_v = this_param.MakeConversionNode(rewrittenOperand, rewrittenType, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 71907, 72031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10490_72071_72083(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 72071, 72083);
                    return return_v;
                }


                int
                f_10490_72058_72091(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72058, 72091);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_72171_72183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 72171, 72183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_72125_72222(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = this_param.RewriteDecimalConversionCore(syntax, operand, fromType, toType, isImplicit, constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72125, 72222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10490_72280_72373(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt)
                {
                    var return_v = this_param.RewriteDecimalConversionCore(syntax, operand, fromType, toType, isImplicit, constantValueOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72280, 72373);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10490_72468_72557(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72468, 72557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 70749, 72569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 70749, 72569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression RewriteDecimalConversionCore(SyntaxNode syntax, BoundExpression operand, TypeSymbol fromType, TypeSymbol toType, bool isImplicit, ConstantValue? constantValueOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 72581, 73846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72824, 72889);

                SpecialMember
                member = f_10490_72847_72888(fromType, toType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72903, 72981);

                var
                method = (MethodSymbol)f_10490_72930_72980(f_10490_72930_72951(_compilation), member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 72995, 73032);

                f_10490_72995_73031((object)method != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73097, 73835) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 73097, 73835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73154, 73271);

                    ConversionKind
                    conversionKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10490, 73186, 73196) || ((isImplicit && DynAbs.Tracing.TraceSender.Conditional_F2(10490, 73199, 73233)) || DynAbs.Tracing.TraceSender.Conditional_F3(10490, 73236, 73270))) ? ConversionKind.ImplicitUserDefined : ConversionKind.ExplicitUserDefined
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73289, 73371);

                    var
                    conversion = f_10490_73306_73370(conversionKind, method, isExtensionMethod: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73391, 73567);

                    return f_10490_73398_73566(syntax, operand, conversion, @checked: false, explicitCastInCode: false, conversionGroupOpt: null, constantValueOpt: constantValueOpt, type: toType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 73097, 73835);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 73097, 73835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73633, 73729);

                    f_10490_73633_73728(f_10490_73646_73727(f_10490_73664_73681(method), toType, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 73747, 73820);

                    return f_10490_73754_73819(syntax, receiverOpt: null, method, operand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 73097, 73835);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 72581, 73846);

                Microsoft.CodeAnalysis.SpecialMember
                f_10490_72847_72888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeFrom, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeTo)
                {
                    var return_v = DecimalConversionMethod(typeFrom, typeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72847, 72888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10490_72930_72951(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 72930, 72951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10490_72930_72980(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.GetSpecialTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72930, 72980);
                    return return_v;
                }


                int
                f_10490_72995_73031(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 72995, 73031);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_73306_73370(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, bool
                isExtensionMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod: isExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 73306, 73370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10490_73398_73566(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 73398, 73566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_73664_73681(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 73664, 73681);
                    return return_v;
                }


                bool
                f_10490_73646_73727(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 73646, 73727);
                    return return_v;
                }


                int
                f_10490_73633_73728(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 73633, 73728);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10490_73754_73819(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = BoundCall.Synthesized(syntax, receiverOpt: receiverOpt, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 73754, 73819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 72581, 73846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 72581, 73846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion TryMakeConversion(SyntaxNode syntax, Conversion conversion, TypeSymbol fromType, TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 74010, 78991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74153, 78980);

                switch (conversion.Kind)
                {

                    case ConversionKind.ExplicitUserDefined:
                    case ConversionKind.ImplicitUserDefined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74153, 78980);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74357, 74386);

                            var
                            meth = conversion.Method
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74412, 74438);

                            f_10490_74412_74437(meth is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74464, 74591);

                            Conversion
                            fromConversion = f_10490_74492_74590(this, syntax, conversion.UserDefinedFromConversion, fromType, f_10490_74566_74589(f_10490_74566_74581(meth)[0]))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74617, 74759) || true) && (f_10490_74621_74643_M(!fromConversion.Exists))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74617, 74759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74701, 74732);

                                return Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74617, 74759);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74787, 74900);

                            Conversion
                            toConversion = f_10490_74813_74899(this, syntax, conversion.UserDefinedToConversion, f_10490_74875_74890(meth), toType)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 74926, 75066) || true) && (f_10490_74930_74950_M(!toConversion.Exists))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74926, 75066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75008, 75039);

                                return Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74926, 75066);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75094, 75857) || true) && (fromConversion == conversion.UserDefinedFromConversion && (DynAbs.Tracing.TraceSender.Expression_True(10490, 75098, 75206) && toConversion == conversion.UserDefinedToConversion))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 75094, 75857);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75264, 75282);

                                return conversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 75094, 75857);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 75094, 75857);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75497, 75603);

                                var
                                analysis = f_10490_75512_75602(meth, fromConversion, toConversion, fromType, toType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75633, 75747);

                                var
                                result = UserDefinedConversionResult.Valid(f_10490_75680_75742(analysis), 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75777, 75830);

                                return f_10490_75784_75829(result, conversion.IsImplicit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 75094, 75857);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74153, 78980);

                    case ConversionKind.IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74153, 78980);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 75974, 76041);

                            SpecialMember
                            member = f_10490_75997_76040(fromType, toType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76067, 76087);

                            MethodSymbol
                            method
                            = default(MethodSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76113, 76285) || true) && (!f_10490_76118_76169(this, syntax, member, out method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 76113, 76285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76227, 76258);

                                return Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 76113, 76285);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76313, 76406);

                            return f_10490_76320_76405(this, syntax, method, fromType, toType, conversion.IsImplicit);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74153, 78980);

                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ExplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74153, 78980);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76610, 77219) || true) && (f_10490_76614_76634(fromType) == SpecialType.System_Decimal || (DynAbs.Tracing.TraceSender.Expression_False(10490, 76614, 76716) || f_10490_76668_76686(toType) == SpecialType.System_Decimal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 76610, 77219);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76766, 76831);

                            SpecialMember
                            member = f_10490_76789_76830(fromType, toType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76857, 76877);

                            MethodSymbol
                            method
                            = default(MethodSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 76903, 77075) || true) && (!f_10490_76908_76959(this, syntax, member, out method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 76903, 77075);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77017, 77048);

                                return Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 76903, 77075);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77103, 77196);

                            return f_10490_77110_77195(this, syntax, method, fromType, toType, conversion.IsImplicit);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 76610, 77219);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77241, 77259);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74153, 78980);

                    case ConversionKind.ImplicitEnumeration:
                    case ConversionKind.ExplicitEnumeration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74153, 78980);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77448, 78859) || true) && (f_10490_77452_77472(fromType) == SpecialType.System_Decimal)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 77448, 78859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77552, 77600);

                            var
                            underlying = f_10490_77569_77599(toType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77626, 77658);

                            f_10490_77626_77657(underlying is { });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77684, 77753);

                            SpecialMember
                            member = f_10490_77707_77752(fromType, underlying)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77779, 77799);

                            MethodSymbol
                            method
                            = default(MethodSymbol);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77825, 77997) || true) && (!f_10490_77830_77881(this, syntax, member, out method))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 77825, 77997);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 77939, 77970);

                                return Conversion.NoConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 77825, 77997);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78025, 78118);

                            return f_10490_78032_78117(this, syntax, method, fromType, toType, conversion.IsImplicit);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 77448, 78859);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 77448, 78859);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78168, 78859) || true) && (f_10490_78172_78190(toType) == SpecialType.System_Decimal)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 78168, 78859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78270, 78320);

                                var
                                underlying = f_10490_78287_78319(fromType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78346, 78378);

                                f_10490_78346_78377(underlying is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78404, 78471);

                                SpecialMember
                                member = f_10490_78427_78470(underlying, toType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78497, 78517);

                                MethodSymbol
                                method
                                = default(MethodSymbol);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78543, 78715) || true) && (!f_10490_78548_78599(this, syntax, member, out method))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 78543, 78715);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78657, 78688);

                                    return Conversion.NoConversion;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 78543, 78715);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78743, 78836);

                                return f_10490_78750_78835(this, syntax, method, fromType, toType, conversion.IsImplicit);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 78168, 78859);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 77448, 78859);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78881, 78899);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74153, 78980);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 74153, 78980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 78947, 78965);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 74153, 78980);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 74010, 78991);

                int
                f_10490_74412_74437(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 74412, 74437);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10490_74566_74581(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 74566, 74581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_74566_74589(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 74566, 74589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_74492_74590(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, conversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 74492, 74590);
                    return return_v;
                }


                bool
                f_10490_74621_74643_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 74621, 74643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_74875_74890(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 74875, 74890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_74813_74899(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, conversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 74813, 74899);
                    return return_v;
                }


                bool
                f_10490_74930_74950_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 74930, 74950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10490_75512_75602(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Normal(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 75512, 75602);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10490_75680_75742(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    var return_v = ImmutableArray.Create<UserDefinedConversionAnalysis>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 75680, 75742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_75784_75829(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(conversionResult, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 75784, 75829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_75997_76040(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = GetIntPtrConversionMethod(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 75997, 76040);
                    return return_v;
                }


                bool
                f_10490_76118_76169(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.TryGetSpecialTypeMethod(syntax, specialMember, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 76118, 76169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_76320_76405(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                meth, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit)
                {
                    var return_v = this_param.TryMakeUserDefinedConversion(syntax, meth, fromType, toType, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 76320, 76405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_76614_76634(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 76614, 76634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_76668_76686(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 76668, 76686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_76789_76830(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeFrom, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeTo)
                {
                    var return_v = DecimalConversionMethod(typeFrom, typeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 76789, 76830);
                    return return_v;
                }


                bool
                f_10490_76908_76959(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.TryGetSpecialTypeMethod(syntax, specialMember, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 76908, 76959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_77110_77195(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                meth, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit)
                {
                    var return_v = this_param.TryMakeUserDefinedConversion(syntax, meth, fromType, toType, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 77110, 77195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_77452_77472(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 77452, 77472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_77569_77599(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 77569, 77599);
                    return return_v;
                }


                int
                f_10490_77626_77657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 77626, 77657);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_77707_77752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeFrom, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeTo)
                {
                    var return_v = DecimalConversionMethod(typeFrom, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 77707, 77752);
                    return return_v;
                }


                bool
                f_10490_77830_77881(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.TryGetSpecialTypeMethod(syntax, specialMember, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 77830, 77881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_78032_78117(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                meth, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit)
                {
                    var return_v = this_param.TryMakeUserDefinedConversion(syntax, meth, fromType, toType, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78032, 78117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10490_78172_78190(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 78172, 78190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10490_78287_78319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78287, 78319);
                    return return_v;
                }


                int
                f_10490_78346_78377(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78346, 78377);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialMember
                f_10490_78427_78470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeFrom, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeTo)
                {
                    var return_v = DecimalConversionMethod((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)typeFrom, typeTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78427, 78470);
                    return return_v;
                }


                bool
                f_10490_78548_78599(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SpecialMember
                specialMember, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.TryGetSpecialTypeMethod(syntax, specialMember, out method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78548, 78599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_78750_78835(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                meth, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType, bool
                isImplicit)
                {
                    var return_v = this_param.TryMakeUserDefinedConversion(syntax, meth, fromType, toType, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 78750, 78835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 74010, 78991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 74010, 78991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion TryMakeConversion(SyntaxNode syntax, TypeSymbol fromType, TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 79155, 79590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 79275, 79326);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 79340, 79492);

                var
                result = f_10490_79353_79491(this, syntax, f_10490_79379_79472(f_10490_79379_79403(_compilation), fromType, toType, ref useSiteDiagnostics), fromType, toType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 79506, 79551);

                f_10490_79506_79550(_diagnostics, syntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 79565, 79579);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 79155, 79590);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10490_79379_79403(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 79379, 79403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_79379_79472(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 79379, 79472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_79353_79491(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, conversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 79353, 79491);
                    return return_v;
                }


                bool
                f_10490_79506_79550(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 79506, 79550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 79155, 79590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 79155, 79590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion TryMakeUserDefinedConversion(SyntaxNode syntax, MethodSymbol meth, TypeSymbol fromType, TypeSymbol toType, bool isImplicit = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10490, 79754, 80742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 79928, 80017);

                Conversion
                fromConversion = f_10490_79956_80016(this, syntax, fromType, f_10490_79992_80015(f_10490_79992_80007(meth)[0]))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80031, 80137) || true) && (f_10490_80035_80057_M(!fromConversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 80031, 80137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80091, 80122);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 80031, 80137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80153, 80230);

                Conversion
                toConversion = f_10490_80179_80229(this, syntax, f_10490_80205_80220(meth), toType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80244, 80348) || true) && (f_10490_80248_80268_M(!toConversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10490, 80244, 80348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80302, 80333);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10490, 80244, 80348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80441, 80547);

                var
                analysis = f_10490_80456_80546(meth, fromConversion, toConversion, fromType, toType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80561, 80675);

                var
                result = UserDefinedConversionResult.Valid(f_10490_80608_80670(analysis), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10490, 80689, 80731);

                return f_10490_80696_80730(result, isImplicit);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10490, 79754, 80742);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10490_79992_80007(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 79992, 80007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_79992_80015(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 79992, 80015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_79956_80016(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 79956, 80016);
                    return return_v;
                }


                bool
                f_10490_80035_80057_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 80035, 80057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10490_80205_80220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 80205, 80220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_80179_80229(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.TryMakeConversion(syntax, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 80179, 80229);
                    return return_v;
                }


                bool
                f_10490_80248_80268_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10490, 80248, 80268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                f_10490_80456_80546(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                op, Microsoft.CodeAnalysis.CSharp.Conversion
                sourceConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                targetConversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = UserDefinedConversionAnalysis.Normal(op, sourceConversion, targetConversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 80456, 80546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis>
                f_10490_80608_80670(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionAnalysis
                item)
                {
                    var return_v = ImmutableArray.Create<UserDefinedConversionAnalysis>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 80608, 80670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10490_80696_80730(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(conversionResult, isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10490, 80696, 80730);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10490, 79754, 80742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10490, 79754, 80742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
