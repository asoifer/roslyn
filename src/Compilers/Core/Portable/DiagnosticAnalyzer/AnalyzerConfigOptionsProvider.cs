// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class AnalyzerConfigOptionsProvider
    {
        public abstract AnalyzerConfigOptions GlobalOptions { get; }

        public abstract AnalyzerConfigOptions GetOptions(SyntaxTree tree);

        public abstract AnalyzerConfigOptions GetOptions(AdditionalText textFile);

        public AnalyzerConfigOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(220, 378, 1018);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(220, 378, 1018);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(220, 378, 1018);
        }


        static AnalyzerConfigOptionsProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(220, 378, 1018);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(220, 378, 1018);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(220, 378, 1018);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(220, 378, 1018);
    }
}
