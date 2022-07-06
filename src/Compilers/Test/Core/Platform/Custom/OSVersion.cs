// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Roslyn.Test.Utilities
{
    public static class OSVersion
    {
        public static bool IsWin8
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(25145, 462, 528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25145, 478, 528);
                    return f_25145_478_520(f_25145_478_514(f_25145_478_506())) >= 9200; DynAbs.Tracing.TraceSender.TraceExitMethod(25145, 462, 528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25145, 462, 528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25145, 462, 528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static OSVersion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25145, 269, 536);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25145, 269, 536);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25145, 269, 536);
        }


        static System.OperatingSystem
        f_25145_478_506()
        {
            var return_v = System.Environment.OSVersion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25145, 478, 506);
            return return_v;
        }


        static System.Version
        f_25145_478_514(System.OperatingSystem
        this_param)
        {
            var return_v = this_param.Version;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25145, 478, 514);
            return return_v;
        }


        static int
        f_25145_478_520(System.Version
        this_param)
        {
            var return_v = this_param.Build;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25145, 478, 520);
            return return_v;
        }

    }
}
