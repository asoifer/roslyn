// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    public static class WellKnownDiagnosticTags
    {
        public const string
        Unnecessary = nameof(Unnecessary)
        ;

        public const string
        EditAndContinue = nameof(EditAndContinue)
        ;

        public const string
        Build = nameof(Build)
        ;

        public const string
        Compiler = nameof(Compiler)
        ;

        public const string
        Telemetry = nameof(Telemetry)
        ;

        public const string
        NotConfigurable = nameof(NotConfigurable)
        ;

        public const string
        AnalyzerException = nameof(AnalyzerException)
        ;

        public const string
        CustomObsolete = nameof(CustomObsolete)
        ;

        public const string
        CompilationEnd = nameof(CompilationEnd)
        ;

        static WellKnownDiagnosticTags()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(204, 294, 2295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 508, 541);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 697, 738);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 882, 903);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 1055, 1082);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 1231, 1260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 1475, 1516);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 1712, 1757);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 2001, 2040);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(204, 2248, 2287);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(204, 294, 2295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(204, 294, 2295);
        }

    }
}
