// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Text;

namespace Roslyn.Utilities
{
    internal static class CommandLineUtilities
    {
        public static IEnumerable<string> SplitCommandLineIntoArguments(string commandLine, bool removeHashComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(312, 2389, 2610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2522, 2599);

                return f_312_2529_2598(commandLine, removeHashComments, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(312, 2389, 2610);

                System.Collections.Generic.IEnumerable<string>
                f_312_2529_2598(string
                commandLine, bool
                removeHashComments, out char?
                illegalChar)
                {
                    var return_v = SplitCommandLineIntoArguments(commandLine, removeHashComments, out illegalChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 2529, 2598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(312, 2389, 2610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(312, 2389, 2610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> SplitCommandLineIntoArguments(string commandLine, bool removeHashComments, out char? illegalChar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(312, 2622, 6401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2778, 2830);

                var
                builder = f_312_2792_2829(f_312_2810_2828(commandLine))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2844, 2874);

                var
                list = f_312_2855_2873()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2888, 2898);

                var
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2914, 2933);

                illegalChar = null;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 2947, 6362) || true) && (i < f_312_2958_2976(commandLine))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 2947, 6362);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3010, 3141) || true) && (i < f_312_3021_3039(commandLine) && (DynAbs.Tracing.TraceSender.Expression_True(312, 3017, 3076) && f_312_3043_3076(f_312_3061_3075(commandLine, i))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3010, 3141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3118, 3122);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3010, 3141);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(312, 3010, 3141);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(312, 3010, 3141);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3161, 3255) || true) && (i == f_312_3170_3188(commandLine))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3161, 3255);
                            DynAbs.Tracing.TraceSender.TraceBreak(312, 3230, 3236);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3161, 3255);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3275, 3389) || true) && (f_312_3279_3293(commandLine, i) == '#' && (DynAbs.Tracing.TraceSender.Expression_True(312, 3279, 3322) && removeHashComments))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3275, 3389);
                            DynAbs.Tracing.TraceSender.TraceBreak(312, 3364, 3370);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3275, 3389);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3409, 3428);

                        var
                        quoteCount = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3446, 3465);

                        builder.Length = 0;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3483, 5820) || true) && (i < f_312_3494_3512(commandLine) && (DynAbs.Tracing.TraceSender.Expression_True(312, 3490, 3577) && (!f_312_3518_3551(f_312_3536_3550(commandLine, i)) || (DynAbs.Tracing.TraceSender.Expression_False(312, 3517, 3576) || (quoteCount % 2 != 0)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3483, 5820);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3619, 3648);

                                var
                                current = f_312_3633_3647(commandLine, i)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3670, 5801);

                                switch (current)
                                {

                                    case '\\':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3670, 5801);
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3810, 3829);

                                            var
                                            slashCount = 0
                                            ;
                                            {
                                                try
                                                {
                                                    do

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3863, 4155);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3938, 3969);

                                                        f_312_3938_3968(builder, f_312_3953_3967(commandLine, i));
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4007, 4011);

                                                        i++;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4049, 4062);

                                                        slashCount++;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3863, 4155);
                                                    }
                                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 3863, 4155) || true) && (i < f_312_4109_4127(commandLine) && (DynAbs.Tracing.TraceSender.Expression_True(312, 4105, 4153) && f_312_4131_4145(commandLine, i) == '\\'))
                                                    );
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(312, 3863, 4155);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(312, 3863, 4155);
                                                }
                                            }
                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4292, 4459) || true) && (i >= f_312_4301_4319(commandLine) || (DynAbs.Tracing.TraceSender.Expression_False(312, 4296, 4344) || f_312_4323_4337(commandLine, i) != '"'))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 4292, 4459);
                                                DynAbs.Tracing.TraceSender.TraceBreak(312, 4418, 4424);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(312, 4292, 4459);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4664, 4809) || true) && (slashCount % 2 == 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 4664, 4809);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4761, 4774);

                                                quoteCount++;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(312, 4664, 4809);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4845, 4865);

                                            f_312_4845_4864(
                                                                            builder, '"');
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 4899, 4903);

                                            i++;
                                            DynAbs.Tracing.TraceSender.TraceBreak(312, 4937, 4943);

                                            break;
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3670, 5801);

                                    case '"':
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3670, 5801);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5041, 5065);

                                        f_312_5041_5064(builder, current);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5095, 5108);

                                        quoteCount++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5138, 5142);

                                        i++;
                                        DynAbs.Tracing.TraceSender.TraceBreak(312, 5172, 5178);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3670, 5801);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 3670, 5801);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5244, 5706) || true) && ((current >= 0x1 && (DynAbs.Tracing.TraceSender.Expression_True(312, 5249, 5282) && current <= 0x1f)) || (DynAbs.Tracing.TraceSender.Expression_False(312, 5248, 5301) || current == '|'))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 5244, 5706);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5367, 5521) || true) && (illegalChar == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 5367, 5521);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5464, 5486);

                                                illegalChar = current;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(312, 5367, 5521);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 5244, 5706);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 5244, 5706);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5651, 5675);

                                            f_312_5651_5674(builder, current);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 5244, 5706);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5738, 5742);

                                        i++;
                                        DynAbs.Tracing.TraceSender.TraceBreak(312, 5772, 5778);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3670, 5801);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(312, 3483, 5820);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(312, 3483, 5820);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(312, 3483, 5820);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 5979, 6215) || true) && (quoteCount == 2 && (DynAbs.Tracing.TraceSender.Expression_True(312, 5983, 6019) && f_312_6002_6012(builder, 0) == '"') && (DynAbs.Tracing.TraceSender.Expression_True(312, 5983, 6057) && f_312_6023_6050(builder, f_312_6031_6045(builder) - 1) == '"'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 5979, 6215);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 6099, 6128);

                            f_312_6099_6127(builder, 0, length: 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 6150, 6196);

                            f_312_6150_6195(builder, f_312_6165_6179(builder) - 1, length: 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 5979, 6215);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 6235, 6347) || true) && (f_312_6239_6253(builder) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(312, 6235, 6347);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 6299, 6328);

                            f_312_6299_6327(list, f_312_6308_6326(builder));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(312, 6235, 6347);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(312, 2947, 6362);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(312, 2947, 6362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(312, 2947, 6362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(312, 6378, 6390);

                return list;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(312, 2622, 6401);

                int
                f_312_2810_2828(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 2810, 2828);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_2792_2829(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 2792, 2829);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_312_2855_2873()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 2855, 2873);
                    return return_v;
                }


                int
                f_312_2958_2976(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 2958, 2976);
                    return return_v;
                }


                int
                f_312_3021_3039(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3021, 3039);
                    return return_v;
                }


                char
                f_312_3061_3075(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3061, 3075);
                    return return_v;
                }


                bool
                f_312_3043_3076(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 3043, 3076);
                    return return_v;
                }


                int
                f_312_3170_3188(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3170, 3188);
                    return return_v;
                }


                char
                f_312_3279_3293(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3279, 3293);
                    return return_v;
                }


                int
                f_312_3494_3512(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3494, 3512);
                    return return_v;
                }


                char
                f_312_3536_3550(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3536, 3550);
                    return return_v;
                }


                bool
                f_312_3518_3551(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 3518, 3551);
                    return return_v;
                }


                char
                f_312_3633_3647(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3633, 3647);
                    return return_v;
                }


                char
                f_312_3953_3967(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 3953, 3967);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_3938_3968(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 3938, 3968);
                    return return_v;
                }


                int
                f_312_4109_4127(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 4109, 4127);
                    return return_v;
                }


                char
                f_312_4131_4145(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 4131, 4145);
                    return return_v;
                }


                int
                f_312_4301_4319(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 4301, 4319);
                    return return_v;
                }


                char
                f_312_4323_4337(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 4323, 4337);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_4845_4864(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 4845, 4864);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_5041_5064(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 5041, 5064);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_5651_5674(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 5651, 5674);
                    return return_v;
                }


                char
                f_312_6002_6012(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 6002, 6012);
                    return return_v;
                }


                int
                f_312_6031_6045(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 6031, 6045);
                    return return_v;
                }


                char
                f_312_6023_6050(System.Text.StringBuilder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 6023, 6050);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_6099_6127(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 6099, 6127);
                    return return_v;
                }


                int
                f_312_6165_6179(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 6165, 6179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_312_6150_6195(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length: length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 6150, 6195);
                    return return_v;
                }


                int
                f_312_6239_6253(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(312, 6239, 6253);
                    return return_v;
                }


                string
                f_312_6308_6326(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 6308, 6326);
                    return return_v;
                }


                int
                f_312_6299_6327(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(312, 6299, 6327);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(312, 2622, 6401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(312, 2622, 6401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandLineUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(312, 300, 6408);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(312, 300, 6408);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(312, 300, 6408);
        }

    }
}
