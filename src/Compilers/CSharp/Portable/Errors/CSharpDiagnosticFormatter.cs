// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    public class CSharpDiagnosticFormatter : DiagnosticFormatter
    {
        internal CSharpDiagnosticFormatter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10607, 333, 391);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10607, 333, 391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10607, 333, 391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10607, 333, 391);
            }
        }

        public static new CSharpDiagnosticFormatter Instance { get; }

        static CSharpDiagnosticFormatter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10607, 256, 506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10607, 403, 499);
            Instance = f_10607_467_498(); 
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10607, 256, 506);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10607, 256, 506);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10607, 256, 506);

        static Microsoft.CodeAnalysis.CSharp.CSharpDiagnosticFormatter
        f_10607_467_498()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpDiagnosticFormatter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10607, 467, 498);
            return return_v;
        }

    }
}
