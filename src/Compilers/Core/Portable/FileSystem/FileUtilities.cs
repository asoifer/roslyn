// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Roslyn.Utilities
{
    internal static class FileUtilities
    {
        internal static string? ResolveRelativePath(
                    string path,
                    string? basePath,
                    string? baseDirectory,
                    IEnumerable<string> searchPaths,
                    Func<string, bool> fileExists)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 1642, 3666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 1894, 1996);

                f_300_1894_1995(baseDirectory == null || (DynAbs.Tracing.TraceSender.Expression_False(300, 1907, 1951) || searchPaths != null) || (DynAbs.Tracing.TraceSender.Expression_False(300, 1907, 1994) || f_300_1955_1994(baseDirectory)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2010, 2050);

                f_300_2010_2049(searchPaths != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2064, 2103);

                f_300_2064_2102(fileExists != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2119, 2140);

                string?
                combinedPath
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2154, 2197);

                var
                kind = f_300_2165_2196(path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2211, 3272) || true) && (kind == PathKind.Relative)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 2211, 3272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2329, 2387);

                    baseDirectory = f_300_2345_2386(basePath, baseDirectory);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2405, 2781) || true) && (baseDirectory != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 2405, 2781);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2472, 2544);

                        combinedPath = f_300_2487_2543(baseDirectory, path);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2566, 2619);

                        f_300_2566_2618(f_300_2579_2617(combinedPath));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2641, 2762) || true) && (f_300_2645_2669(fileExists, combinedPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 2641, 2762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2719, 2739);

                            return combinedPath;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 2641, 2762);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 2405, 2781);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2839, 3225);
                        foreach (var searchPath in f_300_2866_2877_I(searchPaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 2839, 3225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 2919, 2988);

                            combinedPath = f_300_2934_2987(searchPath, path);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3010, 3063);

                            f_300_3010_3062(f_300_3023_3061(combinedPath));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3085, 3206) || true) && (f_300_3089_3113(fileExists, combinedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 3085, 3206);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3163, 3183);

                                return combinedPath;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(300, 3085, 3206);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 2839, 3225);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(300, 1, 387);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(300, 1, 387);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3245, 3257);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 2211, 3272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3288, 3360);

                combinedPath = f_300_3303_3359(kind, path, basePath, baseDirectory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3374, 3627) || true) && (combinedPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 3374, 3627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3432, 3485);

                    f_300_3432_3484(f_300_3445_3483(combinedPath));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3503, 3612) || true) && (f_300_3507_3531(fileExists, combinedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 3503, 3612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3573, 3593);

                        return combinedPath;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 3503, 3612);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 3374, 3627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3643, 3655);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 1642, 3666);

                bool
                f_300_1955_1994(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 1955, 1994);
                    return return_v;
                }


                int
                f_300_1894_1995(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 1894, 1995);
                    return 0;
                }


                int
                f_300_2010_2049(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2010, 2049);
                    return 0;
                }


                int
                f_300_2064_2102(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2064, 2102);
                    return 0;
                }


                Roslyn.Utilities.PathKind
                f_300_2165_2196(string
                path)
                {
                    var return_v = PathUtilities.GetPathKind(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2165, 2196);
                    return return_v;
                }


                string?
                f_300_2345_2386(string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = GetBaseDirectory(basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2345, 2386);
                    return return_v;
                }


                string
                f_300_2487_2543(string
                root, string
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2487, 2543);
                    return return_v;
                }


                bool
                f_300_2579_2617(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2579, 2617);
                    return return_v;
                }


                int
                f_300_2566_2618(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2566, 2618);
                    return 0;
                }


                bool
                f_300_2645_2669(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2645, 2669);
                    return return_v;
                }


                string
                f_300_2934_2987(string
                root, string
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2934, 2987);
                    return return_v;
                }


                bool
                f_300_3023_3061(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3023, 3061);
                    return return_v;
                }


                int
                f_300_3010_3062(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3010, 3062);
                    return 0;
                }


                bool
                f_300_3089_3113(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3089, 3113);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_300_2866_2877_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 2866, 2877);
                    return return_v;
                }


                string?
                f_300_3303_3359(Roslyn.Utilities.PathKind
                kind, string
                path, string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = ResolveRelativePath(kind, path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3303, 3359);
                    return return_v;
                }


                bool
                f_300_3445_3483(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3445, 3483);
                    return return_v;
                }


                int
                f_300_3432_3484(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3432, 3484);
                    return 0;
                }


                bool
                f_300_3507_3531(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3507, 3531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 1642, 3666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 1642, 3666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? ResolveRelativePath(string? path, string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 3678, 3848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3783, 3837);

                return f_300_3790_3836(path, null, baseDirectory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 3678, 3848);

                string?
                f_300_3790_3836(string?
                path, string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = ResolveRelativePath(path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3790, 3836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 3678, 3848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 3678, 3848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? ResolveRelativePath(string? path, string? basePath, string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 3860, 4178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 3983, 4062);

                f_300_3983_4061(baseDirectory == null || (DynAbs.Tracing.TraceSender.Expression_False(300, 3996, 4060) || f_300_4021_4060(baseDirectory)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4076, 4167);

                return f_300_4083_4166(f_300_4103_4134(path), path, basePath, baseDirectory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 3860, 4178);

                bool
                f_300_4021_4060(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4021, 4060);
                    return return_v;
                }


                int
                f_300_3983_4061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 3983, 4061);
                    return 0;
                }


                Roslyn.Utilities.PathKind
                f_300_4103_4134(string?
                path)
                {
                    var return_v = PathUtilities.GetPathKind(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4103, 4134);
                    return return_v;
                }


                string?
                f_300_4083_4166(Roslyn.Utilities.PathKind
                kind, string?
                path, string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = ResolveRelativePath(kind, path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4083, 4166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 3860, 4178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 3860, 4178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? ResolveRelativePath(PathKind kind, string? path, string? basePath, string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 4190, 7305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4327, 4381);

                f_300_4327_4380(f_300_4340_4371(path) == kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4397, 7294);

                switch (kind)
                {

                    case PathKind.Empty:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4485, 4497);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.Relative:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4562, 4620);

                        baseDirectory = f_300_4578_4619(basePath, baseDirectory);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4642, 4752) || true) && (baseDirectory == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4642, 4752);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4717, 4729);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4642, 4752);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 4872, 4936);

                        return f_300_4879_4935(baseDirectory, path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.RelativeToCurrentDirectory:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5019, 5077);

                        baseDirectory = f_300_5035_5076(basePath, baseDirectory);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5099, 5209) || true) && (baseDirectory == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 5099, 5209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5174, 5186);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 5099, 5209);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5233, 5579) || true) && (f_300_5237_5249(path!) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 5233, 5579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5336, 5357);

                            return baseDirectory;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 5233, 5579);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 5233, 5579);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5492, 5556);

                            return f_300_5499_5555(baseDirectory, path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 5233, 5579);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.RelativeToCurrentParent:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5659, 5717);

                        baseDirectory = f_300_5675_5716(basePath, baseDirectory);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5739, 5849) || true) && (baseDirectory == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 5739, 5849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5814, 5826);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 5739, 5849);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 5902, 5966);

                        return f_300_5909_5965(baseDirectory, path);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.RelativeToCurrentRoot:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6044, 6061);

                        string?
                        baseRoot
                        = default(string?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6083, 6510) || true) && (basePath != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 6083, 6510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6153, 6200);

                            baseRoot = f_300_6164_6199(basePath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 6083, 6510);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 6083, 6510);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6250, 6510) || true) && (baseDirectory != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 6250, 6510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6325, 6377);

                                baseRoot = f_300_6336_6376(baseDirectory);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(300, 6250, 6510);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 6250, 6510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6475, 6487);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(300, 6250, 6510);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 6083, 6510);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6534, 6659) || true) && (f_300_6538_6574(baseRoot))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 6534, 6659);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6624, 6636);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(300, 6534, 6659);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6683, 6742);

                        f_300_6683_6741(f_300_6696_6740(f_300_6731_6739(path!, 0)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6764, 6843);

                        f_300_6764_6842(f_300_6777_6788(path) == 1 || (DynAbs.Tracing.TraceSender.Expression_False(300, 6777, 6841) || !f_300_6798_6841(f_300_6833_6840(path, 1))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 6865, 6937);

                        return f_300_6872_6936(baseRoot, f_300_6918_6935(path, 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.RelativeToDriveDirectory:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7093, 7105);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    case PathKind.Absolute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7170, 7182);

                        return path;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 4397, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7232, 7279);

                        throw f_300_7238_7278(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 4397, 7294);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 4190, 7305);

                Roslyn.Utilities.PathKind
                f_300_4340_4371(string?
                path)
                {
                    var return_v = PathUtilities.GetPathKind(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4340, 4371);
                    return return_v;
                }


                int
                f_300_4327_4380(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4327, 4380);
                    return 0;
                }


                string?
                f_300_4578_4619(string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = GetBaseDirectory(basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4578, 4619);
                    return return_v;
                }


                string
                f_300_4879_4935(string
                root, string?
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 4879, 4935);
                    return return_v;
                }


                string?
                f_300_5035_5076(string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = GetBaseDirectory(basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 5035, 5076);
                    return return_v;
                }


                int
                f_300_5237_5249(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 5237, 5249);
                    return return_v;
                }


                string
                f_300_5499_5555(string
                root, string
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 5499, 5555);
                    return return_v;
                }


                string?
                f_300_5675_5716(string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = GetBaseDirectory(basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 5675, 5716);
                    return return_v;
                }


                string
                f_300_5909_5965(string
                root, string?
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 5909, 5965);
                    return return_v;
                }


                string?
                f_300_6164_6199(string
                path)
                {
                    var return_v = PathUtilities.GetPathRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6164, 6199);
                    return return_v;
                }


                string?
                f_300_6336_6376(string
                path)
                {
                    var return_v = PathUtilities.GetPathRoot(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6336, 6376);
                    return return_v;
                }


                bool
                f_300_6538_6574(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6538, 6574);
                    return return_v;
                }


                char
                f_300_6731_6739(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 6731, 6739);
                    return return_v;
                }


                bool
                f_300_6696_6740(char
                c)
                {
                    var return_v = PathUtilities.IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6696, 6740);
                    return return_v;
                }


                int
                f_300_6683_6741(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6683, 6741);
                    return 0;
                }


                int
                f_300_6777_6788(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 6777, 6788);
                    return return_v;
                }


                char
                f_300_6833_6840(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 6833, 6840);
                    return return_v;
                }


                bool
                f_300_6798_6841(char
                c)
                {
                    var return_v = PathUtilities.IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6798, 6841);
                    return return_v;
                }


                int
                f_300_6764_6842(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6764, 6842);
                    return 0;
                }


                string
                f_300_6918_6935(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6918, 6935);
                    return return_v;
                }


                string
                f_300_6872_6936(string
                root, string
                relativePath)
                {
                    var return_v = PathUtilities.CombinePathsUnchecked(root, relativePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 6872, 6936);
                    return return_v;
                }


                System.Exception
                f_300_7238_7278(Roslyn.Utilities.PathKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 7238, 7278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 4190, 7305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 4190, 7305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? GetBaseDirectory(string? basePath, string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 7317, 8083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7494, 7566);

                string?
                resolvedBasePath = f_300_7521_7565(basePath, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7580, 7678) || true) && (resolvedBasePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 7580, 7678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7642, 7663);

                    return baseDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 7580, 7678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7812, 7869);

                f_300_7812_7868(f_300_7825_7867(resolvedBasePath));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 7919, 7966);

                    return f_300_7926_7965(resolvedBasePath);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 7995, 8072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8045, 8057);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 7995, 8072);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 7317, 8083);

                string?
                f_300_7521_7565(string?
                path, string?
                baseDirectory)
                {
                    var return_v = ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 7521, 7565);
                    return return_v;
                }


                bool
                f_300_7825_7867(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 7825, 7867);
                    return return_v;
                }


                int
                f_300_7812_7868(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 7812, 7868);
                    return 0;
                }


                string?
                f_300_7926_7965(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 7926, 7965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 7317, 8083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 7317, 8083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_invalidPathChars;

        internal static string? NormalizeRelativePath(string path, string? basePath, string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 8186, 9008);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8430, 8589) || true) && (f_300_8434_8479(path, "://", StringComparison.Ordinal) >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(300, 8434, 8528) || f_300_8488_8523(path, s_invalidPathChars) >= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 8430, 8589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8562, 8574);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 8430, 8589);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8605, 8679);

                string?
                resolvedPath = f_300_8628_8678(path, basePath, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8693, 8778) || true) && (resolvedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 8693, 8778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8751, 8763);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 8693, 8778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8794, 8858);

                string?
                normalizedPath = f_300_8819_8857(resolvedPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8872, 8959) || true) && (normalizedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 8872, 8959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8932, 8944);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(300, 8872, 8959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8975, 8997);

                return normalizedPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 8186, 9008);

                int
                f_300_8434_8479(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 8434, 8479);
                    return return_v;
                }


                int
                f_300_8488_8523(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 8488, 8523);
                    return return_v;
                }


                string?
                f_300_8628_8678(string
                path, string?
                basePath, string?
                baseDirectory)
                {
                    var return_v = ResolveRelativePath(path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 8628, 8678);
                    return return_v;
                }


                string?
                f_300_8819_8857(string
                path)
                {
                    var return_v = TryNormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 8819, 8857);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 8186, 9008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 8186, 9008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NormalizeAbsolutePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 9262, 10015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 9467, 9512);

                f_300_9467_9511(f_300_9480_9510(path));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 9564, 9594);

                    return f_300_9571_9593(path);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 9623, 9734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 9683, 9719);

                    throw f_300_9689_9718(f_300_9705_9714(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 9623, 9734);
                }
                catch (System.Security.SecurityException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 9748, 9875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 9824, 9860);

                    throw f_300_9830_9859(f_300_9846_9855(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 9748, 9875);
                }
                catch (NotSupportedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 9889, 10004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 9953, 9989);

                    throw f_300_9959_9988(f_300_9975_9984(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 9889, 10004);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 9262, 10015);

                bool
                f_300_9480_9510(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9480, 9510);
                    return return_v;
                }


                int
                f_300_9467_9511(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9467, 9511);
                    return 0;
                }


                string
                f_300_9571_9593(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9571, 9593);
                    return return_v;
                }


                string
                f_300_9705_9714(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 9705, 9714);
                    return return_v;
                }


                System.IO.IOException
                f_300_9689_9718(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.IO.IOException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9689, 9718);
                    return return_v;
                }


                string
                f_300_9846_9855(System.Security.SecurityException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 9846, 9855);
                    return return_v;
                }


                System.IO.IOException
                f_300_9830_9859(string
                message, System.Security.SecurityException
                innerException)
                {
                    var return_v = new System.IO.IOException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9830, 9859);
                    return return_v;
                }


                string
                f_300_9975_9984(System.NotSupportedException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 9975, 9984);
                    return return_v;
                }


                System.IO.IOException
                f_300_9959_9988(string
                message, System.NotSupportedException
                innerException)
                {
                    var return_v = new System.IO.IOException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 9959, 9988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 9262, 10015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 9262, 10015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string NormalizeDirectoryPath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 10027, 10225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10110, 10214);

                return f_300_10117_10213(f_300_10117_10144(path), Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 10027, 10225);

                string
                f_300_10117_10144(string
                path)
                {
                    var return_v = NormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10117, 10144);
                    return return_v;
                }


                string
                f_300_10117_10213(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10117, 10213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 10027, 10225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 10027, 10225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string? TryNormalizeAbsolutePath(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 10237, 10555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10323, 10368);

                f_300_10323_10367(f_300_10336_10366(path));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10420, 10450);

                    return f_300_10427_10449(path);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 10479, 10544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10517, 10529);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 10479, 10544);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 10237, 10555);

                bool
                f_300_10336_10366(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10336, 10366);
                    return return_v;
                }


                int
                f_300_10323_10367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10323, 10367);
                    return 0;
                }


                string
                f_300_10427_10449(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10427, 10449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 10237, 10555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 10237, 10555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Stream OpenRead(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 10567, 11051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10640, 10689);

                f_300_10640_10688(f_300_10653_10687(fullPath));

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10741, 10821);

                    return f_300_10748_10820(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 10850, 10923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10902, 10908);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 10850, 10923);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 10937, 11040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 10989, 11025);

                    throw f_300_10995_11024(f_300_11011_11020(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 10937, 11040);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 10567, 11051);

                bool
                f_300_10653_10687(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10653, 10687);
                    return return_v;
                }


                int
                f_300_10640_10688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10640, 10688);
                    return 0;
                }


                System.IO.FileStream
                f_300_10748_10820(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10748, 10820);
                    return return_v;
                }


                string
                f_300_11011_11020(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 11011, 11020);
                    return return_v;
                }


                System.IO.IOException
                f_300_10995_11024(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 10995, 11024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 10567, 11051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 10567, 11051);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Stream OpenAsyncRead(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 11063, 11367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 11141, 11190);

                f_300_11141_11189(f_300_11154_11188(fullPath));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 11206, 11356);

                return f_300_11213_11355(() => new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 11063, 11367);

                bool
                f_300_11154_11188(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 11154, 11188);
                    return return_v;
                }


                int
                f_300_11141_11189(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 11141, 11189);
                    return 0;
                }


                System.IO.FileStream
                f_300_11213_11355(System.Func<System.IO.FileStream>
                operation)
                {
                    var return_v = RethrowExceptionsAsIOException(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 11213, 11355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 11063, 11367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 11063, 11367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T RethrowExceptionsAsIOException<T>(Func<T> operation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 11379, 11759);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 11510, 11529);

                    return f_300_11517_11528(operation);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 11558, 11631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 11610, 11616);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 11558, 11631);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 11645, 11748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 11697, 11733);

                    throw f_300_11703_11732(f_300_11719_11728(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 11645, 11748);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 11379, 11759);

                T
                f_300_11517_11528(System.Func<T>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 11517, 11528);
                    return return_v;
                }


                string
                f_300_11719_11728(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 11719, 11728);
                    return return_v;
                }


                System.IO.IOException
                f_300_11703_11732(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 11703, 11732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 11379, 11759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 11379, 11759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Stream CreateFileStreamChecked(Func<string, Stream> factory, string path, string? paramName = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 12017, 13057);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12193, 12214);

                    return f_300_12200_12213(factory, path);
                }
                catch (ArgumentNullException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 12243, 12533);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12305, 12518) || true) && (paramName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 12305, 12518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12368, 12374);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 12305, 12518);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 12305, 12518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12456, 12499);

                        throw f_300_12462_12498(paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 12305, 12518);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 12243, 12533);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 12547, 12842);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12607, 12827) || true) && (paramName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 12607, 12827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12670, 12676);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 12607, 12827);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(300, 12607, 12827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12758, 12808);

                        throw f_300_12764_12807(f_300_12786_12795(e), paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(300, 12607, 12827);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 12547, 12842);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 12856, 12929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12908, 12914);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 12856, 12929);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 12943, 13046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 12995, 13031);

                    throw f_300_13001_13030(f_300_13017_13026(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 12943, 13046);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 12017, 13057);

                System.IO.Stream
                f_300_12200_12213(System.Func<string, System.IO.Stream>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 12200, 12213);
                    return return_v;
                }


                System.ArgumentNullException
                f_300_12462_12498(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 12462, 12498);
                    return return_v;
                }


                string
                f_300_12786_12795(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 12786, 12795);
                    return return_v;
                }


                System.ArgumentException
                f_300_12764_12807(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 12764, 12807);
                    return return_v;
                }


                string
                f_300_13017_13026(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 13017, 13026);
                    return return_v;
                }


                System.IO.IOException
                f_300_13001_13030(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13001, 13030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 12017, 13057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 12017, 13057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DateTime GetFileTimeStamp(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 13114, 13568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13197, 13246);

                f_300_13197_13245(f_300_13210_13244(fullPath));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13296, 13338);

                    return f_300_13303_13337(fullPath);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 13367, 13440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13419, 13425);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 13367, 13440);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 13454, 13557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13506, 13542);

                    throw f_300_13512_13541(f_300_13528_13537(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 13454, 13557);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 13114, 13568);

                bool
                f_300_13210_13244(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13210, 13244);
                    return return_v;
                }


                int
                f_300_13197_13245(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13197, 13245);
                    return 0;
                }


                System.DateTime
                f_300_13303_13337(string
                path)
                {
                    var return_v = File.GetLastWriteTimeUtc(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13303, 13337);
                    return return_v;
                }


                string
                f_300_13528_13537(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 13528, 13537);
                    return return_v;
                }


                System.IO.IOException
                f_300_13512_13541(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13512, 13541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 13114, 13568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 13114, 13568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static long GetFileLength(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 13625, 14101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13701, 13750);

                f_300_13701_13749(f_300_13714_13748(fullPath));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13800, 13834);

                    var
                    info = f_300_13811_13833(fullPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13852, 13871);

                    return f_300_13859_13870(info);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 13900, 13973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 13952, 13958);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 13900, 13973);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 13987, 14090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14039, 14075);

                    throw f_300_14045_14074(f_300_14061_14070(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 13987, 14090);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 13625, 14101);

                bool
                f_300_13714_13748(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13714, 13748);
                    return return_v;
                }


                int
                f_300_13701_13749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13701, 13749);
                    return 0;
                }


                System.IO.FileInfo
                f_300_13811_13833(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 13811, 13833);
                    return return_v;
                }


                long
                f_300_13859_13870(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 13859, 13870);
                    return return_v;
                }


                string
                f_300_14061_14070(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 14061, 14070);
                    return return_v;
                }


                System.IO.IOException
                f_300_14045_14074(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 14045, 14074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 13625, 14101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 13625, 14101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Stream OpenFileStream(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(300, 14113, 14724);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14224, 14251);

                    return f_300_14231_14250(path);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 14280, 14359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14338, 14344);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 14280, 14359);
                }
                catch (DirectoryNotFoundException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 14373, 14509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14442, 14494);

                    throw f_300_14448_14493(f_300_14474_14483(e), path, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 14373, 14509);
                }
                catch (IOException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 14523, 14596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14575, 14581);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 14523, 14596);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(300, 14610, 14713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 14662, 14698);

                    throw f_300_14668_14697(f_300_14684_14693(e), e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(300, 14610, 14713);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(300, 14113, 14724);

                System.IO.FileStream
                f_300_14231_14250(string
                path)
                {
                    var return_v = File.OpenRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 14231, 14250);
                    return return_v;
                }


                string
                f_300_14474_14483(System.IO.DirectoryNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 14474, 14483);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_300_14448_14493(string
                message, string
                fileName, System.IO.DirectoryNotFoundException
                innerException)
                {
                    var return_v = new System.IO.FileNotFoundException(message, fileName, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 14448, 14493);
                    return return_v;
                }


                string
                f_300_14684_14693(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(300, 14684, 14693);
                    return return_v;
                }


                System.IO.IOException
                f_300_14668_14697(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.IO.IOException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 14668, 14697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(300, 14113, 14724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 14113, 14724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FileUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(300, 340, 14731);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(300, 8126, 8173);
            s_invalidPathChars = f_300_8147_8173(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(300, 340, 14731);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(300, 340, 14731);
        }


        static char[]
        f_300_8147_8173()
        {
            var return_v = Path.GetInvalidPathChars();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(300, 8147, 8173);
            return return_v;
        }

    }
}
