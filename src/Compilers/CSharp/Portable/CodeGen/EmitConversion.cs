// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.CodeGen
{
    internal partial class CodeGenerator
    {
        private static bool IsNumeric(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10963, 473, 1436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 544, 1425);

                switch (f_10963_552_574(type))
                {

                    case Cci.PrimitiveTypeCode.Int8:
                    case Cci.PrimitiveTypeCode.UInt8:
                    case Cci.PrimitiveTypeCode.Int16:
                    case Cci.PrimitiveTypeCode.UInt16:
                    case Cci.PrimitiveTypeCode.Int32:
                    case Cci.PrimitiveTypeCode.UInt32:
                    case Cci.PrimitiveTypeCode.Int64:
                    case Cci.PrimitiveTypeCode.UInt64:
                    case Cci.PrimitiveTypeCode.Char:
                    case Cci.PrimitiveTypeCode.Float32:
                    case Cci.PrimitiveTypeCode.Float64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 544, 1425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1178, 1190);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 544, 1425);

                    case Cci.PrimitiveTypeCode.IntPtr:
                    case Cci.PrimitiveTypeCode.UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 544, 1425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1317, 1349);

                        return f_10963_1324_1348(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 544, 1425);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 544, 1425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1397, 1410);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 544, 1425);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10963, 473, 1436);

                Microsoft.Cci.PrimitiveTypeCode
                f_10963_552_574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 552, 574);
                    return return_v;
                }


                bool
                f_10963_1324_1348(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 1324, 1348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 473, 1436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 473, 1436);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EmitConversionExpression(BoundConversion conversion, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 1448, 2444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1549, 2058);

                switch (f_10963_1557_1582(conversion))
                {

                    case ConversionKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 1549, 2058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1670, 1738);

                        throw f_10963_1676_1737(f_10963_1711_1736(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 1549, 2058);

                    case ConversionKind.ImplicitNullToPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 1549, 2058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1883, 1911);

                        f_10963_1883_1910(                    // The null pointer is represented as 0u.
                                            _builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1933, 1970);

                        f_10963_1933_1969(_builder, ILOpCode.Conv_u);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 1992, 2014);

                        f_10963_1992_2013(this, used);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2036, 2043);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 1549, 2058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2074, 2107);

                var
                operand = f_10963_2088_2106(conversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2123, 2308) || true) && (!used && (DynAbs.Tracing.TraceSender.Expression_True(10963, 2127, 2174) && !f_10963_2137_2174(conversion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 2123, 2308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2208, 2239);

                    f_10963_2208_2238(this, operand, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2286, 2293);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 2123, 2308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2324, 2354);

                f_10963_2324_2353(this, operand, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2368, 2395);

                f_10963_2368_2394(this, conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2411, 2433);

                f_10963_2411_2432(this, used);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 1448, 2444);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_1557_1582(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 1557, 1582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_1711_1736(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 1711, 1736);
                    return return_v;
                }


                System.Exception
                f_10963_1676_1737(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 1676, 1737);
                    return return_v;
                }


                int
                f_10963_1883_1910(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 1883, 1910);
                    return 0;
                }


                int
                f_10963_1933_1969(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 1933, 1969);
                    return 0;
                }


                int
                f_10963_1992_2013(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 1992, 2013);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_2088_2106(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 2088, 2106);
                    return return_v;
                }


                bool
                f_10963_2137_2174(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionHasSideEffects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2137, 2174);
                    return return_v;
                }


                int
                f_10963_2208_2238(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2208, 2238);
                    return 0;
                }


                int
                f_10963_2324_2353(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2324, 2353);
                    return 0;
                }


                int
                f_10963_2368_2394(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2368, 2394);
                    return 0;
                }


                int
                f_10963_2411_2432(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, bool
                used)
                {
                    this_param.EmitPopIfUnused(used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2411, 2432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 1448, 2444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 1448, 2444);
            }
        }

        private void EmitReadOnlySpanFromArrayExpression(BoundReadOnlySpanFromArray expression, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 2456, 3629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2579, 2624);

                BoundExpression
                operand = f_10963_2605_2623(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2638, 2684);

                var
                typeTo = (NamedTypeSymbol)f_10963_2668_2683(expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2700, 2929);

                f_10963_2700_2928((f_10963_2714_2736(f_10963_2714_2726(operand))) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 2713, 2818) && f_10963_2767_2818(this._module.Compilation, typeTo)), "only special kinds of conversions involving ReadOnlySpan may be handled in emit");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 2945, 3618) || true) && (!f_10963_2950_3021(this, typeTo, operand, used, inPlace: false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 2945, 3618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3244, 3274);

                    f_10963_3244_3273(this, operand, used);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3292, 3603) || true) && (used)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3292, 3603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3425, 3480);

                        f_10963_3425_3479(                    // consumes 1 argument (array) and produces one result (span)
                                            _builder, ILOpCode.Call, stackAdjustment: 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3502, 3584);

                        f_10963_3502_3583(this, f_10963_3518_3545(expression), expression.Syntax, optArgList: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3292, 3603);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 2945, 3618);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 2456, 3629);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_2605_2623(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 2605, 2623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_2668_2683(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 2668, 2683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_2714_2726(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 2714, 2726);
                    return return_v;
                }


                bool
                f_10963_2714_2736(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2714, 2736);
                    return return_v;
                }


                bool
                f_10963_2767_2818(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsReadOnlySpanType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2767, 2818);
                    return return_v;
                }


                int
                f_10963_2700_2928(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2700, 2928);
                    return 0;
                }


                bool
                f_10963_2950_3021(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                spanType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                wrappedExpression, bool
                used, bool
                inPlace)
                {
                    var return_v = this_param.TryEmitReadonlySpanAsBlobWrapper(spanType, wrappedExpression, used, inPlace: inPlace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 2950, 3021);
                    return return_v;
                }


                int
                f_10963_3244_3273(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 3244, 3273);
                    return 0;
                }


                int
                f_10963_3425_3479(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment: stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 3425, 3479);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10963_3518_3545(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.ConversionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 3518, 3545);
                    return return_v;
                }


                int
                f_10963_3502_3583(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList: optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 3502, 3583);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 2456, 3629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 2456, 3629);
            }
        }

        private void EmitConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 3641, 8880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3721, 8869);

                switch (f_10963_3729_3754(conversion))
                {

                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 3839, 3874);

                        f_10963_3839_3873(this, conversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 3896, 3902);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitNumeric:
                    case ConversionKind.ExplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 4032, 4066);

                        f_10963_4032_4065(this, conversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 4088, 4094);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitReference:
                    case ConversionKind.Boxing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 4515, 4559);

                        f_10963_4515_4558(this, conversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 4581, 4587);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ExplicitReference:
                    case ConversionKind.Unboxing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 5011, 5055);

                        f_10963_5011_5054(this, conversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 5077, 5083);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitEnumeration:
                    case ConversionKind.ExplicitEnumeration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 5221, 5252);

                        f_10963_5221_5251(this, conversion);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 5274, 5280);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitUserDefined:
                    case ConversionKind.ExplicitUserDefined:
                    case ConversionKind.AnonymousFunction:
                    case ConversionKind.MethodGroup:
                    case ConversionKind.ImplicitTupleLiteral:
                    case ConversionKind.ImplicitTuple:
                    case ConversionKind.ExplicitTupleLiteral:
                    case ConversionKind.ExplicitTuple:
                    case ConversionKind.ImplicitDynamic:
                    case ConversionKind.ExplicitDynamic:
                    case ConversionKind.ImplicitThrow:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 5986, 6054);

                        throw f_10963_5992_6053(f_10963_6027_6052(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitPointerToVoid:
                    case ConversionKind.ExplicitPointerToPointer:
                    case ConversionKind.ImplicitPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6253, 6260);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ExplicitPointerToInteger:
                    case ConversionKind.ExplicitIntegerToPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6468, 6507);

                        var
                        fromType = f_10963_6483_6506(f_10963_6483_6501(conversion))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6529, 6581);

                        var
                        fromPredefTypeKind = f_10963_6554_6580(fromType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6605, 6634);

                        var
                        toType = f_10963_6618_6633(conversion)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6656, 6704);

                        var
                        toPredefTypeKind = f_10963_6679_6703(toType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6739, 7838);

                        switch (fromPredefTypeKind)
                        {

                            case Microsoft.Cci.PrimitiveTypeCode.IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6859, 6893) || true) && (f_10963_6864_6893_M(!fromType.IsNativeIntegerType)) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 6859, 6893) || true)
                        :
                            case Microsoft.Cci.PrimitiveTypeCode.UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 6965, 6999) || true) && (f_10963_6970_6999_M(!fromType.IsNativeIntegerType)) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 6965, 6999) || true)
                        :
                            case Microsoft.Cci.PrimitiveTypeCode.Pointer:
                            case Microsoft.Cci.PrimitiveTypeCode.FunctionPointer:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 6739, 7838);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 7180, 7212);

                                f_10963_7180_7211(f_10963_7193_7210(toType));
                                DynAbs.Tracing.TraceSender.TraceBreak(10963, 7242, 7248);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 6739, 7838);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 6739, 7838);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 7312, 7346);

                                f_10963_7312_7345(f_10963_7325_7344(fromType));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 7376, 7779);

                                f_10963_7376_7778((toPredefTypeKind == Microsoft.Cci.PrimitiveTypeCode.IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10963, 7424, 7545) || toPredefTypeKind == Microsoft.Cci.PrimitiveTypeCode.UIntPtr)) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 7423, 7577) && f_10963_7550_7577_M(!toType.IsNativeIntegerType)) || (DynAbs.Tracing.TraceSender.Expression_False(10963, 7423, 7673) || toPredefTypeKind == Microsoft.Cci.PrimitiveTypeCode.Pointer) || (DynAbs.Tracing.TraceSender.Expression_False(10963, 7423, 7777) || toPredefTypeKind == Microsoft.Cci.PrimitiveTypeCode.FunctionPointer));
                                DynAbs.Tracing.TraceSender.TraceBreak(10963, 7809, 7815);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 6739, 7838);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 7870, 7959);

                        f_10963_7870_7958(
                                            _builder, fromPredefTypeKind, toPredefTypeKind, f_10963_7939_7957(conversion));
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 7981, 7987);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.PinnedObjectToPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 8381, 8418);

                        f_10963_8381_8417(                    // CLR allows unsafe conversion from(O) to native int/uint.
                                                              // The conversion does not change the representation of the value, 
                                                              // but the value will not be reported to subsequent GC operations (and therefore will not be updated by such operations)
                                            _builder, ILOpCode.Conv_u);
                        DynAbs.Tracing.TraceSender.TraceBreak(10963, 8440, 8446);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitNullToPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 8528, 8596);

                        throw f_10963_8534_8595(f_10963_8569_8594(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);

                    case ConversionKind.ImplicitNullable:
                    case ConversionKind.ExplicitNullable:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 3721, 8869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 8786, 8854);

                        throw f_10963_8792_8853(f_10963_8827_8852(conversion));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 3721, 8869);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 3641, 8880);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_3729_3754(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 3729, 3754);
                    return return_v;
                }


                int
                f_10963_3839_3873(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitIdentityConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 3839, 3873);
                    return 0;
                }


                int
                f_10963_4032_4065(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitNumericConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 4032, 4065);
                    return 0;
                }


                int
                f_10963_4515_4558(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitImplicitReferenceConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 4515, 4558);
                    return 0;
                }


                int
                f_10963_5011_5054(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitExplicitReferenceConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 5011, 5054);
                    return 0;
                }


                int
                f_10963_5221_5251(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitEnumConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 5221, 5251);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_6027_6052(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6027, 6052);
                    return return_v;
                }


                System.Exception
                f_10963_5992_6053(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 5992, 6053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_6483_6501(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6483, 6501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_6483_6506(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6483, 6506);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_6554_6580(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6554, 6580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_6618_6633(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6618, 6633);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_6679_6703(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6679, 6703);
                    return return_v;
                }


                bool
                f_10963_6864_6893_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6864, 6893);
                    return return_v;
                }


                bool
                f_10963_6970_6999_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 6970, 6999);
                    return return_v;
                }


                bool
                f_10963_7193_7210(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7193, 7210);
                    return return_v;
                }


                int
                f_10963_7180_7211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7180, 7211);
                    return 0;
                }


                bool
                f_10963_7325_7344(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7325, 7344);
                    return return_v;
                }


                int
                f_10963_7312_7345(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7312, 7345);
                    return 0;
                }


                bool
                f_10963_7550_7577_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 7550, 7577);
                    return return_v;
                }


                int
                f_10963_7376_7778(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7376, 7778);
                    return 0;
                }


                bool
                f_10963_7939_7957(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 7939, 7957);
                    return return_v;
                }


                int
                f_10963_7870_7958(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 7870, 7958);
                    return 0;
                }


                int
                f_10963_8381_8417(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 8381, 8417);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_8569_8594(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 8569, 8594);
                    return return_v;
                }


                System.Exception
                f_10963_8534_8595(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 8534, 8595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10963_8827_8852(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 8827, 8852);
                    return return_v;
                }


                System.Exception
                f_10963_8792_8853(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 8792, 8853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 3641, 8880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 3641, 8880);
            }
        }

        private void EmitIdentityConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 8892, 10513);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 9424, 10502) || true) && (f_10963_9428_9457(conversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 9424, 10502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 9491, 10487);

                    switch (f_10963_9499_9532(f_10963_9499_9514(conversion)))
                    {

                        case Microsoft.Cci.PrimitiveTypeCode.Float32:
                        case Microsoft.Cci.PrimitiveTypeCode.Float64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 9491, 10487);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10273, 10436) || true) && (f_10963_10277_10309(f_10963_10277_10295(conversion)) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 10273, 10436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10375, 10409);

                                f_10963_10375_10408(this, conversion);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 10273, 10436);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10963, 10462, 10468);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 9491, 10487);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 9424, 10502);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 8892, 10513);

                bool
                f_10963_9428_9457(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 9428, 9457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_9499_9514(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 9499, 9514);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_9499_9532(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 9499, 9532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_10277_10295(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10277, 10295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10963_10277_10309(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10277, 10309);
                    return return_v;
                }


                int
                f_10963_10375_10408(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                conversion)
                {
                    this_param.EmitNumericConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10375, 10408);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 8892, 10513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 8892, 10513);
            }
        }

        private void EmitNumericConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 10525, 11034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10612, 10651);

                var
                fromType = f_10963_10627_10650(f_10963_10627_10645(conversion))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10665, 10717);

                var
                fromPredefTypeKind = f_10963_10690_10716(fromType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10731, 10765);

                f_10963_10731_10764(f_10963_10744_10763(fromType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10781, 10810);

                var
                toType = f_10963_10794_10809(conversion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10824, 10872);

                var
                toPredefTypeKind = f_10963_10847_10871(toType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10886, 10918);

                f_10963_10886_10917(f_10963_10899_10916(toType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 10934, 11023);

                f_10963_10934_11022(
                            _builder, fromPredefTypeKind, toPredefTypeKind, f_10963_11003_11021(conversion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 10525, 11034);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_10627_10645(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10627, 10645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_10627_10650(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10627, 10650);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_10690_10716(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10690, 10716);
                    return return_v;
                }


                bool
                f_10963_10744_10763(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10744, 10763);
                    return return_v;
                }


                int
                f_10963_10731_10764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10731, 10764);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_10794_10809(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10794, 10809);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_10847_10871(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 10847, 10871);
                    return return_v;
                }


                bool
                f_10963_10899_10916(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10899, 10916);
                    return return_v;
                }


                int
                f_10963_10886_10917(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10886, 10917);
                    return 0;
                }


                bool
                f_10963_11003_11021(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11003, 11021);
                    return return_v;
                }


                int
                f_10963_10934_11022(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 10934, 11022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 10525, 11034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 10525, 11034);
            }
        }

        private void EmitImplicitReferenceConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 11046, 12684);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11361, 11520) || true) && (!f_10963_11366_11411(f_10963_11366_11389(f_10963_11366_11384(conversion))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 11361, 11520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11445, 11505);

                    f_10963_11445_11504(this, f_10963_11453_11476(f_10963_11453_11471(conversion)), f_10963_11478_11496(conversion).Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 11361, 11520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11812, 11845);

                var
                resultType = f_10963_11829_11844(conversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11859, 12650) || true) && (!f_10963_11864_11896(resultType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 11859, 12650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11930, 11970);

                    f_10963_11930_11969(_builder, ILOpCode.Unbox_any);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 11988, 12040);

                    f_10963_11988_12039(this, f_10963_12004_12019(conversion), conversion.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 11859, 12650);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 11859, 12650);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 12074, 12650) || true) && (f_10963_12078_12098(resultType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 12074, 12650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 12584, 12635);

                        f_10963_12584_12634(this, f_10963_12599_12614(conversion), conversion.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 12074, 12650);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 11859, 12650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 12666, 12673);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 11046, 12684);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_11366_11384(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11366, 11384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_11366_11389(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11366, 11389);
                    return return_v;
                }


                bool
                f_10963_11366_11411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 11366, 11411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_11453_11471(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11453, 11471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_11453_11476(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11453, 11476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_11478_11496(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11478, 11496);
                    return return_v;
                }


                int
                f_10963_11445_11504(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 11445, 11504);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_11829_11844(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 11829, 11844);
                    return return_v;
                }


                bool
                f_10963_11864_11896(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 11864, 11896);
                    return return_v;
                }


                int
                f_10963_11930_11969(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 11930, 11969);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_12004_12019(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 12004, 12019);
                    return return_v;
                }


                int
                f_10963_11988_12039(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 11988, 12039);
                    return 0;
                }


                bool
                f_10963_12078_12098(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 12078, 12098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_12599_12614(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 12599, 12614);
                    return return_v;
                }


                int
                f_10963_12584_12634(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                to, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    this_param.EmitStaticCast(to, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 12584, 12634);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 11046, 12684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 11046, 12684);
            }
        }

        private void EmitExplicitReferenceConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 12696, 13905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13011, 13170) || true) && (!f_10963_13016_13061(f_10963_13016_13039(f_10963_13016_13034(conversion))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 13011, 13170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13095, 13155);

                    f_10963_13095_13154(this, f_10963_13103_13126(f_10963_13103_13121(conversion)), f_10963_13128_13146(conversion).Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 13011, 13170);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13518, 13894) || true) && (f_10963_13522_13559(f_10963_13522_13537(conversion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 13518, 13894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13593, 13633);

                    f_10963_13593_13632(_builder, ILOpCode.Castclass);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13651, 13703);

                    f_10963_13651_13702(this, f_10963_13667_13682(conversion), conversion.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 13518, 13894);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 13518, 13894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13769, 13809);

                    f_10963_13769_13808(_builder, ILOpCode.Unbox_any);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 13827, 13879);

                    f_10963_13827_13878(this, f_10963_13843_13858(conversion), conversion.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 13518, 13894);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 12696, 13905);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_13016_13034(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13016, 13034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_13016_13039(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13016, 13039);
                    return return_v;
                }


                bool
                f_10963_13016_13061(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13016, 13061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_13103_13121(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13103, 13121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_13103_13126(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13103, 13126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_13128_13146(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13128, 13146);
                    return return_v;
                }


                int
                f_10963_13095_13154(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13095, 13154);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_13522_13537(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13522, 13537);
                    return return_v;
                }


                bool
                f_10963_13522_13559(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13522, 13559);
                    return return_v;
                }


                int
                f_10963_13593_13632(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13593, 13632);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_13667_13682(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13667, 13682);
                    return return_v;
                }


                int
                f_10963_13651_13702(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13651, 13702);
                    return 0;
                }


                int
                f_10963_13769_13808(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13769, 13808);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_13843_13858(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 13843, 13858);
                    return return_v;
                }


                int
                f_10963_13827_13878(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitSymbolToken(symbol, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 13827, 13878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 12696, 13905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 12696, 13905);
            }
        }

        private void EmitEnumConversion(BoundConversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 13917, 14923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14147, 14195);

                f_10963_14147_14194(!f_10963_14161_14193(f_10963_14161_14176(conversion)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14211, 14250);

                var
                fromType = f_10963_14226_14249(f_10963_14226_14244(conversion))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14264, 14396) || true) && (f_10963_14268_14289(fromType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 14264, 14396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14323, 14381);

                    fromType = f_10963_14334_14380(((NamedTypeSymbol)fromType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 14264, 14396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14412, 14464);

                var
                fromPredefTypeKind = f_10963_14437_14463(fromType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14478, 14512);

                f_10963_14478_14511(f_10963_14491_14510(fromType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14528, 14557);

                var
                toType = f_10963_14541_14556(conversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14571, 14697) || true) && (f_10963_14575_14594(toType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 14571, 14697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14628, 14682);

                    toType = f_10963_14637_14681(((NamedTypeSymbol)toType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 14571, 14697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14713, 14761);

                var
                toPredefTypeKind = f_10963_14736_14760(toType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14775, 14807);

                f_10963_14775_14806(f_10963_14788_14805(toType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 14823, 14912);

                f_10963_14823_14911(
                            _builder, fromPredefTypeKind, toPredefTypeKind, f_10963_14892_14910(conversion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 13917, 14923);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_14161_14176(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14161, 14176);
                    return return_v;
                }


                bool
                f_10963_14161_14193(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14161, 14193);
                    return return_v;
                }


                int
                f_10963_14147_14194(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14147, 14194);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10963_14226_14244(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14226, 14244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_14226_14249(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14226, 14249);
                    return return_v;
                }


                bool
                f_10963_14268_14289(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14268, 14289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10963_14334_14380(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14334, 14380);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_14437_14463(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14437, 14463);
                    return return_v;
                }


                bool
                f_10963_14491_14510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14491, 14510);
                    return return_v;
                }


                int
                f_10963_14478_14511(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14478, 14511);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_14541_14556(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14541, 14556);
                    return return_v;
                }


                bool
                f_10963_14575_14594(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14575, 14594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10963_14637_14681(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14637, 14681);
                    return return_v;
                }


                Microsoft.Cci.PrimitiveTypeCode
                f_10963_14736_14760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.PrimitiveTypeCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14736, 14760);
                    return return_v;
                }


                bool
                f_10963_14788_14805(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumeric(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14788, 14805);
                    return return_v;
                }


                int
                f_10963_14775_14806(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14775, 14806);
                    return 0;
                }


                bool
                f_10963_14892_14910(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 14892, 14910);
                    return return_v;
                }


                int
                f_10963_14823_14911(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.PrimitiveTypeCode
                fromPredefTypeKind, Microsoft.Cci.PrimitiveTypeCode
                toPredefTypeKind, bool
                @checked)
                {
                    this_param.EmitNumericConversion(fromPredefTypeKind, toPredefTypeKind, @checked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 14823, 14911);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 13917, 14923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 13917, 14923);
            }
        }

        private void EmitDelegateCreation(BoundExpression node, BoundExpression receiver, bool isExtensionMethod, MethodSymbol method, TypeSymbol delegateType, bool used)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 14935, 16981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15122, 15197);

                var
                isStatic = receiver == null || (DynAbs.Tracing.TraceSender.Expression_False(10963, 15137, 15196) || (!isExtensionMethod && (DynAbs.Tracing.TraceSender.Expression_True(10963, 15158, 15195) && f_10963_15180_15195(method))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15211, 15402) || true) && (!used)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 15211, 15402);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15254, 15360) || true) && (!isStatic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 15254, 15360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15309, 15341);

                        f_10963_15309_15340(this, receiver, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 15254, 15360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15380, 15387);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 15211, 15402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15452, 15797) || true) && (isStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 15452, 15797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15498, 15526);

                    f_10963_15498_15525(_builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 15452, 15797);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 15452, 15797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15592, 15623);

                    f_10963_15592_15622(this, receiver, true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15641, 15782) || true) && (!f_10963_15646_15681(f_10963_15646_15659(receiver)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 15641, 15782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 15723, 15763);

                        f_10963_15723_15762(this, f_10963_15731_15744(receiver), receiver.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 15641, 15782);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 15452, 15797);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16000, 16618) || true) && (f_10963_16004_16030(method) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 16004, 16073) && !f_10963_16035_16073(f_10963_16035_16056(method))) && (DynAbs.Tracing.TraceSender.Expression_True(10963, 16004, 16107) && f_10963_16077_16107_M(!receiver.SuppressVirtualCalls)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 16000, 16618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16212, 16246);

                    f_10963_16212_16245(                // NOTE: method.IsMetadataVirtual -> receiver != null
                                    _builder, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16264, 16304);

                    f_10963_16264_16303(_builder, ILOpCode.Ldvirtftn);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16396, 16501);

                    method = f_10963_16405_16500(method, f_10963_16448_16470(_method), requireSameReturnType: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 16000, 16618);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 16000, 16618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16567, 16603);

                    f_10963_16567_16602(_builder, ILOpCode.Ldftn);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 16000, 16618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16634, 16677);

                f_10963_16634_16676(this, method, node.Syntax, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16735, 16776);

                f_10963_16735_16775(
                            // call delegate constructor
                            _builder, ILOpCode.Newobj, -1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16831, 16889);

                var
                ctor = f_10963_16842_16888(this, node.Syntax, delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16903, 16970) || true) && ((object)ctor != null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 16903, 16970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 16929, 16970);

                    f_10963_16929_16969(this, ctor, node.Syntax, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 16903, 16970);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 14935, 16981);

                bool
                f_10963_15180_15195(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 15180, 15195);
                    return return_v;
                }


                int
                f_10963_15309_15340(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 15309, 15340);
                    return 0;
                }


                int
                f_10963_15498_15525(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EmitNullConstant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 15498, 15525);
                    return 0;
                }


                int
                f_10963_15592_15622(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expression, bool
                used)
                {
                    this_param.EmitExpression(expression, used);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 15592, 15622);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10963_15646_15659(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 15646, 15659);
                    return return_v;
                }


                bool
                f_10963_15646_15681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsVerifierReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 15646, 15681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_15731_15744(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 15731, 15744);
                    return return_v;
                }


                int
                f_10963_15723_15762(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode)
                {
                    this_param.EmitBox(type, syntaxNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 15723, 15762);
                    return 0;
                }


                bool
                f_10963_16004_16030(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16004, 16030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10963_16035_16056(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 16035, 16056);
                    return return_v;
                }


                bool
                f_10963_16035_16073(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16035, 16073);
                    return return_v;
                }


                bool
                f_10963_16077_16107_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 16077, 16107);
                    return return_v;
                }


                int
                f_10963_16212_16245(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16212, 16245);
                    return 0;
                }


                int
                f_10963_16264_16303(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16264, 16303);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10963_16448_16470(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 16448, 16470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10963_16405_16500(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetConstructedLeastOverriddenMethod(accessingTypeOpt, requireSameReturnType: requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16405, 16500);
                    return return_v;
                }


                int
                f_10963_16567_16602(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16567, 16602);
                    return 0;
                }


                int
                f_10963_16634_16676(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16634, 16676);
                    return 0;
                }


                int
                f_10963_16735_16775(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16735, 16775);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10963_16842_16888(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType)
                {
                    var return_v = this_param.DelegateConstructor(syntax, delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16842, 16888);
                    return return_v;
                }


                int
                f_10963_16929_16969(Microsoft.CodeAnalysis.CSharp.CodeGen.CodeGenerator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList)
                {
                    this_param.EmitSymbolToken(method, syntaxNode, optArgList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 16929, 16969);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 14935, 16981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 14935, 16981);
            }
        }

        private MethodSymbol DelegateConstructor(SyntaxNode syntax, TypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10963, 16993, 17959);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17102, 17751);
                    foreach (var possibleCtor in f_10963_17131_17200_I(f_10963_17131_17200(delegateType, WellKnownMemberNames.InstanceConstructorName)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 17102, 17751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17234, 17271);

                        var
                        m = possibleCtor as MethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17289, 17321) || true) && ((object)m == null)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 17289, 17321);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17312, 17321);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 17289, 17321);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17339, 17369);

                        var
                        parameters = f_10963_17356_17368(m)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17387, 17424) || true) && (parameters.Length != 2)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 17387, 17424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17415, 17424);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 17387, 17424);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17442, 17516) || true) && (f_10963_17446_17476(f_10963_17446_17464(parameters[0])) != SpecialType.System_Object)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 17442, 17516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17507, 17516);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 17442, 17516);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17534, 17575);

                        var
                        p1t = f_10963_17544_17574(f_10963_17544_17562(parameters[1]))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17593, 17736) || true) && (p1t == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10963, 17597, 17666) || p1t == SpecialType.System_UIntPtr))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10963, 17593, 17736);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17708, 17717);

                            return m;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 17593, 17736);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10963, 17102, 17751);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10963, 1, 650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10963, 1, 650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17836, 17922);

                f_10963_17836_17921(
                            // The delegate '{0}' does not have a valid constructor
                            _diagnostics, ErrorCode.ERR_BadDelegateConstructor, f_10963_17891_17906(syntax), delegateType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10963, 17936, 17948);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10963, 16993, 17959);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10963_17131_17200(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 17131, 17200);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10963_17356_17368(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17356, 17368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_17446_17464(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17446, 17464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10963_17446_17476(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17446, 17476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10963_17544_17562(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17544, 17562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10963_17544_17574(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17544, 17574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10963_17131_17200_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 17131, 17200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10963_17891_17906(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10963, 17891, 17906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10963_17836_17921(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10963, 17836, 17921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10963, 16993, 17959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10963, 16993, 17959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
