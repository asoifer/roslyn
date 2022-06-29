// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal static class FileNameUtilities
    {
        internal const char
        DirectorySeparatorChar = '\\'
        ;

        internal const char
        AltDirectorySeparatorChar = '/'
        ;

        internal const char
        VolumeSeparatorChar = ':'
        ;

        internal static bool IsFileName([NotNullWhen(returnValue: true)] string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 1411, 1559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 1514, 1548);

                return f_330_1521_1542(path) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 1411, 1559);

                int
                f_330_1521_1542(string?
                path)
                {
                    var return_v = IndexOfFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 1521, 1542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 1411, 1559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 1411, 1559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int IndexOfExtension(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 1893, 2652);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 1967, 2042) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 1967, 2042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2017, 2027);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 1967, 2042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2058, 2083);

                int
                length = f_330_2071_2082(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2097, 2112);

                int
                i = length
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2128, 2615) || true) && (--i >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 2128, 2615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2177, 2194);

                        char
                        c = f_330_2186_2193(path, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2212, 2420) || true) && (c == '.')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 2212, 2420);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2266, 2367) || true) && (i != length - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 2266, 2367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2335, 2344);

                                return i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(330, 2266, 2367);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2391, 2401);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(330, 2212, 2420);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2440, 2600) || true) && (c == DirectorySeparatorChar || (DynAbs.Tracing.TraceSender.Expression_False(330, 2444, 2505) || c == AltDirectorySeparatorChar) || (DynAbs.Tracing.TraceSender.Expression_False(330, 2444, 2533) || c == VolumeSeparatorChar))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 2440, 2600);
                            DynAbs.Tracing.TraceSender.TraceBreak(330, 2575, 2581);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(330, 2440, 2600);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(330, 2128, 2615);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(330, 2128, 2615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(330, 2128, 2615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 2631, 2641);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 1893, 2652);

                int
                f_330_2071_2082(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 2071, 2082);
                    return return_v;
                }


                char
                f_330_2186_2193(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 2186, 2193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 1893, 2652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 1893, 2652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        internal static string? GetExtension(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 3000, 3346);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3134, 3211) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 3134, 3211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3184, 3196);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 3134, 3211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3227, 3262);

                int
                index = f_330_3239_3261(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3276, 3335);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(330, 3283, 3295) || (((index >= 0) && DynAbs.Tracing.TraceSender.Conditional_F2(330, 3298, 3319)) || DynAbs.Tracing.TraceSender.Conditional_F3(330, 3322, 3334))) ? f_330_3298_3319(path, index) : string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 3000, 3346);

                int
                f_330_3239_3261(string
                path)
                {
                    var return_v = IndexOfExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 3239, 3261);
                    return return_v;
                }


                string
                f_330_3298_3319(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 3298, 3319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 3000, 3346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 3000, 3346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        private static string? RemoveExtension(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 3586, 4198);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3722, 3799) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 3722, 3799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3772, 3784);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 3722, 3799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3815, 3850);

                int
                index = f_330_3827_3849(path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3864, 3959) || true) && (index >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 3864, 3959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 3912, 3944);

                    return f_330_3919_3943(path, 0, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 3864, 3959);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4017, 4159) || true) && (f_330_4021_4032(path) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(330, 4021, 4068) && f_330_4040_4061(path, f_330_4045_4056(path) - 1) == '.'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 4017, 4159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4102, 4144);

                    return f_330_4109_4143(path, 0, f_330_4127_4138(path) - 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 4017, 4159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4175, 4187);

                return path;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 3586, 4198);

                int
                f_330_3827_3849(string
                path)
                {
                    var return_v = IndexOfExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 3827, 3849);
                    return return_v;
                }


                string
                f_330_3919_3943(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 3919, 3943);
                    return return_v;
                }


                int
                f_330_4021_4032(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 4021, 4032);
                    return return_v;
                }


                int
                f_330_4045_4056(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 4045, 4056);
                    return return_v;
                }


                char
                f_330_4040_4061(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 4040, 4061);
                    return return_v;
                }


                int
                f_330_4127_4138(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 4127, 4138);
                    return return_v;
                }


                string
                f_330_4109_4143(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 4109, 4143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 3586, 4198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 3586, 4198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        internal static string? ChangeExtension(string? path, string? extension)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 4732, 5388);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4888, 4965) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 4888, 4965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4938, 4950);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 4888, 4965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 4981, 5030);

                var
                pathWithoutExtension = f_330_5008_5029(path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5044, 5162) || true) && (extension == null || (DynAbs.Tracing.TraceSender.Expression_False(330, 5048, 5085) || f_330_5069_5080(path) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 5044, 5162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5119, 5147);

                    return pathWithoutExtension;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 5044, 5162);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5178, 5321) || true) && (f_330_5182_5198(extension) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(330, 5182, 5226) || f_330_5207_5219(extension, 0) != '.'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 5178, 5321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5260, 5306);

                    return pathWithoutExtension + "." + extension;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 5178, 5321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5337, 5377);

                return pathWithoutExtension + extension;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 4732, 5388);

                string?
                f_330_5008_5029(string
                path)
                {
                    var return_v = RemoveExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 5008, 5029);
                    return return_v;
                }


                int
                f_330_5069_5080(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 5069, 5080);
                    return return_v;
                }


                int
                f_330_5182_5198(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 5182, 5198);
                    return return_v;
                }


                char
                f_330_5207_5219(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 5207, 5219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 4732, 5388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 4732, 5388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int IndexOfFileName(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 5575, 6072);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5649, 5724) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 5649, 5724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5699, 5709);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(330, 5649, 5724);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5749, 5768);

                    for (int
        i = f_330_5753_5764(path) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5740, 6036) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5778, 5781)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(330, 5740, 6036))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 5740, 6036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5815, 5833);

                        char
                        ch = f_330_5825_5832(path, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5851, 6021) || true) && (ch == DirectorySeparatorChar || (DynAbs.Tracing.TraceSender.Expression_False(330, 5855, 5918) || ch == AltDirectorySeparatorChar) || (DynAbs.Tracing.TraceSender.Expression_False(330, 5855, 5947) || ch == VolumeSeparatorChar))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(330, 5851, 6021);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 5989, 6002);

                            return i + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(330, 5851, 6021);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(330, 1, 297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(330, 1, 297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 6052, 6061);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 5575, 6072);

                int
                f_330_5753_5764(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 5753, 5764);
                    return return_v;
                }


                char
                f_330_5825_5832(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(330, 5825, 5832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 5575, 6072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 5575, 6072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        internal static string? GetFileName(string? path, bool includeExtension = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(330, 6300, 6683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 6463, 6505);

                int
                fileNameStart = f_330_6483_6504(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 6519, 6595);

                var
                fileName = (DynAbs.Tracing.TraceSender.Conditional_F1(330, 6534, 6554) || (((fileNameStart <= 0) && DynAbs.Tracing.TraceSender.Conditional_F2(330, 6557, 6561)) || DynAbs.Tracing.TraceSender.Conditional_F3(330, 6564, 6594))) ? path : f_330_6564_6594(path!, fileNameStart)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 6609, 6672);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(330, 6616, 6632) || ((includeExtension && DynAbs.Tracing.TraceSender.Conditional_F2(330, 6635, 6643)) || DynAbs.Tracing.TraceSender.Conditional_F3(330, 6646, 6671))) ? fileName : f_330_6646_6671(fileName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(330, 6300, 6683);

                int
                f_330_6483_6504(string?
                path)
                {
                    var return_v = IndexOfFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 6483, 6504);
                    return return_v;
                }


                string
                f_330_6564_6594(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 6564, 6594);
                    return return_v;
                }


                string?
                f_330_6646_6671(string?
                path)
                {
                    var return_v = RemoveExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(330, 6646, 6671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(330, 6300, 6683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 6300, 6683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FileNameUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(330, 744, 6690);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 820, 849);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 880, 911);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(330, 942, 967);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(330, 744, 6690);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(330, 744, 6690);
        }

    }
}
