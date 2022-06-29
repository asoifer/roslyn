// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class DiagnosticSuppressor : DiagnosticAnalyzer
    {
        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(264, 726, 771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(264, 729, 771);
                    return ImmutableArray<DiagnosticDescriptor>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(264, 726, 771);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(264, 726, 771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(264, 726, 771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(264, 816, 987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(264, 904, 976);

                f_264_904_975(context, GeneratedCodeAnalysisFlags.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(264, 816, 987);

                int
                f_264_904_975(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                analysisMode)
                {
                    this_param.ConfigureGeneratedCodeAnalysis(analysisMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(264, 904, 975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(264, 816, 987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(264, 816, 987);
            }
        }

        public abstract ImmutableArray<SuppressionDescriptor> SupportedSuppressions { get; }

        public abstract void ReportSuppressions(SuppressionAnalysisContext context);

        public DiagnosticSuppressor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(264, 472, 2146);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(264, 472, 2146);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(264, 472, 2146);
        }


        static DiagnosticSuppressor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(264, 472, 2146);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(264, 472, 2146);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(264, 472, 2146);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(264, 472, 2146);
    }
}
