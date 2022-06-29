// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract class CompilationEvent
    {
        internal CompilationEvent(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(246, 318, 435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(246, 447, 486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(246, 393, 424);

                this.Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(246, 318, 435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(246, 318, 435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(246, 318, 435);
            }
        }

        public Compilation Compilation { get; }

        static CompilationEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(246, 261, 493);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(246, 261, 493);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(246, 261, 493);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(246, 261, 493);
    }
}
