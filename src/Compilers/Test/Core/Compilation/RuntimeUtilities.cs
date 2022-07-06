// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Roslyn.Test.Utilities;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static partial class RuntimeUtilities
    {
        internal static bool IsDesktopRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25061, 717, 787);

#if NET472
            return true;
#elif NETCOREAPP
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 782, 787);
                    return false;
#elif NETSTANDARD2_0
            throw new PlatformNotSupportedException();
#else
#error Unsupported configuration
#endif
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25061, 717, 787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25061, 717, 787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 717, 787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsCoreClrRuntime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25061, 963, 983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 966, 983);
                    return f_25061_966_983_M(!IsDesktopRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(25061, 963, 983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25061, 963, 983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 963, 983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static BuildPaths CreateBuildPaths(string workingDirectory, string sdkDirectory = null, string tempDirectory = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25061, 996, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 1146, 1198);

                tempDirectory = tempDirectory ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(25061, 1162, 1197) ?? f_25061_1179_1197());

#if NET472
            return new BuildPaths(
                clientDir: Path.GetDirectoryName(typeof(BuildPathsUtil).Assembly.Location),
                workingDir: workingDirectory,
                sdkDir: sdkDirectory ?? RuntimeEnvironment.GetRuntimeDirectory(),
                tempDir: tempDirectory);
#else
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 1532, 1736);
                return f_25061_1539_1735(clientDir: f_25061_1583_1607(), workingDir: workingDirectory, sdkDir: sdkDirectory, tempDir: tempDirectory);
#endif
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25061, 996, 1755);

                string
                f_25061_1179_1197()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25061, 1179, 1197);
                    return return_v;
                }


                string
                f_25061_1583_1607()
                {
                    var return_v = AppContext.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25061, 1583, 1607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BuildPaths
                f_25061_1539_1735(string
                clientDir, string
                workingDir, string?
                sdkDir, string
                tempDir)
                {
                    var return_v = new Microsoft.CodeAnalysis.BuildPaths(clientDir: clientDir, workingDir: workingDir, sdkDir: sdkDir, tempDir: tempDir);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25061, 1539, 1735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25061, 996, 1755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 996, 1755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IRuntimeEnvironmentFactory GetRuntimeEnvironmentFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25061, 1767, 2199);

#if NET472
            return new Roslyn.Test.Utilities.Desktop.DesktopRuntimeEnvironmentFactory();
#elif NETCOREAPP
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 1985, 2061);
                return f_25061_1992_2060();

                Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironmentFactory
                f_25061_1992_2060()
                {
                    var return_v = new Roslyn.Test.Utilities.CoreClr.CoreCLRRuntimeEnvironmentFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25061, 1992, 2060);
                    return return_v;
                }
#elif NETSTANDARD2_0
            throw new PlatformNotSupportedException();
#else
#error Unsupported configuration
#endif

                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25061, 1767, 2199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25061, 1767, 2199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 1767, 2199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetAssemblyLocation(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25061, 2328, 2461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25061, 2406, 2450);

                return f_25061_2413_2449(f_25061_2413_2440(f_25061_2413_2431(type)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25061, 2328, 2461);

                System.Reflection.TypeInfo
                f_25061_2413_2431(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25061, 2413, 2431);
                    return return_v;
                }


                System.Reflection.Assembly
                f_25061_2413_2440(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25061, 2413, 2440);
                    return return_v;
                }


                string
                f_25061_2413_2449(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25061, 2413, 2449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25061, 2328, 2461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 2328, 2461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuntimeUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25061, 618, 2468);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25061, 618, 2468);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25061, 618, 2468);
        }


        static bool
        f_25061_966_983_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25061, 966, 983);
            return return_v;
        }

    }
}
