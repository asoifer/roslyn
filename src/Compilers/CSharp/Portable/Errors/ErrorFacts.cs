// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class ErrorFacts
    {
        private const string
        s_titleSuffix = "_Title"
        ;

        private const string
        s_descriptionSuffix = "_Description"
        ;

        private static readonly Lazy<ImmutableDictionary<ErrorCode, string>> s_categoriesMap;

        public static readonly ImmutableHashSet<string> NullableWarnings;

        static ErrorFacts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10610, 873, 6297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 526, 550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 582, 618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 698, 785);
                s_categoriesMap = f_10610_716_785(CreateCategoriesMap); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 844, 860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9795, 9812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 917, 1010);

                ImmutableHashSet<string>.Builder
                nullableWarnings = f_10610_969_1009()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1026, 1093);

                f_10610_1026_1092(
                            nullableWarnings, f_10610_1047_1091(ErrorCode.WRN_NullReferenceAssignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1107, 1172);

                f_10610_1107_1171(nullableWarnings, f_10610_1128_1170(ErrorCode.WRN_NullReferenceReceiver));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1186, 1249);

                f_10610_1186_1248(nullableWarnings, f_10610_1207_1247(ErrorCode.WRN_NullReferenceReturn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1263, 1328);

                f_10610_1263_1327(nullableWarnings, f_10610_1284_1326(ErrorCode.WRN_NullReferenceArgument));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1342, 1415);

                f_10610_1342_1414(nullableWarnings, f_10610_1363_1413(ErrorCode.WRN_UninitializedNonNullableField));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1429, 1504);

                f_10610_1429_1503(nullableWarnings, f_10610_1450_1502(ErrorCode.WRN_NullabilityMismatchInAssignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1518, 1591);

                f_10610_1518_1590(nullableWarnings, f_10610_1539_1589(ErrorCode.WRN_NullabilityMismatchInArgument));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1605, 1687);

                f_10610_1605_1686(nullableWarnings, f_10610_1626_1685(ErrorCode.WRN_NullabilityMismatchInArgumentForOutput));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1701, 1792);

                f_10610_1701_1791(nullableWarnings, f_10610_1722_1790(ErrorCode.WRN_NullabilityMismatchInReturnTypeOfTargetDelegate));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1806, 1900);

                f_10610_1806_1899(nullableWarnings, f_10610_1827_1898(ErrorCode.WRN_NullabilityMismatchInParameterTypeOfTargetDelegate));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1914, 1975);

                f_10610_1914_1974(nullableWarnings, f_10610_1935_1973(ErrorCode.WRN_NullAsNonNullable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 1989, 2059);

                f_10610_1989_2058(nullableWarnings, f_10610_2010_2057(ErrorCode.WRN_NullableValueTypeMayBeNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2073, 2161);

                f_10610_2073_2160(nullableWarnings, f_10610_2094_2159(ErrorCode.WRN_NullabilityMismatchInTypeParameterConstraint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2175, 2276);

                f_10610_2175_2275(nullableWarnings, f_10610_2196_2274(ErrorCode.WRN_NullabilityMismatchInTypeParameterReferenceTypeConstraint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2290, 2385);

                f_10610_2290_2384(nullableWarnings, f_10610_2311_2383(ErrorCode.WRN_NullabilityMismatchInTypeParameterNotNullConstraint));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2399, 2460);

                f_10610_2399_2459(nullableWarnings, f_10610_2420_2458(ErrorCode.WRN_ThrowPossibleNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2474, 2535);

                f_10610_2474_2534(nullableWarnings, f_10610_2495_2533(ErrorCode.WRN_UnboxPossibleNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2549, 2629);

                f_10610_2549_2628(nullableWarnings, f_10610_2570_2627(ErrorCode.WRN_SwitchExpressionNotExhaustiveForNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2643, 2731);

                f_10610_2643_2730(nullableWarnings, f_10610_2664_2729(ErrorCode.WRN_SwitchExpressionNotExhaustiveForNullWithWhen));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2747, 2822);

                f_10610_2747_2821(
                            nullableWarnings, f_10610_2768_2820(ErrorCode.WRN_ConvertingNullableToNonNullable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2836, 2927);

                f_10610_2836_2926(nullableWarnings, f_10610_2857_2925(ErrorCode.WRN_DisallowNullAttributeForbidsMaybeNullAssignment));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 2941, 3020);

                f_10610_2941_3019(nullableWarnings, f_10610_2962_3018(ErrorCode.WRN_ParameterConditionallyDisallowsNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3034, 3093);

                f_10610_3034_3092(nullableWarnings, f_10610_3055_3091(ErrorCode.WRN_ShouldNotReturn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3109, 3188);

                f_10610_3109_3187(
                            nullableWarnings, f_10610_3130_3186(ErrorCode.WRN_NullabilityMismatchInTypeOnOverride));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3202, 3287);

                f_10610_3202_3286(nullableWarnings, f_10610_3223_3285(ErrorCode.WRN_NullabilityMismatchInReturnTypeOnOverride));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3301, 3385);

                f_10610_3301_3384(nullableWarnings, f_10610_3322_3383(ErrorCode.WRN_NullabilityMismatchInReturnTypeOnPartial));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3399, 3487);

                f_10610_3399_3486(nullableWarnings, f_10610_3420_3485(ErrorCode.WRN_NullabilityMismatchInParameterTypeOnOverride));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3501, 3588);

                f_10610_3501_3587(nullableWarnings, f_10610_3522_3586(ErrorCode.WRN_NullabilityMismatchInParameterTypeOnPartial));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3602, 3695);

                f_10610_3602_3694(nullableWarnings, f_10610_3623_3693(ErrorCode.WRN_NullabilityMismatchInTypeOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3709, 3808);

                f_10610_3709_3807(nullableWarnings, f_10610_3730_3806(ErrorCode.WRN_NullabilityMismatchInReturnTypeOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3822, 3924);

                f_10610_3822_3923(nullableWarnings, f_10610_3843_3922(ErrorCode.WRN_NullabilityMismatchInParameterTypeOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 3938, 4031);

                f_10610_3938_4030(nullableWarnings, f_10610_3959_4029(ErrorCode.WRN_NullabilityMismatchInTypeOnExplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4045, 4144);

                f_10610_4045_4143(nullableWarnings, f_10610_4066_4142(ErrorCode.WRN_NullabilityMismatchInReturnTypeOnExplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4158, 4260);

                f_10610_4158_4259(nullableWarnings, f_10610_4179_4258(ErrorCode.WRN_NullabilityMismatchInParameterTypeOnExplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4274, 4374);

                f_10610_4274_4373(nullableWarnings, f_10610_4295_4372(ErrorCode.WRN_NullabilityMismatchInConstraintsOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4388, 4483);

                f_10610_4388_4482(nullableWarnings, f_10610_4409_4481(ErrorCode.WRN_NullabilityMismatchInExplicitlyImplementedInterface));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4497, 4588);

                f_10610_4497_4587(nullableWarnings, f_10610_4518_4586(ErrorCode.WRN_NullabilityMismatchInInterfaceImplementedByBase));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4602, 4697);

                f_10610_4602_4696(nullableWarnings, f_10610_4623_4695(ErrorCode.WRN_DuplicateInterfaceWithNullabilityMismatchInBaseList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4711, 4810);

                f_10610_4711_4809(nullableWarnings, f_10610_4732_4808(ErrorCode.WRN_NullabilityMismatchInConstraintsOnPartialImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4824, 4892);

                f_10610_4824_4891(nullableWarnings, f_10610_4845_4890(ErrorCode.WRN_NullReferenceInitializer));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4906, 4965);

                f_10610_4906_4964(nullableWarnings, f_10610_4927_4963(ErrorCode.WRN_ShouldNotReturn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 4979, 5044);

                f_10610_4979_5043(nullableWarnings, f_10610_5000_5042(ErrorCode.WRN_DoesNotReturnMismatch));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5058, 5168);

                f_10610_5058_5167(nullableWarnings, f_10610_5079_5166(ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnExplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5182, 5292);

                f_10610_5182_5291(nullableWarnings, f_10610_5203_5290(ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5306, 5402);

                f_10610_5306_5401(nullableWarnings, f_10610_5327_5400(ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnOverride));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5416, 5523);

                f_10610_5416_5522(nullableWarnings, f_10610_5437_5521(ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnExplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5537, 5644);

                f_10610_5537_5643(nullableWarnings, f_10610_5558_5642(ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnImplicitImplementation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5658, 5751);

                f_10610_5658_5750(nullableWarnings, f_10610_5679_5749(ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnOverride));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5765, 5822);

                f_10610_5765_5821(nullableWarnings, f_10610_5786_5820(ErrorCode.WRN_MemberNotNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5836, 5902);

                f_10610_5836_5901(nullableWarnings, f_10610_5857_5900(ErrorCode.WRN_MemberNotNullBadMember));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5916, 5977);

                f_10610_5916_5976(nullableWarnings, f_10610_5937_5975(ErrorCode.WRN_MemberNotNullWhen));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 5991, 6057);

                f_10610_5991_6056(nullableWarnings, f_10610_6012_6055(ErrorCode.WRN_ParameterDisallowsNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6071, 6140);

                f_10610_6071_6139(nullableWarnings, f_10610_6092_6138(ErrorCode.WRN_ParameterNotNullIfNotNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6154, 6220);

                f_10610_6154_6219(nullableWarnings, f_10610_6175_6218(ErrorCode.WRN_ReturnNotNullIfNotNull));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6236, 6286);

                NullableWarnings = f_10610_6255_6285(nullableWarnings);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10610, 873, 6297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 873, 6297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 873, 6297);
            }
        }

        private static string GetId(ErrorCode errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 6309, 6459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6382, 6448);

                return f_10610_6389_6447(MessageProvider.Instance, errorCode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 6309, 6459);

                string
                f_10610_6389_6447(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6389, 6447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 6309, 6459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 6309, 6459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableDictionary<ErrorCode, string> CreateCategoriesMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 6471, 6757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6571, 6695);

                var
                map = f_10610_6581_6694()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6711, 6746);

                return f_10610_6718_6745(map);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 6471, 6757);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>
                f_10610_6581_6694()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6581, 6694);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>
                f_10610_6718_6745(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>
                source)
                {
                    var return_v = source.ToImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6718, 6745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 6471, 6757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 6471, 6757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticSeverity GetSeverity(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 6769, 7573);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6856, 7562) || true) && (code == ErrorCode.Void)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 6856, 7562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6916, 6955);

                    return InternalDiagnosticSeverity.Void;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 6856, 7562);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 6856, 7562);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 6989, 7562) || true) && (code == ErrorCode.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 6989, 7562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7052, 7094);

                        return InternalDiagnosticSeverity.Unknown;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 6989, 7562);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 6989, 7562);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7128, 7562) || true) && (f_10610_7132_7147(code))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7128, 7562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7181, 7215);

                            return DiagnosticSeverity.Warning;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7128, 7562);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7128, 7562);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7249, 7562) || true) && (f_10610_7253_7265(code))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7249, 7562);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7299, 7330);

                                return DiagnosticSeverity.Info;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7249, 7562);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7249, 7562);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7364, 7562) || true) && (f_10610_7368_7382(code))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7364, 7562);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7416, 7449);

                                    return DiagnosticSeverity.Hidden;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7364, 7562);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 7364, 7562);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7515, 7547);

                                    return DiagnosticSeverity.Error;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7364, 7562);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7249, 7562);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 7128, 7562);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 6989, 7562);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 6856, 7562);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 6769, 7573);

                bool
                f_10610_7132_7147(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsWarning(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7132, 7147);
                    return return_v;
                }


                bool
                f_10610_7253_7265(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7253, 7265);
                    return return_v;
                }


                bool
                f_10610_7368_7382(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsHidden(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7368, 7382);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 6769, 7573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 6769, 7573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMessage(MessageID code, CultureInfo culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 7668, 7946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7761, 7830);

                string
                message = f_10610_7778_7829(f_10610_7778_7793(), f_10610_7804_7819(code), culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7844, 7906);

                f_10610_7844_7905(!f_10610_7858_7887(message), f_10610_7889_7904(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 7920, 7935);

                return message;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 7668, 7946);

                System.Resources.ResourceManager
                f_10610_7778_7793()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 7778, 7793);
                    return return_v;
                }


                string
                f_10610_7804_7819(Microsoft.CodeAnalysis.CSharp.MessageID
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7804, 7819);
                    return return_v;
                }


                string?
                f_10610_7778_7829(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7778, 7829);
                    return return_v;
                }


                bool
                f_10610_7858_7887(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7858, 7887);
                    return return_v;
                }


                string
                f_10610_7889_7904(Microsoft.CodeAnalysis.CSharp.MessageID
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7889, 7904);
                    return return_v;
                }


                int
                f_10610_7844_7905(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 7844, 7905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 7668, 7946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 7668, 7946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMessage(ErrorCode code, CultureInfo culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 8041, 8319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8134, 8203);

                string
                message = f_10610_8151_8202(f_10610_8151_8166(), f_10610_8177_8192(code), culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8217, 8279);

                f_10610_8217_8278(!f_10610_8231_8260(message), f_10610_8262_8277(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8293, 8308);

                return message;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 8041, 8319);

                System.Resources.ResourceManager
                f_10610_8151_8166()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 8151, 8166);
                    return return_v;
                }


                string
                f_10610_8177_8192(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8177, 8192);
                    return return_v;
                }


                string?
                f_10610_8151_8202(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8151, 8202);
                    return return_v;
                }


                bool
                f_10610_8231_8260(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8231, 8260);
                    return return_v;
                }


                string
                f_10610_8262_8277(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8262, 8277);
                    return return_v;
                }


                int
                f_10610_8217_8278(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8217, 8278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 8041, 8319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 8041, 8319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalizableResourceString GetMessageFormat(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 8331, 8530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8428, 8519);

                return f_10610_8435_8518(f_10610_8465_8480(code), f_10610_8482_8497(), typeof(ErrorFacts));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 8331, 8530);

                string
                f_10610_8465_8480(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8465, 8480);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_10610_8482_8497()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 8482, 8497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10610_8435_8518(string
                nameOfLocalizableResource, System.Resources.ResourceManager
                resourceManager, System.Type
                resourceSource)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalizableResourceString(nameOfLocalizableResource, resourceManager, resourceSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8435, 8518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 8331, 8530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 8331, 8530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalizableResourceString GetTitle(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 8542, 8749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8631, 8738);

                return f_10610_8638_8737(f_10610_8668_8683(code) + s_titleSuffix, f_10610_8701_8716(), typeof(ErrorFacts));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 8542, 8749);

                string
                f_10610_8668_8683(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8668, 8683);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_10610_8701_8716()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 8701, 8716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10610_8638_8737(string
                nameOfLocalizableResource, System.Resources.ResourceManager
                resourceManager, System.Type
                resourceSource)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalizableResourceString(nameOfLocalizableResource, resourceManager, resourceSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8638, 8737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 8542, 8749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 8542, 8749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LocalizableResourceString GetDescription(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 8761, 8980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 8856, 8969);

                return f_10610_8863_8968(f_10610_8893_8908(code) + s_descriptionSuffix, f_10610_8932_8947(), typeof(ErrorFacts));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 8761, 8980);

                string
                f_10610_8893_8908(Microsoft.CodeAnalysis.CSharp.ErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8893, 8908);
                    return return_v;
                }


                System.Resources.ResourceManager
                f_10610_8932_8947()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 8932, 8947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10610_8863_8968(string
                nameOfLocalizableResource, System.Resources.ResourceManager
                resourceManager, System.Type
                resourceSource)
                {
                    var return_v = new Microsoft.CodeAnalysis.LocalizableResourceString(nameOfLocalizableResource, resourceManager, resourceSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 8863, 8968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 8761, 8980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 8761, 8980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetHelpLink(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 8992, 9164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9065, 9153);

                return $"https://msdn.microsoft.com/query/roslyn.query?appId=roslyn&k=k({f_10610_9138_9149(code)})";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 8992, 9164);

                string
                f_10610_9138_9149(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = GetId(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 9138, 9149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 8992, 9164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 8992, 9164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetCategory(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 9176, 9473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9249, 9265);

                string
                category
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9279, 9401) || true) && (f_10610_9283_9336(f_10610_9283_9304(s_categoriesMap), code, out category))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 9279, 9401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9370, 9386);

                    return category;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 9279, 9401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9417, 9462);

                return Diagnostic.CompilerDiagnosticCategory;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 9176, 9473);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>
                f_10610_9283_9304(System.Lazy<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 9283, 9304);
                    return return_v;
                }


                bool
                f_10610_9283_9336(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 9283, 9336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 9176, 9473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 9176, 9473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetMessage(XmlParseErrorCode id, CultureInfo culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 9568, 9735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9667, 9724);

                return f_10610_9674_9723(f_10610_9674_9689(), f_10610_9700_9713(id), culture);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 9568, 9735);

                System.Resources.ResourceManager
                f_10610_9674_9689()
                {
                    var return_v = ResourceManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 9674, 9689);
                    return return_v;
                }


                string
                f_10610_9700_9713(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 9700, 9713);
                    return return_v;
                }


                string?
                f_10610_9674_9723(System.Resources.ResourceManager
                this_param, string
                name, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.GetString(name, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 9674, 9723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 9568, 9735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 9568, 9735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static System.Resources.ResourceManager s_resourceManager;

        private static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 9911, 10230);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 9947, 10170) || true) && (s_resourceManager == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 9947, 10170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 10018, 10151);

                        s_resourceManager = f_10610_10038_10150(f_10610_10075_10107(typeof(CSharpResources)), f_10610_10109_10149(f_10610_10109_10140(typeof(ErrorCode))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 9947, 10170);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 10190, 10215);

                    return s_resourceManager;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 9911, 10230);

                    string?
                    f_10610_10075_10107(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 10075, 10107);
                        return return_v;
                    }


                    System.Reflection.TypeInfo
                    f_10610_10109_10140(System.Type
                    type)
                    {
                        var return_v = type.GetTypeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 10109, 10140);
                        return return_v;
                    }


                    System.Reflection.Assembly
                    f_10610_10109_10149(System.Reflection.TypeInfo
                    this_param)
                    {
                        var return_v = this_param.Assembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 10109, 10149);
                        return return_v;
                    }


                    System.Resources.ResourceManager
                    f_10610_10038_10150(string?
                    baseName, System.Reflection.Assembly
                    assembly)
                    {
                        var return_v = new System.Resources.ResourceManager(baseName, assembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 10038, 10150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 9823, 10241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 9823, 10241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static int GetWarningLevel(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 10253, 27823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 10329, 10569) || true) && (f_10610_10333_10345(code) || (DynAbs.Tracing.TraceSender.Expression_False(10610, 10333, 10363) || f_10610_10349_10363(code)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10329, 10569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 10510, 10554);

                    return Diagnostic.InfoAndHiddenWarningLevel;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10329, 10569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 10585, 27692);

                switch (code)
                {

                    case ErrorCode.WRN_NubExprIsConstBool2:
                    case ErrorCode.WRN_StaticInAsOrIs:
                    case ErrorCode.WRN_PrecedenceInversion:
                    case ErrorCode.WRN_UnassignedThisAutoProperty:
                    case ErrorCode.WRN_UnassignedThis:
                    case ErrorCode.WRN_ParamUnassigned:
                    case ErrorCode.WRN_UseDefViolationProperty:
                    case ErrorCode.WRN_UseDefViolationField:
                    case ErrorCode.WRN_UseDefViolationThis:
                    case ErrorCode.WRN_UseDefViolationOut:
                    case ErrorCode.WRN_UseDefViolation:
                    case ErrorCode.WRN_SyncAndAsyncEntryPoints:
                    case ErrorCode.WRN_ParameterIsStaticClass:
                    case ErrorCode.WRN_ReturnTypeIsStaticClass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 11633, 11642);

                        return 5;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);

                    case ErrorCode.WRN_InvalidMainSig:
                    case ErrorCode.WRN_LowercaseEllSuffix:
                    case ErrorCode.WRN_NewNotRequired:
                    case ErrorCode.WRN_MainCantBeGeneric:
                    case ErrorCode.WRN_ProtectedInSealed:
                    case ErrorCode.WRN_UnassignedInternalField:
                    case ErrorCode.WRN_MissingParamTag:
                    case ErrorCode.WRN_MissingXMLComment:
                    case ErrorCode.WRN_MissingTypeParamTag:
                    case ErrorCode.WRN_InvalidVersionFormat:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 12218, 12227);

                        return 4;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);

                    case ErrorCode.WRN_UnreferencedEvent:
                    case ErrorCode.WRN_DuplicateUsing:
                    case ErrorCode.WRN_UnreferencedVar:
                    case ErrorCode.WRN_UnreferencedField:
                    case ErrorCode.WRN_UnreferencedVarAssg:
                    case ErrorCode.WRN_UnreferencedLocalFunction:
                    case ErrorCode.WRN_SequentialOnPartialClass:
                    case ErrorCode.WRN_UnreferencedFieldAssg:
                    case ErrorCode.WRN_AmbiguousXMLReference:
                    case ErrorCode.WRN_PossibleMistakenNullStatement:
                    case ErrorCode.WRN_EqualsWithoutGetHashCode:
                    case ErrorCode.WRN_EqualityOpWithoutEquals:
                    case ErrorCode.WRN_EqualityOpWithoutGetHashCode:
                    case ErrorCode.WRN_IncorrectBooleanAssg:
                    case ErrorCode.WRN_BitwiseOrSignExtend:
                    case ErrorCode.WRN_TypeParameterSameAsOuterTypeParameter:
                    case ErrorCode.WRN_InvalidAssemblyName:
                    case ErrorCode.WRN_UnifyReferenceBldRev:
                    case ErrorCode.WRN_AssignmentToSelf:
                    case ErrorCode.WRN_ComparisonToSelf:
                    case ErrorCode.WRN_IsDynamicIsConfusing:
                    case ErrorCode.WRN_DebugFullNameTooLong:
                    case ErrorCode.WRN_PdbLocalNameTooLong:
                    case ErrorCode.WRN_RecordEqualsWithoutGetHashCode:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 13674, 13683);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);

                    case ErrorCode.WRN_NewRequired:
                    case ErrorCode.WRN_NewOrOverrideExpected:
                    case ErrorCode.WRN_UnreachableCode:
                    case ErrorCode.WRN_UnreferencedLabel:
                    case ErrorCode.WRN_NegativeArrayIndex:
                    case ErrorCode.WRN_BadRefCompareLeft:
                    case ErrorCode.WRN_BadRefCompareRight:
                    case ErrorCode.WRN_PatternIsAmbiguous:
                    case ErrorCode.WRN_PatternNotPublicOrNotInstance:
                    case ErrorCode.WRN_PatternBadSignature:
                    case ErrorCode.WRN_SameFullNameThisNsAgg:
                    case ErrorCode.WRN_SameFullNameThisAggAgg:
                    case ErrorCode.WRN_SameFullNameThisAggNs:
                    case ErrorCode.WRN_GlobalAliasDefn:
                    case ErrorCode.WRN_AlwaysNull:
                    case ErrorCode.WRN_CmpAlwaysFalse:
                    case ErrorCode.WRN_GotoCaseShouldConvert:
                    case ErrorCode.WRN_NubExprIsConstBool:
                    case ErrorCode.WRN_ExplicitImplCollision:
                    case ErrorCode.WRN_DeprecatedSymbolStr:
                    case ErrorCode.WRN_VacuousIntegralComp:
                    case ErrorCode.WRN_AssignmentToLockOrDispose:
                    case ErrorCode.WRN_DeprecatedCollectionInitAddStr:
                    case ErrorCode.WRN_DeprecatedCollectionInitAdd:
                    case ErrorCode.WRN_DuplicateParamTag:
                    case ErrorCode.WRN_UnmatchedParamTag:
                    case ErrorCode.WRN_UnprocessedXMLComment:
                    case ErrorCode.WRN_InvalidSearchPathDir:
                    case ErrorCode.WRN_UnifyReferenceMajMin:
                    case ErrorCode.WRN_DuplicateTypeParamTag:
                    case ErrorCode.WRN_UnmatchedTypeParamTag:
                    case ErrorCode.WRN_UnmatchedParamRefTag:
                    case ErrorCode.WRN_UnmatchedTypeParamRefTag:
                    case ErrorCode.WRN_CantHaveManifestForModule:
                    case ErrorCode.WRN_DynamicDispatchToConditionalMethod:
                    case ErrorCode.WRN_NoSources:
                    case ErrorCode.WRN_CLS_MeaninglessOnPrivateType:
                    case ErrorCode.WRN_CLS_AssemblyNotCLS2:
                    case ErrorCode.WRN_MainIgnored:
                    case ErrorCode.WRN_UnqualifiedNestedTypeInCref:
                    case ErrorCode.WRN_NoRuntimeMetadataVersion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 16087, 16096);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);

                    case ErrorCode.WRN_IsAlwaysTrue:
                    case ErrorCode.WRN_IsAlwaysFalse:
                    case ErrorCode.WRN_ByRefNonAgileField:
                    case ErrorCode.WRN_VolatileByRef:
                    case ErrorCode.WRN_FinalizeMethod:
                    case ErrorCode.WRN_DeprecatedSymbol:
                    case ErrorCode.WRN_ExternMethodNoImplementation:
                    case ErrorCode.WRN_AttributeLocationOnBadDeclaration:
                    case ErrorCode.WRN_InvalidAttributeLocation:
                    case ErrorCode.WRN_NonObsoleteOverridingObsolete:
                    case ErrorCode.WRN_CoClassWithoutComImport:
                    case ErrorCode.WRN_ObsoleteOverridingNonObsolete:
                    case ErrorCode.WRN_ExternCtorNoImplementation:
                    case ErrorCode.WRN_WarningDirective:
                    case ErrorCode.WRN_UnreachableGeneralCatch:
                    case ErrorCode.WRN_DefaultValueForUnconsumedLocation:
                    case ErrorCode.WRN_EmptySwitch:
                    case ErrorCode.WRN_XMLParseError:
                    case ErrorCode.WRN_BadXMLRef:
                    case ErrorCode.WRN_BadXMLRefParamType:
                    case ErrorCode.WRN_BadXMLRefReturnType:
                    case ErrorCode.WRN_BadXMLRefSyntax:
                    case ErrorCode.WRN_FailedInclude:
                    case ErrorCode.WRN_InvalidInclude:
                    case ErrorCode.WRN_XMLParseIncludeError:
                    case ErrorCode.WRN_ALinkWarn:
                    case ErrorCode.WRN_AssemblyAttributeFromModuleIsOverridden:
                    case ErrorCode.WRN_CmdOptionConflictsSource:
                    case ErrorCode.WRN_IllegalPragma:
                    case ErrorCode.WRN_IllegalPPWarning:
                    case ErrorCode.WRN_BadRestoreNumber:
                    case ErrorCode.WRN_NonECMAFeature:
                    case ErrorCode.WRN_ErrorOverride:
                    case ErrorCode.WRN_MultiplePredefTypes:
                    case ErrorCode.WRN_TooManyLinesForDebugger:
                    case ErrorCode.WRN_CallOnNonAgileField:
                    case ErrorCode.WRN_InvalidNumber:
                    case ErrorCode.WRN_IllegalPPChecksum:
                    case ErrorCode.WRN_EndOfPPLineExpected:
                    case ErrorCode.WRN_ConflictingChecksum:
                    case ErrorCode.WRN_DotOnDefault:
                    case ErrorCode.WRN_BadXMLRefTypeVar:
                    case ErrorCode.WRN_ReferencedAssemblyReferencesLinkedPIA:
                    case ErrorCode.WRN_MultipleRuntimeImplementationMatches:
                    case ErrorCode.WRN_MultipleRuntimeOverrideMatches:
                    case ErrorCode.WRN_FileAlreadyIncluded:
                    case ErrorCode.WRN_NoConfigNotOnCommandLine:
                    case ErrorCode.WRN_AnalyzerCannotBeCreated:
                    case ErrorCode.WRN_NoAnalyzerInAssembly:
                    case ErrorCode.WRN_UnableToLoadAnalyzer:
                    case ErrorCode.WRN_DefineIdentifierRequired:
                    case ErrorCode.WRN_CLS_NoVarArgs:
                    case ErrorCode.WRN_CLS_BadArgType:
                    case ErrorCode.WRN_CLS_BadReturnType:
                    case ErrorCode.WRN_CLS_BadFieldPropType:
                    case ErrorCode.WRN_CLS_BadIdentifierCase:
                    case ErrorCode.WRN_CLS_OverloadRefOut:
                    case ErrorCode.WRN_CLS_OverloadUnnamed:
                    case ErrorCode.WRN_CLS_BadIdentifier:
                    case ErrorCode.WRN_CLS_BadBase:
                    case ErrorCode.WRN_CLS_BadInterfaceMember:
                    case ErrorCode.WRN_CLS_NoAbstractMembers:
                    case ErrorCode.WRN_CLS_NotOnModules:
                    case ErrorCode.WRN_CLS_ModuleMissingCLS:
                    case ErrorCode.WRN_CLS_AssemblyNotCLS:
                    case ErrorCode.WRN_CLS_BadAttributeType:
                    case ErrorCode.WRN_CLS_ArrayArgumentToAttribute:
                    case ErrorCode.WRN_CLS_NotOnModules2:
                    case ErrorCode.WRN_CLS_IllegalTrueInFalse:
                    case ErrorCode.WRN_CLS_MeaninglessOnParam:
                    case ErrorCode.WRN_CLS_MeaninglessOnReturn:
                    case ErrorCode.WRN_CLS_BadTypeVar:
                    case ErrorCode.WRN_CLS_VolatileField:
                    case ErrorCode.WRN_CLS_BadInterface:
                    case ErrorCode.WRN_UnobservedAwaitableExpression:
                    case ErrorCode.WRN_CallerLineNumberParamForUnconsumedLocation:
                    case ErrorCode.WRN_CallerFilePathParamForUnconsumedLocation:
                    case ErrorCode.WRN_CallerMemberNameParamForUnconsumedLocation:
                    case ErrorCode.WRN_CallerFilePathPreferredOverCallerMemberName:
                    case ErrorCode.WRN_CallerLineNumberPreferredOverCallerMemberName:
                    case ErrorCode.WRN_CallerLineNumberPreferredOverCallerFilePath:
                    case ErrorCode.WRN_DelaySignButNoKey:
                    case ErrorCode.WRN_UnimplementedCommandLineSwitch:
                    case ErrorCode.WRN_AsyncLacksAwaits:
                    case ErrorCode.WRN_BadUILang:
                    case ErrorCode.WRN_RefCultureMismatch:
                    case ErrorCode.WRN_ConflictingMachineAssembly:
                    case ErrorCode.WRN_FilterIsConstantTrue:
                    case ErrorCode.WRN_FilterIsConstantFalse:
                    case ErrorCode.WRN_FilterIsConstantFalseRedundantTryCatch:
                    case ErrorCode.WRN_IdentifierOrNumericLiteralExpected:
                    case ErrorCode.WRN_ReferencedAssemblyDoesNotHaveStrongName:
                    case ErrorCode.WRN_AlignmentMagnitude:
                    case ErrorCode.WRN_AttributeIgnoredWhenPublicSigning:
                    case ErrorCode.WRN_TupleLiteralNameMismatch:
                    case ErrorCode.WRN_Experimental:
                    case ErrorCode.WRN_AttributesOnBackingFieldsNotAvailable:
                    case ErrorCode.WRN_TupleBinopLiteralNameMismatch:
                    case ErrorCode.WRN_TypeParameterSameAsOuterMethodTypeParameter:
                    case ErrorCode.WRN_ConvertingNullableToNonNullable:
                    case ErrorCode.WRN_NullReferenceAssignment:
                    case ErrorCode.WRN_NullReferenceReceiver:
                    case ErrorCode.WRN_NullReferenceReturn:
                    case ErrorCode.WRN_NullReferenceArgument:
                    case ErrorCode.WRN_NullabilityMismatchInTypeOnOverride:
                    case ErrorCode.WRN_NullabilityMismatchInReturnTypeOnOverride:
                    case ErrorCode.WRN_NullabilityMismatchInReturnTypeOnPartial:
                    case ErrorCode.WRN_NullabilityMismatchInParameterTypeOnOverride:
                    case ErrorCode.WRN_NullabilityMismatchInParameterTypeOnPartial:
                    case ErrorCode.WRN_NullabilityMismatchInConstraintsOnPartialImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInTypeOnImplicitImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInReturnTypeOnImplicitImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInParameterTypeOnImplicitImplementation:
                    case ErrorCode.WRN_DuplicateInterfaceWithNullabilityMismatchInBaseList:
                    case ErrorCode.WRN_NullabilityMismatchInInterfaceImplementedByBase:
                    case ErrorCode.WRN_NullabilityMismatchInExplicitlyImplementedInterface:
                    case ErrorCode.WRN_NullabilityMismatchInTypeOnExplicitImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInReturnTypeOnExplicitImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInParameterTypeOnExplicitImplementation:
                    case ErrorCode.WRN_UninitializedNonNullableField:
                    case ErrorCode.WRN_NullabilityMismatchInAssignment:
                    case ErrorCode.WRN_NullabilityMismatchInArgument:
                    case ErrorCode.WRN_NullabilityMismatchInArgumentForOutput:
                    case ErrorCode.WRN_NullabilityMismatchInReturnTypeOfTargetDelegate:
                    case ErrorCode.WRN_NullabilityMismatchInParameterTypeOfTargetDelegate:
                    case ErrorCode.WRN_NullAsNonNullable:
                    case ErrorCode.WRN_NullableValueTypeMayBeNull:
                    case ErrorCode.WRN_NullabilityMismatchInTypeParameterConstraint:
                    case ErrorCode.WRN_MissingNonNullTypesContextForAnnotation:
                    case ErrorCode.WRN_MissingNonNullTypesContextForAnnotationInGeneratedCode:
                    case ErrorCode.WRN_NullabilityMismatchInConstraintsOnImplicitImplementation:
                    case ErrorCode.WRN_NullabilityMismatchInTypeParameterReferenceTypeConstraint:
                    case ErrorCode.WRN_SwitchExpressionNotExhaustive:
                    case ErrorCode.WRN_IsTypeNamedUnderscore:
                    case ErrorCode.WRN_GivenExpressionNeverMatchesPattern:
                    case ErrorCode.WRN_GivenExpressionAlwaysMatchesConstant:
                    case ErrorCode.WRN_SwitchExpressionNotExhaustiveWithUnnamedEnumValue:
                    case ErrorCode.WRN_CaseConstantNamedUnderscore:
                    case ErrorCode.WRN_ThrowPossibleNull:
                    case ErrorCode.WRN_UnboxPossibleNull:
                    case ErrorCode.WRN_SwitchExpressionNotExhaustiveForNull:
                    case ErrorCode.WRN_ImplicitCopyInReadOnlyMember:
                    case ErrorCode.WRN_UnconsumedEnumeratorCancellationAttributeUsage:
                    case ErrorCode.WRN_UndecoratedCancellationTokenParameter:
                    case ErrorCode.WRN_NullabilityMismatchInTypeParameterNotNullConstraint:
                    case ErrorCode.WRN_DisallowNullAttributeForbidsMaybeNullAssignment:
                    case ErrorCode.WRN_ParameterConditionallyDisallowsNull:
                    case ErrorCode.WRN_NullReferenceInitializer:
                    case ErrorCode.WRN_ShouldNotReturn:
                    case ErrorCode.WRN_DoesNotReturnMismatch:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnOverride:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnOverride:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnImplicitImplementation:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnImplicitImplementation:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInReturnTypeOnExplicitImplementation:
                    case ErrorCode.WRN_TopLevelNullabilityMismatchInParameterTypeOnExplicitImplementation:
                    case ErrorCode.WRN_ConstOutOfRangeChecked:
                    case ErrorCode.WRN_MemberNotNull:
                    case ErrorCode.WRN_MemberNotNullBadMember:
                    case ErrorCode.WRN_MemberNotNullWhen:
                    case ErrorCode.WRN_GeneratorFailedDuringInitialization:
                    case ErrorCode.WRN_GeneratorFailedDuringGeneration:
                    case ErrorCode.WRN_ParameterDisallowsNull:
                    case ErrorCode.WRN_GivenExpressionAlwaysMatchesPattern:
                    case ErrorCode.WRN_IsPatternAlways:
                    case ErrorCode.WRN_SwitchExpressionNotExhaustiveWithWhen:
                    case ErrorCode.WRN_SwitchExpressionNotExhaustiveForNullWithWhen:
                    case ErrorCode.WRN_RecordNamedDisallowed:
                    case ErrorCode.WRN_ParameterNotNullIfNotNull:
                    case ErrorCode.WRN_ReturnNotNullIfNotNull:
                    case ErrorCode.WRN_AnalyzerReferencesFramework:
                    case ErrorCode.WRN_UnreadRecordParameter:
                    case ErrorCode.WRN_DoNotCompareFunctionPointers:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 27611, 27620);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 10585, 27692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 27668, 27677);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 10585, 27692);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 10253, 27823);

                bool
                f_10610_10333_10345(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 10333, 10345);
                    return return_v;
                }


                bool
                f_10610_10349_10363(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsHidden(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 10349, 10363);
                    return return_v;
                }

                // Note: when adding a warning here, consider whether it should be registered as a nullability warning too
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 10253, 27823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 10253, 27823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool PreventsSuccessfulDelegateConversion(ErrorCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 28494, 29463);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 28592, 28709) || true) && (code == ErrorCode.Void || (DynAbs.Tracing.TraceSender.Expression_False(10610, 28596, 28647) || code == ErrorCode.Unknown))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 28592, 28709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 28681, 28694);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 28592, 28709);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 28725, 28806) || true) && (f_10610_28729_28744(code))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 28725, 28806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 28778, 28791);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 28725, 28806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 28822, 29452);

                switch (code)
                {

                    case ErrorCode.ERR_DuplicateParamName:
                    case ErrorCode.ERR_LocalDuplicate:
                    case ErrorCode.ERR_LocalIllegallyOverrides:
                    case ErrorCode.ERR_LocalSameNameAsTypeParam:
                    case ErrorCode.ERR_QueryRangeVariableOverrides:
                    case ErrorCode.ERR_QueryRangeVariableSameAsTypeParam:
                    case ErrorCode.ERR_DeprecatedCollectionInitAddStr:
                    case ErrorCode.ERR_DeprecatedSymbolStr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 28822, 29452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 29364, 29377);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 28822, 29452);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 28822, 29452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 29425, 29437);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 28822, 29452);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 28494, 29463);

                bool
                f_10610_28729_28744(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = IsWarning(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 28729, 28744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 28494, 29463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 28494, 29463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool PreventsSuccessfulDelegateConversion(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 29685, 30137);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 29794, 30097);
                    foreach (Diagnostic diag in f_10610_29822_29848_I(f_10610_29822_29848(diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 29794, 30097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 29936, 30082) || true) && (f_10610_29940_30009(f_10610_29999_30008(diag)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 29936, 30082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30051, 30063);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 29936, 30082);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 29794, 30097);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10610, 1, 304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10610, 1, 304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30113, 30126);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 29685, 30137);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10610_29822_29848(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 29822, 29848);
                    return return_v;
                }


                int
                f_10610_29999_30008(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 29999, 30008);
                    return return_v;
                }


                bool
                f_10610_29940_30009(int
                code)
                {
                    var return_v = ErrorFacts.PreventsSuccessfulDelegateConversion((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 29940, 30009);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_10610_29822_29848_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 29822, 29848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 29685, 30137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 29685, 30137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool PreventsSuccessfulDelegateConversion(ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10610, 30149, 30538);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30271, 30498);
                    foreach (var diag in f_10610_30292_30303_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 30271, 30498);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30337, 30483) || true) && (f_10610_30341_30410(f_10610_30400_30409(diag)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10610, 30337, 30483);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30452, 30464);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 30337, 30483);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10610, 30271, 30498);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10610, 1, 228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10610, 1, 228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30514, 30527);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10610, 30149, 30538);

                int
                f_10610_30400_30409(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10610, 30400, 30409);
                    return return_v;
                }


                bool
                f_10610_30341_30410(int
                code)
                {
                    var return_v = ErrorFacts.PreventsSuccessfulDelegateConversion((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 30341, 30410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10610_30292_30303_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 30292, 30303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 30149, 30538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 30149, 30538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorCode GetStaticClassParameterCode(bool useWarning)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10610, 30634, 30725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30637, 30725);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10610, 30637, 30647) || ((useWarning && DynAbs.Tracing.TraceSender.Conditional_F2(10610, 30650, 30686)) || DynAbs.Tracing.TraceSender.Conditional_F3(10610, 30689, 30725))) ? ErrorCode.WRN_ParameterIsStaticClass : ErrorCode.ERR_ParameterIsStaticClass; DynAbs.Tracing.TraceSender.TraceExitMethod(10610, 30634, 30725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 30634, 30725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 30634, 30725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorCode GetStaticClassReturnCode(bool useWarning)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10610, 30819, 30912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10610, 30822, 30912);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10610, 30822, 30832) || ((useWarning && DynAbs.Tracing.TraceSender.Conditional_F2(10610, 30835, 30872)) || DynAbs.Tracing.TraceSender.Conditional_F3(10610, 30875, 30912))) ? ErrorCode.WRN_ReturnTypeIsStaticClass : ErrorCode.ERR_ReturnTypeIsStaticClass; DynAbs.Tracing.TraceSender.TraceExitMethod(10610, 30819, 30912);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10610, 30819, 30912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10610, 30819, 30912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static System.Lazy<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>>
        f_10610_716_785(System.Func<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.ErrorCode, string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 716, 785);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>.Builder
        f_10610_969_1009()
        {
            var return_v = ImmutableHashSet.CreateBuilder<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 969, 1009);
            return return_v;
        }


        static string
        f_10610_1047_1091(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1047, 1091);
            return return_v;
        }


        static bool
        f_10610_1026_1092(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1026, 1092);
            return return_v;
        }


        static string
        f_10610_1128_1170(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1128, 1170);
            return return_v;
        }


        static bool
        f_10610_1107_1171(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1107, 1171);
            return return_v;
        }


        static string
        f_10610_1207_1247(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1207, 1247);
            return return_v;
        }


        static bool
        f_10610_1186_1248(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1186, 1248);
            return return_v;
        }


        static string
        f_10610_1284_1326(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1284, 1326);
            return return_v;
        }


        static bool
        f_10610_1263_1327(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1263, 1327);
            return return_v;
        }


        static string
        f_10610_1363_1413(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1363, 1413);
            return return_v;
        }


        static bool
        f_10610_1342_1414(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1342, 1414);
            return return_v;
        }


        static string
        f_10610_1450_1502(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1450, 1502);
            return return_v;
        }


        static bool
        f_10610_1429_1503(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1429, 1503);
            return return_v;
        }


        static string
        f_10610_1539_1589(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1539, 1589);
            return return_v;
        }


        static bool
        f_10610_1518_1590(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1518, 1590);
            return return_v;
        }


        static string
        f_10610_1626_1685(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1626, 1685);
            return return_v;
        }


        static bool
        f_10610_1605_1686(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1605, 1686);
            return return_v;
        }


        static string
        f_10610_1722_1790(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1722, 1790);
            return return_v;
        }


        static bool
        f_10610_1701_1791(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1701, 1791);
            return return_v;
        }


        static string
        f_10610_1827_1898(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1827, 1898);
            return return_v;
        }


        static bool
        f_10610_1806_1899(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1806, 1899);
            return return_v;
        }


        static string
        f_10610_1935_1973(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1935, 1973);
            return return_v;
        }


        static bool
        f_10610_1914_1974(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1914, 1974);
            return return_v;
        }


        static string
        f_10610_2010_2057(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2010, 2057);
            return return_v;
        }


        static bool
        f_10610_1989_2058(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 1989, 2058);
            return return_v;
        }


        static string
        f_10610_2094_2159(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2094, 2159);
            return return_v;
        }


        static bool
        f_10610_2073_2160(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2073, 2160);
            return return_v;
        }


        static string
        f_10610_2196_2274(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2196, 2274);
            return return_v;
        }


        static bool
        f_10610_2175_2275(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2175, 2275);
            return return_v;
        }


        static string
        f_10610_2311_2383(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2311, 2383);
            return return_v;
        }


        static bool
        f_10610_2290_2384(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2290, 2384);
            return return_v;
        }


        static string
        f_10610_2420_2458(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2420, 2458);
            return return_v;
        }


        static bool
        f_10610_2399_2459(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2399, 2459);
            return return_v;
        }


        static string
        f_10610_2495_2533(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2495, 2533);
            return return_v;
        }


        static bool
        f_10610_2474_2534(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2474, 2534);
            return return_v;
        }


        static string
        f_10610_2570_2627(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2570, 2627);
            return return_v;
        }


        static bool
        f_10610_2549_2628(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2549, 2628);
            return return_v;
        }


        static string
        f_10610_2664_2729(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2664, 2729);
            return return_v;
        }


        static bool
        f_10610_2643_2730(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2643, 2730);
            return return_v;
        }


        static string
        f_10610_2768_2820(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2768, 2820);
            return return_v;
        }


        static bool
        f_10610_2747_2821(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2747, 2821);
            return return_v;
        }


        static string
        f_10610_2857_2925(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2857, 2925);
            return return_v;
        }


        static bool
        f_10610_2836_2926(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2836, 2926);
            return return_v;
        }


        static string
        f_10610_2962_3018(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2962, 3018);
            return return_v;
        }


        static bool
        f_10610_2941_3019(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 2941, 3019);
            return return_v;
        }


        static string
        f_10610_3055_3091(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3055, 3091);
            return return_v;
        }


        static bool
        f_10610_3034_3092(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3034, 3092);
            return return_v;
        }


        static string
        f_10610_3130_3186(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3130, 3186);
            return return_v;
        }


        static bool
        f_10610_3109_3187(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3109, 3187);
            return return_v;
        }


        static string
        f_10610_3223_3285(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3223, 3285);
            return return_v;
        }


        static bool
        f_10610_3202_3286(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3202, 3286);
            return return_v;
        }


        static string
        f_10610_3322_3383(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3322, 3383);
            return return_v;
        }


        static bool
        f_10610_3301_3384(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3301, 3384);
            return return_v;
        }


        static string
        f_10610_3420_3485(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3420, 3485);
            return return_v;
        }


        static bool
        f_10610_3399_3486(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3399, 3486);
            return return_v;
        }


        static string
        f_10610_3522_3586(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3522, 3586);
            return return_v;
        }


        static bool
        f_10610_3501_3587(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3501, 3587);
            return return_v;
        }


        static string
        f_10610_3623_3693(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3623, 3693);
            return return_v;
        }


        static bool
        f_10610_3602_3694(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3602, 3694);
            return return_v;
        }


        static string
        f_10610_3730_3806(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3730, 3806);
            return return_v;
        }


        static bool
        f_10610_3709_3807(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3709, 3807);
            return return_v;
        }


        static string
        f_10610_3843_3922(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3843, 3922);
            return return_v;
        }


        static bool
        f_10610_3822_3923(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3822, 3923);
            return return_v;
        }


        static string
        f_10610_3959_4029(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3959, 4029);
            return return_v;
        }


        static bool
        f_10610_3938_4030(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 3938, 4030);
            return return_v;
        }


        static string
        f_10610_4066_4142(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4066, 4142);
            return return_v;
        }


        static bool
        f_10610_4045_4143(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4045, 4143);
            return return_v;
        }


        static string
        f_10610_4179_4258(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4179, 4258);
            return return_v;
        }


        static bool
        f_10610_4158_4259(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4158, 4259);
            return return_v;
        }


        static string
        f_10610_4295_4372(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4295, 4372);
            return return_v;
        }


        static bool
        f_10610_4274_4373(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4274, 4373);
            return return_v;
        }


        static string
        f_10610_4409_4481(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4409, 4481);
            return return_v;
        }


        static bool
        f_10610_4388_4482(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4388, 4482);
            return return_v;
        }


        static string
        f_10610_4518_4586(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4518, 4586);
            return return_v;
        }


        static bool
        f_10610_4497_4587(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4497, 4587);
            return return_v;
        }


        static string
        f_10610_4623_4695(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4623, 4695);
            return return_v;
        }


        static bool
        f_10610_4602_4696(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4602, 4696);
            return return_v;
        }


        static string
        f_10610_4732_4808(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4732, 4808);
            return return_v;
        }


        static bool
        f_10610_4711_4809(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4711, 4809);
            return return_v;
        }


        static string
        f_10610_4845_4890(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4845, 4890);
            return return_v;
        }


        static bool
        f_10610_4824_4891(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4824, 4891);
            return return_v;
        }


        static string
        f_10610_4927_4963(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4927, 4963);
            return return_v;
        }


        static bool
        f_10610_4906_4964(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4906, 4964);
            return return_v;
        }


        static string
        f_10610_5000_5042(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5000, 5042);
            return return_v;
        }


        static bool
        f_10610_4979_5043(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 4979, 5043);
            return return_v;
        }


        static string
        f_10610_5079_5166(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5079, 5166);
            return return_v;
        }


        static bool
        f_10610_5058_5167(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5058, 5167);
            return return_v;
        }


        static string
        f_10610_5203_5290(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5203, 5290);
            return return_v;
        }


        static bool
        f_10610_5182_5291(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5182, 5291);
            return return_v;
        }


        static string
        f_10610_5327_5400(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5327, 5400);
            return return_v;
        }


        static bool
        f_10610_5306_5401(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5306, 5401);
            return return_v;
        }


        static string
        f_10610_5437_5521(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5437, 5521);
            return return_v;
        }


        static bool
        f_10610_5416_5522(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5416, 5522);
            return return_v;
        }


        static string
        f_10610_5558_5642(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5558, 5642);
            return return_v;
        }


        static bool
        f_10610_5537_5643(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5537, 5643);
            return return_v;
        }


        static string
        f_10610_5679_5749(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5679, 5749);
            return return_v;
        }


        static bool
        f_10610_5658_5750(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5658, 5750);
            return return_v;
        }


        static string
        f_10610_5786_5820(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5786, 5820);
            return return_v;
        }


        static bool
        f_10610_5765_5821(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5765, 5821);
            return return_v;
        }


        static string
        f_10610_5857_5900(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5857, 5900);
            return return_v;
        }


        static bool
        f_10610_5836_5901(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5836, 5901);
            return return_v;
        }


        static string
        f_10610_5937_5975(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5937, 5975);
            return return_v;
        }


        static bool
        f_10610_5916_5976(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5916, 5976);
            return return_v;
        }


        static string
        f_10610_6012_6055(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6012, 6055);
            return return_v;
        }


        static bool
        f_10610_5991_6056(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 5991, 6056);
            return return_v;
        }


        static string
        f_10610_6092_6138(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6092, 6138);
            return return_v;
        }


        static bool
        f_10610_6071_6139(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6071, 6139);
            return return_v;
        }


        static string
        f_10610_6175_6218(Microsoft.CodeAnalysis.CSharp.ErrorCode
        errorCode)
        {
            var return_v = GetId(errorCode);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6175, 6218);
            return return_v;
        }


        static bool
        f_10610_6154_6219(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6154, 6219);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableHashSet<string>
        f_10610_6255_6285(System.Collections.Immutable.ImmutableHashSet<string>.Builder
        this_param)
        {
            var return_v = this_param.ToImmutable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10610, 6255, 6285);
            return return_v;
        }

    }
}
