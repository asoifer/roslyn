// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal enum EnumOverflowKind { NoOverflow, OverflowReport, OverflowIgnore }
    internal static class EnumConstantHelper
    {
        internal static EnumOverflowKind OffsetValue(ConstantValue constantValue, uint offset, out ConstantValue offsetValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(16, 775, 5418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 917, 952);

                f_16_917_951(f_16_930_950_M(!constantValue.IsBad));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 966, 991);

                f_16_966_990(offset > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1007, 1039);

                offsetValue = f_16_1021_1038();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1055, 1085);

                EnumOverflowKind
                overflowKind
                = default(EnumOverflowKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1099, 5371);

                switch (f_16_1107_1134(constantValue))
                {

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1259, 1300);

                            long
                            previous = f_16_1275_1299(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1326, 1389);

                            overflowKind = f_16_1341_1388(sbyte.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1415, 1610) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1415, 1610);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1520, 1583);

                                offsetValue = f_16_1534_1582((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1415, 1610);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 1655, 1661);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1769, 1810);

                            ulong
                            previous = f_16_1786_1809(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1836, 1898);

                            overflowKind = f_16_1851_1897(byte.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 1924, 2118) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1924, 2118);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2029, 2091);

                                offsetValue = f_16_2043_2090((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1924, 2118);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 2163, 2169);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2278, 2319);

                            long
                            previous = f_16_2294_2318(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2345, 2408);

                            overflowKind = f_16_2360_2407(short.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2434, 2629) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 2434, 2629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2539, 2602);

                                offsetValue = f_16_2553_2601((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 2434, 2629);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 2674, 2680);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2790, 2833);

                            ulong
                            previous = f_16_2807_2832(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2859, 2923);

                            overflowKind = f_16_2874_2922(ushort.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 2949, 3145) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 2949, 3145);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3054, 3118);

                                offsetValue = f_16_3068_3117((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 2949, 3145);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 3190, 3196);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3305, 3346);

                            long
                            previous = f_16_3321_3345(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3372, 3433);

                            overflowKind = f_16_3387_3432(int.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3459, 3652) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 3459, 3652);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3564, 3625);

                                offsetValue = f_16_3578_3624((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 3459, 3652);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 3697, 3703);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3813, 3856);

                            ulong
                            previous = f_16_3830_3855(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3882, 3944);

                            overflowKind = f_16_3897_3943(uint.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 3970, 4164) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 3970, 4164);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4075, 4137);

                                offsetValue = f_16_4089_4136((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 3970, 4164);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 4209, 4215);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4324, 4365);

                            long
                            previous = f_16_4340_4364(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4391, 4453);

                            overflowKind = f_16_4406_4452(long.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4479, 4673) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 4479, 4673);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4584, 4646);

                                offsetValue = f_16_4598_4645((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 4479, 4673);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 4718, 4724);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4834, 4877);

                            ulong
                            previous = f_16_4851_4876(constantValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4903, 4966);

                            overflowKind = f_16_4918_4965(ulong.MaxValue, previous, offset);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 4992, 5187) || true) && (overflowKind == EnumOverflowKind.NoOverflow)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 4992, 5187);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5097, 5160);

                                offsetValue = f_16_5111_5159((previous + offset));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(16, 4992, 5187);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(16, 5232, 5238);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(16, 1099, 5371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5286, 5356);

                        throw f_16_5292_5355(f_16_5327_5354(constantValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(16, 1099, 5371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5387, 5407);

                return overflowKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(16, 775, 5418);

                bool
                f_16_930_950_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 930, 950);
                    return return_v;
                }


                int
                f_16_917_951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 917, 951);
                    return 0;
                }


                int
                f_16_966_990(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 966, 990);
                    return 0;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_1021_1038()
                {
                    var return_v = ConstantValue.Bad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 1021, 1038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_16_1107_1134(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 1107, 1134);
                    return return_v;
                }


                sbyte
                f_16_1275_1299(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 1275, 1299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_1341_1388(sbyte
                maxOffset, long
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((long)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 1341, 1388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_1534_1582(long
                value)
                {
                    var return_v = ConstantValue.Create((sbyte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 1534, 1582);
                    return return_v;
                }


                byte
                f_16_1786_1809(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 1786, 1809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_1851_1897(byte
                maxOffset, ulong
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((ulong)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 1851, 1897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_2043_2090(ulong
                value)
                {
                    var return_v = ConstantValue.Create((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 2043, 2090);
                    return return_v;
                }


                short
                f_16_2294_2318(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 2294, 2318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_2360_2407(short
                maxOffset, long
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((long)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 2360, 2407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_2553_2601(long
                value)
                {
                    var return_v = ConstantValue.Create((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 2553, 2601);
                    return return_v;
                }


                ushort
                f_16_2807_2832(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 2807, 2832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_2874_2922(ushort
                maxOffset, ulong
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((ulong)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 2874, 2922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_3068_3117(ulong
                value)
                {
                    var return_v = ConstantValue.Create((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 3068, 3117);
                    return return_v;
                }


                int
                f_16_3321_3345(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 3321, 3345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_3387_3432(int
                maxOffset, long
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((long)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 3387, 3432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_3578_3624(long
                value)
                {
                    var return_v = ConstantValue.Create((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 3578, 3624);
                    return return_v;
                }


                uint
                f_16_3830_3855(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 3830, 3855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_3897_3943(uint
                maxOffset, ulong
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow((ulong)maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 3897, 3943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_4089_4136(ulong
                value)
                {
                    var return_v = ConstantValue.Create((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 4089, 4136);
                    return return_v;
                }


                long
                f_16_4340_4364(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 4340, 4364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_4406_4452(long
                maxOffset, long
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow(maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 4406, 4452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_4598_4645(long
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 4598, 4645);
                    return return_v;
                }


                ulong
                f_16_4851_4876(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 4851, 4876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_4918_4965(ulong
                maxOffset, ulong
                previous, uint
                offset)
                {
                    var return_v = CheckOverflow(maxOffset, previous, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 4918, 4965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_16_5111_5159(ulong
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5111, 5159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_16_5327_5354(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(16, 5327, 5354);
                    return return_v;
                }


                System.Exception
                f_16_5292_5355(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5292, 5355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(16, 775, 5418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(16, 775, 5418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EnumOverflowKind CheckOverflow(long maxOffset, long previous, uint offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(16, 5430, 5676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5544, 5580);

                f_16_5544_5579(maxOffset >= previous);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5594, 5665);

                return f_16_5601_5664(unchecked((maxOffset - previous)), offset);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(16, 5430, 5676);

                int
                f_16_5544_5579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5544, 5579);
                    return 0;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_5601_5664(long
                maxOffset, uint
                offset)
                {
                    var return_v = CheckOverflow((ulong)maxOffset, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5601, 5664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(16, 5430, 5676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(16, 5430, 5676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EnumOverflowKind CheckOverflow(ulong maxOffset, ulong previous, uint offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(16, 5688, 5916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5804, 5840);

                f_16_5804_5839(maxOffset >= previous);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 5854, 5905);

                return f_16_5861_5904(maxOffset - previous, offset);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(16, 5688, 5916);

                int
                f_16_5804_5839(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5804, 5839);
                    return 0;
                }


                Microsoft.CodeAnalysis.EnumOverflowKind
                f_16_5861_5904(ulong
                maxOffset, uint
                offset)
                {
                    var return_v = CheckOverflow(maxOffset, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(16, 5861, 5904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(16, 5688, 5916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(16, 5688, 5916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static EnumOverflowKind CheckOverflow(ulong maxOffset, uint offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(16, 5928, 6232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(16, 6028, 6221);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(16, 6035, 6056) || (((offset <= maxOffset) && DynAbs.Tracing.TraceSender.Conditional_F2(16, 6076, 6103)) || DynAbs.Tracing.TraceSender.Conditional_F3(16, 6123, 6220))) ? EnumOverflowKind.NoOverflow : ((DynAbs.Tracing.TraceSender.Conditional_F1(16, 6124, 6151) || ((((offset - 1) == maxOffset) && DynAbs.Tracing.TraceSender.Conditional_F2(16, 6154, 6185)) || DynAbs.Tracing.TraceSender.Conditional_F3(16, 6188, 6219))) ? EnumOverflowKind.OverflowReport : EnumOverflowKind.OverflowIgnore);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(16, 5928, 6232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(16, 5928, 6232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(16, 5928, 6232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumConstantHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(16, 424, 6239);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(16, 424, 6239);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(16, 424, 6239);
        }

    }
}
