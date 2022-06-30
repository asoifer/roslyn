// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal sealed partial class ControlFlowGraphBuilder
    {
        internal class CaptureIdDispenser
        {
            private int _captureId;

            public int GetNextId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(453, 461, 576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(453, 516, 561);

                    return f_453_523_560(ref _captureId);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(453, 461, 576);

                    int
                    f_453_523_560(ref int
                    location)
                    {
                        var return_v = Interlocked.Increment(ref location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(453, 523, 560);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(453, 461, 576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(453, 461, 576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetCurrentId()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(453, 592, 683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(453, 650, 668);

                    return _captureId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(453, 592, 683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(453, 592, 683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(453, 592, 683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public CaptureIdDispenser()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(453, 359, 694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(453, 429, 444);
                this._captureId = -1; DynAbs.Tracing.TraceSender.TraceExitConstructor(453, 359, 694);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(453, 359, 694);
            }


            static CaptureIdDispenser()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(453, 359, 694);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(453, 359, 694);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(453, 359, 694);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(453, 359, 694);
        }
    }
}
