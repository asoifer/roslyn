// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal sealed class CompilationCompletedEvent : CompilationEvent
    {
        public CompilationCompletedEvent(Compilation compilation) : base(f_245_513_524_C(compilation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(245, 448, 529);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(245, 448, 529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(245, 448, 529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(245, 448, 529);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(245, 539, 643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(245, 597, 632);

                return "CompilationCompletedEvent";
                DynAbs.Tracing.TraceSender.TraceExitMethod(245, 539, 643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(245, 539, 643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(245, 539, 643);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CompilationCompletedEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(245, 365, 650);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(245, 365, 650);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(245, 365, 650);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(245, 365, 650);

        static Microsoft.CodeAnalysis.Compilation
        f_245_513_524_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(245, 448, 529);
            return return_v;
        }

    }
}
