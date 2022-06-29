// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Globalization;

namespace Microsoft.CodeAnalysis
{
    internal static class VersionHelper
    {
        internal static bool TryParse(string s, out Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(42, 902, 1113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 987, 1102);

                return f_42_994_1101(s, allowWildcard: false, maxValue: ushort.MaxValue, allowPartialParse: true, version: out version);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(42, 902, 1113);

                bool
                f_42_994_1101(string
                s, bool
                allowWildcard, ushort
                maxValue, bool
                allowPartialParse, out System.Version
                version)
                {
                    var return_v = TryParse(s, allowWildcard: allowWildcard, maxValue: maxValue, allowPartialParse: allowPartialParse, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 994, 1101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(42, 902, 1113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 902, 1113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseAssemblyVersion(string s, bool allowWildcard, out Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(42, 2000, 2259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 2120, 2248);

                return f_42_2127_2247(s, allowWildcard: allowWildcard, maxValue: ushort.MaxValue - 1, allowPartialParse: false, version: out version);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(42, 2000, 2259);

                bool
                f_42_2127_2247(string
                s, bool
                allowWildcard, int
                maxValue, bool
                allowPartialParse, out System.Version
                version)
                {
                    var return_v = TryParse(s, allowWildcard: allowWildcard, maxValue: (ushort)maxValue, allowPartialParse: allowPartialParse, out version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 2127, 2247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(42, 2000, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 2000, 2259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryParse(string s, bool allowWildcard, ushort maxValue, bool allowPartialParse, out Version version)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(42, 3572, 7509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 3717, 3776);

                f_42_3717_3775(!allowWildcard || (DynAbs.Tracing.TraceSender.Expression_False(42, 3730, 3774) || maxValue < ushort.MaxValue));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 3792, 3943) || true) && (f_42_3796_3824(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 3792, 3943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 3858, 3897);

                    version = AssemblyIdentity.NullVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 3915, 3928);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 3792, 3943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 3959, 3992);

                string[]
                elements = f_42_3979_3991(s, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4191, 4264);

                bool
                hasWildcard = allowWildcard && (DynAbs.Tracing.TraceSender.Expression_True(42, 4210, 4263) && elements[f_42_4236_4251(elements) - 1] == "*")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4280, 4462) || true) && ((hasWildcard && (DynAbs.Tracing.TraceSender.Expression_True(42, 4285, 4319) && f_42_4300_4315(elements) < 3)) || (DynAbs.Tracing.TraceSender.Expression_False(42, 4284, 4343) || f_42_4324_4339(elements) > 4))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 4280, 4462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4377, 4416);

                    version = AssemblyIdentity.NullVersion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4434, 4447);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 4280, 4462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4478, 4510);

                ushort[]
                values = new ushort[4]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4524, 4600);

                int
                lastExplicitValue = (DynAbs.Tracing.TraceSender.Conditional_F1(42, 4548, 4559) || ((hasWildcard && DynAbs.Tracing.TraceSender.Conditional_F2(42, 4562, 4581)) || DynAbs.Tracing.TraceSender.Conditional_F3(42, 4584, 4599))) ? f_42_4562_4577(elements) - 1 : f_42_4584_4599(elements)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4614, 4638);

                bool
                parseError = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4661, 4666);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4652, 7154) || true) && (i < lastExplicitValue)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4691, 4694)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(42, 4652, 7154))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 4652, 7154);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4730, 7139) || true) && (!f_42_4735_4827(elements[i], NumberStyles.None, f_42_4783_4811(), out values[i]) || (DynAbs.Tracing.TraceSender.Expression_False(42, 4734, 4851) || values[i] > maxValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 4730, 7139);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4893, 5066) || true) && (!allowPartialParse)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 4893, 5066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 4965, 5004);

                                version = AssemblyIdentity.NullVersion;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5030, 5043);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(42, 4893, 5066);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5090, 5108);

                            parseError = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5132, 5293) || true) && (f_42_5136_5174(elements[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 5132, 5293);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5224, 5238);

                                values[i] = 0;
                                DynAbs.Tracing.TraceSender.TraceBreak(42, 5264, 5270);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(42, 5132, 5293);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5319, 5624) || true) && (values[i] > maxValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 5319, 5624);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5552, 5566);

                                values[i] = 0;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5592, 5601);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(42, 5319, 5624);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5648, 5675);

                            bool
                            invalidFormat = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5697, 5735);

                            System.Numerics.BigInteger
                            number = 0
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5982, 5989);

                                //There could be an invalid character in the input so check for the presence of one and
                                //parse up to that point. examples of invalid characters are alphas and punctuation
                                for (var
            idx = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 5973, 6362) || true) && (idx < f_42_5997_6015(elements[i]))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6017, 6022)
            , idx++, DynAbs.Tracing.TraceSender.TraceExitCondition(42, 5973, 6362))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 5973, 6362);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6072, 6339) || true) && (!f_42_6077_6107(f_42_6090_6106(elements[i], idx)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 6072, 6339);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6165, 6186);

                                        invalidFormat = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6218, 6276);

                                        f_42_6218_6275(f_42_6230_6259(elements[i], 0, idx), out values[i]);
                                        DynAbs.Tracing.TraceSender.TraceBreak(42, 6306, 6312);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(42, 6072, 6339);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(42, 1, 390);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(42, 1, 390);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6386, 7020) || true) && (!invalidFormat)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 6386, 7020);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6683, 6997) || true) && (f_42_6687_6726(elements[i], out values[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 6683, 6997);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 6961, 6970);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 6683, 6997);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(42, 6386, 7020);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(42, 7114, 7120);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(42, 4730, 7139);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(42, 1, 2503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(42, 1, 2503);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7176, 7383) || true) && (hasWildcard)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 7176, 7383);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7234, 7255);
                        for (int
        i = lastExplicitValue
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7225, 7368) || true) && (i < f_42_7261_7274(values))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7276, 7279)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(42, 7225, 7368))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 7225, 7368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7321, 7349);

                            values[i] = ushort.MaxValue;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(42, 1, 144);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(42, 1, 144);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 7176, 7383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7399, 7465);

                version = f_42_7409_7464(values[0], values[1], values[2], values[3]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7479, 7498);

                return !parseError;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(42, 3572, 7509);

                int
                f_42_3717_3775(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 3717, 3775);
                    return 0;
                }


                bool
                f_42_3796_3824(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 3796, 3824);
                    return return_v;
                }


                string[]
                f_42_3979_3991(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 3979, 3991);
                    return return_v;
                }


                int
                f_42_4236_4251(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4236, 4251);
                    return return_v;
                }


                int
                f_42_4300_4315(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4300, 4315);
                    return return_v;
                }


                int
                f_42_4324_4339(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4324, 4339);
                    return return_v;
                }


                int
                f_42_4562_4577(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4562, 4577);
                    return return_v;
                }


                int
                f_42_4584_4599(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4584, 4599);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_42_4783_4811()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 4783, 4811);
                    return return_v;
                }


                bool
                f_42_4735_4827(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out ushort
                result)
                {
                    var return_v = ushort.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 4735, 4827);
                    return return_v;
                }


                bool
                f_42_5136_5174(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 5136, 5174);
                    return return_v;
                }


                int
                f_42_5997_6015(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 5997, 6015);
                    return return_v;
                }


                char
                f_42_6090_6106(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 6090, 6106);
                    return return_v;
                }


                bool
                f_42_6077_6107(char
                c)
                {
                    var return_v = char.IsDigit(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 6077, 6107);
                    return return_v;
                }


                string
                f_42_6230_6259(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 6230, 6259);
                    return return_v;
                }


                bool
                f_42_6218_6275(string
                s, out ushort
                value)
                {
                    var return_v = TryGetValue(s, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 6218, 6275);
                    return return_v;
                }


                bool
                f_42_6687_6726(string
                s, out ushort
                value)
                {
                    var return_v = TryGetValue(s, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 6687, 6726);
                    return return_v;
                }


                int
                f_42_7261_7274(ushort[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 7261, 7274);
                    return return_v;
                }


                System.Version
                f_42_7409_7464(ushort
                major, ushort
                minor, ushort
                build, ushort
                revision)
                {
                    var return_v = new System.Version((int)major, (int)minor, (int)build, (int)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 7409, 7464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(42, 3572, 7509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 3572, 7509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetValue(string s, out ushort value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(42, 7521, 8232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7605, 7639);

                System.Numerics.BigInteger
                number
                = default(System.Numerics.BigInteger);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7653, 8020) || true) && (System.Numerics.BigInteger.TryParse(s, NumberStyles.None, f_42_7715_7743(), out number))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 7653, 8020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7942, 7975);

                    value = (ushort)(number % 65536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 7993, 8005);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 7653, 8020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 8184, 8194);

                value = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 8208, 8221);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(42, 7521, 8232);

                System.Globalization.CultureInfo
                f_42_7715_7743()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 7715, 7743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(42, 7521, 8232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 7521, 8232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Version? GenerateVersionFromPatternAndCurrentTime(DateTime time, Version pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(42, 8389, 9704);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 8509, 8631) || true) && (pattern == null || (DynAbs.Tracing.TraceSender.Expression_False(42, 8513, 8567) || f_42_8532_8548(pattern) != ushort.MaxValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 8509, 8631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 8601, 8616);

                    return pattern;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 8509, 8631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 8940, 9038) || true) && (time == default(DateTime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 8940, 9038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9003, 9023);

                    time = DateTime.Now;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 8940, 9038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9054, 9106);

                int
                revision = (int)time.TimeOfDay.TotalSeconds / 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9171, 9212);

                f_42_9171_9211(revision < ushort.MaxValue);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9228, 9693) || true) && (f_42_9232_9245(pattern) == ushort.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 9228, 9693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9298, 9351);

                    TimeSpan
                    days = time.Date - f_42_9326_9350(2000, 1, 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9369, 9428);

                    int
                    build = f_42_9381_9427(ushort.MaxValue, days.TotalDays)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9448, 9530);

                    return f_42_9455_9529(f_42_9467_9480(pattern), f_42_9482_9495(pattern), (ushort)build, (ushort)revision);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 9228, 9693);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(42, 9228, 9693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(42, 9596, 9678);

                    return f_42_9603_9677(f_42_9615_9628(pattern), f_42_9630_9643(pattern), f_42_9645_9658(pattern), (ushort)revision);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(42, 9228, 9693);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(42, 8389, 9704);

                int
                f_42_8532_8548(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 8532, 8548);
                    return return_v;
                }


                int
                f_42_9171_9211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 9171, 9211);
                    return 0;
                }


                int
                f_42_9232_9245(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9232, 9245);
                    return return_v;
                }


                System.DateTime
                f_42_9326_9350(int
                year, int
                month, int
                day)
                {
                    var return_v = new System.DateTime(year, month, day);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 9326, 9350);
                    return return_v;
                }


                int
                f_42_9381_9427(ushort
                val1, double
                val2)
                {
                    var return_v = Math.Min((int)val1, (int)val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 9381, 9427);
                    return return_v;
                }


                int
                f_42_9467_9480(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9467, 9480);
                    return return_v;
                }


                int
                f_42_9482_9495(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9482, 9495);
                    return return_v;
                }


                System.Version
                f_42_9455_9529(int
                major, int
                minor, ushort
                build, ushort
                revision)
                {
                    var return_v = new System.Version(major, minor, (int)build, (int)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 9455, 9529);
                    return return_v;
                }


                int
                f_42_9615_9628(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9615, 9628);
                    return return_v;
                }


                int
                f_42_9630_9643(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9630, 9643);
                    return return_v;
                }


                int
                f_42_9645_9658(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(42, 9645, 9658);
                    return return_v;
                }


                System.Version
                f_42_9603_9677(int
                major, int
                minor, int
                build, ushort
                revision)
                {
                    var return_v = new System.Version(major, minor, build, (int)revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(42, 9603, 9677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(42, 8389, 9704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 8389, 9704);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VersionHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(42, 322, 9711);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(42, 322, 9711);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(42, 322, 9711);
        }

    }
}
