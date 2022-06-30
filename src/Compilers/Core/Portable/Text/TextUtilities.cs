// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Text
{
    internal static class TextUtilities
    {
        internal static int GetLengthOfLineBreak(SourceText text, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(735, 544, 1030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 637, 657);

                var
                c = f_735_645_656(text, index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 817, 844);

                const uint
                bias = '\r' + 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 858, 955) || true) && (unchecked(c - bias) <= (127 - bias))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 858, 955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 931, 940);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(735, 858, 955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 971, 1019);

                return f_735_978_1018(text, index, c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(735, 544, 1030);

                char
                f_735_645_656(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(735, 645, 656);
                    return return_v;
                }


                int
                f_735_978_1018(Microsoft.CodeAnalysis.Text.SourceText
                text, int
                index, char
                c)
                {
                    var return_v = GetLengthOfLineBreakSlow(text, index, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(735, 978, 1018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(735, 544, 1030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(735, 544, 1030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetLengthOfLineBreakSlow(SourceText text, int index, char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(735, 1042, 1498);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1146, 1487) || true) && (c == '\r')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 1146, 1487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1193, 1214);

                    var
                    next = index + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1232, 1290);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(735, 1239, 1281) || (((next < f_735_1247_1258(text)) && (DynAbs.Tracing.TraceSender.Expression_True(735, 1239, 1281) && '\n' == f_735_1271_1281(text, next)) && DynAbs.Tracing.TraceSender.Conditional_F2(735, 1284, 1285)) || DynAbs.Tracing.TraceSender.Conditional_F3(735, 1288, 1289))) ? 2 : 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(735, 1146, 1487);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 1146, 1487);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1324, 1487) || true) && (f_735_1328_1354(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 1324, 1487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1388, 1397);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 1324, 1487);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 1324, 1487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 1463, 1472);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 1324, 1487);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(735, 1146, 1487);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(735, 1042, 1498);

                int
                f_735_1247_1258(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(735, 1247, 1258);
                    return return_v;
                }


                char
                f_735_1271_1281(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(735, 1271, 1281);
                    return return_v;
                }


                bool
                f_735_1328_1354(char
                c)
                {
                    var return_v = IsAnyLineBreakCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(735, 1328, 1354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(735, 1042, 1498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(735, 1042, 1498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void GetStartAndLengthOfLineBreakEndingAt(SourceText text, int index, out int startLinebreak, out int lengthLinebreak)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(735, 1862, 2801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2019, 2040);

                char
                c = f_735_2028_2039(text, index)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2054, 2790) || true) && (c == '\n')
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2054, 2790);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2101, 2485) || true) && (index > 0 && (DynAbs.Tracing.TraceSender.Expression_True(735, 2105, 2141) && f_735_2118_2133(text, index - 1) == '\r'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2101, 2485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2250, 2277);

                        startLinebreak = index - 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2299, 2319);

                        lengthLinebreak = 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2101, 2485);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2101, 2485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2401, 2424);

                        startLinebreak = index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2446, 2466);

                        lengthLinebreak = 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2101, 2485);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2054, 2790);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2054, 2790);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2519, 2790) || true) && (f_735_2523_2549(c))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2519, 2790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2583, 2606);

                        startLinebreak = index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2624, 2644);

                        lengthLinebreak = 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2519, 2790);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(735, 2519, 2790);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2710, 2737);

                        startLinebreak = index + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 2755, 2775);

                        lengthLinebreak = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2519, 2790);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(735, 2054, 2790);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(735, 1862, 2801);

                char
                f_735_2028_2039(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(735, 2028, 2039);
                    return return_v;
                }


                char
                f_735_2118_2133(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(735, 2118, 2133);
                    return return_v;
                }


                bool
                f_735_2523_2549(char
                c)
                {
                    var return_v = IsAnyLineBreakCharacter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(735, 2523, 2549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(735, 1862, 2801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(735, 1862, 2801);
            }
        }

        internal static bool IsAnyLineBreakCharacter(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(735, 2940, 3109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(735, 3017, 3098);

                return c == '\n' || (DynAbs.Tracing.TraceSender.Expression_False(735, 3024, 3046) || c == '\r') || (DynAbs.Tracing.TraceSender.Expression_False(735, 3024, 3063) || c == '\u0085') || (DynAbs.Tracing.TraceSender.Expression_False(735, 3024, 3080) || c == '\u2028') || (DynAbs.Tracing.TraceSender.Expression_False(735, 3024, 3097) || c == '\u2029');
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(735, 2940, 3109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(735, 2940, 3109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(735, 2940, 3109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TextUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(735, 354, 3116);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(735, 354, 3116);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(735, 354, 3116);
        }

    }
}
