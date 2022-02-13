// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public static class ProcessUtilities
    {
        public static ProcessResult Run(
                    string fileName,
                    string arguments,
                    string workingDirectory = null,
                    IEnumerable<KeyValuePair<string, string>> additionalEnvironmentVars = null,
                    string stdInput = null,
                    bool redirectStandardInput = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25025, 579, 3324);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 917, 1006) || true) && (fileName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 917, 1006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 956, 1006);

                    throw f_25025_962_1005(nameof(fileName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 917, 1006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1022, 1441);

                var
                startInfo = new ProcessStartInfo
                {
                    FileName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => fileName, 25025, 1038, 1440),
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    RedirectStandardInput = stdInput != null || (DynAbs.Tracing.TraceSender.Expression_False(25025, 1330, 1371) || redirectStandardInput),
                    WorkingDirectory = workingDirectory
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1698, 1799) || true) && (stdInput == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 1698, 1799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1752, 1784);

                    startInfo.CreateNoWindow = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 1698, 1799);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1815, 2056) || true) && (additionalEnvironmentVars != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 1815, 2056);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1886, 2041);
                        foreach (var entry in f_25025_1908_1933_I(additionalEnvironmentVars))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 1886, 2041);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 1975, 2022);

                            f_25025_1975_1996(startInfo)[entry.Key] = entry.Value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 1886, 2041);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25025, 1, 156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25025, 1, 156);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 1815, 2056);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2072, 3313);
                using (var
                process = new Process { StartInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => startInfo, 25025, 2093, 2130) }
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2164, 2214);

                    StringBuilder
                    outputBuilder = f_25025_2194_2213()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2232, 2281);

                    StringBuilder
                    errorBuilder = f_25025_2261_2280()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2299, 2491);

                    process.OutputDataReceived += (sender, args) =>
                                    {
                                        if (args.Data != null)
                                            outputBuilder.AppendLine(args.Data);
                                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2509, 2699);

                    process.ErrorDataReceived += (sender, args) =>
                                    {
                                        if (args.Data != null)
                                            errorBuilder.AppendLine(args.Data);
                                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2719, 2735);

                    f_25025_2719_2734(
                                    process);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2755, 2785);

                    f_25025_2755_2784(
                                    process);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2803, 2832);

                    f_25025_2803_2831(process);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2852, 3025) || true) && (stdInput != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 2852, 3025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2914, 2952);

                        f_25025_2914_2951(f_25025_2914_2935(process), stdInput);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 2974, 3006);

                        f_25025_2974_3005(f_25025_2974_2995(process));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 2852, 3025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3045, 3067);

                    f_25025_3045_3066(
                                    process);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3152, 3184);

                    f_25025_3152_3183(f_25025_3165_3182(process));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3204, 3298);

                    return f_25025_3211_3297(f_25025_3229_3245(process), f_25025_3247_3271(outputBuilder), f_25025_3273_3296(errorBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25025, 2072, 3313);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25025, 579, 3324);

                System.ArgumentNullException
                f_25025_962_1005(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 962, 1005);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, string>
                f_25025_1975_1996(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.Environment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 1975, 1996);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                f_25025_1908_1933_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 1908, 1933);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25025_2194_2213()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2194, 2213);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25025_2261_2280()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2261, 2280);
                    return return_v;
                }


                bool
                f_25025_2719_2734(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2719, 2734);
                    return return_v;
                }


                int
                f_25025_2755_2784(System.Diagnostics.Process
                this_param)
                {
                    this_param.BeginOutputReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2755, 2784);
                    return 0;
                }


                int
                f_25025_2803_2831(System.Diagnostics.Process
                this_param)
                {
                    this_param.BeginErrorReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2803, 2831);
                    return 0;
                }


                System.IO.StreamWriter
                f_25025_2914_2935(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 2914, 2935);
                    return return_v;
                }


                int
                f_25025_2914_2951(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2914, 2951);
                    return 0;
                }


                System.IO.StreamWriter
                f_25025_2974_2995(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 2974, 2995);
                    return return_v;
                }


                int
                f_25025_2974_3005(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 2974, 3005);
                    return 0;
                }


                int
                f_25025_3045_3066(System.Diagnostics.Process
                this_param)
                {
                    this_param.WaitForExit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3045, 3066);
                    return 0;
                }


                bool
                f_25025_3165_3182(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.HasExited;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 3165, 3182);
                    return return_v;
                }


                int
                f_25025_3152_3183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3152, 3183);
                    return 0;
                }


                int
                f_25025_3229_3245(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 3229, 3245);
                    return return_v;
                }


                string
                f_25025_3247_3271(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3247, 3271);
                    return return_v;
                }


                string
                f_25025_3273_3296(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3273, 3296);
                    return return_v;
                }


                Roslyn.Test.Utilities.ProcessResult
                f_25025_3211_3297(int
                exitCode, string
                output, string
                errors)
                {
                    var return_v = new Roslyn.Test.Utilities.ProcessResult(exitCode, output, errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3211, 3297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25025, 579, 3324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25025, 579, 3324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Process StartProcess(string fileName, string arguments, string workingDirectory = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25025, 3530, 4290);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3656, 3775) || true) && (fileName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 3656, 3775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3710, 3760);

                    throw f_25025_3716_3759(nameof(fileName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 3656, 3775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 3791, 4166);

                var
                startInfo = new ProcessStartInfo
                {
                    FileName = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => fileName, 25025, 3807, 4165),
                    Arguments = arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = workingDirectory
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4182, 4232);

                Process
                p = new Process { StartInfo = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => startInfo, 25025, 4194, 4231) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4246, 4256);

                f_25025_4246_4255(p);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4270, 4279);

                return p;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25025, 3530, 4290);

                System.ArgumentNullException
                f_25025_3716_3759(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 3716, 3759);
                    return return_v;
                }


                bool
                f_25025_4246_4255(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 4246, 4255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25025, 3530, 4290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25025, 3530, 4290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string RunAndGetOutput(string exeFileName, string arguments = null, int expectedRetCode = 0, string startFolder = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25025, 4302, 5613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4460, 4523);

                ProcessStartInfo
                startInfo = f_25025_4489_4522(exeFileName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4537, 4639) || true) && (arguments != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 4537, 4639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4592, 4624);

                    startInfo.Arguments = arguments;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 4537, 4639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4653, 4674);

                string
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4690, 4722);

                startInfo.CreateNoWindow = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4736, 4776);

                startInfo.RedirectStandardOutput = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4790, 4824);

                startInfo.UseShellExecute = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4840, 4953) || true) && (startFolder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25025, 4840, 4953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4897, 4938);

                    startInfo.WorkingDirectory = startFolder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25025, 4840, 4953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 4969, 5572);
                using (var
                process = f_25025_4990_5033(startInfo)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 5305, 5349);

                    result = f_25025_5314_5348(f_25025_5314_5336(process));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 5367, 5389);

                    f_25025_5367_5388(process);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 5407, 5557);

                    f_25025_5407_5556(expectedRetCode == f_25025_5438_5454(process), $"Unexpected exit code: {f_25025_5481_5497(process)} (expecting {expectedRetCode}). Process output: {result}");
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25025, 4969, 5572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25025, 5588, 5602);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25025, 4302, 5613);

                System.Diagnostics.ProcessStartInfo
                f_25025_4489_4522(string
                fileName)
                {
                    var return_v = new System.Diagnostics.ProcessStartInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 4489, 4522);
                    return return_v;
                }


                System.Diagnostics.Process
                f_25025_4990_5033(System.Diagnostics.ProcessStartInfo
                startInfo)
                {
                    var return_v = System.Diagnostics.Process.Start(startInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 4990, 5033);
                    return return_v;
                }


                System.IO.StreamReader
                f_25025_5314_5336(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.StandardOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 5314, 5336);
                    return return_v;
                }


                string
                f_25025_5314_5348(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 5314, 5348);
                    return return_v;
                }


                int
                f_25025_5367_5388(System.Diagnostics.Process
                this_param)
                {
                    this_param.WaitForExit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 5367, 5388);
                    return 0;
                }


                int
                f_25025_5438_5454(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 5438, 5454);
                    return return_v;
                }


                int
                f_25025_5481_5497(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.ExitCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25025, 5481, 5497);
                    return return_v;
                }


                int
                f_25025_5407_5556(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25025, 5407, 5556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25025, 4302, 5613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25025, 4302, 5613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ProcessUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25025, 382, 5620);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25025, 382, 5620);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25025, 382, 5620);
        }

    }
}
