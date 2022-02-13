// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Test.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    internal class MockCSharpCompiler : CSharpCompiler
    {
        private readonly ImmutableArray<DiagnosticAnalyzer> _analyzers;

        private readonly ImmutableArray<ISourceGenerator> _generators;

        internal Compilation Compilation;

        internal AnalyzerOptions AnalyzerOptions;

        public MockCSharpCompiler(string responseFile, string workingDirectory, string[] args, ImmutableArray<DiagnosticAnalyzer> analyzers = default, ImmutableArray<ISourceGenerator> generators = default, AnalyzerAssemblyLoader loader = null)
        : this(f_21013_1091_1103_C(responseFile), f_21013_1105_1139(workingDirectory), args, analyzers, generators, loader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21013, 835, 1199);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21013, 835, 1199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 835, 1199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 835, 1199);
            }
        }

        public MockCSharpCompiler(string responseFile, BuildPaths buildPaths, string[] args, ImmutableArray<DiagnosticAnalyzer> analyzers = default, ImmutableArray<ISourceGenerator> generators = default, AnalyzerAssemblyLoader loader = null)
        : base(f_21013_1465_1496_C(f_21013_1465_1496()), responseFile, args, buildPaths, f_21013_1530_1571("LIB"), loader ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.AnalyzerAssemblyLoader?>(21013, 1573, 1618) ?? f_21013_1583_1618()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21013, 1211, 1745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 760, 771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 807, 822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 1644, 1681);

                _analyzers = analyzers.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 1695, 1734);

                _generators = generators.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21013, 1211, 1745);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 1211, 1745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 1211, 1745);
            }
        }

        private static BuildPaths CreateBuildPaths(string workingDirectory, string sdkDirectory = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21013, 1853, 1921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 1856, 1921);
                return f_21013_1856_1921(workingDirectory, sdkDirectory); DynAbs.Tracing.TraceSender.TraceExitMethod(21013, 1853, 1921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 1853, 1921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 1853, 1921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ResolveAnalyzersFromArguments(
                    List<DiagnosticInfo> diagnostics,
                    CommonMessageProvider messageProvider,
                    bool skipAnalyzers,
                    out ImmutableArray<DiagnosticAnalyzer> analyzers,
                    out ImmutableArray<ISourceGenerator> generators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21013, 1934, 2684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2270, 2381);

                //LAFHIS
                base.ResolveAnalyzersFromArguments(diagnostics, messageProvider, skipAnalyzers, out analyzers, out generators);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 2270, 2380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2395, 2525) || true) && (f_21013_2399_2427_M(!_analyzers.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21013, 2395, 2525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2461, 2510);

                    analyzers = analyzers.InsertRange(0, _analyzers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21013, 2395, 2525);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2539, 2673) || true) && (f_21013_2543_2572_M(!_generators.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21013, 2539, 2673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2606, 2658);

                    generators = generators.InsertRange(0, _generators);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21013, 2539, 2673);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21013, 1934, 2684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 1934, 2684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 1934, 2684);
            }
        }

        public Compilation CreateCompilation(
                    TextWriter consoleOutput,
                    TouchedFileLogger touchedFilesLogger,
                    ErrorLogger errorLogger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21013, 2875, 3011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 2878, 3011);
                return f_21013_2878_3011(this, consoleOutput, touchedFilesLogger, errorLogger, syntaxDiagOptionsOpt: default, globalDiagnosticOptionsOpt: default); DynAbs.Tracing.TraceSender.TraceExitMethod(21013, 2875, 3011);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 2875, 3011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 2875, 3011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Compilation CreateCompilation(
                    TextWriter consoleOutput,
                    TouchedFileLogger touchedFilesLogger,
                    ErrorLogger errorLogger,
                    ImmutableArray<AnalyzerConfigOptionsResult> syntaxDiagOptionsOpt,
                    AnalyzerConfigOptionsResult globalDiagnosticOptionsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21013, 3024, 3550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 3371, 3506);

                Compilation = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateCompilation(consoleOutput, touchedFilesLogger, errorLogger, syntaxDiagOptionsOpt, globalDiagnosticOptionsOpt), 21013, 3385, 3505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 3520, 3539);

                return Compilation;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21013, 3024, 3550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 3024, 3550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 3024, 3550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override AnalyzerOptions CreateAnalyzerOptions(
                    ImmutableArray<AdditionalText> additionalTextFiles,
                    AnalyzerConfigOptionsProvider analyzerConfigOptionsProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21013, 3562, 3928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 3783, 3880);

                AnalyzerOptions = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateAnalyzerOptions(additionalTextFiles, analyzerConfigOptionsProvider), 21013, 3801, 3879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21013, 3894, 3917);

                return AnalyzerOptions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21013, 3562, 3928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21013, 3562, 3928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 3562, 3928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MockCSharpCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21013, 527, 3935);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21013, 527, 3935);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21013, 527, 3935);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21013, 527, 3935);

        static Microsoft.CodeAnalysis.BuildPaths
        f_21013_1105_1139(string
        workingDirectory)
        {
            var return_v = CreateBuildPaths(workingDirectory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 1105, 1139);
            return return_v;
        }


        static string
        f_21013_1091_1103_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(21013, 835, 1199);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
        f_21013_1465_1496()
        {
            var return_v = CSharpCommandLineParser.Default;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21013, 1465, 1496);
            return return_v;
        }


        static string?
        f_21013_1530_1571(string
        variable)
        {
            var return_v = Environment.GetEnvironmentVariable(variable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 1530, 1571);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DefaultAnalyzerAssemblyLoader
        f_21013_1583_1618()
        {
            var return_v = new Microsoft.CodeAnalysis.DefaultAnalyzerAssemblyLoader();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 1583, 1618);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
        f_21013_1465_1496_C(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(21013, 1211, 1745);
            return return_v;
        }


        static Microsoft.CodeAnalysis.BuildPaths
        f_21013_1856_1921(string
        workingDirectory, string?
        sdkDirectory)
        {
            var return_v = RuntimeUtilities.CreateBuildPaths(workingDirectory, sdkDirectory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 1856, 1921);
            return return_v;
        }


        bool
        f_21013_2399_2427_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21013, 2399, 2427);
            return return_v;
        }


        bool
        f_21013_2543_2572_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21013, 2543, 2572);
            return return_v;
        }


        Microsoft.CodeAnalysis.Compilation
        f_21013_2878_3011(Microsoft.CodeAnalysis.CSharp.Test.Utilities.MockCSharpCompiler
        this_param, System.IO.TextWriter
        consoleOutput, Microsoft.CodeAnalysis.TouchedFileLogger
        touchedFilesLogger, Microsoft.CodeAnalysis.ErrorLogger
        errorLogger, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
        syntaxDiagOptionsOpt, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
        globalDiagnosticOptionsOpt)
        {
            var return_v = this_param.CreateCompilation(consoleOutput, touchedFilesLogger, errorLogger, syntaxDiagOptionsOpt: syntaxDiagOptionsOpt, globalDiagnosticOptionsOpt: globalDiagnosticOptionsOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21013, 2878, 3011);
            return return_v;
        }

    }
}
