// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.CodeAnalysis
{
    internal static class RealParser
    {
        public static bool TryParseDouble(string s, out double d)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 1674, 2106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 1756, 1807);

                var
                str = DecimalFloatingPointString.FromSource(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 1821, 1864);

                var
                dbl = DoubleFloatingPointType.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 1878, 1891);

                ulong
                result
                = default(ulong);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 1905, 1985);

                var
                status = f_27_1918_1984(str, dbl, out result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 1999, 2048);

                d = f_27_2003_2047(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 2062, 2095);

                return status != Status.Overflow;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 1674, 2106);

                Microsoft.CodeAnalysis.RealParser.Status
                f_27_1918_1984(Microsoft.CodeAnalysis.RealParser.DecimalFloatingPointString
                data, Microsoft.CodeAnalysis.RealParser.DoubleFloatingPointType
                type, out ulong
                result)
                {
                    var return_v = RealParser.ConvertDecimalToFloatingPointBits(data, (Microsoft.CodeAnalysis.RealParser.FloatingPointType)type, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 1918, 1984);
                    return return_v;
                }


                double
                f_27_2003_2047(ulong
                value)
                {
                    var return_v = BitConverter.Int64BitsToDouble((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 2003, 2047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 1674, 2106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 1674, 2106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParseFloat(string s, out float f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 2703, 3118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 2783, 2834);

                var
                str = DecimalFloatingPointString.FromSource(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 2848, 2890);

                var
                dbl = FloatFloatingPointType.Instance
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 2904, 2917);

                ulong
                result
                = default(ulong);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 2931, 3011);

                var
                status = f_27_2944_3010(str, dbl, out result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3025, 3060);

                f = f_27_3029_3059(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3074, 3107);

                return status != Status.Overflow;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 2703, 3118);

                Microsoft.CodeAnalysis.RealParser.Status
                f_27_2944_3010(Microsoft.CodeAnalysis.RealParser.DecimalFloatingPointString
                data, Microsoft.CodeAnalysis.RealParser.FloatFloatingPointType
                type, out ulong
                result)
                {
                    var return_v = RealParser.ConvertDecimalToFloatingPointBits(data, (Microsoft.CodeAnalysis.RealParser.FloatingPointType)type, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 2944, 3010);
                    return return_v;
                }


                float
                f_27_3029_3059(ulong
                i)
                {
                    var return_v = Int32BitsToFloat((uint)i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 3029, 3059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 2703, 3118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 2703, 3118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly BigInteger s_bigZero;

        private static readonly BigInteger s_bigOne;

        private static readonly BigInteger s_bigTwo;

        private static readonly BigInteger s_bigTen;
        private abstract class FloatingPointType
        {
            public abstract ushort DenormalMantissaBits { get; }

            public ushort NormalMantissaBits
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 3702, 3739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3705, 3739);
                        return (ushort)(f_27_3714_3734() + 1); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 3702, 3739);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 3702, 3739);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 3702, 3739);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public abstract ushort ExponentBits { get; }

            public int MinBinaryExponent
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 3894, 3918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3897, 3918);
                        return 1 - f_27_3901_3918(); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 3894, 3918);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 3894, 3918);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 3894, 3918);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public abstract int MaxBinaryExponent { get; }

            public int OverflowDecimalExponent
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 4028, 4079);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 4031, 4079);
                        return (f_27_4032_4049() + 2 * f_27_4056_4074()) / 3; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 4028, 4079);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 4028, 4079);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 4028, 4079);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public abstract int ExponentBias { get; }

            public ulong DenormalMantissaMask
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 4183, 4221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 4186, 4221);
                        return (1UL << (f_27_4195_4215())) - 1; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 4183, 4221);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 4183, 4221);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 4183, 4221);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ulong NormalMantissaMask
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 4268, 4302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 4271, 4302);
                        return (1UL << f_27_4279_4297()) - 1; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 4268, 4302);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 4268, 4302);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 4268, 4302);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public abstract ulong Zero { get; }

            public abstract ulong Infinity { get; }

            public Status AssembleFloatingPointValue(
                            ulong initialMantissa,
                            int initialExponent,
                            bool hasZeroTail,
                            out ulong result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 6321, 13655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 6773, 6838);

                    uint
                    initialMantissaBits = f_27_6800_6837(initialMantissa)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 6856, 6933);

                    int
                    normalMantissaShift = f_27_6882_6905(this) - (int)initialMantissaBits
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 6951, 7010);

                    int
                    normalExponent = initialExponent - normalMantissaShift
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7030, 7063);

                    ulong
                    mantissa = initialMantissa
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7081, 7111);

                    int
                    exponent = normalExponent
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7131, 12847) || true) && (normalExponent > f_27_7152_7174(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 7131, 12847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7369, 7392);

                        result = f_27_7378_7391(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7414, 7437);

                        return Status.Overflow;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 7131, 12847);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 7131, 12847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 7479, 12847) || true) && (normalExponent < f_27_7500_7522(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 7479, 12847);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 8104, 8293);

                            int
                            denormalMantissaShift =
                                                    normalMantissaShift +
                                                    normalExponent +
                            f_27_8246_8263(this) -
                                                    1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 8474, 8504);

                            exponent = f_27_8485_8503_M(-this.ExponentBias);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 8528, 11258) || true) && (denormalMantissaShift < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 8528, 11258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 8846, 8927);

                                mantissa = f_27_8857_8926(mantissa, -denormalMantissaShift, hasZeroTail);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 9035, 9210) || true) && (mantissa == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 9035, 9210);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 9110, 9129);

                                    result = f_27_9119_9128(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 9159, 9183);

                                    return Status.Underflow;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 9035, 9210);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 10520, 11102) || true) && (mantissa > f_27_10535_10560(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 10520, 11102);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 10897, 11075);

                                    exponent =
                                                                    initialExponent -
                                                                    (denormalMantissaShift + 1) -
                                                                    normalMantissaShift;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 10520, 11102);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 8528, 11258);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 8528, 11258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 11200, 11235);

                                mantissa <<= denormalMantissaShift;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 8528, 11258);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 7479, 12847);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 7479, 12847);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 11340, 12828) || true) && (normalMantissaShift < 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 11340, 12828);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 11656, 11735);

                                mantissa = f_27_11667_11734(mantissa, -normalMantissaShift, hasZeroTail);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12030, 12645) || true) && (mantissa > f_27_12045_12068(this))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 12030, 12645);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12126, 12141);

                                    mantissa >>= 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12171, 12182);

                                    ++exponent;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12404, 12618) || true) && (exponent > f_27_12419_12441(this))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 12404, 12618);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12507, 12530);

                                        result = f_27_12516_12529(this);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12564, 12587);

                                        return Status.Overflow;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 12404, 12618);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 12030, 12645);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 11340, 12828);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 11340, 12828);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12695, 12828) || true) && (normalMantissaShift > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 12695, 12828);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 12772, 12805);

                                    mantissa <<= normalMantissaShift;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 12695, 12828);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 11340, 12828);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 7479, 12847);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 7131, 12847);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13016, 13054);

                    mantissa &= f_27_13028_13053(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13074, 13148);

                    f_27_13074_13147((f_27_13088_13108() & (1UL << f_27_13119_13139())) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13166, 13254);

                    ulong
                    shiftedExponent = ((ulong)(exponent + f_27_13210_13227(this))) << f_27_13233_13253()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13272, 13332);

                    f_27_13272_13331((shiftedExponent & f_27_13304_13324()) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13350, 13404);

                    f_27_13350_13403((mantissa & f_27_13375_13396_M(~DenormalMantissaMask)) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13422, 13521);

                    f_27_13422_13520((shiftedExponent & ~(((1UL << f_27_13465_13482(this)) - 1) << f_27_13492_13512())) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13569, 13605);

                    result = shiftedExponent | mantissa;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13623, 13640);

                    return Status.OK;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(27, 6321, 13655);

                    uint
                    f_27_6800_6837(ulong
                    data)
                    {
                        var return_v = CountSignificantBits(data);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 6800, 6837);
                        return return_v;
                    }


                    ushort
                    f_27_6882_6905(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.NormalMantissaBits;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 6882, 6905);
                        return return_v;
                    }


                    int
                    f_27_7152_7174(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.MaxBinaryExponent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 7152, 7174);
                        return return_v;
                    }


                    ulong
                    f_27_7378_7391(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.Infinity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 7378, 7391);
                        return return_v;
                    }


                    int
                    f_27_7500_7522(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.MinBinaryExponent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 7500, 7522);
                        return return_v;
                    }


                    int
                    f_27_8246_8263(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.ExponentBias;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 8246, 8263);
                        return return_v;
                    }


                    int
                    f_27_8485_8503_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 8485, 8503);
                        return return_v;
                    }


                    ulong
                    f_27_8857_8926(ulong
                    value, int
                    shift, bool
                    hasZeroTail)
                    {
                        var return_v = RightShiftWithRounding(value, shift, hasZeroTail);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 8857, 8926);
                        return return_v;
                    }


                    ulong
                    f_27_9119_9128(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.Zero;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 9119, 9128);
                        return return_v;
                    }


                    ulong
                    f_27_10535_10560(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.DenormalMantissaMask;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 10535, 10560);
                        return return_v;
                    }


                    ulong
                    f_27_11667_11734(ulong
                    value, int
                    shift, bool
                    hasZeroTail)
                    {
                        var return_v = RightShiftWithRounding(value, shift, hasZeroTail);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 11667, 11734);
                        return return_v;
                    }


                    ulong
                    f_27_12045_12068(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.NormalMantissaMask;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 12045, 12068);
                        return return_v;
                    }


                    int
                    f_27_12419_12441(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.MaxBinaryExponent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 12419, 12441);
                        return return_v;
                    }


                    ulong
                    f_27_12516_12529(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.Infinity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 12516, 12529);
                        return return_v;
                    }


                    ulong
                    f_27_13028_13053(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.DenormalMantissaMask;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13028, 13053);
                        return return_v;
                    }


                    ulong
                    f_27_13088_13108()
                    {
                        var return_v = DenormalMantissaMask;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13088, 13108);
                        return return_v;
                    }


                    ushort
                    f_27_13119_13139()
                    {
                        var return_v = DenormalMantissaBits;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13119, 13139);
                        return return_v;
                    }


                    int
                    f_27_13074_13147(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 13074, 13147);
                        return 0;
                    }


                    int
                    f_27_13210_13227(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.ExponentBias;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13210, 13227);
                        return return_v;
                    }


                    ushort
                    f_27_13233_13253()
                    {
                        var return_v = DenormalMantissaBits;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13233, 13253);
                        return return_v;
                    }


                    ulong
                    f_27_13304_13324()
                    {
                        var return_v = DenormalMantissaMask;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13304, 13324);
                        return return_v;
                    }


                    int
                    f_27_13272_13331(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 13272, 13331);
                        return 0;
                    }


                    ulong
                    f_27_13375_13396_M(ulong
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13375, 13396);
                        return return_v;
                    }


                    int
                    f_27_13350_13403(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 13350, 13403);
                        return 0;
                    }


                    ushort
                    f_27_13465_13482(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                    this_param)
                    {
                        var return_v = this_param.ExponentBits;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13465, 13482);
                        return return_v;
                    }


                    ushort
                    f_27_13492_13512()
                    {
                        var return_v = DenormalMantissaBits;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 13492, 13512);
                        return return_v;
                    }


                    int
                    f_27_13422_13520(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 13422, 13520);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 6321, 13655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 6321, 13655);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public FloatingPointType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(27, 3538, 13666);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(27, 3538, 13666);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 3538, 13666);
            }


            static FloatingPointType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 3538, 13666);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 3538, 13666);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 3538, 13666);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(27, 3538, 13666);

            ushort
            f_27_3714_3734()
            {
                var return_v = DenormalMantissaBits;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 3714, 3734);
                return return_v;
            }


            int
            f_27_3901_3918()
            {
                var return_v = MaxBinaryExponent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 3901, 3918);
                return return_v;
            }


            int
            f_27_4032_4049()
            {
                var return_v = MaxBinaryExponent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 4032, 4049);
                return return_v;
            }


            ushort
            f_27_4056_4074()
            {
                var return_v = NormalMantissaBits;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 4056, 4074);
                return return_v;
            }


            ushort
            f_27_4195_4215()
            {
                var return_v = DenormalMantissaBits;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 4195, 4215);
                return return_v;
            }


            ushort
            f_27_4279_4297()
            {
                var return_v = NormalMantissaBits;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 4279, 4297);
                return return_v;
            }

        }
        private sealed class FloatFloatingPointType : FloatingPointType
        {
            public static FloatFloatingPointType Instance;

            private FloatFloatingPointType()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(27, 13943, 13979);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(27, 13943, 13979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 13943, 13979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 13943, 13979);
                }
            }

            public override ushort DenormalMantissaBits
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14037, 14042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14040, 14042);
                        return 23; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14037, 14042);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14037, 14042);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14037, 14042);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ushort ExponentBits
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14093, 14097);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14096, 14097);
                        return 8; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14093, 14097);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14093, 14097);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14093, 14097);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int MaxBinaryExponent
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14150, 14156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14153, 14156);
                        return 127; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14150, 14156);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14150, 14156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14150, 14156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int ExponentBias
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14204, 14210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14207, 14210);
                        return 127; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14204, 14210);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14204, 14210);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14204, 14210);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ulong Zero
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14252, 14277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14255, 14277);
                        return f_27_14255_14277(0.0f); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14252, 14277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14252, 14277);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14252, 14277);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ulong Infinity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14323, 14366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14326, 14366);
                        return f_27_14326_14366(float.PositiveInfinity); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14323, 14366);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14323, 14366);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14323, 14366);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static FloatFloatingPointType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 13764, 14378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 13889, 13928);
                Instance = f_27_13900_13928(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 13764, 14378);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 13764, 14378);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(27, 13764, 14378);

            static Microsoft.CodeAnalysis.RealParser.FloatFloatingPointType
            f_27_13900_13928()
            {
                var return_v = new Microsoft.CodeAnalysis.RealParser.FloatFloatingPointType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 13900, 13928);
                return return_v;
            }


            uint
            f_27_14255_14277(float
            f)
            {
                var return_v = FloatToInt32Bits(f);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 14255, 14277);
                return return_v;
            }


            uint
            f_27_14326_14366(float
            f)
            {
                var return_v = FloatToInt32Bits(f);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 14326, 14366);
                return return_v;
            }

        }
        private sealed class DoubleFloatingPointType : FloatingPointType
        {
            public static DoubleFloatingPointType Instance;

            private DoubleFloatingPointType()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(27, 14659, 14696);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(27, 14659, 14696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14659, 14696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14659, 14696);
                }
            }

            public override ushort DenormalMantissaBits
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14754, 14759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14757, 14759);
                        return 52; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14754, 14759);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14754, 14759);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14754, 14759);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ushort ExponentBits
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14810, 14815);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14813, 14815);
                        return 11; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14810, 14815);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14810, 14815);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14810, 14815);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int MaxBinaryExponent
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14868, 14875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14871, 14875);
                        return 1023; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14868, 14875);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14868, 14875);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14868, 14875);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int ExponentBias
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14923, 14930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14926, 14930);
                        return 1023; DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14923, 14930);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14923, 14930);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14923, 14930);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ulong Zero
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 14972, 15018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14975, 15018);
                        return (ulong)f_27_14982_15018(0.0d); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 14972, 15018);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 14972, 15018);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14972, 15018);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ulong Infinity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 15064, 15129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 15067, 15129);
                        return (ulong)f_27_15074_15129(double.PositiveInfinity); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 15064, 15129);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 15064, 15129);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 15064, 15129);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static DoubleFloatingPointType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 14477, 15141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 14604, 14644);
                Instance = f_27_14615_14644(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 14477, 15141);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 14477, 15141);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(27, 14477, 15141);

            static Microsoft.CodeAnalysis.RealParser.DoubleFloatingPointType
            f_27_14615_14644()
            {
                var return_v = new Microsoft.CodeAnalysis.RealParser.DoubleFloatingPointType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 14615, 14644);
                return return_v;
            }


            long
            f_27_14982_15018(double
            value)
            {
                var return_v = BitConverter.DoubleToInt64Bits(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 14982, 15018);
                return return_v;
            }


            long
            f_27_15074_15129(double
            value)
            {
                var return_v = BitConverter.DoubleToInt64Bits(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 15074, 15129);
                return return_v;
            }

        }

        [DebuggerDisplay("0.{Mantissa}e{Exponent}")]
        private struct DecimalFloatingPointString
        {

            public int Exponent;

            public string Mantissa;

            public uint MantissaCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(27, 16108, 16132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16111, 16132);
                        return (uint)f_27_16117_16132(Mantissa); DynAbs.Tracing.TraceSender.TraceExitMethod(27, 16108, 16132);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 16108, 16132);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 16108, 16132);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public static DecimalFloatingPointString FromSource(string source)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 16395, 19615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16494, 16536);

                    var
                    mantissaBuilder = f_27_16516_16535()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16554, 16571);

                    var
                    exponent = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16589, 16599);

                    int
                    i = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16617, 16667) || true) && (i < f_27_16628_16641(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 16624, 16661) && f_27_16645_16654(source, i) == '0'))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 16617, 16667);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16663, 16667);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 16617, 16667);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 16617, 16667);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(27, 16617, 16667);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16685, 16709);

                    int
                    skippedDecimals = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16727, 17271) || true) && (i < f_27_16738_16751(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 16734, 16771) && f_27_16755_16764(source, i) >= '0') && (DynAbs.Tracing.TraceSender.Expression_True(27, 16734, 16791) && f_27_16775_16784(source, i) <= '9'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 16727, 17271);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16833, 17193) || true) && (f_27_16837_16846(source, i) == '0')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 16833, 17193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 16903, 16921);

                                skippedDecimals++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 16833, 17193);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 16833, 17193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17019, 17064);

                                f_27_17019_17063(mantissaBuilder, '0', skippedDecimals);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17090, 17110);

                                skippedDecimals = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17136, 17170);

                                f_27_17136_17169(mantissaBuilder, f_27_17159_17168(source, i));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 16833, 17193);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17215, 17226);

                            exponent++;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17248, 17252);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 16727, 17271);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 16727, 17271);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(27, 16727, 17271);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17289, 17980) || true) && (i < f_27_17297_17310(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 17293, 17330) && f_27_17314_17323(source, i) == '.'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 17289, 17980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17372, 17376);

                        i++;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17398, 17961) || true) && (i < f_27_17409_17422(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 17405, 17442) && f_27_17426_17435(source, i) >= '0') && (DynAbs.Tracing.TraceSender.Expression_True(27, 17405, 17462) && f_27_17446_17455(source, i) <= '9'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 17398, 17961);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17512, 17908) || true) && (f_27_17516_17525(source, i) == '0')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 17512, 17908);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17590, 17608);

                                    skippedDecimals++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 17512, 17908);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 17512, 17908);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17722, 17767);

                                    f_27_17722_17766(mantissaBuilder, '0', skippedDecimals);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17797, 17817);

                                    skippedDecimals = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17847, 17881);

                                    f_27_17847_17880(mantissaBuilder, f_27_17870_17879(source, i));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 17512, 17908);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17934, 17938);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 17398, 17961);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 17398, 17961);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(27, 17398, 17961);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 17289, 17980);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 17998, 18047);

                    var
                    result = default(DecimalFloatingPointString)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18065, 18110);

                    result.Mantissa = f_27_18083_18109(mantissaBuilder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18128, 19523) || true) && (i < f_27_18136_18149(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 18132, 18191) && (f_27_18154_18163(source, i) == 'e' || (DynAbs.Tracing.TraceSender.Expression_False(27, 18154, 18190) || f_27_18174_18183(source, i) == 'E'))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 18128, 19523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18233, 18263);

                        const int
                        MAX_EXP = (1 << 30)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18308, 18333);

                        char
                        exponentSign = '\0'
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18355, 18359);

                        i++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18381, 18572) || true) && (i < f_27_18389_18402(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 18385, 18444) && (f_27_18407_18416(source, i) == '-' || (DynAbs.Tracing.TraceSender.Expression_False(27, 18407, 18443) || f_27_18427_18436(source, i) == '+'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 18381, 18572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18494, 18519);

                            exponentSign = f_27_18509_18518(source, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18545, 18549);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 18381, 18572);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18594, 18616);

                        int
                        firstExponent = i
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18638, 18659);

                        int
                        lastExponent = i
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18681, 18766) || true) && (i < f_27_18692_18705(source) && (DynAbs.Tracing.TraceSender.Expression_True(27, 18688, 18725) && f_27_18709_18718(source, i) >= '0') && (DynAbs.Tracing.TraceSender.Expression_True(27, 18688, 18745) && f_27_18729_18738(source, i) <= '9'))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 18681, 18766);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18747, 18766);

                                lastExponent = ++i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 18681, 18766);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 18681, 18766);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(27, 18681, 18766);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18790, 18816);

                        int
                        exponentMagnitude = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 18840, 19504) || true) && (f_27_18844_18942(f_27_18857_18918(source, firstExponent, lastExponent - firstExponent), out exponentMagnitude) && (DynAbs.Tracing.TraceSender.Expression_True(27, 18844, 18999) && exponentMagnitude <= MAX_EXP))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 18840, 19504);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19049, 19331) || true) && (exponentSign == '-')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 19049, 19331);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19130, 19160);

                                exponent -= exponentMagnitude;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 19049, 19331);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 19049, 19331);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19274, 19304);

                                exponent += exponentMagnitude;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27, 19049, 19331);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 18840, 19504);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 18840, 19504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19429, 19481);

                            exponent = (DynAbs.Tracing.TraceSender.Conditional_F1(27, 19440, 19459) || ((exponentSign == '-' && DynAbs.Tracing.TraceSender.Conditional_F2(27, 19462, 19470)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 19473, 19480))) ? -MAX_EXP : MAX_EXP;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 18840, 19504);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 18128, 19523);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19541, 19568);

                    result.Exponent = exponent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 19586, 19600);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 16395, 19615);

                    System.Text.StringBuilder
                    f_27_16516_16535()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 16516, 16535);
                        return return_v;
                    }


                    int
                    f_27_16628_16641(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16628, 16641);
                        return return_v;
                    }


                    char
                    f_27_16645_16654(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16645, 16654);
                        return return_v;
                    }


                    int
                    f_27_16738_16751(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16738, 16751);
                        return return_v;
                    }


                    char
                    f_27_16755_16764(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16755, 16764);
                        return return_v;
                    }


                    char
                    f_27_16775_16784(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16775, 16784);
                        return return_v;
                    }


                    char
                    f_27_16837_16846(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16837, 16846);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_27_17019_17063(System.Text.StringBuilder
                    this_param, char
                    value, int
                    repeatCount)
                    {
                        var return_v = this_param.Append(value, repeatCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 17019, 17063);
                        return return_v;
                    }


                    char
                    f_27_17159_17168(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17159, 17168);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_27_17136_17169(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 17136, 17169);
                        return return_v;
                    }


                    int
                    f_27_17297_17310(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17297, 17310);
                        return return_v;
                    }


                    char
                    f_27_17314_17323(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17314, 17323);
                        return return_v;
                    }


                    int
                    f_27_17409_17422(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17409, 17422);
                        return return_v;
                    }


                    char
                    f_27_17426_17435(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17426, 17435);
                        return return_v;
                    }


                    char
                    f_27_17446_17455(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17446, 17455);
                        return return_v;
                    }


                    char
                    f_27_17516_17525(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17516, 17525);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_27_17722_17766(System.Text.StringBuilder
                    this_param, char
                    value, int
                    repeatCount)
                    {
                        var return_v = this_param.Append(value, repeatCount);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 17722, 17766);
                        return return_v;
                    }


                    char
                    f_27_17870_17879(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 17870, 17879);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_27_17847_17880(System.Text.StringBuilder
                    this_param, char
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 17847, 17880);
                        return return_v;
                    }


                    string
                    f_27_18083_18109(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 18083, 18109);
                        return return_v;
                    }


                    int
                    f_27_18136_18149(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18136, 18149);
                        return return_v;
                    }


                    char
                    f_27_18154_18163(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18154, 18163);
                        return return_v;
                    }


                    char
                    f_27_18174_18183(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18174, 18183);
                        return return_v;
                    }


                    int
                    f_27_18389_18402(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18389, 18402);
                        return return_v;
                    }


                    char
                    f_27_18407_18416(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18407, 18416);
                        return return_v;
                    }


                    char
                    f_27_18427_18436(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18427, 18436);
                        return return_v;
                    }


                    char
                    f_27_18509_18518(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18509, 18518);
                        return return_v;
                    }


                    int
                    f_27_18692_18705(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18692, 18705);
                        return return_v;
                    }


                    char
                    f_27_18709_18718(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18709, 18718);
                        return return_v;
                    }


                    char
                    f_27_18729_18738(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 18729, 18738);
                        return return_v;
                    }


                    string
                    f_27_18857_18918(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 18857, 18918);
                        return return_v;
                    }


                    bool
                    f_27_18844_18942(string
                    s, out int
                    result)
                    {
                        var return_v = int.TryParse(s, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 18844, 18942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 16395, 19615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 16395, 19615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static DecimalFloatingPointString()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 15891, 19626);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 15891, 19626);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 15891, 19626);
            }

            int
            f_27_16117_16132(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 16117, 16132);
                return return_v;
            }

        }

        private enum Status
        {
            OK,
            NoDigits,
            Underflow,
            Overflow
        }

        private static Status ConvertDecimalToFloatingPointBits(DecimalFloatingPointString data, FloatingPointType type, out ulong result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 19920, 30615);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 20075, 20213) || true) && (f_27_20079_20099(data.Mantissa) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 20075, 20213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 20138, 20157);

                    result = f_27_20147_20156(type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 20175, 20198);

                    return Status.NoDigits;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 20075, 20213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 20554, 20619);

                uint
                requiredBitsOfPrecision = (uint)f_27_20591_20614(type) + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21280, 21337);

                uint
                positiveExponent = (uint)f_27_21310_21336(0, data.Exponent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21351, 21426);

                uint
                integerDigitsPresent = f_27_21379_21425(positiveExponent, data.MantissaCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21440, 21508);

                uint
                integerDigitsMissing = positiveExponent - integerDigitsPresent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21522, 21549);

                uint
                integerFirstIndex = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21563, 21608);

                uint
                integerLastIndex = integerDigitsPresent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21624, 21669);

                uint
                fractionalFirstIndex = integerLastIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21683, 21729);

                uint
                fractionalLastIndex = data.MantissaCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21743, 21817);

                uint
                fractionalDigitsPresent = fractionalLastIndex - fractionalFirstIndex
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 21923, 22030);

                BigInteger
                integerValue = f_27_21949_22029(data, integerFirstIndex, integerLastIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22046, 22388) || true) && (integerDigitsMissing > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 22046, 22388);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22108, 22292) || true) && (integerDigitsMissing > f_27_22135_22163(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 22108, 22292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22205, 22228);

                        result = f_27_22214_22227(type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22250, 22273);

                        return Status.Overflow;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 22108, 22292);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22312, 22373);

                    f_27_22312_22372(ref integerValue, integerDigitsMissing);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 22046, 22388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22728, 22755);

                byte[]
                integerValueAsBytes
                = default(byte[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22769, 22859);

                uint
                integerBitsOfPrecision = f_27_22799_22858(integerValue, out integerValueAsBytes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 22873, 23267) || true) && (integerBitsOfPrecision >= requiredBitsOfPrecision || (DynAbs.Tracing.TraceSender.Expression_False(27, 22877, 22975) || fractionalDigitsPresent == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 22873, 23267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 23009, 23252);

                    return f_27_23016_23251(integerValueAsBytes, integerBitsOfPrecision, fractionalDigitsPresent != 0, type, out result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 22873, 23267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 23882, 24046);

                uint
                fractionalDenominatorExponent = (DynAbs.Tracing.TraceSender.Conditional_F1(27, 23919, 23936) || ((data.Exponent < 0
                && DynAbs.Tracing.TraceSender.Conditional_F2(27, 23956, 24002)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 24022, 24045))) ? fractionalDigitsPresent + (uint)-data.Exponent
                : fractionalDigitsPresent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24060, 24558) || true) && (integerBitsOfPrecision == 0 && (DynAbs.Tracing.TraceSender.Expression_True(27, 24064, 24183) && (fractionalDenominatorExponent - (int)data.MantissaCount) > f_27_24155_24183(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 24060, 24558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24482, 24501);

                    result = f_27_24491_24500(type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24519, 24543);

                    return Status.Underflow;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 24060, 24558);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24574, 24694);

                BigInteger
                fractionalNumerator = f_27_24607_24693(data, fractionalFirstIndex, fractionalLastIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24708, 24750);

                f_27_24708_24749(f_27_24721_24748_M(!fractionalNumerator.IsZero));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24766, 24810);

                BigInteger
                fractionalDenominator = s_bigOne
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 24824, 24903);

                f_27_24824_24902(ref fractionalDenominator, fractionalDenominatorExponent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25420, 25493);

                uint
                fractionalNumeratorBits = f_27_25451_25492(fractionalNumerator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25507, 25584);

                uint
                fractionalDenominatorBits = f_27_25540_25583(fractionalDenominator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25600, 25767);

                uint
                fractionalShift = (DynAbs.Tracing.TraceSender.Conditional_F1(27, 25623, 25674) || ((fractionalDenominatorBits > fractionalNumeratorBits
                && DynAbs.Tracing.TraceSender.Conditional_F2(27, 25694, 25745)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 25765, 25766))) ? fractionalDenominatorBits - fractionalNumeratorBits
                : 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25783, 25907) || true) && (fractionalShift > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 25783, 25907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25840, 25892);

                    f_27_25840_25891(ref fractionalNumerator, fractionalShift);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 25783, 25907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 25923, 26047);

                uint
                requiredFractionalBitsOfPrecision =
                                requiredBitsOfPrecision -
                                integerBitsOfPrecision
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 26063, 26137);

                uint
                remainingBitsOfPrecisionRequired = requiredFractionalBitsOfPrecision
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 26151, 27660) || true) && (integerBitsOfPrecision > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 26151, 27660);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 27195, 27573) || true) && (fractionalShift > remainingBitsOfPrecisionRequired)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 27195, 27573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 27291, 27554);

                        return f_27_27298_27553(integerValueAsBytes, integerBitsOfPrecision, fractionalDigitsPresent != 0, type, out result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 27195, 27573);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 27593, 27645);

                    remainingBitsOfPrecisionRequired -= fractionalShift;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 26151, 27660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28100, 28244);

                uint
                fractionalExponent = (DynAbs.Tracing.TraceSender.Conditional_F1(27, 28126, 28169) || ((fractionalNumerator < fractionalDenominator
                && DynAbs.Tracing.TraceSender.Conditional_F2(27, 28189, 28208)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 28228, 28243))) ? fractionalShift + 1
                : fractionalShift
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28260, 28329);

                f_27_28260_28328(ref fractionalNumerator, remainingBitsOfPrecisionRequired);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28343, 28374);

                BigInteger
                fractionalRemainder
                = default(BigInteger);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28388, 28510);

                BigInteger
                bigFractionalMantissa = BigInteger.DivRem(fractionalNumerator, fractionalDenominator, out fractionalRemainder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28524, 28580);

                ulong
                fractionalMantissa = (ulong)bigFractionalMantissa
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28596, 28642);

                bool
                hasZeroTail = fractionalRemainder.IsZero
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28795, 28866);

                uint
                fractionalMantissaBits = f_27_28825_28865(fractionalMantissa)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28880, 29212) || true) && (fractionalMantissaBits > requiredFractionalBitsOfPrecision)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 28880, 29212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 28976, 29054);

                    int
                    shift = (int)(fractionalMantissaBits - requiredFractionalBitsOfPrecision)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 29072, 29150);

                    hasZeroTail = hasZeroTail && (DynAbs.Tracing.TraceSender.Expression_True(27, 29086, 29149) && (fractionalMantissa & ((1UL << shift) - 1)) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 29168, 29197);

                    fractionalMantissa >>= shift;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 28880, 29212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 29306, 29348);

                f_27_29306_29347(integerBitsOfPrecision < 60);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 29409, 29453);

                ulong
                integerMantissa = (ulong)integerValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 29469, 29609);

                ulong
                completeMantissa =
                                (integerMantissa << (int)requiredFractionalBitsOfPrecision) +
                                fractionalMantissa
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 30343, 30491);

                int
                finalExponent = (DynAbs.Tracing.TraceSender.Conditional_F1(27, 30363, 30389) || ((integerBitsOfPrecision > 0
                && DynAbs.Tracing.TraceSender.Conditional_F2(27, 30409, 30440)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 30460, 30490))) ? (int)integerBitsOfPrecision - 2
                : -(int)(fractionalExponent) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 30507, 30604);

                return f_27_30514_30603(type, completeMantissa, finalExponent, hasZeroTail, out result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 19920, 30615);

                int
                f_27_20079_20099(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 20079, 20099);
                    return return_v;
                }


                ulong
                f_27_20147_20156(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.Zero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 20147, 20156);
                    return return_v;
                }


                ushort
                f_27_20591_20614(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.NormalMantissaBits;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 20591, 20614);
                    return return_v;
                }


                int
                f_27_21310_21336(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 21310, 21336);
                    return return_v;
                }


                uint
                f_27_21379_21425(uint
                val1, uint
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 21379, 21425);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_27_21949_22029(Microsoft.CodeAnalysis.RealParser.DecimalFloatingPointString
                data, uint
                integer_first_index, uint
                integer_last_index)
                {
                    var return_v = AccumulateDecimalDigitsIntoBigInteger(data, integer_first_index, integer_last_index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 21949, 22029);
                    return return_v;
                }


                int
                f_27_22135_22163(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.OverflowDecimalExponent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 22135, 22163);
                    return return_v;
                }


                ulong
                f_27_22214_22227(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.Infinity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 22214, 22227);
                    return return_v;
                }


                int
                f_27_22312_22372(ref System.Numerics.BigInteger
                number, uint
                power)
                {
                    MultiplyByPowerOfTen(ref number, power);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 22312, 22372);
                    return 0;
                }


                uint
                f_27_22799_22858(System.Numerics.BigInteger
                data, out byte[]
                dataBytes)
                {
                    var return_v = CountSignificantBits(data, out dataBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 22799, 22858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RealParser.Status
                f_27_23016_23251(byte[]
                integerValueAsBytes, uint
                integerBitsOfPrecision, bool
                hasNonzeroFractionalPart, Microsoft.CodeAnalysis.RealParser.FloatingPointType
                type, out ulong
                result)
                {
                    var return_v = ConvertBigIntegerToFloatingPointBits(integerValueAsBytes, integerBitsOfPrecision, hasNonzeroFractionalPart, type, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 23016, 23251);
                    return return_v;
                }


                int
                f_27_24155_24183(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.OverflowDecimalExponent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 24155, 24183);
                    return return_v;
                }


                ulong
                f_27_24491_24500(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.Zero;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 24491, 24500);
                    return return_v;
                }


                System.Numerics.BigInteger
                f_27_24607_24693(Microsoft.CodeAnalysis.RealParser.DecimalFloatingPointString
                data, uint
                integer_first_index, uint
                integer_last_index)
                {
                    var return_v = AccumulateDecimalDigitsIntoBigInteger(data, integer_first_index, integer_last_index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 24607, 24693);
                    return return_v;
                }


                bool
                f_27_24721_24748_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 24721, 24748);
                    return return_v;
                }


                int
                f_27_24708_24749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 24708, 24749);
                    return 0;
                }


                int
                f_27_24824_24902(ref System.Numerics.BigInteger
                number, uint
                power)
                {
                    MultiplyByPowerOfTen(ref number, power);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 24824, 24902);
                    return 0;
                }


                uint
                f_27_25451_25492(System.Numerics.BigInteger
                data)
                {
                    var return_v = CountSignificantBits(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 25451, 25492);
                    return return_v;
                }


                uint
                f_27_25540_25583(System.Numerics.BigInteger
                data)
                {
                    var return_v = CountSignificantBits(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 25540, 25583);
                    return return_v;
                }


                int
                f_27_25840_25891(ref System.Numerics.BigInteger
                number, uint
                shift)
                {
                    ShiftLeft(ref number, shift);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 25840, 25891);
                    return 0;
                }


                Microsoft.CodeAnalysis.RealParser.Status
                f_27_27298_27553(byte[]
                integerValueAsBytes, uint
                integerBitsOfPrecision, bool
                hasNonzeroFractionalPart, Microsoft.CodeAnalysis.RealParser.FloatingPointType
                type, out ulong
                result)
                {
                    var return_v = ConvertBigIntegerToFloatingPointBits(integerValueAsBytes, integerBitsOfPrecision, hasNonzeroFractionalPart, type, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 27298, 27553);
                    return return_v;
                }


                int
                f_27_28260_28328(ref System.Numerics.BigInteger
                number, uint
                shift)
                {
                    ShiftLeft(ref number, shift);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 28260, 28328);
                    return 0;
                }


                uint
                f_27_28825_28865(ulong
                data)
                {
                    var return_v = CountSignificantBits(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 28825, 28865);
                    return return_v;
                }


                int
                f_27_29306_29347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 29306, 29347);
                    return 0;
                }


                Microsoft.CodeAnalysis.RealParser.Status
                f_27_30514_30603(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param, ulong
                initialMantissa, int
                initialExponent, bool
                hasZeroTail, out ulong
                result)
                {
                    var return_v = this_param.AssembleFloatingPointValue(initialMantissa, initialExponent, hasZeroTail, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 30514, 30603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 19920, 30615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 19920, 30615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Status ConvertBigIntegerToFloatingPointBits(byte[] integerValueAsBytes, uint integerBitsOfPrecision, bool hasNonzeroFractionalPart, FloatingPointType type, out ulong result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 31660, 33210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 31873, 31918);

                int
                baseExponent = f_27_31892_31917(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 31932, 31945);

                int
                exponent
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 31959, 31974);

                ulong
                mantissa
                = default(ulong);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 31988, 32035);

                bool
                has_zero_tail = !hasNonzeroFractionalPart
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32049, 32109);

                int
                topElementIndex = ((int)integerBitsOfPrecision - 1) / 8
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32561, 32630);

                int
                bottomElementIndex = f_27_32586_32629(0, topElementIndex - (64 / 8) + 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32644, 32693);

                exponent = baseExponent + bottomElementIndex * 8;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32707, 32720);

                mantissa = 0;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32743, 32767);
                    for (int
        i = (int)topElementIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32734, 32914) || true) && (i >= bottomElementIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32794, 32797)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(27, 32734, 32914))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 32734, 32914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32831, 32846);

                        mantissa <<= 8;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32864, 32899);

                        mantissa |= integerValueAsBytes[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 1, 181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27, 1, 181);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32937, 32963);
                    for (int
        i = bottomElementIndex - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32928, 33097) || true) && (has_zero_tail && (DynAbs.Tracing.TraceSender.Expression_True(27, 32965, 32988) && i >= 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 32990, 32993)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(27, 32928, 33097))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 32928, 33097);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33027, 33082) || true) && (integerValueAsBytes[i] != 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 33027, 33082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33060, 33082);

                            has_zero_tail = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 33027, 33082);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 1, 170);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27, 1, 170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33113, 33199);

                return f_27_33120_33198(type, mantissa, exponent, has_zero_tail, out result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 31660, 33210);

                ushort
                f_27_31892_31917(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param)
                {
                    var return_v = this_param.DenormalMantissaBits;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 31892, 31917);
                    return return_v;
                }


                int
                f_27_32586_32629(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 32586, 32629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RealParser.Status
                f_27_33120_33198(Microsoft.CodeAnalysis.RealParser.FloatingPointType
                this_param, ulong
                initialMantissa, int
                initialExponent, bool
                hasZeroTail, out ulong
                result)
                {
                    var return_v = this_param.AssembleFloatingPointValue(initialMantissa, initialExponent, hasZeroTail, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 33120, 33198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 31660, 33210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 31660, 33210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BigInteger AccumulateDecimalDigitsIntoBigInteger(DecimalFloatingPointString data, uint integer_first_index, uint integer_last_index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 33686, 34115);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33858, 33922) || true) && (integer_first_index == integer_last_index)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 33858, 33922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33905, 33922);

                    return s_bigZero;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 33858, 33922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 33936, 34053);

                var
                valueString = f_27_33954_34052(data.Mantissa, integer_first_index, (integer_last_index - integer_first_index))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34067, 34104);

                return BigInteger.Parse(valueString);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 33686, 34115);

                string
                f_27_33954_34052(string
                this_param, uint
                startIndex, uint
                length)
                {
                    var return_v = this_param.Substring((int)startIndex, (int)length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 33954, 34052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 33686, 34115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 33686, 34115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint CountSignificantBits(ulong data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 34231, 34482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34308, 34324);

                uint
                result = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34338, 34441) || true) && (data != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 34338, 34441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34388, 34399);

                        data >>= 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34417, 34426);

                        result++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 34338, 34441);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 34338, 34441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27, 34338, 34441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34457, 34471);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 34231, 34482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 34231, 34482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 34231, 34482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint CountSignificantBits(byte data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 34598, 34848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34674, 34690);

                uint
                result = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34704, 34807) || true) && (data != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 34704, 34807);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34754, 34765);

                        data >>= 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34783, 34792);

                        result++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27, 34704, 34807);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 34704, 34807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27, 34704, 34807);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 34823, 34837);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 34598, 34848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 34598, 34848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 34598, 34848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint CountSignificantBits(BigInteger data, out byte[] dataBytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 34964, 35531);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35068, 35183) || true) && (data.IsZero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 35068, 35183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35117, 35141);

                    dataBytes = new byte[1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35159, 35168);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 35068, 35183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35199, 35230);

                dataBytes = data.ToByteArray();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35313, 35337);
                    for (int
        i = f_27_35317_35333(dataBytes) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35304, 35495) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35347, 35350)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(27, 35304, 35495))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 35304, 35495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35384, 35405);

                        var
                        v = dataBytes[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35423, 35480) || true) && (v != 0)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 35423, 35480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35435, 35480);

                            return 8 * (uint)i + f_27_35456_35479(v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27, 35423, 35480);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35511, 35520);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 34964, 35531);

                int
                f_27_35317_35333(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27, 35317, 35333);
                    return return_v;
                }


                uint
                f_27_35456_35479(byte
                data)
                {
                    var return_v = CountSignificantBits(data);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 35456, 35479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 34964, 35531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 34964, 35531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static uint CountSignificantBits(BigInteger data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 35647, 35820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35729, 35746);

                byte[]
                dataBytes
                = default(byte[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 35760, 35809);

                return f_27_35767_35808(data, out dataBytes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 35647, 35820);

                uint
                f_27_35767_35808(System.Numerics.BigInteger
                data, out byte[]
                dataBytes)
                {
                    var return_v = CountSignificantBits(data, out dataBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 35767, 35808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 35647, 35820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 35647, 35820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ulong RightShiftWithRounding(ulong value, int shift, bool hasZeroTail)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 36454, 37211);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36687, 36713) || true) && (shift >= 64)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(27, 36687, 36713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36704, 36713);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(27, 36687, 36713);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36729, 36776);

                ulong
                extraBitsMask = (1UL << (shift - 1)) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36790, 36832);

                ulong
                roundBitMask = (1UL << (shift - 1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36846, 36878);

                ulong
                lsbBitMask = 1UL << shift
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36894, 36934);

                bool
                lsbBit = (value & lsbBitMask) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 36948, 36992);

                bool
                roundBit = (value & roundBitMask) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 37006, 37070);

                bool
                hasTailBits = !hasZeroTail || (DynAbs.Tracing.TraceSender.Expression_False(27, 37025, 37069) || (value & extraBitsMask) != 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 37086, 37200);

                return (value >> shift) + ((DynAbs.Tracing.TraceSender.Conditional_F1(27, 37113, 37188) || ((f_27_37113_37188(lsbBit: lsbBit, roundBit: roundBit, hasTailBits: hasTailBits) && DynAbs.Tracing.TraceSender.Conditional_F2(27, 37191, 37194)) || DynAbs.Tracing.TraceSender.Conditional_F3(27, 37197, 37198))) ? 1UL : 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 36454, 37211);

                bool
                f_27_37113_37188(bool
                lsbBit, bool
                roundBit, bool
                hasTailBits)
                {
                    var return_v = ShouldRoundUp(lsbBit: lsbBit, roundBit: roundBit, hasTailBits: hasTailBits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 37113, 37188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 36454, 37211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 36454, 37211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ShouldRoundUp(
                    bool lsbBit,
                    bool roundBit,
                    bool hasTailBits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 38196, 38852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 38798, 38841);

                return roundBit && (DynAbs.Tracing.TraceSender.Expression_True(27, 38805, 38840) && (hasTailBits || (DynAbs.Tracing.TraceSender.Expression_False(27, 38818, 38839) || lsbBit)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 38196, 38852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 38196, 38852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 38196, 38852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ShiftLeft(ref BigInteger number, uint shift)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 39165, 39362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 39254, 39308);

                var
                powerOfTwo = BigInteger.Pow(s_bigTwo, (int)shift)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 39322, 39351);

                number = number * powerOfTwo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 39165, 39362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 39165, 39362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 39165, 39362);
            }
        }

        private static void MultiplyByPowerOfTen(ref BigInteger number, uint power)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 39675, 39883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 39775, 39829);

                var
                powerOfTen = BigInteger.Pow(s_bigTen, (int)power)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 39843, 39872);

                number = number * powerOfTen;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 39675, 39883);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 39675, 39883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 39675, 39883);
            }
        }

        private static uint FloatToInt32Bits(float f)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 40011, 40190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40081, 40112);

                var
                bits = default(FloatUnion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40126, 40145);

                bits.FloatData = f;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40159, 40179);

                return bits.IntData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 40011, 40190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 40011, 40190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 40011, 40190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static float Int32BitsToFloat(uint i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27, 40312, 40491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40382, 40413);

                var
                bits = default(FloatUnion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40427, 40444);

                bits.IntData = i;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 40458, 40480);

                return bits.FloatData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27, 40312, 40491);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27, 40312, 40491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 40312, 40491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct FloatUnion
        {

            [FieldOffset(0)]
            public uint IntData;

            [FieldOffset(0)]
            public float FloatData;
            static FloatUnion()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 40638, 40861);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 40638, 40861);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 40638, 40861);
            }
        }

        static RealParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27, 1035, 40868);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3165, 3192);
            s_bigZero = BigInteger.Zero; DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3238, 3263);
            s_bigOne = BigInteger.One; DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3309, 3337);
            s_bigTwo = f_27_3320_3337(2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(27, 3383, 3412);
            s_bigTen = f_27_3394_3412(10); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27, 1035, 40868);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27, 1035, 40868);
        }


        static System.Numerics.BigInteger
        f_27_3320_3337(int
        value)
        {
            var return_v = new System.Numerics.BigInteger(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 3320, 3337);
            return return_v;
        }


        static System.Numerics.BigInteger
        f_27_3394_3412(int
        value)
        {
            var return_v = new System.Numerics.BigInteger(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(27, 3394, 3412);
            return return_v;
        }

    }
}
