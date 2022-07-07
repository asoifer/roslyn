// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Roslyn.Utilities
{
    internal static class ValueTaskFactory
    {
        [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "This is a ValueTask wrapper, not an asynchronous method.")]
        public static ValueTask<T> FromResult<T>(T result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(395, 769, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(395, 772, 783);
                return f_395_772_783(result);

                System.Threading.Tasks.ValueTask<T>
f_395_772_783(T?
result)
                {
                    var return_v = new System.Threading.Tasks.ValueTask<T>(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(395, 772, 783);
                    return return_v;
                }

                DynAbs.Tracing.TraceSender.TraceExitMethod(395, 769, 783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(395, 769, 783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(395, 769, 783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ValueTask CompletedTask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(395, 847, 855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(395, 850, 855);
                    return f_395_850_855();

                    System.Threading.Tasks.ValueTask
f_395_850_855()
                    {
                        var return_v = new System.Threading.Tasks.ValueTask();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(395, 850, 855);
                        return return_v;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(395, 847, 855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(395, 847, 855);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(395, 847, 855);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ValueTaskFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(395, 486, 863);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(395, 486, 863);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(395, 486, 863);
        }

    }
}
