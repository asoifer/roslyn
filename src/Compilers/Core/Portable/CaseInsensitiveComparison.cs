// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public static class CaseInsensitiveComparison
    {
        private static readonly TextInfo s_unicodeCultureTextInfo;

        private static CultureInfo GetUnicodeCulture()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 830, 1748);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 1220, 1249);

                    return f_3_1227_1248("en");
                }
                catch (ArgumentException) // System.Globalization.CultureNotFoundException not on all platforms
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(3, 1278, 1737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 1686, 1722);

                    return f_3_1693_1721();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(3, 1278, 1737);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 830, 1748);

                System.Globalization.CultureInfo
                f_3_1227_1248(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 1227, 1248);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_3_1693_1721()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 1693, 1721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 830, 1748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 830, 1748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static char ToLower(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 2239, 2833);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2466, 2584) || true) && (unchecked((uint)(c - 'A')) <= ('Z' - 'A'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 2466, 2584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2545, 2569);

                    return (char)(c | 0x20);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 2466, 2584);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2600, 2780) || true) && (c < 0xC0)
                ) // Covers ASCII (U+0000 - U+007F) and up to the next upper-case codepoint (Latin Capital Letter A with Grave)

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 2600, 2780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2756, 2765);

                    return c;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 2600, 2780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2796, 2822);

                return f_3_2803_2821(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 2239, 2833);

                char
                f_3_2803_2821(char
                c)
                {
                    var return_v = ToLowerNonAscii(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 2803, 2821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 2239, 2833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 2239, 2833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static char ToLowerNonAscii(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 2845, 3315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 2913, 3245) || true) && (c == '\u0130')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 2913, 3245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3219, 3230);

                    return 'i';
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 2913, 3245);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3261, 3304);

                return f_3_3268_3303(s_unicodeCultureTextInfo, c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 2845, 3315);

                char
                f_3_3268_3303(System.Globalization.TextInfo
                this_param, char
                c)
                {
                    var return_v = this_param.ToLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 3268, 3303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 2845, 3315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 2845, 3315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class OneToOneUnicodeComparer : StringComparer
        {
            private static int CompareLowerUnicode(char c1, char c2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 3537, 3691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3626, 3676);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(3, 3633, 3643) || (((c1 == c2) && DynAbs.Tracing.TraceSender.Conditional_F2(3, 3646, 3647)) || DynAbs.Tracing.TraceSender.Conditional_F3(3, 3650, 3675))) ? 0 : f_3_3650_3661(c1) - f_3_3664_3675(c2);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 3537, 3691);

                    char
                    f_3_3650_3661(char
                    c)
                    {
                        var return_v = ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 3650, 3661);
                        return return_v;
                    }


                    char
                    f_3_3664_3675(char
                    c)
                    {
                        var return_v = ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 3664, 3675);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 3537, 3691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 3537, 3691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int Compare(string? str1, string? str2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 3707, 4601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3795, 3890) || true) && ((object?)str1 == str2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 3795, 3890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3862, 3871);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 3795, 3890);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3910, 3997) || true) && (str1 is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 3910, 3997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 3968, 3978);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 3910, 3997);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4017, 4103) || true) && (str2 is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 4017, 4103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4075, 4084);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 4017, 4103);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4123, 4168);

                    int
                    len = f_3_4133_4167(f_3_4142_4153(str1), f_3_4155_4166(str2))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4195, 4200);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4186, 4453) || true) && (i < len)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4211, 4214)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 4186, 4453))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 4186, 4453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4256, 4308);

                            int
                            ordDiff = f_3_4270_4307(f_3_4290_4297(str1, i), f_3_4299_4306(str2, i))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4330, 4434) || true) && (ordDiff != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 4330, 4434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4396, 4411);

                                return ordDiff;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 4330, 4434);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 268);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4553, 4586);

                    return f_3_4560_4571(str1) - f_3_4574_4585(str2);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(3, 3707, 4601);

                    int
                    f_3_4142_4153(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4142, 4153);
                        return return_v;
                    }


                    int
                    f_3_4155_4166(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4155, 4166);
                        return return_v;
                    }


                    int
                    f_3_4133_4167(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 4133, 4167);
                        return return_v;
                    }


                    char
                    f_3_4290_4297(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4290, 4297);
                        return return_v;
                    }


                    char
                    f_3_4299_4306(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4299, 4306);
                        return return_v;
                    }


                    int
                    f_3_4270_4307(char
                    c1, char
                    c2)
                    {
                        var return_v = CompareLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 4270, 4307);
                        return return_v;
                    }


                    int
                    f_3_4560_4571(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4560, 4571);
                        return return_v;
                    }


                    int
                    f_3_4574_4585(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 4574, 4585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 3707, 4601);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 3707, 4601);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int Compare(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 4648, 5227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4749, 4794);

                    int
                    len = f_3_4759_4793(str1.Length, str2.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4821, 4826);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4812, 5079) || true) && (i < len)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4837, 4840)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 4812, 5079))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 4812, 5079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4882, 4934);

                            int
                            ordDiff = f_3_4896_4933(str1[i], str2[i])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 4956, 5060) || true) && (ordDiff != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 4956, 5060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5022, 5037);

                                return ordDiff;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 4956, 5060);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 268);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5179, 5212);

                    return str1.Length - str2.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(3, 4648, 5227);

                    int
                    f_3_4759_4793(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 4759, 4793);
                        return return_v;
                    }


                    int
                    f_3_4896_4933(char
                    c1, char
                    c2)
                    {
                        var return_v = CompareLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 4896, 4933);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 4648, 5227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 4648, 5227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool AreEqualLowerUnicode(char c1, char c2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 5251, 5403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5342, 5388);

                    return c1 == c2 || (DynAbs.Tracing.TraceSender.Expression_False(3, 5349, 5387) || f_3_5361_5372(c1) == f_3_5376_5387(c2));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 5251, 5403);

                    char
                    f_3_5361_5372(char
                    c)
                    {
                        var return_v = ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 5361, 5372);
                        return return_v;
                    }


                    char
                    f_3_5376_5387(char
                    c)
                    {
                        var return_v = ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 5376, 5387);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 5251, 5403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 5251, 5403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(string? str1, string? str2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 5419, 6148);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5507, 5605) || true) && ((object?)str1 == str2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 5507, 5605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5574, 5586);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 5507, 5605);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5625, 5731) || true) && (str1 is null || (DynAbs.Tracing.TraceSender.Expression_False(3, 5629, 5657) || str2 is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 5625, 5731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5699, 5712);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 5625, 5731);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5751, 5855) || true) && (f_3_5755_5766(str1) != f_3_5770_5781(str2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 5751, 5855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5823, 5836);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 5751, 5855);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5884, 5889);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5875, 6101) || true) && (i < f_3_5895_5906(str1))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5908, 5911)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 5875, 6101))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 5875, 6101);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 5953, 6082) || true) && (!f_3_5958_5996(f_3_5979_5986(str1, i), f_3_5988_5995(str2, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 5953, 6082);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6046, 6059);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 5953, 6082);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6121, 6133);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(3, 5419, 6148);

                    int
                    f_3_5755_5766(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 5755, 5766);
                        return return_v;
                    }


                    int
                    f_3_5770_5781(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 5770, 5781);
                        return return_v;
                    }


                    int
                    f_3_5895_5906(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 5895, 5906);
                        return return_v;
                    }


                    char
                    f_3_5979_5986(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 5979, 5986);
                        return return_v;
                    }


                    char
                    f_3_5988_5995(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 5988, 5995);
                        return return_v;
                    }


                    bool
                    f_3_5958_5996(char
                    c1, char
                    c2)
                    {
                        var return_v = AreEqualLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 5958, 5996);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 5419, 6148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 5419, 6148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 6195, 6693);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6296, 6400) || true) && (str1.Length != str2.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 6296, 6400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6368, 6381);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 6296, 6400);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6429, 6434);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6420, 6646) || true) && (i < str1.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6453, 6456)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 6420, 6646))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 6420, 6646);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6498, 6627) || true) && (!f_3_6503_6541(str1[i], str2[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 6498, 6627);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6591, 6604);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 6498, 6627);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 227);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6666, 6678);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(3, 6195, 6693);

                    bool
                    f_3_6503_6541(char
                    c1, char
                    c2)
                    {
                        var return_v = AreEqualLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 6503, 6541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 6195, 6693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 6195, 6693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool EndsWith(string value, string possibleEnd)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 6717, 7595);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6811, 6916) || true) && ((object)value == possibleEnd)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 6811, 6916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6885, 6897);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 6811, 6916);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 6936, 7066) || true) && ((object)value == null || (DynAbs.Tracing.TraceSender.Expression_False(3, 6940, 6992) || (object)possibleEnd == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 6936, 7066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7034, 7047);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 6936, 7066);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7086, 7111);

                    int
                    i = f_3_7094_7106(value) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7129, 7160);

                    int
                    j = f_3_7137_7155(possibleEnd) - 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7180, 7263) || true) && (i < j)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7180, 7263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7231, 7244);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7180, 7263);
                    }
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7283, 7548) || true) && (j >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7283, 7548);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7338, 7475) || true) && (!f_3_7343_7389(f_3_7364_7372(value, i), f_3_7374_7388(possibleEnd, j)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7338, 7475);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7439, 7452);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7338, 7475);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7499, 7503);

                            i--;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7525, 7529);

                            j--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7283, 7548);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 7283, 7548);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 7283, 7548);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7568, 7580);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 6717, 7595);

                    int
                    f_3_7094_7106(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 7094, 7106);
                        return return_v;
                    }


                    int
                    f_3_7137_7155(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 7137, 7155);
                        return return_v;
                    }


                    char
                    f_3_7364_7372(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 7364, 7372);
                        return return_v;
                    }


                    char
                    f_3_7374_7388(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 7374, 7388);
                        return return_v;
                    }


                    bool
                    f_3_7343_7389(char
                    c1, char
                    c2)
                    {
                        var return_v = AreEqualLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 7343, 7389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 6717, 7595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 6717, 7595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static bool StartsWith(string value, string possibleStart)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 7611, 8413);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7709, 7816) || true) && ((object)value == possibleStart)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7709, 7816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7785, 7797);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7709, 7816);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7836, 7968) || true) && ((object)value == null || (DynAbs.Tracing.TraceSender.Expression_False(3, 7840, 7894) || (object)possibleStart == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7836, 7968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7936, 7949);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7836, 7968);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 7988, 8101) || true) && (f_3_7992_8004(value) < f_3_8007_8027(possibleStart))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 7988, 8101);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8069, 8082);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(3, 7988, 8101);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8130, 8135);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8121, 8366) || true) && (i < f_3_8141_8161(possibleStart))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8163, 8166)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 8121, 8366))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 8121, 8366);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8208, 8347) || true) && (!f_3_8213_8261(f_3_8234_8242(value, i), f_3_8244_8260(possibleStart, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 8208, 8347);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8311, 8324);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(3, 8208, 8347);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 246);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 246);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8386, 8398);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 7611, 8413);

                    int
                    f_3_7992_8004(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 7992, 8004);
                        return return_v;
                    }


                    int
                    f_3_8007_8027(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8007, 8027);
                        return return_v;
                    }


                    int
                    f_3_8141_8161(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8141, 8161);
                        return return_v;
                    }


                    char
                    f_3_8234_8242(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8234, 8242);
                        return return_v;
                    }


                    char
                    f_3_8244_8260(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8244, 8260);
                        return return_v;
                    }


                    bool
                    f_3_8213_8261(char
                    c1, char
                    c2)
                    {
                        var return_v = AreEqualLowerUnicode(c1, c2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 8213, 8261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 7611, 8413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 7611, 8413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode(string str)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 8429, 8764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8505, 8539);

                    int
                    hashCode = Hash.FnvOffsetBias
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8568, 8573);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8559, 8713) || true) && (i < f_3_8579_8589(str))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8591, 8594)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 8559, 8713))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 8559, 8713);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8636, 8694);

                            hashCode = f_3_8647_8693(hashCode, f_3_8677_8692(f_3_8685_8691(str, i)));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 8733, 8749);

                    return hashCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(3, 8429, 8764);

                    int
                    f_3_8579_8589(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8579, 8589);
                        return return_v;
                    }


                    char
                    f_3_8685_8691(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 8685, 8691);
                        return return_v;
                    }


                    char
                    f_3_8677_8692(char
                    c)
                    {
                        var return_v = ToLower(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 8677, 8692);
                        return return_v;
                    }


                    int
                    f_3_8647_8693(int
                    hashCode, char
                    ch)
                    {
                        var return_v = Hash.CombineFNVHash(hashCode, ch);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 8647, 8693);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 8429, 8764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 8429, 8764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public OneToOneUnicodeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(3, 3451, 8775);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(3, 3451, 8775);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 3451, 8775);
            }


            static OneToOneUnicodeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(3, 3451, 8775);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(3, 3451, 8775);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 3451, 8775);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(3, 3451, 8775);
        }

        private static readonly OneToOneUnicodeComparer s_comparer;

        public static StringComparer Comparer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 9592, 9605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 9595, 9605);
                    return s_comparer; DynAbs.Tracing.TraceSender.TraceExitMethod(3, 9592, 9605);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 9592, 9605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 9592, 9605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool Equals(string left, string right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 10217, 10250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 10220, 10250);
                return f_3_10220_10250(s_comparer, left, right); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 10217, 10250);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 10217, 10250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 10217, 10250);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_3_10220_10250(Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
            this_param, string
            str1, string
            str2)
            {
                var return_v = this_param.Equals(str1, str2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 10220, 10250);
                return return_v;
            }

        }

        public static bool Equals(ReadOnlySpan<char> left, ReadOnlySpan<char> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 10917, 10950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 10920, 10950);
                return f_3_10920_10950(s_comparer, left, right); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 10917, 10950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 10917, 10950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 10917, 10950);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_3_10920_10950(Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
            this_param, System.ReadOnlySpan<char>
            str1, System.ReadOnlySpan<char>
            str2)
            {
                var return_v = this_param.Equals(str1, str2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 10920, 10950);
                return return_v;
            }

        }

        public static bool EndsWith(string value, string possibleEnd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 11280, 11335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 11283, 11335);
                return f_3_11283_11335(value, possibleEnd); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 11280, 11335);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 11280, 11335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 11280, 11335);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_3_11283_11335(string
            value, string
            possibleEnd)
            {
                var return_v = OneToOneUnicodeComparer.EndsWith(value, possibleEnd);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 11283, 11335);
                return return_v;
            }

        }

        public static bool StartsWith(string value, string possibleStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 11668, 11727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 11671, 11727);
                return f_3_11671_11727(value, possibleStart); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 11668, 11727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 11668, 11727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 11668, 11727);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_3_11671_11727(string
            value, string
            possibleStart)
            {
                var return_v = OneToOneUnicodeComparer.StartsWith(value, possibleStart);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 11671, 11727);
                return return_v;
            }

        }

        public static int Compare(string left, string right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 12415, 12449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 12418, 12449);
                return f_3_12418_12449(s_comparer, left, right); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 12415, 12449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 12415, 12449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 12415, 12449);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_3_12418_12449(Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
            this_param, string
            str1, string
            str2)
            {
                var return_v = this_param.Compare(str1, str2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 12418, 12449);
                return return_v;
            }

        }

        public static int Compare(ReadOnlySpan<char> left, ReadOnlySpan<char> right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(3, 13192, 13226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 13195, 13226);
                return f_3_13195_13226(s_comparer, left, right); DynAbs.Tracing.TraceSender.TraceExitMethod(3, 13192, 13226);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 13192, 13226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 13192, 13226);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_3_13195_13226(Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
            this_param, System.ReadOnlySpan<char>
            str1, System.ReadOnlySpan<char>
            str2)
            {
                var return_v = this_param.Compare(str1, str2);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 13195, 13226);
                return return_v;
            }

        }

        public static int GetHashCode(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 13634, 13800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 13702, 13736);

                f_3_13702_13735(value != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 13752, 13789);

                return f_3_13759_13788(s_comparer, value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 13634, 13800);

                int
                f_3_13702_13735(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 13702, 13735);
                    return 0;
                }


                int
                f_3_13759_13788(Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
                this_param, string
                str)
                {
                    var return_v = this_param.GetHashCode(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 13759, 13788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 13634, 13800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 13634, 13800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "value")]
        public static string? ToLower(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 13990, 14510);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14119, 14167) || true) && (value is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 14119, 14167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14155, 14167);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 14119, 14167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14183, 14236) || true) && (f_3_14187_14199(value) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 14183, 14236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14223, 14236);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 14183, 14236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14252, 14309);

                var
                pooledStrbuilder = f_3_14275_14308()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14323, 14372);

                StringBuilder
                builder = pooledStrbuilder.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14388, 14410);

                f_3_14388_14409(
                            builder, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14424, 14441);

                f_3_14424_14440(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14457, 14499);

                return f_3_14464_14498(pooledStrbuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 13990, 14510);

                int
                f_3_14187_14199(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 14187, 14199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_3_14275_14308()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 14275, 14308);
                    return return_v;
                }


                System.Text.StringBuilder
                f_3_14388_14409(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 14388, 14409);
                    return return_v;
                }


                int
                f_3_14424_14440(System.Text.StringBuilder
                builder)
                {
                    ToLower(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 14424, 14440);
                    return 0;
                }


                string
                f_3_14464_14498(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 14464, 14498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 13990, 14510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 13990, 14510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ToLower(StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(3, 14699, 14966);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14773, 14818) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 14773, 14818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14811, 14818);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(3, 14773, 14818);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14843, 14848);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14834, 14955) || true) && (i < f_3_14854_14868(builder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14870, 14873)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(3, 14834, 14955))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(3, 14834, 14955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 14907, 14940);

                        builder[i] = f_3_14920_14939(f_3_14928_14938(builder, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(3, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(3, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(3, 14699, 14966);

                int
                f_3_14854_14868(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 14854, 14868);
                    return return_v;
                }


                char
                f_3_14928_14938(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 14928, 14938);
                    return return_v;
                }


                char
                f_3_14920_14939(char
                c)
                {
                    var return_v = ToLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 14920, 14939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(3, 14699, 14966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 14699, 14966);
            }
        }

        static CaseInsensitiveComparison()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(3, 568, 14973);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 762, 817);
            s_unicodeCultureTextInfo = f_3_789_817(f_3_789_808()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(3, 9167, 9209);
            s_comparer = f_3_9180_9209(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(3, 568, 14973);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(3, 568, 14973);
        }


        static System.Globalization.CultureInfo
        f_3_789_808()
        {
            var return_v = GetUnicodeCulture();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 789, 808);
            return return_v;
        }


        static System.Globalization.TextInfo
        f_3_789_817(System.Globalization.CultureInfo
        this_param)
        {
            var return_v = this_param.TextInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(3, 789, 817);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer
        f_3_9180_9209()
        {
            var return_v = new Microsoft.CodeAnalysis.CaseInsensitiveComparison.OneToOneUnicodeComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(3, 9180, 9209);
            return return_v;
        }

    }
}
