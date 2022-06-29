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
                this._reportedDiagnostics = f_127_3250_3275(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68176, 68185);
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
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 6910, 7288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7160, 7277);

                //return f_127_7167_7276_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(
                //    f_127_7167_7240(f_127_7167_7180(type)), 127, 7167, 7276) ? 
                //    f_127_7241_7273(.InformationalVersion, '+')[0]);
                return "";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 6910, 7288);

                System.Reflection.Assembly
                f_127_7167_7180(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7167, 7180);
                    return return_v;
                }


                System.Reflection.AssemblyInformationalVersionAttribute?
                f_127_7167_7240(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7167, 7240);
                    return return_v;
                }


                string[]
                f_127_7241_7273(string
                this_param, char
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7241, 7273);
                    return return_v;
                }


                string?
                f_127_7167_7276_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7167, 7276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 6910, 7288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 6910, 7288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? GetShortCommitHash(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 7300, 7511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7377, 7450);

                var
                hash = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_7388_7443(f_127_7388_7401(type)), 127, 7388, 7449)?.Hash
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7464, 7500);

                return f_127_7471_7499(hash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 7300, 7511);

                System.Reflection.Assembly
                f_127_7388_7401(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7388, 7401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommitHashAttribute?
                f_127_7388_7443(System.Reflection.Assembly
                element)
                {
                    var return_v = element.GetCustomAttribute<Microsoft.CodeAnalysis.CommitHashAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7388, 7443);
                    return return_v;
                }


                string?
                f_127_7471_7499(string?
                hash)
                {
                    var return_v = ExtractShortCommitHash(hash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7471, 7499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 7300, 7511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 7300, 7511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract string GetToolName();

        internal Version? GetAssemblyVersion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 7806, 7933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 7869, 7922);

                return f_127_7876_7921(f_127_7876_7913(f_127_7876_7903(f_127_7876_7894(f_127_7876_7880()))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 7806, 7933);

                System.Type
                f_127_7876_7880()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7876, 7880);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_127_7876_7894(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7876, 7894);
                    return return_v;
                }


                System.Reflection.Assembly
                f_127_7876_7903(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7876, 7903);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_127_7876_7913(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 7876, 7913);
                    return return_v;
                }


                System.Version?
                f_127_7876_7921(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 7876, 7921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 7806, 7933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 7806, 7933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetCultureName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 7945, 8033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8002, 8022);

                return f_127_8009_8021(f_127_8009_8016());
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 7945, 8033);

                System.Globalization.CultureInfo
                f_127_8009_8016()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8009, 8016);
                    return return_v;
                }


                string
                f_127_8009_8021(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8009, 8021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 7945, 8033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 7945, 8033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Func<string, MetadataReferenceProperties, PortableExecutableReference> GetMetadataProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8045, 8270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8179, 8259);

                return (path, properties) => MetadataReference.CreateFromFile(path, properties);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8045, 8270);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8045, 8270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8045, 8270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual MetadataReferenceResolver GetCommandLineMetadataReferenceResolver(TouchedFileLogger? loggerOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8282, 8635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8419, 8514);

                var
                pathResolver = f_127_8438_8513(f_127_8463_8487(f_127_8463_8472()), f_127_8489_8512(f_127_8489_8498()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 8528, 8624);

                return f_127_8535_8623(pathResolver, f_127_8590_8611(this), loggerOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8282, 8635);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_8463_8472()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8463, 8472);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_8463_8487(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReferencePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8463, 8487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_8489_8498()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8489, 8498);
                    return return_v;
                }


                string?
                f_127_8489_8512(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 8489, 8512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RelativePathResolver
                f_127_8438_8513(System.Collections.Immutable.ImmutableArray<string>
                searchPaths, string?
                baseDirectory)
                {
                    var return_v = new Microsoft.CodeAnalysis.RelativePathResolver(searchPaths, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8438, 8513);
                    return return_v;
                }


                System.Func<string, Microsoft.CodeAnalysis.MetadataReferenceProperties, Microsoft.CodeAnalysis.PortableExecutableReference>
                f_127_8590_8611(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetMetadataProvider();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8590, 8611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver
                f_127_8535_8623(Microsoft.CodeAnalysis.RelativePathResolver
                pathResolver, System.Func<string, Microsoft.CodeAnalysis.MetadataReferenceProperties, Microsoft.CodeAnalysis.PortableExecutableReference>
                provider, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver(pathResolver, provider, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 8535, 8623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8282, 8635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8282, 8635);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 8822, 9868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9070, 9159);

                var
                commandLineReferenceResolver = f_127_9105_9158(this, touchedFiles)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9175, 9240);

                List<MetadataReference>
                resolved = f_127_9210_9239()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9254, 9365);

                f_127_9254_9364(f_127_9254_9263(), commandLineReferenceResolver, diagnostics, f_127_9333_9353(this), resolved);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9381, 9825) || true) && (f_127_9385_9409(f_127_9385_9394()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 9381, 9825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9443, 9501);

                    referenceDirectiveResolver = commandLineReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 9381, 9825);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 9381, 9825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9691, 9810);

                    referenceDirectiveResolver = f_127_9720_9809(commandLineReferenceResolver, f_127_9781_9808(resolved));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 9381, 9825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 9841, 9857);

                return resolved;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 8822, 9868);

                Microsoft.CodeAnalysis.MetadataReferenceResolver
                f_127_9105_9158(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.TouchedFileLogger?
                loggerOpt)
                {
                    var return_v = this_param.GetCommandLineMetadataReferenceResolver(loggerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9105, 9158);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                f_127_9210_9239()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9210, 9239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_9254_9263()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9254, 9263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_9333_9353(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9333, 9353);
                    return return_v;
                }


                bool
                f_127_9254_9364(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, Microsoft.CodeAnalysis.MetadataReferenceResolver
                metadataResolver, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProviderOpt, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                resolved)
                {
                    var return_v = this_param.ResolveMetadataReferences(metadataResolver, diagnosticsOpt, messageProviderOpt, resolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9254, 9364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_9385_9394()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9385, 9394);
                    return return_v;
                }


                bool
                f_127_9385_9409(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.IsScriptRunner;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 9385, 9409);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_127_9781_9808(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                items)
                {
                    var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9781, 9808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver
                f_127_9720_9809(Microsoft.CodeAnalysis.MetadataReferenceResolver
                resolver, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                availableReferences)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.ExistingReferencesResolver(resolver, availableReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 9720, 9809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 8822, 9868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 8822, 9868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceText? TryReadFileContent(CommandLineSourceFile file, IList<DiagnosticInfo> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 10174, 10364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 10301, 10353);

                return f_127_10308_10352(this, file, diagnostics, out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 10174, 10364);

                Microsoft.CodeAnalysis.Text.SourceText?
                f_127_10308_10352(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                file, System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, out string?
                normalizedFilePath)
                {
                    var return_v = this_param.TryReadFileContent(file, diagnostics, out normalizedFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 10308, 10352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 10174, 10364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 10174, 10364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SourceText? TryReadFileContent(CommandLineSourceFile file, IList<DiagnosticInfo> diagnostics, out string? normalizedFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 10838, 12084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 10997, 11022);

                var
                filePath = file.Path
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11072, 11829) || true) && (file.IsInputRedirected)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 11072, 11829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11140, 11185);

                        using var
                        data = f_127_11157_11184()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11207, 11237);

                        normalizedFilePath = filePath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11259, 11421);

                        return f_127_11266_11420(data, _fallbackEncoding, f_127_11316_11334(f_127_11316_11325()), f_127_11336_11363(f_127_11336_11345()), canBeEmbedded: f_127_11380_11419(f_127_11380_11399(), file.Path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 11072, 11829);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 11072, 11829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11503, 11573);

                        using var
                        data = f_127_11520_11572(filePath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11595, 11626);

                        normalizedFilePath = f_127_11616_11625(data);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11648, 11810);

                        return f_127_11655_11809(data, _fallbackEncoding, f_127_11705_11723(f_127_11705_11714()), f_127_11725_11752(f_127_11725_11734()), canBeEmbedded: f_127_11769_11808(f_127_11769_11788(), file.Path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 11072, 11829);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 11858, 12073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 11910, 11984);

                    f_127_11910_11983(diagnostics, f_127_11926_11982(f_127_11948_11968(this), e, filePath));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12002, 12028);

                    normalizedFilePath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12046, 12058);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 11858, 12073);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 10838, 12084);

                System.IO.Stream
                f_127_11157_11184()
                {
                    var return_v = Console.OpenStandardInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11157, 11184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11316_11325()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11316, 11325);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_11316_11334(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11316, 11334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11336_11345()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11336, 11345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_11336_11363(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11336, 11363);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_11380_11399()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11380, 11399);
                    return return_v;
                }


                bool
                f_127_11380_11419(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11380, 11419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_11266_11420(System.IO.Stream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding?
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Create(stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11266, 11420);
                    return return_v;
                }


                System.IO.FileStream
                f_127_11520_11572(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11520, 11572);
                    return return_v;
                }


                string
                f_127_11616_11625(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11616, 11625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11705_11714()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11705, 11714);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_11705_11723(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11705, 11723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_11725_11734()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11725, 11734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_11725_11752(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11725, 11752);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_11769_11788()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11769, 11788);
                    return return_v;
                }


                bool
                f_127_11769_11808(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11769, 11808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_11655_11809(System.IO.FileStream
                stream, System.Lazy<System.Text.Encoding>
                getEncoding, System.Text.Encoding?
                defaultEncoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                canBeEmbedded)
                {
                    var return_v = EncodedStringText.Create((System.IO.Stream)stream, getEncoding, defaultEncoding, checksumAlgorithm, canBeEmbedded: canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11655, 11809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_11948_11968(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 11948, 11968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_11926_11982(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11926, 11982);
                    return return_v;
                }


                int
                f_127_11910_11983(System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 11910, 11983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 10838, 12084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 10838, 12084);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 12211, 14456);
                string? normalizedPath = default(string?);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> setDiagnostics = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12446, 12529);

                var
                configs = f_127_12460_12528(analyzerConfigPaths.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12545, 12601);

                var
                processedDirs = f_127_12565_12600()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12617, 14053);
                    foreach (var configPath in f_127_12644_12663_I(analyzerConfigPaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 12617, 14053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 12978, 13072);

                        string?
                        fileContent = f_127_13000_13071(this, configPath, diagnostics, out normalizedPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13090, 13253) || true) && (fileContent is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13090, 13253);
                            DynAbs.Tracing.TraceSender.TraceBreak(127, 13228, 13234);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13090, 13253);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13273, 13312);

                        f_127_13273_13311(normalizedPath is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13330, 13402);

                        var
                        directory = f_127_13346_13383(normalizedPath) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(127, 13346, 13401) ?? normalizedPath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13420, 13489);

                        var
                        editorConfig = f_127_13439_13488(fileContent, normalizedPath)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13509, 13994) || true) && (f_127_13513_13535_M(!editorConfig.IsGlobal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13509, 13994);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13577, 13924) || true) && (f_127_13581_13614(processedDirs, directory))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 13577, 13924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13664, 13869);

                                f_127_13664_13868(diagnostics, f_127_13680_13867(f_127_13728_13743(), f_127_13774_13826(f_127_13774_13789()), directory));
                                DynAbs.Tracing.TraceSender.TraceBreak(127, 13895, 13901);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13577, 13924);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 13946, 13975);

                            f_127_13946_13974(processedDirs, directory);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 13509, 13994);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14012, 14038);

                        f_127_14012_14037(configs, editorConfig);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 12617, 14053);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14069, 14090);

                f_127_14069_14089(
                            processedDirs);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14106, 14274) || true) && (f_127_14110_14136(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 14106, 14274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14170, 14185);

                    f_127_14170_14184(configs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14203, 14228);

                    analyzerConfigSet = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14246, 14259);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 14106, 14274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14290, 14368);

                analyzerConfigSet = f_127_14310_14367(configs, out setDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14382, 14419);

                f_127_14382_14418(diagnostics, setDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14433, 14445);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 12211, 14456);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                f_127_12460_12528(int
                capacity)
                {
                    var return_v = ArrayBuilder<AnalyzerConfig>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12460, 12528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_127_12565_12600()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12565, 12600);
                    return return_v;
                }


                string?
                f_127_13000_13071(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out string?
                normalizedPath)
                {
                    var return_v = this_param.TryReadFileContent(filePath, diagnostics, out normalizedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13000, 13071);
                    return return_v;
                }


                int
                f_127_13273_13311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13273, 13311);
                    return 0;
                }


                string?
                f_127_13346_13383(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13346, 13383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_127_13439_13488(string
                text, string
                pathToFile)
                {
                    var return_v = AnalyzerConfig.Parse(text, pathToFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13439, 13488);
                    return return_v;
                }


                bool
                f_127_13513_13535_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13513, 13535);
                    return return_v;
                }


                bool
                f_127_13581_13614(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13581, 13614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_13728_13743()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13728, 13743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_13774_13789()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13774, 13789);
                    return return_v;
                }


                int
                f_127_13774_13826(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MultipleAnalyzerConfigsInSameDir;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 13774, 13826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_13680_13867(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13680, 13867);
                    return return_v;
                }


                int
                f_127_13664_13868(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13664, 13868);
                    return 0;
                }


                bool
                f_127_13946_13974(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 13946, 13974);
                    return return_v;
                }


                int
                f_127_14012_14037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfig
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14012, 14037);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_12644_12663_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 12644, 12663);
                    return return_v;
                }


                int
                f_127_14069_14089(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14069, 14089);
                    return 0;
                }


                bool
                f_127_14110_14136(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14110, 14136);
                    return return_v;
                }


                int
                f_127_14170_14184(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14170, 14184);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigSet
                f_127_14310_14367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                analyzerConfigs, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = AnalyzerConfigSet.Create(analyzerConfigs, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14310, 14367);
                    return return_v;
                }


                int
                f_127_14382_14418(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 14382, 14418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 12211, 14456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 12211, 14456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Encoding? GetFallbackEncoding()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 14626, 14846);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14691, 14807) || true) && (f_127_14695_14727(_fallbackEncoding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 14691, 14807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14761, 14792);

                    return f_127_14768_14791(_fallbackEncoding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 14691, 14807);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 14823, 14835);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 14626, 14846);

                bool
                f_127_14695_14727(System.Lazy<System.Text.Encoding>
                this_param)
                {
                    var return_v = this_param.IsValueCreated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 14695, 14727);
                    return return_v;
                }


                System.Text.Encoding
                f_127_14768_14791(System.Lazy<System.Text.Encoding>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 14768, 14791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 14626, 14846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 14626, 14846);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string? TryReadFileContent(string filePath, DiagnosticBag diagnostics, out string? normalizedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 14977, 15680);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15144, 15208);

                    var
                    data = f_127_15155_15207(filePath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15226, 15253);

                    normalizedPath = f_127_15243_15252(data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15271, 15415);
                    using (var
                    reader = f_127_15291_15328(data, f_127_15314_15327())
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15370, 15396);

                        return f_127_15377_15395(reader);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 15271, 15415);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 15444, 15669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15496, 15584);

                    f_127_15496_15583(diagnostics, f_127_15512_15582(f_127_15530_15581(f_127_15552_15567(), e, filePath)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15602, 15624);

                    normalizedPath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 15642, 15654);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 15444, 15669);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 14977, 15680);

                System.IO.FileStream
                f_127_15155_15207(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15155, 15207);
                    return return_v;
                }


                string
                f_127_15243_15252(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15243, 15252);
                    return return_v;
                }


                System.Text.Encoding
                f_127_15314_15327()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15314, 15327);
                    return return_v;
                }


                System.IO.StreamReader
                f_127_15291_15328(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15291, 15328);
                    return return_v;
                }


                string
                f_127_15377_15395(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15377, 15395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_15552_15567()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 15552, 15567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_15530_15581(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15530, 15581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_15512_15582(Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = Diagnostic.Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15512, 15582);
                    return return_v;
                }


                int
                f_127_15496_15583(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 15496, 15583);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 14977, 15680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 14977, 15680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FileStream OpenFileForReadWithSmallBufferOptimization(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 15692, 16388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16147, 16377);

                return f_127_16154_16376(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, bufferSize: 1, options: FileOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 15692, 16388);

                System.IO.FileStream
                f_127_16154_16376(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share, int
                bufferSize, System.IO.FileOptions
                options)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share, bufferSize: bufferSize, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16154, 16376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 15692, 16388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 15692, 16388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EmbeddedText? TryReadEmbeddedFileContent(string filePath, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 16400, 17486);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16554, 17241);
                    using (var
                    stream = f_127_16574_16626(filePath)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16668, 16711);

                        const int
                        LargeObjectHeapLimit = 80 * 1024
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16733, 17120) || true) && (f_127_16737_16750(stream) < LargeObjectHeapLimit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 16733, 17120);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16823, 16848);

                            ArraySegment<byte>
                            bytes
                            = default(ArraySegment<byte>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16874, 17097) || true) && (f_127_16878_16936(stream, out bytes))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 16874, 17097);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 16994, 17070);

                                return f_127_17001_17069(filePath, bytes, f_127_17041_17068(f_127_17041_17050()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 16874, 17097);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 16733, 17120);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17144, 17222);

                        return f_127_17151_17221(filePath, stream, f_127_17193_17220(f_127_17193_17202()));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 16554, 17241);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 17270, 17475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17322, 17430);

                    f_127_17322_17429(diagnostics, f_127_17338_17428(f_127_17338_17353(), f_127_17371_17427(f_127_17393_17413(this), e, filePath)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17448, 17460);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 17270, 17475);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 16400, 17486);

                System.IO.FileStream
                f_127_16574_16626(string
                filePath)
                {
                    var return_v = OpenFileForReadWithSmallBufferOptimization(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16574, 16626);
                    return return_v;
                }


                long
                f_127_16737_16750(System.IO.FileStream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 16737, 16750);
                    return return_v;
                }


                bool
                f_127_16878_16936(System.IO.FileStream
                data, out System.ArraySegment<byte>
                bytes)
                {
                    var return_v = EncodedStringText.TryGetBytesFromStream((System.IO.Stream)data, out bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 16878, 16936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17041_17050()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17041, 17050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_17041_17068(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17041, 17068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_17001_17069(string
                filePath, System.ArraySegment<byte>
                bytes, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = EmbeddedText.FromBytes(filePath, bytes, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17001, 17069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17193_17202()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17193, 17202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_127_17193_17220(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17193, 17220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_17151_17221(string
                filePath, System.IO.FileStream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = EmbeddedText.FromStream(filePath, (System.IO.Stream)stream, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17151, 17221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_17338_17353()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17338, 17353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_17393_17413(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17393, 17413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_17371_17427(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, System.Exception
                e, string
                filePath)
                {
                    var return_v = ToFileReadDiagnostics(messageProvider, e, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17371, 17427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_17338_17428(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.CreateDiagnostic(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17338, 17428);
                    return return_v;
                }


                int
                f_127_17322_17429(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17322, 17429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 16400, 17486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 16400, 17486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<EmbeddedText?> AcquireEmbeddedTexts(Compilation compilation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 17498, 20014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17633, 17701);

                f_127_17633_17700(f_127_17646_17689(f_127_17646_17665(compilation)) is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17715, 17842) || true) && (f_127_17719_17728().EmbeddedFiles.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 17715, 17842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17784, 17827);

                    return ImmutableArray<EmbeddedText?>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 17715, 17842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17858, 17947);

                var
                embeddedTreeMap = f_127_17880_17946(f_127_17915_17924().EmbeddedFiles.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 17961, 18058);

                var
                embeddedFileOrderedSet = f_127_17990_18057(f_127_18013_18022().EmbeddedFiles.Select(e => e.Path))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18074, 18991);
                    foreach (var tree in f_127_18095_18118_I(f_127_18095_18118(compilation)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18074, 18991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18223, 18341) || true) && (!f_127_18228_18271(f_127_18228_18247(), f_127_18257_18270(tree)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18223, 18341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18313, 18322);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18223, 18341);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18482, 18598) || true) && (f_127_18486_18528(embeddedTreeMap, f_127_18514_18527(tree)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 18482, 18598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18570, 18579);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18482, 18598);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18690, 18731);

                        f_127_18690_18730(
                                        // map embedded file path to corresponding source tree
                                        embeddedTreeMap, f_127_18710_18723(tree), tree);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 18839, 18976);

                        f_127_18839_18975(this, tree, f_127_18894_18937(f_127_18894_18913(compilation)), embeddedFileOrderedSet, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 18074, 18991);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19007, 19107);

                var
                embeddedTextBuilder = f_127_19033_19106(f_127_19077_19105(embeddedFileOrderedSet))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19121, 19942);
                    foreach (var path in f_127_19142_19164_I(embeddedFileOrderedSet))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19121, 19942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19198, 19215);

                        SyntaxTree?
                        tree
                        = default(SyntaxTree?);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19233, 19252);

                        EmbeddedText?
                        text
                        = default(EmbeddedText?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19272, 19696) || true) && (f_127_19276_19319(embeddedTreeMap, path, out tree))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19272, 19696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19361, 19414);

                            text = f_127_19368_19413(path, f_127_19398_19412(tree));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19436, 19463);

                            f_127_19436_19462(text != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19272, 19696);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 19272, 19696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19545, 19598);

                            text = f_127_19552_19597(this, path, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19620, 19677);

                            f_127_19620_19676(text != null || (DynAbs.Tracing.TraceSender.Expression_False(127, 19633, 19675) || f_127_19649_19675(diagnostics)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19272, 19696);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19897, 19927);

                        f_127_19897_19926(
                                        // We can safely add nulls because result will be ignored if any error is produced.
                                        // This allows the MoveToImmutable to work below in all cases.
                                        embeddedTextBuilder, text);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 19121, 19942);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 19958, 20003);

                return f_127_19965_20002(embeddedTextBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 17498, 20014);

                Microsoft.CodeAnalysis.CompilationOptions
                f_127_17646_17665(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17646, 17665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver?
                f_127_17646_17689(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17646, 17689);
                    return return_v;
                }


                int
                f_127_17633_17700(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17633, 17700);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17719_17728()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17719, 17728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_17915_17924()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 17915, 17924);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                f_127_17880_17946(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17880, 17946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_18013_18022()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18013, 18022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                f_127_17990_18057(System.Collections.Generic.IEnumerable<string>
                items)
                {
                    var return_v = new Microsoft.CodeAnalysis.Collections.OrderedSet<string>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 17990, 18057);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_18095_18118(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18095, 18118);
                    return return_v;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_18228_18247()
                {
                    var return_v = EmbeddedSourcePaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18228, 18247);
                    return return_v;
                }


                string
                f_127_18257_18270(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18257, 18270);
                    return return_v;
                }


                bool
                f_127_18228_18271(Roslyn.Utilities.IReadOnlySet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18228, 18271);
                    return return_v;
                }


                string
                f_127_18514_18527(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18514, 18527);
                    return return_v;
                }


                bool
                f_127_18486_18528(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18486, 18528);
                    return return_v;
                }


                string
                f_127_18710_18723(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18710, 18723);
                    return return_v;
                }


                int
                f_127_18690_18730(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, Microsoft.CodeAnalysis.SyntaxTree
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18690, 18730);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_18894_18913(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18894, 18913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceReferenceResolver
                f_127_18894_18937(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SourceReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 18894, 18937);
                    return return_v;
                }


                int
                f_127_18839_18975(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.SourceReferenceResolver
                resolver, Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                embeddedFiles, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ResolveEmbeddedFilesFromExternalSourceDirectives(tree, resolver, embeddedFiles, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18839, 18975);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_18095_18118_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 18095, 18118);
                    return return_v;
                }


                int
                f_127_19077_19105(Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 19077, 19105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                f_127_19033_19106(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<EmbeddedText?>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19033, 19106);
                    return return_v;
                }


                bool
                f_127_19276_19319(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.SyntaxTree>
                this_param, string
                key, out Microsoft.CodeAnalysis.SyntaxTree?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19276, 19319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_19398_19412(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19398, 19412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_19368_19413(string
                filePath, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = EmbeddedText.FromSource(filePath, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19368, 19413);
                    return return_v;
                }


                int
                f_127_19436_19462(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19436, 19462);
                    return 0;
                }


                Microsoft.CodeAnalysis.EmbeddedText?
                f_127_19552_19597(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TryReadEmbeddedFileContent(filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19552, 19597);
                    return return_v;
                }


                bool
                f_127_19649_19675(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19649, 19675);
                    return return_v;
                }


                int
                f_127_19620_19676(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19620, 19676);
                    return 0;
                }


                int
                f_127_19897_19926(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                this_param, Microsoft.CodeAnalysis.EmbeddedText?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19897, 19926);
                    return 0;
                }


                Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                f_127_19142_19164_I(Microsoft.CodeAnalysis.Collections.OrderedSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19142, 19164);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                f_127_19965_20002(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>.Builder
                this_param)
                {
                    var return_v = this_param.MoveToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 19965, 20002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 17498, 20014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 17498, 20014);
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
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 20278, 21387);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 20393, 20534) || true) && (arguments.EmbeddedFiles.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 20393, 20534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 20462, 20519);

                    return f_127_20469_20518();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 20393, 20534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21152, 21227);

                var
                set = f_127_21162_21226(arguments.EmbeddedFiles.Select(f => f.Path))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21241, 21302);

                f_127_21241_21301(set, arguments.SourceFiles.Select(f => f.Path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21316, 21376);

                return f_127_21323_21375(set);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 20278, 21387);

                Roslyn.Utilities.IReadOnlySet<string>
                f_127_20469_20518()
                {
                    var return_v = SpecializedCollections.EmptyReadOnlySet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 20469, 20518);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_127_21162_21226(System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21162, 21226);
                    return return_v;
                }


                int
                f_127_21241_21301(System.Collections.Generic.HashSet<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                other)
                {
                    this_param.IntersectWith(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21241, 21301);
                    return 0;
                }


                Roslyn.Utilities.IReadOnlySet<string>
                f_127_21323_21375(System.Collections.Generic.HashSet<string>
                set)
                {
                    var return_v = SpecializedCollections.StronglyTypedReadOnlySet((System.Collections.Generic.ISet<string>)set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21323, 21375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 20278, 21387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 20278, 21387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticInfo ToFileReadDiagnostics(CommonMessageProvider messageProvider, Exception e, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 21399, 22217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21545, 21575);

                DiagnosticInfo
                diagnosticInfo
                = default(DiagnosticInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21591, 22168) || true) && (e is FileNotFoundException || (DynAbs.Tracing.TraceSender.Expression_False(127, 21595, 21656) || e is DirectoryNotFoundException))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21591, 22168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21690, 21787);

                    diagnosticInfo = f_127_21707_21786(messageProvider, f_127_21743_21775(messageProvider), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21591, 22168);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21591, 22168);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21821, 22168) || true) && (e is InvalidDataException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21821, 22168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 21884, 21979);

                        diagnosticInfo = f_127_21901_21978(messageProvider, f_127_21937_21967(messageProvider), filePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21821, 22168);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 21821, 22168);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22045, 22153);

                        diagnosticInfo = f_127_22062_22152(messageProvider, f_127_22098_22130(messageProvider), filePath, f_127_22142_22151(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21821, 22168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 21591, 22168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22184, 22206);

                return diagnosticInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 21399, 22217);

                int
                f_127_21743_21775(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_FileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 21743, 21775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_21707_21786(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21707, 21786);
                    return return_v;
                }


                int
                f_127_21937_21967(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_BinaryFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 21937, 21967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_21901_21978(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 21901, 21978);
                    return return_v;
                }


                int
                f_127_22098_22130(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_NoSourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 22098, 22130);
                    return return_v;
                }


                string
                f_127_22142_22151(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 22142, 22151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_22062_22152(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22062, 22152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 21399, 22217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 21399, 22217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ReportDiagnostics(IEnumerable<Diagnostic> diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 22317, 25746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22491, 22514);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22528, 22699);
                    foreach (var diag in f_127_22549_22560_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22528, 22699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22594, 22684);

                        f_127_22594_22683(diag, (DynAbs.Tracing.TraceSender.Conditional_F1(127, 22617, 22636) || ((compilation == null && DynAbs.Tracing.TraceSender.Conditional_F2(127, 22639, 22643)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 22646, 22682))) ? null : f_127_22646_22682(diag, compilation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22528, 22699);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22715, 22732);

                return hasErrors;

                void reportDiagnostic(Diagnostic diag, SuppressionInfo? suppressionInfo)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 22780, 25735);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 22885, 24045) || true) && (f_127_22889_22924(_reportedDiagnostics, diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22885, 24045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 23813, 23820);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22885, 24045);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 22885, 24045);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 23862, 24045) || true) && (f_127_23866_23879(diag) == DiagnosticSeverity.Hidden)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 23862, 24045);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24019, 24026);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 23862, 24045);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 22885, 24045);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24255, 24308);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(errorLoggerOpt, 127, 24255, 24307)?.LogDiagnostic(diag, suppressionInfo), 127, 24270, 24307);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24586, 25201) || true) && (f_127_24590_24622(diag) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24586, 25201);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24672, 25098);
                                foreach (var (id, justification) in f_127_24708_24753_I(f_127_24708_24753(f_127_24708_24740(diag))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24672, 25098);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24803, 24876);

                                    var
                                    suppressionDiag = f_127_24825_24875(diag, id, justification)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 24902, 25075) || true) && (f_127_24906_24947(_reportedDiagnostics, suppressionDiag))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 24902, 25075);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25005, 25048);

                                        f_127_25005_25047(this, suppressionDiag, consoleOutput);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24902, 25075);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24672, 25098);
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
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25122, 25153);

                            f_127_25122_25152(
                                                _reportedDiagnostics, diag);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25175, 25182);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 24586, 25201);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25221, 25310) || true) && (f_127_25225_25242(diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 25221, 25310);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25284, 25291);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 25221, 25310);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25494, 25617) || true) && (f_127_25498_25511(diag) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 25494, 25617);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25581, 25598);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 25494, 25617);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25637, 25669);

                        f_127_25637_25668(this, diag, consoleOutput);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 25689, 25720);

                        f_127_25689_25719(
                                        _reportedDiagnostics, diag);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(127, 22780, 25735);

                        bool
                        f_127_22889_22924(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22889, 22924);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_127_23866_23879(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 23866, 23879);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
                        f_127_24590_24622(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.ProgrammaticSuppressionInfo;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24590, 24622);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        f_127_24708_24740(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.ProgrammaticSuppressionInfo;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24708, 24740);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        f_127_24708_24753(Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo
                        this_param)
                        {
                            var return_v = this_param.Suppressions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 24708, 24753);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        f_127_24825_24875(Microsoft.CodeAnalysis.Diagnostic
                        originalDiagnostic, string
                        suppressionId, Microsoft.CodeAnalysis.LocalizableString
                        suppressionJustification)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic(originalDiagnostic, suppressionId, suppressionJustification);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24825, 24875);
                            return return_v;
                        }


                        bool
                        f_127_24906_24947(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        item)
                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.Diagnostic)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24906, 24947);
                            return return_v;
                        }


                        int
                        f_127_25005_25047(Microsoft.CodeAnalysis.CommonCompiler
                        this_param, Microsoft.CodeAnalysis.CommonCompiler.SuppressionDiagnostic
                        diagnostic, System.IO.TextWriter
                        consoleOutput)
                        {
                            this_param.PrintError((Microsoft.CodeAnalysis.Diagnostic)diagnostic, consoleOutput);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25005, 25047);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        f_127_24708_24753_I(System.Collections.Immutable.ImmutableHashSet<(string Id, Microsoft.CodeAnalysis.LocalizableString Justification)>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 24708, 24753);
                            return return_v;
                        }


                        bool
                        f_127_25122_25152(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25122, 25152);
                            return return_v;
                        }


                        bool
                        f_127_25225_25242(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.IsSuppressed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 25225, 25242);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.DiagnosticSeverity
                        f_127_25498_25511(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.Severity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 25498, 25511);
                            return return_v;
                        }


                        int
                        f_127_25637_25668(Microsoft.CodeAnalysis.CommonCompiler
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        diagnostic, System.IO.TextWriter
                        consoleOutput)
                        {
                            this_param.PrintError(diagnostic, consoleOutput);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25637, 25668);
                            return 0;
                        }


                        bool
                        f_127_25689_25719(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.Diagnostic>
                        this_param, Microsoft.CodeAnalysis.Diagnostic
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 25689, 25719);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 22780, 25735);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 22780, 25735);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 22317, 25746);

                Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo?
                f_127_22646_22682(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetSuppressionInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22646, 22682);
                    return return_v;
                }


                int
                f_127_22594_22683(Microsoft.CodeAnalysis.Diagnostic
                diag, Microsoft.CodeAnalysis.Diagnostics.SuppressionInfo?
                suppressionInfo)
                {
                    reportDiagnostic(diag, suppressionInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22594, 22683);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_22549_22560_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 22549, 22560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 22317, 25746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 22317, 25746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReportDiagnostics(DiagnosticBag diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 25998, 26088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 26001, 26088);
                return f_127_26001_26088(this, f_127_26019_26043(diagnostics), consoleOutput, errorLoggerOpt, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 25998, 26088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 25998, 26088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 25998, 26088);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            f_127_26019_26043(Microsoft.CodeAnalysis.DiagnosticBag
            this_param)
            {
                var return_v = this_param.ToReadOnly();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26019, 26043);
                return return_v;
            }


            bool
            f_127_26001_26088(Microsoft.CodeAnalysis.CommonCompiler
            this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics, System.IO.TextWriter
            consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
            errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
            compilation)
            {
                var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26001, 26088);
                return return_v;
            }

        }

        internal bool ReportDiagnostics(IEnumerable<DiagnosticInfo> diagnostics, TextWriter consoleOutput, ErrorLogger? errorLoggerOpt, Compilation? compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 26356, 26473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 26359, 26473);
                return f_127_26359_26473(this, f_127_26377_26428(diagnostics, info => Diagnostic.Create(info)), consoleOutput, errorLoggerOpt, compilation); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 26356, 26473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 26356, 26473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 26356, 26473);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            f_127_26377_26428(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>
            source, System.Func<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>
            selector)
            {
                var return_v = source.Select<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.Diagnostic>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26377, 26428);
                return return_v;
            }


            bool
            f_127_26359_26473(Microsoft.CodeAnalysis.CommonCompiler
            this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
            diagnostics, System.IO.TextWriter
            consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
            errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
            compilation)
            {
                var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 26359, 26473);
                return return_v;
            }

        }

        internal static bool HasUnsuppressableErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 26961, 27296);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27057, 27258);
                    foreach (var diag in f_127_27078_27104_I(f_127_27078_27104(diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27057, 27258);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27138, 27243) || true) && (f_127_27142_27170(diag))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27138, 27243);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27212, 27224);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27138, 27243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27057, 27258);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27272, 27285);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 26961, 27296);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27078_27104(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27078, 27104);
                    return return_v;
                }


                bool
                f_127_27142_27170(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsUnsuppressableError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27142, 27170);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27078_27104_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27078, 27104);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 26961, 27296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 26961, 27296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasUnsuppressedErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 27578, 27928);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27672, 27888);
                    foreach (Diagnostic diagnostic in f_127_27706_27732_I(f_127_27706_27732(diagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27672, 27888);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27766, 27873) || true) && (f_127_27770_27800(diagnostic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 27766, 27873);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27842, 27854);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27766, 27873);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 27672, 27888);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 27904, 27917);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 27578, 27928);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27706_27732(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.AsEnumerable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27706, 27732);
                    return return_v;
                }


                bool
                f_127_27770_27800(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsUnsuppressedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 27770, 27800);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                f_127_27706_27732_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 27706, 27732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 27578, 27928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 27578, 27928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void PrintError(Diagnostic diagnostic, TextWriter consoleOutput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 27940, 28131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28047, 28120);

                f_127_28047_28119(consoleOutput, f_127_28071_28118(f_127_28071_28090(), diagnostic, f_127_28110_28117()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 27940, 28131);

                Microsoft.CodeAnalysis.DiagnosticFormatter
                f_127_28071_28090()
                {
                    var return_v = DiagnosticFormatter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28071, 28090);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_28110_28117()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28110, 28117);
                    return return_v;
                }


                string
                f_127_28071_28118(Microsoft.CodeAnalysis.DiagnosticFormatter
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, System.Globalization.CultureInfo
                formatter)
                {
                    var return_v = this_param.Format(diagnostic, (System.IFormatProvider)formatter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28071, 28118);
                    return return_v;
                }


                int
                f_127_28047_28119(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28047, 28119);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 27940, 28131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 27940, 28131);
            }
        }

        public SarifErrorLogger? GetErrorLogger(TextWriter consoleOutput, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 28143, 29715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28270, 28324);

                f_127_28270_28323(f_127_28283_28314_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_28283_28308(f_127_28283_28292()), 127, 28283, 28314)?.Path) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28340, 28386);

                var
                diagnostics = f_127_28358_28385()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28400, 28692);

                var
                errorLog = f_127_28415_28691(this, f_127_28424_28454(f_127_28424_28449(f_127_28424_28433())), diagnostics, FileMode.Create, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28708, 28733);

                SarifErrorLogger?
                logger
                = default(SarifErrorLogger?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28747, 29551) || true) && (errorLog == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 28747, 29551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28801, 28842);

                    f_127_28801_28841(f_127_28814_28840(diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28860, 28874);

                    logger = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 28747, 29551);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 28747, 29551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28940, 28972);

                    string
                    toolName = f_127_28958_28971(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 28990, 29036);

                    string
                    compilerVersion = f_127_29015_29035(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29054, 29118);

                    Version
                    assemblyVersion = f_127_29080_29100(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version?>(127, 29080, 29117) ?? f_127_29104_29117())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29138, 29536) || true) && (f_127_29142_29180(f_127_29142_29167(f_127_29142_29151())) == SarifVersion.Sarif1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 29138, 29536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29245, 29340);

                        logger = f_127_29254_29339(errorLog, toolName, compilerVersion, assemblyVersion, f_127_29331_29338());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 29138, 29536);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 29138, 29536);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29422, 29517);

                        logger = f_127_29431_29516(errorLog, toolName, compilerVersion, assemblyVersion, f_127_29508_29515());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 29138, 29536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 28747, 29551);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29567, 29676);

                f_127_29567_29675(this, f_127_29585_29616(diagnostics), consoleOutput, errorLoggerOpt: logger, compilation: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29690, 29704);

                return logger;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 28143, 29715);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_28283_28292()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28283, 28292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions?
                f_127_28283_28308(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28283, 28308);
                    return return_v;
                }


                string?
                f_127_28283_28314_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28283, 28314);
                    return return_v;
                }


                int
                f_127_28270_28323(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28270, 28323);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_28358_28385()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28358, 28385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_28424_28433()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28424, 28433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions
                f_127_28424_28449(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28424, 28449);
                    return return_v;
                }


                string
                f_127_28424_28454(Microsoft.CodeAnalysis.ErrorLogOptions
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 28424, 28454);
                    return return_v;
                }


                System.IO.Stream?
                f_127_28415_28691(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28415, 28691);
                    return return_v;
                }


                bool
                f_127_28814_28840(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28814, 28840);
                    return return_v;
                }


                int
                f_127_28801_28841(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28801, 28841);
                    return 0;
                }


                string
                f_127_28958_28971(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetToolName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 28958, 28971);
                    return return_v;
                }


                string
                f_127_29015_29035(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetCompilerVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29015, 29035);
                    return return_v;
                }


                System.Version?
                f_127_29080_29100(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetAssemblyVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29080, 29100);
                    return return_v;
                }


                System.Version
                f_127_29104_29117()
                {
                    var return_v = new System.Version();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29104, 29117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_29142_29151()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29142, 29151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions
                f_127_29142_29167(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29142, 29167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifVersion
                f_127_29142_29180(Microsoft.CodeAnalysis.ErrorLogOptions
                this_param)
                {
                    var return_v = this_param.SarifVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29142, 29180);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_29331_29338()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29331, 29338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifV1ErrorLogger
                f_127_29254_29339(System.IO.Stream
                stream, string
                toolName, string
                toolFileVersion, System.Version
                toolAssemblyVersion, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = new Microsoft.CodeAnalysis.SarifV1ErrorLogger(stream, toolName, toolFileVersion, toolAssemblyVersion, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29254, 29339);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_29508_29515()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29508, 29515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifV2ErrorLogger
                f_127_29431_29516(System.IO.Stream
                stream, string
                toolName, string
                toolFileVersion, System.Version
                toolAssemblyVersion, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = new Microsoft.CodeAnalysis.SarifV2ErrorLogger(stream, toolName, toolFileVersion, toolAssemblyVersion, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29431, 29516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_29585_29616(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29585, 29616);
                    return return_v;
                }


                bool
                f_127_29567_29675(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt: (Microsoft.CodeAnalysis.ErrorLogger?)errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 29567, 29675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 28143, 29715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 28143, 29715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int Run(TextWriter consoleOutput, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 29820, 31458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 29940, 29989);

                var
                saveUICulture = f_127_29960_29988()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30003, 30040);

                SarifErrorLogger?
                errorLogger = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30272, 30299);

                    var
                    culture = f_127_30286_30298(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30317, 30436) || true) && (culture != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30317, 30436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30378, 30417);

                        CultureInfo.CurrentUICulture = culture;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30317, 30436);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30456, 30755) || true) && (f_127_30460_30491_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_127_30460_30485(f_127_30460_30469()), 127, 30460, 30491)?.Path) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30456, 30755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30541, 30604);

                        errorLogger = f_127_30555_30603(this, consoleOutput, cancellationToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30626, 30736) || true) && (errorLogger == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 30626, 30736);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30699, 30713);

                            return Failed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30626, 30736);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 30456, 30755);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30775, 30837);

                    return f_127_30782_30836(this, consoleOutput, errorLogger, cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 30866, 31292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 30933, 30986);

                    var
                    errorCode = f_127_30949_30985(f_127_30949_30964())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31004, 31243) || true) && (errorCode > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 31004, 31243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31063, 31121);

                        var
                        diag = f_127_31074_31120(f_127_31093_31108(), errorCode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31143, 31224);

                        f_127_31143_31223(this, new[] { diag }, consoleOutput, errorLogger, compilation: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 31004, 31243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31263, 31277);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 30866, 31292);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 31306, 31447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31346, 31391);

                    CultureInfo.CurrentUICulture = saveUICulture;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 31409, 31432);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(errorLogger, 127, 31409, 31431)?.Dispose(), 127, 31421, 31431);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(127, 31306, 31447);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 29820, 31458);

                System.Globalization.CultureInfo
                f_127_29960_29988()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 29960, 29988);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_127_30286_30298(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30286, 30298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_30460_30469()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30460, 30469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions?
                f_127_30460_30485(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30460, 30485);
                    return return_v;
                }


                string?
                f_127_30460_30491_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30460, 30491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SarifErrorLogger?
                f_127_30555_30603(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetErrorLogger(consoleOutput, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 30555, 30603);
                    return return_v;
                }


                int
                f_127_30782_30836(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLogger, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.RunCore(consoleOutput, (Microsoft.CodeAnalysis.ErrorLogger?)errorLogger, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 30782, 30836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_30949_30964()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30949, 30964);
                    return return_v;
                }


                int
                f_127_30949_30985(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CompileCancelled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 30949, 30985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_31093_31108()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 31093, 31108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_127_31074_31120(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticInfo(messageProvider, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 31074, 31120);
                    return return_v;
                }


                bool
                f_127_31143_31223(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo[]
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.SarifErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, (Microsoft.CodeAnalysis.ErrorLogger?)errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 31143, 31223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 29820, 31458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 29820, 31458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private protected virtual Compilation RunGenerators(Compilation input, ParseOptions parseOptions, ImmutableArray<ISourceGenerator> generators, AnalyzerConfigOptionsProvider analyzerConfigOptionsProvider, ImmutableArray<AdditionalText> additionalTexts, DiagnosticBag generatorDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 32357, 32662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32647, 32660);

                return input;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 32357, 32662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 32357, 32662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 32357, 32662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int RunCore(TextWriter consoleOutput, ErrorLogger? errorLogger, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 32674, 38044);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer> analyzers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator> generators = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>);
                System.Threading.CancellationTokenSource? analyzerCts = default(System.Threading.CancellationTokenSource?);
                bool reportAnalyzer = default(bool);
                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver? analyzerDriver = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32807, 32847);

                f_127_32807_32846(f_127_32820_32845_M(!f_127_32821_32830().IsScriptRunner));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32863, 32912);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32928, 33068) || true) && (f_127_32932_32956(f_127_32932_32941()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 32928, 33068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 32990, 33018);

                    f_127_32990_33017(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33036, 33053);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 32928, 33068);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33084, 33234) || true) && (f_127_33088_33117(f_127_33088_33097()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33084, 33234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33151, 33184);

                    f_127_33151_33183(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33202, 33219);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33084, 33234);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33250, 33349) || true) && (f_127_33254_33275(f_127_33254_33263()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33250, 33349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33309, 33334);

                    f_127_33309_33333(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33250, 33349);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33365, 33499) || true) && (f_127_33369_33390(f_127_33369_33378()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33365, 33499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33424, 33449);

                    f_127_33424_33448(this, consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33467, 33484);

                    return Succeeded;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33365, 33499);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33515, 33664) || true) && (f_127_33519_33601(this, f_127_33537_33553(f_127_33537_33546()), consoleOutput, errorLogger, compilation: null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 33515, 33664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33635, 33649);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 33515, 33664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33680, 33775);

                var
                touchedFilesLogger = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 33705, 33741) || (((f_127_33706_33732(f_127_33706_33715()) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 33744, 33767)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 33770, 33774))) ? f_127_33744_33767() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33791, 33837);

                var
                diagnostics = f_127_33809_33836()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33853, 33897);

                AnalyzerConfigSet?
                analyzerConfigSet = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 33911, 33997);

                ImmutableArray<AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions = default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34011, 34069);

                AnalyzerConfigOptionsResult
                globalConfigOptions = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34085, 34958) || true) && (f_127_34089_34098().AnalyzerConfigPaths.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34085, 34958);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34163, 34495) || true) && (!f_127_34168_34258(this, f_127_34192_34221(f_127_34192_34201()), diagnostics, out analyzerConfigSet))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34163, 34495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34300, 34394);

                        var
                        hadErrors = f_127_34316_34393(this, diagnostics, consoleOutput, errorLogger, compilation: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34416, 34440);

                        f_127_34416_34439(hadErrors);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34462, 34476);

                        return Failed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34163, 34495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34515, 34575);

                    globalConfigOptions = f_127_34537_34574(analyzerConfigSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34593, 34719);

                    sourceFileAnalyzerConfigOptions = f_127_34627_34636().SourceFiles.SelectAsArray(f => analyzerConfigSet.GetOptionsForSourcePath(f.Path));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34739, 34943);
                        foreach (var sourceFileAnalyzerConfigOption in f_127_34786_34817_I(sourceFileAnalyzerConfigOptions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 34739, 34943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34859, 34924);

                            f_127_34859_34923(diagnostics, sourceFileAnalyzerConfigOption.Diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34739, 34943);
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
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 34085, 34958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 34974, 35121);

                Compilation?
                compilation = f_127_35001_35120(this, consoleOutput, touchedFilesLogger, errorLogger, sourceFileAnalyzerConfigOptions, globalConfigOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35135, 35221) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35135, 35221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35192, 35206);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35135, 35221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35237, 35286);

                var
                diagnosticInfos = f_127_35259_35285()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35300, 35428);

                f_127_35300_35427(this, diagnosticInfos, f_127_35347_35362(), f_127_35364_35387(f_127_35364_35373()), out analyzers, out generators);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35442, 35558);

                var
                additionalTextFiles = f_127_35468_35557(this, diagnosticInfos, f_127_35521_35536(), touchedFilesLogger)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35572, 35714) || true) && (f_127_35576_35651(this, diagnosticInfos, consoleOutput, errorLogger, compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35572, 35714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35685, 35699);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35572, 35714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35730, 35823);

                ImmutableArray<EmbeddedText?>
                embeddedTexts = f_127_35776_35822(this, compilation, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35837, 35975) || true) && (f_127_35841_35912(this, diagnostics, consoleOutput, errorLogger, compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 35837, 35975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35946, 35960);

                    return Failed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 35837, 35975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 35991, 36072);

                var
                additionalTexts = ImmutableArray<AdditionalText>.CastUp(additionalTextFiles)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 36088, 36592);

                f_127_36088_36591(this, touchedFilesLogger, ref compilation, analyzers, generators, additionalTexts, analyzerConfigSet, sourceFileAnalyzerConfigOptions, embeddedTexts, diagnostics, cancellationToken, out analyzerCts, out reportAnalyzer, out analyzerDriver);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37026, 37119) || true) && (analyzerCts != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37026, 37119);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37083, 37104);

                    f_127_37083_37103(analyzerCts);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37026, 37119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37135, 37277);

                var
                exitCode = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 37150, 37221) || ((f_127_37150_37221(this, diagnostics, consoleOutput, errorLogger, compilation) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 37241, 37247)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 37267, 37276))) ? Failed
                : Succeeded
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37455, 37723);
                    foreach (var additionalFile in f_127_37486_37505_I(additionalTextFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37455, 37723);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37539, 37708) || true) && (f_127_37543_37629(this, f_127_37561_37587(additionalFile), consoleOutput, errorLogger, compilation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37539, 37708);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37671, 37689);

                            exitCode = Failed;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37539, 37708);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37455, 37723);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37739, 37758);

                f_127_37739_37757(
                            diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37772, 38001) || true) && (reportAnalyzer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 37772, 38001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37824, 37863);

                    f_127_37824_37862(analyzerDriver is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 37881, 37986);

                    f_127_37881_37985(consoleOutput, analyzerDriver, f_127_37940_37947(), f_127_37949_37984(f_127_37949_37968(compilation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 37772, 38001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38017, 38033);

                return exitCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 32674, 38044);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_32821_32830()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32821, 32830);
                    return return_v;
                }


                bool
                f_127_32820_32845_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32820, 32845);
                    return return_v;
                }


                int
                f_127_32807_32846(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 32807, 32846);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_32932_32941()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32932, 32941);
                    return return_v;
                }


                bool
                f_127_32932_32956(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 32932, 32956);
                    return return_v;
                }


                int
                f_127_32990_33017(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintVersion(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 32990, 33017);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33088_33097()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33088, 33097);
                    return return_v;
                }


                bool
                f_127_33088_33117(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayLangVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33088, 33117);
                    return return_v;
                }


                int
                f_127_33151_33183(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintLangVersions(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33151, 33183);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33254_33263()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33254, 33263);
                    return return_v;
                }


                bool
                f_127_33254_33275(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayLogo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33254, 33275);
                    return return_v;
                }


                int
                f_127_33309_33333(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintLogo(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33309, 33333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33369_33378()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33369, 33378);
                    return return_v;
                }


                bool
                f_127_33369_33390(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DisplayHelp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33369, 33390);
                    return return_v;
                }


                int
                f_127_33424_33448(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput)
                {
                    this_param.PrintHelp(consoleOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33424, 33448);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33537_33546()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33537, 33546);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_33537_33553(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33537, 33553);
                    return return_v;
                }


                bool
                f_127_33519_33601(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33519, 33601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_33706_33715()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33706, 33715);
                    return return_v;
                }


                string?
                f_127_33706_33732(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 33706, 33732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TouchedFileLogger
                f_127_33744_33767()
                {
                    var return_v = new Microsoft.CodeAnalysis.TouchedFileLogger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33744, 33767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_33809_33836()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 33809, 33836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34089_34098()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34089, 34098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34192_34201()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34192, 34201);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_127_34192_34221(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.AnalyzerConfigPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34192, 34221);
                    return return_v;
                }


                bool
                f_127_34168_34258(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<string>
                analyzerConfigPaths, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.AnalyzerConfigSet?
                analyzerConfigSet)
                {
                    var return_v = this_param.TryGetAnalyzerConfigSet(analyzerConfigPaths, diagnostics, out analyzerConfigSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34168, 34258);
                    return return_v;
                }


                bool
                f_127_34316_34393(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation?
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation: compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34316, 34393);
                    return return_v;
                }


                int
                f_127_34416_34439(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34416, 34439);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_34537_34574(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param)
                {
                    var return_v = this_param.GlobalConfigOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34537, 34574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_34627_34636()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 34627, 34636);
                    return return_v;
                }


                int
                f_127_34859_34923(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34859, 34923);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_34786_34817_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 34786, 34817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_127_35001_35120(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                analyzerConfigOptions, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                globalConfigOptions)
                {
                    var return_v = this_param.CreateCompilation(consoleOutput, touchedFilesLogger, errorLoggerOpt, analyzerConfigOptions, globalConfigOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35001, 35120);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_127_35259_35285()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35259, 35285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_35347_35362()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35347, 35362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_35364_35373()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35364, 35373);
                    return return_v;
                }


                bool
                f_127_35364_35387(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SkipAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35364, 35387);
                    return return_v;
                }


                int
                f_127_35300_35427(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, bool
                skipAnalyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators)
                {
                    this_param.ResolveAnalyzersFromArguments(diagnostics, messageProvider, skipAnalyzers, out analyzers, out generators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35300, 35427);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_35521_35536()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 35521, 35536);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_35468_35557(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger)
                {
                    var return_v = this_param.ResolveAdditionalFilesFromArguments(diagnostics, messageProvider, touchedFilesLogger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35468, 35557);
                    return return_v;
                }


                bool
                f_127_35576_35651(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35576, 35651);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedText?>
                f_127_35776_35822(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.AcquireEmbeddedTexts(compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35776, 35822);
                    return return_v;
                }


                bool
                f_127_35841_35912(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 35841, 35912);
                    return return_v;
                }


                int
                f_127_36088_36591(Microsoft.CodeAnalysis.CommonCompiler
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 36088, 36591);
                    return 0;
                }


                int
                f_127_37083_37103(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37083, 37103);
                    return 0;
                }


                bool
                f_127_37150_37221(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics(diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37150, 37221);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_127_37561_37587(Microsoft.CodeAnalysis.AdditionalTextFile
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 37561, 37587);
                    return return_v;
                }


                bool
                f_127_37543_37629(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics, System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.ErrorLogger?
                errorLoggerOpt, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.ReportDiagnostics((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics, consoleOutput, errorLoggerOpt, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37543, 37629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_37486_37505_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37486, 37505);
                    return return_v;
                }


                int
                f_127_37739_37757(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37739, 37757);
                    return 0;
                }


                int
                f_127_37824_37862(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37824, 37862);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_127_37940_37947()
                {
                    var return_v = Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 37940, 37947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_37949_37968(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 37949, 37968);
                    return return_v;
                }


                bool
                f_127_37949_37984(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ConcurrentBuild;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 37949, 37984);
                    return return_v;
                }


                int
                f_127_37881_37985(System.IO.TextWriter
                consoleOutput, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                analyzerDriver, System.Globalization.CultureInfo
                culture, bool
                isConcurrentBuild)
                {
                    ReportAnalyzerExecutionTime(consoleOutput, analyzerDriver, culture, isConcurrentBuild);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 37881, 37985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 32674, 38044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 32674, 38044);
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
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 38056, 39939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38532, 38613);

                var
                builder = f_127_38546_38612()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38627, 38637);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38651, 39190);
                    foreach (var syntaxTree in f_127_38678_38689_I(syntaxTrees))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 38651, 39190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38725, 38790);

                        var
                        options = sourceFileAnalyzerConfigOptions[i].AnalyzerOptions
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38896, 39153) || true) && (f_127_38900_38913(options) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 38896, 39153);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 38959, 39044);

                            f_127_38959_39043(f_127_38972_39003(existing, syntaxTree) == f_127_39007_39042());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39066, 39134);

                            f_127_39066_39133(builder, syntaxTree, f_127_39090_39132(options));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 38896, 39153);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39171, 39175);

                        i++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 38651, 39190);
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
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39206, 39847) || true) && (f_127_39210_39236_M(!additionalFiles.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39206, 39847);
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39275, 39280)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39270, 39832) || true) && (i < additionalFiles.Length)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39310, 39313)
   , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39270, 39832))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39270, 39832);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39355, 39410);

                            var
                            options = additionalFileOptions[i].AnalyzerOptions
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39524, 39813) || true) && (f_127_39528_39541(options) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 39524, 39813);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39595, 39688);

                                f_127_39595_39687(f_127_39608_39647(existing, additionalFiles[i]) == f_127_39651_39686());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39714, 39790);

                                f_127_39714_39789(builder, additionalFiles[i], f_127_39746_39788(options));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39524, 39813);
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
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 39206, 39847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 39863, 39928);

                return f_127_39870_39927(existing, f_127_39905_39926(builder));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 38056, 39939);

                System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                f_127_38546_38612()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<object, AnalyzerConfigOptions>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38546, 38612);
                    return return_v;
                }


                int
                f_127_38900_38913(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 38900, 38913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                f_127_38972_39003(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = this_param.GetOptions(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38972, 39003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39007_39042()
                {
                    var return_v = CompilerAnalyzerConfigOptions.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39007, 39042);
                    return return_v;
                }


                int
                f_127_38959_39043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38959, 39043);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39090_39132(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39090, 39132);
                    return return_v;
                }


                int
                f_127_39066_39133(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                key, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                value)
                {
                    this_param.Add((object)key, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39066, 39133);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_38678_38689_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 38678, 38689);
                    return return_v;
                }


                bool
                f_127_39210_39236_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39210, 39236);
                    return return_v;
                }


                int
                f_127_39528_39541(System.Collections.Immutable.ImmutableDictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39528, 39541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
                f_127_39608_39647(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.AdditionalText
                textFile)
                {
                    var return_v = this_param.GetOptions(textFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39608, 39647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39651_39686()
                {
                    var return_v = CompilerAnalyzerConfigOptions.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 39651, 39686);
                    return return_v;
                }


                int
                f_127_39595_39687(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39595, 39687);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_39746_39788(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39746, 39788);
                    return return_v;
                }


                int
                f_127_39714_39789(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param, Microsoft.CodeAnalysis.AdditionalText
                key, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                value)
                {
                    this_param.Add((object)key, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39714, 39789);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
                f_127_39905_39926(System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39905, 39926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_39870_39927(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, System.Collections.Immutable.ImmutableDictionary<object, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions>
                treeDict)
                {
                    var return_v = this_param.WithAdditionalTreeOptions(treeDict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 39870, 39927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 38056, 39939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 38056, 39939);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 40174, 61322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 40934, 40953);

                analyzerCts = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 40967, 40990);

                reportAnalyzer = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41004, 41026);

                analyzerDriver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41149, 41261);

                f_127_41149_41260(
                            // Print the diagnostics produced during the parsing stage and exit if there were any errors.
                            compilation, CompilationStage.Parse, includeEarlierStages: false, diagnostics, cancellationToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41275, 41371) || true) && (f_127_41279_41315(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41275, 41371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41349, 41356);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41275, 41371);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41387, 41438);

                DiagnosticBag?
                analyzerExceptionDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41452, 48381) || true) && (f_127_41456_41474_M(!analyzers.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(127, 41456, 41497) || f_127_41478_41497_M(!generators.IsEmpty)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41452, 48381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41531, 41604);

                    var
                    analyzerConfigProvider = f_127_41560_41603()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41622, 42927) || true) && (f_127_41626_41635().AnalyzerConfigPaths.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 41622, 42927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41708, 41750);

                        f_127_41708_41749(analyzerConfigSet is object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 41772, 41946);

                        analyzerConfigProvider = f_127_41797_41945(analyzerConfigProvider, f_127_41838_41944(f_127_41872_41927(analyzerConfigSet, string.Empty).AnalyzerOptions));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42182, 42373);

                        ImmutableArray<AnalyzerConfigOptionsResult>
                        additionalFileAnalyzerOptions =
                                                additionalTextFiles.SelectAsArray(f => analyzerConfigSet.GetOptionsForSourcePath(f.Path))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42397, 42563);
                            foreach (var result in f_127_42420_42449_I(additionalFileAnalyzerOptions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 42397, 42563);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42499, 42540);

                                f_127_42499_42539(diagnostics, result.Diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 42397, 42563);
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
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42587, 42908);

                        analyzerConfigProvider = f_127_42612_42907(analyzerConfigProvider, f_127_42723_42746(compilation), sourceFileAnalyzerConfigOptions, additionalTextFiles, additionalFileAnalyzerOptions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41622, 42927);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 42947, 46845) || true) && (f_127_42951_42970_M(!generators.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 42947, 46845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43200, 43335);

                        compilation = f_127_43214_43334(this, compilation, f_127_43241_43263(f_127_43241_43250()), generators, analyzerConfigProvider, additionalTextFiles, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43359, 43424);

                        bool
                        hasAnalyzerConfigs = f_127_43385_43423_M(!f_127_43386_43395().AnalyzerConfigPaths.IsEmpty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43446, 43544);

                        bool
                        hasGeneratedOutputPath = !f_127_43477_43543(f_127_43503_43542(f_127_43503_43512()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43568, 43663);

                        var
                        generatedSyntaxTrees = f_127_43595_43662(f_127_43595_43653(f_127_43595_43618(compilation), f_127_43624_43633().SourceFiles.Length))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43687, 43826);

                        var
                        analyzerOptionsBuilder = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 43716, 43734) || ((hasAnalyzerConfigs && DynAbs.Tracing.TraceSender.Conditional_F2(127, 43737, 43818)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 43821, 43825))) ? f_127_43737_43818(f_127_43791_43817(generatedSyntaxTrees)) : null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 43848, 43941);

                        var
                        embeddedTextBuilder = f_127_43874_43940(f_127_43913_43939(generatedSyntaxTrees))
                        ;
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44015, 46141);
                                foreach (var tree in f_127_44036_44056_I(generatedSyntaxTrees))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44015, 46141);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44114, 44170);

                                    f_127_44114_44169(!f_127_44128_44168(f_127_44154_44167(tree)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44200, 44249);

                                    cancellationToken.ThrowIfCancellationRequested();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44281, 44330);

                                    var
                                    sourceText = f_127_44298_44329(tree, cancellationToken)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44461, 44537);

                                    f_127_44461_44536(
                                                                // embed the generated text and get analyzer options for it if needed
                                                                embeddedTextBuilder, f_127_44485_44535(f_127_44509_44522(tree), sourceText));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44567, 44786) || true) && (analyzerOptionsBuilder is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44567, 44786);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44669, 44755);

                                        f_127_44669_44754(analyzerOptionsBuilder, f_127_44696_44753(analyzerConfigSet!, f_127_44739_44752(tree)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44567, 44786);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44895, 46114) || true) && (hasGeneratedOutputPath)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 44895, 46114);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 44987, 45068);

                                        var
                                        path = f_127_44998_45067(f_127_45011_45020().GeneratedFilesOutputDirectory!, f_127_45053_45066(tree))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45102, 45327) || true) && (f_127_45106_45163(f_127_45123_45162(f_127_45123_45132())))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 45102, 45327);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45237, 45292);

                                            f_127_45237_45291(f_127_45263_45290(path));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 45102, 45327);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45363, 45483);

                                        var
                                        fileStream = f_127_45380_45482(this, path, diagnostics, FileMode.Create, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45517, 46083) || true) && (fileStream is object)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 45517, 46083);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45615, 45653);

                                            f_127_45615_45652(f_127_45628_45641(tree) is object);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45693, 45788);

                                            using var
                                            disposer = f_127_45714_45787(fileStream, path, diagnostics, f_127_45771_45786())
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45826, 45889);

                                            using var
                                            writer = f_127_45845_45888(fileStream, f_127_45874_45887(tree))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 45929, 45973);

                                            f_127_45929_45972(
                                                                                sourceText, writer, cancellationToken);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46011, 46048);

                                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(touchedFilesLogger, 127, 46011, 46047)?.AddWritten(path), 127, 46030, 46047);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 45517, 46083);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44895, 46114);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 44015, 46141);
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
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46169, 46229);

                            embeddedTexts = embeddedTexts.AddRange(embeddedTextBuilder);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46255, 46618) || true) && (analyzerOptionsBuilder is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 46255, 46618);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46349, 46591);

                                analyzerConfigProvider = f_127_46374_46590(analyzerConfigProvider, generatedSyntaxTrees, f_127_46553_46589(analyzerOptionsBuilder));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 46255, 46618);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 46663, 46826);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46719, 46750);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(analyzerOptionsBuilder, 127, 46719, 46749)?.Free(), 127, 46742, 46749);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46776, 46803);

                            f_127_46776_46802(embeddedTextBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(127, 46663, 46826);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 42947, 46845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 46865, 46990);

                    AnalyzerOptions
                    analyzerOptions = f_127_46899_46989(this, additionalTextFiles, analyzerConfigProvider)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47010, 48366) || true) && (f_127_47014_47032_M(!analyzers.IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 47010, 48366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47074, 47155);

                        analyzerCts = f_127_47088_47154(cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47177, 47228);

                        analyzerExceptionDiagnostics = f_127_47208_47227();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47601, 47644);

                        var
                        severityFilter = SeverityFilter.Hidden
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47666, 47765) || true) && (f_127_47670_47692(f_127_47670_47679()) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 47666, 47765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47727, 47765);

                            severityFilter |= SeverityFilter.Info;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 47666, 47765);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 47789, 48261);

                        analyzerDriver = f_127_47806_48260(compilation, analyzers, analyzerOptions, f_127_47992_48022(analyzers), analyzerExceptionDiagnostics.Add, f_127_48108_48132(f_127_48108_48117()), severityFilter, out compilation, f_127_48242_48259(analyzerCts));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48283, 48347);

                        reportAnalyzer = f_127_48300_48324(f_127_48300_48309()) && (DynAbs.Tracing.TraceSender.Expression_True(127, 48300, 48346) && f_127_48328_48346_M(!analyzers.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 47010, 48366);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 41452, 48381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48397, 48511);

                f_127_48397_48510(
                            compilation, CompilationStage.Declare, includeEarlierStages: false, diagnostics, cancellationToken);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48525, 48621) || true) && (f_127_48529_48565(diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 48525, 48621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48599, 48606);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 48525, 48621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 48637, 48686);

                cancellationToken.ThrowIfCancellationRequested();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49083, 49154);

                string
                outputName = f_127_49103_49152(this, compilation, cancellationToken)!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49168, 49230);

                var
                finalPeFilePath = f_127_49190_49229(f_127_49190_49199(), outputName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49244, 49304);

                var
                finalPdbFilePath = f_127_49267_49303(f_127_49267_49276(), outputName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49318, 49369);

                var
                finalXmlFilePath = f_127_49341_49368(f_127_49341_49350())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49385, 49443);

                NoThrowStreamDisposer?
                sourceLinkStreamDisposerOpt = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 49629, 49836);

                    var
                    emitOptions = f_127_49647_49835(f_127_49647_49725(f_127_49647_49668(f_127_49647_49656()), outputName), f_127_49764_49834(finalPdbFilePath, f_127_49816_49833(f_127_49816_49825())))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50088, 50355) || true) && (f_127_50092_50159(f_127_50092_50123(f_127_50092_50114(f_127_50092_50101())), "pdb-path-determinism") && (DynAbs.Tracing.TraceSender.Expression_True(127, 50092, 50209) && !f_127_50164_50209(f_127_50185_50208(emitOptions))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50088, 50355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50251, 50336);

                        emitOptions = f_127_50265_50335(emitOptions, f_127_50293_50334(f_127_50310_50333(emitOptions)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50088, 50355);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50375, 51086) || true) && (f_127_50379_50399(f_127_50379_50388()) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50375, 51086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50449, 50693);

                        var
                        sourceLinkStreamOpt = f_127_50475_50692(this, f_127_50510_50530(f_127_50510_50519()), diagnostics, FileMode.Open, FileAccess.Read, FileShare.Read)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50717, 51067) || true) && (sourceLinkStreamOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 50717, 51067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 50798, 51044);

                            sourceLinkStreamDisposerOpt = f_127_50828_51043(sourceLinkStreamOpt, f_127_50934_50954(f_127_50934_50943()), diagnostics, f_127_51027_51042());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50717, 51067);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 50375, 51086);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51106, 51562);

                    var
                    moduleBeingBuilt = f_127_51129_51561(compilation, diagnostics, f_127_51232_51259(f_127_51232_51241()), emitOptions, debugEntryPoint: null, sourceLinkStream: f_127_51378_51413_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 51378, 51413)?.Stream), embeddedTexts: embeddedTexts, testData: null, cancellationToken: cancellationToken)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51582, 60355) || true) && (moduleBeingBuilt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 51582, 60355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51652, 51665);

                        bool
                        success
                        = default(bool);

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 51741, 52151);

                            success = f_127_51751_52150(compilation, moduleBeingBuilt, f_127_51855_51872(f_127_51855_51864()), f_127_51903_51931(emitOptions), f_127_51962_51994(emitOptions), diagnostics, filterOpt: null, cancellationToken: cancellationToken);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 52752, 52975) || true) && (analyzerDriver != null && (DynAbs.Tracing.TraceSender.Expression_True(127, 52756, 52819) && f_127_52782_52819_M(!diagnostics.IsEmptyWithoutResolution)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 52752, 52975);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 52877, 52948);

                                f_127_52877_52947(analyzerDriver, diagnostics, compilation);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 52752, 52975);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53003, 53142) || true) && (f_127_53007_53041(diagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53003, 53142);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53099, 53115);

                                success = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53003, 53142);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53170, 56483) || true) && (success)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53170, 56483);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53435, 53486);

                                NoThrowStreamDisposer?
                                xmlStreamDisposerOpt = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53518, 54953) || true) && (finalXmlFilePath != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 53518, 54953);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 53612, 53996);

                                    var
                                    xmlStreamOpt = f_127_53631_53995(this, finalXmlFilePath, diagnostics, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite | FileShare.Delete)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54032, 54172) || true) && (xmlStreamOpt == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 54032, 54172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54130, 54137);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 54032, 54172);
                                    }

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54284, 54310);

                                        f_127_54284_54309(xmlStreamOpt, 0);
                                    }
                                    catch (Exception e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 54379, 54628);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54471, 54548);

                                        f_127_54471_54547(f_127_54471_54486(), e, finalXmlFilePath, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54586, 54593);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(127, 54379, 54628);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54662, 54922);

                                    xmlStreamDisposerOpt = f_127_54685_54921(xmlStreamOpt, finalXmlFilePath, diagnostics, f_127_54905_54920());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53518, 54953);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 54985, 55980);
                                using (xmlStreamDisposerOpt)
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55078, 55949);
                                    using (var
                                    win32ResourceStreamOpt = f_127_55114_55185(f_127_55132_55147(), f_127_55149_55158(), compilation, diagnostics)
                                    )
                                    {

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55259, 55427) || true) && (f_127_55263_55299(diagnostics))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 55259, 55427);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55381, 55388);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 55259, 55427);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 55467, 55914);

                                        success = f_127_55477_55913(compilation, moduleBeingBuilt, f_127_55632_55660_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(xmlStreamDisposerOpt, 127, 55632, 55660)?.Stream), win32ResourceStreamOpt, f_127_55768_55798(emitOptions), diagnostics, cancellationToken);
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 55078, 55949);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 54985, 55980);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56012, 56168) || true) && (f_127_56016_56056_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(xmlStreamDisposerOpt, 127, 56016, 56056)?.HasFailedToDispose) == true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56012, 56168);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56130, 56137);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56012, 56168);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56278, 56456) || true) && (success)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56278, 56456);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56355, 56425);

                                    f_127_56355_56424(compilation, null, diagnostics, cancellationToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56278, 56456);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 53170, 56483);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56511, 56543);

                            f_127_56511_56542(
                                                    compilation, null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56571, 57450) || true) && (analyzerDriver != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 56571, 57450);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 56901, 56978);

                                var
                                hostDiagnostics = f_127_56923_56977(f_127_56923_56970(analyzerDriver, compilation))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57008, 57046);

                                f_127_57008_57045(diagnostics, hostDiagnostics);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57078, 57423) || true) && (f_127_57082_57119_M(!diagnostics.IsEmptyWithoutResolution))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57078, 57423);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57321, 57392);

                                    f_127_57321_57391(                                // Apply diagnostic suppressions for analyzer and/or compiler diagnostics from diagnostic suppressors.
                                                                    analyzerDriver, diagnostics, compilation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57078, 57423);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 56571, 57450);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 57495, 57613);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57551, 57590);

                            f_127_57551_57589(moduleBeingBuilt);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(127, 57495, 57613);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57637, 57764) || true) && (f_127_57641_57675(diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57637, 57764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57725, 57741);

                            success = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57637, 57764);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57788, 60336) || true) && (success)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 57788, 60336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57849, 57926);

                            var
                            peStreamProvider = f_127_57872_57925(this, finalPeFilePath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 57952, 58065);

                            var
                            pdbStreamProviderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 57979, 58000) || ((f_127_57979_58000(f_127_57979_57988()) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 58003, 58057)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 58060, 58064))) ? f_127_58003_58057(this, finalPdbFilePath) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58093, 58150);

                            string?
                            finalRefPeFilePath = f_127_58122_58149(f_127_58122_58131())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58176, 58298);

                            var
                            refPeStreamProviderOpt = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 58205, 58231) || ((finalRefPeFilePath != null && DynAbs.Tracing.TraceSender.Conditional_F2(127, 58234, 58290)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 58293, 58297))) ? f_127_58234_58290(this, finalRefPeFilePath) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58326, 58362);

                            RSAParameters?
                            privateKeyOpt = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58388, 58644) || true) && (f_127_58392_58430(f_127_58392_58411(compilation)) != null && (DynAbs.Tracing.TraceSender.Expression_True(127, 58392, 58470) && f_127_58442_58470(compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(127, 58392, 58505) && f_127_58474_58505_M(!f_127_58475_58494(compilation).PublicSign)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 58388, 58644);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58563, 58617);

                                privateKeyOpt = f_127_58579_58605(compilation).PrivateKey;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 58388, 58644);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58851, 58931);

                            emitOptions = f_127_58865_58930(emitOptions, f_127_58908_58929(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 58959, 59493);

                            success = f_127_58969_59492(compilation, moduleBeingBuilt, peStreamProvider, refPeStreamProviderOpt, pdbStreamProviderOpt, testSymWriterFactory: null, diagnostics: diagnostics, emitOptions: emitOptions, privateKeyOpt: privateKeyOpt, cancellationToken: cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59521, 59557);

                            f_127_59521_59556(
                                                    peStreamProvider, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59583, 59626);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(refPeStreamProviderOpt, 127, 59583, 59625)?.Close(diagnostics), 127, 59606, 59625);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59652, 59693);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pdbStreamProviderOpt, 127, 59652, 59692)?.Close(diagnostics), 127, 59673, 59692);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59721, 60313) || true) && (success && (DynAbs.Tracing.TraceSender.Expression_True(127, 59725, 59762) && touchedFilesLogger != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 59721, 60313);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59820, 59997) || true) && (pdbStreamProviderOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 59820, 59997);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 59918, 59966);

                                    f_127_59918_59965(touchedFilesLogger, finalPdbFilePath);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 59820, 59997);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60027, 60209) || true) && (refPeStreamProviderOpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60027, 60209);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60127, 60178);

                                    f_127_60127_60177(touchedFilesLogger, finalRefPeFilePath!);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60027, 60209);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60239, 60286);

                                f_127_60239_60285(touchedFilesLogger, finalPeFilePath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 59721, 60313);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(127, 57788, 60336);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 51582, 60355);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60375, 60483) || true) && (f_127_60379_60415(diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60375, 60483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60457, 60464);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60375, 60483);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(127, 60512, 60606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60552, 60591);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 60552, 60590)?.Dispose(), 127, 60580, 60590);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(127, 60512, 60606);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60622, 60737) || true) && (f_127_60626_60673_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceLinkStreamDisposerOpt, 127, 60626, 60673)?.HasFailedToDispose) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60622, 60737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60715, 60722);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60622, 60737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60753, 60802);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60818, 61101) || true) && (analyzerExceptionDiagnostics != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60818, 61101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60892, 60943);

                    f_127_60892_60942(diagnostics, analyzerExceptionDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 60961, 61086) || true) && (f_127_60965_61018(analyzerExceptionDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 60961, 61086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61060, 61067);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60961, 61086);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 60818, 61101);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61117, 61166);

                cancellationToken.ThrowIfCancellationRequested();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61182, 61311) || true) && (!f_127_61187_61255(this, diagnostics, touchedFilesLogger, finalXmlFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61182, 61311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61289, 61296);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61182, 61311);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 40174, 61322);

                int
                f_127_41149_41260(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, bool
                includeEarlierStages, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.GetDiagnostics(stage, includeEarlierStages: includeEarlierStages, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41149, 41260);
                    return 0;
                }


                bool
                f_127_41279_41315(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41279, 41315);
                    return return_v;
                }


                bool
                f_127_41456_41474_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41456, 41474);
                    return return_v;
                }


                bool
                f_127_41478_41497_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41478, 41497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_41560_41603()
                {
                    var return_v = CompilerAnalyzerConfigOptionsProvider.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41560, 41603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_41626_41635()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 41626, 41635);
                    return return_v;
                }


                int
                f_127_41708_41749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41708, 41749);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_41872_41927(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param, string
                sourcePath)
                {
                    var return_v = this_param.GetOptionsForSourcePath(sourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41872, 41927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                f_127_41838_41944(System.Collections.Immutable.ImmutableDictionary<string, string>
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions(properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41838, 41944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_41797_41945(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                this_param, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptions
                globalOptions)
                {
                    var return_v = this_param.WithGlobalOptions((Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions)globalOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 41797, 41945);
                    return return_v;
                }


                int
                f_127_42499_42539(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42499, 42539);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_42420_42449_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42420, 42449);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_42723_42746(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 42723, 42746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_42612_42907(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                existing, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalFiles, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                additionalFileOptions)
                {
                    var return_v = UpdateAnalyzerConfigOptionsProvider(existing, syntaxTrees, sourceFileAnalyzerConfigOptions, additionalFiles, additionalFileOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 42612, 42907);
                    return return_v;
                }


                bool
                f_127_42951_42970_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 42951, 42970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43241_43250()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43241, 43250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_127_43241_43263(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ParseOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43241, 43263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_127_43214_43334(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                input, Microsoft.CodeAnalysis.ParseOptions
                parseOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
                generators, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                analyzerConfigOptionsProvider, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTexts, Microsoft.CodeAnalysis.DiagnosticBag
                generatorDiagnostics)
                {
                    var return_v = this_param.RunGenerators(input, parseOptions, generators, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider)analyzerConfigOptionsProvider, additionalTexts, generatorDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43214, 43334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43386_43395()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43386, 43395);
                    return return_v;
                }


                bool
                f_127_43385_43423_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43385, 43423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43503_43512()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43503, 43512);
                    return return_v;
                }


                string?
                f_127_43503_43542(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.GeneratedFilesOutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43503, 43542);
                    return return_v;
                }


                bool
                f_127_43477_43543(string?
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43477, 43543);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43595_43618(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43595, 43618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_43624_43633()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43624, 43633);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43595_43653(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source, int
                count)
                {
                    var return_v = source.Skip<Microsoft.CodeAnalysis.SyntaxTree>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43595, 43653);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_43595_43662(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43595, 43662);
                    return return_v;
                }


                int
                f_127_43791_43817(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43791, 43817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_43737_43818(int
                capacity)
                {
                    var return_v = ArrayBuilder<AnalyzerConfigOptionsResult>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43737, 43818);
                    return return_v;
                }


                int
                f_127_43913_43939(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 43913, 43939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                f_127_43874_43940(int
                capacity)
                {
                    var return_v = ArrayBuilder<EmbeddedText>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 43874, 43940);
                    return return_v;
                }


                string
                f_127_44154_44167(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44154, 44167);
                    return return_v;
                }


                bool
                f_127_44128_44168(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44128, 44168);
                    return return_v;
                }


                int
                f_127_44114_44169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44114, 44169);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_127_44298_44329(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetText(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44298, 44329);
                    return return_v;
                }


                string
                f_127_44509_44522(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44509, 44522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_127_44485_44535(string
                filePath, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = EmbeddedText.FromSource(filePath, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44485, 44535);
                    return return_v;
                }


                int
                f_127_44461_44536(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                this_param, Microsoft.CodeAnalysis.EmbeddedText
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44461, 44536);
                    return 0;
                }


                string
                f_127_44739_44752(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 44739, 44752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_127_44696_44753(Microsoft.CodeAnalysis.AnalyzerConfigSet
                this_param, string
                sourcePath)
                {
                    var return_v = this_param.GetOptionsForSourcePath(sourcePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44696, 44753);
                    return return_v;
                }


                int
                f_127_44669_44754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44669, 44754);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_45011_45020()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45011, 45020);
                    return return_v;
                }


                string
                f_127_45053_45066(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45053, 45066);
                    return return_v;
                }


                string
                f_127_44998_45067(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44998, 45067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_45123_45132()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45123, 45132);
                    return return_v;
                }


                string?
                f_127_45123_45162(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.GeneratedFilesOutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45123, 45162);
                    return return_v;
                }


                bool
                f_127_45106_45163(string?
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45106, 45163);
                    return return_v;
                }


                string?
                f_127_45263_45290(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45263, 45290);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_127_45237_45291(string?
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45237, 45291);
                    return return_v;
                }


                System.IO.Stream?
                f_127_45380_45482(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45380, 45482);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_45628_45641(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45628, 45641);
                    return return_v;
                }


                int
                f_127_45615_45652(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45615, 45652);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_45771_45786()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45771, 45786);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_45714_45787(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45714, 45787);
                    return return_v;
                }


                System.Text.Encoding
                f_127_45874_45887(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 45874, 45887);
                    return return_v;
                }


                System.IO.StreamWriter
                f_127_45845_45888(System.IO.Stream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter(stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45845, 45888);
                    return return_v;
                }


                int
                f_127_45929_45972(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.IO.StreamWriter
                textWriter, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Write((System.IO.TextWriter)textWriter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 45929, 45972);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                f_127_44036_44056_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 44036, 44056);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                f_127_46553_46589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46553, 46589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                f_127_46374_46590(Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                existing, System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxTree>
                syntaxTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                sourceFileAnalyzerConfigOptions)
                {
                    var return_v = UpdateAnalyzerConfigOptionsProvider(existing, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, sourceFileAnalyzerConfigOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46374, 46590);
                    return return_v;
                }


                int
                f_127_46776_46802(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.EmbeddedText>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46776, 46802);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
                f_127_46899_46989(Microsoft.CodeAnalysis.CommonCompiler
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTextFiles, Microsoft.CodeAnalysis.Diagnostics.CompilerAnalyzerConfigOptionsProvider
                analyzerConfigOptionsProvider)
                {
                    var return_v = this_param.CreateAnalyzerOptions(additionalTextFiles, (Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider)analyzerConfigOptionsProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 46899, 46989);
                    return return_v;
                }


                bool
                f_127_47014_47032_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47014, 47032);
                    return return_v;
                }


                System.Threading.CancellationTokenSource
                f_127_47088_47154(params System.Threading.CancellationToken[]
                tokens)
                {
                    var return_v = CancellationTokenSource.CreateLinkedTokenSource(tokens);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47088, 47154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_47208_47227()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47208, 47227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_47670_47679()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47670, 47679);
                    return return_v;
                }


                string?
                f_127_47670_47692(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ErrorLogPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 47670, 47692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager
                f_127_47992_48022(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                analyzers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerManager(analyzers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47992, 48022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_48108_48117()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48108, 48117);
                    return return_v;
                }


                bool
                f_127_48108_48132(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReportAnalyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48108, 48132);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_127_48242_48259(System.Threading.CancellationTokenSource
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48242, 48259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                f_127_47806_48260(Microsoft.CodeAnalysis.Compilation
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 47806, 48260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_48300_48309()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48300, 48309);
                    return return_v;
                }


                bool
                f_127_48300_48324(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ReportAnalyzer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48300, 48324);
                    return return_v;
                }


                bool
                f_127_48328_48346_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 48328, 48346);
                    return return_v;
                }


                int
                f_127_48397_48510(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, bool
                includeEarlierStages, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.GetDiagnostics(stage, includeEarlierStages: includeEarlierStages, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 48397, 48510);
                    return 0;
                }


                bool
                f_127_48529_48565(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 48529, 48565);
                    return return_v;
                }


                string
                f_127_49103_49152(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOutputFileName(compilation, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49103, 49152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49190_49199()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49190, 49199);
                    return return_v;
                }


                string
                f_127_49190_49229(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, string
                outputFileName)
                {
                    var return_v = this_param.GetOutputFilePath(outputFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49190, 49229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49267_49276()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49267, 49276);
                    return return_v;
                }


                string
                f_127_49267_49303(Microsoft.CodeAnalysis.CommandLineArguments
                this_param, string
                outputFileName)
                {
                    var return_v = this_param.GetPdbFilePath(outputFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49267, 49303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49341_49350()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49341, 49350);
                    return return_v;
                }


                string?
                f_127_49341_49368(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.DocumentationPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49341, 49368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49647_49656()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49647, 49656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49647_49668(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49647, 49668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49647_49725(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                outputName)
                {
                    var return_v = this_param.WithOutputNameOverride(outputName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49647, 49725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_49816_49825()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49816, 49825);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_127_49816_49833(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.PathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 49816, 49833);
                    return return_v;
                }


                string
                f_127_49764_49834(string
                filePath, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap)
                {
                    var return_v = PathUtilities.NormalizePathPrefix(filePath, pathMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49764, 49834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_49647_49835(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                path)
                {
                    var return_v = this_param.WithPdbFilePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 49647, 49835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50092_50101()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50092, 50101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_127_50092_50114(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ParseOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50092, 50114);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, string>
                f_127_50092_50123(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Features;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50092, 50123);
                    return return_v;
                }


                bool
                f_127_50092_50159(System.Collections.Generic.IReadOnlyDictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50092, 50159);
                    return return_v;
                }


                string?
                f_127_50185_50208(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50185, 50208);
                    return return_v;
                }


                bool
                f_127_50164_50209(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50164, 50209);
                    return return_v;
                }


                string
                f_127_50310_50333(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.PdbFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50310, 50333);
                    return return_v;
                }


                string?
                f_127_50293_50334(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50293, 50334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_50265_50335(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, string
                path)
                {
                    var return_v = this_param.WithPdbFilePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50265, 50335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50379_50388()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50379, 50388);
                    return return_v;
                }


                string?
                f_127_50379_50399(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50379, 50399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50510_50519()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50510, 50519);
                    return return_v;
                }


                string
                f_127_50510_50530(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50510, 50530);
                    return return_v;
                }


                System.IO.Stream?
                f_127_50475_50692(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50475, 50692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_50934_50943()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50934, 50943);
                    return return_v;
                }


                string
                f_127_50934_50954(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceLink;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 50934, 50954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_51027_51042()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51027, 51042);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_50828_51043(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 50828, 51043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_51232_51241()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51232, 51241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ResourceDescription>
                f_127_51232_51259(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.ManifestResources;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51232, 51259);
                    return return_v;
                }


                System.IO.Stream?
                f_127_51378_51413_M(System.IO.Stream?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51378, 51413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder?
                f_127_51129_51561(Microsoft.CodeAnalysis.Compilation
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 51129, 51561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_51855_51864()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51855, 51864);
                    return return_v;
                }


                bool
                f_127_51855_51872(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitPdb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51855, 51872);
                    return return_v;
                }


                bool
                f_127_51903_51931(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitMetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51903, 51931);
                    return return_v;
                }


                bool
                f_127_51962_51994(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.EmitTestCoverageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 51962, 51994);
                    return return_v;
                }


                bool
                f_127_51751_52150(Microsoft.CodeAnalysis.Compilation
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 51751, 52150);
                    return return_v;
                }


                bool
                f_127_52782_52819_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 52782, 52819);
                    return return_v;
                }


                int
                f_127_52877_52947(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 52877, 52947);
                    return 0;
                }


                bool
                f_127_53007_53041(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressedErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 53007, 53041);
                    return return_v;
                }


                System.IO.Stream?
                f_127_53631_53995(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 53631, 53995);
                    return return_v;
                }


                int
                f_127_54284_54309(System.IO.Stream
                this_param, int
                value)
                {
                    this_param.SetLength((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54284, 54309);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_54471_54486()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 54471, 54486);
                    return return_v;
                }


                int
                f_127_54471_54547(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54471, 54547);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_54905_54920()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 54905, 54920);
                    return return_v;
                }


                Roslyn.Utilities.NoThrowStreamDisposer
                f_127_54685_54921(System.IO.Stream
                stream, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider)
                {
                    var return_v = new Roslyn.Utilities.NoThrowStreamDisposer(stream, filePath, diagnostics, messageProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 54685, 54921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_55132_55147()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55132, 55147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_55149_55158()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55149, 55158);
                    return return_v;
                }


                System.IO.Stream?
                f_127_55114_55185(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetWin32Resources(messageProvider, arguments, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55114, 55185);
                    return return_v;
                }


                bool
                f_127_55263_55299(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55263, 55299);
                    return return_v;
                }


                System.IO.Stream?
                f_127_55632_55660_M(System.IO.Stream?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55632, 55660);
                    return return_v;
                }


                string?
                f_127_55768_55798(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param)
                {
                    var return_v = this_param.OutputNameOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 55768, 55798);
                    return return_v;
                }


                bool
                f_127_55477_55913(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBeingBuilt, System.IO.Stream?
                xmlDocumentationStream, System.IO.Stream?
                win32ResourcesStream, string?
                outputNameOverride, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GenerateResourcesAndDocumentationComments(moduleBeingBuilt, xmlDocumentationStream, win32ResourcesStream, outputNameOverride, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 55477, 55913);
                    return return_v;
                }


                bool?
                f_127_56016_56056_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 56016, 56056);
                    return return_v;
                }


                int
                f_127_56355_56424(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.ReportUnusedImports(filterTree, diagnostics, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56355, 56424);
                    return 0;
                }


                int
                f_127_56511_56542(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                filterTree)
                {
                    this_param.CompleteTrees(filterTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56511, 56542);
                    return 0;
                }


                System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_127_56923_56970(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetDiagnosticsAsync(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 56923, 56970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_56923_56977(System.Threading.Tasks.Task<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 56923, 56977);
                    return return_v;
                }


                int
                f_127_57008_57045(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57008, 57045);
                    return 0;
                }


                bool
                f_127_57082_57119_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 57082, 57119);
                    return return_v;
                }


                int
                f_127_57321_57391(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                reportedDiagnostics, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    this_param.ApplyProgrammaticSuppressions(reportedDiagnostics, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57321, 57391);
                    return 0;
                }


                int
                f_127_57551_57589(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                this_param)
                {
                    this_param.CompilationFinished();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57551, 57589);
                    return 0;
                }


                bool
                f_127_57641_57675(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressedErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57641, 57675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_57872_57925(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 57872, 57925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_57979_57988()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 57979, 57988);
                    return return_v;
                }


                bool
                f_127_57979_58000(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.EmitPdbFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 57979, 58000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_58003_58057(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58003, 58057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_58122_58131()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58122, 58131);
                    return return_v;
                }


                string?
                f_127_58122_58149(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputRefFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58122, 58149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                f_127_58234_58290(Microsoft.CodeAnalysis.CommonCompiler
                compiler, string
                filePath)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider(compiler, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58234, 58290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_58392_58411(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58392, 58411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameProvider?
                f_127_58392_58430(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.StrongNameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58392, 58430);
                    return return_v;
                }


                bool
                f_127_58442_58470(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SignUsingBuilder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58442, 58470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_58475_58494(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58475, 58494);
                    return return_v;
                }


                bool
                f_127_58474_58505_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58474, 58505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.StrongNameKeys
                f_127_58579_58605(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.StrongNameKeys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 58579, 58605);
                    return return_v;
                }


                System.Text.Encoding?
                f_127_58908_58929(Microsoft.CodeAnalysis.CommonCompiler
                this_param)
                {
                    var return_v = this_param.GetFallbackEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58908, 58929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_127_58865_58930(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Text.Encoding?
                fallbackSourceFileEncoding)
                {
                    var return_v = this_param.WithFallbackSourceFileEncoding(fallbackSourceFileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58865, 58930);
                    return return_v;
                }


                bool
                f_127_58969_59492(Microsoft.CodeAnalysis.Compilation
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 58969, 59492);
                    return return_v;
                }


                int
                f_127_59521_59556(Microsoft.CodeAnalysis.CommonCompiler.CompilerEmitStreamProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.Close(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 59521, 59556);
                    return 0;
                }


                int
                f_127_59918_59965(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 59918, 59965);
                    return 0;
                }


                int
                f_127_60127_60177(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60127, 60177);
                    return 0;
                }


                int
                f_127_60239_60285(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60239, 60285);
                    return 0;
                }


                bool
                f_127_60379_60415(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60379, 60415);
                    return return_v;
                }


                bool?
                f_127_60626_60673_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 60626, 60673);
                    return return_v;
                }


                int
                f_127_60892_60942(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60892, 60942);
                    return 0;
                }


                bool
                f_127_60965_61018(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = HasUnsuppressableErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 60965, 61018);
                    return return_v;
                }


                bool
                f_127_61187_61255(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.TouchedFileLogger?
                touchedFilesLogger, string?
                finalXmlFilePath)
                {
                    var return_v = this_param.WriteTouchedFiles(diagnostics, touchedFilesLogger, finalXmlFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61187, 61255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 40174, 61322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 40174, 61322);
            }
        }

        protected virtual Diagnostics.AnalyzerOptions CreateAnalyzerOptions(
                    ImmutableArray<AdditionalText> additionalTextFiles,
                    AnalyzerConfigOptionsProvider analyzerConfigOptionsProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 61587, 61673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61590, 61673);
                return f_127_61590_61673(additionalTextFiles, analyzerConfigOptionsProvider); DynAbs.Tracing.TraceSender.TraceExitMethod(127, 61587, 61673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 61587, 61673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 61587, 61673);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions
            f_127_61590_61673(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
            additionalFiles, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
            optionsProvider)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerOptions(additionalFiles, optionsProvider);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61590, 61673);
                return return_v;
            }

        }

        private bool WriteTouchedFiles(DiagnosticBag diagnostics, TouchedFileLogger? touchedFilesLogger, string? finalXmlFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 61686, 63502);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61833, 63463) || true) && (f_127_61837_61863(f_127_61837_61846()) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61833, 63463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61905, 61946);

                    f_127_61905_61945(touchedFilesLogger != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 61966, 62103) || true) && (finalXmlFilePath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 61966, 62103);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62036, 62084);

                        f_127_62036_62083(touchedFilesLogger, finalXmlFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61966, 62103);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62123, 62183);

                    string
                    readFilesPath = f_127_62146_62172(f_127_62146_62155()) + ".read"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62201, 62265);

                    string
                    writtenFilesPath = f_127_62227_62253(f_127_62227_62236()) + ".write"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62285, 62368);

                    var
                    readStream = f_127_62302_62367(this, readFilesPath, diagnostics, mode: FileMode.OpenOrCreate)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62386, 62475);

                    var
                    writtenStream = f_127_62406_62474(this, writtenFilesPath, diagnostics, mode: FileMode.OpenOrCreate)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62495, 62616) || true) && (readStream == null || (DynAbs.Tracing.TraceSender.Expression_False(127, 62499, 62542) || writtenStream == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 62495, 62616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62584, 62597);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 62495, 62616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62636, 62660);

                    string?
                    filePath = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62722, 62747);

                        filePath = readFilesPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62769, 62932);
                        using (var
                        writer = f_127_62789_62817(readStream)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62867, 62909);

                            f_127_62867_62908(touchedFilesLogger, writer);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(127, 62769, 62932);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 62956, 62984);

                        filePath = writtenFilesPath;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63006, 63175);
                        using (var
                        writer = f_127_63026_63057(writtenStream)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63107, 63152);

                            f_127_63107_63151(touchedFilesLogger, writer);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(127, 63006, 63175);
                        }
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 63212, 63448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63272, 63303);

                        f_127_63272_63302(filePath != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63325, 63394);

                        f_127_63325_63393(f_127_63325_63340(), e, filePath, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63416, 63429);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(127, 63212, 63448);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 61833, 63463);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63479, 63491);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 61686, 63502);

                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_61837_61846()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 61837, 61846);
                    return return_v;
                }


                string?
                f_127_61837_61863(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 61837, 61863);
                    return return_v;
                }


                int
                f_127_61905_61945(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 61905, 61945);
                    return 0;
                }


                int
                f_127_62036_62083(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, string
                path)
                {
                    this_param.AddWritten(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62036, 62083);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_62146_62155()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62146, 62155);
                    return return_v;
                }


                string
                f_127_62146_62172(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62146, 62172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_62227_62236()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62227, 62236);
                    return return_v;
                }


                string
                f_127_62227_62253(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.TouchedFilesPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 62227, 62253);
                    return return_v;
                }


                System.IO.Stream?
                f_127_62302_62367(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode: mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62302, 62367);
                    return return_v;
                }


                System.IO.Stream?
                f_127_62406_62474(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.IO.FileMode
                mode)
                {
                    var return_v = this_param.OpenFile(filePath, diagnostics, mode: mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62406, 62474);
                    return return_v;
                }


                System.IO.StreamWriter
                f_127_62789_62817(System.IO.Stream
                stream)
                {
                    var return_v = new System.IO.StreamWriter(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62789, 62817);
                    return return_v;
                }


                int
                f_127_62867_62908(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, System.IO.StreamWriter
                s)
                {
                    this_param.WriteReadPaths((System.IO.TextWriter)s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 62867, 62908);
                    return 0;
                }


                System.IO.StreamWriter
                f_127_63026_63057(System.IO.Stream
                stream)
                {
                    var return_v = new System.IO.StreamWriter(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63026, 63057);
                    return return_v;
                }


                int
                f_127_63107_63151(Microsoft.CodeAnalysis.TouchedFileLogger
                this_param, System.IO.StreamWriter
                s)
                {
                    this_param.WriteWrittenPaths((System.IO.TextWriter)s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63107, 63151);
                    return 0;
                }


                int
                f_127_63272_63302(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63272, 63302);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_63325_63340()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63325, 63340);
                    return return_v;
                }


                int
                f_127_63325_63393(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63325, 63393);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 61686, 63502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 61686, 63502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual ImmutableArray<AdditionalTextFile> ResolveAdditionalFilesFromArguments(List<DiagnosticInfo> diagnostics, CommonMessageProvider messageProvider, TouchedFileLogger? touchedFilesLogger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 63514, 64024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63739, 63804);

                var
                builder = f_127_63753_63803()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63820, 63963);
                    foreach (var file in f_127_63841_63866_I(f_127_63841_63866(f_127_63841_63850())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 63820, 63963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63900, 63948);

                        f_127_63900_63947(builder, f_127_63912_63946(file, this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 63820, 63963);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 63979, 64013);

                return f_127_63986_64012(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 63514, 64024);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                f_127_63753_63803()
                {
                    var return_v = ImmutableArray.CreateBuilder<AdditionalTextFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63753, 63803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineArguments
                f_127_63841_63850()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63841, 63850);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_63841_63866(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.AdditionalFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 63841, 63866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AdditionalTextFile
                f_127_63912_63946(Microsoft.CodeAnalysis.CommandLineSourceFile
                sourceFile, Microsoft.CodeAnalysis.CommonCompiler
                compiler)
                {
                    var return_v = new Microsoft.CodeAnalysis.AdditionalTextFile(sourceFile, compiler);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63912, 63946);
                    return return_v;
                }


                int
                f_127_63900_63947(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                this_param, Microsoft.CodeAnalysis.AdditionalTextFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63900, 63947);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_63841_63866_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63841, 63866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>
                f_127_63986_64012(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>.Builder
                builder)
                {
                    var return_v = builder.ToImmutableArray<Microsoft.CodeAnalysis.AdditionalTextFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 63986, 64012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 63514, 64024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 63514, 64024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportAnalyzerExecutionTime(TextWriter consoleOutput, AnalyzerDriver analyzerDriver, CultureInfo culture, bool isConcurrentBuild)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 64036, 67505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64210, 64270);

                f_127_64210_64269(f_127_64223_64260(analyzerDriver) != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64284, 64389) || true) && (f_127_64288_64333(f_127_64288_64325(analyzerDriver)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 64284, 64389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64367, 64374);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 64284, 64389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64405, 64511);

                var
                totalAnalyzerExecutionTime = f_127_64438_64510(f_127_64438_64475(analyzerDriver), kvp => kvp.Value.TotalSeconds)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64525, 64601);

                Func<double, string>
                getFormattedTime = d => d.ToString("##0.000", culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64615, 64641);

                f_127_64615_64640(consoleOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64655, 64790);

                f_127_64655_64789(consoleOutput, f_127_64679_64788(f_127_64693_64741(), f_127_64743_64787(getFormattedTime, totalAnalyzerExecutionTime)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64806, 64958) || true) && (isConcurrentBuild)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 64806, 64958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64861, 64943);

                    f_127_64861_64942(consoleOutput, f_127_64885_64941());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 64806, 64958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 64974, 65193);

                var
                analyzersByAssembly = f_127_65000_65192(f_127_65000_65112(f_127_65000_65037(analyzerDriver), kvp => kvp.Key.GetType().GetTypeInfo().Assembly), kvp => kvp.Sum(entry => entry.Value.Ticks))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65209, 65235);

                f_127_65209_65234(
                            consoleOutput);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65251, 65412);

                getFormattedTime = d => d < 0.001 ?
                                string.Format(culture, "{0,8:<0.000}", 0.001) :
                                string.Format(culture, "{0,8:##0.000}", d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65426, 65526);

                Func<int, string>
                getFormattedPercentage = i => string.Format("{0,5}", i < 1 ? "<1" : i.ToString())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65540, 65604);

                Func<string?, string>
                getFormattedAnalyzerName = s => "   " + s
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65649, 65754);

                var
                analyzerTimeColumn = f_127_65674_65753("{0,8}", f_127_65697_65752())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65768, 65827);

                var
                analyzerPercentageColumn = f_127_65799_65826("{0,5}", "%")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65841, 65939);

                var
                analyzerNameColumn = f_127_65866_65938(getFormattedAnalyzerName, f_127_65891_65937())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 65953, 66045);

                f_127_65953_66044(consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66109, 67494);
                    foreach (var analyzerGroup in f_127_66139_66158_I(analyzersByAssembly))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 66109, 67494);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66192, 66261);

                        var
                        executionTime = f_127_66212_66260(analyzerGroup, kvp => kvp.Value.TotalSeconds)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66279, 66352);

                        var
                        percentage = (int)(executionTime * 100 / totalAnalyzerExecutionTime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66372, 66425);

                        analyzerTimeColumn = f_127_66393_66424(getFormattedTime, executionTime);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66443, 66505);

                        analyzerPercentageColumn = f_127_66470_66504(getFormattedPercentage, percentage);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66523, 66597);

                        analyzerNameColumn = f_127_66544_66596(getFormattedAnalyzerName, f_127_66569_66595(f_127_66569_66586(analyzerGroup)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66617, 66709);

                        f_127_66617_66708(
                                        consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66800, 67433);
                            foreach (var kvp in f_127_66820_66869_I(f_127_66820_66869(analyzerGroup, kvp => kvp.Value)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 66800, 67433);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66911, 66950);

                                executionTime = kvp.Value.TotalSeconds;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 66972, 67041);

                                percentage = (int)(executionTime * 100 / totalAnalyzerExecutionTime);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67065, 67118);

                                analyzerTimeColumn = f_127_67086_67117(getFormattedTime, executionTime);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67140, 67202);

                                analyzerPercentageColumn = f_127_67167_67201(getFormattedPercentage, percentage);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67224, 67298);

                                analyzerNameColumn = f_127_67245_67297(getFormattedAnalyzerName, "   " + f_127_67278_67296(kvp.Key));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67322, 67414);

                                f_127_67322_67413(
                                                    consoleOutput, analyzerTimeColumn + analyzerPercentageColumn + analyzerNameColumn);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(127, 66800, 67433);
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
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67453, 67479);

                        f_127_67453_67478(
                                        consoleOutput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 66109, 67494);
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
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 64036, 67505);

                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64223_64260(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64223, 64260);
                    return return_v;
                }


                int
                f_127_64210_64269(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64210, 64269);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64288_64325(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64288, 64325);
                    return return_v;
                }


                bool
                f_127_64288_64333(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64288, 64333);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_64438_64475(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64438, 64475);
                    return return_v;
                }


                double
                f_127_64438_64510(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, double>
                selector)
                {
                    var return_v = source.Sum<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64438, 64510);
                    return return_v;
                }


                int
                f_127_64615_64640(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64615, 64640);
                    return 0;
                }


                string
                f_127_64693_64741()
                {
                    var return_v = CodeAnalysisResources.AnalyzerTotalExecutionTime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64693, 64741);
                    return return_v;
                }


                string
                f_127_64743_64787(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64743, 64787);
                    return return_v;
                }


                string
                f_127_64679_64788(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64679, 64788);
                    return return_v;
                }


                int
                f_127_64655_64789(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64655, 64789);
                    return 0;
                }


                string
                f_127_64885_64941()
                {
                    var return_v = CodeAnalysisResources.MultithreadedAnalyzerExecutionNote;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 64885, 64941);
                    return return_v;
                }


                int
                f_127_64861_64942(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 64861, 64942);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                f_127_65000_65037(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver
                this_param)
                {
                    var return_v = this_param.AnalyzerExecutionTimes
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65000, 65037);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_65000_65112(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.Reflection.Assembly>
                keySelector)
                {
                    var return_v = source.GroupBy<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.Reflection.Assembly>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65000, 65112);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_65000_65192(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                source, System.Func<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>, long>
                keySelector)
                {
                    var return_v = source.OrderByDescending<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>, long>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65000, 65192);
                    return return_v;
                }


                int
                f_127_65209_65234(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65209, 65234);
                    return 0;
                }


                string
                f_127_65697_65752()
                {
                    var return_v = CodeAnalysisResources.AnalyzerExecutionTimeColumnHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65697, 65752);
                    return return_v;
                }


                string
                f_127_65674_65753(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65674, 65753);
                    return return_v;
                }


                string
                f_127_65799_65826(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65799, 65826);
                    return return_v;
                }


                string
                f_127_65891_65937()
                {
                    var return_v = CodeAnalysisResources.AnalyzerNameColumnHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 65891, 65937);
                    return return_v;
                }


                string
                f_127_65866_65938(System.Func<string?, string>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65866, 65938);
                    return return_v;
                }


                int
                f_127_65953_66044(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 65953, 66044);
                    return 0;
                }


                double
                f_127_66212_66260(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, double>
                selector)
                {
                    var return_v = source.Sum<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66212, 66260);
                    return return_v;
                }


                string
                f_127_66393_66424(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66393, 66424);
                    return return_v;
                }


                string
                f_127_66470_66504(System.Func<int, string>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66470, 66504);
                    return return_v;
                }


                System.Reflection.Assembly
                f_127_66569_66586(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 66569, 66586);
                    return return_v;
                }


                string?
                f_127_66569_66595(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 66569, 66595);
                    return return_v;
                }


                string
                f_127_66544_66596(System.Func<string?, string>
                this_param, string?
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66544, 66596);
                    return return_v;
                }


                int
                f_127_66617_66708(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66617, 66708);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                f_127_66820_66869(System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.TimeSpan>
                keySelector)
                {
                    var return_v = source.OrderByDescending<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>, System.TimeSpan>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66820, 66869);
                    return return_v;
                }


                string
                f_127_67086_67117(System.Func<double, string>
                this_param, double
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67086, 67117);
                    return return_v;
                }


                string
                f_127_67167_67201(System.Func<int, string>
                this_param, int
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67167, 67201);
                    return return_v;
                }


                string
                f_127_67278_67296(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67278, 67296);
                    return return_v;
                }


                string
                f_127_67245_67297(System.Func<string?, string>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67245, 67297);
                    return return_v;
                }


                int
                f_127_67322_67413(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67322, 67413);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                f_127_66820_66869_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66820, 66869);
                    return return_v;
                }


                int
                f_127_67453_67478(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 67453, 67478);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                f_127_66139_66158_I(System.Linq.IOrderedEnumerable<System.Linq.IGrouping<System.Reflection.Assembly, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.TimeSpan>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 66139, 66158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 64036, 67505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 64036, 67505);
            }
        }

        protected abstract string GetOutputFileName(Compilation compilation, CancellationToken cancellationToken);

        internal Func<string, FileMode, FileAccess, FileShare, Stream> FileOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 67947, 68050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 67953, 68048);

                    return _fileOpen ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Func<string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.Stream>?>(127, 67960, 68047) ?? ((path, mode, access, share) => new FileStream(path, mode, access, share)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 67947, 68050);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 67851, 68101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 67851, 68101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 68064, 68090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68070, 68088);

                    _fileOpen = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 68064, 68090);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 67851, 68101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 67851, 68101);
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
                DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 68198, 68753);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68500, 68547);

                    // LAFHIS
                    //return f_127_68507_68546(FileOpen, filePath, mode, access, share);
                    var temp = FileOpen(filePath, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 68507, 68546);
                    return temp;
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 68576, 68742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68628, 68697);

                    f_127_68628_68696(f_127_68628_68643(), e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 68715, 68727);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 68576, 68742);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(127, 68198, 68753);

                System.Func<string, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, System.IO.Stream>
                f_127_68507_68515()
                {
                    var return_v = FileOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 68507, 68515);
                    return return_v;
                }


                System.IO.Stream
                f_127_68507_68546(Microsoft.CodeAnalysis.CommonCompiler
                this_param, string
                arg1, System.IO.FileMode
                arg2, System.IO.FileAccess
                arg3, System.IO.FileShare
                arg4)
                {
                    var return_v = this_param.FileOpen(arg1, arg2, arg3, arg4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 68507, 68546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_127_68628_68643()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 68628, 68643);
                    return return_v;
                }


                int
                f_127_68628_68696(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 68628, 68696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 68198, 68753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 68198, 68753);
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
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 68798, 69419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69061, 69107);

                var
                diagnostics = f_127_69079_69106()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69121, 69206);

                var
                stream = f_127_69134_69205(messageProvider, arguments, compilation, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69220, 69380);

                errors = f_127_69229_69260(diagnostics).SelectAsArray(diag => new DiagnosticInfo(messageProvider, diag.IsWarningAsError, diag.Code, (object[])diag.Arguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69394, 69408);

                return stream;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 68798, 69419);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_127_69079_69106()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69079, 69106);
                    return return_v;
                }


                System.IO.Stream?
                f_127_69134_69205(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetWin32Resources(messageProvider, arguments, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69134, 69205);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_127_69229_69260(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69229, 69260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 68798, 69419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 68798, 69419);
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
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 69431, 70768);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69672, 69905) || true) && (f_127_69676_69703(arguments) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 69672, 69905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69745, 69890);

                    return f_127_69752_69889(messageProvider, f_127_69780_69807(arguments), f_127_69809_69832(arguments), f_127_69834_69875(messageProvider), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 69672, 69905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 69921, 70729);
                using (Stream?
                manifestStream = f_127_69953_70044(messageProvider, f_127_69989_70019(f_127_69989_70008(compilation)), arguments, diagnostics)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70078, 70714);
                    using (Stream?
                    iconStream = f_127_70106_70231(messageProvider, f_127_70134_70153(arguments), f_127_70155_70178(arguments), f_127_70180_70217(messageProvider), diagnostics)
                    )
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70325, 70433);

                            return f_127_70332_70432(compilation, true, f_127_70378_70403(arguments), manifestStream, iconStream);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 70478, 70695);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70547, 70672);

                            f_127_70547_70671(diagnostics, f_127_70563_70670(messageProvider, f_127_70596_70642(messageProvider), f_127_70644_70657(), f_127_70659_70669(ex)));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(127, 70478, 70695);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(127, 70078, 70714);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 69921, 70729);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70745, 70757);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 69431, 70768);

                string?
                f_127_69676_69703(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32ResourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69676, 69703);
                    return return_v;
                }


                string
                f_127_69780_69807(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32ResourceFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69780, 69807);
                    return return_v;
                }


                string?
                f_127_69809_69832(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69809, 69832);
                    return return_v;
                }


                int
                f_127_69834_69875(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69834, 69875);
                    return return_v;
                }


                System.IO.Stream?
                f_127_69752_69889(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69752, 69889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_127_69989_70008(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69989, 70008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_127_69989_70019(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 69989, 70019);
                    return return_v;
                }


                System.IO.Stream?
                f_127_69953_70044(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.OutputKind
                outputKind, Microsoft.CodeAnalysis.CommandLineArguments
                arguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenManifestStream(messageProvider, outputKind, arguments, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 69953, 70044);
                    return return_v;
                }


                string?
                f_127_70134_70153(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32Icon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70134, 70153);
                    return return_v;
                }


                string?
                f_127_70155_70178(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70155, 70178);
                    return return_v;
                }


                int
                f_127_70180_70217(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Icon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70180, 70217);
                    return return_v;
                }


                System.IO.Stream?
                f_127_70106_70231(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string?
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70106, 70231);
                    return return_v;
                }


                bool
                f_127_70378_70403(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.NoWin32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70378, 70403);
                    return return_v;
                }


                System.IO.Stream
                f_127_70332_70432(Microsoft.CodeAnalysis.Compilation
                this_param, bool
                versionResource, bool
                noManifest, System.IO.Stream?
                manifestContents, System.IO.Stream?
                iconInIcoFormat)
                {
                    var return_v = this_param.CreateDefaultWin32Resources(versionResource, noManifest, manifestContents, iconInIcoFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70332, 70432);
                    return return_v;
                }


                int
                f_127_70596_70642(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_ErrorBuildingWin32Resource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70596, 70642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_70644_70657()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70644, 70657);
                    return return_v;
                }


                string
                f_127_70659_70669(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 70659, 70669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_70563_70670(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70563, 70670);
                    return return_v;
                }


                int
                f_127_70547_70671(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70547, 70671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 69431, 70768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 69431, 70768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? OpenManifestStream(CommonMessageProvider messageProvider, OutputKind outputKind, CommandLineArguments arguments, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 70780, 71187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 70967, 71176);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(127, 70974, 70998) || ((f_127_70974_70998(outputKind) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 71018, 71022)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 71042, 71175))) ? null
                : f_127_71042_71175(messageProvider, f_127_71070_71093(arguments), f_127_71095_71118(arguments), f_127_71120_71161(messageProvider), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 70780, 71187);

                bool
                f_127_70974_70998(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 70974, 70998);
                    return return_v;
                }


                string?
                f_127_71070_71093(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.Win32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71070, 71093);
                    return return_v;
                }


                string?
                f_127_71095_71118(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71095, 71118);
                    return return_v;
                }


                int
                f_127_71120_71161(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantOpenWin32Manifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71120, 71161);
                    return return_v;
                }


                System.IO.Stream?
                f_127_71042_71175(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string?
                path, string?
                baseDirectory, int
                errorCode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = OpenStream(messageProvider, path, baseDirectory, errorCode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71042, 71175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 70780, 71187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 70780, 71187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Stream? OpenStream(CommonMessageProvider messageProvider, string? path, string? baseDirectory, int errorCode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 71199, 72003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71375, 71452) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 71375, 71452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71425, 71437);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 71375, 71452);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71468, 71558);

                string?
                fullPath = f_127_71487_71557(messageProvider, path, baseDirectory, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71572, 71653) || true) && (fullPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 71572, 71653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71626, 71638);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 71572, 71653);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71705, 71769);

                    return f_127_71712_71768(fullPath, FileMode.Open, FileAccess.Read);
                }
                catch (Exception ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 71798, 71964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71851, 71949);

                    f_127_71851_71948(diagnostics, f_127_71867_71947(messageProvider, errorCode, f_127_71911_71924(), fullPath, f_127_71936_71946(ex)));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(127, 71798, 71964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 71980, 71992);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 71199, 72003);

                string?
                f_127_71487_71557(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, string
                path, string?
                baseDirectory, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ResolveRelativePath(messageProvider, path, baseDirectory, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71487, 71557);
                    return return_v;
                }


                System.IO.FileStream
                f_127_71712_71768(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71712, 71768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_71911_71924()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71911, 71924);
                    return return_v;
                }


                string
                f_127_71936_71946(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 71936, 71946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_71867_71947(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71867, 71947);
                    return return_v;
                }


                int
                f_127_71851_71948(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 71851, 71948);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 71199, 72003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 71199, 72003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? ResolveRelativePath(CommonMessageProvider messageProvider, string path, string? baseDirectory, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 72015, 72503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72184, 72258);

                string?
                fullPath = f_127_72203_72257(path, baseDirectory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72272, 72460) || true) && (fullPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 72272, 72460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72326, 72445);

                    f_127_72326_72444(diagnostics, f_127_72342_72443(messageProvider, f_127_72375_72415(messageProvider), f_127_72417_72430(), path ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(127, 72432, 72442) ?? "")));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(127, 72272, 72460);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72476, 72492);

                return fullPath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 72015, 72503);

                string?
                f_127_72203_72257(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72203, 72257);
                    return return_v;
                }


                int
                f_127_72375_72415(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.FTL_InvalidInputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72375, 72415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_127_72417_72430()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72417, 72430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_127_72342_72443(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72342, 72443);
                    return return_v;
                }


                int
                f_127_72326_72444(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72326, 72444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 72015, 72503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 72015, 72503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetCompilerDiagnosticCode(string diagnosticId, string expectedPrefix, out uint code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 72515, 72829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72648, 72657);

                code = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 72671, 72818);

                return f_127_72678_72743(diagnosticId, expectedPrefix, StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(127, 72678, 72817) && f_127_72747_72817(f_127_72761_72806(diagnosticId, f_127_72784_72805(expectedPrefix)), out code));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 72515, 72829);

                bool
                f_127_72678_72743(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72678, 72743);
                    return return_v;
                }


                int
                f_127_72784_72805(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 72784, 72805);
                    return return_v;
                }


                string
                f_127_72761_72806(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72761, 72806);
                    return return_v;
                }


                bool
                f_127_72747_72817(string
                s, out uint
                result)
                {
                    var return_v = uint.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 72747, 72817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 72515, 72829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 72515, 72829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual CultureInfo Culture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(127, 73131, 73247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73167, 73232);

                    return f_127_73174_73199(f_127_73174_73183()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Globalization.CultureInfo?>(127, 73174, 73231) ?? f_127_73203_73231());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(127, 73131, 73247);

                    Microsoft.CodeAnalysis.CommandLineArguments
                    f_127_73174_73183()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73174, 73183);
                        return return_v;
                    }


                    System.Globalization.CultureInfo?
                    f_127_73174_73199(Microsoft.CodeAnalysis.CommandLineArguments
                    this_param)
                    {
                        var return_v = this_param.PreferredUILang;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73174, 73199);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_127_73203_73231()
                    {
                        var return_v = CultureInfo.CurrentUICulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73203, 73231);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 73069, 73258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 73069, 73258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static void EmitDeterminismKey(CommandLineArguments args, string[] rawArgs, string baseDirectory, CommandLineParser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 73270, 73799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73426, 73495);

                var
                key = f_127_73436_73494(args, rawArgs, baseDirectory, parser)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73509, 73589);

                var
                filePath = f_127_73524_73588(f_127_73537_73557(args), f_127_73559_73578(args) + ".key")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73603, 73788);
                using (var
                stream = f_127_73623_73644(filePath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73678, 73718);

                    var
                    bytes = f_127_73690_73717(f_127_73690_73703(), key)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 73736, 73773);

                    f_127_73736_73772(stream, bytes, 0, f_127_73759_73771(bytes));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(127, 73603, 73788);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 73270, 73799);

                string
                f_127_73436_73494(Microsoft.CodeAnalysis.CommandLineArguments
                args, string[]
                rawArgs, string
                baseDirectory, Microsoft.CodeAnalysis.CommandLineParser
                parser)
                {
                    var return_v = CreateDeterminismKey(args, rawArgs, baseDirectory, parser);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73436, 73494);
                    return return_v;
                }


                string
                f_127_73537_73557(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73537, 73557);
                    return return_v;
                }


                string?
                f_127_73559_73578(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73559, 73578);
                    return return_v;
                }


                string
                f_127_73524_73588(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73524, 73588);
                    return return_v;
                }


                System.IO.FileStream
                f_127_73623_73644(string
                path)
                {
                    var return_v = File.Create(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73623, 73644);
                    return return_v;
                }


                System.Text.Encoding
                f_127_73690_73703()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73690, 73703);
                    return return_v;
                }


                byte[]
                f_127_73690_73717(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73690, 73717);
                    return return_v;
                }


                int
                f_127_73759_73771(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 73759, 73771);
                    return return_v;
                }


                int
                f_127_73736_73772(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 73736, 73772);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 73270, 73799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 73270, 73799);
            }
        }

        private static string CreateDeterminismKey(CommandLineArguments args, string[] rawArgs, string baseDirectory, CommandLineParser parser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(127, 74329, 76073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74489, 74543);

                List<Diagnostic>
                diagnostics = f_127_74520_74542()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74557, 74605);

                List<string>
                flattenedArgs = f_127_74586_74604()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74619, 74696);

                f_127_74619_74695(parser, rawArgs, diagnostics, flattenedArgs, null, baseDirectory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74712, 74746);

                var
                builder = f_127_74726_74745()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74760, 74970);

                var
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(127, 74771, 74813) || ((!f_127_74772_74813(f_127_74793_74812(args)) && DynAbs.Tracing.TraceSender.Conditional_F2(127, 74833, 74904)) || DynAbs.Tracing.TraceSender.Conditional_F3(127, 74924, 74969))) ? f_127_74833_74904(f_127_74866_74903(f_127_74883_74902(args))) : $"no-output-name-{Guid.NewGuid().ToString()}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 74986, 75016);

                f_127_74986_75015(
                            builder, $"{name}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75030, 75067);

                f_127_75030_75066(builder, $"Command Line:");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75081, 75202);
                    foreach (var current in f_127_75105_75118_I(flattenedArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 75081, 75202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75152, 75187);

                        f_127_75152_75186(builder, $"\t{current}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 75081, 75202);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75218, 75254);

                f_127_75218_75253(
                            builder, "Source Files:");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75268, 75292);

                var
                hash = f_127_75279_75291()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75306, 76020);
                    foreach (var sourceFile in f_127_75333_75349_I(f_127_75333_75349(args)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(127, 75306, 76020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75383, 75438);

                        var
                        sourceFileName = f_127_75404_75437(sourceFile.Path)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75458, 75475);

                        string
                        hashValue
                        = default(string);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75537, 75584);

                            var
                            bytes = f_127_75549_75583(sourceFile.Path)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75606, 75646);

                            var
                            hashBytes = f_127_75622_75645(hash, bytes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75668, 75712);

                            var
                            data = f_127_75679_75711(hashBytes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75734, 75768);

                            hashValue = f_127_75746_75767(data, "-", "");
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(127, 75805, 75931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75866, 75912);

                            hashValue = $"Could not compute {f_127_75899_75909(ex)}";
                            DynAbs.Tracing.TraceSender.TraceExitCatch(127, 75805, 75931);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 75949, 76005);

                        f_127_75949_76004(builder, $"\t{sourceFileName} - {hashValue}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(127, 75306, 76020);
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
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(127, 76036, 76062);

                return f_127_76043_76061(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(127, 74329, 76073);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                f_127_74520_74542()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74520, 74542);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_127_74586_74604()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74586, 74604);
                    return return_v;
                }


                int
                f_127_74619_74695(Microsoft.CodeAnalysis.CommandLineParser
                this_param, string[]
                rawArguments, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.List<string>
                processedArgs, System.Collections.Generic.List<string>?
                scriptArgsOpt, string
                baseDirectory)
                {
                    this_param.FlattenArgs((System.Collections.Generic.IEnumerable<string>)rawArguments, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, processedArgs, scriptArgsOpt, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74619, 74695);
                    return 0;
                }


                System.Text.StringBuilder
                f_127_74726_74745()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74726, 74745);
                    return return_v;
                }


                string?
                f_127_74793_74812(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 74793, 74812);
                    return return_v;
                }


                bool
                f_127_74772_74813(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74772, 74813);
                    return return_v;
                }


                string
                f_127_74883_74902(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.OutputFileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 74883, 74902);
                    return return_v;
                }


                string?
                f_127_74866_74903(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74866, 74903);
                    return return_v;
                }


                string?
                f_127_74833_74904(string
                path)
                {
                    var return_v = Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74833, 74904);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_74986_75015(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 74986, 75015);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75030_75066(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75030, 75066);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75152_75186(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75152, 75186);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_127_75105_75118_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75105, 75118);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75218_75253(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75218, 75253);
                    return return_v;
                }


                System.Security.Cryptography.MD5
                f_127_75279_75291()
                {
                    var return_v = MD5.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75279, 75291);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_75333_75349(Microsoft.CodeAnalysis.CommandLineArguments
                this_param)
                {
                    var return_v = this_param.SourceFiles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 75333, 75349);
                    return return_v;
                }


                string?
                f_127_75404_75437(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75404, 75437);
                    return return_v;
                }


                byte[]
                f_127_75549_75583(string
                path)
                {
                    var return_v = File.ReadAllBytes(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75549, 75583);
                    return return_v;
                }


                byte[]
                f_127_75622_75645(System.Security.Cryptography.MD5
                this_param, byte[]
                buffer)
                {
                    var return_v = this_param.ComputeHash(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75622, 75645);
                    return return_v;
                }


                string
                f_127_75679_75711(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75679, 75711);
                    return return_v;
                }


                string
                f_127_75746_75767(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75746, 75767);
                    return return_v;
                }


                string
                f_127_75899_75909(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(127, 75899, 75909);
                    return return_v;
                }


                System.Text.StringBuilder
                f_127_75949_76004(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75949, 76004);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_127_75333_75349_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 75333, 75349);
                    return return_v;
                }


                string
                f_127_76043_76061(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(127, 76043, 76061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(127, 74329, 76073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(127, 74329, 76073);
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
