// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public abstract class CommandLineParser
    {
        private readonly CommonMessageProvider _messageProvider;

        internal readonly bool IsScriptCommandLineParser;

        private static readonly char[] s_searchPatternTrimChars;

        internal const string
        ErrorLogOptionFormat = "<file>[,version={1|1.0|2|2.1}]"
        ;

        internal CommandLineParser(CommonMessageProvider messageProvider, bool isScriptCommandLineParser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(123, 1006, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 693, 709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 743, 768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 1128, 1172);

                f_123_1128_1171(messageProvider != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 1186, 1221);

                _messageProvider = messageProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 1235, 1289);

                IsScriptCommandLineParser = isScriptCommandLineParser;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(123, 1006, 1300);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 1006, 1300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 1006, 1300);
            }
        }

        internal CommonMessageProvider MessageProvider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 1383, 1415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 1389, 1413);

                    return _messageProvider;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(123, 1383, 1415);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 1312, 1426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 1312, 1426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract string RegularFileExtension { get; }

        protected abstract string ScriptFileExtension { get; }

        internal virtual TextReader CreateTextFileReader(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 1602, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 1692, 1880);

                return f_123_1699_1879(f_123_1734_1806(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read), detectEncodingFromByteOrderMarks: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 1602, 1891);

                System.IO.FileStream
                f_123_1734_1806(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 1734, 1806);
                    return return_v;
                }


                System.IO.StreamReader
                f_123_1699_1879(System.IO.FileStream
                stream, bool
                detectEncodingFromByteOrderMarks)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 1699, 1879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 1602, 1891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 1602, 1891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual IEnumerable<string> EnumerateFiles(string? directory, string fileNamePattern, SearchOption searchOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 2529, 2966);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 2675, 2801) || true) && (directory is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 2675, 2801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 2730, 2786);

                    return f_123_2737_2785();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 2675, 2801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 2817, 2867);

                f_123_2817_2866(f_123_2830_2865(directory));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 2881, 2955);

                return f_123_2888_2954(directory, fileNamePattern, searchOption);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 2529, 2966);

                System.Collections.Generic.IEnumerable<string>
                f_123_2737_2785()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2737, 2785);
                    return return_v;
                }


                bool
                f_123_2830_2865(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2830, 2865);
                    return return_v;
                }


                int
                f_123_2817_2866(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2817, 2866);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_2888_2954(string
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 2888, 2954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 2529, 2966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 2529, 2966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract CommandLineArguments CommonParse(IEnumerable<string> args, string baseDirectory, string? sdkDirectory, string? additionalReferenceDirectories);

        public CommandLineArguments Parse(IEnumerable<string> args, string baseDirectory, string? sdkDirectory, string? additionalReferenceDirectories)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 3785, 4050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 3953, 4039);

                return f_123_3960_4038(this, args, baseDirectory, sdkDirectory, additionalReferenceDirectories);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 3785, 4050);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_123_3960_4038(Microsoft.CodeAnalysis.CommandLineParser
                this_param, System.Collections.Generic.IEnumerable<string>
                args, string
                baseDirectory, string?
                sdkDirectory, string?
                additionalReferenceDirectories)
                {
                    var return_v = this_param.CommonParse(args, baseDirectory, sdkDirectory, additionalReferenceDirectories);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 3960, 4038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 3785, 4050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 3785, 4050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsOption(string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 4062, 4208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4127, 4197);

                return !f_123_4135_4160(arg) && (DynAbs.Tracing.TraceSender.Expression_True(123, 4134, 4196) && (f_123_4165_4171(arg, 0) == '/' || (DynAbs.Tracing.TraceSender.Expression_False(123, 4165, 4195) || f_123_4182_4188(arg, 0) == '-')));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 4062, 4208);

                bool
                f_123_4135_4160(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 4135, 4160);
                    return return_v;
                }


                char
                f_123_4165_4171(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 4165, 4171);
                    return return_v;
                }


                char
                f_123_4182_4188(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 4182, 4188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 4062, 4208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 4062, 4208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseOption(string arg, [NotNullWhen(true)] out string? name, out string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 4220, 5765);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4349, 4490) || true) && (!f_123_4354_4367(arg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 4349, 4490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4401, 4413);

                    name = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4431, 4444);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4462, 4475);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 4349, 4490);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4544, 4679) || true) && (arg == "-")
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 4544, 4679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4592, 4603);

                    name = arg;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4621, 4634);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4652, 4664);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 4544, 4679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4695, 4724);

                int
                colon = f_123_4707_4723(arg, ':')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 4998, 5395) || true) && (f_123_5002_5012(arg) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(123, 5002, 5033) && f_123_5020_5026(arg, 0) != '-'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 4998, 5395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5067, 5103);

                    int
                    separator = f_123_5083_5102(arg, '/', 1)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5121, 5380) || true) && (separator > 0 && (DynAbs.Tracing.TraceSender.Expression_True(123, 5125, 5174) && (colon < 0 || (DynAbs.Tracing.TraceSender.Expression_False(123, 5143, 5173) || separator < colon))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 5121, 5380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5279, 5291);

                        name = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5313, 5326);

                        value = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5348, 5361);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 5121, 5380);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 4998, 5395);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5411, 5681) || true) && (colon >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 5411, 5681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5459, 5494);

                    name = f_123_5466_5493(arg, 1, colon - 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5512, 5545);

                    value = f_123_5520_5544(arg, colon + 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 5411, 5681);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 5411, 5681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5611, 5635);

                    name = f_123_5618_5634(arg, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5653, 5666);

                    value = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 5411, 5681);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5697, 5728);

                name = f_123_5704_5727(name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 5742, 5754);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 4220, 5765);

                bool
                f_123_4354_4367(string
                arg)
                {
                    var return_v = IsOption(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 4354, 4367);
                    return return_v;
                }


                int
                f_123_4707_4723(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 4707, 4723);
                    return return_v;
                }


                int
                f_123_5002_5012(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 5002, 5012);
                    return return_v;
                }


                char
                f_123_5020_5026(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 5020, 5026);
                    return return_v;
                }


                int
                f_123_5083_5102(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5083, 5102);
                    return return_v;
                }


                string
                f_123_5466_5493(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5466, 5493);
                    return return_v;
                }


                string
                f_123_5520_5544(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5520, 5544);
                    return return_v;
                }


                string
                f_123_5618_5634(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5618, 5634);
                    return return_v;
                }


                string
                f_123_5704_5727(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 5704, 5727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 4220, 5765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 4220, 5765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ErrorLogOptions? ParseErrorLogOptions(
                    string arg,
                    IList<Diagnostic> diagnostics,
                    string? baseDirectory,
                    out bool diagnosticAlreadyReported)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 5777, 7880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6003, 6037);

                diagnosticAlreadyReported = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6053, 6191);

                IEnumerator<string>
                partsEnumerator = f_123_6091_6190(f_123_6091_6174(arg, s_pathSeparators, StringSplitOptions.RemoveEmptyEntries))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6205, 6346) || true) && (!f_123_6210_6236(partsEnumerator) || (DynAbs.Tracing.TraceSender.Expression_False(123, 6209, 6285) || f_123_6240_6285(f_123_6261_6284(partsEnumerator))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 6205, 6346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6319, 6331);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 6205, 6346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6362, 6453);

                string?
                path = f_123_6377_6452(this, f_123_6400_6423(partsEnumerator), diagnostics, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6467, 6737) || true) && (path is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 6467, 6737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6659, 6692);

                    diagnosticAlreadyReported = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6710, 6722);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 6467, 6737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6753, 6798);

                const char
                ParameterNameValueSeparator = '='
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6812, 6861);

                SarifVersion
                sarifVersion = SarifVersion.Default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6877, 7699) || true) && (f_123_6881_6907(partsEnumerator) && (DynAbs.Tracing.TraceSender.Expression_True(123, 6881, 6957) && !f_123_6912_6957(f_123_6933_6956(partsEnumerator))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 6877, 7699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 6991, 7029);

                    string
                    part = f_123_7005_7028(partsEnumerator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7049, 7125);

                    string
                    versionParameterDesignator = "version" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (ParameterNameValueSeparator).ToString(), 123, 7097, 7124)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7143, 7216);

                    int
                    versionParameterDesignatorLength = f_123_7182_7215(versionParameterDesignator)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7236, 7684) || true) && (!(
                    f_123_7268_7279(part) > versionParameterDesignatorLength && (DynAbs.Tracing.TraceSender.Expression_True(123, 7268, 7465) && f_123_7343_7465(f_123_7343_7394(part, 0, versionParameterDesignatorLength), versionParameterDesignator, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(123, 7268, 7588) && f_123_7494_7588(f_123_7521_7569(part, versionParameterDesignatorLength), out sarifVersion))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 7236, 7684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7653, 7665);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 7236, 7684);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 6877, 7699);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7715, 7806) || true) && (f_123_7719_7745(partsEnumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 7715, 7806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7779, 7791);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 7715, 7806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 7822, 7869);

                return f_123_7829_7868(path, sarifVersion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 5777, 7880);

                System.Collections.Generic.IEnumerable<string>
                f_123_6091_6174(string
                str, char[]
                separators, System.StringSplitOptions
                options)
                {
                    var return_v = ParseSeparatedStrings(str, separators, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6091, 6174);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_123_6091_6190(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6091, 6190);
                    return return_v;
                }


                bool
                f_123_6210_6236(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6210, 6236);
                    return return_v;
                }


                string
                f_123_6261_6284(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 6261, 6284);
                    return return_v;
                }


                bool
                f_123_6240_6285(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6240, 6285);
                    return return_v;
                }


                string
                f_123_6400_6423(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 6400, 6423);
                    return return_v;
                }


                string?
                f_123_6377_6452(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6377, 6452);
                    return return_v;
                }


                bool
                f_123_6881_6907(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6881, 6907);
                    return return_v;
                }


                string
                f_123_6933_6956(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 6933, 6956);
                    return return_v;
                }


                bool
                f_123_6912_6957(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 6912, 6957);
                    return return_v;
                }


                string
                f_123_7005_7028(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 7005, 7028);
                    return return_v;
                }


                int
                f_123_7182_7215(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 7182, 7215);
                    return return_v;
                }


                int
                f_123_7268_7279(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 7268, 7279);
                    return return_v;
                }


                string
                f_123_7343_7394(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7343, 7394);
                    return return_v;
                }


                bool
                f_123_7343_7465(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7343, 7465);
                    return return_v;
                }


                string
                f_123_7521_7569(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7521, 7569);
                    return return_v;
                }


                bool
                f_123_7494_7588(string
                version, out Microsoft.CodeAnalysis.SarifVersion
                result)
                {
                    var return_v = SarifVersionFacts.TryParse(version, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7494, 7588);
                    return return_v;
                }


                bool
                f_123_7719_7745(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7719, 7745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions
                f_123_7829_7868(string
                path, Microsoft.CodeAnalysis.SarifVersion
                sarifVersion)
                {
                    var return_v = new Microsoft.CodeAnalysis.ErrorLogOptions(path, sarifVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 7829, 7868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 5777, 7880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 5777, 7880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ParseAndNormalizeFile(
                    string unquoted,
                    string? baseDirectory,
                    out string? outputFileName,
                    out string? outputDirectory,
                    out string invalidPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 7892, 9725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8146, 8168);

                outputFileName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8182, 8205);

                outputDirectory = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8219, 8242);

                invalidPath = unquoted;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8258, 8340);

                string?
                resolvedPath = f_123_8281_8339(unquoted, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8354, 9375) || true) && (resolvedPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 8354, 9375);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8693, 8739);

                        resolvedPath = f_123_8708_8738(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8844, 8871);

                        invalidPath = resolvedPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8895, 8943);

                        outputFileName = f_123_8912_8942(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 8965, 9019);

                        outputDirectory = f_123_8983_9018(resolvedPath);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 9056, 9153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9114, 9134);

                        resolvedPath = null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(123, 9056, 9153);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9173, 9360) || true) && (outputFileName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 9173, 9360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9280, 9341);

                        outputFileName = f_123_9297_9340(outputFileName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 9173, 9360);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 8354, 9375);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9391, 9714) || true) && (resolvedPath == null || (DynAbs.Tracing.TraceSender.Expression_False(123, 9395, 9564) ||                // NUL-terminated, non-empty, valid Unicode strings
                                !f_123_9506_9564(outputDirectory)) || (DynAbs.Tracing.TraceSender.Expression_False(123, 9395, 9643) || !f_123_9586_9643(outputFileName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 9391, 9714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9677, 9699);

                    outputFileName = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 9391, 9714);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 7892, 9725);

                string?
                f_123_8281_8339(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8281, 8339);
                    return return_v;
                }


                string
                f_123_8708_8738(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8708, 8738);
                    return return_v;
                }


                string?
                f_123_8912_8942(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8912, 8942);
                    return return_v;
                }


                string?
                f_123_8983_9018(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 8983, 9018);
                    return return_v;
                }


                string?
                f_123_9297_9340(string
                path)
                {
                    var return_v = RemoveTrailingSpacesAndDots(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9297, 9340);
                    return return_v;
                }


                bool
                f_123_9506_9564(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9506, 9564);
                    return return_v;
                }


                bool
                f_123_9586_9643(string?
                str)
                {
                    var return_v = MetadataHelpers.IsValidMetadataIdentifier(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 9586, 9643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 7892, 9725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 7892, 9725);
            }
        }

        [return: NotNullIfNotNull("path")]
        internal static string? RemoveTrailingSpacesAndDots(string? path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 9851, 10441);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 9985, 10062) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 9985, 10062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10035, 10047);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 9985, 10062);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10078, 10103);

                int
                length = f_123_10091_10102(path)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10126, 10140);
                    for (int
        i = length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10117, 10394) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10150, 10153)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(123, 10117, 10394))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 10117, 10394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10187, 10204);

                        char
                        c = f_123_10196_10203(path, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10222, 10379) || true) && (!f_123_10227_10247(c) && (DynAbs.Tracing.TraceSender.Expression_True(123, 10226, 10259) && c != '.'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 10222, 10379);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10301, 10360);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(123, 10308, 10325) || ((i == (length - 1) && DynAbs.Tracing.TraceSender.Conditional_F2(123, 10328, 10332)) || DynAbs.Tracing.TraceSender.Conditional_F3(123, 10335, 10359))) ? path : f_123_10335_10359(path, 0, i + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 10222, 10379);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10410, 10430);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 9851, 10441);

                int
                f_123_10091_10102(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 10091, 10102);
                    return return_v;
                }


                char
                f_123_10196_10203(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 10196, 10203);
                    return return_v;
                }


                bool
                f_123_10227_10247(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10227, 10247);
                    return return_v;
                }


                string
                f_123_10335_10359(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10335, 10359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 9851, 10441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 9851, 10441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected ImmutableArray<KeyValuePair<string, string>> ParsePathMap(string pathMap, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 10453, 11980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10587, 10715) || true) && (f_123_10591_10608(pathMap))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 10587, 10715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10642, 10700);

                    return ImmutableArray<KeyValuePair<string, string>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 10587, 10715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10731, 10809);

                var
                pathMapBuilder = f_123_10752_10808()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10825, 11910);
                    foreach (var kEqualsV in f_123_10850_10897_I(f_123_10850_10897(pathMap, ',')))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 10825, 11910);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10931, 11023) || true) && (f_123_10935_10953(kEqualsV))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 10931, 11023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 10995, 11004);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 10931, 11023);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11043, 11101);

                        var
                        kv = f_123_11052_11100(kEqualsV, '=')
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11119, 11324) || true) && (f_123_11123_11132(kv) != 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 11119, 11324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11179, 11274);

                            f_123_11179_11273(errors, f_123_11190_11272(_messageProvider, f_123_11226_11261(_messageProvider), kEqualsV));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11296, 11305);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 11119, 11324);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11344, 11361);

                        var
                        from = kv[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11379, 11394);

                        var
                        to = kv[1]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11414, 11895) || true) && (f_123_11418_11429(from) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(123, 11418, 11452) || f_123_11438_11447(to) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 11414, 11895);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11494, 11589);

                            f_123_11494_11588(errors, f_123_11505_11587(_messageProvider, f_123_11541_11576(_messageProvider), kEqualsV));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 11414, 11895);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 11414, 11895);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11671, 11722);

                            from = f_123_11678_11721(from);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11744, 11791);

                            to = f_123_11749_11790(to);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11813, 11876);

                            f_123_11813_11875(pathMapBuilder, f_123_11832_11874(from, to));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 11414, 11895);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 10825, 11910);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 1086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 1086);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 11926, 11969);

                return f_123_11933_11968(pathMapBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 10453, 11980);

                bool
                f_123_10591_10608(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10591, 10608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
                f_123_10752_10808()
                {
                    var return_v = ArrayBuilder<KeyValuePair<string, string>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10752, 10808);
                    return return_v;
                }


                string[]
                f_123_10850_10897(string
                str, char
                separator)
                {
                    var return_v = SplitWithDoubledSeparatorEscaping(str, separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10850, 10897);
                    return return_v;
                }


                bool
                f_123_10935_10953(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10935, 10953);
                    return return_v;
                }


                string[]
                f_123_11052_11100(string
                str, char
                separator)
                {
                    var return_v = SplitWithDoubledSeparatorEscaping(str, separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11052, 11100);
                    return return_v;
                }


                int
                f_123_11123_11132(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 11123, 11132);
                    return return_v;
                }


                int
                f_123_11226_11261(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidPathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 11226, 11261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_11190_11272(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11190, 11272);
                    return return_v;
                }


                int
                f_123_11179_11273(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11179, 11273);
                    return 0;
                }


                int
                f_123_11418_11429(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 11418, 11429);
                    return return_v;
                }


                int
                f_123_11438_11447(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 11438, 11447);
                    return return_v;
                }


                int
                f_123_11541_11576(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_InvalidPathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 11541, 11576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_11505_11587(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11505, 11587);
                    return return_v;
                }


                int
                f_123_11494_11588(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11494, 11588);
                    return 0;
                }


                string
                f_123_11678_11721(string
                s)
                {
                    var return_v = PathUtilities.EnsureTrailingSeparator(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11678, 11721);
                    return return_v;
                }


                string
                f_123_11749_11790(string
                s)
                {
                    var return_v = PathUtilities.EnsureTrailingSeparator(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11749, 11790);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<string, string>
                f_123_11832_11874(string
                key, string
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<string, string>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11832, 11874);
                    return return_v;
                }


                int
                f_123_11813_11875(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
                this_param, System.Collections.Generic.KeyValuePair<string, string>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11813, 11875);
                    return 0;
                }


                string[]
                f_123_10850_10897_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 10850, 10897);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_123_11933_11968(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, string>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 11933, 11968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 10453, 11980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 10453, 11980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] SplitWithDoubledSeparatorEscaping(string str, char separator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 12285, 13378);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12396, 12493) || true) && (f_123_12400_12410(str) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 12396, 12493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12449, 12478);

                    return f_123_12456_12477();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 12396, 12493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12509, 12557);

                var
                result = f_123_12522_12556()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12571, 12622);

                var
                pooledPart = f_123_12588_12621()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12636, 12666);

                var
                part = pooledPart.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12682, 12692);

                int
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12706, 13244) || true) && (i < f_123_12717_12727(str))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 12706, 13244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12761, 12779);

                        char
                        c = f_123_12770_12778(str, i++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12797, 13194) || true) && (c == separator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 12797, 13194);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12857, 13175) || true) && (i < f_123_12865_12875(str) && (DynAbs.Tracing.TraceSender.Expression_True(123, 12861, 12898) && f_123_12879_12885(str, i) == separator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 12857, 13175);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 12948, 12952);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 12857, 13175);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 12857, 13175);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13050, 13078);

                                f_123_13050_13077(result, f_123_13061_13076(part));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13104, 13117);

                                f_123_13104_13116(part);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13143, 13152);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 12857, 13175);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 12797, 13194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13214, 13229);

                        f_123_13214_13228(
                                        part, c);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 12706, 13244);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 12706, 13244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 12706, 13244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13260, 13288);

                f_123_13260_13287(
                            result, f_123_13271_13286(part));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13304, 13322);

                f_123_13304_13321(
                            pooledPart);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13336, 13367);

                return f_123_13343_13366(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 12285, 13378);

                int
                f_123_12400_12410(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12400, 12410);
                    return return_v;
                }


                string[]
                f_123_12456_12477()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12456, 12477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_123_12522_12556()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12522, 12556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_123_12588_12621()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 12588, 12621);
                    return return_v;
                }


                int
                f_123_12717_12727(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12717, 12727);
                    return return_v;
                }


                char
                f_123_12770_12778(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12770, 12778);
                    return return_v;
                }


                int
                f_123_12865_12875(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12865, 12875);
                    return return_v;
                }


                char
                f_123_12879_12885(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 12879, 12885);
                    return return_v;
                }


                string
                f_123_13061_13076(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13061, 13076);
                    return return_v;
                }


                int
                f_123_13050_13077(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13050, 13077);
                    return 0;
                }


                System.Text.StringBuilder
                f_123_13104_13116(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13104, 13116);
                    return return_v;
                }


                System.Text.StringBuilder
                f_123_13214_13228(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13214, 13228);
                    return return_v;
                }


                string
                f_123_13271_13286(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13271, 13286);
                    return return_v;
                }


                int
                f_123_13260_13287(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13260, 13287);
                    return 0;
                }


                int
                f_123_13304_13321(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13304, 13321);
                    return 0;
                }


                string[]
                f_123_13343_13366(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13343, 13366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 12285, 13378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 12285, 13378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ParseOutputFile(
                    string value,
                    IList<Diagnostic> errors,
                    string? baseDirectory,
                    out string? outputFileName,
                    out string? outputDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 13390, 14180);
                string invalidPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13630, 13678);

                string
                unquoted = f_123_13648_13677(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13692, 13805);

                f_123_13692_13804(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13819, 14169) || true) && (outputFileName == null || (DynAbs.Tracing.TraceSender.Expression_False(123, 13823, 13926) || !f_123_13867_13926(outputFileName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 13819, 14169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 13960, 14064);

                    f_123_13960_14063(errors, f_123_13971_14062(_messageProvider, f_123_14007_14048(_messageProvider), invalidPath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14082, 14104);

                    outputFileName = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14122, 14154);

                    outputDirectory = baseDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 13819, 14169);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 13390, 14180);

                string?
                f_123_13648_13677(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13648, 13677);
                    return return_v;
                }


                int
                f_123_13692_13804(string
                unquoted, string?
                baseDirectory, out string?
                outputFileName, out string?
                outputDirectory, out string?
                invalidPath)
                {
                    ParseAndNormalizeFile(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13692, 13804);
                    return 0;
                }


                bool
                f_123_13867_13926(string
                name)
                {
                    var return_v = MetadataHelpers.IsValidAssemblyOrModuleName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13867, 13926);
                    return return_v;
                }


                int
                f_123_14007_14048(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 14007, 14048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_13971_14062(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13971, 14062);
                    return return_v;
                }


                int
                f_123_13960_14063(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 13960, 14063);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 13390, 14180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 13390, 14180);
            }
        }

        internal string? ParsePdbPath(
                    string value,
                    IList<Diagnostic> errors,
                    string? baseDirectory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 14192, 15231);
                string? outputFileName = default(string?);
                string? outputDirectory = default(string?);
                string invalidPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14349, 14372);

                string?
                pdbPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14388, 14436);

                string
                unquoted = f_123_14406_14435(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14450, 14579);

                f_123_14450_14578(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14593, 15189) || true) && (outputFileName == null || (DynAbs.Tracing.TraceSender.Expression_False(123, 14597, 14714) || f_123_14640_14709(f_123_14640_14702(outputFileName, extension: null)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 14593, 15189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 14748, 14852);

                    f_123_14748_14851(errors, f_123_14759_14850(_messageProvider, f_123_14795_14836(_messageProvider), invalidPath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 14593, 15189);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 14593, 15189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15030, 15070);

                    f_123_15030_15069(outputDirectory is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15088, 15174);

                    pdbPath = f_123_15098_15173(f_123_15119_15164(outputDirectory, outputFileName), ".pdb");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 14593, 15189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15205, 15220);

                return pdbPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 14192, 15231);

                string?
                f_123_14406_14435(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 14406, 14435);
                    return return_v;
                }


                int
                f_123_14450_14578(string
                unquoted, string?
                baseDirectory, out string?
                outputFileName, out string?
                outputDirectory, out string?
                invalidPath)
                {
                    ParseAndNormalizeFile(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 14450, 14578);
                    return 0;
                }


                string
                f_123_14640_14702(string
                path, string?
                extension)
                {
                    var return_v = PathUtilities.ChangeExtension(path, extension: extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 14640, 14702);
                    return return_v;
                }


                int
                f_123_14640_14709(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 14640, 14709);
                    return return_v;
                }


                int
                f_123_14795_14836(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 14795, 14836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_14759_14850(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 14759, 14850);
                    return return_v;
                }


                int
                f_123_14748_14851(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 14748, 14851);
                    return 0;
                }


                int
                f_123_15030_15069(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15030, 15069);
                    return 0;
                }


                string
                f_123_15119_15164(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15119, 15164);
                    return return_v;
                }


                string?
                f_123_15098_15173(string
                path, string
                extension)
                {
                    var return_v = Path.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15098, 15173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 14192, 15231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 14192, 15231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string? ParseGenericPathToFile(
                    string unquoted,
                    IList<Diagnostic> errors,
                    string? baseDirectory,
                    bool generateDiagnostic = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 15243, 16210);
                string? outputFileName = default(string?);
                string? outputDirectory = default(string?);
                string invalidPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15458, 15485);

                string?
                genericPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15501, 15630);

                f_123_15501_15629(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15644, 16164) || true) && (f_123_15648_15689(outputFileName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 15644, 16164);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15723, 15910) || true) && (generateDiagnostic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 15723, 15910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 15787, 15891);

                        f_123_15787_15890(errors, f_123_15798_15889(_messageProvider, f_123_15834_15875(_messageProvider), invalidPath));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 15723, 15910);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 15644, 16164);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 15644, 16164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16088, 16149);

                    genericPath = f_123_16102_16148(outputDirectory!, outputFileName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 15644, 16164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16180, 16199);

                return genericPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 15243, 16210);

                int
                f_123_15501_15629(string
                unquoted, string?
                baseDirectory, out string?
                outputFileName, out string?
                outputDirectory, out string?
                invalidPath)
                {
                    ParseAndNormalizeFile(unquoted, baseDirectory, out outputFileName, out outputDirectory, out invalidPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15501, 15629);
                    return 0;
                }


                bool
                f_123_15648_15689(string?
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15648, 15689);
                    return return_v;
                }


                int
                f_123_15834_15875(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 15834, 15875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_15798_15889(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15798, 15889);
                    return return_v;
                }


                int
                f_123_15787_15890(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 15787, 15890);
                    return 0;
                }


                string
                f_123_16102_16148(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16102, 16148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 15243, 16210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 15243, 16210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void FlattenArgs(
                    IEnumerable<string> rawArguments,
                    IList<Diagnostic> diagnostics,
                    List<string> processedArgs,
                    List<string>? scriptArgsOpt,
                    string? baseDirectory,
                    List<string>? responsePaths = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 16222, 20713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16532, 16563);

                bool
                parsingScriptArgs = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16577, 16605);

                bool
                sourceFileSeen = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16619, 16645);

                bool
                optionsEnded = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16661, 16714);

                var
                args = f_123_16672_16713(f_123_16690_16712(rawArguments))
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 16728, 20702) || true) && (f_123_16735_16745(args) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 16728, 20702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17034, 17068);

                        string
                        arg = f_123_17047_17067(f_123_17047_17057(args))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17088, 17225) || true) && (parsingScriptArgs)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 17088, 17225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17151, 17175);

                            f_123_17151_17174(scriptArgsOpt!, arg);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17197, 17206);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 17088, 17225);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17245, 18442) || true) && (scriptArgsOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 17245, 18442);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17765, 18086) || true) && (sourceFileSeen)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 17765, 18086);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 17954, 17979);

                                parsingScriptArgs = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18005, 18028);

                                f_123_18005_18027(scriptArgsOpt, arg);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18054, 18063);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 17765, 18086);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18110, 18423) || true) && (!optionsEnded && (DynAbs.Tracing.TraceSender.Expression_True(123, 18114, 18142) && arg == "--"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18110, 18423);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18296, 18316);

                                optionsEnded = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18342, 18365);

                                f_123_18342_18364(processedArgs, arg);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18391, 18400);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18110, 18423);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 17245, 18442);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18462, 20687) || true) && (!optionsEnded && (DynAbs.Tracing.TraceSender.Expression_True(123, 18466, 18528) && f_123_18483_18528(arg, "@", StringComparison.Ordinal)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18462, 20687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18609, 18678);

                            string
                            path = f_123_18623_18677(f_123_18623_18663(f_123_18646_18662(arg, 1)), null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18700, 18778);

                            string?
                            resolvedPath = f_123_18723_18777(path, baseDirectory)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18800, 20492) || true) && (resolvedPath != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18800, 20492);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 18874, 19620);
                                    foreach (string newArg in f_123_18900_18954_I(f_123_18900_18954(f_123_18900_18944(this, resolvedPath, diagnostics))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18874, 19620);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19098, 19593) || true) && (!f_123_19103_19173(newArg, "/noconfig", StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(123, 19102, 19248) && !f_123_19178_19248(newArg, "-noconfig", StringComparison.OrdinalIgnoreCase)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 19098, 19593);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19314, 19332);

                                            f_123_19314_19331(args, newArg);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 19098, 19593);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 19098, 19593);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19462, 19562);

                                            f_123_19462_19561(diagnostics, f_123_19478_19560(_messageProvider, f_123_19514_19559(_messageProvider)));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 19098, 19593);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18874, 19620);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 747);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 747);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19648, 20269) || true) && (responsePaths != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 19648, 20269);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19731, 19796);

                                    string?
                                    directory = f_123_19751_19795(resolvedPath)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19826, 20242) || true) && (directory is null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 19826, 20242);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 19913, 20015);

                                        f_123_19913_20014(diagnostics, f_123_19929_20013(_messageProvider, f_123_19965_20006(_messageProvider), path));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 19826, 20242);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 19826, 20242);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 20145, 20211);

                                        f_123_20145_20210(responsePaths, f_123_20163_20209(directory));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 19826, 20242);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 19648, 20269);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18800, 20492);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18800, 20492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 20367, 20469);

                                f_123_20367_20468(diagnostics, f_123_20383_20467(_messageProvider, f_123_20419_20460(_messageProvider), path));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18800, 20492);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18462, 20687);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 18462, 20687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 20574, 20597);

                            f_123_20574_20596(processedArgs, arg);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 20619, 20668);

                            sourceFileSeen |= optionsEnded || (DynAbs.Tracing.TraceSender.Expression_False(123, 20637, 20667) || !f_123_20654_20667(arg));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 18462, 20687);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 16728, 20702);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 16728, 20702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 16728, 20702);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 16222, 20713);

                System.Collections.Generic.IEnumerable<string>
                f_123_16690_16712(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Reverse<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16690, 16712);
                    return return_v;
                }


                System.Collections.Generic.Stack<string>
                f_123_16672_16713(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.Stack<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 16672, 16713);
                    return return_v;
                }


                int
                f_123_16735_16745(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 16735, 16745);
                    return return_v;
                }


                string
                f_123_17047_17057(System.Collections.Generic.Stack<string>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 17047, 17057);
                    return return_v;
                }


                string
                f_123_17047_17067(string
                this_param)
                {
                    var return_v = this_param.TrimEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 17047, 17067);
                    return return_v;
                }


                int
                f_123_17151_17174(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 17151, 17174);
                    return 0;
                }


                int
                f_123_18005_18027(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18005, 18027);
                    return 0;
                }


                int
                f_123_18342_18364(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18342, 18364);
                    return 0;
                }


                bool
                f_123_18483_18528(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18483, 18528);
                    return return_v;
                }


                string
                f_123_18646_18662(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18646, 18662);
                    return return_v;
                }


                string?
                f_123_18623_18663(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18623, 18663);
                    return return_v;
                }


                string
                f_123_18623_18677(string
                this_param, params char[]?
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18623, 18677);
                    return return_v;
                }


                string?
                f_123_18723_18777(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18723, 18777);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_18900_18944(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                fullPath, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseResponseFile(fullPath, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18900, 18944);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_18900_18954(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Reverse<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18900, 18954);
                    return return_v;
                }


                bool
                f_123_19103_19173(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19103, 19173);
                    return return_v;
                }


                bool
                f_123_19178_19248(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19178, 19248);
                    return return_v;
                }


                int
                f_123_19314_19331(System.Collections.Generic.Stack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19314, 19331);
                    return 0;
                }


                int
                f_123_19514_19559(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.WRN_NoConfigNotOnCommandLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 19514, 19559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_19478_19560(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19478, 19560);
                    return return_v;
                }


                int
                f_123_19462_19561(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19462, 19561);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_18900_18954_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 18900, 18954);
                    return return_v;
                }


                string?
                f_123_19751_19795(string
                path)
                {
                    var return_v = PathUtilities.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19751, 19795);
                    return return_v;
                }


                int
                f_123_19965_20006(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 19965, 20006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_19929_20013(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19929, 20013);
                    return return_v;
                }


                int
                f_123_19913_20014(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 19913, 20014);
                    return 0;
                }


                string
                f_123_20163_20209(string
                path)
                {
                    var return_v = FileUtilities.NormalizeAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20163, 20209);
                    return return_v;
                }


                int
                f_123_20145_20210(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20145, 20210);
                    return 0;
                }


                int
                f_123_20419_20460(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 20419, 20460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_20383_20467(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20383, 20467);
                    return return_v;
                }


                int
                f_123_20367_20468(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20367, 20468);
                    return 0;
                }


                int
                f_123_20574_20596(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20574, 20596);
                    return 0;
                }


                bool
                f_123_20654_20667(string
                arg)
                {
                    var return_v = IsOption(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 20654, 20667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 16222, 20713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 16222, 20713);
            }
        }

        internal static bool TryParseClientArgs(
                    IEnumerable<string> args,
                    out List<string>? parsedArgs,
                    out bool containsShared,
                    out string? keepAliveValue,
                    out string? pipeName,
                    out string? errorMessage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 21875, 25352);
                bool hasValue = default(bool);
                string? value = default(string?);
                int intValue = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22175, 22198);

                containsShared = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22212, 22234);

                keepAliveValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22248, 22268);

                errorMessage = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22282, 22300);

                parsedArgs = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22314, 22330);

                pipeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22344, 22377);

                var
                newArgs = f_123_22358_22376()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22391, 24023);
                    foreach (var arg in f_123_22411_22415_I(args))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22391, 24023);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22449, 23403) || true) && (f_123_22453_22527(arg, "keepalive", out hasValue, out value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22449, 23403);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22569, 22766) || true) && (f_123_22573_22600(value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22569, 22766);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22650, 22704);

                                errorMessage = f_123_22665_22703();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22730, 22743);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22569, 22766);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22790, 23353) || true) && (f_123_22794_22831(value, out intValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22790, 23353);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22881, 23083) || true) && (intValue < -1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22881, 23083);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 22956, 23013);

                                    errorMessage = f_123_22971_23012();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23043, 23056);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22881, 23083);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23109, 23132);

                                keepAliveValue = value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22790, 23353);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 22790, 23353);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23230, 23291);

                                errorMessage = f_123_23245_23290();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23317, 23330);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22790, 23353);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23375, 23384);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22449, 23403);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23423, 23971) || true) && (f_123_23427_23485(arg, "shared", out hasValue, out value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 23423, 23971);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23527, 23875) || true) && (hasValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 23527, 23875);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23589, 23807) || true) && (f_123_23593_23620(value))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 23589, 23807);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23678, 23737);

                                    errorMessage = f_123_23693_23736();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23767, 23780);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 23589, 23807);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23835, 23852);

                                pipeName = value;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 23527, 23875);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23899, 23921);

                            containsShared = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23943, 23952);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 23423, 23971);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 23991, 24008);

                        f_123_23991_24007(
                                        newArgs, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 22391, 24023);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 1633);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24039, 24341) || true) && (keepAliveValue != null && (DynAbs.Tracing.TraceSender.Expression_True(123, 24043, 24084) && !containsShared))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24039, 24341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24118, 24178);

                    errorMessage = f_123_24133_24177();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24196, 24209);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24039, 24341);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24039, 24341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24275, 24296);

                    parsedArgs = newArgs;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24314, 24326);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24039, 24341);
                }

                static bool isClientArgsOption(string arg, string optionName, out bool hasValue, out string? optionValue)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 24357, 25341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24495, 24512);

                        hasValue = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24530, 24549);

                        optionValue = null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24569, 24699) || true) && (f_123_24573_24583(arg) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(123, 24573, 24625) || !(f_123_24594_24600(arg, 0) == '/' || (DynAbs.Tracing.TraceSender.Expression_False(123, 24594, 24624) || f_123_24611_24617(arg, 0) == '-'))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24569, 24699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24667, 24680);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24569, 24699);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24719, 24742);

                        arg = f_123_24725_24741(arg, 1);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24760, 24901) || true) && (!f_123_24765_24827(arg, optionName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24760, 24901);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24869, 24882);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24760, 24901);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24921, 25294) || true) && (f_123_24925_24935(arg) > f_123_24938_24955(optionName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24921, 25294);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 24997, 25152) || true) && (!(f_123_25003_25025(arg, f_123_25007_25024(optionName)) == ':' || (DynAbs.Tracing.TraceSender.Expression_False(123, 25003, 25065) || f_123_25036_25058(arg, f_123_25040_25057(optionName)) == '=')))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 24997, 25152);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25116, 25129);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24997, 25152);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25176, 25192);

                            hasValue = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25214, 25275);

                            optionValue = f_123_25228_25274(f_123_25228_25264(arg, f_123_25242_25259(optionName) + 1), '"');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 24921, 25294);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25314, 25326);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 24357, 25341);

                        int
                        f_123_24573_24583(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24573, 24583);
                            return return_v;
                        }


                        char
                        f_123_24594_24600(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24594, 24600);
                            return return_v;
                        }


                        char
                        f_123_24611_24617(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24611, 24617);
                            return return_v;
                        }


                        string
                        f_123_24725_24741(string
                        this_param, int
                        startIndex)
                        {
                            var return_v = this_param.Substring(startIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 24725, 24741);
                            return return_v;
                        }


                        bool
                        f_123_24765_24827(string
                        this_param, string
                        value, System.StringComparison
                        comparisonType)
                        {
                            var return_v = this_param.StartsWith(value, comparisonType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 24765, 24827);
                            return return_v;
                        }


                        int
                        f_123_24925_24935(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24925, 24935);
                            return return_v;
                        }


                        int
                        f_123_24938_24955(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24938, 24955);
                            return return_v;
                        }


                        int
                        f_123_25007_25024(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25007, 25024);
                            return return_v;
                        }


                        char
                        f_123_25003_25025(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25003, 25025);
                            return return_v;
                        }


                        int
                        f_123_25040_25057(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25040, 25057);
                            return return_v;
                        }


                        char
                        f_123_25036_25058(string
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25036, 25058);
                            return return_v;
                        }


                        int
                        f_123_25242_25259(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25242, 25259);
                            return return_v;
                        }


                        string
                        f_123_25228_25264(string
                        this_param, int
                        startIndex)
                        {
                            var return_v = this_param.Substring(startIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25228, 25264);
                            return return_v;
                        }


                        string
                        f_123_25228_25274(string
                        this_param, char
                        trimChar)
                        {
                            var return_v = this_param.Trim(trimChar);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25228, 25274);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 24357, 25341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 24357, 25341);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 21875, 25352);

                System.Collections.Generic.List<string>
                f_123_22358_22376()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22358, 22376);
                    return return_v;
                }


                bool
                f_123_22453_22527(string
                arg, string
                optionName, out bool
                hasValue, out string?
                optionValue)
                {
                    var return_v = isClientArgsOption(arg, optionName, out hasValue, out optionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22453, 22527);
                    return return_v;
                }


                bool
                f_123_22573_22600(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22573, 22600);
                    return return_v;
                }


                string
                f_123_22665_22703()
                {
                    var return_v = CodeAnalysisResources.MissingKeepAlive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 22665, 22703);
                    return return_v;
                }


                bool
                f_123_22794_22831(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22794, 22831);
                    return return_v;
                }


                string
                f_123_22971_23012()
                {
                    var return_v = CodeAnalysisResources.KeepAliveIsTooSmall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 22971, 23012);
                    return return_v;
                }


                string
                f_123_23245_23290()
                {
                    var return_v = CodeAnalysisResources.KeepAliveIsNotAnInteger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 23245, 23290);
                    return return_v;
                }


                bool
                f_123_23427_23485(string
                arg, string
                optionName, out bool
                hasValue, out string?
                optionValue)
                {
                    var return_v = isClientArgsOption(arg, optionName, out hasValue, out optionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 23427, 23485);
                    return return_v;
                }


                bool
                f_123_23593_23620(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 23593, 23620);
                    return return_v;
                }


                string
                f_123_23693_23736()
                {
                    var return_v = CodeAnalysisResources.SharedArgumentMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 23693, 23736);
                    return return_v;
                }


                int
                f_123_23991_24007(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 23991, 24007);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_22411_22415_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 22411, 22415);
                    return return_v;
                }


                string
                f_123_24133_24177()
                {
                    var return_v = CodeAnalysisResources.KeepAliveWithoutShared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 24133, 24177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 21875, 25352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 21875, 25352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string MismatchedVersionErrorText
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 25414, 25456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25417, 25456);
                    return f_123_25417_25456(); DynAbs.Tracing.TraceSender.TraceExitMethod(123, 25414, 25456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 25414, 25456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 25414, 25456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<string> ParseResponseFile(string fullPath, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 25635, 26452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25749, 25789);

                List<string>
                lines = f_123_25770_25788()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25839, 25888);

                    f_123_25839_25887(f_123_25852_25886(fullPath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25906, 25963);

                    using TextReader
                    reader = f_123_25932_25962(this, fullPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 25981, 25993);

                    string?
                    str
                    = default(string?);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26011, 26127) || true) && ((str = f_123_26025_26042(reader)) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 26011, 26127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26093, 26108);

                            f_123_26093_26107(lines, str);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 26011, 26127);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 26011, 26127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(123, 26011, 26127);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 26156, 26392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26206, 26303);

                    f_123_26206_26302(errors, f_123_26217_26301(_messageProvider, f_123_26253_26290(_messageProvider), fullPath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26321, 26377);

                    return f_123_26328_26376();
                    DynAbs.Tracing.TraceSender.TraceExitCatch(123, 26156, 26392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26408, 26441);

                return f_123_26415_26440(lines);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 25635, 26452);

                System.Collections.Generic.List<string>
                f_123_25770_25788()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25770, 25788);
                    return return_v;
                }


                bool
                f_123_25852_25886(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25852, 25886);
                    return return_v;
                }


                int
                f_123_25839_25887(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25839, 25887);
                    return 0;
                }


                System.IO.TextReader
                f_123_25932_25962(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                fullPath)
                {
                    var return_v = this_param.CreateTextFileReader(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 25932, 25962);
                    return return_v;
                }


                string?
                f_123_26025_26042(System.IO.TextReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26025, 26042);
                    return return_v;
                }


                int
                f_123_26093_26107(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26093, 26107);
                    return 0;
                }


                int
                f_123_26253_26290(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_OpenResponseFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 26253, 26290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_26217_26301(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26217, 26301);
                    return return_v;
                }


                int
                f_123_26206_26302(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26206, 26302);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_26328_26376()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26328, 26376);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_26415_26440(System.Collections.Generic.List<string>
                lines)
                {
                    var return_v = ParseResponseLines((System.Collections.Generic.IEnumerable<string>)lines);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26415, 26440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 25635, 26452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 25635, 26452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> ParseResponseLines(IEnumerable<string> lines)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 26648, 27018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26754, 26798);

                List<string>
                arguments = f_123_26779_26797()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26814, 26974);
                    foreach (string line in f_123_26838_26843_I(lines))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 26814, 26974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26877, 26959);

                        f_123_26877_26958(arguments, f_123_26896_26957(line, removeHashComments: true));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 26814, 26974);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 26990, 27007);

                return arguments;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 26648, 27018);

                System.Collections.Generic.List<string>
                f_123_26779_26797()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26779, 26797);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_26896_26957(string
                commandLine, bool
                removeHashComments)
                {
                    var return_v = SplitCommandLineIntoArguments(commandLine, removeHashComments: removeHashComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26896, 26957);
                    return return_v;
                }


                int
                f_123_26877_26958(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26877, 26958);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_26838_26843_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 26838, 26843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 26648, 27018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 26648, 27018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_resourceSeparators;

        internal static void ParseResourceDescription(
                    string resourceDescriptor,
                    string? baseDirectory,
                    bool skipLeadingSeparators, //VB does this
                    out string? filePath,
                    out string? fullPath,
                    out string? fileName,
                    out string resourceName,
                    out string? accessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 27104, 29123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27490, 27506);

                filePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27520, 27536);

                fullPath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27550, 27566);

                fileName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27580, 27598);

                resourceName = "";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27612, 27633);

                accessibility = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27735, 27826);

                string[]
                parts = f_123_27752_27825(f_123_27752_27815(resourceDescriptor, s_resourceSeparators))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27842, 27857);

                int
                offset = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27873, 27899);

                int
                length = f_123_27886_27898(parts)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27915, 28136) || true) && (skipLeadingSeparators)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 27915, 28136);
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27974, 28084) || true) && (offset < length && (DynAbs.Tracing.TraceSender.Expression_True(123, 27981, 28035) && f_123_28000_28035(parts[offset])))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28037, 28045)
   , offset++, DynAbs.Tracing.TraceSender.TraceExitCondition(123, 27974, 28084))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 27974, 28084);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 111);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 111);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28104, 28121);

                    length -= offset;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 27915, 28136);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28154, 28271) || true) && (length >= 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 28154, 28271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28203, 28256);

                    filePath = f_123_28214_28255(parts[offset + 0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 28154, 28271);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28287, 28408) || true) && (length >= 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 28287, 28408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28336, 28393);

                    resourceName = f_123_28351_28392(parts[offset + 1]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 28287, 28408);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28424, 28546) || true) && (length >= 3)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 28424, 28546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28473, 28531);

                    accessibility = f_123_28489_28530(parts[offset + 2]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 28424, 28546);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28562, 28663) || true) && (f_123_28566_28607(filePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 28562, 28663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28641, 28648);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 28562, 28663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28679, 28726);

                fileName = f_123_28690_28725(filePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28740, 28810);

                fullPath = f_123_28751_28809(filePath, baseDirectory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 28990, 29112) || true) && (f_123_28994_29039(resourceName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 28990, 29112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 29073, 29097);

                    resourceName = fileName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 28990, 29112);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 27104, 29123);

                System.Collections.Generic.IEnumerable<string>
                f_123_27752_27815(string
                str, char[]
                separators)
                {
                    var return_v = ParseSeparatedStrings(str, separators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 27752, 27815);
                    return return_v;
                }


                string[]
                f_123_27752_27825(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 27752, 27825);
                    return return_v;
                }


                int
                f_123_27886_27898(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 27886, 27898);
                    return return_v;
                }


                bool
                f_123_28000_28035(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28000, 28035);
                    return return_v;
                }


                string?
                f_123_28214_28255(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28214, 28255);
                    return return_v;
                }


                string?
                f_123_28351_28392(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28351, 28392);
                    return return_v;
                }


                string?
                f_123_28489_28530(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28489, 28530);
                    return return_v;
                }


                bool
                f_123_28566_28607(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28566, 28607);
                    return return_v;
                }


                string?
                f_123_28690_28725(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28690, 28725);
                    return return_v;
                }


                string?
                f_123_28751_28809(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28751, 28809);
                    return return_v;
                }


                bool
                f_123_28994_29039(string
                value)
                {
                    var return_v = RoslynString.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 28994, 29039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 27104, 29123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 27104, 29123);
            }
        }

        public static IEnumerable<string> SplitCommandLineIntoArguments(string commandLine, bool removeHashComments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 29279, 29514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 29412, 29503);

                return f_123_29419_29502(commandLine, removeHashComments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 29279, 29514);

                System.Collections.Generic.IEnumerable<string>
                f_123_29419_29502(string
                commandLine, bool
                removeHashComments)
                {
                    var return_v = CommandLineUtilities.SplitCommandLineIntoArguments(commandLine, removeHashComments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 29419, 29502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 29279, 29514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 29279, 29514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull(parameterName: "arg")]
        internal static string? RemoveQuotesAndSlashes(string? arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 30041, 31060);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30183, 30258) || true) && (arg == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 30183, 30258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30232, 30243);

                    return arg;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 30183, 30258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30274, 30319);

                var
                pool = f_123_30285_30318()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30333, 30360);

                var
                builder = pool.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30374, 30384);

                var
                i = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30398, 31003) || true) && (i < f_123_30409_30419(arg))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 30398, 31003);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30453, 30470);

                        var
                        cur = f_123_30463_30469(arg, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30488, 30988);

                        switch (cur)
                        {

                            case '\\':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 30488, 30988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30577, 30613);

                                f_123_30577_30612(builder, arg, ref i);
                                DynAbs.Tracing.TraceSender.TraceBreak(123, 30639, 30645);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 30488, 30988);

                            case '"':
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 30488, 30988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30795, 30799);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceBreak(123, 30825, 30831);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 30488, 30988);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 30488, 30988);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30887, 30907);

                                f_123_30887_30906(builder, cur);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 30933, 30937);

                                i++;
                                DynAbs.Tracing.TraceSender.TraceBreak(123, 30963, 30969);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 30488, 30988);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 30398, 31003);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 30398, 31003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 30398, 31003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31019, 31049);

                return f_123_31026_31048(pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 30041, 31060);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_123_30285_30318()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 30285, 30318);
                    return return_v;
                }


                int
                f_123_30409_30419(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 30409, 30419);
                    return return_v;
                }


                char
                f_123_30463_30469(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 30463, 30469);
                    return return_v;
                }


                int
                f_123_30577_30612(System.Text.StringBuilder
                builder, string
                arg, ref int
                i)
                {
                    ProcessSlashes(builder, arg, ref i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 30577, 30612);
                    return 0;
                }


                System.Text.StringBuilder
                f_123_30887_30906(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 30887, 30906);
                    return return_v;
                }


                string
                f_123_31026_31048(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31026, 31048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 30041, 31060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 30041, 31060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ProcessSlashes(StringBuilder builder, string arg, ref int i)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 31188, 32662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31294, 31326);

                f_123_31294_31325(arg != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31340, 31369);

                f_123_31340_31368(i < f_123_31357_31367(arg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31385, 31404);

                var
                slashCount = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31418, 31541) || true) && (i < f_123_31429_31439(arg) && (DynAbs.Tracing.TraceSender.Expression_True(123, 31425, 31457) && f_123_31443_31449(arg, i) == '\\'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 31418, 31541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31491, 31504);

                        slashCount++;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31522, 31526);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 31418, 31541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 31418, 31541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 31418, 31541);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31557, 32651) || true) && (i < f_123_31565_31575(arg) && (DynAbs.Tracing.TraceSender.Expression_True(123, 31561, 31592) && f_123_31579_31585(arg, i) == '"'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 31557, 32651);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31773, 31915) || true) && (slashCount >= 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 31773, 31915);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31837, 31858);

                            f_123_31837_31857(builder, '\\');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31880, 31896);

                            slashCount -= 2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 31773, 31915);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 31773, 31915);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(123, 31773, 31915);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 31935, 31965);

                    f_123_31935_31964(slashCount >= 0);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32173, 32329) || true) && (slashCount == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 32173, 32329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32290, 32310);

                        f_123_32290_32309(                    // The quote is escaped so eat it.
                                            builder, '"');
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 32173, 32329);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32349, 32353);

                    i++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 31557, 32651);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 31557, 32651);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32498, 32636) || true) && (slashCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 32498, 32636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32561, 32582);

                            f_123_32561_32581(builder, '\\');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32604, 32617);

                            slashCount--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 32498, 32636);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 32498, 32636);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(123, 32498, 32636);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 31557, 32651);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 31188, 32662);

                int
                f_123_31294_31325(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31294, 31325);
                    return 0;
                }


                int
                f_123_31357_31367(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 31357, 31367);
                    return return_v;
                }


                int
                f_123_31340_31368(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31340, 31368);
                    return 0;
                }


                int
                f_123_31429_31439(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 31429, 31439);
                    return return_v;
                }


                char
                f_123_31443_31449(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 31443, 31449);
                    return return_v;
                }


                int
                f_123_31565_31575(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 31565, 31575);
                    return return_v;
                }


                char
                f_123_31579_31585(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 31579, 31585);
                    return return_v;
                }


                System.Text.StringBuilder
                f_123_31837_31857(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31837, 31857);
                    return return_v;
                }


                int
                f_123_31935_31964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 31935, 31964);
                    return 0;
                }


                System.Text.StringBuilder
                f_123_32290_32309(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 32290, 32309);
                    return return_v;
                }


                System.Text.StringBuilder
                f_123_32561_32581(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 32561, 32581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 31188, 32662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 31188, 32662);
            }
        }

        private static IEnumerable<string> Split(string? str, Func<char, bool> splitHere)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 32812, 33368);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32918, 32994) || true) && (str == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 32918, 32994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 32967, 32979);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 32918, 32994);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33010, 33028);

                int
                nextPiece = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33053, 33058);

                    for (int
        c = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33044, 33303) || true) && (c < f_123_33064_33074(str))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33076, 33079)
        , c++, DynAbs.Tracing.TraceSender.TraceExitCondition(123, 33044, 33303))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 33044, 33303);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33113, 33288) || true) && (f_123_33117_33134(splitHere, f_123_33127_33133(str, c)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 33113, 33288);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33176, 33229);

                            listYield.Add(f_123_33189_33228(str, nextPiece, c - nextPiece));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33251, 33269);

                            nextPiece = c + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 33113, 33288);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33319, 33357);

                listYield.Add(f_123_33332_33356(str, nextPiece));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 32812, 33368);

                return listYield;

                int
                f_123_33064_33074(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 33064, 33074);
                    return return_v;
                }


                char
                f_123_33127_33133(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 33127, 33133);
                    return return_v;
                }


                bool
                f_123_33117_33134(System.Func<char, bool>
                this_param, char
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33117, 33134);
                    return return_v;
                }


                string
                f_123_33189_33228(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33189, 33228);
                    return return_v;
                }


                string
                f_123_33332_33356(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33332, 33356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 32812, 33368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 32812, 33368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_pathSeparators;

        private static readonly char[] s_wildcards;

        internal static IEnumerable<string> ParseSeparatedPaths(string? str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 33529, 33756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33622, 33745);

                return f_123_33629_33743(f_123_33629_33712(str, s_pathSeparators, StringSplitOptions.RemoveEmptyEntries), RemoveQuotesAndSlashes)!;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 33529, 33756);

                System.Collections.Generic.IEnumerable<string>
                f_123_33629_33712(string?
                str, char[]
                separators, System.StringSplitOptions
                options)
                {
                    var return_v = ParseSeparatedStrings(str, separators, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33629, 33712);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string?>
                f_123_33629_33743(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, string>
                selector)
                {
                    var return_v = source.Select<string, string?>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 33629, 33743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 33529, 33756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 33529, 33756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable<string> ParseSeparatedStrings(string? str, char[] separators, StringSplitOptions options = StringSplitOptions.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 33895, 34512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34063, 34085);

                bool
                inQuotes = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34101, 34384);

                var
                result = f_123_34114_34383(str, (c =>
                                {
                                    if (c == '\"')
                                    {
                                        inQuotes = !inQuotes;
                                    }

                                    return !inQuotes && separators.Contains(c);
                                }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34400, 34501);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(123, 34407, 34457) || (((options == StringSplitOptions.RemoveEmptyEntries) && DynAbs.Tracing.TraceSender.Conditional_F2(123, 34460, 34491)) || DynAbs.Tracing.TraceSender.Conditional_F3(123, 34494, 34500))) ? f_123_34460_34491(result, s => s.Length > 0) : result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 33895, 34512);

                System.Collections.Generic.IEnumerable<string>
                f_123_34114_34383(string?
                str, System.Func<char, bool>
                splitHere)
                {
                    var return_v = Split(str, splitHere);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34114, 34383);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_34460_34491(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34460, 34491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 33895, 34512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 33895, 34512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<string> ResolveRelativePaths(IEnumerable<string> paths, string baseDirectory, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 34524, 35145);

                var listYield = new List<String>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34673, 35134);
                    foreach (var path in f_123_34694_34699_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 34673, 35134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34733, 34811);

                        string?
                        resolvedPath = f_123_34756_34810(path, baseDirectory)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34829, 35119) || true) && (resolvedPath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 34829, 35119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 34895, 34992);

                            f_123_34895_34991(errors, f_123_34906_34990(_messageProvider, f_123_34942_34983(_messageProvider), path));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 34829, 35119);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 34829, 35119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35074, 35100);

                            listYield.Add(resolvedPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 34829, 35119);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 34673, 35134);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 462);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 34524, 35145);

                return listYield;

                string?
                f_123_34756_34810(string
                path, string
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34756, 34810);
                    return return_v;
                }


                int
                f_123_34942_34983(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 34942, 34983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_34906_34990(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34906, 34990);
                    return return_v;
                }


                int
                f_123_34895_34991(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34895, 34991);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_34694_34699_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 34694, 34699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 34524, 35145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 34524, 35145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected CommandLineSourceFile ToCommandLineSourceFile(string resolvedPath, bool isInputRedirected = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 35157, 35987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35298, 35358);

                string
                extension = f_123_35317_35357(resolvedPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35374, 35392);

                bool
                isScriptFile
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35406, 35880) || true) && (IsScriptCommandLineParser)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 35406, 35880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35469, 35568);

                    isScriptFile = !f_123_35485_35567(extension, f_123_35510_35530(), StringComparison.OrdinalIgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 35406, 35880);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 35406, 35880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35844, 35865);

                    isScriptFile = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 35406, 35880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 35896, 35976);

                return f_123_35903_35975(resolvedPath, isScriptFile, isInputRedirected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 35157, 35987);

                string
                f_123_35317_35357(string
                path)
                {
                    var return_v = PathUtilities.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 35317, 35357);
                    return return_v;
                }


                string
                f_123_35510_35530()
                {
                    var return_v = RegularFileExtension;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 35510, 35530);
                    return return_v;
                }


                bool
                f_123_35485_35567(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 35485, 35567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_123_35903_35975(string
                path, bool
                isScript, bool
                isInputRedirected)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineSourceFile(path, isScript, isInputRedirected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 35903, 35975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 35157, 35987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 35157, 35987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<string> ParseFileArgument(string arg, string? baseDirectory, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 35999, 37314);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36131, 36271);

                f_123_36131_36270(IsScriptCommandLineParser || (DynAbs.Tracing.TraceSender.Expression_False(123, 36144, 36269) || !f_123_36174_36219(arg, "-", StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(123, 36173, 36269) && !f_123_36224_36269(arg, "@", StringComparison.Ordinal))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36484, 36526);

                string
                path = f_123_36498_36525(arg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36542, 36586);

                int
                wildcard = f_123_36557_36585(path, s_wildcards)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36600, 37303) || true) && (wildcard != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 36600, 37303);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36652, 36833);
                        foreach (var file in f_123_36673_36754_I(f_123_36673_36754(this, path, baseDirectory, SearchOption.TopDirectoryOnly, errors)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 36652, 36833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36796, 36814);

                            listYield.Add(file);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 36652, 36833);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 182);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 182);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 36600, 37303);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 36600, 37303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36899, 36977);

                    string?
                    resolvedPath = f_123_36922_36976(path, baseDirectory)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 36995, 37288) || true) && (resolvedPath == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 36995, 37288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37061, 37161);

                        f_123_37061_37160(errors, f_123_37072_37159(f_123_37090_37105(), f_123_37112_37152(f_123_37112_37127()), path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 36995, 37288);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 36995, 37288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37243, 37269);

                        listYield.Add(resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 36995, 37288);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 36600, 37303);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 35999, 37314);

                return listYield;

                bool
                f_123_36174_36219(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36174, 36219);
                    return return_v;
                }


                bool
                f_123_36224_36269(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36224, 36269);
                    return return_v;
                }


                int
                f_123_36131_36270(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36131, 36270);
                    return 0;
                }


                string?
                f_123_36498_36525(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36498, 36525);
                    return return_v;
                }


                int
                f_123_36557_36585(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36557, 36585);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_36673_36754(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                path, string?
                baseDirectory, System.IO.SearchOption
                searchOption, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ExpandFileNamePattern(path, baseDirectory, searchOption, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36673, 36754);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_36673_36754_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36673, 36754);
                    return return_v;
                }


                string?
                f_123_36922_36976(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 36922, 36976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_37090_37105()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 37090, 37105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_37112_37127()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 37112, 37127);
                    return return_v;
                }


                int
                f_123_37112_37152(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 37112, 37152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_37072_37159(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37072, 37159);
                    return return_v;
                }


                int
                f_123_37061_37160(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37061, 37160);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 35999, 37314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 35999, 37314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected IEnumerable<string> ParseSeparatedFileArgument(string value, string? baseDirectory, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 37326, 37784);

                var listYield = new List<String>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37478, 37773);
                    foreach (string path in f_123_37502_37578_I(f_123_37502_37578(f_123_37502_37528(value), (path) => !string.IsNullOrWhiteSpace(path))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 37478, 37773);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37612, 37758);
                            foreach (var file in f_123_37633_37679_I(f_123_37633_37679(this, path, baseDirectory, errors)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 37612, 37758);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37721, 37739);

                                listYield.Add(file);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 37612, 37758);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 147);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 147);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 37478, 37773);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 296);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 37326, 37784);

                return listYield;

                System.Collections.Generic.IEnumerable<string>
                f_123_37502_37528(string
                str)
                {
                    var return_v = ParseSeparatedPaths(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37502, 37528);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_37502_37578(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37502, 37578);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_37633_37679(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                arg, string?
                baseDirectory, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseFileArgument(arg, baseDirectory, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37633, 37679);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_37633_37679_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37633, 37679);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_37502_37578_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37502, 37578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 37326, 37784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 37326, 37784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<CommandLineSourceFile> ParseRecurseArgument(string arg, string? baseDirectory, IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 37796, 38148);

                var listYield = new List<CommandLineSourceFile>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 37946, 38137);
                    foreach (var path in f_123_37967_38045_I(f_123_37967_38045(this, arg, baseDirectory, SearchOption.AllDirectories, errors)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 37946, 38137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38079, 38122);

                        listYield.Add(f_123_38092_38121(this, path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 37946, 38137);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 1, 192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(123, 1, 192);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 37796, 38148);

                return listYield;

                System.Collections.Generic.IEnumerable<string>
                f_123_37967_38045(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                path, string?
                baseDirectory, System.IO.SearchOption
                searchOption, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ExpandFileNamePattern(path, baseDirectory, searchOption, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37967, 38045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_123_38092_38121(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.ToCommandLineSourceFile(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38092, 38121);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_37967_38045_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 37967, 38045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 37796, 38148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 37796, 38148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Encoding? TryParseEncodingName(string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 38160, 38721);
                long codepage = default(long);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38243, 38682) || true) && (!f_123_38248_38278(arg) && (DynAbs.Tracing.TraceSender.Expression_True(123, 38247, 38385) && f_123_38299_38385(arg, NumberStyles.None, f_123_38337_38365(), out codepage)) && (DynAbs.Tracing.TraceSender.Expression_True(123, 38247, 38420) && (codepage > 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 38243, 38682);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38498, 38541);

                        return f_123_38505_38540(codepage);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 38578, 38667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38636, 38648);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(123, 38578, 38667);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 38243, 38682);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38698, 38710);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 38160, 38721);

                bool
                f_123_38248_38278(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38248, 38278);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_123_38337_38365()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 38337, 38365);
                    return return_v;
                }


                bool
                f_123_38299_38385(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out long
                result)
                {
                    var return_v = long.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38299, 38385);
                    return return_v;
                }


                System.Text.Encoding
                f_123_38505_38540(long
                codepage)
                {
                    var return_v = Encoding.GetEncoding((int)codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38505, 38540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 38160, 38721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 38160, 38721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SourceHashAlgorithm TryParseHashAlgorithmName(string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 38733, 39251);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38831, 38978) || true) && (f_123_38835_38897("sha1", arg, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 38831, 38978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38931, 38963);

                    return SourceHashAlgorithm.Sha1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 38831, 38978);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 38994, 39145) || true) && (f_123_38998_39062("sha256", arg, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 38994, 39145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39096, 39130);

                    return SourceHashAlgorithm.Sha256;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 38994, 39145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39208, 39240);

                return SourceHashAlgorithm.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 38733, 39251);

                bool
                f_123_38835_38897(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38835, 38897);
                    return return_v;
                }


                bool
                f_123_38998_39062(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 38998, 39062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 38733, 39251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 38733, 39251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<string> ExpandFileNamePattern(
                    string path,
                    string? baseDirectory,
                    SearchOption searchOption,
                    IList<Diagnostic> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 39263, 42714);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39479, 39536);

                string?
                directory = f_123_39499_39535(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39550, 39599);

                string
                pattern = f_123_39567_39598(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39615, 39787);

                var
                resolvedDirectoryPath = (DynAbs.Tracing.TraceSender.Conditional_F1(123, 39643, 39674) || ((f_123_39643_39674(directory) && DynAbs.Tracing.TraceSender.Conditional_F2(123, 39694, 39707)) || DynAbs.Tracing.TraceSender.Conditional_F3(123, 39727, 39786))) ? baseDirectory : f_123_39727_39786(directory, baseDirectory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39803, 39842);

                IEnumerator<string>?
                enumerator = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 39892, 39913);

                    bool
                    yielded = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40188, 40237);

                    pattern = f_123_40198_40236(pattern, s_searchPatternTrimChars);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40255, 40333);

                    bool
                    singleDotPattern = f_123_40279_40332(pattern, ".", StringComparison.Ordinal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40353, 41899) || true) && (!singleDotPattern)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 40353, 41899);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40416, 41880) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 40416, 41880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40477, 40505);

                                string?
                                resolvedPath = null
                                ;
                                try
                                {

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40591, 40800) || true) && (enumerator == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 40591, 40800);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40679, 40769);

                                        enumerator = f_123_40692_40768(f_123_40692_40752(this, resolvedDirectoryPath, pattern, searchOption));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 40591, 40800);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40832, 40961) || true) && (!f_123_40837_40858(enumerator))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 40832, 40961);
                                        DynAbs.Tracing.TraceSender.TraceBreak(123, 40924, 40930);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 40832, 40961);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 40993, 41027);

                                    resolvedPath = f_123_41008_41026(enumerator);
                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 41080, 41189);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41142, 41162);

                                    resolvedPath = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(123, 41080, 41189);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41217, 41489) || true) && (resolvedPath != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 41217, 41489);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41384, 41462);

                                    resolvedPath = f_123_41399_41461(resolvedPath, baseDirectory);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 41217, 41489);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41517, 41762) || true) && (resolvedPath == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 41517, 41762);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41599, 41699);

                                    f_123_41599_41698(errors, f_123_41610_41697(f_123_41628_41643(), f_123_41650_41690(f_123_41650_41665()), path));
                                    DynAbs.Tracing.TraceSender.TraceBreak(123, 41729, 41735);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 41517, 41762);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41790, 41805);

                                yielded = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41831, 41857);

                                listYield.Add(resolvedPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(123, 40416, 41880);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(123, 40416, 41880);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(123, 40416, 41880);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 40353, 41899);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 41975, 42515) || true) && (!yielded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 41975, 42515);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 42029, 42496) || true) && (searchOption == SearchOption.AllDirectories)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 42029, 42496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 42172, 42224);

                            f_123_42172_42223(this, path, errors);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 42029, 42496);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 42029, 42496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 42381, 42473);

                            f_123_42381_42472(                        // handling wildcard in file spec
                                                    errors, f_123_42392_42471(f_123_42410_42425(), f_123_42432_42464(f_123_42432_42447()), path));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(123, 42029, 42496);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 41975, 42515);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(123, 42544, 42703);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 42584, 42688) || true) && (enumerator != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 42584, 42688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 42648, 42669);

                        f_123_42648_42668(enumerator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 42584, 42688);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(123, 42544, 42703);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 39263, 42714);

                return listYield;

                string?
                f_123_39499_39535(string
                path)
                {
                    var return_v = PathUtilities.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 39499, 39535);
                    return return_v;
                }


                string?
                f_123_39567_39598(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 39567, 39598);
                    return return_v;
                }


                bool
                f_123_39643_39674(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 39643, 39674);
                    return return_v;
                }


                string?
                f_123_39727_39786(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 39727, 39786);
                    return return_v;
                }


                string
                f_123_40198_40236(string
                this_param, params char[]
                trimChars)
                {
                    var return_v = this_param.Trim(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 40198, 40236);
                    return return_v;
                }


                bool
                f_123_40279_40332(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 40279, 40332);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_123_40692_40752(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string?
                directory, string
                fileNamePattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = this_param.EnumerateFiles(directory, fileNamePattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 40692, 40752);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_123_40692_40768(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 40692, 40768);
                    return return_v;
                }


                bool
                f_123_40837_40858(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 40837, 40858);
                    return return_v;
                }


                string
                f_123_41008_41026(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 41008, 41026);
                    return return_v;
                }


                string?
                f_123_41399_41461(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 41399, 41461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_41628_41643()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 41628, 41643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_41650_41665()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 41650, 41665);
                    return return_v;
                }


                int
                f_123_41650_41690(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 41650, 41690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_41610_41697(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 41610, 41697);
                    return return_v;
                }


                int
                f_123_41599_41698(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 41599, 41698);
                    return 0;
                }


                int
                f_123_42172_42223(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string
                path, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    this_param.GenerateErrorForNoFilesFoundInRecurse(path, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 42172, 42223);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_42410_42425()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 42410, 42425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_123_42432_42447()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 42432, 42447);
                    return return_v;
                }


                int
                f_123_42432_42464(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_FileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 42432, 42464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_123_42392_42471(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 42392, 42471);
                    return return_v;
                }


                int
                f_123_42381_42472(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 42381, 42472);
                    return 0;
                }


                int
                f_123_42648_42668(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 42648, 42668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 39263, 42714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 39263, 42714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void GenerateErrorForNoFilesFoundInRecurse(string path, IList<Diagnostic> errors);

        internal ReportDiagnostic GetDiagnosticOptionsFromRulesetFile(string? fullPath, out Dictionary<string, ReportDiagnostic> diagnosticOptions, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 42838, 43159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43033, 43148);

                return f_123_43040_43147(fullPath, out diagnosticOptions, diagnostics, _messageProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(123, 42838, 43159);

                Microsoft.CodeAnalysis.ReportDiagnostic
                f_123_43040_43147(string?
                rulesetFileFullPath, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                diagnosticOptions, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProviderOpt)
                {
                    var return_v = RuleSet.GetDiagnosticOptionsFromRulesetFile(rulesetFileFullPath, out diagnosticOptions, diagnosticsOpt, messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 43040, 43147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 42838, 43159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 42838, 43159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseUInt64(string? value, out ulong result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 43527, 44288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43620, 43631);

                result = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43647, 43746) || true) && (f_123_43651_43684(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 43647, 43746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43718, 43731);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 43647, 43746);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43762, 43779);

                int
                numBase = 10
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43795, 44060) || true) && (f_123_43799_43857(value, "0x", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 43795, 44060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43891, 43904);

                    numBase = 16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 43795, 44060);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 43795, 44060);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 43938, 44060) || true) && (f_123_43942_43999(value, "0", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 43938, 44060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44033, 44045);

                        numBase = 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 43938, 44060);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 43795, 44060);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44112, 44154);

                    result = f_123_44121_44153(value, numBase);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 44183, 44249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44221, 44234);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(123, 44183, 44249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44265, 44277);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 43527, 44288);

                bool
                f_123_43651_43684(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 43651, 43684);
                    return return_v;
                }


                bool
                f_123_43799_43857(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 43799, 43857);
                    return return_v;
                }


                bool
                f_123_43942_43999(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 43942, 43999);
                    return return_v;
                }


                ulong
                f_123_44121_44153(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToUInt64(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 44121, 44153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 43527, 44288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 43527, 44288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseUInt16(string? value, out ushort result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 44656, 45418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44750, 44761);

                result = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44777, 44876) || true) && (f_123_44781_44814(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 44777, 44876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44848, 44861);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 44777, 44876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44892, 44909);

                int
                numBase = 10
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 44925, 45190) || true) && (f_123_44929_44987(value, "0x", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 44925, 45190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45021, 45034);

                    numBase = 16;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 44925, 45190);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 44925, 45190);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45068, 45190) || true) && (f_123_45072_45129(value, "0", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(123, 45068, 45190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45163, 45175);

                        numBase = 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(123, 45068, 45190);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(123, 44925, 45190);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45242, 45284);

                    result = f_123_45251_45283(value, numBase);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(123, 45313, 45379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45351, 45364);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(123, 45313, 45379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45395, 45407);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 44656, 45418);

                bool
                f_123_44781_44814(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 44781, 44814);
                    return return_v;
                }


                bool
                f_123_44929_44987(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 44929, 44987);
                    return return_v;
                }


                bool
                f_123_45072_45129(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 45072, 45129);
                    return return_v;
                }


                ushort
                f_123_45251_45283(string
                value, int
                fromBase)
                {
                    var return_v = Convert.ToUInt16(value, fromBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 45251, 45283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 44656, 45418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 44656, 45418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableDictionary<string, string> ParseFeatures(List<string> features)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(123, 45430, 45739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45543, 45609);

                var
                builder = f_123_45557_45608()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45623, 45685);

                f_123_45623_45684(builder, features);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 45699, 45728);

                return f_123_45706_45727(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(123, 45430, 45739);

                System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                f_123_45557_45608()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 45557, 45608);
                    return return_v;
                }


                int
                f_123_45623_45684(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                builder, System.Collections.Generic.List<string>
                values)
                {
                    CompilerOptionParseUtilities.ParseFeatures((System.Collections.Generic.IDictionary<string, string>)builder, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 45623, 45684);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_123_45706_45727(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 45706, 45727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 45430, 45739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 45430, 45739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<KeyValuePair<string, string>> SortPathMap(ImmutableArray<KeyValuePair<string, string>> pathMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(123, 46223, 46287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 46226, 46287);
                return pathMap.Sort((x, y) => -x.Key.Length.CompareTo(y.Key.Length)); DynAbs.Tracing.TraceSender.TraceExitMethod(123, 46223, 46287);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(123, 46223, 46287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 46223, 46287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandLineParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(123, 598, 46295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 810, 905);
            s_searchPatternTrimChars = new char[] { '\t', '\n', '\v', '\f', '\r', ' ', '\x0085', '\x00a0' }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 938, 993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 27061, 27091);
            s_resourceSeparators = new char[] { ',' }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33411, 33442);
            s_pathSeparators = new char[] { ';', ',' }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(123, 33484, 33516);
            s_wildcards = new[] { '*', '?' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(123, 598, 46295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(123, 598, 46295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(123, 598, 46295);

        static int
        f_123_1128_1171(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(123, 1128, 1171);
            return 0;
        }


        static string
        f_123_25417_25456()
        {
            var return_v = CodeAnalysisResources.MismatchedVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(123, 25417, 25456);
            return return_v;
        }

    }
}
