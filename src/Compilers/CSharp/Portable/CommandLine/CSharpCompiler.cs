// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CSharpCompiler : CommonCompiler
    {
        internal const string
        ResponseFileName = "csc.rsp"
        ;

        private readonly CommandLineDiagnosticFormatter _diagnosticFormatter;

        private readonly string? _tempDirectory;

        protected CSharpCompiler(CSharpCommandLineParser parser, string? responseFile, string[] args, BuildPaths buildPaths, string? additionalReferenceDirectories, IAnalyzerAssemblyLoader assemblyLoader)
        : base(f_10972_1141_1147_C(parser), responseFile, args, buildPaths, additionalReferenceDirectories, assemblyLoader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10972, 924, 1474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 841, 861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 897, 911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 1253, 1407);

                _diagnosticFormatter = f_10972_1276_1406(buildPaths.WorkingDirectory, f_10972_1340_1364(f_10972_1340_1349()), f_10972_1366_1405(f_10972_1366_1375()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 1421, 1463);

                _tempDirectory = buildPaths.TempDirectory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10972, 924, 1474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 924, 1474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 924, 1474);
            }
        }

        public override DiagnosticFormatter DiagnosticFormatter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 1544, 1580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 1550, 1578);

                    return _diagnosticFormatter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 1544, 1580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 1486, 1582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 1486, 1582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal new CSharpCommandLineArguments Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 1654, 1712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 1660, 1710);

                    return (CSharpCommandLineArguments)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Arguments, 10972, 1695, 1709);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 1654, 1712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 1592, 1714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 1592, 1714);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Compilation? CreateCompilation(
                    TextWriter consoleOutput,
                    TouchedFileLogger? touchedFilesLogger,
                    ErrorLogger? errorLogger,
                    ImmutableArray<AnalyzerConfigOptionsResult> analyzerConfigOptions,
                    AnalyzerConfigOptionsResult globalConfigOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 1726, 7967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2070, 2112);

                var
                parseOptions = f_10972_2089_2111(f_10972_2089_2098())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2271, 2341);

                var
                scriptParseOptions = f_10972_2296_2340(parseOptions, SourceCodeKind.Script)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2357, 2380);

                bool
                hadErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2396, 2436);

                var
                sourceFiles = f_10972_2414_2435(f_10972_2414_2423())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2450, 2498);

                var
                trees = new SyntaxTree?[sourceFiles.Length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2512, 2570);

                var
                normalizedFilePaths = new string?[sourceFiles.Length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2584, 2632);

                var
                diagnosticBag = f_10972_2604_2631()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2648, 3896) || true) && (f_10972_2652_2696(f_10972_2652_2680(f_10972_2652_2661())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 2648, 3896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 2730, 3372);

                    f_10972_2730_3371(0, sourceFiles.Length, f_10972_2836_3325(i =>
                                        {
                        //NOTE: order of trees is important!!
                        trees[i] = ParseFile(
                                                parseOptions,
                                                scriptParseOptions,
                                                ref hadErrors,
                                                sourceFiles[i],
                                                diagnosticBag,
                                                out normalizedFilePaths[i]);
                                        }), CancellationToken.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 2648, 3896);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 2648, 3896);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 3447, 3452);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 3438, 3881) || true) && (i < sourceFiles.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 3478, 3481)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 3438, 3881))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 3438, 3881);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 3582, 3862);

                            trees[i] = f_10972_3593_3861(this, parseOptions, scriptParseOptions, ref hadErrors, sourceFiles[i], diagnosticBag, out normalizedFilePaths[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 444);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 444);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 2648, 3896);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4026, 4232) || true) && (f_10972_4030_4129(this, f_10972_4048_4081(diagnosticBag), consoleOutput, errorLogger, compilation: null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 4026, 4232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4163, 4187);

                    f_10972_4163_4186(hadErrors);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4205, 4217);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 4026, 4232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4248, 4293);

                var
                diagnostics = f_10972_4266_4292()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4307, 4383);

                var
                uniqueFilePaths = f_10972_4329_4382(f_10972_4349_4381())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4406, 4411);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4397, 5190) || true) && (i < sourceFiles.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4437, 4440)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 4397, 5190))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 4397, 5190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4474, 4522);

                        var
                        normalizedFilePath = normalizedFilePaths[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4540, 4581);

                        f_10972_4540_4580(normalizedFilePath != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4599, 4694);

                        f_10972_4599_4693(sourceFiles[i].IsInputRedirected || (DynAbs.Tracing.TraceSender.Expression_False(10972, 4612, 4692) || f_10972_4648_4692(normalizedFilePath)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4714, 5175) || true) && (!f_10972_4719_4758(uniqueFilePaths, normalizedFilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 4714, 5175);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 4883, 5116);

                            f_10972_4883_5115(                    // warning CS2002: Source file '{0}' specified multiple times
                                                diagnostics, f_10972_4899_5114(f_10972_4918_4933(), ErrorCode.WRN_FileAlreadyIncluded, 
                                                (DynAbs.Tracing.TraceSender.Conditional_F1(10972, 5000, 5024) || 
                                                ((f_10972_5000_5024(f_10972_5000_5009()) && 
                                                DynAbs.Tracing.TraceSender.Conditional_F2(10972, 5027, 5045)) || 
                                                DynAbs.Tracing.TraceSender.Conditional_F3(10972, 5048, 5113))) ? 
                                                normalizedFilePath : f_10972_5048_5113(_diagnosticFormatter, normalizedFilePath)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5140, 5156);

                            trees[i] = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 4714, 5175);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 794);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5206, 5484) || true) && (f_10972_5210_5236(f_10972_5210_5219()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 5206, 5484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5278, 5321);

                    f_10972_5278_5320(touchedFilesLogger is object);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5339, 5469);
                        foreach (var path in f_10972_5360_5375_I(uniqueFilePaths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 5339, 5469);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5417, 5450);

                            f_10972_5417_5449(touchedFilesLogger, path);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 5339, 5469);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 131);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 131);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 5206, 5484);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5500, 5571);

                var
                assemblyIdentityComparer = f_10972_5531_5570()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5585, 5634);

                var
                appConfigPath = f_10972_5605_5633(f_10972_5605_5619(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5648, 6422) || true) && (appConfigPath != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 5648, 6422);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5751, 6002);
                        using (var
                        appConfigStream = f_10972_5780_5841(appConfigPath, FileMode.Open, FileAccess.Read)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 5891, 5979);

                            assemblyIdentityComparer = f_10972_5918_5978(appConfigStream);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(10972, 5751, 6002);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6026, 6171) || true) && (touchedFilesLogger != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 6026, 6171);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6106, 6148);

                            f_10972_6106_6147(touchedFilesLogger, appConfigPath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 6026, 6171);
                        }
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10972, 6208, 6407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6269, 6388);

                        f_10972_6269_6387(diagnostics, f_10972_6285_6386(f_10972_6304_6319(), ErrorCode.ERR_CantReadConfigFile, appConfigPath, f_10972_6375_6385(ex)));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10972, 6208, 6407);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 5648, 6422);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6438, 6532);

                var
                xmlFileResolver = f_10972_6460_6531(f_10972_6487_6510(f_10972_6487_6496()), touchedFilesLogger)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6546, 6695);

                var
                sourceFileResolver = f_10972_6571_6694(ImmutableArray<string>.Empty, f_10972_6631_6654(f_10972_6631_6640()), f_10972_6656_6673(f_10972_6656_6665()), touchedFilesLogger)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6711, 6764);

                MetadataReferenceResolver
                referenceDirectiveResolver
                = default(MetadataReferenceResolver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6778, 6894);

                var
                resolvedReferences = f_10972_6803_6893(this, diagnostics, touchedFilesLogger, out referenceDirectiveResolver)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 6908, 7050) || true) && (f_10972_6912_6989(this, diagnostics, consoleOutput, errorLogger, compilation: null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 6908, 7050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 7023, 7035);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 6908, 7050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 7066, 7158);

                var
                loggingFileSystem = f_10972_7090_7157(touchedFilesLogger, _tempDirectory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 7172, 7283);

                var
                optionsProvider = f_10972_7194_7282(trees, analyzerConfigOptions, globalConfigOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 7299, 7956);

                return f_10972_7306_7955(f_10972_7349_7374(f_10972_7349_7358()), f_10972_7393_7413(trees), resolvedReferences, f_10972_7469_7954(f_10972_7469_7885(f_10972_7469_7815(f_10972_7469_7718(f_10972_7469_7654(f_10972_7469_7577(f_10972_7469_7497(f_10972_7469_7478()), referenceDirectiveResolver), assemblyIdentityComparer), xmlFileResolver), f_10972_7764_7814(f_10972_7764_7773(), loggingFileSystem)), sourceFileResolver), optionsProvider));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 1726, 7967);

                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_2089_2098()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2089, 2098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10972_2089_2111(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.ParseOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2089, 2111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10972_2296_2340(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param, Microsoft.CodeAnalysis.SourceCodeKind
                kind)
                {
                    var return_v = this_param.WithKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 2296, 2340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_2414_2423()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2414, 2423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10972_2414_2435(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2414, 2435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10972_2604_2631()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 2604, 2631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_2652_2661()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2652, 2661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_2652_2680(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.CompilationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2652, 2680);
                    return return_v;
                }


                bool
                f_10972_2652_2696(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 2652, 2696);
                    return return_v;
                }


                System.Action<int>
                f_10972_2836_3325(System.Action<int>
                action)
                {
                    var return_v = UICultureUtilities.WithCurrentUICulture<int>(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 2836, 3325);
                    return return_v;
                }


                System.Threading.Tasks.ParallelLoopResult
                f_10972_2730_3371(int
                fromInclusive, int
                toExclusive, System.Action<int>
                body, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = RoslynParallel.For(fromInclusive, toExclusive, body, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 2730, 3371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10972_3593_3861(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                scriptParseOptions, ref bool
                addedDiagnostics, Microsoft.CodeAnalysis.CommandLineSourceFile
                file, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out string?
                normalizedFilePath)
                {
                    var return_v = this_param.ParseFile(parseOptions, scriptParseOptions, ref addedDiagnostics, file, diagnostics, out normalizedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 3593, 3861);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10972_4048_4081(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4048, 4081);
                    return return_v;
                }


                bool
                f_10972_4030_4129(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4030, 4129);
                    return return_v;
                }


                int
                f_10972_4163_4186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4163, 4186);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10972_4266_4292()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4266, 4292);
                    return return_v;
                }


                System.StringComparer
                f_10972_4349_4381()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 4349, 4381);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_10972_4329_4382(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4329, 4382);
                    return return_v;
                }


                int
                f_10972_4540_4580(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4540, 4580);
                    return 0;
                }


                bool
                f_10972_4648_4692(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4648, 4692);
                    return return_v;
                }


                int
                f_10972_4599_4693(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4599, 4693);
                    return 0;
                }


                bool
                f_10972_4719_4758(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4719, 4758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_10972_4918_4933()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 4918, 4933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_5000_5009()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5000, 5009);
                    return return_v;
                }


                bool
                f_10972_5000_5024(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.PrintFullPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5000, 5024);
                    return return_v;
                }


                string
                f_10972_5048_5113(Microsoft.CodeAnalysis.CSharp.CommandLineDiagnosticFormatter
                this_param, string
                normalizedPath)
                {
                    var return_v = this_param.RelativizeNormalizedPath(normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5048, 5113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10972_4899_5114(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4899, 5114);
                    return return_v;
                }


                int
                f_10972_4883_5115(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 4883, 5115);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_5210_5219()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5210, 5219);
                    return return_v;
                }


                string?
                f_10972_5210_5236(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5210, 5236);
                    return return_v;
                }


                int
                f_10972_5278_5320(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5278, 5320);
                    return 0;
                }


                int
                f_10972_5417_5449(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5417, 5449);
                    return 0;
                }


                System.Collections.Generic.HashSet<string>
                f_10972_5360_5375_I(System.Collections.Generic.HashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5360, 5375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_10972_5531_5570()
                {
                    var return_v = DesktopAssemblyIdentityComparer.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5531, 5570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_5605_5619(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5605, 5619);
                    return return_v;
                }


                string?
                f_10972_5605_5633(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.AppConfigPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 5605, 5633);
                    return return_v;
                }


                System.IO.FileStream
                f_10972_5780_5841(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5780, 5841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                f_10972_5918_5978(System.IO.FileStream
                input)
                {
                    var return_v = DesktopAssemblyIdentityComparer.LoadFromXml((System.IO.Stream)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 5918, 5978);
                    return return_v;
                }


                int
                f_10972_6106_6147(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddRead(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6106, 6147);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_10972_6304_6319()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6304, 6319);
                    return return_v;
                }


                string
                f_10972_6375_6385(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6375, 6385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10972_6285_6386(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6285, 6386);
                    return return_v;
                }


                int
                f_10972_6269_6387(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6269, 6387);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_6487_6496()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6487, 6496);
                    return return_v;
                }


                string?
                f_10972_6487_6510(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6487, 6510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingXmlFileResolver
                f_10972_6460_6531(string?
                baseDirectory, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingXmlFileResolver(baseDirectory, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6460, 6531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_6631_6640()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6631, 6640);
                    return return_v;
                }


                string?
                f_10972_6631_6654(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6631, 6654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_6656_6665()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6656, 6665);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_10972_6656_6673(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.PathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 6656, 6673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver
                f_10972_6571_6694(System.Collections.Immutable.ImmutableArray<string>
                searchPaths, string?
                baseDirectory, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver(searchPaths, baseDirectory, pathMap, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6571, 6694);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_10972_6803_6893(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFiles, out Microsoft.CodeAnalysis.MetadataReferenceResolver
                referenceDirectiveResolver)
                {
                    var return_v = this_param.ResolveMetadataReferences(diagnostics, touchedFiles, out referenceDirectiveResolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6803, 6893);
                    return return_v;
                }


                bool
                f_10972_6912_6989(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 6912, 6989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingStrongNameFileSystem
                f_10972_7090_7157(Microsoft.CodeAnalysis.TouchedFileLogger?
                logger, string?
                customTempPath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingStrongNameFileSystem(logger, customTempPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7090, 7157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider
                f_10972_7194_7282(Microsoft.CodeAnalysis.SyntaxTree?[]
                trees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                results, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                globalResults)
                {
                    var return_v = new Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider(trees, results, globalResults);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7194, 7282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_7349_7358()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 7349, 7358);
                    return return_v;
                }


                string?
                f_10972_7349_7374(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.CompilationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 7349, 7374);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_10972_7393_7413(Microsoft.CodeAnalysis.SyntaxTree?[]
                source)
                {
                    var return_v = source.WhereNotNull<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7393, 7413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_7469_7478()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 7469, 7478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7497(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.CompilationOptions
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 7469, 7497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7577(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                resolver)
                {
                    var return_v = this_param.WithMetadataReferenceResolver(resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7654(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.DesktopAssemblyIdentityComparer
                comparer)
                {
                    var return_v = this_param.WithAssemblyIdentityComparer((Microsoft.CodeAnalysis.AssemblyIdentityComparer)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7718(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.CommonCompiler.LoggingXmlFileResolver
                resolver)
                {
                    var return_v = this_param.WithXmlReferenceResolver((Microsoft.CodeAnalysis.XmlReferenceResolver)resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_7764_7773()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 7764, 7773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider
                f_10972_7764_7814(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param, Microsoft.CodeAnalysis.CommonCompiler.LoggingStrongNameFileSystem
                fileSystem)
                {
                    var return_v = this_param.GetStrongNameProvider((Microsoft.CodeAnalysis.StrongNameFileSystem)fileSystem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7764, 7814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7815(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.StrongNameProvider
                provider)
                {
                    var return_v = this_param.WithStrongNameProvider(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7885(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver
                resolver)
                {
                    var return_v = this_param.WithSourceReferenceResolver((Microsoft.CodeAnalysis.SourceReferenceResolver)resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_7469_7954(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.CompilerSyntaxTreeOptionsProvider
                provider)
                {
                    var return_v = this_param.WithSyntaxTreeOptionsProvider((Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7469, 7954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10972_7306_7955(string?
                assemblyName, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharpCompilation.Create(assemblyName, syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 7306, 7955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 1726, 7967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 1726, 7967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SyntaxTree? ParseFile(
                    CSharpParseOptions parseOptions,
                    CSharpParseOptions scriptParseOptions,
                    ref bool addedDiagnostics,
                    CommandLineSourceFile file,
                    DiagnosticBag diagnostics,
                    out string? normalizedFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 7979, 8994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8298, 8347);

                var
                fileDiagnostics = f_10972_8320_8346()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8361, 8441);

                var
                content = f_10972_8375_8440(this, file, fileDiagnostics, out normalizedFilePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8457, 8983) || true) && (content == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 8457, 8983);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8510, 8663);
                        foreach (var info in f_10972_8531_8546_I(fileDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 8510, 8663);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8588, 8644);

                            f_10972_8588_8643(diagnostics, f_10972_8604_8642(f_10972_8604_8619(), info));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 8510, 8663);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 154);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 154);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8681, 8705);

                    f_10972_8681_8704(fileDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8723, 8747);

                    addedDiagnostics = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8765, 8777);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 8457, 8983);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 8457, 8983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8843, 8884);

                    f_10972_8843_8883(f_10972_8856_8877(fileDiagnostics) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 8902, 8968);

                    return f_10972_8909_8967(parseOptions, scriptParseOptions, content, file);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 8457, 8983);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 7979, 8994);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10972_8320_8346()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8320, 8346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText?
                f_10972_8375_8440(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                file, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, out string?
                normalizedFilePath)
                {
                    var return_v = this_param.TryReadFileContent(file, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, out normalizedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8375, 8440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_10972_8604_8619()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 8604, 8619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10972_8604_8642(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.CreateDiagnostic(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8604, 8642);
                    return return_v;
                }


                int
                f_10972_8588_8643(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8588, 8643);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10972_8531_8546_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8531, 8546);
                    return return_v;
                }


                int
                f_10972_8681_8704(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8681, 8704);
                    return 0;
                }


                int
                f_10972_8856_8877(System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 8856, 8877);
                    return return_v;
                }


                int
                f_10972_8843_8883(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8843, 8883);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10972_8909_8967(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                scriptParseOptions, Microsoft.CodeAnalysis.Text.SourceText
                content, Microsoft.CodeAnalysis.CommandLineSourceFile
                file)
                {
                    var return_v = ParseFile(parseOptions, scriptParseOptions, content, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 8909, 8967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 7979, 8994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 7979, 8994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxTree ParseFile(
                    CSharpParseOptions parseOptions,
                    CSharpParseOptions scriptParseOptions,
                    SourceText content,
                    CommandLineSourceFile file)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10972, 9006, 9752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 9239, 9403);

                var
                tree = f_10972_9250_9402(content, (DynAbs.Tracing.TraceSender.Conditional_F1(10972, 9324, 9337) || ((file.IsScript && DynAbs.Tracing.TraceSender.Conditional_F2(10972, 9340, 9358)) || DynAbs.Tracing.TraceSender.Conditional_F3(10972, 9361, 9373))) ? scriptParseOptions : parseOptions, file.Path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 9606, 9625);

                bool
                isHiddenDummy
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 9639, 9713);

                f_10972_9639_9712(tree, default(TextSpan), out isHiddenDummy);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 9729, 9741);

                return tree;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10972, 9006, 9752);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10972_9250_9402(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, (Microsoft.CodeAnalysis.ParseOptions)options, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 9250, 9402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10972_9639_9712(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, out bool
                isHiddenPosition)
                {
                    var return_v = this_param.GetMappedLineSpanAndVisibility(span, out isHiddenPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 9639, 9712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 9006, 9752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 9006, 9752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string GetOutputFileName(Compilation compilation, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 10679, 11825);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 10809, 10928) || true) && (f_10972_10813_10837(f_10972_10813_10822()) is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 10809, 10928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 10881, 10913);

                    return f_10972_10888_10912(f_10972_10888_10897());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 10809, 10928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 10944, 11014);

                f_10972_10944_11013(f_10972_10957_11012(f_10972_10957_10996(f_10972_10957_10985(f_10972_10957_10966()))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11030, 11072);

                var
                comp = (CSharpCompilation)compilation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11088, 11126);

                Symbol?
                entryPoint = f_10972_11109_11125(comp)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11140, 11623) || true) && (entryPoint is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 11140, 11623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11196, 11247);

                    var
                    method = f_10972_11209_11246(comp, cancellationToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11265, 11608) || true) && (method is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 11265, 11608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11327, 11383);

                        entryPoint = f_10972_11340_11372(method) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10972, 11340, 11382) ?? method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 11265, 11608);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 11265, 11608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11574, 11589);

                        return "error";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 11265, 11608);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 11140, 11623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11639, 11744);

                string
                entryPointFileName = f_10972_11667_11743(f_10972_11693_11742(entryPoint.Locations.First().SourceTree!))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11758, 11814);

                return f_10972_11765_11813(entryPointFileName, ".exe");
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 10679, 11825);

                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_10813_10822()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10813, 10822);
                    return return_v;
                }


                string?
                f_10972_10813_10837(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10813, 10837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_10888_10897()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10888, 10897);
                    return return_v;
                }


                string
                f_10972_10888_10912(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10888, 10912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_10957_10966()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10957, 10966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10972_10957_10985(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param)
                {
                    var return_v = this_param.CompilationOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10957, 10985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10972_10957_10996(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 10957, 10996);
                    return return_v;
                }


                bool
                f_10972_10957_11012(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 10957, 11012);
                    return return_v;
                }


                int
                f_10972_10944_11013(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 10944, 11013);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10972_11109_11125(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 11109, 11125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10972_11209_11246(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetEntryPoint(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 11209, 11246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10972_11340_11372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 11340, 11372);
                    return return_v;
                }


                string
                f_10972_11693_11742(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 11693, 11742);
                    return return_v;
                }


                string?
                f_10972_11667_11743(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 11667, 11743);
                    return return_v;
                }


                string?
                f_10972_11765_11813(string
                path, string
                extension)
                {
                    var return_v = Path.ChangeExtension(path, extension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 11765, 11813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 10679, 11825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 10679, 11825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool SuppressDefaultResponseFile(IEnumerable<string> args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 11837, 12041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 11938, 12030);

                return f_10972_11945_12029(args, arg => new[] { "/noconfig", "-noconfig" }.Contains(arg.ToLowerInvariant()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 11837, 12041);

                bool
                f_10972_11945_12029(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Any<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 11945, 12029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 11837, 12041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 11837, 12041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void PrintLogo(TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 12183, 12528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12264, 12382);

                f_10972_12264_12381(consoleOutput, f_10972_12288_12343(MessageID.IDS_LogoLine1, f_10972_12335_12342()), f_10972_12345_12358(this), f_10972_12360_12380(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12396, 12477);

                f_10972_12396_12476(consoleOutput, f_10972_12420_12475(MessageID.IDS_LogoLine2, f_10972_12467_12474()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12491, 12517);

                f_10972_12491_12516(consoleOutput);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 12183, 12528);

                System.Globalization.CultureInfo
                f_10972_12335_12342()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 12335, 12342);
                    return return_v;
                }


                string
                f_10972_12288_12343(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12288, 12343);
                    return return_v;
                }


                string
                f_10972_12345_12358(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param)
                {
                    var return_v = this_param.GetToolName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12345, 12358);
                    return return_v;
                }


                string
                f_10972_12360_12380(Microsoft.CodeAnalysis.CSharp.CSharpCompiler
                this_param)
                {
                    var return_v = this_param.GetCompilerVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12360, 12380);
                    return return_v;
                }


                int
                f_10972_12264_12381(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12264, 12381);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_10972_12467_12474()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 12467, 12474);
                    return return_v;
                }


                string
                f_10972_12420_12475(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12420, 12475);
                    return return_v;
                }


                int
                f_10972_12396_12476(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12396, 12476);
                    return 0;
                }


                int
                f_10972_12491_12516(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12491, 12516);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 12183, 12528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 12183, 12528);
            }
        }

        public override void PrintLangVersions(TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 12540, 13521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12629, 12713);

                f_10972_12629_12712(consoleOutput, f_10972_12653_12711(MessageID.IDS_LangVersions, f_10972_12703_12710()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12727, 12805);

                var
                defaultVersion = f_10972_12748_12804(LanguageVersion.Default)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12819, 12895);

                var
                latestVersion = f_10972_12839_12894(LanguageVersion.Latest)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 12909, 13470);
                    foreach (var v in f_10972_12927_12985_I((LanguageVersion[])f_10972_12946_12985(typeof(LanguageVersion))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 12909, 13470);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13019, 13455) || true) && (v == defaultVersion)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 13019, 13455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13084, 13144);

                            f_10972_13084_13143(consoleOutput, $"{f_10972_13111_13130(v)} (default)");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 13019, 13455);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 13019, 13455);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13186, 13455) || true) && (v == latestVersion)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 13186, 13455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13250, 13309);

                                f_10972_13250_13308(consoleOutput, $"{f_10972_13277_13296(v)} (latest)");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 13186, 13455);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 13186, 13455);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13391, 13436);

                                f_10972_13391_13435(consoleOutput, f_10972_13415_13434(v));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 13186, 13455);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 13019, 13455);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 12909, 13470);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13484, 13510);

                f_10972_13484_13509(consoleOutput);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 12540, 13521);

                System.Globalization.CultureInfo
                f_10972_12703_12710()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 12703, 12710);
                    return return_v;
                }


                string
                f_10972_12653_12711(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12653, 12711);
                    return return_v;
                }


                int
                f_10972_12629_12712(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12629, 12712);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10972_12748_12804(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12748, 12804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10972_12839_12894(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.MapSpecifiedToEffectiveVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12839, 12894);
                    return return_v;
                }


                System.Array
                f_10972_12946_12985(System.Type
                enumType)
                {
                    var return_v = Enum.GetValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12946, 12985);
                    return return_v;
                }


                string
                f_10972_13111_13130(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13111, 13130);
                    return return_v;
                }


                int
                f_10972_13084_13143(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13084, 13143);
                    return 0;
                }


                string
                f_10972_13277_13296(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13277, 13296);
                    return return_v;
                }


                int
                f_10972_13250_13308(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13250, 13308);
                    return 0;
                }


                string
                f_10972_13415_13434(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13415, 13434);
                    return return_v;
                }


                int
                f_10972_13391_13435(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13391, 13435);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion[]
                f_10972_12927_12985_I(Microsoft.CodeAnalysis.CSharp.LanguageVersion[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 12927, 12985);
                    return return_v;
                }


                int
                f_10972_13484_13509(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13484, 13509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 12540, 13521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 12540, 13521);
            }
        }

        internal override Type Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 13585, 13752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13707, 13737);

                    return typeof(CSharpCompiler);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 13585, 13752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 13533, 13763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 13533, 13763);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string GetToolName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 13775, 13911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 13838, 13900);

                return f_10972_13845_13899(MessageID.IDS_ToolName, f_10972_13891_13898());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 13775, 13911);

                System.Globalization.CultureInfo
                f_10972_13891_13898()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 13891, 13898);
                    return return_v;
                }


                string
                f_10972_13845_13899(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 13845, 13899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 13775, 13911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 13775, 13911);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void PrintHelp(TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 14103, 14274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 14184, 14263);

                f_10972_14184_14262(consoleOutput, f_10972_14208_14261(MessageID.IDS_CSCHelp, f_10972_14253_14260()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 14103, 14274);

                System.Globalization.CultureInfo
                f_10972_14253_14260()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 14253, 14260);
                    return return_v;
                }


                string
                f_10972_14208_14261(Microsoft.CodeAnalysis.CSharp.MessageID
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 14208, 14261);
                    return return_v;
                }


                int
                f_10972_14184_14262(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 14184, 14262);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 14103, 14274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 14103, 14274);
            }
        }

        protected override bool TryGetCompilerDiagnosticCode(string diagnosticId, out uint code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 14286, 14491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 14399, 14480);

                return f_10972_14406_14479(diagnosticId, "CS", out code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 14286, 14491);

                bool
                f_10972_14406_14479(string
                diagnosticId, string
                expectedPrefix, out uint
                code)
                {
                    var return_v = CommonCompiler.TryGetCompilerDiagnosticCode(diagnosticId, expectedPrefix, out code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 14406, 14479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 14286, 14491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 14286, 14491);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 14503, 15004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 14839, 14993);

                f_10972_14839_14992(f_10972_14839_14848(), LanguageNames.CSharp, diagnostics, messageProvider, f_10972_14931_14945(), skipAnalyzers, out analyzers, out generators);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 14503, 15004);

                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10972_14839_14848()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 14839, 14848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                f_10972_14931_14945()
                {
                    var return_v = AssemblyLoader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 14931, 14945);
                    return return_v;
                }


                int
                f_10972_14839_14992(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                this_param, string
                language, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.IAnalyzerAssemblyLoader
                analyzerLoader, bool
                skipAnalyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators)
                {
                    this_param.ResolveAnalyzersFromArguments(language, diagnostics, messageProvider, analyzerLoader, skipAnalyzers, out analyzers, out generators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 14839, 14992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 14503, 15004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 14503, 15004);
            }
        }

        protected override void ResolveEmbeddedFilesFromExternalSourceDirectives(
                    SyntaxTree tree,
                    SourceReferenceResolver resolver,
                    OrderedSet<string> embeddedFiles,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 15016, 16230);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15278, 16219);
                    foreach (LineDirectiveTriviaSyntax directive in f_10972_15326_15451_I(f_10972_15326_15451(f_10972_15326_15340(tree), d => d.IsActive && !d.HasErrors && d.Kind() == SyntaxKind.LineDirectiveTrivia)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 15278, 16219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15485, 15526);

                        var
                        path = (string?)directive.File.Value
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15544, 15630) || true) && (path == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 15544, 15630);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15602, 15611);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 15544, 15630);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15650, 15720);

                        string?
                        resolvedPath = f_10972_15673_15719(resolver, path, f_10972_15705_15718(tree))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15738, 16152) || true) && (resolvedPath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10972, 15738, 16152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 15804, 16100);

                            f_10972_15804_16099(diagnostics, f_10972_15846_16098(f_10972_15846_15861(), ErrorCode.ERR_NoSourceFile, directive.File.GetLocation(), path, f_10972_16065_16097()));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16124, 16133);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 15738, 16152);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16172, 16204);

                        f_10972_16172_16203(
                                        embeddedFiles, resolvedPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10972, 15278, 16219);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10972, 1, 942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10972, 1, 942);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 15016, 16230);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10972_15326_15340(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15326, 15340);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10972_15326_15451(Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax, bool>?
                filter)
                {
                    var return_v = node.GetDirectives(filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15326, 15451);
                    return return_v;
                }


                string
                f_10972_15705_15718(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 15705, 15718);
                    return return_v;
                }


                string?
                f_10972_15673_15719(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                path, string
                baseFilePath)
                {
                    var return_v = this_param.ResolveReference(path, baseFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15673, 15719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_10972_15846_15861()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 15846, 15861);
                    return return_v;
                }


                string
                f_10972_16065_16097()
                {
                    var return_v = CSharpResources.CouldNotFindFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 16065, 16097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10972_15846_16098(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic((int)code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15846, 16098);
                    return return_v;
                }


                int
                f_10972_15804_16099(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15804, 16099);
                    return 0;
                }


                bool
                f_10972_16172_16203(Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 16172, 16203);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10972_15326_15451_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 15326, 15451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 15016, 16230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 15016, 16230);
            }
        }

        private protected override Compilation RunGenerators(Compilation input, ParseOptions parseOptions, ImmutableArray<ISourceGenerator> generators, AnalyzerConfigOptionsProvider analyzerConfigProvider, ImmutableArray<AdditionalText> additionalTexts, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10972, 16242, 16888);
                Microsoft.CodeAnalysis.Compilation compilationOut = default(Microsoft.CodeAnalysis.Compilation);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> generatorDiagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16539, 16668);

                var
                driver = f_10972_16552_16667(generators, additionalTexts, parseOptions, analyzerConfigProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16682, 16784);

                f_10972_16682_16783(driver, input, out compilationOut, out generatorDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16798, 16841);

                f_10972_16798_16840(diagnostics, generatorDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 16855, 16877);

                return compilationOut;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10972, 16242, 16888);

                Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver
                f_10972_16552_16667(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTexts, Microsoft.CodeAnalysis.ParseOptions
                parseOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                optionsProvider)
                {
                    var return_v = CSharpGeneratorDriver.Create((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISourceGenerator>)generators, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AdditionalText>)additionalTexts, (Microsoft.CodeAnalysis.CSharp.CSharpParseOptions)parseOptions, optionsProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 16552, 16667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriver
                f_10972_16682_16783(Microsoft.CodeAnalysis.CSharp.CSharpGeneratorDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, out Microsoft.CodeAnalysis.Compilation
                outputCompilation, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = this_param.RunGeneratorsAndUpdateCompilation(compilation, out outputCompilation, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 16682, 16783);
                    return return_v;
                }


                int
                f_10972_16798_16840(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 16798, 16840);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10972, 16242, 16888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 16242, 16888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10972, 658, 16895);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10972, 752, 780);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10972, 658, 16895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10972, 658, 16895);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10972, 658, 16895);

        Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
        f_10972_1340_1349()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 1340, 1349);
            return return_v;
        }


        bool
        f_10972_1340_1364(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
        this_param)
        {
            var return_v = this_param.PrintFullPaths;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 1340, 1364);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
        f_10972_1366_1375()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 1366, 1375);
            return return_v;
        }


        bool
        f_10972_1366_1405(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
        this_param)
        {
            var return_v = this_param.ShouldIncludeErrorEndLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10972, 1366, 1405);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CommandLineDiagnosticFormatter
        f_10972_1276_1406(string
        baseDirectory, bool
        displayFullPaths, bool
        displayEndLocations)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CommandLineDiagnosticFormatter(baseDirectory, displayFullPaths, displayEndLocations);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10972, 1276, 1406);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommandLineParser
        f_10972_1141_1147_C(Microsoft.CodeAnalysis.CommandLineParser
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10972, 924, 1474);
            return return_v;
        }

    }
}
