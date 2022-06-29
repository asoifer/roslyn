// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class CompilationWithAnalyzersOptions
    {
        private readonly AnalyzerOptions? _options;

        private readonly Action<Exception, DiagnosticAnalyzer, Diagnostic>? _onAnalyzerException;

        private readonly Func<Exception, bool>? _analyzerExceptionFilter;

        private readonly bool _concurrentAnalysis;

        private readonly bool _logAnalyzerExecutionTime;

        private readonly bool _reportSuppressedDiagnostics;

        public AnalyzerOptions? Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 1026, 1037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 1029, 1037);
                    return _options; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 1026, 1037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 1026, 1037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 1026, 1037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Action<Exception, DiagnosticAnalyzer, Diagnostic>? OnAnalyzerException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 1261, 1284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 1264, 1284);
                    return _onAnalyzerException; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 1261, 1284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 1261, 1284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 1261, 1284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Func<Exception, bool>? AnalyzerExceptionFilter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 1507, 1534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 1510, 1534);
                    return _analyzerExceptionFilter; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 1507, 1534);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 1507, 1534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 1507, 1534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ConcurrentAnalysis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 1722, 1744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 1725, 1744);
                    return _concurrentAnalysis; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 1722, 1744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 1722, 1744);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 1722, 1744);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool LogAnalyzerExecutionTime
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 1920, 1948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 1923, 1948);
                    return _logAnalyzerExecutionTime; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 1920, 1948);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 1920, 1948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 1920, 1948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReportSuppressedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(250, 2169, 2200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 2172, 2200);
                    return _reportSuppressedDiagnostics; DynAbs.Tracing.TraceSender.TraceExitMethod(250, 2169, 2200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 2169, 2200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 2169, 2200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CompilationWithAnalyzersOptions(
                    AnalyzerOptions options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic>? onAnalyzerException,
                    bool concurrentAnalysis,
                    bool logAnalyzerExecutionTime)
        : this(f_250_3052_3059_C(options), onAnalyzerException, concurrentAnalysis, logAnalyzerExecutionTime, reportSuppressedDiagnostics: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(250, 2787, 3185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(250, 2787, 3185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 2787, 3185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 2787, 3185);
            }
        }

        public CompilationWithAnalyzersOptions(
                    AnalyzerOptions options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic>? onAnalyzerException,
                    bool concurrentAnalysis,
                    bool logAnalyzerExecutionTime,
                    bool reportSuppressedDiagnostics)
        : this(f_250_4254_4261_C(options), onAnalyzerException, concurrentAnalysis, logAnalyzerExecutionTime, reportSuppressedDiagnostics, analyzerExceptionFilter: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(250, 3942, 4411);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(250, 3942, 4411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 3942, 4411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 3942, 4411);
            }
        }

        public CompilationWithAnalyzersOptions(
                    AnalyzerOptions? options,
                    Action<Exception, DiagnosticAnalyzer, Diagnostic>? onAnalyzerException,
                    bool concurrentAnalysis,
                    bool logAnalyzerExecutionTime,
                    bool reportSuppressedDiagnostics,
                    Func<Exception, bool>? analyzerExceptionFilter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(250, 5303, 6028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 515, 523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 602, 622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 673, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 730, 749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 782, 807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 840, 868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5681, 5700);

                _options = options;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5714, 5757);

                _onAnalyzerException = onAnalyzerException;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5771, 5822);

                _analyzerExceptionFilter = analyzerExceptionFilter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5836, 5877);

                _concurrentAnalysis = concurrentAnalysis;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5891, 5944);

                _logAnalyzerExecutionTime = logAnalyzerExecutionTime;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(250, 5958, 6017);

                _reportSuppressedDiagnostics = reportSuppressedDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(250, 5303, 6028);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(250, 5303, 6028);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 5303, 6028);
            }
        }

        static CompilationWithAnalyzersOptions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(250, 413, 6035);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(250, 413, 6035);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(250, 413, 6035);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(250, 413, 6035);

        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
        f_250_3052_3059_C(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(250, 2787, 3185);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
        f_250_4254_4261_C(Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(250, 3942, 4411);
            return return_v;
        }

    }
}
