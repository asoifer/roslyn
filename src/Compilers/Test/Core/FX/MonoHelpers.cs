// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public static class MonoHelpers
    {
        public static bool IsRunningOnMono()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25014, 387, 448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25014, 390, 448);
                return f_25014_390_448(); DynAbs.Tracing.TraceSender.TraceExitMethod(25014, 387, 448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25014, 387, 448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25014, 387, 448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MonoHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25014, 302, 456);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25014, 302, 456);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25014, 302, 456);
        }


        static bool
        f_25014_390_448()
        {
            var return_v = Roslyn.Test.Utilities.ExecutionConditionUtil.IsMonoDesktop;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25014, 390, 448);
            return return_v;
        }

    }
}
