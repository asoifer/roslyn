// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LambdaCapturedVariable : SynthesizedFieldSymbolBase
    {
        private readonly TypeWithAnnotations _type;

        private readonly bool _isThis;

        private LambdaCapturedVariable(SynthesizedContainer frame, TypeWithAnnotations type, string fieldName, bool isThisParameter)
        : base(f_10456_895_900_C(frame), fieldName, isPublic: true, isReadOnly: false, isStatic: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10456, 750, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 730, 737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1069, 1096);

                f_10456_1069_1095(type.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1285, 1298);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1312, 1338);

                _isThis = isThisParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10456, 750, 1349);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 750, 1349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 750, 1349);
            }
        }

        public static LambdaCapturedVariable Create(SynthesizedClosureEnvironment frame, Symbol captured, ref int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10456, 1361, 1865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1501, 1570);

                f_10456_1501_1569(captured is LocalSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10456, 1514, 1568) || captured is ParameterSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1586, 1658);

                string
                fieldName = f_10456_1605_1657(captured, ref uniqueId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1672, 1736);

                TypeSymbol
                type = f_10456_1690_1735(frame, captured)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1750, 1854);

                return f_10456_1757_1853(frame, TypeWithAnnotations.Create(type), fieldName, f_10456_1836_1852(captured));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10456, 1361, 1865);

                int
                f_10456_1501_1569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1501, 1569);
                    return 0;
                }


                string
                f_10456_1605_1657(Microsoft.CodeAnalysis.CSharp.Symbol
                variable, ref int
                uniqueId)
                {
                    var return_v = GetCapturedVariableFieldName(variable, ref uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1605, 1657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10456_1690_1735(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                frame, Microsoft.CodeAnalysis.CSharp.Symbol
                variable)
                {
                    var return_v = GetCapturedVariableFieldType((Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer)frame, variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1690, 1735);
                    return return_v;
                }


                bool
                f_10456_1836_1852(Microsoft.CodeAnalysis.CSharp.Symbol
                captured)
                {
                    var return_v = IsThis(captured);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1836, 1852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
                f_10456_1757_1853(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                frame, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, string
                fieldName, bool
                isThisParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable((Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer)frame, type, fieldName, isThisParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1757, 1853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 1361, 1865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 1361, 1865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsThis(Symbol captured)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10456, 1877, 2067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 1945, 1989);

                var
                parameter = captured as ParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2003, 2056);

                return (object)parameter != null && (DynAbs.Tracing.TraceSender.Expression_True(10456, 2010, 2055) && f_10456_2039_2055(parameter));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10456, 1877, 2067);

                bool
                f_10456_2039_2055(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsThis;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 2039, 2055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 1877, 2067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 1877, 2067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetCapturedVariableFieldName(Symbol variable, ref int uniqueId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10456, 2079, 3963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2189, 2301) || true) && (f_10456_2193_2209(variable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 2189, 2301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2243, 2286);

                    return f_10456_2250_2285();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 2189, 2301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2317, 2353);

                var
                local = variable as LocalSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2367, 3865) || true) && ((object)local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 2367, 3865);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2426, 2616) || true) && (f_10456_2430_2451(local) == SynthesizedLocalKind.LambdaDisplayClass)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 2426, 2616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2536, 2597);

                        return f_10456_2543_2596(uniqueId++);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 2426, 2616);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2636, 2871) || true) && (f_10456_2640_2661(local) == SynthesizedLocalKind.ExceptionFilterAwaitHoistedExceptionLocal)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 2636, 2871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2769, 2852);

                        return f_10456_2776_2851(f_10456_2817_2838(local), uniqueId++);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 2636, 2871);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 2891, 3110) || true) && (f_10456_2895_2916(local) == SynthesizedLocalKind.InstrumentationPayload)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 2891, 3110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 3005, 3091);

                        return f_10456_3012_3090(uniqueId++);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 2891, 3110);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 3130, 3850) || true) && (f_10456_3134_3155(local) == SynthesizedLocalKind.UserDefined && (DynAbs.Tracing.TraceSender.Expression_True(10456, 3134, 3370) && (f_10456_3242_3249(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10456_3217_3241(local), 10456, 3217, 3249)) == SyntaxKind.SwitchSection || (DynAbs.Tracing.TraceSender.Expression_False(10456, 3217, 3369) || f_10456_3328_3335(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10456_3303_3327(local), 10456, 3303, 3335)) == SyntaxKind.SwitchExpressionArm))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 3130, 3850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 3736, 3831);

                        return f_10456_3743_3830(f_10456_3784_3805(local), uniqueId++, f_10456_3819_3829(local));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 3130, 3850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 2367, 3865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 3881, 3917);

                f_10456_3881_3916(f_10456_3894_3907(variable) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 3931, 3952);

                return f_10456_3938_3951(variable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10456, 2079, 3963);

                bool
                f_10456_2193_2209(Microsoft.CodeAnalysis.CSharp.Symbol
                captured)
                {
                    var return_v = IsThis(captured);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 2193, 2209);
                    return return_v;
                }


                string
                f_10456_2250_2285()
                {
                    var return_v = GeneratedNames.ThisProxyFieldName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 2250, 2285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_2430_2451(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 2430, 2451);
                    return return_v;
                }


                string
                f_10456_2543_2596(int
                uniqueId)
                {
                    var return_v = GeneratedNames.MakeLambdaDisplayLocalName(uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 2543, 2596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_2640_2661(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 2640, 2661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_2817_2838(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 2817, 2838);
                    return return_v;
                }


                string
                f_10456_2776_2851(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, int
                slotIndex)
                {
                    var return_v = GeneratedNames.MakeHoistedLocalFieldName(kind, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 2776, 2851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_2895_2916(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 2895, 2916);
                    return return_v;
                }


                string
                f_10456_3012_3090(int
                uniqueId)
                {
                    var return_v = GeneratedNames.MakeSynthesizedInstrumentationPayloadLocalFieldName(uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 3012, 3090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_3134_3155(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3134, 3155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10456_3217_3241(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3217, 3241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10456_3242_3249(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 3242, 3249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10456_3303_3327(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeDesignatorOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3303, 3327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10456_3328_3335(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node?.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 3328, 3335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SynthesizedLocalKind
                f_10456_3784_3805(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizedKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3784, 3805);
                    return return_v;
                }


                string
                f_10456_3819_3829(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3819, 3829);
                    return return_v;
                }


                string
                f_10456_3743_3830(Microsoft.CodeAnalysis.SynthesizedLocalKind
                kind, int
                slotIndex, string
                localNameOpt)
                {
                    var return_v = GeneratedNames.MakeHoistedLocalFieldName(kind, slotIndex, localNameOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 3743, 3830);
                    return return_v;
                }


                string
                f_10456_3894_3907(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3894, 3907);
                    return return_v;
                }


                int
                f_10456_3881_3916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 3881, 3916);
                    return 0;
                }


                string
                f_10456_3938_3951(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 3938, 3951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 2079, 3963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 2079, 3963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol GetCapturedVariableFieldType(SynthesizedContainer frame, Symbol variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10456, 3975, 5206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4099, 4135);

                var
                local = variable as LocalSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4149, 5030) || true) && ((object)local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 4149, 5030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4322, 4403);

                    var
                    lambdaFrame = f_10456_4340_4369(f_10456_4340_4350(local)) as SynthesizedClosureEnvironment
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4421, 5015) || true) && ((object)lambdaFrame != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 4421, 5015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4630, 4705);

                        var
                        typeArguments = f_10456_4650_4704(frame)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4727, 4919) || true) && (typeArguments.Length > f_10456_4754_4771(lambdaFrame))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10456, 4727, 4919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4821, 4896);

                            typeArguments = f_10456_4837_4895(typeArguments, 0, f_10456_4877_4894(lambdaFrame));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 4727, 4919);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 4943, 4996);

                        return lambdaFrame.ConstructIfGeneric(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 4421, 5015);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10456, 4149, 5030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 5046, 5195);

                return f_10456_5053_5189(f_10456_5053_5066(frame), ((DynAbs.Tracing.TraceSender.Conditional_F1(10456, 5083, 5104) || (((object)local != null && DynAbs.Tracing.TraceSender.Conditional_F2(10456, 5107, 5132)) || DynAbs.Tracing.TraceSender.Conditional_F3(10456, 5135, 5182))) ? f_10456_5107_5132(local) : f_10456_5135_5182(((ParameterSymbol)variable))).Type).Type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10456, 3975, 5206);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10456_4340_4350(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 4340, 4350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10456_4340_4369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 4340, 4369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10456_4650_4704(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 4650, 4704);
                    return return_v;
                }


                int
                f_10456_4754_4771(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 4754, 4771);
                    return return_v;
                }


                int
                f_10456_4877_4894(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 4877, 4894);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10456_4837_4895(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items, int
                start, int
                length)
                {
                    var return_v = ImmutableArray.Create(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 4837, 4895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10456_5053_5066(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 5053, 5066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10456_5107_5132(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 5107, 5132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10456_5135_5182(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10456, 5135, 5182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10456_5053_5189(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 5053, 5189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 3975, 5206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 3975, 5206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10456, 5218, 5357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 5333, 5346);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10456, 5218, 5357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 5218, 5357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 5218, 5357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsCapturedFrame
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10456, 5432, 5498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 5468, 5483);

                    return _isThis;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10456, 5432, 5498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 5369, 5509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 5369, 5509);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10456, 5593, 5657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10456, 5629, 5642);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10456, 5593, 5657);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10456, 5521, 5668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 5521, 5668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static LambdaCapturedVariable()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10456, 565, 5675);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10456, 565, 5675);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10456, 565, 5675);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10456, 565, 5675);

        int
        f_10456_1069_1095(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10456, 1069, 1095);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10456_895_900_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10456, 750, 1349);
            return return_v;
        }

    }
}
