// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct BuildPaths
    {

        internal string ClientDirectory { get; }

        internal string WorkingDirectory { get; }

        internal string? SdkDirectory { get; }

        internal string? TempDirectory { get; }

        internal BuildPaths(string clientDir, string workingDir, string? sdkDir, string? tempDir)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(127, 1692, 1963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 1806, 1834);

                ClientDirectory = clientDir;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 1848, 1878);

                WorkingDirectory = workingDir;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 1892, 1914);

                SdkDirectory = sdkDir;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 1928, 1952);

                TempDirectory = tempDir;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(127, 1692, 1963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 1692, 1963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 1692, 1963);
            }
        }
        static BuildPaths()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(127, 772, 1970);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(127, 772, 1970);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 772, 1970);
        }
    }
    internal abstract partial class CommonCompiler
    {
        internal const int
        Failed = 1
        ;

        internal const int
        Succeeded = 0
        ;

        private readonly Lazy<Encoding> _fallbackEncoding;

        public CommonMessageProvider MessageProvider { get; }

        public CommandLineArguments Arguments { get; }

        public IAnalyzerAssemblyLoader AssemblyLoader { get; private set; }

        public abstract DiagnosticFormatter DiagnosticFormatter { get; }

        public IReadOnlySet<string> EmbeddedSourcePaths { get; }

        private readonly HashSet<Diagnostic> _reportedDiagnostics;

        public abstract Compilation? CreateCompilation(
                    TextWriter consoleOutput,
                    TouchedFileLogger? touchedFilesLogger,
                    ErrorLogger? errorLoggerOpt,
                    ImmutableArray<AnalyzerConfigOptionsResult> analyzerConfigOptions,
                    AnalyzerConfigOptionsResult globalConfigOptions);

        public abstract void PrintLogo(TextWriter consoleOutput);

        public abstract void PrintHelp(TextWriter consoleOutput);

        public abstract void PrintLangVersions(TextWriter consoleOutput);

        public virtual void PrintVersion(TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 3967, 4107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 4050, 4096);

                f_127_4050_4095(consoleOutput, f_127_4074_4094(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 3967, 4107);

                string
                f_127_4074_4094(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetCompilerVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4074, 4094);
                    return return_v;
                }


                int
                f_127_4050_4095(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4050, 4095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 3967, 4107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 3967, 4107);
            }
        }

        protected abstract bool TryGetCompilerDiagnosticCode(string diagnosticId, out uint code);

        protected abstract void ResolveAnalyzersFromArguments(
                    List<DiagnosticInfo> diagnostics,
                    CommonMessageProvider messageProvider,
                    bool skipAnalyzers,
                    out ImmutableArray<DiagnosticAnalyzer> analyzers,
                    out ImmutableArray<ISourceGenerator> generators);

        public CommonCompiler(CommandLineParser parser, string? responseFile, string[] args, BuildPaths buildPaths, string? additionalReferenceDirectories, IAnalyzerAssemblyLoader assemblyLoader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(127, 4544, 5613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2546, 2626);
                this._fallbackEncoding = f_127_2566_2626(EncodedStringText.CreateFallbackEncoding); DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2639, 2692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2702, 2748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 2758, 2825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 3122, 3178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 3227, 3275);
                this._reportedDiagnostics = f_127_3250_3275(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68250, 68259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 4756, 4791);

                IEnumerable<string>
                allArgs = args
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 4807, 4884);

                f_127_4807_4883(null == responseFile || (DynAbs.Tracing.TraceSender.Expression_False(127, 4820, 4882) || f_127_4844_4882(responseFile)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 4898, 5069) || true) && (!f_127_4903_4936(this, args) && (DynAbs.Tracing.TraceSender.Expression_True(127, 4902, 4965) && f_127_4940_4965(responseFile)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 4898, 5069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 4999, 5054);

                    allArgs = f_127_5009_5053(new[] { "@" + responseFile }, allArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 4898, 5069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5085, 5210);

                this.Arguments = f_127_5102_5209(parser, allArgs, buildPaths.WorkingDirectory, buildPaths.SdkDirectory, additionalReferenceDirectories);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5224, 5270);

                this.MessageProvider = f_127_5247_5269(parser);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5284, 5321);

                this.AssemblyLoader = assemblyLoader;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5335, 5396);

                this.EmbeddedSourcePaths = f_127_5362_5395(f_127_5385_5394());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5412, 5602) || true) && (f_127_5416_5480(f_127_5416_5447(f_127_5416_5438(f_127_5416_5425())), "debug-determinism"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 5412, 5602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 5514, 5587);

                    f_127_5514_5586(f_127_5533_5542(), args, buildPaths.WorkingDirectory, parser);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 5412, 5602);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(127, 4544, 5613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 4544, 5613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 4544, 5613);
            }
        }

        internal abstract bool SuppressDefaultResponseFile(IEnumerable<string> args);

        internal abstract Type Type { get; }

        internal string GetCompilerVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 6131, 6234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6192, 6223);

                return f_127_6199_6222(f_127_6217_6221());
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 6131, 6234);

                System.Type
                f_127_6217_6221()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6217, 6221);
                    return return_v;
                }


                string
                f_127_6199_6222(System.Type
                type)
                {
                    var return_v = GetProductVersion(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6199, 6222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 6131, 6234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 6131, 6234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetProductVersion(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 6246, 6505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6322, 6389);

                string?
                assemblyVersion = f_127_6348_6388(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6403, 6443);

                string?
                hash = f_127_6418_6442(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6457, 6494);

                return $"{assemblyVersion} ({hash})";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 6246, 6505);

                string?
                f_127_6348_6388(System.Type
                type)
                {
                    var return_v = GetInformationalVersionWithoutHash(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6348, 6388);
                    return return_v;
                }


                string?
                f_127_6418_6442(System.Type
                type)
                {
                    var return_v = GetShortCommitHash(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6418, 6442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 6246, 6505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 6246, 6505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [return: NotNullIfNotNull("hash")]
        internal static string? ExtractShortCommitHash(string? hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 6517, 6898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6728, 6859) || true) && (hash != null && (DynAbs.Tracing.TraceSender.Expression_True(127, 6732, 6764) && f_127_6748_6759(hash) >= 8) && (DynAbs.Tracing.TraceSender.Expression_True(127, 6732, 6782) && f_127_6768_6775(hash, 0) != '<'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 6728, 6859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6816, 6844);

                    return f_127_6823_6843(hash, 0, 8);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 6728, 6859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 6875, 6887);

                return hash;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 6517, 6898);

                int
                f_127_6748_6759(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6748, 6759);
                    return return_v;
                }


                char
                f_127_6768_6775(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 6768, 6775);
                    return return_v;
                }


                string
                f_127_6823_6843(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 6823, 6843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 6517, 6898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 6517, 6898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? GetInformationalVersionWithoutHash(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 6910, 7362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7183, 7268);

                var
                temp = f_127_7194_7267(f_127_7194_7207(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7282, 7351);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(127, 7289, 7301) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(127, 7304, 7343)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 7346, 7350))) ? f_127_7304_7340(f_127_7304_7329(temp), '+')[0] : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 6910, 7362);

                System.Reflection.Assembly
                f_127_7194_7207(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7194, 7207);
                    return return_v;
                }


                System.Reflection.AssemblyInformationalVersionAttribute?
                f_127_7194_7267(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7194, 7267);
                    return return_v;
                }


                string
                f_127_7304_7329(System.Reflection.AssemblyInformationalVersionAttribute
                this_param)
                {
                    var return_v = this_param.InformationalVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7304, 7329);
                    return return_v;
                }


                string[]
                f_127_7304_7340(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7304, 7340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 6910, 7362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 6910, 7362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? GetShortCommitHash(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 7374, 7585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7451, 7524);

                var
                hash = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_7462_7517(f_127_7462_7475(type)), 127, 7462, 7523)?.Hash
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7538, 7574);

                return f_127_7545_7573(hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 7374, 7585);

                System.Reflection.Assembly
                f_127_7462_7475(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7462, 7475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommitHashAttribute?
                f_127_7462_7517(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<Microsoft.CodeAnalysis.CommitHashAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7462, 7517);
                    return return_v;
                }


                string?
                f_127_7545_7573(string?
                hash)
                {
                    var return_v = ExtractShortCommitHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7545, 7573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 7374, 7585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 7374, 7585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract string GetToolName();

        internal Version? GetAssemblyVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 7880, 8007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7943, 7996);

                return f_127_7950_7995(f_127_7950_7987(f_127_7950_7977(f_127_7950_7968(f_127_7950_7954()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 7880, 8007);

                System.Type
                f_127_7950_7954()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7950, 7954);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_127_7950_7968(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7950, 7968);
                    return return_v;
                }


                System.Reflection.Assembly
                f_127_7950_7977(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7950, 7977);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_127_7950_7987(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7950, 7987);
                    return return_v;
                }


                System.Version?
                f_127_7950_7995(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7950, 7995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 7880, 8007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 7880, 8007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetCultureName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8019, 8107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8076, 8096);

                return f_127_8083_8095(f_127_8083_8090());
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8019, 8107);

                System.Globalization.CultureInfo
                f_127_8083_8090()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8083, 8090);
                    return return_v;
                }


                string
                f_127_8083_8095(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8083, 8095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8019, 8107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8019, 8107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Func<string, MetadataReferenceProperties, PortableExecutableReference> GetMetadataProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8119, 8344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8253, 8333);

                return (path, properties) => MetadataReference.CreateFromFile(path, properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8119, 8344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8119, 8344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8119, 8344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual MetadataReferenceResolver GetCommandLineMetadataReferenceResolver(TouchedFileLogger? loggerOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8356, 8709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8493, 8588);

                var
                pathResolver = f_127_8512_8587(f_127_8537_8561(f_127_8537_8546()), f_127_8563_8586(f_127_8563_8572()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8602, 8698);

                return f_127_8609_8697(pathResolver, f_127_8664_8685(this), loggerOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8356, 8709);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_8537_8546()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8537, 8546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_8537_8561(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReferencePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8537, 8561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_8563_8572()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8563, 8572);
                    return return_v;
                }


                string?
                f_127_8563_8586(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8563, 8586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RelativePathResolver
                f_127_8512_8587(System.Collections.Immutable.ImmutableArray<string>
                searchPaths, string?
                baseDirectory)
                {
                    var return_v = new Microsoft.CodeAnalysis.RelativePathResolver(searchPaths, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8512, 8587);
                    return return_v;
                }


                System.Func<string, Microsoft.CodeAnalysis.MetadataReferenceProperties, Microsoft.CodeAnalysis.PortableExecutableReference>
                f_127_8664_8685(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetMetadataProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8664, 8685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver
                f_127_8609_8697(Microsoft.CodeAnalysis.RelativePathResolver
                pathResolver, System.Func<string, Microsoft.CodeAnalysis.MetadataReferenceProperties, Microsoft.CodeAnalysis.PortableExecutableReference>
                provider, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver(pathResolver, provider, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8609, 8697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8356, 8709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8356, 8709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal List<MetadataReference> ResolveMetadataReferences(
                    List<DiagnosticInfo> diagnostics,
                    TouchedFileLogger? touchedFiles,
                    out MetadataReferenceResolver referenceDirectiveResolver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8896, 9942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9144, 9233);

                var
                commandLineReferenceResolver = f_127_9179_9232(this, touchedFiles)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9249, 9314);

                List<MetadataReference>
                resolved = f_127_9284_9313()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9328, 9439);

                f_127_9328_9438(f_127_9328_9337(), commandLineReferenceResolver, diagnostics, f_127_9407_9427(this), resolved);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9455, 9899) || true) && (f_127_9459_9483(f_127_9459_9468()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 9455, 9899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9517, 9575);

                    referenceDirectiveResolver = commandLineReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 9455, 9899);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 9455, 9899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9765, 9884);

                    referenceDirectiveResolver = f_127_9794_9883(commandLineReferenceResolver, f_127_9855_9882(resolved));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 9455, 9899);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9915, 9931);

                return resolved;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8896, 9942);

                Microsoft.CodeAnalysis.MetadataReferenceResolver
                f_127_9179_9232(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.TouchedFileLogger?
                loggerOpt)
                {
                    var return_v = this_param.GetCommandLineMetadataReferenceResolver(loggerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9179, 9232);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_127_9284_9313()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9284, 9313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_9328_9337()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9328, 9337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_9407_9427(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9407, 9427);
                    return return_v;
                }


                bool
                f_127_9328_9438(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                metadataResolver, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProviderOpt, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                resolved)
                {
                    var return_v = this_param.ResolveMetadataReferences(metadataResolver, diagnosticsOpt, messageProviderOpt, resolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9328, 9438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_9459_9468()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9459, 9468);
                    return return_v;
                }


                bool
                f_127_9459_9483(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.IsScriptRunner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9459, 9483);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_127_9855_9882(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9855, 9882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver
                f_127_9794_9883(Microsoft.CodeAnalysis.MetadataReferenceResolver
                resolver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                availableReferences)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver(resolver, availableReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9794, 9883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8896, 9942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8896, 9942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceText? TryReadFileContent(CommandLineSourceFile file, IList<DiagnosticInfo> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 10248, 10438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 10375, 10427);

                return f_127_10382_10426(this, file, diagnostics, out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 10248, 10438);

                Microsoft.CodeAnalysis.Text.SourceText?
                f_127_10382_10426(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                file, System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, out string?
                normalizedFilePath)
                {
                    var return_v = this_param.TryReadFileContent(file, diagnostics, out normalizedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10382, 10426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 10248, 10438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 10248, 10438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceText? TryReadFileContent(CommandLineSourceFile file, IList<DiagnosticInfo> diagnostics, out string? normalizedFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 10912, 12158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11071, 11096);

                var
                filePath = file.Path
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11146, 11903) || true) && (file.IsInputRedirected)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 11146, 11903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11214, 11259);

                        using var
                        data = f_127_11231_11258()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11281, 11311);

                        normalizedFilePath = filePath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11333, 11495);

                        return f_127_11340_11494(data, _fallbackEncoding, f_127_11390_11408(f_127_11390_11399()), f_127_11410_11437(f_127_11410_11419()), canBeEmbedded: f_127_11454_11493(f_127_11454_11473(), file.Path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 11146, 11903);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 11146, 11903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11577, 11647);

                        using var
                        data = f_127_11594_11646(filePath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11669, 11700);

                        normalizedFilePath = f_127_11690_11699(data);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11722, 11884);

                        return f_127_11729_11883(data, _fallbackEncoding, f_127_11779_11797(f_127_11779_11788()), f_127_11799_11826(f_127_11799_11808()), canBeEmbedded: f_127_11843_11882(f_127_11843_11862(), file.Path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 11146, 11903);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 11932, 12147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11984, 12058);

                    f_127_11984_12057(diagnostics, f_127_12000_12056(f_127_12022_12042(this), e, filePath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12076, 12102);

                    normalizedFilePath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12120, 12132);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 11932, 12147);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 10912, 12158);

                System.IO.Stream
                f_127_11231_11258()
                {
                    var return_v = Console.OpenStandardInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11231, 11258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11390_11399()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11390, 11399);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_11390_11408(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11390, 11408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11410_11419()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11410, 11419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_11410_11437(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11410, 11437);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_11454_11473()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11454, 11473);
                    return return_v;
                }


                bool
                f_127_11454_11493(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11454, 11493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_11340_11494(System.IO.Stream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding?
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Create(stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11340, 11494);
                    return return_v;
                }


                System.IO.FileStream
                f_127_11594_11646(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11594, 11646);
                    return return_v;
                }


                string
                f_127_11690_11699(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11690, 11699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11779_11788()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11779, 11788);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_11779_11797(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11779, 11797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11799_11808()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11799, 11808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_11799_11826(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11799, 11826);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_11843_11862()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11843, 11862);
                    return return_v;
                }


                bool
                f_127_11843_11882(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11843, 11882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_11729_11883(System.IO.FileStream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding?
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Create((System.IO.Stream)stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11729, 11883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_12022_12042(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 12022, 12042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_12000_12056(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12000, 12056);
                    return return_v;
                }


                int
                f_127_11984_12057(System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11984, 12057);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 10912, 12158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 10912, 12158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetAnalyzerConfigSet(
                    ImmutableArray<string> analyzerConfigPaths,
                    DiagnosticBag diagnostics,
                    [NotNullWhen(true)] out AnalyzerConfigSet? analyzerConfigSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 12285, 14530);
                string? normalizedPath = default(string?);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> setDiagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12520, 12603);

                var
                configs = f_127_12534_12602(analyzerConfigPaths.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12619, 12675);

                var
                processedDirs = f_127_12639_12674()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12691, 14127);
                    foreach (var configPath in f_127_12718_12737_I(analyzerConfigPaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 12691, 14127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13052, 13146);

                        string?
                        fileContent = f_127_13074_13145(this, configPath, diagnostics, out normalizedPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13164, 13327) || true) && (fileContent is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13164, 13327);
                            DynAbs.Tracing.TraceSender.TraceBreak(127, 13302, 13308);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13164, 13327);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13347, 13386);

                        f_127_13347_13385(normalizedPath is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13404, 13476);

                        var
                        directory = f_127_13420_13457(normalizedPath) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(127, 13420, 13475) ?? normalizedPath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13494, 13563);

                        var
                        editorConfig = f_127_13513_13562(fileContent, normalizedPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13583, 14068) || true) && (f_127_13587_13609_M(!editorConfig.IsGlobal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13583, 14068);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13651, 13998) || true) && (f_127_13655_13688(processedDirs, directory))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13651, 13998);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13738, 13943);

                                f_127_13738_13942(diagnostics, f_127_13754_13941(f_127_13802_13817(), f_127_13848_13900(f_127_13848_13863()), directory));
                                DynAbs.Tracing.TraceSender.TraceBreak(127, 13969, 13975);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13651, 13998);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14020, 14049);

                            f_127_14020_14048(processedDirs, directory);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13583, 14068);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14086, 14112);

                        f_127_14086_14111(configs, editorConfig);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 12691, 14127);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 1437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 1437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14143, 14164);

                f_127_14143_14163(
                            processedDirs);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14180, 14348) || true) && (f_127_14184_14210(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 14180, 14348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14244, 14259);

                    f_127_14244_14258(configs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14277, 14302);

                    analyzerConfigSet = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14320, 14333);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 14180, 14348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14364, 14442);

                analyzerConfigSet = f_127_14384_14441(configs, out setDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14456, 14493);

                f_127_14456_14492(diagnostics, setDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14507, 14519);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 12285, 14530);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                f_127_12534_12602(int
                capacity)
                {
                    var return_v = ArrayBuilder<AnalyzerConfig>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12534, 12602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_127_12639_12674()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12639, 12674);
                    return return_v;
                }


                string?
                f_127_13074_13145(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out string?
                normalizedPath)
                {
                    var return_v = this_param.TryReadFileContent(filePath, diagnostics, out normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13074, 13145);
                    return return_v;
                }


                int
                f_127_13347_13385(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13347, 13385);
                    return 0;
                }


                string?
                f_127_13420_13457(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13420, 13457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_127_13513_13562(string
                text, string
                pathToFile)
                {
                    var return_v = AnalyzerConfig.Parse(text, pathToFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13513, 13562);
                    return return_v;
                }


                bool
                f_127_13587_13609_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13587, 13609);
                    return return_v;
                }


                bool
                f_127_13655_13688(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13655, 13688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_13802_13817()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13802, 13817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_13848_13863()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13848, 13863);
                    return return_v;
                }


                int
                f_127_13848_13900(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MultipleAnalyzerConfigsInSameDir;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13848, 13900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_13754_13941(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13754, 13941);
                    return return_v;
                }


                int
                f_127_13738_13942(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13738, 13942);
                    return 0;
                }


                bool
                f_127_14020_14048(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14020, 14048);
                    return return_v;
                }


                int
                f_127_14086_14111(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfig
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14086, 14111);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_12718_12737_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12718, 12737);
                    return return_v;
                }


                int
                f_127_14143_14163(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14143, 14163);
                    return 0;
                }


                bool
                f_127_14184_14210(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14184, 14210);
                    return return_v;
                }


                int
                f_127_14244_14258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14244, 14258);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigSet
                f_127_14384_14441(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                analyzerConfigs, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = AnalyzerConfigSet.Create(analyzerConfigs, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14384, 14441);
                    return return_v;
                }


                int
                f_127_14456_14492(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14456, 14492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 12285, 14530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 12285, 14530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Encoding? GetFallbackEncoding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 14700, 14920);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14765, 14881) || true) && (f_127_14769_14801(_fallbackEncoding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 14765, 14881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14835, 14866);

                    return f_127_14842_14865(_fallbackEncoding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 14765, 14881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14897, 14909);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 14700, 14920);

                bool
                f_127_14769_14801(System.Lazy<System.Text.Encoding>
                this_param)
                {
                    var return_v = this_param.IsValueCreated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 14769, 14801);
                    return return_v;
                }


                System.Text.Encoding
                f_127_14842_14865(System.Lazy<System.Text.Encoding>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 14842, 14865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 14700, 14920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 14700, 14920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string? TryReadFileContent(string filePath, DiagnosticBag diagnostics, out string? normalizedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 15051, 15754);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15218, 15282);

                    var
                    data = f_127_15229_15281(filePath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15300, 15327);

                    normalizedPath = f_127_15317_15326(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15345, 15489);
                    using (var
                    reader = f_127_15365_15402(data, f_127_15388_15401())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15444, 15470);

                        return f_127_15451_15469(reader);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 15345, 15489);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 15518, 15743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15570, 15658);

                    f_127_15570_15657(diagnostics, f_127_15586_15656(f_127_15604_15655(f_127_15626_15641(), e, filePath)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15676, 15698);

                    normalizedPath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15716, 15728);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 15518, 15743);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 15051, 15754);

                System.IO.FileStream
                f_127_15229_15281(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15229, 15281);
                    return return_v;
                }


                string
                f_127_15317_15326(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15317, 15326);
                    return return_v;
                }


                System.Text.Encoding
                f_127_15388_15401()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15388, 15401);
                    return return_v;
                }


                System.IO.StreamReader
                f_127_15365_15402(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15365, 15402);
                    return return_v;
                }


                string
                f_127_15451_15469(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15451, 15469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_15626_15641()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15626, 15641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_15604_15655(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15604, 15655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_15586_15656(Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = Diagnostic.Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15586, 15656);
                    return return_v;
                }


                int
                f_127_15570_15657(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15570, 15657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 15051, 15754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 15051, 15754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FileStream OpenFileForReadWithSmallBufferOptimization(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 15766, 16462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16221, 16451);

                return f_127_16228_16450(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, bufferSize: 1, options: FileOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 15766, 16462);

                System.IO.FileStream
                f_127_16228_16450(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share, int
                bufferSize, System.IO.FileOptions
                options)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share, bufferSize: bufferSize, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16228, 16450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 15766, 16462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 15766, 16462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EmbeddedText? TryReadEmbeddedFileContent(string filePath, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 16474, 17560);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16628, 17315);
                    using (var
                    stream = f_127_16648_16700(filePath)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16742, 16785);

                        const int
                        LargeObjectHeapLimit = 80 * 1024
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16807, 17194) || true) && (f_127_16811_16824(stream) < LargeObjectHeapLimit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 16807, 17194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16897, 16922);

                            ArraySegment<byte>
                            bytes
                            = default(ArraySegment<byte>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16948, 17171) || true) && (f_127_16952_17010(stream, out bytes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 16948, 17171);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17068, 17144);

                                return f_127_17075_17143(filePath, bytes, f_127_17115_17142(f_127_17115_17124()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 16948, 17171);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 16807, 17194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17218, 17296);

                        return f_127_17225_17295(filePath, stream, f_127_17267_17294(f_127_17267_17276()));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 16628, 17315);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 17344, 17549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17396, 17504);

                    f_127_17396_17503(diagnostics, f_127_17412_17502(f_127_17412_17427(), f_127_17445_17501(f_127_17467_17487(this), e, filePath)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17522, 17534);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 17344, 17549);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 16474, 17560);

                System.IO.FileStream
                f_127_16648_16700(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16648, 16700);
                    return return_v;
                }


                long
                f_127_16811_16824(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 16811, 16824);
                    return return_v;
                }


                bool
                f_127_16952_17010(System.IO.FileStream
                data, out System.ArraySegment<byte>
                bytes)
                {
                    var return_v = EncodedStringText.TryGetBytesFromStream((System.IO.Stream)data, out bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16952, 17010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17115_17124()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17115, 17124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_17115_17142(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17115, 17142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_17075_17143(string
                filePath, System.ArraySegment<byte>
                bytes, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = EmbeddedText.FromBytes(filePath, bytes, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17075, 17143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17267_17276()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17267, 17276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_17267_17294(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17267, 17294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_17225_17295(string
                filePath, System.IO.FileStream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = EmbeddedText.FromStream(filePath, (System.IO.Stream)stream, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17225, 17295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_17412_17427()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17412, 17427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_17467_17487(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17467, 17487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_17445_17501(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17445, 17501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_17412_17502(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.CreateDiagnostic(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17412, 17502);
                    return return_v;
                }


                int
                f_127_17396_17503(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17396, 17503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 16474, 17560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 16474, 17560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<EmbeddedText?> AcquireEmbeddedTexts(Compilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 17572, 20088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17707, 17775);

                f_127_17707_17774(f_127_17720_17763(f_127_17720_17739(compilation)) is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17789, 17916) || true) && (f_127_17793_17802().EmbeddedFiles.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 17789, 17916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17858, 17901);

                    return ImmutableArray<EmbeddedText?>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 17789, 17916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17932, 18021);

                var
                embeddedTreeMap = f_127_17954_18020(f_127_17989_17998().EmbeddedFiles.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18035, 18132);

                var
                embeddedFileOrderedSet = f_127_18064_18131(f_127_18087_18096().EmbeddedFiles.Select(e => e.Path))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18148, 19065);
                    foreach (var tree in f_127_18169_18192_I(f_127_18169_18192(compilation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18148, 19065);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18297, 18415) || true) && (!f_127_18302_18345(f_127_18302_18321(), f_127_18331_18344(tree)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18297, 18415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18387, 18396);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18297, 18415);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18556, 18672) || true) && (f_127_18560_18602(embeddedTreeMap, f_127_18588_18601(tree)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18556, 18672);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18644, 18653);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18556, 18672);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18764, 18805);

                        f_127_18764_18804(
                                        // map embedded file path to corresponding source tree
                                        embeddedTreeMap, f_127_18784_18797(tree), tree);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18913, 19050);

                        f_127_18913_19049(this, tree, f_127_18968_19011(f_127_18968_18987(compilation)), embeddedFileOrderedSet, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18148, 19065);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19081, 19181);

                var
                embeddedTextBuilder = f_127_19107_19180(f_127_19151_19179(embeddedFileOrderedSet))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19195, 20016);
                    foreach (var path in f_127_19216_19238_I(embeddedFileOrderedSet))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19195, 20016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19272, 19289);

                        SyntaxTree?
                        tree
                        = default(SyntaxTree?);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19307, 19326);

                        EmbeddedText?
                        text
                        = default(EmbeddedText?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19346, 19770) || true) && (f_127_19350_19393(embeddedTreeMap, path, out tree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19346, 19770);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19435, 19488);

                            text = f_127_19442_19487(path, f_127_19472_19486(tree));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19510, 19537);

                            f_127_19510_19536(text != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19346, 19770);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19346, 19770);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19619, 19672);

                            text = f_127_19626_19671(this, path, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19694, 19751);

                            f_127_19694_19750(text != null || (DynAbs.Tracing.TraceSender.Expression_False(127, 19707, 19749) || f_127_19723_19749(diagnostics)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19346, 19770);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19971, 20001);

                        f_127_19971_20000(
                                        // We can safely add nulls because result will be ignored if any error is produced.
                                        // This allows the MoveToImmutable to work below in all cases.
                                        embeddedTextBuilder, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19195, 20016);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 20032, 20077);

                return f_127_20039_20076(embeddedTextBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 17572, 20088);

                Microsoft.CodeAnalysis.CompilationOptions
                f_127_17720_17739(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17720, 17739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_127_17720_17763(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17720, 17763);
                    return return_v;
                }


                int
                f_127_17707_17774(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17707, 17774);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17793_17802()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17793, 17802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17989_17998()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17989, 17998);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_127_17954_18020(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17954, 18020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_18087_18096()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18087, 18096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                f_127_18064_18131(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.OrderedSet<string>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18064, 18131);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_18169_18192(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18169, 18192);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_18302_18321()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18302, 18321);
                    return return_v;
                }


                string
                f_127_18331_18344(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18331, 18344);
                    return return_v;
                }


                bool
                f_127_18302_18345(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18302, 18345);
                    return return_v;
                }


                string
                f_127_18588_18601(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18588, 18601);
                    return return_v;
                }


                bool
                f_127_18560_18602(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18560, 18602);
                    return return_v;
                }


                string
                f_127_18784_18797(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18784, 18797);
                    return return_v;
                }


                int
                f_127_18764_18804(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, Microsoft.CodeAnalysis.SyntaxTree
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18764, 18804);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_18968_18987(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18968, 18987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver
                f_127_18968_19011(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18968, 19011);
                    return return_v;
                }


                int
                f_127_18913_19049(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                embeddedFiles, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ResolveEmbeddedFilesFromExternalSourceDirectives(tree, resolver, embeddedFiles, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18913, 19049);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_18169_18192_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18169, 18192);
                    return return_v;
                }


                int
                f_127_19151_19179(Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 19151, 19179);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                f_127_19107_19180(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<EmbeddedText?>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19107, 19180);
                    return return_v;
                }


                bool
                f_127_19350_19393(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, out Microsoft.CodeAnalysis.SyntaxTree?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19350, 19393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_19472_19486(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19472, 19486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_19442_19487(string
                filePath, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = EmbeddedText.FromSource(filePath, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19442, 19487);
                    return return_v;
                }


                int
                f_127_19510_19536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19510, 19536);
                    return 0;
                }


                Microsoft.CodeAnalysis.EmbeddedText?
                f_127_19626_19671(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryReadEmbeddedFileContent(filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19626, 19671);
                    return return_v;
                }


                bool
                f_127_19723_19749(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19723, 19749);
                    return return_v;
                }


                int
                f_127_19694_19750(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19694, 19750);
                    return 0;
                }


                int
                f_127_19971_20000(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                this_param, Microsoft.CodeAnalysis.EmbeddedText?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19971, 20000);
                    return 0;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                f_127_19216_19238_I(Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19216, 19238);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                f_127_20039_20076(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                this_param)
                {
                    var return_v = this_param.MoveToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 20039, 20076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 17572, 20088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 17572, 20088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void ResolveEmbeddedFilesFromExternalSourceDirectives(
                    SyntaxTree tree,
                    SourceReferenceResolver resolver,
                    OrderedSet<string> embeddedFiles,
                    DiagnosticBag diagnostics);

        private static IReadOnlySet<string> GetEmbeddedSourcePaths(CommandLineArguments arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 20352, 21461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 20467, 20608) || true) && (arguments.EmbeddedFiles.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 20467, 20608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 20536, 20593);

                    return f_127_20543_20592();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 20467, 20608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21226, 21301);

                var
                set = f_127_21236_21300(arguments.EmbeddedFiles.Select(f => f.Path))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21315, 21376);

                f_127_21315_21375(set, arguments.SourceFiles.Select(f => f.Path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21390, 21450);

                return f_127_21397_21449(set);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 20352, 21461);

                Roslyn.Utilities.IReadOnlySet<string>
                f_127_20543_20592()
                {
                    var return_v = SpecializedCollections.EmptyReadOnlySet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 20543, 20592);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_127_21236_21300(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21236, 21300);
                    return return_v;
                }


                int
                f_127_21315_21375(System.Collections.Generic.HashSet<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                other)
                {
                    this_param.IntersectWith(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21315, 21375);
                    return 0;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_21397_21449(System.Collections.Generic.HashSet<string>
                set)
                {
                    var return_v = SpecializedCollections.StronglyTypedReadOnlySet((System.Collections.Generic.ISet<string>)set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21397, 21449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 20352, 21461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 20352, 21461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticInfo ToFileReadDiagnostics(CommonMessageProvider messageProvider, Exception e, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 21473, 22291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21619, 21649);

                DiagnosticInfo
                diagnosticInfo
                = default(DiagnosticInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21665, 22242) || true) && (e is FileNotFoundException || (DynAbs.Tracing.TraceSender.Expression_False(127, 21669, 21730) || e is DirectoryNotFoundException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21665, 22242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21764, 21861);

                    diagnosticInfo = f_127_21781_21860(messageProvider, f_127_21817_21849(messageProvider), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21665, 22242);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21665, 22242);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21895, 22242) || true) && (e is InvalidDataException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21895, 22242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21958, 22053);

                        diagnosticInfo = f_127_21975_22052(messageProvider, f_127_22011_22041(messageProvider), filePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21895, 22242);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21895, 22242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22119, 22227);

                        diagnosticInfo = f_127_22136_22226(messageProvider, f_127_22172_22204(messageProvider), filePath, f_127_22216_22225(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21895, 22242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21665, 22242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22258, 22280);

                return diagnosticInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 21473, 22291);

                int
                f_127_21817_21849(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_FileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 21817, 21849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_21781_21860(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21781, 21860);
                    return return_v;
                }


                int
                f_127_22011_22041(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BinaryFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 22011, 22041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_21975_22052(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21975, 22052);
                    return return_v;
                }


                int
                f_127_22172_22204(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_NoSourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 22172, 22204);
                    return return_v;
                }


                string
                f_127_22216_22225(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 22216, 22225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_22136_22226(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22136, 22226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 21473, 22291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 21473, 22291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ReportDiagnostics(IEnumerable<Diagnostic> diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 22391, 25820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22565, 22588);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22602, 22773);
                    foreach (var diag in f_127_22623_22634_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22602, 22773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22668, 22758);

                        f_127_22668_22757(diag, (DynAbs.Tracing.TraceSender.Conditional_F1(127, 22691, 22710) || ((compilation == null && DynAbs.Tracing.TraceSender.Conditional_F2(127, 22713, 22717)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 22720, 22756))) ? null : f_127_22720_22756(diag, compilation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22602, 22773);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22789, 22806);

                return hasErrors;

                void reportDiagnostic(Diagnostic diag, SuppressionInfo? suppressionInfo)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 22854, 25809);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22959, 24119) || true) && (f_127_22963_22998(_reportedDiagnostics, diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22959, 24119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 23887, 23894);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22959, 24119);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22959, 24119);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 23936, 24119) || true) && (f_127_23940_23953(diag) == DiagnosticSeverity.Hidden)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 23936, 24119);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24093, 24100);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 23936, 24119);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22959, 24119);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24329, 24382);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(errorLoggerOpt, 127, 24329, 24381)?.LogDiagnostic(diag, suppressionInfo), 127, 24344, 24381);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24660, 25275) || true) && (f_127_24664_24696(diag) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24660, 25275);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24746, 25172);
                                foreach (var (id, justification) in f_127_24782_24827_I(f_127_24782_24827(f_127_24782_24814(diag))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24746, 25172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24877, 24950);

                                    var
                                    suppressionDiag = f_127_24899_24949(diag, id, justification)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24976, 25149) || true) && (f_127_24980_25021(_reportedDiagnostics, suppressionDiag))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24976, 25149);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25079, 25122);

                                        f_127_25079_25121(this, suppressionDiag, consoleOutput);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24976, 25149);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24746, 25172);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 427);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 427);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25196, 25227);

                            f_127_25196_25226(
                                                _reportedDiagnostics, diag);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25249, 25256);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24660, 25275);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25295, 25384) || true) && (f_127_25299_25316(diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 25295, 25384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25358, 25365);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 25295, 25384);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25568, 25691) || true) && (f_127_25572_25585(diag) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 25568, 25691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25655, 25672);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 25568, 25691);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25711, 25743);

                        f_127_25711_25742(this, diag, consoleOutput);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25763, 25794);

                        f_127_25763_25793(
                                        _reportedDiagnostics, diag);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(127, 22854, 25809);

                        bool
                        f_127_22963_22998(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22963, 22998);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_127_23940_23953(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 23940, 23953);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
                        f_127_24664_24696(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.ProgrammaticSuppressionInfo;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24664, 24696);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        f_127_24782_24814(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.ProgrammaticSuppressionInfo;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24782, 24814);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        f_127_24782_24827(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        this_param)
                        {
                            var return_v = this_param.Suppressions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24782, 24827);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        f_127_24899_24949(Microsoft.CodeAnalysis.Diagnostic
                        originalDiagnostic, string
                        suppressionId, Microsoft.CodeAnalysis.LocalizableString
                        suppressionJustification)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic(originalDiagnostic, suppressionId, suppressionJustification);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24899, 24949);
                            return return_v;
                        }


                        bool
                        f_127_24980_25021(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        item)
                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostic)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24980, 25021);
                            return return_v;
                        }


                        int
                        f_127_25079_25121(Microsoft.CodeAnalysis.CommonCompiler
                        this_param, Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        diagnostic, System.IO.TextWriter
                        consoleOutput)
                        {
                            this_param.PrintError((Microsoft.CodeAnalysis.Diagnostic)diagnostic, consoleOutput);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25079, 25121);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        f_127_24782_24827_I(System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24782, 24827);
                            return return_v;
                        }


                        bool
                        f_127_25196_25226(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25196, 25226);
                            return return_v;
                        }


                        bool
                        f_127_25299_25316(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.IsSuppressed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 25299, 25316);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_127_25572_25585(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 25572, 25585);
                            return return_v;
                        }


                        int
                        f_127_25711_25742(Microsoft.CodeAnalysis.CommonCompiler
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        diagnostic, System.IO.TextWriter
                        consoleOutput)
                        {
                            this_param.PrintError(diagnostic, consoleOutput);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25711, 25742);
                            return 0;
                        }


                        bool
                        f_127_25763_25793(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25763, 25793);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 22854, 25809);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 22854, 25809);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 22391, 25820);

                Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo?
                f_127_22720_22756(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetSuppressionInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22720, 22756);
                    return return_v;
                }


                int
                f_127_22668_22757(Microsoft.CodeAnalysis.Diagnostic
                diag, Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo?
                suppressionInfo)
                {
                    reportDiagnostic(diag, suppressionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22668, 22757);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_22623_22634_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22623, 22634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 22391, 25820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 22391, 25820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReportDiagnostics(DiagnosticBag diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 26072, 26162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 26075, 26162);
                return f_127_26075_26162(this, f_127_26093_26117(diagnostics), consoleOutput, errorLoggerOpt, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 26072, 26162);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 26072, 26162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 26072, 26162);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            f_127_26093_26117(Microsoft.CodeAnalysis.DiagnosticBag
            this_param)
            {
                var return_v = this_param.ToReadOnly();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26093, 26117);
                return return_v;
            }


            bool
            f_127_26075_26162(Microsoft.CodeAnalysis.CommonCompiler
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics, System.IO.TextWriter
            consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
            errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
            compilation)
            {
                var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26075, 26162);
                return return_v;
            }

        }

        internal bool ReportDiagnostics(IEnumerable<DiagnosticInfo> diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 26430, 26547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 26433, 26547);
                return f_127_26433_26547(this, f_127_26451_26502(diagnostics, info => Diagnostic.Create(info)), consoleOutput, errorLoggerOpt, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 26430, 26547);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 26430, 26547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 26430, 26547);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            f_127_26451_26502(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>
            source, System.Func<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26451, 26502);
                return return_v;
            }


            bool
            f_127_26433_26547(Microsoft.CodeAnalysis.CommonCompiler
            this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics, System.IO.TextWriter
            consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
            errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
            compilation)
            {
                var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26433, 26547);
                return return_v;
            }

        }

        internal static bool HasUnsuppressableErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 27035, 27370);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27131, 27332);
                    foreach (var diag in f_127_27152_27178_I(f_127_27152_27178(diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27131, 27332);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27212, 27317) || true) && (f_127_27216_27244(diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27212, 27317);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27286, 27298);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27212, 27317);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27131, 27332);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27346, 27359);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 27035, 27370);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27152_27178(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27152, 27178);
                    return return_v;
                }


                bool
                f_127_27216_27244(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsUnsuppressableError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27216, 27244);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27152_27178_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27152, 27178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 27035, 27370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 27035, 27370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasUnsuppressedErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 27652, 28002);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27746, 27962);
                    foreach (Diagnostic diagnostic in f_127_27780_27806_I(f_127_27780_27806(diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27746, 27962);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27840, 27947) || true) && (f_127_27844_27874(diagnostic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27840, 27947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27916, 27928);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27840, 27947);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27746, 27962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27978, 27991);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 27652, 28002);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27780_27806(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27780, 27806);
                    return return_v;
                }


                bool
                f_127_27844_27874(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsUnsuppressedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 27844, 27874);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27780_27806_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27780, 27806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 27652, 28002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 27652, 28002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void PrintError(Diagnostic diagnostic, TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 28014, 28205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28121, 28194);

                f_127_28121_28193(consoleOutput, f_127_28145_28192(f_127_28145_28164(), diagnostic, f_127_28184_28191()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 28014, 28205);

                Microsoft.CodeAnalysis.DiagnosticFormatter
                f_127_28145_28164()
                {
                    var return_v = DiagnosticFormatter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28145, 28164);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_28184_28191()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28184, 28191);
                    return return_v;
                }


                string
                f_127_28145_28192(Microsoft.CodeAnalysis.DiagnosticFormatter
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Globalization.CultureInfo
                formatter)
                {
                    var return_v = this_param.Format(diagnostic, (System.IFormatProvider)formatter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28145, 28192);
                    return return_v;
                }


                int
                f_127_28121_28193(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28121, 28193);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 28014, 28205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 28014, 28205);
            }
        }

        public SarifErrorLogger? GetErrorLogger(TextWriter consoleOutput, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 28217, 29789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28344, 28398);

                f_127_28344_28397(f_127_28357_28388_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_28357_28382(f_127_28357_28366()), 127, 28357, 28388)?.Path) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28414, 28460);

                var
                diagnostics = f_127_28432_28459()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28474, 28766);

                var
                errorLog = f_127_28489_28765(this, f_127_28498_28528(f_127_28498_28523(f_127_28498_28507())), diagnostics, FileMode.Create, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28782, 28807);

                SarifErrorLogger?
                logger
                = default(SarifErrorLogger?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28821, 29625) || true) && (errorLog == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 28821, 29625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28875, 28916);

                    f_127_28875_28915(f_127_28888_28914(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28934, 28948);

                    logger = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 28821, 29625);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 28821, 29625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29014, 29046);

                    string
                    toolName = f_127_29032_29045(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29064, 29110);

                    string
                    compilerVersion = f_127_29089_29109(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29128, 29192);

                    Version
                    assemblyVersion = f_127_29154_29174(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version?>(127, 29154, 29191) ?? f_127_29178_29191())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29212, 29610) || true) && (f_127_29216_29254(f_127_29216_29241(f_127_29216_29225())) == SarifVersion.Sarif1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 29212, 29610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29319, 29414);

                        logger = f_127_29328_29413(errorLog, toolName, compilerVersion, assemblyVersion, f_127_29405_29412());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 29212, 29610);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 29212, 29610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29496, 29591);

                        logger = f_127_29505_29590(errorLog, toolName, compilerVersion, assemblyVersion, f_127_29582_29589());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 29212, 29610);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 28821, 29625);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29641, 29750);

                f_127_29641_29749(this, f_127_29659_29690(diagnostics), consoleOutput, errorLoggerOpt: logger, compilation: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29764, 29778);

                return logger;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 28217, 29789);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_28357_28366()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28357, 28366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions?
                f_127_28357_28382(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28357, 28382);
                    return return_v;
                }


                string?
                f_127_28357_28388_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28357, 28388);
                    return return_v;
                }


                int
                f_127_28344_28397(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28344, 28397);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_28432_28459()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28432, 28459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_28498_28507()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28498, 28507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions
                f_127_28498_28523(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28498, 28523);
                    return return_v;
                }


                string
                f_127_28498_28528(Microsoft.CodeAnalysis.ErrorLogOptions
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28498, 28528);
                    return return_v;
                }


                System.IO.Stream?
                f_127_28489_28765(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28489, 28765);
                    return return_v;
                }


                bool
                f_127_28888_28914(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28888, 28914);
                    return return_v;
                }


                int
                f_127_28875_28915(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28875, 28915);
                    return 0;
                }


                string
                f_127_29032_29045(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetToolName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29032, 29045);
                    return return_v;
                }


                string
                f_127_29089_29109(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetCompilerVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29089, 29109);
                    return return_v;
                }


                System.Version?
                f_127_29154_29174(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetAssemblyVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29154, 29174);
                    return return_v;
                }


                System.Version
                f_127_29178_29191()
                {
                    var return_v = new System.Version();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29178, 29191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_29216_29225()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29216, 29225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions
                f_127_29216_29241(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29216, 29241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifVersion
                f_127_29216_29254(Microsoft.CodeAnalysis.ErrorLogOptions
                this_param)
                {
                    var return_v = this_param.SarifVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29216, 29254);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_29405_29412()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29405, 29412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifV1ErrorLogger
                f_127_29328_29413(System.IO.Stream
                stream, string
                toolName, string
                toolFileVersion, System.Version
                toolAssemblyVersion, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = new Microsoft.CodeAnalysis.SarifV1ErrorLogger(stream, toolName, toolFileVersion, toolAssemblyVersion, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29328, 29413);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_29582_29589()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29582, 29589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifV2ErrorLogger
                f_127_29505_29590(System.IO.Stream
                stream, string
                toolName, string
                toolFileVersion, System.Version
                toolAssemblyVersion, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = new Microsoft.CodeAnalysis.SarifV2ErrorLogger(stream, toolName, toolFileVersion, toolAssemblyVersion, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29505, 29590);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_29659_29690(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29659, 29690);
                    return return_v;
                }


                bool
                f_127_29641_29749(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt: (Microsoft.CodeAnalysis.ErrorLogger?)errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29641, 29749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 28217, 29789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 28217, 29789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int Run(TextWriter consoleOutput, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 29894, 31532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30014, 30063);

                var
                saveUICulture = f_127_30034_30062()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30077, 30114);

                SarifErrorLogger?
                errorLogger = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30346, 30373);

                    var
                    culture = f_127_30360_30372(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30391, 30510) || true) && (culture != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30391, 30510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30452, 30491);

                        CultureInfo.CurrentUICulture = culture;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30391, 30510);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30530, 30829) || true) && (f_127_30534_30565_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_30534_30559(f_127_30534_30543()), 127, 30534, 30565)?.Path) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30530, 30829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30615, 30678);

                        errorLogger = f_127_30629_30677(this, consoleOutput, cancellationToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30700, 30810) || true) && (errorLogger == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30700, 30810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30773, 30787);

                            return Failed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30700, 30810);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30530, 30829);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30849, 30911);

                    return f_127_30856_30910(this, consoleOutput, errorLogger, cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 30940, 31366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31007, 31060);

                    var
                    errorCode = f_127_31023_31059(f_127_31023_31038())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31078, 31317) || true) && (errorCode > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 31078, 31317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31137, 31195);

                        var
                        diag = f_127_31148_31194(f_127_31167_31182(), errorCode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31217, 31298);

                        f_127_31217_31297(this, new[] { diag }, consoleOutput, errorLogger, compilation: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 31078, 31317);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31337, 31351);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 30940, 31366);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 31380, 31521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31420, 31465);

                    CultureInfo.CurrentUICulture = saveUICulture;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31483, 31506);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(errorLogger, 127, 31483, 31505)?.Dispose(), 127, 31495, 31505);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(127, 31380, 31521);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 29894, 31532);

                System.Globalization.CultureInfo
                f_127_30034_30062()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30034, 30062);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_30360_30372(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30360, 30372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_30534_30543()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30534, 30543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions?
                f_127_30534_30559(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30534, 30559);
                    return return_v;
                }


                string?
                f_127_30534_30565_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30534, 30565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifErrorLogger?
                f_127_30629_30677(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetErrorLogger(consoleOutput, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 30629, 30677);
                    return return_v;
                }


                int
                f_127_30856_30910(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLogger, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.RunCore(consoleOutput, (Microsoft.CodeAnalysis.ErrorLogger?)errorLogger, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 30856, 30910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_31023_31038()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 31023, 31038);
                    return return_v;
                }


                int
                f_127_31023_31059(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CompileCancelled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 31023, 31059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_31167_31182()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 31167, 31182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_31148_31194(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 31148, 31194);
                    return return_v;
                }


                bool
                f_127_31217_31297(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, (Microsoft.CodeAnalysis.ErrorLogger?)errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 31217, 31297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 29894, 31532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 29894, 31532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected virtual Compilation RunGenerators(Compilation input, ParseOptions parseOptions, ImmutableArray<ISourceGenerator> generators, AnalyzerConfigOptionsProvider analyzerConfigOptionsProvider, ImmutableArray<AdditionalText> additionalTexts, DiagnosticBag generatorDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 32431, 32736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32721, 32734);

                return input;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 32431, 32736);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 32431, 32736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 32431, 32736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int RunCore(TextWriter consoleOutput, ErrorLogger? errorLogger, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 32748, 38118);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer> analyzers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator> generators = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>);
                System.Threading.CancellationTokenSource? analyzerCts = default(System.Threading.CancellationTokenSource?);
                bool reportAnalyzer = default(bool);
                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver? analyzerDriver = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32881, 32921);

                f_127_32881_32920(f_127_32894_32919_M(!f_127_32895_32904().IsScriptRunner));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32937, 32986);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33002, 33142) || true) && (f_127_33006_33030(f_127_33006_33015()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33002, 33142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33064, 33092);

                    f_127_33064_33091(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33110, 33127);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33002, 33142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33158, 33308) || true) && (f_127_33162_33191(f_127_33162_33171()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33158, 33308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33225, 33258);

                    f_127_33225_33257(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33276, 33293);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33158, 33308);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33324, 33423) || true) && (f_127_33328_33349(f_127_33328_33337()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33324, 33423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33383, 33408);

                    f_127_33383_33407(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33324, 33423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33439, 33573) || true) && (f_127_33443_33464(f_127_33443_33452()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33439, 33573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33498, 33523);

                    f_127_33498_33522(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33541, 33558);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33439, 33573);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33589, 33738) || true) && (f_127_33593_33675(this, f_127_33611_33627(f_127_33611_33620()), consoleOutput, errorLogger, compilation: null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33589, 33738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33709, 33723);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33589, 33738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33754, 33849);

                var
                touchedFilesLogger = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 33779, 33815) || (((f_127_33780_33806(f_127_33780_33789()) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 33818, 33841)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 33844, 33848))) ? f_127_33818_33841() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33865, 33911);

                var
                diagnostics = f_127_33883_33910()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33927, 33971);

                AnalyzerConfigSet?
                analyzerConfigSet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33985, 34071);

                ImmutableArray<AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34085, 34143);

                AnalyzerConfigOptionsResult
                globalConfigOptions = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34159, 35032) || true) && (f_127_34163_34172().AnalyzerConfigPaths.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34159, 35032);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34237, 34569) || true) && (!f_127_34242_34332(this, f_127_34266_34295(f_127_34266_34275()), diagnostics, out analyzerConfigSet))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34237, 34569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34374, 34468);

                        var
                        hadErrors = f_127_34390_34467(this, diagnostics, consoleOutput, errorLogger, compilation: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34490, 34514);

                        f_127_34490_34513(hadErrors);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34536, 34550);

                        return Failed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34237, 34569);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34589, 34649);

                    globalConfigOptions = f_127_34611_34648(analyzerConfigSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34667, 34793);

                    sourceFileAnalyzerConfigOptions = f_127_34701_34710().SourceFiles.SelectAsArray(f => analyzerConfigSet.GetOptionsForSourcePath(f.Path));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34813, 35017);
                        foreach (var sourceFileAnalyzerConfigOption in f_127_34860_34891_I(sourceFileAnalyzerConfigOptions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34813, 35017);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34933, 34998);

                            f_127_34933_34997(diagnostics, sourceFileAnalyzerConfigOption.Diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34813, 35017);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 205);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34159, 35032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35048, 35195);

                Compilation?
                compilation = f_127_35075_35194(this, consoleOutput, touchedFilesLogger, errorLogger, sourceFileAnalyzerConfigOptions, globalConfigOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35209, 35295) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35209, 35295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35266, 35280);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35209, 35295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35311, 35360);

                var
                diagnosticInfos = f_127_35333_35359()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35374, 35502);

                f_127_35374_35501(this, diagnosticInfos, f_127_35421_35436(), f_127_35438_35461(f_127_35438_35447()), out analyzers, out generators);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35516, 35632);

                var
                additionalTextFiles = f_127_35542_35631(this, diagnosticInfos, f_127_35595_35610(), touchedFilesLogger)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35646, 35788) || true) && (f_127_35650_35725(this, diagnosticInfos, consoleOutput, errorLogger, compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35646, 35788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35759, 35773);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35646, 35788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35804, 35897);

                ImmutableArray<EmbeddedText?>
                embeddedTexts = f_127_35850_35896(this, compilation, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35911, 36049) || true) && (f_127_35915_35986(this, diagnostics, consoleOutput, errorLogger, compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35911, 36049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 36020, 36034);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35911, 36049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 36065, 36146);

                var
                additionalTexts = ImmutableArray<AdditionalText>.CastUp(additionalTextFiles)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 36162, 36666);

                f_127_36162_36665(this, touchedFilesLogger, ref compilation, analyzers, generators, additionalTexts, analyzerConfigSet, sourceFileAnalyzerConfigOptions, embeddedTexts, diagnostics, cancellationToken, out analyzerCts, out reportAnalyzer, out analyzerDriver);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37100, 37193) || true) && (analyzerCts != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37100, 37193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37157, 37178);

                    f_127_37157_37177(analyzerCts);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37100, 37193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37209, 37351);

                var
                exitCode = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 37224, 37295) || ((f_127_37224_37295(this, diagnostics, consoleOutput, errorLogger, compilation) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 37315, 37321)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 37341, 37350))) ? Failed
                : Succeeded
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37529, 37797);
                    foreach (var additionalFile in f_127_37560_37579_I(additionalTextFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37529, 37797);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37613, 37782) || true) && (f_127_37617_37703(this, f_127_37635_37661(additionalFile), consoleOutput, errorLogger, compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37613, 37782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37745, 37763);

                            exitCode = Failed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37613, 37782);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37529, 37797);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 269);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37813, 37832);

                f_127_37813_37831(
                            diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37846, 38075) || true) && (reportAnalyzer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37846, 38075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37898, 37937);

                    f_127_37898_37936(analyzerDriver is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37955, 38060);

                    f_127_37955_38059(consoleOutput, analyzerDriver, f_127_38014_38021(), f_127_38023_38058(f_127_38023_38042(compilation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37846, 38075);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38091, 38107);

                return exitCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 32748, 38118);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_32895_32904()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32895, 32904);
                    return return_v;
                }


                bool
                f_127_32894_32919_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32894, 32919);
                    return return_v;
                }


                int
                f_127_32881_32920(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 32881, 32920);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33006_33015()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33006, 33015);
                    return return_v;
                }


                bool
                f_127_33006_33030(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33006, 33030);
                    return return_v;
                }


                int
                f_127_33064_33091(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintVersion(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33064, 33091);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33162_33171()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33162, 33171);
                    return return_v;
                }


                bool
                f_127_33162_33191(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayLangVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33162, 33191);
                    return return_v;
                }


                int
                f_127_33225_33257(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintLangVersions(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33225, 33257);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33328_33337()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33328, 33337);
                    return return_v;
                }


                bool
                f_127_33328_33349(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayLogo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33328, 33349);
                    return return_v;
                }


                int
                f_127_33383_33407(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintLogo(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33383, 33407);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33443_33452()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33443, 33452);
                    return return_v;
                }


                bool
                f_127_33443_33464(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33443, 33464);
                    return return_v;
                }


                int
                f_127_33498_33522(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintHelp(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33498, 33522);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33611_33620()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33611, 33620);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_33611_33627(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33611, 33627);
                    return return_v;
                }


                bool
                f_127_33593_33675(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33593, 33675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33780_33789()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33780, 33789);
                    return return_v;
                }


                string?
                f_127_33780_33806(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33780, 33806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TouchedFileLogger
                f_127_33818_33841()
                {
                    var return_v = new Microsoft.CodeAnalysis.TouchedFileLogger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33818, 33841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_33883_33910()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33883, 33910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34163_34172()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34163, 34172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34266_34275()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34266, 34275);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_34266_34295(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.AnalyzerConfigPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34266, 34295);
                    return return_v;
                }


                bool
                f_127_34242_34332(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<string>
                analyzerConfigPaths, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.AnalyzerConfigSet?
                analyzerConfigSet)
                {
                    var return_v = this_param.TryGetAnalyzerConfigSet(analyzerConfigPaths, diagnostics, out analyzerConfigSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34242, 34332);
                    return return_v;
                }


                bool
                f_127_34390_34467(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34390, 34467);
                    return return_v;
                }


                int
                f_127_34490_34513(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34490, 34513);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_34611_34648(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param)
                {
                    var return_v = this_param.GlobalConfigOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34611, 34648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34701_34710()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34701, 34710);
                    return return_v;
                }


                int
                f_127_34933_34997(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34933, 34997);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_34860_34891_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34860, 34891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_127_35075_35194(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                analyzerConfigOptions, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                globalConfigOptions)
                {
                    var return_v = this_param.CreateCompilation(consoleOutput, touchedFilesLogger, errorLoggerOpt, analyzerConfigOptions, globalConfigOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35075, 35194);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_127_35333_35359()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35333, 35359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_35421_35436()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35421, 35436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_35438_35447()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35438, 35447);
                    return return_v;
                }


                bool
                f_127_35438_35461(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SkipAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35438, 35461);
                    return return_v;
                }


                int
                f_127_35374_35501(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                skipAnalyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators)
                {
                    this_param.ResolveAnalyzersFromArguments(diagnostics, messageProvider, skipAnalyzers, out analyzers, out generators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35374, 35501);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_35595_35610()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35595, 35610);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_35542_35631(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger)
                {
                    var return_v = this_param.ResolveAdditionalFilesFromArguments(diagnostics, messageProvider, touchedFilesLogger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35542, 35631);
                    return return_v;
                }


                bool
                f_127_35650_35725(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35650, 35725);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                f_127_35850_35896(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AcquireEmbeddedTexts(compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35850, 35896);
                    return return_v;
                }


                bool
                f_127_35915_35986(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35915, 35986);
                    return return_v;
                }


                int
                f_127_36162_36665(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger, ref Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTextFiles, Microsoft.CodeAnalysis.AnalyzerConfigSet?
                analyzerConfigSet, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                embeddedTexts, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken, out System.Threading.CancellationTokenSource?
                analyzerCts, out bool
                reportAnalyzer, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?
                analyzerDriver)
                {
                    this_param.CompileAndEmit(touchedFilesLogger, ref compilation, analyzers, generators, additionalTextFiles, analyzerConfigSet, sourceFileAnalyzerConfigOptions, embeddedTexts, diagnostics, cancellationToken, out analyzerCts, out reportAnalyzer, out analyzerDriver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 36162, 36665);
                    return 0;
                }


                int
                f_127_37157_37177(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37157, 37177);
                    return 0;
                }


                bool
                f_127_37224_37295(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37224, 37295);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_127_37635_37661(Microsoft.CodeAnalysis.AdditionalTextFile
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 37635, 37661);
                    return return_v;
                }


                bool
                f_127_37617_37703(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37617, 37703);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_37560_37579_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37560, 37579);
                    return return_v;
                }


                int
                f_127_37813_37831(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37813, 37831);
                    return 0;
                }


                int
                f_127_37898_37936(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37898, 37936);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_127_38014_38021()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 38014, 38021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_38023_38042(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 38023, 38042);
                    return return_v;
                }


                bool
                f_127_38023_38058(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 38023, 38058);
                    return return_v;
                }


                int
                f_127_37955_38059(System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                analyzerDriver, System.Globalization.CultureInfo
                culture, bool
                isConcurrentBuild)
                {
                    ReportAnalyzerExecutionTime(consoleOutput, analyzerDriver, culture, isConcurrentBuild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37955, 38059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 32748, 38118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 32748, 38118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CompilerAnalyzerConfigOptionsProvider UpdateAnalyzerConfigOptionsProvider(
                    CompilerAnalyzerConfigOptionsProvider existing,
                    IEnumerable<SyntaxTree> syntaxTrees,
                    ImmutableArray<AnalyzerConfigOptionsResult> sourceFileAnalyzerConfigOptions,
                    ImmutableArray<AdditionalText> additionalFiles = default,
                    ImmutableArray<AnalyzerConfigOptionsResult> additionalFileOptions = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 38130, 40013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38606, 38687);

                var
                builder = f_127_38620_38686()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38701, 38711);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38725, 39264);
                    foreach (var syntaxTree in f_127_38752_38763_I(syntaxTrees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 38725, 39264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38799, 38864);

                        var
                        options = sourceFileAnalyzerConfigOptions[i].AnalyzerOptions
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38970, 39227) || true) && (f_127_38974_38987(options) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 38970, 39227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39033, 39118);

                            f_127_39033_39117(f_127_39046_39077(existing, syntaxTree) == f_127_39081_39116());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39140, 39208);

                            f_127_39140_39207(builder, syntaxTree, f_127_39164_39206(options));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 38970, 39227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39245, 39249);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 38725, 39264);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 540);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39280, 39921) || true) && (f_127_39284_39310_M(!additionalFiles.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39280, 39921);
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39349, 39354)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39344, 39906) || true) && (i < additionalFiles.Length)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39384, 39387)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39344, 39906))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39344, 39906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39429, 39484);

                            var
                            options = additionalFileOptions[i].AnalyzerOptions
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39598, 39887) || true) && (f_127_39602_39615(options) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39598, 39887);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39669, 39762);

                                f_127_39669_39761(f_127_39682_39721(existing, additionalFiles[i]) == f_127_39725_39760());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39788, 39864);

                                f_127_39788_39863(builder, additionalFiles[i], f_127_39820_39862(options));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39598, 39887);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 563);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39280, 39921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39937, 40002);

                return f_127_39944_40001(existing, f_127_39979_40000(builder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 38130, 40013);

                System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                f_127_38620_38686()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<object, AnalyzerConfigOptions>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38620, 38686);
                    return return_v;
                }


                int
                f_127_38974_38987(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 38974, 38987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                f_127_39046_39077(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetOptions(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39046, 39077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39081_39116()
                {
                    var return_v = CompilerAnalyzerConfigOptions.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39081, 39116);
                    return return_v;
                }


                int
                f_127_39033_39117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39033, 39117);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39164_39206(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39164, 39206);
                    return return_v;
                }


                int
                f_127_39140_39207(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                value)
                {
                    this_param.Add((object)key, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39140, 39207);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_38752_38763_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38752, 38763);
                    return return_v;
                }


                bool
                f_127_39284_39310_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39284, 39310);
                    return return_v;
                }


                int
                f_127_39602_39615(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39602, 39615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                f_127_39682_39721(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.AdditionalText
                textFile)
                {
                    var return_v = this_param.GetOptions(textFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39682, 39721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39725_39760()
                {
                    var return_v = CompilerAnalyzerConfigOptions.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39725, 39760);
                    return return_v;
                }


                int
                f_127_39669_39761(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39669, 39761);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39820_39862(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39820, 39862);
                    return return_v;
                }


                int
                f_127_39788_39863(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param, Microsoft.CodeAnalysis.AdditionalText
                key, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                value)
                {
                    this_param.Add((object)key, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39788, 39863);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
                f_127_39979_40000(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39979, 40000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_39944_40001(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
                treeDict)
                {
                    var return_v = this_param.WithAdditionalTreeOptions(treeDict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39944, 40001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 38130, 40013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 38130, 40013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CompileAndEmit(
                    TouchedFileLogger? touchedFilesLogger,
                    ref Compilation compilation,
                    ImmutableArray<DiagnosticAnalyzer> analyzers,
                    ImmutableArray<ISourceGenerator> generators,
                    ImmutableArray<AdditionalText> additionalTextFiles,
                    AnalyzerConfigSet? analyzerConfigSet,
                    ImmutableArray<AnalyzerConfigOptionsResult> sourceFileAnalyzerConfigOptions,
                    ImmutableArray<EmbeddedText?> embeddedTexts,
                    DiagnosticBag diagnostics,
                    CancellationToken cancellationToken,
                    out CancellationTokenSource? analyzerCts,
                    out bool reportAnalyzer,
                    out AnalyzerDriver? analyzerDriver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 40248, 61396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41008, 41027);

                analyzerCts = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41041, 41064);

                reportAnalyzer = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41078, 41100);

                analyzerDriver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41223, 41335);

                f_127_41223_41334(
                            // Print the diagnostics produced during the parsing stage and exit if there were any errors.
                            compilation, CompilationStage.Parse, includeEarlierStages: false, diagnostics, cancellationToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41349, 41445) || true) && (f_127_41353_41389(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41349, 41445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41423, 41430);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41349, 41445);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41461, 41512);

                DiagnosticBag?
                analyzerExceptionDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41526, 48455) || true) && (f_127_41530_41548_M(!analyzers.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(127, 41530, 41571) || f_127_41552_41571_M(!generators.IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41526, 48455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41605, 41678);

                    var
                    analyzerConfigProvider = f_127_41634_41677()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41696, 43001) || true) && (f_127_41700_41709().AnalyzerConfigPaths.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41696, 43001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41782, 41824);

                        f_127_41782_41823(analyzerConfigSet is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41846, 42020);

                        analyzerConfigProvider = f_127_41871_42019(analyzerConfigProvider, f_127_41912_42018(f_127_41946_42001(analyzerConfigSet, string.Empty).AnalyzerOptions));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42256, 42447);

                        ImmutableArray<AnalyzerConfigOptionsResult>
                        additionalFileAnalyzerOptions =
                                                additionalTextFiles.SelectAsArray(f => analyzerConfigSet.GetOptionsForSourcePath(f.Path))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42471, 42637);
                            foreach (var result in f_127_42494_42523_I(additionalFileAnalyzerOptions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 42471, 42637);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42573, 42614);

                                f_127_42573_42613(diagnostics, result.Diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 42471, 42637);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 167);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 167);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42661, 42982);

                        analyzerConfigProvider = f_127_42686_42981(analyzerConfigProvider, f_127_42797_42820(compilation), sourceFileAnalyzerConfigOptions, additionalTextFiles, additionalFileAnalyzerOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41696, 43001);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43021, 46919) || true) && (f_127_43025_43044_M(!generators.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 43021, 46919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43274, 43409);

                        compilation = f_127_43288_43408(this, compilation, f_127_43315_43337(f_127_43315_43324()), generators, analyzerConfigProvider, additionalTextFiles, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43433, 43498);

                        bool
                        hasAnalyzerConfigs = f_127_43459_43497_M(!f_127_43460_43469().AnalyzerConfigPaths.IsEmpty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43520, 43618);

                        bool
                        hasGeneratedOutputPath = !f_127_43551_43617(f_127_43577_43616(f_127_43577_43586()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43642, 43737);

                        var
                        generatedSyntaxTrees = f_127_43669_43736(f_127_43669_43727(f_127_43669_43692(compilation), f_127_43698_43707().SourceFiles.Length))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43761, 43900);

                        var
                        analyzerOptionsBuilder = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 43790, 43808) || ((hasAnalyzerConfigs && DynAbs.Tracing.TraceSender.Conditional_F2(127, 43811, 43892)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 43895, 43899))) ? f_127_43811_43892(f_127_43865_43891(generatedSyntaxTrees)) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43922, 44015);

                        var
                        embeddedTextBuilder = f_127_43948_44014(f_127_43987_44013(generatedSyntaxTrees))
                        ;
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44089, 46215);
                                foreach (var tree in f_127_44110_44130_I(generatedSyntaxTrees))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44089, 46215);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44188, 44244);

                                    f_127_44188_44243(!f_127_44202_44242(f_127_44228_44241(tree)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44274, 44323);

                                    cancellationToken.ThrowIfCancellationRequested();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44355, 44404);

                                    var
                                    sourceText = f_127_44372_44403(tree, cancellationToken)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44535, 44611);

                                    f_127_44535_44610(
                                                                // embed the generated text and get analyzer options for it if needed
                                                                embeddedTextBuilder, f_127_44559_44609(f_127_44583_44596(tree), sourceText));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44641, 44860) || true) && (analyzerOptionsBuilder is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44641, 44860);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44743, 44829);

                                        f_127_44743_44828(analyzerOptionsBuilder, f_127_44770_44827(analyzerConfigSet!, f_127_44813_44826(tree)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44641, 44860);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44969, 46188) || true) && (hasGeneratedOutputPath)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44969, 46188);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45061, 45142);

                                        var
                                        path = f_127_45072_45141(f_127_45085_45094().GeneratedFilesOutputDirectory!, f_127_45127_45140(tree))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45176, 45401) || true) && (f_127_45180_45237(f_127_45197_45236(f_127_45197_45206())))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 45176, 45401);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45311, 45366);

                                            f_127_45311_45365(f_127_45337_45364(path));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 45176, 45401);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45437, 45557);

                                        var
                                        fileStream = f_127_45454_45556(this, path, diagnostics, FileMode.Create, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45591, 46157) || true) && (fileStream is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 45591, 46157);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45689, 45727);

                                            f_127_45689_45726(f_127_45702_45715(tree) is object);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45767, 45862);

                                            using var
                                            disposer = f_127_45788_45861(fileStream, path, diagnostics, f_127_45845_45860())
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45900, 45963);

                                            using var
                                            writer = f_127_45919_45962(fileStream, f_127_45948_45961(tree))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46003, 46047);

                                            f_127_46003_46046(
                                                                                sourceText, writer, cancellationToken);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46085, 46122);

                                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(touchedFilesLogger, 127, 46085, 46121)?.AddWritten(path), 127, 46104, 46121);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 45591, 46157);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44969, 46188);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44089, 46215);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 2127);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 2127);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46243, 46303);

                            embeddedTexts = embeddedTexts.AddRange(embeddedTextBuilder);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46329, 46692) || true) && (analyzerOptionsBuilder is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 46329, 46692);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46423, 46665);

                                analyzerConfigProvider = f_127_46448_46664(analyzerConfigProvider, generatedSyntaxTrees, f_127_46627_46663(analyzerOptionsBuilder));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 46329, 46692);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 46737, 46900);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46793, 46824);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerOptionsBuilder, 127, 46793, 46823)?.Free(), 127, 46816, 46823);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46850, 46877);

                            f_127_46850_46876(embeddedTextBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(127, 46737, 46900);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 43021, 46919);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46939, 47064);

                    AnalyzerOptions
                    analyzerOptions = f_127_46973_47063(this, additionalTextFiles, analyzerConfigProvider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47084, 48440) || true) && (f_127_47088_47106_M(!analyzers.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 47084, 48440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47148, 47229);

                        analyzerCts = f_127_47162_47228(cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47251, 47302);

                        analyzerExceptionDiagnostics = f_127_47282_47301();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47675, 47718);

                        var
                        severityFilter = SeverityFilter.Hidden
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47740, 47839) || true) && (f_127_47744_47766(f_127_47744_47753()) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 47740, 47839);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47801, 47839);

                            severityFilter |= SeverityFilter.Info;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 47740, 47839);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47863, 48335);

                        analyzerDriver = f_127_47880_48334(compilation, analyzers, analyzerOptions, f_127_48066_48096(analyzers), analyzerExceptionDiagnostics.Add, f_127_48182_48206(f_127_48182_48191()), severityFilter, out compilation, f_127_48316_48333(analyzerCts));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48357, 48421);

                        reportAnalyzer = f_127_48374_48398(f_127_48374_48383()) && (DynAbs.Tracing.TraceSender.Expression_True(127, 48374, 48420) && f_127_48402_48420_M(!analyzers.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 47084, 48440);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41526, 48455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48471, 48585);

                f_127_48471_48584(
                            compilation, CompilationStage.Declare, includeEarlierStages: false, diagnostics, cancellationToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48599, 48695) || true) && (f_127_48603_48639(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 48599, 48695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48673, 48680);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 48599, 48695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48711, 48760);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49157, 49228);

                string
                outputName = f_127_49177_49226(this, compilation, cancellationToken)!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49242, 49304);

                var
                finalPeFilePath = f_127_49264_49303(f_127_49264_49273(), outputName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49318, 49378);

                var
                finalPdbFilePath = f_127_49341_49377(f_127_49341_49350(), outputName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49392, 49443);

                var
                finalXmlFilePath = f_127_49415_49442(f_127_49415_49424())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49459, 49517);

                NoThrowStreamDisposer?
                sourceLinkStreamDisposerOpt = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49703, 49910);

                    var
                    emitOptions = f_127_49721_49909(f_127_49721_49799(f_127_49721_49742(f_127_49721_49730()), outputName), f_127_49838_49908(finalPdbFilePath, f_127_49890_49907(f_127_49890_49899())))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50162, 50429) || true) && (f_127_50166_50233(f_127_50166_50197(f_127_50166_50188(f_127_50166_50175())), "pdb-path-determinism") && (DynAbs.Tracing.TraceSender.Expression_True(127, 50166, 50283) && !f_127_50238_50283(f_127_50259_50282(emitOptions))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50162, 50429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50325, 50410);

                        emitOptions = f_127_50339_50409(emitOptions, f_127_50367_50408(f_127_50384_50407(emitOptions)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50162, 50429);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50449, 51160) || true) && (f_127_50453_50473(f_127_50453_50462()) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50449, 51160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50523, 50767);

                        var
                        sourceLinkStreamOpt = f_127_50549_50766(this, f_127_50584_50604(f_127_50584_50593()), diagnostics, FileMode.Open, FileAccess.Read, FileShare.Read)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50791, 51141) || true) && (sourceLinkStreamOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50791, 51141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50872, 51118);

                            sourceLinkStreamDisposerOpt = f_127_50902_51117(sourceLinkStreamOpt, f_127_51008_51028(f_127_51008_51017()), diagnostics, f_127_51101_51116());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50791, 51141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50449, 51160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51180, 51636);

                    var
                    moduleBeingBuilt = f_127_51203_51635(compilation, diagnostics, f_127_51306_51333(f_127_51306_51315()), emitOptions, debugEntryPoint: null, sourceLinkStream: f_127_51452_51487_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 51452, 51487)?.Stream), embeddedTexts: embeddedTexts, testData: null, cancellationToken: cancellationToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51656, 60429) || true) && (moduleBeingBuilt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 51656, 60429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51726, 51739);

                        bool
                        success
                        = default(bool);

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51815, 52225);

                            success = f_127_51825_52224(compilation, moduleBeingBuilt, f_127_51929_51946(f_127_51929_51938()), f_127_51977_52005(emitOptions), f_127_52036_52068(emitOptions), diagnostics, filterOpt: null, cancellationToken: cancellationToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 52826, 53049) || true) && (analyzerDriver != null && (DynAbs.Tracing.TraceSender.Expression_True(127, 52830, 52893) && f_127_52856_52893_M(!diagnostics.IsEmptyWithoutResolution)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 52826, 53049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 52951, 53022);

                                f_127_52951_53021(analyzerDriver, diagnostics, compilation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 52826, 53049);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53077, 53216) || true) && (f_127_53081_53115(diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53077, 53216);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53173, 53189);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53077, 53216);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53244, 56557) || true) && (success)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53244, 56557);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53509, 53560);

                                NoThrowStreamDisposer?
                                xmlStreamDisposerOpt = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53592, 55027) || true) && (finalXmlFilePath != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53592, 55027);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53686, 54070);

                                    var
                                    xmlStreamOpt = f_127_53705_54069(this, finalXmlFilePath, diagnostics, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54106, 54246) || true) && (xmlStreamOpt == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 54106, 54246);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54204, 54211);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 54106, 54246);
                                    }

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54358, 54384);

                                        f_127_54358_54383(xmlStreamOpt, 0);
                                    }
                                    catch (Exception e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 54453, 54702);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54545, 54622);

                                        f_127_54545_54621(f_127_54545_54560(), e, finalXmlFilePath, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54660, 54667);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(127, 54453, 54702);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54736, 54996);

                                    xmlStreamDisposerOpt = f_127_54759_54995(xmlStreamOpt, finalXmlFilePath, diagnostics, f_127_54979_54994());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53592, 55027);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55059, 56054);
                                using (xmlStreamDisposerOpt)
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55152, 56023);
                                    using (var
                                    win32ResourceStreamOpt = f_127_55188_55259(f_127_55206_55221(), f_127_55223_55232(), compilation, diagnostics)
                                    )
                                    {

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55333, 55501) || true) && (f_127_55337_55373(diagnostics))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 55333, 55501);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55455, 55462);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 55333, 55501);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55541, 55988);

                                        success = f_127_55551_55987(compilation, moduleBeingBuilt, f_127_55706_55734_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(xmlStreamDisposerOpt, 127, 55706, 55734)?.Stream), win32ResourceStreamOpt, f_127_55842_55872(emitOptions), diagnostics, cancellationToken);
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 55152, 56023);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 55059, 56054);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56086, 56242) || true) && (f_127_56090_56130_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(xmlStreamDisposerOpt, 127, 56090, 56130)?.HasFailedToDispose) == true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56086, 56242);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56204, 56211);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56086, 56242);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56352, 56530) || true) && (success)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56352, 56530);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56429, 56499);

                                    f_127_56429_56498(compilation, null, diagnostics, cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56352, 56530);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53244, 56557);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56585, 56617);

                            f_127_56585_56616(
                                                    compilation, null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56645, 57524) || true) && (analyzerDriver != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56645, 57524);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56975, 57052);

                                var
                                hostDiagnostics = f_127_56997_57051(f_127_56997_57044(analyzerDriver, compilation))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57082, 57120);

                                f_127_57082_57119(diagnostics, hostDiagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57152, 57497) || true) && (f_127_57156_57193_M(!diagnostics.IsEmptyWithoutResolution))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57152, 57497);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57395, 57466);

                                    f_127_57395_57465(                                // Apply diagnostic suppressions for analyzer and/or compiler diagnostics from diagnostic suppressors.
                                                                    analyzerDriver, diagnostics, compilation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57152, 57497);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56645, 57524);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 57569, 57687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57625, 57664);

                            f_127_57625_57663(moduleBeingBuilt);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(127, 57569, 57687);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57711, 57838) || true) && (f_127_57715_57749(diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57711, 57838);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57799, 57815);

                            success = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57711, 57838);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57862, 60410) || true) && (success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57862, 60410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57923, 58000);

                            var
                            peStreamProvider = f_127_57946_57999(this, finalPeFilePath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58026, 58139);

                            var
                            pdbStreamProviderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 58053, 58074) || ((f_127_58053_58074(f_127_58053_58062()) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 58077, 58131)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 58134, 58138))) ? f_127_58077_58131(this, finalPdbFilePath) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58167, 58224);

                            string?
                            finalRefPeFilePath = f_127_58196_58223(f_127_58196_58205())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58250, 58372);

                            var
                            refPeStreamProviderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 58279, 58305) || ((finalRefPeFilePath != null && DynAbs.Tracing.TraceSender.Conditional_F2(127, 58308, 58364)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 58367, 58371))) ? f_127_58308_58364(this, finalRefPeFilePath) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58400, 58436);

                            RSAParameters?
                            privateKeyOpt = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58462, 58718) || true) && (f_127_58466_58504(f_127_58466_58485(compilation)) != null && (DynAbs.Tracing.TraceSender.Expression_True(127, 58466, 58544) && f_127_58516_58544(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(127, 58466, 58579) && f_127_58548_58579_M(!f_127_58549_58568(compilation).PublicSign)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 58462, 58718);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58637, 58691);

                                privateKeyOpt = f_127_58653_58679(compilation).PrivateKey;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 58462, 58718);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58925, 59005);

                            emitOptions = f_127_58939_59004(emitOptions, f_127_58982_59003(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59033, 59567);

                            success = f_127_59043_59566(compilation, moduleBeingBuilt, peStreamProvider, refPeStreamProviderOpt, pdbStreamProviderOpt, testSymWriterFactory: null, diagnostics: diagnostics, emitOptions: emitOptions, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59595, 59631);

                            f_127_59595_59630(
                                                    peStreamProvider, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59657, 59700);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(refPeStreamProviderOpt, 127, 59657, 59699)?.Close(diagnostics), 127, 59680, 59699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59726, 59767);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pdbStreamProviderOpt, 127, 59726, 59766)?.Close(diagnostics), 127, 59747, 59766);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59795, 60387) || true) && (success && (DynAbs.Tracing.TraceSender.Expression_True(127, 59799, 59836) && touchedFilesLogger != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 59795, 60387);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59894, 60071) || true) && (pdbStreamProviderOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 59894, 60071);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59992, 60040);

                                    f_127_59992_60039(touchedFilesLogger, finalPdbFilePath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 59894, 60071);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60101, 60283) || true) && (refPeStreamProviderOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60101, 60283);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60201, 60252);

                                    f_127_60201_60251(touchedFilesLogger, finalRefPeFilePath!);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60101, 60283);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60313, 60360);

                                f_127_60313_60359(touchedFilesLogger, finalPeFilePath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 59795, 60387);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57862, 60410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 51656, 60429);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60449, 60557) || true) && (f_127_60453_60489(diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60449, 60557);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60531, 60538);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60449, 60557);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 60586, 60680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60626, 60665);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 60626, 60664)?.Dispose(), 127, 60654, 60664);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(127, 60586, 60680);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60696, 60811) || true) && (f_127_60700_60747_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 60700, 60747)?.HasFailedToDispose) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60696, 60811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60789, 60796);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60696, 60811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60827, 60876);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60892, 61175) || true) && (analyzerExceptionDiagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60892, 61175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60966, 61017);

                    f_127_60966_61016(diagnostics, analyzerExceptionDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61035, 61160) || true) && (f_127_61039_61092(analyzerExceptionDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61035, 61160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61134, 61141);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61035, 61160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60892, 61175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61191, 61240);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61256, 61385) || true) && (!f_127_61261_61329(this, diagnostics, touchedFilesLogger, finalXmlFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61256, 61385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61363, 61370);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61256, 61385);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 40248, 61396);

                int
                f_127_41223_41334(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, bool
                includeEarlierStages, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.GetDiagnostics(stage, includeEarlierStages: includeEarlierStages, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41223, 41334);
                    return 0;
                }


                bool
                f_127_41353_41389(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41353, 41389);
                    return return_v;
                }


                bool
                f_127_41530_41548_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41530, 41548);
                    return return_v;
                }


                bool
                f_127_41552_41571_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41552, 41571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_41634_41677()
                {
                    var return_v = CompilerAnalyzerConfigOptionsProvider.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41634, 41677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_41700_41709()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41700, 41709);
                    return return_v;
                }


                int
                f_127_41782_41823(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41782, 41823);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_41946_42001(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param, string
                sourcePath)
                {
                    var return_v = this_param.GetOptionsForSourcePath(sourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41946, 42001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_41912_42018(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41912, 42018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_41871_42019(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                globalOptions)
                {
                    var return_v = this_param.WithGlobalOptions((Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)globalOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41871, 42019);
                    return return_v;
                }


                int
                f_127_42573_42613(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42573, 42613);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_42494_42523_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42494, 42523);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_42797_42820(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 42797, 42820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_42686_42981(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                existing, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalFiles, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                additionalFileOptions)
                {
                    var return_v = UpdateAnalyzerConfigOptionsProvider(existing, syntaxTrees, sourceFileAnalyzerConfigOptions, additionalFiles, additionalFileOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42686, 42981);
                    return return_v;
                }


                bool
                f_127_43025_43044_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43025, 43044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43315_43324()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43315, 43324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_127_43315_43337(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ParseOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43315, 43337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_127_43288_43408(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                input, Microsoft.CodeAnalysis.ParseOptions
                parseOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                analyzerConfigOptionsProvider, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTexts, Microsoft.CodeAnalysis.DiagnosticBag
                generatorDiagnostics)
                {
                    var return_v = this_param.RunGenerators(input, parseOptions, generators, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider)analyzerConfigOptionsProvider, additionalTexts, generatorDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43288, 43408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43460_43469()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43460, 43469);
                    return return_v;
                }


                bool
                f_127_43459_43497_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43459, 43497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43577_43586()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43577, 43586);
                    return return_v;
                }


                string?
                f_127_43577_43616(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.GeneratedFilesOutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43577, 43616);
                    return return_v;
                }


                bool
                f_127_43551_43617(string?
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43551, 43617);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43669_43692(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43669, 43692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43698_43707()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43698, 43707);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43669_43727(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source, int
                count)
                {
                    var return_v = source.Skip<Microsoft.CodeAnalysis.SyntaxTree>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43669, 43727);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43669_43736(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43669, 43736);
                    return return_v;
                }


                int
                f_127_43865_43891(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43865, 43891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_43811_43892(int
                capacity)
                {
                    var return_v = ArrayBuilder<AnalyzerConfigOptionsResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43811, 43892);
                    return return_v;
                }


                int
                f_127_43987_44013(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43987, 44013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                f_127_43948_44014(int
                capacity)
                {
                    var return_v = ArrayBuilder<EmbeddedText>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43948, 44014);
                    return return_v;
                }


                string
                f_127_44228_44241(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44228, 44241);
                    return return_v;
                }


                bool
                f_127_44202_44242(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44202, 44242);
                    return return_v;
                }


                int
                f_127_44188_44243(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44188, 44243);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_44372_44403(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44372, 44403);
                    return return_v;
                }


                string
                f_127_44583_44596(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44583, 44596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_44559_44609(string
                filePath, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = EmbeddedText.FromSource(filePath, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44559, 44609);
                    return return_v;
                }


                int
                f_127_44535_44610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                this_param, Microsoft.CodeAnalysis.EmbeddedText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44535, 44610);
                    return 0;
                }


                string
                f_127_44813_44826(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44813, 44826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_44770_44827(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param, string
                sourcePath)
                {
                    var return_v = this_param.GetOptionsForSourcePath(sourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44770, 44827);
                    return return_v;
                }


                int
                f_127_44743_44828(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44743, 44828);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_45085_45094()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45085, 45094);
                    return return_v;
                }


                string
                f_127_45127_45140(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45127, 45140);
                    return return_v;
                }


                string
                f_127_45072_45141(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45072, 45141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_45197_45206()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45197, 45206);
                    return return_v;
                }


                string?
                f_127_45197_45236(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.GeneratedFilesOutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45197, 45236);
                    return return_v;
                }


                bool
                f_127_45180_45237(string?
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45180, 45237);
                    return return_v;
                }


                string?
                f_127_45337_45364(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45337, 45364);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_127_45311_45365(string?
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45311, 45365);
                    return return_v;
                }


                System.IO.Stream?
                f_127_45454_45556(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45454, 45556);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_45702_45715(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45702, 45715);
                    return return_v;
                }


                int
                f_127_45689_45726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45689, 45726);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_45845_45860()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45845, 45860);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_45788_45861(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45788, 45861);
                    return return_v;
                }


                System.Text.Encoding
                f_127_45948_45961(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45948, 45961);
                    return return_v;
                }


                System.IO.StreamWriter
                f_127_45919_45962(System.IO.Stream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter(stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45919, 45962);
                    return return_v;
                }


                int
                f_127_46003_46046(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.IO.StreamWriter
                textWriter, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Write((System.IO.TextWriter)textWriter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46003, 46046);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_44110_44130_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44110, 44130);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_46627_46663(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46627, 46663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_46448_46664(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                existing, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions)
                {
                    var return_v = UpdateAnalyzerConfigOptionsProvider(existing, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, sourceFileAnalyzerConfigOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46448, 46664);
                    return return_v;
                }


                int
                f_127_46850_46876(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46850, 46876);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_127_46973_47063(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTextFiles, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                analyzerConfigOptionsProvider)
                {
                    var return_v = this_param.CreateAnalyzerOptions(additionalTextFiles, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider)analyzerConfigOptionsProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46973, 47063);
                    return return_v;
                }


                bool
                f_127_47088_47106_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47088, 47106);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_127_47162_47228(params System.Threading.CancellationToken[]
                tokens)
                {
                    var return_v = CancellationTokenSource.CreateLinkedTokenSource(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47162, 47228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_47282_47301()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47282, 47301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_47744_47753()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47744, 47753);
                    return return_v;
                }


                string?
                f_127_47744_47766(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47744, 47766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_127_48066_48096(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 48066, 48096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_48182_48191()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48182, 48191);
                    return return_v;
                }


                bool
                f_127_48182_48206(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReportAnalyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48182, 48206);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_127_48316_48333(System.Threading.CancellationTokenSource
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48316, 48333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_127_47880_48334(Microsoft.CodeAnalysis.Compilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                options, Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                analyzerManager, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                addExceptionDiagnostic, bool
                reportAnalyzer, Microsoft.CodeAnalysis.Diagnostics.SeverityFilter
                severityFilter, out Microsoft.CodeAnalysis.Compilation
                newCompilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = AnalyzerDriver.CreateAndAttachToCompilation(compilation, analyzers, options, analyzerManager, addExceptionDiagnostic, reportAnalyzer, severityFilter, out newCompilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47880, 48334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_48374_48383()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48374, 48383);
                    return return_v;
                }


                bool
                f_127_48374_48398(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReportAnalyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48374, 48398);
                    return return_v;
                }


                bool
                f_127_48402_48420_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48402, 48420);
                    return return_v;
                }


                int
                f_127_48471_48584(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, bool
                includeEarlierStages, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.GetDiagnostics(stage, includeEarlierStages: includeEarlierStages, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 48471, 48584);
                    return 0;
                }


                bool
                f_127_48603_48639(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 48603, 48639);
                    return return_v;
                }


                string
                f_127_49177_49226(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOutputFileName(compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49177, 49226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49264_49273()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49264, 49273);
                    return return_v;
                }


                string
                f_127_49264_49303(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, string
                outputFileName)
                {
                    var return_v = this_param.GetOutputFilePath(outputFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49264, 49303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49341_49350()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49341, 49350);
                    return return_v;
                }


                string
                f_127_49341_49377(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, string
                outputFileName)
                {
                    var return_v = this_param.GetPdbFilePath(outputFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49341, 49377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49415_49424()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49415, 49424);
                    return return_v;
                }


                string?
                f_127_49415_49442(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DocumentationPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49415, 49442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49721_49730()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49721, 49730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49721_49742(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49721, 49742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49721_49799(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                outputName)
                {
                    var return_v = this_param.WithOutputNameOverride(outputName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49721, 49799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49890_49899()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49890, 49899);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_127_49890_49907(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.PathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49890, 49907);
                    return return_v;
                }


                string
                f_127_49838_49908(string
                filePath, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap)
                {
                    var return_v = PathUtilities.NormalizePathPrefix(filePath, pathMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49838, 49908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49721_49909(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                path)
                {
                    var return_v = this_param.WithPdbFilePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49721, 49909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50166_50175()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50166, 50175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_127_50166_50188(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ParseOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50166, 50188);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_127_50166_50197(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50166, 50197);
                    return return_v;
                }


                bool
                f_127_50166_50233(System.Collections.Generic.IReadOnlyDictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50166, 50233);
                    return return_v;
                }


                string?
                f_127_50259_50282(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50259, 50282);
                    return return_v;
                }


                bool
                f_127_50238_50283(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50238, 50283);
                    return return_v;
                }


                string
                f_127_50384_50407(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50384, 50407);
                    return return_v;
                }


                string?
                f_127_50367_50408(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50367, 50408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_50339_50409(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                path)
                {
                    var return_v = this_param.WithPdbFilePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50339, 50409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50453_50462()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50453, 50462);
                    return return_v;
                }


                string?
                f_127_50453_50473(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50453, 50473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50584_50593()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50584, 50593);
                    return return_v;
                }


                string
                f_127_50584_50604(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50584, 50604);
                    return return_v;
                }


                System.IO.Stream?
                f_127_50549_50766(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50549, 50766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_51008_51017()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51008, 51017);
                    return return_v;
                }


                string
                f_127_51008_51028(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51008, 51028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_51101_51116()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51101, 51116);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_50902_51117(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50902, 51117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_51306_51315()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51306, 51315);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ResourceDescription>
                f_127_51306_51333(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ManifestResources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51306, 51333);
                    return return_v;
                }


                System.IO.Stream?
                f_127_51452_51487_M(System.IO.Stream?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51452, 51487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                f_127_51203_51635(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData?
                testData, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CheckOptionsAndCreateModuleBuilder(diagnostics, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources, options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>)embeddedTexts, testData: testData, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 51203, 51635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_51929_51938()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51929, 51938);
                    return return_v;
                }


                bool
                f_127_51929_51946(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitPdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51929, 51946);
                    return return_v;
                }


                bool
                f_127_51977_52005(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51977, 52005);
                    return return_v;
                }


                bool
                f_127_52036_52068(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitTestCoverageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 52036, 52068);
                    return return_v;
                }


                bool
                f_127_51825_52224(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, bool
                emittingPdb, bool
                emitMetadataOnly, bool
                emitTestCoverageData, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Predicate<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>?
                filterOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.CompileMethods(moduleBuilder, emittingPdb, emitMetadataOnly, emitTestCoverageData, diagnostics, filterOpt: filterOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 51825, 52224);
                    return return_v;
                }


                bool
                f_127_52856_52893_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 52856, 52893);
                    return return_v;
                }


                int
                f_127_52951_53021(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 52951, 53021);
                    return 0;
                }


                bool
                f_127_53081_53115(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressedErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 53081, 53115);
                    return return_v;
                }


                System.IO.Stream?
                f_127_53705_54069(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 53705, 54069);
                    return return_v;
                }


                int
                f_127_54358_54383(System.IO.Stream
                this_param, int
                value)
                {
                    this_param.SetLength((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54358, 54383);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_54545_54560()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 54545, 54560);
                    return return_v;
                }


                int
                f_127_54545_54621(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54545, 54621);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_54979_54994()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 54979, 54994);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_54759_54995(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54759, 54995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_55206_55221()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55206, 55221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_55223_55232()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55223, 55232);
                    return return_v;
                }


                System.IO.Stream?
                f_127_55188_55259(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetWin32Resources(messageProvider, arguments, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55188, 55259);
                    return return_v;
                }


                bool
                f_127_55337_55373(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55337, 55373);
                    return return_v;
                }


                System.IO.Stream?
                f_127_55706_55734_M(System.IO.Stream?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55706, 55734);
                    return return_v;
                }


                string?
                f_127_55842_55872(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55842, 55872);
                    return return_v;
                }


                bool
                f_127_55551_55987(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32ResourcesStream, string?
                outputNameOverride, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GenerateResourcesAndDocumentationComments(moduleBeingBuilt, xmlDocumentationStream, win32ResourcesStream, outputNameOverride, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55551, 55987);
                    return return_v;
                }


                bool?
                f_127_56090_56130_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 56090, 56130);
                    return return_v;
                }


                int
                f_127_56429_56498(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ReportUnusedImports(filterTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56429, 56498);
                    return 0;
                }


                int
                f_127_56585_56616(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree)
                {
                    this_param.CompleteTrees(filterTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56585, 56616);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_127_56997_57044(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetDiagnosticsAsync(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56997, 57044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_56997_57051(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 56997, 57051);
                    return return_v;
                }


                int
                f_127_57082_57119(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57082, 57119);
                    return 0;
                }


                bool
                f_127_57156_57193_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 57156, 57193);
                    return return_v;
                }


                int
                f_127_57395_57465(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57395, 57465);
                    return 0;
                }


                int
                f_127_57625_57663(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    this_param.CompilationFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57625, 57663);
                    return 0;
                }


                bool
                f_127_57715_57749(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressedErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57715, 57749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_57946_57999(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57946, 57999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_58053_58062()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58053, 58062);
                    return return_v;
                }


                bool
                f_127_58053_58074(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitPdbFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58053, 58074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_58077_58131(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58077, 58131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_58196_58205()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58196, 58205);
                    return return_v;
                }


                string?
                f_127_58196_58223(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputRefFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58196, 58223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_58308_58364(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58308, 58364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_58466_58485(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58466, 58485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_127_58466_58504(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58466, 58504);
                    return return_v;
                }


                bool
                f_127_58516_58544(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SignUsingBuilder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58516, 58544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_58549_58568(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58549, 58568);
                    return return_v;
                }


                bool
                f_127_58548_58579_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58548, 58579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_127_58653_58679(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58653, 58679);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_58982_59003(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetFallbackEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58982, 59003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_58939_59004(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Text.Encoding?
                fallbackSourceFileEncoding)
                {
                    var return_v = this_param.WithFallbackSourceFileEncoding(fallbackSourceFileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58939, 59004);
                    return return_v;
                }


                bool
                f_127_59043_59566(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                peStreamProvider, Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider?
                metadataPEStreamProvider, Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider?
                pdbStreamProvider, System.Func<Microsoft.DiaSymReader.ISymWriterMetadataProvider, Microsoft.DiaSymReader.SymUnmanagedWriter>?
                testSymWriterFactory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, System.Security.Cryptography.RSAParameters?
                privateKeyOpt, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.SerializeToPeStream(moduleBeingBuilt, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider)peStreamProvider, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider?)metadataPEStreamProvider, (Microsoft.CodeAnalysis.Compilation.EmitStreamProvider?)pdbStreamProvider, testSymWriterFactory: testSymWriterFactory, diagnostics: diagnostics, emitOptions: emitOptions, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 59043, 59566);
                    return return_v;
                }


                int
                f_127_59595_59630(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.Close(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 59595, 59630);
                    return 0;
                }


                int
                f_127_59992_60039(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 59992, 60039);
                    return 0;
                }


                int
                f_127_60201_60251(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60201, 60251);
                    return 0;
                }


                int
                f_127_60313_60359(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60313, 60359);
                    return 0;
                }


                bool
                f_127_60453_60489(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60453, 60489);
                    return return_v;
                }


                bool?
                f_127_60700_60747_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 60700, 60747);
                    return return_v;
                }


                int
                f_127_60966_61016(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60966, 61016);
                    return 0;
                }


                bool
                f_127_61039_61092(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61039, 61092);
                    return return_v;
                }


                bool
                f_127_61261_61329(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger, string?
                finalXmlFilePath)
                {
                    var return_v = this_param.WriteTouchedFiles(diagnostics, touchedFilesLogger, finalXmlFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61261, 61329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 40248, 61396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 40248, 61396);
            }
        }

        protected virtual Diagnostics.AnalyzerOptions CreateAnalyzerOptions(
                    ImmutableArray<AdditionalText> additionalTextFiles,
                    AnalyzerConfigOptionsProvider analyzerConfigOptionsProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 61661, 61747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61664, 61747);
                return f_127_61664_61747(additionalTextFiles, analyzerConfigOptionsProvider); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 61661, 61747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 61661, 61747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 61661, 61747);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
            f_127_61664_61747(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
            additionalFiles, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
            optionsProvider)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions(additionalFiles, optionsProvider);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61664, 61747);
                return return_v;
            }

        }

        private bool WriteTouchedFiles(DiagnosticBag diagnostics, TouchedFileLogger? touchedFilesLogger, string? finalXmlFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 61760, 63576);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61907, 63537) || true) && (f_127_61911_61937(f_127_61911_61920()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61907, 63537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61979, 62020);

                    f_127_61979_62019(touchedFilesLogger != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62040, 62177) || true) && (finalXmlFilePath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 62040, 62177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62110, 62158);

                        f_127_62110_62157(touchedFilesLogger, finalXmlFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 62040, 62177);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62197, 62257);

                    string
                    readFilesPath = f_127_62220_62246(f_127_62220_62229()) + ".read"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62275, 62339);

                    string
                    writtenFilesPath = f_127_62301_62327(f_127_62301_62310()) + ".write"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62359, 62442);

                    var
                    readStream = f_127_62376_62441(this, readFilesPath, diagnostics, mode: FileMode.OpenOrCreate)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62460, 62549);

                    var
                    writtenStream = f_127_62480_62548(this, writtenFilesPath, diagnostics, mode: FileMode.OpenOrCreate)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62569, 62690) || true) && (readStream == null || (DynAbs.Tracing.TraceSender.Expression_False(127, 62573, 62616) || writtenStream == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 62569, 62690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62658, 62671);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 62569, 62690);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62710, 62734);

                    string?
                    filePath = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62796, 62821);

                        filePath = readFilesPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62843, 63006);
                        using (var
                        writer = f_127_62863_62891(readStream)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62941, 62983);

                            f_127_62941_62982(touchedFilesLogger, writer);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(127, 62843, 63006);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63030, 63058);

                        filePath = writtenFilesPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63080, 63249);
                        using (var
                        writer = f_127_63100_63131(writtenStream)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63181, 63226);

                            f_127_63181_63225(touchedFilesLogger, writer);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(127, 63080, 63249);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 63286, 63522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63346, 63377);

                        f_127_63346_63376(filePath != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63399, 63468);

                        f_127_63399_63467(f_127_63399_63414(), e, filePath, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63490, 63503);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(127, 63286, 63522);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61907, 63537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63553, 63565);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 61760, 63576);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_61911_61920()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 61911, 61920);
                    return return_v;
                }


                string?
                f_127_61911_61937(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 61911, 61937);
                    return return_v;
                }


                int
                f_127_61979_62019(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61979, 62019);
                    return 0;
                }


                int
                f_127_62110_62157(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62110, 62157);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_62220_62229()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62220, 62229);
                    return return_v;
                }


                string
                f_127_62220_62246(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62220, 62246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_62301_62310()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62301, 62310);
                    return return_v;
                }


                string
                f_127_62301_62327(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62301, 62327);
                    return return_v;
                }


                System.IO.Stream?
                f_127_62376_62441(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode: mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62376, 62441);
                    return return_v;
                }


                System.IO.Stream?
                f_127_62480_62548(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode: mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62480, 62548);
                    return return_v;
                }


                System.IO.StreamWriter
                f_127_62863_62891(System.IO.Stream
                stream)
                {
                    var return_v = new System.IO.StreamWriter(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62863, 62891);
                    return return_v;
                }


                int
                f_127_62941_62982(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, System.IO.StreamWriter
                s)
                {
                    this_param.WriteReadPaths((System.IO.TextWriter)s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62941, 62982);
                    return 0;
                }


                System.IO.StreamWriter
                f_127_63100_63131(System.IO.Stream
                stream)
                {
                    var return_v = new System.IO.StreamWriter(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63100, 63131);
                    return return_v;
                }


                int
                f_127_63181_63225(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, System.IO.StreamWriter
                s)
                {
                    this_param.WriteWrittenPaths((System.IO.TextWriter)s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63181, 63225);
                    return 0;
                }


                int
                f_127_63346_63376(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63346, 63376);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_63399_63414()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63399, 63414);
                    return return_v;
                }


                int
                f_127_63399_63467(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63399, 63467);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 61760, 63576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 61760, 63576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual ImmutableArray<AdditionalTextFile> ResolveAdditionalFilesFromArguments(List<DiagnosticInfo> diagnostics, CommonMessageProvider messageProvider, TouchedFileLogger? touchedFilesLogger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 63588, 64098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63813, 63878);

                var
                builder = f_127_63827_63877()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63894, 64037);
                    foreach (var file in f_127_63915_63940_I(f_127_63915_63940(f_127_63915_63924())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 63894, 64037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63974, 64022);

                        f_127_63974_64021(builder, f_127_63986_64020(file, this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 63894, 64037);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64053, 64087);

                return f_127_64060_64086(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 63588, 64098);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                f_127_63827_63877()
                {
                    var return_v = ImmutableArray.CreateBuilder<AdditionalTextFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63827, 63877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_63915_63924()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63915, 63924);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_63915_63940(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63915, 63940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AdditionalTextFile
                f_127_63986_64020(Microsoft.CodeAnalysis.CommandLineSourceFile
                sourceFile, Microsoft.CodeAnalysis.CommonCompiler
                compiler)
                {
                    var return_v = new Microsoft.CodeAnalysis.AdditionalTextFile(sourceFile, compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63986, 64020);
                    return return_v;
                }


                int
                f_127_63974_64021(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                this_param, Microsoft.CodeAnalysis.AdditionalTextFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63974, 64021);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_63915_63940_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63915, 63940);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_64060_64086(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64060, 64086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 63588, 64098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 63588, 64098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportAnalyzerExecutionTime(TextWriter consoleOutput, AnalyzerDriver analyzerDriver, CultureInfo culture, bool isConcurrentBuild)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 64110, 67579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64284, 64344);

                f_127_64284_64343(f_127_64297_64334(analyzerDriver) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64358, 64463) || true) && (f_127_64362_64407(f_127_64362_64399(analyzerDriver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 64358, 64463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64441, 64448);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 64358, 64463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64479, 64585);

                var
                totalAnalyzerExecutionTime = f_127_64512_64584(f_127_64512_64549(analyzerDriver), kvp => kvp.Value.TotalSeconds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64599, 64675);

                Func<double, string>
                getFormattedTime = d => d.ToString("##0.000", culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64689, 64715);

                f_127_64689_64714(consoleOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64729, 64864);

                f_127_64729_64863(consoleOutput, f_127_64753_64862(f_127_64767_64815(), f_127_64817_64861(getFormattedTime, totalAnalyzerExecutionTime)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64880, 65032) || true) && (isConcurrentBuild)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 64880, 65032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64935, 65017);

                    f_127_64935_65016(consoleOutput, f_127_64959_65015());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 64880, 65032);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65048, 65267);

                var
                analyzersByAssembly = f_127_65074_65266(f_127_65074_65186(f_127_65074_65111(analyzerDriver), kvp => kvp.Key.GetType().GetTypeInfo().Assembly), kvp => kvp.Sum(entry => entry.Value.Ticks))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65283, 65309);

                f_127_65283_65308(
                            consoleOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65325, 65486);

                getFormattedTime = d => d < 0.001 ?
                                string.Format(culture, "{0,8:<0.000}", 0.001) :
                                string.Format(culture, "{0,8:##0.000}", d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65500, 65600);

                Func<int, string>
                getFormattedPercentage = i => string.Format("{0,5}", i < 1 ? "<1" : i.ToString())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65614, 65678);

                Func<string?, string>
                getFormattedAnalyzerName = s => "   " + s
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65723, 65828);

                var
                analyzerTimeColumn = f_127_65748_65827("{0,8}", f_127_65771_65826())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65842, 65901);

                var
                analyzerPercentageColumn = f_127_65873_65900("{0,5}", "%")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65915, 66013);

                var
                analyzerNameColumn = f_127_65940_66012(getFormattedAnalyzerName, f_127_65965_66011())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66027, 66119);

                f_127_66027_66118(consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66183, 67568);
                    foreach (var analyzerGroup in f_127_66213_66232_I(analyzersByAssembly))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 66183, 67568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66266, 66335);

                        var
                        executionTime = f_127_66286_66334(analyzerGroup, kvp => kvp.Value.TotalSeconds)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66353, 66426);

                        var
                        percentage = (int)(executionTime * 100 / totalAnalyzerExecutionTime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66446, 66499);

                        analyzerTimeColumn = f_127_66467_66498(getFormattedTime, executionTime);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66517, 66579);

                        analyzerPercentageColumn = f_127_66544_66578(getFormattedPercentage, percentage);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66597, 66671);

                        analyzerNameColumn = f_127_66618_66670(getFormattedAnalyzerName, f_127_66643_66669(f_127_66643_66660(analyzerGroup)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66691, 66783);

                        f_127_66691_66782(
                                        consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66874, 67507);
                            foreach (var kvp in f_127_66894_66943_I(f_127_66894_66943(analyzerGroup, kvp => kvp.Value)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 66874, 67507);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66985, 67024);

                                executionTime = kvp.Value.TotalSeconds;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67046, 67115);

                                percentage = (int)(executionTime * 100 / totalAnalyzerExecutionTime);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67139, 67192);

                                analyzerTimeColumn = f_127_67160_67191(getFormattedTime, executionTime);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67214, 67276);

                                analyzerPercentageColumn = f_127_67241_67275(getFormattedPercentage, percentage);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67298, 67372);

                                analyzerNameColumn = f_127_67319_67371(getFormattedAnalyzerName, "   " + f_127_67352_67370(kvp.Key));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67396, 67488);

                                f_127_67396_67487(
                                                    consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 66874, 67507);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 634);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 634);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67527, 67553);

                        f_127_67527_67552(
                                        consoleOutput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 66183, 67568);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 1386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 1386);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 64110, 67579);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64297_64334(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64297, 64334);
                    return return_v;
                }


                int
                f_127_64284_64343(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64284, 64343);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64362_64399(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64362, 64399);
                    return return_v;
                }


                bool
                f_127_64362_64407(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64362, 64407);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64512_64549(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64512, 64549);
                    return return_v;
                }


                double
                f_127_64512_64584(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, double>
                selector)
                {
                    var return_v = source.Sum<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64512, 64584);
                    return return_v;
                }


                int
                f_127_64689_64714(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64689, 64714);
                    return 0;
                }


                string
                f_127_64767_64815()
                {
                    var return_v = CodeAnalysisResources.AnalyzerTotalExecutionTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64767, 64815);
                    return return_v;
                }


                string
                f_127_64817_64861(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64817, 64861);
                    return return_v;
                }


                string
                f_127_64753_64862(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64753, 64862);
                    return return_v;
                }


                int
                f_127_64729_64863(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64729, 64863);
                    return 0;
                }


                string
                f_127_64959_65015()
                {
                    var return_v = CodeAnalysisResources.MultithreadedAnalyzerExecutionNote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64959, 65015);
                    return return_v;
                }


                int
                f_127_64935_65016(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64935, 65016);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_65074_65111(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65074, 65111);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_65074_65186(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.Reflection.Assembly>
                keySelector)
                {
                    var return_v = source.GroupBy<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.Reflection.Assembly>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65074, 65186);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_65074_65266(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                source, System.Func<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>, long>
                keySelector)
                {
                    var return_v = source.OrderByDescending<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>, long>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65074, 65266);
                    return return_v;
                }


                int
                f_127_65283_65308(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65283, 65308);
                    return 0;
                }


                string
                f_127_65771_65826()
                {
                    var return_v = CodeAnalysisResources.AnalyzerExecutionTimeColumnHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65771, 65826);
                    return return_v;
                }


                string
                f_127_65748_65827(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65748, 65827);
                    return return_v;
                }


                string
                f_127_65873_65900(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65873, 65900);
                    return return_v;
                }


                string
                f_127_65965_66011()
                {
                    var return_v = CodeAnalysisResources.AnalyzerNameColumnHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65965, 66011);
                    return return_v;
                }


                string
                f_127_65940_66012(System.Func<string?, string>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65940, 66012);
                    return return_v;
                }


                int
                f_127_66027_66118(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66027, 66118);
                    return 0;
                }


                double
                f_127_66286_66334(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, double>
                selector)
                {
                    var return_v = source.Sum<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66286, 66334);
                    return return_v;
                }


                string
                f_127_66467_66498(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66467, 66498);
                    return return_v;
                }


                string
                f_127_66544_66578(System.Func<int, string>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66544, 66578);
                    return return_v;
                }


                System.Reflection.Assembly
                f_127_66643_66660(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 66643, 66660);
                    return return_v;
                }


                string?
                f_127_66643_66669(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 66643, 66669);
                    return return_v;
                }


                string
                f_127_66618_66670(System.Func<string?, string>
                this_param, string?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66618, 66670);
                    return return_v;
                }


                int
                f_127_66691_66782(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66691, 66782);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                f_127_66894_66943(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.TimeSpan>
                keySelector)
                {
                    var return_v = source.OrderByDescending<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.TimeSpan>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66894, 66943);
                    return return_v;
                }


                string
                f_127_67160_67191(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67160, 67191);
                    return return_v;
                }


                string
                f_127_67241_67275(System.Func<int, string>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67241, 67275);
                    return return_v;
                }


                string
                f_127_67352_67370(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67352, 67370);
                    return return_v;
                }


                string
                f_127_67319_67371(System.Func<string?, string>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67319, 67371);
                    return return_v;
                }


                int
                f_127_67396_67487(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67396, 67487);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                f_127_66894_66943_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66894, 66943);
                    return return_v;
                }


                int
                f_127_67527_67552(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67527, 67552);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_66213_66232_I(System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66213, 66232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 64110, 67579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 64110, 67579);
            }
        }

        protected abstract string GetOutputFileName(Compilation compilation, CancellationToken cancellationToken);

        internal Func<string, FileMode, FileAccess, FileShare, Stream> FileOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 68021, 68124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68027, 68122);

                    return _fileOpen ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Func<string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.Stream>?>(127, 68034, 68121) ?? ((path, mode, access, share) => new FileStream(path, mode, access, share)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 68021, 68124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 67925, 68175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 67925, 68175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 68138, 68164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68144, 68162);

                    _fileOpen = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 68138, 68164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 67925, 68175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 67925, 68175);
                }
            }
        }

        private Func<string, FileMode, FileAccess, FileShare, Stream>? _fileOpen;

        private Stream? OpenFile(
                    string filePath,
                    DiagnosticBag diagnostics,
                    FileMode mode = FileMode.Open,
                    FileAccess access = FileAccess.ReadWrite,
                    FileShare share = FileShare.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 68272, 68827);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68574, 68621);

                    // LAFHIS
                    //return f_127_68581_68620(FileOpen, filePath, mode, access, share);
                    var temp = FileOpen(filePath, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 68581, 68620);
                    return temp;
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 68650, 68816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68702, 68771);

                    f_127_68702_68770(f_127_68702_68717(), e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68789, 68801);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 68650, 68816);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 68272, 68827);

                System.Func<string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.Stream>
                f_127_68581_68589()
                {
                    var return_v = FileOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 68581, 68589);
                    return return_v;
                }

                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_68702_68717()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 68702, 68717);
                    return return_v;
                }


                int
                f_127_68702_68770(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 68702, 68770);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 68272, 68827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 68272, 68827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Stream? GetWin32ResourcesInternal(
                    CommonMessageProvider messageProvider,
                    CommandLineArguments arguments,
                    Compilation compilation,
                    out IEnumerable<DiagnosticInfo> errors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 68872, 69493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69135, 69181);

                var
                diagnostics = f_127_69153_69180()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69195, 69280);

                var
                stream = f_127_69208_69279(messageProvider, arguments, compilation, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69294, 69454);

                errors = f_127_69303_69334(diagnostics).SelectAsArray(diag => new DiagnosticInfo(messageProvider, diag.IsWarningAsError, diag.Code, (object[])diag.Arguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69468, 69482);

                return stream;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 68872, 69493);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_69153_69180()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69153, 69180);
                    return return_v;
                }


                System.IO.Stream?
                f_127_69208_69279(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetWin32Resources(messageProvider, arguments, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69208, 69279);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_69303_69334(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69303, 69334);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 68872, 69493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 68872, 69493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? GetWin32Resources(
                    CommonMessageProvider messageProvider,
                    CommandLineArguments arguments,
                    Compilation compilation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 69505, 70842);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69746, 69979) || true) && (f_127_69750_69777(arguments) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 69746, 69979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69819, 69964);

                    return f_127_69826_69963(messageProvider, f_127_69854_69881(arguments), f_127_69883_69906(arguments), f_127_69908_69949(messageProvider), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 69746, 69979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69995, 70803);
                using (Stream?
                manifestStream = f_127_70027_70118(messageProvider, f_127_70063_70093(f_127_70063_70082(compilation)), arguments, diagnostics)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70152, 70788);
                    using (Stream?
                    iconStream = f_127_70180_70305(messageProvider, f_127_70208_70227(arguments), f_127_70229_70252(arguments), f_127_70254_70291(messageProvider), diagnostics)
                    )
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70399, 70507);

                            return f_127_70406_70506(compilation, true, f_127_70452_70477(arguments), manifestStream, iconStream);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 70552, 70769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70621, 70746);

                            f_127_70621_70745(diagnostics, f_127_70637_70744(messageProvider, f_127_70670_70716(messageProvider), f_127_70718_70731(), f_127_70733_70743(ex)));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(127, 70552, 70769);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 70152, 70788);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 69995, 70803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70819, 70831);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 69505, 70842);

                string?
                f_127_69750_69777(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32ResourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69750, 69777);
                    return return_v;
                }


                string
                f_127_69854_69881(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32ResourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69854, 69881);
                    return return_v;
                }


                string?
                f_127_69883_69906(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69883, 69906);
                    return return_v;
                }


                int
                f_127_69908_69949(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69908, 69949);
                    return return_v;
                }


                System.IO.Stream?
                f_127_69826_69963(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69826, 69963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_70063_70082(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70063, 70082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_127_70063_70093(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70063, 70093);
                    return return_v;
                }


                System.IO.Stream?
                f_127_70027_70118(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.OutputKind
                outputKind, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenManifestStream(messageProvider, outputKind, arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70027, 70118);
                    return return_v;
                }


                string?
                f_127_70208_70227(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32Icon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70208, 70227);
                    return return_v;
                }


                string?
                f_127_70229_70252(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70229, 70252);
                    return return_v;
                }


                int
                f_127_70254_70291(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Icon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70254, 70291);
                    return return_v;
                }


                System.IO.Stream?
                f_127_70180_70305(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string?
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70180, 70305);
                    return return_v;
                }


                bool
                f_127_70452_70477(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.NoWin32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70452, 70477);
                    return return_v;
                }


                System.IO.Stream
                f_127_70406_70506(Microsoft.CodeAnalysis.Compilation
                this_param, bool
                versionResource, bool
                noManifest, System.IO.Stream?
                manifestContents, System.IO.Stream?
                iconInIcoFormat)
                {
                    var return_v = this_param.CreateDefaultWin32Resources(versionResource, noManifest, manifestContents, iconInIcoFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70406, 70506);
                    return return_v;
                }


                int
                f_127_70670_70716(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ErrorBuildingWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70670, 70716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_70718_70731()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70718, 70731);
                    return return_v;
                }


                string
                f_127_70733_70743(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70733, 70743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_70637_70744(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70637, 70744);
                    return return_v;
                }


                int
                f_127_70621_70745(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70621, 70745);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 69505, 70842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 69505, 70842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? OpenManifestStream(CommonMessageProvider messageProvider, OutputKind outputKind, CommandLineArguments arguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 70854, 71261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71041, 71250);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(127, 71048, 71072) || ((f_127_71048_71072(outputKind) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 71092, 71096)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 71116, 71249))) ? null
                : f_127_71116_71249(messageProvider, f_127_71144_71167(arguments), f_127_71169_71192(arguments), f_127_71194_71235(messageProvider), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 70854, 71261);

                bool
                f_127_71048_71072(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71048, 71072);
                    return return_v;
                }


                string?
                f_127_71144_71167(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71144, 71167);
                    return return_v;
                }


                string?
                f_127_71169_71192(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71169, 71192);
                    return return_v;
                }


                int
                f_127_71194_71235(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71194, 71235);
                    return return_v;
                }


                System.IO.Stream?
                f_127_71116_71249(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string?
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71116, 71249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 70854, 71261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 70854, 71261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? OpenStream(CommonMessageProvider messageProvider, string? path, string? baseDirectory, int errorCode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 71273, 72077);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71449, 71526) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 71449, 71526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71499, 71511);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 71449, 71526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71542, 71632);

                string?
                fullPath = f_127_71561_71631(messageProvider, path, baseDirectory, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71646, 71727) || true) && (fullPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 71646, 71727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71700, 71712);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 71646, 71727);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71779, 71843);

                    return f_127_71786_71842(fullPath, FileMode.Open, FileAccess.Read);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 71872, 72038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71925, 72023);

                    f_127_71925_72022(diagnostics, f_127_71941_72021(messageProvider, errorCode, f_127_71985_71998(), fullPath, f_127_72010_72020(ex)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 71872, 72038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72054, 72066);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 71273, 72077);

                string?
                f_127_71561_71631(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string?
                baseDirectory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ResolveRelativePath(messageProvider, path, baseDirectory, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71561, 71631);
                    return return_v;
                }


                System.IO.FileStream
                f_127_71786_71842(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71786, 71842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_71985_71998()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71985, 71998);
                    return return_v;
                }


                string
                f_127_72010_72020(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72010, 72020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_71941_72021(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71941, 72021);
                    return return_v;
                }


                int
                f_127_71925_72022(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71925, 72022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 71273, 72077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 71273, 72077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? ResolveRelativePath(CommonMessageProvider messageProvider, string path, string? baseDirectory, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 72089, 72577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72258, 72332);

                string?
                fullPath = f_127_72277_72331(path, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72346, 72534) || true) && (fullPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 72346, 72534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72400, 72519);

                    f_127_72400_72518(diagnostics, f_127_72416_72517(messageProvider, f_127_72449_72489(messageProvider), f_127_72491_72504(), path ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(127, 72506, 72516) ?? "")));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 72346, 72534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72550, 72566);

                return fullPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 72089, 72577);

                string?
                f_127_72277_72331(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72277, 72331);
                    return return_v;
                }


                int
                f_127_72449_72489(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72449, 72489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_72491_72504()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72491, 72504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_72416_72517(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72416, 72517);
                    return return_v;
                }


                int
                f_127_72400_72518(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72400, 72518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 72089, 72577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 72089, 72577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetCompilerDiagnosticCode(string diagnosticId, string expectedPrefix, out uint code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 72589, 72903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72722, 72731);

                code = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72745, 72892);

                return f_127_72752_72817(diagnosticId, expectedPrefix, StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(127, 72752, 72891) && f_127_72821_72891(f_127_72835_72880(diagnosticId, f_127_72858_72879(expectedPrefix)), out code));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 72589, 72903);

                bool
                f_127_72752_72817(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72752, 72817);
                    return return_v;
                }


                int
                f_127_72858_72879(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72858, 72879);
                    return return_v;
                }


                string
                f_127_72835_72880(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72835, 72880);
                    return return_v;
                }


                bool
                f_127_72821_72891(string
                s, out uint
                result)
                {
                    var return_v = uint.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72821, 72891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 72589, 72903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 72589, 72903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual CultureInfo Culture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 73205, 73321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73241, 73306);

                    return f_127_73248_73273(f_127_73248_73257()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo?>(127, 73248, 73305) ?? f_127_73277_73305());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 73205, 73321);

                    Microsoft.CodeAnalysis.CommandLineArguments
                    f_127_73248_73257()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73248, 73257);
                        return return_v;
                    }


                    System.Globalization.CultureInfo?
                    f_127_73248_73273(Microsoft.CodeAnalysis.CommandLineArguments
                    this_param)
                    {
                        var return_v = this_param.PreferredUILang;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73248, 73273);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_127_73277_73305()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73277, 73305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 73143, 73332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 73143, 73332);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static void EmitDeterminismKey(CommandLineArguments args, string[] rawArgs, string baseDirectory, CommandLineParser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 73344, 73873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73500, 73569);

                var
                key = f_127_73510_73568(args, rawArgs, baseDirectory, parser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73583, 73663);

                var
                filePath = f_127_73598_73662(f_127_73611_73631(args), f_127_73633_73652(args) + ".key")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73677, 73862);
                using (var
                stream = f_127_73697_73718(filePath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73752, 73792);

                    var
                    bytes = f_127_73764_73791(f_127_73764_73777(), key)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73810, 73847);

                    f_127_73810_73846(stream, bytes, 0, f_127_73833_73845(bytes));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 73677, 73862);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 73344, 73873);

                string
                f_127_73510_73568(Microsoft.CodeAnalysis.CommandLineArguments
                args, string[]
                rawArgs, string
                baseDirectory, Microsoft.CodeAnalysis.CommandLineParser
                parser)
                {
                    var return_v = CreateDeterminismKey(args, rawArgs, baseDirectory, parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73510, 73568);
                    return return_v;
                }


                string
                f_127_73611_73631(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73611, 73631);
                    return return_v;
                }


                string?
                f_127_73633_73652(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73633, 73652);
                    return return_v;
                }


                string
                f_127_73598_73662(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73598, 73662);
                    return return_v;
                }


                System.IO.FileStream
                f_127_73697_73718(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73697, 73718);
                    return return_v;
                }


                System.Text.Encoding
                f_127_73764_73777()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73764, 73777);
                    return return_v;
                }


                byte[]
                f_127_73764_73791(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73764, 73791);
                    return return_v;
                }


                int
                f_127_73833_73845(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73833, 73845);
                    return return_v;
                }


                int
                f_127_73810_73846(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73810, 73846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 73344, 73873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 73344, 73873);
            }
        }

        private static string CreateDeterminismKey(CommandLineArguments args, string[] rawArgs, string baseDirectory, CommandLineParser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 74403, 76147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74563, 74617);

                List<Diagnostic>
                diagnostics = f_127_74594_74616()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74631, 74679);

                List<string>
                flattenedArgs = f_127_74660_74678()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74693, 74770);

                f_127_74693_74769(parser, rawArgs, diagnostics, flattenedArgs, null, baseDirectory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74786, 74820);

                var
                builder = f_127_74800_74819()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74834, 75044);

                var
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 74845, 74887) || ((!f_127_74846_74887(f_127_74867_74886(args)) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 74907, 74978)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 74998, 75043))) ? f_127_74907_74978(f_127_74940_74977(f_127_74957_74976(args))) : $"no-output-name-{Guid.NewGuid().ToString()}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75060, 75090);

                f_127_75060_75089(
                            builder, $"{name}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75104, 75141);

                f_127_75104_75140(builder, $"Command Line:");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75155, 75276);
                    foreach (var current in f_127_75179_75192_I(flattenedArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 75155, 75276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75226, 75261);

                        f_127_75226_75260(builder, $"\t{current}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 75155, 75276);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 122);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75292, 75328);

                f_127_75292_75327(
                            builder, "Source Files:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75342, 75366);

                var
                hash = f_127_75353_75365()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75380, 76094);
                    foreach (var sourceFile in f_127_75407_75423_I(f_127_75407_75423(args)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 75380, 76094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75457, 75512);

                        var
                        sourceFileName = f_127_75478_75511(sourceFile.Path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75532, 75549);

                        string
                        hashValue
                        = default(string);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75611, 75658);

                            var
                            bytes = f_127_75623_75657(sourceFile.Path)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75680, 75720);

                            var
                            hashBytes = f_127_75696_75719(hash, bytes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75742, 75786);

                            var
                            data = f_127_75753_75785(hashBytes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75808, 75842);

                            hashValue = f_127_75820_75841(data, "-", "");
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 75879, 76005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75940, 75986);

                            hashValue = $"Could not compute {f_127_75973_75983(ex)}";
                            DynAbs.Tracing.TraceSender.TraceExitCatch(127, 75879, 76005);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 76023, 76079);

                        f_127_76023_76078(builder, $"\t{sourceFileName} - {hashValue}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 75380, 76094);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(127, 1, 715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(127, 1, 715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 76110, 76136);

                return f_127_76117_76135(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 74403, 76147);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                f_127_74594_74616()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74594, 74616);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_127_74660_74678()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74660, 74678);
                    return return_v;
                }


                int
                f_127_74693_74769(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string[]
                rawArguments, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.List<string>
                processedArgs, System.Collections.Generic.List<string>?
                scriptArgsOpt, string
                baseDirectory)
                {
                    this_param.FlattenArgs((System.Collections.Generic.IEnumerable<string>)rawArguments, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, processedArgs, scriptArgsOpt, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74693, 74769);
                    return 0;
                }


                System.Text.StringBuilder
                f_127_74800_74819()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74800, 74819);
                    return return_v;
                }


                string?
                f_127_74867_74886(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 74867, 74886);
                    return return_v;
                }


                bool
                f_127_74846_74887(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74846, 74887);
                    return return_v;
                }


                string
                f_127_74957_74976(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 74957, 74976);
                    return return_v;
                }


                string?
                f_127_74940_74977(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74940, 74977);
                    return return_v;
                }


                string?
                f_127_74907_74978(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74907, 74978);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75060_75089(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75060, 75089);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75104_75140(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75104, 75140);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75226_75260(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75226, 75260);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_127_75179_75192_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75179, 75192);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75292_75327(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75292, 75327);
                    return return_v;
                }


                System.Security.Cryptography.MD5
                f_127_75353_75365()
                {
                    var return_v = MD5.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75353, 75365);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_75407_75423(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 75407, 75423);
                    return return_v;
                }


                string?
                f_127_75478_75511(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75478, 75511);
                    return return_v;
                }


                byte[]
                f_127_75623_75657(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75623, 75657);
                    return return_v;
                }


                byte[]
                f_127_75696_75719(System.Security.Cryptography.MD5
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.ComputeHash(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75696, 75719);
                    return return_v;
                }


                string
                f_127_75753_75785(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75753, 75785);
                    return return_v;
                }


                string
                f_127_75820_75841(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75820, 75841);
                    return return_v;
                }


                string
                f_127_75973_75983(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 75973, 75983);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_76023_76078(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 76023, 76078);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_75407_75423_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75407, 75423);
                    return return_v;
                }


                string
                f_127_76117_76135(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 76117, 76135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 74403, 76147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 74403, 76147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        System.Lazy<System.Text.Encoding>
        f_127_2566_2626(System.Func<System.Text.Encoding>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Text.Encoding>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 2566, 2626);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
        f_127_3250_3275()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 3250, 3275);
            return return_v;
        }


        static bool
        f_127_4844_4882(string
        path)
        {
            var return_v = PathUtilities.IsAbsolute(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4844, 4882);
            return return_v;
        }


        static int
        f_127_4807_4883(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4807, 4883);
            return 0;
        }


        static bool
        f_127_4903_4936(Microsoft.CodeAnalysis.CommonCompiler
        this_param, string[]
        args)
        {
            var return_v = this_param.SuppressDefaultResponseFile((System.Collections.Generic.IEnumerable<string>)args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4903, 4936);
            return return_v;
        }


        static bool
        f_127_4940_4965(string?
        path)
        {
            var return_v = File.Exists(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 4940, 4965);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_127_5009_5053(string[]
        first, System.Collections.Generic.IEnumerable<string>
        second)
        {
            var return_v = first.Concat<string>(second);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5009, 5053);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommandLineArguments
        f_127_5102_5209(Microsoft.CodeAnalysis.CommandLineParser
        this_param, System.Collections.Generic.IEnumerable<string>
        args, string
        baseDirectory, string?
        sdkDirectory, string?
        additionalReferenceDirectories)
        {
            var return_v = this_param.Parse(args, baseDirectory, sdkDirectory, additionalReferenceDirectories);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5102, 5209);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_127_5247_5269(Microsoft.CodeAnalysis.CommandLineParser
        this_param)
        {
            var return_v = this_param.MessageProvider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5247, 5269);
            return return_v;
        }


        Microsoft.CodeAnalysis.CommandLineArguments
        f_127_5385_5394()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5385, 5394);
            return return_v;
        }


        static Roslyn.Utilities.IReadOnlySet<string>
        f_127_5362_5395(Microsoft.CodeAnalysis.CommandLineArguments
        arguments)
        {
            var return_v = GetEmbeddedSourcePaths(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5362, 5395);
            return return_v;
        }


        Microsoft.CodeAnalysis.CommandLineArguments
        f_127_5416_5425()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5416, 5425);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ParseOptions
        f_127_5416_5438(Microsoft.CodeAnalysis.CommandLineArguments
        this_param)
        {
            var return_v = this_param.ParseOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5416, 5438);
            return return_v;
        }


        static System.Collections.Generic.IReadOnlyDictionary<string, string>
        f_127_5416_5447(Microsoft.CodeAnalysis.ParseOptions
        this_param)
        {
            var return_v = this_param.Features;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5416, 5447);
            return return_v;
        }


        static bool
        f_127_5416_5480(System.Collections.Generic.IReadOnlyDictionary<string, string>
        this_param, string
        key)
        {
            var return_v = this_param.ContainsKey(key);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5416, 5480);
            return return_v;
        }


        Microsoft.CodeAnalysis.CommandLineArguments
        f_127_5533_5542()
        {
            var return_v = Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 5533, 5542);
            return return_v;
        }


        static int
        f_127_5514_5586(Microsoft.CodeAnalysis.CommandLineArguments
        args, string[]
        rawArgs, string
        baseDirectory, Microsoft.CodeAnalysis.CommandLineParser
        parser)
        {
            EmitDeterminismKey(args, rawArgs, baseDirectory, parser);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 5514, 5586);
            return 0;
        }

    }
}
