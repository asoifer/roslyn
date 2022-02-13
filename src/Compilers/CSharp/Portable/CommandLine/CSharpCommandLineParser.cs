// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    public class CSharpCommandLineParser : CommandLineParser
    {
        public static CSharpCommandLineParser Default { get; }

        public static CSharpCommandLineParser Script { get; }

        private static readonly char[] s_quoteOrEquals;

        internal CSharpCommandLineParser(bool isScriptCommandLineParser = false)
        : base(f_10971_1110_1141_C(CSharp.MessageProvider.Instance), isScriptCommandLineParser)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10971, 1017, 1191);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10971, 1017, 1191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 1017, 1191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 1017, 1191);
            }
        }

        protected override string RegularFileExtension
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 1252, 1273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 1258, 1271);

                    return ".cs";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 1252, 1273);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 1203, 1275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 1203, 1275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override string ScriptFileExtension
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 1333, 1355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 1339, 1353);

                    return ".csx";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 1333, 1355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 1285, 1357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 1285, 1357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CommandLineArguments CommonParse(IEnumerable<string> args, string baseDirectory, string? sdkDirectory, string? additionalReferenceDirectories)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 1369, 1652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 1561, 1641);

                return f_10971_1568_1640(this, args, baseDirectory, sdkDirectory, additionalReferenceDirectories);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 1369, 1652);

                Microsoft.CodeAnalysis.CSharp.CSharpCommandLineArguments
                f_10971_1568_1640(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, System.Collections.Generic.IEnumerable<string>
                args, string
                baseDirectory, string?
                sdkDirectory, string?
                additionalReferenceDirectories)
                {
                    var return_v = this_param.Parse(args, baseDirectory, sdkDirectory, additionalReferenceDirectories);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 1568, 1640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 1369, 1652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 1369, 1652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new CSharpCommandLineArguments Parse(IEnumerable<string> args, string? baseDirectory, string? sdkDirectory, string? additionalReferenceDirectories = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 2284, 72460);
                bool diagnosticAlreadyReported = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2470, 2549);

                f_10971_2470_2548(baseDirectory == null || (DynAbs.Tracing.TraceSender.Expression_False(10971, 2483, 2547) || f_10971_2508_2547(baseDirectory)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2565, 2619);

                List<Diagnostic>
                diagnostics = f_10971_2596_2618()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2633, 2681);

                List<string>
                flattenedArgs = f_10971_2662_2680()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2695, 2776);

                List<string>?
                scriptArgs = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 2722, 2747) || ((IsScriptCommandLineParser && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 2750, 2768)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 2771, 2775))) ? f_10971_2750_2768() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2790, 2874);

                List<string>?
                responsePaths = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 2820, 2845) || ((IsScriptCommandLineParser && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 2848, 2866)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 2869, 2873))) ? f_10971_2848_2866() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2888, 2976);

                f_10971_2888_2975(this, args, diagnostics, flattenedArgs, scriptArgs, baseDirectory, responsePaths);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 2992, 3021);

                string?
                appConfigPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3035, 3059);

                bool
                displayLogo = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3073, 3098);

                bool
                displayHelp = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3112, 3140);

                bool
                displayVersion = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3154, 3187);

                bool
                displayLangVersions = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3201, 3223);

                bool
                optimize = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3237, 3264);

                bool
                checkOverflow = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3278, 3357);

                NullableContextOptions
                nullableContextOptions = NullableContextOptions.Disable
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3371, 3396);

                bool
                allowUnsafe = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3410, 3438);

                bool
                concurrentBuild = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3452, 3479);

                bool
                deterministic = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3545, 3566);

                bool
                emitPdb = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3580, 3727);

                DebugInformationFormat
                debugInformationFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 3628, 3660) || ((f_10971_3628_3660() && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 3663, 3697)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 3700, 3726))) ? DebugInformationFormat.PortablePdb : DebugInformationFormat.Pdb
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3741, 3764);

                bool
                debugPlus = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3778, 3801);

                string?
                pdbPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3815, 3857);

                bool
                noStdLib = IsScriptCommandLineParser
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3927, 3967);

                string?
                outputDirectory = baseDirectory
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 3981, 4087);

                ImmutableArray<KeyValuePair<string, string>>
                pathMap = ImmutableArray<KeyValuePair<string, string>>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4101, 4131);

                string?
                outputFileName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4145, 4178);

                string?
                outputRefFilePath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4192, 4213);

                bool
                refOnly = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4227, 4272);

                string?
                generatedFilesOutputDirectory = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4286, 4319);

                string?
                documentationPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4333, 4373);

                ErrorLogOptions?
                errorLogOptions = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4387, 4427);

                bool
                parseDocumentationComments = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4548, 4572);

                bool
                utf8output = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4586, 4640);

                OutputKind
                outputKind = OutputKind.ConsoleApplication
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4654, 4712);

                SubsystemVersion
                subsystemVersion = SubsystemVersion.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4726, 4784);

                LanguageVersion
                languageVersion = LanguageVersion.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4798, 4826);

                string?
                mainTypeName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4840, 4873);

                string?
                win32ManifestFile = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4887, 4920);

                string?
                win32ResourceFile = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4934, 4963);

                string?
                win32IconFile = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 4977, 5006);

                bool
                noWin32Manifest = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5020, 5056);

                Platform
                platform = Platform.AnyCpu
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5070, 5092);

                ulong
                baseAddress = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5106, 5128);

                int
                fileAlignment = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5142, 5172);

                bool?
                delaySignSetting = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5186, 5216);

                string?
                keyFileSetting = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5230, 5265);

                string?
                keyContainerSetting = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5279, 5356);

                List<ResourceDescription>
                managedResources = f_10971_5324_5355()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5370, 5446);

                List<CommandLineSourceFile>
                sourceFiles = f_10971_5412_5445()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5460, 5540);

                List<CommandLineSourceFile>
                additionalFiles = f_10971_5506_5539()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5554, 5615);

                var
                analyzerConfigPaths = f_10971_5580_5614()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5629, 5707);

                List<CommandLineSourceFile>
                embeddedFiles = f_10971_5673_5706()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5721, 5755);

                bool
                sourceFilesSpecified = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5769, 5802);

                bool
                embedAllSourceFiles = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5816, 5857);

                bool
                resourcesOrModulesSpecified = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5871, 5897);

                Encoding?
                codepage = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 5911, 5988);

                var
                checksumAlgorithm = SourceHashAlgorithmUtils.DefaultContentHashAlgorithm
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6002, 6051);

                var
                defines = f_10971_6016_6050()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6065, 6146);

                List<CommandLineReference>
                metadataReferences = f_10971_6113_6145()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6160, 6248);

                List<CommandLineAnalyzerReference>
                analyzers = f_10971_6207_6247()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6262, 6305);

                List<string>
                libPaths = f_10971_6286_6304()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6319, 6365);

                List<string>
                sourcePaths = f_10971_6346_6364()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6379, 6432);

                List<string>
                keyFileSearchPaths = f_10971_6413_6431()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6446, 6487);

                List<string>
                usings = f_10971_6468_6486()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6501, 6556);

                var
                generalDiagnosticOption = ReportDiagnostic.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6570, 6637);

                var
                diagnosticOptions = f_10971_6594_6636()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6651, 6708);

                var
                noWarns = f_10971_6665_6707()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6722, 6784);

                var
                warnAsErrors = f_10971_6741_6783()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6798, 6848);

                int
                warningLevel = Diagnostic.DefaultWarningLevel
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6862, 6889);

                bool
                highEntropyVA = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6903, 6931);

                bool
                printFullPaths = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6945, 6979);

                string?
                moduleAssemblyName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 6993, 7019);

                string?
                moduleName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7033, 7076);

                List<string>
                features = f_10971_7057_7075()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7090, 7128);

                string?
                runtimeMetadataVersion = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7142, 7172);

                bool
                errorEndLocation = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7186, 7214);

                bool
                reportAnalyzer = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7228, 7255);

                bool
                skipAnalyzers = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7269, 7374);

                ArrayBuilder<InstrumentationKind>
                instrumentationKinds = f_10971_7326_7373()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7388, 7424);

                CultureInfo?
                preferredUILang = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7438, 7470);

                string?
                touchedFilesPath = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7484, 7510);

                bool
                optionsEnded = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7524, 7553);

                bool
                interactiveMode = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7567, 7591);

                bool
                publicSign = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7605, 7631);

                string?
                sourceLink = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7645, 7672);

                string?
                ruleSetPath = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7917, 8879) || true) && (!IsScriptCommandLineParser)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 7917, 8879);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 7981, 8864);
                        foreach (string arg in f_10971_8004_8017_I(flattenedArgs))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 7981, 8864);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8059, 8079);

                            string?
                            name
                            = default(string?),
                            value
                            = default(string?);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8101, 8845) || true) && (f_10971_8105_8145(arg, out name, out value) && (DynAbs.Tracing.TraceSender.Expression_True(10971, 8105, 8168) && (name == "ruleset")))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 8101, 8845);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8218, 8263);

                                var
                                unquoted = f_10971_8233_8262(value)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8291, 8822) || true) && (f_10971_8295_8331(unquoted))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 8291, 8822);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8389, 8465);

                                    f_10971_8389_8464(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 8291, 8822);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 8291, 8822);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8579, 8654);

                                    ruleSetPath = f_10971_8593_8653(this, unquoted, diagnostics, baseDirectory);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8684, 8795);

                                    generalDiagnosticOption = f_10971_8710_8794(this, ruleSetPath, out diagnosticOptions, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 8291, 8822);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 8101, 8845);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 7981, 8864);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 884);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 7917, 8879);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8895, 62050);
                    foreach (string arg in f_10971_8918_8931_I(flattenedArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 8895, 62050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 8965, 9042);

                        f_10971_8965_9041(optionsEnded || (DynAbs.Tracing.TraceSender.Expression_False(10971, 8978, 9040) || !f_10971_8995_9040(arg, "@", StringComparison.Ordinal)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9062, 9082);

                        string?
                        name
                        = default(string?),
                        value
                        = default(string?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9100, 9596) || true) && (optionsEnded || (DynAbs.Tracing.TraceSender.Expression_False(10971, 9104, 9161) || !f_10971_9121_9161(arg, out name, out value)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9100, 9596);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9203, 9394);
                                foreach (var path in f_10971_9224_9274_I(f_10971_9224_9274(this, arg, baseDirectory, diagnostics)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9203, 9394);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9324, 9371);

                                    f_10971_9324_9370(sourceFiles, f_10971_9340_9369(this, path));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9203, 9394);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 192);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 192);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9418, 9544) || true) && (f_10971_9422_9439(sourceFiles) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9418, 9544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9493, 9521);

                                sourceFilesSpecified = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9418, 9544);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9568, 9577);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9100, 9596);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9616, 12294);

                        switch (name)
                        {

                            case "?":
                            case "help":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9739, 9758);

                                displayHelp = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9784, 9793);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "version":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9858, 9880);

                                displayVersion = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9906, 9915);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "langversion":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 9984, 10022);

                                value = f_10971_9992_10021(value);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10048, 11227) || true) && (f_10971_10052_10085(value))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10048, 11227);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10143, 10251);

                                    f_10971_10143_10250(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_10203_10232(MessageID.IDS_Text), "/langversion:");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10048, 11227);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10048, 11227);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10309, 11227) || true) && (f_10971_10313_10360(value, "0", StringComparison.Ordinal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10309, 11227);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10712, 10800);

                                        f_10971_10712_10799(diagnostics, ErrorCode.ERR_LanguageVersionCannotHaveLeadingZeroes, value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10309, 11227);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10309, 11227);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10858, 11227) || true) && (value == "?")
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10858, 11227);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 10932, 10959);

                                            displayLangVersions = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10858, 11227);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 10858, 11227);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11017, 11227) || true) && (!f_10971_11022_11079(value, out languageVersion))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 11017, 11227);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11137, 11200);

                                                f_10971_11137_11199(diagnostics, ErrorCode.ERR_BadCompatMode, value);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 11017, 11227);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10858, 11227);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10309, 11227);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 10048, 11227);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11253, 11262);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "r":
                            case "reference":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11360, 11464);

                                f_10971_11360_11463(metadataReferences, f_10971_11388_11462(arg, value, diagnostics, embedInteropTypes: false));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11490, 11499);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "features":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11565, 11818) || true) && (value == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 11565, 11818);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11640, 11657);

                                    f_10971_11640_11656(features);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 11565, 11818);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 11565, 11818);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11771, 11791);

                                    f_10971_11771_11790(features, value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 11565, 11818);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11844, 11853);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "lib":
                            case "libpath":
                            case "libpaths":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 11989, 12096);

                                f_10971_11989_12095(name, value, baseDirectory, libPaths, MessageID.IDS_LIB_OPTION, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12122, 12131);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);

                            case "attachdebugger":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 9616, 12294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12214, 12232);

                                f_10971_12214_12231();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12258, 12267);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 9616, 12294);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12314, 61958) || true) && (IsScriptCommandLineParser)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12314, 61958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12385, 14468);

                            switch (name)
                            {

                                case "-": // csi -- script.csx
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12385, 14468);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12507, 12532) || true) && (value != null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12507, 12532);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 12526, 12532);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12507, 12532);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12562, 13247) || true) && (arg == "-")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12562, 13247);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12642, 13173) || true) && (f_10971_12646_12671())
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12642, 13173);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12745, 12834);

                                            f_10971_12745_12833(sourceFiles, f_10971_12761_12832("-", isScript: true, isInputRedirected: true));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 12872, 12900);

                                            sourceFilesSpecified = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12642, 13173);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12642, 13173);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13046, 13138);

                                            f_10971_13046_13137(diagnostics, ErrorCode.ERR_StdInOptionProvidedButConsoleInputIsNotRedirected);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12642, 13173);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13207, 13216);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12562, 13247);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13384, 13404);

                                    optionsEnded = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13434, 13443);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12385, 14468);

                                case "i":
                                case "i+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12385, 14468);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13546, 13571) || true) && (value != null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 13546, 13571);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 13565, 13571);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 13546, 13571);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13601, 13624);

                                    interactiveMode = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13654, 13663);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12385, 14468);

                                case "i-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12385, 14468);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13731, 13756) || true) && (value != null)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 13731, 13756);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 13750, 13756);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 13731, 13756);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13786, 13810);

                                    interactiveMode = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13840, 13849);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12385, 14468);

                                case "loadpath":
                                case "loadpaths":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12385, 14468);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 13966, 14086);

                                    f_10971_13966_14085(name, value, baseDirectory, sourcePaths, MessageID.IDS_REFERENCEPATH_OPTION, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14116, 14125);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12385, 14468);

                                case "u":
                                case "using":
                                case "usings":
                                case "import":
                                case "imports":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12385, 14468);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14352, 14406);

                                    f_10971_14352_14405(usings, f_10971_14368_14404(arg, value, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14436, 14445);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12385, 14468);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12314, 61958);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 12314, 61958);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14550, 61939);

                            switch (name)
                            {

                                case "a":
                                case "analyzer":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14693, 14753);

                                    f_10971_14693_14752(analyzers, f_10971_14712_14751(arg, value, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14783, 14792);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "d":
                                case "define":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 14899, 15151) || true) && (f_10971_14903_14936(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14899, 15151);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15002, 15077);

                                        f_10971_15002_15076(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", arg);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15111, 15120);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14899, 15151);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15183, 15225);

                                    IEnumerable<Diagnostic>
                                    defineDiagnostics
                                    = default(IEnumerable<Diagnostic>);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15255, 15362);

                                    f_10971_15255_15361(defines, f_10971_15272_15360(f_10971_15307_15336(value), out defineDiagnostics));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15392, 15432);

                                    f_10971_15392_15431(diagnostics, defineDiagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15462, 15471);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "codepage":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15545, 15583);

                                    value = f_10971_15553_15582(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15613, 15846) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 15613, 15846);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15696, 15772);

                                        f_10971_15696_15771(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15806, 15815);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 15613, 15846);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15878, 15921);

                                    var
                                    encoding = f_10971_15893_15920(value)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 15951, 16172) || true) && (encoding == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 15951, 16172);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16037, 16098);

                                        f_10971_16037_16097(diagnostics, ErrorCode.FTL_BadCodepage, value);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16132, 16141);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 15951, 16172);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16204, 16224);

                                    codepage = encoding;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16254, 16263);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "checksumalgorithm":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16346, 16599) || true) && (f_10971_16350_16383(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 16346, 16599);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16449, 16525);

                                        f_10971_16449_16524(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16559, 16568);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 16346, 16599);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16631, 16691);

                                    var
                                    newChecksumAlgorithm = f_10971_16658_16690(value)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16721, 16983) || true) && (newChecksumAlgorithm == SourceHashAlgorithm.None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 16721, 16983);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16839, 16909);

                                        f_10971_16839_16908(diagnostics, ErrorCode.FTL_BadChecksumAlgorithm, value);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 16943, 16952);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 16721, 16983);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17015, 17056);

                                    checksumAlgorithm = newChecksumAlgorithm;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17086, 17095);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "checked":
                                case "checked+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17210, 17330) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 17210, 17330);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 17293, 17299);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 17210, 17330);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17362, 17383);

                                    checkOverflow = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17413, 17422);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "checked-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17496, 17554) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 17496, 17554);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 17548, 17554);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 17496, 17554);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17586, 17608);

                                    checkOverflow = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17638, 17647);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nullable":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17723, 17761);

                                    value = f_10971_17731_17760(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17791, 20063) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 17791, 20063);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17874, 18146) || true) && (f_10971_17878_17893(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 17874, 18146);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 17967, 18064);

                                            f_10971_17967_18063(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_18027_18056(MessageID.IDS_Text), name);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18102, 18111);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 17874, 18146);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18182, 18220);

                                        string
                                        loweredValue = f_10971_18204_18219(value)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18254, 19847);

                                        switch (loweredValue)
                                        {

                                            case "disable":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 18254, 19847);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18405, 18484);

                                                f_10971_18405_18483(loweredValue == f_10971_18434_18482(nameof(NullableContextOptions.Disable)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18526, 18582);

                                                nullableContextOptions = NullableContextOptions.Disable;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 18624, 18630);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 18254, 19847);

                                            case "enable":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 18254, 19847);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18724, 18802);

                                                f_10971_18724_18801(loweredValue == f_10971_18753_18800(nameof(NullableContextOptions.Enable)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 18844, 18899);

                                                nullableContextOptions = NullableContextOptions.Enable;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 18941, 18947);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 18254, 19847);

                                            case "warnings":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 18254, 19847);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19043, 19123);

                                                f_10971_19043_19122(loweredValue == f_10971_19072_19121(nameof(NullableContextOptions.Warnings)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19165, 19222);

                                                nullableContextOptions = NullableContextOptions.Warnings;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 19264, 19270);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 18254, 19847);

                                            case "annotations":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 18254, 19847);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19369, 19452);

                                                f_10971_19369_19451(loweredValue == f_10971_19398_19450(nameof(NullableContextOptions.Annotations)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19494, 19554);

                                                nullableContextOptions = NullableContextOptions.Annotations;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 19596, 19602);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 18254, 19847);

                                            default:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 18254, 19847);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19690, 19764);

                                                f_10971_19690_19763(diagnostics, ErrorCode.ERR_BadNullableContextOption, value);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 19806, 19812);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 18254, 19847);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 17791, 20063);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 17791, 20063);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 19977, 20032);

                                        nullableContextOptions = NullableContextOptions.Enable;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 17791, 20063);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20093, 20102);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nullable+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20179, 20299) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 20179, 20299);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 20262, 20268);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 20179, 20299);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20331, 20386);

                                    nullableContextOptions = NullableContextOptions.Enable;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20416, 20425);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nullable-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20500, 20558) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 20500, 20558);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 20552, 20558);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 20500, 20558);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20590, 20646);

                                    nullableContextOptions = NullableContextOptions.Disable;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20676, 20685);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "instrument":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20761, 20799);

                                    value = f_10971_20769_20798(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20829, 21597) || true) && (f_10971_20833_20866(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 20829, 21597);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 20932, 21008);

                                        f_10971_20932_21007(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 20829, 21597);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 20829, 21597);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 21138, 21566);
                                            foreach (InstrumentationKind instrumentationKind in f_10971_21190_21235_I(f_10971_21190_21235(value, diagnostics)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 21138, 21566);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 21309, 21531) || true) && (!f_10971_21314_21364(instrumentationKinds, instrumentationKind))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 21309, 21531);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 21446, 21492);

                                                    f_10971_21446_21491(instrumentationKinds, instrumentationKind);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 21309, 21531);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 21138, 21566);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 429);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 429);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 20829, 21597);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 21629, 21638);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "noconfig":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 21802, 21811);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "sqmsessionguid":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22072, 22688) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 22072, 22688);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22155, 22234);

                                        f_10971_22155_22233(diagnostics, ErrorCode.ERR_MissingGuidForOption, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 22072, 22688);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 22072, 22688);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22364, 22384);

                                        Guid
                                        sqmSessionGuid
                                        = default(Guid);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22418, 22657) || true) && (!Guid.TryParse(value, out sqmSessionGuid))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 22418, 22657);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22537, 22622);

                                            f_10971_22537_22621(diagnostics, ErrorCode.ERR_InvalidFormatForGuidForOption, value, name);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 22418, 22657);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 22072, 22688);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22718, 22727);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "preferreduilang":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22808, 22846);

                                    value = f_10971_22816_22845(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22878, 23130) || true) && (f_10971_22882_22915(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 22878, 23130);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 22981, 23056);

                                        f_10971_22981_23055(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", arg);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23090, 23099);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 22878, 23130);
                                    }

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23230, 23271);

                                        preferredUILang = f_10971_23248_23270(value);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23305, 23582) || true) && ((f_10971_23310_23338(preferredUILang) & CultureTypes.UserCustomCulture) != 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 23305, 23582);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23524, 23547);

                                            preferredUILang = null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 23305, 23582);
                                        }
                                    }
                                    catch (CultureNotFoundException)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10971, 23643, 23737);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(10971, 23643, 23737);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23769, 23952) || true) && (preferredUILang == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 23769, 23952);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23862, 23921);

                                        f_10971_23862_23920(diagnostics, ErrorCode.WRN_BadUILang, value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 23769, 23952);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 23984, 23993);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nosdkpath":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24068, 24088);

                                    sdkDirectory = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24120, 24129);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "out":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24198, 24617) || true) && (f_10971_24202_24240(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 24198, 24617);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24306, 24364);

                                        f_10971_24306_24363(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 24198, 24617);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 24198, 24617);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24494, 24586);

                                        f_10971_24494_24585(this, value, diagnostics, baseDirectory, out outputFileName, out outputDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 24198, 24617);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24649, 24658);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "refout":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24730, 24768);

                                    value = f_10971_24738_24767(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24798, 25198) || true) && (f_10971_24802_24835(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 24798, 25198);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 24901, 24959);

                                        f_10971_24901_24958(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 24798, 25198);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 24798, 25198);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25089, 25167);

                                        outputRefFilePath = f_10971_25109_25166(this, value, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 24798, 25198);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25230, 25239);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "refonly":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25312, 25370) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 25312, 25370);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 25364, 25370);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 25312, 25370);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25402, 25417);

                                    refOnly = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25447, 25456);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "t":
                                case "target":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25563, 25714) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 25563, 25714);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 25646, 25652);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 25563, 25714);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25746, 26111) || true) && (f_10971_25750_25783(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 25746, 26111);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 25849, 25905);

                                        f_10971_25849_25904(diagnostics, ErrorCode.FTL_InvalidTarget);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 25746, 26111);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 25746, 26111);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26035, 26080);

                                        outputKind = f_10971_26048_26079(value, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 25746, 26111);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26143, 26152);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "moduleassemblyname":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26236, 26283);

                                    value = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 26244, 26257) || ((value != null && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 26260, 26275)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 26278, 26282))) ? f_10971_26260_26275(value) : null;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26315, 27023) || true) && (f_10971_26319_26352(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 26315, 27023);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26418, 26493);

                                        f_10971_26418_26492(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 26315, 27023);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 26315, 27023);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26559, 27023) || true) && (!f_10971_26564_26614(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 26559, 27023);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26758, 26835);

                                            f_10971_26758_26834(diagnostics, ErrorCode.ERR_InvalidAssemblyName, "<text>", arg);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 26559, 27023);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 26559, 27023);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 26965, 26992);

                                            moduleAssemblyName = value;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 26559, 27023);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 26315, 27023);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27055, 27064);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "modulename":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27140, 27195);

                                    var
                                    unquotedModuleName = f_10971_27165_27194(value)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27225, 27676) || true) && (f_10971_27229_27269(unquotedModuleName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 27225, 27676);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27335, 27440);

                                        f_10971_27335_27439(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_27395_27424(MessageID.IDS_Text), "modulename");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27474, 27483);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 27225, 27676);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 27225, 27676);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27613, 27645);

                                        moduleName = unquotedModuleName;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 27225, 27676);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27708, 27717);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "platform":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27791, 27829);

                                    value = f_10971_27799_27828(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27859, 28245) || true) && (f_10971_27863_27896(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 27859, 28245);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 27962, 28039);

                                        f_10971_27962_28038(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<string>", arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 27859, 28245);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 27859, 28245);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28169, 28214);

                                        platform = f_10971_28180_28213(value, diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 27859, 28245);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28275, 28284);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "recurse":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28357, 28395);

                                    value = f_10971_28365_28394(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28427, 29279) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 28427, 29279);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 28510, 28516);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 28427, 29279);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 28427, 29279);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28613, 29279) || true) && (f_10971_28617_28650(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 28613, 29279);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28716, 28774);

                                            f_10971_28716_28773(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 28613, 29279);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 28613, 29279);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28904, 28935);

                                            int
                                            before = f_10971_28917_28934(sourceFiles)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 28969, 29047);

                                            f_10971_28969_29046(sourceFiles, f_10971_28990_29045(this, value, baseDirectory, diagnostics));

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29081, 29248) || true) && (f_10971_29085_29102(sourceFiles) > before)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 29081, 29248);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29185, 29213);

                                                sourceFilesSpecified = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 29081, 29248);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 28613, 29279);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 28427, 29279);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29309, 29318);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "generatedfilesout":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29401, 29439);

                                    value = f_10971_29409_29438(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29469, 29918) || true) && (f_10971_29473_29505(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 29469, 29918);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29571, 29667);

                                        f_10971_29571_29666(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_29631_29660(MessageID.IDS_Text), arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 29469, 29918);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 29469, 29918);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29797, 29887);

                                        generatedFilesOutputDirectory = f_10971_29829_29886(this, value, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 29469, 29918);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 29948, 29957);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "doc":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30026, 30060);

                                    parseDocumentationComments = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30090, 30363) || true) && (f_10971_30094_30127(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 30090, 30363);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30193, 30289);

                                        f_10971_30193_30288(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_30253_30282(MessageID.IDS_Text), arg);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30323, 30332);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 30090, 30363);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30393, 30442);

                                    string?
                                    unquoted = f_10971_30412_30441(value)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30472, 31165) || true) && (f_10971_30476_30512(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 30472, 31165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 30800, 30900);

                                        f_10971_30800_30899(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_30860_30889(MessageID.IDS_Text), "/doc:");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 30472, 31165);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 30472, 31165);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31053, 31134);

                                        documentationPath = f_10971_31073_31133(this, unquoted, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 30472, 31165);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31195, 31204);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "addmodule":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31279, 32438) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 31279, 32438);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31362, 31468);

                                        f_10971_31362_31467(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_31422_31451(MessageID.IDS_Text), "/addmodule:");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 31279, 32438);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 31279, 32438);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31534, 32438) || true) && (f_10971_31538_31565(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 31534, 32438);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 31631, 31689);

                                            f_10971_31631_31688(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 31534, 32438);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 31534, 32438);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32199, 32338);

                                            f_10971_32199_32337(                                // NOTE(tomat): Dev10 used to report CS1541: ERR_CantIncludeDirectory if the path was a directory.
                                                                                                // Since we now support /referencePaths option we would need to search them to see if the resolved path is a directory.
                                                                                                // An error will be reported by the assembly manager anyways.
                                                                            metadataReferences, f_10971_32227_32336(f_10971_32227_32253(value), path => new CommandLineReference(path, MetadataReferenceProperties.Module)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32372, 32407);

                                            resourcesOrModulesSpecified = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 31534, 32438);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 31279, 32438);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32468, 32477);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "l":
                                case "link":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32582, 32685);

                                    f_10971_32582_32684(metadataReferences, f_10971_32610_32683(arg, value, diagnostics, embedInteropTypes: true));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32715, 32724);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "win32res":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32798, 32859);

                                    win32ResourceFile = f_10971_32818_32858(arg, value, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32889, 32898);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "win32icon":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 32973, 33030);

                                    win32IconFile = f_10971_32989_33029(arg, value, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33060, 33069);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "win32manifest":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33148, 33209);

                                    win32ManifestFile = f_10971_33168_33208(arg, value, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33239, 33263);

                                    noWin32Manifest = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33293, 33302);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nowin32manifest":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33383, 33406);

                                    noWin32Manifest = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33436, 33461);

                                    win32ManifestFile = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33491, 33500);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "res":
                                case "resource":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33611, 33768) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 33611, 33768);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 33694, 33700);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 33611, 33768);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33800, 33904);

                                    var
                                    embeddedResource = f_10971_33823_33903(arg, value, baseDirectory, diagnostics, embedded: true)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 33934, 34167) || true) && (embeddedResource != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 33934, 34167);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34028, 34067);

                                        f_10971_34028_34066(managedResources, embeddedResource);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34101, 34136);

                                        resourcesOrModulesSpecified = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 33934, 34167);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34199, 34208);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "linkres":
                                case "linkresource":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34327, 34484) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 34327, 34484);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 34410, 34416);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 34327, 34484);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34516, 34619);

                                    var
                                    linkedResource = f_10971_34537_34618(arg, value, baseDirectory, diagnostics, embedded: false)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34649, 34878) || true) && (linkedResource != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 34649, 34878);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34741, 34778);

                                        f_10971_34741_34777(managedResources, linkedResource);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34812, 34847);

                                        resourcesOrModulesSpecified = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 34649, 34878);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34910, 34919);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "sourcelink":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 34995, 35033);

                                    value = f_10971_35003_35032(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35063, 35456) || true) && (f_10971_35067_35100(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 35063, 35456);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35166, 35224);

                                        f_10971_35166_35223(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 35063, 35456);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 35063, 35456);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35354, 35425);

                                        sourceLink = f_10971_35367_35424(this, value, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 35063, 35456);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35486, 35495);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "debug":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35566, 35581);

                                    emitPdb = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35685, 35723);

                                    value = f_10971_35693_35722(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35753, 37187) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 35753, 37187);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35836, 36108) || true) && (f_10971_35840_35855(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 35836, 36108);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 35929, 36026);

                                            f_10971_35929_36025(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_35989_36018(MessageID.IDS_Text), name);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 36064, 36073);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 35836, 36108);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 36142, 37156);

                                        switch (f_10971_36150_36165(value))
                                        {

                                            case "full":
                                            case "pdbonly":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 36142, 37156);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 36346, 36470);

                                                debugInformationFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 36371, 36403) || ((f_10971_36371_36403() && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 36406, 36440)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 36443, 36469))) ? DebugInformationFormat.PortablePdb : DebugInformationFormat.Pdb;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 36512, 36518);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 36142, 37156);

                                            case "portable":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 36142, 37156);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 36614, 36674);

                                                debugInformationFormat = DebugInformationFormat.PortablePdb;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 36716, 36722);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 36142, 37156);

                                            case "embedded":
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 36142, 37156);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 36818, 36875);

                                                debugInformationFormat = DebugInformationFormat.Embedded;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 36917, 36923);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 36142, 37156);

                                            default:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 36142, 37156);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37011, 37073);

                                                f_10971_37011_37072(diagnostics, ErrorCode.ERR_BadDebugType, value);
                                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 37115, 37121);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 36142, 37156);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 35753, 37187);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37217, 37226);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "debug+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37355, 37413) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 37355, 37413);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 37407, 37413);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 37355, 37413);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37445, 37460);

                                    emitPdb = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37490, 37507);

                                    debugPlus = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37537, 37546);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "debug-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37618, 37676) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 37618, 37676);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 37670, 37676);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 37618, 37676);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37708, 37724);

                                    emitPdb = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37754, 37772);

                                    debugPlus = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37802, 37811);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "o":
                                case "optimize":
                                case "o+":
                                case "optimize+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 37999, 38057) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 37999, 38057);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 38051, 38057);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 37999, 38057);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38089, 38105);

                                    optimize = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38135, 38144);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "o-":
                                case "optimize-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38255, 38313) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 38255, 38313);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 38307, 38313);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 38255, 38313);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38345, 38362);

                                    optimize = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38392, 38401);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "deterministic":
                                case "deterministic+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38528, 38586) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 38528, 38586);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 38580, 38586);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 38528, 38586);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38618, 38639);

                                    deterministic = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38669, 38678);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "deterministic-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38758, 38816) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 38758, 38816);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 38810, 38816);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 38758, 38816);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38846, 38868);

                                    deterministic = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 38898, 38907);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "p":
                                case "parallel":
                                case "p+":
                                case "parallel+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39095, 39153) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 39095, 39153);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 39147, 39153);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 39095, 39153);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39185, 39208);

                                    concurrentBuild = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39238, 39247);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "p-":
                                case "parallel-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39358, 39416) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 39358, 39416);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 39410, 39416);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 39358, 39416);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39448, 39472);

                                    concurrentBuild = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39502, 39511);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "warnaserror":
                                case "warnaserror+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39634, 40499) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 39634, 40499);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 39717, 39766);

                                        generalDiagnosticOption = ReportDiagnostic.Error;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40002, 40023);

                                        f_10971_40002_40022(
                                                                        // Reset specific warnaserror options (since last /warnaserror flag on the command line always wins),
                                                                        // and bump warnings to errors.
                                                                        warnAsErrors);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40057, 40423);
                                            foreach (var key in f_10971_40077_40099_I(f_10971_40077_40099(diagnosticOptions)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 40057, 40423);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40173, 40388) || true) && (f_10971_40177_40199(diagnosticOptions, key) == ReportDiagnostic.Warn)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 40173, 40388);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40306, 40349);

                                                    warnAsErrors[key] = ReportDiagnostic.Error;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 40173, 40388);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 40057, 40423);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 367);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 367);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40459, 40468);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 39634, 40499);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40531, 40927) || true) && (f_10971_40535_40562(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 40531, 40927);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40628, 40694);

                                        f_10971_40628_40693(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 40531, 40927);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 40531, 40927);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40824, 40896);

                                        f_10971_40824_40895(warnAsErrors, ReportDiagnostic.Error, f_10971_40874_40894(value));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 40531, 40927);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 40957, 40966);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "warnaserror-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41044, 41446) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41044, 41446);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41127, 41178);

                                        generalDiagnosticOption = ReportDiagnostic.Default;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41349, 41370);

                                        f_10971_41349_41369(
                                                                        // Clear specific warnaserror options (since last /warnaserror flag on the command line always wins).
                                                                        warnAsErrors);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41406, 41415);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41044, 41446);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41478, 42432) || true) && (f_10971_41482_41509(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41478, 42432);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41575, 41641);

                                        f_10971_41575_41640(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41478, 42432);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41478, 42432);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41771, 42401);
                                            foreach (var id in f_10971_41790_41810_I(f_10971_41790_41810(value)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41771, 42401);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41884, 41914);

                                                ReportDiagnostic
                                                ruleSetValue
                                                = default(ReportDiagnostic);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 41952, 42366) || true) && (f_10971_41956_42007(diagnosticOptions, id, out ruleSetValue))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41952, 42366);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42089, 42121);

                                                    warnAsErrors[id] = ruleSetValue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41952, 42366);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 41952, 42366);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42283, 42327);

                                                    warnAsErrors[id] = ReportDiagnostic.Default;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41952, 42366);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41771, 42401);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 631);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 631);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 41478, 42432);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42462, 42471);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "w":
                                case "warn":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42576, 42614);

                                    value = f_10971_42584_42613(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42644, 42867) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 42644, 42867);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42727, 42793);

                                        f_10971_42727_42792(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42827, 42836);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 42644, 42867);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42899, 42919);

                                    int
                                    newWarningLevel
                                    = default(int);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 42949, 43653) || true) && (f_10971_42953_42980(value) || (DynAbs.Tracing.TraceSender.Expression_False(10971, 42953, 43110) || !f_10971_43018_43110(value, NumberStyles.Integer, f_10971_43060_43088(), out newWarningLevel)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 42949, 43653);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43176, 43242);

                                        f_10971_43176_43241(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 42949, 43653);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 42949, 43653);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43308, 43653) || true) && (newWarningLevel < 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 43308, 43653);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43397, 43461);

                                            f_10971_43397_43460(diagnostics, ErrorCode.ERR_BadWarningLevel, name);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 43308, 43653);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 43308, 43653);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43591, 43622);

                                            warningLevel = newWarningLevel;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 43308, 43653);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 42949, 43653);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43683, 43692);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nowarn":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43764, 43987) || true) && (value == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 43764, 43987);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43847, 43913);

                                        f_10971_43847_43912(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 43947, 43956);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 43764, 43987);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44019, 44413) || true) && (f_10971_44023_44050(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 44019, 44413);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44116, 44182);

                                        f_10971_44116_44181(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 44019, 44413);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 44019, 44413);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44312, 44382);

                                        f_10971_44312_44381(noWarns, ReportDiagnostic.Suppress, f_10971_44360_44380(value));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 44019, 44413);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44443, 44452);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "unsafe":
                                case "unsafe+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44565, 44623) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 44565, 44623);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 44617, 44623);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 44565, 44623);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44655, 44674);

                                    allowUnsafe = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44704, 44713);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "unsafe-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44786, 44844) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 44786, 44844);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 44838, 44844);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 44786, 44844);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44876, 44896);

                                    allowUnsafe = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 44926, 44935);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "delaysign":
                                case "delaysign+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45054, 45174) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 45054, 45174);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 45137, 45143);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 45054, 45174);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45206, 45230);

                                    delaySignSetting = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45260, 45269);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "delaysign-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45345, 45465) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 45345, 45465);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 45428, 45434);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 45345, 45465);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45497, 45522);

                                    delaySignSetting = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45552, 45561);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "publicsign":
                                case "publicsign+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45682, 45802) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 45682, 45802);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 45765, 45771);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 45682, 45802);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45834, 45852);

                                    publicSign = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45882, 45891);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "publicsign-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 45968, 46088) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 45968, 46088);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 46051, 46057);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 45968, 46088);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46120, 46139);

                                    publicSign = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46169, 46178);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "keyfile":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46251, 46289);

                                    value = f_10971_46259_46288(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46319, 46664) || true) && (f_10971_46323_46350(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 46319, 46664);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46416, 46480);

                                        f_10971_46416_46479(diagnostics, ErrorCode.ERR_NoFileSpec, "keyfile");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 46319, 46664);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 46319, 46664);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 46610, 46633);

                                        keyFileSetting = value;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 46319, 46664);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 47674, 47683);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "keycontainer":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 47761, 48154) || true) && (f_10971_47765_47792(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 47761, 48154);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 47858, 47965);

                                        f_10971_47858_47964(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_47918_47947(MessageID.IDS_Text), "keycontainer");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 47761, 48154);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 47761, 48154);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 48095, 48123);

                                        keyContainerSetting = value;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 47761, 48154);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49159, 49168);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "highentropyva":
                                case "highentropyva+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49295, 49353) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 49295, 49353);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 49347, 49353);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 49295, 49353);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49385, 49406);

                                    highEntropyVA = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49436, 49445);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "highentropyva-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49525, 49583) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 49525, 49583);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 49577, 49583);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 49525, 49583);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49615, 49637);

                                    highEntropyVA = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49667, 49676);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nologo":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49748, 49768);

                                    displayLogo = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49798, 49807);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "baseaddress":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49884, 49922);

                                    value = f_10971_49892_49921(value);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 49954, 49975);

                                    ulong
                                    newBaseAddress
                                    = default(ulong);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50005, 50759) || true) && (f_10971_50009_50036(value) || (DynAbs.Tracing.TraceSender.Expression_False(10971, 50009, 50082) || !f_10971_50041_50082(value, out newBaseAddress)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 50005, 50759);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50148, 50569) || true) && (f_10971_50152_50185(value))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 50148, 50569);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50259, 50325);

                                            f_10971_50259_50324(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 50148, 50569);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 50148, 50569);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50471, 50534);

                                            f_10971_50471_50533(diagnostics, ErrorCode.ERR_BadBaseNumber, value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 50148, 50569);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 50005, 50759);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 50005, 50759);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50699, 50728);

                                        baseAddress = newBaseAddress;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 50005, 50759);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50791, 50800);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "subsystemversion":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50882, 51170) || true) && (f_10971_50886_50919(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 50882, 51170);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 50985, 51096);

                                        f_10971_50985_51095(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_51045_51074(MessageID.IDS_Text), "subsystemversion");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51130, 51139);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 50882, 51170);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51322, 51371);

                                    SubsystemVersion
                                    version = SubsystemVersion.None
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51401, 51777) || true) && (SubsystemVersion.TryParse(value, out version))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 51401, 51777);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51516, 51543);

                                        subsystemVersion = version;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 51401, 51777);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 51401, 51777);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51673, 51746);

                                        f_10971_51673_51745(diagnostics, ErrorCode.ERR_InvalidSubsystemVersion, value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 51401, 51777);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51809, 51818);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "touchedfiles":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51896, 51937);

                                    unquoted = f_10971_51907_51936(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 51967, 52406) || true) && (f_10971_51971_52001(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 51967, 52406);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52067, 52174);

                                        f_10971_52067_52173(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_52127_52156(MessageID.IDS_Text), "touchedfiles");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52208, 52217);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 51967, 52406);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 51967, 52406);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52347, 52375);

                                        touchedFilesPath = unquoted;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 51967, 52406);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52438, 52447);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "bugreport":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52522, 52561);

                                    f_10971_52522_52560(diagnostics, name);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52591, 52600);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "utf8output":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52676, 52734) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 52676, 52734);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 52728, 52734);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 52676, 52734);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52766, 52784);

                                    utf8output = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 52814, 52823);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "m":
                                case "main":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53086, 53127);

                                    unquoted = f_10971_53097_53126(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53157, 53407) || true) && (f_10971_53161_53191(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 53157, 53407);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53257, 53333);

                                        f_10971_53257_53332(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53367, 53376);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 53157, 53407);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53439, 53463);

                                    mainTypeName = unquoted;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53493, 53502);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "fullpaths":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53577, 53635) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 53577, 53635);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 53629, 53635);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 53577, 53635);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53667, 53689);

                                    printFullPaths = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53719, 53728);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "pathmap":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    // "/pathmap:K1=V1,K2=V2..."
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53894, 53935);

                                        unquoted = f_10971_53905_53934(value);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 53971, 54106) || true) && (unquoted == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 53971, 54106);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10971, 54065, 54071);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 53971, 54106);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54142, 54204);

                                        pathMap = pathMap.Concat(f_10971_54167_54202(this, unquoted, diagnostics));
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54265, 54274);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "filealign":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54349, 54387);

                                    value = f_10971_54357_54386(value);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54419, 54439);

                                    ushort
                                    newAlignment
                                    = default(ushort);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54469, 55334) || true) && (f_10971_54473_54506(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54469, 55334);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54572, 54638);

                                        f_10971_54572_54637(diagnostics, ErrorCode.ERR_SwitchNeedsNumber, name);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54469, 55334);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54469, 55334);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54704, 55334) || true) && (!f_10971_54709_54748(value, out newAlignment))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54704, 55334);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54814, 54884);

                                            f_10971_54814_54883(diagnostics, ErrorCode.ERR_InvalidFileAlignment, value);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54704, 55334);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54704, 55334);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 54950, 55334) || true) && (!f_10971_54955_55008(newAlignment))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54950, 55334);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55074, 55144);

                                                f_10971_55074_55143(diagnostics, ErrorCode.ERR_InvalidFileAlignment, value);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54950, 55334);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 54950, 55334);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55274, 55303);

                                                fileAlignment = newAlignment;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54950, 55334);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54704, 55334);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 54469, 55334);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55364, 55373);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "pdb":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55442, 55480);

                                    value = f_10971_55450_55479(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55510, 55890) || true) && (f_10971_55514_55547(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 55510, 55890);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55613, 55671);

                                        f_10971_55613_55670(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 55510, 55890);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 55510, 55890);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55801, 55859);

                                        pdbPath = f_10971_55811_55858(this, value, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 55510, 55890);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 55920, 55929);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "errorendlocation":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56011, 56035);

                                    errorEndLocation = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56065, 56074);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "reportanalyzer":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56154, 56176);

                                    reportAnalyzer = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56206, 56215);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "skipanalyzers":
                                case "skipanalyzers+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56342, 56400) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 56342, 56400);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 56394, 56400);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 56342, 56400);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56432, 56453);

                                    skipAnalyzers = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56483, 56492);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "skipanalyzers-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56572, 56630) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 56572, 56630);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 56624, 56630);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 56572, 56630);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56662, 56684);

                                    skipAnalyzers = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56714, 56723);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nostdlib":
                                case "nostdlib+":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56840, 56898) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 56840, 56898);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 56892, 56898);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 56840, 56898);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56930, 56946);

                                    noStdLib = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 56976, 56985);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "nostdlib-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57060, 57118) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 57060, 57118);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10971, 57112, 57118);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 57060, 57118);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57150, 57167);

                                    noStdLib = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57197, 57206);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "errorreport":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57283, 57292);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "errorlog":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57366, 57407);

                                    unquoted = f_10971_57377_57406(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57437, 58231) || true) && (f_10971_57441_57477(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 57437, 58231);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57543, 57654);

                                        f_10971_57543_57653(diagnostics, ErrorCode.ERR_SwitchNeedsString, ErrorLogOptionFormat, f_10971_57625_57652(arg));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 57437, 58231);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 57437, 58231);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57784, 57897);

                                        errorLogOptions = f_10971_57802_57896(this, unquoted, diagnostics, baseDirectory, out diagnosticAlreadyReported);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 57931, 58200) || true) && (errorLogOptions == null && (DynAbs.Tracing.TraceSender.Expression_True(10971, 57935, 57988) && !diagnosticAlreadyReported))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 57931, 58200);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58062, 58165);

                                            f_10971_58062_58164(diagnostics, ErrorCode.ERR_BadSwitchValue, unquoted, "/errorlog:", ErrorLogOptionFormat);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 57931, 58200);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 57437, 58231);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58261, 58270);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "appconfig":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58345, 58386);

                                    unquoted = f_10971_58356_58385(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58416, 58860) || true) && (f_10971_58420_58456(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 58416, 58860);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58522, 58622);

                                        f_10971_58522_58621(diagnostics, ErrorCode.ERR_SwitchNeedsString, ":<text>", f_10971_58593_58620(arg));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 58416, 58860);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 58416, 58860);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58752, 58829);

                                        appConfigPath = f_10971_58768_58828(this, unquoted, diagnostics, baseDirectory);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 58416, 58860);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58890, 58899);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "runtimemetadataversion":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 58987, 59028);

                                    unquoted = f_10971_58998_59027(value);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59058, 59308) || true) && (f_10971_59062_59092(unquoted))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 59058, 59308);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59158, 59234);

                                        f_10971_59158_59233(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<text>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59268, 59277);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 59058, 59308);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59340, 59374);

                                    runtimeMetadataVersion = unquoted;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59404, 59413);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "ruleset":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59587, 59596);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "additionalfile":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59676, 59934) || true) && (f_10971_59680_59713(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 59676, 59934);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59779, 59860);

                                        f_10971_59779_59859(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<file list>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59894, 59903);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 59676, 59934);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 59966, 60196);
                                        foreach (var path in f_10971_59987_60048_I(f_10971_59987_60048(this, value, baseDirectory, diagnostics)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 59966, 60196);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60114, 60165);

                                            f_10971_60114_60164(additionalFiles, f_10971_60134_60163(this, path));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 59966, 60196);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 231);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 231);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60226, 60235);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "analyzerconfig":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60315, 60573) || true) && (f_10971_60319_60352(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 60315, 60573);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60418, 60499);

                                        f_10971_60418_60498(diagnostics, ErrorCode.ERR_SwitchNeedsString, "<file list>", name);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60533, 60542);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 60315, 60573);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60605, 60697);

                                    f_10971_60605_60696(
                                                                analyzerConfigPaths, f_10971_60634_60695(this, value, baseDirectory, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60727, 60736);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "embed":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60807, 61011) || true) && (f_10971_60811_60844(value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 60807, 61011);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60910, 60937);

                                        embedAllSourceFiles = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 60971, 60980);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 60807, 61011);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61043, 61271);
                                        foreach (var path in f_10971_61064_61125_I(f_10971_61064_61125(this, value, baseDirectory, diagnostics)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 61043, 61271);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61191, 61240);

                                            f_10971_61191_61239(embeddedFiles, f_10971_61209_61238(this, path));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 61043, 61271);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 229);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 229);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61301, 61310);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);

                                case "-":
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 14550, 61939);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61377, 61877) || true) && (f_10971_61381_61406())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 61377, 61877);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61472, 61562);

                                        f_10971_61472_61561(sourceFiles, f_10971_61488_61560("-", isScript: false, isInputRedirected: true));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61596, 61624);

                                        sourceFilesSpecified = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 61377, 61877);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 61377, 61877);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61754, 61846);

                                        f_10971_61754_61845(diagnostics, ErrorCode.ERR_StdInOptionProvidedButConsoleInputIsNotRedirected);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 61377, 61877);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61907, 61916);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 14550, 61939);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 12314, 61958);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 61978, 62035);

                        f_10971_61978_62034(diagnostics, ErrorCode.ERR_BadSwitch, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 8895, 62050);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 53156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 53156);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62066, 62180);
                    foreach (var o in f_10971_62084_62096_I(warnAsErrors))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 62066, 62180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62130, 62165);

                        diagnosticOptions[o.Key] = o.Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 62066, 62180);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 115);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62282, 62391);
                    foreach (var o in f_10971_62300_62307_I(noWarns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 62282, 62391);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62341, 62376);

                        diagnosticOptions[o.Key] = o.Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 62282, 62391);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 110);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62407, 62577) || true) && (refOnly && (DynAbs.Tracing.TraceSender.Expression_True(10971, 62411, 62447) && outputRefFilePath != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 62407, 62577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62481, 62562);

                    f_10971_62481_62561(diagnostics, diagnosticOptions, ErrorCode.ERR_NoRefOutWhenRefOnly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 62407, 62577);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62593, 62820) || true) && (outputKind == OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(10971, 62597, 62673) && (refOnly || (DynAbs.Tracing.TraceSender.Expression_False(10971, 62636, 62672) || outputRefFilePath != null))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 62593, 62820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62707, 62805);

                    f_10971_62707_62804(diagnostics, diagnosticOptions, ErrorCode.ERR_NoNetModuleOutputWhenRefOutOrRefOnly);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 62593, 62820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62836, 63073) || true) && (!IsScriptCommandLineParser && (DynAbs.Tracing.TraceSender.Expression_True(10971, 62840, 62891) && !sourceFilesSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(10971, 62840, 62953) && (f_10971_62896_62920(outputKind) || (DynAbs.Tracing.TraceSender.Expression_False(10971, 62896, 62952) || !resourcesOrModulesSpecified))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 62836, 63073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 62987, 63058);

                    f_10971_62987_63057(diagnostics, diagnosticOptions, ErrorCode.WRN_NoSources);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 62836, 63073);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63089, 63312) || true) && (!noStdLib && (DynAbs.Tracing.TraceSender.Expression_True(10971, 63093, 63126) && sdkDirectory != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 63089, 63312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63160, 63297);

                    f_10971_63160_63296(metadataReferences, 0, f_10971_63189_63295(f_10971_63214_63256(sdkDirectory, "mscorlib.dll"), MetadataReferenceProperties.Assembly));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 63089, 63312);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63328, 63640) || true) && (!f_10971_63333_63357(platform))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 63328, 63640);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63391, 63625) || true) && (baseAddress > uint.MaxValue - 0x8000)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 63391, 63625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63473, 63568);

                        f_10971_63473_63567(diagnostics, ErrorCode.ERR_BadBaseNumber, f_10971_63529_63566("0x{0:X}", baseAddress));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63590, 63606);

                        baseAddress = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 63391, 63625);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 63328, 63640);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63716, 63951) || true) && (!f_10971_63721_63773(additionalReferenceDirectories))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 63716, 63951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63807, 63936);

                    f_10971_63807_63935(null, additionalReferenceDirectories, baseDirectory, libPaths, MessageID.IDS_LIB_ENV, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 63716, 63951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 63967, 64063);

                ImmutableArray<string>
                referencePaths = f_10971_64007_64062(this, sdkDirectory, libPaths, responsePaths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64079, 64179);

                f_10971_64079_64178(win32ResourceFile, win32IconFile, win32ManifestFile, outputKind, diagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64383, 64516) || true) && (!f_10971_64388_64429(baseDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 64383, 64516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64463, 64501);

                    f_10971_64463_64500(keyFileSearchPaths, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 64383, 64516);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64532, 64832) || true) && (f_10971_64536_64579(outputDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 64532, 64832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64613, 64673);

                    f_10971_64613_64672(diagnostics, ErrorCode.ERR_NoOutputDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 64532, 64832);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 64532, 64832);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64707, 64832) || true) && (baseDirectory != outputDirectory)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 64707, 64832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64777, 64817);

                        f_10971_64777_64816(keyFileSearchPaths, outputDirectory);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 64707, 64832);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 64532, 64832);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 64920, 65114) || true) && (publicSign && (DynAbs.Tracing.TraceSender.Expression_True(10971, 64924, 64981) && !f_10971_64939_64981(keyFileSetting)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 64920, 65114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65015, 65099);

                    keyFileSetting = f_10971_65032_65098(this, keyFileSetting, diagnostics, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 64920, 65114);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65130, 65277) || true) && (sourceLink != null && (DynAbs.Tracing.TraceSender.Expression_True(10971, 65134, 65164) && !emitPdb))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 65130, 65277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65198, 65262);

                    f_10971_65198_65261(diagnostics, ErrorCode.ERR_SourceLinkRequiresPdb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 65130, 65277);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65293, 65401) || true) && (embedAllSourceFiles)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 65293, 65401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65350, 65386);

                    f_10971_65350_65385(embeddedFiles, sourceFiles);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 65293, 65401);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65417, 65569) || true) && (f_10971_65421_65440(embeddedFiles) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10971, 65421, 65456) && !emitPdb))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 65417, 65569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65490, 65554);

                    f_10971_65490_65553(diagnostics, ErrorCode.ERR_CannotEmbedWithoutPdb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 65417, 65569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65585, 65630);

                var
                parsedFeatures = f_10971_65606_65629(features)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65646, 65670);

                string?
                compilationName
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65684, 65850);

                f_10971_65684_65849(this, diagnostics, outputKind, sourceFiles, sourceFilesSpecified, moduleAssemblyName, ref outputFileName, ref moduleName, out compilationName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 65866, 66316);

                var
                parseOptions = f_10971_65885_66315(languageVersion: languageVersion, preprocessorSymbols: f_10971_66012_66040(defines), documentationMode: (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 66078, 66104) || ((parseDocumentationComments && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 66107, 66133)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 66136, 66158))) ? DocumentationMode.Diagnose : DocumentationMode.None, kind: (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 66183, 66208) || ((IsScriptCommandLineParser && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 66211, 66232)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 66235, 66257))) ? SourceCodeKind.Script : SourceCodeKind.Regular, features: parsedFeatures)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 66507, 66567);

                var
                reportSuppressedDiagnostics = errorLogOptions is object
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 66583, 67727);

                var
                options = f_10971_66597_67726(outputKind: outputKind, moduleName: moduleName, mainTypeName: mainTypeName, scriptClassName: WellKnownMemberNames.DefaultScriptClassName, usings: usings, optimizationLevel: (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 66916, 66924) || ((optimize && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 66927, 66952)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 66955, 66978))) ? OptimizationLevel.Release : OptimizationLevel.Debug, checkOverflow: checkOverflow, nullableContextOptions: nullableContextOptions, allowUnsafe: allowUnsafe, deterministic: deterministic, concurrentBuild: concurrentBuild, cryptoKeyContainer: keyContainerSetting, cryptoKeyFile: keyFileSetting, delaySign: delaySignSetting, platform: platform, generalDiagnosticOption: generalDiagnosticOption, warningLevel: warningLevel, specificDiagnosticOptions: diagnosticOptions, reportSuppressedDiagnostics: reportSuppressedDiagnostics, publicSign: publicSign)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 67743, 67852) || true) && (debugPlus)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 67743, 67852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 67790, 67837);

                    options = f_10971_67800_67836(options, debugPlus);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 67743, 67852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 67868, 68825);

                var
                emitOptions = f_10971_67886_68824(metadataOnly: refOnly, includePrivateMembers: !refOnly && (DynAbs.Tracing.TraceSender.Expression_True(10971, 67997, 68034) && outputRefFilePath == null), debugInformationFormat: debugInformationFormat, pdbFilePath: null, outputNameOverride: null, baseAddress: baseAddress, highEntropyVirtualAddressSpace: highEntropyVA, fileAlignment: fileAlignment, subsystemVersion: subsystemVersion, runtimeMetadataVersion: runtimeMetadataVersion, instrumentationKinds: f_10971_68543_68584(instrumentationKinds), pdbChecksumAlgorithm: HashAlgorithmName.SHA256, defaultSourceFileEncoding: codepage)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 68898, 68935);

                f_10971_68898_68934(
                            // add option incompatibility errors if any
                            diagnostics, f_10971_68919_68933(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 68949, 68991);

                f_10971_68949_68990(diagnostics, f_10971_68970_68989(parseOptions));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 69007, 69607) || true) && (nullableContextOptions != NullableContextOptions.Disable && (DynAbs.Tracing.TraceSender.Expression_True(10971, 69011, 69163) && f_10971_69071_69099(parseOptions) < f_10971_69102_69163(MessageID.IDS_FeatureNullableReferenceTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 69007, 69607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 69197, 69592);

                    f_10971_69197_69591(diagnostics, f_10971_69213_69590(f_10971_69230_69574(ErrorCode.ERR_NullableOptionNotAvailable, "nullable", nullableContextOptions, f_10971_69379_69425(f_10971_69379_69407(parseOptions)), f_10971_69477_69573(f_10971_69511_69572(MessageID.IDS_FeatureNullableReferenceTypes))), f_10971_69576_69589()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 69007, 69607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 69623, 69654);

                pathMap = f_10971_69633_69653(pathMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 69670, 72449);

                return new CSharpCommandLineArguments
                {
                    IsScriptRunner = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => IsScriptCommandLineParser, 10971, 69677, 72448),
                    InteractiveMode = interactiveMode || (DynAbs.Tracing.TraceSender.Expression_False(10971, 69819, 69889) || IsScriptCommandLineParser && (DynAbs.Tracing.TraceSender.Expression_True(10971, 69838, 69889) && f_10971_69867_69884(sourceFiles) == 0)),
                    BaseDirectory = baseDirectory,
                    PathMap = pathMap,
                    Errors = f_10971_70001_70026(diagnostics),
                    Utf8Output = utf8output,
                    CompilationName = compilationName,
                    OutputFileName = outputFileName,
                    OutputRefFilePath = outputRefFilePath,
                    PdbPath = pdbPath,
                    EmitPdb = emitPdb && (DynAbs.Tracing.TraceSender.Expression_True(10971, 70291, 70310) && !refOnly),
                    SourceLink = sourceLink,
                    RuleSetPath = ruleSetPath,
                    OutputDirectory = outputDirectory!,
                    DocumentationPath = documentationPath,
                    GeneratedFilesOutputDirectory = generatedFilesOutputDirectory,
                    ErrorLogOptions = errorLogOptions,
                    AppConfigPath = appConfigPath,
                    SourceFiles = f_10971_70793_70818(sourceFiles),
                    Encoding = codepage,
                    ChecksumAlgorithm = checksumAlgorithm,
                    MetadataReferences = f_10971_70952_70984(metadataReferences),
                    AnalyzerReferences = f_10971_71024_71047(analyzers),
                    AnalyzerConfigPaths = f_10971_71088_71128(analyzerConfigPaths),
                    AdditionalFiles = f_10971_71165_71194(additionalFiles),
                    ReferencePaths = referencePaths,
                    SourcePaths = f_10971_71277_71302(sourcePaths),
                    KeyFileSearchPaths = f_10971_71342_71374(keyFileSearchPaths),
                    Win32ResourceFile = win32ResourceFile,
                    Win32Icon = win32IconFile,
                    Win32Manifest = win32ManifestFile,
                    NoWin32Manifest = noWin32Manifest,
                    DisplayLogo = displayLogo,
                    DisplayHelp = displayHelp,
                    DisplayVersion = displayVersion,
                    DisplayLangVersions = displayLangVersions,
                    ManifestResources = f_10971_71815_71845(managedResources),
                    CompilationOptions = options,
                    ParseOptions = parseOptions,
                    EmitOptions = emitOptions,
                    ScriptArguments = f_10971_72019_72050(scriptArgs),
                    TouchedFilesPath = touchedFilesPath,
                    PrintFullPaths = printFullPaths,
                    ShouldIncludeErrorEndLocation = errorEndLocation,
                    PreferredUILang = preferredUILang,
                    ReportAnalyzer = reportAnalyzer,
                    SkipAnalyzers = skipAnalyzers,
                    EmbeddedFiles = f_10971_72406_72433(embeddedFiles)
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 2284, 72460);

                bool
                f_10971_2508_2547(string
                path)
                {
                    var return_v = PathUtilities.IsAbsolute(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2508, 2547);
                    return return_v;
                }


                int
                f_10971_2470_2548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2470, 2548);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                f_10971_2596_2618()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2596, 2618);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_2662_2680()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2662, 2680);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_2750_2768()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2750, 2768);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_2848_2866()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2848, 2866);
                    return return_v;
                }


                int
                f_10971_2888_2975(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, System.Collections.Generic.IEnumerable<string>
                rawArguments, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.List<string>
                processedArgs, System.Collections.Generic.List<string>?
                scriptArgsOpt, string?
                baseDirectory, System.Collections.Generic.List<string>?
                responsePaths)
                {
                    this_param.FlattenArgs(rawArguments, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, processedArgs, scriptArgsOpt, baseDirectory, responsePaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 2888, 2975);
                    return 0;
                }


                bool
                f_10971_3628_3660()
                {
                    var return_v = PathUtilities.IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 3628, 3660);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.ResourceDescription>
                f_10971_5324_5355()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 5324, 5355);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_5412_5445()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 5412, 5445);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_5506_5539()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 5506, 5539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10971_5580_5614()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 5580, 5614);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_5673_5706()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 5673, 5706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10971_6016_6050()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6016, 6050);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                f_10971_6113_6145()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6113, 6145);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_10971_6207_6247()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6207, 6247);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_6286_6304()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6286, 6304);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_6346_6364()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6346, 6364);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_6413_6431()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6413, 6431);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_6468_6486()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6468, 6486);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10971_6594_6636()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6594, 6636);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10971_6665_6707()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6665, 6707);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10971_6741_6783()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 6741, 6783);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_7057_7075()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 7057, 7075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_10971_7326_7373()
                {
                    var return_v = ArrayBuilder<InstrumentationKind>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 7326, 7373);
                    return return_v;
                }


                bool
                f_10971_8105_8145(string
                arg, out string?
                name, out string?
                value)
                {
                    var return_v = TryParseOption(arg, out name, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8105, 8145);
                    return return_v;
                }


                string?
                f_10971_8233_8262(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8233, 8262);
                    return return_v;
                }


                bool
                f_10971_8295_8331(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8295, 8331);
                    return return_v;
                }


                int
                f_10971_8389_8464(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8389, 8464);
                    return 0;
                }


                string?
                f_10971_8593_8653(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8593, 8653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10971_8710_8794(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string?
                fullPath, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>?
                diagnosticOptions, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = this_param.GetDiagnosticOptionsFromRulesetFile(fullPath, out diagnosticOptions, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8710, 8794);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_8004_8017_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8004, 8017);
                    return return_v;
                }


                bool
                f_10971_8995_9040(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8995, 9040);
                    return return_v;
                }


                int
                f_10971_8965_9041(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8965, 9041);
                    return 0;
                }


                bool
                f_10971_9121_9161(string
                arg, out string?
                name, out string?
                value)
                {
                    var return_v = TryParseOption(arg, out name, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9121, 9161);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_9224_9274(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                arg, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseFileArgument(arg, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9224, 9274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_9340_9369(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.ToCommandLineSourceFile(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9340, 9369);
                    return return_v;
                }


                int
                f_10971_9324_9370(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9324, 9370);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_9224_9274_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9224, 9274);
                    return return_v;
                }


                int
                f_10971_9422_9439(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 9422, 9439);
                    return return_v;
                }


                string?
                f_10971_9992_10021(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 9992, 10021);
                    return return_v;
                }


                bool
                f_10971_10052_10085(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 10052, 10085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_10203_10232(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 10203, 10232);
                    return return_v;
                }


                int
                f_10971_10143_10250(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 10143, 10250);
                    return 0;
                }


                bool
                f_10971_10313_10360(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 10313, 10360);
                    return return_v;
                }


                int
                f_10971_10712_10799(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 10712, 10799);
                    return 0;
                }


                bool
                f_10971_11022_11079(string
                version, out Microsoft.CodeAnalysis.CSharp.LanguageVersion
                result)
                {
                    var return_v = LanguageVersionFacts.TryParse(version, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11022, 11079);
                    return return_v;
                }


                int
                f_10971_11137_11199(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11137, 11199);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                f_10971_11388_11462(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                embedInteropTypes)
                {
                    var return_v = ParseAssemblyReferences(arg, value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11388, 11462);
                    return return_v;
                }


                int
                f_10971_11360_11463(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11360, 11463);
                    return 0;
                }


                int
                f_10971_11640_11656(System.Collections.Generic.List<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11640, 11656);
                    return 0;
                }


                int
                f_10971_11771_11790(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11771, 11790);
                    return 0;
                }


                int
                f_10971_11989_12095(string
                switchName, string?
                switchValue, string?
                baseDirectory, System.Collections.Generic.List<string>
                builder, Microsoft.CodeAnalysis.CSharp.MessageID
                origin, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    ParseAndResolveReferencePaths(switchName, switchValue, baseDirectory, builder, origin, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 11989, 12095);
                    return 0;
                }


                bool
                f_10971_12214_12231()
                {
                    var return_v = Debugger.Launch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 12214, 12231);
                    return return_v;
                }


                bool
                f_10971_12646_12671()
                {
                    var return_v = Console.IsInputRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 12646, 12671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_12761_12832(string
                path, bool
                isScript, bool
                isInputRedirected)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineSourceFile(path, isScript: isScript, isInputRedirected: isInputRedirected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 12761, 12832);
                    return return_v;
                }


                int
                f_10971_12745_12833(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 12745, 12833);
                    return 0;
                }


                int
                f_10971_13046_13137(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 13046, 13137);
                    return 0;
                }


                int
                f_10971_13966_14085(string
                switchName, string?
                switchValue, string?
                baseDirectory, System.Collections.Generic.List<string>
                builder, Microsoft.CodeAnalysis.CSharp.MessageID
                origin, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    ParseAndResolveReferencePaths(switchName, switchValue, baseDirectory, builder, origin, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 13966, 14085);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_14368_14404(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParseUsings(arg, value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 14368, 14404);
                    return return_v;
                }


                int
                f_10971_14352_14405(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 14352, 14405);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_10971_14712_14751(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParseAnalyzers(arg, value, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 14712, 14751);
                    return return_v;
                }


                int
                f_10971_14693_14752(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 14693, 14752);
                    return 0;
                }


                bool
                f_10971_14903_14936(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 14903, 14936);
                    return return_v;
                }


                int
                f_10971_15002_15076(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15002, 15076);
                    return 0;
                }


                string?
                f_10971_15307_15336(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15307, 15336);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_15272_15360(string
                value, out System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParseConditionalCompilationSymbols(value, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15272, 15360);
                    return return_v;
                }


                int
                f_10971_15255_15361(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15255, 15361);
                    return 0;
                }


                int
                f_10971_15392_15431(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15392, 15431);
                    return 0;
                }


                string?
                f_10971_15553_15582(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15553, 15582);
                    return return_v;
                }


                int
                f_10971_15696_15771(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15696, 15771);
                    return 0;
                }


                System.Text.Encoding?
                f_10971_15893_15920(string
                arg)
                {
                    var return_v = TryParseEncodingName(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 15893, 15920);
                    return return_v;
                }


                int
                f_10971_16037_16097(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 16037, 16097);
                    return 0;
                }


                bool
                f_10971_16350_16383(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 16350, 16383);
                    return return_v;
                }


                int
                f_10971_16449_16524(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 16449, 16524);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_10971_16658_16690(string
                arg)
                {
                    var return_v = TryParseHashAlgorithmName(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 16658, 16690);
                    return return_v;
                }


                int
                f_10971_16839_16908(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 16839, 16908);
                    return 0;
                }


                string?
                f_10971_17731_17760(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 17731, 17760);
                    return return_v;
                }


                bool
                f_10971_17878_17893(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 17878, 17893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_18027_18056(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18027, 18056);
                    return return_v;
                }


                int
                f_10971_17967_18063(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 17967, 18063);
                    return 0;
                }


                string
                f_10971_18204_18219(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18204, 18219);
                    return return_v;
                }


                string
                f_10971_18434_18482(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18434, 18482);
                    return return_v;
                }


                int
                f_10971_18405_18483(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18405, 18483);
                    return 0;
                }


                string
                f_10971_18753_18800(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18753, 18800);
                    return return_v;
                }


                int
                f_10971_18724_18801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 18724, 18801);
                    return 0;
                }


                string
                f_10971_19072_19121(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 19072, 19121);
                    return return_v;
                }


                int
                f_10971_19043_19122(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 19043, 19122);
                    return 0;
                }


                string
                f_10971_19398_19450(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 19398, 19450);
                    return return_v;
                }


                int
                f_10971_19369_19451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 19369, 19451);
                    return 0;
                }


                int
                f_10971_19690_19763(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 19690, 19763);
                    return 0;
                }


                string?
                f_10971_20769_20798(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 20769, 20798);
                    return return_v;
                }


                bool
                f_10971_20833_20866(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 20833, 20866);
                    return return_v;
                }


                int
                f_10971_20932_21007(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 20932, 21007);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_10971_21190_21235(string
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParseInstrumentationKinds(value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 21190, 21235);
                    return return_v;
                }


                bool
                f_10971_21314_21364(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                this_param, Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 21314, 21364);
                    return return_v;
                }


                int
                f_10971_21446_21491(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                this_param, Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 21446, 21491);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_10971_21190_21235_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 21190, 21235);
                    return return_v;
                }


                int
                f_10971_22155_22233(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 22155, 22233);
                    return 0;
                }


                int
                f_10971_22537_22621(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 22537, 22621);
                    return 0;
                }


                string?
                f_10971_22816_22845(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 22816, 22845);
                    return return_v;
                }


                bool
                f_10971_22882_22915(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 22882, 22915);
                    return return_v;
                }


                int
                f_10971_22981_23055(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 22981, 23055);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_10971_23248_23270(string
                name)
                {
                    var return_v = new System.Globalization.CultureInfo(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 23248, 23270);
                    return return_v;
                }


                System.Globalization.CultureTypes
                f_10971_23310_23338(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CultureTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 23310, 23338);
                    return return_v;
                }


                int
                f_10971_23862_23920(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 23862, 23920);
                    return 0;
                }


                bool
                f_10971_24202_24240(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24202, 24240);
                    return return_v;
                }


                int
                f_10971_24306_24363(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24306, 24363);
                    return 0;
                }


                int
                f_10971_24494_24585(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory, out string?
                outputFileName, out string?
                outputDirectory)
                {
                    this_param.ParseOutputFile(value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory, out outputFileName, out outputDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24494, 24585);
                    return 0;
                }


                string?
                f_10971_24738_24767(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24738, 24767);
                    return return_v;
                }


                bool
                f_10971_24802_24835(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24802, 24835);
                    return return_v;
                }


                int
                f_10971_24901_24958(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 24901, 24958);
                    return 0;
                }


                string?
                f_10971_25109_25166(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 25109, 25166);
                    return return_v;
                }


                bool
                f_10971_25750_25783(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 25750, 25783);
                    return return_v;
                }


                int
                f_10971_25849_25904(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 25849, 25904);
                    return 0;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10971_26048_26079(string
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParseTarget(value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26048, 26079);
                    return return_v;
                }


                string
                f_10971_26260_26275(string
                arg)
                {
                    var return_v = arg.Unquote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26260, 26275);
                    return return_v;
                }


                bool
                f_10971_26319_26352(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26319, 26352);
                    return return_v;
                }


                int
                f_10971_26418_26492(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26418, 26492);
                    return 0;
                }


                bool
                f_10971_26564_26614(string
                name)
                {
                    var return_v = MetadataHelpers.IsValidAssemblyOrModuleName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26564, 26614);
                    return return_v;
                }


                int
                f_10971_26758_26834(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 26758, 26834);
                    return 0;
                }


                string?
                f_10971_27165_27194(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27165, 27194);
                    return return_v;
                }


                bool
                f_10971_27229_27269(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27229, 27269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_27395_27424(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27395, 27424);
                    return return_v;
                }


                int
                f_10971_27335_27439(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27335, 27439);
                    return 0;
                }


                string?
                f_10971_27799_27828(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27799, 27828);
                    return return_v;
                }


                bool
                f_10971_27863_27896(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27863, 27896);
                    return return_v;
                }


                int
                f_10971_27962_28038(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 27962, 28038);
                    return 0;
                }


                Microsoft.CodeAnalysis.Platform
                f_10971_28180_28213(string
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ParsePlatform(value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28180, 28213);
                    return return_v;
                }


                string?
                f_10971_28365_28394(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28365, 28394);
                    return return_v;
                }


                bool
                f_10971_28617_28650(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28617, 28650);
                    return return_v;
                }


                int
                f_10971_28716_28773(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28716, 28773);
                    return 0;
                }


                int
                f_10971_28917_28934(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 28917, 28934);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_28990_29045(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                arg, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseRecurseArgument(arg, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28990, 29045);
                    return return_v;
                }


                int
                f_10971_28969_29046(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineSourceFile>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 28969, 29046);
                    return 0;
                }


                int
                f_10971_29085_29102(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 29085, 29102);
                    return return_v;
                }


                string?
                f_10971_29409_29438(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 29409, 29438);
                    return return_v;
                }


                bool
                f_10971_29473_29505(string?
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 29473, 29505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_29631_29660(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 29631, 29660);
                    return return_v;
                }


                int
                f_10971_29571_29666(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 29571, 29666);
                    return 0;
                }


                string?
                f_10971_29829_29886(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 29829, 29886);
                    return return_v;
                }


                bool
                f_10971_30094_30127(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30094, 30127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_30253_30282(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30253, 30282);
                    return return_v;
                }


                int
                f_10971_30193_30288(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30193, 30288);
                    return 0;
                }


                string?
                f_10971_30412_30441(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30412, 30441);
                    return return_v;
                }


                bool
                f_10971_30476_30512(string
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30476, 30512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_30860_30889(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30860, 30889);
                    return return_v;
                }


                int
                f_10971_30800_30899(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 30800, 30899);
                    return 0;
                }


                string?
                f_10971_31073_31133(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 31073, 31133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_31422_31451(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 31422, 31451);
                    return return_v;
                }


                int
                f_10971_31362_31467(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 31362, 31467);
                    return 0;
                }


                bool
                f_10971_31538_31565(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 31538, 31565);
                    return return_v;
                }


                int
                f_10971_31631_31688(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 31631, 31688);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_32227_32253(string
                str)
                {
                    var return_v = ParseSeparatedPaths(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32227, 32253);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                f_10971_32227_32336(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, Microsoft.CodeAnalysis.CommandLineReference>
                selector)
                {
                    var return_v = source.Select<string, Microsoft.CodeAnalysis.CommandLineReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32227, 32336);
                    return return_v;
                }


                int
                f_10971_32199_32337(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32199, 32337);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                f_10971_32610_32683(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                embedInteropTypes)
                {
                    var return_v = ParseAssemblyReferences(arg, value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32610, 32683);
                    return return_v;
                }


                int
                f_10971_32582_32684(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineReference>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32582, 32684);
                    return 0;
                }


                string?
                f_10971_32818_32858(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = GetWin32Setting(arg, value, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32818, 32858);
                    return return_v;
                }


                string?
                f_10971_32989_33029(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = GetWin32Setting(arg, value, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 32989, 33029);
                    return return_v;
                }


                string?
                f_10971_33168_33208(string
                arg, string?
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = GetWin32Setting(arg, value, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 33168, 33208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ResourceDescription?
                f_10971_33823_33903(string
                arg, string
                resourceDescriptor, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                embedded)
                {
                    var return_v = ParseResourceDescription(arg, resourceDescriptor, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, embedded: embedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 33823, 33903);
                    return return_v;
                }


                int
                f_10971_34028_34066(System.Collections.Generic.List<Microsoft.CodeAnalysis.ResourceDescription>
                this_param, Microsoft.CodeAnalysis.ResourceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 34028, 34066);
                    return 0;
                }


                Microsoft.CodeAnalysis.ResourceDescription?
                f_10971_34537_34618(string
                arg, string
                resourceDescriptor, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, bool
                embedded)
                {
                    var return_v = ParseResourceDescription(arg, resourceDescriptor, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, embedded: embedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 34537, 34618);
                    return return_v;
                }


                int
                f_10971_34741_34777(System.Collections.Generic.List<Microsoft.CodeAnalysis.ResourceDescription>
                this_param, Microsoft.CodeAnalysis.ResourceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 34741, 34777);
                    return 0;
                }


                string?
                f_10971_35003_35032(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35003, 35032);
                    return return_v;
                }


                bool
                f_10971_35067_35100(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35067, 35100);
                    return return_v;
                }


                int
                f_10971_35166_35223(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35166, 35223);
                    return 0;
                }


                string?
                f_10971_35367_35424(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35367, 35424);
                    return return_v;
                }


                string?
                f_10971_35693_35722(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35693, 35722);
                    return return_v;
                }


                bool
                f_10971_35840_35855(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35840, 35855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_35989_36018(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35989, 36018);
                    return return_v;
                }


                int
                f_10971_35929_36025(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 35929, 36025);
                    return 0;
                }


                string
                f_10971_36150_36165(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 36150, 36165);
                    return return_v;
                }


                bool
                f_10971_36371_36403()
                {
                    var return_v = PathUtilities.IsUnixLikePlatform;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 36371, 36403);
                    return return_v;
                }


                int
                f_10971_37011_37072(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 37011, 37072);
                    return 0;
                }


                int
                f_10971_40002_40022(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40002, 40022);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.KeyCollection
                f_10971_40077_40099(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 40077, 40099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10971_40177_40199(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 40177, 40199);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.KeyCollection
                f_10971_40077_40099_I(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40077, 40099);
                    return return_v;
                }


                bool
                f_10971_40535_40562(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40535, 40562);
                    return return_v;
                }


                int
                f_10971_40628_40693(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40628, 40693);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_40874_40894(string
                value)
                {
                    var return_v = ParseWarnings(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40874, 40894);
                    return return_v;
                }


                int
                f_10971_40824_40895(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                d, Microsoft.CodeAnalysis.ReportDiagnostic
                kind, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    AddWarnings(d, kind, items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 40824, 40895);
                    return 0;
                }


                int
                f_10971_41349_41369(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41349, 41369);
                    return 0;
                }


                bool
                f_10971_41482_41509(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41482, 41509);
                    return return_v;
                }


                int
                f_10971_41575_41640(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41575, 41640);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_41790_41810(string
                value)
                {
                    var return_v = ParseWarnings(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41790, 41810);
                    return return_v;
                }


                bool
                f_10971_41956_42007(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41956, 42007);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_41790_41810_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 41790, 41810);
                    return return_v;
                }


                string?
                f_10971_42584_42613(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 42584, 42613);
                    return return_v;
                }


                int
                f_10971_42727_42792(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 42727, 42792);
                    return 0;
                }


                bool
                f_10971_42953_42980(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 42953, 42980);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10971_43060_43088()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 43060, 43088);
                    return return_v;
                }


                bool
                f_10971_43018_43110(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out int
                result)
                {
                    var return_v = int.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 43018, 43110);
                    return return_v;
                }


                int
                f_10971_43176_43241(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 43176, 43241);
                    return 0;
                }


                int
                f_10971_43397_43460(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 43397, 43460);
                    return 0;
                }


                int
                f_10971_43847_43912(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 43847, 43912);
                    return 0;
                }


                bool
                f_10971_44023_44050(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 44023, 44050);
                    return return_v;
                }


                int
                f_10971_44116_44181(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 44116, 44181);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_44360_44380(string
                value)
                {
                    var return_v = ParseWarnings(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 44360, 44380);
                    return return_v;
                }


                int
                f_10971_44312_44381(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                d, Microsoft.CodeAnalysis.ReportDiagnostic
                kind, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    AddWarnings(d, kind, items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 44312, 44381);
                    return 0;
                }


                string?
                f_10971_46259_46288(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 46259, 46288);
                    return return_v;
                }


                bool
                f_10971_46323_46350(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 46323, 46350);
                    return return_v;
                }


                int
                f_10971_46416_46479(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 46416, 46479);
                    return 0;
                }


                bool
                f_10971_47765_47792(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 47765, 47792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_47918_47947(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 47918, 47947);
                    return return_v;
                }


                int
                f_10971_47858_47964(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 47858, 47964);
                    return 0;
                }


                string?
                f_10971_49892_49921(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 49892, 49921);
                    return return_v;
                }


                bool
                f_10971_50009_50036(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50009, 50036);
                    return return_v;
                }


                bool
                f_10971_50041_50082(string
                value, out ulong
                result)
                {
                    var return_v = TryParseUInt64(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50041, 50082);
                    return return_v;
                }


                bool
                f_10971_50152_50185(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50152, 50185);
                    return return_v;
                }


                int
                f_10971_50259_50324(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50259, 50324);
                    return 0;
                }


                int
                f_10971_50471_50533(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50471, 50533);
                    return 0;
                }


                bool
                f_10971_50886_50919(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50886, 50919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_51045_51074(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 51045, 51074);
                    return return_v;
                }


                int
                f_10971_50985_51095(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 50985, 51095);
                    return 0;
                }


                int
                f_10971_51673_51745(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 51673, 51745);
                    return 0;
                }


                string?
                f_10971_51907_51936(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 51907, 51936);
                    return return_v;
                }


                bool
                f_10971_51971_52001(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 51971, 52001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_52127_52156(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 52127, 52156);
                    return return_v;
                }


                int
                f_10971_52067_52173(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 52067, 52173);
                    return 0;
                }


                int
                f_10971_52522_52560(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, string
                switchName)
                {
                    UnimplementedSwitch((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, switchName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 52522, 52560);
                    return 0;
                }


                string?
                f_10971_53097_53126(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 53097, 53126);
                    return return_v;
                }


                bool
                f_10971_53161_53191(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 53161, 53191);
                    return return_v;
                }


                int
                f_10971_53257_53332(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 53257, 53332);
                    return 0;
                }


                string?
                f_10971_53905_53934(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 53905, 53934);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_10971_54167_54202(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                pathMap, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParsePathMap(pathMap, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54167, 54202);
                    return return_v;
                }


                string?
                f_10971_54357_54386(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54357, 54386);
                    return return_v;
                }


                bool
                f_10971_54473_54506(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54473, 54506);
                    return return_v;
                }


                int
                f_10971_54572_54637(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54572, 54637);
                    return 0;
                }


                bool
                f_10971_54709_54748(string
                value, out ushort
                result)
                {
                    var return_v = TryParseUInt16(value, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54709, 54748);
                    return return_v;
                }


                int
                f_10971_54814_54883(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54814, 54883);
                    return 0;
                }


                bool
                f_10971_54955_55008(ushort
                value)
                {
                    var return_v = CompilationOptions.IsValidFileAlignment((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 54955, 55008);
                    return return_v;
                }


                int
                f_10971_55074_55143(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 55074, 55143);
                    return 0;
                }


                string?
                f_10971_55450_55479(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 55450, 55479);
                    return return_v;
                }


                bool
                f_10971_55514_55547(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 55514, 55547);
                    return return_v;
                }


                int
                f_10971_55613_55670(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 55613, 55670);
                    return 0;
                }


                string?
                f_10971_55811_55858(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                value, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParsePdbPath(value, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 55811, 55858);
                    return return_v;
                }


                string?
                f_10971_57377_57406(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 57377, 57406);
                    return return_v;
                }


                bool
                f_10971_57441_57477(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 57441, 57477);
                    return return_v;
                }


                string?
                f_10971_57625_57652(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 57625, 57652);
                    return return_v;
                }


                int
                f_10971_57543_57653(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 57543, 57653);
                    return 0;
                }


                Microsoft.CodeAnalysis.ErrorLogOptions?
                f_10971_57802_57896(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                arg, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, string?
                baseDirectory, out bool
                diagnosticAlreadyReported)
                {
                    var return_v = this_param.ParseErrorLogOptions(arg, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, baseDirectory, out diagnosticAlreadyReported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 57802, 57896);
                    return return_v;
                }


                int
                f_10971_58062_58164(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58062, 58164);
                    return 0;
                }


                string?
                f_10971_58356_58385(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58356, 58385);
                    return return_v;
                }


                bool
                f_10971_58420_58456(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58420, 58456);
                    return return_v;
                }


                string?
                f_10971_58593_58620(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58593, 58620);
                    return return_v;
                }


                int
                f_10971_58522_58621(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58522, 58621);
                    return 0;
                }


                string?
                f_10971_58768_58828(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58768, 58828);
                    return return_v;
                }


                string?
                f_10971_58998_59027(string?
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 58998, 59027);
                    return return_v;
                }


                bool
                f_10971_59062_59092(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59062, 59092);
                    return return_v;
                }


                int
                f_10971_59158_59233(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59158, 59233);
                    return 0;
                }


                bool
                f_10971_59680_59713(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59680, 59713);
                    return return_v;
                }


                int
                f_10971_59779_59859(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59779, 59859);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_59987_60048(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                value, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseSeparatedFileArgument(value, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59987, 60048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_60134_60163(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.ToCommandLineSourceFile(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60134, 60163);
                    return return_v;
                }


                int
                f_10971_60114_60164(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60114, 60164);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_59987_60048_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 59987, 60048);
                    return return_v;
                }


                bool
                f_10971_60319_60352(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60319, 60352);
                    return return_v;
                }


                int
                f_10971_60418_60498(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60418, 60498);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_60634_60695(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                value, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseSeparatedFileArgument(value, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60634, 60695);
                    return return_v;
                }


                int
                f_10971_60605_60696(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60605, 60696);
                    return 0;
                }


                bool
                f_10971_60811_60844(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 60811, 60844);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_61064_61125(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                value, string?
                baseDirectory, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors)
                {
                    var return_v = this_param.ParseSeparatedFileArgument(value, baseDirectory, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61064, 61125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_61209_61238(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.ToCommandLineSourceFile(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61209, 61238);
                    return return_v;
                }


                int
                f_10971_61191_61239(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61191, 61239);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_61064_61125_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61064, 61125);
                    return return_v;
                }


                bool
                f_10971_61381_61406()
                {
                    var return_v = Console.IsInputRedirected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 61381, 61406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_61488_61560(string
                path, bool
                isScript, bool
                isInputRedirected)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineSourceFile(path, isScript: isScript, isInputRedirected: isInputRedirected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61488, 61560);
                    return return_v;
                }


                int
                f_10971_61472_61561(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61472, 61561);
                    return 0;
                }


                int
                f_10971_61754_61845(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61754, 61845);
                    return 0;
                }


                int
                f_10971_61978_62034(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 61978, 62034);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_10971_8918_8931_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 8918, 8931);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10971_62084_62096_I(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62084, 62096);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10971_62300_62307_I(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62300, 62307);
                    return return_v;
                }


                int
                f_10971_62481_62561(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                warningOptions, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, warningOptions, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62481, 62561);
                    return 0;
                }


                int
                f_10971_62707_62804(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                warningOptions, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, warningOptions, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62707, 62804);
                    return 0;
                }


                bool
                f_10971_62896_62920(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62896, 62920);
                    return return_v;
                }


                int
                f_10971_62987_63057(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                warningOptions, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, warningOptions, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 62987, 63057);
                    return 0;
                }


                string
                f_10971_63214_63256(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63214, 63256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineReference
                f_10971_63189_63295(string
                reference, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineReference(reference, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63189, 63295);
                    return return_v;
                }


                int
                f_10971_63160_63296(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                this_param, int
                index, Microsoft.CodeAnalysis.CommandLineReference
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63160, 63296);
                    return 0;
                }


                bool
                f_10971_63333_63357(Microsoft.CodeAnalysis.Platform
                value)
                {
                    var return_v = value.Requires64Bit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63333, 63357);
                    return return_v;
                }


                string
                f_10971_63529_63566(string
                format, ulong
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63529, 63566);
                    return return_v;
                }


                int
                f_10971_63473_63567(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63473, 63567);
                    return 0;
                }


                bool
                f_10971_63721_63773(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63721, 63773);
                    return return_v;
                }


                int
                f_10971_63807_63935(string?
                switchName, string
                switchValue, string?
                baseDirectory, System.Collections.Generic.List<string>
                builder, Microsoft.CodeAnalysis.CSharp.MessageID
                origin, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    ParseAndResolveReferencePaths(switchName, switchValue, baseDirectory, builder, origin, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 63807, 63935);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_64007_64062(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string?
                sdkDirectoryOpt, System.Collections.Generic.List<string>
                libPaths, System.Collections.Generic.List<string>?
                responsePathsOpt)
                {
                    var return_v = this_param.BuildSearchPaths(sdkDirectoryOpt, libPaths, responsePathsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64007, 64062);
                    return return_v;
                }


                int
                f_10971_64079_64178(string?
                win32ResourceFile, string?
                win32IconResourceFile, string?
                win32ManifestFile, Microsoft.CodeAnalysis.OutputKind
                outputKind, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    ValidateWin32Settings(win32ResourceFile, win32IconResourceFile, win32ManifestFile, outputKind, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64079, 64178);
                    return 0;
                }


                bool
                f_10971_64388_64429(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64388, 64429);
                    return return_v;
                }


                int
                f_10971_64463_64500(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64463, 64500);
                    return 0;
                }


                bool
                f_10971_64536_64579(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64536, 64579);
                    return return_v;
                }


                int
                f_10971_64613_64672(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64613, 64672);
                    return 0;
                }


                int
                f_10971_64777_64816(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64777, 64816);
                    return 0;
                }


                bool
                f_10971_64939_64981(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 64939, 64981);
                    return return_v;
                }


                string?
                f_10971_65032_65098(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, string
                unquoted, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                errors, string?
                baseDirectory)
                {
                    var return_v = this_param.ParseGenericPathToFile(unquoted, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)errors, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65032, 65098);
                    return return_v;
                }


                int
                f_10971_65198_65261(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65198, 65261);
                    return 0;
                }


                int
                f_10971_65350_65385(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommandLineSourceFile>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65350, 65385);
                    return 0;
                }


                int
                f_10971_65421_65440(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 65421, 65440);
                    return return_v;
                }


                int
                f_10971_65490_65553(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65490, 65553);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_10971_65606_65629(System.Collections.Generic.List<string>
                features)
                {
                    var return_v = ParseFeatures(features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65606, 65629);
                    return return_v;
                }


                int
                f_10971_65684_65849(Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.OutputKind
                outputKind, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                sourceFiles, bool
                sourceFilesSpecified, string?
                moduleAssemblyName, ref string?
                outputFileName, ref string?
                moduleName, out string?
                compilationName)
                {
                    this_param.GetCompilationAndModuleNames(diagnostics, outputKind, sourceFiles, sourceFilesSpecified, moduleAssemblyName, ref outputFileName, ref moduleName, out compilationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65684, 65849);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_66012_66040(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 66012, 66040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                f_10971_65885_66315(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                languageVersion, System.Collections.Immutable.ImmutableArray<string>
                preprocessorSymbols, Microsoft.CodeAnalysis.DocumentationMode
                documentationMode, Microsoft.CodeAnalysis.SourceCodeKind
                kind, System.Collections.Immutable.ImmutableDictionary<string, string>
                features)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpParseOptions(languageVersion: languageVersion, preprocessorSymbols: preprocessorSymbols, documentationMode: documentationMode, kind: kind, features: (System.Collections.Generic.IReadOnlyDictionary<string, string>)features);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 65885, 66315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10971_66597_67726(Microsoft.CodeAnalysis.OutputKind
                outputKind, string?
                moduleName, string?
                mainTypeName, string
                scriptClassName, System.Collections.Generic.List<string>
                usings, Microsoft.CodeAnalysis.OptimizationLevel
                optimizationLevel, bool
                checkOverflow, Microsoft.CodeAnalysis.NullableContextOptions
                nullableContextOptions, bool
                allowUnsafe, bool
                deterministic, bool
                concurrentBuild, string?
                cryptoKeyContainer, string?
                cryptoKeyFile, bool?
                delaySign, Microsoft.CodeAnalysis.Platform
                platform, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, int
                warningLevel, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificDiagnosticOptions, bool
                reportSuppressedDiagnostics, bool
                publicSign)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions(outputKind: outputKind, moduleName: moduleName, mainTypeName: mainTypeName, scriptClassName: scriptClassName, usings: (System.Collections.Generic.IEnumerable<string>)usings, optimizationLevel: optimizationLevel, checkOverflow: checkOverflow, nullableContextOptions: nullableContextOptions, allowUnsafe: allowUnsafe, deterministic: deterministic, concurrentBuild: concurrentBuild, cryptoKeyContainer: cryptoKeyContainer, cryptoKeyFile: cryptoKeyFile, delaySign: delaySign, platform: platform, generalDiagnosticOption: generalDiagnosticOption, warningLevel: warningLevel, specificDiagnosticOptions: (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>)specificDiagnosticOptions, reportSuppressedDiagnostics: reportSuppressedDiagnostics, publicSign: publicSign);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 66597, 67726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10971_67800_67836(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                debugPlusMode)
                {
                    var return_v = this_param.WithDebugPlusMode(debugPlusMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 67800, 67836);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_10971_68543_68584(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 68543, 68584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_10971_67886_68824(bool
                metadataOnly, bool
                includePrivateMembers, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                debugInformationFormat, string?
                pdbFilePath, string?
                outputNameOverride, ulong
                baseAddress, bool
                highEntropyVirtualAddressSpace, int
                fileAlignment, Microsoft.CodeAnalysis.SubsystemVersion
                subsystemVersion, string?
                runtimeMetadataVersion, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds, System.Security.Cryptography.HashAlgorithmName
                pdbChecksumAlgorithm, System.Text.Encoding?
                defaultSourceFileEncoding)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions(metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers, debugInformationFormat: debugInformationFormat, pdbFilePath: pdbFilePath, outputNameOverride: outputNameOverride, baseAddress: baseAddress, highEntropyVirtualAddressSpace: highEntropyVirtualAddressSpace, fileAlignment: fileAlignment, subsystemVersion: subsystemVersion, runtimeMetadataVersion: runtimeMetadataVersion, instrumentationKinds: instrumentationKinds, pdbChecksumAlgorithm: (System.Security.Cryptography.HashAlgorithmName?)pdbChecksumAlgorithm, defaultSourceFileEncoding: defaultSourceFileEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 67886, 68824);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10971_68919_68933(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 68919, 68933);
                    return return_v;
                }


                int
                f_10971_68898_68934(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 68898, 68934);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10971_68970_68989(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.Errors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 68970, 68989);
                    return return_v;
                }


                int
                f_10971_68949_68990(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 68949, 68990);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10971_69071_69099(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 69071, 69099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10971_69102_69163(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69102, 69163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10971_69379_69407(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 69379, 69407);
                    return return_v;
                }


                string
                f_10971_69379_69425(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = version.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69379, 69425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10971_69511_69572(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69511, 69572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10971_69477_69573(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69477, 69573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10971_69230_69574(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69230, 69574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10971_69576_69589()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 69576, 69589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10971_69213_69590(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69213, 69590);
                    return return_v;
                }


                int
                f_10971_69197_69591(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69197, 69591);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_10971_69633_69653(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap)
                {
                    var return_v = SortPathMap(pathMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 69633, 69653);
                    return return_v;
                }


                int
                f_10971_69867_69884(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 69867, 69884);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10971_70001_70026(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 70001, 70026);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_70793_70818(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 70793, 70818);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineReference>
                f_10971_70952_70984(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineReference>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CommandLineReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 70952, 70984);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                f_10971_71024_71047(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CommandLineAnalyzerReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71024, 71047);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_71088_71128(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71088, 71128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_71165_71194(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71165, 71194);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_71277_71302(System.Collections.Generic.List<string>
                items)
                {
                    var return_v = items.AsImmutable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71277, 71302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_71342_71374(System.Collections.Generic.List<string>
                items)
                {
                    var return_v = items.AsImmutable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71342, 71374);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ResourceDescription>
                f_10971_71815_71845(System.Collections.Generic.List<Microsoft.CodeAnalysis.ResourceDescription>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 71815, 71845);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_72019_72050(System.Collections.Generic.List<string>?
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72019, 72050);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommandLineSourceFile>
                f_10971_72406_72433(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72406, 72433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 2284, 72460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 2284, 72460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ParseAndResolveReferencePaths(string? switchName, string? switchValue, string? baseDirectory, List<string> builder, MessageID origin, List<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 72472, 73790);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 72680, 72976) || true) && (f_10971_72684_72717(switchValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 72680, 72976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 72751, 72811);

                    f_10971_72751_72810(!f_10971_72771_72809(switchName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 72829, 72936);

                    f_10971_72829_72935(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_72889_72922(MessageID.IDS_PathList), switchName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 72954, 72961);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 72680, 72976);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 72992, 73779);
                    foreach (string path in f_10971_73016_73048_I(f_10971_73016_73048(switchValue)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 72992, 73779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73082, 73160);

                        string?
                        resolvedPath = f_10971_73105_73159(path, baseDirectory)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73178, 73764) || true) && (resolvedPath == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73178, 73764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73244, 73382);

                            f_10971_73244_73381(diagnostics, ErrorCode.WRN_InvalidSearchPathDir, path, f_10971_73313_73330(origin), f_10971_73332_73380(MessageID.IDS_DirectoryHasInvalidPath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73178, 73764);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73178, 73764);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73424, 73764) || true) && (!f_10971_73429_73459(resolvedPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73424, 73764);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73501, 73637);

                                f_10971_73501_73636(diagnostics, ErrorCode.WRN_InvalidSearchPathDir, path, f_10971_73570_73587(origin), f_10971_73589_73635(MessageID.IDS_DirectoryDoesNotExist));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73424, 73764);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73424, 73764);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73719, 73745);

                                f_10971_73719_73744(builder, resolvedPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73424, 73764);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73178, 73764);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 72992, 73779);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 788);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 72472, 73790);

                bool
                f_10971_72684_72717(string?
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72684, 72717);
                    return return_v;
                }


                bool
                f_10971_72771_72809(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72771, 72809);
                    return return_v;
                }


                int
                f_10971_72751_72810(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72751, 72810);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_72889_72922(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72889, 72922);
                    return return_v;
                }


                int
                f_10971_72829_72935(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 72829, 72935);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_73016_73048(string
                str)
                {
                    var return_v = ParseSeparatedPaths(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73016, 73048);
                    return return_v;
                }


                string?
                f_10971_73105_73159(string
                path, string?
                baseDirectory)
                {
                    var return_v = FileUtilities.ResolveRelativePath(path, baseDirectory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73105, 73159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_73313_73330(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73313, 73330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_73332_73380(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73332, 73380);
                    return return_v;
                }


                int
                f_10971_73244_73381(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73244, 73381);
                    return 0;
                }


                bool
                f_10971_73429_73459(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73429, 73459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_73570_73587(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73570, 73587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_73589_73635(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73589, 73635);
                    return return_v;
                }


                int
                f_10971_73501_73636(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73501, 73636);
                    return 0;
                }


                int
                f_10971_73719_73744(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73719, 73744);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_73016_73048_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73016, 73048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 72472, 73790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 72472, 73790);
            }
        }

        private static string? GetWin32Setting(string arg, string? value, List<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 73802, 74473);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73922, 74434) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73922, 74434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 73973, 74031);

                    f_10971_73973_74030(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73922, 74434);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 73922, 74434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74097, 74145);

                    string
                    noQuotes = f_10971_74115_74144(value)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74163, 74419) || true) && (f_10971_74167_74202(noQuotes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 74163, 74419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74244, 74302);

                        f_10971_74244_74301(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 74163, 74419);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 74163, 74419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74384, 74400);

                        return noQuotes;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 74163, 74419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 73922, 74434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74450, 74462);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 73802, 74473);

                int
                f_10971_73973_74030(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 73973, 74030);
                    return 0;
                }


                string?
                f_10971_74115_74144(string
                arg)
                {
                    var return_v = RemoveQuotesAndSlashes(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 74115, 74144);
                    return return_v;
                }


                bool
                f_10971_74167_74202(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 74167, 74202);
                    return return_v;
                }


                int
                f_10971_74244_74301(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 74244, 74301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 73802, 74473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 73802, 74473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetCompilationAndModuleNames(
                    List<Diagnostic> diagnostics,
                    OutputKind outputKind,
                    List<CommandLineSourceFile> sourceFiles,
                    bool sourceFilesSpecified,
                    string? moduleAssemblyName,
                    ref string? outputFileName,
                    ref string? moduleName,
                    out string? compilationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 74485, 77124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74886, 74905);

                string?
                simpleName
                = default(string?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 74919, 76535) || true) && (outputFileName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 74919, 76535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75242, 76152) || true) && (!IsScriptCommandLineParser && (DynAbs.Tracing.TraceSender.Expression_True(10971, 75246, 75297) && !sourceFilesSpecified))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 75242, 76152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75339, 75397);

                        f_10971_75339_75396(diagnostics, ErrorCode.ERR_OutputNeedsName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75419, 75437);

                        simpleName = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 75242, 76152);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 75242, 76152);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75479, 76152) || true) && (f_10971_75483_75509(outputKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 75479, 76152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75551, 75569);

                            simpleName = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 75479, 76152);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 75479, 76152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75651, 75756);

                            simpleName = f_10971_75664_75755(f_10971_75694_75754(f_10971_75720_75748(sourceFiles).Path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75778, 75841);

                            outputFileName = simpleName + f_10971_75808_75840(outputKind);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75865, 76133) || true) && (f_10971_75869_75886(simpleName) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10971, 75869, 75920) && !f_10971_75896_75920(outputKind)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 75865, 76133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 75970, 76049);

                                f_10971_75970_76048(diagnostics, ErrorCode.FTL_InvalidInputFileName, outputFileName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76075, 76110);

                                outputFileName = simpleName = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 75865, 76133);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 75479, 76152);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 75242, 76152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 74919, 76535);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 74919, 76535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76218, 76277);

                    simpleName = f_10971_76231_76276(outputFileName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76297, 76520) || true) && (f_10971_76301_76318(simpleName) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 76297, 76520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76365, 76444);

                        f_10971_76365_76443(diagnostics, ErrorCode.FTL_InvalidInputFileName, outputFileName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76466, 76501);

                        outputFileName = simpleName = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 76297, 76520);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 74919, 76535);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76551, 76998) || true) && (f_10971_76555_76579(outputKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 76551, 76998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76613, 76654);

                    f_10971_76613_76653(!IsScriptCommandLineParser);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76674, 76711);

                    compilationName = moduleAssemblyName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 76551, 76998);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 76551, 76998);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76777, 76934) || true) && (moduleAssemblyName != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 76777, 76934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76849, 76915);

                        f_10971_76849_76914(diagnostics, ErrorCode.ERR_AssemblyNameOnNonModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 76777, 76934);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 76954, 76983);

                    compilationName = simpleName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 76551, 76998);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77014, 77113) || true) && (moduleName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 77014, 77113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77070, 77098);

                    moduleName = outputFileName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 77014, 77113);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 74485, 77124);

                int
                f_10971_75339_75396(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75339, 75396);
                    return 0;
                }


                bool
                f_10971_75483_75509(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75483, 75509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineSourceFile
                f_10971_75720_75748(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommandLineSourceFile>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CommandLineSourceFile>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75720, 75748);
                    return return_v;
                }


                string?
                f_10971_75694_75754(string
                path)
                {
                    var return_v = PathUtilities.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75694, 75754);
                    return return_v;
                }


                string
                f_10971_75664_75755(string
                path)
                {
                    var return_v = PathUtilities.RemoveExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75664, 75755);
                    return return_v;
                }


                string
                f_10971_75808_75840(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.GetDefaultExtension();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75808, 75840);
                    return return_v;
                }


                int
                f_10971_75869_75886(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 75869, 75886);
                    return return_v;
                }


                bool
                f_10971_75896_75920(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75896, 75920);
                    return return_v;
                }


                int
                f_10971_75970_76048(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 75970, 76048);
                    return 0;
                }


                string
                f_10971_76231_76276(string
                path)
                {
                    var return_v = PathUtilities.RemoveExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 76231, 76276);
                    return return_v;
                }


                int
                f_10971_76301_76318(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 76301, 76318);
                    return return_v;
                }


                int
                f_10971_76365_76443(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 76365, 76443);
                    return 0;
                }


                bool
                f_10971_76555_76579(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 76555, 76579);
                    return return_v;
                }


                int
                f_10971_76613_76653(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 76613, 76653);
                    return 0;
                }


                int
                f_10971_76849_76914(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 76849, 76914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 74485, 77124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 74485, 77124);
            }
        }

        private ImmutableArray<string> BuildSearchPaths(string? sdkDirectoryOpt, List<string> libPaths, List<string>? responsePathsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 77136, 78240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77288, 77337);

                var
                builder = f_10971_77302_77336()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77612, 77717) || true) && (sdkDirectoryOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 77612, 77717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77673, 77702);

                    f_10971_77673_77701(builder, sdkDirectoryOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 77612, 77717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 77757, 77784);

                f_10971_77757_77783(
                            // libpath
                            builder, libPaths);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78007, 78177) || true) && (responsePathsOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 78007, 78177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78069, 78109);

                    f_10971_78069_78108(IsScriptCommandLineParser);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78127, 78162);

                    f_10971_78127_78161(builder, responsePathsOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 78007, 78177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78193, 78229);

                return f_10971_78200_78228(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 77136, 78240);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10971_77302_77336()
                {
                    var return_v = ArrayBuilder<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 77302, 77336);
                    return return_v;
                }


                int
                f_10971_77673_77701(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 77673, 77701);
                    return 0;
                }


                int
                f_10971_77757_77783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.List<string>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 77757, 77783);
                    return 0;
                }


                int
                f_10971_78069_78108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78069, 78108);
                    return 0;
                }


                int
                f_10971_78127_78161(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, System.Collections.Generic.List<string>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78127, 78161);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_78200_78228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78200, 78228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 77136, 78240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 77136, 78240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> ParseConditionalCompilationSymbols(string value, out IEnumerable<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 78252, 79552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78400, 78462);

                DiagnosticBag
                outputDiagnostics = f_10971_78434_78461()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78478, 78506);

                value = f_10971_78486_78505(value, null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78587, 78766) || true) && (!f_10971_78592_78607(value) && (DynAbs.Tracing.TraceSender.Expression_True(10971, 78591, 78672) && (f_10971_78629_78641(value) == ';' || (DynAbs.Tracing.TraceSender.Expression_False(10971, 78629, 78671) || f_10971_78652_78664(value) == ','))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 78587, 78766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78706, 78751);

                    value = f_10971_78714_78750(value, 0, f_10971_78733_78745(value) - 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 78587, 78766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78782, 78881);

                string[]
                values = f_10971_78800_78880(value, new char[] { ';', ',' })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78895, 78949);

                var
                defines = f_10971_78909_78948(f_10971_78934_78947(values))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 78965, 79429);
                    foreach (string id in f_10971_78987_78993_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 78965, 79429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79027, 79056);

                        string
                        trimmedId = f_10971_79046_79055(id)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79074, 79414) || true) && (f_10971_79078_79118(trimmedId))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79074, 79414);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79160, 79183);

                            f_10971_79160_79182(defines, trimmedId);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79074, 79414);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79074, 79414);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79265, 79395);

                            f_10971_79265_79394(outputDiagnostics, f_10971_79287_79393(CSharp.MessageProvider.Instance, ErrorCode.WRN_DefineIdentifierRequired, trimmedId));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79074, 79414);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 78965, 79429);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79445, 79497);

                diagnostics = f_10971_79459_79496(outputDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79511, 79541);

                return f_10971_79518_79540(defines);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 78252, 79552);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10971_78434_78461()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78434, 78461);
                    return return_v;
                }


                string
                f_10971_78486_78505(string
                this_param, params char[]?
                trimChars)
                {
                    var return_v = this_param.TrimEnd(trimChars);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78486, 78505);
                    return return_v;
                }


                bool
                f_10971_78592_78607(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78592, 78607);
                    return return_v;
                }


                char
                f_10971_78629_78641(string
                arg)
                {
                    var return_v = arg.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78629, 78641);
                    return return_v;
                }


                char
                f_10971_78652_78664(string
                arg)
                {
                    var return_v = arg.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78652, 78664);
                    return return_v;
                }


                int
                f_10971_78733_78745(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 78733, 78745);
                    return return_v;
                }


                string
                f_10971_78714_78750(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78714, 78750);
                    return return_v;
                }


                string[]
                f_10971_78800_78880(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78800, 78880);
                    return return_v;
                }


                int
                f_10971_78934_78947(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 78934, 78947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                f_10971_78909_78948(int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78909, 78948);
                    return return_v;
                }


                string
                f_10971_79046_79055(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79046, 79055);
                    return return_v;
                }


                bool
                f_10971_79078_79118(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79078, 79118);
                    return return_v;
                }


                int
                f_10971_79160_79182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79160, 79182);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10971_79287_79393(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79287, 79393);
                    return return_v;
                }


                int
                f_10971_79265_79394(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79265, 79394);
                    return 0;
                }


                string[]
                f_10971_78987_78993_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 78987, 78993);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10971_79459_79496(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79459, 79496);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_79518_79540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                source)
                {
                    var return_v = source.AsEnumerable<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79518, 79540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 78252, 79552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 78252, 79552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Platform ParsePlatform(string value, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 79564, 80452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79671, 80441);

                switch (f_10971_79679_79703(value))
                {

                    case "x86":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79770, 79790);

                        return Platform.X86;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "x64":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79841, 79861);

                        return Platform.X64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "itanium":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79916, 79940);

                        return Platform.Itanium;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "anycpu":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 79994, 80017);

                        return Platform.AnyCpu;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "anycpu32bitpreferred":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80085, 80122);

                        return Platform.AnyCpu32BitPreferred;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "arm":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80173, 80193);

                        return Platform.Arm;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    case "arm64":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80246, 80268);

                        return Platform.Arm64;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 79671, 80441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80316, 80381);

                        f_10971_80316_80380(diagnostics, ErrorCode.ERR_BadPlatformType, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80403, 80426);

                        return Platform.AnyCpu;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 79671, 80441);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 79564, 80452);

                string
                f_10971_79679_79703(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 79679, 79703);
                    return return_v;
                }


                int
                f_10971_80316_80380(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 80316, 80380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 79564, 80452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 79564, 80452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static OutputKind ParseTarget(string value, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 80464, 81383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80571, 81372);

                switch (f_10971_80579_80603(value))
                {

                    case "exe":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80670, 80707);

                        return OutputKind.ConsoleApplication;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    case "winexe":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80763, 80800);

                        return OutputKind.WindowsApplication;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    case "library":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80857, 80900);

                        return OutputKind.DynamicallyLinkedLibrary;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    case "module":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 80956, 80984);

                        return OutputKind.NetModule;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    case "appcontainerexe":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81049, 81093);

                        return OutputKind.WindowsRuntimeApplication;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    case "winmdobj":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81151, 81192);

                        return OutputKind.WindowsRuntimeMetadata;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 80571, 81372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81242, 81298);

                        f_10971_81242_81297(diagnostics, ErrorCode.FTL_InvalidTarget);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81320, 81357);

                        return OutputKind.ConsoleApplication;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 80571, 81372);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 80464, 81383);

                string
                f_10971_80579_80603(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 80579, 80603);
                    return return_v;
                }


                int
                f_10971_81242_81297(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic(diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81242, 81297);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 80464, 81383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 80464, 81383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> ParseUsings(string arg, string? value, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 81395, 81916);

                var listYield = new List<String>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81524, 81742) || true) && (f_10971_81528_81561(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 81524, 81742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81595, 81697);

                    f_10971_81595_81696(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_81655_81690(MessageID.IDS_Namespace1), arg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81715, 81727);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 81524, 81742);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81758, 81905);
                    foreach (var u in f_10971_81776_81841_I(f_10971_81776_81841(value, new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 81758, 81905);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 81875, 81890);

                        listYield.Add(u);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 81758, 81905);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 81395, 81916);

                return listYield;

                bool
                f_10971_81528_81561(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81528, 81561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_81655_81690(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81655, 81690);
                    return return_v;
                }


                int
                f_10971_81595_81696(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81595, 81696);
                    return 0;
                }


                string[]
                f_10971_81776_81841(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81776, 81841);
                    return return_v;
                }


                string[]
                f_10971_81776_81841_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 81776, 81841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 81395, 81916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 81395, 81916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<CommandLineAnalyzerReference> ParseAnalyzers(string arg, string? value, List<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 81928, 82730);

                var listYield = new List<CommandLineAnalyzerReference>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82081, 82450) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82081, 82450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82132, 82228);

                    f_10971_82132_82227(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_82192_82221(MessageID.IDS_Text), arg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82246, 82258);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82081, 82450);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82081, 82450);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82292, 82450) || true) && (f_10971_82296_82308(value) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82292, 82450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82347, 82405);

                        f_10971_82347_82404(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82423, 82435);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82292, 82450);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82081, 82450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82466, 82573);

                List<string>
                paths = f_10971_82487_82572(f_10971_82487_82563(f_10971_82487_82513(value), (path) => !string.IsNullOrWhiteSpace(path)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82589, 82719);
                    foreach (string path in f_10971_82613_82618_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82589, 82719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82652, 82704);

                        listYield.Add(f_10971_82665_82703(path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82589, 82719);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 81928, 82730);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_82192_82221(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82192, 82221);
                    return return_v;
                }


                int
                f_10971_82132_82227(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82132, 82227);
                    return 0;
                }


                int
                f_10971_82296_82308(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 82296, 82308);
                    return return_v;
                }


                int
                f_10971_82347_82404(System.Collections.Generic.List<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic((System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>)diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82347, 82404);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_82487_82513(string
                str)
                {
                    var return_v = ParseSeparatedPaths(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82487, 82513);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_82487_82563(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82487, 82563);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_82487_82572(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82487, 82572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineAnalyzerReference
                f_10971_82665_82703(string
                path)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineAnalyzerReference(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82665, 82703);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_82613_82618_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82613, 82618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 81928, 82730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 81928, 82730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<CommandLineReference> ParseAssemblyReferences(string arg, string? value, IList<Diagnostic> diagnostics, bool embedInteropTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 82742, 85540);

                var listYield = new List<CommandLineReference>();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82921, 83290) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82921, 83290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 82972, 83068);

                    f_10971_82972_83067(diagnostics, ErrorCode.ERR_SwitchNeedsString, f_10971_83032_83061(MessageID.IDS_Text), arg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83086, 83098);

                    return listYield;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82921, 83290);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 82921, 83290);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83132, 83290) || true) && (f_10971_83136_83148(value) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 83132, 83290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83187, 83245);

                        f_10971_83187_83244(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83263, 83275);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 83132, 83290);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 82921, 83290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83709, 83760);

                int
                eqlOrQuote = f_10971_83726_83759(value, s_quoteOrEquals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83776, 83790);

                string?
                alias
                = default(string?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83804, 84301) || true) && (eqlOrQuote >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10971, 83808, 83851) && f_10971_83827_83844(value, eqlOrQuote) == '='))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 83804, 84301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83885, 83924);

                    alias = f_10971_83893_83923(value, 0, eqlOrQuote);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 83942, 83982);

                    value = f_10971_83950_83981(value, eqlOrQuote + 1);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84002, 84207) || true) && (!f_10971_84007_84043(alias))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 84002, 84207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84085, 84154);

                        f_10971_84085_84153(diagnostics, ErrorCode.ERR_BadExternIdentifier, alias);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84176, 84188);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 84002, 84207);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 83804, 84301);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 83804, 84301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84273, 84286);

                    alias = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 83804, 84301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84317, 84424);

                List<string>
                paths = f_10971_84338_84423(f_10971_84338_84414(f_10971_84338_84364(value), (path) => !string.IsNullOrWhiteSpace(path)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84438, 84889) || true) && (alias != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 84438, 84889);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84489, 84673) || true) && (f_10971_84493_84504(paths) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 84489, 84673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84550, 84620);

                        f_10971_84550_84619(diagnostics, ErrorCode.ERR_OneAliasPerReference, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84642, 84654);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 84489, 84673);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84693, 84874) || true) && (f_10971_84697_84708(paths) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 84693, 84874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84755, 84821);

                        f_10971_84755_84820(diagnostics, ErrorCode.ERR_AliasMissingFile, alias);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84843, 84855);

                        return listYield;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 84693, 84874);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 84438, 84889);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 84905, 85529);
                    foreach (string path in f_10971_84929_84934_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 84905, 85529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85223, 85315);

                        var
                        aliases = (DynAbs.Tracing.TraceSender.Conditional_F1(10971, 85237, 85252) || (((alias != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10971, 85255, 85283)) || DynAbs.Tracing.TraceSender.Conditional_F3(10971, 85286, 85314))) ? f_10971_85255_85283(alias) : ImmutableArray<string>.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85335, 85440);

                        var
                        properties = f_10971_85352_85439(MetadataImageKind.Assembly, aliases, embedInteropTypes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85458, 85514);

                        listYield.Add(f_10971_85471_85513(path, properties));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 84905, 85529);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 625);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 82742, 85540);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10971_83032_83061(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 83032, 83061);
                    return return_v;
                }


                int
                f_10971_82972_83067(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 82972, 83067);
                    return 0;
                }


                int
                f_10971_83136_83148(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 83136, 83148);
                    return return_v;
                }


                int
                f_10971_83187_83244(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 83187, 83244);
                    return 0;
                }


                int
                f_10971_83726_83759(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 83726, 83759);
                    return return_v;
                }


                char
                f_10971_83827_83844(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 83827, 83844);
                    return return_v;
                }


                string
                f_10971_83893_83923(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 83893, 83923);
                    return return_v;
                }


                string
                f_10971_83950_83981(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 83950, 83981);
                    return return_v;
                }


                bool
                f_10971_84007_84043(string
                name)
                {
                    var return_v = SyntaxFacts.IsValidIdentifier(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84007, 84043);
                    return return_v;
                }


                int
                f_10971_84085_84153(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84085, 84153);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_84338_84364(string
                str)
                {
                    var return_v = ParseSeparatedPaths(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84338, 84364);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_84338_84414(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, bool>
                predicate)
                {
                    var return_v = source.Where<string>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84338, 84414);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_84338_84423(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84338, 84423);
                    return return_v;
                }


                int
                f_10971_84493_84504(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 84493, 84504);
                    return return_v;
                }


                int
                f_10971_84550_84619(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84550, 84619);
                    return 0;
                }


                int
                f_10971_84697_84708(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 84697, 84708);
                    return return_v;
                }


                int
                f_10971_84755_84820(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84755, 84820);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10971_85255_85283(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 85255, 85283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_10971_85352_85439(Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind, aliases, embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 85352, 85439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommandLineReference
                f_10971_85471_85513(string
                reference, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommandLineReference(reference, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 85471, 85513);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_10971_84929_84934_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 84929, 84934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 82742, 85540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 82742, 85540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ValidateWin32Settings(string? win32ResourceFile, string? win32IconResourceFile, string? win32ManifestFile, OutputKind outputKind, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 85552, 86376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85757, 86175) || true) && (win32ResourceFile != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 85757, 86175);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85820, 85980) || true) && (win32IconResourceFile != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 85820, 85980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 85895, 85961);

                        f_10971_85895_85960(diagnostics, ErrorCode.ERR_CantHaveWin32ResAndIcon);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 85820, 85980);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86000, 86160) || true) && (win32ManifestFile != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 86000, 86160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86071, 86141);

                        f_10971_86071_86140(diagnostics, ErrorCode.ERR_CantHaveWin32ResAndManifest);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 86000, 86160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 85757, 86175);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86191, 86365) || true) && (f_10971_86195_86219(outputKind) && (DynAbs.Tracing.TraceSender.Expression_True(10971, 86195, 86248) && win32ManifestFile != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 86191, 86365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86282, 86350);

                    f_10971_86282_86349(diagnostics, ErrorCode.WRN_CantHaveManifestForModule);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 86191, 86365);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 85552, 86376);

                int
                f_10971_85895_85960(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic(diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 85895, 85960);
                    return 0;
                }


                int
                f_10971_86071_86140(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic(diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86071, 86140);
                    return 0;
                }


                bool
                f_10971_86195_86219(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86195, 86219);
                    return return_v;
                }


                int
                f_10971_86282_86349(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    AddDiagnostic(diagnostics, errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86282, 86349);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 85552, 86376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 85552, 86376);
            }
        }

        private static IEnumerable<InstrumentationKind> ParseInstrumentationKinds(string value, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 86388, 87086);

                var listYield = new List<InstrumentationKind>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86531, 86614);

                string[]
                kinds = f_10971_86548_86613(value, new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86628, 87075);
                    foreach (var kind in f_10971_86649_86654_I(kinds))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 86628, 87075);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86688, 87060);

                        switch (f_10971_86696_86710(kind))
                        {

                            case "testcoverage":
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 86688, 87060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86798, 86844);

                                listYield.Add(InstrumentationKind.TestCoverage);
                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 86870, 86876);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 86688, 87060);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 86688, 87060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 86934, 87009);

                                f_10971_86934_87008(diagnostics, ErrorCode.ERR_InvalidInstrumentationKind, kind);
                                DynAbs.Tracing.TraceSender.TraceBreak(10971, 87035, 87041);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 86688, 87060);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 86628, 87075);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 448);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 86388, 87086);

                return listYield;

                string[]
                f_10971_86548_86613(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86548, 86613);
                    return return_v;
                }


                string
                f_10971_86696_86710(string
                this_param)
                {
                    var return_v = this_param.ToLower();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86696, 86710);
                    return return_v;
                }


                int
                f_10971_86934_87008(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86934, 87008);
                    return 0;
                }


                string[]
                f_10971_86649_86654_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 86649, 86654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 86388, 87086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 86388, 87086);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ResourceDescription? ParseResourceDescription(
                    string arg,
                    string resourceDescriptor,
                    string? baseDirectory,
                    IList<Diagnostic> diagnostics,
                    bool embedded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 87098, 89763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87358, 87375);

                string?
                filePath
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87389, 87406);

                string?
                fullPath
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87420, 87437);

                string?
                fileName
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87451, 87472);

                string?
                resourceName
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87486, 87508);

                string?
                accessibility
                = default(string?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87524, 87807);

                f_10971_87524_87806(resourceDescriptor, baseDirectory, false, out filePath, out fullPath, out fileName, out resourceName, out accessibility);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87823, 87837);

                bool
                isPublic
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 87851, 88595) || true) && (accessibility == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 87851, 88595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88070, 88086);

                    isPublic = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 87851, 88595);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 87851, 88595);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88120, 88595) || true) && (f_10971_88124_88198(accessibility, "public", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88120, 88595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88232, 88248);

                        isPublic = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88120, 88595);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88120, 88595);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88282, 88595) || true) && (f_10971_88286_88361(accessibility, "private", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88282, 88595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88395, 88412);

                            isPublic = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88282, 88595);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88282, 88595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88478, 88550);

                            f_10971_88478_88549(diagnostics, ErrorCode.ERR_BadResourceVis, accessibility);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88568, 88580);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88282, 88595);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88120, 88595);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 87851, 88595);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88611, 88793) || true) && (f_10971_88615_88656(filePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88611, 88793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88690, 88748);

                    f_10971_88690_88747(diagnostics, ErrorCode.ERR_NoFileSpec, arg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88766, 88778);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88611, 88793);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88807, 88845);

                f_10971_88807_88844(!f_10971_88821_88843(resourceName));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88913, 89109) || true) && (!f_10971_88918_88957(fullPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 88913, 89109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 88991, 89064);

                    f_10971_88991_89063(diagnostics, ErrorCode.FTL_InvalidInputFileName, filePath);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 89082, 89094);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 88913, 89109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 89125, 89631);

                Func<Stream>
                dataProvider = () =>
                                                            {
                                                // Use FileShare.ReadWrite because the file could be opened by the current process.
                                                // For example, it is an XML doc file produced by the build.
                                                return new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                                                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 89645, 89752);

                return f_10971_89652_89751(resourceName, fileName, dataProvider, isPublic, embedded, checkArgs: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 87098, 89763);

                int
                f_10971_87524_87806(string
                resourceDescriptor, string?
                baseDirectory, bool
                skipLeadingSeparators, out string?
                filePath, out string?
                fullPath, out string?
                fileName, out string?
                resourceName, out string?
                accessibility)
                {
                    ParseResourceDescription(resourceDescriptor, baseDirectory, skipLeadingSeparators, out filePath, out fullPath, out fileName, out resourceName, out accessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 87524, 87806);
                    return 0;
                }


                bool
                f_10971_88124_88198(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88124, 88198);
                    return return_v;
                }


                bool
                f_10971_88286_88361(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88286, 88361);
                    return return_v;
                }


                int
                f_10971_88478_88549(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88478, 88549);
                    return 0;
                }


                bool
                f_10971_88615_88656(string?
                value)
                {
                    var return_v = RoslynString.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88615, 88656);
                    return return_v;
                }


                int
                f_10971_88690_88747(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88690, 88747);
                    return 0;
                }


                bool
                f_10971_88821_88843(string
                source)
                {
                    var return_v = source.IsEmpty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88821, 88843);
                    return return_v;
                }


                int
                f_10971_88807_88844(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88807, 88844);
                    return 0;
                }


                bool
                f_10971_88918_88957(string?
                fullPath)
                {
                    var return_v = PathUtilities.IsValidFilePath(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88918, 88957);
                    return return_v;
                }


                int
                f_10971_88991_89063(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 88991, 89063);
                    return 0;
                }


                Microsoft.CodeAnalysis.ResourceDescription
                f_10971_89652_89751(string
                resourceName, string?
                fileName, System.Func<System.IO.Stream>
                dataProvider, bool
                isPublic, bool
                isEmbedded, bool
                checkArgs)
                {
                    var return_v = new Microsoft.CodeAnalysis.ResourceDescription(resourceName, fileName, dataProvider, isPublic, isEmbedded, checkArgs: checkArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 89652, 89751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 87098, 89763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 87098, 89763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<string> ParseWarnings(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 89775, 91527);
                ushort number = default(ushort);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 89862, 89886);

                value = f_10971_89870_89885(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 89900, 89999);

                string[]
                values = f_10971_89918_89998(value, new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90013, 91516);
                    foreach (string id in f_10971_90035_90041_I(values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90013, 91516);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90075, 91501) || true) && (f_10971_90079_90144(id, "nullable", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90075, 91501);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90186, 90335);
                                foreach (var errorCode in f_10971_90212_90239_I(ErrorFacts.NullableWarnings))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90186, 90335);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90289, 90312);

                                    listYield.Add(errorCode);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90186, 90335);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 150);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 150);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90359, 90482);

                            listYield.Add(f_10971_90372_90481(CSharp.MessageProvider.Instance, ErrorCode.WRN_MissingNonNullTypesContextForAnnotation));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90504, 90642);

                            listYield.Add(f_10971_90517_90641(CSharp.MessageProvider.Instance, ErrorCode.WRN_MissingNonNullTypesContextForAnnotationInGeneratedCode));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90075, 91501);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90075, 91501);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90684, 91501) || true) && (f_10971_90688_90778(id, NumberStyles.Integer, f_10971_90730_90758(), out number) && (DynAbs.Tracing.TraceSender.Expression_True(10971, 90688, 90845) && f_10971_90806_90845(number)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90684, 91501);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 90948, 91019);

                                listYield.Add(f_10971_90961_91018(CSharp.MessageProvider.Instance, number));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90684, 91501);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 90684, 91501);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 91466, 91482);

                                listYield.Add(id);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90684, 91501);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90075, 91501);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 90013, 91516);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 1504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 1504);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 89775, 91527);

                return listYield;

                string
                f_10971_89870_89885(string
                arg)
                {
                    var return_v = arg.Unquote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 89870, 89885);
                    return return_v;
                }


                string[]
                f_10971_89918_89998(string
                this_param, char[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 89918, 89998);
                    return return_v;
                }


                bool
                f_10971_90079_90144(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90079, 90144);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<string>
                f_10971_90212_90239_I(System.Collections.Immutable.ImmutableHashSet<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90212, 90239);
                    return return_v;
                }


                string
                f_10971_90372_90481(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90372, 90481);
                    return return_v;
                }


                string
                f_10971_90517_90641(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90517, 90641);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_10971_90730_90758()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10971, 90730, 90758);
                    return return_v;
                }


                bool
                f_10971_90688_90778(string
                s, System.Globalization.NumberStyles
                style, System.Globalization.CultureInfo
                provider, out ushort
                result)
                {
                    var return_v = ushort.TryParse(s, style, (System.IFormatProvider)provider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90688, 90778);
                    return return_v;
                }


                bool
                f_10971_90806_90845(ushort
                code)
                {
                    var return_v = ErrorFacts.IsWarning((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90806, 90845);
                    return return_v;
                }


                string
                f_10971_90961_91018(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, ushort
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90961, 91018);
                    return return_v;
                }


                string[]
                f_10971_90035_90041_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 90035, 90041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 89775, 91527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 89775, 91527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddWarnings(Dictionary<string, ReportDiagnostic> d, ReportDiagnostic kind, IEnumerable<string> items)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 91539, 92185);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 91685, 92174);
                    foreach (var id in f_10971_91704_91709_I(items))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 91685, 92174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 91743, 91769);

                        ReportDiagnostic
                        existing
                        = default(ReportDiagnostic);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 91787, 92159) || true) && (f_10971_91791_91822(d, id, out existing))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 91787, 92159);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 91961, 92042) || true) && (existing != ReportDiagnostic.Suppress)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 91961, 92042);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 92029, 92042);

                                d[id] = kind;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 91961, 92042);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 91787, 92159);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 91787, 92159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 92124, 92140);

                            f_10971_92124_92139(d, id, kind);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 91787, 92159);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 91685, 92174);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10971, 1, 490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10971, 1, 490);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 91539, 92185);

                bool
                f_10971_91791_91822(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 91791, 91822);
                    return return_v;
                }


                int
                f_10971_92124_92139(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92124, 92139);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_10971_91704_91709_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 91704, 91709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 91539, 92185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 91539, 92185);
            }
        }

        private static void UnimplementedSwitch(IList<Diagnostic> diagnostics, string switchName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 92197, 92413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 92311, 92402);

                f_10971_92311_92401(diagnostics, ErrorCode.WRN_UnimplementedCommandLineSwitch, "/" + switchName);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 92197, 92413);

                int
                f_10971_92311_92401(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92311, 92401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 92197, 92413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 92197, 92413);
            }
        }

        internal override void GenerateErrorForNoFilesFoundInRecurse(string path, IList<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10971, 92425, 92588);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10971, 92425, 92588);
                //  no error in csc.exe
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 92425, 92588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 92425, 92588);
            }
        }

        private static void AddDiagnostic(IList<Diagnostic> diagnostics, ErrorCode errorCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 92600, 92805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 92710, 92794);

                f_10971_92710_92793(diagnostics, f_10971_92726_92792(CSharp.MessageProvider.Instance, errorCode));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 92600, 92805);

                Microsoft.CodeAnalysis.Diagnostic
                f_10971_92726_92792(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92726, 92792);
                    return return_v;
                }


                int
                f_10971_92710_92793(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92710, 92793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 92600, 92805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 92600, 92805);
            }
        }

        private static void AddDiagnostic(IList<Diagnostic> diagnostics, ErrorCode errorCode, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 92817, 93060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 92954, 93049);

                f_10971_92954_93048(diagnostics, f_10971_92970_93047(CSharp.MessageProvider.Instance, errorCode, arguments));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 92817, 93060);

                Microsoft.CodeAnalysis.Diagnostic
                f_10971_92970_93047(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92970, 93047);
                    return return_v;
                }


                int
                f_10971_92954_93048(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 92954, 93048);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 92817, 93060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 92817, 93060);
            }
        }

        private static void AddDiagnostic(IList<Diagnostic> diagnostics, Dictionary<string, ReportDiagnostic> warningOptions, ErrorCode errorCode, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10971, 93236, 93759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 93426, 93452);

                int
                code = (int)errorCode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 93466, 93489);

                ReportDiagnostic
                value
                = default(ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 93503, 93598);

                f_10971_93503_93597(warningOptions, f_10971_93530_93585(CSharp.MessageProvider.Instance, code), out value);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 93612, 93748) || true) && (value != ReportDiagnostic.Suppress)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10971, 93612, 93748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 93684, 93733);

                    f_10971_93684_93732(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10971, 93612, 93748);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10971, 93236, 93759);

                string
                f_10971_93530_93585(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, int
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 93530, 93585);
                    return return_v;
                }


                bool
                f_10971_93503_93597(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 93503, 93597);
                    return return_v;
                }


                int
                f_10971_93684_93732(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, params object[]
                arguments)
                {
                    AddDiagnostic(diagnostics, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 93684, 93732);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10971, 93236, 93759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 93236, 93759);
            }
        }

        static CSharpCommandLineParser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10971, 638, 93766);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 711, 798);
            Default = f_10971_768_797(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 808, 925);
            Script = f_10971_864_924(isScriptCommandLineParser: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10971, 968, 1004);
            s_quoteOrEquals = new[] { '"', '=' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10971, 638, 93766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10971, 638, 93766);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10971, 638, 93766);

        static Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
        f_10971_768_797()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 768, 797);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser
        f_10971_864_924(bool
        isScriptCommandLineParser)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCommandLineParser(isScriptCommandLineParser: isScriptCommandLineParser);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10971, 864, 924);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10971_1110_1141_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10971, 1017, 1191);
            return return_v;
        }

    }
}
