// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;

namespace Roslyn.Utilities
{
    internal static class PlatformInformation
    {
        public static bool IsWindows
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(355, 748, 786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(355, 751, 786);
                    return Path.DirectorySeparatorChar == '\\'; DynAbs.Tracing.TraceSender.TraceExitMethod(355, 748, 786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(355, 748, 786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(355, 748, 786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsUnix
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(355, 823, 860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(355, 826, 860);
                    return Path.DirectorySeparatorChar == '/'; DynAbs.Tracing.TraceSender.TraceExitMethod(355, 823, 860);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(355, 823, 860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(355, 823, 860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool IsRunningOnMono
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(355, 930, 1257);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(355, 1010, 1057);

                        return !(f_355_1019_1047("Mono.Runtime") is null);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(355, 1094, 1242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(355, 1210, 1223);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(355, 1094, 1242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(355, 930, 1257);

                    System.Type?
                    f_355_1019_1047(string
                    typeName)
                    {
                        var return_v = Type.GetType(typeName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(355, 1019, 1047);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(355, 871, 1268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(355, 871, 1268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PlatformInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(355, 661, 1275);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(355, 661, 1275);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(355, 661, 1275);
        }

    }
}
