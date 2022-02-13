// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class IlasmUtilities
    {
        public static DisposableFile CreateTempAssembly(string declarations, bool prependDefaultHeader = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25023, 440, 864);
                string assemblyPath = default(string);
                string pdbPath = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 567, 721);

                f_25023_567_720(declarations, prependDefaultHeader, includePdb: false, autoInherit: true, assemblyPath: out assemblyPath, pdbPath: out pdbPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 735, 764);

                f_25023_735_763(assemblyPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 778, 799);

                f_25023_778_798(pdbPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 813, 853);

                return f_25023_820_852(assemblyPath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25023, 440, 864);

                int
                f_25023_567_720(string
                declarations, bool
                appendDefaultHeader, bool
                includePdb, bool
                autoInherit, out string
                assemblyPath, out string
                pdbPath)
                {
                    IlasmTempAssembly(declarations, appendDefaultHeader, includePdb: includePdb, autoInherit: autoInherit, out assemblyPath, out pdbPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 567, 720);
                    return 0;
                }


                int
                f_25023_735_763(string
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 735, 763);
                    return 0;
                }


                int
                f_25023_778_798(string
                @object)
                {
                    Assert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 778, 798);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25023_820_852(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 820, 852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25023, 440, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25023, 440, 864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetIlasmPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25023, 876, 2248);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 937, 1394) || true) && (f_25023_941_980())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 937, 1394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1226, 1379);

                    return f_25023_1233_1378(f_25023_1268_1343(f_25023_1290_1342(typeof(object))), "ilasm.exe");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 937, 1394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1410, 1483);

                var
                ilasmExeName = (DynAbs.Tracing.TraceSender.Conditional_F1(25023, 1429, 1458) || ((f_25023_1429_1458() && DynAbs.Tracing.TraceSender.Conditional_F2(25023, 1461, 1472)) || DynAbs.Tracing.TraceSender.Conditional_F3(25023, 1475, 1482))) ? "ilasm.exe" : "ilasm"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1497, 1599);

                var
                directory = f_25023_1513_1598(f_25023_1535_1597(typeof(RuntimeUtilities)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1613, 1628);

                string
                ridName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1642, 2145) || true) && (f_25023_1646_1678())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1642, 2145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1712, 1732);

                    ridName = "win-x64";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1642, 2145);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1642, 2145);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1766, 2145) || true) && (f_25023_1770_1800())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1766, 2145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1834, 1854);

                        ridName = "osx-x64";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1766, 2145);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1766, 2145);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1888, 2145) || true) && (f_25023_1892_1922())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1888, 2145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 1956, 1978);

                            ridName = "linux-x64";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1888, 2145);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 1888, 2145);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2044, 2130);

                            throw f_25023_2050_2129("Runtime platform not supported for testing");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1888, 2145);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1766, 2145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 1642, 2145);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2161, 2237);

                return f_25023_2168_2236(directory, "runtimes", ridName, "native", ilasmExeName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25023, 876, 2248);

                bool
                f_25023_941_980()
                {
                    var return_v = ExecutionConditionUtil.IsWindowsDesktop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 941, 980);
                    return return_v;
                }


                string
                f_25023_1290_1342(System.Type
                type)
                {
                    var return_v = RuntimeUtilities.GetAssemblyLocation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 1290, 1342);
                    return return_v;
                }


                string?
                f_25023_1268_1343(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 1268, 1343);
                    return return_v;
                }


                string
                f_25023_1233_1378(string?
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 1233, 1378);
                    return return_v;
                }


                bool
                f_25023_1429_1458()
                {
                    var return_v = PlatformInformation.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 1429, 1458);
                    return return_v;
                }


                string
                f_25023_1535_1597(System.Type
                type)
                {
                    var return_v = RuntimeUtilities.GetAssemblyLocation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 1535, 1597);
                    return return_v;
                }


                string?
                f_25023_1513_1598(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 1513, 1598);
                    return return_v;
                }


                bool
                f_25023_1646_1678()
                {
                    var return_v = ExecutionConditionUtil.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 1646, 1678);
                    return return_v;
                }


                bool
                f_25023_1770_1800()
                {
                    var return_v = ExecutionConditionUtil.IsMacOS;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 1770, 1800);
                    return return_v;
                }


                bool
                f_25023_1892_1922()
                {
                    var return_v = ExecutionConditionUtil.IsLinux;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 1892, 1922);
                    return return_v;
                }


                System.PlatformNotSupportedException
                f_25023_2050_2129(string
                message)
                {
                    var return_v = new System.PlatformNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2050, 2129);
                    return return_v;
                }


                string
                f_25023_2168_2236(params string[]
                paths)
                {
                    var return_v = Path.Combine(paths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2168, 2236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25023, 876, 2248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25023, 876, 2248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly string IlasmPath;

        public static void IlasmTempAssembly(string declarations, bool appendDefaultHeader, bool includePdb, bool autoInherit, out string assemblyPath, out string pdbPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25023, 2330, 4654);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2518, 2615) || true) && (declarations == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 2518, 2615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2561, 2615);

                    throw f_25023_2567_2614(nameof(declarations));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 2518, 2615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2631, 4643);
                using (var
                sourceFile = f_25023_2655_2691(extension: ".il")
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2725, 2799);

                    string
                    sourceFileName = f_25023_2749_2798(f_25023_2782_2797(sourceFile))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2819, 2969);

                    assemblyPath = f_25023_2834_2968(TempRoot.Root, f_25023_2905_2967(f_25023_2926_2959(f_25023_2943_2958(sourceFile)), "dll"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2989, 3007);

                    string
                    completeIL
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3025, 3634) || true) && (appendDefaultHeader)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 3025, 3634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3090, 3127);

                        const string
                        corLibName = "mscorlib"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3149, 3188);

                        const string
                        corLibVersion = "4:0:0:0"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3210, 3261);

                        const string
                        corLibKey = "B7 7A 5C 56 19 34 E0 89"
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3285, 3458);

                        completeIL =
                        $@".assembly '{sourceFileName}' {{}} 

.assembly extern {corLibName} 
{{
  .publickeytoken = ({corLibKey})
  .ver {corLibVersion}
}} 

{declarations}";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 3025, 3634);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 3025, 3634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3540, 3615);

                        completeIL = f_25023_3553_3614(declarations, "<<GeneratedFileName>>", sourceFileName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 3025, 3634);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3654, 3690);

                    f_25023_3654_3689(
                                    sourceFile, completeIL);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3710, 3820);

                    var
                    arguments = $"\"{f_25023_3731_3746(sourceFile)}\" -DLL {((DynAbs.Tracing.TraceSender.Conditional_F1(25023, 3757, 3768) || ((autoInherit && DynAbs.Tracing.TraceSender.Conditional_F2(25023, 3771, 3773)) || DynAbs.Tracing.TraceSender.Conditional_F3(25023, 3776, 3792))) ? "" : "-noautoinherit")} -out=\"{assemblyPath}\""
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3840, 4173) || true) && (includePdb && (DynAbs.Tracing.TraceSender.Expression_True(25023, 3844, 3888) && !f_25023_3859_3888()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 3840, 4173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 3930, 3982);

                        pdbPath = f_25023_3940_3981(assemblyPath, "pdb");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 4004, 4057);

                        arguments += f_25023_4017_4056(" -PDB=\"{0}\"", pdbPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 3840, 4173);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 3840, 4173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 4139, 4154);

                        pdbPath = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 3840, 4173);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 4193, 4249);

                    var
                    result = f_25023_4206_4248(IlasmPath, arguments)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 4269, 4628) || true) && (f_25023_4273_4294(result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25023, 4269, 4628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 4336, 4609);

                        throw f_25023_4342_4608("The provided IL cannot be compiled." + f_25023_4430_4449() +
                                                IlasmPath + " " + arguments + f_25023_4507_4526() +
                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (result).ToString(), 25023, 4554, 4560), nameof(declarations));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25023, 4269, 4628);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(25023, 2631, 4643);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25023, 2330, 4654);

                System.ArgumentNullException
                f_25023_2567_2614(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2567, 2614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                f_25023_2655_2691(string
                extension)
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DisposableFile(extension: extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2655, 2691);
                    return return_v;
                }


                string
                f_25023_2782_2797(Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 2782, 2797);
                    return return_v;
                }


                string?
                f_25023_2749_2798(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2749, 2798);
                    return return_v;
                }


                string
                f_25023_2943_2958(Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 2943, 2958);
                    return return_v;
                }


                string?
                f_25023_2926_2959(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2926, 2959);
                    return return_v;
                }


                string?
                f_25023_2905_2967(string
                path, string
                extension)
                {
                    var return_v = Path.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2905, 2967);
                    return return_v;
                }


                string
                f_25023_2834_2968(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2834, 2968);
                    return return_v;
                }


                string
                f_25023_3553_3614(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 3553, 3614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.TempFile
                f_25023_3654_3689(Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                this_param, string
                content)
                {
                    var return_v = this_param.WriteAllText(content);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 3654, 3689);
                    return return_v;
                }


                string
                f_25023_3731_3746(Microsoft.CodeAnalysis.Test.Utilities.DisposableFile
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 3731, 3746);
                    return return_v;
                }


                bool
                f_25023_3859_3888()
                {
                    var return_v = MonoHelpers.IsRunningOnMono();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 3859, 3888);
                    return return_v;
                }


                string?
                f_25023_3940_3981(string
                path, string
                extension)
                {
                    var return_v = Path.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 3940, 3981);
                    return return_v;
                }


                string
                f_25023_4017_4056(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 4017, 4056);
                    return return_v;
                }


                Roslyn.Test.Utilities.ProcessResult
                f_25023_4206_4248(string
                fileName, string
                arguments)
                {
                    var return_v = ProcessUtilities.Run(fileName, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 4206, 4248);
                    return return_v;
                }


                bool
                f_25023_4273_4294(Roslyn.Test.Utilities.ProcessResult
                this_param)
                {
                    var return_v = this_param.ContainsErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 4273, 4294);
                    return return_v;
                }


                string
                f_25023_4430_4449()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 4430, 4449);
                    return return_v;
                }


                string
                f_25023_4507_4526()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25023, 4507, 4526);
                    return return_v;
                }


                System.ArgumentException
                f_25023_4342_4608(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 4342, 4608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25023, 2330, 4654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25023, 2330, 4654);
            }
        }

        static IlasmUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25023, 389, 4661);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25023, 2291, 2317);
            IlasmPath = f_25023_2303_2317(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25023, 389, 4661);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25023, 389, 4661);
        }


        static string
        f_25023_2303_2317()
        {
            var return_v = GetIlasmPath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25023, 2303, 2317);
            return return_v;
        }

    }
}
