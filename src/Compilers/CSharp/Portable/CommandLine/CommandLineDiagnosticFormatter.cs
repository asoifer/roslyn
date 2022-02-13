// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class CommandLineDiagnosticFormatter : CSharpDiagnosticFormatter
    {
        private readonly string _baseDirectory;

        private readonly Lazy<string> _lazyNormalizedBaseDirectory;

        private readonly bool _displayFullPaths;

        private readonly bool _displayEndLocations;

        internal CommandLineDiagnosticFormatter(string baseDirectory, bool displayFullPaths, bool displayEndLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10969, 675, 1083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 476, 490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 531, 559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 592, 609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 642, 662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 810, 841);

                _baseDirectory = baseDirectory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 855, 892);

                _displayFullPaths = displayFullPaths;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 906, 949);

                _displayEndLocations = displayEndLocations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 963, 1072);

                _lazyNormalizedBaseDirectory = f_10969_994_1071(() => FileUtilities.TryNormalizeAbsolutePath(baseDirectory));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10969, 675, 1083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10969, 675, 1083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10969, 675, 1083);
            }
        }

        internal override string FormatSourceSpan(LinePositionSpan span, IFormatProvider formatter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10969, 1095, 1722);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 1211, 1711) || true) && (_displayEndLocations)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10969, 1211, 1711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 1269, 1496);

                    return f_10969_1276_1495(formatter, "({0},{1},{2},{3})", span.Start.Line + 1, span.Start.Character + 1, span.End.Line + 1, span.End.Character + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10969, 1211, 1711);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10969, 1211, 1711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 1562, 1696);

                    return f_10969_1569_1695(formatter, "({0},{1})", span.Start.Line + 1, span.Start.Character + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10969, 1211, 1711);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10969, 1095, 1722);

                string
                f_10969_1276_1495(System.IFormatProvider
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format(provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 1276, 1495);
                    return return_v;
                }


                string
                f_10969_1569_1695(System.IFormatProvider
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format(provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 1569, 1695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10969, 1095, 1722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10969, 1095, 1722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override string FormatSourcePath(string path, string basePath, IFormatProvider formatter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10969, 1734, 2335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 1857, 1946);

                var
                normalizedPath = f_10969_1878_1945(path, basePath, _baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 1960, 2047) || true) && (normalizedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10969, 1960, 2047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2020, 2032);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10969, 1960, 2047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2239, 2324);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10969, 2246, 2263) || ((_displayFullPaths && DynAbs.Tracing.TraceSender.Conditional_F2(10969, 2266, 2280)) || DynAbs.Tracing.TraceSender.Conditional_F3(10969, 2283, 2323))) ? normalizedPath : f_10969_2283_2323(this, normalizedPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10969, 1734, 2335);

                string?
                f_10969_1878_1945(string
                path, string
                basePath, string
                baseDirectory)
                {
                    var return_v = FileUtilities.NormalizeRelativePath(path, basePath, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 1878, 1945);
                    return return_v;
                }


                string
                f_10969_2283_2323(Microsoft.CodeAnalysis.CSharp.CommandLineDiagnosticFormatter
                this_param, string
                normalizedPath)
                {
                    var return_v = this_param.RelativizeNormalizedPath(normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 2283, 2323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10969, 1734, 2335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10969, 1734, 2335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string RelativizeNormalizedPath(string normalizedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10969, 2472, 3276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2560, 2625);

                var
                normalizedBaseDirectory = f_10969_2590_2624(_lazyNormalizedBaseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2639, 2745) || true) && (normalizedBaseDirectory == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10969, 2639, 2745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2708, 2730);

                    return normalizedPath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10969, 2639, 2745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2761, 2834);

                var
                normalizedDirectory = f_10969_2787_2833(normalizedPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2848, 3227) || true) && (f_10969_2852_2936(normalizedDirectory, normalizedBaseDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10969, 2848, 3227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 2970, 3212);

                    return f_10969_2977_3211(normalizedPath, (DynAbs.Tracing.TraceSender.Conditional_F1(10969, 3024, 3090) || ((f_10969_3024_3090(f_10969_3059_3089(normalizedBaseDirectory)) && DynAbs.Tracing.TraceSender.Conditional_F2(10969, 3118, 3148)) || DynAbs.Tracing.TraceSender.Conditional_F3(10969, 3176, 3210))) ? f_10969_3118_3148(normalizedBaseDirectory) : f_10969_3176_3206(normalizedBaseDirectory) + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10969, 2848, 3227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10969, 3243, 3265);

                return normalizedPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10969, 2472, 3276);

                string
                f_10969_2590_2624(System.Lazy<string>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10969, 2590, 2624);
                    return return_v;
                }


                string?
                f_10969_2787_2833(string
                path)
                {
                    var return_v = PathUtilities.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 2787, 2833);
                    return return_v;
                }


                bool
                f_10969_2852_2936(string?
                child, string
                parent)
                {
                    var return_v = PathUtilities.IsSameDirectoryOrChildOf(child, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 2852, 2936);
                    return return_v;
                }


                char
                f_10969_3059_3089(string
                arg)
                {
                    var return_v = arg.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 3059, 3089);
                    return return_v;
                }


                bool
                f_10969_3024_3090(char
                c)
                {
                    var return_v = PathUtilities.IsDirectorySeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 3024, 3090);
                    return return_v;
                }


                int
                f_10969_3118_3148(string
                this_param)
                {
                    var return_v = this_param.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10969, 3118, 3148);
                    return return_v;
                }


                int
                f_10969_3176_3206(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10969, 3176, 3206);
                    return return_v;
                }


                string
                f_10969_2977_3211(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 2977, 3211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10969, 2472, 3276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10969, 2472, 3276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandLineDiagnosticFormatter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10969, 355, 3283);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10969, 355, 3283);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10969, 355, 3283);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10969, 355, 3283);

        System.Lazy<string>
        f_10969_994_1071(System.Func<string>
        valueFactory)
        {
            var return_v = new System.Lazy<string>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10969, 994, 1071);
            return return_v;
        }

    }
}
