// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Threading;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public static class DiagnosticAnalyzerExtensions
    {
        public static CompilationWithAnalyzers WithAnalyzers(this Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, AnalyzerOptions? options = null, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(261, 895, 1227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(261, 1128, 1216);

                return f_261_1135_1215(compilation, analyzers, options, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(261, 895, 1227);

                Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                f_261_1135_1215(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions?
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers(compilation, analyzers, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(261, 1135, 1215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(261, 895, 1227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(261, 895, 1227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CompilationWithAnalyzers WithAnalyzers(this Compilation compilation, ImmutableArray<DiagnosticAnalyzer> analyzers, CompilationWithAnalyzersOptions analysisOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(261, 1691, 1981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(261, 1893, 1970);

                return f_261_1900_1969(compilation, analyzers, analysisOptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(261, 1691, 1981);

                Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers
                f_261_1900_1969(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzersOptions
                analysisOptions)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilationWithAnalyzers(compilation, analyzers, analysisOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(261, 1900, 1969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(261, 1691, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(261, 1691, 1981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticAnalyzerExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(261, 325, 1988);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(261, 325, 1988);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(261, 325, 1988);
        }

    }
}
