// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerDriver
    {
        private sealed class EventProcessedState
        {
            public static readonly EventProcessedState Processed;

            public static readonly EventProcessedState NotProcessed;

            public EventProcessedStateKind Kind { get; }

            public ImmutableArray<DiagnosticAnalyzer> SubsetProcessedAnalyzers { get; }

            private EventProcessedState(EventProcessedStateKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(224, 1188, 1358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 818, 862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 1278, 1290);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 1308, 1343);

                    SubsetProcessedAnalyzers = default;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(224, 1188, 1358);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(224, 1188, 1358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(224, 1188, 1358);
                }
            }

            private EventProcessedState(ImmutableArray<DiagnosticAnalyzer> subsetProcessedAnalyzers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(224, 1374, 1630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 818, 862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 1495, 1547);

                    SubsetProcessedAnalyzers = subsetProcessedAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 1565, 1615);

                    Kind = EventProcessedStateKind.PartiallyProcessed;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(224, 1374, 1630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(224, 1374, 1630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(224, 1374, 1630);
                }
            }

            public static EventProcessedState CreatePartiallyProcessed(ImmutableArray<DiagnosticAnalyzer> subsetProcessedAnalyzers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(224, 1646, 1870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 1798, 1855);

                    return f_224_1805_1854(subsetProcessedAnalyzers);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(224, 1646, 1870);

                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
                    f_224_1805_1854(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    subsetProcessedAnalyzers)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState(subsetProcessedAnalyzers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(224, 1805, 1854);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(224, 1646, 1870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(224, 1646, 1870);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static EventProcessedState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(224, 489, 1881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 597, 667);
                Processed = f_224_609_667(EventProcessedStateKind.Processed); DynAbs.Tracing.TraceSender.TraceSimpleStatement(224, 725, 801);
                NotProcessed = f_224_740_801(EventProcessedStateKind.NotProcessed); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(224, 489, 1881);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(224, 489, 1881);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(224, 489, 1881);

            static Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
            f_224_609_667(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedStateKind
            kind)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState(kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(224, 609, 667);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState
            f_224_740_801(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedStateKind
            kind)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.EventProcessedState(kind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(224, 740, 801);
                return return_v;
            }

        }

        private enum EventProcessedStateKind
        {
            Processed,
            NotProcessed,
            PartiallyProcessed
        }
    }
}
