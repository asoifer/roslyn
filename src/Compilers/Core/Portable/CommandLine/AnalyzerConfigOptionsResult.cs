// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using AnalyzerOptions = System.Collections.Immutable.ImmutableDictionary<string, string>;
using TreeOptions = System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>;

namespace Microsoft.CodeAnalysis
{

    public readonly struct AnalyzerConfigOptionsResult
    {

        public TreeOptions TreeOptions { get; }

        public AnalyzerOptions AnalyzerOptions { get; }

        public ImmutableArray<Diagnostic> Diagnostics { get; }

        internal AnalyzerConfigOptionsResult(
                    TreeOptions treeOptions,
                    AnalyzerOptions analyzerOptions,
                    ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(119, 1307, 1733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1506, 1540);

                f_119_1506_1539(treeOptions != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1554, 1592);

                f_119_1554_1591(analyzerOptions != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1608, 1634);

                TreeOptions = treeOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1648, 1682);

                AnalyzerOptions = analyzerOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(119, 1696, 1722);

                Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(119, 1307, 1733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(119, 1307, 1733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(119, 1307, 1733);
            }
        }
        static AnalyzerConfigOptionsResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(119, 658, 1740);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(119, 658, 1740);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(119, 658, 1740);
        }

        static int
        f_119_1506_1539(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 1506, 1539);
            return 0;
        }


        static int
        f_119_1554_1591(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(119, 1554, 1591);
            return 0;
        }

    }
}
