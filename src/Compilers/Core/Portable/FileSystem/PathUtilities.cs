// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace Roslyn.Utilities
{
    internal static class PathUtilities
    {
        internal static readonly char DirectorySeparatorChar;

        internal const char
        AltDirectorySeparatorChar = '/'
        ;

        internal const string
        ParentRelativeDirectory = ".."
        ;

        internal const string
        ThisDirectory = "."
        ;

        internal static readonly string DirectorySeparatorStr;

        internal const char
        VolumeSeparatorChar = ':'
        ;

        internal static bool IsUnixLikePlatform
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 1312, 1341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1315, 1341);
                    return f_302_1315_1341(); 
                    DynAbs.Tracing.TraceSender.TraceExitMethod(302, 1312, 1341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 1312, 1341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 1312, 1341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsDirectorySeparator(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 1568, 1632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1571, 1632);
                return c == DirectorySeparatorChar || (DynAbs.Tracing.TraceSender.Expression_False(302, 1571, 1632) || c == AltDirectorySeparatorChar); DynAbs.Tracing.TraceSender.TraceExitMethod(302, 1568, 1632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 1568, 1632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 1568, 1632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAnyDirectorySeparator(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 1827, 1851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1830, 1851);
                return c == '\\' || (DynAbs.Tracing.TraceSender.Expression_False(302, 1830, 1851) || c == '/'); DynAbs.Tracing.TraceSender.TraceExitMethod(302, 1827, 1851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 1827, 1851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 1827, 1851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string TrimTrailingSeparators(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 2129, 2552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2207, 2236);

                int
                lastSeparator = f_302_2227_2235(s)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2250, 2388) || true) && (lastSeparator > 0 && (DynAbs.Tracing.TraceSender.Expression_True(302, 2257, 2320) && f_302_2278_2320(f_302_2299_2319(s, lastSeparator - 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 2250, 2388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2354, 2373);

                        lastSeparator -= 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 2250, 2388);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 2250, 2388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 2250, 2388);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2404, 2516) || true) && (lastSeparator != f_302_2425_2433(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 2404, 2516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2467, 2501);

                    s = f_302_2471_2500(s, 0, lastSeparator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 2404, 2516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2532, 2541);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 2129, 2552);

                int
                f_302_2227_2235(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2227, 2235);
                    return return_v;
                }


                char
                f_302_2299_2319(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2299, 2319);
                    return return_v;
                }


                bool
                f_302_2278_2320(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 2278, 2320);
                    return return_v;
                }


                int
                f_302_2425_2433(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2425, 2433);
                    return return_v;
                }


                string
                f_302_2471_2500(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 2471, 2500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 2129, 2552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 2129, 2552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string EnsureTrailingSeparator(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 2673, 3489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2752, 2871) || true) && (f_302_2756_2764(s) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(302, 2756, 2813) || f_302_2773_2813(f_302_2797_2812(s, f_302_2799_2807(s) - 1))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 2752, 2871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2847, 2856);

                    return s;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 2752, 2871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 2963, 2999);

                bool
                hasSlash = f_302_2979_2993(s, '/') >= 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3013, 3054);

                bool
                hasBackslash = f_302_3033_3048(s, '\\') >= 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3068, 3478) || true) && (hasSlash && (DynAbs.Tracing.TraceSender.Expression_True(302, 3072, 3097) && !hasBackslash))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 3068, 3478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3131, 3146);

                    return s + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ('/').ToString(), 302, 3142, 3145);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 3068, 3478);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 3068, 3478);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3180, 3478) || true) && (!hasSlash && (DynAbs.Tracing.TraceSender.Expression_True(302, 3184, 3209) && hasBackslash))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 3180, 3478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3243, 3259);

                        return s + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ('\\').ToString(), 302, 3254, 3258);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 3180, 3478);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 3180, 3478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3429, 3463);

                        return s + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (DirectorySeparatorChar).ToString(), 302, 3440, 3462);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 3180, 3478);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 3068, 3478);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 2673, 3489);

                int
                f_302_2756_2764(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2756, 2764);
                    return return_v;
                }


                int
                f_302_2799_2807(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2799, 2807);
                    return return_v;
                }


                char
                f_302_2797_2812(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 2797, 2812);
                    return return_v;
                }


                bool
                f_302_2773_2813(char
                c)
                {
                    var return_v = IsAnyDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 2773, 2813);
                    return return_v;
                }


                int
                f_302_2979_2993(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 2979, 2993);
                    return return_v;
                }


                int
                f_302_3033_3048(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 3033, 3048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 2673, 3489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 2673, 3489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetExtension(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 3501, 3627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3572, 3616);

                return f_302_3579_3615(path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 3501, 3627);

                string?
                f_302_3579_3615(string
                path)
                {
                    var return_v = FileNameUtilities.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 3579, 3615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 3501, 3627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 3501, 3627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ChangeExtension(string path, string? extension)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 3639, 3801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3732, 3790);

                return f_302_3739_3789(path, extension);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 3639, 3801);

                string?
                f_302_3739_3789(string
                path, string?
                extension)
                {
                    var return_v = FileNameUtilities.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 3739, 3789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 3639, 3801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 3639, 3801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string RemoveExtension(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 3813, 3962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 3887, 3951);

                return f_302_3894_3950(path, extension: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 3813, 3962);

                string?
                f_302_3894_3950(string
                path, string?
                extension)
                {
                    var return_v = FileNameUtilities.ChangeExtension(path, extension: extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 3894, 3950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 3813, 3962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 3813, 3962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        public static string? GetFileName(string? path, bool includeExtension = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 3974, 4207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4135, 4196);

                return f_302_4142_4195(path, includeExtension);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 3974, 4207);

                string?
                f_302_4142_4195(string?
                path, bool
                includeExtension)
                {
                    var return_v = FileNameUtilities.GetFileName(path, includeExtension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 4142, 4195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 3974, 4207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 3974, 4207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? GetDirectoryName(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 4550, 4688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4627, 4677);

                return f_302_4634_4676(path, f_302_4657_4675());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 4550, 4688);

                bool
                f_302_4657_4675()
                {
                    var return_v = IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 4657, 4675);
                    return return_v;
                }


                string?
                f_302_4634_4676(string?
                path, bool
                isUnixLike)
                {
                    var return_v = GetDirectoryName(path, isUnixLike);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 4634, 4676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 4550, 4688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 4550, 4688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? GetDirectoryName(string? path, bool isUnixLike)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 4700, 5587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4796, 5548) || true) && (path != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 4796, 5548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4846, 4900);

                    var
                    rootLength = f_302_4863_4899(f_302_4863_4892(path, isUnixLike))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4918, 5533) || true) && (f_302_4922_4933(path) > rootLength)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 4918, 5533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 4988, 5008);

                        var
                        i = f_302_4996_5007(path)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5030, 5462) || true) && (i > rootLength)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 5030, 5462);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5101, 5105);

                                i--;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5131, 5439) || true) && (f_302_5135_5164(f_302_5156_5163(path, i)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 5131, 5439);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5222, 5374) || true) && (i > 0 && (DynAbs.Tracing.TraceSender.Expression_True(302, 5226, 5268) && f_302_5235_5268(f_302_5256_5267(path, i - 1))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 5222, 5374);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5334, 5343);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 5222, 5374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(302, 5406, 5412);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 5131, 5439);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 5030, 5462);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 5030, 5462);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(302, 5030, 5462);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5486, 5514);

                        return f_302_5493_5513(path, 0, i);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 4918, 5533);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 4796, 5548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5564, 5576);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 4700, 5587);

                string?
                f_302_4863_4892(string
                path, bool
                isUnixLike)
                {
                    var return_v = GetPathRoot(path, isUnixLike);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 4863, 4892);
                    return return_v;
                }


                int
                f_302_4863_4899(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 4863, 4899);
                    return return_v;
                }


                int
                f_302_4922_4933(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 4922, 4933);
                    return return_v;
                }


                int
                f_302_4996_5007(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 4996, 5007);
                    return return_v;
                }


                char
                f_302_5156_5163(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 5156, 5163);
                    return return_v;
                }


                bool
                f_302_5135_5164(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5135, 5164);
                    return return_v;
                }


                char
                f_302_5256_5267(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 5256, 5267);
                    return return_v;
                }


                bool
                f_302_5235_5268(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5235, 5268);
                    return return_v;
                }


                string
                f_302_5493_5513(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5493, 5513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 4700, 5587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 4700, 5587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSameDirectoryOrChildOf(string child, string parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 5599, 6209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5698, 5748);

                parent = f_302_5707_5747(parent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5762, 5791);

                string?
                currentChild = child
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5805, 6169) || true) && (currentChild != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 5805, 6169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5866, 5928);

                        currentChild = f_302_5881_5927(currentChild);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 5948, 6088) || true) && (f_302_5952_6015(currentChild, parent, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 5948, 6088);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6057, 6069);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 5948, 6088);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6108, 6154);

                        currentChild = f_302_6123_6153(currentChild);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 5805, 6169);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 5805, 6169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 5805, 6169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6185, 6198);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 5599, 6209);

                string
                f_302_5707_5747(string
                path)
                {
                    var return_v = RemoveTrailingDirectorySeparator(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5707, 5747);
                    return return_v;
                }


                string
                f_302_5881_5927(string
                path)
                {
                    var return_v = RemoveTrailingDirectorySeparator(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5881, 5927);
                    return return_v;
                }


                bool
                f_302_5952_6015(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 5952, 6015);
                    return return_v;
                }


                string?
                f_302_6123_6153(string
                path)
                {
                    var return_v = GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 6123, 6153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 5599, 6209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 5599, 6209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        public static string? GetPathRoot(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 6313, 6500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6444, 6489);

                return f_302_6451_6488(path, f_302_6469_6487());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 6313, 6500);

                bool
                f_302_6469_6487()
                {
                    var return_v = IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 6469, 6487);
                    return return_v;
                }


                string?
                f_302_6451_6488(string?
                path, bool
                isUnixLike)
                {
                    var return_v = GetPathRoot(path, isUnixLike);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 6451, 6488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 6313, 6500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 6313, 6500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "path")]
        private static string? GetPathRoot(string? path, bool isUnixLike)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 6512, 6947);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6661, 6738) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 6661, 6738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6711, 6723);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 6661, 6738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6754, 6936) || true) && (isUnixLike)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 6754, 6936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6802, 6827);

                    return f_302_6809_6826(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 6754, 6936);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 6754, 6936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 6893, 6921);

                    return f_302_6900_6920(path);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 6754, 6936);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 6512, 6947);

                string
                f_302_6809_6826(string
                path)
                {
                    var return_v = GetUnixRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 6809, 6826);
                    return return_v;
                }


                string
                f_302_6900_6920(string
                path)
                {
                    var return_v = GetWindowsRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 6900, 6920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 6512, 6947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 6512, 6947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetWindowsRoot(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 6959, 9402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7057, 7082);

                int
                length = f_302_7070_7081(path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7096, 9391) || true) && (length >= 1 && (DynAbs.Tracing.TraceSender.Expression_True(302, 7100, 7144) && f_302_7115_7144(f_302_7136_7143(path, 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 7096, 9391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7178, 7501) || true) && (length < 2 || (DynAbs.Tracing.TraceSender.Expression_False(302, 7182, 7226) || !f_302_7197_7226(f_302_7218_7225(path, 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 7178, 7501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7454, 7482);

                        return f_302_7461_7481(path, 0, 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 7178, 7501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7581, 7591);

                    int
                    i = 2
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7609, 7657);

                    i = f_302_7613_7656(path, length, i);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7829, 7855);

                    bool
                    hitSeparator = false
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7873, 8970) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 7873, 8970);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 7926, 8154) || true) && (i == length)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 7926, 8154);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8119, 8131);

                                return path;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 7926, 8154);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8178, 8408) || true) && (!f_302_8183_8212(f_302_8204_8211(path, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 8178, 8408);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8346, 8350);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8376, 8385);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 8178, 8408);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8432, 8806) || true) && (!hitSeparator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 8432, 8806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8654, 8674);

                                hitSeparator = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8700, 8748);

                                i = f_302_8704_8747(path, length, i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8774, 8783);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 8432, 8806);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 8923, 8951);

                            return f_302_8930_8950(path, 0, i);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 7873, 8970);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 7873, 8970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(302, 7873, 8970);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 7096, 9391);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 7096, 9391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9004, 9391) || true) && (length >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(302, 9008, 9053) && f_302_9023_9030(path, 1) == VolumeSeparatorChar))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 9004, 9391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9126, 9266);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(302, 9133, 9177) || ((length >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(302, 9133, 9177) && f_302_9148_9177(f_302_9169_9176(path, 2))) && DynAbs.Tracing.TraceSender.Conditional_F2(302, 9201, 9221)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 9245, 9265))) ? f_302_9201_9221(path, 0, 3) : f_302_9245_9265(path, 0, 2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 9004, 9391);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 9004, 9391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9366, 9376);

                        return "";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 9004, 9391);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 7096, 9391);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 6959, 9402);

                int
                f_302_7070_7081(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 7070, 7081);
                    return return_v;
                }


                char
                f_302_7136_7143(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 7136, 7143);
                    return return_v;
                }


                bool
                f_302_7115_7144(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 7115, 7144);
                    return return_v;
                }


                char
                f_302_7218_7225(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 7218, 7225);
                    return return_v;
                }


                bool
                f_302_7197_7226(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 7197, 7226);
                    return return_v;
                }


                string
                f_302_7461_7481(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 7461, 7481);
                    return return_v;
                }


                int
                f_302_7613_7656(string
                path, int
                length, int
                i)
                {
                    var return_v = ConsumeDirectorySeparators(path, length, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 7613, 7656);
                    return return_v;
                }


                char
                f_302_8204_8211(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 8204, 8211);
                    return return_v;
                }


                bool
                f_302_8183_8212(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 8183, 8212);
                    return return_v;
                }


                int
                f_302_8704_8747(string
                path, int
                length, int
                i)
                {
                    var return_v = ConsumeDirectorySeparators(path, length, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 8704, 8747);
                    return return_v;
                }


                string
                f_302_8930_8950(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 8930, 8950);
                    return return_v;
                }


                char
                f_302_9023_9030(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 9023, 9030);
                    return return_v;
                }


                char
                f_302_9169_9176(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 9169, 9176);
                    return return_v;
                }


                bool
                f_302_9148_9177(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9148, 9177);
                    return return_v;
                }


                string
                f_302_9201_9221(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9201, 9221);
                    return return_v;
                }


                string
                f_302_9245_9265(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9245, 9265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 6959, 9402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 6959, 9402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int ConsumeDirectorySeparators(string path, int length, int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 9414, 9655);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9516, 9619) || true) && (i < length && (DynAbs.Tracing.TraceSender.Expression_True(302, 9523, 9566) && f_302_9537_9566(f_302_9558_9565(path, i))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 9516, 9619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9600, 9604);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 9516, 9619);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 9516, 9619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 9516, 9619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9635, 9644);

                return i;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 9414, 9655);

                char
                f_302_9558_9565(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 9558, 9565);
                    return return_v;
                }


                bool
                f_302_9537_9566(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9537, 9566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 9414, 9655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 9414, 9655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetUnixRoot(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 9667, 9959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 9830, 9948);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(302, 9837, 9885) || ((f_302_9837_9848(path) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(302, 9837, 9885) && f_302_9856_9885(f_302_9877_9884(path, 0))) && DynAbs.Tracing.TraceSender.Conditional_F2(302, 9905, 9925)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 9945, 9947))) ? f_302_9905_9925(path, 0, 1) : "";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 9667, 9959);

                int
                f_302_9837_9848(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 9837, 9848);
                    return return_v;
                }


                char
                f_302_9877_9884(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 9877, 9884);
                    return return_v;
                }


                bool
                f_302_9856_9885(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9856, 9885);
                    return return_v;
                }


                string
                f_302_9905_9925(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 9905, 9925);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 9667, 9959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 9667, 9959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static PathKind GetPathKind(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 10084, 11709);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10157, 10269) || true) && (f_302_10161_10198(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10157, 10269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10232, 10254);

                    return PathKind.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10157, 10269);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10376, 10470) || true) && (f_302_10380_10396(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10376, 10470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10430, 10455);

                    return PathKind.Absolute;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10376, 10470);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10570, 11078) || true) && (f_302_10574_10585(path) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(302, 10574, 10607) && f_302_10593_10600(path, 0) == '.'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10570, 11078);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10641, 10798) || true) && (f_302_10645_10656(path) == 1 || (DynAbs.Tracing.TraceSender.Expression_False(302, 10645, 10694) || f_302_10665_10694(f_302_10686_10693(path, 1))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10641, 10798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10736, 10779);

                        return PathKind.RelativeToCurrentDirectory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10641, 10798);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10818, 11063) || true) && (f_302_10822_10829(path, 1) == '.')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10818, 11063);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10878, 11044) || true) && (f_302_10882_10893(path) == 2 || (DynAbs.Tracing.TraceSender.Expression_False(302, 10882, 10931) || f_302_10902_10931(f_302_10923_10930(path, 2))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 10878, 11044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 10981, 11021);

                            return PathKind.RelativeToCurrentParent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10878, 11044);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10818, 11063);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 10570, 11078);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11094, 11631) || true) && (f_302_11098_11117_M(!IsUnixLikePlatform))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 11094, 11631);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11202, 11354) || true) && (f_302_11206_11217(path) >= 1 && (DynAbs.Tracing.TraceSender.Expression_True(302, 11206, 11255) && f_302_11226_11255(f_302_11247_11254(path, 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 11202, 11354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11297, 11335);

                        return PathKind.RelativeToCurrentRoot;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 11202, 11354);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11404, 11616) || true) && (f_302_11408_11419(path) >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(302, 11408, 11458) && f_302_11428_11435(path, 1) == VolumeSeparatorChar) && (DynAbs.Tracing.TraceSender.Expression_True(302, 11408, 11514) && (f_302_11463_11474(path) <= 2 || (DynAbs.Tracing.TraceSender.Expression_False(302, 11463, 11513) || !f_302_11484_11513(f_302_11505_11512(path, 2))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 11404, 11616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11556, 11597);

                        return PathKind.RelativeToDriveDirectory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 11404, 11616);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 11094, 11631);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11673, 11698);

                return PathKind.Relative;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 10084, 11709);

                bool
                f_302_10161_10198(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 10161, 10198);
                    return return_v;
                }


                bool
                f_302_10380_10396(string
                path)
                {
                    var return_v = IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 10380, 10396);
                    return return_v;
                }


                int
                f_302_10574_10585(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10574, 10585);
                    return return_v;
                }


                char
                f_302_10593_10600(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10593, 10600);
                    return return_v;
                }


                int
                f_302_10645_10656(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10645, 10656);
                    return return_v;
                }


                char
                f_302_10686_10693(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10686, 10693);
                    return return_v;
                }


                bool
                f_302_10665_10694(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 10665, 10694);
                    return return_v;
                }


                char
                f_302_10822_10829(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10822, 10829);
                    return return_v;
                }


                int
                f_302_10882_10893(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10882, 10893);
                    return return_v;
                }


                char
                f_302_10923_10930(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 10923, 10930);
                    return return_v;
                }


                bool
                f_302_10902_10931(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 10902, 10931);
                    return return_v;
                }


                bool
                f_302_11098_11117_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11098, 11117);
                    return return_v;
                }


                int
                f_302_11206_11217(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11206, 11217);
                    return return_v;
                }


                char
                f_302_11247_11254(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11247, 11254);
                    return return_v;
                }


                bool
                f_302_11226_11255(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 11226, 11255);
                    return return_v;
                }


                int
                f_302_11408_11419(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11408, 11419);
                    return return_v;
                }


                char
                f_302_11428_11435(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11428, 11435);
                    return return_v;
                }


                int
                f_302_11463_11474(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11463, 11474);
                    return return_v;
                }


                char
                f_302_11505_11512(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 11505, 11512);
                    return return_v;
                }


                bool
                f_302_11484_11513(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 11484, 11513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 10084, 11709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 10084, 11709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAbsolute([NotNullWhen(true)] string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 11853, 12613);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 11941, 12039) || true) && (f_302_11945_11977(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 11941, 12039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12011, 12024);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 11941, 12039);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12055, 12167) || true) && (f_302_12059_12077())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 12055, 12167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12111, 12152);

                    return f_302_12118_12125(path, 0) == DirectorySeparatorChar;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 12055, 12167);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12205, 12358) || true) && (f_302_12209_12240(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 12205, 12358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12331, 12343);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 12205, 12358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12478, 12602);

                return f_302_12485_12496(path) >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(302, 12485, 12551) && f_302_12522_12551(f_302_12543_12550(path, 0))) && (DynAbs.Tracing.TraceSender.Expression_True(302, 12485, 12601) && f_302_12572_12601(f_302_12593_12600(path, 1)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 11853, 12613);

                bool
                f_302_11945_11977(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 11945, 11977);
                    return return_v;
                }


                bool
                f_302_12059_12077()
                {
                    var return_v = IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12059, 12077);
                    return return_v;
                }


                char
                f_302_12118_12125(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12118, 12125);
                    return return_v;
                }


                bool
                f_302_12209_12240(string
                path)
                {
                    var return_v = IsDriveRootedAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 12209, 12240);
                    return return_v;
                }


                int
                f_302_12485_12496(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12485, 12496);
                    return return_v;
                }


                char
                f_302_12543_12550(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12543, 12550);
                    return return_v;
                }


                bool
                f_302_12522_12551(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 12522, 12551);
                    return return_v;
                }


                char
                f_302_12593_12600(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12593, 12600);
                    return return_v;
                }


                bool
                f_302_12572_12601(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 12572, 12601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 11853, 12613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 11853, 12613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDriveRootedAbsolutePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 12771, 13004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12854, 12888);

                f_302_12854_12887(f_302_12867_12886_M(!IsUnixLikePlatform));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 12902, 12993);

                return f_302_12909_12920(path) >= 3 && (DynAbs.Tracing.TraceSender.Expression_True(302, 12909, 12959) && f_302_12929_12936(path, 1) == VolumeSeparatorChar) && (DynAbs.Tracing.TraceSender.Expression_True(302, 12909, 12992) && f_302_12963_12992(f_302_12984_12991(path, 2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 12771, 13004);

                bool
                f_302_12867_12886_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12867, 12886);
                    return return_v;
                }


                int
                f_302_12854_12887(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 12854, 12887);
                    return 0;
                }


                int
                f_302_12909_12920(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12909, 12920);
                    return return_v;
                }


                char
                f_302_12929_12936(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12929, 12936);
                    return return_v;
                }


                char
                f_302_12984_12991(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 12984, 12991);
                    return return_v;
                }


                bool
                f_302_12963_12992(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 12963, 12992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 12771, 13004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 12771, 13004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? CombineAbsoluteAndRelativePaths(string root, string relativePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 13634, 13871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 13746, 13777);

                f_302_13746_13776(f_302_13759_13775(root));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 13793, 13860);

                return f_302_13800_13859(root, relativePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 13634, 13871);

                bool
                f_302_13759_13775(string
                path)
                {
                    var return_v = IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 13759, 13775);
                    return return_v;
                }


                int
                f_302_13746_13776(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 13746, 13776);
                    return 0;
                }


                string?
                f_302_13800_13859(string
                root, string
                relativePath)
                {
                    var return_v = CombinePossiblyRelativeAndRelativePaths(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 13800, 13859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 13634, 13871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 13634, 13871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string? CombinePossiblyRelativeAndRelativePaths(string? root, string? relativePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 14328, 14963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14450, 14547) || true) && (f_302_14454_14486(root))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 14450, 14547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14520, 14532);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 14450, 14547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14563, 14887);

                switch (f_302_14571_14596(relativePath))
                {

                    case PathKind.Empty:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 14563, 14887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14672, 14684);

                        return root;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 14563, 14887);

                    case PathKind.Absolute:
                    case PathKind.RelativeToCurrentRoot:
                    case PathKind.RelativeToDriveDirectory:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 14563, 14887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14860, 14872);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 14563, 14887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 14903, 14952);

                return f_302_14910_14951(root, relativePath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 14328, 14963);

                bool
                f_302_14454_14486(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 14454, 14486);
                    return return_v;
                }


                Roslyn.Utilities.PathKind
                f_302_14571_14596(string?
                path)
                {
                    var return_v = GetPathKind(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 14571, 14596);
                    return return_v;
                }


                string
                f_302_14910_14951(string
                root, string?
                relativePath)
                {
                    var return_v = CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 14910, 14951);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 14328, 14963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 14328, 14963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string CombinePathsUnchecked(string root, string? relativePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 14975, 15402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15077, 15131);

                f_302_15077_15130(!f_302_15097_15129(root));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15147, 15178);

                char
                c = f_302_15156_15177(root, f_302_15161_15172(root) - 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15192, 15348) || true) && (!f_302_15197_15220(c) && (DynAbs.Tracing.TraceSender.Expression_True(302, 15196, 15248) && c != VolumeSeparatorChar))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 15192, 15348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15282, 15333);

                    return root + DirectorySeparatorStr + relativePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 15192, 15348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15364, 15391);

                return root + relativePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 14975, 15402);

                bool
                f_302_15097_15129(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 15097, 15129);
                    return return_v;
                }


                int
                f_302_15077_15130(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 15077, 15130);
                    return 0;
                }


                int
                f_302_15161_15172(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15161, 15172);
                    return return_v;
                }


                char
                f_302_15156_15177(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15156, 15177);
                    return return_v;
                }


                bool
                f_302_15197_15220(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 15197, 15220);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 14975, 15402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 14975, 15402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string RemoveTrailingDirectorySeparator(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 15414, 15752);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15506, 15741) || true) && (f_302_15510_15521(path) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(302, 15510, 15572) && f_302_15529_15572(f_302_15550_15571(path, f_302_15555_15566(path) - 1))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 15506, 15741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15606, 15648);

                    return f_302_15613_15647(path, 0, f_302_15631_15642(path) - 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 15506, 15741);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 15506, 15741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 15714, 15726);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 15506, 15741);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 15414, 15752);

                int
                f_302_15510_15521(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15510, 15521);
                    return return_v;
                }


                int
                f_302_15555_15566(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15555, 15566);
                    return return_v;
                }


                char
                f_302_15550_15571(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15550, 15571);
                    return return_v;
                }


                bool
                f_302_15529_15572(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 15529, 15572);
                    return return_v;
                }


                int
                f_302_15631_15642(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 15631, 15642);
                    return return_v;
                }


                string
                f_302_15613_15647(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 15613, 15647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 15414, 15752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 15414, 15752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsFilePath(string assemblyDisplayNameOrPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 15978, 16575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 16066, 16120);

                f_302_16066_16119(assemblyDisplayNameOrPath != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 16136, 16214);

                string?
                extension = f_302_16156_16213(assemblyDisplayNameOrPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 16228, 16564);

                return f_302_16235_16303(extension, ".dll", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(302, 16235, 16392) || f_302_16324_16392(extension, ".exe", StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(302, 16235, 16476) || f_302_16413_16470(assemblyDisplayNameOrPath, DirectorySeparatorChar) != -1
                ) || (DynAbs.Tracing.TraceSender.Expression_False(302, 16235, 16563) || f_302_16497_16557(assemblyDisplayNameOrPath, AltDirectorySeparatorChar) != -1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 15978, 16575);

                int
                f_302_16066_16119(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16066, 16119);
                    return 0;
                }


                string?
                f_302_16156_16213(string
                path)
                {
                    var return_v = FileNameUtilities.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16156, 16213);
                    return return_v;
                }


                bool
                f_302_16235_16303(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16235, 16303);
                    return return_v;
                }


                bool
                f_302_16324_16392(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16324, 16392);
                    return return_v;
                }


                int
                f_302_16413_16470(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16413, 16470);
                    return return_v;
                }


                int
                f_302_16497_16557(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 16497, 16557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 15978, 16575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 15978, 16575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsPathComponent(string? path, string component, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 17283, 18198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17397, 17489);

                var
                comparison = (DynAbs.Tracing.TraceSender.Conditional_F1(302, 17414, 17424) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(302, 17427, 17461)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 17464, 17488))) ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17503, 18158) || true) && (f_302_17507_17543_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(path, 302, 17507, 17543)?.IndexOf(component, comparison)) >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 17503, 18158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17582, 17668);

                    var
                    comparer = (DynAbs.Tracing.TraceSender.Conditional_F1(302, 17597, 17607) || ((ignoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(302, 17610, 17642)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 17645, 17667))) ? f_302_17610_17642() : f_302_17645_17667()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17688, 17702);

                    int
                    count = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17720, 17747);

                    string?
                    currentPath = path
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17765, 18143) || true) && (currentPath != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 17765, 18143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17833, 17876);

                            var
                            currentName = f_302_17851_17875(currentPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17898, 18026) || true) && (f_302_17902_17941(comparer, currentName, component))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 17898, 18026);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 17991, 18003);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 17898, 18026);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18050, 18094);

                            currentPath = f_302_18064_18093(currentPath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18116, 18124);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 17765, 18143);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 17765, 18143);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(302, 17765, 18143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 17503, 18158);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18174, 18187);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 17283, 18198);

                int?
                f_302_17507_17543_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 17507, 17543);
                    return return_v;
                }


                System.StringComparer
                f_302_17610_17642()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 17610, 17642);
                    return return_v;
                }


                System.StringComparer
                f_302_17645_17667()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 17645, 17667);
                    return return_v;
                }


                string?
                f_302_17851_17875(string
                path)
                {
                    var return_v = GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 17851, 17875);
                    return return_v;
                }


                bool
                f_302_17902_17941(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 17902, 17941);
                    return return_v;
                }


                string?
                f_302_18064_18093(string
                path)
                {
                    var return_v = GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 18064, 18093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 17283, 18198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 17283, 18198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string GetRelativePath(string directory, string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 18307, 20127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18403, 18438);

                string
                relativePath = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18454, 18588) || true) && (f_302_18458_18490(directory, fullPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 18454, 18588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18524, 18573);

                    return f_302_18531_18572(directory, fullPath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 18454, 18588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18604, 18653);

                var
                directoryPathParts = f_302_18629_18652(directory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18667, 18710);

                var
                fullPathParts = f_302_18687_18709(fullPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18726, 18854) || true) && (f_302_18730_18755(directoryPathParts) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(302, 18730, 18789) || f_302_18764_18784(fullPathParts) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 18726, 18854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18823, 18839);

                    return fullPath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 18726, 18854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18870, 18884);

                int
                index = 0
                ;
                try
                {
                    // find index where full path diverges from base path
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 18967, 19196) || true) && (index < f_302_18982_19007(directoryPathParts))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19009, 19016)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(302, 18967, 19196))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 18967, 19196);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19050, 19181) || true) && (!f_302_19055_19114(directoryPathParts[index], fullPathParts[index]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 19050, 19181);
                            DynAbs.Tracing.TraceSender.TraceBreak(302, 19156, 19162);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 19050, 19181);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 230);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19348, 19427) || true) && (index == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 19348, 19427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19396, 19412);

                    return fullPath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 19348, 19427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19527, 19582);

                var
                remainingParts = f_302_19548_19573(directoryPathParts) - index
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19596, 19845) || true) && (remainingParts > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 19596, 19845);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19661, 19666);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19652, 19830) || true) && (i < remainingParts)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19688, 19691)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(302, 19652, 19830))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 19652, 19830);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19733, 19811);

                            relativePath = relativePath + ParentRelativeDirectory + DirectorySeparatorStr;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 179);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 179);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 19596, 19845);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19922, 19931);

                    // add the rest of the full path parts
                    for (int
        i = index
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19913, 20080) || true) && (i < f_302_19937_19957(fullPathParts))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19959, 19962)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(302, 19913, 20080))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 19913, 20080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 19996, 20065);

                        relativePath = f_302_20011_20064(relativePath, fullPathParts[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 20096, 20116);

                return relativePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 18307, 20127);

                bool
                f_302_18458_18490(string
                parentPath, string
                childPath)
                {
                    var return_v = IsChildPath(parentPath, childPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 18458, 18490);
                    return return_v;
                }


                string
                f_302_18531_18572(string
                parentPath, string
                childPath)
                {
                    var return_v = GetRelativeChildPath(parentPath, childPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 18531, 18572);
                    return return_v;
                }


                string[]
                f_302_18629_18652(string
                path)
                {
                    var return_v = GetPathParts(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 18629, 18652);
                    return return_v;
                }


                string[]
                f_302_18687_18709(string
                path)
                {
                    var return_v = GetPathParts(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 18687, 18709);
                    return return_v;
                }


                int
                f_302_18730_18755(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 18730, 18755);
                    return return_v;
                }


                int
                f_302_18764_18784(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 18764, 18784);
                    return return_v;
                }


                int
                f_302_18982_19007(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 18982, 19007);
                    return return_v;
                }


                bool
                f_302_19055_19114(string
                path1, string
                path2)
                {
                    var return_v = PathsEqual(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 19055, 19114);
                    return return_v;
                }


                int
                f_302_19548_19573(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 19548, 19573);
                    return return_v;
                }


                int
                f_302_19937_19957(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 19937, 19957);
                    return return_v;
                }


                string
                f_302_20011_20064(string
                root, string
                relativePath)
                {
                    var return_v = CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20011, 20064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 18307, 20127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 18307, 20127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsChildPath(string parentPath, string childPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 20253, 20647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 20345, 20636);

                return f_302_20352_20369(parentPath) > 0
                && (DynAbs.Tracing.TraceSender.Expression_True(302, 20352, 20430) && f_302_20394_20410(childPath) > f_302_20413_20430(parentPath)) && (DynAbs.Tracing.TraceSender.Expression_True(302, 20352, 20503) && f_302_20451_20503(childPath, parentPath, f_302_20485_20502(parentPath))) && (DynAbs.Tracing.TraceSender.Expression_True(302, 20352, 20635) && (f_302_20525_20580(f_302_20546_20579(parentPath, f_302_20557_20574(parentPath) - 1)) || (DynAbs.Tracing.TraceSender.Expression_False(302, 20525, 20634) || f_302_20584_20634(f_302_20605_20633(childPath, f_302_20615_20632(parentPath))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 20253, 20647);

                int
                f_302_20352_20369(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20352, 20369);
                    return return_v;
                }


                int
                f_302_20394_20410(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20394, 20410);
                    return return_v;
                }


                int
                f_302_20413_20430(string
                this_param)
                {
                    var return_v = this_param.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20413, 20430);
                    return return_v;
                }


                int
                f_302_20485_20502(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20485, 20502);
                    return return_v;
                }


                bool
                f_302_20451_20503(string
                path1, string
                path2, int
                length)
                {
                    var return_v = PathsEqual(path1, path2, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20451, 20503);
                    return return_v;
                }


                int
                f_302_20557_20574(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20557, 20574);
                    return return_v;
                }


                char
                f_302_20546_20579(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20546, 20579);
                    return return_v;
                }


                bool
                f_302_20525_20580(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20525, 20580);
                    return return_v;
                }


                int
                f_302_20615_20632(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20615, 20632);
                    return return_v;
                }


                char
                f_302_20605_20633(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20605, 20633);
                    return return_v;
                }


                bool
                f_302_20584_20634(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20584, 20634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 20253, 20647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 20253, 20647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetRelativeChildPath(string parentPath, string childPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 20659, 21169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 20763, 20821);

                var
                relativePath = f_302_20782_20820(childPath, f_302_20802_20819(parentPath))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 20924, 21001);

                int
                start = f_302_20936_21000(relativePath, f_302_20977_20996(relativePath), 0)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21015, 21122) || true) && (start > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 21015, 21122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21062, 21107);

                    relativePath = f_302_21077_21106(relativePath, start);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 21015, 21122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21138, 21158);

                return relativePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 20659, 21169);

                int
                f_302_20802_20819(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20802, 20819);
                    return return_v;
                }


                string
                f_302_20782_20820(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20782, 20820);
                    return return_v;
                }


                int
                f_302_20977_20996(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 20977, 20996);
                    return return_v;
                }


                int
                f_302_20936_21000(string
                path, int
                length, int
                i)
                {
                    var return_v = ConsumeDirectorySeparators(path, length, i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 20936, 21000);
                    return return_v;
                }


                string
                f_302_21077_21106(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21077, 21106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 20659, 21169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 20659, 21169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_pathChars;

        private static string[] GetPathParts(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 21324, 21707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21398, 21438);

                var
                pathParts = f_302_21414_21437(path, s_pathChars)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21514, 21663) || true) && (f_302_21518_21551(pathParts, ThisDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 21514, 21663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21585, 21648);

                    pathParts = f_302_21597_21647(f_302_21597_21637(pathParts, s => s != ThisDirectory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 21514, 21663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21679, 21696);

                return pathParts;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 21324, 21707);

                string[]
                f_302_21414_21437(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21414, 21437);
                    return return_v;
                }


                bool
                f_302_21518_21551(string[]
                list, string
                item)
                {
                    var return_v = list.Contains<string>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21518, 21551);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_302_21597_21637(string[]
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21597, 21637);
                    return return_v;
                }


                string[]
                f_302_21597_21647(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21597, 21647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 21324, 21707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 21324, 21707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool PathsEqual(string path1, string path2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 21815, 21978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21897, 21967);

                return f_302_21904_21966(path1, path2, f_302_21929_21965(f_302_21938_21950(path1), f_302_21952_21964(path2)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 21815, 21978);

                int
                f_302_21938_21950(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 21938, 21950);
                    return return_v;
                }


                int
                f_302_21952_21964(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 21952, 21964);
                    return return_v;
                }


                int
                f_302_21929_21965(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21929, 21965);
                    return return_v;
                }


                bool
                f_302_21904_21966(string
                path1, string
                path2, int
                length)
                {
                    var return_v = PathsEqual(path1, path2, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 21904, 21966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 21815, 21978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 21815, 21978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool PathsEqual(string path1, string path2, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 22125, 22579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22220, 22332) || true) && (f_302_22224_22236(path1) < length || (DynAbs.Tracing.TraceSender.Expression_False(302, 22224, 22270) || f_302_22249_22261(path2) < length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 22220, 22332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22304, 22317);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 22220, 22332);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22357, 22362);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22348, 22540) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22376, 22379)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(302, 22348, 22540))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 22348, 22540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22413, 22525) || true) && (!f_302_22418_22451(f_302_22432_22440(path1, i), f_302_22442_22450(path2, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 22413, 22525);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22493, 22506);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 22413, 22525);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22556, 22568);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 22125, 22579);

                int
                f_302_22224_22236(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 22224, 22236);
                    return return_v;
                }


                int
                f_302_22249_22261(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 22249, 22261);
                    return return_v;
                }


                char
                f_302_22432_22440(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 22432, 22440);
                    return return_v;
                }


                char
                f_302_22442_22450(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 22442, 22450);
                    return return_v;
                }


                bool
                f_302_22418_22451(char
                x, char
                y)
                {
                    var return_v = PathCharEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 22418, 22451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 22125, 22579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 22125, 22579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool PathCharEqual(char x, char y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 22591, 22931);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22665, 22780) || true) && (f_302_22669_22692(x) && (DynAbs.Tracing.TraceSender.Expression_True(302, 22669, 22719) && f_302_22696_22719(y)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 22665, 22780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22753, 22765);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 22665, 22780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 22796, 22920);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(302, 22803, 22821) || ((f_302_22803_22821() && DynAbs.Tracing.TraceSender.Conditional_F2(302, 22841, 22847)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 22867, 22919))) ? x == y
                : f_302_22867_22891(x) == f_302_22895_22919(y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 22591, 22931);

                bool
                f_302_22669_22692(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 22669, 22692);
                    return return_v;
                }


                bool
                f_302_22696_22719(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 22696, 22719);
                    return return_v;
                }


                bool
                f_302_22803_22821()
                {
                    var return_v = IsUnixLikePlatform
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 22803, 22821);
                    return return_v;
                }


                char
                f_302_22867_22891(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 22867, 22891);
                    return return_v;
                }


                char
                f_302_22895_22919(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 22895, 22919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 22591, 22931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 22591, 22931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int PathHashCode(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 22943, 23382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23013, 23024);

                int
                hc = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23040, 23345) || true) && (path != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23040, 23345);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23090, 23330);
                        foreach (var ch in f_302_23109_23113_I(path))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23090, 23330);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23155, 23311) || true) && (!f_302_23160_23184(ch))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23155, 23311);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23234, 23288);

                                hc = f_302_23239_23287(f_302_23257_23282(ch), hc);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23155, 23311);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23090, 23330);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 241);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 241);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23040, 23345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23361, 23371);

                return hc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 22943, 23382);

                bool
                f_302_23160_23184(char
                c)
                {
                    var return_v = IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 23160, 23184);
                    return return_v;
                }


                char
                f_302_23257_23282(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 23257, 23282);
                    return return_v;
                }


                int
                f_302_23239_23287(char
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine((int)newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 23239, 23287);
                    return return_v;
                }


                string
                f_302_23109_23113_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 23109, 23113);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 22943, 23382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 22943, 23382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string NormalizePathPrefix(string filePath, ImmutableArray<KeyValuePair<string, string>> pathMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 23394, 25052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23530, 23623) || true) && (pathMap.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23530, 23623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23592, 23608);

                    return filePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23530, 23623);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23862, 25009);
                    foreach (var kv in f_302_23881_23888_I(pathMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23862, 25009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23922, 23945);

                        var
                        oldPrefix = kv.Key
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23963, 24002) || true) && (!(f_302_23969_23986_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(oldPrefix, 302, 23969, 23986)?.Length) > 0))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 23963, 24002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 23993, 24002);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23963, 24002);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24208, 24994) || true) && (f_302_24212_24268(filePath, oldPrefix, StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 24208, 24994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24310, 24343);

                            var
                            replacementPrefix = kv.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24412, 24487);

                            var
                            replacement = replacementPrefix + f_302_24450_24486(filePath, f_302_24469_24485(oldPrefix))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24602, 24654);

                            bool
                            hasSlash = f_302_24618_24648(replacementPrefix, '/') >= 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24676, 24733);

                            bool
                            hasBackslash = f_302_24696_24727(replacementPrefix, '\\') >= 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 24755, 24975);

                            return
                            (DynAbs.Tracing.TraceSender.Conditional_F1(302, 24787, 24814) || (((hasSlash && (DynAbs.Tracing.TraceSender.Expression_True(302, 24788, 24813) && !hasBackslash)) && DynAbs.Tracing.TraceSender.Conditional_F2(302, 24817, 24847)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 24875, 24974))) ? f_302_24817_24847(replacement, '\\', '/') : (DynAbs.Tracing.TraceSender.Conditional_F1(302, 24875, 24902) || (((hasBackslash && (DynAbs.Tracing.TraceSender.Expression_True(302, 24876, 24901) && !hasSlash)) && DynAbs.Tracing.TraceSender.Conditional_F2(302, 24905, 24935)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 24963, 24974))) ? f_302_24905_24935(replacement, '/', '\\') : replacement;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(302, 24208, 24994);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 23862, 25009);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(302, 1, 1148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(302, 1, 1148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 25025, 25041);

                return filePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 23394, 25052);

                int?
                f_302_23969_23986_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 23969, 23986);
                    return return_v;
                }


                bool
                f_302_24212_24268(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24212, 24268);
                    return return_v;
                }


                int
                f_302_24469_24485(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 24469, 24485);
                    return return_v;
                }


                string
                f_302_24450_24486(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24450, 24486);
                    return return_v;
                }


                int
                f_302_24618_24648(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24618, 24648);
                    return return_v;
                }


                int
                f_302_24696_24727(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24696, 24727);
                    return return_v;
                }


                string
                f_302_24817_24847(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24817, 24847);
                    return return_v;
                }


                string
                f_302_24905_24935(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 24905, 24935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_302_23881_23888_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 23881, 23888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 23394, 25052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 23394, 25052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidFilePath([NotNullWhen(true)] string? fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(302, 25892, 26933);
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 26025, 26139) || true) && (f_302_26029_26065(fullPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 26025, 26139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 26107, 26120);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 26025, 26139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 26313, 26351);

                    var
                    fileInfo = f_302_26328_26350(fullPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 26369, 26413);

                    return !f_302_26377_26412(f_302_26398_26411(fileInfo));
                }
                catch (Exception ex) when (
                    ex is ArgumentException || (DynAbs.Tracing.TraceSender.Expression_False(302, 26487, 26653) || ex is PathTooLongException) || (DynAbs.Tracing.TraceSender.Expression_False(302, 26487, 26791) || ex is NotSupportedException))        // fileName contains a colon (:) in the middle of the string.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(302, 26442, 26922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 26894, 26907);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(302, 26442, 26922);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(302, 25892, 26933);

                bool
                f_302_26029_26065(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 26029, 26065);
                    return return_v;
                }


                System.IO.FileInfo
                f_302_26328_26350(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 26328, 26350);
                    return return_v;
                }


                string
                f_302_26398_26411(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 26398, 26411);
                    return return_v;
                }


                bool
                f_302_26377_26412(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 26377, 26412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 25892, 26933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 25892, 26933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string NormalizeWithForwardSlash(string p)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 27462, 27539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27465, 27539);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(302, 27465, 27494) || ((DirectorySeparatorChar == '/' && DynAbs.Tracing.TraceSender.Conditional_F2(302, 27497, 27498)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 27501, 27539))) ? p : f_302_27501_27539(p, DirectorySeparatorChar, '/'); DynAbs.Tracing.TraceSender.TraceExitMethod(302, 27462, 27539);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 27462, 27539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 27462, 27539);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_302_27501_27539(string
            this_param, char
            oldChar, char
            newChar)
            {
                var return_v = this_param.Replace(oldChar, newChar);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 27501, 27539);
                return return_v;
            }

        }

        public static readonly IEqualityComparer<string> Comparer;
        private class PathComparer : IEqualityComparer<string?>
        {
            public bool Equals(string? x, string? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 27723, 28074);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27796, 27895) || true) && (x == null && (DynAbs.Tracing.TraceSender.Expression_True(302, 27800, 27822) && y == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 27796, 27895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27864, 27876);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 27796, 27895);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27915, 28015) || true) && (x == null || (DynAbs.Tracing.TraceSender.Expression_False(302, 27919, 27941) || y == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(302, 27915, 28015);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27983, 27996);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(302, 27915, 28015);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 28035, 28059);

                    return f_302_28042_28058(x, y);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(302, 27723, 28074);

                    bool
                    f_302_28042_28058(string
                    path1, string
                    path2)
                    {
                        var return_v = PathsEqual(path1, path2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 28042, 28058);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 27723, 28074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 27723, 28074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(string? s)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 28090, 28194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 28156, 28179);

                    return f_302_28163_28178(s);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(302, 28090, 28194);

                    int
                    f_302_28163_28178(string?
                    path)
                    {
                        var return_v = PathHashCode(path);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 28163, 28178);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 28090, 28194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 28090, 28194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PathComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(302, 27643, 28205);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(302, 27643, 28205);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 27643, 28205);
            }


            static PathComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(302, 27643, 28205);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(302, 27643, 28205);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 27643, 28205);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(302, 27643, 28205);
        }
        internal static class TestAccessor
        {
            internal static string? GetDirectoryName(string path, bool isUnixLike)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(302, 28364, 28415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 28367, 28415);
                    return f_302_28367_28415(path, isUnixLike); DynAbs.Tracing.TraceSender.TraceExitMethod(302, 28364, 28415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(302, 28364, 28415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 28364, 28415);
                }
                throw new System.Exception("Slicer error: unreachable code");

                string?
                f_302_28367_28415(string
                path, bool
                isUnixLike)
                {
                    var return_v = PathUtilities.GetDirectoryName(path, isUnixLike);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 28367, 28415);
                    return return_v;
                }

            }

            static TestAccessor()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(302, 28217, 28427);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(302, 28217, 28427);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 28217, 28427);
            }

        }

        static PathUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(302, 654, 28434);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 867, 931);
            DirectorySeparatorChar = (DynAbs.Tracing.TraceSender.Conditional_F1(302, 892, 918) || ((f_302_892_918() && DynAbs.Tracing.TraceSender.Conditional_F2(302, 921, 924)) || DynAbs.Tracing.TraceSender.Conditional_F3(302, 927, 931))) ? '/' : '\\'; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 962, 993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1026, 1056);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1089, 1108);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1151, 1205);
            DirectorySeparatorStr = f_302_1175_1205(DirectorySeparatorChar, 1);

            static string
f_302_1175_1205(char
c, int
count)
            {
                var return_v = new string(c, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 1175, 1205);
                return return_v;
            }

            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 1236, 1261);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 21212, 21311);
            s_pathChars = new char[] { VolumeSeparatorChar, DirectorySeparatorChar, AltDirectorySeparatorChar }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(302, 27601, 27630);
            Comparer = f_302_27612_27630(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(302, 654, 28434);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(302, 654, 28434);
        }


        static bool
        f_302_892_918()
        {
            var return_v = PlatformInformation.IsUnix;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 892, 918);
            return return_v;
        }


        static bool
        f_302_1315_1341()
        {
            var return_v = PlatformInformation.IsUnix;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(302, 1315, 1341);
            return return_v;
        }


        static Roslyn.Utilities.PathUtilities.PathComparer
        f_302_27612_27630()
        {
            var return_v = new Roslyn.Utilities.PathUtilities.PathComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(302, 27612, 27630);
            return return_v;
        }

    }
}
