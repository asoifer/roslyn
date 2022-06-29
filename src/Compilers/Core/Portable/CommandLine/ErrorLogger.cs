// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal abstract class ErrorLogger
    {
        public abstract void LogDiagnostic(Diagnostic diagnostic, SuppressionInfo? suppressionInfo);

        public ErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(134, 387, 538);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(134, 387, 538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(134, 387, 538);
        }


        static ErrorLogger()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(134, 387, 538);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(134, 387, 538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(134, 387, 538);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(134, 387, 538);
    }
}
